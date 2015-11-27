using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class HullWhite_MRO_FittingCurveSetting : HullWhite_FittingCurveSetting
    {
        public override Excel_yieldCurveViewModel value(DateTime dateTime, Excel_instrumentViewModel e_instVM, Excel_underlyingInfoViewModel excel_uivm)
        {
            IRCurveMarketDataLoader curveLoader = IRCurveMarketDataLoader.CreateMarketDataLoader("MRO");

            Excel_interestRateViewModel e_irvm = excel_uivm as Excel_interestRateViewModel;

            ObservableCollection<Excel_irCurveDataViewModel> e_ircdvmList = new ObservableCollection<Excel_irCurveDataViewModel>();

            curveLoader.load(dateTime, e_irvm.LinkedCurveCode_, e_ircdvmList);
            //e_icsvm.Symbol_ = excel_uivm.KrCode_;

            //e_icsvm.dataLoad(dateTime, e_irvm.LinkedCurveCode_);

            Excel_yieldCurveViewModel e_ycvm = new Excel_yieldCurveViewModel();

            e_ycvm.Excel_interpolationViewModel_ = Excel_interpolationViewModel_;

            e_ycvm.Code_ = e_ircdvmList[0].Curve_code_;

            e_ycvm.Excel_rateDataViewModel_ = e_ircdvmList[0].Excel_rateDataViewModelList_;

            return e_ycvm;
        }
    }
}
