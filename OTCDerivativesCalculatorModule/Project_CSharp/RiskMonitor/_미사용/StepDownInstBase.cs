//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;

//namespace RiskMonitor
//{
//    public class StepDownInstBase : InstrumentBase
//    {

//        public StepDownInstBase(string itemCode)
//            : base(itemCode)
//        {
//            this.Instrument_ = new StandardInstrument();
//            this.Parameter_ = new StepDownKIParameter(itemCode);
//            this.Result_ = new StepDownKIResult();
//        }

//        public override void calculate()
//        {
//            //DateTime referenceDate = 
//            //this.buildParametorXmlData();
//            //this.buildProductXmlData();

//            //string instrumentXml = this.instXml_.InnerXml;

//            XmlNode pricingNode = ResultParametorXml_.SelectSingleNode("pricing");

//            if (pricingNode.FirstChild["pricingResult"] != null )
//            {
//                pricingNode.RemoveChild(pricingNode.FirstChild["pricingResult"]);
//            }


//            string result = StepDownCppDLL.calculationLibCall(
//                                            this.InstXml_.InnerXml, 
//                                            this.ResultParametorXml_.InnerXml);



//            XmlDocumentFragment frag = ResultParametorXml_.CreateDocumentFragment();
//            frag.InnerXml = result;
//            ResultParametorXml_.DocumentElement.AppendChild(frag);

            
//        }

//        public override void instrumentFromXml(XmlNode instNode)
//        {
//            string instrumentType = "";

//            this.Instrument_ = new StandardInstrument();

//            this.Instrument_.instrumentFromXml(instNode);
//        }

//        //한파일에 묶여 있음 이 두개는
//        public override void parameterFromXml(XmlNode resultparaXml)
//        {
//            #region BasePara

//            // xml file 내부에 있는 것을 사용함. View에 있는 referenceDate 는 file로드를 위한것.
//            DateTime referenceDate = CustomFunction.StrToDate(resultparaXml.SelectSingleNode("pricing/evaluationTime").InnerText);
            
//            string itemCode = resultparaXml.SelectSingleNode("pricing/itemCode").InnerText;

//            this.Parameter_.ReferenceDate_ = referenceDate;
//            this.Parameter_.ItemCode_ = itemCode;

//            XmlNode resultparaNode = resultparaXml.SelectSingleNode("pricing/pricingParameter");

//            #endregion

//            string parameterType = "";
//            //this.Parameter_ = new StepDownKIParameter();

//            #region Load

//            this.Parameter_.loadFromXml(resultparaNode);

            

//            #endregion

//        }
//        public override void resultFromXml(XmlNode resultparaXml)
//        {

//            #region BaseResult  

//            DateTime referenceDate = CustomFunction.StrToDate(resultparaXml.SelectSingleNode("pricing/evaluationTime").InnerText);
//            string itemCode = resultparaXml.SelectSingleNode("pricing/itemCode").InnerText;

//            this.Result_.ReferenceDate_ = referenceDate;
//            this.Result_.ItemCode_ = itemCode;

//            XmlNode pricingNode = resultparaXml.SelectSingleNode("pricing");
//            XmlNode resultparaNode = pricingNode.SelectSingleNode("pricingResult");

//            #endregion

//            string resultType = "";
//            this.Result_ = new StepDownKIResult();

//            #region Load
//            if (resultparaNode != null)
//            {
//                this.IsCalculated_ = true;
//                this.Result_.loadFromXml(pricingNode);
//            }
//            else 
//            {
//                this.IsCalculated_ = false;
//                OutputLogViewModel.addResult(new ErrorOutput("",ItemCode_,"Result Calulation Not yet"));
//            }


//            #endregion

//        }


   
//    }
//}
