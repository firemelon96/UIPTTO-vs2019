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
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            addUserForm addUserForm = new addUserForm();
            addUserForm.ShowDialog(); 
        }
    }
}
