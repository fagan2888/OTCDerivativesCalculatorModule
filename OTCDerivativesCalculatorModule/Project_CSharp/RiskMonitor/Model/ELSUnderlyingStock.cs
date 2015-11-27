using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace RiskMonitor
{
    public class ELSUnderlyingStock : Underlying
    {
        public ELSUnderlyingStock(
                    //DateTime referenceDate,
                     string name,
                     long currentPrice,
                     double basePrice,
                     double dividend,
                     string associateDerivativesCode,
                     double volatiltity,
                     Delta delta,
                     Gamma gamma,
                     Vega vega)
        {
            //this.referenceDate_ = referenceDate;
            this.Name_ = name;
            this.CurrentPrice_ = currentPrice; // - Live
            
            //int Quantity_ 
            //double UnitPrice_ - Calculate

            this.BasePrice_ = basePrice;
            this.Dividend_ = dividend;
            this.AssociateDerivativesCode_ = associateDerivativesCode;
            this.Volatility_ = volatiltity;
            this.Delta_ = delta;
            this.Gamma_ = gamma;
            this.Vega_ = vega;

        }

        #region later use
        //public ELSUnderlyingStock(string name)
        //{
        //    Name_ = name;
        //    BasePrice_ = 100;
        //}

        public ELSUnderlyingStock(string name, double basePrice) 
        {
            Name_ = name;
            BasePrice_ = basePrice;
        }

        //public ELSUnderlyingStock(string name, double basePrice)
        //{
        //    Name_ = name;
        //    //BasePrice_ = basePrice;
        //}

        #endregion

        public override void buildProductXmlData(XmlWriter xmlWriter)
        {
            base.buildProductXmlData(xmlWriter);
            // 추가적으로 추가할것을 적음.
        }

        public void buildParametorXmlData(XmlWriter xmlWriter, ParameterSetting paraSetting)
        {
            //base.buildParametorXmlData(xmlWriter, paraSetting);
            // 추가적으로 추가할것을 적음.
        }

        private DateTime referenceDate_;

        public double CurrentPrice_ { get; set; } // Live

        public int Quantity_ { get; set; } // Live
        public double UnitPrice_ { get; set; } 

        //public double BasePrice_ { get; set; }

        //public int Position_ { get; set; }

        public string AssociateDerivativesCode_ { get; set; }
        public double Volatility_ { get; set; }


        #region ELSGreek

        public Delta Delta_ { get; set; }
        public Gamma Gamma_ { get; set; }
        public Vega Vega_ { get; set; }

        #endregion

    }
}
