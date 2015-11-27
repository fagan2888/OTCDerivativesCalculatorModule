using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class QuoteInfo
    {
        private int p;

        public QuoteInfo(int p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
        public DateTime FixingTime_ { get; set; }
        public CodeManager ItemCode_ { get; set; }

    }
}
