using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace RiskMonitor
{
    public class HistoryResultViewModel
    {
        public ParameterSetting parametorSetting_ { get; set; }
        public string ItemCode_ { get; set; }

        public HistoryResultViewModel() 
        {
            
        }

        #region InitialDate_
        private DateTime initialDate_;
        public DateTime InitialDate_
        {
            get { return this.initialDate_; }
            set
            {
                if (this.initialDate_ != value)
                {
                    this.initialDate_ = value;
                    this.NotifyPropertyChanged("InitialDate_");
                }
            }
        }
        #endregion

        #region LastDate_
        private DateTime lastDate_;
        public DateTime LastDate_
        {
            get { return this.lastDate_; }
            set
            {
                if (this.lastDate_ != value)
                {
                    this.lastDate_ = value;
                    this.NotifyPropertyChanged("LastDate_");
                }
            }
        }
        #endregion

        #region HistoryResults_
        private ObservableCollection<ResultModel> historyResults_;
        public ObservableCollection<ResultModel> HistoryResults_
        {
            get { return this.historyResults_; }
            set
            {
                if (this.historyResults_ != value)
                {
                    this.historyResults_ = value;
                    this.NotifyPropertyChanged("HistoryResults_");
                }
            }
        }
        #endregion

        public void loadHistory() 
        {
            //MRO loader 에 쿼리파일 전달
            MROResultDataLoader loader = new MROResultDataLoader();
            
            //loader.QuerySet_.Add("", sb);
            this.historyResults_ = loader.historyResults(initialDate_,lastDate_,this.ItemCode_);

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
