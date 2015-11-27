using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Excel_Interface
{
    public class YahooMarketDataLoader
    {
        public List<IndexTickerInfo> indexYahooTickerList_ { get; set; }

        public List<IndexMarketData> marketDataList_ { get; set; }
        public List<IndexHistoryMarketData> marketHistoryDataList_ { get; set; }

        public YahooMarketDataLoader()
        {
            this.indexYahooTickerList_ = new List<IndexTickerInfo>();
            this.marketDataList_ = new List<IndexMarketData>();
            this.marketHistoryDataList_ = new List<IndexHistoryMarketData>();
            
        }

        public int loadTickerList()
        {
            // data file로부터 로드함
            this.indexYahooTickerList_ = new List<IndexTickerInfo>();

            return 0;
        }

        public void loadData()
        {
            this.marketDataList_ = new List<IndexMarketData>();

            WebClient webClient = new WebClient();

            StringBuilder sb = new StringBuilder();

            sb.Append("http://download.finance.yahoo.com/d/quotes.csv?s=%40%5EDJI");

            foreach (IndexTickerInfo item in this.indexYahooTickerList_)
            {
                sb.Append(",");
                sb.Append(item.Yahoo_ticker_);
            }

            sb.Append("&f=d1nsl1op&e=.csv");

            string dataURL = sb.ToString();

            var reader = new StreamReader(webClient.OpenRead(dataURL));

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] values = line.Split(',');

                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = values[i].Replace("\"", "");
                }

                DateTime d = DateTime.Parse(values[0]);

                this.marketDataList_.Add(new IndexMarketData(
                    d.ToString("yyyyMMdd"),
                    values[2],
                    values[3]));
            }
        }

        public void loadHistoryData(DateTime sDate, DateTime eDate)
        {
            this.marketDataList_ = new List<IndexMarketData>();

            WebClient webClient = new WebClient();

            StringBuilder sb = new StringBuilder();

            string s_year = (sDate.Year).ToString();
            string s_month = (sDate.Month -1).ToString();
            string s_day = (sDate.Day).ToString();
            string e_year = (eDate.Year).ToString();
            string e_month = (eDate.Month - 1).ToString();
            string e_day = (eDate.Day).ToString();

            foreach (var item in this.indexYahooTickerList_)
            {
                sb.Clear();

                sb.Append("http://ichart.yahoo.com/table.csv?s=%40%5EDJI," + item.Yahoo_ticker_ +
                    "&a=" + s_month +
                    "&b=" + s_day +
                    "&c=" + s_year +
                    "&d=" + e_month +
                    "&e=" + e_day +
                    "&f=" + e_year +
                    "&g=d&ignore=.csv");

                IndexHistoryMarketData ihmd = new IndexHistoryMarketData(item);

                string dataURL = sb.ToString();

                Stream stream = webClient.OpenRead(dataURL);
                StreamReader reader = new StreamReader(stream);

                // 처음 한줄은 건너뜀
                var line = reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    var values = line.Split(',');
                    
                    DateTime d = DateTime.Parse(values[0]);

                    ihmd.TimeSeries_.Add(d.ToString("yyyyMMdd"), values[4]);

                }

                stream.Close();
                reader.Close();

                this.marketHistoryDataList_.Add(ihmd);

            }

        }

        public void dbInsert()
        {
            foreach (var item in this.marketDataList_)
            {
                item.insertDB();
                //item.insertHistoryDB();
            }
        }

        public void dbInsertHistory()
        {
            foreach (var item in this.marketHistoryDataList_)
            {
                item.insertHistoryDB();
            }
        }

        public static bool dataTest(string ticker)
        {
            WebClient webClient = new WebClient();

            StringBuilder sb = new StringBuilder();

            sb.Append("http://download.finance.yahoo.com/d/quotes.csv?s=%40%5EDJI");

            sb.Append("," + ticker);

            sb.Append("&f=d1nsl1op&e=.csv");

            string dataURL = sb.ToString();

            Stream stream = webClient.OpenRead(dataURL);
            StreamReader reader = new StreamReader(stream);

            var line = reader.ReadLine();
            string[] values = line.Split(',');

            stream.Close();
            reader.Close();

            if (values[4] == "N/A")
            {
                return false;
            }
            else
            {
                return true;
            }

            
            
        }

    }
}
