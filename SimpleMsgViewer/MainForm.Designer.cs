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
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabPlain = new TabPage();
            txtBodyText = new TextBox();
            tabHeader = new TabPage();
            txtHeaders = new TextBox();
            groupBox1.SuspendLayout();
            tabDocument.SuspendLayout();
            tabHTML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            tabPlain.SuspendLayout();
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
            groupBox1.Text = "  .msg File  ";
            // 
            // btnAbout
            // 
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
            // 
            // tabDocument
            // 
            tabDocument.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabDocument.Controls.Add(tabHTML);
            tabDocument.Controls.Add(tabPlain);
            tabDocument.Controls.Add(tabHeader);
            tabDocument.Location = new Point(12, 106);
            tabDocument.Name = "tabDocument";
            tabDocument.SelectedIndex = 0;
            tabDocument.Size = new Size(1081, 585);
            tabDocument.TabIndex = 4;
            // 
            // tabHTML
            // 
            tabHTML.Controls.Add(webView);
            tabHTML.Location = new Point(4, 24);
            tabHTML.Name = "tabHTML";
            tabHTML.Size = new Size(1073, 557);
            tabHTML.TabIndex = 2;
            tabHTML.Text = "HTML";
            tabHTML.UseVisualStyleBackColor = true;
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
            // tabHeader
            // 
            tabHeader.Controls.Add(txtHeaders);
            tabHeader.Location = new Point(4, 24);
            tabHeader.Name = "tabHeader";
            tabHeader.Padding = new Padding(3);
            tabHeader.Size = new Size(1073, 557);
            tabHeader.TabIndex = 0;
            tabHeader.Text = "Headers";
            tabHeader.UseVisualStyleBackColor = true;
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
            txtHeaders.Size = new Size(1061, 545);
            txtHeaders.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 703);
            Controls.Add(tabDocument);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtSubject);
            Name = "MainForm";
            Text = "Simple Msg Viewer";
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabDocument.ResumeLayout(false);
            tabHTML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            tabPlain.ResumeLayout(false);
            tabPlain.PerformLayout();
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
    }
}
