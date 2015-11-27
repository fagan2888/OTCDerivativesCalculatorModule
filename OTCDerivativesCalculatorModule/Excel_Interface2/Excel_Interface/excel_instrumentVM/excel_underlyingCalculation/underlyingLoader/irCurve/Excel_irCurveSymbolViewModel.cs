using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using QLNet;

namespace Excel_Interface
{
    public class Excel_irCurveSymbolViewModel : Excel_marketDataSymbol
    {
        #region Excel_irCurveDataViewModelList_
        private ObservableCollection<Excel_irCurveDataViewModel> excel_irCurveDataViewModelList_;
        public ObservableCollection<Excel_irCurveDataViewModel> Excel_irCurveDataViewModelList_
        {
            get { return this.excel_irCurveDataViewModelList_; }
            set
            {
                if (this.excel_irCurveDataViewModelList_ != value)
                {
                    this.excel_irCurveDataViewModelList_ = value;
                    this.NotifyPropertyChanged("Excel_irCurveDataViewModelList_");
                }
            }
        }
        #endregion

        public Excel_irCurveSymbolViewModel()
        {
            this.excel_irCurveDataViewModelList_ = new ObservableCollection<Excel_irCurveDataViewModel>();

        }

        public override string dataLoad(DateTime refDate, string code)
        {
            MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

            dao.SYMBOL_ = code;

            dao.select(DataBaseConnectManager.ConnectionFactory("myDB"));

            this.setFromDAO(dao);

            IRCurveMarketDataLoader irLoader = IRCurveMarketDataLoader.CreateMarketDataLoader(this.provider_);

            ObservableCollection<Excel_irCurveDataViewModel> e_ircdvmList = new ObservableCollection<Excel_irCurveDataViewModel>();

            irLoader.load(refDate, this.Linkedcurve_, e_ircdvmList);

            int tenorNum = e_ircdvmList[0].getTenorIndex(this.Tenor_);

            string value = e_ircdvmList[0].Excel_rateDataViewModelList_[tenorNum].Value_;

            return value;
        }

        public YieldTermStructure buildQLNet_YieldTS(Excel_irCurveDataViewModel e_irCurveData)
        {
            QLNet.YieldTermStructure ql_yts = new YieldTermStructure();

            List<QLNet.Date> dates = new List<QLNet.Date>();
            List<double> yields = new List<double>();

            foreach (var item in e_irCurveData.Excel_rateDataViewModelList_)
            {
                string tenor = item.Tenor_;

                if (tenor.Substring(0, 1) == "D")
                {
                    int addDays = Convert.ToInt32(tenor.Substring(1, 3));
                    dates.Add(ProgramVariable.ReferenceDate_.AddDays(addDays));
                }
                else if (tenor.Substring(0, 1) == "M")
                {
                    int addMonths = Convert.ToInt32(tenor.Substring(1, 3));
                    dates.Add(ProgramVariable.ReferenceDate_.AddMonths(addMonths));
                }
                else
                {
                    throw new Exception("unknown type tenor : " + tenor);
                }

                yields.Add(Convert.ToDouble(item.Value_));

            }

            QLNet.DayCounter dc = new QLNet.Actual365Fixed();

            QLNet.InterpolatedZeroCurve<QLNet.Linear> curve = new QLNet.InterpolatedZeroCurve<QLNet.Linear>(
                dates, yields, dc, new QLNet.Linear());

            return ql_yts;
        }

        public YieldTermStructure yieldCurveLoadFromDB(DateTime refDate, string code)
        {

            string provider = Excel_marketDataSymbol.getProvider(code);

            IRCurveMarketDataLoader irLoader = IRCurveMarketDataLoader.CreateMarketDataLoader(provider);

            this.excel_irCurveDataViewModelList_.Clear();

            irLoader.load(refDate, code, this.excel_irCurveDataViewModelList_);

            return this.buildQLNet_YieldTS(this.excel_irCurveDataViewModelList_[0]);

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

        }

        public override Excel_underlyingInfoViewModel underlyingInfoVM()
        {
            Excel_interestRateViewModel e_irvm = new Excel_interestRateViewModel();

            e_irvm.KrCode_ = this.Symbol_; // curve code.... 

            e_irvm.Tenor_ = this.Tenor_;

            e_irvm.NameTrans_ = new NameTrans(this.name_eng_);

            return e_irvm;
        }
    }
}
