using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace PrimeSolutions.Library
{
    class PurchaseCommon
    {
        SQLHelper _sql = new SQLHelper();
        public DataTable GetStock()
        {
        string str = "Select category,sub_category,purchase_amt,sale_amt from BillItem Where type= 'Purchase'";
            DataTable d1 =  _sql.GetDataTable(str);
            return d1;
        }
    }
}
