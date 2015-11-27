using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Windows.Controls;


namespace Excel_Interface
{
    public class MarketDataManagerViewModel
    {
        //#region View_
        //protected Control view_;
        //public Control View_
        //{
        //    get { return this.view_; }
        //    set
        //    {
        //        if (this.view_ != value)
        //        {
        //            this.view_ = value;
        //            this.NotifyPropertyChanged("View_");
        //        }
        //    }
        //}
        //#endregion

        #region Event
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region DefinedIndexSymbolList_
        private ObservableCollection<IndexTickerInfo> definedIndexSymbolList_;
        public ObservableCollection<IndexTickerInfo> DefinedIndexSymbolList_
        {
            get { return this.definedIndexSymbolList_; }
            set
            {
                if (this.definedIndexSymbolList_ != value)
                {
                    this.definedIndexSymbolList_ = value;
                    //this.NotifyPropertyChanged("DefinedIndexSymbolList_");
                }
            }
        }
        #endregion

        private string connectionStr_ = EnvironmentVariable.MarketDataDBFile_;

        public MarketDataManagerViewModel()
        {
            this.definedIndexSymbolList_ = new ObservableCollection<IndexTickerInfo>();

            //this.view_ = new MarketDataManagerView();
            //this.view_.DataContext = this;
        }

        public void loadDefinedIndexSymbolFromDB()
        {
            this.definedIndexSymbolList_.Clear();
            SqlCeConnection connection = new SqlCeConnection(this.connectionStr_);

            try
            {
                SqlCeCommand command = connection.CreateCommand();
                connection.Open();

                command.CommandText = "SELECT * FROM INDEX_TICKER_INFO";

                SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command.CommandText, connection);

                DataTable tb = new DataTable();
                dataAdapter.Fill(tb);
                //string selectionStr = " DATE = '"++"' and CODE_A = '" + itemCode1 + "' and CODE_B = '" + itemCode2 + "'";
                //DataRow[] results = tb.Select(selectionStr);

                //tb.Select("
                
                foreach (DataRow row in tb.Rows)
	            {
                    string name = row["NAME"].ToString();
                    string krcode = row["KRCODE"].ToString();
                    string yahoo_ticker = row["YAHOO_TICKER"].ToString();
                    string bloomberg_ticker = row["BLOOMBERG_TICKER"].ToString();
                    string kap_ticker = row["KAP_TICKER"].ToString();
                    string kis_ticker = row["KIS_TICKER"].ToString();
                    string datasource = row["DATASOURCE"].ToString();
                    string time_download = row["TIME_DOWNLOAD"].ToString();
                    string index_type = row["INDEX_TYPE"].ToString();

                    this.definedIndexSymbolList_.Add(new IndexTickerInfo(name, krcode, yahoo_ticker,
                                                                        bloomberg_ticker,
                                                                        kap_ticker,
                                                                        kis_ticker,
                                                                        datasource,
                                                                        time_download,
                                                                        index_type
                                                                        ));
	            }

                connection.Close();

            }
            catch (SqlCeException )
            {
                connection.Close();
                OutputLogViewModel.addResult("DataBase Connection Error : DB Load");
                throw;
            }

            //this.definedIndexSymbolList_.Add("VGK");
            //this.definedIndexSymbolList_.Add("^VIX");
            //this.definedIndexSymbolList_.Add("005930.KS");
            
        }

        public int addDefinedIndex(IndexTickerInfo iti)
        {
            SqlCeConnection connection = new SqlCeConnection(this.connectionStr_);

            try
            {

                DataTable tb = new DataTable();

                SqlCeCommand command = connection.CreateCommand();
                connection.Open();

                SqlCeCommand delCommand = connection.CreateCommand();
                //delCommand.CommandText = "DELETE FROM CORRELATION WHERE DATE ='" + ReferenceDate_.ToString("yyyy-MM-dd") + "'";
                //delCommand.ExecuteNonQuery();

                string name = QueryStr.wrapComma(iti.Name_);
                string krcode = QueryStr.wrapComma(iti.KrCode_);
                string yahoo_ticker = QueryStr.wrapComma(iti.Yahoo_ticker_);
                string bloomberg_ticker = QueryStr.wrapComma(iti.Bloomberg_ticker_);
                string kap_ticker = QueryStr.wrapComma(iti.Kap_ticker_);
                string kis_ticker = QueryStr.wrapComma(iti.Kis_ticker_);
                string datasource = QueryStr.wrapComma(iti.Datasource_);
                string time_download = QueryStr.wrapComma(iti.Time_download_);

                //if name 존재하면 pass
                //command.CommandText = "DELETE FROM INDEX_TICKER_INFO WHERE NAME=" + name +
                                                             
                //command.ExecuteNonQuery();

                command.CommandText = "INSERT INTO INDEX_TICKER_INFO (NAME,KRCODE,YAHOO_TICKER,BLOOMBERG_TICKER," +
                                                             "KAP_TICKER,KIS_TICKER,DATASOURCE,TIME_DOWNLOAD) " +
                                      " VALUES (" + name + "," +
                                                    krcode + "," +
                                                    yahoo_ticker + "," +
                                                    bloomberg_ticker + "," +
                                                    kap_ticker + "," +
                                                    kis_ticker + "," +
                                                    datasource + "," +
                                                    time_download + ")";

                command.ExecuteNonQuery();

                connection.Close();

                return 0;

            }
            catch (SqlCeException )
            {
                connection.Close();
                OutputLogViewModel.addResult("DataBase Connection Error : DB Load");
                return 1;
            }
        }

