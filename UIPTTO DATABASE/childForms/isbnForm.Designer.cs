namespace UIPTTO_DATABASE.childForms
{
    partial class isbnForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(isbnForm));
            this.txtboxSearchIsbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvIsbn = new System.Windows.Forms.DataGridView();
            this.ibid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.college = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_filed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issued_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelIsbn = new System.Windows.Forms.Button();
            this.btnEditIsbn = new System.Windows.Forms.Button();
            this.btnAddIsbn = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsbn)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxSearchIsbn
            // 
            this.txtboxSearchIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxSearchIsbn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxSearchIsbn.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxSearchIsbn.Location = new System.Drawing.Point(808, 97);
            this.txtboxSearchIsbn.Name = "txtboxSearchIsbn";
            this.txtboxSearchIsbn.Size = new System.Drawing.Size(235, 29);
            this.txtboxSearchIsbn.TabIndex = 22;
            this.txtboxSearchIsbn.TextChanged += new System.EventHandler(this.txtboxSearchIsbn_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham Thin", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "List of ISBN";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Gotham Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIsbn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblIsbn.Location = new System.Drawing.Point(12, 24);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(100, 36);
            this.lblIsbn.TabIndex = 21;
            this.lblIsbn.Text = "ISBN";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(808, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 29);
            this.textBox2.TabIndex = 23;
            // 
            // dgvIsbn
            // 
            this.dgvIsbn.AllowUserToAddRows = false;
            this.dgvIsbn.AllowUserToDeleteRows = false;
            this.dgvIsbn.AllowUserToResizeColumns = false;
            this.dgvIsbn.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIsbn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIsbn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIsbn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.dgvIsbn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIsbn.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvIsbn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIsbn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIsbn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsbn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ibid,
            this.title,
            this.college,
            this.author,
            this.date_filed,
            this.issued_no,
            this.status});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIsbn.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvIsbn.EnableHeadersVisualStyles = false;
            this.dgvIsbn.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvIsbn.Location = new System.Drawing.Point(12, 155);
            this.dgvIsbn.MultiSelect = false;
            this.dgvIsbn.Name = "dgvIsbn";
            this.dgvIsbn.ReadOnly = true;
            this.dgvIsbn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIsbn.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvIsbn.RowHeadersVisible = false;
            this.dgvIsbn.RowHeadersWidth = 51;
            this.dgvIsbn.RowTemplate.Height = 29;
            this.dgvIsbn.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIsbn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvIsbn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIsbn.Size = new System.Drawing.Size(1090, 579);
            this.dgvIsbn.TabIndex = 29;
            this.dgvIsbn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIsbn_CellContentClick);
            // 
            // ibid
            // 
            this.ibid.DataPropertyName = "ibid";
            this.ibid.HeaderText = "ibid";
            this.ibid.MinimumWidth = 6;
            this.ibid.Name = "ibid";
            this.ibid.ReadOnly = true;
            this.ibid.Visible = false;
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
            // issued_no
            // 
            this.issued_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issued_no.DataPropertyName = "issued_no";
            this.issued_no.HeaderText = "Issued No.";
            this.issued_no.MinimumWidth = 6;
            this.issued_no.Name = "issued_no";
            this.issued_no.ReadOnly = true;
            this.issued_no.Width = 170;
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
            // btnDelIsbn
            // 
            this.btnDelIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelIsbn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnDelIsbn.FlatAppearance.BorderSize = 0;
            this.btnDelIsbn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelIsbn.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelIsbn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelIsbn.Image = ((System.Drawing.Image)(resources.GetObject("btnDelIsbn.Image")));
            this.btnDelIsbn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelIsbn.Location = new System.Drawing.Point(278, 761);
            this.btnDelIsbn.Name = "btnDelIsbn";
            this.btnDelIsbn.Size = new System.Drawing.Size(143, 47);
            this.btnDelIsbn.TabIndex = 28;
            this.btnDelIsbn.Text = "DELETE";
            this.btnDelIsbn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelIsbn.UseVisualStyleBackColor = false;
            this.btnDelIsbn.Click += new System.EventHandler(this.btnDelIsbn_Click);
            // 
            // btnEditIsbn
            // 
            this.btnEditIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditIsbn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnEditIsbn.FlatAppearance.BorderSize = 0;
            this.btnEditIsbn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditIsbn.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditIsbn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditIsbn.Image = ((System.Drawing.Image)(resources.GetObject("btnEditIsbn.Image")));
            this.btnEditIsbn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditIsbn.Location = new System.Drawing.Point(148, 761);
            this.btnEditIsbn.Name = "btnEditIsbn";
            this.btnEditIsbn.Size = new System.Drawing.Size(105, 47);
            this.btnEditIsbn.TabIndex = 27;
            this.btnEditIsbn.Text = "EDIT";
            this.btnEditIsbn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditIsbn.UseVisualStyleBackColor = false;
            this.btnEditIsbn.Click += new System.EventHandler(this.btnEditIsbn_Click);
            // 
            // btnAddIsbn
            // 
            this.btnAddIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddIsbn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAddIsbn.FlatAppearance.BorderSize = 0;
            this.btnAddIsbn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIsbn.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddIsbn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddIsbn.Image = ((System.Drawing.Image)(resources.GetObject("btnAddIsbn.Image")));
            this.btnAddIsbn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddIsbn.Location = new System.Drawing.Point(14, 761);
            this.btnAddIsbn.Name = "btnAddIsbn";
            this.btnAddIsbn.Size = new System.Drawing.Size(110, 47);
            this.btnAddIsbn.TabIndex = 26;
            this.btnAddIsbn.TabStop = false;
            this.btnAddIsbn.Text = "NEW";
            this.btnAddIsbn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddIsbn.UseVisualStyleBackColor = false;
            this.btnAddIsbn.Click += new System.EventHandler(this.btnAddIsbn_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1060, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 42);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // isbnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 837);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvIsbn);
            this.Controls.Add(this.btnDelIsbn);
            this.Controls.Add(this.btnEditIsbn);
            this.Controls.Add(this.btnAddIsbn);
            this.Controls.Add(this.txtboxSearchIsbn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.textBox2);
            this.Name = "isbnForm";
            this.Text = "isbnForm";
            this.Load += new System.EventHandler(this.isbnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsbn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtboxSearchIsbn;
        private Label label2;
        private Label lblIsbn;
        private TextBox textBox2;
        public DataGridView dgvIsbn;
        private Button btnDelIsbn;
        private Button btnEditIsbn;
        private Button btnAddIsbn;
        private DataGridViewTextBoxColumn ibid;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn college;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn date_filed;
        private DataGridViewTextBoxColumn issued_no;
        private DataGridViewTextBoxColumn status;
        public Button btnSearch;
    }
}