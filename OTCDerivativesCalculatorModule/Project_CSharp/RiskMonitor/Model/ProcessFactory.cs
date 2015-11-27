using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace RiskMonitor
{
    class ProcessFactory
    {

        public enum ProcessType { GemetricBrownianMotion, BlackScholesMertonProcess, HullWhite, Vasicek }

        // ProcessArr 생성용 //외부사용함.
        public static StochasticProcessArray buildProcess(UnderlyingInfo underInfo)
        {
            Date today = Settings.evaluationDate();

            List<Handle<Quote>> underlyingH = new List<Handle<Quote>>(); 

            // bootstrap the yield/dividend/vol curves

            CorrelationSetting corrSetting = new CorrelationSetting();

            List<Underlying> underlyings = underInfo.underlyings();

            Matrix CorrMatrix = corrSetting.correlationMatrix(today);

            List<StochasticProcess1D> process1DList = new List<StochasticProcess1D>();

            for (int i = 0; i < underlyings.Count ; i++)
            {
                process1DList.Add(ProcessFactory.buildProcess1D(underlyings[i]));
                
            }

            StochasticProcessArray processArr = new StochasticProcessArray(process1DList, CorrMatrix);

            return processArr;

        }


        // Process1D 생성용 //내부사용함.
        private static StochasticProcess1D buildProcess1D(Underlying under) 
        {
            Date today = Settings.evaluationDate();

            CurveSetting curveSetting = new CurveSetting();
            ProcessSetting processSetting = new ProcessSetting();

            ProcessType proType = processSetting.processType(under);

            StochasticProcess1D process;

            if (proType == ProcessType.BlackScholesMertonProcess)
            {
                Handle<Quote> quite = new Handle<Quote>();//under.quoteValue(today);

                Handle<YieldTermStructure> driftTS = curveSetting.driftCurve(under);
                Handle<YieldTermStructure> dividendTS = curveSetting.dividendCurve(under);
                Handle<BlackVolTermStructure> volTS = curveSetting.volCurve(under);

                process = new BlackScholesMertonProcess(quite,driftTS,dividendTS,volTS);
            }
            else if (proType == ProcessType.GemetricBrownianMotion)
            {
                throw new NotImplementedException();
            }
            else if ( proType == ProcessType.HullWhite )
            {
                throw new NotImplementedException();
            }
            else if (proType == ProcessType.Vasicek)
            {
                throw new NotImplementedException();
            }
            else 
            {
                throw new NotImplementedException();
            }

            return process;

        }

    }
}
