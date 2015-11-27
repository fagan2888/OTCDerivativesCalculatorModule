using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class OTCApplicationBookViewModel
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

        public OTCApplicationBookViewModel()
        {
            RootBookViewModel.setRootBookReferenceDate(ProgramVariable.ReferenceDate_);

            BookFolderView bfv = new BookFolderView();

            bfv.ReferenceDate_ = ProgramVariable.ReferenceDate_;
            bfv.positionXmlReload();

            this.view_ = bfv;

        }

 
    }
}
