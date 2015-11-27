using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class HullWhite_FittingCurveSetting
    {
        protected Excel_interpolationViewModel Excel_interpolationViewModel_
            = new Excel_interpolationViewModel();

        public abstract Excel_yieldCurveViewModel value(DateTime dateTime, Excel_instrumentViewModel e_instVM, Excel_underlyingInfoViewModel excel_uivm);
    }
}
