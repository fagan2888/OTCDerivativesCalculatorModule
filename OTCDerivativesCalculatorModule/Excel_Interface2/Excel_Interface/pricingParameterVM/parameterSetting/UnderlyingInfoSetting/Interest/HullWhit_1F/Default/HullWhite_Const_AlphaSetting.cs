using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class HullWhite_Const_AlphaSetting : HullWhite_AlphaSetting
    {
        private string constAlpha_;

        public HullWhite_Const_AlphaSetting(string constAlpha)
        {
            // TODO: Complete member initialization
            this.constAlpha_ = constAlpha;
        }

        public override string value(DateTime dateTime, Excel_instrumentViewModel excel_instrumentViewModel, Excel_underlyingInfoViewModel excel_uivm)
        {
            return this.constAlpha_;
        }
    }
}
