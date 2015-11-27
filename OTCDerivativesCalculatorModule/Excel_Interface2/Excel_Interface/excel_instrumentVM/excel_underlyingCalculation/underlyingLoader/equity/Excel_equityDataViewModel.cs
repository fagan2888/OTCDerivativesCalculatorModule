using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_equityDataViewModel
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                if (propertyName == "")
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
                else
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
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

        #region Equity_code_
        private string equity_code_;
        public string Equity_code_
        {
            get { return this.equity_code_; }
            set
            {
                if (this.equity_code_ != value)
                {
                    this.equity_code_ = value;
                    this.NotifyPropertyChanged("Equity_code_");
                }
            }
        }
        #endregion

        #region Equity_value_
        private string equity_value_;
        public string Equity_value_
        {
            get { return this.equity_value_; }
            set
            {
                if (this.equity_value_ != value)
                {
                    this.equity_value_ = value;
                    this.NotifyPropertyChanged("Equity_value_");
                }
            }
        }
        #endregion

        public Excel_equityDataViewModel()
        {
        }

    }
}
