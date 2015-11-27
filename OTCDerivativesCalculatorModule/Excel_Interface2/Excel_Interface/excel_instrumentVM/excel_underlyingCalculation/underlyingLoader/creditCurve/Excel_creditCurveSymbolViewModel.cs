using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_creditCurveSymbolViewModel : Excel_marketDataSymbol
    {
        #region Excel_creditCurveDataViewModelList_
        private ObservableCollection<Excel_creditCurveDataViewModel> excel_creditCurveDataViewModelList_;
        public ObservableCollection<Excel_creditCurveDataViewModel> Excel_creditCurveDataViewModelList_
        {
            get { return this.excel_creditCurveDataViewModelList_; }
            set
            {
                if (this.excel_creditCurveDataViewModelList_ != value)
                {
                    this.excel_creditCurveDataViewModelList_ = value;
                    this.NotifyPropertyChanged("Excel_irCurveDataViewModelList_");
                }
            }
        }
        #endregion

        public Excel_creditCurveSymbolViewModel()
        {
            this.excel_creditCurveDataViewModelList_ = new ObservableCollection<Excel_creditCurveDataViewModel>();

        }

        public override string dataLoad(DateTime refDate, string code)
        {
            MRO_IRCurveMarketDataLoader mro_irLoader = new MRO_IRCurveMarketDataLoader(this.provider_);

            //this.excel_irCurveDataViewModelList_.Clear();

            //mro_irLoader.load(refDate, this.symbol_, this.excel_irCurveDataViewModelList_);


            //CURVE_DATA_Table_DAOManager daoM = new CURVE_DATA_Table_DAOManager();

            //daoM.CURVE_CODE_ = this.symbol_;
            //daoM.KeyColumn_ = this.symbol_;

            //// 날짜 select 해서

            //daoM.select(DataBaseConnectManager.ConnectionFactory("myDB"));

            //Excel_irCurveDataViewModel e_icdvm = new Excel_irCurveDataViewModel();

            //string refDateStr = refDate.ToString(StringFormat.DbDateFormat_);

            //e_icdvm.ReferenceDate_ = refDate;
            //e_icdvm.Curve_code_ = this.symbol_;
            //e_icdvm.Excel_rateDataViewModelList_.Clear();

            //foreach (CURVE_DATA_Table_DAO item in daoM.DAOList_)
            //{
            //    Excel_rateDataViewModel e_rdvm = new Excel_rateDataViewModel();

            //    e_rdvm.Tenor_ = item.TENOR_;
            //    e_rdvm.Value_ = item.VALUE_;
            //    e_rdvm.RateType_ = item.CURVE_TYPE_;

            //    e_icdvm.Excel_rateDataViewModelList_.Add(e_rdvm);

            //}

            return "not implemented";

        }

        public override Excel_underlyingInfoViewModel underlyingInfoVM()
        {
            throw new NotImplementedException();
        }
    }
}
