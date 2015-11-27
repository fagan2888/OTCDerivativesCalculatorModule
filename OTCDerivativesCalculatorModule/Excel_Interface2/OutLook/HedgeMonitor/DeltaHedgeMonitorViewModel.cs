using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class DeltaHedgeMonitorViewModel
    {
        //#region View_
        //protected Control view_;
        //public Control View_
        //{
        //    get { return this.view_; }
        //    set
        //    {
        //        if (this.view_ != value)
        //        {
        //            this.view_ = value;
        //            this.NotifyPropertyChanged("View_");
        //        }
        //    }
        //}
        //#endregion

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

        public DeltaHedgeMonitorViewModel()
        {
            this.hedgeUnderlyingGreekPositionViewModelList_ 
                = new ObservableCollection<HedgeUnderlyingGreekPositionViewModel>();

            //this.view_ = new DeltaHedgeMonitorView();
            //this.view_.DataContext = this;

        }

        #region HedgeUnderlyingGreekPositionViewModelList_
        private ObservableCollection<HedgeUnderlyingGreekPositionViewModel> hedgeUnderlyingGreekPositionViewModelList_;
        public ObservableCollection<HedgeUnderlyingGreekPositionViewModel> HedgeUnderlyingGreekPositionViewModelList_
        {
            get { return this.hedgeUnderlyingGreekPositionViewModelList_; }
            set
            {
                if (this.hedgeUnderlyingGreekPositionViewModelList_ != value)
                {
                    this.hedgeUnderlyingGreekPositionViewModelList_ = value;
                    this.NotifyPropertyChanged("HedgeUnderlyingGreekPositionViewModelList_");
                }
            }
        }
        #endregion

        #region UnderlyingList_
        private List<string> underlyingList_;
        public List<string> UnderlyingList_
        {
            get { return this.underlyingList_; }
            set
            {
                if (this.underlyingList_ != value)
                {
                    this.underlyingList_ = value;
                    this.NotifyPropertyChanged("UnderlyingList_");
                }
            }
        }
        #endregion

        //public void setInstrumentList(ObservableCollection<Excel_instrumentViewModel> instList)
        //{
        //    // 로딩을 죄다 해야함.

        //    foreach (Excel_instrumentViewModel item in instList)
        //    {
        //        item.loadParameterFromXml();
        //    }

        //    // 기초자산을 추출해서 HedgeUnderlyingGreekPositionViewModel 를 만듬

        //    // 기초자산을 빼서 리스트를 만들어

        //    this.underlyingList_ = new List<string>();

        //    foreach (Excel_instrumentViewModel item in instList)
        //    {
        //        foreach (GreekPositionViewModel greekP in item.greekPosition())
        //        {
        //            if (!this.underlyingList_.Contains(greekP.Name_))
        //            {
        //                this.underlyingList_.Add(greekP.Name_);

        //                HedgeUnderlyingGreekPositionViewModel hugpvm
        //                    = new HedgeUnderlyingGreekPositionViewModel(greekP.Name_);

        //                hugpvm.addGreekPosition(greekP);

        //                this.hedgeUnderlyingGreekPositionViewModelList_.Add(hugpvm);
        //            }
        //            else 
        //            {
        //                foreach (HedgeUnderlyingGreekPositionViewModel hedgeUnderItem in this.hedgeUnderlyingGreekPositionViewModelList_)
        //                {
        //                    if (hedgeUnderItem.UnderlyingName_ == greekP.Name_)
        //                    {
        //                        hedgeUnderItem.addGreekPosition(greekP);
        //                    }
        //                }
        //            }

        //        }

        //    }

        //    // InstUnderlyingStockGreekPositionViewModel 을 만들어서 각각에 박음

        //}

        public Control view()
        {
            Control v = new DeltaHedgeMonitorView();

            v.DataContext = this;

            return v;
        }
    }
}
