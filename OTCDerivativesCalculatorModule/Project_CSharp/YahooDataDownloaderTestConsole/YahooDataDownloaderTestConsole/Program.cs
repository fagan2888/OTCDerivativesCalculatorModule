using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.ComponentModel;
using System.IO;


namespace YahooDataDownloaderTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            string dataURL = "http://download.finance.yahoo.com/d/quotes.csv?s=%40%5EDJI,GOOG,VGK&f=nsl1op&e=.csv";

            var reader = new StreamReader(webClient.OpenRead(dataURL));

            List<string> listA = new List<string>();
            List<string> listB = new List<string>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                listA.Add(values[0]);
                listB.Add(values[1]);

                Console.WriteLine(values[0] + " | " + values[1] + " | " + values[2]);
            }
        }



    }
}
