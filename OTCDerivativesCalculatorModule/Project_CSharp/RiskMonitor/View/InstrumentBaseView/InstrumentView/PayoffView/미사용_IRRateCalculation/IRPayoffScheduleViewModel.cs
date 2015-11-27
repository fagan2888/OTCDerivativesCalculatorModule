using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class IRPayoffScheduleViewModel
    {

        public IRPayoffScheduleViewModel()
        { 
        
        }

        #region IRCouponList_
        private ObservableCollection<CouponViewModel> irCouponList_;
        public ObservableCollection<CouponViewModel> IRCouponList_
        {
            get { return this.irCouponList_; }
            set
            {
                if (this.irCouponList_ != value)
                {
                    this.irCouponList_ = value;
                    this.NotifyPropertyChanged("IRCouponList_");
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
    }
}
