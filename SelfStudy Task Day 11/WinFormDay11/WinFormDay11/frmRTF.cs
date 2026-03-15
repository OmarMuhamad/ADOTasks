using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormDay11
{
    public partial class frmRTF : Form
    {
        public frmRTF()
        {
            InitializeComponent();
        }

        private void frmRTF_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            btnClose.Click += (sender, e) => this.Close();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRTF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit? (Y|N): ", "Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                e.Cancel = false; // allow close
            }
            else
            {
                e.Cancel = true; // prevent close
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            flgOpen.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";
            if (flgOpen.ShowDialog() == DialogResult.OK)
            {
                switch (flgOpen.FilterIndex)
                {
                    case 1:
                        rtfTXT.LoadFile(flgOpen.FileName, RichTextBoxStreamType.RichText);
                        break;
                    case 2:
                        rtfTXT.LoadFile(flgOpen.FileName, RichTextBoxStreamType.PlainText);
                        break;
                }



            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            flgSave.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";
            flgSave.InitialDirectory = "G:";
            if (flgSave.ShowDialog() == DialogResult.OK)
            {
                rtfTXT.SaveFile(flgSave.FileName, (RichTextBoxStreamType)(flgSave.FilterIndex - 1));
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (rtfTXT.SelectedText?.Length > 0)
            {
                flgFont.Font = rtfTXT.SelectionFont;
            }
            if (flgFont.ShowDialog() == DialogResult.OK)
            {
                rtfTXT.SelectionFont = flgFont.Font;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (rtfTXT.SelectedText?.Length > 0)
            {
                flgColor.Color = rtfTXT.SelectionColor;
            }
            if (flgColor.ShowDialog() == DialogResult.OK)
            {
                rtfTXT.SelectionColor = flgColor.Color;
            }
        }
        CustDialog custDialog = new();
        private void btnCust_Click(object sender, EventArgs e)
        {
            custDialog.UserTxt = "Type Here.";
            if (custDialog.ShowDialog() == DialogResult.OK)
            {
                this.rtfTXT.AppendText(custDialog.UserTxt);
            }
        }
    }
}
