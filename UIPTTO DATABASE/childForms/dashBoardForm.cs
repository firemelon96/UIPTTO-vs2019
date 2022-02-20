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

        void patentsCount()
        {
            var patent = db.PatentTables.Count();
            patentCount.Text = patent.ToString();
        }

        void issnCOunt()
        {
            var issn = db.IssnTables.Count();
            ISSNCount.Text = issn.ToString();
        }

        void isbnCOunt()
        {
            var isbn = db.IsbnTables.Count();
            ISBNCount.Text = isbn.ToString();
        }

        void trademarkCOunt()
        {
            var trademark = db.TrademarkTables.Count();
            trademarkCounts.Text = trademark.ToString();
        }

        private void dashBoardForm_Load(object sender, EventArgs e)
        {
            copyrightCount();
            patentsCount();
            issnCOunt();
            isbnCOunt();
            trademarkCOunt();
        }
    }
}
