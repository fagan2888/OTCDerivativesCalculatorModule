using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class Vega : Greek
    {
        public Vega(double value) 
        {
            this.Value_ = value;
        }


    }
}
