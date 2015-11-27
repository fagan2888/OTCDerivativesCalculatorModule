using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace CalculationSockerServer_CSharp_Win
{
    public class CalculationManager
    {
        public static List<Process> ProcessList_ = new List<Process>();
        //private string fileName = "calculation.exe";
        private string processFileName = @"D:\Project File\OTCDerivativesCalculatorModule\ExercutableCalculator_CSharp_Win\bin\Debug\ExercutableCalculator_CSharp_Win.exe";
        //

        public CalculationManager()
        {
            this.calcCount = 0;
        }

        //public string doCalculation()
        //{ 
        
        //}


        //public List<Process> 

        //public bool isCalculable()
        //{ 
        //    // check

        //    return true;

        //}

        //public int calculation()
        //{ 
            
        //}

        public bool isAcceptable()
        {
            if (this.calcCount > 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string calculate(string content)
        {
            //Thread.Sleep(10000);

            //string header = "<?xml version='1.0' encoding='UTF-8'?>";
            //string kk = "<pricingResult><price>0.151433</price><excel_greekResult><excel_greekUnderlying><delta>0.00139354</delta><gamma>-6.25278e-016</gamma><vega>0.0129804</vega></excel_greekUnderlying><excel_greekUnderlying><delta>-0.000507093</delta><gamma>0.0249467</gamma><vega>0.0129804</vega></excel_greekUnderlying><excel_greekUnderlying><delta>-0.00664364</delta><gamma>0.0276585</gamma><vega>0.0160237</vega></excel_greekUnderlying><theta>100</theta></excel_greekResult><excel_cashFlowsResult><excel_cashFlowResult><eventDate>41946</eventDate><type>0</type><value>0</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42038</eventDate><type>0</type><value>0.0063047</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42038</eventDate><type>0</type><value>0.0093044</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42127</eventDate><type>0</type><value>0.00889264</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42219</eventDate><type>0</type><value>0.0142917</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42219</eventDate><type>0</type><value>0.00679286</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42311</eventDate><type>0</type><value>0.00705671</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42403</eventDate><type>0</type><value>0.011851</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42403</eventDate><type>0</type><value>0.00566268</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42493</eventDate><type>0</type><value>0.00573297</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42585</eventDate><type>0</type><value>0.00669785</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42585</eventDate><type>0</type><value>0.00528168</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42677</eventDate><type>0</type><value>0.00547911</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42769</eventDate><type>0</type><value>0.00957374</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42769</eventDate><type>0</type><value>0.00473512</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42858</eventDate><type>0</type><value>0.00476513</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42950</eventDate><type>0</type><value>0.00731552</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42950</eventDate><type>0</type><value>-0.13935</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42950</eventDate><type>0</type><value>0.00441465</value></excel_cashFlowResult></excel_cashFlowsResult></pricingResult>";
            
            //content 를 세이브함.
            DateTime d = DateTime.Now;

            string instFileName = d.ToString("yyyyMMddffffff") + "_instInfo.xml";
            string resultFileName = d.ToString("yyyyMMddffffff") + "_resultInfo.xml";

            File.WriteAllText(instFileName, content);

            string arguments = instFileName + " " + resultFileName;

            Process p = new Process();

            ProcessStartInfo psi = new ProcessStartInfo(processFileName, arguments);
            p.StartInfo = psi;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = false;
            p.Start();

            p.WaitForExit();

            string result = File.ReadAllText(resultFileName);

            return result;

        }

        public string testCalculate()
        {
            //Thread.Sleep(10000);

            //string header = "<?xml version='1.0' encoding='UTF-8'?>";
            //string kk = "<pricingResult><price>0.151433</price><excel_greekResult><excel_greekUnderlying><delta>0.00139354</delta><gamma>-6.25278e-016</gamma><vega>0.0129804</vega></excel_greekUnderlying><excel_greekUnderlying><delta>-0.000507093</delta><gamma>0.0249467</gamma><vega>0.0129804</vega></excel_greekUnderlying><excel_greekUnderlying><delta>-0.00664364</delta><gamma>0.0276585</gamma><vega>0.0160237</vega></excel_greekUnderlying><theta>100</theta></excel_greekResult><excel_cashFlowsResult><excel_cashFlowResult><eventDate>41946</eventDate><type>0</type><value>0</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42038</eventDate><type>0</type><value>0.0063047</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42038</eventDate><type>0</type><value>0.0093044</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42127</eventDate><type>0</type><value>0.00889264</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42219</eventDate><type>0</type><value>0.0142917</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42219</eventDate><type>0</type><value>0.00679286</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42311</eventDate><type>0</type><value>0.00705671</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42403</eventDate><type>0</type><value>0.011851</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42403</eventDate><type>0</type><value>0.00566268</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42493</eventDate><type>0</type><value>0.00573297</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42585</eventDate><type>0</type><value>0.00669785</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42585</eventDate><type>0</type><value>0.00528168</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42677</eventDate><type>0</type><value>0.00547911</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42769</eventDate><type>0</type><value>0.00957374</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42769</eventDate><type>0</type><value>0.00473512</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42858</eventDate><type>0</type><value>0.00476513</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42950</eventDate><type>0</type><value>0.00731552</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42950</eventDate><type>0</type><value>-0.13935</value></excel_cashFlowResult><excel_cashFlowResult><eventDate>42950</eventDate><type>0</type><value>0.00441465</value></excel_cashFlowResult></excel_cashFlowsResult></pricingResult>";

            //content 를 세이브함.
            DateTime d = DateTime.Now;

            //string xmlFileName = d.ToString("yyyyMMddffffff") + "_test.xml";
            string xmlFileName = "mergedInstHist.xml result.xml";

            Process p = new Process();

            ProcessStartInfo psi = new ProcessStartInfo(processFileName, xmlFileName);
            p.StartInfo = psi;
            p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardOutput = false;
            p.Start();

            p.WaitForExit();

            string result = File.ReadAllText("result.xml");

            return result;

            //StreamReader sOut = p.StandardOutput;

            //Console.WriteLine(sOut.ReadToEnd());

            //return sOut.ReadToEnd();

            //return header + kk;
        }

        public int calcCount { get; set; }
    }
}
