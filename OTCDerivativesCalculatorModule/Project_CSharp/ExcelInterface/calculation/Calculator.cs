//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;
//using System.Runtime.InteropServices;

//namespace ExcelInterface
//{
//    public class Calculator
//    {

//        public XmlDocument InstXml_ { get; set; }
//        public XmlDocument ParaResultXml_ { get; set; }

//        public Calculator() 
//        { 
//            // dll 존재하는지 검사
//        }


//        public string loadInstrument(string path) 
//        {
//            InstXml_.Load(path);

//            return "";
//        }

//        public string loadParameter(string path)
//        {
//            ParaResultXml_.Load(path);

//            return "";
//        }

//        public string calculate()
//        {
//            return "";
//        }

//        [DllImport("D:\\Project File\\OTCDerivativesCalculatorModule\\Debug\\StepDownKI_DLL.dll")]
//        private void calculateFromDLL();


//    }
//}
