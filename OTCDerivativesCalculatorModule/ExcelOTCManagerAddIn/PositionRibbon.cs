using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows;
using RiskMonitor;
using Excel = Microsoft.Office.Interop.Excel;
//using Office = Microsoft.Office.Core;
//using Microsoft.Office.Tools.Excel;
//using System.Runtime.InteropServices;

namespace ExcelOTCManagerAddIn
{
    public partial class PositionRibbon
    {
        //Data Source=D:\Project File\OTCDerivativesCalculatorModule\ExcelOTCManagerAddIn\PositionMasterInformationDB.sdf

        private InstPositionWrapperVM InstPositionWapperVM_ { get; set; }

        private void PositionRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        //private void button1_Click(object sender, RibbonControlEventArgs e)
        //{
        //    //PositionMasterView view = new PositionMasterView();

        //    ////view.ViewModel_. = InstPositionWapperVM_;

        //    //Window w = new Window();
        //    //w.Content = view;
            
        //    //w.Visibility = 0;

        //    //DataBaseManager dbManager = new DataBaseManager();

        //    //List<string> fieldName = new List<string>();
        //    //List<string> fieldValue = new List<string>();

        //    //fieldName.Add("KRCODE");
        //    //fieldName.Add("NAME");
        //    //fieldValue.Add("KR000000001");
        //    //fieldValue.Add("ELS1011");

        //    //dbManager.addInstDB("MasterInfo", fieldName, fieldValue);

        //}

        private PositionBookingInfoVM readPositionInfoFromExcel()
        {

            
            Excel.Application xl_app = (Microsoft.Office.Interop.Excel.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application");
            Excel.Workbook xl_workbook = null;
            xl_workbook = xl_app.ActiveWorkbook;
            Excel.Worksheet sheet = null;
            sheet = (Excel.Worksheet)xl_workbook.Worksheets.get_Item(1);


            //check book valid

            //Excel.Range newFirstRow = sheet.get_Range("TestName");


            //newFirstRow.Value2 = "OK";

            string itemcode = Convert.ToString(sheet.get_Range("itemcode").Value2);
            string krcode = Convert.ToString(sheet.get_Range("krcode").Value2);
            string teamcode = Convert.ToString(sheet.get_Range("teamcode").Value2);
            string fundcode = Convert.ToString(sheet.get_Range("fundcode").Value2);
            string bookID = Convert.ToString(sheet.get_Range("bookID").Value2);
            string excelType = Convert.ToString(sheet.get_Range("excelType").Value2);
            string productType = Convert.ToString(sheet.get_Range("productType").Value2);
            string groupID = Convert.ToString(sheet.get_Range("groupID").Value2);
            string groupState = Convert.ToString(sheet.get_Range("groupState").Value2);
            string itemname = Convert.ToString(sheet.get_Range("itemname").Value2);
            string shortName = Convert.ToString(sheet.get_Range("shortName").Value2);
            string issueDate = Convert.ToString(sheet.get_Range("issueDate").Value2);
            string maturityDate = Convert.ToString(sheet.get_Range("maturityDate").Value2);
            string underlying = Convert.ToString(sheet.get_Range("underlying").Value2);
            string counterParty = Convert.ToString(sheet.get_Range("counterParty").Value2);
            string contractType = Convert.ToString(sheet.get_Range("contractType").Value2);
            string notional = Convert.ToString(sheet.get_Range("notional").Value2);
            string currency = Convert.ToString(sheet.get_Range("currency").Value2);
            string bookedOrder = Convert.ToString(sheet.get_Range("bookedOrder").Value2);
            string bookingState = Convert.ToString(sheet.get_Range("bookingState").Value2);
            string bookingDate = Convert.ToString(sheet.get_Range("bookingDate").Value2);


            PositionBookingInfoVM vm = new PositionBookingInfoVM(itemcode,
                                                                krcode,
                                                                teamcode,
                                                                fundcode,
                                                                bookID,
                                                                excelType,
                                                                productType,
                                                                groupID,
                                                                groupState,
                                                                itemname,
                                                                shortName,
                                                                issueDate,
                                                                maturityDate,
                                                                underlying,
                                                                counterParty,
                                                                contractType,
                                                                notional,
                                                                currency,
                                                                bookedOrder,
                                                                bookingState,
                                                                bookingDate);

            return vm;

            //엑셀에서 로드해 갔고 InstPositionWapperVM_ 에 다가 박음
        }



        private void positionLoadBtn_Click(object sender, RibbonControlEventArgs e)
        {
            PositionMasterView view = new PositionMasterView();

            PositionMasterVM vm = new PositionMasterVM();

            view.ViewModel_ = vm;

            //view.ViewModel_. = InstPositionWapperVM_;

            Window w = new Window();
            w.Content = view;

            w.Visibility = 0;
        }

        private void newProductBtn_Click(object sender, RibbonControlEventArgs e)
        {
            NewProductView view = new NewProductView();

            view.ViewModel_ = new NewProductVM();
            view.ViewModel_.loadProductExcelWB();

            Window w = new Window();
            w.Content = view;

            w.Visibility = 0;

        }

        private void bookingBtn_Click(object sender, RibbonControlEventArgs e)
        {
            BookingPositionView view = new BookingPositionView();

            PositionBookingInfoVM vm = this.readPositionInfoFromExcel();

            view.ViewModel_ = vm;

            //view.ViewModel_. = InstPositionWapperVM_;

            Window w = new Window();
            w.Content = view;

            w.Visibility = 0;
        }

    }
}
