using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPTTO_DATABASE.childForms.popupForm
{
    public partial class addCopyrightForm : Form
    {
        public addCopyrightForm()
        {
            InitializeComponent();
        }

        private void rbApproved_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateApproved.Enabled = rbApproved.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
