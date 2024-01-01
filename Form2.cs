using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOPFinalProject_1
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HOBAYAN\OneDrive\Desktop\visual studio c#\OOPFinalProject_1\Database_login.mdf"";Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtregemail.Text = "";
            txtreguser.Text = "";
            txtregpass.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Do you really want to exit?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtregemail.Text == "" || txtreguser.Text == "" || txtregpass.Text == "")
            {
                MessageBox.Show("Please fill all blank field", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                        string checkUsername = "SELECT * FROM admin WHERE username = '" + txtreguser.Text.Trim() + "'";

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, con))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(txtreguser.Text + " is already exist", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (email, username, password) " +
                                "VALUES(@email, @username, @pass)";


                                using (SqlCommand cmd = new SqlCommand(insertData, con))
                                {
                                    cmd.Parameters.AddWithValue("@email", txtregemail.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", txtreguser.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", txtregpass.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 f1 = new Form1();
                                    f1.Show();
                                    this.Hide();
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

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
