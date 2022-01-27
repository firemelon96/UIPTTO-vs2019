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
    public partial class copyrightForm : Form
    {
        public copyrightForm()
        {
            InitializeComponent();
        }

        private void btnAddCopyright_Click(object sender, EventArgs e)
        {
            addCopyrightForm addCopyrightForm = new addCopyrightForm();
            addCopyrightForm.ShowDialog();
        }
    }
}
