using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class ParameterSettingManagerBuilder
    {
        public static ParameterSettingManager makeParaSettingManager(string settingID,DateTime refDate,Excel_instrumentViewModel e_instVM)
        {
            ParameterSettingManager psm = new ParameterSettingManager(refDate, e_instVM);

            // simulation Number
            psm.SimulationNumber_ = 10000;

            // underlying
            {
                UnderlyingParaSetting ups = new UnderlyingParaSetting(psm);

                // stock

                GBMSetting gbmSetting = new GBMSetting();

                gbmSetting.GBMDriftSetting_ = new GBM_Const_DriftSetting("0.0289");
                gbmSetting.GBMDividendSetting_ = new GBM_Const_DividendSetting("0.019");
                gbmSetting.GBMVolatilitySetting_ = new GBM_Const_VolatilitySetting("0.3");

                ups.StockParaSetting_ = new GBMSetting();

                // ir

                HullWhiteSetting hwSetting = new HullWhiteSetting();

                hwSetting.HullWhite_AlphaSetting_ = new HullWhite_Const_AlphaSetting("");
                hwSetting.HullWhite_SigmaSetting_ = new HullWhite_Const_SigmaSetting("");
                hwSetting.HullWhite_FittingCurveSetting_ = new HullWhite_Const_FittingCurveSetting("");

                ups.InterestRateParaSetting_ = hwSetting;

                // fx


                // corr

                ups.CorrelationParaSetting_ = new Constant_CorrelationParaSetting(psm);
            }

            // discount
            {
                DiscountCurveParaSetting dcps = new DiscountCurveParaSetting(psm);

                psm.DiscountCurveParaSetting_ = dcps;
            }

            return psm;
        }
    }
}
