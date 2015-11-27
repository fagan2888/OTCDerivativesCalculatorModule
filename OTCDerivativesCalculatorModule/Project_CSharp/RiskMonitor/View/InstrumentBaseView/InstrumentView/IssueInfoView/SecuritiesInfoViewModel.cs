using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class SecuritiesInfoViewModel : IssueInformationViewModel
    {
    
        public SecuritiesInfoViewModel() { }
        
    
        #region Notional_
        private string notional_;
        public string Notional_
        {
            get { return this.notional_; }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                    this.NotifyPropertyChanged("Notional_");
                }
            }
        }
        #endregion
        
        #region TradeDate_
        private string tradeDate_;
        public string TradeDate_
        {
            get { return this.tradeDate_; }
            set
            {
                if (this.tradeDate_ != value)
                {
                    this.tradeDate_ = value;
                    this.NotifyPropertyChanged("TradeDate_");
                }
            }
        }
        #endregion
        
        #region EffectiveDate_
        private string effectiveDate_;
        public string EffectiveDate_
        {
            get { return this.effectiveDate_; }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                    this.NotifyPropertyChanged("EffectiveDate_");
                }
            }
        }
        #endregion
        
        #region MaturityDate_
        private string maturityDate_;
        public string MaturityDate_
        {
            get { return this.maturityDate_; }
            set
            {
                if (this.maturityDate_ != value)
                {
                    this.maturityDate_ = value;
                    this.NotifyPropertyChanged("MaturityDate_");
                }
            }
        }
        #endregion
        
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
        
        #region Premium_
        private string premium_;
        public string Premium_
        {
            get { return this.premium_; }
            set
            {
                if (this.premium_ != value)
                {
                    this.premium_ = value;
                    this.NotifyPropertyChanged("Premium_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.IssueInformation serial_IssueInformation = serial_Class as FpmlSerializedCSharp.IssueInformation;
            FpmlSerializedCSharp.SecuritiesInfo serial_SecuritiesInfo = serial_IssueInformation.SecuritiesInfo_;
        
            this.notional_ = serial_SecuritiesInfo.Notional_.ValueStr;
            
            this.tradeDate_ = serial_SecuritiesInfo.TradeDate_.ValueStr;
            
            this.effectiveDate_ = serial_SecuritiesInfo.EffectiveDate_.ValueStr;
            
            this.maturityDate_ = serial_SecuritiesInfo.MaturityDate_.ValueStr;
            
            FpmlSerializedCSharp.CalculationAmount serial_calculationAmount = serial_SecuritiesInfo.CalculationAmount_;
            this.calculationAmountViewModel_.setFromSerial(serial_calculationAmount);
            
            this.premium_ = serial_SecuritiesInfo.Premium_.ValueStr;
            
            this.view_ = new SecuritiesInfoView();
            this.view_.DataContext = this;
        }
        
    
    }
    
}

