using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaasOne.Finance.YahooFinance;
using MaasOne.Base;
using System.IO;

namespace Yahoo_Ticker
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //StringWriter writeStream = new StringWriter();

            StreamWriter writeStream = new StreamWriter("list.txt", false, System.Text.Encoding.UTF8);

            AlphabeticIDIndexDownload dl1 = new AlphabeticIDIndexDownload();
            dl1.Settings.TopIndex = null;
            Response<AlphabeticIDIndexResult> resp1 = dl1.Download();

            writeStream.WriteLine("Id|Isin|Name|Exchange|Type|Industry");

            foreach (var alphabeticalIndex in resp1.Result.Items)
            {
                AlphabeticalTopIndex topIndex = (AlphabeticalTopIndex)alphabeticalIndex;
                dl1.Settings.TopIndex = topIndex;
                Response<AlphabeticIDIndexResult> resp2 = dl1.Download();

                foreach (var index in resp2.Result.Items)
                {
                    IDSearchDownload dl2 = new IDSearchDownload();
                    Response<IDSearchResult> resp3 = dl2.Download(index);


                    int i = 0;
                    foreach (var item in resp3.Result.Items)
                    {
                        writeStream.WriteLine(item.ID + "|" + item.ISIN + "|" + item.Name + "|" + item.Exchange + "|" + item.Type + "|" + item.Industry);
                        Console.WriteLine(item.ID + "|" + item.ISIN + "|" + item.Name + "|" + item.Exchange + "|" + item.Type + "|" + item.Industry);
                    }

                }
            }
        }
    }
}
