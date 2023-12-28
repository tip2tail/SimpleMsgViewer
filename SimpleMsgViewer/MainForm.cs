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
                    txtHeaders.Text = ConvertHeadersToText(message.Headers.RawHeaders);
                }
                else
                {
                    txtHeaders.Text = "Unable to load headers - null value";
                }
                txtBodyText.Text = message.BodyText;
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

            foreach(Storage.Attachment attachment in message.Attachments)
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

        private string ConvertHeadersToText(NameValueCollection rawHeaders)
        {
            var outText = string.Empty;
            foreach (var key in rawHeaders.AllKeys)
            {
                outText += $"{key}: {rawHeaders[key]}{Environment.NewLine}";
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
        }

        private void WebView_CoreWebView2InitializationCompleted(object? sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            Debug.WriteLine("WebView_CoreWebView2InitializationCompleted");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Msg Viewer\n - by Mark Young.\n\nLicensed under the MIT License.\n\n" +
                "github.com/tip2tail\n\nVersion 1.0.0\n28 December 2023", "About this application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fileToOpen))
            {
                txtFile.Text = fileToOpen;
                fileToOpen = string.Empty;
                OpenFile();
            }
        }
    }
}
