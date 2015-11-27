using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculationSockerServer_CSharp_Win
{
    class CalculationServerProtocol
    {
        private string p;

        public CalculationServerProtocol(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
        public string Type_ { get; set; }
    }
}
