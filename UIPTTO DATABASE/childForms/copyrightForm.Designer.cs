namespace UIPTTO_DATABASE.childForms
{
    partial class copyrightForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(copyrightForm));
            this.btnAddCopyright = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxSearchCopyright = new System.Windows.Forms.TextBox();
            this.dgvCopyright = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.college = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_filed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appr_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblSearchCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopyright)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCopyright
            // 
            this.btnAddCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCopyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAddCopyright.FlatAppearance.BorderSize = 0;
            this.btnAddCopyright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCopyright.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCopyright.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCopyright.Image = global::UIPTTO_DATABASE.Properties.Resources.plus2;
            this.btnAddCopyright.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCopyright.Location = new System.Drawing.Point(934, 755);
            this.btnAddCopyright.Name = "btnAddCopyright";
            this.btnAddCopyright.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddCopyright.Size = new System.Drawing.Size(168, 53);
            this.btnAddCopyright.TabIndex = 12;
            this.btnAddCopyright.TabStop = false;
            this.btnAddCopyright.Text = "NEW";
            this.btnAddCopyright.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCopyright.UseVisualStyleBackColor = false;
            this.btnAddCopyright.Click += new System.EventHandler(this.btnAddCopyright_Click);
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
            this.textBox2.TabIndex = 9;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Gotham Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCopyright.Location = new System.Drawing.Point(12, 24);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(228, 36);
            this.lblCopyright.TabIndex = 7;
            this.lblCopyright.Text = "COPYRIGHT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham Thin", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "List of Copyrights";
            // 
            // txtboxSearchCopyright
            // 
            this.txtboxSearchCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxSearchCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxSearchCopyright.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxSearchCopyright.Location = new System.Drawing.Point(867, 99);
            this.txtboxSearchCopyright.Name = "txtboxSearchCopyright";
            this.txtboxSearchCopyright.Size = new System.Drawing.Size(235, 29);
            this.txtboxSearchCopyright.TabIndex = 8;
            // 
            // dgvCopyright
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gotham Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCopyright.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCopyright.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCopyright.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.dgvCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCopyright.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvCopyright.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCopyright.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCopyright.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCopyright.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.college,
            this.author,
            this.date_filed,
            this.reg_no,
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
            this.dgvCopyright.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCopyright.EnableHeadersVisualStyles = false;
            this.dgvCopyright.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCopyright.Location = new System.Drawing.Point(12, 152);
            this.dgvCopyright.Name = "dgvCopyright";
            this.dgvCopyright.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCopyright.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCopyright.RowHeadersVisible = false;
            this.dgvCopyright.RowHeadersWidth = 51;
            this.dgvCopyright.RowTemplate.Height = 29;
            this.dgvCopyright.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCopyright.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCopyright.Size = new System.Drawing.Size(1090, 584);
            this.dgvCopyright.TabIndex = 10;
            // 
            // title
            // 
            this.title.FillWeight = 109.5583F;
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            // 
            // college
            // 
            this.college.FillWeight = 109.5583F;
            this.college.HeaderText = "College";
            this.college.MinimumWidth = 6;
            this.college.Name = "college";
            // 
            // author
            // 
            this.author.FillWeight = 109.5583F;
            this.author.HeaderText = "Author";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            // 
            // date_filed
            // 
            this.date_filed.FillWeight = 109.5583F;
            this.date_filed.HeaderText = "Date Filed";
            this.date_filed.MinimumWidth = 6;
            this.date_filed.Name = "date_filed";
            // 
            // reg_no
            // 
            this.reg_no.FillWeight = 109.5583F;
            this.reg_no.HeaderText = "Reg. No.";
            this.reg_no.MinimumWidth = 6;
            this.reg_no.Name = "reg_no";
            // 
            // appr_date
            // 
            this.appr_date.FillWeight = 109.5583F;
            this.appr_date.HeaderText = "Approval Date";
            this.appr_date.MinimumWidth = 6;
            this.appr_date.Name = "appr_date";
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.FillWeight = 39.30481F;
            this.edit.HeaderText = "Edit";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.Width = 75;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.FillWeight = 38.34541F;
            this.delete.HeaderText = "Del";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Width = 88;
            // 
            // lblSearchCopyright
            // 
            this.lblSearchCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchCopyright.AutoSize = true;
            this.lblSearchCopyright.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearchCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearchCopyright.Location = new System.Drawing.Point(722, 107);
            this.lblSearchCopyright.Name = "lblSearchCopyright";
            this.lblSearchCopyright.Size = new System.Drawing.Size(135, 31);
            this.lblSearchCopyright.TabIndex = 11;
            this.lblSearchCopyright.Text = "SEARCH";
            // 
            // copyrightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 837);
            this.Controls.Add(this.btnAddCopyright);
            this.Controls.Add(this.lblSearchCopyright);
            this.Controls.Add(this.dgvCopyright);
            this.Controls.Add(this.txtboxSearchCopyright);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.textBox2);
            this.Name = "copyrightForm";
            this.Text = "copyrightForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopyright)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddCopyright;
        private TextBox textBox2;
        private Label lblCopyright;
        private Label label2;
        private TextBox txtboxSearchCopyright;
        private DataGridView dgvCopyright;
        private Label lblSearchCopyright;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn college;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn date_filed;
        private DataGridViewTextBoxColumn reg_no;
        private DataGridViewTextBoxColumn appr_date;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn delete;
    }
}