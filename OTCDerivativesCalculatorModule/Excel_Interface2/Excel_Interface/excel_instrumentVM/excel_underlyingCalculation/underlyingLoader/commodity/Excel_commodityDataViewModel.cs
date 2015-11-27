using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_commodityDataViewModel
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

        #region Commodity_code_
        private string commodity_code_;
        public string Commodity_code_
        {
            get { return this.commodity_code_; }
            set
            {
                if (this.commodity_code_ != value)
                {
                    this.commodity_code_ = value;
                    this.NotifyPropertyChanged("Commodity_code_");
                }
            }
        }
        #endregion

        #region Commodity_value_
        private string commodity_value_;
        public string Commodity_value_
        {
            get { return this.commodity_value_; }
            set
            {
                if (this.commodity_value_ != value)
                {
                    this.commodity_value_ = value;
                    this.NotifyPropertyChanged("Commodity_value_");
                }
            }
        }
        #endregion

        public Excel_commodityDataViewModel()
        {
        }

    }
}
