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
            this.btnAddISBN = new System.Windows.Forms.Button();
            this.lblSearchIsbn = new System.Windows.Forms.Label();
            this.dgvIsbn = new System.Windows.Forms.DataGridView();
            this.txtboxSearchIsbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.college = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_filed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issued_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appr_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsbn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddISBN
            // 
            this.btnAddISBN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAddISBN.FlatAppearance.BorderSize = 0;
            this.btnAddISBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddISBN.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddISBN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddISBN.Image = global::UIPTTO_DATABASE.Properties.Resources.plus2;
            this.btnAddISBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddISBN.Location = new System.Drawing.Point(934, 752);
            this.btnAddISBN.Name = "btnAddISBN";
            this.btnAddISBN.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddISBN.Size = new System.Drawing.Size(168, 53);
            this.btnAddISBN.TabIndex = 26;
            this.btnAddISBN.TabStop = false;
            this.btnAddISBN.Text = "NEW";
            this.btnAddISBN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddISBN.UseVisualStyleBackColor = false;
            this.btnAddISBN.Click += new System.EventHandler(this.btnAddISBN_Click);
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
            // dgvIsbn
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gotham Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
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
            this.title,
            this.college,
            this.author,
            this.date_filed,
            this.issued_no,
            this.appr_date,
            this.edit,
            this.delete});
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
            this.dgvIsbn.Location = new System.Drawing.Point(12, 152);
            this.dgvIsbn.Name = "dgvIsbn";
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
            this.dgvIsbn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvIsbn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIsbn.Size = new System.Drawing.Size(1090, 584);
            this.dgvIsbn.TabIndex = 24;
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
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            // 
            // college
            // 
            this.college.HeaderText = "College";
            this.college.MinimumWidth = 6;
            this.college.Name = "college";
            // 
            // author
            // 
            this.author.HeaderText = "Author";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            // 
            // date_filed
            // 
            this.date_filed.HeaderText = "Date Filed";
            this.date_filed.MinimumWidth = 6;
            this.date_filed.Name = "date_filed";
            // 
            // issued_no
            // 
            this.issued_no.HeaderText = "Issued No.";
            this.issued_no.MinimumWidth = 6;
            this.issued_no.Name = "issued_no";
            // 
            // appr_date
            // 
            this.appr_date.HeaderText = "Approval Date";
            this.appr_date.MinimumWidth = 6;
            this.appr_date.Name = "appr_date";
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.FillWeight = 35F;
            this.edit.HeaderText = "Edit";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit.Width = 98;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.FillWeight = 35F;
            this.delete.HeaderText = "Del";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Width = 88;
            // 
            // isbnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 837);
            this.Controls.Add(this.btnAddISBN);
            this.Controls.Add(this.lblSearchIsbn);
            this.Controls.Add(this.dgvIsbn);
            this.Controls.Add(this.txtboxSearchIsbn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.textBox2);
            this.Name = "isbnForm";
            this.Text = "isbnForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsbn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddISBN;
        private Label lblSearchIsbn;
        private DataGridView dgvIsbn;
        private TextBox txtboxSearchIsbn;
        private Label label2;
        private Label lblIsbn;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn college;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn date_filed;
        private DataGridViewTextBoxColumn issued_no;
        private DataGridViewTextBoxColumn appr_date;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn delete;
    }
}