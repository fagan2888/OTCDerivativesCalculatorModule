using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace RiskMonitor
{
    public class CorrelationSetting
    {
        public string filePath_ { get; set; }
        public string fileName_ { get; set; }

        public Matrix correlationMatrix(Date today)
        {
            throw new NotImplementedException();
        }
    }
}
