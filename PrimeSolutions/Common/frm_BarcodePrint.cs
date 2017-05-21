using PrimeSolutions.ClassFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSolutions.Common
{
    public partial class frm_BarcodePrint : Form
    {
        public frm_BarcodePrint()
        {
            InitializeComponent();
        }
        AllClassFile _objBarcode = new AllClassFile();
        private void bttn_View_Click(object sender, EventArgs e)
        {
            DataTable dt = _objBarcode.getBarcodeItem(dtp_Start.Text, dtp_End.Text);
            if (rbt_SellectAll.Checked == true)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgv_BarcodeDetail.Rows.Add();
                    dgv_BarcodeDetail.Rows[i].Cells["Srno"].Value = i + 1;
                    dgv_BarcodeDetail.Rows[i].Cells["Barcode"].Value = dt.Rows[i]["Barcode"].ToString();
                    dgv_BarcodeDetail.Rows[i].Cells["Category"].Value = dt.Rows[i]["category"].ToString();
                    dgv_BarcodeDetail.Rows[i].Cells["SubCategory"].Value = dt.Rows[i]["sub_category"].ToString();
                    dgv_BarcodeDetail.Rows[i].Cells["PurchaseAmt"].Value = dt.Rows[i]["purchase_amt"].ToString();
                    dgv_BarcodeDetail.Rows[i].Cells["SellingAmt"].Value = dt.Rows[i]["sale_amt"].ToString();
                    dgv_BarcodeDetail.Rows[i].Cells["Total"].Value = dt.Rows[i]["Total"].ToString();
                    dgv_BarcodeDetail.Rows[i].Cells["Qty"].Value = dt.Rows[i]["qty"].ToString();
                }
            
            }

        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
