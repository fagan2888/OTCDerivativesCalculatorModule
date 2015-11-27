using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    class VolCalculationInformationViewModel
    {
        public DateTime startDate = new DateTime();
        public DateTime endDate = new DateTime();

        private List<string> calculationStr_ = Setting.VolCalculationMethod;
        private List<string> selectedCalculationStr_;

        public VolCalculationInformationViewModel()
        {
            //VolDataBaseDataSet vol = new VolDataBaseDataSet();
            this.volCalculationManager_ = new VolCalculationManager();
            this.result_ = new List<List<double>>();
        }

        public void AddCalculationMethod(string calMethodType,int month) 
        {
            if (calMethodType == "HIST")
            {
                HistVolCalculator histVolCal = new HistVolCalculator();
                histVolCal.MethodType_ = HistVolCalculator.MethodType.HISTORYCAL;
                histVolCal.CalculationInterval = month;

                //this.volCalculationManager_.VolCalculaters_.Add(histVolCal);
            }
            else if (calMethodType == "OTHER")
            {

            }
        }

        public void calculate(string underCode) 
        {
            //data connection 을 여기서 하고 dataset을 만듬.

            this.result_ = new List<List<double>>();

            volCalculationManager_.calculateVol(this.result_);

            //foreach (VolCalculater item in volCalculaters_)
            //{
            //    item.result(underCode,startDate,endDate,selectedCalculationStr_));
            //}
        }


        #region Result_
        private List<List<double>> result_;
        public List<List<double>> Result_
        {
            get { return this.result_; }
            set
            {
                if (this.result_ != value)
                {
                    this.result_ = value;
                    this.NotifyPropertyChanged("Result_");
                }
            }
        }
        #endregion

        #region VolCalculationManager_
        private VolCalculationManager volCalculationManager_;
        public VolCalculationManager VolCalculationManager_
        {
            get { return this.volCalculationManager_; }
            set
            {
                if (this.volCalculationManager_ != value)
                {
                    this.volCalculationManager_ = value;
                    this.NotifyPropertyChanged("VolCalculationManager_");
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
