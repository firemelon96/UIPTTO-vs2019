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
    public partial class trademarkForm : Form
    {
        private mainDBContext db = new mainDBContext();
        TrademarkTable trademark = new TrademarkTable();
        public trademarkForm()
        {
            InitializeComponent();
            this.btnEditTrademark.Enabled = false;
            this.btnDelTrademark.Enabled = false;
        }

        private void btnAddTrademark_Click(object sender, EventArgs e)
        {
            using (addTradmarkForm addTradmark = new addTradmarkForm(this))
            {
                //everytime na magcclick ako net, iseset ko ang text value ng form sa 0
                addTradmark.txtboxId.Text = "0";
                addTradmark.ShowDialog();

            }
        }

        public void populateDgv()
        {
            var trademark = from t in db.TrademarkTables
                          select new {
                              tid = t.TId,
                              title = t.TTitle ,
                              reg_no = t.TRegNo,
                              date_filed = t.TDateFiled,
                              appr_date = t.TApprDate,
                              status = t.tStatus,
                              nxt_filing = t.TDaufiling,
                              cor_expe = t.TExpiryDate
                          };
            dgvTrademark.DataSource = trademark.ToList();

        }

        private void trademarkForm_Load(object sender, EventArgs e)
        {
            populateDgv();
        }

        private void btnEditTrademark_Click(object sender, EventArgs e)
        {
            using (addTradmarkForm addTradmark = new addTradmarkForm(this))
            {

                var tradeid = Convert.ToInt32(dgvTrademark.CurrentRow.Cells["tid"].Value);
                var prof = db.TrademarkTables.AsNoTracking().Where(t => t.TId == tradeid).FirstOrDefault();
                if (prof != null)
                {
                    //ilalagay ko sa txtboxId ang value ng mareretrieve ko na id mula sa database.
                    addTradmark.lblNewTrademark.Text = "EDIT TRADEMARK";
                    addTradmark.txtboxId.Text = prof.TId.ToString();
                    addTradmark.txtTregno.Text = prof.TRegNo.ToString();
                    addTradmark.txtboxTtitle.Text = prof.TTitle;
                    addTradmark.dptDatefiled.Value = Convert.ToDateTime( prof.TDateFiled);
                    addTradmark.dtpTappr.Value = Convert.ToDateTime( prof.TApprDate);
                    addTradmark.dtpTnxt.Value = Convert.ToDateTime( prof.TDaufiling);
                    addTradmark.dtpTCOR.Value = Convert.ToDateTime(prof.TExpiryDate);
                    if (prof.tStatus == "Approved")
                    {
                        addTradmark.rbApproved.Checked = true;
                    }
                    else
                    {
                        addTradmark.rbProgress.Checked = true;
                    }
                    addTradmark.btnSave.Text = "Update";
                    addTradmark.ShowDialog();

                }
            }
        }

        private void btnDelTrademark_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Author Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.TrademarkTables.Remove(trademark);
                db.SaveChanges();

                MessageBox.Show("Trademark Record Deleted Successfully!");
                populateDgv();
            }
        }

        private void dgvTrademark_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTrademark.CurrentRow.Index != -1)
            {
                trademark.TId = Convert.ToInt32(dgvTrademark.CurrentRow.Cells["tid"].Value);
                this.btnEditTrademark.Enabled = true;
                this.btnDelTrademark.Enabled = true;
            }
            else
            {
                this.btnEditTrademark.Enabled = false;
                this.btnDelTrademark.Enabled = false;
            }
        }
    }
}
