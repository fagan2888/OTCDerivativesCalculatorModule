using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    //public abstract class EventViewModel
    public class EventViewModel
    {
        #region Event

        private event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        public static string eventCodeGen()
        {
            return "testEventCode00";
        }

        #region Properties

        #region Event_code_
        private string event_code_;
        public string Event_code_
        {
            get { return this.event_code_; }
            set
            {
                if (this.event_code_ != value)
                {
                    this.event_code_ = value;
                    this.NotifyPropertyChanged("Event_code_");
                }
            }
        }
        #endregion

        #region Event_date_
        private DateTime event_date_;
        public DateTime Event_date_
        {
            get { return this.event_date_; }
            set
            {
                if (this.event_date_ != value)
                {
                    this.event_date_ = value;
                    this.NotifyPropertyChanged("Event_date_");
                }
            }
        }
        #endregion

        #region Event_type_
        private string event_type_;
        public string Event_type_
        {
            get { return this.event_type_; }
            set
            {
                if (this.event_type_ != value)
                {
                    this.event_type_ = value;
                    this.NotifyPropertyChanged("Event_type_");
                }
            }
        }
        #endregion

        #region Event_subtype_
        private string event_subtype_;
        public string Event_subtype_
        {
            get { return this.event_subtype_; }
            set
            {
                if (this.event_subtype_ != value)
                {
                    this.event_subtype_ = value;
                    this.NotifyPropertyChanged("Event_subtype_");
                }
            }
        }
        #endregion

        #region Event_name_
        private string event_name_;
        public string Event_name_
        {
            get { return this.event_name_; }
            set
            {
                if (this.event_name_ != value)
                {
                    this.event_name_ = value;
                    this.NotifyPropertyChanged("Event_name_");
                }
            }
        }
        #endregion

        #region Event_description_
        private string event_description_;
        public string Event_description_
        {
            get { return this.event_description_; }
            set
            {
                if (this.event_description_ != value)
                {
                    this.event_description_ = value;
                    this.NotifyPropertyChanged("Event_description_");
                }
            }
        }
        #endregion

        #region Currency_
        private string currency_;
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

        #region Event_amount_
        private string event_amount_;
        public string Event_amount_
        {
            get { return this.event_amount_; }
            set
            {
                if (this.event_amount_ != value)
                {
                    this.event_amount_ = value;
                    this.NotifyPropertyChanged("Event_amount_");
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

        #region Floating_flag_
        private string floating_flag_;
        public string Floating_flag_
        {
            get { return this.floating_flag_; }
            set
            {
                if (this.floating_flag_ != value)
                {
                    this.floating_flag_ = value;
                    this.NotifyPropertyChanged("Floating_flag_");
                }
            }
        }
        #endregion

        #region Calculation_type_
        private string calculation_type_;
        public string Calculation_type_
        {
            get { return this.calculation_type_; }
            set
            {
                if (this.calculation_type_ != value)
                {
                    this.calculation_type_ = value;
                    this.NotifyPropertyChanged("Calculation_type_");
                }
            }
        }
        #endregion

        #region Fixing_underlyings_
        private string fixing_underlyings_;
        public string Fixing_underlyings_
        {
            get { return this.fixing_underlyings_; }
            set
            {
                if (this.fixing_underlyings_ != value)
                {
                    this.fixing_underlyings_ = value;
                    this.NotifyPropertyChanged("Fixing_underlyings_");
                }
            }
        }
        #endregion

        #region Fixing_observation_
        private string fixing_observation_;
        public string Fixing_observation_
        {
            get { return this.fixing_observation_; }
            set
            {
                if (this.fixing_observation_ != value)
                {
                    this.fixing_observation_ = value;
                    this.NotifyPropertyChanged("Fixing_observation_");
                }
            }
        }
        #endregion

        #region Fixing_flag_
        private string fixing_flag_;
        public string Fixing_flag_
        {
            get { return this.fixing_flag_; }
            set
            {
                if (this.fixing_flag_ != value)
                {
                    this.fixing_flag_ = value;
                    this.NotifyPropertyChanged("Fixing_flag_");
                }
            }
        }
        #endregion

        #region Expired_flag_
        private string expired_flag_;
        public string Expired_flag_
        {
            get { return this.expired_flag_; }
            set
            {
                if (this.expired_flag_ != value)
                {
                    this.expired_flag_ = value;
                    this.NotifyPropertyChanged("Expired_flag_");
                }
            }
        }
        #endregion

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

        #region Item_type_
        private string item_type_;
        public string Item_type_
        {
            get { return this.item_type_; }
            set
            {
                if (this.item_type_ != value)
                {
                    this.item_type_ = value;
                    this.NotifyPropertyChanged("Item_type_");
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


        #endregion

        public void setFromDAO(EVENT_INFO_Table_DAO dao)
        {
                        // bussiness logic here
            try
            {
                this.event_code_ = dao.EVENT_CODE_;
                this.Event_date_ = DateTime.ParseExact(dao.EVENT_DATE_, "yyyyMMdd", null);
                this.event_type_ = dao.EVENT_TYPE_;
                this.event_subtype_ = dao.EVENT_SUBTYPE_;
                this.event_name_ = dao.EVENT_NAME_;
                this.event_description_ = dao.EVENT_DESCRIPTION_;
                this.currency_ = dao.CURRENCY_;
                this.notional_ = dao.NOTIONAL_;
                this.remain_notional_ = dao.REMAIN_NOTIONAL_;
                this.event_amount_ = dao.EVENT_AMOUNT_;
                this.counterparty_ = dao.COUNTERPARTY_;
                this.floating_flag_ = dao.FLOATING_FLAG_;
                this.calculation_type_ = dao.CALCULATION_TYPE_;
                this.fixing_underlyings_ = dao.FIXING_UNDERLYINGS_;
                this.fixing_observation_ = dao.FIXING_OBSERVATION_;
                this.fixing_flag_ = dao.FIXING_FLAG_;
                this.expired_flag_ = dao.EXPIRED_FLAG_;
                this.item_code_ = dao.ITEM_CODE_;
                this.item_type_ = dao.ITEM_TYPE_;
                this.item_name_ = dao.ITEM_NAME_;
            }
            catch (Exception )
            {
                //OutputLogViewModel.addResult("event dao : " + e.Message + " " + item_code_ + " " + item_name_);
            }
        }

        public void buildDAO()
        {
            // bussiness logic here
            EVENT_INFO_Table_DAO insertDao = new EVENT_INFO_Table_DAO();
            insertDao.EVENT_CODE_ = this.Event_code_;
            insertDao.EVENT_DATE_ = this.Event_date_.ToString("yyyyMMdd");
            insertDao.EVENT_TYPE_ = this.Event_type_;
            insertDao.EVENT_SUBTYPE_ = this.Event_subtype_;
            insertDao.EVENT_NAME_ = this.Event_name_;
            insertDao.EVENT_DESCRIPTION_ = this.Event_description_;
            insertDao.CURRENCY_ = this.Currency_;
            insertDao.NOTIONAL_ = this.Notional_;
            insertDao.REMAIN_NOTIONAL_ = this.Remain_notional_;
            insertDao.EVENT_AMOUNT_ = this.Event_amount_;
            insertDao.COUNTERPARTY_ = this.Counterparty_;
            insertDao.FLOATING_FLAG_ = this.Floating_flag_;
            insertDao.CALCULATION_TYPE_ = this.Calculation_type_;
            insertDao.FIXING_UNDERLYINGS_ = this.Fixing_underlyings_;
            insertDao.FIXING_OBSERVATION_ = this.Fixing_observation_;
            insertDao.FIXING_FLAG_ = this.Fixing_flag_;
            insertDao.EXPIRED_FLAG_ = this.Expired_flag_;
            insertDao.ITEM_CODE_ = this.Item_code_;
            insertDao.ITEM_TYPE_ = this.Item_type_;
            insertDao.ITEM_NAME_ = this.Item_name_;
        }

        public void dbDelete()
        {
            EVENT_INFO_Table_DAO insertDao = new EVENT_INFO_Table_DAO();

            insertDao.KeyColumn_ = this.event_code_;

            //set insertDao

            insertDao.delete(DataBaseConnectManager.ConnectionFactory("myDB"));

        }

        public void dbUpdate()
        {
            EVENT_INFO_Table_DAO updateDao = new EVENT_INFO_Table_DAO();

            //set insertDao

            updateDao.delete(DataBaseConnectManager.ConnectionFactory("myDB"));
        }

        public void dbInsert() 
        {
            // bussiness logic here
            EVENT_INFO_Table_DAO insertDao = new EVENT_INFO_Table_DAO();

            insertDao.EVENT_DATE_ = this.Event_date_.ToString("yyyyMMdd");
            insertDao.EVENT_TYPE_ = this.Event_type_;
            insertDao.EVENT_SUBTYPE_ = this.Event_subtype_;
            insertDao.EVENT_DESCRIPTION_ = this.Event_description_;
            insertDao.EVENT_NAME_ = this.Event_name_;
            insertDao.CURRENCY_ = this.Currency_;
            insertDao.EVENT_AMOUNT_ = this.Event_amount_;
            insertDao.FIXING_UNDERLYINGS_ = this.Fixing_underlyings_;
            insertDao.FIXING_FLAG_ = this.Fixing_flag_;
            insertDao.ITEM_CODE_ = this.Item_code_;
            insertDao.ITEM_TYPE_ = this.Item_type_;
            insertDao.ITEM_NAME_ = this.Item_name_;
            insertDao.REMAIN_NOTIONAL_ = this.Remain_notional_;

            insertDao.insert(DataBaseConnectManager.ConnectionFactory("myDB"));
        }


    }
}
