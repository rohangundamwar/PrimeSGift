using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSolutions.Library;

namespace PrimeSolutions.Report.Sale
{
    public partial class frm_SaleReport : Form
    {
        public frm_SaleReport()
        {
            InitializeComponent();
        }

        SaleCommon _s = new SaleCommon();
        clsCommon _common = new clsCommon();
        ExportToExcel _e = new ExportToExcel();

        private void bttn_generate_Click(object sender, EventArgs e)
        {
            dgv_CustomerItem.Rows.Clear();
           DataTable dt= _s.GetCustomerReport(dtp_date.Text);
            if(dt.Rows.Count>0)
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv_CustomerItem.Rows.Add();
                dgv_CustomerItem.Rows[i].Cells["BillNo"].Value = dt.Rows[i]["BillNo"].ToString();
                //dgv_CustomerItem.Rows[i].Cells["Name"].Value = dt.Rows[i]["Name"].ToString();
                dgv_CustomerItem.Rows[i].Cells["Amount"].Value = dt.Rows[i]["TotalAmount"].ToString();
                DataTable item = _s.GetBillItem(dt.Rows[i]["BillNo"].ToString());
                if(item.Rows.Count>0)
                dgv_CustomerItem.Rows[i].Cells["Item"].Value = item.Rows[0]["Category"].ToString();
                string name = _s.GetCustomerByCustid(dt.Rows[i]["CustomerId"].ToString());
                dgv_CustomerItem.Rows[i].Cells["Name"].Value = name;


                }
            
        }

        private void bttn_Excel_Click(object sender, EventArgs e)
        {
            _e.exporttoexcel(dgv_CustomerItem, "Daily Sale", dtp_date.Value.ToString("dd_MM_yyyy"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_SaleReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
