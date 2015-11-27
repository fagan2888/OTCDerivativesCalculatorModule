//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using QLNet;

//namespace RiskMonitor
//{D:\Project File\OTCDerivativesCalculatorModule\Project_CSharp\RiskMonitor\Model\NotUse\BarrierEvent.cs
//    public class BarrierEvent : AbstractEvent
//    {
//        private Exercise exercise_;
//        private double upperBarrier_;

//        public BarrierEvent(Exercise exercise,
//                            double upperBarrier) 
//        : base(exercise.dates()) {
//            this.exercise_ = exercise;
//            this.upperBarrier_ = upperBarrier;

//        }

//        //public void setPosition(TimeGrid timeGrid,
//        //                 DayCounter dayCounter,
//        //                 Calendar calendar) 
//        //{
//        //    position_ = new List<int>();
//        //    Date today = Settings.evaluationDate();
//        //    List<Date> positionDate = exercise_.dates();

//        //    foreach (Date item in positionDate)
//        //    {
//        //        double fraction = dayCounter.yearFraction(today,item);
//        //        position_.Add(timeGrid.closestIndex(fraction));
//        //    }
            
//        //}

//        public bool checkEvent(MultiPath path)
//        {
//            bool occ = false;

//            if (exercise_.type() == Exercise.Type.American)
//            {
//                for (int i = position_[0]; i < position_[1] ; i++)
//                {
//                    for (int j = 0; j < path.assetNumber() ; j++)
//                    {
//                        if (path[j][i] > upperBarrier_)
//                        {

//                            occ = true;
//                        }
//                    }
//                }
//            }
//            else if (exercise_.type() == Exercise.Type.Bermudan)
//            {
//                for (int i = 0; i < position_.Count; i++)
//                {
//                    for (int j = 0; j < path.assetNumber() ; j++)
//                    {
//                        if (path[j][position_[i]] < upperBarrier_)
//                        {
//                            occ = true;
//                        }
//                    }
//                }
//            }

//            return occ ; 
//        }

//        public Date eventOccDate() 
//        {
//            return new Date();
//        }

//        public double eventOccTime()
//        {
//            return 0.0;
//        }

//        public void reset() 
//        {

//        }

//    }
//}
