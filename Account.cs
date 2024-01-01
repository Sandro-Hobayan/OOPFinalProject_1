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

namespace OOPFinalProject_1
{
    public partial class Account : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HOBAYAN\OneDrive\Desktop\visual studio c#\OOPFinalProject_1\Database_login.mdf"";Integrated Security=True");
        public Account()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * From admin";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvacc.DataSource = dt;
            con.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Please fill all blank field", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(txtPass.Text == txtConfirm.Text)
                {
                    if (con.State != ConnectionState.Open)
                    {
                        try
                        {
                            con.Open();
                            string checkUsername = "SELECT * FROM admin WHERE username = '" + txtUser.Text.Trim() + "'";

                            using (SqlCommand checkUser = new SqlCommand(checkUsername, con))
                            {
                                SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                if (table.Rows.Count >= 1)
                                {
                                    MessageBox.Show(txtUser.Text + " is already exist", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string insertData = "INSERT INTO admin (email, username, password) " +
                                    "VALUES(@email, @username, @pass)";


                                    using (SqlCommand cmd = new SqlCommand(insertData, con))
                                    {
                                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                                        cmd.Parameters.AddWithValue("@username", txtUser.Text.Trim());
                                        cmd.Parameters.AddWithValue("@pass", txtPass.Text.Trim());
                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Registered Successfully", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show("Invalid Password", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            txtConfirm.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshow.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }
    }
}
