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

            addCopyrightForm.txtboxId.Text = "0";

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
            dgvCopyright.DataSource = joinTbles.ToList();
            txtboxSearchCopyright.Text = "";
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
                this.btnEditCopyright.Enabled = true;
                this.btnDelCopyright.Enabled = true;
            }
        }

        private void btnEditCopyright_Click(object sender, EventArgs e)
        {
            using (addCopyrightForm copyrightForm = new addCopyrightForm(this))
            {
                var copyId = Convert.ToInt32(dgvCopyright.CurrentRow.Cells["cid"].Value);
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
                    apprdate = c.CApprDate,
                    pid = p.PId
                }
                ).Where(e => e.id == copyId).FirstOrDefault();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
                if (copy != null)
                    {
                    List<ProfileTable> profileTables = (from ProfileTable in db.ProfileTables select ProfileTable).ToList();

                    profileTables.Insert(0, new ProfileTable {
                        PId = copy.pid,
                        PFname = copy.author
                    });                    
                    copyrightForm.cbAuthor.DataSource = profileTables;
                    copyrightForm.cbAuthor.DisplayMember = "PFullname";
                    copyrightForm.cbAuthor.ValueMember = "PId";
                    copyrightForm.lblNewCopyright.Text = "EDIT COPYRIGHT";
                    copyrightForm.txtboxId.Text = copy.id.ToString();
                    copyrightForm.txtboxCcollege.Text = copy.college;
                    copyrightForm.txtboxCtitle.Text = copy.title;
                    copyrightForm.dptDatefiled.Value = Convert.ToDateTime(copy.date_filed);
                    copyrightForm.txtboxCregno.Text = copy.reg_no.ToString();
                    copyrightForm.dptApprovaldate.Value = Convert.ToDateTime(copy.apprdate);
                    if (copy.status == "Approved")
                    {
                        copyrightForm.rbApproved.Checked = true;
                    }
                    else
                    {
                        copyrightForm.rbProgress.Checked = true;
                    }
                    copyrightForm.btnSave.Text = "Update";
                    copyrightForm.ShowDialog();
                } 
            }
        }

        private void btnDelCopyright_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Author Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.CopyrightTables.Remove(copyrightTable);
                db.SaveChanges();
                txtboxSearchCopyright.Text = "";

                MessageBox.Show("Author Record Deleted Successfully!");
                populateDgv();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtboxSearchCopyright.Text.Trim()))
                {
                    populateDgv();
                }
                else
                {
                    var joinTbles = db.CopyrightTables
                .Join(
                db.ProfileTables,
                c => c.PId,
                p => p.PId,
                (c, p) => new {
                    c.CId,
                    c.CTitle,
                    p.PCollege,
                    p.PFname,
                    p.PLname,
                    p.PFullname,
                    c.CDateFiled,
                    c.CRegNo,
                    c.CStatus
                })
                .Where(x => x.CTitle.Contains(txtboxSearchCopyright.Text) 
                || x.PCollege.Contains(txtboxSearchCopyright.Text)
                || x.PFname.Contains(txtboxSearchCopyright.Text)
                || x.PLname.Contains(txtboxSearchCopyright.Text))
                .Select(x=> new {
                    cid = x.CId,
                    title = x.CTitle,
                    college = x.PCollege,
                    author = x.PFullname,
                    date_filed = x.CDateFiled,
                    reg_no = x.CRegNo,
                    status = x.CStatus
                });
                    
                    dgvCopyright.DataSource = joinTbles.ToList();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());

            }
        }

        private void txtboxSearchCopyright_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxSearchCopyright.Text))
            {
                populateDgv();
            }
        }
    }
}
