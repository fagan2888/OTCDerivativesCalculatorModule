using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class GreekUnderlyingResultWrapperViewModel
    {
        //private ELSUnderlyingStock stock_;

        //public GreekUnderlyingResultWrapperViewModel(ELSUnderlyingStock stock,
        //                              ObservableCollection<ELSStepDownGreekPositionViewModel> linkedInstruments) 
        //{
            
        //    this.stock_ = stock;
        //    this.linkedInstruments_ = linkedInstruments;

        //    this.krCode_ = stock.KRCode_;
        //    this.name_ = stock.Name_;
        //    this.quantity_ = stock.Quantity_;
        //    this.unitPrice_ = stock.UnitPrice_;

        //    this.totalValue_ = Convert.ToInt32(this.unitPrice_ * (double)this.quantity_);

        //}

        public GreekUnderlyingResultWrapperViewModel()
        { }

        public GreekUnderlyingResultWrapperViewModel(UnderlyingViewModel underlyingVM)
        {
            // TODO: Complete member initialization
            this.underlyingVM = underlyingVM;
        }

        #region LinkedInstruments_
        private ObservableCollection<ELSStepDownGreekPositionViewModel> linkedInstruments_;
        public ObservableCollection<ELSStepDownGreekPositionViewModel> LinkedInstruments_    
        {
            get { return this.linkedInstruments_; }
            set
            {
                if (this.linkedInstruments_ != value)
                {
                    this.linkedInstruments_ = value;
                    this.NotifyPropertyChanged("Instruments_");
                }
            }
        }
        #endregion

        #region Main_Underlying_Information

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

        #region Name_ - 종목명
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

        #region Quantity_ - 수량
        private int quantity_;
        public int Quantity_
        {
            get { return this.quantity_; }
            set
            {
                if (this.quantity_ != value)
                {
                    this.quantity_ = value;
                    this.NotifyPropertyChanged("Quantity_");
                }
            }
        }
        #endregion

        #region UnitPrice_ - 장부단가
        private double unitPrice_;
        public double UnitPrice_
        {
            get { return this.unitPrice_; }
            set
            {
                if (this.unitPrice_ != value)
                {
                    this.unitPrice_ = value;
                    this.NotifyPropertyChanged("UnitPrice_");
                }
            }
        }
        #endregion

        #region TotalValue_ - 장부금액
        private int totalValue_;
        public int TotalValue_
        {
            get { return this.totalValue_; }
            set
            {
                if (this.totalValue_ != value)
                {
                    this.totalValue_ = value;
                    this.NotifyPropertyChanged("TotalValue_");
                }
            }
        }
        #endregion

        #region DeltaPosition_ - 델타금액
        private int deltaPosition_;
        public int DeltaPosition_
        {
            get { return this.deltaPosition_; }
            set
            {
                if (this.deltaPosition_ != value)
                {
                    this.deltaPosition_ = value;
                    this.NotifyPropertyChanged("DeltaPosition_");
                }
            }
        }
        #endregion
        
        #region CurrentPrice_ - 현재가
        private double currentPrice_;
        public double CurrentPrice_
        {
            get { return this.currentPrice_; }
            set
            {
                if (this.currentPrice_ != value)
                {
                    this.currentPrice_ = value;
                    this.NotifyPropertyChanged("CurrentPrice_");
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

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private UnderlyingViewModel underlyingVM;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
