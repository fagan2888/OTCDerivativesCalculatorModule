using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class UnderlyingModelSetting
    {
        public ParameterSettingManager ParameterSettingManager_ { get; set; }

        public UnderlyingModelSetting()
        {
            //this.ParameterSettingManager_ = new ParameterSettingManager();

            //ParameterSettingManager_.gbmSetting_ = new GBMSetting();
            //ParameterSettingManager_.hullWhiteSetting_ = new HullWhiteSetting();
            //ParameterSettingManager_.curveInterpolationSetting_ = new CurveInterpolationSetting();
        }

        public Excel_underlyingInfo_paraViewModel getUnderlyingParameterModel(Excel_underlyingInfoViewModel e_uivm)
        {
            Excel_underlyingInfo_paraViewModel e_uipvm = new Excel_underlyingInfo_paraViewModel();

            if (e_uivm.Excel_type_.ToUpper() == "STOCK")
            {
                e_uipvm.KrCode_ = e_uivm.KrCode_;
                //e_uipvm.UnderName_ = e_uivm.Name_;
                //e_uipvm.Model_ = "GBM";

                Excel_geometricBMViewModel e_gbmvm = new Excel_geometricBMViewModel();

                e_gbmvm.Code_ = e_uivm.KrCode_;

                e_uipvm.Excel_underlyingModel_paraViewModel_ = e_gbmvm;

            }
            else if (e_uivm.Excel_type_.ToUpper() == "INTERESTRATE")
            {
                e_uipvm.KrCode_ = e_uivm.KrCode_;
                //e_uipvm.UnderName_ = e_uivm.Name_;
                //e_uipvm.Model_ = "HullWhiteOne";

                Excel_hullWhiteOneFactorViewModel e_hwofvm = new Excel_hullWhiteOneFactorViewModel();

                Excel_interestRateViewModel e_irvm = e_uivm as Excel_interestRateViewModel;

                e_hwofvm.Code_ = e_uivm.KrCode_;

                e_hwofvm.setInterestRateInfo(e_irvm);

                e_uipvm.Excel_underlyingModel_paraViewModel_ = e_hwofvm;
            }
            else
            {
                throw new NotImplementedException();
            }

            e_uipvm.Excel_underlyingModel_paraViewModel_.parameterLoad(
                this.ParameterSettingManager_);

            return e_uipvm;
        }
    }
}
