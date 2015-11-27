using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.IO;

namespace RiskMonitor
{
    public class BatchManagerViewModel
    {
        #region ReferenceDate_
        private DateTime referenceDate_;
        public DateTime ReferenceDate_
        {
            get { return this.referenceDate_; }
            set
            {
                if (this.referenceDate_ != value)
                {
                    this.referenceDate_ = value;
                    this.NotifyPropertyChanged("ReferenceDate_");
                }
            }
        }
        #endregion

        #region BatchInstVMWrapperList_
        private ObservableCollection<BatchInstrumentVMWrapper> batchInstVMWrapperList_;
        public ObservableCollection<BatchInstrumentVMWrapper> BatchInstVMWrapperList_
        {
            get { return this.batchInstVMWrapperList_; }
            set
            {
                if (this.batchInstVMWrapperList_ != value)
                {
                    this.batchInstVMWrapperList_ = value;
                    this.NotifyPropertyChanged("BatchInstVMWrapperList_");
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

        public BatchManagerViewModel()
        {
            this.ReferenceDate_ = PositionSingletonManger.positionMasterVM().ReferenceDate_;
            this.initialize();
        }

        public void initialize()
        {
            this.batchInstVMWrapperList_ = new ObservableCollection<BatchInstrumentVMWrapper>();

            ResultSingletonMaster.resultMasterVM().loadDBResult(this.ReferenceDate_);

            foreach (var item in ResultSingletonMaster.resultMasterVM().InstResultMasterWrapperVMList_)
	        {
                BatchInstrumentVMWrapper batchWrapper = new BatchInstrumentVMWrapper(item);
                this.batchInstVMWrapperList_.Add(batchWrapper);
	        }
        }
    }
}
