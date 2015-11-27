using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;


namespace Excel_Interface
{
    public class Excel_profitLossViewModel
    {
        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion  

        #region TradeID_
        private string tradeID_;
        public string TradeID_
        {
            get { return this.tradeID_; }
            set
            {
                if (this.tradeID_ != value)
                {
                    this.tradeID_ = value;
                    this.NotifyPropertyChanged("TradeID_");
                }
            }
        }
        #endregion

        #region ItemCode_
        private string itemCode_;
        public string ItemCode_
        {
            get { return this.itemCode_; }
            set
            {
                if (this.itemCode_ != value)
                {
                    this.itemCode_ = value;
                    this.NotifyPropertyChanged("ItemCode_");
                }
            }
        }
        #endregion

        #region BookValue_
        private string bookValue_;
        public string BookValue_
        {
            get { return this.bookValue_; }
            set
            {
                if (this.bookValue_ != value)
                {
                    this.bookValue_ = value;
                    this.NotifyPropertyChanged("BookValue_");
                }
            }
        }
        #endregion

        #region EvalAmount_
        private string evalAmount_;
        public string EvalAmount_
        {
            get { return this.evalAmount_; }
            set
            {
                if (this.evalAmount_ != value)
                {
                    this.evalAmount_ = value;
                    this.NotifyPropertyChanged("EvalAmount_");
                }
            }
        }
        #endregion

        #region 아직 미사용

        #region ReferenceDate_
        private DateTime referenceDate_;
        public DateTime ReferenceDate_
        {
            get { return this.referenceDate_; }
            set
            {
                if (this.referenceDate_ != value)
                {
                    this.referenceDate_ = value;
                    this.NotifyPropertyChanged("ReferenceDate_");
                }
            }
        }
        #endregion

        #region ExportItemCode_ 이걸로 외부 가격 mapping을 함. ( 임시 방편 ) 그리고 이걸로 PL을 검색함.
        private string exportItemCode_;
        public string ExportItemCode_
        {
            get { return this.exportItemCode_; }
            set
            {
                if (this.exportItemCode_ != value)
                {
                    this.exportItemCode_ = value;
                    this.NotifyPropertyChanged("ExportItemCode_");
                }
            }
        }
        #endregion

        #region NPV_
        private double npv_;
        public double NPV_
        {
            get { return this.npv_; }
            set
            {
                if (this.npv_ != value)
                {
                    this.npv_ = value;
                    this.NotifyPropertyChanged("NPV_");
                }
            }
        }
        #endregion

        #region TotalProfitLoss_
        private double totalProfitLoss_;
        public double TotalProfitLoss_
        {
            get { return this.totalProfitLoss_; }
            set
            {
                if (this.totalProfitLoss_ != value)
                {
                    this.totalProfitLoss_ = value;
                    this.NotifyPropertyChanged("TotalProfitLoss_");
                }
            }
        }
        #endregion

        #region CalculationHostType_
        private string calculationHostType_;
        public string CalculationHostType_
        {
            get { return this.calculationHostType_; }
            set
            {
                if (this.calculationHostType_ != value)
                {
                    this.calculationHostType_ = value;
                    this.NotifyPropertyChanged("CalculationHostType_");
                }
            }
        }
        #endregion

        #region DailyProfitLoss_
        private double dailyProfitLoss_;
        public double DailyProfitLoss_
        {
            get { return this.dailyProfitLoss_; }
            set
            {
                if (this.dailyProfitLoss_ != value)
                {
                    this.dailyProfitLoss_ = value;
                    this.NotifyPropertyChanged("DailyProfitLoss_");
                }
            }
        }
        #endregion

        #region TradeEvent

        #region TradeEventViewModelList_
        private ObservableCollection<TradeEventViewModel> tradeEventViewModelList_;
        public ObservableCollection<TradeEventViewModel> TradeEventViewModelList_
        {
            get { return this.tradeEventViewModelList_; }
            set
            {
                if (this.tradeEventViewModelList_ != value)
                {
                    this.tradeEventViewModelList_ = value;
                    this.NotifyPropertyChanged("TradeEventViewModelList_");
                }
            }
        }
        #endregion

        #endregion

        #endregion

        public Excel_profitLossViewModel()
        {
            //this.tradeID_ = tradeID;
            //this.view_ = new Excel_profitLossView();
            //this.view_.DataContext = this;
        }

        public void masterEventObserver(object sender, PropertyChangedEventArgs e)
        {
            MasterInformationViewModel mivm = sender as MasterInformationViewModel;

            if (e.PropertyName == "Trade_id_")
            {
                this.TradeID_ = mivm.Trade_id_;
            }
        }

