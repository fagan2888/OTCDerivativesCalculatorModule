using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class FixedRatePayoff_AViewModel : EventTrigger_AViewModel
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
        
        public FixedRatePayoff_AViewModel() { }
        
        #region DayCounter_
        private string dayCounter_;
        public string DayCounter_
        {
            get { return this.dayCounter_; }
            set
            {
                if (this.dayCounter_ != value)
                {
                    this.dayCounter_ = value;
                    this.NotifyPropertyChanged("DayCounter_");
                }
            }
        }
        #endregion
        
        #region CalculationStartDate_
        private DateTime calculationStartDate_;
        public DateTime CalculationStartDate_
        {
            get { return this.calculationStartDate_; }
            set
            {
                if (this.calculationStartDate_ != value)
                {
                    this.calculationStartDate_ = value;
                    this.NotifyPropertyChanged("CalculationStartDate_");
                }
            }
        }
        #endregion
        
        #region CalculationEndDate_
        private DateTime calculationEndDate_;
        public DateTime CalculationEndDate_
        {
            get { return this.calculationEndDate_; }
            set
            {
                if (this.calculationEndDate_ != value)
                {
                    this.calculationEndDate_ = value;
                    this.NotifyPropertyChanged("CalculationEndDate_");
                }
            }
        }
        #endregion
        
        #region FixedRate_
        private string fixedRate_;
        public string FixedRate_
        {
            get { return this.fixedRate_; }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                    this.NotifyPropertyChanged("FixedRate_");
                }
            }
        }
        #endregion
        
        #region PayoffDate_
        private DateTime payoffDate_;
        public DateTime PayoffDate_
        {
            get { return this.payoffDate_; }
            set
            {
                if (this.payoffDate_ != value)
                {
                    this.payoffDate_ = value;
                    this.NotifyPropertyChanged("PayoffDate_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("eventTrigger_A");
                xmlWriter.WriteElementString("excel_type" , "fixedRatePayoff_A");
                xmlWriter.WriteStartElement("fixedRatePayoff_A");
                    xmlWriter.WriteElementString("dayCounter" , this.dayCounter_);
                    
                    xmlWriter.WriteElementString("calculationStartDate" , StringConverter.xmlDateTimeToDateString(this.calculationStartDate_));
                    
                    xmlWriter.WriteElementString("calculationEndDate" , StringConverter.xmlDateTimeToDateString(this.calculationEndDate_));
                    
                    xmlWriter.WriteElementString("fixedRate" , this.fixedRate_);
                    
                    xmlWriter.WriteElementString("payoffDate" , StringConverter.xmlDateTimeToDateString(this.payoffDate_));
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new FixedRatePayoff_AView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventTrigger_A serial_EventTrigger_A = serial_Class as FpmlSerializedCSharp.EventTrigger_A;
            FpmlSerializedCSharp.FixedRatePayoff_A serial_FixedRatePayoff_A = serial_EventTrigger_A.FixedRatePayoff_A_;
        
            this.dayCounter_ = serial_FixedRatePayoff_A.DayCounter_.ValueStr;
            
            this.calculationStartDate_ = StringConverter.xmlDateToDateTime(serial_FixedRatePayoff_A.CalculationStartDate_.ValueStr);
            
            this.calculationEndDate_ = StringConverter.xmlDateToDateTime(serial_FixedRatePayoff_A.CalculationEndDate_.ValueStr);
            
            this.fixedRate_ = serial_FixedRatePayoff_A.FixedRate_.ValueStr;
            
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_FixedRatePayoff_A.PayoffDate_.ValueStr);
            
        }
        
        
    
        
    
        
    
    }
    
}

