using System;
using System.Windows.Forms;
using UIPTTO_DATABASE.childForms;

namespace UIPTTO_DATABASE
{
    public partial class mainForm : Form
    {
        //fields
        private Form currentChildForm;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public mainForm()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
        }
        //childform setting
        private void openChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new dashBoardForm());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            openChildForm(new profileForm());
        }

        private void btnCopyright_Click(object sender, EventArgs e)
        {
            openChildForm(new copyrightForm());
        }

        private void btnPatents_Click(object sender, EventArgs e)
        {
            openChildForm(new patentForm());
        }

        private void btnISSN_Click(object sender, EventArgs e)
        {
            openChildForm(new issnForm());
        }

        private void btnISBN_Click(object sender, EventArgs e)
        {
            openChildForm(new isbnForm());
        }

        private void btnTrademark_Click(object sender, EventArgs e)
        {
            openChildForm(new trademarkForm());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            openChildForm(new reportForm());
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            openChildForm(new backupForm());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new userForm());
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}