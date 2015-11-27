using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_calendarViewModel
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

        #region Excel_holidayViewModelList_
        private ObservableCollection<Excel_holidayViewModel> excel_holidayViewModelList_;
        public ObservableCollection<Excel_holidayViewModel> Excel_holidayViewModelList_
        {
            get { return this.excel_holidayViewModelList_; }
            set
            {
                if (this.excel_holidayViewModelList_ != value)
                {
                    this.excel_holidayViewModelList_ = value;
                    this.NotifyPropertyChanged("Excel_holidayViewModelList_");
                }
            }
        }
        #endregion

        #region CalendarName_
        private string calendarName_;
        public string CalendarName_
        {
            get { return this.calendarName_; }
            set
            {
                if (this.calendarName_ != value)
                {
                    this.calendarName_ = value;
                    this.NotifyPropertyChanged("CalendarName_");
                }
            }
        }
        #endregion

        public Excel_calendarViewModel(string calendarName)
        {
            this.calendarName_ = calendarName;
            this.excel_holidayViewModelList_ = new ObservableCollection<Excel_holidayViewModel>();
        }

        public void holidayLoadFromDB()
        {

        }

        public void mergeCalendar(Excel_calendarViewModel e_cvm)
        {

        }

        public string description()
        {
            return "test calendar description";
        }
    }
}
