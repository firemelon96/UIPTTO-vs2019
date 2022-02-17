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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(isbnForm));
            this.lblSearchIsbn = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsbn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchIsbn
            // 
            this.lblSearchIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchIsbn.AutoSize = true;
            this.lblSearchIsbn.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearchIsbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearchIsbn.Location = new System.Drawing.Point(722, 107);
            this.lblSearchIsbn.Name = "lblSearchIsbn";
            this.lblSearchIsbn.Size = new System.Drawing.Size(135, 31);
            this.lblSearchIsbn.TabIndex = 25;
            this.lblSearchIsbn.Text = "SEARCH";
            // 
            // txtboxSearchIsbn
            // 
            this.txtboxSearchIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxSearchIsbn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxSearchIsbn.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxSearchIsbn.Location = new System.Drawing.Point(867, 99);
            this.txtboxSearchIsbn.Name = "txtboxSearchIsbn";
            this.txtboxSearchIsbn.Size = new System.Drawing.Size(235, 29);
            this.txtboxSearchIsbn.TabIndex = 22;
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
            this.textBox2.Location = new System.Drawing.Point(867, 107);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIsbn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIsbn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIsbn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.dgvIsbn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIsbn.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvIsbn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIsbn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIsbn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsbn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ibid,
            this.title,
            this.college,
            this.author,
            this.date_filed,
            this.issued_no,
            this.status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIsbn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIsbn.EnableHeadersVisualStyles = false;
            this.dgvIsbn.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvIsbn.Location = new System.Drawing.Point(12, 155);
            this.dgvIsbn.MultiSelect = false;
            this.dgvIsbn.Name = "dgvIsbn";
            this.dgvIsbn.ReadOnly = true;
            this.dgvIsbn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIsbn.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            // isbnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 837);
            this.Controls.Add(this.dgvIsbn);
            this.Controls.Add(this.btnDelIsbn);
            this.Controls.Add(this.btnEditIsbn);
            this.Controls.Add(this.btnAddIsbn);
            this.Controls.Add(this.lblSearchIsbn);
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
        private Label lblSearchIsbn;
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
    }
}