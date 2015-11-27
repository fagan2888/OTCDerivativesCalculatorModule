using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class HullWhite_Const_SigmaSetting : HullWhite_SigmaSetting
    {
        private string constSigma_;

        public HullWhite_Const_SigmaSetting(string constSigma)
        {
            // TODO: Complete member initialization
            this.constSigma_ = constSigma;
        }
        public override string value(DateTime dateTime, Excel_instrumentViewModel excel_instrumentViewModel, Excel_underlyingInfoViewModel excel_uivm)
        {
            return constSigma_;
        }
    }
}
