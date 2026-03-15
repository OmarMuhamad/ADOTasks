using BLL.Entities;
using BLL.EntityList;
using BLL.EntityManager;
using DAL;

namespace Lab_Task_14
{
    public partial class GridView : Form
    {
        public GridView()
        {
            InitializeComponent();
        }
        TitleList titles;
        BindingSource bindingSource;
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Grid View Form";
            titles = TitleManager.SelectALLTitles();
            bindingSource = new BindingSource(titles, "");
            dataGridView.DataSource = bindingSource;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource.EndEdit();
            //foreach (Title t in titles)
            //{
            //    MessageBox.Show($"ID: '{t.TitleId}' | Name: '{t.TitleName}' | State: {t.entityState}");
            //}

            this.Text = $"{TitleManager.UpdateTitles(titles)} Rows affected";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Title selectedTitle)
            {
                selectedTitle.entityState = EntityState.Deleted;
            }
        }
    }
}
