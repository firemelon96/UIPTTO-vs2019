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
    public partial class addIssnForm : Form
    {
        private mainDBContext db = new mainDBContext();
        IssnTable issn = new IssnTable();

        issnForm iform;
        public addIssnForm(issnForm iss)
        {
            InitializeComponent();
            this.iform = iss;
        }

        private void rbApproved_CheckedChanged(object sender, EventArgs e)
        {
            dptApprovaldate.Enabled = rbApproved.Checked;
        }

        private void cbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuthor.SelectedItem != null)
            {
                int id;
                bool result = int.TryParse(cbAuthor.SelectedValue.ToString(), out id);
                if (result)
                {
                    var profile_id = db.ProfileTables
                    .Where(p => p.PId == id)
                    .FirstOrDefault<ProfileTable>();
                    if (profile_id != null)
                    {
                        txtboxIcollege.Text = profile_id.PCollege;
                    }
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            issn.IId = Convert.ToInt32(txtboxId.Text);
            issn.ITitle = txtboxItitle.Text;
            issn.IDateFiled = dptDatefiled.Value;
            issn.IIssuedNo = Convert.ToInt32(txtboxIregno.Text);
            issn.IApprDate = dptApprovaldate.Value;
            issn.PId = Convert.ToInt32(cbAuthor.SelectedValue);
            if (rbApproved.Checked)
            {
                issn.IStatus = "Approved";
                issn.IApprDate = dptApprovaldate.Value;
            }
            else
            {
                issn.IStatus = "On progress";
            }
            if (issn.IId == 0)
            {
                db.IssnTables.Add(issn);
                MessageBox.Show("Added Copyright successfully");
            }
            else
            {
                db.Entry(issn).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                MessageBox.Show("Updated Copyright successfully");
            }

            db.SaveChanges();
            iform.populateDgv();
            this.Close();
        }
    }
}
