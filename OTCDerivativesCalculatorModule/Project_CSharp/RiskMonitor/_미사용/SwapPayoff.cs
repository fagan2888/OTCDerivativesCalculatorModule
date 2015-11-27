//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;

//namespace RiskMonitor
//{
//    public partial class SwapPayoff 
//    {

//        public List<SwapStream> SwapStreamList_ { get; set; }

//        //protected void setVM()
//        //{
//        //    this.viewModel_ = new SwapPayoffViewModel();
//        //    this.viewModel_.setPayoffInfoVM(this);
//        //}

//        public void buildProductXmlData(System.Xml.XmlWriter xmlWriter)
//        {
//            throw new NotImplementedException();
//        }

//        public void payoffInfoFromXml(XmlNode InstNode)
//        {
//            SwapPayoff swapPayoff = new SwapPayoff(InstNode);

//            foreach (var item in  swapPayoff.SwapStream_)
//            {
//                SwapStream swapStream = new SwapStream();
//                swapStream.payoffInfoFromXml(item.Node_);
//            }

//        }
//    }
//}
