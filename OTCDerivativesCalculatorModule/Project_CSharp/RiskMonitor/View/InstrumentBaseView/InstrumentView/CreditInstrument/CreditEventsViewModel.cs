using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class CreditEventsViewModel : IXmlData
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
        
    
        public CreditEventsViewModel() { }
        
    
        #region FailureToPay_
        private string failureToPay_;
        public string FailureToPay_
        {
            get { return this.failureToPay_; }
            set
            {
                if (this.failureToPay_ != value)
                {
                    this.failureToPay_ = value;
                    this.NotifyPropertyChanged("FailureToPay_");
                }
            }
        }
        #endregion
        
        #region ObligationAcceleration_
        private string obligationAcceleration_;
        public string ObligationAcceleration_
        {
            get { return this.obligationAcceleration_; }
            set
            {
                if (this.obligationAcceleration_ != value)
                {
                    this.obligationAcceleration_ = value;
                    this.NotifyPropertyChanged("ObligationAcceleration_");
                }
            }
        }
        #endregion
        
        #region RepudiationMoratorium_
        private string repudiationMoratorium_;
        public string RepudiationMoratorium_
        {
            get { return this.repudiationMoratorium_; }
            set
            {
                if (this.repudiationMoratorium_ != value)
                {
                    this.repudiationMoratorium_ = value;
                    this.NotifyPropertyChanged("RepudiationMoratorium_");
                }
            }
        }
        #endregion
        
        #region Restructuring_
        private string restructuring_;
        public string Restructuring_
        {
            get { return this.restructuring_; }
            set
            {
                if (this.restructuring_ != value)
                {
                    this.restructuring_ = value;
                    this.NotifyPropertyChanged("Restructuring_");
                }
            }
        }
        #endregion
        
        #region DefaultRequirement_
        private string defaultRequirement_;
        public string DefaultRequirement_
        {
            get { return this.defaultRequirement_; }
            set
            {
                if (this.defaultRequirement_ != value)
                {
                    this.defaultRequirement_ = value;
                    this.NotifyPropertyChanged("DefaultRequirement_");
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
            FpmlSerializedCSharp.CreditEvents serial_CreditEvents = serial_Class as FpmlSerializedCSharp.CreditEvents;
        
            this.failureToPay_ = serial_CreditEvents.FailureToPay_.ValueStr;
            
            this.obligationAcceleration_ = serial_CreditEvents.ObligationAcceleration_.ValueStr;
            
            this.repudiationMoratorium_ = serial_CreditEvents.RepudiationMoratorium_.ValueStr;
            
            this.restructuring_ = serial_CreditEvents.Restructuring_.ValueStr;
            
            this.defaultRequirement_ = serial_CreditEvents.DefaultRequirement_.ValueStr;
            
            this.view_ = new CreditEventsView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}

