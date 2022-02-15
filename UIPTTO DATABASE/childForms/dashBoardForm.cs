using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIPTTO_DATABASE.Models;

namespace UIPTTO_DATABASE.childForms
{
    public partial class dashBoardForm : Form
    {
        private mainDBContext db = new mainDBContext();
        CopyrightTable copyrightTable = new CopyrightTable();
        public dashBoardForm()
        {
            InitializeComponent();
        }

        void copyrightCount()
        {
            var copyright = db.CopyrightTables.Count();
            lblcopyrightCount.Text = copyright.ToString();
        }

        private void dashBoardForm_Load(object sender, EventArgs e)
        {
            copyrightCount();
        }
    }
}
