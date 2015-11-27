using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class HullWhite_Const_FittingCurveSetting : HullWhite_FittingCurveSetting
    {
        private string constRate_;

        public HullWhite_Const_FittingCurveSetting(string constRate)
        {
            // TODO: Complete member initialization
            this.constRate_ = constRate;
        }
        public override Excel_yieldCurveViewModel value(DateTime dateTime, Excel_instrumentViewModel e_instVM, Excel_underlyingInfoViewModel excel_uivm)
        {
            Excel_interestRateViewModel e_irvm = excel_uivm as Excel_interestRateViewModel;

            ObservableCollection<Excel_irCurveDataViewModel> e_ircdvmList = new ObservableCollection<Excel_irCurveDataViewModel>();

            Excel_yieldCurveViewModel e_ycvm = new Excel_yieldCurveViewModel();

            e_ycvm.Excel_interpolationViewModel_ = Excel_interpolationViewModel_;

            e_ycvm.Code_ = "constDefaultCurve";

            e_ycvm.loadCurve(constRate_);

            return e_ycvm;
        }
    }
}
