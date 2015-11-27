//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;
//using System.ComponentModel;
//using System.Collections.ObjectModel;
//using QLNet;

//namespace RiskMonitor
//{
//    public class StandardInstrument : Instrument
//    {
//        //parametor properties

//        //public StepDownKIPayoff StepDownKIPayoff_ { get; set; }
        
//        public InstrumentInformation InstInfo_ { get; set; }
//        public UnderlyingInfo UnderInfo_ { get; set; }
//        public PayoffInfo PayoffInfo_ { get; set; }

//        public StandardInstrument() 
//        {
//            this.viewModel_ = new StandardInstViewModel();
//        }

//        public override void buildProductXmlData(XmlWriter xmlWriter)
//        {
//            xmlWriter.WriteStartElement("instrument");

//            InstInfo_.buildProductXmlData(xmlWriter);
//            UnderInfo_.buildProductXmlData(xmlWriter);
//            PayoffInfo_.buildProductXmlData(xmlWriter);

//            //string redemptionInfo = RedemptionInfo_.buildProductXmlData();
//            //string nonkiEventInfo = NonKIEventInfo_.buildProductXmlData();

//            xmlWriter.WriteEndElement();
//        }

//        public void instrumentFromXml(XmlNode instNode)
//        {
//            this.instInfoFromXml(instNode);
//            this.underInfoFromXml(instNode);
//            this.payoffInfoFromXml(instNode);

//            this.setVM();
//        }

//        //public StepDownKITypeProduct(XmlDocument instXml)
//        //{
//        //    // TODO: Complete member initialization
//        //    //this.instXml_ = instXml;

//        //    this.InstInfo_ = new InstrumentInformation();
//        //    this.UnderInfo_ = new UnderlyingInfo();
//        //    this.PayoffInfo_ = new StepDownKIPayoff();
            
//        //    //file로 load 하는 경우에 
//        //    //this.ResultModel_ = new ResultModel();

//        //    this.loadFromXml(instXml);
//        //    //this.resultFromXml(resultXml);
//        //}

//        //public override void calculate() 
//        //{
//        //    //DateTime referenceDate = 
//        //    //this.buildParametorXmlData();
//        //    //this.buildProductXmlData();

//        //    //string instrumentXml = this.instXml_.InnerXml;

//        //    string result = StepDownCppDLL.calculationLibCall(this.instXml_.InnerXml, this.parametorXml_.InnerXml);

//        //}

//        protected void setVM()
//        {
//            //this.viewModel_ = new StandardInstViewModel();
//            //this.viewModel_.setInstrument(this);
//        }

//        public void calculate()
//        {
//            throw new NotImplementedException();
//        }


//        //public override void resultFromXml(XmlDocument resultparaXml)
//        //{
//        //    DateTime referenceDate = CustomFunction.StrToDate(resultparaXml.SelectSingleNode("pricing/evaluationTime").InnerText);
//        //    string itemCode = resultparaXml.SelectSingleNode("pricing/krcode").InnerText;

//        //    this.ResultModel_.ReferenceDate_ = referenceDate;
//        //    this.ResultModel_.ItemCode_ = itemCode;

//        //    XmlNode resultparaNode = resultparaXml.SelectSingleNode("pricing/pricingResult");

//        //    this.ResultModel_.loadFromXml(resultparaNode);
//        //}

//        //public override void parameterFromXml(XmlDocument resultparaXml)
//        //{
//        //    DateTime referenceDate = CustomFunction.StrToDate(resultparaXml.SelectSingleNode("pricing/evaluationTime").InnerText);
//        //    string itemCode = resultparaXml.SelectSingleNode("pricing/krcode").InnerText;

//        //    this.Parameter_.ReferenceDate_ = referenceDate;
//        //    this.Parameter_.ItemCode_ = itemCode;

//        //    XmlNode resultparaNode = resultparaXml.SelectSingleNode("pricing/pricingParametor");

//        //    this.Parameter_.loadFromXml(resultparaNode);
//        //}


//        //engine으로 드가야하는데 나중에 refactorying.
//        //public string buildParametorXmlData(XmlWriter xmlWriter)
//        //public override void buildParametorXmlData()
//        //{
//        //    this.parametorXml_ = new XmlDocument();

//        //    StringBuilder sb = new StringBuilder();
//        //    XmlWriterSettings setting = new XmlWriterSettings();

//        //    setting.Indent = true;
//        //    //setting.Encoding = Encoding.UTF8;

//        //    XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

//        //    xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");

//        //    this.Parameter_.buildParametorXmlData(xmlWriter);

//        //    xmlWriter.Close();

//        //    parametorXml_.LoadXml(sb.ToString());

//        //}

//        #region Event

//        public event PropertyChangedEventHandler PropertyChanged;

//        private void NotifyPropertyChanged(string propertyName)
//        {
//            if (PropertyChanged != null)
//            {
//                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
//            }
//        }


//        #endregion

//        public void instInfoFromXml(XmlNode node)
//        {
//            XmlNode instInfoNode = node.SelectSingleNode("instrument/issueInformation");
//            string instInfoType = instInfoNode.FirstChild.Name;
//            this.setInstInfo(instInfoType);
//            this.InstInfo_.instInfoFromXml(node);
//        }

//        public void underInfoFromXml(XmlNode node)
//        {
            
//            XmlNode underInfoNode = node.SelectSingleNode("instrument/underlyingInformation");
//            string underInfoType = "UNDERLYING";
//            this.setUnderInfo(underInfoType);
            
//            this.UnderInfo_.underInfoFromXml(underInfoNode);
//        }
//        public void payoffInfoFromXml(XmlNode node)
//        {
//            XmlNode payoffInfoNode = node.SelectSingleNode("instrument/ELSStepDownRedemptions");
//            string payoffInfoType = "STEPDOWNKI";
//            this.setPayoffInfo(payoffInfoType);
//            this.PayoffInfo_.payoffInfoFromXml(payoffInfoNode);
//        }

//        public void setInstInfo(string instInfoType)
//        {
//            if (instInfoType.ToUpper() == "SECURITIES")
//            {
//                this.InstInfo_ = new NoteInformation();
//            }
//            else if (instInfoType.ToUpper() == "SWAPINFORMATION")
//            {
//                this.InstInfo_ = new SwapInformation();
//            }
//            else
//            {
//                throw new NotImplementedException();
//            }
//        }

//        public void setUnderInfo(string underInfoType)
//        {

//            if (underInfoType.ToUpper() == "UNDERLYING")
//            {
//                this.UnderInfo_ = new UnderlyingInfo(this.InstInfo_.KRCode_);
//            }
//            else
//            {
//                throw new NotImplementedException();
//            }
//        }

//        public void setPayoffInfo(string payoffInfoType)
//        {
//            if (payoffInfoType.ToUpper() == "STEPDOWNKI")
//            {
//                this.PayoffInfo_ = new StepDownKIPayoff();
//            }
//            else
//            {
//                throw new NotImplementedException();
//            }
//        }
//    }
//}
