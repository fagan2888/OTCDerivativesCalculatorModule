using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class BookPropertyViewModel
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

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region BookViewModel_
        private BookViewModel bookViewModel_;
        public BookViewModel BookViewModel_
        {
            get { return this.bookViewModel_; }
            set
            {
                if (this.bookViewModel_ != value)
                {
                    this.bookViewModel_ = value;
                    this.NotifyPropertyChanged("BookViewModel_");
                }
            }
        }
        #endregion

        public BookPropertyViewModel()
        {
            //this.view_ = new BookPropertyView();
            //this.view_.DataContext = this;
        }

        public Control view()
        {
            Control v = new BookPropertyView();

            v.DataContext = this;

            return v;
        }
    }
}
