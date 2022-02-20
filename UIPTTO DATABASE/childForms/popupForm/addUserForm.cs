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
using UIPTTO_DATABASE.childForms.popupForm;
using Microsoft.EntityFrameworkCore;

namespace UIPTTO_DATABASE.childForms.popupForm
{
    public partial class addUserForm : Form
    {
        private mainDBContext db = new mainDBContext();
        UserTable UserTable = new UserTable();

        userForm uform;
        public addUserForm(userForm uf)
        {
            InitializeComponent();
            this.uform = uf;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserTable.UId = Convert.ToInt32(txtboxId.Text);
            UserTable.UFname = txtboxFirstName.Text.Trim();
            UserTable.ULname = txtboxLastName.Text.Trim();
            UserTable.UEmail = txtboxEmail.Text.Trim();
            UserTable.UCollege = txtboxCollege.Text.Trim();
            UserTable.UUsername = txtboxUsername.Text.Trim();
            UserTable.UPassword = txtboxUserPassword.Text.Trim();
            UserTable.UPassword = txtboxUserPassword.Text.Trim();
            UserTable.UDob = dtpDOB.Value;
            if (rbMale.Checked)
            {
                UserTable.UGender = "male";
            }
            else
            {
                UserTable.UGender = "female";
            }
            if (txtboxUserPassword.Text != txtboxConfirmPass.Text)
            {
                lblConfirmPass.Text = "Password doesnt match";
                lblConfirmPass.ForeColor = Color.Red;
            }
            if (UserTable.UId == 0)
            {
                db.UserTables.Add(UserTable);

                MessageBox.Show("Author Profile added Successfully!");
            }
            else
            {
                db.Entry(UserTable).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                MessageBox.Show("Upadted User Successfully");

            }
            db.SaveChanges();
            this.Close();
            uform.populateDgv();
            //kapag naconvert na sa integer, iccheck ko. if(profileTable.PId == 0)

        }
    }
}
