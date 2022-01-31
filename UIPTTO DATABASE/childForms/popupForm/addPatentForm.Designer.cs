namespace UIPTTO_DATABASE.childForms.popupForm
{
    partial class addPatentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addPatentForm));
            this.cbInventor = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbOnProcess = new System.Windows.Forms.RadioButton();
            this.rbApproved = new System.Windows.Forms.RadioButton();
            this.txtboxApplicationNo = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txtboxCollege = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtboxInvention = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dtpDateApproved = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFiled = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblNewPatent = new System.Windows.Forms.Label();
            this.pbPatent = new System.Windows.Forms.PictureBox();
            this.pnlBody.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatent)).BeginInit();
            this.SuspendLayout();
            // 
            // cbInventor
            // 
            this.cbInventor.Font = new System.Drawing.Font("Gotham", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbInventor.FormattingEnabled = true;
            this.cbInventor.Items.AddRange(new object[] {
            "SELECT AUTHOR"});
            this.cbInventor.Location = new System.Drawing.Point(35, 105);
            this.cbInventor.Name = "cbInventor";
            this.cbInventor.Size = new System.Drawing.Size(363, 44);
            this.cbInventor.TabIndex = 2;
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
            this.btnCancel.TabIndex = 8;
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
            this.btnSave.TabIndex = 7;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // rbOnProcess
            // 
            this.rbOnProcess.AutoSize = true;
            this.rbOnProcess.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbOnProcess.Location = new System.Drawing.Point(217, 283);
            this.rbOnProcess.Name = "rbOnProcess";
            this.rbOnProcess.Size = new System.Drawing.Size(193, 35);
            this.rbOnProcess.TabIndex = 6;
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
            this.rbApproved.TabIndex = 5;
            this.rbApproved.TabStop = true;
            this.rbApproved.Text = "Approved";
            this.rbApproved.UseVisualStyleBackColor = true;
            // 
            // txtboxApplicationNo
            // 
            this.txtboxApplicationNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxApplicationNo.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxApplicationNo.Location = new System.Drawing.Point(436, 188);
            this.txtboxApplicationNo.Name = "txtboxApplicationNo";
            this.txtboxApplicationNo.PlaceholderText = "Application No.";
            this.txtboxApplicationNo.Size = new System.Drawing.Size(363, 43);
            this.txtboxApplicationNo.TabIndex = 4;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox11.Enabled = false;
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
            this.textBox13.Enabled = false;
            this.textBox13.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox13.Location = new System.Drawing.Point(436, 280);
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
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox9.Location = new System.Drawing.Point(35, 197);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(363, 43);
            this.textBox9.TabIndex = 4;
            // 
            // txtboxCollege
            // 
            this.txtboxCollege.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxCollege.Enabled = false;
            this.txtboxCollege.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxCollege.Location = new System.Drawing.Point(436, 105);
            this.txtboxCollege.Name = "txtboxCollege";
            this.txtboxCollege.PlaceholderText = "College/Unit";
            this.txtboxCollege.ReadOnly = true;
            this.txtboxCollege.Size = new System.Drawing.Size(363, 43);
            this.txtboxCollege.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(436, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(363, 43);
            this.textBox3.TabIndex = 4;
            // 
            // txtboxInvention
            // 
            this.txtboxInvention.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxInvention.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxInvention.Location = new System.Drawing.Point(35, 23);
            this.txtboxInvention.Name = "txtboxInvention";
            this.txtboxInvention.PlaceholderText = "Title of the Invention";
            this.txtboxInvention.Size = new System.Drawing.Size(764, 43);
            this.txtboxInvention.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(35, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(764, 43);
            this.textBox2.TabIndex = 4;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.pnlBody.Controls.Add(this.dtpDateApproved);
            this.pnlBody.Controls.Add(this.dtpDateFiled);
            this.pnlBody.Controls.Add(this.cbInventor);
            this.pnlBody.Controls.Add(this.btnCancel);
            this.pnlBody.Controls.Add(this.btnSave);
            this.pnlBody.Controls.Add(this.rbOnProcess);
            this.pnlBody.Controls.Add(this.rbApproved);
            this.pnlBody.Controls.Add(this.txtboxApplicationNo);
            this.pnlBody.Controls.Add(this.textBox11);
            this.pnlBody.Controls.Add(this.textBox13);
            this.pnlBody.Controls.Add(this.textBox9);
            this.pnlBody.Controls.Add(this.txtboxCollege);
            this.pnlBody.Controls.Add(this.textBox3);
            this.pnlBody.Controls.Add(this.textBox5);
            this.pnlBody.Controls.Add(this.txtboxInvention);
            this.pnlBody.Controls.Add(this.textBox2);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 67);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(847, 421);
            this.pnlBody.TabIndex = 5;
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
            this.dtpDateApproved.TabIndex = 13;
            this.dtpDateApproved.Value = new System.DateTime(2022, 1, 28, 0, 0, 0, 0);
            // 
            // dtpDateFiled
            // 
            this.dtpDateFiled.CalendarFont = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateFiled.CustomFormat = "";
            this.dtpDateFiled.Font = new System.Drawing.Font("Gotham", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateFiled.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFiled.Location = new System.Drawing.Point(35, 190);
            this.dtpDateFiled.Name = "dtpDateFiled";
            this.dtpDateFiled.Size = new System.Drawing.Size(363, 43);
            this.dtpDateFiled.TabIndex = 3;
            this.dtpDateFiled.Value = new System.DateTime(2022, 1, 28, 0, 0, 0, 0);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(35, 114);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(363, 43);
            this.textBox5.TabIndex = 4;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlTitle.Controls.Add(this.lblNewPatent);
            this.pnlTitle.Controls.Add(this.pbPatent);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(847, 67);
            this.pnlTitle.TabIndex = 4;
            // 
            // lblNewPatent
            // 
            this.lblNewPatent.AutoSize = true;
            this.lblNewPatent.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewPatent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNewPatent.Location = new System.Drawing.Point(86, 19);
            this.lblNewPatent.Name = "lblNewPatent";
            this.lblNewPatent.Size = new System.Drawing.Size(227, 33);
            this.lblNewPatent.TabIndex = 1;
            this.lblNewPatent.Text = "NEW PATENT";
            // 
            // pbPatent
            // 
            this.pbPatent.Image = ((System.Drawing.Image)(resources.GetObject("pbPatent.Image")));
            this.pbPatent.Location = new System.Drawing.Point(35, 12);
            this.pbPatent.Name = "pbPatent";
            this.pbPatent.Size = new System.Drawing.Size(42, 49);
            this.pbPatent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPatent.TabIndex = 0;
            this.pbPatent.TabStop = false;
            // 
            // addPatentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 488);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addPatentForm";
            this.Text = "addPatentForm";
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbInventor;
        private Button btnCancel;
        private Button btnSave;
        private RadioButton rbOnProcess;
        private RadioButton rbApproved;
        private TextBox txtboxApplicationNo;
        private TextBox textBox11;
        private TextBox textBox13;
        private TextBox textBox9;
        private TextBox txtboxCollege;
        private TextBox textBox3;
        private TextBox txtboxInvention;
        private TextBox textBox2;
        private Panel pnlBody;
        private TextBox textBox5;
        private Panel pnlTitle;
        private Label lblNewPatent;
        private PictureBox pbPatent;
        private DateTimePicker dtpDateApproved;
        private DateTimePicker dtpDateFiled;
    }
}