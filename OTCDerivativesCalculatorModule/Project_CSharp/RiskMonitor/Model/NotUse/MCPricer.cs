using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace RiskMonitor
{
    public abstract class MCPricer : ViewCtrl , PathPricer<MultiPath> 
    {
        public YieldTermStructure discountTS_ { get; set; }

        public List<double> discountFactor_;

        protected int assetNumber_ { get; set; }

        public int assetNumber()
        {
            return this.assetNumber_;
        }

        abstract public void setPosition(TimeGrid timeGrid,
                                      DayCounter dayCounter,
                                      Calendar calendar);

        abstract public double value(MultiPath path);

        
    }
}
