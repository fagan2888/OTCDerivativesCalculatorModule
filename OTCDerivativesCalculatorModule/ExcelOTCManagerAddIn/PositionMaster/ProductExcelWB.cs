using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelOTCManagerAddIn
{
    public class ProductExcelWB
    {

        private string fileName_;

        public ProductExcelWB(string fileName)
        {
            this.fileName_ = fileName;
        }

        public void openWB()
        {
            Excel.Application xl_app = (Microsoft.Office.Interop.Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");

            Excel.Workbook sourceWB = xl_app.Workbooks.Open(this.fileName_);

            sourceWB.SaveCopyAs("testMy.xls");

        }
    }
}