        public int updateDefinedIndex(IndexTickerInfo iti)
        {
            SqlCeConnection connection = new SqlCeConnection(this.connectionStr_);

            try
            {

                DataTable tb = new DataTable();

                SqlCeCommand command = connection.CreateCommand();
                connection.Open();

                //delCommand.CommandText = "DELETE FROM CORRELATION WHERE DATE ='" + ReferenceDate_.ToString("yyyy-MM-dd") + "'";
                //delCommand.ExecuteNonQuery();

                string name = QueryStr.wrapComma(iti.Name_);
                string krcode = QueryStr.wrapComma(iti.KrCode_);
                string yahoo_ticker = QueryStr.wrapComma(iti.Yahoo_ticker_);
                string bloomberg_ticker = QueryStr.wrapComma(iti.Bloomberg_ticker_);
                string kap_ticker = QueryStr.wrapComma(iti.Kap_ticker_);
                string kis_ticker = QueryStr.wrapComma(iti.Kis_ticker_);
                string datasource = QueryStr.wrapComma(iti.Datasource_);
                string time_download = QueryStr.wrapComma(iti.Time_download_);
                string index_type = QueryStr.wrapComma(iti.Index_type_);

                command.CommandText = "DELETE FROM INDEX_TICKER_INFO WHERE NAME=" + name;

                command.ExecuteNonQuery();

                command.CommandText = "INSERT INTO INDEX_TICKER_INFO (NAME,KRCODE,YAHOO_TICKER,BLOOMBERG_TICKER," +
                                                             "KAP_TICKER,KIS_TICKER,DATASOURCE,TIME_DOWNLOAD,INDEX_TYPE) " +
                                      " VALUES (" + name + "," +
                                                    krcode + "," +
                                                    yahoo_ticker + "," +
                                                    bloomberg_ticker + "," +
                                                    kap_ticker + "," +
                                                    kis_ticker + "," +
                                                    datasource + "," +
                                                    time_download + "," +
                                                    index_type + ")";

                command.ExecuteNonQuery();

                connection.Close();

                return 0;

            }
            catch (SqlCeException )
            {
                connection.Close();
                OutputLogViewModel.addResult("DataBase Connection Error : DB Load");
                return 1;
            }
        }

        public int deleteDefinedIndex(string nameStr) 
        {
        SqlCeConnection connection = new SqlCeConnection(this.connectionStr_);

            try
            {

                DataTable tb = new DataTable();

                connection.Open();

                SqlCeCommand delCommand = connection.CreateCommand();
                //delCommand.CommandText = "DELETE FROM CORRELATION WHERE DATE ='" + ReferenceDate_.ToString("yyyy-MM-dd") + "'";
                //delCommand.ExecuteNonQuery();

                string name = QueryStr.wrapComma(nameStr);

                delCommand.CommandText = "DELETE FROM INDEX_TICKER_INFO WHERE NAME=" + name;

                delCommand.ExecuteNonQuery();

                delCommand.CommandText = "DELETE FROM INDEXDATA WHERE NAME=" + name;

                delCommand.ExecuteNonQuery();

                connection.Close();

                return 0;

            }
            catch (SqlCeException e)
            {
                connection.Close();
                OutputLogViewModel.addResult("DataBase Connection Error : DB Load" + e.Errors);
                return 1;
            }
        }

        public IndexTickerInfo loadDefinedIndex(string nameStr)
        {

            SqlCeConnection connection = new SqlCeConnection(this.connectionStr_);

            try
            {
                SqlCeCommand command = connection.CreateCommand();
                connection.Open();

                string wrapName = QueryStr.wrapComma(nameStr);

                command.CommandText = "SELECT * FROM INDEX_TICKER_INFO WHERE NAME=" + wrapName;

                SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command.CommandText, connection);

                DataTable tb = new DataTable();
                dataAdapter.Fill(tb);

                IndexTickerInfo loadITI = new IndexTickerInfo();

                foreach (DataRow row in tb.Rows)
                {
                    string name = row["NAME"].ToString();
                    string krcode = row["KRCODE"].ToString();
                    string yahoo_ticker = row["YAHOO_TICKER"].ToString();
                    string bloomberg_ticker = row["BLOOMBERG_TICKER"].ToString();
                    string kap_ticker = row["KAP_TICKER"].ToString();
                    string kis_ticker = row["KIS_TICKER"].ToString();
                    string datasource = row["DATASOURCE"].ToString();
                    string time_download = row["TIME_DOWNLOAD"].ToString();
                    string index_type = row["INDEX_TYPE"].ToString();

                     loadITI = new IndexTickerInfo(name, krcode, yahoo_ticker,
                                                                        bloomberg_ticker,
                                                                        kap_ticker,
                                                                        kis_ticker,
                                                                        datasource,
                                                                        time_download,
                                                                        index_type
                                                                        );
                }

                connection.Close();

                return loadITI;

            }
            catch (SqlCeException )
            {
                connection.Close();
                OutputLogViewModel.addResult("DataBase Connection Error : DB Load");
                throw;
            }
        }

        public int historyDataDownload(IndexTickerInfo iti)
        {
            YahooMarketDataLoader ymdl = new YahooMarketDataLoader();

            DateTime sDate = new DateTime(2014, 1, 1);

            DateTime eDate = DateTime.Now;

            ymdl.indexYahooTickerList_.Add(iti);

            ymdl.loadHistoryData(sDate, eDate);
            ymdl.dbInsertHistory();

            return 0;
        }

        public System.Windows.Controls.Control view()
        {
            Control v = new MarketDataManagerView();

            v.DataContext = this;

            return v;
        }
    }
}
