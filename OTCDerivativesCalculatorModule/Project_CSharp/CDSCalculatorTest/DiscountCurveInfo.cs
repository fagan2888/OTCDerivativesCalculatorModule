using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace CDSCalculatorTest
{
    public class DiscountCurveInfo
    {
        #region Name_
        private string name_;
        public string Name_
        {
            get { return this.name_; }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                    this.NotifyPropertyChanged("Name_");
                }
            }
        }
        #endregion

        #region Tenor1D_
        private double tenor1D_;
        public double Tenor1D_
        {
            get { return this.tenor1D_; }
            set
            {
                if (this.tenor1D_ != value)
                {
                    this.tenor1D_ = value;
                    this.NotifyPropertyChanged("Tenor1D_");
                }
            }
        }
        #endregion

        #region Tenor6M_
        private double tenor6M_;
        public double Tenor6M_
        {
            get { return this.tenor6M_; }
            set
            {
                if (this.tenor6M_ != value)
                {
                    this.tenor6M_ = value;
                    this.NotifyPropertyChanged("Tenor6M_");
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
