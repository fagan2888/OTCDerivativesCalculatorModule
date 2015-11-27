using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class BondInformationViewModel : IXmlData
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
        
        public BondInformationViewModel() { }
        
        #region IrFrequency_
        private string irFrequency_;
        public string IrFrequency_
        {
            get { return this.irFrequency_; }
            set
            {
                if (this.irFrequency_ != value)
                {
                    this.irFrequency_ = value;
                    this.NotifyPropertyChanged("IrFrequency_");
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
        
        #region IssueDate_
        private DateTime issueDate_;
        public DateTime IssueDate_
        {
            get { return this.issueDate_; }
            set
            {
                if (this.issueDate_ != value)
                {
                    this.issueDate_ = value;
                    this.NotifyPropertyChanged("IssueDate_");
                }
            }
        }
        #endregion
        
        #region MaturityDate_
        private DateTime maturityDate_;
        public DateTime MaturityDate_
        {
            get { return this.maturityDate_; }
            set
            {
                if (this.maturityDate_ != value)
                {
                    this.maturityDate_ = value;
                    this.NotifyPropertyChanged("MaturityDate_");
                }
            }
        }
        #endregion
        
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
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "bondInformation");
                xmlWriter.WriteStartElement("bondInformation");
                    xmlWriter.WriteElementString("irFrequency" , this.irFrequency_);
                    
                    xmlWriter.WriteElementString("notional" , this.notional_);
                    
                    xmlWriter.WriteElementString("issueDate" , StringConverter.xmlDateTimeToDateString(this.issueDate_));
                    
                    xmlWriter.WriteElementString("maturityDate" , StringConverter.xmlDateTimeToDateString(this.maturityDate_));
                    
                    xmlWriter.WriteElementString("dayCounter" , this.dayCounter_);
                    
                    xmlWriter.WriteElementString("businessDayConvention" , this.businessDayConvention_);
                    
                    xmlWriter.WriteElementString("calendar" , this.calendar_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new BondInformationView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.BondInformation serial_BondInformation = serial_Class as FpmlSerializedCSharp.BondInformation;
        
            this.irFrequency_ = serial_BondInformation.IrFrequency_.ValueStr;
            
            this.notional_ = serial_BondInformation.Notional_.ValueStr;
            
            this.issueDate_ = StringConverter.xmlDateToDateTime(serial_BondInformation.IssueDate_.ValueStr);
            
            this.maturityDate_ = StringConverter.xmlDateToDateTime(serial_BondInformation.MaturityDate_.ValueStr);
            
            this.dayCounter_ = serial_BondInformation.DayCounter_.ValueStr;
            
            this.businessDayConvention_ = serial_BondInformation.BusinessDayConvention_.ValueStr;
            
            this.calendar_ = serial_BondInformation.Calendar_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

