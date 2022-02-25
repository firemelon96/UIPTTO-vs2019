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
using Microsoft.EntityFrameworkCore;

namespace UIPTTO_DATABASE.loginRegister
{
    public partial class registerForm : Form
    {
        private mainDBContext db = new mainDBContext();
        UserTable userTable = new UserTable();
        public registerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtboxFname.Text != string.Empty || txtboxLname.Text != string.Empty || txtboxUsername.Text != string.Empty || txtPassword.Text != string.Empty || txtboxCnfirmPassword.Text != string.Empty)
            {
                if (txtPassword.Text == txtboxCnfirmPassword.Text)
                {
                    var checkuser = db.UserTables.Where(u => u.UUsername == txtboxUsername.Text).AsNoTracking().FirstOrDefault();
                    if (checkuser !=null)
                    {
                        MessageBox.Show("Username already Exist");
                    }
                    else
                    {
                        userTable.UFname = txtboxFname.Text;
                        userTable.ULname = txtboxLname.Text;
                        userTable.UUsername = txtboxUsername.Text;
                        userTable.UPassword = txtPassword.Text;
                        userTable.UDob = dptDob.Value;
                        if (rbMale.Checked == true)
                        {
                            userTable.UGender = "Male";
                        }
                        else
                        {
                            userTable.UGender = "Female";
                        }

                        db.UserTables.Add(userTable);
                        db.SaveChanges();
                        bntCancel.Text = "LOGIN";
                        MessageBox.Show("Account Created Successfully, Login Now");
                    }
                }
                else
                {
                    MessageBox.Show("Password Doesnt match");
                }
            }
            else
            {
                MessageBox.Show("Please enter a Value in all fields");
            }
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();
            login.ShowDialog();
        }
    }
}
