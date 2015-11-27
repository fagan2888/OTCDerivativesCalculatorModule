//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using QLNet;

//namespace RiskMonitor
//{
//    public class BarrierEventPricer : MCPricer
//    {
//        public enum PayoffDeliveryType { Expiry = -1, Event = 1 }

//        private PathMultiPayoff barrierPayoff_;
//        private PathMultiPayoff nonBarrierPayoff_;
//        private BarrierEvent barrierEvent_;
//        private PayoffDeliveryType deliveryType_;

//        public BarrierEventPricer(
//                                //Option.Type type, 
//                                  BarrierEvent barrierEvent,
//                                  PathMultiPayoff barrierPayoff,
//                                  PathMultiPayoff nonBarrierPayoff,
//                                  PayoffDeliveryType deliveryType) 
//        {
//            this.barrierEvent_ = barrierEvent;
//            this.barrierPayoff_ = barrierPayoff;
//            this.nonBarrierPayoff_ = nonBarrierPayoff;
//            this.deliveryType_ = deliveryType;
//        }

//        override public void setPosition(TimeGrid timeGrid,
//                                  DayCounter dayCounter,
//                                  Calendar calendar) 
//        {
//            this.barrierEvent_.setPosition(timeGrid, dayCounter, calendar);
//        }

//        override public double value(MultiPath path) 
//        {

//            bool eventOcc = barrierEvent_.checkEvent(path);
//            double payoffValue = 0.0;

//            if (eventOcc)
//            {
//                payoffValue = barrierPayoff_.value(path);
//            }
//            else 
//            {
//                payoffValue = nonBarrierPayoff_.value(path);
//            }

//            double discountFactor = discountTS_.discount(barrierEvent_.eventOccTime());

//            return payoffValue * discountFactor;

//        }

 

        
//    }
//}
