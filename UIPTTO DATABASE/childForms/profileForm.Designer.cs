namespace UIPTTO_DATABASE.childForms
{
    partial class profileForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profileForm));
            this.lblProfileTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxSearchProfile = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvProfile = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.college = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchProfile = new System.Windows.Forms.Label();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnEditAuthor = new System.Windows.Forms.Button();
            this.btnDelAuthor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfileTitle
            // 
            this.lblProfileTitle.AutoSize = true;
            this.lblProfileTitle.Font = new System.Drawing.Font("Gotham Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfileTitle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblProfileTitle.Location = new System.Drawing.Point(12, 26);
            this.lblProfileTitle.Name = "lblProfileTitle";
            this.lblProfileTitle.Size = new System.Drawing.Size(169, 36);
            this.lblProfileTitle.TabIndex = 1;
            this.lblProfileTitle.Text = "PROFILE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham Thin", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "List of Authors/Inventors";
            // 
            // txtboxSearchProfile
            // 
            this.txtboxSearchProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxSearchProfile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxSearchProfile.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxSearchProfile.Location = new System.Drawing.Point(867, 101);
            this.txtboxSearchProfile.Name = "txtboxSearchProfile";
            this.txtboxSearchProfile.Size = new System.Drawing.Size(235, 29);
            this.txtboxSearchProfile.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(867, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 29);
            this.textBox2.TabIndex = 2;
            // 
            // dgvProfile
            // 
            this.dgvProfile.AllowUserToAddRows = false;
            this.dgvProfile.AllowUserToDeleteRows = false;
            this.dgvProfile.AllowUserToResizeColumns = false;
            this.dgvProfile.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfile.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProfile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.dgvProfile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProfile.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvProfile.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullname,
            this.email,
            this.college,
            this.birthday,
            this.gender});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfile.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProfile.EnableHeadersVisualStyles = false;
            this.dgvProfile.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProfile.Location = new System.Drawing.Point(12, 154);
            this.dgvProfile.MultiSelect = false;
            this.dgvProfile.Name = "dgvProfile";
            this.dgvProfile.ReadOnly = true;
            this.dgvProfile.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfile.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProfile.RowHeadersVisible = false;
            this.dgvProfile.RowHeadersWidth = 51;
            this.dgvProfile.RowTemplate.Height = 29;
            this.dgvProfile.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProfile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfile.Size = new System.Drawing.Size(1090, 579);
            this.dgvProfile.TabIndex = 3;
            this.dgvProfile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfile_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
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
            // college
            // 
            this.college.DataPropertyName = "college";
            this.college.HeaderText = "College/Unit";
            this.college.MinimumWidth = 6;
            this.college.Name = "college";
            this.college.ReadOnly = true;
            // 
            // birthday
            // 
            this.birthday.DataPropertyName = "birthday";
            this.birthday.HeaderText = "Birthday";
            this.birthday.MinimumWidth = 6;
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // lblSearchProfile
            // 
            this.lblSearchProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchProfile.AutoSize = true;
            this.lblSearchProfile.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearchProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearchProfile.Location = new System.Drawing.Point(722, 109);
            this.lblSearchProfile.Name = "lblSearchProfile";
            this.lblSearchProfile.Size = new System.Drawing.Size(135, 31);
            this.lblSearchProfile.TabIndex = 4;
            this.lblSearchProfile.Text = "SEARCH";
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAddAuthor.FlatAppearance.BorderSize = 0;
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthor.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAuthor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddAuthor.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAuthor.Image")));
            this.btnAddAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAuthor.Location = new System.Drawing.Point(13, 752);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(110, 47);
            this.btnAddAuthor.TabIndex = 5;
            this.btnAddAuthor.TabStop = false;
            this.btnAddAuthor.Text = "NEW";
            this.btnAddAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnEditAuthor
            // 
            this.btnEditAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnEditAuthor.FlatAppearance.BorderSize = 0;
            this.btnEditAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAuthor.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditAuthor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditAuthor.Image = ((System.Drawing.Image)(resources.GetObject("btnEditAuthor.Image")));
            this.btnEditAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAuthor.Location = new System.Drawing.Point(147, 752);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.btnEditAuthor.Size = new System.Drawing.Size(105, 47);
            this.btnEditAuthor.TabIndex = 6;
            this.btnEditAuthor.Text = "EDIT";
            this.btnEditAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditAuthor.UseVisualStyleBackColor = false;
            this.btnEditAuthor.Click += new System.EventHandler(this.btnEditAuthor_Click);
            // 
            // btnDelAuthor
            // 
            this.btnDelAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnDelAuthor.FlatAppearance.BorderSize = 0;
            this.btnDelAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelAuthor.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelAuthor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelAuthor.Image = ((System.Drawing.Image)(resources.GetObject("btnDelAuthor.Image")));
            this.btnDelAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelAuthor.Location = new System.Drawing.Point(277, 752);
            this.btnDelAuthor.Name = "btnDelAuthor";
            this.btnDelAuthor.Size = new System.Drawing.Size(143, 47);
            this.btnDelAuthor.TabIndex = 6;
            this.btnDelAuthor.Text = "DELETE";
            this.btnDelAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelAuthor.UseVisualStyleBackColor = false;
            this.btnDelAuthor.Click += new System.EventHandler(this.btnDelAuthor_Click);
            // 
            // profileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 837);
            this.Controls.Add(this.btnDelAuthor);
            this.Controls.Add(this.btnEditAuthor);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.lblSearchProfile);
            this.Controls.Add(this.dgvProfile);
            this.Controls.Add(this.txtboxSearchProfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProfileTitle);
            this.Controls.Add(this.textBox2);
            this.Name = "profileForm";
            this.Text = "profileForm";
            this.Load += new System.EventHandler(this.profileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProfileTitle;
        private Label label2;
        private TextBox txtboxSearchProfile;
        private TextBox textBox2;
        private Label lblSearchProfile;
        private Button btnAddAuthor;
        public DataGridView dgvProfile;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fullname;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn college;
        private DataGridViewTextBoxColumn birthday;
        private DataGridViewTextBoxColumn gender;
        private Button btnEditAuthor;
        private Button btnDelAuthor;
    }
}