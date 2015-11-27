using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class FixedBond_TradeString : TradeString
    {
        protected readonly string[] currencyAliases_ = { "currency" };
        protected readonly string[] couponTenorAliases_ = { "couponTenor" };
        protected readonly string[] fixedRateAliases_ = { "fixedRate" };
        protected readonly string[] issueDateAliases_ = { "issueDate" };
        protected readonly string[] maturityDateAliases_ = { "maturityDate" };
        protected readonly string[] maturityYearAliases_ = { "maturityYear" };

        public string Currency_ = "";
        public string CouponTenor_ = "";
        public string FixedRate_ = "";
        public string IssueDate_ = "";
        public string MaturityDate_ = "";
        public string MaturityYear_ = "";

        public FixedBond_TradeString()
        : base("fixedBond")
        { 
        }

        public override void parsingString(string tradeStr)
        {
            if (tradeStr == "dafault" || tradeStr == "" || tradeStr == null)
            {
                this.Currency_ = "KRW";
                this.CouponTenor_ = "3M";
                this.FixedRate_ = "3.75";
                this.IssueDate_ = "2014-08-15";
                this.MaturityDate_ = "";
                this.MaturityYear_ = "5Y";
            }
            else 
            {
                this.keyValuePairs_ = tradeStr.Split(';')
                                            .Where(kvp => kvp.Contains('='))
                                            .Select(kvp => kvp.Split(new char[] { '=' }, 2))
                                            .ToDictionary(kvp => kvp[0].Trim(),
                                                          kvp => kvp[1].Trim(),
                                                          StringComparer.InvariantCultureIgnoreCase);

                this.Currency_ = this.getValue(currencyAliases_);
                this.CouponTenor_ = this.getValue(couponTenorAliases_);
                this.FixedRate_ = this.getValue(fixedRateAliases_);
                this.IssueDate_ = this.getValue(issueDateAliases_);
                this.MaturityDate_ = this.getValue(maturityDateAliases_);
                this.MaturityYear_ = this.getValue(maturityYearAliases_);
            }
        }

        public override string printValue()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("product String : " + this.productString_);
            sb.AppendLine("----------------------------------------");
            sb.AppendLine("Currency       : " + this.Currency_);
            sb.AppendLine("CouponTenor    : " + this.CouponTenor_);
            sb.AppendLine("FixedRate      : " + this.FixedRate_);
            sb.AppendLine("IssueDate      : " + this.IssueDate_);
            sb.AppendLine("MaturityDate   : " + this.MaturityDate_);
            sb.AppendLine("MaturityYear   : " + this.MaturityYear_);

            return sb.ToString();
        }
    }
}
