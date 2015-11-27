using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using QLNet;

namespace ExcelAddInRibbonTest
{
    public class GBMParaViewModel : INotifyPropertyChanged
    {
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

        #region ReferenceDate_
        private DateTime referenceDate_;
        public DateTime ReferenceDate_
        {
            get { return this.referenceDate_; }
            set
            {
                if (this.referenceDate_ != value)
                {
                    this.referenceDate_ = value;
                    this.NotifyPropertyChanged("ReferenceDate_");
                }
            }
        }
        #endregion

        #region CurrentPrice_
        private double currentPrice_;
        public double CurrentPrice_
        {
            get { return this.currentPrice_; }
            set
            {
                if (this.currentPrice_ != value)
                {
                    this.currentPrice_ = value;
                    this.NotifyPropertyChanged("CurrentPrice_");
                }
            }
        }
        #endregion

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

        public Interpolation Call_Interpolation_ { get; set; }
        public Interpolation Put_Interpolation_ { get; set; }
    }
}