        // 나중에 ETL 까지 같이 생각해야함... 지금은 RDW에서 가져옴.
        //public void loadNPV(DateTime referenceDate)
        public void loadNPV()
        {
            //// db 접속 후 로드함. 그리고 나머지 계산함..?
            ////this.referenceDate_ = referenceDate;

            //this.npv_ = 999999;
            //this.dailyProfitLoss_ = 999999;
            //this.totalProfitLoss_ = 999999;
            
            //DataTable tb = new DataTable();

            //SqlCeConnection connection = new SqlCeConnection(connectionStr_);
            //SqlCeCommand command = connection.CreateCommand();

            //try
            //{
            //    string exportItemCodeWrap = QueryStr.wrapComma(this.exportItemCode_);
            //    string dateWrap = QueryStr.wrapComma(this.referenceDate_.ToString("yyyyMMdd"));

            //    command.CommandText = "SELECT DATE, TRADE_ID , NPV , TOTAL_PL , " +
            //                                " DAILY_PL,EXPORT_ITEMCODE FROM POSITION_PL " +
            //                                " WHERE EXPORT_ITEMCODE =" + exportItemCodeWrap +
            //                                " AND DATE = " + dateWrap;

            //    connection.Open();
            //    SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command.CommandText, connection);

            //    dataAdapter.Fill(tb);
            //    connection.Close();

            //    DataRow[] resultRows = tb.Select();

            //    if (resultRows.Length == 0)
            //    {
            //        OutputLogViewModel.addResult("referenceDate : " + this.referenceDate_.ToString("yyyyMMdd")  + " No result pl : " + tradeID_);
            //    }

            //    foreach (DataRow item in resultRows)
            //    {
            //        //this.tradeID_ = item["ITEM_CODE"].ToString();
            //        //this.Name_ = item["ITEM_NAME"].ToString();

            //        this.npv_ = Convert.ToDouble(item["NPV"].ToString());
            //        this.totalProfitLoss_ = Convert.ToDouble(item["TOTAL_PL"].ToString());
            //        this.dailyProfitLoss_ = Convert.ToDouble(item["DAILY_PL"].ToString());

            //        //mivm.TradeDate_ = DateTime.Parse(item["TRADE_DATE"].ToString());
            //        //mivm.MaturityDate_ = DateTime.Parse(item["MATURITY_DATE"].ToString());
            //    }

            //}
            //catch (Exception e)
            //{
            //    OutputLogViewModel.addResult(e.Message);
            //    connection.Close();
                
            //}

            
        }

        public void addTradeEvent(TradeEventViewModel tradeEventVM)
        {
            this.tradeEventViewModelList_.Add(tradeEventVM);
        }

        public void loadTradeEvent()
        {
            this.tradeEventViewModelList_ = new ObservableCollection<TradeEventViewModel>();

            TradeEventViewModel sampleTradeEvent = new Buy_TradeEventViewModel();
            
            this.tradeEventViewModelList_.Add(sampleTradeEvent);
            this.tradeEventViewModelList_.Add(sampleTradeEvent);
            this.tradeEventViewModelList_.Add(sampleTradeEvent);
        }

        // 나중에 ETL 까지 같이 생각해야함... 지금은 RDW에서 가져옴.
        //public void loadNPV(DateTime referenceDate)
        //{
        //    // db 접속 후 로드함. 그리고 나머지 계산함..?

        //    this.referenceDate_ = referenceDate;

        //    this.npv_ = 999999;
        //    this.dailyProfitLoss_ = 999999;
        //    this.totalProfitLoss_ = 999999;

        //    DataTable tb = new DataTable();

        //    using (SqlCeConnection connection = new SqlCeConnection(connectionStr_))
        //    using (SqlCeCommand command = connection.CreateCommand())
        //    {
        //        string exportItemCodeWrap = QueryStr.wrapComma(this.exportItemCode_);

        //        command.CommandText = "SELECT DATE, TRADE_ID , NPV , TOTAL_PL , " +
        //                                    " DAILY_PL,EXPORT_ITEMCODE FROM POSITION_PL WHERE EXPORT_ITEMCODE =" + exportItemCodeWrap;

        //        connection.Open();
        //        SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command.CommandText, connection);

        //        dataAdapter.Fill(tb);
        //    }

        //    DataRow[] resultRows = tb.Select();

        //    if (resultRows.Length == 0)
        //    {
        //        OutputLogViewModel.addResult("no result pl : " + tradeID_);
        //    }

        //    foreach (DataRow item in resultRows)
        //    {
        //        //this.tradeID_ = item["ITEM_CODE"].ToString();
        //        //this.Name_ = item["ITEM_NAME"].ToString();

        //        this.npv_ = Convert.ToDouble(item["TRADE_ID"].ToString());
        //        this.totalProfitLoss_ = Convert.ToDouble(item["TYPE"].ToString());
        //        this.dailyProfitLoss_ = Convert.ToDouble(item["TYPE"].ToString());

        //        //mivm.TradeDate_ = DateTime.Parse(item["TRADE_DATE"].ToString());
        //        //mivm.MaturityDate_ = DateTime.Parse(item["MATURITY_DATE"].ToString());
        //    }
        //}

        public Control view()
        {
            Control v = new Excel_profitLossView();

            v.DataContext = this;

            return v;
        }

        public void bookingPL()
        {
            POSITION_PL_Table_DAO dao = new POSITION_PL_Table_DAO();

            dao.TRADE_ID_ = this.tradeID_;
            dao.BOOK_PRICE_ = this.bookValue_;

            dao.insert(DataBaseConnectManager.ConnectionFactory("myDB"));

            //dao.TOTAL_EVAL_PL_ = 
        }

        public void loadBookingInfo()
        {
            POSITION_PL_Table_DAO dao = new POSITION_PL_Table_DAO();

            dao.KeyColumn_ = this.tradeID_;

            dao.select(DataBaseConnectManager.ConnectionFactory("myDB"));

            #region setFromDao

            this.BookValue_ = dao.BOOK_PRICE_;

            #endregion
        }
    }
}
