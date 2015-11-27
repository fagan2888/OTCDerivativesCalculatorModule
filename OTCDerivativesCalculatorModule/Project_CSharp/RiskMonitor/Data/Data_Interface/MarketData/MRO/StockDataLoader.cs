using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace RiskMonitor
{
    public class StockDataLoader
    {
        public List<double> Result_ { get; protected set; }

        #region StaticFunction

        public static StockDataLoader CreateLoader(string vendor)
        {
            throw new NotImplementedException();
        }

        #endregion

        private FileInfo fileInfo1_ = new FileInfo("C:\\Users\\ibks\\documents\\visual studio 2010\\Projects\\MROConnectTest\\OptionCalculator\\Query\\MRO\\StockHistory.txt");
        public List<double> loadHistory(string itemCode, DateTime startDate, DateTime endDate)
        {
            OracleDataBaseConnect conn = OracleDataBaseConnect.CreateOracleDBConnet("Local");

            QueryStr query = new QueryStr(fileInfo1_);

            query.VariableMap_.Add("stockID", itemCode);
            query.VariableMap_.Add("startDate", startDate.ToString("yyyyMMdd"));
            query.VariableMap_.Add("endDate", endDate.ToString("yyyyMMdd"));

            conn.addQuery("Test", query.getQuery());
            conn.excute();
            
            List<double> valueList = new List<double>();
            List<string> datestr = new List<string>();

            foreach (DataRow item in conn.ResultDataSet_.Tables["Test"].Rows)
            {
                valueList.Add(Convert.ToDouble(item["CURR_PRICE"].ToString()));
                datestr.Add(item["STD_DATE"].ToString());
            }

            return Result_;
        }

        // List로 받는거
        //private FileInfo fileInfo2_ = new FileInfo("C:\\Users\\ibks\\documents\\visual studio 2010\\Projects\\MROConnectTest\\OptionCalculator\\Query\\MRO\\StockHistory.txt");
        //public List<double> loadHistory(string itemCode, List<DateTime> referenceDates)
        //{
        //    QueryStr query = new QueryStr(fileInfo2_);

        //    return Result_;
        //}

    }
}
