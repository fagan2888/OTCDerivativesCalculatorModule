using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class OTCApplicationViewModel
    {
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

        #region View_
        protected Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }
        #endregion

        #region ApplicationTab_BookViewModel_
        private OTCApplicationBookViewModel applicationTab_BookViewModel_;
        public OTCApplicationBookViewModel ApplicationTab_BookViewModel_
        {
            get { return this.applicationTab_BookViewModel_; }
            set
            {
                if (this.applicationTab_BookViewModel_ != value)
                {
                    this.applicationTab_BookViewModel_ = value;
                    this.NotifyPropertyChanged("ApplicationTab_BookViewModel_");
                }
            }
        }
        #endregion

        #region ApplicationTab_EventViewModel_
        private OTCApplicationEventViewModel applicationTab_EventViewModel_;
        public OTCApplicationEventViewModel ApplicationTab_EventViewModel_
        {
            get { return this.applicationTab_EventViewModel_; }
            set
            {
                if (this.applicationTab_EventViewModel_ != value)
                {
                    this.applicationTab_EventViewModel_ = value;
                    this.NotifyPropertyChanged("ApplicationTab_EventViewModel_");
                }
            }
        }
        #endregion

        #region ApplicationTab_BatchViewModel_
        private OTCApplicationBatchViewModel applicationTab_BatchViewModel_;
        public OTCApplicationBatchViewModel ApplicationTab_BatchViewModel_
        {
            get { return this.applicationTab_BatchViewModel_; }
            set
            {
                if (this.applicationTab_BatchViewModel_ != value)
                {
                    this.applicationTab_BatchViewModel_ = value;
                    this.NotifyPropertyChanged("ApplicationTab_BatchViewModel_");
                }
            }
        }
        #endregion

        public OTCApplicationViewModel()
        {
            SettingInitializer ini = new SettingInitializer();

            ini.initialze(1);

            DateTime d = this.loadLastPositionDate();

            ProgramVariable.ReferenceDate_ = d;

            //DataBaseConnectManager.ConnectionFactory("myDB")
            //    = DataBaseConnectManager.ConnectionFactory(EnvironmentVariable.MarketDataDBFile_);

            //ProgramVariable.CurrenctParameterSettingManager_ = new ParameterSettingManager();
            //ProgramVariable.CurrenctPricingMethodSettingManager_ = new PricingMethodSettingManager();
            //ProgramVariable.UnderlyingModelSetting_ = new UnderlyingModelSetting();

            ProgramVariable.initialize_ComboStr();

            this.applicationTab_BookViewModel_ = new OTCApplicationBookViewModel();

            //이벤트는 나중에 로드
            this.applicationTab_EventViewModel_ = new OTCApplicationEventViewModel();

            this.applicationTab_BatchViewModel_ = new OTCApplicationBatchViewModel();

            this.applicationTab_BatchViewModel_.ReferenceDate_ = ProgramVariable.ReferenceDate_;

            this.view_ = new OTCApplication();
            this.view_.DataContext = this;
        }

        private DateTime loadLastPositionDate()
        {

            // PROGRAM VARIABLE
            // calendar

            // market data 가 존재하는 일자로 ㄱㄱ



            //while ( 

            return Excel_loaderViewModel.availableMarketDataDate();
        }



    }
}
