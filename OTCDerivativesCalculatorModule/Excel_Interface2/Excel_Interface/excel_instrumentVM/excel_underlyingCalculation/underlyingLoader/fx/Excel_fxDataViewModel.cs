using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_fxDataViewModel
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

        #region Fx_code_
        private string fx_code_;
        public string Fx_code_
        {
            get { return this.fx_code_; }
            set
            {
                if (this.fx_code_ != value)
                {
                    this.fx_code_ = value;
                    this.NotifyPropertyChanged("Fx_code_");
                }
            }
        }
        #endregion

        #region Fx_value_
        private string fx_value_;
        public string Fx_value_
        {
            get { return this.fx_value_; }
            set
            {
                if (this.fx_value_ != value)
                {
                    this.fx_value_ = value;
                    this.NotifyPropertyChanged("Fx_value_");
                }
            }
        }
        #endregion

        public Excel_fxDataViewModel()
        {
        }

    }
}
