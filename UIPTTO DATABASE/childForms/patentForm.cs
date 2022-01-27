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
    public partial class patentForm : Form
    {
        public patentForm()
        {
            InitializeComponent();
        }

        private void btnAddPatents_Click(object sender, EventArgs e)
        {
            addPatentForm addPatentForm = new addPatentForm();
            addPatentForm.ShowDialog();
        }
    }
}
