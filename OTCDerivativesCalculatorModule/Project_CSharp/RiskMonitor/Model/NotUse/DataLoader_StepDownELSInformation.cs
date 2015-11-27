//using System;
//using System.Data;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace RiskMonitor
//{
//    public class DataLoader_StepDownELSInformation
//    {
//        private string dataSQL = SQLSetting.StepDownELSInformation;

//        public List<StepDownELSInformation> ELSDeltaHedgePositionLoad() 
//        {
//            DataSet dataSet_ = new DataSet();

//            DataTable dt = dataSet_.Tables["ELSDELTAHEDGEPOSITION"];

//            List<StepDownELSInformation> instList = new List<StepDownELSInformation>();

//            foreach (DataRow item in dt.Rows)
//            {
//                string productName = item["PRODUCTNAME"].ToString();
//                string productType = item["PRODUCTTYPE"].ToString();
//                string productCode = item["PRODUCTCODE"].ToString();
//                DateTime tradeDate = CustomFunction.StrToDate(item["TRADEDATE"].ToString());
//                DateTime effectiveDate = CustomFunction.StrToDate(item["EFFECTIVEDATE"].ToString());
//                DateTime maturityDate = CustomFunction.StrToDate(item["MATURITYDATE"].ToString());
//                long notional = Convert.ToInt64(item["NOTIONAL"].ToString());
//                string currency = item["CURRENCY"].ToString();
//                long premium = Convert.ToInt64(item["PREMIUM"].ToString());
//                string premiumCurrency = item["PREMIUMCURRENCY"].ToString();


//                DataTable redemTable = dataSet_.Tables["ELSREDEM"];

//                List<DateTime> autoCallDates = new List<DateTime>();
//                List<double> autoCallReturn = new List<double>();
//                List<double> autoCallTrigger = new List<double>();

//                foreach (DataRow redem in redemTable.Rows)
//                {
//                    autoCallDates.Add(CustomFunction.StrToDate(redem["AUTOCALLDATES"].ToString()));
//                    autoCallReturn.Add(Convert.ToDouble(redem["AUTOCALLRETURN"].ToString()));
//                    autoCallTrigger.Add(Convert.ToDouble(redem["AUTOCALLTRIGGER"].ToString()));
//                }

//                //List<double> KITrigger = item["NAME"].ToString();
//                List<double> KITrigger = new List<double>();
//                KITrigger.Add(0.5);KITrigger.Add(0.5);

//                //instList.Add(new StepDownELSInformation(productName,
//                //                                        productType,
//                //                                        productCode,
//                //                                        tradeDate,
//                //                                        effectiveDate,
//                //                                        maturityDate,
//                //                                        notional,
//                //                                        currency,
//                //                                        premium,
//                //                                        premiumCurrency,
//                //                                        autoCallDates,
//                //                                        autoCallReturn,
//                //                                        autoCallTrigger,
//                //                                        KITrigger));

                
//            }

//            return instList;
//        }

//    }
//}
