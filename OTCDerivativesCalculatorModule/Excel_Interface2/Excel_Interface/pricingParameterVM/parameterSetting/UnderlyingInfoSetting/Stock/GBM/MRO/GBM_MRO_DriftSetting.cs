using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace Excel_Interface
{
    public class GBM_MRO_DriftSetting : GBM_DriftSetting
    {
        public override string value(DateTime dateTime, Excel_instrumentViewModel e_instVM, Excel_underlyingInfoViewModel excel_uivm)
        {
            // 국고 커브를 로드함

            DateTime maturity = e_instVM.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.MaturityDate_;

            Excel_yieldCurveViewModel e_ycvm =
                e_instVM.Excel_parameterViewModel_.ParameterSettingManager_.DiscountCurveParaSetting_.discountCurve(dateTime,"KRW");

            QLNet.YieldTermStructure q_y = e_ycvm.yieldCurve();

            TimeSpan timeSpan = maturity - dateTime;

            double t = timeSpan.TotalDays / 365;

            InterestRate rate = q_y.zeroRate(t, QLNet.Compounding.Compounded);
            
            double drift = rate.value();
            
            return drift.ToString();
        }
    }
}
