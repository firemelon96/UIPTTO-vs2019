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
    
    public partial class addCopyrightForm : Form
    {
        private mainDBContext db = new mainDBContext();
        CopyrightTable copyright = new CopyrightTable();

        copyrightForm cform;
        public addCopyrightForm(copyrightForm cf)
        {
            InitializeComponent();
            this.cform = cf;
        }

        private void rbApproved_CheckedChanged(object sender, EventArgs e)
        {
             dptApprovaldate.Enabled = rbApproved.Checked;
        }

        private void cbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuthor.SelectedItem != null)
            {
                int id;
                bool result = int.TryParse(cbAuthor.SelectedValue.ToString(), out id);
                if (result)
                {
                    var profile_id = db.ProfileTables
                    .Where(p => p.PId == id)
                    .FirstOrDefault<ProfileTable>();
                    if (profile_id != null)
                    {
                        txtboxCcollege.Text = profile_id.PCollege;
                    }
                }
                
            }
        }

        private void addCopyrightForm_Load(object sender, EventArgs e)
        {
            List<ProfileTable> profileTables = (from ProfileTable in db.ProfileTables select ProfileTable).ToList();

            profileTables.Insert(0, new ProfileTable
            {
                PId = 0,
                PFname = "select author"
            });
            cbAuthor.DataSource = profileTables;
            cbAuthor.DisplayMember = "PFullname";
            cbAuthor.ValueMember = "PId";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //var test = cbAuthor.SelectedValue.ToString();
            //MessageBox.Show(test);
            copyright.CTitle = txtboxCtitle.Text;
            copyright.CDateFiled = dptDatefiled.Value;
            copyright.CRegNo = Convert.ToInt32(txtboxCregno.Text);
            copyright.CApprDate = dptApprovaldate.Value;
            copyright.PId = Convert.ToInt32(cbAuthor.SelectedValue);
            if (rbApproved.Checked)
            {
                copyright.CApprDate = dptApprovaldate.Value;
            }
        }
    }
}
