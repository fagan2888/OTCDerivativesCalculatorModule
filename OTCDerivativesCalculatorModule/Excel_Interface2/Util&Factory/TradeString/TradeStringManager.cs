using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public abstract class TradeString
    {
        #region Read Only Properties

        protected readonly string[] productNameAliases_ = { "name", "productName" };
        protected readonly string[] notionalAliases_ = { "notional", "notionalAmount", "issueAmount" };
        protected readonly string[] notionalCurrencyAliases_ = { "currency", "notionalCurrency", "issueCurrency" };
        protected readonly string[] exportCodeAliases_ = { "exportCode" };
        protected readonly string[] settlementDaysAliases_ = { "settlementDays", "settlementDay" };
        protected readonly string[] tradeNationAliases_ = { "tradeNation", "tradeExchange" };
        protected readonly string[] instTypeAliases_ = { "instrumentType", "productType" ,"type" };
        protected readonly string[] underlyingAliases_ = { "under", "underlying", "underInfo", "unders", "underlyings", "underList", "underLists" };
        protected readonly string[] lyingAliases_ = { "under", "underlying", "underInfo", "unders", "underlyings", "underList", "underLists" };
        protected readonly string[] effectiveDateAliases_ = { "effectiveDate", "effective", "issueDate", "issue" , "tradeDate" , "tradingDate" };
        

        #endregion

        public string Name_ = "TestName";
        public string Notional_ = "10000";
        public string EffectiveDate_ = "";
        public string SettlementDays_ = "2";
        public string TradeNation_ = "KOR";
        public string ExportCode_ = "TestCode";
        public List<string> UnderlyingList_ 
            = new List<string>() { "TestUnder" };

        protected Dictionary<string, string> keyValuePairs_ = new Dictionary<string, string>();

        #region ProductString_
        protected string productString_;
        public string ProductString_
        {
            get { return this.productString_; }
            set
            {
                if (this.productString_ != value)
                {
                    this.productString_ = value;
                }
            }
        }
        #endregion

        public string InstType_ = "";

        public TradeString(string instType_)
        {
            this.InstType_ = instType_;
        }

        public abstract void parsingString(string tradeStr);

        string GetValue(string connectionString, params string[] keyAliases)
        {
            var keyValuePairs = connectionString.Split(';')
                                                .Where(kvp => kvp.Contains('='))
                                                .Select(kvp => kvp.Split(new char[] { '=' }, 2))
                                                .ToDictionary(kvp => kvp[0].Trim(),
                                                              kvp => kvp[1].Trim(),
                                                              StringComparer.InvariantCultureIgnoreCase);
            foreach (var alias in keyAliases)
            {
                string value;
                if (keyValuePairs.TryGetValue(alias, out value))
                    return value;
            }

            return string.Empty;
        }

        protected string getValue(string[] ketAliases)
        {
            foreach (var alias in ketAliases)
            {
                string value;
                if (this.keyValuePairs_.TryGetValue(alias, out value))
                    return value;
            }

            return string.Empty;
        }

        public abstract string printValue();

        public void baseParsingString(string tradeStr)
        {
            this.Name_ = this.getValue(productNameAliases_);

            this.Notional_ = this.getValue(notionalAliases_);

            this.ExportCode_ = this.getValue(exportCodeAliases_);

            this.EffectiveDate_ = this.getValue(effectiveDateAliases_);

            this.UnderlyingList_.Clear();

            string underListStr = this.getValue(underlyingAliases_);

            string[] splitList = underListStr.Split(',');

            foreach (var item in splitList)
            {
                this.UnderlyingList_.Add(item);
            }

        }
    }
}
