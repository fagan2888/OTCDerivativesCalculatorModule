//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace RiskMonitor
//{
//    public class VanillaOptionPayoff : AbstOptionPayoff
//    {
//        // Call , Put
//        public string CPType_ { get; set; }
//        public double Strike_ { get; set; }

//        protected override void setVM()
//        {
//            this.viewModel_ = new VanillaOptionPayoffViewModel();
//            this.viewModel_.setPayoffInfoVM(this);
//        }

//        public override void buildProductXmlData(System.Xml.XmlWriter xmlWriter)
//        {
//            throw new NotImplementedException();
//        }

//        public override void payoffInfoFromXml(System.Xml.XmlNode InstNode)
//        {
//            // 넘길게 없음?
//        }
//    }
//}
