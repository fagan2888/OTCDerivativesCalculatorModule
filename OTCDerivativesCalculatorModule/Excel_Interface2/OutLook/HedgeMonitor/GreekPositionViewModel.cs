using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public  class GreekPositionViewModel //: PositionViewModel
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region Name_
        protected string name_;
        public string Name_
        {
            get { return this.name_; }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                    //this.NotifyPropertyChanged("Name_");
                }
            }
        }
        #endregion

        #region Delta_
        private string delta_;
        public string Delta_
        {
            get { return this.delta_; }
            set
            {
                if (this.delta_ != value)
                {
                    this.delta_ = value;
                    this.NotifyPropertyChanged("Delta_");
                }
            }
        }
        #endregion

        #region Gamma_
        private string gamma_;
        public string Gamma_
        {
            get { return this.gamma_; }
            set
            {
                if (this.gamma_ != value)
                {
                    this.gamma_ = value;
                    this.NotifyPropertyChanged("Gamma_");
                }
            }
        }
        #endregion

        #region Vega_
        private string vega_;
        public string Vega_
        {
            get { return this.vega_; }
            set
            {
                if (this.vega_ != value)
                {
                    this.vega_ = value;
                    this.NotifyPropertyChanged("Vega_");
                }
            }
        }
        #endregion

        private double notional_ = 0.0;
        private double unit_ = 0.0;

        private double unitDelta_ = 0.0;
        private double unitGamma_ = 0.0;
        private double unitVega_ = 0.0;

        private double deltaAmt(double increment)
        {
            double result = this.notional_ * this.unit_ * this.unitDelta_ * increment;

            return 0.0;
        }

        private double gammaAmt(double increment)
        {
            double result = this.notional_ * this.unit_ * (0.5 * this.unitGamma_ * increment * increment);

            return 0.0;
        }

        private double vegaAmt(double increment)
        {
            double result = this.notional_ * this.unit_ * this.unitVega_ * increment ;

            return 0.0;
        }
    }
}
