using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOPFinalProject_1
{
    public partial class Booklist : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HOBAYAN\OneDrive\Desktop\visual studio c#\OOPFinalProject_1\Database_login.mdf"";Integrated Security=True");

        public Booklist()
        {
            InitializeComponent();
        }

        private void Booklist_Load(object sender, EventArgs e)
        {
            Filldgv();

            lblbookname.Enabled = false;
            lblauthor.Enabled = false;
            lblisbn.Enabled = false;
            lblcategory.Enabled = false;
            lblpublisher.Enabled = false;
            lblcopyright.Enabled = false;
            lblstatus.Enabled = false;
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void Filldgv()
        {
            con.Open();
            string query = "Select * From books";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvbook.AutoGenerateColumns = false;
            dgvbook.DataSource = dt;

            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "books");
            dgvbook.DataSource = ds.Tables[0];
            con.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addbook add = new Addbook();
            add.Show();
        }

        private void dgvbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = dgvbook.Rows[e.RowIndex];
                lblbookname.Text = dgvr.Cells[0].Value.ToString();
                lblcategory.Text = dgvr.Cells[1].Value.ToString();
                lblauthor.Text = dgvr.Cells[2].Value.ToString();
                lblstatus.Text = dgvr.Cells[3].Value.ToString();
                lblcopyright.Text = dgvr.Cells[4].Value.ToString();
                lblpublisher.Text = dgvr.Cells[5].Value.ToString();
                lblisbn.Text = dgvr.Cells[6].Value.ToString();
            }
        }

        private void dgvbook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
