//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;
//using FpmlSerializedCSharp;
//using QLNet;

//namespace RiskMonitor
//{
//    public class ELSStepDownLoader
//    {
//        public string FileName_ { get; set; }

//        public ELSStepDownLoader()
//        {

//        }

//        //public StepDownKITypeProduct load() 
//        //{
//        //    XmlDocument instDoc = new XmlDocument();
//        //    instDoc.Load(FileName_);

//        //    XmlNode node = instDoc[""];

//        //    return this.stepDownXmlload(node);

//        //}

//        public StepDownELSInformation stepDownload()
//        {

//            string productName = "ELS840";
//            string productType = "2StepDownKI";
//            string productCode = "555555555";
//            DateTime tradeDate = new DateTime(2013, 05, 24);
//            DateTime effectiveDate = new DateTime(2013, 05, 30);
//            DateTime maturityDate = new DateTime(201, 05, 24);
//            long notional = 2040000000;
//            string currency = "KRW";
//            long premium = 0;
//            string premiumCurrency = "KRW";

//            List<DateTime> autoCallDates = new List<DateTime>();
//            List<double> autoCallReturn = new List<double>();
//            List<double> autoCallTrigger = new List<double>();
//            List<double> KITrigger = new List<double>();

//            autoCallDates.Add(new DateTime(2013, 11, 24));
//            autoCallDates.Add(new DateTime(2014, 05, 24));
//            autoCallDates.Add(new DateTime(2014, 11, 24));
//            autoCallDates.Add(new DateTime(2015, 05, 24));
//            autoCallDates.Add(new DateTime(2015, 11, 24));
//            autoCallDates.Add(new DateTime(2016, 05, 24));

//            autoCallReturn.Add(0.035);
//            autoCallReturn.Add(0.07);
//            autoCallReturn.Add(0.105);
//            autoCallReturn.Add(0.14);
//            autoCallReturn.Add(0.175);
//            autoCallReturn.Add(0.21);

//            autoCallTrigger.Add(0.95);
//            autoCallTrigger.Add(0.90);
//            autoCallTrigger.Add(0.90);
//            autoCallTrigger.Add(0.80);
//            autoCallTrigger.Add(0.80);

//            KITrigger.Add(0.5);
//            KITrigger.Add(0.5);

//            StepDownELSInformation inst = new StepDownELSInformation(productName,
//                                                                    productType,
//                                                                    productCode,
//                                                                    tradeDate,
//                                                                    effectiveDate,
//                                                                    maturityDate,
//                                                                    notional,
//                                                                    currency,
//                                                                    premium,
//                                                                    premiumCurrency,
//                                                                    autoCallDates,
//                                                                    autoCallReturn,
//                                                                    autoCallTrigger,
//                                                                    KITrigger);

//            List<Underlying> underlyings = new List<Underlying>();

//            string underName;
//            long currentPrice;
//            long basePrice;
//            double dividend;
//            string associateDerivativesCode;
//            double volatiltity;
//            Delta delta;
//            Gamma gamma;
//            Vega vega;

//            underName = "한국전력";
//            currentPrice = 145500;
//            basePrice = 145000;
//            dividend = 0.02;
//            associateDerivativesCode = "555555555";
//            volatiltity = 0.24;
//            delta = new Delta(0.1);
//            gamma = new Gamma(0.2);
//            vega = new Vega(0.3);

//            List<Underlying> underList = new List<Underlying>();

//            ELSUnderlyingStock underStock1 = new ELSUnderlyingStock(underName,
//                                                            currentPrice,
//                                                            basePrice,
//                                                            dividend,
//                                                            associateDerivativesCode,
//                                                            volatiltity,
//                                                            delta,
//                                                            gamma,
//                                                            vega);

//            underName = "SK이노베이션";
//            currentPrice = 27200;
//            basePrice = 28483;
//            dividend = 0.01;
//            associateDerivativesCode = "555555555";
//            volatiltity = 0.29;
//            delta = new Delta(0.1);
//            gamma = new Gamma(0.2);
//            vega = new Vega(0.3);

//            ELSUnderlyingStock underStock2 = new ELSUnderlyingStock(underName,
//                                                            currentPrice,
//                                                            basePrice,
//                                                            dividend,
//                                                            associateDerivativesCode,
//                                                            volatiltity,
//                                                            delta,
//                                                            gamma,
//                                                            vega);

//            underList.Add(underStock1);
//            underList.Add(underStock2);

//            //inst.Underlying_ = underList;

//            return inst;
//        }

//        //public StepDownKITypeProduct stepDownXmlload(XmlNode node)
//        //{
//        //    //StepDownELSInformation stepDownInfo = this.stepDownInfoLoad(node);

//        //    StepDownKITypeProduct inst = new StepDownKITypeProduct(this.instInformation(node),
//        //                                                           this.redemEventXml(node),
//        //                                                           this.kiEventXml(node),
//        //                                                           this.nonkiEventXml(node));

//        //    return inst;


//        //}

//        private RedemptionInfo redemEventXml(XmlNode node)
//        {
//            XmlNode redemptionScheduleNode = node["ELSStepDownRedemptions"];

