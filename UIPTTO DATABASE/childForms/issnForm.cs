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
    public partial class issnForm : Form
    {
        private mainDBContext db = new mainDBContext();
        IssnTable issn = new IssnTable();
        public issnForm()
        {
            InitializeComponent();
            this.btnEditIssn.Enabled = false;
            this.btnDelIssn.Enabled=false;
        }

        private void btnAddIssn_Click_1(object sender, EventArgs e)
        {
            addIssnForm addIssnForm = new addIssnForm(this);

            addIssnForm.txtboxId.Text = "0";

            List<ProfileTable> profileTables = (from ProfileTable in db.ProfileTables select ProfileTable).ToList();

            profileTables.Insert(0, new ProfileTable {
                PId = 0,
                PFname = "select author"
            });
            addIssnForm.cbAuthor.DataSource = profileTables;
            addIssnForm.cbAuthor.DisplayMember = "PFullname";
            addIssnForm.cbAuthor.ValueMember = "PId";


            addIssnForm.ShowDialog();
        }

        public void populateDgv()
        {
            var joinTbles = db.IssnTables
                .Join(
                db.ProfileTables,
                i => i.PId,
                p => p.PId,
                (i, p) => new {
                    iid = i.IId,
                    title = i.ITitle,
                    college = p.PCollege,
                    author = p.PFullname,
                    date_filed = i.IDateFiled,
                    reg_no = i.IIssuedNo,
                    status = i.IStatus
                }
                );
            dgvIssn.DataSource = joinTbles.ToList();
        }

        private void issnForm_Load(object sender, EventArgs e)
        {
            populateDgv();
        }

        private void dgvIssn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIssn.CurrentRow.Index != -1)
            {
                issn.IId = Convert.ToInt32(dgvIssn.CurrentRow.Cells["iid"].Value);
                this.btnEditIssn.Enabled = true;
                this.btnDelIssn.Enabled = true;
            }
            else
            {
                this.btnEditIssn.Enabled = true;
                this.btnDelIssn.Enabled = true;
            }
        }

        private void btnEditIssn_Click(object sender, EventArgs e)
        {
            using (addIssnForm issnForm = new addIssnForm(this))
            {
                var copyId = Convert.ToInt32(dgvIssn.CurrentRow.Cells["iid"].Value);
                var copy = db.IssnTables
                .Join(
                db.ProfileTables,
                i => i.PId,
                p => p.PId,
                (i, p) => new {
                    id = i.IId,
                    title = i.ITitle,
                    college = p.PCollege,
                    author = p.PFullname,
                    date_filed = i.IDateFiled,
                    reg_no = i.IIssuedNo,
                    status = i.IStatus,
                    apprdate = i.IApprDate,
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
                    issnForm.cbAuthor.DataSource = profileTables;
                    issnForm.cbAuthor.DisplayMember = "PFullname";
                    issnForm.cbAuthor.ValueMember = "PId";
                    issnForm.lblNewIssn.Text = "EDIT ISSN";
                    issnForm.txtboxId.Text = copy.id.ToString();
                    issnForm.txtboxIcollege.Text = copy.college;
                    issnForm.txtboxItitle.Text = copy.title;
                    issnForm.dptDatefiled.Value = Convert.ToDateTime(copy.date_filed);
                    issnForm.txtboxIregno.Text = copy.reg_no.ToString();
                    issnForm.dptApprovaldate.Value = Convert.ToDateTime(copy.apprdate);
                    if (copy.status == "Approved")
                    {
                        issnForm.rbApproved.Checked = true;
                    }
                    else
                    {
                        issnForm.rbProgress.Checked = true;
                    }
                    issnForm.btnSave.Text = "Update";
                    issnForm.ShowDialog();
                }
            }
        }

        private void btnDelIssn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Author Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.IssnTables.Remove(issn);
                db.SaveChanges();

                MessageBox.Show("ISSN Record Deleted Successfully!");
                populateDgv();
            }
        }
    }
}
