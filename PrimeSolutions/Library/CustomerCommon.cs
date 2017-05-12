using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeSolutions.Library
{
    class CustomerCommon
    {
        SQLHelper _Sql = new SQLHelper();

        public void AddCustomerDetails(string CustId,string Name,string Address,string Mobile,string ContactNo)
        {
            string str = "Insert into CustomerMaster(CustId,Name,Address,MobileNo,ContactNo) VALUES('"+CustId+"','"+Name+"','"+Address+"','"+Mobile+"','"+ContactNo+"') ";
            _Sql.ExecuteSql(str);
        }

        public bool checkCustomerAccount(string CustName)
        {
            string str = "SELECT count (*) FROM  CustomerMaster WHERE (Name = N'" + CustName + "')";
            int i = Convert.ToInt32(_Sql.ExecuteScalar(str));
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
