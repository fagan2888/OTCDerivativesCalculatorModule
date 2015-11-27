using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_marketDataSymbol : INotifyPropertyChanged
    {

        //        SELECT SYMBOL,
//  NAME_ENG,
//  NAME_KOR,
//  SYMBOL_TYPE,
//  PROVIDER,
//  DESCRIPTION
//FROM MARKETDATA_SYMBOL_INFO;

        #region Event
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                if (propertyName == "")
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
                else
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
        #endregion

        #region Properties

        #region Symbol_
        protected string symbol_;
        public string Symbol_
        {
            get { return this.symbol_; }
            set
            {
                if (this.symbol_ != value)
                {
                    this.symbol_ = value;
                    this.NotifyPropertyChanged("Symbol_");
                }
            }
        }
        #endregion

        #region Name_eng_
        protected string name_eng_;
        public string Name_eng_
        {
            get { return this.name_eng_; }
            set
            {
                if (this.name_eng_ != value)
                {
                    this.name_eng_ = value;
                    this.NotifyPropertyChanged("Name_eng_");
                }
            }
        }
        #endregion

        #region Name_kor_
        protected string name_kor_;
        public string Name_kor_
        {
            get { return this.name_kor_; }
            set
            {
                if (this.name_kor_ != value)
                {
                    this.name_kor_ = value;
                    this.NotifyPropertyChanged("Name_kor_");
                }
            }
        }
        #endregion

        #region Symbol_type_
        protected string symbol_type_;
        public string Symbol_type_
        {
            get { return this.symbol_type_; }
            set
            {
                if (this.symbol_type_ != value)
                {
                    this.symbol_type_ = value;
                    this.NotifyPropertyChanged("Symbol_type_");
                }
            }
        }
        #endregion

        #region Provider_
        protected string provider_;
        public string Provider_
        {
            get { return this.provider_; }
            set
            {
                if (this.provider_ != value)
                {
                    this.provider_ = value;
                    this.NotifyPropertyChanged("Provider_");
                }
            }
        }
        #endregion

        #region Description_
        protected string description_;
        public string Description_
        {
            get { return this.description_; }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                    this.NotifyPropertyChanged("Description_");
                }
            }
        }
        #endregion

        #region Tenor_
        protected string tenor_;
        public string Tenor_
        {
            get { return this.tenor_; }
            set
            {
                if (this.tenor_ != value)
                {
                    this.tenor_ = value;
                    this.NotifyPropertyChanged("Tenor_");
                }
            }
        }
        #endregion

        #region Linkedcurve_
        protected string linkedcurve_;
        public string Linkedcurve_
        {
            get { return this.linkedcurve_; }
            set
            {
                if (this.linkedcurve_ != value)
                {
                    this.linkedcurve_ = value;
                    this.NotifyPropertyChanged("Linkedcurve_");
                }
            }
        }
        #endregion

        #region Sub_type_
        protected string sub_type_;
        public string Sub_type_
        {
            get { return this.sub_type_; }
            set
            {
                if (this.sub_type_ != value)
                {
                    this.sub_type_ = value;
                    this.NotifyPropertyChanged("Sub_type_");
                }
            }
        }
        #endregion

        #region Rate_type_
        protected string rate_type_;
        public string Rate_type_
        {
            get { return this.rate_type_; }
            set
            {
                if (this.rate_type_ != value)
                {
                    this.rate_type_ = value;
                    this.NotifyPropertyChanged("Rate_type_");
                }
            }
        }
        #endregion

        #region Leg_tenor_
        protected string leg_tenor_;
        public string Leg_tenor_
        {
            get { return this.leg_tenor_; }
            set
            {
                if (this.leg_tenor_ != value)
                {
                    this.leg_tenor_ = value;
                    this.NotifyPropertyChanged("Leg_tenor_");
                }
            }
        }
        #endregion

        #region Currency_
        protected string currency_;
        public string Currency_
        {
            get { return this.currency_; }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                    this.NotifyPropertyChanged("Currency_");
                }
            }
        }
        #endregion


        #endregion

        public virtual string dataLoad(DateTime refDate, string code) 
        {
            return "virtual not implemented";
        }

        public virtual Excel_underlyingInfoViewModel underlyingInfoVM()
        {
            return new Excel_stockIndexViewModel();
        }

        public void setFromDAO(MARKETDATA_SYMBOL_INFO_Table_DAO dao)
        {
            // bussiness logic here
            this.symbol_ = dao.SYMBOL_;
            this.name_eng_ = dao.NAME_ENG_;
            this.name_kor_ = dao.NAME_KOR_;
            this.symbol_type_ = dao.SYMBOL_TYPE_;
            this.provider_ = dao.PROVIDER_;
            this.description_ = dao.DESCRIPTION_;
            this.tenor_ = dao.TENOR_;
            this.sub_type_ = dao.SUB_TYPE_;
            this.linkedcurve_ = dao.LINKEDCURVE_;
            this.rate_type_ = dao.RATE_TYPE_;
            this.leg_tenor_ = dao.LEG_TENOR_;
            this.currency_ = dao.CURRENCY_;

        }

        public MARKETDATA_SYMBOL_INFO_Table_DAO buildDAO()
        {
            // bussiness logic here
            MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

            dao.SYMBOL_ = this.Symbol_;
            dao.NAME_ENG_ = this.Name_eng_;
            dao.NAME_KOR_ = this.Name_kor_;
            dao.SYMBOL_TYPE_ = this.Symbol_type_;
            dao.PROVIDER_ = this.Provider_;
            dao.DESCRIPTION_ = this.Description_;
            dao.TENOR_ = this.Tenor_;
            dao.SUB_TYPE_ = this.sub_type_;
            dao.LINKEDCURVE_ = this.linkedcurve_;
            dao.RATE_TYPE_ = this.Rate_type_;
            dao.LEG_TENOR_ = this.Leg_tenor_;
            dao.CURRENCY_ = this.Currency_;


            return dao;
        }

        public static string getProvider(string code)
        {
            MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

            dao.SYMBOL_ = code;

            dao.select(DataBaseConnectManager.ConnectionFactory("myDB"));


            return dao.PROVIDER_;
        }

        public static List<Excel_marketDataSymbol> getDefinedSymbolALL()
        {
            List<Excel_marketDataSymbol> symbols = new List<Excel_marketDataSymbol>();

            MARKETDATA_SYMBOL_INFO_Table_DAOManager daoM = new MARKETDATA_SYMBOL_INFO_Table_DAOManager();

            daoM.selectAll(DataBaseConnectManager.ConnectionFactory("myDB"));

            foreach (var item in daoM.DAOList_)
            {
                string underType = item.SYMBOL_TYPE_;

                //Excel_marketDataSymbol e_mds = Excel_loaderViewModel.CreateSymbolViewModel(underType);
                Excel_marketDataSymbol e_mds = new Excel_marketDataSymbol();

                e_mds.setFromDAO(item);

                symbols.Add(e_mds);
            }

            return symbols;

        }
        
        public static Excel_marketDataSymbol getDefinedSymbol(string code)
        {
            MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

            dao.SYMBOL_ = code.Trim();

            dao.select(DataBaseConnectManager.ConnectionFactory("myDB"));

            // 코드를 찾아서 symbol을 로드함.

            // symbol을 통해서 type을 로드함

            // type을 통해서 symbolVM을 만들음

            string underType = dao.SYMBOL_TYPE_;

            if (underType == null)
            {
                throw new Exception("symbol doesn't exist in symbolList : " + dao.SYMBOL_);
            }

            Excel_marketDataSymbol e_mds = Excel_loaderViewModel.CreateSymbolViewModel(underType);

            e_mds.setFromDAO(dao);

            return e_mds;

        }

        public static string underType(string underSymbol)
        {
            MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

            dao.SYMBOL_ = underSymbol.Trim();

            dao.select(DataBaseConnectManager.ConnectionFactory("myDB"));

            // 코드를 찾아서 symbol을 로드함.

            // symbol을 통해서 type을 로드함

            // type을 통해서 symbolVM을 만들음

            string underType = dao.SYMBOL_TYPE_;

            if (underType == null)
            {
                throw new Exception("symbol doesn't exist in symbolList : " + dao.SYMBOL_);
            }

            return underType;
        }

        public string vba_desciption()
        {
            string str = "";

            //if (!(this.Symbol_ == null || this.Symbol_ == "")) str += "symbol=" + this.Symbol_ + ";";
            //if (!(this.Name_eng_ == null || this.Name_eng_ == "")) str += "nameeng=" + this.Name_eng_ + ";";
            //if (!(this.Name_kor_== null || this.Name_kor_== "")) str += "namekor=" + this.Name_kor_+ ";";
            //if (!(this.Symbol_type_ == null || this.Symbol_type_ == "")) str += "symboltype=" + this.Symbol_type_ + ";";
            //if (!(this.Provider_ == null || this.Provider_ == "")) str += "provider=" + this.Sub_type_ + ";";
            //if (!(this.Tenor_ == null || this.Tenor_ == "")) str += "tenor=" + this.Tenor_ + ";";
            //if (!(this.Sub_type_ == null || this.Sub_type_ == "")) str += "subtype=" + this.Sub_type_ + ";";
            //if (!(this.Linkedcurve_ == null || this.Linkedcurve_ == "")) str += "linkedCurve=" + this.Linkedcurve_ + ";";
            //if (!(this.Rate_type_ == null || this.Rate_type_ == "")) str += "rate_type=" + this.Rate_type_ + ";";
            //if (!(this.Leg_tenor_ == null || this.Leg_tenor_ == "")) str += "leg_tenor=" + this.Leg_tenor_ + ";";
            //if (!(this.Currency_ == null || this.Currency_ == "")) str += "CURRENCY=" + this.Currency_ + ";";

            str += "symbol=" + this.Symbol_ + ";";
            str += "nameeng=" + this.Name_eng_ + ";";
            str += "namekor=" + this.Name_kor_ + ";";
            str += "symboltype=" + this.Symbol_type_ + ";";
            str += "provider=" + this.Sub_type_ + ";";
            str += "tenor=" + this.Tenor_ + ";";
            str += "subtype=" + this.Sub_type_ + ";";
            str += "linkedCurve=" + this.Linkedcurve_ + ";";
            str += "rate_type=" + this.Rate_type_ + ";";
            str += "leg_tenor=" + this.Leg_tenor_ + ";";
            str += "currency=" + this.Currency_ + ";";

            return str;
        }

        public static List<Excel_marketDataSymbol> getDefinedSymbolFiltering(string filter)
        {
            List<Excel_marketDataSymbol> symbols = new List<Excel_marketDataSymbol>();

            MARKETDATA_SYMBOL_INFO_Table_DAOManager daoM = new MARKETDATA_SYMBOL_INFO_Table_DAOManager();

            daoM.selectFiltering(DataBaseConnectManager.ConnectionFactory("myDB"), filter);

            foreach (var item in daoM.DAOList_)
	        {
                Excel_marketDataSymbol e_mds = new Excel_marketDataSymbol();

                e_mds.setFromDAO(item);

                symbols.Add(e_mds);
	        }

            return symbols;


        }
    }
}
