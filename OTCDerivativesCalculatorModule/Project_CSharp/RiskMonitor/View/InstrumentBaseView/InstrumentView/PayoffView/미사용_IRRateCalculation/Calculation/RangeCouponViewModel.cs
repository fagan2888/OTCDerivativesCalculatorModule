using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class RangeCouponViewModel : CouponViewModel
    {
        #region Payoff

        public double Gearing_ { get; set; }
        public double Spread_ { get; set; }

        public double Rate_ { get; set; }
        public double FixedRate_ { get; set; }

        public AccuralInfo AccuralInfo_ { get; set; }

        #endregion

        #region RangeInfoVMList_
        protected ObservableCollection<RangeInfoViewModel> rangeInfoVMList_;
        public ObservableCollection<RangeInfoViewModel> RangeInfoVMList_
        {
            get { return this.rangeInfoVMList_; }
            set
            {
                if (this.rangeInfoVMList_ != value)
                {
                    this.rangeInfoVMList_ = value;
                    this.NotifyPropertyChanged("RangeInfoVMList_");
                }
            }
        }

        #endregion

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

        public override void setCouponVM(ICoupon coupon)
        {
            throw new NotImplementedException();
        }
    }
}
