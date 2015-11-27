using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ELSHedgeMonitorViewModel
    {

        public ELSHedgeMonitorViewModel() 
        {
            elsDeltaHedgeInstrument_ = new ObservableCollection<ELSStepDownDeltaHedgeViewModel>();
        }

        #region ELSDeltaHedgeInstrument_
        private ObservableCollection<ELSStepDownDeltaHedgeViewModel> elsDeltaHedgeInstrument_;
        public ObservableCollection<ELSStepDownDeltaHedgeViewModel> ELSDeltaHedgeInstrument_
        {
            get { return this.elsDeltaHedgeInstrument_; }
            set
            {
                if (this.elsDeltaHedgeInstrument_ != value)
                {
                    this.elsDeltaHedgeInstrument_ = value;
                    this.NotifyPropertyChanged("ELSDeltaHedgeInstrument_");
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


        public void add(ELSStepDownDeltaHedgeViewModel elsViewModel)
        {
            this.elsDeltaHedgeInstrument_.Add(elsViewModel);
        }
    }

}
