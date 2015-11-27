using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class ProcessOutput : IOutput
    {
        public string ProcessCode_ { get; set; }

        public ProcessOutput(string instName, 
                             string itemCode, 
                             string outputStr)
        : base(instName, itemCode, outputStr)
        {
            this.ResultType_ = "Process";
        }
    }
}
