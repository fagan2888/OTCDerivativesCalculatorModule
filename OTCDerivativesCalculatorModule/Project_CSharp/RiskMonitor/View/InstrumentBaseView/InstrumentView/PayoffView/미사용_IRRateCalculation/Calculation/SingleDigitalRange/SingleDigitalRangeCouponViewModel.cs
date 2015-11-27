using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class SingleDigitalRangeCouponViewModel : CouponViewModel
    {


        #region RefRateList_
        private ObservableCollection<double> refRateList_;
        public ObservableCollection<double> RefRateList_
        {
            get { return this.refRateList_; }
            set
            {
                if (this.refRateList_ != value)
                {
                    this.refRateList_ = value;
                    this.NotifyPropertyChanged("RefRateList_");
                }
            }
        }
        #endregion

        #region CouponRateList_
        private ObservableCollection<double> couponRateList_;
        public ObservableCollection<double> CouponRateList_
        {
            get { return this.couponRateList_; }
            set
            {
                if (this.couponRateList_ != value)
                {
                    this.couponRateList_ = value;
                    this.NotifyPropertyChanged("CouponRateList_");
                }
            }
        }
        #endregion

        public override void setCouponVM(ICoupon coupon)
        {
            base.setCouponVM(coupon);

            SingleDigitalRangeCoupon sdrc = coupon as SingleDigitalRangeCoupon;
            
            ObservableCollection<double> refRateList = new ObservableCollection<double>();
            ObservableCollection<double> couponRateList = new ObservableCollection<double>();

            for (int i = 0; i < sdrc.RangeCount_; i++)
			{
                refRateList.Add(sdrc.RefRateList_[i]);
                couponRateList.Add(sdrc.CouponRateList_[i]);
			}
                
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

    }
}
