using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace RiskMonitor
{
    public class CurveSetting
    {
        public Date referenceDate_ { get; set; }
        public DayCounter dayCounter_ { get; set; }

        public CurveSetting() 
        { }

        internal Handle<YieldTermStructure> driftCurve(Underlying item)
        {
            //var flatTermStructure = new Handle<YieldTermStructure>(new FlatForward(today, riskFreeRate, dayCounter));
            //var flatDividendTS = new Handle<YieldTermStructure>(new FlatForward(today, dividendYield, dayCounter));
            //var flatVolTS = new Handle<BlackVolTermStructure>(new BlackConstantVol(today, calendar, volatility, dayCounter));

            throw new NotImplementedException();
        }

        public Handle<YieldTermStructure> dividendCurve(Underlying item)
        {
            double riskFreeRate = 0.06;

            var termStructure = new Handle<YieldTermStructure>(new FlatForward(referenceDate_, riskFreeRate, dayCounter_));
            return termStructure;
        }

        public Handle<BlackVolTermStructure> volCurve(Underlying item)
        {
            throw new NotImplementedException();
        }

        public Handle<BlackVolTermStructure> corrCurve(Underlying item)
        {
            throw new NotImplementedException();
        }

        public QLNet.Matrix corrMatrix(List<Underlying> item)
        {
            //int dimension = item.Count;
            int dimension = 2;

            Matrix corr = new Matrix(dimension,dimension);

            //Data Load & Set

            corr[0,0] = 1;   corr[0,1] = 0.5;
            corr[1,0] = 0.5; corr[1,1] = 1;

            return corr;
        }
    }
}
