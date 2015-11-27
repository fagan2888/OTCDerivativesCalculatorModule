using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ScheduleInfoViewModel : IXmlData
    {
        #region View_
        private Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }
        #endregion
    
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
        
    
        public ScheduleInfoViewModel() { }
    
        #region EffectiveDate_
        private string effectiveDate_;
        public string EffectiveDate_
        {
            get { return this.effectiveDate_; }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                    this.NotifyPropertyChanged("EffectiveDate_");
                }
            }
        }
        #endregion
        
        #region TerminationDate_
        private string terminationDate_;
        public string TerminationDate_
        {
            get { return this.terminationDate_; }
            set
            {
                if (this.terminationDate_ != value)
                {
                    this.terminationDate_ = value;
                    this.NotifyPropertyChanged("TerminationDate_");
                }
            }
        }
        #endregion
        
        #region PaymentDays_
        private string paymentDays_;
        public string PaymentDays_
        {
            get { return this.paymentDays_; }
            set
            {
                if (this.paymentDays_ != value)
                {
                    this.paymentDays_ = value;
                    this.NotifyPropertyChanged("PaymentDays_");
                }
            }
        }
        #endregion
        
        #region Calendar_
        private string calendar_;
        public string Calendar_
        {
            get { return this.calendar_; }
            set
            {
                if (this.calendar_ != value)
                {
                    this.calendar_ = value;
                    this.NotifyPropertyChanged("Calendar_");
                }
            }
        }
        #endregion
        
        #region BusinessDayConvention_
        private string businessDayConvention_;
        public string BusinessDayConvention_
        {
            get { return this.businessDayConvention_; }
            set
            {
                if (this.businessDayConvention_ != value)
                {
                    this.businessDayConvention_ = value;
                    this.NotifyPropertyChanged("BusinessDayConvention_");
                }
            }
        }
        #endregion
        
        #region DateGeneration_
        private string dateGeneration_;
        public string DateGeneration_
        {
            get { return this.dateGeneration_; }
            set
            {
                if (this.dateGeneration_ != value)
                {
                    this.dateGeneration_ = value;
                    this.NotifyPropertyChanged("DateGeneration_");
                }
            }
        }
        #endregion
        
        #region PeriodFrequency_
        private string periodFrequency_;
        public string PeriodFrequency_
        {
            get { return this.periodFrequency_; }
            set
            {
                if (this.periodFrequency_ != value)
                {
                    this.periodFrequency_ = value;
                    this.NotifyPropertyChanged("PeriodFrequency_");
                }
            }
        }
        #endregion
        
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ScheduleInfo serial_ScheduleInfo = serial_Class as FpmlSerializedCSharp.ScheduleInfo;
        
            this.effectiveDate_ = serial_ScheduleInfo.EffectiveDate_.ValueStr;
            
            this.terminationDate_ = serial_ScheduleInfo.TerminationDate_.ValueStr;
            
            this.paymentDays_ = serial_ScheduleInfo.PaymentDays_.ValueStr;
            
            this.calendar_ = serial_ScheduleInfo.Calendar_.ValueStr;
            
            this.businessDayConvention_ = serial_ScheduleInfo.BusinessDayConvention_.ValueStr;
            
            this.dateGeneration_ = serial_ScheduleInfo.DateGeneration_.ValueStr;
            
            this.periodFrequency_ = serial_ScheduleInfo.PeriodFrequency_.ValueStr;
            
            this.view_ = new ScheduleInfoView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}

