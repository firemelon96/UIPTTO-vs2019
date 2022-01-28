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
    public partial class isbnForm : Form
    {
        public isbnForm()
        {
            InitializeComponent();
        }

        private void btnAddISBN_Click(object sender, EventArgs e)
        {
            addIsbnForm addIsbnForm = new addIsbnForm();
            addIsbnForm.ShowDialog();
        }
    }
}
