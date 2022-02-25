using System;
using System.Windows.Forms;
using UIPTTO_DATABASE.childForms;
using UIPTTO_DATABASE.Models;
using UIPTTO_DATABASE.loginRegister;

namespace UIPTTO_DATABASE
{
    public partial class mainForm : Form
    {
        loginForm login = new loginForm();
        private mainDBContext db = new mainDBContext();
        //fields
        private Form currentChildForm;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public mainForm()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            //getloggedin();
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(172, 24, 24);
        }

        public void getusertype()
        {
            if (lbltype.Text == "user")
            {
                btnBackup.Visible = false; 
            }
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
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(172, 24, 24);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            openChildForm(new profileForm());
            pnlNav.Height = btnProfile.Height;
            pnlNav.Top = btnProfile.Top;
            pnlNav.Left = btnProfile.Left;
            btnProfile.BackColor = Color.FromArgb(172, 24, 24);
        }

        private void btnCopyright_Click(object sender, EventArgs e)
        {
            openChildForm(new copyrightForm());
            pnlNav.Height = btnCopyright.Height;
            pnlNav.Top = btnCopyright.Top;
            pnlNav.Left = btnCopyright.Left;
            btnCopyright.BackColor = Color.FromArgb(172, 24, 24);
        }

        private void btnPatents_Click(object sender, EventArgs e)
        {
            openChildForm(new patentForm());
            pnlNav.Height = btnPatents.Height;
            pnlNav.Top = btnPatents.Top;
            pnlNav.Left = btnPatents.Left;
            btnPatents.BackColor = Color.FromArgb(172, 24, 24);
        }

        private void btnISSN_Click(object sender, EventArgs e)
        {
            openChildForm(new issnForm());
            pnlNav.Height = btnISSN.Height;
            pnlNav.Top = btnISSN.Top;
            pnlNav.Left = btnISSN.Left;
            btnISSN.BackColor = Color.FromArgb(172, 24, 24);
        }

        private void btnISBN_Click(object sender, EventArgs e)
        {
            openChildForm(new isbnForm());
            pnlNav.Height = btnISBN.Height;
            pnlNav.Top = btnISBN.Top;
            pnlNav.Left = btnISBN.Left;
            btnISBN.BackColor = Color.FromArgb(172, 24, 24);
        }

        private void btnTrademark_Click(object sender, EventArgs e)
        {
            openChildForm(new trademarkForm());
            pnlNav.Height = btnTrademark.Height;
            pnlNav.Top = btnTrademark.Top;
            pnlNav.Left = btnTrademark.Left;
            btnTrademark.BackColor = Color.FromArgb(172, 24, 24);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            openChildForm(new reportForm());
            pnlNav.Height = btnReport.Height;
            pnlNav.Top = btnReport.Top;
            pnlNav.Left = btnReport.Left;
            btnReport.BackColor = Color.FromArgb(172, 24, 24);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            openChildForm(new backupForm());
            pnlNav.Height = btnBackup.Height;
            pnlNav.Top = btnBackup.Top;
            pnlNav.Left = btnBackup.Left;
            btnBackup.BackColor = Color.FromArgb(172, 24, 24);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new userForm());
            pnlNav.Height = btnUser.Height;
            pnlNav.Top = btnUser.Top;
            pnlNav.Left = btnUser.Left;
            btnUser.BackColor = Color.FromArgb(172, 24, 24);
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        public void getloggedin()
        {
            
            var user = db.UserTables.Where(u => u.UUsername == login.txtboxUsername.Text
            && u.UPassword == login.txtboxPassword.Text).Select(u => new {
                id = u.UId
            });
            if (user != null)
            {
                lblUsername.Text = "hi user"; // user.UUsername;
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //lblUsername.Text = 
            openChildForm(new dashBoardForm());
            //lblUsername.Text = "changeee";
            getusertype();
            
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(121,0,0);
        }

        private void btnProfile_Leave(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(121, 0, 0);
        }

        private void btnCopyright_Leave(object sender, EventArgs e)
        {
            btnCopyright.BackColor = Color.FromArgb(121, 0, 0);
        }

        private void btnPatents_Leave(object sender, EventArgs e)
        {
            btnPatents.BackColor = Color.FromArgb(121, 0, 0);
        }

        private void btnISSN_Leave(object sender, EventArgs e)
        {
            btnISSN.BackColor = Color.FromArgb(121, 0, 0);
        }

        private void btnISBN_Leave(object sender, EventArgs e)
        {
            btnISBN.BackColor = Color.FromArgb(121, 0, 0);
        }

        private void btnTrademark_Leave(object sender, EventArgs e)
        {
            btnTrademark.BackColor = Color.FromArgb(121, 0, 0);
        }

        private void btnReport_Leave(object sender, EventArgs e)
        {
            btnReport.BackColor = Color.FromArgb(121, 0, 0);
        }

        private void btnBackup_Leave(object sender, EventArgs e)
        {
            btnBackup.BackColor = Color.FromArgb(121, 0, 0);
        }

        private void btnUser_Leave(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.FromArgb(121, 0, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlLogo.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm login = new loginForm();
            login.ShowDialog();
        }
    }
}