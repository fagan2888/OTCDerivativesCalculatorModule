using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace RiskMonitor
{
    public class CppLibStepDownKITypeMCEngine
    {
        public CppLibStepDownKITypeMCEngine(YieldTermStructure disCountTS,
                                            int simulNum)
        {
        
        }

        public UnderlyingInfo UnderInfo_ { get; set; }

        public void buildPricingParameter() 
        {
            string krcode = UnderInfo_[0].KRCode_;
            string underName = UnderInfo_[0].Name_;
            //long currentValue = UnderInfo_[0].value(this.ReferenceDate_);
            //double drift = 

        }

        public void loadPricingResultXml()
        {
        
        }

    }
}
