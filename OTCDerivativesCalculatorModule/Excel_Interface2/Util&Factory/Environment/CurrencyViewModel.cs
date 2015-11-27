using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    // 여기에 종속된 무언가를 함. curve를 setting한다던지 머... 
    // 환율이라던지
    public class CurrencyViewModel : INotifyPropertyChanged
    {
        //public enum CurrencyEnum 
        //{
        //    USD,
        //    EUR,
        //    JPY,
        //    GBP,
        //    AUD,
        //    CHF,
        //    CAD,
        //    MXN,
        //    CNY,
        //    NZD,
        //    SEK,
        //    RUB,
        //    HKD,
        //    SGD,
        //    TRY
        //};

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

        #region CurrencyString_
        protected string currencyString_;
        public string CurrencyString_
        {
            get { return this.currencyString_; }
            private set
            {
                if (this.currencyString_ != value)
                {
                    this.currencyString_ = value;
                    this.NotifyPropertyChanged("CurrencyString_");
                }
            }
        }
        #endregion

        #region CurrencyCode_
        private string currencyCode_;
        public string CurrencyCode_
        {
            get { return this.currencyCode_; }
            private set
            {
                if (this.currencyCode_ != value)
                {
                    this.currencyCode_ = value;
                    this.NotifyPropertyChanged("CurrencyCode_");
                }
            }
        }
        #endregion

        #region SelectedIndex_
        private int selectedIndex_;
        public int SelectedIndex_
        {
            get { return this.selectedIndex_; }
            set
            {
                if (this.selectedIndex_ != value)
                {
                    this.selectedIndex_ = value;

                    this.currencyCode_ = ProgramVariable.CurrencyStringList_[value].CurrencyCode_;
                    this.currencyString_ = ProgramVariable.CurrencyStringList_[value].CurrencyString_;

                    this.NotifyPropertyChanged("SelectedIndex_");
                }
            }
        }
        #endregion

        public CurrencyViewModel(string currencyCode,string currencyString)
        {
            this.currencyCode_ = currencyCode;
            this.currencyString_ = currencyString;
        }

        public static CurrencyViewModel CreateCurrencyComboViewModel(string type)
        {
            //Dictionary<string, string> contractMap = new Dictionary<string, string>();
            
            CurrencyViewModel cvm = new CurrencyViewModel(type, "Unkown");

            foreach (var item in ProgramVariable.CurrencyStringList_)
            {
                if (item.currencyString_ == type)
                {
                    cvm = item.Clone();
                }
            }
            
            return cvm;
        }

        public CurrencyViewModel Clone()
        {
            CurrencyViewModel clone = new CurrencyViewModel(this.currencyCode_, this.currencyString_);

            clone.SelectedIndex_ = this.SelectedIndex_;

            return clone;
        }

        public void Copy(CurrencyViewModel copy)
        {
            this.selectedIndex_ = copy.SelectedIndex_;
            this.currencyCode_ = copy.currencyCode_;
            this.currencyString_ = copy.currencyString_;
        }
    }
}
