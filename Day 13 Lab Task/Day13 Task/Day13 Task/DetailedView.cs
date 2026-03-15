using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Day13_Task
{
    public partial class DetailedView : Form
    {
        public DetailedView()
        {
            InitializeComponent();
        }
        SqlConnection sqlCN;
        SqlDataAdapter sqlDataAdapterTitles;
        DataTable dtTitles;
        SqlDataAdapter sqlDataAdapterPublisher;
        DataTable dtPublisher;
        BindingSource bs;
        BindingNavigator bindingNavigator1;
        private void PublisherLabel_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            int R = sqlDataAdapterTitles.Update(dtTitles);
            MessageBox.Show($"{R} Rows Affected");
        }

        private void DetailedView_Load(object sender, EventArgs e)
        {
            //sqlCN = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=true;Encrypt=false");
            sqlCN = new();
            sqlCN.ConnectionString = ConfigurationManager.ConnectionStrings["pubsDB"].ConnectionString;
            sqlDataAdapterTitles = new SqlDataAdapter("SELECT * FROM titles", sqlCN);
            SqlCommandBuilder builder = new SqlCommandBuilder(sqlDataAdapterTitles);
            sqlDataAdapterTitles.InsertCommand = builder.GetInsertCommand();
            sqlDataAdapterTitles.UpdateCommand = builder.GetUpdateCommand();
            sqlDataAdapterTitles.DeleteCommand = builder.GetDeleteCommand();
            dtTitles = new DataTable();

            sqlDataAdapterPublisher = new SqlDataAdapter("SELECT pub_id PublisherId, pub_name PublisherName FROM publishers", sqlCN);
            dtPublisher = new DataTable();

            sqlDataAdapterTitles.Fill(dtTitles);
            sqlDataAdapterPublisher.Fill(dtPublisher);

            // Setup BindingSource
            bs = new BindingSource();
            bs.DataSource = dtTitles;

            // Create BindingNavigator
            bindingNavigator1 = new BindingNavigator(true);
            bindingNavigator1.Dock = DockStyle.Top;
            bindingNavigator1.BindingSource = bs;
            this.Controls.Add(bindingNavigator1);

            TitleIdTextBox.DataBindings.Add("Text", bs, "title_id");
            TitleTextBox.DataBindings.Add("Text", bs, "title");
            TypeTextBox.DataBindings.Add("Text", bs, "type");

            PriceUpDown.DataBindings.Add("Value", bs, "price",
                true, DataSourceUpdateMode.OnValidation, 0m);

            AdvanceUpDown.DataBindings.Add("Value", bs, "advance",
                true, DataSourceUpdateMode.OnValidation, 0m);

            numericUpDown4.DataBindings.Add("Value", bs, "ytd_sales",
                true, DataSourceUpdateMode.OnValidation, 0);

            textBox4.DataBindings.Add("Text", bs, "notes",
                true, DataSourceUpdateMode.OnValidation, "");

            dateTimePicker1.DataBindings.Add("Value", bs, "pubdate",
                true, DataSourceUpdateMode.OnValidation, DateTime.Now);
        }
    }
}
