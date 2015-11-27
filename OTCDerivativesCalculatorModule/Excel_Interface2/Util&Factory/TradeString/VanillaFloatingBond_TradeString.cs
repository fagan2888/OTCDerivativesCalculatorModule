using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class VanillaFloatingBond_TradeString : TradeString
    {
        public string Currency_ = "";
        public string CouponTenor_ = "";
        public string FloatingIndexRate = "";
        public string Spread_ = "";
        public string InArrear_ = "";
        public string IssueDate_ = "";
        public string MaturityDate_ = "";
        public string MaturityYear_ = "";
        

        public VanillaFloatingBond_TradeString()
        : base("vanillaFloatingBond")
        { 
        }

        public override void parsingString(string tradeStr)
        {
            this.Currency_ = "KRW";
            this.CouponTenor_ = "3M";
            this.FloatingIndexRate = "3.75";
            this.Spread_ = "0.3";
            this.InArrear_ = "false";
            this.IssueDate_ = "2014-08-15";
            this.MaturityDate_ = "";
            this.MaturityYear_ = "5Y";
        }

        public override string printValue()
        {
            throw new NotImplementedException();
        }
    }
}
