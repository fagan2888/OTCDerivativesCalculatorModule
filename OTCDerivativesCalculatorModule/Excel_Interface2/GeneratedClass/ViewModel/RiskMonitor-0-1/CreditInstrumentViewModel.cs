using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class CreditInstrumentViewModel : IXmlData
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
        
        public CreditInstrumentViewModel() { }
        
        #region IssueInformationViewModel_
        private IssueInformationViewModel issueInformationViewModel_;
        public IssueInformationViewModel IssueInformationViewModel_
        {
            get { return this.issueInformationViewModel_; }
            set
            {
                if (this.issueInformationViewModel_ != value)
                {
                    this.issueInformationViewModel_ = value;
                    this.NotifyPropertyChanged("IssueInformationViewModel_");
                }
            }
        }
        #endregion
        
        #region UnderlyingInformationViewModel_
        private UnderlyingInformationViewModel underlyingInformationViewModel_;
        public UnderlyingInformationViewModel UnderlyingInformationViewModel_
        {
            get { return this.underlyingInformationViewModel_; }
            set
            {
                if (this.underlyingInformationViewModel_ != value)
                {
                    this.underlyingInformationViewModel_ = value;
                    this.NotifyPropertyChanged("UnderlyingInformationViewModel_");
                }
            }
        }
        #endregion
        
        #region CreditPayoffInfoViewModel_
        private CreditPayoffInfoViewModel creditPayoffInfoViewModel_;
        public CreditPayoffInfoViewModel CreditPayoffInfoViewModel_
        {
            get { return this.creditPayoffInfoViewModel_; }
            set
            {
                if (this.creditPayoffInfoViewModel_ != value)
                {
                    this.creditPayoffInfoViewModel_ = value;
                    this.NotifyPropertyChanged("CreditPayoffInfoViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "creditInstrument");
                xmlWriter.WriteStartElement("creditInstrument");
                    issueInformationViewModel_.buildXml(xmlWriter);
                    
                    underlyingInformationViewModel_.buildXml(xmlWriter);
                    
                    creditPayoffInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new CreditInstrumentView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CreditInstrument serial_CreditInstrument = serial_Class as FpmlSerializedCSharp.CreditInstrument;
        
            FpmlSerializedCSharp.IssueInformation serial_issueInformation = serial_CreditInstrument.IssueInformation_;
            string issueInformationtype = serial_issueInformation.Excel_type_.ValueStr;
            this.issueInformationViewModel_ = IssueInformationViewModel.CreateIssueInformation(issueInformationtype);
            this.issueInformationViewModel_.setFromSerial(serial_issueInformation);
            
            FpmlSerializedCSharp.UnderlyingInformation serial_underlyingInformation = serial_CreditInstrument.UnderlyingInformation_;
            string underlyingInformationtype = serial_underlyingInformation.Excel_type_.ValueStr;
            this.underlyingInformationViewModel_ = UnderlyingInformationViewModel.CreateUnderlyingInformation(underlyingInformationtype);
            this.underlyingInformationViewModel_.setFromSerial(serial_underlyingInformation);
            
            FpmlSerializedCSharp.CreditPayoffInfo serial_creditPayoffInfo = serial_CreditInstrument.CreditPayoffInfo_;
            string creditPayoffInfotype = serial_creditPayoffInfo.Excel_type_.ValueStr;
            this.creditPayoffInfoViewModel_ = CreditPayoffInfoViewModel.CreateCreditPayoffInfo(creditPayoffInfotype);
            this.creditPayoffInfoViewModel_.setFromSerial(serial_creditPayoffInfo);
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

