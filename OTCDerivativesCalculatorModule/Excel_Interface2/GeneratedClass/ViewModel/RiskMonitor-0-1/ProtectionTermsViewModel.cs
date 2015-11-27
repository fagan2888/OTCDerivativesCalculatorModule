using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ProtectionTermsViewModel : IXmlData
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
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "protectionTerms");
                xmlWriter.WriteStartElement("protectionTerms");
                    calculationAmountViewModel_.buildXml(xmlWriter);
                    
                    creditEventsViewModel_.buildXml(xmlWriter);
                    
                    obligationsViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("accrualCoupon" , this.accrualCoupon_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new ProtectionTermsView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.ProtectionTerms serial_ProtectionTerms = serial_Class as FpmlSerializedCSharp.ProtectionTerms;
        
            FpmlSerializedCSharp.CalculationAmount serial_calculationAmount = serial_ProtectionTerms.CalculationAmount_;
            string calculationAmounttype = serial_calculationAmount.Excel_type_.ValueStr;
            this.calculationAmountViewModel_ = CalculationAmountViewModel.CreateCalculationAmount(calculationAmounttype);
            this.calculationAmountViewModel_.setFromSerial(serial_calculationAmount);
            
            FpmlSerializedCSharp.CreditEvents serial_creditEvents = serial_ProtectionTerms.CreditEvents_;
            string creditEventstype = serial_creditEvents.Excel_type_.ValueStr;
            this.creditEventsViewModel_ = CreditEventsViewModel.CreateCreditEvents(creditEventstype);
            this.creditEventsViewModel_.setFromSerial(serial_creditEvents);
            
            FpmlSerializedCSharp.Obligations serial_obligations = serial_ProtectionTerms.Obligations_;
            string obligationstype = serial_obligations.Excel_type_.ValueStr;
            this.obligationsViewModel_ = ObligationsViewModel.CreateObligations(obligationstype);
            this.obligationsViewModel_.setFromSerial(serial_obligations);
            
            this.accrualCoupon_ = serial_ProtectionTerms.AccrualCoupon_.ValueStr;
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

