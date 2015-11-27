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
    public class ReferenceInfo
    {
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

        #region ID_
        private string id_;
        public string ID_
        {
            get { return this.id_; }
            set
            {
                if (this.id_ != value)
                {
                    this.id_ = value;
                    this.NotifyPropertyChanged("ID_");
                }
            }
        }
        #endregion

        #region Bond_ID_
        private string bondID_;
        public string Bond_ID_
        {
            get { return this.bondID_; }
            set
            {
                if (this.bondID_ != value)
                {
                    this.bondID_ = value;
                    this.NotifyPropertyChanged("Bond_ID_");
                }
            }
        }
        #endregion

        #region Coupon_
        private double coupon_;
        public double Coupon_
        {
            get { return this.coupon_; }
            set
            {
                if (this.coupon_ != value)
                {
                    this.coupon_ = value;
                    this.NotifyPropertyChanged("Coupon_");
                }
            }
        }
        #endregion

        #region Maturity_
        private DateTime maturiry_;
        public DateTime Maturity_
        {
            get { return this.maturiry_; }
            set
            {
                if (this.maturiry_ != value)
                {
                    this.maturiry_ = value;
                    this.NotifyPropertyChanged("Maturity_");
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


        public void setReferenceInfo(ReferenceInformation item)
        {
            this.name_ = item.ReferenceEntity_.EntityName_.ValueStr;
            this.id_ = item.ReferenceEntity_.EntityId_.ValueStr;
            this.bondID_ = item.ReferenceObligation_.Bond_.InstrumentId_.ValueStr;
            this.coupon_ = item.ReferenceObligation_.Bond_.CouponRate_.DoubleValue();
            this.maturiry_ = item.ReferenceObligation_.Bond_.Maturity_.DateTimeValue();
        }
    }

}
