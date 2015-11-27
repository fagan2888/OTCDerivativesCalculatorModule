using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace RiskMonitor
{
    public class MCEngine
    {
        public Date settlementDate { get; set; }
        public Date maturity { get; set; }
        public DayCounter dayCounter { get; set; }
        public Calendar calendar { get; set; }

        public YieldTermStructure disCountTS_ { get; set; }

        //DayCounter dayCounter = new Actual365Fixed();
        //Calendar calendar = new TARGET();

        private int simulationNumber_;
        private StochasticProcessArray processArr_;
        private MultiPathGenerator<IRNG> pathGenerator_;

        //Constructor
        public MCEngine(YieldTermStructure disCountTS,
                        int simulationNumber) 
        {
            this.disCountTS_ = disCountTS;
            this.simulationNumber_ = simulationNumber;
        }

        public MCEngine(double disCountTS,
                        int simulationNumber)
        {
            this.disCountTS_ = new YieldTermStructure();
            this.simulationNumber_ = simulationNumber;
        }


        public int simulationNumber() { return this.simulationNumber_; }

        public void setUnderlying(UnderlyingInfo under)
        {
            this.processArr_ = ProcessFactory.buildProcess(under);
            this.pathGenerator(under);
        }

        private void pathGenerator(UnderlyingInfo under)
        {
            ulong seed = 1;
            int timeSteps = 365;
            //
            int dimensions = this.processArr_.factors();

            double t = processArr_.time(maturity);

            TimeGrid grid = new TimeGrid(t, timeSteps);

            IRNG rndGenerator = (IRNG)new PseudoRandom().make_sequence_generator(dimensions * (grid.size() - 1), seed);

            this.pathGenerator_ = new MultiPathGenerator<IRNG>(this.processArr_, grid, rndGenerator, false);

        }

        #region GetPath

        public MultiPath multiPath() 
        {
            return new MultiPath();
        }

        public MultiPath multiPathDsPlus(int j)
        {
            throw new NotImplementedException();
        }

        public MultiPath multiPathDsMinus(int j)
        {
            throw new NotImplementedException();
        }

        public MultiPath multiPathDvolPlus(int j)
        {
            throw new NotImplementedException();
        }

        public MultiPath multiPathDvolMinus(int j)
        {
            throw new NotImplementedException();
        }

        public MultiPath multiPathDtPlus()
        {
            throw new NotImplementedException();
        }

        #endregion


    }
}
