using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class StandardInstrumentViewModel : IXmlData
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
        
        public StandardInstrumentViewModel() { }
        
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
        
        #region PayoffInfoViewModel_
        private PayoffInfoViewModel payoffInfoViewModel_;
        public PayoffInfoViewModel PayoffInfoViewModel_
        {
            get { return this.payoffInfoViewModel_; }
            set
            {
                if (this.payoffInfoViewModel_ != value)
                {
                    this.payoffInfoViewModel_ = value;
                    this.NotifyPropertyChanged("PayoffInfoViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "standardInstrument");
                xmlWriter.WriteStartElement("standardInstrument");
                    issueInformationViewModel_.buildXml(xmlWriter);
                    
                    underlyingInformationViewModel_.buildXml(xmlWriter);
                    
                    payoffInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new StandardInstrumentView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.StandardInstrument serial_StandardInstrument = serial_Class as FpmlSerializedCSharp.StandardInstrument;
        
            FpmlSerializedCSharp.IssueInformation serial_issueInformation = serial_StandardInstrument.IssueInformation_;
            string issueInformationtype = serial_issueInformation.Excel_type_.ValueStr;
            this.issueInformationViewModel_ = IssueInformationViewModel.CreateIssueInformation(issueInformationtype);
            this.issueInformationViewModel_.setFromSerial(serial_issueInformation);
            
            FpmlSerializedCSharp.UnderlyingInformation serial_underlyingInformation = serial_StandardInstrument.UnderlyingInformation_;
            string underlyingInformationtype = serial_underlyingInformation.Excel_type_.ValueStr;
            this.underlyingInformationViewModel_ = UnderlyingInformationViewModel.CreateUnderlyingInformation(underlyingInformationtype);
            this.underlyingInformationViewModel_.setFromSerial(serial_underlyingInformation);
            
            FpmlSerializedCSharp.PayoffInfo serial_payoffInfo = serial_StandardInstrument.PayoffInfo_;
            string payoffInfotype = serial_payoffInfo.Excel_type_.ValueStr;
            this.payoffInfoViewModel_ = PayoffInfoViewModel.CreatePayoffInfo(payoffInfotype);
            this.payoffInfoViewModel_.setFromSerial(serial_payoffInfo);
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

