using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIPTTO_DATABASE.childForms.popupForm;
using UIPTTO_DATABASE.Models;
using Microsoft.EntityFrameworkCore;

namespace UIPTTO_DATABASE.childForms
{
    public partial class trademarkForm : Form
    {
        private mainDBContext db = new mainDBContext();
        TrademarkTable trademark = new TrademarkTable();
        public trademarkForm()
        {
            InitializeComponent();
        }

        private void btnAddTrademarks_Click(object sender, EventArgs e)
        {
            addTradmarkForm addTradmarkForm = new addTradmarkForm();
            addTradmarkForm.ShowDialog();
        }
    }
}
