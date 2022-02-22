namespace UIPTTO_DATABASE.childForms
{
    partial class patentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patentForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtboxSearchPatents = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPatents = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnDelPatent = new System.Windows.Forms.Button();
            this.btnEditPatent = new System.Windows.Forms.Button();
            this.btnAddPatent = new System.Windows.Forms.Button();
            this.dgvPatents = new System.Windows.Forms.DataGridView();
            this.ptid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventionTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.college = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_filed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.app_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatents)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxSearchPatents
            // 
            this.txtboxSearchPatents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxSearchPatents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxSearchPatents.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxSearchPatents.Location = new System.Drawing.Point(807, 99);
            this.txtboxSearchPatents.Name = "txtboxSearchPatents";
            this.txtboxSearchPatents.Size = new System.Drawing.Size(235, 29);
            this.txtboxSearchPatents.TabIndex = 15;
            this.txtboxSearchPatents.TextChanged += new System.EventHandler(this.txtboxSearchPatents_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham Thin", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "List of Patents";
            // 
            // lblPatents
            // 
            this.lblPatents.AutoSize = true;
            this.lblPatents.Font = new System.Drawing.Font("Gotham Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPatents.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPatents.Location = new System.Drawing.Point(12, 24);
            this.lblPatents.Name = "lblPatents";
            this.lblPatents.Size = new System.Drawing.Size(183, 36);
            this.lblPatents.TabIndex = 14;
            this.lblPatents.Text = "PATENTS";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(807, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 29);
            this.textBox2.TabIndex = 16;
            // 
            // btnDelPatent
            // 
            this.btnDelPatent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelPatent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnDelPatent.FlatAppearance.BorderSize = 0;
            this.btnDelPatent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelPatent.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelPatent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelPatent.Image = ((System.Drawing.Image)(resources.GetObject("btnDelPatent.Image")));
            this.btnDelPatent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelPatent.Location = new System.Drawing.Point(278, 761);
            this.btnDelPatent.Name = "btnDelPatent";
            this.btnDelPatent.Size = new System.Drawing.Size(143, 47);
            this.btnDelPatent.TabIndex = 21;
            this.btnDelPatent.Text = "DELETE";
            this.btnDelPatent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelPatent.UseVisualStyleBackColor = false;
            this.btnDelPatent.Click += new System.EventHandler(this.btnDelPatent_Click);
            // 
            // btnEditPatent
            // 
            this.btnEditPatent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditPatent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnEditPatent.FlatAppearance.BorderSize = 0;
            this.btnEditPatent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPatent.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditPatent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditPatent.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPatent.Image")));
            this.btnEditPatent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPatent.Location = new System.Drawing.Point(148, 761);
            this.btnEditPatent.Name = "btnEditPatent";
            this.btnEditPatent.Size = new System.Drawing.Size(105, 47);
            this.btnEditPatent.TabIndex = 20;
            this.btnEditPatent.Text = "EDIT";
            this.btnEditPatent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditPatent.UseVisualStyleBackColor = false;
            this.btnEditPatent.Click += new System.EventHandler(this.btnEditPatent_Click);
            // 
            // btnAddPatent
            // 
            this.btnAddPatent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddPatent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAddPatent.FlatAppearance.BorderSize = 0;
            this.btnAddPatent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatent.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddPatent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPatent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPatent.Image")));
            this.btnAddPatent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPatent.Location = new System.Drawing.Point(14, 761);
            this.btnAddPatent.Name = "btnAddPatent";
            this.btnAddPatent.Size = new System.Drawing.Size(110, 47);
            this.btnAddPatent.TabIndex = 19;
            this.btnAddPatent.TabStop = false;
            this.btnAddPatent.Text = "NEW";
            this.btnAddPatent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddPatent.UseVisualStyleBackColor = false;
            this.btnAddPatent.Click += new System.EventHandler(this.btnAddPatent_Click_1);
            // 
            // dgvPatents
            // 
            this.dgvPatents.AllowUserToAddRows = false;
            this.dgvPatents.AllowUserToDeleteRows = false;
            this.dgvPatents.AllowUserToResizeColumns = false;
            this.dgvPatents.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPatents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.dgvPatents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatents.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvPatents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPatents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ptid,
            this.inventionTitle,
            this.college,
            this.inventor,
            this.date_filed,
            this.app_no,
            this.status});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatents.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPatents.EnableHeadersVisualStyles = false;
            this.dgvPatents.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPatents.Location = new System.Drawing.Point(14, 157);
            this.dgvPatents.MultiSelect = false;
            this.dgvPatents.Name = "dgvPatents";
            this.dgvPatents.ReadOnly = true;
            this.dgvPatents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatents.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPatents.RowHeadersVisible = false;
            this.dgvPatents.RowHeadersWidth = 51;
            this.dgvPatents.RowTemplate.Height = 29;
            this.dgvPatents.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPatents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatents.Size = new System.Drawing.Size(1090, 579);
            this.dgvPatents.TabIndex = 22;
            this.dgvPatents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatents_CellContentClick_1);
            // 
            // ptid
            // 
            this.ptid.DataPropertyName = "ptid";
            this.ptid.HeaderText = "ptid";
            this.ptid.MinimumWidth = 6;
            this.ptid.Name = "ptid";
            this.ptid.ReadOnly = true;
            this.ptid.Visible = false;
            // 
            // inventionTitle
            // 
            this.inventionTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inventionTitle.DataPropertyName = "inventionTitle";
            this.inventionTitle.HeaderText = "Name of the Invention";
            this.inventionTitle.MinimumWidth = 6;
            this.inventionTitle.Name = "inventionTitle";
            this.inventionTitle.ReadOnly = true;
            // 
            // college
            // 
            this.college.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.college.DataPropertyName = "college";
            this.college.HeaderText = "College/Unit";
            this.college.MinimumWidth = 6;
            this.college.Name = "college";
            this.college.ReadOnly = true;
            this.college.Width = 218;
            // 
            // inventor
            // 
            this.inventor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.inventor.DataPropertyName = "inventor";
            this.inventor.HeaderText = "Inventor";
            this.inventor.MinimumWidth = 6;
            this.inventor.Name = "inventor";
            this.inventor.ReadOnly = true;
            this.inventor.Width = 157;
            // 
            // date_filed
            // 
            this.date_filed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date_filed.DataPropertyName = "date_filed";
            this.date_filed.HeaderText = "Date filed";
            this.date_filed.MinimumWidth = 6;
            this.date_filed.Name = "date_filed";
            this.date_filed.ReadOnly = true;
            this.date_filed.Width = 161;
            // 
            // app_no
            // 
            this.app_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.app_no.DataPropertyName = "app_no";
            this.app_no.HeaderText = "Application No.";
            this.app_no.MinimumWidth = 6;
            this.app_no.Name = "app_no";
            this.app_no.ReadOnly = true;
            this.app_no.Width = 233;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 129;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1060, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 42);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // patentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 837);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvPatents);
            this.Controls.Add(this.btnDelPatent);
            this.Controls.Add(this.btnEditPatent);
            this.Controls.Add(this.btnAddPatent);
            this.Controls.Add(this.txtboxSearchPatents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPatents);
            this.Controls.Add(this.textBox2);
            this.Name = "patentForm";
            this.Text = "patentForm";
            this.Load += new System.EventHandler(this.patentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtboxSearchPatents;
        private Label label2;
        private Label lblPatents;
        private TextBox textBox2;
        private Button btnDelPatent;
        private Button btnEditPatent;
        private Button btnAddPatent;
        public DataGridView dgvPatents;
        private DataGridViewTextBoxColumn ptid;
        private DataGridViewTextBoxColumn inventionTitle;
        private DataGridViewTextBoxColumn college;
        private DataGridViewTextBoxColumn inventor;
        private DataGridViewTextBoxColumn date_filed;
        private DataGridViewTextBoxColumn app_no;
        private DataGridViewTextBoxColumn status;
        public Button btnSearch;
    }
}