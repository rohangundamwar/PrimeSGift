using BarTender;
using PrimeSolutions.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace PrimeSolutions.ClassFile
{
   
    public class AllClassFile
    {
        SQLHelper _objsqlhelper = new SQLHelper();
        BarTender.ApplicationClass btApp;
        BarTender.Format btFormat;
        BarTender.Messages btMsgs;
        public void InsertCustomerInfo(string accno, string name, string add, string city, string contact, string contact1, string billno , string date)
        {
            string str = " INSERT INTO SupplierMaster (AccNo, name, address, city, contact_no, phone_no, status,SupplierBillNo,SoftDate) VALUES('"+accno+ "','" + name + "','" + add + "','" + city + "','" + contact + "','" + contact1 + "','Supplier','" + billno + "','" + date + "')";
            _objsqlhelper.ExecuteScalar(str);
        }

        internal DataTable getBarcodeItem(string start, string end)
        {
            string str = "Select  Barcode,category,sub_category,purchase_amt,sale_amt,qty,Total From BillItem Where (Barcode != '') AND (CONVERT(DateTime,BillItem.SoftDate, 103) >= CONVERT(DateTime, '" + start + "', 103))  AND (CONVERT(DateTime, BillItem.SoftDate, 103) <= CONVERT(DateTime, '" + end + "', 103)) And type = 'Purchase'";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        public DataTable GetCategory()
        {
            string str = "Select * from CategoryMaster";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }
        public DataTable GetSubCategory()
        {
            string str = "Select * from SubCategoryMaster";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        internal void InsertItem(string barcode,string accno, string category, string subcategory, string purchaseamt,string size, string qty, string sellingamt, string total, string date,string Pbill)
        {
            string str = "INSERT INTO BillItem (Barcode,AccNo, category, sub_category, purchase_amt,sale_amt,size, qty, Total, type, SoftDate,PurchaseBill) VALUES ('" + barcode +"','"+accno+ "','" + category + "','" + subcategory + "','" + purchaseamt + "','" + sellingamt + "','"+size+"','" + qty + "','" + total + "','Purchase','" + date + "','"+Pbill+"')";
            _objsqlhelper.ExecuteScalar(str);
        }

        public void InsertCategory(string category)
        {
            string str = "Insert Into CategoryMaster (Category) values ('"+ category +"')";
            _objsqlhelper.ExecuteScalar(str);
        }

        public void InsertSubCategory(string Subcategory)
        {
            string str = "Insert Into SubCategoryMaster (SubCategory) values ('" + Subcategory + "')";
            _objsqlhelper.ExecuteScalar(str);
        }
        public object getCustomerName()
        {
            string str = "SELECT * From SupplierMaster";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        internal void updateCategory(string SrNo,string name)
        {
            string str = "Update CategoryMaster Set Category = '"+name+"' Where SrNo = '"+ SrNo + "' ";
            _objsqlhelper.ExecuteScalar(str);
        }
        internal void updateSubCategory(string SrNo, string name)
        {
            string str = "Update SubCategoryMaster Set SubCategory = '" + name + "' Where SrNo = '" + SrNo + "' ";
            _objsqlhelper.ExecuteScalar(str);
        }

        internal void DeleteCategory(string srno)
        {
            string str = "Delete  From CategoryMaster Where SrNo = '" + srno + "' ";
            _objsqlhelper.ExecuteScalar(str);
        }
        internal void DeleteSubCategory(string srno)
        {
            string str = "Delete  From SubCategoryMaster Where SrNo = '" + srno + "' ";
            _objsqlhelper.ExecuteScalar(str);
        }

        internal void InsertBillDetail(string billamt, string vatper, string vat, string totalamt, string paid, string bal, string accno,string date)
        {
            string str = "INSERT INTO PurchaseBillMaster (BillAmt, Vatper, VAT, TotalAmt, PaidAmt, BalanceAmt, AccNo,SoftDate) VALUES('" + billamt + "','" + vatper + "','" + vat + "','" + totalamt + "','" + paid + "','" + bal + "','" + accno + "','" + date + "')";
            _objsqlhelper.ExecuteScalar(str);
        }

        public void printBarcode(string barcode, string category, string subcategory, string purchaseamt, string sellingamt,string size, string total, int i)
        {
            btApp = new BarTender.ApplicationClass();
            btFormat = btApp.Formats.Open(Environment.CurrentDirectory + "\\Barcode.btw", false, "");
            try
            {
                btFormat.SetNamedSubStringValue("barcode", barcode);

            }
            catch { }
            try
            {
                btFormat.SetNamedSubStringValue("category", category);

            }
            catch { }
            try
            {
                btFormat.SetNamedSubStringValue("size", size);

            }
            catch { }
            try
            {
                btFormat.SetNamedSubStringValue("subcategory", subcategory);

            }
            catch { }
            
            try
            {
                btFormat.SetNamedSubStringValue("sellingamt", sellingamt);

            }
            catch { }
            
            btFormat.Print("Job" + (i + 1), false, -1, out btMsgs);
        }

        public void printBarcode(string barcode1,string  barcode2, string category1, string category2, string subcategory1, string subcategory2,string sellingamt1,string sellingamt2,string size1,string size2,int i)
        {
            btApp = new BarTender.ApplicationClass();
            btFormat = btApp.Formats.Open(System.Windows.Forms.Application.StartupPath + "\\Barcode2.btw", false, "");
            try
            {
                btFormat.SetNamedSubStringValue("barcode1", barcode1);
                btFormat.SetNamedSubStringValue("barcode2", barcode2);

            }
            catch { }
            try
            {
                btFormat.SetNamedSubStringValue("category1", category1);
                btFormat.SetNamedSubStringValue("category2", category2);

            }
            catch { }
            try
            {
                btFormat.SetNamedSubStringValue("subcategory1", subcategory1);
                btFormat.SetNamedSubStringValue("subcategory2", subcategory2);

            }
            catch { }
            
            try
            {
                btFormat.SetNamedSubStringValue("sellingamt1", sellingamt1);
                btFormat.SetNamedSubStringValue("sellingamt2", sellingamt2);

            }
            catch { }
            try
            {
                btFormat.SetNamedSubStringValue("size1", size1);
                btFormat.SetNamedSubStringValue("size2", size2);

            }
            catch { }
            btFormat.Print("Job" + (i + 1), false, -1, out btMsgs);

        }

        public DataTable GetSupplier( string name)
        {
            string str = "Select * From SupplierMaster where name = '"+name+"'";
            DataTable dt = _objsqlhelper.GetDataTable(str);
            return dt;
        }

        internal bool SupplierDetail(string CustName)
        {
            string str = "SELECT count (*) FROM  SupplierMaster WHERE (name = '" + CustName + "') ";
            int i = Convert.ToInt32(_objsqlhelper.ExecuteScalar(str));
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getbarcode()
        {
            string str = "Select BarcodeCount from setting";
            int barcode = Convert.ToInt32(_objsqlhelper.ExecuteScalar(str));
            return barcode;
        }

        
    }

}
