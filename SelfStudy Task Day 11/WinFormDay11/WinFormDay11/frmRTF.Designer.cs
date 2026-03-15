namespace WinFormDay11
{
    partial class frmRTF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpen = new Button();
            btnFont = new Button();
            btnColor = new Button();
            btnSave = new Button();
            btnCust = new Button();
            btnClose = new Button();
            rtfTXT = new RichTextBox();
            flgOpen = new OpenFileDialog();
            flgSave = new SaveFileDialog();
            flgFont = new FontDialog();
            flgColor = new ColorDialog();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(34, 23);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnFont
            // 
            btnFont.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFont.Location = new Point(34, 326);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(75, 23);
            btnFont.TabIndex = 1;
            btnFont.Text = "Font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // btnColor
            // 
            btnColor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnColor.Location = new Point(252, 326);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(75, 23);
            btnColor.TabIndex = 2;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.Location = new Point(252, 23);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCust
            // 
            btnCust.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCust.Location = new Point(459, 326);
            btnCust.Name = "btnCust";
            btnCust.Size = new Size(75, 23);
            btnCust.TabIndex = 4;
            btnCust.Text = "Cust";
            btnCust.UseVisualStyleBackColor = true;
            btnCust.Click += btnCust_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(459, 23);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // rtfTXT
            // 
            rtfTXT.Location = new Point(34, 62);
            rtfTXT.Name = "rtfTXT";
            rtfTXT.Size = new Size(500, 244);
            rtfTXT.TabIndex = 6;
            rtfTXT.Text = "";
            rtfTXT.TextChanged += richTextBox1_TextChanged;
            // 
            // flgOpen
            // 
            flgOpen.FileName = "openFileDialog1";
            flgOpen.InitialDirectory = "G:";
            // 
            // frmRTF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(rtfTXT);
            Controls.Add(btnClose);
            Controls.Add(btnCust);
            Controls.Add(btnSave);
            Controls.Add(btnColor);
            Controls.Add(btnFont);
            Controls.Add(btnOpen);
            Name = "frmRTF";
            Text = "fromRTF";
            FormClosing += frmRTF_FormClosing;
            Load += frmRTF_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpen;
        private Button btnFont;
        private Button btnColor;
        private Button btnSave;
        private Button btnCust;
        private Button btnClose;
        private RichTextBox rtfTXT;
        private OpenFileDialog flgOpen;
        private SaveFileDialog flgSave;
        private FontDialog flgFont;
        private ColorDialog flgColor;
    }
}