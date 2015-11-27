using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ELSStepDownGreekPositionViewModel
    {
        //public ELSStepDownGreekPositionViewModel(ELSUnderlyingStock stock,
        //                                         StandardInstrument elsInst) 
        public ELSStepDownGreekPositionViewModel(ELSUnderlyingStock stock) 
        {
            //this.krCode_ = elsInst.InstInfo_.KRCode_;
            //this.name_ = elsInst.InstInfo_.ProductName_;
            //this.underlyingName_ = stock.Name_;
            
            ////casting 해서 써야댐? 그외에는 없나.. 2013-08-06

            ////NoteInformation info = elsInst.InstInfo_ as NoteInformation;
            ////this.notional_ = info.Notional_;
            //this.notional_ = elsInst.InstInfo_.Notional_;

            this.baseUnderlyingPrice_ = stock.BasePrice_;
            this.assetParity_ = stock.CurrentPrice_ / stock.BasePrice_;
            this.neededQuantity_ = Convert.ToInt32(stock.Delta_.Value_);
            this.neededDeltaPosition_ = this.notional_ * (int)this.neededQuantity_;
            this.pastDayIncome_ = 999;
            this.cumulativeIncome_ = 999;

        }

        #region KRCode_
        private string krCode_;
        public string KRCode_
        {
            get { return this.krCode_; }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                    this.NotifyPropertyChanged("KRCode_");
                }
            }
        }
        #endregion

        #region Name_ - ELS 종목명
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

        #region UnderlyingName_ - 기초자산 종목명
        private string underlyingName_;
        public string UnderlyingName_
        {
            get { return this.underlyingName_; }
            set
            {
                if (this.underlyingName_ != value)
                {
                    this.underlyingName_ = value;
                    this.NotifyPropertyChanged("UnderlyingName_");
                }
            }
        }
        #endregion

        #region Noitional_ - 잔여명목금액
        private long notional_;
        public long Noitional_
        {
            get { return this.notional_; }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                    this.NotifyPropertyChanged("Noitional_");
                }
            }
        }
        #endregion

        #region BaseUnderlyingPrice_ - 기준가
        private double baseUnderlyingPrice_;
        public double BaseUnderlyingPrice_
        {
            get { return this.baseUnderlyingPrice_; }
            set
            {
                if (this.baseUnderlyingPrice_ != value)
                {
                    this.baseUnderlyingPrice_ = value;
                    this.NotifyPropertyChanged("BaseUnderlyingPrice_");
                }
            }
        }
        #endregion

        #region AssetParity_ - Trigger Current Level
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

        #region NeededQuantity_ - 필요주식수량
        private long neededQuantity_;
        public long NeededQuantity_
        {
            get { return this.neededQuantity_; }
            set
            {
                if (this.neededQuantity_ != value)
                {
                    this.neededQuantity_ = value;
                    this.NotifyPropertyChanged("NeededQuantity_");
                }
            }
        }
        #endregion
        
        #region NeededDeltaPosition_ - 필요델타금액
        private long neededDeltaPosition_;
        public long NeededDeltaPosition_
        {
            get { return this.neededDeltaPosition_; }
            set
            {
                if (this.neededDeltaPosition_ != value)
                {
                    this.neededDeltaPosition_ = value;
                    this.NotifyPropertyChanged("NeededDeltaPosition_");
                }
            }
        }
        #endregion

        #region PastDayIncome_ - 전일대비 손익
        private long pastDayIncome_;
        public long PastDayIncome_
        {
            get { return this.pastDayIncome_; }
            set
            {
                if (this.pastDayIncome_ != value)
                {
                    this.pastDayIncome_ = value;
                    this.NotifyPropertyChanged("PastDayIncome_");
                }
            }
        }
        #endregion

        #region CumulativeIncome - 누적손익
        private long cumulativeIncome_;
        public long CumulativeIncome
        {
            get { return this.cumulativeIncome_; }
            set
            {
                if (this.cumulativeIncome_ != value)
                {
                    this.cumulativeIncome_ = value;
                    this.NotifyPropertyChanged("CumulativeIncome");
                }
            }
        }
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