//            XmlNodeList redemNodes = redemptionScheduleNode.SelectNodes("autoCallTrigger");

//            RedemptionInfo redemptionEventList = new RedemptionInfo();

//            foreach (XmlNode item in redemNodes)
//            {
//                DateTime date = CustomFunction.StrToDate(item["date"].ToString());
//                double trigger = Convert.ToDouble(item["trigger"]);
//                double ret = Convert.ToDouble(item["return"]);

//                redemptionEventList.add(new RedemptionEvent(date, trigger, ret));

//            }

//            return redemptionEventList;
//        }

//        private KIEventInfo kiEventXml(XmlNode node)
//        {
//            XmlNode redemptionScheduleNode = node["ELSStepDownRedemptions"];

//            XmlNode kiNode = node["kiTrigger"];

//            XmlNodeList valuesNodes = kiNode.SelectNodes("value");

//            KIEventInfo kiInfo = new KIEventInfo();

//            foreach (XmlNode item in valuesNodes)
//            {
//                kiInfo.Values_.Add(Convert.ToDouble(item.Value));
//            }

//            return kiInfo;
//        }

//        private NonKIEventInfo nonkiEventXml(XmlNode node)
//        {
//            XmlNode redemptionScheduleNode = node["ELSStepDownRedemptions"];

//            XmlNode nonkiNode = node["nonkiTrigger"];

//            NonKIEventInfo kiInfo = new NonKIEventInfo();

//            kiInfo.ReturnValue_ = Convert.ToDouble(nonkiNode["return"].Value);

//            return kiInfo;

//        }

//        //private KIEventPricer kiEventPricerXml(XmlNode node)
//        //{
//        //    Date startDate = new Date();
//        //    Date endDate = new Date();

//        //    Exercise exercise = new AmericanExercise(startDate, endDate);

//        //    BarrierEvent barrierEvent = new BarrierEvent(exercise, 0.5);

//        //    List<Date> autoCallDates = new List<Date>();
//        //    List<double> triggers = new List<double>();
//        //    List<double> returns = new List<double>();

//        //    XmlNodeList triggerNodeList = node.SelectNodes("autoCallTrigger");

//        //    foreach (XmlNode item in triggerNodeList)
//        //    {
//        //        Date date = CustomFunction.StrToDate(item["date"].ToString());
//        //        autoCallDates.Add(date);

//        //        double trigger = Convert.ToDouble(item["trigger"]);
//        //        triggers.Add(trigger);

//        //        double ret = Convert.ToDouble(item["return"]);
//        //        returns.Add(ret);
//        //    }

//        //    AutoCallTriggerEvent autoEvent = new AutoCallTriggerEvent(autoCallDates, triggers, returns);

//        //    //PathMultiPayoff kiPayoff = new KISlopePayoff();

//        //    XmlNode nontriggerNode = node.SelectSingleNode("nonkiTriger");

//        //    double value = Convert.ToDouble(nontriggerNode["return"]);

//        //    PathMultiPayoff nonKIPayoff = new ConstPayoff(value);


//        //    KIEventPricer pricer = new KIEventPricer(barrierEvent, autoEvent, kiPayoff, nonKIPayoff);

//        //    return pricer;
//        //}

//        private UnderlyingInfo underlyingInfoXml(XmlNode node)
//        {

//            //XmlNodeList indexNodeList = node.SelectNodes("baseIndexes")
//            //FpmlSerializedCSharp.BaseIndexes underlyings_serial = new BaseIndexes(node);

//            List<Underlying> underlyings = new List<Underlying>();

//            underlyings.Add(new Underlying("한국전력"));
//            underlyings.Add(new Underlying("SK이노베이션"));

//            UnderlyingInfo underInfo = new UnderlyingInfo();

//            underInfo.Underlyings_ = underlyings;

//            throw new NotImplementedException();
//        }

//        private StepDownELSInformation stepDownInfoLoad(XmlNode node)
//        {
//            InstrumentInformation baseInformation = this.instInformation(node);

//            throw new NotImplementedException();
//        }

//        private InstrumentInformation instInformation(XmlNode node)
//        {

//            XmlNode issueInfoNode = node["issueInformation"];

//            string productName = issueInfoNode["productName"].Value;
//            string productType = issueInfoNode["productType"].Value;
//            string instrumentID = issueInfoNode["instrumentID"].Value;
//            string krCode = issueInfoNode["krCode"].Value;
//            DateTime tradeDate = Convert.ToDateTime(issueInfoNode["tradeDate"].Value);
//            DateTime effectiveDate = Convert.ToDateTime(issueInfoNode["effectiveDate"].Value);
//            DateTime maturityDate = Convert.ToDateTime(issueInfoNode["maturityDate"].Value);
//            long notional = Convert.ToInt64(issueInfoNode["notional"].Value);
//            long premium = Convert.ToInt64(issueInfoNode["premium"].Value);

//            InstrumentInformation instInfo = new NoteInformation(productName,
//                                                                    productType,
//                                                                    instrumentID,
//                                                                    tradeDate,
//                                                                    effectiveDate,
//                                                                    maturityDate,
//                                                                    notional,
//                                                                    premium);

//            return instInfo;

//        }
//    }
//}
