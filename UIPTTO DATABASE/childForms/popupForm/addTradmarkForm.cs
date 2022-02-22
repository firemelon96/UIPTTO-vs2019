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
using UIPTTO_DATABASE.childForms;

namespace UIPTTO_DATABASE.childForms.popupForm
{
    public partial class addTradmarkForm : Form
    {
        private mainDBContext db = new mainDBContext();
        TrademarkTable tradmarkTable = new TrademarkTable();

        trademarkForm tform;
        public addTradmarkForm(trademarkForm tr)
        {
            InitializeComponent();
            this.tform = tr;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tradmarkTable.TId = Convert.ToInt32(txtboxId.Text);
            tradmarkTable.TTitle = txtboxTtitle.Text;
            tradmarkTable.TRegNo = Convert.ToInt32(txtTregno.Text);
            tradmarkTable.TDateFiled = dptDatefiled.Value;
            tradmarkTable.TApprDate = dtpTappr.Value;
            tradmarkTable.TDaufiling = dtpTnxt.Value;
            tradmarkTable.TExpiryDate = dtpTCOR.Value;
            if (rbApproved.Checked)
            {
                tradmarkTable.TStatus = "Approved";
            }
            else
            {
                tradmarkTable.TStatus = "On Progress";
            }

            //kapag naconvert na sa integer, iccheck ko. if(profileTable.PId == 0)
            if (tradmarkTable.TId == 0)
            {
                db.TrademarkTables.Add(tradmarkTable);

                MessageBox.Show("Trademark Record added Successfully!");
            }
            else
            {
                db.Entry(tradmarkTable).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                MessageBox.Show("Upadted Trademark Record Successfully");

            }
            db.SaveChanges();
            this.Close();
            tform.populateDgv();
        }


        private void rbApproved_CheckedChanged(object sender, EventArgs e)
        {
            //rbApproved.Checked = dtpTappr.Enabled;
            if (rbApproved.Checked)
            {
                dtpTappr.Enabled = true;
                dtpTCOR.Enabled = true;
                dtpTnxt.Enabled = true;
            }
            else
            {
                dtpTappr.Enabled = false;
                dtpTCOR.Enabled = false;
                dtpTnxt.Enabled = false;
            }
        }
    }
}
