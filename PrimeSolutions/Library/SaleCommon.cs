using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            string str = "Update BillItem Set status= 'Sale',SaleBillNo='"+SaleBill+"' Where ItemID='" + ItemId + "'";
            _sql.ExecuteSql(str);
        }

        public void AddItemDetails(string Category, string SubCategory, string Amount,string narration,string BillNo,string AccNo,DateTime date,string Sale)
        {
            string str = "Insert into BillItem(category,sub_category,sale_amt,narration,SaleBillNo,AccNo,date,status) Values('" + Category + "','" + SubCategory + "','" + Amount + "','" + narration + "','" + BillNo + "','" + AccNo + "','" + date + "','"+Sale+"') ";
            _sql.ExecuteSql(str);
        }

    }
}
