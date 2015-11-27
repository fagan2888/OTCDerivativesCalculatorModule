using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ProtectionPartViewModel : IXmlData
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
            throw new NotImplementedException();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ProtectionPart serial_ProtectionPart = serial_Class as FpmlSerializedCSharp.ProtectionPart;
        
            this.payRecieve_ = serial_ProtectionPart.PayRecieve_.ValueStr;
            
            FpmlSerializedCSharp.ReferenceInformationList serial_referenceInformationList = serial_ProtectionPart.ReferenceInformationList_;
            this.referenceInformationListViewModel_ = new ReferenceInformationListViewModel();
            this.referenceInformationListViewModel_.setFromSerial(serial_referenceInformationList);
            
            FpmlSerializedCSharp.ProtectionTerms serial_protectionTerms = serial_ProtectionPart.ProtectionTerms_;
            this.protectionTermsViewModel_ = new ProtectionTermsViewModel();
            this.protectionTermsViewModel_.setFromSerial(serial_protectionTerms);
            
            this.view_ = new ProtectionPartView();
            this.view_.DataContext = this;
        }
    
    }
    
}

