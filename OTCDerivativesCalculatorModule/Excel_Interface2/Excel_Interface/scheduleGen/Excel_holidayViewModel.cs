using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_holidayViewModel
    {
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

        #region HoliDate_
        private DateTime holiDate_;
        public DateTime HoliDate_
        {
            get { return this.holiDate_; }
            set
            {
                if (this.holiDate_ != value)
                {
                    this.holiDate_ = value;
                    this.NotifyPropertyChanged("HoliDate_");
                }
            }
        }
        #endregion

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

        #region StartDate_
        private DateTime startDate_;
        public DateTime StartDate_
        {
            get { return this.startDate_; }
            set
            {
                if (this.startDate_ != value)
                {
                    this.startDate_ = value;
                    this.NotifyPropertyChanged("StartDate_");
                }
            }
        }
        #endregion

        #region EndDate_
        private DateTime endDate_;
        public DateTime EndDate_
        {
            get { return this.endDate_; }
            set
            {
                if (this.endDate_ != value)
                {
                    this.endDate_ = value;
                    this.NotifyPropertyChanged("EndDate_");
                }
            }
        }
        #endregion

        public Excel_holidayViewModel()
        { 
        
        }


    }
}
