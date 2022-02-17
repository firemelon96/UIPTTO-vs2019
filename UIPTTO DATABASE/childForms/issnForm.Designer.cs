namespace UIPTTO_DATABASE.childForms
{
    partial class issnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issnForm));
            this.lblSearchIssn = new System.Windows.Forms.Label();
            this.txtboxIssnSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIssn = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvIssn = new System.Windows.Forms.DataGridView();
            this.iid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.college = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_filed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelIssn = new System.Windows.Forms.Button();
            this.btnEditIssn = new System.Windows.Forms.Button();
            this.btnAddIssn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchIssn
            // 
            this.lblSearchIssn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchIssn.AutoSize = true;
            this.lblSearchIssn.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearchIssn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearchIssn.Location = new System.Drawing.Point(722, 107);
            this.lblSearchIssn.Name = "lblSearchIssn";
            this.lblSearchIssn.Size = new System.Drawing.Size(135, 31);
            this.lblSearchIssn.TabIndex = 25;
            this.lblSearchIssn.Text = "SEARCH";
            // 
            // txtboxIssnSearch
            // 
            this.txtboxIssnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxIssnSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxIssnSearch.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxIssnSearch.Location = new System.Drawing.Point(867, 99);
            this.txtboxIssnSearch.Name = "txtboxIssnSearch";
            this.txtboxIssnSearch.Size = new System.Drawing.Size(235, 29);
            this.txtboxIssnSearch.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham Thin", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "List of ISSN";
            // 
            // lblIssn
            // 
            this.lblIssn.AutoSize = true;
            this.lblIssn.Font = new System.Drawing.Font("Gotham Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIssn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblIssn.Location = new System.Drawing.Point(12, 24);
            this.lblIssn.Name = "lblIssn";
            this.lblIssn.Size = new System.Drawing.Size(98, 36);
            this.lblIssn.TabIndex = 21;
            this.lblIssn.Text = "ISSN";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(867, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 29);
            this.textBox2.TabIndex = 23;
            // 
            // dgvIssn
            // 
            this.dgvIssn.AllowUserToAddRows = false;
            this.dgvIssn.AllowUserToDeleteRows = false;
            this.dgvIssn.AllowUserToResizeColumns = false;
            this.dgvIssn.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIssn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.dgvIssn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIssn.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvIssn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIssn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iid,
            this.title,
            this.college,
            this.author,
            this.date_filed,
            this.reg_no,
            this.status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIssn.EnableHeadersVisualStyles = false;
            this.dgvIssn.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvIssn.Location = new System.Drawing.Point(12, 154);
            this.dgvIssn.MultiSelect = false;
            this.dgvIssn.Name = "dgvIssn";
            this.dgvIssn.ReadOnly = true;
            this.dgvIssn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssn.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIssn.RowHeadersVisible = false;
            this.dgvIssn.RowHeadersWidth = 51;
            this.dgvIssn.RowTemplate.Height = 29;
            this.dgvIssn.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvIssn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssn.Size = new System.Drawing.Size(1090, 579);
            this.dgvIssn.TabIndex = 29;
            this.dgvIssn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssn_CellContentClick);
            // 
            // iid
            // 
            this.iid.DataPropertyName = "iid";
            this.iid.HeaderText = "iid";
            this.iid.MinimumWidth = 6;
            this.iid.Name = "iid";
            this.iid.ReadOnly = true;
            this.iid.Visible = false;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Name of the material";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
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
            // author
            // 
            this.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.author.DataPropertyName = "author";
            this.author.HeaderText = "Author";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Width = 138;
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
            // reg_no
            // 
            this.reg_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.reg_no.DataPropertyName = "reg_no";
            this.reg_no.HeaderText = "Registration No.";
            this.reg_no.MinimumWidth = 6;
            this.reg_no.Name = "reg_no";
            this.reg_no.ReadOnly = true;
            this.reg_no.Width = 241;
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
            // btnDelIssn
            // 
            this.btnDelIssn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelIssn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnDelIssn.FlatAppearance.BorderSize = 0;
            this.btnDelIssn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelIssn.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelIssn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelIssn.Image = ((System.Drawing.Image)(resources.GetObject("btnDelIssn.Image")));
            this.btnDelIssn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelIssn.Location = new System.Drawing.Point(278, 760);
            this.btnDelIssn.Name = "btnDelIssn";
            this.btnDelIssn.Size = new System.Drawing.Size(143, 47);
            this.btnDelIssn.TabIndex = 28;
            this.btnDelIssn.Text = "DELETE";
            this.btnDelIssn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelIssn.UseVisualStyleBackColor = false;
            this.btnDelIssn.Click += new System.EventHandler(this.btnDelIssn_Click);
            // 
            // btnEditIssn
            // 
            this.btnEditIssn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditIssn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnEditIssn.FlatAppearance.BorderSize = 0;
            this.btnEditIssn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditIssn.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditIssn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditIssn.Image = ((System.Drawing.Image)(resources.GetObject("btnEditIssn.Image")));
            this.btnEditIssn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditIssn.Location = new System.Drawing.Point(148, 760);
            this.btnEditIssn.Name = "btnEditIssn";
            this.btnEditIssn.Size = new System.Drawing.Size(105, 47);
            this.btnEditIssn.TabIndex = 27;
            this.btnEditIssn.Text = "EDIT";
            this.btnEditIssn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditIssn.UseVisualStyleBackColor = false;
            this.btnEditIssn.Click += new System.EventHandler(this.btnEditIssn_Click);
            // 
            // btnAddIssn
            // 
            this.btnAddIssn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddIssn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAddIssn.FlatAppearance.BorderSize = 0;
            this.btnAddIssn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIssn.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddIssn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddIssn.Image = ((System.Drawing.Image)(resources.GetObject("btnAddIssn.Image")));
            this.btnAddIssn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddIssn.Location = new System.Drawing.Point(14, 760);
            this.btnAddIssn.Name = "btnAddIssn";
            this.btnAddIssn.Size = new System.Drawing.Size(110, 47);
            this.btnAddIssn.TabIndex = 26;
            this.btnAddIssn.TabStop = false;
            this.btnAddIssn.Text = "NEW";
            this.btnAddIssn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddIssn.UseVisualStyleBackColor = false;
            this.btnAddIssn.Click += new System.EventHandler(this.btnAddIssn_Click_1);
            // 
            // issnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 837);
            this.Controls.Add(this.dgvIssn);
            this.Controls.Add(this.btnDelIssn);
            this.Controls.Add(this.btnEditIssn);
            this.Controls.Add(this.btnAddIssn);
            this.Controls.Add(this.lblSearchIssn);
            this.Controls.Add(this.txtboxIssnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIssn);
            this.Controls.Add(this.textBox2);
            this.Name = "issnForm";
            this.Text = "issnForm";
            this.Load += new System.EventHandler(this.issnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblSearchIssn;
        private TextBox txtboxIssnSearch;
        private Label label2;
        private Label lblIssn;
        private TextBox textBox2;
        public DataGridView dgvIssn;
        private Button btnDelIssn;
        private Button btnEditIssn;
        private Button btnAddIssn;
        private DataGridViewTextBoxColumn iid;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn college;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn date_filed;
        private DataGridViewTextBoxColumn reg_no;
        private DataGridViewTextBoxColumn status;
    }
}