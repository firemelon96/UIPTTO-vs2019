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

namespace UIPTTO_DATABASE.childForms
{
    public partial class issnForm : Form
    {
        public issnForm()
        {
            InitializeComponent();
        }

        private void btnAddISSN_Click(object sender, EventArgs e)
        {
            addIssnForm addIssnForm = new addIssnForm();
            addIssnForm.ShowDialog();
        }
    }
}
