using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class StopLossTypeProduct // : MCInstrument
    {
        public StopLossTypeProduct(StopLossInformation instInfo, 
                                    //UnderlyingInfo underInfo,
                                    //StopEventPricer pricer,
                                    MCEngine mcEngine)
           // : base(instInfo.InstInfo_, underInfo, pricer, mcEngine)
        {
            //this.underInfo_ = underInfo;
            //this.pricer_ = pricer;
            this.mcEngine_ = mcEngine;
        }

        public MCEngine mcEngine_ { get; set; }
    }
}
