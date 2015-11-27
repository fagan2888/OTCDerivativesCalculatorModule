using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class ResultMasterInfo
    {
        public string KRCode_ { get; set; }
        public string InstName_ { get; set; }
        public string InstCode_ { get; set; }
        public string CalValue_ { get; set; }
        public string CalUnitValue_ { get; set; }
        public string ReferenceDate_ { get; set; }
        public string CalculateDate_ { get; set; }
        public string FileName_ { get; set; }
        public string InstType_ { get; set; }
        public string ResultType_ { get; set; }

        public ResultMasterInfo(string krCode,
                                string instName,
                                string instCode,
                                string calValue,
                                string calUnitValue,
                                string referenceDate,
                                string calculateDate,
                                string fileName,
                                string instType,
                                string resultType)
        {
            this.KRCode_ = krCode;
            this.InstName_ = instName;
            this.InstCode_ = instCode;
            this.CalValue_ = calValue;
            this.CalUnitValue_ = calUnitValue;
            this.ReferenceDate_ = referenceDate;
            this.FileName_ = fileName;
            this.InstType_ = instType;
            this.ResultType_ = resultType;
        
        }
    }
}
