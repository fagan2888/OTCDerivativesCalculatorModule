using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace RiskMonitor
{
    public class FxForwardEngine
    {
        public FxForwardEngine() 
        {
        
        }

        public DayCounter dayCounter { get; set; }
        public Calendar calendar { get; set; }

        public YieldTermStructure disCountTS_ { get; set; }

    }

    
}
