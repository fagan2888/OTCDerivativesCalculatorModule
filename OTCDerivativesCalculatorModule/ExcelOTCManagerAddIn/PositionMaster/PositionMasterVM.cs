using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using RiskMonitor;

namespace ExcelOTCManagerAddIn
{
    public class PositionMasterVM
    {

        #region PositionBookingInfoVMList_
        private ObservableCollection<PositionBookingInfoVM> positionBookingInfoVMList_;
        public ObservableCollection<PositionBookingInfoVM> PositionBookingInfoVMList_
        {
            get { return this.positionBookingInfoVMList_; }
            set
            {
                if (this.positionBookingInfoVMList_ != value)
                {
                    this.positionBookingInfoVMList_ = value;
                    this.NotifyPropertyChanged("PositionBookingInfoVMList_");
                }
            }
        }
        #endregion
        
        public PositionMasterVM()
        { 
        
        }

        public void loadPosition()
        {
            DataBaseManager dbManager = new DataBaseManager();

            this.positionBookingInfoVMList_ = dbManager.loadPositionBookingInfoVM();

        }

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
