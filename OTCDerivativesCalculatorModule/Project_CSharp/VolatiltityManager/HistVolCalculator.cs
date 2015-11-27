using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VolatiltityManager
{
    public class HistVolCalculator : VolCalculater
    {
        public enum MethodType { HISTORYCAL }

        public MethodType MethodType_ { get; set; }

        public int CalculationInterval { get; set; }
    }
}
