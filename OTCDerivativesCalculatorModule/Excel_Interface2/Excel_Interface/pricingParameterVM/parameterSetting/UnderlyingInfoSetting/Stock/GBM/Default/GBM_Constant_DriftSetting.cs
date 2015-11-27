using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace Excel_Interface
{
    public class GBM_Const_DriftSetting : GBM_DriftSetting
    {
        private string constDrift_;

        public GBM_Const_DriftSetting()
        {
            this.constDrift_ = "0.03";
        }

        public GBM_Const_DriftSetting(string constDrift)
        {
            this.constDrift_ = constDrift;
        }

        public override string value(DateTime dateTime, Excel_instrumentViewModel e_instVM, Excel_underlyingInfoViewModel excel_uivm)
        {
            return this.constDrift_;
        }
    }
}
