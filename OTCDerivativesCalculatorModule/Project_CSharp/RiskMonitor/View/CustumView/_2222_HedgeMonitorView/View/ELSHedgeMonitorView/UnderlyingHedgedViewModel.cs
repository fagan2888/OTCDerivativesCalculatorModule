using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using QLNet;

namespace RiskMonitor
{
    public class UnderlyingHedgedViewModel
    {
        private ELSUnderlyingStock hedgeStock;

        public UnderlyingHedgedViewModel(ELSUnderlyingStock hedgeStock)
        {
            // TODO: Complete member initialization
            this.hedgeStock = hedgeStock;

            this.name_ = hedgeStock.Name_;
            this.basePrice_ = hedgeStock.BasePrice_;
            this.currentPrice_ = hedgeStock.BasePrice_;
            this.assetParity_ = this.basePrice_ / this.currentPrice_;

        }

        #region Name_
        private string name_;
        public string Name_
        {
            get { return this.name_; }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                    this.NotifyPropertyChanged("Name_");
                }
            }
        }
        #endregion

        #region BasePrice_
        private double basePrice_;
        public double BasePrice_
        {
            get { return this.basePrice_; }
            set
            {
                if (this.basePrice_ != value)
                {
                    this.basePrice_ = value;
                    this.NotifyPropertyChanged("BasePrice_");
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
                    this.reCalculation();
                    this.NotifyPropertyChanged("CurrentPrice_");
                }
            }
        }
        #endregion

        #region TriggerPosition_
        private long triggerPosition_;
        public long TriggerPosition_
        {
            get { return this.triggerPosition_; }
            set
            {
                if (this.triggerPosition_ != value)
                {
                    this.triggerPosition_ = value;
                    this.NotifyPropertyChanged("TriggerPosition_");
                }
            }
        }
        #endregion

        #region AssetParity_
        private double assetParity_;
        public double AssetParity_
        {
            get { return this.assetParity_; }
            set
            {
                if (this.assetParity_ != value)
                {
                    this.assetParity_ = value;
                    this.NotifyPropertyChanged("AssetParity_");
                }
            }
        }
        #endregion

        #region Trigger_
        private double trigger_;
        public double Trigger_
        {
            get { return this.trigger_; }
            set
            {
                if (this.trigger_ != value)
                {
                    this.trigger_ = value;
                    this.NotifyPropertyChanged("Trigger_");
                }
            }
        }
        #endregion

        #region TriggerGap_
        private double triggerGap_;
        public double TriggerGap_
        {
            get { return this.triggerGap_; }
            set
            {
                if (this.triggerGap_ != value)
                {
                    this.triggerGap_ = value;
                    this.NotifyPropertyChanged("TriggerGap_");
                }
            }
        }
        #endregion

        #region ETCString_
        private string etcString_;
        public string ETCString_
        {
            get { return this.etcString_; }
            set
            {
                if (this.etcString_ != value)
                {
                    this.etcString_ = value;
                    this.NotifyPropertyChanged("ETCString_");
                }
            }
        }
        #endregion

        void reCalculation() 
        {
            this.assetParity_ = this.basePrice_ / this.currentPrice_;
            this.triggerGap_ = this.assetParity_ - this.trigger_;
        }

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
