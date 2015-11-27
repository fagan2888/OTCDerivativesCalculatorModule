//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace RiskMonitor
//{
//    public class ConstractViewModel
//    {
//        public ConstractViewModel() 
//        {
//            this.UnitPrice_ = 1.112;
//            this.InstName_ = "Test";
//            this.ItemCode_ = "KRTestCode";

//            this.CalculateFlag_ = true;
//            this.ReferenceDate_ = DateTime.Now;
//        }

//        public DateTime StartTime_ { get; set; }
//        public DateTime EndTime_ { get; set; }
//        public DateTime ReferenceDate_ { get; set; }

//        public bool CalculateFlag_ { get; set; }

//        public double UnitPrice_ { get; set; }
//        public string InstName_ { get; set; }
//        public string ItemCode_ { get; set; }


//        public void calculate() 
//        {
//            this.StartTime_ = DateTime.Now;

//            this.InstrumentBase_.calculate();

//            this.EndTime_ = DateTime.Now;
            


//        }


//    }
//}
