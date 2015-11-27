using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxCurveValuation : PricingStructureValuation
    {
        public FxCurveValuation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode settlementCurrencyYieldCurveNode = xmlNode.SelectSingleNode("settlementCurrencyYieldCurve");
            
            if (settlementCurrencyYieldCurveNode != null)
            {
                if (settlementCurrencyYieldCurveNode.Attributes["href"] != null || settlementCurrencyYieldCurveNode.Attributes["id"] != null) 
                {
                    if (settlementCurrencyYieldCurveNode.Attributes["id"] != null) 
                    {
                        settlementCurrencyYieldCurveIDRef_ = settlementCurrencyYieldCurveNode.Attributes["id"].Value;
                        PricingStructureReference ob = new PricingStructureReference(settlementCurrencyYieldCurveNode);
                        IDManager.SetID(settlementCurrencyYieldCurveIDRef_, ob);
                    }
                    else if (settlementCurrencyYieldCurveNode.Attributes["href"] != null)
                    {
                        settlementCurrencyYieldCurveIDRef_ = settlementCurrencyYieldCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementCurrencyYieldCurve_ = new PricingStructureReference(settlementCurrencyYieldCurveNode);
                    }
                }
                else
                {
                    settlementCurrencyYieldCurve_ = new PricingStructureReference(settlementCurrencyYieldCurveNode);
                }
            }
            
        
            XmlNode forecastCurrencyYieldCurveNode = xmlNode.SelectSingleNode("forecastCurrencyYieldCurve");
            
            if (forecastCurrencyYieldCurveNode != null)
            {
                if (forecastCurrencyYieldCurveNode.Attributes["href"] != null || forecastCurrencyYieldCurveNode.Attributes["id"] != null) 
                {
                    if (forecastCurrencyYieldCurveNode.Attributes["id"] != null) 
                    {
                        forecastCurrencyYieldCurveIDRef_ = forecastCurrencyYieldCurveNode.Attributes["id"].Value;
                        PricingStructureReference ob = new PricingStructureReference(forecastCurrencyYieldCurveNode);
                        IDManager.SetID(forecastCurrencyYieldCurveIDRef_, ob);
                    }
                    else if (forecastCurrencyYieldCurveNode.Attributes["href"] != null)
                    {
                        forecastCurrencyYieldCurveIDRef_ = forecastCurrencyYieldCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        forecastCurrencyYieldCurve_ = new PricingStructureReference(forecastCurrencyYieldCurveNode);
                    }
                }
                else
                {
                    forecastCurrencyYieldCurve_ = new PricingStructureReference(forecastCurrencyYieldCurveNode);
                }
            }
            
        
            XmlNode spotRateNode = xmlNode.SelectSingleNode("spotRate");
            
            if (spotRateNode != null)
            {
                if (spotRateNode.Attributes["href"] != null || spotRateNode.Attributes["id"] != null) 
                {
                    if (spotRateNode.Attributes["id"] != null) 
                    {
                        spotRateIDRef_ = spotRateNode.Attributes["id"].Value;
                        FxRateSet ob = new FxRateSet(spotRateNode);
                        IDManager.SetID(spotRateIDRef_, ob);
                    }
                    else if (spotRateNode.Attributes["href"] != null)
                    {
                        spotRateIDRef_ = spotRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spotRate_ = new FxRateSet(spotRateNode);
                    }
                }
                else
                {
                    spotRate_ = new FxRateSet(spotRateNode);
                }
            }
            
        
            XmlNode fxForwardCurveNode = xmlNode.SelectSingleNode("fxForwardCurve");
            
            if (fxForwardCurveNode != null)
            {
                if (fxForwardCurveNode.Attributes["href"] != null || fxForwardCurveNode.Attributes["id"] != null) 
                {
                    if (fxForwardCurveNode.Attributes["id"] != null) 
                    {
                        fxForwardCurveIDRef_ = fxForwardCurveNode.Attributes["id"].Value;
                        TermCurve ob = new TermCurve(fxForwardCurveNode);
                        IDManager.SetID(fxForwardCurveIDRef_, ob);
                    }
                    else if (fxForwardCurveNode.Attributes["href"] != null)
                    {
                        fxForwardCurveIDRef_ = fxForwardCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxForwardCurve_ = new TermCurve(fxForwardCurveNode);
                    }
                }
                else
                {
                    fxForwardCurve_ = new TermCurve(fxForwardCurveNode);
                }
            }
            
        
            XmlNode fxForwardPointsCurveNode = xmlNode.SelectSingleNode("fxForwardPointsCurve");
            
            if (fxForwardPointsCurveNode != null)
            {
                if (fxForwardPointsCurveNode.Attributes["href"] != null || fxForwardPointsCurveNode.Attributes["id"] != null) 
                {
                    if (fxForwardPointsCurveNode.Attributes["id"] != null) 
                    {
                        fxForwardPointsCurveIDRef_ = fxForwardPointsCurveNode.Attributes["id"].Value;
                        TermCurve ob = new TermCurve(fxForwardPointsCurveNode);
                        IDManager.SetID(fxForwardPointsCurveIDRef_, ob);
                    }
                    else if (fxForwardPointsCurveNode.Attributes["href"] != null)
                    {
                        fxForwardPointsCurveIDRef_ = fxForwardPointsCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxForwardPointsCurve_ = new TermCurve(fxForwardPointsCurveNode);
                    }
                }
                else
                {
                    fxForwardPointsCurve_ = new TermCurve(fxForwardPointsCurveNode);
                }
            }
            
        
        }
        
    
        #region SettlementCurrencyYieldCurve_
        private PricingStructureReference settlementCurrencyYieldCurve_;
        public PricingStructureReference SettlementCurrencyYieldCurve_
        {
            get
            {
                if (this.settlementCurrencyYieldCurve_ != null)
                {
                    return this.settlementCurrencyYieldCurve_; 
                }
                else if (this.settlementCurrencyYieldCurveIDRef_ != null)
                {
                    settlementCurrencyYieldCurve_ = IDManager.getID(settlementCurrencyYieldCurveIDRef_) as PricingStructureReference;
                    return this.settlementCurrencyYieldCurve_; 
                }
                else
                {
                      return this.settlementCurrencyYieldCurve_; 
                }
            }
            set
            {
                if (this.settlementCurrencyYieldCurve_ != value)
                {
                    this.settlementCurrencyYieldCurve_ = value;
                }
            }
        }
        #endregion
        
        public string settlementCurrencyYieldCurveIDRef_ { get; set; }
        #region ForecastCurrencyYieldCurve_
        private PricingStructureReference forecastCurrencyYieldCurve_;
        public PricingStructureReference ForecastCurrencyYieldCurve_
        {
            get
            {
                if (this.forecastCurrencyYieldCurve_ != null)
                {
                    return this.forecastCurrencyYieldCurve_; 
                }
                else if (this.forecastCurrencyYieldCurveIDRef_ != null)
                {
                    forecastCurrencyYieldCurve_ = IDManager.getID(forecastCurrencyYieldCurveIDRef_) as PricingStructureReference;
                    return this.forecastCurrencyYieldCurve_; 
                }
                else
                {
                      return this.forecastCurrencyYieldCurve_; 
                }
            }
            set
            {
                if (this.forecastCurrencyYieldCurve_ != value)
                {
                    this.forecastCurrencyYieldCurve_ = value;
                }
            }
        }
        #endregion
        
        public string forecastCurrencyYieldCurveIDRef_ { get; set; }
        #region SpotRate_
        private FxRateSet spotRate_;
        public FxRateSet SpotRate_
        {
            get
            {
                if (this.spotRate_ != null)
                {
                    return this.spotRate_; 
                }
                else if (this.spotRateIDRef_ != null)
                {
                    spotRate_ = IDManager.getID(spotRateIDRef_) as FxRateSet;
                    return this.spotRate_; 
                }
                else
                {
                      return this.spotRate_; 
                }
            }
            set
            {
                if (this.spotRate_ != value)
                {
                    this.spotRate_ = value;
                }
            }
        }
        #endregion
        
        public string spotRateIDRef_ { get; set; }
        #region FxForwardCurve_
        private TermCurve fxForwardCurve_;
        public TermCurve FxForwardCurve_
        {
            get
            {
                if (this.fxForwardCurve_ != null)
                {
                    return this.fxForwardCurve_; 
                }
                else if (this.fxForwardCurveIDRef_ != null)
                {
                    fxForwardCurve_ = IDManager.getID(fxForwardCurveIDRef_) as TermCurve;
                    return this.fxForwardCurve_; 
                }
                else
                {
                      return this.fxForwardCurve_; 
                }
            }
            set
            {
                if (this.fxForwardCurve_ != value)
                {
                    this.fxForwardCurve_ = value;
                }
            }
        }
        #endregion
        
        public string fxForwardCurveIDRef_ { get; set; }
        #region FxForwardPointsCurve_
        private TermCurve fxForwardPointsCurve_;
        public TermCurve FxForwardPointsCurve_
        {
            get
            {
                if (this.fxForwardPointsCurve_ != null)
                {
                    return this.fxForwardPointsCurve_; 
                }
                else if (this.fxForwardPointsCurveIDRef_ != null)
                {
                    fxForwardPointsCurve_ = IDManager.getID(fxForwardPointsCurveIDRef_) as TermCurve;
                    return this.fxForwardPointsCurve_; 
                }
                else
                {
                      return this.fxForwardPointsCurve_; 
                }
            }
            set
            {
                if (this.fxForwardPointsCurve_ != value)
                {
                    this.fxForwardPointsCurve_ = value;
                }
            }
        }
        #endregion
        
        public string fxForwardPointsCurveIDRef_ { get; set; }
        
    
        
    
    }
    
}

