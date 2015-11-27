using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;

namespace CalculationSockerServer_CSharp_Win
{
    public class CalculationStartJob : IJobAction
    {
        public CalculationStartJob()
        {

        }

        private void instrumentListLoad()
        { 
            // 읽어옴
        }

        public void DoJob()
        {
            

            //./client.StartClient("testMessage");

            //Task[] taskArray = { Task.Factory.StartNew(() => asynchronousClientList[0].StartClient("testMessage1")),
            //                     Task.Factory.StartNew(() => asynchronousClientList[1].StartClient("testMessage2")),
            //                     Task.Factory.StartNew(() => asynchronousClientList[2].StartClient("testMessage3")),
            //                     Task.Factory.StartNew(() => asynchronousClientList[3].StartClient("testMessage4")),
            //                     Task.Factory.StartNew(() => asynchronousClientList[4].StartClient("testMessage5"))
            //                     };

            //var results = new string[taskArray.Length];

            //Task.WaitAll(taskArray);     

            //for (int i = 0; i < taskArray.Length; i++)
            //{
            //    Console.WriteLine(asynchronousClientList[i].RecieveData_);
            //    results[i] = taskArray[i].Result;
            //}


            //string processFileName = "";
            //string arguments = "";

            //Process p = new Process();

            //ProcessStartInfo psi = new ProcessStartInfo(processFileName, arguments);
            //p.StartInfo = psi;

            //p.Start();

            //return "calc start";

        }

        string IJobAction.DoJob()
        {
            throw new NotImplementedException();
        }
    }
}
