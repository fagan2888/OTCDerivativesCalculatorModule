using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ProtectionPartViewModel : IXmlData
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
        
        public ProtectionPartViewModel() { }
        
        #region PayRecieve_
        private string payRecieve_;
        public string PayRecieve_
        {
            get { return this.payRecieve_; }
            set
            {
                if (this.payRecieve_ != value)
                {
                    this.payRecieve_ = value;
                    this.NotifyPropertyChanged("PayRecieve_");
                }
            }
        }
        #endregion
        
        #region ReferenceInformationListViewModel_
        private ReferenceInformationListViewModel referenceInformationListViewModel_;
        public ReferenceInformationListViewModel ReferenceInformationListViewModel_
        {
            get { return this.referenceInformationListViewModel_; }
            set
            {
                if (this.referenceInformationListViewModel_ != value)
                {
                    this.referenceInformationListViewModel_ = value;
                    this.NotifyPropertyChanged("ReferenceInformationListViewModel_");
                }
            }
        }
        #endregion
        
        #region ProtectionTermsViewModel_
        private ProtectionTermsViewModel protectionTermsViewModel_;
        public ProtectionTermsViewModel ProtectionTermsViewModel_
        {
            get { return this.protectionTermsViewModel_; }
            set
            {
                if (this.protectionTermsViewModel_ != value)
                {
                    this.protectionTermsViewModel_ = value;
                    this.NotifyPropertyChanged("ProtectionTermsViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "protectionPart");
                xmlWriter.WriteStartElement("protectionPart");
                    xmlWriter.WriteElementString("payRecieve" , this.payRecieve_);
                    
                    referenceInformationListViewModel_.buildXml(xmlWriter);
                    
                    protectionTermsViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new ProtectionPartView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ProtectionPart serial_ProtectionPart = serial_Class as FpmlSerializedCSharp.ProtectionPart;
        
            this.payRecieve_ = serial_ProtectionPart.PayRecieve_.ValueStr;
            
            FpmlSerializedCSharp.ReferenceInformationList serial_referenceInformationList = serial_ProtectionPart.ReferenceInformationList_;
            string referenceInformationListtype = serial_referenceInformationList.Excel_type_.ValueStr;
            this.referenceInformationListViewModel_ = ReferenceInformationListViewModel.CreateReferenceInformationList(referenceInformationListtype);
            this.referenceInformationListViewModel_.setFromSerial(serial_referenceInformationList);
            
            FpmlSerializedCSharp.ProtectionTerms serial_protectionTerms = serial_ProtectionPart.ProtectionTerms_;
            string protectionTermstype = serial_protectionTerms.Excel_type_.ValueStr;
            this.protectionTermsViewModel_ = ProtectionTermsViewModel.CreateProtectionTerms(protectionTermstype);
            this.protectionTermsViewModel_.setFromSerial(serial_protectionTerms);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

