using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class ErrorOutput : IOutput
    {
        public string ErrorCode_ { get; set; }

        public ErrorOutput(string instName, string itemCode, string outputStr)
        : base(instName, itemCode, outputStr)
        {
            this.ResultType_ = "Error";
        }
    }
}
