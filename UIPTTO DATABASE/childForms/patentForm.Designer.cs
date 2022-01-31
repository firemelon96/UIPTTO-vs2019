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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patentForm));
            this.btnAddPatents = new System.Windows.Forms.Button();
            this.lblSearchPatents = new System.Windows.Forms.Label();
            this.dgvPatents = new System.Windows.Forms.DataGridView();
            this.txtboxSearchPatents = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPatents = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.invention = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.college = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_filed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.app_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appr_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPatents
            // 
            this.btnAddPatents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPatents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAddPatents.FlatAppearance.BorderSize = 0;
            this.btnAddPatents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatents.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddPatents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPatents.Image = global::UIPTTO_DATABASE.Properties.Resources.plus2;
            this.btnAddPatents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPatents.Location = new System.Drawing.Point(934, 753);
            this.btnAddPatents.Name = "btnAddPatents";
            this.btnAddPatents.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddPatents.Size = new System.Drawing.Size(168, 53);
            this.btnAddPatents.TabIndex = 19;
            this.btnAddPatents.TabStop = false;
            this.btnAddPatents.Text = "NEW";
            this.btnAddPatents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPatents.UseVisualStyleBackColor = false;
            this.btnAddPatents.Click += new System.EventHandler(this.btnAddPatents_Click);
            // 
            // lblSearchPatents
            // 
            this.lblSearchPatents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchPatents.AutoSize = true;
            this.lblSearchPatents.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearchPatents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearchPatents.Location = new System.Drawing.Point(722, 107);
            this.lblSearchPatents.Name = "lblSearchPatents";
            this.lblSearchPatents.Size = new System.Drawing.Size(135, 31);
            this.lblSearchPatents.TabIndex = 18;
            this.lblSearchPatents.Text = "SEARCH";
            // 
            // dgvPatents
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gotham Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.dgvPatents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatents.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvPatents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invention,
            this.college,
            this.inventor,
            this.date_filed,
            this.app_no,
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
            this.dgvPatents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatents.EnableHeadersVisualStyles = false;
            this.dgvPatents.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPatents.Location = new System.Drawing.Point(12, 152);
            this.dgvPatents.Name = "dgvPatents";
            this.dgvPatents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatents.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPatents.RowHeadersVisible = false;
            this.dgvPatents.RowHeadersWidth = 51;
            this.dgvPatents.RowTemplate.Height = 29;
            this.dgvPatents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPatents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatents.Size = new System.Drawing.Size(1090, 584);
            this.dgvPatents.TabIndex = 17;
            // 
            // txtboxSearchPatents
            // 
            this.txtboxSearchPatents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxSearchPatents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxSearchPatents.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxSearchPatents.Location = new System.Drawing.Point(867, 99);
            this.txtboxSearchPatents.Name = "txtboxSearchPatents";
            this.txtboxSearchPatents.Size = new System.Drawing.Size(235, 29);
            this.txtboxSearchPatents.TabIndex = 15;
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
            this.textBox2.Location = new System.Drawing.Point(867, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 29);
            this.textBox2.TabIndex = 16;
            // 
            // invention
            // 
            this.invention.HeaderText = "Invention Name";
            this.invention.MinimumWidth = 6;
            this.invention.Name = "invention";
            // 
            // college
            // 
            this.college.HeaderText = "College";
            this.college.MinimumWidth = 6;
            this.college.Name = "college";
            // 
            // inventor
            // 
            this.inventor.HeaderText = "Inventor";
            this.inventor.MinimumWidth = 6;
            this.inventor.Name = "inventor";
            // 
            // date_filed
            // 
            this.date_filed.HeaderText = "Date Filed";
            this.date_filed.MinimumWidth = 6;
            this.date_filed.Name = "date_filed";
            // 
            // app_no
            // 
            this.app_no.HeaderText = "Application No.";
            this.app_no.MinimumWidth = 6;
            this.app_no.Name = "app_no";
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
            // patentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 837);
            this.Controls.Add(this.btnAddPatents);
            this.Controls.Add(this.lblSearchPatents);
            this.Controls.Add(this.dgvPatents);
            this.Controls.Add(this.txtboxSearchPatents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPatents);
            this.Controls.Add(this.textBox2);
            this.Name = "patentForm";
            this.Text = "patentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddPatents;
        private Label lblSearchPatents;
        private DataGridView dgvPatents;
        private TextBox txtboxSearchPatents;
        private Label label2;
        private Label lblPatents;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn invention;
        private DataGridViewTextBoxColumn college;
        private DataGridViewTextBoxColumn inventor;
        private DataGridViewTextBoxColumn date_filed;
        private DataGridViewTextBoxColumn app_no;
        private DataGridViewTextBoxColumn appr_date;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn delete;
    }
}