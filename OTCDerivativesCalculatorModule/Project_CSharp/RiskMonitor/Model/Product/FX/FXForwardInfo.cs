using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace RiskMonitor
{
    public class FxForwardInfo
    {

        public long Notional_ { get; set; }
        public Date tradeDate_ { get; set; }
        public Date settlementDate_ { get; set; }
        public Date maturityDate_ { get; set; }
        public Date payDate_ { get; set; }

        public double fxForwardRate_ { get; set; }

        public string baseCurrency_ { get; set; }
        public string counterCurrency_ { get; set; }

        



    }
}
