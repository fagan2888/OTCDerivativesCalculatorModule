//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;

//namespace RiskMonitor
//{
//    public class NoteInformation : InstrumentInformation
//    {
//        public NoteInformation() { }

//        //public NoteInformation(string productName,
//        //                            string productType,
//        //                            string KRCode,
//        //                            DateTime tradeDate,
//        //                            DateTime effectiveDate,
//        //                            DateTime maturityDate,
//        //                            long notional,
//        //                            //string currency, 
//        //                            long premium)
//        //                            //string premiumCurrency
//        //: base(productName,productType,KRCode,tradeDate,effectiveDate,maturityDate,notional)
//        //{
            
//        //    //this.Currency_ = currency;
//        //    this.Premium_ = premium;
//        //    //this.PremiumCurrency_ = premiumCurrency;
//        //}


//        public DateTime TradeDate_ { get; set; }
//        public DateTime EffectiveDate_ { get; set; }
//        public DateTime MaturityDate_ { get; set; }
//        public string Currency_ { get; set; }
//        public long Premium_ { get; set; }
//        public string PremiumCurrency_ { get; set; }

//        public override void buildProductXmlData(XmlWriter xmlWriter)
//        {
//            //base.buildProductXmlData(xmlWriter);

//            xmlWriter.WriteStartElement("issueInformation");
                
//                xmlWriter.WriteElementString("premium", "0");
//            xmlWriter.WriteEndElement();
//        }

//        public override void buildParametorXmlData(XmlWriter xmlWriter, ParameterSetting ParameterSetting_)
//        {
//            xmlWriter.WriteStartElement("issueInformation");
//                xmlWriter.WriteElementString("productName", ProductName_);
//                xmlWriter.WriteElementString("productType", ProductType_);
//                xmlWriter.WriteElementString("krCode", KRCode_);
//                xmlWriter.WriteElementString("tradeDate", TradeDate_.ToString("yyyy-MM-dd"));
//                xmlWriter.WriteElementString("effectiveDate", EffectiveDate_.ToString("yyyy-MM-dd"));
//                xmlWriter.WriteElementString("maturityDate", MaturityDate_.ToString("yyyy-MM-dd"));
//                xmlWriter.WriteElementString("notional", Convert.ToString(Notional_));
//            xmlWriter.WriteEndElement();
//        }

//        //public override void loadFromXml(System.Xml.XmlNode node)
//        //{
//        //    base.loadFromXml(node);

//        //    XmlNode issueInfoNode = node.SelectSingleNode("issueInformation");

//        //    this.Premium_ = Convert.ToInt64(issueInfoNode["premium"].InnerText);
//        //}

//        public override void error()
//        {
//            base.error();
//        }

//        public override void instInfoFromXml(XmlNode instNode)
//        {
//            base.headerFromXml(instNode);

//            XmlNode issueInfoNode = instNode.SelectSingleNode("instrument/issueInformation/securities");

//            this.TradeDate_ = CustomFunction.StrToDate(issueInfoNode["tradeDate"].InnerText);
//            this.EffectiveDate_ = CustomFunction.StrToDate(issueInfoNode["effectiveDate"].InnerText);
//            this.MaturityDate_ = CustomFunction.StrToDate(issueInfoNode["maturityDate"].InnerText);
//            this.Notional_ = Convert.ToInt64(issueInfoNode["notional"].InnerText);

//            this.setVM();
//        }
//    }
//}
