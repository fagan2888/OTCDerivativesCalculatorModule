using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class Excel_underlyingLoaderViewModel : INotifyPropertyChanged
    {
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

        #region SelectedUnderlyingVM_
        private Excel_underlyingInfoViewModel selectedUnderlyingVM_;
        public Excel_underlyingInfoViewModel SelectedUnderlyingVM_
        {
            get { return this.selectedUnderlyingVM_; }
            set
            {
                if (this.selectedUnderlyingVM_ != value)
                {
                    this.selectedUnderlyingVM_ = value;
                    //this.NotifyPropertyChanged("SelectedUnderlyingVM_");
                }
            }
        }
        #endregion

        #region Excel_equityLoaderViewModel_
        private Excel_equityLoaderViewModel excel_equityLoaderViewModel_;
        public Excel_equityLoaderViewModel Excel_equityLoaderViewModel_
        {
            get { return this.excel_equityLoaderViewModel_; }
            set
            {
                if (this.excel_equityLoaderViewModel_ != value)
                {
                    this.excel_equityLoaderViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_equityLoaderViewModel_");
                }
            }
        }
        #endregion

        #region Excel_indexLoaderViewModel_
        private Excel_indexLoaderViewModel excel_indexLoaderViewModel_;
        public Excel_indexLoaderViewModel Excel_indexLoaderViewModel_
        {
            get { return this.excel_indexLoaderViewModel_; }
            set
            {
                if (this.excel_indexLoaderViewModel_ != value)
                {
                    this.excel_indexLoaderViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_indexLoaderViewModel_");
                }
            }
        }
        #endregion

        #region Excel_irLoaderViewModel_
        private Excel_irLoaderViewModel excel_irLoaderViewModel_;
        public Excel_irLoaderViewModel Excel_irLoaderViewModel_
        {
            get { return this.excel_irLoaderViewModel_; }
            set
            {
                if (this.excel_irLoaderViewModel_ != value)
                {
                    this.excel_irLoaderViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_irLoaderViewModel_");
                }
            }
        }
        #endregion

        #region Excel_irCurveLoaderViewModel_
        private Excel_irCurveLoaderViewModel excel_irCurveLoaderViewModel_;
        public Excel_irCurveLoaderViewModel Excel_irCurveLoaderViewModel_
        {
            get { return this.excel_irCurveLoaderViewModel_; }
            set
            {
                if (this.excel_irCurveLoaderViewModel_ != value)
                {
                    this.excel_irCurveLoaderViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_irCurveLoaderViewModel_");
                }
            }
        }
        #endregion

        #region Excel_fxLoaderViewModel_
        private Excel_fxLoaderViewModel excel_fxLoaderViewModel_;
        public Excel_fxLoaderViewModel Excel_fxLoaderViewModel_
        {
            get { return this.excel_fxLoaderViewModel_; }
            set
            {
                if (this.excel_fxLoaderViewModel_ != value)
                {
                    this.excel_fxLoaderViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_fxLoaderViewModel_");
                }
            }
        }
        #endregion

        #region Excel_commLoaderViewModel_
        private Excel_commLoaderViewModel excel_commLoaderViewModel_;
        public Excel_commLoaderViewModel Excel_commLoaderViewModel_
        {
            get { return this.excel_commLoaderViewModel_; }
            set
            {
                if (this.excel_commLoaderViewModel_ != value)
                {
                    this.excel_commLoaderViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_commLoaderViewModel_");
                }
            }
        }
        #endregion

        #region Excel_creditCurveLoaderViewModel_
        private Excel_creditCurveLoaderViewModel excel_creditCurveLoaderViewModel_;
        public Excel_creditCurveLoaderViewModel Excel_creditCurveLoaderViewModel_
        {
            get { return this.excel_creditCurveLoaderViewModel_; }
            set
            {
                if (this.excel_creditCurveLoaderViewModel_ != value)
                {
                    this.excel_creditCurveLoaderViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_creditCurveLoaderViewModel_");
                }
            }
        }
        #endregion

        public Excel_underlyingLoaderViewModel()
        {
            this.excel_equityLoaderViewModel_ = new Excel_equityLoaderViewModel();
            this.excel_indexLoaderViewModel_ = new Excel_indexLoaderViewModel();
            this.excel_irLoaderViewModel_ = new Excel_irLoaderViewModel();
            this.excel_irCurveLoaderViewModel_ = new Excel_irCurveLoaderViewModel();
            this.excel_fxLoaderViewModel_ = new Excel_fxLoaderViewModel();
            this.excel_commLoaderViewModel_ = new Excel_commLoaderViewModel();
            this.excel_creditCurveLoaderViewModel_ = new Excel_creditCurveLoaderViewModel();

        }

        public Control view()
        {
            Control v = new Excel_underlyingLoaderView();

            v.DataContext = this;

            return v;
        }

        public void reload()
        {
            this.excel_equityLoaderViewModel_.loadDefinedSymbolFromDB();
            this.excel_indexLoaderViewModel_.loadDefinedSymbolFromDB();
            this.excel_irLoaderViewModel_.loadDefinedSymbolFromDB();
            this.excel_irCurveLoaderViewModel_.loadDefinedSymbolFromDB();
            this.excel_fxLoaderViewModel_.loadDefinedSymbolFromDB();
            this.excel_commLoaderViewModel_.loadDefinedSymbolFromDB();
            this.excel_creditCurveLoaderViewModel_.loadDefinedSymbolFromDB();

        }

        
    }
}
