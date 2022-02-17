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
    public partial class isbnForm : Form
    {
        private mainDBContext db = new mainDBContext();
        IsbnTable isbnTable = new IsbnTable(); 

        public isbnForm()
        {
            InitializeComponent();
            this.btnEditIsbn.Enabled = false;
            this.btnDelIsbn.Enabled = false;
        }

        private void btnAddIsbn_Click_1(object sender, EventArgs e)
        {
            addIsbnForm addIsbnForm = new addIsbnForm(this);

            addIsbnForm.txtboxId.Text = "0";

            List<ProfileTable> profileTables = (from ProfileTable in db.ProfileTables select ProfileTable).ToList();

            profileTables.Insert(0, new ProfileTable {
                PId = 0,
                PFname = "select author"
            });
            addIsbnForm.cbAuthor.DataSource = profileTables;
            addIsbnForm.cbAuthor.DisplayMember = "PFullname";
            addIsbnForm.cbAuthor.ValueMember = "PId";


            addIsbnForm.ShowDialog();
        }

        public void populateDgv()
        {
            var joinTbles = db.IsbnTables
                .Join(
                db.ProfileTables,
                ib => ib.PId,
                p => p.PId,
                (ib, p) => new {
                    ibid = ib.IsId,
                    title = ib.IsTitle,
                    college = p.PCollege,
                    author = p.PFullname,
                    date_filed = ib.IsDateFiled,
                    issued_no = ib.IsIssuedNo,
                    status = ib.IsStatus
                }
                );
            dgvIsbn.DataSource = joinTbles.ToList();
        }

        private void isbnForm_Load(object sender, EventArgs e)
        {
            populateDgv();
        }

        private void dgvIsbn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIsbn.CurrentRow.Index != -1)
            {
                isbnTable.IsId = Convert.ToInt32(dgvIsbn.CurrentRow.Cells["ibid"].Value);
                this.btnEditIsbn.Enabled = true;
                this.btnDelIsbn.Enabled = true;
            }
            else
            {
                this.btnEditIsbn.Enabled = true;
                this.btnDelIsbn.Enabled = true;
            }
        }

        private void btnEditIsbn_Click(object sender, EventArgs e)
        {
            using (addIsbnForm isbnForm = new addIsbnForm(this))
            {
                var copyId = Convert.ToInt32(dgvIsbn.CurrentRow.Cells["ibid"].Value);
                var copy = db.IsbnTables
                .Join(
                db.ProfileTables,
                ib => ib.PId,
                p => p.PId,
                (ib, p) => new {
                    id = ib.IsId,
                    title = ib.IsTitle,
                    college = p.PCollege,
                    author = p.PFullname,
                    date_filed = ib.IsDateFiled,
                    reg_no = ib.IsIssuedNo,
                    status = ib.IsStatus,
                    apprdate = ib.IsApprDate,
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
                    isbnForm.cbAuthor.DataSource = profileTables;
                    isbnForm.cbAuthor.DisplayMember = "PFullname";
                    isbnForm.cbAuthor.ValueMember = "PId";
                    isbnForm.lblNewIsbn.Text = "EDIT ISBN";
                    isbnForm.txtboxId.Text = copy.id.ToString();
                    isbnForm.txtboxIbcollege.Text = copy.college;
                    isbnForm.txtboxIbtitle.Text = copy.title;
                    isbnForm.dptDatefiled.Value = Convert.ToDateTime(copy.date_filed);
                    isbnForm.txtboxIbregno.Text = copy.reg_no.ToString();
                    isbnForm.dptApprovaldate.Value = Convert.ToDateTime(copy.apprdate);
                    if (copy.status == "Approved")
                    {
                        isbnForm.rbApproved.Checked = true;
                    }
                    else
                    {
                        isbnForm.rbProgress.Checked = true;
                    }
                    isbnForm.btnSave.Text = "Update";
                    isbnForm.ShowDialog();
                }
            }
        }

        private void btnDelIsbn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Author Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.IsbnTables.Remove(isbnTable);
                db.SaveChanges();

                MessageBox.Show("ISBN Record Deleted Successfully!");
                populateDgv();
            }
        }
    }
}
