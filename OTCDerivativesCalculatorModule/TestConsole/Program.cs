using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace TestConsole
{
    class Program
    {
        static int Main(string[] args)
        {
            testSendSockeToParallelCalcM_Server();

            return 0;
        }

        public static void testSendSockeToParallelCalcM_Server()
        {
            AsynchronousClient.StartClient();
        }

        public static void testProcess()
        {
            Process myProcess = new Process();

            myProcess.StartInfo.UseShellExecute = true;

            myProcess.StartInfo.FileName = @"D:\Project File\OTCDerivativesCalculatorModule\ExercutableCalculator\bin\Debug\ExercutableCalculator.exe";
            myProcess.StartInfo.Arguments = "testArg1 testArg2";
            myProcess.StartInfo.CreateNoWindow = true;

            myProcess.Start();
        }

        //public static void testPing()
        //{
        //    Uri url = new Uri("www.codegain.com");
        //    string pingurl = string.Format("{0}", url.Host);
        //    string host = pingurl;
        //    bool result = false;
        //    Ping p = new Ping();
        //    try
        //    {
        //        PingReply reply = p.Send(host, 3000);
        //        if (reply.Status == IPStatus.Success)
        //            return true;
        //    }
        //    catch { }
            

        //}
    }
}
