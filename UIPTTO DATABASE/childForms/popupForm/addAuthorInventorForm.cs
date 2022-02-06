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
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
