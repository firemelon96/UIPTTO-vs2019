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

namespace UIPTTO_DATABASE.childForms
{
    public partial class profileForm : Form
    {
        private mainDBContext db = new mainDBContext();
        public profileForm()
        {
            InitializeComponent();

            this.btnEditAuthor.Enabled = false;
            this.btnDelAuthor.Enabled = false;
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            using (addAuthorInventorForm addAuthorInventorForm = new addAuthorInventorForm(this))
            {
                if (addAuthorInventorForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void profileForm_Load(object sender, EventArgs e)
        {
            populateDgv();
            //dgvProfile.DataSource = db.ProfileTables.ToList();
        }

        public void populateDgv()
        {
            var authors = from p in db.ProfileTables
                          select new {
                              id = p.PId,
                              fullname = p.PFname + " " + p.PLname,
                              email = p.PEmail,
                              college = p.PCollege,
                              birthday = p.PDob,
                              gender = p.PGender
                          };
            dgvProfile.DataSource = authors.ToList();
        }

        private void dgvProfile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvProfile.SelectedRows.Count > 0)
            {
                this.btnEditAuthor.Enabled = true;
                this.btnDelAuthor.Enabled = true;
            }
            else
            {
                this.btnEditAuthor.Enabled = false;
                this.btnDelAuthor.Enabled = false;
            }
        }

        private void btnEditAuthor_Click(object sender, EventArgs e)
        {

        }

        private void btnDelAuthor_Click(object sender, EventArgs e)
        {

        }
    }
}
