using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class VolCalculator
    {
        public string SortType { get; set; }

        public List<double> ValueList_ { get; set; }

        public List<double> ReturnValueList_ { get; protected set; }

        public double VOL_ { get; protected set; }

        public static VolCalculator CreateCalculator(string method)
        {
            return new HistoryVolCalculator();
        }
    }
}
