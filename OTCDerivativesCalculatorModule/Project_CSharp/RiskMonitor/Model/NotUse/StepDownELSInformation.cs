//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace RiskMonitor
//{
//    public class StepDownELSInformation 
//    {
//        private string productName;
//        private string productType;
//        private string productCode;
//        private DateTime tradeDate;
//        private DateTime effectiveDate;
//        private DateTime maturityDate;
//        private long notional;
//        private string currency;
//        private long premium;
//        private string premiumCurrency;
//        private List<DateTime> autoCallDates;
//        private List<double> autoCallReturn;
//        private List<double> autoCallTrigger;
//        private List<double> KITrigger;

//        public StepDownELSInformation() { }

//        public StepDownELSInformation(InstrumentInformation instInfo,
//                                    List<DateTime> autoCallDates,
//                                    List<double> autoCallReturn,
//                                    List<double> autoCallTrigger,
//                                    List<double> KITrigger)
//        {
//            this.InstInfo_ = instInfo;
//            this.autoCallDates_ = autoCallDates;
//            this.autoCallTrigger_ = autoCallTrigger;
//            this.autoCallReturn_ = autoCallReturn;
//            this.KITrigger_ = KITrigger;

//        }

//        public StepDownELSInformation(InstrumentInformation instInfo,
//                                      RedemptionInfo redemption,
//                                      KIEventInfo kiEventInfo,
//                                      NonKIEventInfo nonkiEventInfo)
//        {
//            this.InstInfo_ = instInfo;

//            this.redemption_ = redemption.RedemList_; ;
//            this.kiEventInfo_ = kiEventInfo;
//            this.nonkiEventInfo_ = nonkiEventInfo;
//        }

//        public StepDownELSInformation(string productName, string productType, string productCode, DateTime tradeDate, DateTime effectiveDate, DateTime maturityDate, long notional, string currency, long premium, string premiumCurrency, List<DateTime> autoCallDates, List<double> autoCallReturn, List<double> autoCallTrigger, List<double> KITrigger)
//        {
//            // TODO: Complete member initialization
//            this.productName = productName;
//            this.productType = productType;
//            this.productCode = productCode;
//            this.tradeDate = tradeDate;
//            this.effectiveDate = effectiveDate;
//            this.maturityDate = maturityDate;
//            this.notional = notional;
//            this.currency = currency;
//            this.premium = premium;
//            this.premiumCurrency = premiumCurrency;
//            this.autoCallDates = autoCallDates;
//            this.autoCallReturn = autoCallReturn;
//            this.autoCallTrigger = autoCallTrigger;
//            this.KITrigger = KITrigger;
//        }

//        public void bulidXml()
//        {
//            // IData Interface 구현할거임
//        }

//        public void load()
//        {
//            // IData Interface 구현할거임
//        }

//        public InstrumentInformation InstInfo_ { get; set; }

//        public List<SingleRedemption> redemption_ { get; set; }
//        public KIEventInfo kiEventInfo_ { get; set; }
//        public NonKIEventInfo nonkiEventInfo_ { get; set; } 
        

//        public List<ELSUnderlyingStock> Underlying_ { get; set; } //out_code , stock_name , stock_price , vol, dividend

//        public List<DateTime> autoCallDates_ { get; set; }
//        public List<double> autoCallReturn_ { get; set; }
//        public List<double> autoCallTrigger_ { get; set; }

//        public List<double> KITrigger_ { get; set; }

//        //public bool hasUnderlying(ELSUnderlyingStock stock)
//        //{
//        //    bool flag = false;

//        //    foreach (Underlying item in this.Underlying_)
//        //    {
//        //        if (stock.KRCode_ == item.KRCode_)
//        //        {
//        //            flag = true;
//        //        }
//        //    }

//        //    return flag;
//        //}

//        internal bool hasUnderlying(ELSUnderlyingStock stock)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
