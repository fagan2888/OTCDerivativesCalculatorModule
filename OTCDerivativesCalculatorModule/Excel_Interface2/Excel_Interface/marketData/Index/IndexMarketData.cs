using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;


namespace Excel_Interface
{
    public class IndexMarketData
    {
        public string Name_ { get; set; }
        public string Value_ { get; set; }
        public string Date_ { get; set; }

        //private string connectionStr_ = @"Data Source=D:\Project File\OTCDerivativesCalculatorModule\Excel_Interface2\Excel_Interface\marketData\MarketDataDB.sdf";
        public Dictionary<string, string> TimeSeries_ { get; set; }

        public IndexMarketData(string date,
            string name,
            string value) 
        {
            this.Date_ = date;
            this.Name_ = name;
            this.Value_ = value;

            this.TimeSeries_ = new Dictionary<string, string>();
        }

        public void insertDB()
        {
            INDEX_DATA_Table_DAO dao = new INDEX_DATA_Table_DAO();

            dao.INDEX_DATE_ = this.Date_;
            dao.INDEX_CODE_ = this.Name_;
            dao.INDEX_NAME_ = this.Name_;
            dao.INDEX_VALUE_ = this.Value_;

            try
            {
                dao.delete(DataBaseConnectManager.ConnectionFactory("myDB"));
                dao.insert(DataBaseConnectManager.ConnectionFactory("myDB"));

            }
            catch (SqlCeException )
            {
                OutputLogViewModel.addResult("dataBase load error : " + this.Name_);
            }

        }


    }
}
