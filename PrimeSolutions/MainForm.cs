using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void supplierDailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SaleForm _form = new frm_SaleForm();
            this.IsMdiContainer = true;
            _form.TopLevel = false;
            panel2.Controls.Add(_form);
            _form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel2.Height = _form.Height;
            panel2.Width = _form.Width;
            _form.Dock = DockStyle.Fill;
            _form.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PurchaseForm _form = new frm_PurchaseForm();
            this.IsMdiContainer = true;
            _form.TopLevel = false;
            panel2.Controls.Add(_form);
            _form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel2.Height = _form.Height;
            panel2.Width = _form.Width;
            _form.Dock = DockStyle.Fill;
            _form.Show();
        }
    }
}
