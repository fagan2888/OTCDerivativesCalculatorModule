using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;


namespace Excel_Interface
{
    public class Excel_marketDataSymbolViewModel : INotifyPropertyChanged
    {
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

        #region AddedDao_
        private MARKETDATA_SYMBOL_INFO_Table_DAO addedDao_;
        public MARKETDATA_SYMBOL_INFO_Table_DAO AddedDao_
        {
            get { return this.addedDao_; }
            set
            {
                if (this.addedDao_ != value)
                {
                    this.addedDao_ = value;
                    this.NotifyPropertyChanged("AddedDao_");
                }
            }
        }
        #endregion

        #region SymbolDAOList_
        private ObservableCollection<MARKETDATA_SYMBOL_INFO_Table_DAO> symbolDAOList_;
        public ObservableCollection<MARKETDATA_SYMBOL_INFO_Table_DAO> SymbolDAOList_
        {
            get { return this.symbolDAOList_; }
            set
            {
                if (this.symbolDAOList_ != value)
                {
                    this.symbolDAOList_ = value;
                    this.NotifyPropertyChanged("SymbolDAOList_");
                }
            }
        }
        #endregion

        public Excel_marketDataSymbolViewModel()
        {
            this.symbolDAOList_ = new ObservableCollection<MARKETDATA_SYMBOL_INFO_Table_DAO>();
            this.addedDao_ = new MARKETDATA_SYMBOL_INFO_Table_DAO();
        }

        public void loadMarketDataSymbolFromDB()
        {
            this.symbolDAOList_.Clear();

            MARKETDATA_SYMBOL_INFO_Table_DAOManager daoM = new MARKETDATA_SYMBOL_INFO_Table_DAOManager();
            
            daoM.selectAll(DataBaseConnectManager.ConnectionFactory("myDB"));

            foreach (var item in daoM.DAOList_)
	        {
                this.symbolDAOList_.Add(item);		 
	        }
            
        }

        public Control view()
        {
            Control v = new Excel_marketDataSymbolView();

            v.DataContext = this;

            return v;
        }

        //public void AddDao()
        //{
        //    try
        //    {
        //        this.addedDao_.insert(DataBaseConnectManager.ConnectionFactory("myDB"));
        //        this.symbolDAOList_.Add(this.addedDao_.clone());
        //    }
        //    catch (Exception)
        //    {
        //        OutputLogViewModel.addResult("symbol data db insert error : " + this.addedDao_.SYMBOL_);
        //    }
        //}

        //public void deleteDao(MARKETDATA_SYMBOL_INFO_Table_DAO dao)
        //{
        //    try
        //    {
        //        // 
        //        dao.delete(DataBaseConnectManager.ConnectionFactory("myDB"));
        //        this.symbolDAOList_.Remove(dao);
        //    }
        //    catch (Exception)
        //    {
        //        OutputLogViewModel.addResult("symbol data db delete error : " + this.addedDao_.SYMBOL_);
        //    }
        //}


        public void AddDao(Excel_marketDataSymbol excel_marketDataSymbol)
        {
            try
            {
                excel_marketDataSymbol.buildDAO().insert(DataBaseConnectManager.ConnectionFactory("myDB"));
                //this.symbolDAOList_.Add(excel_marketDataSymbol.buildDAO());
            }
            catch (Exception)
            {
                OutputLogViewModel.addResult("symbol data db insert error : " + this.addedDao_.SYMBOL_);
            }
        }

        public void deleteDao(Excel_marketDataSymbol excel_marketDataSymbol)
        {
            try
            {
                excel_marketDataSymbol.buildDAO().delete(DataBaseConnectManager.ConnectionFactory("myDB"));
                //this.symbolDAOList_.Add(excel_marketDataSymbol.buildDAO());
            }
            catch (Exception)
            {
                OutputLogViewModel.addResult("symbol data db insert error : " + this.addedDao_.SYMBOL_);
            }
        }
    }
}
