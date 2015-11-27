using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;


namespace Excel_Interface
{
    public class MasterInformationViewModel : INotifyPropertyChanged
    {
        public static ObservableCollection<Excel_instrumentViewModel> WholeMasterPosition_
            = new ObservableCollection<Excel_instrumentViewModel>();

        public static Dictionary<string, Excel_instrumentViewModel> masterPositionMap_
            = new Dictionary<string, Excel_instrumentViewModel>();

        //private static string connectionStr_ = @"Data Source=D:\Project File\OTCDerivativesCalculatorModule\Excel_Interface2\Excel_Interface\marketData\MarketDataDB.sdf";
        private static string connectionStr_ = EnvironmentVariable.MarketDataDBFile_;

        public static void loadWholeMasterPosition()
        {
            MasterInformationViewModel.WholeMasterPosition_.Clear();
            MasterInformationViewModel.masterPositionMap_.Clear();

            MATSER_INFO_Table_DAOManager mt_daoM = new MATSER_INFO_Table_DAOManager();

            mt_daoM.selectAll(DataBaseConnectManager.ConnectionFactory("myDB"));

            foreach (var dao in mt_daoM.DAOList_)
	        {
                Excel_instrumentViewModel e_ivm =
                    CodeClassificationGenerator.CreateInstrument(dao.ITEM_CODE_);

                e_ivm.MasterInformationViewModel_.setFromDAO(dao);

                MasterInformationViewModel.WholeMasterPosition_.Add(e_ivm);

                MasterInformationViewModel.masterPositionMap_.Add(e_ivm.MasterInformationViewModel_.Item_code_, e_ivm);
	        }
                    
        }

