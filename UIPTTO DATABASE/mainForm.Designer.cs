namespace UIPTTO_DATABASE
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pnlSideNavigation = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnTrademark = new System.Windows.Forms.Button();
            this.btnISBN = new System.Windows.Forms.Button();
            this.btnISSN = new System.Windows.Forms.Button();
            this.btnPatents = new System.Windows.Forms.Button();
            this.btnCopyright = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pbUIPTTOlogo = new System.Windows.Forms.PictureBox();
            this.pnlMainTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlSideNavigation.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUIPTTOlogo)).BeginInit();
            this.pnlMainTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideNavigation
            // 
            this.pnlSideNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlSideNavigation.Controls.Add(this.btnUser);
            this.pnlSideNavigation.Controls.Add(this.btnBackup);
            this.pnlSideNavigation.Controls.Add(this.btnReport);
            this.pnlSideNavigation.Controls.Add(this.btnTrademark);
            this.pnlSideNavigation.Controls.Add(this.btnISBN);
            this.pnlSideNavigation.Controls.Add(this.btnISSN);
            this.pnlSideNavigation.Controls.Add(this.btnPatents);
            this.pnlSideNavigation.Controls.Add(this.btnCopyright);
            this.pnlSideNavigation.Controls.Add(this.btnProfile);
            this.pnlSideNavigation.Controls.Add(this.btnDashboard);
            this.pnlSideNavigation.Controls.Add(this.pnlLogo);
            this.pnlSideNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlSideNavigation.Name = "pnlSideNavigation";
            this.pnlSideNavigation.Size = new System.Drawing.Size(280, 913);
            this.pnlSideNavigation.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUser.Image = global::UIPTTO_DATABASE.Properties.Resources.setting2;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 856);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(280, 57);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "USERS";
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.Image")));
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.Location = new System.Drawing.Point(0, 607);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBackup.Size = new System.Drawing.Size(280, 57);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "BACK UP";
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Image = global::UIPTTO_DATABASE.Properties.Resources.report2;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 550);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(280, 57);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "REPORTS";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnTrademark
            // 
            this.btnTrademark.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrademark.FlatAppearance.BorderSize = 0;
            this.btnTrademark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrademark.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTrademark.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrademark.Image = global::UIPTTO_DATABASE.Properties.Resources.trademark2;
            this.btnTrademark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrademark.Location = new System.Drawing.Point(0, 493);
            this.btnTrademark.Name = "btnTrademark";
            this.btnTrademark.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnTrademark.Size = new System.Drawing.Size(280, 57);
            this.btnTrademark.TabIndex = 1;
            this.btnTrademark.Text = "TRADEMARKS";
            this.btnTrademark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrademark.UseVisualStyleBackColor = true;
            this.btnTrademark.Click += new System.EventHandler(this.btnTrademark_Click);
            // 
            // btnISBN
            // 
            this.btnISBN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnISBN.FlatAppearance.BorderSize = 0;
            this.btnISBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnISBN.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnISBN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnISBN.Image = global::UIPTTO_DATABASE.Properties.Resources.open_book2;
            this.btnISBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnISBN.Location = new System.Drawing.Point(0, 436);
            this.btnISBN.Name = "btnISBN";
            this.btnISBN.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnISBN.Size = new System.Drawing.Size(280, 57);
            this.btnISBN.TabIndex = 1;
            this.btnISBN.Text = "ISBN";
            this.btnISBN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnISBN.UseVisualStyleBackColor = true;
            this.btnISBN.Click += new System.EventHandler(this.btnISBN_Click);
            // 
            // btnISSN
            // 
            this.btnISSN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnISSN.FlatAppearance.BorderSize = 0;
            this.btnISSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnISSN.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnISSN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnISSN.Image = global::UIPTTO_DATABASE.Properties.Resources.bar_code2;
            this.btnISSN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnISSN.Location = new System.Drawing.Point(0, 379);
            this.btnISSN.Name = "btnISSN";
            this.btnISSN.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnISSN.Size = new System.Drawing.Size(280, 57);
            this.btnISSN.TabIndex = 1;
            this.btnISSN.Text = "ISSN";
            this.btnISSN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnISSN.UseVisualStyleBackColor = true;
            this.btnISSN.Click += new System.EventHandler(this.btnISSN_Click);
            // 
            // btnPatents
            // 
            this.btnPatents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatents.FlatAppearance.BorderSize = 0;
            this.btnPatents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatents.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPatents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPatents.Image = global::UIPTTO_DATABASE.Properties.Resources.patent2;
            this.btnPatents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatents.Location = new System.Drawing.Point(0, 322);
            this.btnPatents.Name = "btnPatents";
            this.btnPatents.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPatents.Size = new System.Drawing.Size(280, 57);
            this.btnPatents.TabIndex = 1;
            this.btnPatents.Text = "PATENTS";
            this.btnPatents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatents.UseVisualStyleBackColor = true;
            this.btnPatents.Click += new System.EventHandler(this.btnPatents_Click);
            // 
            // btnCopyright
            // 
            this.btnCopyright.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCopyright.FlatAppearance.BorderSize = 0;
            this.btnCopyright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyright.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCopyright.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCopyright.Image = global::UIPTTO_DATABASE.Properties.Resources.copyright2;
            this.btnCopyright.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyright.Location = new System.Drawing.Point(0, 265);
            this.btnCopyright.Name = "btnCopyright";
            this.btnCopyright.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCopyright.Size = new System.Drawing.Size(280, 57);
            this.btnCopyright.TabIndex = 1;
            this.btnCopyright.Text = "COPYRIGHTS";
            this.btnCopyright.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCopyright.UseVisualStyleBackColor = true;
            this.btnCopyright.Click += new System.EventHandler(this.btnCopyright_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 208);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(280, 57);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.Image = global::UIPTTO_DATABASE.Properties.Resources.dashboard2;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 151);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(280, 57);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlLogo.Controls.Add(this.pbUIPTTOlogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(280, 151);
            this.pnlLogo.TabIndex = 0;
            // 
            // pbUIPTTOlogo
            // 
            this.pbUIPTTOlogo.BackColor = System.Drawing.Color.White;
            this.pbUIPTTOlogo.Image = global::UIPTTO_DATABASE.Properties.Resources._254553707_137563841925666_2808408810307729993_n;
            this.pbUIPTTOlogo.Location = new System.Drawing.Point(104, 22);
            this.pbUIPTTOlogo.Name = "pbUIPTTOlogo";
            this.pbUIPTTOlogo.Size = new System.Drawing.Size(65, 88);
            this.pbUIPTTOlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUIPTTOlogo.TabIndex = 2;
            this.pbUIPTTOlogo.TabStop = false;
            // 
            // pnlMainTitleBar
            // 
            this.pnlMainTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlMainTitleBar.Controls.Add(this.label1);
            this.pnlMainTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainTitleBar.Location = new System.Drawing.Point(280, 0);
            this.pnlMainTitleBar.Name = "pnlMainTitleBar";
            this.pnlMainTitleBar.Size = new System.Drawing.Size(1132, 61);
            this.pnlMainTitleBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(876, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello, USER";
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(280, 61);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1132, 852);
            this.panelBody.TabIndex = 2;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(280, 889);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1132, 24);
            this.pnlFooter.TabIndex = 3;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 913);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.pnlMainTitleBar);
            this.Controls.Add(this.pnlSideNavigation);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.pnlSideNavigation.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUIPTTOlogo)).EndInit();
            this.pnlMainTitleBar.ResumeLayout(false);
            this.pnlMainTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlSideNavigation;
        private Panel pnlLogo;
        private Panel pnlMainTitleBar;
        private Button btnDashboard;
        private PictureBox pbUIPTTOlogo;
        private Button btnUser;
        private Button btnBackup;
        private Button btnReport;
        private Button btnTrademark;
        private Button btnISBN;
        private Button btnISSN;
        private Button btnPatents;
        private Button btnCopyright;
        private Button btnProfile;
        private Label label1;
        private Panel panelBody;
        private Panel pnlFooter;
    }
}