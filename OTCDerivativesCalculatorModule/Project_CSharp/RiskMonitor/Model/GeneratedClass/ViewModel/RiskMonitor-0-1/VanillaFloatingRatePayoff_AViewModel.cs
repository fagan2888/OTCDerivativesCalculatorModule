using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class VanillaFloatingRatePayoff_AViewModel : EventTrigger_AViewModel
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
        
        public VanillaFloatingRatePayoff_AViewModel() { }
        
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
        
        #region Gearing_
        private string gearing_;
        public string Gearing_
        {
            get { return this.gearing_; }
            set
            {
                if (this.gearing_ != value)
                {
                    this.gearing_ = value;
                    this.NotifyPropertyChanged("Gearing_");
                }
            }
        }
        #endregion
        
        #region Spread_
        private string spread_;
        public string Spread_
        {
            get { return this.spread_; }
            set
            {
                if (this.spread_ != value)
                {
                    this.spread_ = value;
                    this.NotifyPropertyChanged("Spread_");
                }
            }
        }
        #endregion
        
        #region ReferenceStr_
        private string referenceStr_;
        public string ReferenceStr_
        {
            get { return this.referenceStr_; }
            set
            {
                if (this.referenceStr_ != value)
                {
                    this.referenceStr_ = value;
                    this.NotifyPropertyChanged("ReferenceStr_");
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
        
        #region CapFloorOptionViewModel_
        private CapFloorOptionViewModel capFloorOptionViewModel_;
        public CapFloorOptionViewModel CapFloorOptionViewModel_
        {
            get { return this.capFloorOptionViewModel_; }
            set
            {
                if (this.capFloorOptionViewModel_ != value)
                {
                    this.capFloorOptionViewModel_ = value;
                    this.NotifyPropertyChanged("CapFloorOptionViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("eventTrigger_A");
                xmlWriter.WriteElementString("type" , "vanillaFloatingRatePayoff_A");
                xmlWriter.WriteStartElement("vanillaFloatingRatePayoff_A");
                    xmlWriter.WriteElementString("dayCounter" , this.dayCounter_);
                    
                    xmlWriter.WriteElementString("calculationStartDate" , StringConverter.xmlDateTimeToDateString(this.calculationStartDate_));
                    
                    xmlWriter.WriteElementString("calculationEndDate" , StringConverter.xmlDateTimeToDateString(this.calculationEndDate_));
                    
                    xmlWriter.WriteElementString("gearing" , this.gearing_);
                    
                    xmlWriter.WriteElementString("spread" , this.spread_);
                    
                    xmlWriter.WriteElementString("referenceStr" , this.referenceStr_);
                    
                    xmlWriter.WriteElementString("payoffDate" , StringConverter.xmlDateTimeToDateString(this.payoffDate_));
                    
                    capFloorOptionViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new VanillaFloatingRatePayoff_AView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventTrigger_A serial_EventTrigger_A = serial_Class as FpmlSerializedCSharp.EventTrigger_A;
            FpmlSerializedCSharp.VanillaFloatingRatePayoff_A serial_VanillaFloatingRatePayoff_A = serial_EventTrigger_A.VanillaFloatingRatePayoff_A_;
        
            this.dayCounter_ = serial_VanillaFloatingRatePayoff_A.DayCounter_.ValueStr;
            
            this.calculationStartDate_ = StringConverter.xmlDateToDateTime(serial_VanillaFloatingRatePayoff_A.CalculationStartDate_.ValueStr);
            
            this.calculationEndDate_ = StringConverter.xmlDateToDateTime(serial_VanillaFloatingRatePayoff_A.CalculationEndDate_.ValueStr);
            
            this.gearing_ = serial_VanillaFloatingRatePayoff_A.Gearing_.ValueStr;
            
            this.spread_ = serial_VanillaFloatingRatePayoff_A.Spread_.ValueStr;
            
            this.referenceStr_ = serial_VanillaFloatingRatePayoff_A.ReferenceStr_.ValueStr;
            
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_VanillaFloatingRatePayoff_A.PayoffDate_.ValueStr);
            
            FpmlSerializedCSharp.CapFloorOption serial_capFloorOption = serial_VanillaFloatingRatePayoff_A.CapFloorOption_;
            string capFloorOptiontype = serial_capFloorOption.Excel_type_.ValueStr;
            this.capFloorOptionViewModel_ = CapFloorOptionViewModel.CreateCapFloorOption(capFloorOptiontype);
            this.capFloorOptionViewModel_.setFromSerial(serial_capFloorOption);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

