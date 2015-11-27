using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Runtime.InteropServices;

namespace TestCppDLL
{
    public class InstPricing
    {
        [DllImport("D:\\Project File\\OTCDerivativesCalculatorModule\\Debug\\StepDownKI_DLL.dll")]
        public static extern void stepDownELSFactory(string a, string b, StringBuilder result, int len);

        public InstPricing()
        {
        
        }

        public InstPricing(string instName) 
        {
            this.instName_ = instName;
        }

        public void pricing()
        {
            XmlDocument instDoc = new XmlDocument();
            instDoc.Load("D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\TestCppDLL\\XmlFile\\ELS" + instName_ + "_InstInformation.xml");

            XmlDocument paraDoc = new XmlDocument();
            paraDoc.Load("D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\TestCppDLL\\XmlFile\\ELS" + instName_ + "_Underlying.xml");

            string instText = instDoc.InnerXml;
            string paraText = paraDoc.InnerXml;

            StringBuilder result = new StringBuilder(500);

            //Console.WriteLine(instText);
            //Console.WriteLine(paraText);

            stepDownELSFactory(instText, paraText, result, result.Capacity);
            
            //Console.WriteLine(result);

        }


        public string instName_ { get; set; }
    }
}
