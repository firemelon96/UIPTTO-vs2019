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

namespace UIPTTO_DATABASE.childForms
{
    public partial class profileForm : Form
    {
        private mainDBContext db = new mainDBContext();
        ProfileTable ProfileTable = new ProfileTable();
        public profileForm()
        {
            InitializeComponent();

            this.btnEditAuthor.Enabled = false;
            this.btnDelAuthor.Enabled = false;
        }
        void clear()
        {
            ProfileTable.PId = 0;
            dgvProfile.Rows[0].Cells[0].Selected = false;
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            using (addAuthorInventorForm addAuthorInventorForm = new addAuthorInventorForm(this))
            {
                //everytime na magcclick ako net, iseset ko ang text value ng form sa 0
                addAuthorInventorForm.txtboxId.Text = "0";
                clear();
                addAuthorInventorForm.ShowDialog();
                
            }
        }

        private void profileForm_Load(object sender, EventArgs e)
        {
            populateDgv();
            clear();
            //dgvProfile.DataSource = db.ProfileTables.ToList();
            //find ways to disable the autoselect in datagridview
            
        }

        public void populateDgv()
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
            
        }

        private void dgvProfile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //if (dgvProfile.SelectedRows.Count > 0)
            if(dgvProfile.CurrentRow.Index != -1)
            {
                ProfileTable.PId = Convert.ToInt32(dgvProfile.CurrentRow.Cells["id"].Value);
                this.btnEditAuthor.Enabled = true;
                this.btnDelAuthor.Enabled = true;
            }
            else
            {
                this.btnEditAuthor.Enabled = false;
                this.btnDelAuthor.Enabled = false;
            }
        }

        private void btnEditAuthor_Click(object sender, EventArgs e)
        {
            using (addAuthorInventorForm authorInventorForm = new addAuthorInventorForm(this))
            {
                
                    var profid = Convert.ToInt32(dgvProfile.CurrentRow.Cells["id"].Value);
                    var prof = db.ProfileTables.AsNoTracking().Where(p => p.PId == profid).FirstOrDefault();
                    if (prof != null)
                    {   
                        //ilalagay ko sa txtboxId ang value ng mareretrieve ko na id mula sa database.
                        authorInventorForm.lblNewProfile.Text = "EDIT PROFILE";
                        authorInventorForm.txtboxId.Text = prof.PId.ToString();
                        authorInventorForm.txtboxFirstName.Text = prof.PFname;
                        authorInventorForm.txtboxLastName.Text = prof.PLname;
                        authorInventorForm.txtboxEmail.Text = prof.PEmail;
                        authorInventorForm.txtboxCollege.Text = prof.PCollege;
                        authorInventorForm.txtboxContact.Text = prof.PEmail;
                        if (prof.PGender == "male")
                        {
                           authorInventorForm.rbMale.Checked = true;
                        }
                        else
                        {
                            authorInventorForm.rbFemale.Checked = true;
                        }
                        authorInventorForm.btnSave.Text = "Update";
                    authorInventorForm.ShowDialog();
                                        
                }
            }
        }
        
        private void btnDelAuthor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Author Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //mdb.Entry(ProfileTable).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                
                //var entry = db.Entry(ProfileTable);
                ///if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Detached)
                    //db.ProfileTables.Attach(ProfileTable);
                db.ProfileTables.Remove(ProfileTable);                    
                db.SaveChanges();
                    
                MessageBox.Show("Author Record Deleted Successfully!");
                populateDgv();
            }
        }
    }
}
