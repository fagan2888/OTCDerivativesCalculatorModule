//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.ComponentModel;
//using System.Collections.ObjectModel;

//namespace Excel_Interface
//{
//    public class UnderlyingDetailComboViewModel : INotifyPropertyChanged
//    {
//        #region Event
//        public event PropertyChangedEventHandler PropertyChanged;

//        protected void NotifyPropertyChanged(string propertyName)
//        {
//            if (PropertyChanged != null)
//            {
//                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
//            }
//        }
//        #endregion

//        #region UnderlyingDetailComboString_
//        protected string underlyingDetailComboString_;
//        public string UnderlyingDetailComboString_
//        {
//            get { return this.underlyingDetailComboString_; }
//            set
//            {
//                if (this.underlyingDetailComboString_ != value)
//                {
//                    this.underlyingDetailComboString_ = value;
//                    this.NotifyPropertyChanged("UnderlyingDetailComboString_");
//                }
//            }
//        }
//        #endregion

//        public UnderlyingDetailComboViewModel(string underlyingDetailComboString)
//        {
//            this.underlyingDetailComboString_ = underlyingDetailComboString;
//        }
//    }
//}
