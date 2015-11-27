//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.ComponentModel;
//using System.Collections.ObjectModel;

//namespace RiskMonitor
//{
//    public class InstrumentPortfolio
//    {

//        #region Instruments_
//        private ObservableCollection<Instrument> instruments_;
//        public ObservableCollection<Instrument> Instruments_
//        {
//            get { return this.instruments_; }
//            set
//            {
//                if (this.instruments_ != value)
//                {
//                    this.instruments_ = value;
//                    this.NotifyPropertyChanged("Instruments_");
//                }
//            }
//        }
//        #endregion

//        #region UnderlyingPortfolio_
//        private UnderlyingPortfolio underlyingportfolio_;
//        public UnderlyingPortfolio UnderlyingPortfolio_
//        {
//            get { return this.underlyingportfolio_; }
//            set
//            {
//                if (this.underlyingportfolio_ != value)
//                {
//                    this.underlyingportfolio_ = value;
//                    this.NotifyPropertyChanged("UnderlyingPortfolio_");
//                }
//            }
//        }
//        #endregion

//        public void update()
//        {
//            // calculation 함.
//        }

//        // private 
//        private void loadPosition() 
//        {
//            // intruments 에 data를 집어 넣음...

//            // underlyingPortfolio
//        }

//        private void buildUnderlyingPortfolio()
//        {
            
        
//        }

//        public event PropertyChangedEventHandler PropertyChanged;

//        private void NotifyPropertyChanged(string propertyName)
//        {
//            if (PropertyChanged != null)
//            {
//                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
//            }
//        }

//    }
//}
