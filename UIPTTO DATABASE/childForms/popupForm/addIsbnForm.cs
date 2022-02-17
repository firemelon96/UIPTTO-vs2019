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
    public partial class addIsbnForm : Form
    {
        private mainDBContext db = new mainDBContext();
        IsbnTable isbn = new IsbnTable();

        isbnForm ibform;
        public addIsbnForm(isbnForm ib)
        {
            InitializeComponent();
            ibform = ib;
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
                        txtboxIbcollege.Text = profile_id.PCollege;
                    }
                }

            }
        }

        private void rbApproved_CheckedChanged(object sender, EventArgs e)
        {
            dptApprovaldate.Enabled = rbApproved.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            isbn.IsId = Convert.ToInt32(txtboxId.Text);
            isbn.IsTitle = txtboxIbtitle.Text;
            isbn.IsDateFiled = dptDatefiled.Value;
            isbn.IsIssuedNo = Convert.ToInt32(txtboxIbregno.Text);
            isbn.IsApprDate = dptApprovaldate.Value;
            isbn.PId = Convert.ToInt32(cbAuthor.SelectedValue);
            if (rbApproved.Checked)
            {
                isbn.IsStatus = "Approved";
                isbn.IsApprDate = dptApprovaldate.Value;
            }
            else
            {
                isbn.IsStatus = "On progress";
            }
            if (isbn.IsId == 0)
            {
                db.IsbnTables.Add(isbn);
                MessageBox.Show("Added Copyright successfully");
            }
            else
            {
                db.Entry(isbn).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                MessageBox.Show("Updated ISBN successfully");
            }

            db.SaveChanges();
            ibform.populateDgv();
            this.Close();
        }
    }
}
