using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class LossPayoff
    {
        private double power_;
        private double limit_;
        private double maxLoss_;

        public LossPayoff(double power,
                          double limit,
                          double maxLoss) 
        {
            this.power_ = power;
            this.limit_ = limit;
            this.maxLoss_ = maxLoss;

        }

        double value(double x) 
        {
            double y = 0.0;

            y = 1.0 - 1.0 * power_ * Math.Min(maxLoss_, Math.Max(0, limit_ - x));

            return y;
        }



    }
}
