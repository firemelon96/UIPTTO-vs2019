using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIPTTO_DATABASE.Models;

namespace UIPTTO_DATABASE.loginRegister
{
    public partial class loginForm : Form
    {
        private mainDBContext db = new mainDBContext();
        public loginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registerForm registerForm = new registerForm();
            registerForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var user = db.UserTables.Where(u => u.UUsername == txtboxUsername.Text && u.UPassword == txtboxPassword.Text).FirstOrDefault();
                if (user != null)
                {
                    //textBox_username.Clear();
                    //textBox_password.Clear();
                    checkBox1.Checked = false;
                    
                    this.Hide();
                    
                    mainForm mainForm = new mainForm();
                    mainForm.lblUsername.Text = "Hello " + user.UUsername;
                    //mainForm.lbltype.Text = "Logged in as " + user.UCollege;
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username and Password dont exist");
                    //textBox_username.Focus();
                    //textBox_username.SelectAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtboxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtboxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
