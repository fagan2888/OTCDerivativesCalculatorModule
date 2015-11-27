using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class DeltaHedgeMonitorViewModel
    {
        public DateTime ReferenceDate_ { get; set; }

        //sorting 후 add만 담당함
        public DeltaHedgeMonitorViewModel() 
        {
            this.ReferenceDate_ = DateTime.Now;
        }

        ////Add Type
        //public void setInstrumentBaseVM(ObservableCollection<InstrumentHierarchyViewModel> instHierVMList)
        //{
        //    //greekPositionVMList_ = new ObservableCollection<GreekPositionViewModel>();

        //    //Dictionary<string, GreekPositionViewModel> map = new Dictionary<string, GreekPositionViewModel>();

        //    //foreach (InstrumentHierarchyViewModel item in instHierVMList)
        //    //{
        //    //    List<GreekPositionViewModel> gpvmList = GreekPositionViewModel.CreateUnderGreekPositionVM(item, this.ReferenceDate_);
                
        //    //    foreach (GreekPositionViewModel item2 in gpvmList)
        //    //    {
        //    //        if (map.ContainsKey(item2.ItemCode_))
        //    //        {
        //    //            map[item2.ItemCode_].add(item2);
        //    //        }
        //    //        else 
        //    //        {
        //    //            map[item2.ItemCode_] = item2;
        //    //        }
        //    //    }
        //    //}

        //    //foreach (GreekPositionViewModel item in map.Values)
        //    //{
        //    //    greekPositionVMList_.Add(item);
        //    //}
        //}

        #region GreekPositionVMList_
        private ObservableCollection<GreekPositionViewModel_Backup> greekPositionVMList_;
        public ObservableCollection<GreekPositionViewModel_Backup> GreekPositionVMList_
        {
            get { return this.greekPositionVMList_; }
            set
            {
                if (this.greekPositionVMList_ != value)
                {
                    this.greekPositionVMList_ = value;
                    this.NotifyPropertyChanged("GreekPositionVMList_");
                }
            }
        }
        #endregion

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
