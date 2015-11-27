using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class GBM_Const_DividendSetting : GBM_DividendSetting
    {
        private string constDiv_;

        public GBM_Const_DividendSetting()
        {
            this.constDiv_ = "0.011";
        }

        public GBM_Const_DividendSetting(string constDiv)
        {
            this.constDiv_ = constDiv;
        }


        public override string value(DateTime dateTime, Excel_instrumentViewModel excel_instrumentViewModel, Excel_underlyingInfoViewModel excel_uivm)
        {
            return this.constDiv_;
        }
    }
}
