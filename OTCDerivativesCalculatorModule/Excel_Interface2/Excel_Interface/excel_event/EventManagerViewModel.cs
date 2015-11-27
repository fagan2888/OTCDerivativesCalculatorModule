using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class Excel_eventManagerViewModel
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

        #region ItemCode_
        private string itemCode_;
        public string ItemCode_
        {
            get { return this.itemCode_; }
            set
            {
                if (this.itemCode_ != value)
                {
                    this.itemCode_ = value;
                    this.NotifyPropertyChanged("ItemCode_");
                }
            }
        }
        #endregion

        public Excel_eventManagerViewModel()
        {
            //this.view_ = new EventManagerView();
            this.eventVMList_ = new ObservableCollection<EventViewModel>();

            //this.view_.DataContext = this;

        }

        #region EventVMList_
        private ObservableCollection<EventViewModel> eventVMList_;
        public ObservableCollection<EventViewModel> EventVMList_
        {
            get { return this.eventVMList_; }
            set
            {
                if (this.eventVMList_ != value)
                {
                    this.eventVMList_ = value;
                    this.NotifyPropertyChanged("EventVMList_");
                }
            }
        }
        #endregion

        public void addEvent(EventViewModel evm)
        {
            this.eventVMList_.Add(evm);
            this.sortEvent();
        }

        public void deleteEvent()
        {
            foreach (var item in this.eventVMList_)
            {
                item.dbDelete();
            }
        }

        public void updateEvent(EventViewModel evm)
        {
            evm.dbUpdate();
        }

        public static ObservableCollection<EventViewModel> dbLoad(string itemCode)
        {
            ObservableCollection<EventViewModel> eventVMList = new ObservableCollection<EventViewModel>();

            EVENT_INFO_Table_DAOManager daoManager = new EVENT_INFO_Table_DAOManager();

            daoManager.KeyColumn_ = itemCode;

            daoManager.select(DataBaseConnectManager.ConnectionFactory("myDB"));

            foreach (var item in daoManager.DAOList_)
	        {
                EventViewModel evm = new SettlementEventViewModel();

                evm.setFromDAO(item);

                eventVMList.Add(evm);
	        }

            return eventVMList;
            
            
        }

        public void dbLoad()
        {
            this.eventVMList_ = new ObservableCollection<EventViewModel>();

            EVENT_INFO_Table_DAOManager daoManager = new EVENT_INFO_Table_DAOManager();

            daoManager.KeyColumn_ = this.itemCode_;

            daoManager.select(DataBaseConnectManager.ConnectionFactory("myDB"));

            foreach (var item in daoManager.DAOList_)
            {
                EventViewModel evm = new SettlementEventViewModel();

                evm.setFromDAO(item);

                this.eventVMList_.Add(evm);
            }

            //((EventManagerView)this.view_).refereshDataContext();

        }

        private void sortEvent()
        {
            // sort eventList 
        }

        public Control view()
        {
            Control v = new EventManagerView();

            v.DataContext = this;

            return v;
        }
    }
}
