using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPFinalProject_1
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void controlPanel()
        {
            pnlhome.Controls.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booklist bl = new Booklist() { TopLevel = false, TopMost = true };
            pnlhome.Controls.Add(bl);
            bl.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
                controlPanel();
                Booklist bl = new Booklist() { TopLevel = false, TopMost = true };
                pnlhome.Controls.Add(bl);
                bl.Show();
                lblTitle.Text = "Book List";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pnlhome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure you really want to log out?", "Logging out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Do you really want to log out?", "Logging out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            controlPanel();
            lblTitle.Text = "Borrower List";
        }

        private void pnlhome_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            controlPanel();
            Account acc = new Account() { TopLevel = false, TopMost = true };
            pnlhome.Controls.Add(acc);
            acc.Show();
            lblTitle.Text = "Account settings";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            controlPanel();
            lblTitle.Text = "Transaction";
        }
    }
}
