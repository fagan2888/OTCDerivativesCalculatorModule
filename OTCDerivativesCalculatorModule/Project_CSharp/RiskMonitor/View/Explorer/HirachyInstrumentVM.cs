using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.IO;
using System.Xml;

namespace RiskMonitor
{
    public abstract class HirachyInstrumentVM : InstrumentWrapperVM
    {
        //#region InstName_
        //protected string instName_;
        //public string InstName_
        //{
        //    get { return this.instName_; }
        //    set
        //    {
        //        if (this.instName_ != value)
        //        {
        //            this.instName_ = value;
        //            this.NotifyPropertyChanged("InstName_");
        //        }
        //    }
        //}
        //#endregion

        #region InstInformation

        //#region ProductName_
        //protected string productName_;
        //public string ProductName_
        //{
        //    get { return this.productName_; }
        //    set
        //    {
        //        if (this.productName_ != value)
        //        {
        //            this.productName_ = value;
        //            this.NotifyPropertyChanged("ProductName_");
        //        }
        //    }
        //}
        //#endregion

        #region ProductType_
        protected string productType_;
        public string ProductType_
        {
            get { return this.productType_; }
            set
            {
                if (this.productType_ != value)
                {
                    this.productType_ = value;
                    this.NotifyPropertyChanged("ProductType_");
                }
            }
        }
        #endregion

        #region ItemCode_
        protected string itemCode_;
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

        #endregion

        public HirachyInstrumentVM(InstrumentBaseViewModel instBaseVM)
        {
            this.InstBaseVM_ = instBaseVM;

            this.InstUri_ = this.InstBaseVM_.InstUri_;
            this.ResultUri_ = this.InstBaseVM_.ResultUri_;
            
            this.ProductType_ = instBaseVM.ItemType_;
            this.itemCode_ = instBaseVM.ItemCode_;
        }

        public ObservableCollection<HirachyInstrumentVM> HirachyInstVMList_ { get; set; }

        public void addHirachInstrumentVM(HirachyInstrumentVM hirachyInstVM)
        {
            HirachyInstVMList_.Add(hirachyInstVM);
        }

        protected bool chileInstrumentFlag_;

        //public abstract void calculate();
        //public abstract void buildParameter();
        //public abstract void loadParaResult();

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
