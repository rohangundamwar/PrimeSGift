using PrimeSolutions.Library;
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
    public partial class frm_SaleForm : Form
    {
        public frm_SaleForm()
        {
            InitializeComponent();
        }

        Simplevalidations _objSimpal = new Simplevalidations();
        SQLHelper _objSQLHelper = new SQLHelper();
        clsCommon _common = new clsCommon();
        SaleCommon _Sale = new SaleCommon();
        CustomerCommon _Cust = new CustomerCommon();
        ErrorLog _error = new ErrorLog();

        private void frm_PurchaseForm_Load(object sender, EventArgs e)
        {
            Masterclear();
            cmb_Name.Select();
            this.BringToFront();
            Clear();
            txt_BillNo.Text = _objSQLHelper.gmGetMstID("S", "0");
            cmb_Category.DataSource = _common.GetCategory();
            cmb_SubCategory.DataSource = _common.GetSubCategory();
            txt_TaxPer.Text =Convert.ToString(_common.GetTax()) + '%';

        }

        private void Masterclear()
        {
            cmb_Name.ResetText();
            cmb_Category.SelectedIndex=-1;
            cmb_SubCategory.SelectedIndex = -1;
            cmb_SubCategory.ResetText();
            txt_AccNo.ResetText();
            txt_Address.ResetText();
            txt_BalAmt.ResetText();
            panel.ResetText();
            txt_City.ResetText();
            txt_ContactNo.ResetText();
            txt_MobileNo.ResetText();
            txt_NetAmt.ResetText();
            txt_PaidAmt.ResetText();
            txt_Qty.Text = "1";
            txt_TotalAmt.Text = "0";
            txt_Vat.ResetText();
            txt_SellingAmt.Text = "0";
            txt_BarcodeNo.ResetText();
            
        }
        
        private void cmb_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==  Keys.Enter)
            {
                txt_Address.Focus();
            }

        }

        private void txt_Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_City.Focus();
            }
        }

        private void txt_City_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ContactNo.Focus();
            }
        }

        private void txt_ContactNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_MobileNo.Focus();
            }
        }

        private void txt_MobileNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_BarcodeNo.Focus();
            }
        }

        private void txt_BillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Category.Focus();
            }

        }

        private void cmb_Category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_SubCategory.Focus();
            }
        }

        private void cmb_SubCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_SellingAmt.Select();
            }
        }

       

        private void txt_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Category.Select();
            }
            
        }
        
        private void bttn_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_TotalAmt.Focus();
            }
        }

        private void txt_TotalAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Vat.Focus();
            }
        }

        private void txt_Vat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_NetAmt.Focus();
            }
        }

        private void txt_NetAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PaidAmt.Focus();
            }
        }

        private void txt_PaidAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_BalAmt.Focus();
            }
        }

        private void txt_BalAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Sale.Focus();
            }
        }

        private void bttn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_PurchaseAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Qty.Focus();
            }
        }

        private void txt_SellingAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Amt.Focus();
            }
        }

        private void txt_Amt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Add.Focus();
            }
        }

        private void cmb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharOnly(e);
        }

        private void txt_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharDigitOnly(e);
        }

        private void txt_City_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharOnly(e);
        }

        private void txt_ContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitOnly(e);
        }

        private void txt_MobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitOnly(e);
        }

        private void txt_BillNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharDigitOnly(e);
        }

        private void cmb_Category_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharOnly(e);
        }

        private void cmb_SubCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationCharOnly(e);
        }

        private void txt_PurchaseAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_BarcodeNo.Text);
        }

        private void txt_SellingAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_SellingAmt.Text);
        }

        private void txt_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitOnly(e);
        }

        private void txt_Amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_Amt.Text);
        }

        private void txt_TotalAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_TotalAmt.Text);
        }

        private void txt_Vat_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_Vat.Text);
        }

        private void txt_NetAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_NetAmt.Text);
        }

        private void txt_PaidAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_PaidAmt.Text);
        }

        private void txt_BalAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _objSimpal.ValidationDigitWithPoint(e, txt_BalAmt.Text);
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Amt.Text = (Convert.ToDouble(txt_SellingAmt.Text) * Convert.ToDouble(txt_Qty.Text)).ToString();
            }
            catch { }
        }

        private void txt_BarcodeNo_TextChanged(object sender, EventArgs e)
        {
            if (txt_BarcodeNo.Text != "")
            {
                DataTable dt = _Sale.GetItemDetails(txt_BarcodeNo.Text);
                cmb_Category.Text = dt.Rows[0]["category"].ToString();
                cmb_SubCategory.Text = dt.Rows[0]["sub_category"].ToString();
                txt_SellingAmt.Text = dt.Rows[0]["sale_amt"].ToString();
                txt_Amt.Text = (Convert.ToDouble(txt_SellingAmt.Text) * Convert.ToDouble(txt_Qty.Text)).ToString();
                bttn_Add_Click(sender,e);
            }
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                
                dgv_ItemInfo.Rows.Add(txt_BarcodeNo.Text,cmb_Category.Text, cmb_SubCategory.Text, txt_SellingAmt.Text, txt_Qty.Text, txt_Amt.Text);
                Clear();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Calculate();
            
        }

        private void Clear()
        {
            cmb_Category.ResetText();
            cmb_SubCategory.ResetText();
            txt_Qty.Text = "1";
            txt_SellingAmt.Text = "0";
            txt_BarcodeNo.ResetText();
            txt_Amt.Text = "0";  
        }

        private void Calculate()
        {
            double total = _common.sumGridViewColumn(dgv_ItemInfo, "TotalAmt");
            
            txt_TotalAmt.Text = total.ToString();
        }

        private void bttn_Sale_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
             MessageBox.Show("Do you Want to Continue With Bill Amount of", txt_NetAmt.Text.ToString());
            if (cmb_Name.Text != "" || txt_ContactNo.Text != "")
            {
                if (!_Cust.checkCustomerAccount(cmb_Name.Text))
                {
                    _objSQLHelper.gmGetMstID("C", "0");
                    _Cust.AddCustomerDetails(txt_AccNo.Text, cmb_Name.Text, txt_Address.Text, txt_MobileNo.Text, txt_ContactNo.Text);
                }
            }
            try
            {

                for (int i = 0; i < dgv_ItemInfo.Rows.Count; i++)
                {
                    if (dgv_ItemInfo.Rows[i].Cells["BarcodeNo"].Value == "" ||
                        dgv_ItemInfo.Rows[i].Cells["BarcodeNo"].Value == string.Empty)
                    {
                        string Category = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value);
                        string SubCategory = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SubCategory"].Value);
                        string Amount = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SellingAmt"].Value);
                        //string narration = Convert.ToString(dgv_ItemInfo.Rows[i].Cells[" "].Value);
                        string BillNo = Convert.ToString(txt_BillNo.Text);
                        string AccNo = Convert.ToString(txt_AccNo.Text);

                        _Sale.AddItemDetails(Category, SubCategory, Amount, " ", BillNo, AccNo, date, "Sale");
                    }

                    else
                    {
                        _Sale.UpdateItem(Convert.ToString(dgv_ItemInfo.Rows[i].Cells["BarcodeNo"].Value), txt_BillNo.Text);
                    }

                }
                _Sale.AddBillDetails(txt_BillNo.Text, txt_AccNo.Text, txt_TotalAmt.Text, txt_Vat.Text, txt_NetAmt.Text, " ", date);
            }
            catch (Exception ex)
            {
                _error.AddException(ex, "Sale");
            }
            MessageBox.Show("Sale Successfully Done");
            Masterclear();
            
        }

        private void frm_SaleForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Add)
            {
                txt_TotalAmt.Focus();
            }
        }
    }
}
