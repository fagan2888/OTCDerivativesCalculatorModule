//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;
//using QLNet;

//namespace RiskMonitor
//{
//    public abstract class InstrumentInformation 
//    {
//        //#region ViewModel_
//        //protected InstrumentInformationViewModel viewModel_;
//        //public InstrumentInformationViewModel ViewModel_
//        //{
//        //    get
//        //    {
//        //        this.setVM();

//        //        if (this is NoteInformation)
//        //        {
//        //            throw new NotImplementedException();
//        //        }

//        //        viewModel_.setInstInfo(this);

//        //        return this.viewModel_;
//        //    }


//        //}
//        //#endregion

//        #region ViewModel_
//        protected InstrumentInformationViewModel viewModel_;
//        public InstrumentInformationViewModel ViewModel_
//        {
//            get { return this.viewModel_; }
//            set
//            {
//                if (this.viewModel_ != value)
//                {
//                    this.viewModel_ = value;
//                    //this.NotifyPropertyChanged("ViewModel_");
//                }
//            }
//        }
//        #endregion

//        public InstrumentInformation() 
//        {
        
//        }

//        //public InstrumentInformation(string productName, 
//        //                            string productType,
//        //                            string KRCode, 
//        //                            DateTime tradeDate, 
//        //                            DateTime effectiveDate, 
//        //                            DateTime maturityDate,
//        //                            long notional)
            
//        //{
//        //    // TODO: Complete member initialization
//        //    this.Notional_ = notional;
//        //    this.ProductName_ = productName;
//        //    this.ProductType_ = productType;
//        //    this.KRCode_ = KRCode;
//        //    this.TradeDate_ = tradeDate;
//        //    this.EffectiveDate_ = effectiveDate;
//        //    this.MaturityDate_ = maturityDate;

//        //}

//        #region HeaderInfo

//        public long Notional_ { get; set; }
//        public string ProductName_ { get; set; }
//        public string ProductType_ { get; set; }
//        public string KRCode_ { get; set; }
        
//        #endregion

//        public virtual void error()
//        {
//            this.ProductName_ = "_Error_";
//            this.ProductType_ = "_Error_";
//        }

//        public virtual void buildParametorXmlData(XmlWriter xmlWriter, ParameterSetting parameterSetting)
//        {
//            //xmlWriter.WriteStartElement("notional");
//            //xmlWriter.WriteValue(this.Notional_);
//            //xmlWriter.WriteEndElement();
//        }

//        public abstract void instInfoFromXml(XmlNode instNode);
//        public abstract void buildProductXmlData(XmlWriter xmlWriter);


//        public void headerFromXml(XmlNode instNode)
//        {
//            XmlNode issueInfoNode = instNode.SelectSingleNode("instrument/header");

//            this.ProductName_ = issueInfoNode["productName"].InnerText;
//            this.ProductType_ = issueInfoNode["productType"].InnerText;
//            this.KRCode_ = issueInfoNode["krCode"].InnerText;
//        }

//        //public virtual void buildProductXmlData(XmlWriter xmlWriter)
//        //{

//        //    xmlWriter.WriteStartElement("issueInformation");
//        //        xmlWriter.WriteElementString("productName", ProductName_);
//        //        xmlWriter.WriteElementString("productType", ProductType_);
//        //        xmlWriter.WriteElementString("krCode", KRCode_);
//        //        xmlWriter.WriteElementString("tradeDate", TradeDate_.ToString("yyyy-MM-dd"));
//        //        xmlWriter.WriteElementString("effectiveDate", EffectiveDate_.ToString("yyyy-MM-dd"));
//        //        xmlWriter.WriteElementString("maturityDate", MaturityDate_.ToString("yyyy-MM-dd"));
//        //        xmlWriter.WriteElementString("notional", Convert.ToString(Notional_));
//        //    xmlWriter.WriteEndElement();

//        //}

//        //public virtual void loadFromXml(XmlNode node)
//        //{
//        //    XmlNode issueInfoNode = node.SelectSingleNode("issueInformation");

//        //    this.ProductName_ = issueInfoNode["productName"].InnerText;
//        //    this.ProductType_ = issueInfoNode["productType"].InnerText;
//        //    //this.InstrumentID_ = issueInfoNode["instrumentID"].ToString();
//        //    this.KRCode_ = issueInfoNode["krCode"].InnerText;
//        //    this.TradeDate_ = CustomFunction.StrToDate(issueInfoNode["tradeDate"].InnerText);
//        //    this.EffectiveDate_ = CustomFunction.StrToDate(issueInfoNode["effectiveDate"].InnerText);
//        //    this.MaturityDate_ = CustomFunction.StrToDate(issueInfoNode["maturityDate"].InnerText);
//        //    this.Notional_ = Convert.ToInt64(issueInfoNode["notional"].InnerText);

//        //}


//        //public void buildProductXmlData()
//        //{

//        //XmlWriter xmlWriter = XmlWriter.Create("stepdown_para_20130624.xml");

//        //InterestRateCurveLoader curveLoader = new InterestRateCurveLoader();

//        //CorrelationLoader corrLoader = new CorrelationLoader();

//        //this.Corr_ = corrLoader.corr();

//        //xmlWriter.WriteStartElement("pricingParametor");

//        //xmlWriter.WriteStartElement("notional");
//        //xmlWriter.WriteValue(this.InstInfo_.Notional_);
//        //xmlWriter.WriteEndElement();

//        //UnderInfo_.buildParametorXmlData(xmlWriter, ParameterSetting_);

//        //xmlWriter.WriteStartElement("method");
//        //xmlWriter.WriteValue(this.Method_);
//        //xmlWriter.WriteEndElement();
//        //xmlWriter.WriteStartElement("corr");
//        //xmlWriter.WriteValue(this.Corr_);
//        //xmlWriter.WriteEndElement();
//        //xmlWriter.WriteStartElement("simulationNum");
//        //xmlWriter.WriteValue(this.SimulationNum_);
//        //xmlWriter.WriteEndElement();
//        //xmlWriter.WriteStartElement("dicountFlatTS");
//        //xmlWriter.WriteValue(this.DiscountFlatTS_);
//        //xmlWriter.WriteEndElement();

//        //xmlWriter.WriteEndElement();

//        //    return "";


//        //}







//    }
//}
