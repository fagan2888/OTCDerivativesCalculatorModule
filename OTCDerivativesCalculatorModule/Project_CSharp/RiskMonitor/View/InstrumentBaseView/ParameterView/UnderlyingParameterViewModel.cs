using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class UnderlyingParameterViewModel
    {
        public Underlying Underlying_ { get; set; }

        public UnderlyingParameterViewModel(Underlying under)
        {
            // TODO: Complete member initialization
            this.Underlying_ = under;

            //this.drift_ = item.Drift_;
            //this.dividend_ = item.Dividend_;
            //this.volatility_ = item.Vol_;

            this.drift_ = 0.033;
            this.dividend_ = 0.011;
            this.volatility_ = 0.332;
            this.currentPrice_ = new QuoteInfo(10005);
            this.itemCode_ = new CodeManager(under.KRCode_);
            //this.underlyingType_ = item.groupType_;

        }

        #region Drift_
        private double drift_;
        public double Drift_
        {
            get { return this.drift_; }
            set
            {
                if (this.drift_ != value)
                {
                    this.drift_ = value;
                    this.NotifyPropertyChanged("Drift_");
                }
            }
        }
        #endregion

        #region Dividend_
        private double dividend_;
        public double Dividend_
        {
            get { return this.dividend_; }
            set
            {
                if (this.dividend_ != value)
                {
                    this.dividend_ = value;
                    this.NotifyPropertyChanged("Dividend_");
                }
            }
        }
        #endregion

        #region Volatility_
        private double volatility_;
        public double Volatility_
        {
            get { return this.volatility_; }
            set
            {
                if (this.volatility_ != value)
                {
                    this.volatility_ = value;
                    this.NotifyPropertyChanged("Volatility_");
                }
            }
        }
        #endregion

        #region CurrenctPrice_
        private QuoteInfo currentPrice_;
        public QuoteInfo CurrenctPrice_
        {
            get { return this.currentPrice_; }
            set
            {
                if (this.currentPrice_ != value)
                {
                    this.currentPrice_ = value;
                    this.NotifyPropertyChanged("CurrenctPrice_");
                }
            }
        }
        #endregion

        #region ItemCode_
        private CodeManager itemCode_;
        public CodeManager ItemCode_
        {
            get { return this.itemCode_; }
            set
            {
                if (this.itemCode_ != value)
                {
                    this.itemCode_ = value;
                    this.NotifyPropertyChanged("ItemCode_");
                }
            }
        }
        #endregion

        #region UnderlyingType_
        private string underlyingType_;
        public string UnderlyingType_
        {
            get { return this.underlyingType_; }
            set
            {
                if (this.underlyingType_ != value)
                {
                    this.underlyingType_ = value;
                    this.NotifyPropertyChanged("UnderlyingType_");
                }
            }
        }
        #endregion

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
