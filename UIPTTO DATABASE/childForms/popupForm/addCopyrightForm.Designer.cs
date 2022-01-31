namespace UIPTTO_DATABASE.childForms.popupForm
{
    partial class addCopyrightForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCopyrightForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbOnProcess = new System.Windows.Forms.RadioButton();
            this.rbApproved = new System.Windows.Forms.RadioButton();
            this.txtboxRegNo = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtboxTitle = new System.Windows.Forms.TextBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dtpDateApproved = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFiled = new System.Windows.Forms.DateTimePicker();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.txtboxCollege = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblNewCopyright = new System.Windows.Forms.Label();
            this.pbCopyright = new System.Windows.Forms.PictureBox();
            this.pnlBody.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopyright)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(411, 339);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(202, 53);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(631, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(168, 53);
            this.btnSave.TabIndex = 10;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbOnProcess
            // 
            this.rbOnProcess.AutoSize = true;
            this.rbOnProcess.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbOnProcess.Location = new System.Drawing.Point(217, 283);
            this.rbOnProcess.Name = "rbOnProcess";
            this.rbOnProcess.Size = new System.Drawing.Size(193, 35);
            this.rbOnProcess.TabIndex = 8;
            this.rbOnProcess.TabStop = true;
            this.rbOnProcess.Text = "On process";
            this.rbOnProcess.UseVisualStyleBackColor = true;
            // 
            // rbApproved
            // 
            this.rbApproved.AutoSize = true;
            this.rbApproved.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbApproved.Location = new System.Drawing.Point(35, 283);
            this.rbApproved.Name = "rbApproved";
            this.rbApproved.Size = new System.Drawing.Size(176, 35);
            this.rbApproved.TabIndex = 7;
            this.rbApproved.Text = "Approved";
            this.rbApproved.UseVisualStyleBackColor = true;
            this.rbApproved.CheckedChanged += new System.EventHandler(this.rbApproved_CheckedChanged);
            // 
            // txtboxRegNo
            // 
            this.txtboxRegNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxRegNo.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxRegNo.Location = new System.Drawing.Point(436, 188);
            this.txtboxRegNo.Name = "txtboxRegNo";
            this.txtboxRegNo.PlaceholderText = "Registration No.";
            this.txtboxRegNo.Size = new System.Drawing.Size(363, 43);
            this.txtboxRegNo.TabIndex = 5;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox11.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox11.Location = new System.Drawing.Point(436, 197);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(363, 43);
            this.textBox11.TabIndex = 4;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox13.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox13.Location = new System.Drawing.Point(436, 278);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(363, 43);
            this.textBox13.TabIndex = 4;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox9.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox9.Location = new System.Drawing.Point(35, 197);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(363, 43);
            this.textBox9.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(35, 114);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(363, 43);
            this.textBox5.TabIndex = 4;
            // 
            // txtboxTitle
            // 
            this.txtboxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxTitle.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxTitle.Location = new System.Drawing.Point(35, 23);
            this.txtboxTitle.Name = "txtboxTitle";
            this.txtboxTitle.PlaceholderText = "Title";
            this.txtboxTitle.Size = new System.Drawing.Size(764, 43);
            this.txtboxTitle.TabIndex = 1;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.pnlBody.Controls.Add(this.dtpDateApproved);
            this.pnlBody.Controls.Add(this.dtpDateFiled);
            this.pnlBody.Controls.Add(this.cbAuthor);
            this.pnlBody.Controls.Add(this.btnCancel);
            this.pnlBody.Controls.Add(this.btnSave);
            this.pnlBody.Controls.Add(this.rbOnProcess);
            this.pnlBody.Controls.Add(this.rbApproved);
            this.pnlBody.Controls.Add(this.txtboxRegNo);
            this.pnlBody.Controls.Add(this.textBox11);
            this.pnlBody.Controls.Add(this.textBox13);
            this.pnlBody.Controls.Add(this.textBox9);
            this.pnlBody.Controls.Add(this.txtboxCollege);
            this.pnlBody.Controls.Add(this.textBox3);
            this.pnlBody.Controls.Add(this.textBox5);
            this.pnlBody.Controls.Add(this.txtboxTitle);
            this.pnlBody.Controls.Add(this.textBox2);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 67);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(847, 421);
            this.pnlBody.TabIndex = 3;
            // 
            // dtpDateApproved
            // 
            this.dtpDateApproved.CalendarFont = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateApproved.CustomFormat = "";
            this.dtpDateApproved.Enabled = false;
            this.dtpDateApproved.Font = new System.Drawing.Font("Gotham", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateApproved.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateApproved.Location = new System.Drawing.Point(436, 272);
            this.dtpDateApproved.Name = "dtpDateApproved";
            this.dtpDateApproved.Size = new System.Drawing.Size(363, 43);
            this.dtpDateApproved.TabIndex = 12;
            this.dtpDateApproved.Value = new System.DateTime(2022, 1, 28, 0, 0, 0, 0);
            // 
            // dtpDateFiled
            // 
            this.dtpDateFiled.CalendarFont = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateFiled.CustomFormat = "";
            this.dtpDateFiled.Font = new System.Drawing.Font("Gotham", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateFiled.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFiled.Location = new System.Drawing.Point(35, 188);
            this.dtpDateFiled.Name = "dtpDateFiled";
            this.dtpDateFiled.Size = new System.Drawing.Size(363, 43);
            this.dtpDateFiled.TabIndex = 12;
            this.dtpDateFiled.Value = new System.DateTime(2022, 1, 28, 0, 0, 0, 0);
            // 
            // cbAuthor
            // 
            this.cbAuthor.Font = new System.Drawing.Font("Gotham", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Items.AddRange(new object[] {
            "SELECT AUTHOR"});
            this.cbAuthor.Location = new System.Drawing.Point(35, 105);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(363, 44);
            this.cbAuthor.TabIndex = 11;
            // 
            // txtboxCollege
            // 
            this.txtboxCollege.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxCollege.Enabled = false;
            this.txtboxCollege.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxCollege.Location = new System.Drawing.Point(436, 105);
            this.txtboxCollege.Name = "txtboxCollege";
            this.txtboxCollege.PlaceholderText = "College";
            this.txtboxCollege.ReadOnly = true;
            this.txtboxCollege.Size = new System.Drawing.Size(363, 43);
            this.txtboxCollege.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(436, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(363, 43);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(35, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(764, 43);
            this.textBox2.TabIndex = 4;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlTitle.Controls.Add(this.lblNewCopyright);
            this.pnlTitle.Controls.Add(this.pbCopyright);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(847, 67);
            this.pnlTitle.TabIndex = 2;
            // 
            // lblNewCopyright
            // 
            this.lblNewCopyright.AutoSize = true;
            this.lblNewCopyright.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewCopyright.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNewCopyright.Location = new System.Drawing.Point(86, 19);
            this.lblNewCopyright.Name = "lblNewCopyright";
            this.lblNewCopyright.Size = new System.Drawing.Size(286, 33);
            this.lblNewCopyright.TabIndex = 1;
            this.lblNewCopyright.Text = "NEW COPYRIGHT";
            // 
            // pbCopyright
            // 
            this.pbCopyright.Image = ((System.Drawing.Image)(resources.GetObject("pbCopyright.Image")));
            this.pbCopyright.Location = new System.Drawing.Point(35, 12);
            this.pbCopyright.Name = "pbCopyright";
            this.pbCopyright.Size = new System.Drawing.Size(42, 49);
            this.pbCopyright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCopyright.TabIndex = 0;
            this.pbCopyright.TabStop = false;
            // 
            // addCopyrightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 488);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addCopyrightForm";
            this.Text = "addCopyrightForm";
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopyright)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private RadioButton rbOnProcess;
        private RadioButton rbApproved;
        private TextBox txtboxRegNo;
        private TextBox textBox11;
        private TextBox textBox13;
        private TextBox textBox9;
        private TextBox textBox5;
        private TextBox txtboxTitle;
        private Panel pnlBody;
        private TextBox textBox2;
        private Panel pnlTitle;
        private Label lblNewCopyright;
        private PictureBox pbCopyright;
        private ComboBox cbAuthor;
        private TextBox txtboxCollege;
        private TextBox textBox3;
        private DateTimePicker dtpDateFiled;
        private DateTimePicker dtpDateApproved;
    }
}