using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace RiskMonitor
{
    public class StandardOptionPricer : MCPricer  
    {
        private List<Date> cashFlowDates_;
        private List<PathMultiPayoff> payoffs_;
        private List<EventDomain> domains_;

        private int payoffNum_;

        public StandardOptionPricer() { }

        public StandardOptionPricer(List<Date> cashFlowDates,
                                  List<PathMultiPayoff> payoffs,
                                  List<EventDomain> domain)
        {
            this.cashFlowDates_ = cashFlowDates;
            this.payoffs_ = payoffs;
            this.domains_ = domain;

            payoffNum_ = cashFlowDates_.Count;
        }

        override public void setPosition(TimeGrid timeGrid,
                                  DayCounter dayCounter,
                                  Calendar calendar) 
        {
        
        }

        override public double value(MultiPath path) 
        {
            double val = 0.0;

            //int assetNum = path.assetNumber();
            
            //for (int i = 0; i < payoffNum_; i++)
            //{
            //    int position = cashFlowPosition_[i];

            //    for (int j = 0; i < assetNum; j++)
            //    {
            //        pathValue_[j] = path[j][i];
            //    }
             
            //    if( domains_[i].eventOcc(pathValue_) )
            //    {
            //        val = val + payoffs_[i].value(path) * discountFactor_[i];
            //    }
            //}


            return val;

        }

        
        
    }
}
