using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace RiskMonitor
{
    public class FXForward
    {
        public double unitValue_ { get; private set; }
        public long Value_ { get; private set; }

        private FxForwardInfo instInfo_;
        private FxUnderlying under_;
        //private FxForwardPricer pricer_;
        private FxForwardEngine engine_;

        public FXForward(FxForwardInfo instInfo,
                         FxUnderlying fxUnder,
                         FxForwardEngine engine) 
        {
            this.instInfo_ = instInfo;
            this.under_ = fxUnder;
            //this.pricer_ = pricer;
            this.engine_ = engine;
        }

        public void calculate() 
        {
            FxTermStructure fxForwardTS = under_.fxForwardTS_;
            YieldTermStructure discountTS = engine_.disCountTS_;

            double tradedForward = instInfo_.fxForwardRate_;
            double marketForward = fxForwardTS.forwardRate(instInfo_.maturityDate_);

            unitValue_ = (tradedForward - marketForward) * discountTS.discount(instInfo_.payDate_);

            this.Value_ = Convert.ToInt64(unitValue_) * instInfo_.Notional_;

        }

        protected void setting() 
        {
            
        }



    }
}
