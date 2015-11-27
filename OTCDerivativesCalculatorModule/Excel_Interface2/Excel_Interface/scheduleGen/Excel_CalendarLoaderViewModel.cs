using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using QLNet;

namespace Excel_Interface
{
    public class Excel_calendarLoaderViewModel
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

        #region SelectedCalendarViewModelList_
        private ObservableCollection<Excel_calendarViewModel> selectedCalendarViewModelList_;
        public ObservableCollection<Excel_calendarViewModel> SelectedCalendarViewModelList_
        {
            get { return this.selectedCalendarViewModelList_; }
            set
            {
                if (this.selectedCalendarViewModelList_ != value)
                {
                    this.selectedCalendarViewModelList_ = value;
                    this.NotifyPropertyChanged("SelectedCalendarViewModelList_");
                }
            }
        }
        #endregion

        #region Excel_calendarViewModelList_
        private ObservableCollection<Excel_calendarViewModel> excel_calendarViewModelList_;
        public ObservableCollection<Excel_calendarViewModel> Excel_calendarViewModelList_
        {
            get { return this.excel_calendarViewModelList_; }
            set
            {
                if (this.excel_calendarViewModelList_ != value)
                {
                    this.excel_calendarViewModelList_ = value;
                    this.NotifyPropertyChanged("Excel_calendarViewModelList_");
                }
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

        public Excel_calendarLoaderViewModel()
        {
            this.excel_calendarViewModelList_ = new ObservableCollection<Excel_calendarViewModel>();
            this.selectedCalendarViewModelList_ = new ObservableCollection<Excel_calendarViewModel>();
            this.excel_holidayViewModelList_ = new ObservableCollection<Excel_holidayViewModel>();

        }

        public bool holidays(DateTime date)
        {
            return false;
        }

        public void loadCalendarList()
        {
            this.excel_calendarViewModelList_.Clear();

            Excel_calendarViewModel e_cvmKOR = new Excel_calendarViewModel("KRW");

            this.excel_calendarViewModelList_.Add(e_cvmKOR);

        }


        public Excel_calendarViewModel getCalendar()
        {
            Excel_calendarViewModel e_cvm = new Excel_calendarViewModel("test aggregation custom");

            foreach (var item in this.selectedCalendarViewModelList_)
            {
                e_cvm.mergeCalendar(item);
            }

            return e_cvm;
        }

        public Control view()
        {
            Control v = new Excel_calendarLoaderView();
            v.DataContext = this;
            return v;
        }



    }
}
