using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public abstract class GeneralScheduleDeatilViewModel : IXmlData
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
    
        public GeneralScheduleDeatilViewModel() { }
    
        #region EventDate_
        protected string eventDate_;
        public string EventDate_
        {
            get { return this.eventDate_; }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                    this.NotifyPropertyChanged("EventDate_");
                }
            }
        }
        #endregion

        #region InitialFixingFlag_
        protected string initialFixingFlag_;
        public string InitialFixingFlag_
        {
            get { return this.initialFixingFlag_; }
            set
            {
                if (this.initialFixingFlag_ != value)
                {
                    this.initialFixingFlag_ = value;
                    this.NotifyPropertyChanged("InitialFixingFlag_");
                }
            }
        }
        #endregion

        #region InitialFixingAmount_
        protected string initialFixingAmount_;
        public string InitialFixingAmount_
        {
            get { return this.initialFixingAmount_; }
            set
            {
                if (this.initialFixingAmount_ != value)
                {
                    this.initialFixingAmount_ = value;
                    this.NotifyPropertyChanged("InitialFixingAmount_");
                }
            }
        }
        #endregion

        #region FixingUnderlying_
        protected string fixingUnderlying_;
        public string FixingUnderlying_
        {
            get { return this.fixingUnderlying_; }
            set
            {
                if (this.fixingUnderlying_ != value)
                {
                    this.fixingUnderlying_ = value;
                    this.NotifyPropertyChanged("FixingUnderlying_");
                }
            }
        }
        #endregion

        #region ObservationStartDate_
        protected string observationStartDate_;
        public string ObservationStartDate_
        {
            get { return this.observationStartDate_; }
            set
            {
                if (this.observationStartDate_ != value)
                {
                    this.observationStartDate_ = value;
                    this.NotifyPropertyChanged("ObservationStartDate_");
                }
            }
        }
        #endregion

        #region ObservationEndDate_
        protected string observationEndDate_;
        public string ObservationEndDate_
        {
            get { return this.observationEndDate_; }
            set
            {
                if (this.observationEndDate_ != value)
                {
                    this.observationEndDate_ = value;
                    this.NotifyPropertyChanged("ObservationEndDate_");
                }
            }
        }
        #endregion

        #region Type_
        private string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion
        
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
        public static GeneralScheduleDeatilViewModel CreateGeneralScheduleDeatil(string typeStr)
        {
            if ( typeStr == "general_scheduleDetail_fixedCoupon")
            {
                return new General_scheduleDetail_fixedCouponViewModel();
            }
            else if ( typeStr == "general_scheduleDetail_fixedAmount")
            {
                return new General_scheduleDetail_fixedAmountViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }

        public abstract GeneralScheduleDeatilViewModel Clone();
        
        public abstract string description();

        public abstract void bookingDetailEvent(MasterInformationViewModel masterInformationViewModel,
                                                EVENT_INFO_Table_DAO dao);
        
    }
    
}

