using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class StandardSwapInstrumentViewModel : IXmlData
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
        
        public StandardSwapInstrumentViewModel() { }
        
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
        
        #region SwapPayoffInfoViewModel_
        private SwapPayoffInfoViewModel swapPayoffInfoViewModel_;
        public SwapPayoffInfoViewModel SwapPayoffInfoViewModel_
        {
            get { return this.swapPayoffInfoViewModel_; }
            set
            {
                if (this.swapPayoffInfoViewModel_ != value)
                {
                    this.swapPayoffInfoViewModel_ = value;
                    this.NotifyPropertyChanged("SwapPayoffInfoViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "standardSwapInstrument");
                xmlWriter.WriteStartElement("standardSwapInstrument");
                    issueInformationViewModel_.buildXml(xmlWriter);
                    
                    underlyingInformationViewModel_.buildXml(xmlWriter);
                    
                    swapPayoffInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new StandardSwapInstrumentView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.StandardSwapInstrument serial_StandardSwapInstrument = serial_Class as FpmlSerializedCSharp.StandardSwapInstrument;
        
            FpmlSerializedCSharp.IssueInformation serial_issueInformation = serial_StandardSwapInstrument.IssueInformation_;
            string issueInformationtype = serial_issueInformation.Excel_type_.ValueStr;
            this.issueInformationViewModel_ = IssueInformationViewModel.CreateIssueInformation(issueInformationtype);
            this.issueInformationViewModel_.setFromSerial(serial_issueInformation);
            
            FpmlSerializedCSharp.UnderlyingInformation serial_underlyingInformation = serial_StandardSwapInstrument.UnderlyingInformation_;
            string underlyingInformationtype = serial_underlyingInformation.Excel_type_.ValueStr;
            this.underlyingInformationViewModel_ = UnderlyingInformationViewModel.CreateUnderlyingInformation(underlyingInformationtype);
            this.underlyingInformationViewModel_.setFromSerial(serial_underlyingInformation);
            
            FpmlSerializedCSharp.SwapPayoffInfo serial_swapPayoffInfo = serial_StandardSwapInstrument.SwapPayoffInfo_;
            string swapPayoffInfotype = serial_swapPayoffInfo.Excel_type_.ValueStr;
            this.swapPayoffInfoViewModel_ = SwapPayoffInfoViewModel.CreateSwapPayoffInfo(swapPayoffInfotype);
            this.swapPayoffInfoViewModel_.setFromSerial(serial_swapPayoffInfo);
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

