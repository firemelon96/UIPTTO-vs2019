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

namespace UIPTTO_DATABASE.childForms
{
    public partial class profileForm : Form
    {
        private mainDBContext db = new mainDBContext();
        public profileForm()
        {
            InitializeComponent();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            addAuthorInventorForm addAuthorInventorForm = new addAuthorInventorForm();
            addAuthorInventorForm.ShowDialog();
        }

        private void profileForm_Load(object sender, EventArgs e)
        {
            var authors = from p in db.ProfileTables
                          select new {
                              id = p.PId,
                              fullname = p.PFname + " " + p.PLname,
                              email = p.PEmail,
                              college = p.PCollege,
                              birthday = p.PDob,
                              gender = p.PGender
                          };
            dgvProfile.DataSource = authors.ToList();
            //dgvProfile.DataSource = db.ProfileTables.ToList();
        }

        private void dgvProfile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProfile.Columns[e.ColumnIndex].Name == "edit")
            {                  
                addAuthorInventorForm aform = new addAuthorInventorForm();                
                aform.lblNewProfile.Text = "EDIT PROFILE";
                aform.txtboxFirstName.Text = dgvProfile.CurrentRow.Cells[0].Value.ToString();
                aform.ShowDialog();
            }
            if (dgvProfile.Columns[e.ColumnIndex].Name == "delete")
            {
                if(MessageBox.Show("Are you sure you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show("deleted");
                }
            }
        }
    }
}
