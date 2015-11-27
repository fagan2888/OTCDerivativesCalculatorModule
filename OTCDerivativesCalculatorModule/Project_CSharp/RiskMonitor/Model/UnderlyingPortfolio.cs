//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.ComponentModel;
//using System.Collections.ObjectModel;

//namespace RiskMonitor
//{
//    public class UnderlyingPortfolio : INotifyPropertyChanged
//    {

//        public UnderlyingPortfolio(ObservableCollection<ELSUnderlyingStock> underlyingList) 
//        {
//            underlyingList_ = underlyingList;
//        }

//        public ELSUnderlyingStock getStock(string name) 
//        {

//            foreach (ELSUnderlyingStock item in underlyingList_)
//            {
//                if (item.Name_ == name)
//                {
//                    return item;
//                }
//            }

//            return new ELSUnderlyingStock(name);

//        }

//        #region UnderlyingList_
//        private ObservableCollection<ELSUnderlyingStock> underlyingList_;
//        public ObservableCollection<ELSUnderlyingStock> UnderlyingList_
//        {
//            get { return this.underlyingList_; }
//            set
//            {
//                if (this.underlyingList_ != value)
//                {
//                    this.underlyingList_ = value;
//                    this.NotifyPropertyChanged("Index_");
//                }
//            }
//        }
//        #endregion

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
