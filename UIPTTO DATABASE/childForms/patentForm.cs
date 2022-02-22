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
    public partial class patentForm : Form
    {
        private mainDBContext db = new mainDBContext();
        PatentTable patentTable = new PatentTable();
        public patentForm()
        {
            InitializeComponent();
            this.btnEditPatent.Enabled = false;
            this.btnDelPatent.Enabled = false;
        }

        public void populatepatentDgv()
        {
            var patentjoin = db.PatentTables
                .Join(
                db.ProfileTables,
                pt => pt.PId,
                p => p.PId,
                (pt, p) => new {
                    ptid = pt.PtId,
                    inventionTitle = pt.PtTitle,
                    college = p.PCollege,
                    inventor = p.PFullname,
                    date_filed = pt.PtDateFiled,
                    app_no = pt.PtRegNo,
                    status = pt.PtStatus
                }
                );
            dgvPatents.DataSource = patentjoin.ToList();
            txtboxSearchPatents.Text = "";
        }

        private void patentForm_Load(object sender, EventArgs e)
        {
            populatepatentDgv();
        }


        private void btnEditPatent_Click(object sender, EventArgs e)
        {
            using (addPatentForm patentForm = new addPatentForm(this))
            {
                var copyId = Convert.ToInt32(dgvPatents.CurrentRow.Cells["ptid"].Value);
                var copy = db.PatentTables
                .Join(
                db.ProfileTables,
                pt => pt.PId,
                p => p.PId,
                (pt, p) => new {
                    id = pt.PtId,
                    title = pt.PtTitle,
                    college = p.PCollege,
                    author = p.PFullname,
                    date_filed = pt.PtDateFiled,
                    reg_no = pt.PtRegNo,
                    status = pt.PtStatus,
                    apprdate = pt.PrApprDate,
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
                    patentForm.cbAuthor.DataSource = profileTables;
                    patentForm.cbAuthor.DisplayMember = "PFullname";
                    patentForm.cbAuthor.ValueMember = "PId";
                    patentForm.lblNewPatent.Text = "EDIT Patent";
                    patentForm.txtboxId.Text = copy.id.ToString();
                    patentForm.txtboxPcollege.Text = copy.college;
                    patentForm.txtboxPtitle.Text = copy.title;
                    patentForm.dptDatefiled.Value = Convert.ToDateTime(copy.date_filed);
                    patentForm.txtboxPregno.Text = copy.reg_no.ToString();
                    patentForm.dptApprovaldate.Value = Convert.ToDateTime(copy.apprdate);
                    if (copy.status == "Approved")
                    {
                        patentForm.rbApproved.Checked = true;
                    }
                    else
                    {
                        patentForm.rbProgress.Checked = true;
                    }
                    patentForm.btnSave.Text = "Update";
                    patentForm.ShowDialog();
                }
            }
        }

        private void btnDelPatent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Author Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.PatentTables.Remove(patentTable);
                db.SaveChanges();

                MessageBox.Show("Author Record Deleted Successfully!");
                populatepatentDgv();
            }
        }

        private void btnAddPatent_Click_1(object sender, EventArgs e)
        {
            addPatentForm addPatentForm = new addPatentForm(this);

            addPatentForm.txtboxId.Text = "0";

            List<ProfileTable> profileTables = (from ProfileTable in db.ProfileTables select ProfileTable).ToList();

            profileTables.Insert(0, new ProfileTable {
                PId = 0,
                PFname = "select author"
            });
            addPatentForm.cbAuthor.DataSource = profileTables;
            addPatentForm.cbAuthor.DisplayMember = "PFullname";
            addPatentForm.cbAuthor.ValueMember = "PId";
            addPatentForm.ShowDialog();
        }

        private void dgvPatents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPatents.CurrentRow.Index != -1)
            {
                patentTable.PtId = Convert.ToInt32(dgvPatents.CurrentRow.Cells["ptid"].Value);
                this.btnEditPatent.Enabled = true;
                this.btnDelPatent.Enabled = true;
            }
            else
            {
                this.btnEditPatent.Enabled = true;
                this.btnDelPatent.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtboxSearchPatents.Text.Trim()))
                {
                    populatepatentDgv();
                }
                else
                {
                    var joinTbles = db.PatentTables
                .Join(
                db.ProfileTables,
                pt => pt.PId,
                p => p.PId,
                (pt, p) => new {
                    pt.PtId,
                    pt.PtTitle,
                    p.PCollege,
                    p.PFname,
                    p.PLname,
                    p.PFullname,
                    pt.PtDateFiled,
                    pt.PtRegNo,
                    pt.PtStatus
                })
                .Where(x => x.PtTitle.Contains(txtboxSearchPatents.Text)
                || x.PCollege.Contains(txtboxSearchPatents.Text)
                || x.PFname.Contains(txtboxSearchPatents.Text)
                || x.PLname.Contains(txtboxSearchPatents.Text))
                .Select(x => new {
                    ptid = x.PtId,
                    inventionTitle = x.PtTitle,
                    college = x.PCollege,
                    inventor = x.PFullname,
                    date_filed = x.PtDateFiled,
                    app_no = x.PtRegNo,
                    status = x.PtStatus
                });

                    dgvPatents.DataSource = joinTbles.ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString());

            }
        }

        private void txtboxSearchPatents_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxSearchPatents.Text))
            {
                populatepatentDgv();
            }
        }
    }
}
