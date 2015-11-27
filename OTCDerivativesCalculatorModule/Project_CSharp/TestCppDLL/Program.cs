using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;

namespace TestCppDLL
{
    public class Program
    {

        static void Main(string[] args)
        {

            Uri uri = new Uri("C:\\Users\\ibks\\Desktop\\OTC 잡다계산기\\자체헤지 계산용\\a.kke");
            string filename = System.IO.Path.GetFileName(uri.LocalPath);

            Console.WriteLine(System.IO.Path.GetFileName(uri.LocalPath));
            Console.WriteLine(uri.LocalPath);
            Console.WriteLine(uri.AbsolutePath);
            

            //List<string> instList = new List<string>();

            //instList.Add("570");
            //instList.Add("831");
            //instList.Add("832");
            //instList.Add("840");

            //InstPricing instPricing = new InstPricing();    

            //foreach (string item in instList)
            //{
            //    Console.WriteLine("----------------------" + item + "---------------------");
            //    instPricing.instName_ = item;
            //    instPricing.pricing();
            //    Console.WriteLine();
                
            //}

            //Console.Write("End Pricing");
            //Console.ReadLine();
            
        }


    }
}
