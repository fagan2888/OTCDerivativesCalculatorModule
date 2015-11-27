using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;


namespace Excel_Interface
{
    public class Excel_interestRateCurveLoaderViewModel : INotifyPropertyChanged
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

        #region Excel_interpolationViewModel_
        private Excel_interpolationViewModel excel_interpolationViewModel_;
        public Excel_interpolationViewModel Excel_interpolationViewModel_
        {
            get { return this.excel_interpolationViewModel_; }
            set
            {
                if (this.excel_interpolationViewModel_ != value)
                {
                    this.excel_interpolationViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_interpolationViewModel_");
                }
            }
        }
        #endregion

        #region RateDataViewModel_
        private ObservableCollection<Excel_rateDataViewModel> rateDataViewModel_;
        public ObservableCollection<Excel_rateDataViewModel> RateDataViewModel_
        {
            get { return this.rateDataViewModel_; }
            set
            {
                if (this.rateDataViewModel_ != value)
                {
                    this.rateDataViewModel_ = value;
                    //this.NotifyPropertyChanged("RateDataViewModel_");
                }
            }
        }
        #endregion

        #region Excel_yieldCurveViewModel_
        private Excel_yieldCurveViewModel excel_yieldCurveViewModel;
        public Excel_yieldCurveViewModel Excel_yieldCurveViewModel_
        {
            get { return this.excel_yieldCurveViewModel; }
            set
            {
                if (this.excel_yieldCurveViewModel != value)
                {
                    this.excel_yieldCurveViewModel = value;
                    this.NotifyPropertyChanged("Excel_yieldCurveViewModel_");
                }
            }
        }
        #endregion

        #region CurveHeaderInfoDataList_
        private ObservableCollection<CurveHeaderInfo_Table_DAO> curveHeaderInfoDataList_;
        public ObservableCollection<CurveHeaderInfo_Table_DAO> CurveHeaderInfoDataList_
        {
            get { return this.curveHeaderInfoDataList_; }
            set
            {
                if (this.curveHeaderInfoDataList_ != value)
                {
                    this.curveHeaderInfoDataList_ = value;
                    this.NotifyPropertyChanged("CurveHeaderInfoDataList_");
                }
            }
        }
        #endregion

        public Excel_interestRateCurveLoaderViewModel()
        {
            this.rateDataViewModel_ = new ObservableCollection<Excel_rateDataViewModel>();
            this.curveHeaderInfoDataList_ = new ObservableCollection<CurveHeaderInfo_Table_DAO>();

            //this.view_ = new Excel_interestRateCurveLoaderView();
            //this.view_.DataContext = this;
        }

        public void loadCurveHeaderList(DateTime d)
        {
            CurveHeaderInfo_Table_DAOManager daoM = new CurveHeaderInfo_Table_DAOManager();

            this.curveHeaderInfoDataList_.Clear();

            try
            {
                daoM.select(DataBaseConnectManager.ConnectionFactory("myDB"));

                foreach (var item in daoM.DAOList_)
                {
                    this.curveHeaderInfoDataList_.Add(item);
                }

            }
            catch (Exception)
            {
                OutputLogViewModel.addResult("curveHeaderList db load error");
            }

        }

        public void loadData(DateTime d,string curveCode)
        {
            this.rateDataViewModel_.Clear();

            for (int i = 1; i < 20; i++)
			{
			    Excel_rateDataViewModel e_rdvm = new Excel_rateDataViewModel();

                e_rdvm.RateType_ = "spot";
                e_rdvm.Tenor_ = (i*3).ToString() + "M"; 
                e_rdvm.Value_ = (0.03 + i*0.0007).ToString();
                this.rateDataViewModel_.Add(e_rdvm);
			}
            
        }

        public Control view()
        {
            Control v = new Excel_interestRateCurveLoaderView();

            v.DataContext = this;

            return v;            
        }

    }
}
