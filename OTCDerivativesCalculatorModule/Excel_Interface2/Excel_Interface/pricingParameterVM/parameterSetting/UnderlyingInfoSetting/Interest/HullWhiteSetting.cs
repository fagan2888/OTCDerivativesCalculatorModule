using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class HullWhiteSetting : InterestRateParaSetting
    {
        public HullWhiteSetting()
        {
            this.HullWhite_FittingCurveSetting_ = new HullWhite_Const_FittingCurveSetting("0.03");
            this.HullWhite_AlphaSetting_ = new HullWhite_Const_AlphaSetting("0.013");
            this.HullWhite_SigmaSetting_ = new HullWhite_Const_SigmaSetting("0.01");
        }

        public HullWhite_FittingCurveSetting HullWhite_FittingCurveSetting_;
        public HullWhite_AlphaSetting HullWhite_AlphaSetting_;
        public HullWhite_SigmaSetting HullWhite_SigmaSetting_;


        public override Excel_underlyingModel_paraViewModel underModel(Excel_underlyingInfoViewModel excel_uivm, Excel_instrumentViewModel excel_instrumentViewModel, DateTime dateTime)
        {
            Excel_hullWhiteOneFactorViewModel e_hwofvm = new Excel_hullWhiteOneFactorViewModel();

            Excel_interestRateViewModel e_irvm = excel_uivm as Excel_interestRateViewModel;

            string value = Excel_loaderViewModel.loadMarketData(dateTime, excel_uivm.Excel_type_, excel_uivm.KrCode_);

            e_hwofvm.CurrentValue_ = value;

            e_hwofvm.Alpha_ = this.HullWhite_AlphaSetting_.value(dateTime, excel_instrumentViewModel, excel_uivm);
            e_hwofvm.Volatility_ = this.HullWhite_SigmaSetting_.value(dateTime, excel_instrumentViewModel, excel_uivm);

            e_hwofvm.setInterestRateInfo(e_irvm);

            e_hwofvm.Excel_yieldCurveViewModel_ = this.HullWhite_FittingCurveSetting_.value(dateTime, excel_instrumentViewModel, excel_uivm);

            return e_hwofvm;
        }
    }
}
