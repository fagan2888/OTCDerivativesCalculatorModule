using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_creditCurveDataViewModel
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                if (propertyName == "")
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
                else
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
        #endregion

        #region ReferenceDate_
        private DateTime referenceDate_;
        public DateTime ReferenceDate_
        {
            get { return this.referenceDate_; }
            set
            {
                if (this.referenceDate_ != value)
                {
                    this.referenceDate_ = value;
                    this.NotifyPropertyChanged("ReferenceDate_");
                }
            }
        }
        #endregion

        #region ReferenceEntity_
        private string referenceEntity_;
        public string ReferenceEntity_
        {
            get { return this.referenceEntity_; }
            set
            {
                if (this.referenceEntity_ != value)
                {
                    this.referenceEntity_ = value;
                    this.NotifyPropertyChanged("ReferenceEntity_");
                }
            }
        }
        #endregion

        #region Curve_code_
        private string curve_code_;
        public string Curve_code_
        {
            get { return this.curve_code_; }
            set
            {
                if (this.curve_code_ != value)
                {
                    this.curve_code_ = value;
                    this.NotifyPropertyChanged("Curve_code_");
                }
            }
        }
        #endregion

        #region Excel_rateDataViewModelList_
        private ObservableCollection<Excel_rateDataViewModel> excel_rateDataViewModelList_;
        public ObservableCollection<Excel_rateDataViewModel> Excel_rateDataViewModelList_
        {
            get { return this.excel_rateDataViewModelList_; }
            set
            {
                if (this.excel_rateDataViewModelList_ != value)
                {
                    this.excel_rateDataViewModelList_ = value;
                    this.NotifyPropertyChanged("Excel_rateDataViewModelList_");
                }
            }
        }
        #endregion

        public Excel_creditCurveDataViewModel()
        {
            this.excel_rateDataViewModelList_ = new ObservableCollection<Excel_rateDataViewModel>();
        }
    }
}
