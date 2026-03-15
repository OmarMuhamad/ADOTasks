using System.ComponentModel;


namespace WinFormDay11
{
    public partial class CustDialog : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string UserTxt
        {
            get => txtInput.Text;
            set => txtInput.Text = value;
        }
        public CustDialog()
        {
            InitializeComponent();
        }

        private void CustDialog_Load(object sender, EventArgs e)
        {

        }


    }
} 
