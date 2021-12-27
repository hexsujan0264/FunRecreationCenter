using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunRecreationCenter
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter username and password.");

                }
                else if (txtUser.Text == "admin" && txtPassword.Text == "admin")
                {
                   VisitorInfo fm1 = new VisitorInfo();
                    fm1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter the correct password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
