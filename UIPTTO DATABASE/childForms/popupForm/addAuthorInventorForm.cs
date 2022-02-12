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
    public partial class addAuthorInventorForm : Form
    {
        
        private mainDBContext db = new mainDBContext();
        ProfileTable profileTable = new ProfileTable();

        profileForm pform;
        public addAuthorInventorForm(profileForm pf)
        {
            InitializeComponent();
            this.pform = pf;
        }

        private void addAuthorInventorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //kunin ko lang ang id ng nasa form, hindi ang id ng selected na row, kasi ang formload ay auto select sa row.
            //profileTable.PId = Convert.ToInt32(lblID);
            //find id where the
            //profileTable.PId = Convert.ToInt32(pform.dgvProfile.CurrentRow.Cells["id"].Value);
            //profileTable.PId = Convert.ToInt32(pform.dgvProfile.CurrentRow.Cells["id"].Value);
            //
            //maglalagay ako ulit ng hidden textbox kong saan ilalagay ko ang value mula sa btnedit at btnadd at icoconvvert sa integer
            profileTable.PId = Convert.ToInt32(txtboxId.Text);
            profileTable.PFname = txtboxFirstName.Text.Trim();
            profileTable.PLname = txtboxLastName.Text.Trim();
            profileTable.PEmail = txtboxEmail.Text.Trim();
            profileTable.PCollege = txtboxCollege.Text.Trim();
            
            if (rbMale.Checked)
            {
                profileTable.PGender = "male";
            }
            else
            {
                profileTable.PGender = "female";
            }
            profileTable.PDob = dtpDOB.Value;
            
            //kapag naconvert na sa integer, iccheck ko. if(profileTable.PId == 0)
            if (profileTable.PId == 0)
            {
                db.ProfileTables.Add(profileTable);
                
                MessageBox.Show("Author Profile added Successfully!");
            }
            else
            {                
                db.Entry(profileTable).State = Microsoft.EntityFrameworkCore.EntityState.Modified;                
                MessageBox.Show("Upadted Profile Successfully");
                
            }
            db.SaveChanges();
            this.Close();
            pform.populateDgv();
        }
    }
}
