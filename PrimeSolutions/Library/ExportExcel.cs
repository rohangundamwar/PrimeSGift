using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using PrimeSolutions.Library;
using ClosedXML;
using System.IO;

namespace PrimeSolutions.Library
{
    class ExportToExcel
    {
        ErrorLog _error = new ErrorLog();
        clsCommon _objCommon = new clsCommon();
        

        public void exporttoexcel(DataTable dt, string Name)
        {
            try
            {
                ClosedXML.Excel.XLWorkbook wbook = new ClosedXML.Excel.XLWorkbook();
                wbook.Worksheets.Add(dt, Name);
                try
                {
                    string folder = Environment.CurrentDirectory + "/ExcelReport/";
                    // If directory does not exist, don't even try 
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }

                    wbook.SaveAs(Environment.CurrentDirectory + "/ExcelReport/" + Name + ".xlsx");
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
                MessageBox.Show("Excelsheet saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Check Spire.Office.dll if missing");
                int line = _error.GetLineNumber(ex);
                _error.AddException(ex, "ExportToExcel");
            }
        }


        public void exporttoexcel(DataGridView dgv, string Name,string date)
        {
            try
            {
                DataTable dt = _objCommon.DataGridView2DataTable(dgv,"",0);
                
                Name = Name + date;
                ClosedXML.Excel.XLWorkbook wbook = new ClosedXML.Excel.XLWorkbook();
                wbook.Worksheets.Add(dt, Name);
                try
                {
                    string folder = Environment.CurrentDirectory + "/ExcelReport/";
                    // If directory does not exist, don't even try 
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }

                    wbook.SaveAs(Environment.CurrentDirectory + "/ExcelReport/" + Name +".xlsx");
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
                MessageBox.Show("Excelsheet saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Check Spire.Office.dll if missing");
                int line = _error.GetLineNumber(ex);
                _error.AddException(ex, "ExportToExcel");
            }
        }
    }

}

