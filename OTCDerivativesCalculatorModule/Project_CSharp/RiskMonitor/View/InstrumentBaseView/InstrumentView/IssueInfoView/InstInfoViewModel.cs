using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor.View.InstrumentView.InformationView
{
    public class InstInfoViewModel
    {
        public InstInfoViewModel(string code,
                                string productName,
                                string productType,
                                DateTime tradeDate,
                                DateTime effectiveDate,
                                DateTime maturityDate,
                                long notional,
                                string currency,
                                long premium) 
        {
            this.code_ = code;
            this.productName_ = productName;
            this.productType_ = productType;
            this.tradeDate_ = tradeDate;
            this.effectiveDate_ = effectiveDate;
            this.maturityDate_ = maturityDate;
            this.notional_ = notional;
            this.currency_ = currency;
            this.premium_ = premium;
        }

        #region Code_
        private string code_;
        public string Code_
        {
            get { return this.code_; }
            set
            {
                if (this.code_ != value)
                {
                    this.code_ = value;
                    this.NotifyPropertyChanged("Code_");
                }
            }
        }
        #endregion

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

        #region ProductType_
        private string productType_;
        public string ProductType_
        {
            get { return this.productType_; }
            set
            {
                if (this.productType_ != value)
                {
                    this.productType_ = value;
                    this.NotifyPropertyChanged("ProductType_");
                }
            }
        }
        #endregion

        #region TradeDate_
        private DateTime tradeDate_;
        public DateTime TradeDate_
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

        #region Notional_
        private long notional_;
        public long Notional_
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

        #region Currency_
        private string currency_;
        public string Currency_
        {
            get { return this.currency_; }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                    this.NotifyPropertyChanged("Currency_");
                }
            }
        }
        #endregion

        #region Premium_
        private long premium_;
        public long Premium_
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

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
