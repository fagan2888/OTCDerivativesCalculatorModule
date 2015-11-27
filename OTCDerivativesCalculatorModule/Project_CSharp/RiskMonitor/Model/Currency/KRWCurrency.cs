using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class KRWCurrency : CalculationAmount
    {
        public KRWCurrency(double value)
        : base("KRW", value) 
        {
        }
    }
}
