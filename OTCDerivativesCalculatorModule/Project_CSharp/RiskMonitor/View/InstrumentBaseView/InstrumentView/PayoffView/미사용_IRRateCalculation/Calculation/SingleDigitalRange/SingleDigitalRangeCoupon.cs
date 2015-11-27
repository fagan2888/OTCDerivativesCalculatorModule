using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace RiskMonitor
{
    public class SingleDigitalRangeCoupon : ICoupon
    {
        public int RangeCount_ { get; set; }
        public List<double> RefRateList_ { get; set; }
        public List<double> CouponRateList_ { get; set; }

    }
}
