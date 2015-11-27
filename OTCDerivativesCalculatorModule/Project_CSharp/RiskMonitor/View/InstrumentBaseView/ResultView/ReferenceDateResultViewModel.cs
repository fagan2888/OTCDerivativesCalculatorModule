using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ReferenceDateResultViewModel
    {
        //public DateTime ReferenceDate_ { get; set; }

        public ReferenceDateResultViewModel(ResultModel resultModel)
        {
            // TODO: Complete member initialization
            this.resultModel_ = resultModel;
            this.price_ = resultModel.Price_;
            this.unitValue_ = resultModel.UnitPrice_;
            this.referenceDate_ = resultModel.ReferenceDate_;

        }

        #region ResultModel_
        private ResultModel resultModel_;
        public ResultModel ResultModel_
        {
            get { return this.resultModel_; }
            set
            {
                if (this.resultModel_ != value)
                {
                    this.resultModel_ = value;
                    this.price_ = value.Price_;
                    this.unitValue_ = value.UnitPrice_;
                    this.referenceDate_ = value.ReferenceDate_;
                    this.NotifyPropertyChanged("ResultModel_");
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

        #region Price_
        private double price_;
        public double Price_
        {
            get { return this.price_; }
            set
            {
                if (this.price_ != value)
                {
                    this.price_ = value;
                    this.NotifyPropertyChanged("Price_");
                }
            }
        }
        #endregion

        #region UnitValue_
        private double unitValue_;
        public double UnitValue_
        {
            get { return this.unitValue_; }
            set
            {
                if (this.unitValue_ != value)
                {
                    this.unitValue_ = value;
                    this.NotifyPropertyChanged("UnitValue_");
                }
            }
        }
        #endregion

        


    }
}
