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
            DataTable dt3 = _objBarcode.GetCategory(); //Category
            DataTable dt1 = new DataTable(); //SubCategory
            DataTable dt2 = new DataTable(); // Size
            string a;
            int x = 0, gcount = 0;

            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                dt1 = _objBarcode.GetSubCategoryByCategory(dt3.Rows[i]["category"].ToString());
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    dt2 = _objBarcode.GetSizeByCatAndSubCat(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString());
                    for (int k = 0; k < dt2.Rows.Count; k++)
                    {
                        dgv_BarcodeDetail.Rows.Add();
                        x = x + 1;
                        dgv_BarcodeDetail.Rows[gcount].Cells["SrNo"].Value = Convert.ToString(x);
                        dgv_BarcodeDetail.Rows[gcount].Cells["Category"].Value = dt3.Rows[i]["category"].ToString();
                        dgv_BarcodeDetail.Rows[gcount].Cells["SubCategory"].Value = dt1.Rows[j]["sub_category"].ToString();
                        DataTable X = _objBarcode.GetSizeByCatAndSubCat(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString());
                        dgv_BarcodeDetail.Rows[gcount].Cells["Size"].Value = X.Rows[k]["size"].ToString();
                        DataTable Q = _objBarcode.GetSizeByCatAndSubCat(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString());

                        if (Q.Rows.Count > 0)
                        {
                            a = Convert.ToString(_objBarcode.getQty(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString(), X.Rows[k]["size"].ToString()));
                            dgv_BarcodeDetail.Rows[gcount].Cells["Quantity"].Value = a.ToString();
                        }
                        else
                        {
                            a = Convert.ToString(_objBarcode.getQty(dt3.Rows[i]["category"].ToString(), dt1.Rows[j]["sub_category"].ToString(), ""));
                            dgv_BarcodeDetail.Rows[gcount].Cells["Quantity"].Value = a.ToString();
                        }
                        gcount = gcount + 1;
                    }

                }

            }

        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_Print_Click(object sender, EventArgs e)
        {

        }
    }
}
