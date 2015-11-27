using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class CouponViewModel : IXmlData
    {
        #region No_
        private int no_;
        public int No_
        {
            get { return this.no_; }
            set
            {
                if (this.no_ != value)
                {
                    this.no_ = value;
                    this.NotifyPropertyChanged("No_");
                }
            }
        }
        #endregion

        #region Type_
        private string type_;
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

        #region CalculationStartDate_
        private DateTime calculationStartDate_;
        public DateTime CalculationStartDate_
        {
            get { return this.calculationStartDate_; }
            set
            {
                if (this.calculationStartDate_ != value)
                {
                    this.calculationStartDate_ = value;
                    this.NotifyPropertyChanged("CalculationStartDate_");
                }
            }
        }
        #endregion

        #region CalculationEndDate_
        private DateTime calculationEndDate_;
        public DateTime CalculationEndDate_
        {
            get { return this.calculationEndDate_; }
            set
            {
                if (this.calculationEndDate_ != value)
                {
                    this.calculationEndDate_ = value;
                    this.NotifyPropertyChanged("CalculationEndDate_");
                }
            }
        }
        #endregion

        #region Fixed_
        private double fixed_;
        public double Fixed_
        {
            get { return this.fixed_; }
            set
            {
                if (this.fixed_ != value)
                {
                    this.fixed_ = value;
                    this.NotifyPropertyChanged("Fixed_");
                }
            }
        }
        #endregion

        #region Expired_
        private bool expired_;
        public bool Expired_
        {
            get { return this.expired_; }
            set
            {
                if (this.expired_ != value)
                {
                    this.expired_ = value;
                    this.NotifyPropertyChanged("Expired_");
                }
            }
        }
        #endregion

        #region Description_
        private string description_;
        public string Description_
        {
            get { return this.description_; }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                    this.NotifyPropertyChanged("Description_");
                }
            }
        }
        #endregion


        public virtual void setCouponVM(ICoupon coupon)
        {
            this.no_ = coupon.No_;
            this.type_ = coupon.Type_;
            this.calculationStartDate_ = coupon.CalculationStartDate_;
            this.calculationEndDate_ = coupon.CalculationEndDate_;
            this.fixed_ = coupon.Fixed_;
            this.expired_ = coupon.Expired_;
            this.description_ = coupon.Description_;

        }


        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion


        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public void setFromXml(System.Xml.XmlNode InstNode)
        {
            throw new NotImplementedException();
        }

        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            throw new NotImplementedException();
        }
    }
}
