using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ReferenceInformationViewModel : IXmlData
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
        
    
        public ReferenceInformationViewModel() { }
        
    
        #region ReferenceEntityViewModel_
        private ReferenceEntityViewModel referenceEntityViewModel_;
        public ReferenceEntityViewModel ReferenceEntityViewModel_
        {
            get { return this.referenceEntityViewModel_; }
            set
            {
                if (this.referenceEntityViewModel_ != value)
                {
                    this.referenceEntityViewModel_ = value;
                    this.NotifyPropertyChanged("ReferenceEntityViewModel_");
                }
            }
        }
        #endregion
        
        #region ReferenceObligationViewModel_
        private ReferenceObligationViewModel referenceObligationViewModel_;
        public ReferenceObligationViewModel ReferenceObligationViewModel_
        {
            get { return this.referenceObligationViewModel_; }
            set
            {
                if (this.referenceObligationViewModel_ != value)
                {
                    this.referenceObligationViewModel_ = value;
                    this.NotifyPropertyChanged("ReferenceObligationViewModel_");
                }
            }
        }
        #endregion
        
        #region ReferencePrice_
        private string referencePrice_;
        public string ReferencePrice_
        {
            get { return this.referencePrice_; }
            set
            {
                if (this.referencePrice_ != value)
                {
                    this.referencePrice_ = value;
                    this.NotifyPropertyChanged("ReferencePrice_");
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
            FpmlSerializedCSharp.ReferenceInformation serial_ReferenceInformation = serial_Class as FpmlSerializedCSharp.ReferenceInformation;
        
            FpmlSerializedCSharp.ReferenceEntity serial_referenceEntity = serial_ReferenceInformation.ReferenceEntity_;
            this.referenceEntityViewModel_ = new ReferenceEntityViewModel();
            this.referenceEntityViewModel_.setFromSerial(serial_referenceEntity);
            
            FpmlSerializedCSharp.ReferenceObligation serial_referenceObligation = serial_ReferenceInformation.ReferenceObligation_;
            this.referenceObligationViewModel_ = new ReferenceObligationViewModel();
            this.referenceObligationViewModel_.setFromSerial(serial_referenceObligation);
            
            this.referencePrice_ = serial_ReferenceInformation.ReferencePrice_.ValueStr;
            
        }
    
    }
    
}

