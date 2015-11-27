using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Excel_Interface
{
    public class CalculationModuleDLL
    {
        //[DllImport("D:\\Project File\\OTCDerivativesCalculatorModule\\Release\\StepDownKI_DLL.dll")]
        [DllImport("D:\\Project File\\OTCDerivativesCalculatorModule\\Debug\\testDLL.dll")]
        public static extern void testFunction(string calculationType, 
                                                string instInfo, 
                                                string paraInfo, 
                                                string historyInfo, 
                                                int dateSerialNum,
                                                StringBuilder result,
                                                StringBuilder log, 
                                                int len);

        //public static string calculationLibCall(string calculationType,
        public static string calculationLibCall(string calculationType,
                                                string instrumentXml, 
                                                string parametorXml, 
                                                string underHistData,
                                                DateTime refDate)
        {

            DBCalendar dbC = new DBCalendar();

            //string result = "";
            //string type = "stepdownki";

            StringBuilder result = new StringBuilder(10000);
            StringBuilder log = new StringBuilder(500);

            
            //Console.WriteLine(instrumentXml);
            //Console.WriteLine(parametorXml);

            testFunction(calculationType, instrumentXml, parametorXml, underHistData, dbC.serialNumber(refDate), result, log, result.Capacity);

            //Console.WriteLine(result);

            //return result.ToString();

            return result.ToString();
        }

        //[DllImport("D:\\Project File\\OTCDerivativesCalculatorModule\\Debug\\testDLL.dll")]
        //public static extern void calculate(string fileName, StringBuilder result);

        //public static string calculationLibCall(string fileName)
        //{
        //    StringBuilder result = new StringBuilder(10000);

        //    calculate(fileName, result);

        //    return result.ToString();

        //}

    }

}
