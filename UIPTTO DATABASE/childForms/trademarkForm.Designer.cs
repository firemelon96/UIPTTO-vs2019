namespace UIPTTO_DATABASE.childForms
{
    partial class trademarkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trademarkForm));
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvTrademark = new System.Windows.Forms.DataGridView();
            this.tid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_filed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appr_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nxt_filing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor_expe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelTrademark = new System.Windows.Forms.Button();
            this.btnEditTrademark = new System.Windows.Forms.Button();
            this.btnAddTrademark = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrademark)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(722, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "SEARCH";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(867, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 29);
            this.textBox1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham Thin", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "List of Trademarks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 36);
            this.label1.TabIndex = 21;
            this.label1.Text = "TRADEMARKS";
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
            // dgvTrademark
            // 
            this.dgvTrademark.AllowUserToAddRows = false;
            this.dgvTrademark.AllowUserToDeleteRows = false;
            this.dgvTrademark.AllowUserToResizeColumns = false;
            this.dgvTrademark.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrademark.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrademark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrademark.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrademark.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.dgvTrademark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrademark.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvTrademark.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrademark.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrademark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrademark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tid,
            this.title,
            this.reg_no,
            this.date_filed,
            this.status,
            this.appr_date,
            this.nxt_filing,
            this.cor_expe});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrademark.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTrademark.EnableHeadersVisualStyles = false;
            this.dgvTrademark.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTrademark.Location = new System.Drawing.Point(12, 154);
            this.dgvTrademark.MultiSelect = false;
            this.dgvTrademark.Name = "dgvTrademark";
            this.dgvTrademark.ReadOnly = true;
            this.dgvTrademark.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrademark.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTrademark.RowHeadersVisible = false;
            this.dgvTrademark.RowHeadersWidth = 51;
            this.dgvTrademark.RowTemplate.Height = 29;
            this.dgvTrademark.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrademark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTrademark.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrademark.Size = new System.Drawing.Size(1090, 579);
            this.dgvTrademark.TabIndex = 29;
            this.dgvTrademark.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrademark_CellContentClick);
            // 
            // tid
            // 
            this.tid.DataPropertyName = "tid";
            this.tid.HeaderText = "tid";
            this.tid.MinimumWidth = 6;
            this.tid.Name = "tid";
            this.tid.ReadOnly = true;
            this.tid.Visible = false;
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
            // reg_no
            // 
            this.reg_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.reg_no.DataPropertyName = "reg_no";
            this.reg_no.HeaderText = "Registration No.";
            this.reg_no.MinimumWidth = 6;
            this.reg_no.Name = "reg_no";
            this.reg_no.ReadOnly = true;
            this.reg_no.Width = 181;
            // 
            // date_filed
            // 
            this.date_filed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date_filed.DataPropertyName = "date_filed";
            this.date_filed.HeaderText = "Date filed";
            this.date_filed.MinimumWidth = 6;
            this.date_filed.Name = "date_filed";
            this.date_filed.ReadOnly = true;
            this.date_filed.Width = 123;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 101;
            // 
            // appr_date
            // 
            this.appr_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appr_date.DataPropertyName = "appr_date";
            this.appr_date.HeaderText = "Approval Date";
            this.appr_date.MinimumWidth = 6;
            this.appr_date.Name = "appr_date";
            this.appr_date.ReadOnly = true;
            this.appr_date.Width = 168;
            // 
            // nxt_filing
            // 
            this.nxt_filing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nxt_filing.DataPropertyName = "nxt_filing";
            this.nxt_filing.HeaderText = "Next filing DAU";
            this.nxt_filing.MinimumWidth = 6;
            this.nxt_filing.Name = "nxt_filing";
            this.nxt_filing.ReadOnly = true;
            this.nxt_filing.Width = 132;
            // 
            // cor_expe
            // 
            this.cor_expe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cor_expe.DataPropertyName = "cor_expe";
            this.cor_expe.HeaderText = "COR Expiration";
            this.cor_expe.MinimumWidth = 6;
            this.cor_expe.Name = "cor_expe";
            this.cor_expe.ReadOnly = true;
            this.cor_expe.Width = 173;
            // 
            // btnDelTrademark
            // 
            this.btnDelTrademark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelTrademark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnDelTrademark.FlatAppearance.BorderSize = 0;
            this.btnDelTrademark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelTrademark.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelTrademark.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelTrademark.Image = ((System.Drawing.Image)(resources.GetObject("btnDelTrademark.Image")));
            this.btnDelTrademark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelTrademark.Location = new System.Drawing.Point(278, 760);
            this.btnDelTrademark.Name = "btnDelTrademark";
            this.btnDelTrademark.Size = new System.Drawing.Size(143, 47);
            this.btnDelTrademark.TabIndex = 28;
            this.btnDelTrademark.Text = "DELETE";
            this.btnDelTrademark.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelTrademark.UseVisualStyleBackColor = false;
            this.btnDelTrademark.Click += new System.EventHandler(this.btnDelTrademark_Click);
            // 
            // btnEditTrademark
            // 
            this.btnEditTrademark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditTrademark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnEditTrademark.FlatAppearance.BorderSize = 0;
            this.btnEditTrademark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTrademark.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditTrademark.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditTrademark.Image = ((System.Drawing.Image)(resources.GetObject("btnEditTrademark.Image")));
            this.btnEditTrademark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTrademark.Location = new System.Drawing.Point(148, 760);
            this.btnEditTrademark.Name = "btnEditTrademark";
            this.btnEditTrademark.Size = new System.Drawing.Size(105, 47);
            this.btnEditTrademark.TabIndex = 27;
            this.btnEditTrademark.Text = "EDIT";
            this.btnEditTrademark.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditTrademark.UseVisualStyleBackColor = false;
            this.btnEditTrademark.Click += new System.EventHandler(this.btnEditTrademark_Click);
            // 
            // btnAddTrademark
            // 
            this.btnAddTrademark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTrademark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAddTrademark.FlatAppearance.BorderSize = 0;
            this.btnAddTrademark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTrademark.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTrademark.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddTrademark.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTrademark.Image")));
            this.btnAddTrademark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTrademark.Location = new System.Drawing.Point(14, 760);
            this.btnAddTrademark.Name = "btnAddTrademark";
            this.btnAddTrademark.Size = new System.Drawing.Size(110, 47);
            this.btnAddTrademark.TabIndex = 26;
            this.btnAddTrademark.TabStop = false;
            this.btnAddTrademark.Text = "NEW";
            this.btnAddTrademark.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddTrademark.UseVisualStyleBackColor = false;
            this.btnAddTrademark.Click += new System.EventHandler(this.btnAddTrademark_Click);
            // 
            // trademarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 837);
            this.Controls.Add(this.dgvTrademark);
            this.Controls.Add(this.btnDelTrademark);
            this.Controls.Add(this.btnEditTrademark);
            this.Controls.Add(this.btnAddTrademark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Name = "trademarkForm";
            this.Text = "trademarkForm";
            this.Load += new System.EventHandler(this.trademarkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrademark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        public DataGridView dgvTrademark;
        private Button btnDelTrademark;
        private Button btnEditTrademark;
        private Button btnAddTrademark;
        private DataGridViewTextBoxColumn tid;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn reg_no;
        private DataGridViewTextBoxColumn date_filed;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn appr_date;
        private DataGridViewTextBoxColumn nxt_filing;
        private DataGridViewTextBoxColumn cor_expe;
    }
}