using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;
using RiskMonitor;

namespace CDSCalculatorTest
{
    public class MainWindowViewModel
    {
        //Instrument
        #region ProductName_
        private string productName_;
        public string ProductName_
        {
            get { return this.productName_; }
            set
            {
                if (this.productName_ != value)
                {
                    this.productName_ = value;
                    this.NotifyPropertyChanged("ProductName_");
                }
            }
        }
        #endregion

        #region Notional_
        private double notional_;
        public double Notional_
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

        #region EffectiveDate_
        private DateTime effectiveDate_;
        public DateTime EffectiveDate_
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
        private DateTime maturityDate_;
        public DateTime MaturityDate_
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

        #region ReferenceInfoList_
        private ObservableCollection<ReferenceInfo> referenceInfoList_;
        public ObservableCollection<ReferenceInfo> ReferenceInfoList_
        {
            get { return this.referenceInfoList_; }
            set
            {
                if (this.referenceInfoList_ != value)
                {
                    this.referenceInfoList_ = value;
                    this.NotifyPropertyChanged("ReferenceInfoList_");
                }
            }
        }
        #endregion

        #region CalculationAmount_
        private double calculationAmount_;
        public double CalculationAmount_
        {
            get { return this.calculationAmount_; }
            set
            {
                if (this.calculationAmount_ != value)
                {
                    this.calculationAmount_ = value;
                    this.NotifyPropertyChanged("CalculationAmount_");
                }
            }
        }
        #endregion

        #region Currency
        private string currency_;
        public string Currency
        {
            get { return this.currency_; }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                    this.NotifyPropertyChanged("Currency");
                }
            }
        }
        #endregion

        #region Calendar_
        private string calendar_;
        public string Calendar_
        {
            get { return this.calendar_; }
            set
            {
                if (this.calendar_ != value)
                {
                    this.calendar_ = value;
                    this.NotifyPropertyChanged("Calendar_");
                }
            }
        }
        #endregion

        #region CalculationPeriod_
        private string calculationPeriod_;
        public string CalculationPeriod_
        {
            get { return this.calculationPeriod_; }
            set
            {
                if (this.calculationPeriod_ != value)
                {
                    this.calculationPeriod_ = value;
                    this.NotifyPropertyChanged("CalculationPeriod_");
                }
            }
        }
        #endregion

        #region DayCounter_
        private string dayCounter_;
        public string DayCounter_
        {
            get { return this.dayCounter_; }
            set
            {
                if (this.dayCounter_ != value)
                {
                    this.dayCounter_ = value;
                    this.NotifyPropertyChanged("DayCounter_");
                }
            }
        }
        #endregion

        #region InArrear_
        private bool inArrear_;
        public bool InArrear_
        {
            get { return this.inArrear_; }
            set
            {
                if (this.inArrear_ != value)
                {
                    this.inArrear_ = value;
                    this.NotifyPropertyChanged("InArrear_");
                }
            }
        }
        #endregion

        #region FixedRate_
        private double fixedRate_;
        public double FixedRate_
        {
            get { return this.fixedRate_; }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                    this.NotifyPropertyChanged("FixedRate_");
                }
            }
        }
        #endregion

        //Parameter

        #region PricingType_
        private string pricingType_;
        public string PricingType_
        {
            get { return this.pricingType_; }
            set
            {
                if (this.pricingType_ != value)
                {
                    this.pricingType_ = value;
                    this.NotifyPropertyChanged("PricingType_");
                }
            }
        }
        #endregion

        #region EvaluationTime_
        private DateTime evaluationTime_;
        public DateTime EvaluationTime_
        {
            get { return this.evaluationTime_; }
            set
            {
                if (this.evaluationTime_ != value)
                {
                    this.evaluationTime_ = value;
                    this.NotifyPropertyChanged("EvaluationTime_");
                }
            }
        }
        #endregion

        #region CalculationAmountPara_
        private double calculationAmountPara_;
        public double CalculationAmountPara_
        {
            get { return this.calculationAmountPara_; }
            set
            {
                if (this.calculationAmountPara_ != value)
                {
                    this.calculationAmountPara_ = value;
                    this.NotifyPropertyChanged("CalculationAmountPara_");
                }
            }
        }
        #endregion

        #region CurrencyPara_
        private string currencyPara_;
        public string CurrencyPara_
        {
            get { return this.currencyPara_; }
            set
            {
                if (this.currencyPara_ != value)
                {
                    this.currencyPara_ = value;
                    this.NotifyPropertyChanged("CurrencyPara_");
                }
            }
        }
        #endregion

        #region EntityCurveInfo_
        private EntityCurveInfo entityCurveInfo_;
        public EntityCurveInfo EntityCurveInfo_
        {
            get { return this.entityCurveInfo_; }
            set
            {
                if (this.entityCurveInfo_ != value)
                {
                    this.entityCurveInfo_ = value;
                    this.NotifyPropertyChanged("EntityCurveInfo_");
                }
            }
        }
        #endregion

        #region Correlation_
        private double correlation_;
        public double Correlation_
        {
            get { return this.correlation_; }
            set
            {
                if (this.correlation_ != value)
                {
                    this.correlation_ = value;
                    this.NotifyPropertyChanged("Correlation_");
                }
            }
        }
        #endregion

        #region DiscountCurveInfo_
        private DiscountCurveInfo discountCurveInfo_;
        public DiscountCurveInfo DiscountCurveInfo_
        {
            get { return this.discountCurveInfo_; }
            set
            {
                if (this.discountCurveInfo_ != value)
                {
                    this.discountCurveInfo_ = value;
                    this.NotifyPropertyChanged("DiscountCurveInfo_");
                }
            }
        }
        #endregion

        #region RecoveryRate_
        private double recoveryRate_;
        public double RecoveryRate_
        {
            get { return this.recoveryRate_; }
            set
            {
                if (this.recoveryRate_ != value)
                {
                    this.recoveryRate_ = value;
                    this.NotifyPropertyChanged("RecoveryRate_");
                }
            }
        }
        #endregion


        //result

        #region Price_
        private double price_;
        public double Price_
        {
            get { return this.price_; }
            set
            {
                if (this.price_ != value)
                {
                    this.price_ = value;
                    this.NotifyPropertyChanged("Price_");
                }
            }
        }
        #endregion

        #region CreditCashFlowInfo_
        private CreditCashFlowInfo creditCashFlowInfo_;
        public CreditCashFlowInfo CreditCashFlowInfo_
        {
            get { return this.creditCashFlowInfo_; }
            set
            {
                if (this.creditCashFlowInfo_ != value)
                {
                    this.creditCashFlowInfo_ = value;
                    this.NotifyPropertyChanged("CreditCashFlowInfo_");
                }
            }
        }
        #endregion


        public void load(XmlNode node)
        {
            
            XmlNode headerNode = node.SelectSingleNode("instrument/header");

            XmlNode issueInfoSwapNode = node.SelectSingleNode("instrument/issueInformation/swap");

            XmlNode creditDefaultSwapNode = node.SelectSingleNode("instrument/creditDefaultSwap");

            RiskMonitor.CreditDefaultSwap serial_cds = new RiskMonitor.CreditDefaultSwap(creditDefaultSwapNode);

            this.referenceInfoList_ = new ObservableCollection<ReferenceInfo>();

            foreach (var item in serial_cds.ReferenceInformationList_.ReferenceInformation_)
	        {
                ReferenceInfo referenceInfo = new ReferenceInfo();
                referenceInfo.setReferenceInfo(item);
                this.referenceInfoList_.Add(referenceInfo);
	        }
 

        }


        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
        
    }
}
