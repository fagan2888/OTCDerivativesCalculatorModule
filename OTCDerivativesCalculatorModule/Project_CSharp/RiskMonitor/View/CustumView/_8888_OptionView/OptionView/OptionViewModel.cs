using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace RiskMonitor
{
    public class OptionViewModel
    {
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

        #region FundCode_
        private string fundCode_;
        public string FundCode_
        {
            get { return this.fundCode_; }
            set
            {
                if (this.fundCode_ != value)
                {
                    this.fundCode_ = value;
                    this.NotifyPropertyChanged("FundCode_");
                }
            }
        }
        #endregion

        #region ItemCode_
        private string itemCode_;
        public string ItemCode_
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

        #region ItemName_
        private string itemName_;
        public string ItemName_
        {
            get { return this.itemName_; }
            set
            {
                if (this.itemName_ != value)
                {
                    this.itemName_ = value;
                    this.NotifyPropertyChanged("ItemName_");
                }
            }
        }
        #endregion

        #region Type_
        protected string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion

        #region IssueDate_
        private DateTime issueDate_;
        public DateTime IssueDate_
        {
            get { return this.issueDate_; }
            set
            {
                if (this.issueDate_ != value)
                {
                    this.issueDate_ = value;
                    this.NotifyPropertyChanged("IssueDate_");
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

        #region UnderName_
        private string underName_;
        public string UnderName_
        {
            get { return this.underName_; }
            set
            {
                if (this.underName_ != value)
                {
                    this.underName_ = value;
                    this.NotifyPropertyChanged("UnderName_");
                }
            }
        }
        #endregion

        #region UnderPrice_
        private double underPrice_;
        public double UnderPrice_
        {
            get { return this.underPrice_; }
            set
            {
                if (this.underPrice_ != value)
                {
                    this.underPrice_ = value;
                    this.NotifyPropertyChanged("UnderPrice_");
                }
            }
        }
        #endregion

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

        #region Greek

        #region Delta_
        private double delta_;
        public double Delta_
        {
            get { return this.delta_; }
            set
            {
                if (this.delta_ != value)
                {
                    this.delta_ = value;
                    this.NotifyPropertyChanged("Delta_");
                }
            }
        }
        #endregion

        #region Gamma_
        private double gamma_;
        public double Gamma_
        {
            get { return this.gamma_; }
            set
            {
                if (this.gamma_ != value)
                {
                    this.gamma_ = value;
                    this.NotifyPropertyChanged("Gamma_");
                }
            }
        }
        #endregion

        #region Vega_
        private double vega_;
        public double Vega_
        {
            get { return this.vega_; }
            set
            {
                if (this.vega_ != value)
                {
                    this.vega_ = value;
                    this.NotifyPropertyChanged("Vega_");
                }
            }
        }
        #endregion

        #region Vol_
        private double vol_;
        public double Vol_
        {
            get { return this.vol_; }
            set
            {
                if (this.vol_ != value)
                {
                    this.vol_ = value;
                    this.NotifyPropertyChanged("Vol_");
                }
            }
        }
        #endregion

        #region DividendRate_
        private double dividendRate_;
        public double DividendRate_
        {
            get { return this.dividendRate_; }
            set
            {
                if (this.dividendRate_ != value)
                {
                    this.dividendRate_ = value;
                    this.NotifyPropertyChanged("DividendRate_");
                }
            }
        }
        #endregion

        #region DeltaPosition_
        private double deltaPosition_;
        public double DeltaPosition_
        {
            get { return this.deltaPosition_; }
            set
            {
                if (this.deltaPosition_ != value)
                {
                    this.deltaPosition_ = value;
                    this.NotifyPropertyChanged("DeltaPosition_");
                }
            }
        }
        #endregion

        #region GammaPosition_
        private double gammaPosition_;
        public double GammaPosition_
        {
            get { return this.gammaPosition_; }
            set
            {
                if (this.gammaPosition_ != value)
                {
                    this.gammaPosition_ = value;
                    this.NotifyPropertyChanged("GammaPosition_");
                }
            }
        }
        #endregion

        #region VegaPosition_
        private double vegaPosition_;
        public double VegaPosition_
        {
            get { return this.vegaPosition_; }
            set
            {
                if (this.vegaPosition_ != value)
                {
                    this.vegaPosition_ = value;
                    this.NotifyPropertyChanged("VegaPosition_");
                }
            }
        }
        #endregion

        #region DeltaRisk_
        private double deltaRisk_;
        public double DeltaRisk_
        {
            get { return this.deltaRisk_; }
            set
            {
                if (this.deltaRisk_ != value)
                {
                    this.deltaRisk_ = value;
                    this.NotifyPropertyChanged("DeltaRisk_");
                }
            }
        }
        #endregion

        #region GammaRisk_
        private double gammaRisk_;
        public double GammaRisk_
        {
            get { return this.gammaRisk_; }
            set
            {
                if (this.gammaRisk_ != value)
                {
                    this.gammaRisk_ = value;
                    this.NotifyPropertyChanged("GammaRisk_");
                }
            }
        }
        #endregion

        #region VegaRisk_
        private double vegaRisk_;
        public double VegaRisk_
        {
            get { return this.vegaRisk_; }
            set
            {
                if (this.vegaRisk_ != value)
                {
                    this.vegaRisk_ = value;
                    this.NotifyPropertyChanged("VegaRisk_");
                }
            }
        }
        #endregion

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
