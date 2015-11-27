using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public abstract class HullWhite_SigmaSetting
    {
        public abstract string value(DateTime dateTime, Excel_instrumentViewModel excel_instrumentViewModel, Excel_underlyingInfoViewModel excel_uivm);
    }
}