        public static void removeMasterInfo(string itemCode)
        {
            MATSER_INFO_Table_DAO mt_dao = new MATSER_INFO_Table_DAO();

            mt_dao.KeyColumn_ = itemCode;

            try
            {
                mt_dao.delete(DataBaseConnectManager.ConnectionFactory("myDB"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Excel_instrumentViewModel loadInstrumentVM(string itemCode)
        {
            MATSER_INFO_Table_DAO mt_dao = new MATSER_INFO_Table_DAO();

            mt_dao.ITEM_CODE_ = itemCode;

            mt_dao.select(DataBaseConnectManager.ConnectionFactory("myDB"));

            Excel_instrumentViewModel e_ivm =
                    CodeClassificationGenerator.CreateInstrument(mt_dao.ITEM_CODE_);

            e_ivm.MasterInformationViewModel_.setFromDAO(mt_dao);

            return e_ivm;
        }



        #region Event
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null )
            //if (PropertyChanged != null && propertyName == "ItemCode_")
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        public void issueInformationObserver(object sender, PropertyChangedEventArgs e)
        {
            Excel_issueInfoViewModel e_ivm = sender as Excel_issueInfoViewModel;

            if (e.PropertyName == "EffectiveDate_")
            {
                this.Trade_date_ = e_ivm.EffectiveDate_;
            }

            if (e.PropertyName == "MaturityDate_")
            {
                this.Maturity_date_ = e_ivm.MaturityDate_;
            }
        }

        #region Properties

        #region Item_code_
        private string item_code_;
        public string Item_code_
        {
            get { return this.item_code_; }
            set
            {
                if (this.item_code_ != value)
                {
                    this.item_code_ = value;
                    this.NotifyPropertyChanged("Item_code_");
                }
            }
        }
        #endregion

        #region Item_name_
        private string item_name_;
        public string Item_name_
        {
            get { return this.item_name_; }
            set
            {
                if (this.item_name_ != value)
                {
                    this.item_name_ = value;
                    this.NotifyPropertyChanged("Item_name_");
                }
            }
        }
        #endregion

        #region Notional_
        private string notional_;
        public string Notional_
        {
            get { return this.notional_; }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                    this.NotifyPropertyChanged("Notional_");
                }
            }
        }
        #endregion

        #region Remain_notional_
        private string remain_notional_;
        public string Remain_notional_
        {
            get { return this.remain_notional_; }
            set
            {
                if (this.remain_notional_ != value)
                {
                    this.remain_notional_ = value;
                    this.NotifyPropertyChanged("Remain_notional_");
                }
            }
        }
        #endregion

        #region Currency_
        private CurrencyViewModel currency_;
        public CurrencyViewModel Currency_
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

        #region Trade_date_
        private DateTime trade_date_;
        public DateTime Trade_date_
        {
            get { return this.trade_date_; }
            set
            {
                if (this.trade_date_ != value)
                {
                    this.trade_date_ = value;
                    this.NotifyPropertyChanged("Trade_date_");
                }
            }
        }
        #endregion

        #region Maturity_date_
        private DateTime maturity_date_;
        public DateTime Maturity_date_
        {
            get { return this.maturity_date_; }
            set
            {
                if (this.maturity_date_ != value)
                {
                    this.maturity_date_ = value;
                    this.NotifyPropertyChanged("Maturity_date_");
                }
            }
        }
        #endregion

        #region Counterparty_
        private string counterparty_;
        public string Counterparty_
        {
            get { return this.counterparty_; }
            set
            {
                if (this.counterparty_ != value)
                {
                    this.counterparty_ = value;
                    this.NotifyPropertyChanged("Counterparty_");
                }
            }
        }
        #endregion

        #region Export_itemcode_
        private string export_itemcode_;
        public string Export_itemcode_
        {
            get { return this.export_itemcode_; }
            set
            {
                if (this.export_itemcode_ != value)
                {
                    this.export_itemcode_ = value;
                    this.NotifyPropertyChanged("Export_itemcode_");
                }
            }
        }
        #endregion

        #region Trade_id_
        private string trade_id_;
        public string Trade_id_
        {
            get { return this.trade_id_; }
            set
            {
                if (this.trade_id_ != value)
                {
                    this.trade_id_ = value;
                    this.NotifyPropertyChanged("Trade_id_");
                }
            }
        }
        #endregion

        #region Trade_status_
        private string trade_status_;
        public string Trade_status_
        {
            get { return this.trade_status_; }
            set
            {
                if (this.trade_status_ != value)
                {
                    this.trade_status_ = value;
                    this.NotifyPropertyChanged("Trade_status_");
                }
            }
        }
        #endregion

        #region Instrument_type_
        private string instrument_type_;
        public string Instrument_type_
        {
            get { return this.instrument_type_; }
            set
            {
                if (this.instrument_type_ != value)
                {
                    this.instrument_type_ = value;
                    this.NotifyPropertyChanged("Instrument_type_");
                }
            }
        }
        #endregion

        #region Underlying_type_
        private UnderlyingComboViewModel underlying_type_;
        public UnderlyingComboViewModel Underlying_type_
        {
            get { return this.underlying_type_; }
            set
            {
                if (this.underlying_type_ != value)
                {
                    this.underlying_type_ = value;
                    this.NotifyPropertyChanged("Underlying_type_");
                }
            }
        }
        #endregion

        #region Underlying_detail_type_
        private string underlying_detail_type_;
        public string Underlying_detail_type_
        {
            get { return this.underlying_detail_type_; }
            set
            {
                if (this.underlying_detail_type_ != value)
                {
                    this.underlying_detail_type_ = value;
                    this.NotifyPropertyChanged("Underlying_detail_type_");
                }
            }
        }
        #endregion

        #region Contract_type_
        private ContractComboViewModel contract_type_;
        public ContractComboViewModel Contract_type_
        {
            get { return this.contract_type_; }
            set
            {
                if (this.contract_type_ != value)
                {
                    this.contract_type_ = value;
                    this.NotifyPropertyChanged("Contract_type_");
                }
            }
        }
        #endregion

        #region Contract_subtype_
        private ContractSubComboViewModel contract_subtype_;
        public ContractSubComboViewModel Contract_subtype_
        {
            get { return this.contract_subtype_; }
            set
            {
                if (this.contract_subtype_ != value)
                {
                    this.contract_subtype_ = value;
                    this.NotifyPropertyChanged("Contract_subtype_");
                }
            }
        }
        #endregion

        #region Contract_detail_type_
        private string contract_detail_type_;
        public string Contract_detail_type_
        {
            get { return this.contract_detail_type_; }
            set
            {
                if (this.contract_detail_type_ != value)
                {
                    this.contract_detail_type_ = value;
                    this.NotifyPropertyChanged("Contract_detail_type_");
                }
            }
        }
        #endregion

        #region Booking_type_
        private string booking_type_;
        public string Booking_type_
        {
            get { return this.booking_type_; }
            set
            {
                if (this.booking_type_ != value)
                {
                    this.booking_type_ = value;
                    this.NotifyPropertyChanged("Booking_type_");
                }
            }
        }
        #endregion

        #endregion

        public void setFromDAO(MATSER_INFO_Table_DAO dao)
        {
            // bussiness logic here
            this.item_code_ = dao.ITEM_CODE_;
            this.item_name_ = dao.ITEM_NAME_;
            this.notional_ = dao.NOTIONAL_;
            this.remain_notional_ = dao.REMAIN_NOTIONAL_;
            this.currency_ = CurrencyViewModel.CreateCurrencyComboViewModel(dao.CURRENCY_);
            this.Trade_date_ = DateTime.ParseExact(dao.TRADE_DATE_, "yyyyMMdd", null);
            this.Maturity_date_ = DateTime.ParseExact(dao.MATURITY_DATE_, "yyyyMMdd", null);
            this.counterparty_ = dao.COUNTERPARTY_;
            this.export_itemcode_ = dao.EXPORT_ITEMCODE_;
            this.trade_id_ = dao.TRADE_ID_;
            this.trade_status_ = dao.TRADE_STATUS_;
            this.instrument_type_ = dao.INSTRUMENT_TYPE_;
            this.underlying_type_ = UnderlyingComboViewModel.CreateContractComboViewModel(dao.UNDERLYING_TYPE_);
            this.underlying_detail_type_ = dao.UNDERLYING_DETAIL_TYPE_;
            this.contract_type_ = ContractComboViewModel.CreateContractComboViewModel(dao.CONTRACT_TYPE_);
            this.contract_subtype_ = ContractSubComboViewModel.CreateContractSubComboViewModel(dao.CONTRACT_SUBTYPE_);
            this.contract_detail_type_ = dao.CONTRACT_DETAIL_TYPE_;
            this.booking_type_ = dao.BOOKING_TYPE_;
            
        }

        public MATSER_INFO_Table_DAO buildDAO()
        {
            // bussiness logic here
            MATSER_INFO_Table_DAO insertDao = new MATSER_INFO_Table_DAO();

            insertDao.ITEM_CODE_ = this.Item_code_;
            insertDao.ITEM_NAME_ = this.Item_name_;
            insertDao.NOTIONAL_ = this.Notional_;
            insertDao.REMAIN_NOTIONAL_ = this.Remain_notional_;
            insertDao.CURRENCY_ =  this.Currency_.CurrencyCode_;
            insertDao.TRADE_DATE_ = this.Trade_date_.ToString("yyyyMMdd");
            insertDao.MATURITY_DATE_ = this.Maturity_date_.ToString("yyyyMMdd");
            insertDao.COUNTERPARTY_ = this.Counterparty_;
            insertDao.EXPORT_ITEMCODE_ = this.Export_itemcode_;
            insertDao.TRADE_ID_ = this.Trade_id_;
            insertDao.TRADE_STATUS_ = this.Trade_status_;
            insertDao.INSTRUMENT_TYPE_ = this.Instrument_type_;
            insertDao.UNDERLYING_TYPE_ = this.Underlying_type_.UnderlyingComboCode_;
            insertDao.UNDERLYING_DETAIL_TYPE_ = this.Underlying_detail_type_;
            insertDao.CONTRACT_TYPE_ = this.Contract_type_.ContractComboCode_;
            insertDao.CONTRACT_SUBTYPE_ = this.Contract_subtype_.ContractSubComboCode_;
            insertDao.CONTRACT_DETAIL_TYPE_ = this.Contract_detail_type_;
            insertDao.BOOKING_TYPE_ = this.Booking_type_;

            return insertDao;
        }

        public MasterInformationViewModel()
        {
            //this.view_ = new MasterInformationView();

            this.defaultPropertiesLoad();

            //this.view_.DataContext = this;
        }

        private void defaultPropertiesLoad()
        {
            // bussiness logic here
            //this.item_code_ = dao.ITEM_CODE_;
            this.item_name_ = "Input Name";
            this.notional_ = "100,000,000";
            this.remain_notional_ = "100,000,000";
            this.currency_ = CurrencyViewModel.CreateCurrencyComboViewModel("KRW");
            this.Trade_date_ = DateTime.Now;
            this.Maturity_date_ = DateTime.Now.AddYears(1);
            this.counterparty_ = "Other CounterParty";
            this.export_itemcode_ = "export_itemCode";
            //this.trade_id_ = dao.TRADE_ID_;
            //this.trade_status_ = dao.TRADE_STATUS_;
            //this.instrument_type_ = dao.INSTRUMENT_TYPE_;
            this.underlying_type_ = UnderlyingComboViewModel.CreateContractComboViewModel("IR");
            //this.underlying_detail_type_ = UnderlyingComboViewModel.CreateContractComboViewModel("");
            this.contract_type_ = ContractComboViewModel.CreateContractComboViewModel("OTCContract");
            this.contract_subtype_ = ContractSubComboViewModel.CreateContractSubComboViewModel("Option");
            //this.contract_detail_type_ = "";
            //this.booking_type_ = dao.BOOKING_TYPE_;
        }

        public void loadMasterInfo()
        { 
            // default itemCode = this itemcode

            // error itemcode null or not exist

            this.loadMasterInfo(this.item_code_);
        }

        // 메모리에 어디까지 올릴건가
        // 지금은 그냥 db access함
        public void loadMasterInfo(string itemCode)
        {
            MATSER_INFO_Table_DAO mt_dao = new MATSER_INFO_Table_DAO();

            mt_dao.KeyColumn_ = itemCode;

            mt_dao.select(DataBaseConnectManager.ConnectionFactory("myDB"));

            try
            {
                this.setFromDAO(mt_dao);
            }
            catch (Exception)
            {

                OutputLogViewModel.addResult("favor not implemeted");
            }
            
            //DataTable tb = new DataTable();

            //using (SqlCeConnection connection = new SqlCeConnection(connectionStr_))
            //using (SqlCeCommand command = connection.CreateCommand())
            //{

            //    string itemCodeWrap = QueryStr.wrapComma(itemCode);

            //    command.CommandText = "SELECT TRADE_ID, ITEM_CODE , ITEM_NAME , NOTIONAL , TYPE, " +
            //                                " TRADE_DATE , MATURITY_DATE , COUNTERPARTY , EXPORT_ITEMCODE FROM MASTERINFORMATION WHERE ITEM_CODE =" + itemCodeWrap;


            //    connection.Open();
            //    SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command.CommandText, connection);

            //    dataAdapter.Fill(tb);
            //}

            //DataRow[] resultRows = tb.Select();

            //string formatString = "yyyyMMdd";

            //foreach (DataRow item in resultRows)
            //{
            //    this.tradeID_ = item["TRADE_ID"].ToString();
            //    this.itemCode_ = item["ITEM_CODE"].ToString();
            //    this.name_ = item["ITEM_NAME"].ToString();
            //    this.notional_ = item["NOTIONAL"].ToString();
            //    this.type_ = item["TYPE"].ToString();
            //    this.tradeDate_ = DateTime.ParseExact(item["TRADE_DATE"].ToString(), formatString,null);
            //    this.maturityDate_ = DateTime.ParseExact(item["MATURITY_DATE"].ToString(), formatString, null);
            //    this.conterParty_ = item["COUNTERPARTY"].ToString();
            //    this.export_ItemCode_ = item["EXPORT_ITEMCODE"].ToString();
            //}

            this.dataContextRefersh();

        }

        public void setExportCode()
        {
            SqlCeConnection connection = new SqlCeConnection(connectionStr_);

            if (this.export_itemcode_ == null)
            {
                OutputLogViewModel.addResult("null input!");
                return;
            }
                

            try
            {

                DataTable tb = new DataTable();

                SqlCeCommand updateCommand = connection.CreateCommand();
                connection.Open();

                string itemCode = QueryStr.wrapComma(this.item_code_);
                string exportItemCodeWrap = QueryStr.wrapComma(this.export_itemcode_);

                updateCommand.CommandText = "UPDATE MASTERINFORMATION SET EXPORT_ITEMCODE = " + exportItemCodeWrap +
                                        " WHERE ITEM_CODE = " + itemCode;

                updateCommand.ExecuteNonQuery();

                connection.Close();



            }
            catch (SqlCeException )
            {
                connection.Close();
                OutputLogViewModel.addResult("DataBase Connection Error : DB Load");
                throw;
            }
        }

        public void bookingMasterInfo()
        {
            MATSER_INFO_Table_DAO dao = this.buildDAO();
            dao.insert(DataBaseConnectManager.ConnectionFactory("myDB"));

        }

        public void dataContextRefersh()
        {
            //this.view_ = new MasterInformationView();
            //this.view_.DataContext = this;
        }

        public MasterInformationView view()
        {
            MasterInformationView v = new MasterInformationView();

            //this.defaultPropertiesLoad();

            v.DataContext = this;

            return v;
        }
    }
}
