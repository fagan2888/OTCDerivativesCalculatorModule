using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace Excel_Interface
{
    public abstract class GBM_DriftSetting
    {
        public abstract string value(DateTime dateTime, Excel_instrumentViewModel e_instVM, Excel_underlyingInfoViewModel excel_uivm);
    }
}
