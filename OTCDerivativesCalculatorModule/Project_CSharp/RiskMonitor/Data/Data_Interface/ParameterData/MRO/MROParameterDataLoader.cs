using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Xml;

namespace RiskMonitor
{
        
    public class MROParameterDataLoader
    {
        public DateTime ReferenceDate_ { get; set; }

        private FileInfo fileInfo_      = new FileInfo("D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\Data\\Data_Interface\\ParameterData\\MRO\\MROUnderParameterQueryStr.txt");
        private FileInfo corrQueryInfo_ = new FileInfo("D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\Data\\Data_Interface\\ParameterData\\MRO\\MROCorrQueryStr.txt");
        private FileInfo discountQueryInfo_ = new FileInfo("D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\Data\\Data_Interface\\ParameterData\\MRO\\MROCurveQueryStr.txt");
        private FileInfo masterInfo_ = new FileInfo("D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\Data\\Data_Interface\\ParameterData\\MRO\\MROMasterQueryStr.txt");

        private FileInfo positionInfo_ = new FileInfo("D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\Data\\Data_Interface\\ParameterData\\MRO\\MROPositionQueryStr.txt");

        private Dictionary<string, string> loadedParameter_;

        //private FileInfo dbInfo_ = new FileInfo();
        private string connectionStr = "Data Source=RMS_OP;User ID=RM_VIEW;Password=ahslxj1!;";
        private OracleDataBaseConnect conn_ = new OracleDataBaseConnect();

        private DataSet dataSet_;

        public List<string> PositionList_ { get; set; }
        public List<string> FundCodeList_ { get; set; }

        public MROParameterDataLoader()
        {
            conn_.ConnectionString_ = this.connectionStr;
        }

        private void positionLoad()
        {
            this.PositionList_ = new List<string>();

            QueryStr queryStr = new QueryStr(this.positionInfo_);

            queryStr.VariableMap_.Add("STD_DATE", this.ReferenceDate_.ToString("yyyyMMdd"));
            queryStr.VariableMap_.Add("FUND_CODE", "A27212','A27211','A27214");
            
            conn_.clearQuery();
            conn_.addQuery("position", queryStr.getQuery());
            conn_.excute();

            DataTable tb = conn_.ResultDataSet_.Tables["position"];

            foreach (DataRow item in tb.Rows)
            {
                this.PositionList_.Add(item["KR_CODE"].ToString());
            }
        }

        public void makeParameter()
        {
            this.positionLoad();

            this.loadedParameter_ = new Dictionary<string, string>();

            // monte
            foreach (var item in this.PositionList_)
            {
                string itemCode = item;

                StandardInstBaseViewModel standInstBaseVM = new StandardInstBaseViewModel(new InstUriInfo());

                standInstBaseVM.ReferenceDate_ = this.ReferenceDate_;
                standInstBaseVM.ItemCode_ = itemCode;
                standInstBaseVM.ItemType_ = "stepDownKI";

                Standard_paraViewModel stand_paraVM = new Standard_paraViewModel();

                MonteViewModel methodVM = new MonteViewModel();
                methodVM.SimulationNum_ = Convert.ToString(30000);

                stand_paraVM.MethodViewModel_ = methodVM;

                stand_paraVM.CalculationAmountViewModel_ = this.calculationVM(itemCode);
                stand_paraVM.UnderlyingInfo_paraViewModel_ = this.underInfo_paraVM(itemCode);
                stand_paraVM.DiscountCurve_paraViewModel_ = this.discount_paraVM(itemCode);

                standInstBaseVM.PricingParameterViewModel_ = stand_paraVM;

                standInstBaseVM.buildPara();

                string kk = standInstBaseVM.ParaResultXml_.InnerXml;
                this.loadedParameter_.Add(itemCode, kk);

                //StringBuilder sb = new StringBuilder();
                //XmlWriterSettings setting = new XmlWriterSettings();

                //setting.Indent = true;
                //setting.Encoding = Encoding.UTF8;
                //XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

                //standInstBaseVM.ParaResultXml_.Save(xmlWriter);
                
                //this.loadedParameter_.Add(itemCode, sb.ToString());

                //this.loadedParameter_.Add(itemCode, standInstBaseVM.ParaResultXml_.InnerXml);
                //loadedParameter_.Add(itemCode,
            }
            
        }

        public void saveFile(string parameterPath)
        {
            int count = 1;
            
            foreach (var item in this.loadedParameter_)
            {
                string itemCode = item.Key;
                string fileName = this.ReferenceDate_.ToString("yyyyMMdd") + "_" + itemCode + "_StepDownKI.xml";
                string filePath = parameterPath + fileName;

                File.WriteAllText(filePath, item.Value, new UTF8Encoding(true));
                Console.WriteLine(count + " : " + fileName + " : build complete");

                count += 1;
            }
            Console.WriteLine("total gen number : " + count);
        }

