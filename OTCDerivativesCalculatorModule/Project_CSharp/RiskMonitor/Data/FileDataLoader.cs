using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class FileDataLoader
    {
        public static string baseDir = "D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\XmlFile\\HistoryData\\";
        //public static string HistoryDir = "@D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\XmlFile\\HistoryData\\";
        
        public static string HistoryDir(DateTime referenceDate ,string filePath) 
        {
            //FileDataLoader.HistoryDir + code + "\\" + this.fileName_ + "_20130801"
            return "D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\XmlFile\\HistoryData\\50507A3616S0\\20130801_50507A3616S0.xml";
            //return "F:\\Users\\ahn\\Desktop\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\XmlFile\\HistoryData\\50507A3616S0\\20130801_50507A3616S0.xml";
        }

        public static string HistoryDir(string portfolioName ,DateTime referenceDate, string itemCode, string parameterStr)
        {
            return baseDir + referenceDate.ToString("yyyyMMdd") + "_" + itemCode + "_" + parameterStr + ".xml";
        }
    }
}
