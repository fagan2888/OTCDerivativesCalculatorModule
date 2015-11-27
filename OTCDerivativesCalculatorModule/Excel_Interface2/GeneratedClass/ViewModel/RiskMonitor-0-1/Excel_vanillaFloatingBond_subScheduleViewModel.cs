using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_vanillaFloatingBond_subScheduleViewModel : IXmlData
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
        
        public Excel_vanillaFloatingBond_subScheduleViewModel() { }
        
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
        
        #region FixingDate_
        private DateTime fixingDate_;
        public DateTime FixingDate_
        {
            get { return this.fixingDate_; }
            set
            {
                if (this.fixingDate_ != value)
                {
                    this.fixingDate_ = value;
                    this.NotifyPropertyChanged("FixingDate_");
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
        
        #region PaymentDate_
        private DateTime paymentDate_;
        public DateTime PaymentDate_
        {
            get { return this.paymentDate_; }
            set
            {
                if (this.paymentDate_ != value)
                {
                    this.paymentDate_ = value;
                    this.NotifyPropertyChanged("PaymentDate_");
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
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_vanillaFloatingBond_subSchedule");
                xmlWriter.WriteStartElement("excel_vanillaFloatingBond_subSchedule");
                    xmlWriter.WriteElementString("eventDate" , StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    
                    xmlWriter.WriteElementString("fixingDate" , StringConverter.xmlDateTimeToDateString(this.fixingDate_));
                    
                    xmlWriter.WriteElementString("calculationStartDate" , StringConverter.xmlDateTimeToDateString(this.calculationStartDate_));
                    
                    xmlWriter.WriteElementString("calculationEndDate" , StringConverter.xmlDateTimeToDateString(this.calculationEndDate_));
                    
                    xmlWriter.WriteElementString("paymentDate" , StringConverter.xmlDateTimeToDateString(this.paymentDate_));
                    
                    xmlWriter.WriteElementString("gearing" , this.gearing_);
                    
                    xmlWriter.WriteElementString("spread" , this.spread_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_vanillaFloatingBond_subScheduleView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_vanillaFloatingBond_subSchedule serial_Excel_vanillaFloatingBond_subSchedule = serial_Class as FpmlSerializedCSharp.Excel_vanillaFloatingBond_subSchedule;
        
            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_Excel_vanillaFloatingBond_subSchedule.EventDate_.ValueStr);
            
            this.fixingDate_ = StringConverter.xmlDateToDateTime(serial_Excel_vanillaFloatingBond_subSchedule.FixingDate_.ValueStr);
            
            this.calculationStartDate_ = StringConverter.xmlDateToDateTime(serial_Excel_vanillaFloatingBond_subSchedule.CalculationStartDate_.ValueStr);
            
            this.calculationEndDate_ = StringConverter.xmlDateToDateTime(serial_Excel_vanillaFloatingBond_subSchedule.CalculationEndDate_.ValueStr);
            
            this.paymentDate_ = StringConverter.xmlDateToDateTime(serial_Excel_vanillaFloatingBond_subSchedule.PaymentDate_.ValueStr);
            
            this.gearing_ = serial_Excel_vanillaFloatingBond_subSchedule.Gearing_.ValueStr;
            
            this.spread_ = serial_Excel_vanillaFloatingBond_subSchedule.Spread_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

