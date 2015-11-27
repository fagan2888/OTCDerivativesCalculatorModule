using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class Error : Exception
    {
        private string errText_;

        public Error(string errText)
        : base(errText)
        {
            this.errText_ = errText;
        }


    }
}
