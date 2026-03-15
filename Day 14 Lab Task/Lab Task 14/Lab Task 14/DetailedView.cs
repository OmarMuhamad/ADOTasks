using BLL.Entities;
using BLL.EntityList;
using BLL.EntityManager;

namespace Lab_Task_14
{
    public partial class DetailedView : Form
    {
        public DetailedView()
        {
            InitializeComponent();
        }

        TitleList titles;
        BindingSource bs;
        BindingNavigator bindingNavigator1;

        private void DetailedView_Load(object sender, EventArgs e)
        {

            titles = TitleManager.SelectALLTitles();

            bs = new BindingSource();
            bs.DataSource = titles;
            bindingNavigator1 = new BindingNavigator(true);
            bindingNavigator1.Dock = DockStyle.Top;
            bindingNavigator1.BindingSource = bs;
            this.Controls.Add(bindingNavigator1);

            TitleIdTextBox.DataBindings.Add("Text", bs, "TitleId");
            TitleTextBox.DataBindings.Add("Text", bs, "TitleName");
            TypeTextBox.DataBindings.Add("Text", bs, "Type",
                true, DataSourceUpdateMode.OnValidation, "");
            PublisherComboBox.DataBindings.Add("Text", bs, "PubId",
                true, DataSourceUpdateMode.OnValidation, "");
            PriceUpDown.DataBindings.Add("Value", bs, "Price",
                true, DataSourceUpdateMode.OnValidation, 0m);
            AdvanceUpDown.DataBindings.Add("Value", bs, "Advance",
                true, DataSourceUpdateMode.OnValidation, 0m);
            numericUpDown4.DataBindings.Add("Value", bs, "YtdSales",
                true, DataSourceUpdateMode.OnValidation, 0);
            textBox4.DataBindings.Add("Text", bs, "Notes",
                true, DataSourceUpdateMode.OnValidation, "");
            dateTimePicker1.DataBindings.Add("Value", bs, "PubDate",
                true, DataSourceUpdateMode.OnValidation, DateTime.Now);
            textBox1.DataBindings.Add("Text", bs, "entityState");
        }



        private void SaveButton_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            int affected = TitleManager.UpdateTitles(titles);
            MessageBox.Show($"{affected} Rows Affected");

            //titles = TitleManager.SelectALLTitles();
            //bs.DataSource = titles;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (bs.Current is Title selectedTitle)
            {
                selectedTitle.entityState = EntityState.Deleted;
                bs.ResetCurrentItem(); 
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            titles = TitleManager.SelectALLTitles();
            bs.DataSource = titles;
        }
    }
}