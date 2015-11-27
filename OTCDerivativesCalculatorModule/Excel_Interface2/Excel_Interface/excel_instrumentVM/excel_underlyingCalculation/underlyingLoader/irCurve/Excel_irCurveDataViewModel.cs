using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_irCurveDataViewModel
    {
        public enum TenorType
        { 
            Month,
            Year
        }


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

        public List<string> tenorList_ { get; set; }

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

        public void setTenorIndex(List<string> tenorList)
        {
            this.tenorList_ = tenorList;
        }

        public int getTenorIndex(string tenorStr)
        {

            string tenorConvStr = this.convToTenor(tenorStr, TenorType.Month);

            for (int i = 0; i < this.tenorList_.Count; i++)
            {
                string tenorSet = this.convToTenor(this.tenorList_[i], TenorType.Month);

                if ( tenorSet == tenorConvStr)
                {
                    return i;
                }
            }

            return -1;
        }

        public Excel_irCurveDataViewModel()
        {
            this.excel_rateDataViewModelList_ = new ObservableCollection<Excel_rateDataViewModel>();
        }

        // type 으로 바꿔줌
        public string convToTenor(string tenor,TenorType type)
        {
            int len = tenor.Length;

            string periodMultiplier = tenor.Substring(0, len - 1);
            string period = tenor.Substring(len - 1, 1);

            if (period == "D")
            {
                return tenor;

            }
            else if (period == "M")
            {
                if (type == TenorType.Month)
                {
                    return tenor;
                }
                else if (type == TenorType.Year)
                {
                    double p = Convert.ToDouble(periodMultiplier) / 12.0;
                    double roundP = Math.Round(p, 1);

                    return roundP.ToString() + "Y";
                }
            }
            else if (period == "Y")
            {
                if (type == TenorType.Month)
                {
                    double p = Convert.ToDouble(periodMultiplier) * 12.0;
                    double roundP = Math.Round(p, 0);

                    return roundP.ToString() + "M";
                }
                else if (type == TenorType.Year)
                {
                    double p = Convert.ToDouble(periodMultiplier) / 12.0;
                    double roundP = Math.Round(p, 1);

                    return roundP.ToString() + "Y";
                }
            }
            else
            {
                throw new Exception("unknown type tenor : " + tenor);
            }

            return tenor;
        }
        

        
    }
}
