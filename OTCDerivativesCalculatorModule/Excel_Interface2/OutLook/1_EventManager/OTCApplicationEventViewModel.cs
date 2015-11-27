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
    public class OTCApplicationEventViewModel : INotifyPropertyChanged
    {
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

        #region View_
        protected Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }

        #endregion

        public static ObservableCollection<EventViewModel> WholeEventViewModel_
            = new ObservableCollection<EventViewModel>();

        public static Dictionary<string, EventViewModel> _eventViewModelMap_
            = new Dictionary<string,EventViewModel>();

        public ObservableCollection<EventViewModel> BindingEventViewModel_
            = new ObservableCollection<EventViewModel>();

        public OTCApplicationEventViewModel()
        {
            OTCApplicationEventView otcEventView = new OTCApplicationEventView();

            otcEventView.DataContext = this;

            otcEventView.ReferenceDate_ = this.loadLastPositionDate();
            //otcEventView.positionXmlReload();

            this.view_ = otcEventView;

            OTCApplicationEventViewModel.loadWholeEvent(this.loadLastPositionDate());

            //this._eventViewModelMap_ = new Dictionary<int, EventViewModel>();

            
            //foreach (var item in OTCApplicationEventViewModel.WholeEventViewModel_)
            //{
                
            //}

        }

        // d : position 기준일
        public static void loadWholeEvent(DateTime d)
        {
            OTCApplicationEventViewModel.WholeEventViewModel_.Clear();
            OTCApplicationEventViewModel._eventViewModelMap_.Clear();

            EVENT_INFO_Table_DAOManager daoManager = new EVENT_INFO_Table_DAOManager();

            //daoManager.KeyColumn_ = d.ToString("yyyyMMdd");

            daoManager.selectAll(DataBaseConnectManager.ConnectionFactory("myDB"));

            foreach (var item in daoManager.DAOList_)
            {
                EventViewModel e_vm = new EventViewModel();

                e_vm.setFromDAO(item);

                OTCApplicationEventViewModel.WholeEventViewModel_.Add(e_vm);
                //OTCApplicationEventViewModel._eventViewModelMap_.Add(
                //    e_vm.Event_date_.ToString(StringFormat.DbDateFormat_), e_vm);

            }
        }

        private DateTime loadLastPositionDate()
        {
            return DateTime.Now;
        }

        public void reloadEventViewModel(SelectedDatesCollection col)
        {
            //EVENT_INFO_Table_DAOManager daoM = new EVENT_INFO_Table_DAOManager();

            //List<string> dateStr = new List<string>();

            //foreach (var item in col)
            //{
            //    dateStr.Add(item.ToString(StringFormat.DbDateFormat_));
            //}


            //daoM.selectEventDateList(DataBaseConnectManager.ConnectionFactory("myDB"),dateStr);

            //foreach (var item in daoM.DAOList_)
            //{
		 
            //} 
            this.BindingEventViewModel_.Clear();

            List<string> containDates = new List<string>();

            foreach (var item in col)
	        {
		         containDates.Add(item.ToString(StringFormat.DbDateFormat_));
	        }

            var result = from eve in OTCApplicationEventViewModel.WholeEventViewModel_
                         where containDates.Contains(eve.Event_date_.ToString(StringFormat.DbDateFormat_))
                         select eve;

            foreach (var item in result)
            {
                this.BindingEventViewModel_.Add((EventViewModel)item);
            }


            //this.BindingEventViewModel_.Add(_eventViewModelMap_[item.ToString(StringFormat.DbDateFormat_)]);
        }
    }
}
