using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOPFinalProject_1
{
    public partial class Addbook : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HOBAYAN\OneDrive\Desktop\visual studio c#\OOPFinalProject_1\Database_login.mdf"";Integrated Security=True");
        string category;
        string status;

        public Addbook()
        {
            InitializeComponent();
        }

        private void Addbook_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtbookname.Text = "";
            txtauthor.Text = "";
            txtisbn.Text = "";
            txtpublisher.Text = "";
            txtcopyright.Text = "";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (txtbookname.Text == "" || txtauthor.Text == "" || txtisbn.Text == "" || txtpublisher.Text == "" || txtcopyright.Text == "")
            {
                MessageBox.Show("Please fill all blank field", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Add book data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    if (con.State != ConnectionState.Open)
                    {
                        try
                        {
                            con.Open();
                            string checkUsername = "SELECT * FROM books WHERE bookname = '" + txtbookname.Text.Trim() + "'";

                            using (SqlCommand checkUser = new SqlCommand(checkUsername, con))
                            {
                                SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                if (table.Rows.Count >= 1)
                                {
                                    MessageBox.Show(txtbookname.Text + " is already exist", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string insertData = "INSERT INTO books (category, bookname, author, isbn, publisher, copyright, status) " +
                                    "VALUES(@category, @bookname, @author, @isbn, @publisher, @copyright, @status)";

                                    if (radacad.Checked == true)
                                    {
                                        category = "Academic";
                                    }
                                    else if (radfiction.Checked == true)
                                    {
                                        category = "Fictional";
                                    }
                                    else
                                    {
                                        category = "Non-fictional";
                                    }

                                    if (radborrowed.Checked == true)
                                    {
                                        status = "Borrowed";
                                    }
                                    else if (radreturned.Checked == true)
                                    {
                                        status = "Returned";
                                    }
                                    else
                                    {
                                        status = "Reserve";
                                    }


                                    using (SqlCommand cmd = new SqlCommand(insertData, con))
                                    {
                                        cmd.Parameters.AddWithValue("@category", category.Trim());
                                        cmd.Parameters.AddWithValue("@bookname", txtbookname.Text.Trim());
                                        cmd.Parameters.AddWithValue("@author", txtauthor.Text.Trim());
                                        cmd.Parameters.AddWithValue("@isbn", txtisbn.Text.Trim());
                                        cmd.Parameters.AddWithValue("@publisher", txtpublisher.Text.Trim());
                                        cmd.Parameters.AddWithValue("@copyright", txtcopyright.Text.Trim());
                                        cmd.Parameters.AddWithValue("@status", status.Trim());

                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Added Successfully", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        this.Close();

                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error connecting database" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
