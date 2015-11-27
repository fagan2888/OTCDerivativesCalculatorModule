//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;


//namespace RiskMonitor
//{
//    public class CreditDefaultSwapPayoff : PayoffInfo
//    {

//        public CreditDefaultSwapPayoff()
//        { 


//        }

//        public List<ReferenceEntityInfo> ReferenceInfoList_ { get; set;}
//        public IRCalculationPayoff IRRateCalculation_ { get; set;}
//        public ProtectionTerm ProtectionTerm_ { get; set; }

//        protected override void setVM()
//        {
//            this.viewModel_ = new CreditDefaultSwapPayoffViewModel();
//            this.viewModel_.setPayoffInfoVM(this);
//        }

//        public override void buildProductXmlData(XmlWriter xmlWriter)
//        {
//            throw new NotImplementedException();
//        }

//        public override void payoffInfoFromXml(XmlNode InstNode)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
