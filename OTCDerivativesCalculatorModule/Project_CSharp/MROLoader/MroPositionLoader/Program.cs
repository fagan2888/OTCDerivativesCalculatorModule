using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MroPositionLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            //string positionPath_ = "D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\XmlFile\\book\\mrogen_position\\";
            string positionPath_ = @"D:\OTC_Batch\";

            Console.Write("Write Reference Date (yyyymmdd) : ");
            string referenceStr = Console.ReadLine();

            int yearStr = Convert.ToInt32(referenceStr.Substring(0, 4));
            int monthStr = Convert.ToInt32(referenceStr.Substring(4, 2));
            int dayStr = Convert.ToInt32(referenceStr.Substring(6, 2));

            DateTime refDate = new DateTime(yearStr, monthStr, dayStr);

            RiskMonitor.MROPositionDataLoader loader = new RiskMonitor.MROPositionDataLoader(refDate.ToString("yyyyMMdd"));

            loader.makePosition();
            loader.saveFile(positionPath_);

            Console.WriteLine("Generation Path Directory : " + positionPath_ );
            
        }
    }
}