        private CalculationAmountViewModel calculationVM(string itemCode)
        {
            CalculationAmountViewModel calculationVM = new CalculationAmountViewModel();

            QueryStr queryStr = new QueryStr(this.masterInfo_);

            queryStr.VariableMap_.Add("KR_CODE", itemCode);

            conn_.clearQuery();
            conn_.addQuery("elsmaster", queryStr.getQuery());
            conn_.excute();

            DataTable tb = conn_.ResultDataSet_.Tables["elsmaster"];

            string issue_amt = "0";
            string currency = "KRW";

            foreach (DataRow item in tb.Rows)
            {
                issue_amt = item["ISSUE_AMT"].ToString();

            }

            calculationVM.Amount_ = issue_amt;
            calculationVM.Currency_ = currency;

            return calculationVM;
        }

        private DiscountCurve_paraViewModel discount_paraVM(string itemCode)
        {
            DiscountCurve_paraViewModel discount_paraVM = new DiscountCurve_paraViewModel();
            YieldTermstructureViewModel yieldTSVM = new YieldTermstructureViewModel();

            yieldTSVM.Type_ = "ZEROYIELD";
            yieldTSVM.Interpolation_ = "BACKWARDFLAT";
            yieldTSVM.Daycounter_ = "ACT365FIX";
            yieldTSVM.Calendar_ = "NULLCALENDAR";
            yieldTSVM.BusinessDayConvention_ = "Following";

            QueryStr queryStr = new QueryStr(this.discountQueryInfo_);

            queryStr.VariableMap_.Add("STD_DATE", this.ReferenceDate_.ToString("yyyyMMdd"));
            queryStr.VariableMap_.Add("CURVE_CODE", "S");
            queryStr.VariableMap_.Add("BOND_CLASS_ID","111001");
            
            conn_.clearQuery();
            conn_.addQuery("discountCurve", queryStr.getQuery());
            conn_.excute();

            DataTable tb = conn_.ResultDataSet_.Tables["discountCurve"];

            foreach (DataRow item in tb.Rows)
	        {
                yieldTSVM.RateDataViewModel_.Add(this.rateDataVM("1","D", ( Convert.ToDouble(item["D001"].ToString())/100).ToString() ));
                yieldTSVM.RateDataViewModel_.Add(this.rateDataVM("3", "M", ( Convert.ToDouble(item["M003"].ToString()) / 100).ToString() ));
                yieldTSVM.RateDataViewModel_.Add(this.rateDataVM("6", "M", ( Convert.ToDouble(item["M006"].ToString()) / 100).ToString() ));
                yieldTSVM.RateDataViewModel_.Add(this.rateDataVM("9", "M", ( Convert.ToDouble(item["M009"].ToString()) / 100).ToString() ));
                yieldTSVM.RateDataViewModel_.Add(this.rateDataVM("12", "M", ( Convert.ToDouble(item["M012"].ToString()) / 100).ToString() ));
                yieldTSVM.RateDataViewModel_.Add(this.rateDataVM("18", "M", ( Convert.ToDouble(item["M018"].ToString()) / 100).ToString() ));
                yieldTSVM.RateDataViewModel_.Add(this.rateDataVM("24", "M", ( Convert.ToDouble(item["M024"].ToString()) / 100).ToString() ));
                yieldTSVM.RateDataViewModel_.Add(this.rateDataVM("30", "M", ( Convert.ToDouble(item["M030"].ToString()) / 100).ToString() ));
                yieldTSVM.RateDataViewModel_.Add(this.rateDataVM("36", "M", ( Convert.ToDouble(item["M036"].ToString()) / 100).ToString() ));
                yieldTSVM.RateDataViewModel_.Add(this.rateDataVM("48", "M", ( Convert.ToDouble(item["M048"].ToString()) / 100).ToString() ));
                yieldTSVM.RateDataViewModel_.Add(this.rateDataVM("60", "M", ( Convert.ToDouble(item["M060"].ToString()) / 100).ToString() ));
                yieldTSVM.RateDataViewModel_.Add(this.rateDataVM("84", "M", ( Convert.ToDouble(item["M084"].ToString()) / 100).ToString() ));
                yieldTSVM.RateDataViewModel_.Add(this.rateDataVM("120", "M", ( Convert.ToDouble(item["M120"].ToString()) / 100).ToString() ));
                yieldTSVM.RateDataViewModel_.Add(this.rateDataVM("180", "M", ( Convert.ToDouble(item["M180"].ToString()) / 100).ToString() ));
                yieldTSVM.RateDataViewModel_.Add(this.rateDataVM("240", "M", ( Convert.ToDouble(item["M240"].ToString()) / 100).ToString() ));
                yieldTSVM.RateDataViewModel_.Add(this.rateDataVM("360", "M", ( Convert.ToDouble(item["M360"].ToString()) / 100).ToString() ));

	        }

            discount_paraVM.YieldTermstructureViewModel_.Add(yieldTSVM);

            return discount_paraVM;
        }

