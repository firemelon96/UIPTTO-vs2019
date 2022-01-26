using System;
using System.Windows.Forms;
using UIPTTO_DATABASE.childForms;

namespace UIPTTO_DATABASE
{
    public partial class mainForm : Form
    {
        //fields
        private Form currentChildForm;
        public mainForm()
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
    }
}