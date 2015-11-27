using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class GBM_Const_VolatilitySetting : GBM_VolatilitySetting
    {
        private string constVol_;

        public GBM_Const_VolatilitySetting()
        {
            this.constVol_ = "0.31";
        }

        public GBM_Const_VolatilitySetting(string constVol)
        {
            // TODO: Complete member initialization
            this.constVol_ = constVol;
        }
        public override string value(DateTime dateTime, Excel_instrumentViewModel e_instVM, Excel_underlyingInfoViewModel excel_uivm)
        {
            return constVol_;
        }
    }
}
