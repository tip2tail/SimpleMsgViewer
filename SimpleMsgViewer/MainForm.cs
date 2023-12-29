using Microsoft.Web.WebView2.Core;
using MsgReader.Outlook;
using System.Buffers.Text;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Text;

namespace SimpleMsgViewer
{
    public partial class MainForm : Form
    {
        internal string fileToOpen;
        private bool populatingAttachments;
        private NameValueCollection rawHeaders;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dlgOpen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = dlgOpen.FileName;
                OpenFile();
            }
        }

        private void OpenFile()
        {
            try
            {
                webView.NavigateToString("<h1>Loading document...</h1>");
                EncodingProvider encProvider = CodePagesEncodingProvider.Instance;
                Encoding.RegisterProvider(encProvider);
                var message = new Storage.Message(txtFile.Text);
                txtSubject.Text = message.Subject;
                if (message.Headers != null)
                {
                    rawHeaders = message.Headers.RawHeaders;
                    txtHeaders.Text = ConvertHeadersToText();
                }
                else
                {
                    txtHeaders.Text = "Unable to load headers - null value";
                }
                txtBodyText.Text = message.BodyText;

                ClearAttachmentDetails();
                UpdateAttachments(message);

                if (string.IsNullOrEmpty(message.BodyHtml))
                {
                    webView.NavigateToString("<h1>No HTML Content - see Plain Text</h1>");
                    tabDocument.SelectedTab = tabPlain;
                }
                else
                {
                    webView.NavigateToString(GetHtmlWithImages(message));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open file: " + ex.Message + Environment.NewLine + Environment.NewLine + ex.StackTrace, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAttachments(Storage.Message message)
        {
            populatingAttachments = true;
            lstAttachments.Items.Clear();
            foreach (Storage.Attachment attachment in message.Attachments)
            {
                if (attachment.Hidden)
                {
                    continue;
                }
                var item = new ListAttachment()
                {
                    attachment = attachment,
                };
                lstAttachments.Items.Add(item);
            }
            tabAttachments.Text = $"Attachments ({lstAttachments.Items.Count})";
            populatingAttachments = false;
        }

        private string GetHtmlWithImages(Storage.Message message)
        {
            if (message.Attachments.Count == 0)
            {
                return message.BodyHtml;
            }
            var hasHidden = false;
            foreach (Storage.Attachment attachment in message.Attachments)
            {
                if (attachment.Hidden)
                {
                    hasHidden = true;
                    break;
                }
            }
            if (!hasHidden)
            {
                return message.BodyHtml;
            }

            // OK so we have some hidden attachments we will convert to Base64 and embed
            var html = message.BodyHtml;

            foreach (Storage.Attachment attachment in message.Attachments)
            {
                if (!attachment.Hidden)
                {
                    continue;
                }
                var contentId = $"cid:{attachment.ContentId}";
                var mime = attachment.MimeType;
                var base64 = Convert.ToBase64String(attachment.Data);
                var replacement = $"data:{mime};base64, {base64}";
                html = html.Replace(contentId, replacement);
            }

            return html;
        }

        private string ConvertHeadersToText()
        {
            var outText = string.Empty;
            foreach (var key in rawHeaders.AllKeys)
            {
                outText += $"{key}: {rawHeaders[key]}{Environment.NewLine}";
                if (cbBlankLine.Checked)
                {
                    outText += Environment.NewLine;
                }
            }
            return outText;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            // Init the web browser...
            webView.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;
            Debug.WriteLine("before InitializeAsync");
            await InitializeAsync();
            Debug.WriteLine("after InitializeAsync");
            if (!string.IsNullOrEmpty(fileToOpen))
            {
                txtFile.Text = fileToOpen;
                fileToOpen = string.Empty;
                OpenFile();
            }
        }

        private async Task InitializeAsync()
        {
            Debug.WriteLine("InitializeAsync");
            await webView.EnsureCoreWebView2Async(null);
            Debug.WriteLine("WebView2 Runtime version: " + webView.CoreWebView2.Environment.BrowserVersionString);

            if ((webView == null) || (webView.CoreWebView2 == null))
            {
                Debug.WriteLine("not ready");
                return;
            }

            webView.NavigateToString("<h1>Open document above...</h1>");
            Debug.WriteLine("after NavigateToString");
            panelLoading.Hide();
        }

        private void WebView_CoreWebView2InitializationCompleted(object? sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            Debug.WriteLine("WebView_CoreWebView2InitializationCompleted");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Msg Viewer\n - by Mark Young.\n\nLicensed under the MIT License.\n\n" +
                "github.com/tip2tail\n\nVersion 1.1.0\n29 December 2023", "About this application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lstAttachments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (populatingAttachments)
            {
                ClearAttachmentDetails();
                return;
            }
            if (lstAttachments.SelectedItem == null)
            {
                ClearAttachmentDetails();
                return;
            }
            ListAttachment item = (ListAttachment)lstAttachments.SelectedItem;
            txtAttName.Tag = item.attachment;
            txtAttName.Text = item.attachment.FileName;
            txtAttMime.Text = item.attachment.MimeType;
            txtAttBytes.Text = item.attachment.Data.LongLength.ToString("n0");
            txtAttCreated.Text = item.attachment.CreationTime.HasValue ?
                $"{item.attachment.CreationTime.Value.ToLongDateString()} {item.attachment.CreationTime.Value.ToLongTimeString()}" :
                "Unknown";
            txtAttModified.Text = item.attachment.LastModificationTime.HasValue ?
                $"{item.attachment.LastModificationTime.Value.ToLongDateString()} {item.attachment.LastModificationTime.Value.ToLongTimeString()}" :
                "Unknown";
        }

        private void ClearAttachmentDetails()
        {
            txtAttName.Text = string.Empty;
            txtAttMime.Text = string.Empty;
            txtAttBytes.Text = string.Empty;
            txtAttCreated.Text = string.Empty;
            txtAttModified.Text = string.Empty;
            txtAttName.Tag = null;
        }

        private void btnAttSave_Click(object sender, EventArgs e)
        {
            if (txtAttName.Tag == null)
            {
                MessageBox.Show("No attachment has been loaded.  Click an attachment (if one is available) from the list on the left.", "No Attachment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dlgSave.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dlgSave.FileName = txtAttName.Text;
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                var attachment = (Storage.Attachment)txtAttName.Tag;
                File.WriteAllBytes(dlgSave.FileName, attachment.Data);
                ExploreFile(dlgSave.FileName);
            }
        }

        private bool ExploreFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }
            // Clean up file path so it can be navigated OK
            filePath = Path.GetFullPath(filePath);
            Process.Start("explorer.exe", string.Format("/select,\"{0}\"", filePath));
            return true;
        }

        private void cbHeaderWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            txtHeaders.WordWrap = cbHeaderWordWrap.Checked;
        }

        private void cbBlankLine_CheckedChanged(object sender, EventArgs e)
        {
            txtHeaders.Text = ConvertHeadersToText();
        }
    }
}
