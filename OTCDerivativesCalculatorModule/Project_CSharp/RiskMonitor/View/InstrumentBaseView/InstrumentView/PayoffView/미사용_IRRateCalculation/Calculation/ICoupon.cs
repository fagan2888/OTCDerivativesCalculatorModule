using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class ICoupon 
    {

        #region CouponInfomation

        public int No_ { get; set; }
        public string Type_ { get; set; }
        public DateTime CalculationStartDate_ { get; set; }
        public DateTime CalculationEndDate_ { get; set; }
        public double Fixed_ { get; set; }
        public bool Expired_ { get; set; }
        public string Description_ { get; set; }

        #endregion

        #region ViewModel_
        protected CouponViewModel viewModel_;
        public CouponViewModel ViewModel_
        {
            get
            {
                //this.setVM();

                return this.viewModel_;
            }
            set
            {
                if (this.viewModel_ != value)
                {
                    this.viewModel_ = value;
                }
            }

        }
        #endregion

    }
}
