using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class StepDownKI_TradeString : TradeString
    {
        protected readonly string[] couponAliases_ = { "coupon", "coupon(p.a)" };
        protected readonly string[] kiAliases_ = { "ki", "knock in barrier" };
        protected readonly string[] maturiryAliases_ = { "maturity", "tenor" };
        protected readonly string[] observationPeriodAliases_ = { "observation", "observation period" };
        protected readonly string[] triggerAliases_ = { "trigger", "trigger level" };
        

        public string Trigger_ = "";
        public List<string> TriggerList_;

        public string Coupon_ = ""; // % 가 붙어 있으면 그냥 쓰고 , 없으면 곱하기 100함
        public string KI_ = "";
        public string ObKI_ = "";
        public string MaturiryYear_ = "";
        public string ObTenor_ = "";
        public string Under_ = "";
        

        public StepDownKI_TradeString()
        : base("stepDownKI")
        {
            this.TriggerList_ = new List<string>();
        }

        public override void parsingString(string tradeStr = "default")
        {
            this.productString_ = tradeStr;

            if (tradeStr == "default" || tradeStr == "" || tradeStr == null)
            {
                this.Trigger_ = "92.5/92.5/87.5/87.5/82.5/82.5";
                this.Coupon_ = "8.0";
                this.KI_ = "55.5";
                this.ObKI_ = "Conti";
                this.MaturiryYear_ = "3Y";
                this.ObTenor_ = "6M";
                this.Under_ = "이노베이션,경남은행";

                this.TriggerList_.Add("92.5");
                this.TriggerList_.Add("92.5");
                this.TriggerList_.Add("87.5");
                this.TriggerList_.Add("87.5");
                this.TriggerList_.Add("82.5");
                this.TriggerList_.Add("82.5");
            }
            else
            {
                this.keyValuePairs_  = tradeStr.Split(';')
                                        .Where(kvp => kvp.Contains('='))
                                        .Select(kvp => kvp.Split(new char[] { '=' }, 2))
                                        .ToDictionary(kvp => kvp[0].Trim(),
                                                      kvp => kvp[1].Trim(),
                                                      StringComparer.InvariantCultureIgnoreCase);

                base.baseParsingString(tradeStr);

                this.Coupon_ = this.getValue(couponAliases_);
                this.KI_ = this.getValue(kiAliases_);

                this.ObKI_ = "";
                this.MaturiryYear_ = this.getValue(maturiryAliases_);
                this.ObTenor_ = this.getValue(observationPeriodAliases_);
                this.Under_ = "";
                

                this.Trigger_ = this.getValue(triggerAliases_);

                this.TriggerList_.Clear();

                string[] splitList = this.Trigger_.Split('/');

                foreach (var item in splitList)
                {
                    this.TriggerList_.Add(item);
                }

            }
            
        }

        public override string printValue()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("product String : " + this.productString_);
            sb.AppendLine("----------------------------------------");
            sb.AppendLine("Trigger       : " + this.Trigger_);
            sb.AppendLine("Coupon        : " + this.Coupon_);
            sb.AppendLine("KI            : " + this.KI_);
            sb.AppendLine("ObKI          : " + this.ObKI_);
            sb.AppendLine("MaturiryYear  : " + this.MaturiryYear_);
            sb.AppendLine("ObTenor       : " + this.ObTenor_);
            sb.AppendLine("Under         : " + this.Under_);
            sb.AppendLine("EffectiveDate : " + this.Under_);

            return sb.ToString();
        }
    }
}
