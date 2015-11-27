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
        private DateTime eventDate_;
        public DateTime EventDate_
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
        
        #region General_scheduleDetail_fixedCouponViewModel_
        private General_scheduleDetail_fixedCouponViewModel general_scheduleDetail_fixedCouponViewModel_;
        public General_scheduleDetail_fixedCouponViewModel General_scheduleDetail_fixedCouponViewModel_
        {
            get { return this.general_scheduleDetail_fixedCouponViewModel_; }
            set
            {
                if (this.general_scheduleDetail_fixedCouponViewModel_ != value)
                {
                    this.general_scheduleDetail_fixedCouponViewModel_ = value;
                    this.NotifyPropertyChanged("General_scheduleDetail_fixedCouponViewModel_");
                }
            }
        }
        #endregion
        
        #region General_scheduleDetail_fixedAmountViewModel_
        private General_scheduleDetail_fixedAmountViewModel general_scheduleDetail_fixedAmountViewModel_;
        public General_scheduleDetail_fixedAmountViewModel General_scheduleDetail_fixedAmountViewModel_
        {
            get { return this.general_scheduleDetail_fixedAmountViewModel_; }
            set
            {
                if (this.general_scheduleDetail_fixedAmountViewModel_ != value)
                {
                    this.general_scheduleDetail_fixedAmountViewModel_ = value;
                    this.NotifyPropertyChanged("General_scheduleDetail_fixedAmountViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
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
        
        
    
    }
    
}

