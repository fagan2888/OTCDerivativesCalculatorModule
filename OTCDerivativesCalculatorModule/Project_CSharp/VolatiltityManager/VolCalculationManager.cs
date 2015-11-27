using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace VolatiltityManager
{
    public class VolCalculationManager
    {
        #region VolCalculaters_
        private List<VolCalculater> volCalculaters_;
        public List<VolCalculater> VolCalculaters_
        {
            get { return this.volCalculaters_; }
            set
            {
                if (this.volCalculaters_ != value)
                {
                    this.volCalculaters_ = value;
                    this.NotifyPropertyChanged("VolCalculaters_");
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
            data.Capacity = volCalculaters_.Count;


        }
    }
}
