using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace PrimeSolutions.Library
{
    public class SaleCommon
    {
        SQLHelper _sql = new SQLHelper();
        public void AddBillDetails(string BillNo,string CustomerId,string BillAmt,string VAT,string TotalAmt,string Discount,DateTime date)
        {
            string str = "Insert into SaleBillMaster(BillNo,CustomerId,BillAmount,VAT,TotalAmount,Discount,date)Values('"+BillNo+"','"+CustomerId+"','"+BillAmt+"','"+VAT+"','"+TotalAmt+"','"+Discount+"','"+date+"')";
            _sql.ExecuteSql(str);
        }

        public void UpdateItem(string ItemId, string SaleBill)
        {
            string str = "Update BillItem Set type= 'Sale',SaleBillNo='"+SaleBill+ "' Where Barcode='" + ItemId + "'";
            _sql.ExecuteSql(str);
        }

        public void AddItemDetails(string Category, string SubCategory, string Amount,string narration,string BillNo,string AccNo,DateTime date,string Sale)
        {
            string str = "Insert into BillItem(category,sub_category,sale_amt,narration,SaleBillNo,AccNo,date,status) Values('" + Category + "','" + SubCategory + "','" + Amount + "','" + narration + "','" + BillNo + "','" + AccNo + "','" + date + "','"+Sale+"') ";
            _sql.ExecuteSql(str);
        }

        public DataTable GetItemDetails(string Barcode)
        {
            string str = "Select * from BillItem where Barcode = '"+Barcode+"'" ;
            DataTable dt = _sql.GetDataTable(str);
            return dt;
        }             
     }
}
