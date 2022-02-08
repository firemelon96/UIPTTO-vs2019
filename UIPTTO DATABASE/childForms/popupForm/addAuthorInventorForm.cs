﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIPTTO_DATABASE.Models;
using UIPTTO_DATABASE.childForms;


namespace UIPTTO_DATABASE.childForms.popupForm
{
    public partial class addAuthorInventorForm : Form
    {
        
        private mainDBContext db = new mainDBContext();
        ProfileTable profileTable = new ProfileTable();

        profileForm pform;
        public addAuthorInventorForm(profileForm pf)
        {
            InitializeComponent();
            this.pform = pf;
        }

        private void addAuthorInventorForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            profileTable.PFname = txtboxFirstName.Text.Trim();
            profileTable.PLname = txtboxLastName.Text.Trim();
            profileTable.PEmail = txtboxEmail.Text.Trim();
            profileTable.PCollege = txtboxCollege.Text.Trim();
            if (rbMale.Checked)
            {
                profileTable.PGender = "male";
            }
            else
            {
                profileTable.PGender = "female";
            }
            profileTable.PDob = dtpDOB.Value;
            //profileTable.PFname = txtboxFirstName.Text.Trim();
            if (profileTable.PId == 0)
            {
                db.ProfileTables.Add(profileTable);
                db.SaveChanges();
                MessageBox.Show("Author Profile added Successfully!");
            }
            else
            {
                db.Entry(profileTable).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            pform.populateDgv();
        }
    }
}
