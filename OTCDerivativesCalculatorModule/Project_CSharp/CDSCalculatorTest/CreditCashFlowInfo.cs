using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace CDSCalculatorTest
{
    public class CreditCashFlowInfo
    {
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

        #region PaymentDate_
        private DateTime paymentDate_;
        public DateTime PaymentDate_
        {
            get { return this.paymentDate_; }
            set
            {
                if (this.paymentDate_ != value)
                {
                    this.paymentDate_ = value;
                    this.NotifyPropertyChanged("PaymentDate_");
                }
            }
        }
        #endregion

        #region SurvivalProb_
        private double survivalProb_;
        public double SurvivalProb_
        {
            get { return this.survivalProb_; }
            set
            {
                if (this.survivalProb_ != value)
                {
                    this.survivalProb_ = value;
                    this.NotifyPropertyChanged("SurvivalProb_");
                }
            }
        }
        #endregion

        #region DefaultProb_
        private double defaultProb_;
        public double DefaultProb_
        {
            get { return this.defaultProb_; }
            set
            {
                if (this.defaultProb_ != value)
                {
                    this.defaultProb_ = value;
                    this.NotifyPropertyChanged("DefaultProb_");
                }
            }
        }
        #endregion

        #region CouponLeg_
        private double couponLeg_;
        public double CouponLeg_
        {
            get { return this.couponLeg_; }
            set
            {
                if (this.couponLeg_ != value)
                {
                    this.couponLeg_ = value;
                    this.NotifyPropertyChanged("CouponLeg_");
                }
            }
        }
        #endregion

        #region ProtectedLeg_
        private double protectedLeg_;
        public double ProtectedLeg_
        {
            get { return this.protectedLeg_; }
            set
            {
                if (this.protectedLeg_ != value)
                {
                    this.protectedLeg_ = value;
                    this.NotifyPropertyChanged("ProtectedLeg_");
                }
            }
        }
        #endregion

        #region DicountFactor_
        private double discountFactor_;
        public double DicountFactor_
        {
            get { return this.discountFactor_; }
            set
            {
                if (this.discountFactor_ != value)
                {
                    this.discountFactor_ = value;
                    this.NotifyPropertyChanged("DicountFactor_");
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
