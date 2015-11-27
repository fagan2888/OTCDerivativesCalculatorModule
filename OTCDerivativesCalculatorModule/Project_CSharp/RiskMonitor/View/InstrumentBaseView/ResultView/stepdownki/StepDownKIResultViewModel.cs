using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class StepDownKIResultViewModel : PricingResultViewModel
    {
        public StepDownKIResultViewModel() { }
    
        #region UnderylingInfoResultViewModel_
        private UnderylingInfoResultViewModel underylingInfoResultViewModel_;
        public UnderylingInfoResultViewModel UnderylingInfoResultViewModel_
        {
            get { return this.underylingInfoResultViewModel_; }
            set
            {
                if (this.underylingInfoResultViewModel_ != value)
                {
                    this.underylingInfoResultViewModel_ = value;
                    this.NotifyPropertyChanged("UnderylingInfoResultViewModel_");
                }
            }
        }
        #endregion
        
        #region CashFlowInfoResultViewModel_
        private CashFlowInfoResultViewModel cashFlowInfoResultViewModel_;
        public CashFlowInfoResultViewModel CashFlowInfoResultViewModel_
        {
            get { return this.cashFlowInfoResultViewModel_; }
            set
            {
                if (this.cashFlowInfoResultViewModel_ != value)
                {
                    this.cashFlowInfoResultViewModel_ = value;
                    this.NotifyPropertyChanged("CashFlowInfoResultViewModel_");
                }
            }
        }
        #endregion
        
        #region Theta_
        private string theta_;
        public string Theta_
        {
            get { return this.theta_; }
            set
            {
                if (this.theta_ != value)
                {
                    this.theta_ = value;
                    this.NotifyPropertyChanged("Theta_");
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
            FpmlSerializedCSharp.PricingResult serial_PricingResult = serial_Class as FpmlSerializedCSharp.PricingResult;
            FpmlSerializedCSharp.StepDownKIResult serial_StepDownKIResult = serial_PricingResult.StepDownKIResult_;

            this.Type_ = serial_PricingResult.Type_.ValueStr;

            FpmlSerializedCSharp.CommonResult serial_commonResult = serial_PricingResult.CommonResult_;
            this.CommonResultViewModel_ = new CommonResultViewModel();
            this.CommonResultViewModel_.setFromSerial(serial_commonResult);

            FpmlSerializedCSharp.UnderylingInfoResult serial_underylingInfoResult = serial_StepDownKIResult.UnderylingInfoResult_;
            this.underylingInfoResultViewModel_ = new UnderylingInfoResultViewModel();
            this.underylingInfoResultViewModel_.setFromSerial(serial_underylingInfoResult);
            
            //FpmlSerializedCSharp.CashFlowInfoResult serial_cashFlowInfoResult = serial_StepDownKIResult.CashFlowInfoResult_;
            //string cashFlowInfoResulttype = serial_cashFlowInfoResult.Type_.ValueStr;
            //this.cashFlowInfoResultViewModel_ = CashFlowInfoResultViewModel.CreateCashFlowInfoResult(cashFlowInfoResulttype);
            //this.cashFlowInfoResultViewModel_.setFromSerial(serial_cashFlowInfoResult);
            
            this.theta_ = serial_StepDownKIResult.Theta_.ValueStr;
            this.view_ = new StepDownKIResultView();
            this.view_.DataContext = this;
        }

        public override UnderylingResultViewModel getUnderlyingResult()
        {
            throw new NotImplementedException();
        }
    }
    
}

