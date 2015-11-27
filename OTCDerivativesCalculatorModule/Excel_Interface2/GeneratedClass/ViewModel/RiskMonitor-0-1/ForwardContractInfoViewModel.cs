using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ForwardContractInfoViewModel : IXmlData
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
        
        public ForwardContractInfoViewModel() { }
        
        #region CalculationDate_
        private DateTime calculationDate_;
        public DateTime CalculationDate_
        {
            get { return this.calculationDate_; }
            set
            {
                if (this.calculationDate_ != value)
                {
                    this.calculationDate_ = value;
                    this.NotifyPropertyChanged("CalculationDate_");
                }
            }
        }
        #endregion
        
        #region SettlementDays_
        private string settlementDays_;
        public string SettlementDays_
        {
            get { return this.settlementDays_; }
            set
            {
                if (this.settlementDays_ != value)
                {
                    this.settlementDays_ = value;
                    this.NotifyPropertyChanged("SettlementDays_");
                }
            }
        }
        #endregion
        
        #region SettlementDate_
        private DateTime settlementDate_;
        public DateTime SettlementDate_
        {
            get { return this.settlementDate_; }
            set
            {
                if (this.settlementDate_ != value)
                {
                    this.settlementDate_ = value;
                    this.NotifyPropertyChanged("SettlementDate_");
                }
            }
        }
        #endregion
        
        #region ForwardPoint_
        private string forwardPoint_;
        public string ForwardPoint_
        {
            get { return this.forwardPoint_; }
            set
            {
                if (this.forwardPoint_ != value)
                {
                    this.forwardPoint_ = value;
                    this.NotifyPropertyChanged("ForwardPoint_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "forwardContractInfo");
                xmlWriter.WriteStartElement("forwardContractInfo");
                    xmlWriter.WriteElementString("calculationDate" , StringConverter.xmlDateTimeToDateString(this.calculationDate_));
                    
                    xmlWriter.WriteElementString("settlementDays" , this.settlementDays_);
                    
                    xmlWriter.WriteElementString("settlementDate" , StringConverter.xmlDateTimeToDateString(this.settlementDate_));
                    
                    xmlWriter.WriteElementString("forwardPoint" , this.forwardPoint_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new ForwardContractInfoView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ForwardContractInfo serial_ForwardContractInfo = serial_Class as FpmlSerializedCSharp.ForwardContractInfo;
        
            this.calculationDate_ = StringConverter.xmlDateToDateTime(serial_ForwardContractInfo.CalculationDate_.ValueStr);
            
            this.settlementDays_ = serial_ForwardContractInfo.SettlementDays_.ValueStr;
            
            this.settlementDate_ = StringConverter.xmlDateToDateTime(serial_ForwardContractInfo.SettlementDate_.ValueStr);
            
            this.forwardPoint_ = serial_ForwardContractInfo.ForwardPoint_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

