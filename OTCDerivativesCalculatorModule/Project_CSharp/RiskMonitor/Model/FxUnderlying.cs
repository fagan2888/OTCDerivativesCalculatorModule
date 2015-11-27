using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace RiskMonitor
{
    public enum CurrencyType { KRW , USD , EUR , AUD , JPY };

    public class FxUnderlying : Underlying
    {
        public Date referenceDate_ { get; set; }
        public double spotRate_ { get; set; }

        public CurrencyType baseCurrency_ { get; set; }
        public CurrencyType counterCurrency_ { get; set; }
        public YieldTermStructure baseCurrencyTS_ { get; set; }
        public YieldTermStructure counterCurrencyTS_ { get; set; }
        //public FxTermStructure fxForwardTS_ { get; set; }

        public FxUnderlying(CurrencyType baseCurrency,
                            YieldTermStructure baseCurrencyTS,
                            CurrencyType counterCurrency,
                            YieldTermStructure counterCurrencyTS,
                            double spotRate)
        {
            this.baseCurrency_ = baseCurrency;
            this.counterCurrency_ = counterCurrency;
            this.baseCurrencyTS_ = baseCurrencyTS;
            this.counterCurrencyTS_ = counterCurrencyTS;
            this.spotRate_ = spotRate;
        }


    }
}
