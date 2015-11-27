//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;

//namespace RiskMonitor
//{
//    public class StepDownKIParameter : Parameter
//    {
//        public double DiscountValue_ { get; set; }
//        public long Notional_ { get; set; }

//        //로드가된 것들을 이용함
//        public StandardInstrument Inst_ { get; set; }

//        public UnderlyingParameterInfo UnderlyingParameterInfo_ { get; set; }

//        public StepDownKIParameter(string itemCode)
//        {
//            this.loadParameterSetting("");
//        }
        
//        protected override void setReferenceDate(DateTime referenceDate)
//        {
//            this.UnderlyingParameterInfo_.ReferenceDate_ = referenceDate;
//        }

//        //public override void setInstrument(Instrument inst) 
//        //{
//        //    this.Inst_ = inst as StandardInstrument;
//        //    this.ItemCode_ = this.Inst_.InstInfo_.KRCode_;
//        //    this.Notional_ = this.Inst_.InstInfo_.Notional_;

//        //    UnderlyingParameterInfo_ = new UnderlyingParameterInfo();
//        //    UnderlyingParameterInfo_.ReferenceDate_ = this.ReferenceDate_;
//        //    UnderlyingParameterInfo_.setUnderInfo(this.Inst_.UnderInfo_);
            
        
//        //}

//        //// 상품마다 underlying의 parameter를 만드는 방법이 다르므로 이렇게 받아서 와야함
//        //// 개개의 class에 parameter build를 넣을 순 없음
//        //// product build 는 상품마다 달라지지 않으므로 넣어도 상관없어 보임.
//        //// build할때 필요한것이며, parameterView에 보여줄땐 필요 없음.
//        //public StepDownKIParameter(StepDownKITypeProduct inst)
//        //{
//        //    this.Inst_ = inst;
//        //}

//        public override void buildParameterXmlData(XmlWriter xmlWriter)
//        {
//            //InterestRateCurveLoader curveLoader = new InterestRateCurveLoader();
//            //    // 이건 우선 그냥 쓰다가 나중에 따로 만들던가 하자.

//            //    this.Inst_.InstInfo_.buildParametorXmlData(xmlWriter, ParameterSetting_);
//            //    this.Inst_.UnderInfo_.buildParametorXmlData(xmlWriter, ParameterSetting_);

//            //    // 이건 해줘야함 fixing이라던지 그런거 처리 해줘야 하니까
//            //    //Parameter_.buildParametorXmlData(xmlWriter, ParameterSetting_);

//            xmlWriter.WriteStartElement("pricingParameter");

//                xmlWriter.WriteElementString("notional", this.Notional_.ToString());
//                UnderlyingParameterInfo_.buildParameterXmlData(xmlWriter);
//                xmlWriter.WriteElementString("method", "monte");
//                xmlWriter.WriteElementString("simulationNum", "100000");
//                xmlWriter.WriteElementString("dicountFlatTS", "0.029");
                
//                xmlWriter.WriteStartElement("instrumentInfo");
//                    xmlWriter.WriteElementString("kiEvent", "false");
//                xmlWriter.WriteEndElement();

//            xmlWriter.WriteEndElement();
//        }

//        //result 만 따로 로드하는 경우를 위해 필요함.
//        public override void loadFromXml(XmlNode node)
//        {
//            #region UnderlyingPart

//            //underlying은 같이 쓰기로 했으니까 걍 같이 감.

//            //UnderlyingParameterInfo underParaInfo = new UnderlyingParameterInfo();
//            UnderlyingParameterInfo_ = new UnderlyingParameterInfo();
//            UnderlyingParameterInfo_.ReferenceDate_ = this.ReferenceDate_;
//            UnderlyingParameterInfo_.underParaInfoFromXml(node);
            
//            //underInfo.loadData(this.ReferenceDate_, this.ParameterSetting_);
//            //underInfo.loadData(this.ReferenceDate_, this.ParameterSetting_);


//            #endregion

//            this.Method_ = "";
            
//        }

//        public override void loadParameter()
//        {
            
//        }

//        public override void saveParameter()
//        {
//            throw new NotImplementedException();
//        }


//    }
//}
