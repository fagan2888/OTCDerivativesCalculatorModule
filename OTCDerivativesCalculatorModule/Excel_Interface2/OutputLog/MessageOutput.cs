using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class MessageOutput : IOutput
    {
        public MessageOutput(string message) 
        : base("","",message)
        {
            this.ResultType_ = "Message";
        }
    }
}
