using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ProtectionTermsViewModel : IXmlData
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
    
        public ProtectionTermsViewModel() { }
        
        #region CalculationAmountViewModel_
        private CalculationAmountViewModel calculationAmountViewModel_;
        public CalculationAmountViewModel CalculationAmountViewModel_
        {
            get { return this.calculationAmountViewModel_; }
            set
            {
                if (this.calculationAmountViewModel_ != value)
                {
                    this.calculationAmountViewModel_ = value;
                    this.NotifyPropertyChanged("CalculationAmountViewModel_");
                }
            }
        }
        #endregion
        
        #region CreditEventsViewModel_
        private CreditEventsViewModel creditEventsViewModel_;
        public CreditEventsViewModel CreditEventsViewModel_
        {
            get { return this.creditEventsViewModel_; }
            set
            {
                if (this.creditEventsViewModel_ != value)
                {
                    this.creditEventsViewModel_ = value;
                    this.NotifyPropertyChanged("CreditEventsViewModel_");
                }
            }
        }
        #endregion
        
        #region ObligationsViewModel_
        private ObligationsViewModel obligationsViewModel_;
        public ObligationsViewModel ObligationsViewModel_
        {
            get { return this.obligationsViewModel_; }
            set
            {
                if (this.obligationsViewModel_ != value)
                {
                    this.obligationsViewModel_ = value;
                    this.NotifyPropertyChanged("ObligationsViewModel_");
                }
            }
        }
        #endregion
        
        #region AccrualCoupon_
        private string accrualCoupon_;
        public string AccrualCoupon_
        {
            get { return this.accrualCoupon_; }
            set
            {
                if (this.accrualCoupon_ != value)
                {
                    this.accrualCoupon_ = value;
                    this.NotifyPropertyChanged("AccrualCoupon_");
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
            FpmlSerializedCSharp.ProtectionTerms serial_ProtectionTerms = serial_Class as FpmlSerializedCSharp.ProtectionTerms;
        
            FpmlSerializedCSharp.CalculationAmount serial_calculationAmount = serial_ProtectionTerms.CalculationAmount_;
            this.calculationAmountViewModel_ = new CalculationAmountViewModel();
            this.calculationAmountViewModel_.setFromSerial(serial_calculationAmount);
            
            FpmlSerializedCSharp.CreditEvents serial_creditEvents = serial_ProtectionTerms.CreditEvents_;
            this.creditEventsViewModel_ = new CreditEventsViewModel();
            this.creditEventsViewModel_.setFromSerial(serial_creditEvents);
            
            FpmlSerializedCSharp.Obligations serial_obligations = serial_ProtectionTerms.Obligations_;
            this.obligationsViewModel_ = new ObligationsViewModel();
            this.obligationsViewModel_.setFromSerial(serial_obligations);
            
            this.accrualCoupon_ = serial_ProtectionTerms.AccrualCoupon_.ValueStr;
            
            this.view_ = new ProtectionTermsView();
            this.view_.DataContext = this;
        }
    
    }
    
}

