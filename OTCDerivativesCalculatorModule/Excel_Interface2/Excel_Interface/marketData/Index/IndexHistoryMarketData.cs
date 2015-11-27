using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.ComponentModel;
using System.Collections.ObjectModel;

using QLNet;

namespace Excel_Interface
{
    public class IndexHistoryMarketData
    {
        public string Code_ { get; set; }
        public string Tenor_ { get; set; }
        public string Name_ { get; set; }
        public string LinkedCurveCode_ { get; set; }

        //private string connectionStr_ = @"Data Source=D:\Project File\OTCDerivativesCalculatorModule\Excel_Interface2\Excel_Interface\marketData\MarketDataDB.sdf";
        private string connectionStr_ = EnvironmentVariable.MarketDataDBFile_;

        //[ date , value ]   |  yyyyMMdd
        public Dictionary<string, string> TimeSeries_ { get; set; }

        public IndexHistoryMarketData(string code)
        {
            this.Code_ = code;
        }

        public IndexHistoryMarketData(IndexTickerInfo indexTicker)
        {
            this.Code_ = indexTicker.KrCode_;
            this.Name_ = indexTicker.Name_;
            
            this.TimeSeries_ = new Dictionary<string, string>();
        }

        public void insertHistoryDB()
        {

            INDEX_DATA_Table_DAO dao = new INDEX_DATA_Table_DAO();

            dao.INDEX_CODE_ = this.Code_;
            dao.INDEX_NAME_ = this.Name_;

            try
            {

                dao.deleteIndex(DataBaseConnectManager.ConnectionFactory("myDB"));
                
                foreach (var item in this.TimeSeries_)
                {
                    dao.INDEX_DATE_ = QueryStr.wrapComma(item.Key);
                    dao.INDEX_VALUE_ = QueryStr.wrapComma(item.Value);

                    dao.insert(DataBaseConnectManager.ConnectionFactory("myDB"));
                }


            }
            catch (SqlCeException )
            {
                OutputLogViewModel.addResult("DataBase Connection Error : DB Load");
                throw;
            }
        }

        public TimeSeries<string> historySeries(DateTime sDate, DateTime eDate )
        {
            TimeSeries<string> hist = new TimeSeries<string>();

            INDEX_DATA_Table_DAOManager dao_m = new INDEX_DATA_Table_DAOManager();

            dao_m.INDEX_CODE_ = this.Code_;
            
            dao_m.selectInterval(DataBaseConnectManager.ConnectionFactory("myDB"),sDate,eDate);

            foreach (var item in dao_m.DAOList_)
            {
                string date = item.INDEX_DATE_;

                int year =  Convert.ToInt32(date.Substring(0, 4));
                int month = Convert.ToInt32(date.Substring(4, 2));
                int day = Convert.ToInt32(date.Substring(6, 2));

                string value = item.INDEX_VALUE_;

                hist.Add(new Date(new DateTime(year,month, day)), value);

            }

            return hist;
        }


        public TimeSeries<string> historySeriesMRO(DateTime sDate, DateTime eDate)
        {
            TimeSeries<string> hist = new TimeSeries<string>();

            TD_MRSTOCKFACTOR_Table_DAOManager dao_m = new TD_MRSTOCKFACTOR_Table_DAOManager();

            dao_m.STOCK_ID_ = this.Code_;

            dao_m.selectInterval(DataBaseConnectManager.ConnectionFactory("MRO"), sDate, eDate);

            foreach (var item in dao_m.DAOList_)
            {
                string date = item.STD_DATE_;

                int year = Convert.ToInt32(date.Substring(0, 4));
                int month = Convert.ToInt32(date.Substring(4, 2));
                int day = Convert.ToInt32(date.Substring(6, 2));

                string value = item.CURR_PRICE_;

                hist.Add(new Date(new DateTime(year, month, day)), value);

            }

            return hist;
        }

        public TimeSeries<string> historyCurveSeriesMRO(DateTime sDate, DateTime eDate)
        {
            TimeSeries<string> hist = new TimeSeries<string>();

            IRCurveMarketDataLoader irCurveLoader = IRCurveMarketDataLoader.CreateMarketDataLoader("MRO");

            ObservableCollection<Excel_irCurveDataViewModel> e_ircdvmList = new ObservableCollection<Excel_irCurveDataViewModel>();

            irCurveLoader.loadInterval(sDate, eDate, this.LinkedCurveCode_, e_ircdvmList);

            //TD_MRSTOCKFACTOR_Table_DAOManager dao_m = new TD_MRSTOCKFACTOR_Table_DAOManager();

            //dao_m.STOCK_ID_ = this.Code_;

            //dao_m.selectInterval(DataBaseConnectManager.ConnectionFactory("MRO"), sDate, eDate);

            int tenorIndex = e_ircdvmList[0].getTenorIndex(this.Tenor_);

            if (tenorIndex != -1)
            {
                foreach (var item in e_ircdvmList)
                {
                    string value = item.Excel_rateDataViewModelList_[tenorIndex].Value_;

                    hist.Add(new Date(item.ReferenceDate_), value);
                }

            }

            return hist;
        }
    }

}
