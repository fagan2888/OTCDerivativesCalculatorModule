using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class DiscountCurveParaSetting
    {
        private ParameterSettingManager owner_parameterSettingManager_;

        public DiscountCurveParaSetting(ParameterSettingManager parameterSettingManager)
        {
            // TODO: Complete member initialization
            this.owner_parameterSettingManager_ = parameterSettingManager;
        }

        public Excel_yieldCurveViewModel discountCurve(DateTime refDate, string currencyCode)
        {
            //조회함       

            Excel_yieldCurveViewModel e_ycvm = new Excel_yieldCurveViewModel();

            DISCOUNTCURVESETTING_Table_DAO dao = new DISCOUNTCURVESETTING_Table_DAO();

            //dao.CURRENCY_ = cvm.CurrencyCode_;
            dao.KeyColumn_ = currencyCode;

            dao.select(DataBaseConnectManager.ConnectionFactory("myDB"));

            string provider = dao.PROVIDER_;
            string curveCode = dao.CURVECODE_;

            e_ycvm.Code_ = curveCode;
            e_ycvm.Currency_ = currencyCode;

            IRCurveMarketDataLoader loader = IRCurveMarketDataLoader.CreateMarketDataLoader(provider);

            ObservableCollection<Excel_irCurveDataViewModel> e_ircdvmList = new ObservableCollection<Excel_irCurveDataViewModel>();

            loader.load(refDate, curveCode, e_ircdvmList);

            foreach (var item in e_ircdvmList[0].Excel_rateDataViewModelList_)
            {
                Excel_rateDataViewModel e_rdvm = new Excel_rateDataViewModel();

                e_rdvm.RateType_ = item.RateType_;
                e_rdvm.Tenor_ = item.Tenor_;
                e_rdvm.Value_ = item.Value_;

                e_ycvm.Excel_rateDataViewModel_.Add(e_rdvm);
            }

            e_ycvm.Excel_interpolationViewModel_ = new Excel_interpolationViewModel();


            //e_ycvm.loadCurve();

            return e_ycvm;
        }

        public Excel_yieldCurveViewModel discountCurve(DateTime refDate,CurrencyViewModel cvm)
        {
            return this.discountCurve(refDate,cvm.CurrencyCode_);
            
        }
    }
}
