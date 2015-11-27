using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class EngineFactory
    {
        public static MCEngine engine(string type) 
        {
            return new MCEngine(0.03, 100);
        }
    }
}
