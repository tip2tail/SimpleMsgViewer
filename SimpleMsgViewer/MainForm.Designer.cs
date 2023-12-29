namespace SimpleMsgViewer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSubject = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnAbout = new Button();
            btnOpen = new Button();
            txtFile = new TextBox();
            dlgOpen = new OpenFileDialog();
            tabDocument = new TabControl();
            tabHTML = new TabPage();
            panelLoading = new Panel();
            labLoading = new Label();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabPlain = new TabPage();
            txtBodyText = new TextBox();
            tabAttachments = new TabPage();
            groupBox2 = new GroupBox();
            btnAttSave = new Button();
            txtAttModified = new TextBox();
            label5 = new Label();
            txtAttCreated = new TextBox();
            label6 = new Label();
            txtAttBytes = new TextBox();
            label4 = new Label();
            txtAttMime = new TextBox();
            label3 = new Label();
            txtAttName = new TextBox();
            label2 = new Label();
            lstAttachments = new ListBox();
            tabHeader = new TabPage();
            cbBlankLine = new CheckBox();
            cbHeaderWordWrap = new CheckBox();
            txtHeaders = new TextBox();
            dlgSave = new SaveFileDialog();
            groupBox1.SuspendLayout();
            tabDocument.SuspendLayout();
            tabHTML.SuspendLayout();
            panelLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            tabPlain.SuspendLayout();
            tabAttachments.SuspendLayout();
            groupBox2.SuspendLayout();
            tabHeader.SuspendLayout();
            SuspendLayout();
            // 
            // txtSubject
            // 
            txtSubject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSubject.Font = new Font("Consolas", 9F);
            txtSubject.Location = new Point(67, 78);
            txtSubject.Name = "txtSubject";
            txtSubject.ReadOnly = true;
            txtSubject.Size = new Size(1026, 22);
            txtSubject.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Subject:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnAbout);
            groupBox1.Controls.Add(btnOpen);
            groupBox1.Controls.Add(txtFile);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1081, 60);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "  Outlook Mail File  ";
            // 
            // btnAbout
            // 
            btnAbout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAbout.Location = new Point(1000, 22);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(75, 23);
            btnAbout.TabIndex = 2;
            btnAbout.Text = "About...";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnOpen
            // 
            btnOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpen.Location = new Point(919, 22);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open...";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // txtFile
            // 
            txtFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFile.Location = new Point(16, 22);
            txtFile.Name = "txtFile";
            txtFile.ReadOnly = true;
            txtFile.Size = new Size(897, 23);
            txtFile.TabIndex = 0;
            // 
            // dlgOpen
            // 
            dlgOpen.Filter = "Outlook Mail Files (*.msg)|*.msg";
            dlgOpen.Title = "Open Mail File";
            // 
            // tabDocument
            // 
            tabDocument.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabDocument.Controls.Add(tabHTML);
            tabDocument.Controls.Add(tabPlain);
            tabDocument.Controls.Add(tabAttachments);
            tabDocument.Controls.Add(tabHeader);
            tabDocument.Location = new Point(12, 106);
            tabDocument.Name = "tabDocument";
            tabDocument.SelectedIndex = 0;
            tabDocument.Size = new Size(1081, 537);
            tabDocument.TabIndex = 4;
            // 
            // tabHTML
            // 
            tabHTML.Controls.Add(panelLoading);
            tabHTML.Controls.Add(webView);
            tabHTML.Location = new Point(4, 24);
            tabHTML.Name = "tabHTML";
            tabHTML.Size = new Size(1073, 557);
            tabHTML.TabIndex = 2;
            tabHTML.Text = "HTML";
            tabHTML.UseVisualStyleBackColor = true;
            // 
            // panelLoading
            // 
            panelLoading.Controls.Add(labLoading);
            panelLoading.Location = new Point(3, 3);
            panelLoading.Name = "panelLoading";
            panelLoading.Size = new Size(1067, 551);
            panelLoading.TabIndex = 5;
            // 
            // labLoading
            // 
            labLoading.AutoSize = true;
            labLoading.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labLoading.Location = new Point(300, 260);
            labLoading.Name = "labLoading";
            labLoading.Size = new Size(467, 30);
            labLoading.TabIndex = 0;
            labLoading.Text = "Application is loading WebView2 - please wait...";
            // 
            // webView
            // 
            webView.AllowExternalDrop = false;
            webView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(3, 3);
            webView.Name = "webView";
            webView.Size = new Size(1067, 551);
            webView.TabIndex = 0;
            webView.ZoomFactor = 1D;
            // 
            // tabPlain
            // 
            tabPlain.Controls.Add(txtBodyText);
            tabPlain.Location = new Point(4, 24);
            tabPlain.Name = "tabPlain";
            tabPlain.Padding = new Padding(3);
            tabPlain.Size = new Size(1073, 557);
            tabPlain.TabIndex = 1;
            tabPlain.Text = "Plain Text";
            tabPlain.UseVisualStyleBackColor = true;
            // 
            // txtBodyText
            // 
            txtBodyText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBodyText.Font = new Font("Consolas", 9F);
            txtBodyText.Location = new Point(6, 6);
            txtBodyText.Multiline = true;
            txtBodyText.Name = "txtBodyText";
            txtBodyText.ReadOnly = true;
            txtBodyText.ScrollBars = ScrollBars.Both;
            txtBodyText.Size = new Size(1061, 545);
            txtBodyText.TabIndex = 3;
            // 
            // tabAttachments
            // 
            tabAttachments.Controls.Add(groupBox2);
            tabAttachments.Controls.Add(lstAttachments);
            tabAttachments.Location = new Point(4, 24);
            tabAttachments.Name = "tabAttachments";
            tabAttachments.Padding = new Padding(3);
            tabAttachments.Size = new Size(1073, 557);
            tabAttachments.TabIndex = 3;
            tabAttachments.Text = "Attachments (0)";
            tabAttachments.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btnAttSave);
            groupBox2.Controls.Add(txtAttModified);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtAttCreated);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtAttBytes);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtAttMime);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtAttName);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(427, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(640, 212);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "  Properties  ";
            // 
            // btnAttSave
            // 
            btnAttSave.Location = new Point(81, 167);
            btnAttSave.Name = "btnAttSave";
            btnAttSave.Size = new Size(146, 23);
            btnAttSave.TabIndex = 11;
            btnAttSave.Text = "Save Attachment";
            btnAttSave.UseVisualStyleBackColor = true;
            btnAttSave.Click += btnAttSave_Click;
            // 
            // txtAttModified
            // 
            txtAttModified.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAttModified.Location = new Point(81, 138);
            txtAttModified.Name = "txtAttModified";
            txtAttModified.ReadOnly = true;
            txtAttModified.Size = new Size(553, 23);
            txtAttModified.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 141);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Modified:";
            // 
            // txtAttCreated
            // 
            txtAttCreated.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAttCreated.Location = new Point(81, 109);
            txtAttCreated.Name = "txtAttCreated";
            txtAttCreated.ReadOnly = true;
            txtAttCreated.Size = new Size(553, 23);
            txtAttCreated.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 112);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 7;
            label6.Text = "Created:";
            // 
            // txtAttBytes
            // 
            txtAttBytes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAttBytes.Location = new Point(81, 80);
            txtAttBytes.Name = "txtAttBytes";
            txtAttBytes.ReadOnly = true;
            txtAttBytes.Size = new Size(553, 23);
            txtAttBytes.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 4;
            label4.Text = "Size (bytes):";
            // 
            // txtAttMime
            // 
            txtAttMime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAttMime.Location = new Point(81, 51);
            txtAttMime.Name = "txtAttMime";
            txtAttMime.ReadOnly = true;
            txtAttMime.Size = new Size(553, 23);
            txtAttMime.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Type:";
            // 
            // txtAttName
            // 
            txtAttName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAttName.Location = new Point(81, 22);
            txtAttName.Name = "txtAttName";
            txtAttName.ReadOnly = true;
            txtAttName.Size = new Size(553, 23);
            txtAttName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "Filename:";
            // 
            // lstAttachments
            // 
            lstAttachments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstAttachments.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstAttachments.FormattingEnabled = true;
            lstAttachments.ItemHeight = 25;
            lstAttachments.Location = new Point(6, 6);
            lstAttachments.Name = "lstAttachments";
            lstAttachments.Size = new Size(415, 529);
            lstAttachments.TabIndex = 0;
            lstAttachments.SelectedIndexChanged += lstAttachments_SelectedIndexChanged;
            // 
            // tabHeader
            // 
            tabHeader.Controls.Add(cbBlankLine);
            tabHeader.Controls.Add(cbHeaderWordWrap);
            tabHeader.Controls.Add(txtHeaders);
            tabHeader.Location = new Point(4, 24);
            tabHeader.Name = "tabHeader";
            tabHeader.Padding = new Padding(3);
            tabHeader.Size = new Size(1073, 509);
            tabHeader.TabIndex = 0;
            tabHeader.Text = "Headers";
            tabHeader.UseVisualStyleBackColor = true;
            // 
            // cbBlankLine
            // 
            cbBlankLine.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbBlankLine.AutoSize = true;
            cbBlankLine.CheckAlign = ContentAlignment.MiddleRight;
            cbBlankLine.Location = new Point(136, 484);
            cbBlankLine.Name = "cbBlankLine";
            cbBlankLine.Size = new Size(224, 19);
            cbBlankLine.TabIndex = 5;
            cbBlankLine.Text = "Show blank line between each header";
            cbBlankLine.UseVisualStyleBackColor = true;
            cbBlankLine.CheckedChanged += cbBlankLine_CheckedChanged;
            // 
            // cbHeaderWordWrap
            // 
            cbHeaderWordWrap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbHeaderWordWrap.AutoSize = true;
            cbHeaderWordWrap.CheckAlign = ContentAlignment.MiddleRight;
            cbHeaderWordWrap.Location = new Point(6, 484);
            cbHeaderWordWrap.Name = "cbHeaderWordWrap";
            cbHeaderWordWrap.Size = new Size(124, 19);
            cbHeaderWordWrap.TabIndex = 4;
            cbHeaderWordWrap.Text = "Enable Word Wrap";
            cbHeaderWordWrap.UseVisualStyleBackColor = true;
            cbHeaderWordWrap.CheckedChanged += cbHeaderWordWrap_CheckedChanged;
            // 
            // txtHeaders
            // 
            txtHeaders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHeaders.Font = new Font("Consolas", 9F);
            txtHeaders.Location = new Point(6, 6);
            txtHeaders.Multiline = true;
            txtHeaders.Name = "txtHeaders";
            txtHeaders.ReadOnly = true;
            txtHeaders.ScrollBars = ScrollBars.Both;
            txtHeaders.Size = new Size(1061, 472);
            txtHeaders.TabIndex = 3;
            txtHeaders.WordWrap = false;
            // 
            // dlgSave
            // 
            dlgSave.Title = "Save Attachment";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 655);
            Controls.Add(tabDocument);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtSubject);
            MinimumSize = new Size(800, 600);
            Name = "MainForm";
            Text = "Simple Msg Viewer";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabDocument.ResumeLayout(false);
            tabHTML.ResumeLayout(false);
            panelLoading.ResumeLayout(false);
            panelLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            tabPlain.ResumeLayout(false);
            tabPlain.PerformLayout();
            tabAttachments.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabHeader.ResumeLayout(false);
            tabHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSubject;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnOpen;
        private TextBox txtFile;
        private OpenFileDialog dlgOpen;
        private TabControl tabDocument;
        private TabPage tabHeader;
        private TextBox txtHeaders;
        private TabPage tabPlain;
        private TextBox txtBodyText;
        private TabPage tabHTML;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private Button btnAbout;
        private TabPage tabAttachments;
        private GroupBox groupBox2;
        private ListBox lstAttachments;
        private Label label2;
        private Button btnAttSave;
        private TextBox txtAttModified;
        private Label label5;
        private TextBox txtAttCreated;
        private Label label6;
        private TextBox txtAttBytes;
        private Label label4;
        private TextBox txtAttMime;
        private Label label3;
        private TextBox txtAttName;
        private SaveFileDialog dlgSave;
        private Panel panelLoading;
        private Label labLoading;
        private CheckBox cbHeaderWordWrap;
        private CheckBox cbBlankLine;
    }
}
