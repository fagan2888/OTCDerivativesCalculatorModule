using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace RiskMonitor
{
    public class GreekResult
    {

        public string ItemCode_ { get; set; }
        public string ItemName_ { get; set; }
        public double Notional_ { get; set; }

        public double CurrentValue_ { get; set; }
        public double Vol_ { get; set; }

        //result 의 단위가격ex) 10000
        public double Unit_ { get; set; }

        public double Delta_ { get; set; }
        public double Gamma_ { get; set; }
        public double Vega_ { get; set; }

        public double DeltaPosition_ { get; set; }
        public double GammaPosition_ { get; set; }
        public double VegaPosition_ { get; set; }

        //public double DeltaAmt_ { get; set; }
        //public double GammaAmt_ { get; set; }
        //public double VegaAmt_ { get; set; }

        public void loadFromXml(XmlNode underInfoNode,XmlNode underResultNode)
        {
            this.ItemCode_ = underInfoNode["krCode"].InnerText;
            this.ItemName_ = underInfoNode["underName"].InnerText;
            this.CurrentValue_ = Convert.ToDouble(underInfoNode["currentValue"].InnerText);
            this.Vol_ = Convert.ToDouble(underInfoNode["volatility"].InnerText);

            this.Delta_ = Convert.ToDouble(underResultNode["delta"]["value"].InnerText);
            this.Gamma_ = Convert.ToDouble(underResultNode["gamma"]["value"].InnerText);
            this.Vega_ = Convert.ToDouble(underResultNode["vega"]["value"].InnerText);

            this.DeltaPosition_ = (Notional_ / Unit_) * (CurrentValue_ * Delta_);
            this.GammaPosition_ = (Notional_ / Unit_) * (CurrentValue_ * Gamma_);
            this.VegaPosition_ = Notional_  * ( Vega_ / 100 );

        }
    }
}
