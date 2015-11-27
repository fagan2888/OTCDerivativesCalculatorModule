using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public abstract class StockParaSetting
    {
        public abstract Excel_underlyingModel_paraViewModel underModel(Excel_underlyingInfoViewModel excel_uivm,
                                                                       Excel_instrumentViewModel excel_instrumentViewModel,
                                                                       DateTime dateTime);
    }
}
