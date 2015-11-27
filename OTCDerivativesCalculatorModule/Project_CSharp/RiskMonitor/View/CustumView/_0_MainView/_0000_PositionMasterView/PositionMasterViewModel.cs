using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Xml;
using System.IO;

namespace RiskMonitor
{
    // 여기서 path info 를 관장함.
    public class PositionMasterViewModel
    {
        public DateTime ReferenceDate_ { get; set; }
        public DataBaseManager Loader_ { get; set; }

        #region InstPositionWrapperVMList_
        private ObservableCollection<InstPositionWrapperVM> instPositionWrapperVMList_;
        public ObservableCollection<InstPositionWrapperVM> InstPositionWrapperVMList_
        {
            get { return this.instPositionWrapperVMList_; }
            set
            {
                if (this.instPositionWrapperVMList_ != value)
                {
                    this.instPositionWrapperVMList_ = value;
                    this.NotifyPropertyChanged("InstPositionWrapperVMList_");
                }
            }
        }
        #endregion

        public PositionMasterViewModel()
        {
            this.Loader_ = new DataBaseManager();

        }

        public void loadDBPosition(string position)
        {
            this.instPositionWrapperVMList_ = new ObservableCollection<InstPositionWrapperVM>();

            RiskMonitor.PositionSingletonManger.setReferenceDate(this.ReferenceDate_);

            //db 만들어서 관리 해야함?  ㅇㅇ 그래야함 ㅡ.ㅡㅋ
            instPositionWrapperVMList_.Clear();

            DataBaseManager loader = new DataBaseManager();
            loader.PositionHostInfo_ = new PositionHostInfo(position);

            List<InstPositionInfo> instDataList = loader.loadPositionData();

            foreach (InstPositionInfo item in instDataList)
            {
                InstUriInfo instUri = PositionSingletonManger.CreateInstUriInfo(item.InstCode_, item.InstType_);
                //ResultUriInfo resultUri = CreateResultUriInfo(item.InstCode_, item.InstType_);
                //InstrumentBaseViewModel instBaseVM = InstrumentBaseViewModel.CreateInstBaseVM(instUri, resultUri);
                InstrumentBaseViewModel instBaseVM = InstrumentBaseViewModel.CreateInstBaseVM(instUri);
                instBaseVM.ReferenceDate_ = PositionSingletonManger.referenceDate();

                InstPositionWrapperVM viewModel = new InstPositionWrapperVM(item, instBaseVM);
                instPositionWrapperVMList_.Add(viewModel);
            }

        }

        public bool addInstrument(InstrumentBaseViewModel instBaseVM)
        {

            if (!Loader_.hasInstDB(instBaseVM.ItemCode_))
            {
                InstPositionWrapperVM wrapperVM = new InstPositionWrapperVM(instBaseVM);
                this.instPositionWrapperVMList_.Add(wrapperVM);

                // 중복 체크
                Loader_.addInstDB(wrapperVM);
                return true;
            }
            else 
            {
                return false;
            }
            
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
