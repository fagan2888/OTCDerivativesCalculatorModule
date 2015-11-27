using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    interface IMarketDataLoad
    {
        void marketDataLoad(DateTime ReferenceDate);
    }
}
