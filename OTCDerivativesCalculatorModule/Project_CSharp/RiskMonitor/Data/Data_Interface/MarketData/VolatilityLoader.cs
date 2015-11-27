using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class VolatilityLoader
    {
        public ParameterSetting Setting_ { get; set; }

        public VolatilityLoader() 
        {
        
        }

        public VolatilityLoader(ParameterSetting setting) 
        {
            Setting_ = setting;
        }

        public double vol(string code) 
        {
            return 0.0;
        }
    }
}
