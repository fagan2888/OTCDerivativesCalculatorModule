using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class Gamma : Greek
    {
        public Gamma(double value) 
        {
            this.Value_ = value;
        }

        public double value()
        {
            return Value_;
        }
    }
}
