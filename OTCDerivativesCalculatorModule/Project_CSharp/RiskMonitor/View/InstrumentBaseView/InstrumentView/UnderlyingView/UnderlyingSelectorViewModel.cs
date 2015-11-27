using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class UnderlyingSelectorViewModel
    {
        public UnderlyingSelectorViewModel() 
        {
            this.availableUnderingList_ = new List<string>();
            this.load();
        }

        public void load() 
        {
            this.availableUnderingList_.Add("SK");
            this.availableUnderingList_.Add("LG");
            this.availableUnderingList_.Add("Hynix");
            this.availableUnderingList_.Add("Hyosung");
            this.availableUnderingList_.Add("Hanwa");
            this.availableUnderingList_.Add("Hyeondae");

        }

        #region AvailableUnderlyingList_
        private List<string> availableUnderingList_;
        public List<string> AvailableUnderlyingList_
        {
            get { return this.availableUnderingList_; }
            set
            {
                if (this.availableUnderingList_ != value)
                {
                    this.availableUnderingList_ = value;
                    this.NotifyPropertyChanged("AvailableUnderlyingList_");
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

    }
}
