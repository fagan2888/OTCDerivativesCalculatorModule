using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class InstPositionInfo
    {
        public string KRCode_ { get; set; }
        public string InstName_ { get; set; }
        public string InstCode_ { get; set; }
        public string BookedDate_ { get; set; }
        public string UnBookedDate_ { get; set; }
        public string InstType_ { get; set; }
        public string MaturityDate_ { get; set; }
        public string FileName_ { get; set; }
        public string PositionName_ { get; set; }
        public string CounterParty_ { get; set; }
        public string Notional_ { get; set;}
        public string Currency_ { get; set; }
        public string FundCode_ { get; set; }
        public string FundName_ { get; set; }

        public InstPositionInfo(string krCode,
                        string instName,
                        string instCode,
                        string instType,
                        string bookedDate,
                        string unBookedDate,
                        string maturityDate,
                        string fileName,
                        string positionName,
                        string counterParty,
                        string notional,
                        string currency,
                        string fundCode,
                        string fundName)
        {
            this.KRCode_ = krCode;
            this.InstName_ = instName;
            this.InstCode_ = instCode;
            this.InstType_ = instType;
            this.BookedDate_ = bookedDate;
            this.UnBookedDate_ = unBookedDate;
            this.MaturityDate_ = maturityDate;
            this.FileName_ = fileName;
            this.PositionName_ = positionName;
            this.Notional_ = notional;
            this.Currency_ = currency;
            this.FundCode_ = fundCode;
            this.FundName_ = fundName;

        }
    }
}
