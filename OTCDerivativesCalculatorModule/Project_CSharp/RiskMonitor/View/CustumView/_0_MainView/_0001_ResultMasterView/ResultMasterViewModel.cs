using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace RiskMonitor
{
    public class ResultMasterViewModel
    {
        public DateTime ReferenceDate_ { get; set; }
        public ResultMasterLoader Loader_ { get; set; }

        #region InstResultMasterWrapperVMList_
        private ObservableCollection<InstResultMasterWrapperVM> instResultMasterWrapperVMList;
        public ObservableCollection<InstResultMasterWrapperVM> InstResultMasterWrapperVMList_
        {
            get { return this.instResultMasterWrapperVMList; }
            set
            {
                if (this.instResultMasterWrapperVMList != value)
                {
                    this.instResultMasterWrapperVMList = value;
                    this.NotifyPropertyChanged("InstResultMasterWrapperVMList_");
                }
            }
        }
        #endregion

        public ResultMasterViewModel()
        { 
            
        }

        public void loadDBResult(DateTime referenceDate)
        {
            this.loadDBResult(referenceDate.ToString("yyyyMMdd"));
        }

        public void loadDBResult(string referenceDate)
        {
            this.instResultMasterWrapperVMList = new ObservableCollection<InstResultMasterWrapperVM>();

            string positionName = PositionSingletonManger.positionName();

            this.Loader_ = new ResultMasterLoader();
            this.Loader_.PositionHostInfo_ = new PositionHostInfo(positionName);

            List<ResultMasterInfo> resultMasterInfoList = this.Loader_.loadResultData();

            

            foreach (ResultMasterInfo item in resultMasterInfoList)
            {
                InstUriInfo instUri = PositionSingletonManger.CreateInstUriInfo(item.InstCode_, item.InstType_);
                InstrumentBaseViewModel instBaseVM = InstrumentBaseViewModel.CreateInstBaseVM(instUri);

                InstResultMasterWrapperVM viewModel = new InstResultMasterWrapperVM(instBaseVM, item);
                this.instResultMasterWrapperVMList.Add(viewModel);
            }
        }

        //db랑 연결하여 history를 쓰던

        //그냥 가져오던

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
