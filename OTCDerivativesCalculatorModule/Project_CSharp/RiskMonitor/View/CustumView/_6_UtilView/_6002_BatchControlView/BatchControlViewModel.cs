using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.IO;

namespace RiskMonitor
{
    public class BatchControlViewModel
    {
        private BookInfoViewModel bookInfoVM_ { get; set; }

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

        #region PathURLInfo_
        private string pathURLInfo_;
        public string PathURLInfo_
        {
            get { return this.pathURLInfo_; }
            set
            {
                if (this.pathURLInfo_ != value)
                {
                    this.pathURLInfo_ = value;
                    this.NotifyPropertyChanged("PathURLInfo_");
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

        public BatchControlViewModel(BookInfoViewModel bookInfoVM) 
        {
            this.bookInfoVM_ = bookInfoVM_;
            this.loadBookInfo();
            
            //this.ReferenceDate_ = DateTime.Now;
        }

        public BatchControlViewModel()
        {
            this.loadPosition();
            //this.ReferenceDate_ = DateTime.Now;
        }

        private void loadPosition()
        {
            //this.batchInstVMWrapperList_ = new ObservableCollection<BatchInstrumentVMWrapper>();

            //ObservableCollection<InstrumentWrapperVM> instList = PositionSigletonManger.instrumentList();

            //PositionMasterViewModel positionMasterVM = PositionSigletonManger.positionMasterVM();

            //foreach (InstrumentWrapperVM item in instList)
            //{

            //    //InstUriInfo instUri = positionMasterVM.CreateInstUriInfo(item);
            //    //ResultUriInfo resultUri = positionMasterVM.CreateResultUriInfo(item);

            //    BatchInstrumentVMWrapper batchInstVMWrapper = new BatchInstrumentVMWrapper(item.InstBaseVM_);

            //    this.batchInstVMWrapperList_.Add(batchInstVMWrapper);
            //}

        }

        private void loadBookInfo()
        {
            this.batchInstVMWrapperList_ = new ObservableCollection<BatchInstrumentVMWrapper>();

            FpmlSerializedCSharp.BookInformation serial_bookInfo = new FpmlSerializedCSharp.BookInformation(this.bookInfoVM_.BookInfoXml_);

            this.PathURLInfo_ = this.bookInfoVM_.PathURLInfo_;

            //serial_bookInfo.PathInfo_.Url_.ValueStr;

            DirectoryInfo directoryInfo = new DirectoryInfo(this.PathURLInfo_);

            foreach (var item in serial_bookInfo.InstrumentList_.InstHirachyInfo_)
            {
                string itemCode = item.Code_.ValueStr;
                string itemType = item.Type_.ValueStr;

                InstUriInfo instUri = bookInfoVM_.InstUri(item);
                //ResultUriInfo resultUri = bookInfoVM_.resultUri(item);

                FileInfo fileInfo = new FileInfo(directoryInfo.FullName + itemCode + "_" + itemType + ".xml");

                InstrumentBaseViewModel instBaseVM = InstrumentBaseViewModel.CreateInstBaseVM(instUri);

                //ExploreHirachyInstrumentVMWrapper hirachyInstVMWrapper
                //    = new ExploreHirachyInstrumentVMWrapper(itemCode, itemType, instBaseVM);

                BatchInstrumentVMWrapper batchInstVMWrapper = new BatchInstrumentVMWrapper(instBaseVM);

                batchInstVMWrapper.setFromSerial(item);

                this.batchInstVMWrapperList_.Add(batchInstVMWrapper);
            }
        }

        //public ParameterSettingViewModel ParaSettingViewModel_ { get; set; }

        public void loadParaResult()
        {
            foreach (var item in batchInstVMWrapperList_)
            {
                item.ReferenceDate_ = this.referenceDate_;
                //item.loadParaResult();
            }
        }

        public void calculate()
        {
            foreach (var item in batchInstVMWrapperList_)
            {
                item.ReferenceDate_ = this.referenceDate_;
                //item.calculate();
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
