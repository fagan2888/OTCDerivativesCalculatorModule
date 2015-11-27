using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_indexDataViewModel
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

        #region Index_code_
        private string index_code_;
        public string Index_code_
        {
            get { return this.index_code_; }
            set
            {
                if (this.index_code_ != value)
                {
                    this.index_code_ = value;
                    this.NotifyPropertyChanged("Index_code_");
                }
            }
        }
        #endregion

        #region Index_value_
        private string index_value_;
        public string Index_value_
        {
            get { return this.index_value_; }
            set
            {
                if (this.index_value_ != value)
                {
                    this.index_value_ = value;
                    this.NotifyPropertyChanged("Index_value_");
                }
            }
        }
        #endregion

        public Excel_indexDataViewModel()
        {
        }

    }
}
