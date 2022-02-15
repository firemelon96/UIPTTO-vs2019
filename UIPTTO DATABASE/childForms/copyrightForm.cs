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
    public partial class copyrightForm : Form
    {
        private mainDBContext db = new mainDBContext();
        CopyrightTable copyrightTable = new CopyrightTable();
        public copyrightForm()
        {
            InitializeComponent();
            this.btnEditCopyright.Enabled = false;
            this.btnDelCopyright.Enabled = false;
        }

        private void btnAddCopyright_Click_1(object sender, EventArgs e)
        {
            addCopyrightForm addCopyrightForm = new addCopyrightForm(this);
            List<ProfileTable> profileTables = (from ProfileTable in db.ProfileTables select ProfileTable).ToList();

            profileTables.Insert(0, new ProfileTable {
                PId = 0,
                PFname = "select author"
            });
            addCopyrightForm.cbAuthor.DataSource = profileTables;
            addCopyrightForm.cbAuthor.DisplayMember = "PFullname";
            addCopyrightForm.cbAuthor.ValueMember = "PId";

            
            addCopyrightForm.ShowDialog();
        }

        public void populateDgv()
        {
            var joinTbles = db.CopyrightTables
                .Join(
                db.ProfileTables,
                c => c.PId,
                p => p.PId,
                (c, p) => new {
                    cid = c.CId,
                    title = c.CTitle,
                    college = p.PCollege,
                    author = p.PFullname,
                    date_filed = c.CDateFiled,
                    reg_no = c.CRegNo,
                    status = c.CStatus
                }
                );
            dgvCopyright.DataSource = joinTbles.ToList(); ;
        }

        private void copyrightForm_Load(object sender, EventArgs e)
        {
            populateDgv();
        }

        private void dgvCopyright_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCopyright.CurrentRow.Index != -1)
            {
                copyrightTable.CId = Convert.ToInt32(dgvCopyright.CurrentRow.Cells["cid"].Value);
                this.btnEditCopyright.Enabled = true;
                this.btnDelCopyright.Enabled = true;
            }
            else
            {

                //this.btnEditAuthor.ForeColor = System.Drawing.Color.Gray;
                this.btnEditCopyright.Enabled = true;
                this.btnDelCopyright.Enabled = true;
            }
        }

        private void btnEditCopyright_Click(object sender, EventArgs e)
        {
            using (addCopyrightForm copyrightForm = new addCopyrightForm(this))
            {
                var copyId = Convert.ToInt32(dgvCopyright.CurrentRow.Cells["cid"].Value);
                //MessageBox.Show(copyId.ToString());
                //var cop = db.CopyrightTables.Where(c => c.CId == copyId).FirstOrDefault();
                var copy = db.CopyrightTables
                .Join(
                db.ProfileTables,
                c => c.PId,
                p => p.PId,
                (c, p) => new {
                    id = c.CId,
                    title = c.CTitle,
                    college = p.PCollege,
                    author = p.PFullname,
                    date_filed = c.CDateFiled,
                    reg_no = c.CRegNo,
                    status = c.CStatus,
                    pid = p.PId
                }
                ).Where(e => e.id == copyId).FirstOrDefault();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
                if (copy != null)
                   // if (cop != null)
                    {
                    List<ProfileTable> profileTables = (from ProfileTable in db.ProfileTables select ProfileTable).ToList();

                    profileTables.Insert(0, new ProfileTable {
                        PId = copy.pid,
                        PFname = copy.author
                    });                    
                    //List a selected id of author from copyright table
                    copyrightForm.cbAuthor.DataSource = profileTables;
                    copyrightForm.cbAuthor.DisplayMember = "PFullname";
                    copyrightForm.cbAuthor.ValueMember = "PId";
                    //ilalagay ko sa txtboxId ang value ng mareretrieve ko na id mula sa database.
                    copyrightForm.lblNewCopyright.Text = "EDIT COPYRIGHT";
                    copyrightForm.txtboxId.Text = copy.id.ToString();
                    //copyrightForm.cbAuthor.SelectedItem = copy.author;
                    copyrightForm.txtboxCcollege.Text = copy.college;
                    //copyrightForm.dptDatefiled.Value = copy.date_filed.Value.Date;
                    //copyrightForm.txtboxCregno.Text = copy.reg_no.ToString();
                    //authorInventorForm.txtboxEmail.Text = prof.PEmail;
                    //authorInventorForm.txtboxCollege.Text = prof.PCollege;
                    //authorInventorForm.txtboxContact.Text = prof.PEmail;
                   // if (cop.CStatus == "Approved")
                   // {
                   //     copyrightForm.rbApproved.Checked = true;
                   // }
                  //  else
                  //  {
                   //     copyrightForm.rbProgress.Checked = true;
                  //  }
                    copyrightForm.btnSave.Text = "Update";
                    copyrightForm.ShowDialog();
                }
            }
        }
    }
}
