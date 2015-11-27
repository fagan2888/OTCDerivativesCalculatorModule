using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class CurrencyManagerViewModel
    {
        //#region View_
        //protected Control view_;
        //public Control View_
        //{
        //    get { return this.view_; }
        //    set
        //    {
        //        if (this.view_ != value)
        //        {
        //            this.view_ = value;
        //            this.NotifyPropertyChanged("View_");
        //        }
        //    }
        //}
        //#endregion

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

        #region CurrencyVMList_
        private ObservableCollection<CurrencyViewModel> currencyVMList_;
        public ObservableCollection<CurrencyViewModel> CurrencyVMList_
        {
            get { return this.currencyVMList_; }
            set
            {
                if (this.currencyVMList_ != value)
                {
                    this.currencyVMList_ = value;
                    this.NotifyPropertyChanged("CurrencyVMList_");
                }
            }
        }
        #endregion

        public CurrencyManagerViewModel()
        {
            this.currencyVMList_ = new ObservableCollection<CurrencyViewModel>();


        }



    }
}
