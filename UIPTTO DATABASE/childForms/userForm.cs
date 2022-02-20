using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIPTTO_DATABASE.childForms.popupForm;
using UIPTTO_DATABASE.Models;
using Microsoft.EntityFrameworkCore;

namespace UIPTTO_DATABASE.childForms
{
    public partial class userForm : Form
    {
        private mainDBContext db = new mainDBContext();
        UserTable userTable = new UserTable();
        public userForm()
        {
            InitializeComponent();
            this.btnEditUser.Enabled = false;
            this.btnDelUser.Enabled = false;
        }


        private void userForm_Load(object sender, EventArgs e)
        {
            populateDgv();
        }

        private void txtboxUserSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (addUserForm addUserForm = new addUserForm(this))
            {
                addUserForm.txtboxId.Text = "0";
                addUserForm.ShowDialog();
            }
        }

        public void populateDgv()
        {
            var user = from u in db.UserTables
                          select new {
                              uid = u.UId,
                              fullname = u.UFname + " " + u.ULname,
                              email = u.UEmail,
                              college = u.UCollege,
                              username = u.UUsername,
                              password = u.UPassword,
                              birthday = u.UDob,
                              gender = u.UGender
                          };
            dgvUsers.DataSource = user.ToList();

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.CurrentRow.Index != -1)
            {
                userTable.UId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["uid"].Value);
                this.btnEditUser.Enabled = true;
                this.btnDelUser.Enabled = true;
            }
            else
            {

                this.btnEditUser.ForeColor = System.Drawing.Color.Gray;
                this.btnEditUser.Enabled = false;
                this.btnDelUser.Enabled = false;
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            using (addUserForm addUserForm = new addUserForm(this))
            {

                var userid = Convert.ToInt32(dgvUsers.CurrentRow.Cells["uid"].Value);
                var user = db.UserTables.AsNoTracking().Where(u => u.UId == userid).FirstOrDefault();
                if (user != null)
                {
                    addUserForm.lblNewUser.Text = "EDIT USER";
                    addUserForm.txtboxId.Text = user.UId.ToString();
                    addUserForm.txtboxFirstName.Text = user.UFname;
                    addUserForm.txtboxLastName.Text = user.ULname;
                    addUserForm.txtboxEmail.Text = user.UEmail;
                    addUserForm.txtboxCollege.Text = user.UCollege;
                    addUserForm.txtboxUsername.Text = user.UUsername;                    
                    addUserForm.txtboxUserPassword.Text = user.UPassword;
                    addUserForm.dtpDOB.Value = Convert.ToDateTime(user.UDob);
                    if (user.UGender == "male")
                    {
                        addUserForm.rbMale.Checked = true;
                    }
                    else
                    {
                        addUserForm.rbFemale.Checked = true;
                    }
                    addUserForm.btnSave.Text = "Update";
                    addUserForm.ShowDialog();

                }
            }
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Author Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.UserTables.Remove(userTable);
                db.SaveChanges();

                MessageBox.Show("Author Record Deleted Successfully!");
                populateDgv();
            }
        }
    }
}
