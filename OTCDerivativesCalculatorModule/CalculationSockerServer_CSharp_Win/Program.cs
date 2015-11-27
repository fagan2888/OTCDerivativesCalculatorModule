using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using CalculationSockerServer_CSharp_Win;

namespace CalculationSocketServer
{
    class Program
    {
        public static int Main(String[] args)
        {
            AsynchronousSocketListener listener = new AsynchronousSocketListener();
            listener.StartListening();

            //CalculationManager cm = new CalculationManager();

            //Console.Write(cm.testCalculate());

            return 0;
        }

    }
}
