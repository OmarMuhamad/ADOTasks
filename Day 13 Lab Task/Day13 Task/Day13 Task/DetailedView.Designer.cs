namespace Day13_Task
{
    partial class DetailedView
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
            TitleIdTextBox = new TextBox();
            TitleTextBox = new TextBox();
            TypeTextBox = new TextBox();
            PriceUpDown = new NumericUpDown();
            AdvanceUpDown = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            titleIdLabel = new Label();
            TitleLabel = new Label();
            TypeLabel = new Label();
            PublisherComboBox = new ComboBox();
            PublisherLabel = new Label();
            PriceLabel = new Label();
            AdvanceLabel = new Label();
            YTDLabel = new Label();
            NotesLabel = new Label();
            label1 = new Label();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PriceUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdvanceUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            SuspendLayout();
            // 
            // TitleIdTextBox
            // 
            TitleIdTextBox.Location = new Point(169, 80);
            TitleIdTextBox.Name = "TitleIdTextBox";
            TitleIdTextBox.Size = new Size(164, 23);
            TitleIdTextBox.TabIndex = 0;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(169, 109);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(164, 23);
            TitleTextBox.TabIndex = 1;
            // 
            // TypeTextBox
            // 
            TypeTextBox.Location = new Point(169, 138);
            TypeTextBox.Name = "TypeTextBox";
            TypeTextBox.Size = new Size(164, 23);
            TypeTextBox.TabIndex = 2;
            // 
            // PriceUpDown
            // 
            PriceUpDown.Location = new Point(168, 208);
            PriceUpDown.Name = "PriceUpDown";
            PriceUpDown.Size = new Size(165, 23);
            PriceUpDown.TabIndex = 4;
            // 
            // AdvanceUpDown
            // 
            AdvanceUpDown.Location = new Point(169, 249);
            AdvanceUpDown.Name = "AdvanceUpDown";
            AdvanceUpDown.Size = new Size(164, 23);
            AdvanceUpDown.TabIndex = 5;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(168, 291);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(165, 23);
            numericUpDown4.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(168, 334);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 56);
            textBox4.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(168, 421);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(164, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // titleIdLabel
            // 
            titleIdLabel.AutoSize = true;
            titleIdLabel.Location = new Point(101, 83);
            titleIdLabel.Name = "titleIdLabel";
            titleIdLabel.Size = new Size(49, 15);
            titleIdLabel.TabIndex = 9;
            titleIdLabel.Text = "Title ID: ";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(101, 112);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(32, 15);
            TitleLabel.TabIndex = 10;
            TitleLabel.Text = "Title:";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(101, 141);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(37, 15);
            TypeLabel.TabIndex = 11;
            TypeLabel.Text = "Type: ";
            // 
            // PublisherComboBox
            // 
            PublisherComboBox.FormattingEnabled = true;
            PublisherComboBox.Location = new Point(168, 170);
            PublisherComboBox.Name = "PublisherComboBox";
            PublisherComboBox.Size = new Size(165, 23);
            PublisherComboBox.TabIndex = 12;
            // 
            // PublisherLabel
            // 
            PublisherLabel.AutoSize = true;
            PublisherLabel.Location = new Point(101, 173);
            PublisherLabel.Name = "PublisherLabel";
            PublisherLabel.Size = new Size(62, 15);
            PublisherLabel.TabIndex = 13;
            PublisherLabel.Text = "Publisher: ";
            PublisherLabel.Click += PublisherLabel_Click;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(100, 210);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(36, 15);
            PriceLabel.TabIndex = 14;
            PriceLabel.Text = "Price:";
            // 
            // AdvanceLabel
            // 
            AdvanceLabel.AutoSize = true;
            AdvanceLabel.Location = new Point(100, 251);
            AdvanceLabel.Name = "AdvanceLabel";
            AdvanceLabel.Size = new Size(56, 15);
            AdvanceLabel.TabIndex = 15;
            AdvanceLabel.Text = "Advance:";
            // 
            // YTDLabel
            // 
            YTDLabel.AutoSize = true;
            YTDLabel.Location = new Point(100, 293);
            YTDLabel.Name = "YTDLabel";
            YTDLabel.Size = new Size(60, 15);
            YTDLabel.TabIndex = 16;
            YTDLabel.Text = "YTD Sales:";
            // 
            // NotesLabel
            // 
            NotesLabel.AutoSize = true;
            NotesLabel.Location = new Point(101, 355);
            NotesLabel.Name = "NotesLabel";
            NotesLabel.Size = new Size(41, 15);
            NotesLabel.TabIndex = 17;
            NotesLabel.Text = "Notes:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 427);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 18;
            label1.Text = "Pub Date:";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(372, 504);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 19;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DetailedView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 555);
            Controls.Add(SaveButton);
            Controls.Add(label1);
            Controls.Add(NotesLabel);
            Controls.Add(YTDLabel);
            Controls.Add(AdvanceLabel);
            Controls.Add(PriceLabel);
            Controls.Add(PublisherLabel);
            Controls.Add(PublisherComboBox);
            Controls.Add(TypeLabel);
            Controls.Add(TitleLabel);
            Controls.Add(titleIdLabel);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(numericUpDown4);
            Controls.Add(AdvanceUpDown);
            Controls.Add(PriceUpDown);
            Controls.Add(TypeTextBox);
            Controls.Add(TitleTextBox);
            Controls.Add(TitleIdTextBox);
            Name = "DetailedView";
            Text = "DetailedView";
            Load += DetailedView_Load;
            ((System.ComponentModel.ISupportInitialize)PriceUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdvanceUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TitleIdTextBox;
        private TextBox TitleTextBox;
        private TextBox TypeTextBox;
        private NumericUpDown PriceUpDown;
        private NumericUpDown AdvanceUpDown;
        private NumericUpDown numericUpDown4;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Label titleIdLabel;
        private Label TitleLabel;
        private Label TypeLabel;
        private ComboBox PublisherComboBox;
        private Label PublisherLabel;
        private Label PriceLabel;
        private Label AdvanceLabel;
        private Label YTDLabel;
        private Label NotesLabel;
        private Label label1;
        private Button SaveButton;
    }
}