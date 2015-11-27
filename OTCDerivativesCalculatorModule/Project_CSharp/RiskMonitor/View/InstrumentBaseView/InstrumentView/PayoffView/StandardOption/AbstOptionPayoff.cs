//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;

//namespace RiskMonitor
//{
//    public abstract class AbstOptionPayoff : PayoffInfo
//    {
        
//        public DateTime ExpiryDate_ { get; set; }
//        public DateTime DeliveryDate_ { get; set; }

//        public string OptionType_ { get; set; }
//        public double ParityRate_ { get; set; }
//        public double InitialPrice_ { get; set; }

//        protected abstract void setVM();

//        public void buildProductXmlData(XmlWriter xmlWriter)
//        {
//            xmlWriter.WriteStartElement("option");
            
//                xmlWriter.WriteElementString("optionType", OptionType_);
//                xmlWriter.WriteElementString("expiryDate", ExpiryDate_.ToString("yyyy-MM-dd"));
//                xmlWriter.WriteElementString("deliveryDate", DeliveryDate_.ToString("yyyy-MM-dd"));
//                xmlWriter.WriteElementString("initialPrice", InitialPrice_.ToString());

//            xmlWriter.WriteEndElement();
//        }

//        public abstract void payoffInfoFromXml(XmlNode InstNode);
//    }
//}
