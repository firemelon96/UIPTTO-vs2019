namespace UIPTTO_DATABASE.childForms
{
    partial class backupForm
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
            this.btnAddCopyright = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCopyright
            // 
            this.btnAddCopyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnAddCopyright.FlatAppearance.BorderSize = 0;
            this.btnAddCopyright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCopyright.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCopyright.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCopyright.Image = global::UIPTTO_DATABASE.Properties.Resources.plus2;
            this.btnAddCopyright.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCopyright.Location = new System.Drawing.Point(12, 272);
            this.btnAddCopyright.Name = "btnAddCopyright";
            this.btnAddCopyright.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddCopyright.Size = new System.Drawing.Size(168, 53);
            this.btnAddCopyright.TabIndex = 19;
            this.btnAddCopyright.TabStop = false;
            this.btnAddCopyright.Text = "NEW";
            this.btnAddCopyright.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCopyright.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham Thin", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Backup/Restore the Database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "BACKUP";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::UIPTTO_DATABASE.Properties.Resources.plus2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 135);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(168, 53);
            this.button1.TabIndex = 19;
            this.button1.TabStop = false;
            this.button1.Text = "NEW";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // backupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 837);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddCopyright);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "backupForm";
            this.Text = "backupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddCopyright;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}