        private RateDataViewModel rateDataVM(string multiple, string period, string data)
        {
            RateDataViewModel rateDataVM = new RateDataViewModel();

            rateDataVM.PeriodMultiplier_ = multiple;
            rateDataVM.Period_ = period;
            rateDataVM.Data_ = data;

            return rateDataVM;
        }

        private UnderlyingInfo_paraViewModel underInfo_paraVM(string itemCode)
        {
            UnderlyingInfo_paraViewModel underInfo_paraVM = new UnderlyingInfo_paraViewModel();

            QueryStr queryStr = new QueryStr(this.fileInfo_);

            queryStr.VariableMap_.Add("ITEM_CODE", itemCode);
            queryStr.VariableMap_.Add("STD_DATE", this.ReferenceDate_.ToString("yyyyMMdd"));

            conn_.addQuery("underInfo", queryStr.getQuery());

            conn_.excute();

            DataTable tb = conn_.ResultDataSet_.Tables["underInfo"];

            string krCode;
            string underName;
            string currentValue;
            string drift;
            string dividend;
            string volatility;

            List<string> underCode = new List<string>();

            foreach (DataRow item in tb.Rows)
            {
                krCode = item["STOCK_ID"].ToString();
                underName = item["STOCK_NAME"].ToString();
                currentValue = item["CURR_PRICE"].ToString();
                drift = ( Convert.ToDouble(item["RF"].ToString())/100 ).ToString();
                dividend = (Convert.ToDouble(item["DIVIDEND_RATE"].ToString()) / 100).ToString();
                volatility = (Convert.ToDouble(item["VOL"].ToString()) / 100).ToString();

                underCode.Add(krCode);

                GeometricBMViewModel gbmVM = this.makeGBM(krCode, underName, currentValue, drift, dividend, volatility);

                underInfo_paraVM.Underlying_paraViewModel_.Add(gbmVM);
            }

            underInfo_paraVM.CorrelationInfo_paraViewModel_ = this.makeCorrInfo(underCode);

            return underInfo_paraVM;
        }

        public GeometricBMViewModel makeGBM(string krCode,
                                            string underName,
                                            string currentValue,
                                            string drift,
                                            string dividend,
                                            string volatility)
        {
            GeometricBMViewModel gbmVm = new GeometricBMViewModel();

            gbmVm.Type_ = "geometricBM";
            gbmVm.KrCode_ = krCode;
            gbmVm.UnderName_ = underName;
            gbmVm.CurrentValue_ = currentValue;
            gbmVm.Drift_ = drift;
            gbmVm.Dividend_ = dividend;
            gbmVm.Volatility_ = volatility;

            return gbmVm;
        }

        private CorrelationInfo_paraViewModel makeCorrInfo(List<string> underCodeList)
        {

            QueryStr queryStr = new QueryStr(this.corrQueryInfo_);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < underCodeList.Count; i++)
            {
                sb.Append(QueryStr.wrapComma(underCodeList[i]));

                if (i != underCodeList.Count - 1)
                {
                    sb.Append(",");
                }

            }

            queryStr.VariableMap_.Add("STD_DATE",this.ReferenceDate_.ToString("yyyyMMdd"));
            queryStr.VariableMap_.Add("UNDER_LIST", sb.ToString());

            conn_.addQuery("underCorrInfo", queryStr.getQuery());

            conn_.excute();

            DataTable tb = conn_.ResultDataSet_.Tables["underCorrInfo"];

            List<string> first = new List<string>();
            List<string> second = new List<string>();
            List<string> values = new List<string>();

            foreach (DataRow item in tb.Rows)
            {
                first.Add(item["STOCK_ID"].ToString());
                second.Add(item["OTHER_ID"].ToString());
                values.Add(item["CORR"].ToString());
            }

            CorrelationInfo_paraViewModel corrInfoVM = new CorrelationInfo_paraViewModel();
            corrInfoVM.Dimension_ = underCodeList.Count.ToString();

            //Int32 dimensionTrans = underCodeList.Count;
            //Int32 needCorrNum = dimensionTrans * (dimensionTrans + 1) / 2;

            for (int i = 0; i < values.Count; i++)
            {
                corrInfoVM.Correlation_paraViewModel_.Add(this.makeCorr(first[i], second[i], values[i]));
            }

            return corrInfoVM;

        }

        private Correlation_paraViewModel makeCorr(string first,string second,string value)
        {
            Correlation_paraViewModel corrVM = new Correlation_paraViewModel();
            
            corrVM.First_ = first;
            corrVM.Second_ = second;
            corrVM.Value_ = value;
            
            return corrVM;
        
        }




        public string batchFile()
        {

            StringBuilder sb = new StringBuilder();
            string calculatorFileName = "OTCcalculator.exe";
            foreach (var item in this.PositionList_)
	        {
		         sb.AppendLine(calculatorFileName + " stepDownKI " + item + "_StepDownKI.xml " + 
                               this.ReferenceDate_.ToString("yyyyMMdd") + "_" + item + "_StepDownKI.xml " +
                               "output.txt");
	        }

            return sb.ToString();
            
        }
    }
}
