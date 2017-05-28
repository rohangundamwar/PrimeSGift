using PrimeSolutions.ClassFile;
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
    public partial class frm_PurchaseForm : Form
    {
        public frm_PurchaseForm()
        {
           
            InitializeComponent();
        }

        Simplevalidations _objSimpal = new Simplevalidations();
        SQLHelper _objSQLHelper = new SQLHelper();
        Validation _objValidation = new Validation();
        AllClassFile _objCustmor = new AllClassFile();
        ErrorLog _error = new ErrorLog();
        Setting datasv;

        private void frm_PurchaseForm_Load(object sender, EventArgs e)
        {
            fiicomboox();
            Masterclear();
            cmb_Name.Select();
            this.BringToFront();
            
            
        
        }

        private void fiicomboox()
        {
            cmb_Name.DataSource = _objCustmor.getCustomerName();
            cmb_Category.DataSource = _objCustmor.GetCategory();
            cmb_SubCategory.DataSource = _objCustmor.GetSubCategory();
        }

        private void Masterclear()
        {
            cmb_Name.SelectedIndex = -1;
            cmb_Category.SelectedIndex = -1;
            cmb_SubCategory.SelectedIndex = -1;
            txt_Address.ResetText();
            txt_BalAmt.Text = "0";
            txt_BillNo.ResetText();
            txt_City.ResetText();
            txt_ContactNo.ResetText();
            txt_MobileNo.ResetText();
            txt_NetAmt.Text = "0";
            txt_PaidAmt.Text = "0";
            txt_Qty.Text = "0";
            txt_TotalAmt.ResetText();
            txt_Vat.ResetText();
            txt_SellingAmt.Text = "0";
            txt_PurchaseAmt.Text = "0";
            txt_Vat.Text = "0";
            txt_TotalAmt.Text = "0";
            dgv_ItemInfo.Rows.Clear();
            try
            {
                txt_AccNo.Text = _objSQLHelper.gmGetMstID("P", "0");
            }
            catch(Exception ex)
            {
            }
            chbk_barcode.Checked = true;

        }

        private void cmb_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==  Keys.Enter)
            {
                fillSupplier();
                txt_Address.Focus();
            }

        }

        private void fillSupplier()
        {
            DataTable dt = _objCustmor.GetSupplier(cmb_Name.Text);
            if (dt.Rows.Count > 0)
            {
                txt_AccNo.Text = dt.Rows[0]["AccNo"].ToString();
                txt_Address.Text = dt.Rows[0]["address"].ToString();
                txt_City.Text = dt.Rows[0]["city"].ToString();
                txt_ContactNo.Text = dt.Rows[0]["contact_no"].ToString();
                txt_MobileNo.Text = dt.Rows[0]["phone_no"].ToString();
            }
            else
            { }
           
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
                txt_BillNo.Focus();
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
            if (e.KeyCode == Keys.F10)
            {
                txt_PaidAmt.Focus();
            }
        }

        private void cmb_SubCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_PurchaseAmt.Focus();
            }
        }

       

        private void txt_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Amt.Focus();
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
                txt_VatValue.Focus();
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
                bttn_Purchase.Focus();
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
                txt_SellingAmt.Focus();
            }
        }

        private void txt_SellingAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Size.Focus();
            }
        }

        private void txt_Amt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttn_Add_Click(sender,e);
                cmb_Category.Select();
                Clear();
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
            _objSimpal.ValidationDigitWithPoint(e, txt_PurchaseAmt.Text);
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
                txt_Amt.Text = (Convert.ToDouble(txt_PurchaseAmt.Text) * Convert.ToDouble(txt_Qty.Text)).ToString();
            }
            catch { }
        }

        private void txt_PurchaseAmt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Amt.Text = (Convert.ToDouble(txt_PurchaseAmt.Text) * Convert.ToDouble(txt_Qty.Text)).ToString();
            }
            catch (Exception ex)
            { }
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            try
            {

                
                dgv_ItemInfo.Rows.Add(cmb_Category.Text, cmb_SubCategory.Text, txt_PurchaseAmt.Text, txt_Qty.Text, txt_SellingAmt.Text, txt_Amt.Text,txt_BillNo.Text,txt_Size.Text);
                Clear();
                
            }
            catch(Exception ex)
            {
                _error.AddException(ex, "Purchase");
            }
            Calculate();
        }

        private void Clear()
        {
            cmb_Category.ResetText();
            cmb_SubCategory.ResetText();
            txt_Qty.Text = "0";
            txt_SellingAmt.Text = "0";
            txt_PurchaseAmt.Text = "0";
            txt_Size.Text = "";
            txt_Amt.Text = "";
        }

        private void frm_PurchaseForm_Leave(object sender, EventArgs e)
        {
            
        }

        private void frm_PurchaseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Calculate()
        {
            double total = 0;

            for (int i = 0; i < dgv_ItemInfo.Rows.Count; i++)
            {
                total += Convert.ToInt32(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
            }

            txt_TotalAmt.Text = total.ToString();
            try
            {
                if (txt_VatValue.Text == "")
                {
                    txt_Vat.Text = "0";
                   
                }
                else
                {
                    txt_Vat.Text = ((Convert.ToDouble(txt_TotalAmt.Text) * Convert.ToDouble(txt_VatValue.Text)) / 100).ToString();
                }
                txt_NetAmt.Text = (Convert.ToDouble(txt_TotalAmt.Text) + Convert.ToDouble(txt_Vat.Text)).ToString();
                txt_BalAmt.Text = (Convert.ToDouble(txt_NetAmt.Text) - Convert.ToDouble(txt_PaidAmt.Text)).ToString();
            }
            catch (Exception ex)
            { }
        }

        private void txt_Vat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_VatValue_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txt_PaidAmt_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txt_VatValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Vat.Focus();
            }
        }

        private void txt_BalAmt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void bttn_Purchase_Click(object sender, EventArgs e)
        {
            int BarcodeCount = _objCustmor.getbarcode();
            if (checkData())
            {
                if (!_objCustmor.SupplierDetail(cmb_Name.Text))
                {
                    _objCustmor.InsertCustomerInfo(txt_AccNo.Text, cmb_Name.Text, txt_Address.Text, txt_City.Text, txt_ContactNo.Text, txt_MobileNo.Text, txt_BillNo.Text, dtp_Date.Text);
                }
                for (int i = 0; i < dgv_ItemInfo.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgv_ItemInfo.Rows[i].Cells["Qty"].Value) == 1)
                    {
                        if (BarcodeCount == 1)
                        {
                            string barcode = _objSQLHelper.gmGetMstID("B", "0");
                            string category = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value);
                            string subcategory = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SubCategory"].Value);
                            string purchaseamt = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PurchaseAmt"].Value);
                            //string qty = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Qty"].Value);
                            string sellingamt = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SellingAmt"].Value);
                            string Total = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                            string PBillNo = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PBill"].Value);
                            string size = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["size"].Value);
                            _objCustmor.InsertItem(barcode, txt_AccNo.Text, category, subcategory, purchaseamt, size, "1", sellingamt, Total, dtp_Date.Text, PBillNo);
                            if (chbk_barcode.Checked == true)
                            {
                                _objCustmor.printBarcode(barcode, category, subcategory, purchaseamt, sellingamt,size, Total, i);

                            }
                        }
                        else if (BarcodeCount == 2)
                        {
                            int Qty = Convert.ToInt32(Convert.ToInt32(dgv_ItemInfo.Rows[i].Cells["Qty"].Value));
                            for (int j = 0; j < Qty; j++)
                            {
                                string barcode2 = "";
                                string category2 = "";
                                string subcategory2 = "";
                                string sellingamt2 = "";
                                string size2 = "";
                                string barcode1 = _objSQLHelper.gmGetMstID("B", "0");
                                string category1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value);
                                string subcategory1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SubCategory"].Value);
                                string purchaseamt1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PurchaseAmt"].Value);
                                //string qty = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Qty"].Value);
                                string sellingamt1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SellingAmt"].Value);
                                string Total1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                                string PBillNo1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PBill"].Value);
                                string size1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["size"].Value);
                                _objCustmor.InsertItem(barcode1, txt_AccNo.Text, category1, subcategory1, purchaseamt1, size1, "1", sellingamt1, Total1, dtp_Date.Text, PBillNo1);
                                if (chbk_barcode.Checked == true)
                                {
                                    _objCustmor.printBarcode(barcode1, barcode2, category1, category2, subcategory1, subcategory2, sellingamt1, sellingamt2, size1, size2, j);

                                }
                                j++;
                            }
                        }
                    }
                    else if (Convert.ToInt32(dgv_ItemInfo.Rows[i].Cells["Qty"].Value) > 1)
                    {
                        if(BarcodeCount==1)
                        { 
                        int Qty = Convert.ToInt32(Convert.ToInt32(dgv_ItemInfo.Rows[i].Cells["Qty"].Value));
                        for (int j = 0; j < Qty; j++)
                        {
                            string barcode = _objSQLHelper.gmGetMstID("B", "0");
                            string category = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value);
                            string subcategory = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SubCategory"].Value);
                            string purchaseamt = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PurchaseAmt"].Value);
                            //string qty = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Qty"].Value);
                            string sellingamt = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SellingAmt"].Value);
                            string Total = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                            string PBillNo = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PBill"].Value);
                            string size = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["size"].Value);
                            _objCustmor.InsertItem(barcode, txt_AccNo.Text, category, subcategory, purchaseamt,size, "1", sellingamt, Total, dtp_Date.Text, PBillNo);
                            if (chbk_barcode.Checked == true)
                            {
                                _objCustmor.printBarcode(barcode, category, subcategory, purchaseamt, sellingamt,size,Total, i);
                            }
                        }
                        }
                        else if (BarcodeCount == 2)
                        {
                            int Qty = Convert.ToInt32(Convert.ToInt32(dgv_ItemInfo.Rows[i].Cells["Qty"].Value));
                            for (int j = 0; j < Qty; j++)
                            {
                                string barcode2 = "";
                                string category2 = "";
                                string subcategory2 = "";
                                string sellingamt2 = "";
                                string size2 = "";
                                string barcode1 = _objSQLHelper.gmGetMstID("B", "0");
                                string category1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value);
                                string subcategory1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SubCategory"].Value);
                                string purchaseamt1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PurchaseAmt"].Value);
                                //string qty = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Qty"].Value);
                                string sellingamt1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SellingAmt"].Value);
                                string Total1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                                string PBillNo1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PBill"].Value);
                                string size1 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["size"].Value);
                                _objCustmor.InsertItem(barcode1, txt_AccNo.Text, category1, subcategory1, purchaseamt1,size1, "1", sellingamt1, Total1, dtp_Date.Text, PBillNo1);
                                if (Qty-j>=2)
                                {
                                    barcode2 = _objSQLHelper.gmGetMstID("B", "0");
                                    category2 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Category"].Value);
                                    subcategory2 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SubCategory"].Value);
                                    string purchaseamt2 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PurchaseAmt"].Value);
                                    //string qty = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["Qty"].Value);
                                    sellingamt2 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["SellingAmt"].Value);
                                    string Total2 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["TotalAmt"].Value);
                                    string PBillNo2 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["PBill"].Value);
                                    size2 = Convert.ToString(dgv_ItemInfo.Rows[i].Cells["size"].Value);
                                    _objCustmor.InsertItem(barcode2, txt_AccNo.Text, category2, subcategory2, purchaseamt2, size2, "1", sellingamt2, Total1, dtp_Date.Text, PBillNo1);
                                    
                                }
                                if (chbk_barcode.Checked == true)
                                {
                                    _objCustmor.printBarcode(barcode1, barcode2, category1, category2, subcategory1, subcategory2, sellingamt1, sellingamt2, size1, size2, j);

                                }
                                j++;
                            }
                        }
                    }
     
                        _objCustmor.InsertBillDetail(txt_TotalAmt.Text, txt_VatValue.Text, txt_Vat.Text, txt_NetAmt.Text, txt_PaidAmt.Text, txt_BalAmt.Text, txt_AccNo.Text, dtp_Date.Text);
                    
                }
                Masterclear();
                MessageBox.Show("Purchased Done");
                cmb_Name.Select();
            }
        }
        private bool checkData()
        {
            if (_objValidation.IsNotEmpty(txt_AccNo.Text))
            {
                if (_objValidation.IsNotEmpty(cmb_Name.Text))
                {
                    if (dgv_ItemInfo.Rows.Count != 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Please enter Item Into the Cart", "Software Says", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            try {

                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Category"].Value = cmb_Category.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SubCategory"].Value = cmb_SubCategory.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["PurchaseAmt"].Value = txt_PurchaseAmt;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SellingAmt"].Value = txt_SellingAmt.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["size"].Value = txt_Size.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Qty"].Value = txt_Qty.Text;
                dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["TotalAmt"].Value = txt_TotalAmt.Text;
                Calculate();
                MessageBox.Show("");
            }
            catch (Exception ex)
            {
                _error.AddException(ex, "Purchase");
            }
            bttn_Add.Enabled = true;
            Clear();

        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
           
        }

        private void dgv_ItemInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex >= -1)
                {
                    bttn_Delete.Enabled = true;
                    bttn_Update.Enabled = true;
                    bttn_Add.Enabled = false;
                    cmb_Category.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Category"].Value.ToString();
                    cmb_SubCategory.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SubCategory"].Value.ToString();
                    
                    txt_PurchaseAmt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["PurchaseAmt"].Value.ToString();
                    txt_SellingAmt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["SellingAmt"].Value.ToString();
                    txt_Size.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["size"].Value.ToString();
                    txt_Qty.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["Qty"].Value.ToString();
                    txt_Amt.Text = dgv_ItemInfo.Rows[dgv_ItemInfo.CurrentRow.Index].Cells["TotalAmt"].Value.ToString();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                _error.AddException(ex,"Purchase");
            }
        }

        private void txt_Size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Qty.Focus();
            }
        }
    }
}
