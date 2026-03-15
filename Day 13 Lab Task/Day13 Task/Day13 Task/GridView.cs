using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Day13_Task
{
    public partial class GridView : Form
    {
        public GridView()
        {
            InitializeComponent();
        }
        SqlConnection sqlCN;
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDataAdapterTitles;
        DataTable dtTitles;
        SqlCommand sqlcmdSelectAllPublishers;
        SqlDataAdapter sqlDataAdapterPublisher;
        DataTable dtPublisher;
        private void Form1_Load(object sender, EventArgs e)
        {
            //sqlCN = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=true;Encrypt=false");
            sqlCN = new();
            sqlCN.ConnectionString = ConfigurationManager.ConnectionStrings["pubsDB"].ConnectionString;
            sqlCmd = new("Select * from Titles", sqlCN);
            sqlDataAdapterTitles = new(sqlCmd);
            dtTitles = new();

            SqlCommandBuilder builder = new SqlCommandBuilder(sqlDataAdapterTitles);
            sqlDataAdapterTitles.InsertCommand = builder.GetInsertCommand();
            sqlDataAdapterTitles.UpdateCommand = builder.GetUpdateCommand();
            sqlDataAdapterTitles.DeleteCommand = builder.GetDeleteCommand();

            sqlcmdSelectAllPublishers = new("select pub_id PublisherId, pub_name PublisherName from publishers", sqlCN);
            sqlDataAdapterPublisher = new(sqlcmdSelectAllPublishers);
            dtPublisher = new();
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sqlDataAdapterTitles.Fill(dtTitles);
            sqlDataAdapterPublisher.Fill(dtPublisher);

            dataGridView.DataSource = dtTitles;
            DataGridViewComboBoxColumn PubCol = new DataGridViewComboBoxColumn();

            PubCol.DataSource = dtPublisher;
            PubCol.DisplayMember = "PublisherName"; 
            PubCol.ValueMember = "PublisherId"; 
            PubCol.DataPropertyName = "pub_id";

            PubCol.HeaderText = "Publisher";
            dataGridView.Columns.Add(PubCol);

            //dataGridView.Columns["pub_id"].Visible = true;    
            //dataGridView.Columns["title_id"].ReadOnly = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.EndEdit();

            int R = sqlDataAdapterTitles.Update(dtTitles);

            this.Text = $"{R} Rows Affected";
        }
    }
}
