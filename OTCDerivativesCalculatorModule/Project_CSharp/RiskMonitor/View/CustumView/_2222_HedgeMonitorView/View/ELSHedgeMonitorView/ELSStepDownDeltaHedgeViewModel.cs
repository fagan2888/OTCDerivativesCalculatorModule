using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using QLNet;

namespace RiskMonitor
{
    public class ELSStepDownDeltaHedgeViewModel
    {

        public ELSStepDownDeltaHedgeViewModel()
        {
            ////this.name_ = inst.ProductName_;
            ////this.type_ = inst.ProductType_;
            ////this.notional_ = inst.Notional_;

            //DateTime calDate = QLNet.Settings.evaluationDate();

            //for (int i = 0; i < inst.autoCallDates_.Count; i++)
            //{
            //    if(calDate < inst.autoCallDates_[i])
            //    {
            //        this.closeAutoCallDate_ = inst.autoCallDates_[i];
            //        this.autoCallreturn_ = inst.autoCallReturn_[i];
            //        this.closeAutoCallTrigger_ = inst.autoCallTrigger_[i];
            //        break;
            //    }
            //}

            //// assetParity 계산

            //this.remainDateToAutoCall_ = (this.closeAutoCallDate_ - calDate).Days;

            //this.underlyingVM_ = new ObservableCollection<UnderlyingHedgedViewModel>();

            //foreach (Underlying item in inst.Underlying_)
            //{
            //    ELSUnderlyingStock under = item as ELSUnderlyingStock;

            //    UnderlyingHedgedViewModel underVM = new UnderlyingHedgedViewModel(under);
            //    underVM.Trigger_ = this.closeAutoCallTrigger_;

            //    this.underlyingVM_.Add(underVM);
            //}
        }


        #region Main_ELS_Information
        
        #region Name_
        private string name_;
        public string Name_
        {
            get { return this.name_; }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                    this.NotifyPropertyChanged("Name_");
                }
            }
        }
        #endregion

        #region Type_
        protected string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion

        #region Notional_
        private long notional_;
        public long Notional_
        {
            get { return this.notional_; }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                    this.NotifyPropertyChanged("Notional_");
                }
            }
        }
        #endregion

        #region CloseAutoCallDate_
        private DateTime closeAutoCallDate_;
        public DateTime CloseAutoCallDate_
        {
            get { return this.closeAutoCallDate_; }
            set
            {
                if (this.closeAutoCallDate_ != value)
                {
                    this.closeAutoCallDate_ = value;
                    this.NotifyPropertyChanged("CloseAutoCallDate_");
                }
            }
        }
        #endregion

        #region AutoCallReturn_
        private double autoCallreturn_;
        public double AutoCallReturn_
        {
            get { return this.autoCallreturn_; }
            set
            {
                if (this.autoCallreturn_ != value)
                {
                    this.autoCallreturn_ = value;
                    this.NotifyPropertyChanged("AutoCallReturn_");
                }
            }
        }
        #endregion

        #region AutoCallReturnPosition_
        private long autoCallReturnPosition_;
        public long AutoCallReturnPosition_
        {
            get { return this.autoCallReturnPosition_; }
            set
            {
                if (this.autoCallReturnPosition_ != value)
                {
                    this.autoCallReturnPosition_ = value;
                    this.NotifyPropertyChanged("AutoCallReturnPosition_");
                }
            }
        }
        #endregion

        #region CloseAutoCallTrigger_
        private double closeAutoCallTrigger_;
        public double CloseAutoCallTrigger_
        {
            get { return this.closeAutoCallTrigger_; }
            set
            {
                if (this.closeAutoCallTrigger_ != value)
                {
                    this.closeAutoCallTrigger_ = value;
                    this.NotifyPropertyChanged("CloseAutoCallTrigger_");
                }
            }
        }
        #endregion

        #region AssetParity_
        private double assetParity_;
        public double AssetParity_
        {
            get { return this.assetParity_; }
            set
            {
                if (this.assetParity_ != value)
                {
                    this.assetParity_ = value;
                    this.NotifyPropertyChanged("AssetParity_");
                }
            }
        }
        #endregion

        #region RemainDateToAutoCall_
        private int remainDateToAutoCall_;
        public int RemainDateToAutoCall_
        {
            get { return this.remainDateToAutoCall_; }
            set
            {
                if (this.remainDateToAutoCall_ != value)
                {
                    this.remainDateToAutoCall_ = value;
                    this.NotifyPropertyChanged("RemainDateToAutoCall_");
                }
            }
        }
        #endregion

        #region PastKIFlag_
        private bool pastKIFlag_;
        public bool PastKIFlag_
        {
            get { return this.pastKIFlag_; }
            set
            {
                if (this.pastKIFlag_ != value)
                {
                    this.pastKIFlag_ = value;
                    this.NotifyPropertyChanged("PastKIFlag_");
                }
            }
        }
        #endregion

        #endregion

        #region Sub_Underlying_Information

        #region UnderlyingVM_
        private ObservableCollection<UnderlyingHedgedViewModel> underlyingVM_;
        public ObservableCollection<UnderlyingHedgedViewModel> UnderlyingVM_
        {
            get { return this.underlyingVM_; }
            set
            {
                if (this.underlyingVM_ != value)
                {
                    this.underlyingVM_ = value;
                    this.NotifyPropertyChanged("UnderlyingVM_");
                }
            }
        }
        #endregion

        #endregion

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
