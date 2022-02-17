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
    public partial class addPatentForm : Form
    {
        private mainDBContext db = new mainDBContext();
        PatentTable patent = new PatentTable();

        patentForm pform;
        public addPatentForm(patentForm pf)
        {
            InitializeComponent();
            this.pform = pf;
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
                        txtboxPcollege.Text = profile_id.PCollege;
                    }
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            patent.PtId = Convert.ToInt32(txtboxId.Text);
            patent.PtTitle = txtboxPtitle.Text;
            patent.PtDateFiled = dptDatefiled.Value;
            patent.PtRegNo = Convert.ToInt32(txtboxPregno.Text);
            patent.PrApprDate = dptApprovaldate.Value;
            patent.PId = Convert.ToInt32(cbAuthor.SelectedValue);
            if (rbApproved.Checked)
            {
                patent.PtStatus = "Approved";
                patent.PrApprDate = dptApprovaldate.Value;
            }
            else
            {
                patent.PtStatus = "On progress";
            }
            if (patent.PtId == 0)
            {
                db.PatentTables.Add(patent);
                MessageBox.Show("Added Patent record successfully");
            }
            else
            {
                db.Entry(patent).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                MessageBox.Show("Updated Patent record successfully");
            }

            db.SaveChanges();
            pform.populatepatentDgv();
            this.Close();
        }

        private void rbApproved_CheckedChanged(object sender, EventArgs e)
        {
            dptApprovaldate.Enabled = rbApproved.Checked;
        }
    }
}
