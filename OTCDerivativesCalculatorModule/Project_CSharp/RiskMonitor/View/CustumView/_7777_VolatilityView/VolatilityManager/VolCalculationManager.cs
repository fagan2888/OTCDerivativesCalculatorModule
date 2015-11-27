using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class VolCalculationManager
    {
        #region VolCalculaters_
        private List<VolCalculator> volCalculators_;
        public List<VolCalculator> VolCalculators_
        {
            get { return this.volCalculators_; }
            set
            {
                if (this.volCalculators_ != value)
                {
                    this.volCalculators_ = value;
                    this.NotifyPropertyChanged("VolCalculators_");
                }
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        internal void calculateVol(List<List<double>> data)
        {
            data.Capacity = volCalculators_.Count;


        }
    }
}
