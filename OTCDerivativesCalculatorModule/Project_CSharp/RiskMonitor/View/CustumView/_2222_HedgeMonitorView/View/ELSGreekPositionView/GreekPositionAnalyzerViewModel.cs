using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using QLNet;

namespace RiskMonitor
{
    public class GreekPositionAnalyzerViewModel
    {

        public GreekPositionAnalyzerViewModel() 
        {
            this.GreekWrapperVMList_ = new ObservableCollection<GreekUnderlyingResultWrapperViewModel>();
        }

        #region UnderlyingViewModelList_
        private ObservableCollection<GreekUnderlyingResultWrapperViewModel> greekWrapperVMList_;
        public ObservableCollection<GreekUnderlyingResultWrapperViewModel> GreekWrapperVMList_
        {
            get { return this.greekWrapperVMList_; }
            set
            {
                if (this.greekWrapperVMList_ != value)
                {
                    this.greekWrapperVMList_ = value;
                    this.NotifyPropertyChanged("UnderlyingViewModelList_");
                }
            }
        }
        #endregion

        #region UnderlyingPickerViewModel_ 
		private UnderlyingPickerViewModel underlyingPickerViewModel_;
		public UnderlyingPickerViewModel UnderlyingPickerViewModel_ 
		{ 
			get { return this.underlyingPickerViewModel_; }
			set
			{
			if (this.underlyingPickerViewModel_ != value)
			{
				this.underlyingPickerViewModel_ = value;
				this.NotifyPropertyChanged("UnderlyingPickerViewModel_");
			}
			}
		}
		#endregion

        public void analyzePosition(List<InstPositionWrapperVM> positionList)
        {
            this.greekWrapperVMList_ = new ObservableCollection<GreekUnderlyingResultWrapperViewModel>();

            foreach (var item in positionList)
            {
                this.addUnderFromPosition(item);
            }
        }

        private void addUnderFromPosition(InstPositionWrapperVM instPositionWrapperVM)
        {
            StandardInstBaseViewModel stand = instPositionWrapperVM.InstBaseVM_ as StandardInstBaseViewModel;

            UnderlyingViewModel underlyingVM = stand.InstrumentViewModel_.getUnderlying();

            // inst에서 하던under 로 하던 나중에 결정하자으 

            bool pickFlag = this.underlyingPickerViewModel_.pickUnderlying(underlyingVM);

            if (pickFlag)
            {
                GreekUnderlyingResultWrapperViewModel greekWrapperVM = new GreekUnderlyingResultWrapperViewModel(underlyingVM);
                this.greekWrapperVMList_.Add(greekWrapperVM);
            }
            

        }

        //public static List<UnderViewModel> underVMList()
        //{
        //    List<UnderViewModel> result = new List<UnderViewModel>();



        //    return result;
        //}

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
