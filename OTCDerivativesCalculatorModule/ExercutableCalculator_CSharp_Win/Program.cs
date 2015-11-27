using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace ExercutableCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("single calculation process running..");

            Console.Write("argument[0] : ");
            Console.WriteLine(args[0]);

            Console.Write("argument[1] : ");
            Console.WriteLine(args[1]);

            //string xmlFileName = "mergedInstHist.xml";

            string result = CalculationModuleDLL.calculationLibCall(args[0]);

            File.WriteAllText(args[1], result);
            
        }
    }


}
