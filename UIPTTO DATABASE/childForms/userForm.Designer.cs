namespace UIPTTO_DATABASE.childForms
{
    partial class userForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtboxUserSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxUserSearch
            // 
            this.txtboxUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxUserSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxUserSearch.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxUserSearch.Location = new System.Drawing.Point(806, 102);
            this.txtboxUserSearch.Name = "txtboxUserSearch";
            this.txtboxUserSearch.Size = new System.Drawing.Size(235, 29);
            this.txtboxUserSearch.TabIndex = 8;
            this.txtboxUserSearch.TextChanged += new System.EventHandler(this.txtboxUserSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham Thin", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "List of Users";
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.Font = new System.Drawing.Font("Gotham Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserTitle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblUserTitle.Location = new System.Drawing.Point(12, 24);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(133, 36);
            this.lblUserTitle.TabIndex = 7;
            this.lblUserTitle.Text = "USERS";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(806, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 29);
            this.textBox2.TabIndex = 9;
            // 
            // btnDelUser
            // 
            this.btnDelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnDelUser.FlatAppearance.BorderSize = 0;
            this.btnDelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelUser.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDelUser.Image")));
            this.btnDelUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelUser.Location = new System.Drawing.Point(277, 754);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(143, 47);
            this.btnDelUser.TabIndex = 14;
            this.btnDelUser.Text = "DELETE";
            this.btnDelUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelUser.UseVisualStyleBackColor = false;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditUser.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUser.Image")));
            this.btnEditUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUser.Location = new System.Drawing.Point(147, 754);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(105, 47);
            this.btnEditUser.TabIndex = 15;
            this.btnEditUser.Text = "EDIT";
            this.btnEditUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(13, 754);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(110, 47);
            this.btnAddUser.TabIndex = 13;
            this.btnAddUser.TabStop = false;
            this.btnAddUser.Text = "NEW";
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uid,
            this.fullname,
            this.email,
            this.username,
            this.password,
            this.gender,
            this.birthday});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUsers.Location = new System.Drawing.Point(12, 156);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 29;
            this.dgvUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1090, 579);
            this.dgvUsers.TabIndex = 12;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1060, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 42);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // uid
            // 
            this.uid.DataPropertyName = "uid";
            this.uid.HeaderText = "id";
            this.uid.MinimumWidth = 6;
            this.uid.Name = "uid";
            this.uid.ReadOnly = true;
            this.uid.Visible = false;
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "Full Name";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // birthday
            // 
            this.birthday.DataPropertyName = "birthday";
            this.birthday.HeaderText = "Birthday";
            this.birthday.MinimumWidth = 6;
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 837);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.txtboxUserSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserTitle);
            this.Controls.Add(this.textBox2);
            this.Name = "userForm";
            this.Text = "userForm";
            this.Load += new System.EventHandler(this.userForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtboxUserSearch;
        private Label label2;
        private Label lblUserTitle;
        private TextBox textBox2;
        private Button btnDelUser;
        private Button btnEditUser;
        private Button btnAddUser;
        public DataGridView dgvUsers;
        public Button btnSearch;
        private DataGridViewTextBoxColumn uid;
        private DataGridViewTextBoxColumn fullname;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn birthday;
    }
}