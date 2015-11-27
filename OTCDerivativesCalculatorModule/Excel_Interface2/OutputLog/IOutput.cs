using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Documents;

namespace Excel_Interface
{
    public abstract class IOutput
    {
        public IOutput(string instName,string itemCode, string outputStr) 
        {
            this.InstName_ = instName;
            this.ItemCode_ = itemCode;
            this.OutputStr_ = outputStr;
            this.OccurrenceTime_ = DateTime.Now;
            //this.OccurrenceTimeStr_ = this.OccurrenceTime_.ToString("HH:mm:ss:ff");
            this.OccurrenceTimeStr_ = this.OccurrenceTime_.ToString("HH:mm:ss");
        }

        public string OutputStr_ { get; set; }

        public string InstName_ { get; set; }
        public string ItemCode_ { get; set; }
        public string ResultType_ { get; set; }
        public DateTime OccurrenceTime_ { get; set; }
        public string OccurrenceTimeStr_ { get; set; }
        

    }
}
