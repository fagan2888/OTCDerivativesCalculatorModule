using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;


namespace RiskMonitor
{
    public class StepDownCppDLL
    {
        //[DllImport("D:\\Project File\\OTCDerivativesCalculatorModule\\Release\\StepDownKI_DLL.dll")]
        [DllImport("D:\\Project File\\OTCDerivativesCalculatorModule\\Debug\\StepDownKI_DLL.dll")]
        public static extern void calculationModule(string type,string a, string b, StringBuilder result, int len);

        public static string calculationLibCall(string instrumentXml,string parametorXml) 
        { 

            //string result = "";
            string type = "stepdownki";

            StringBuilder result = new StringBuilder(500);

            Console.WriteLine(instrumentXml);
            Console.WriteLine(parametorXml);

            calculationModule(type,instrumentXml, parametorXml, result, result.Capacity);

            Console.WriteLine(result);

            return result.ToString();

            //return "test_Result";
        }
    }
}
