//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;

//namespace RiskMonitor
//{
//    public class BarrierOptionPayoff : AbstOptionPayoff
//    {
//        //Call , Put
//        public string CPType_ { get; set; }
//        public double Strike_ { get; set; }

//        //In , Out
//        public string BarrierType_ { get; set; }
//        public double Barrier_ { get; set; }

//        public double HitRebate_ { get; set; }

//        protected override void setVM()
//        {
//            this.viewModel_ = new BarrierOptionPayoffViewModel();
//            this.viewModel_.setPayoffInfoVM(this);
//        }

//        public override void buildProductXmlData(XmlWriter xmlWriter)
//        {
//            base.buildProductXmlData(xmlWriter);
            
//            xmlWriter.WriteElementString("cpType", CPType_);
//            xmlWriter.WriteElementString("barrier", Barrier_.ToString());
//            xmlWriter.WriteElementString("strike", Strike_.ToString());
//            xmlWriter.WriteElementString("rebate", HitRebate_.ToString());
            
//        }

//        public override void payoffInfoFromXml(XmlNode InstNode)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
