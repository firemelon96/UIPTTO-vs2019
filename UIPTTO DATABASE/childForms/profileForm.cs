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
        public bool Checked { get; set;}
        public profileForm()
        {
            InitializeComponent();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            addAuthorInventorForm addAuthorInventorForm = new addAuthorInventorForm(this);
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
            
            if (dgvProfile.Columns[e.ColumnIndex].Name == "fullname")
            {
                var id = dgvProfile.Rows[e.RowIndex].Cells[0].Value;
                //MessageBox.Show(id);
                var prof = db.ProfileTables.Find(id);
                
                if (prof != null)
                {
                    addAuthorInventorForm aform = new addAuthorInventorForm(this);
                    aform.lblNewProfile.Text = "EDIT PROFILE";
                    aform.txtId.Text = id.ToString();
                    aform.txtboxFirstName.Text = prof.PFname;
                    aform.txtboxLastName.Text = prof.PLname;
                    aform.txtboxEmail.Text = prof.PEmail;
                    aform.txtboxCollege.Text = prof.PCollege;
                    aform.txtboxContact.Text = prof.PEmail;
                    DateTime pDob = (DateTime)prof.PDob;
                    aform.dtpDOB.Value = pDob;
                    if (prof.PGender == "male")
                    {
                        aform.rbMale.Checked = true;
                    }
                    //aform.txtboxFirstName.Text = dgvProfile.CurrentRow.Cells[0].Value.ToString();
                    aform.ShowDialog();
                }
                
            }
            if (dgvProfile.Columns[e.ColumnIndex].Name == "delete")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show("deleted");
                }
            }

        }
    }
}
