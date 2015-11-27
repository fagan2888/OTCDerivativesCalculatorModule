using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace testConsoleQNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendar calendar = new TARGET();

            Date todaysDate = new Date(22, 7, 2014);
            Date settlementDate = new Date(3, 6, 2014);
            Settings.setEvaluationDate(todaysDate);

            DayCounter dayCounter = new Actual365Fixed();
            double dividendYield = 0.0117;
            double volatility = 0.15517;

            Barrier.Type type = Barrier.Type.UpOut;
            QLNet.PlainVanillaPayoff payoff = new PlainVanillaPayoff(Option.Type.Call,261.4);
            QLNet.EuropeanExercise ex = new EuropeanExercise(new Date(30,11,2015));

            //QLNet.BarrierOption barrierOption = new BarrierOption(type, 1.2,1.0, 0.0, payoff, ex);
            //QLNet.BarrierOption barrierOption = new BarrierOption(type, 313.68, 0.0, payoff, ex);
            QLNet.BarrierOption barrierOption = new BarrierOption(type, 313.68, 0.32,0.0, payoff, ex);

            double underlying = 262.86;
            double riskFreeRate = 0.0243;
            
            Handle<Quote> underlyingH = new Handle<Quote>(new SimpleQuote(underlying));

            // bootstrap the yield/dividend/vol curves
            var flatTermStructure = new Handle<YieldTermStructure>(new FlatForward(settlementDate, riskFreeRate, dayCounter));
            var flatDividendTS = new Handle<YieldTermStructure>(new FlatForward(settlementDate, dividendYield, dayCounter));
            var flatVolTS = new Handle<BlackVolTermStructure>(new BlackConstantVol(settlementDate, calendar, volatility, dayCounter));
            var bsmProcess = new BlackScholesMertonProcess(underlyingH, flatDividendTS, flatTermStructure, flatVolTS);

            QLNet.AnalyticBarrierWithPartiRateEngine engine = new AnalyticBarrierWithPartiRateEngine(bsmProcess);
            barrierOption.setPricingEngine(engine);

            double kk = barrierOption.NPV();

            Console.WriteLine(kk);
            Console.WriteLine(kk / 261.4);
        }
    }
}
