using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxCurveValuation
    {
        public FxCurveValuation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList settlementCurrencyYieldCurveNodeList = xmlNode.SelectNodes("settlementCurrencyYieldCurve");
            if (settlementCurrencyYieldCurveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementCurrencyYieldCurveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementCurrencyYieldCurveIDRef = item.Attributes["id"].Name;
                        PricingStructureReference ob = PricingStructureReference();
                        IDManager.SetID(settlementCurrencyYieldCurveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementCurrencyYieldCurveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementCurrencyYieldCurve = new PricingStructureReference(item);
                    }
                }
            }
            
        
            XmlNodeList forecastCurrencyYieldCurveNodeList = xmlNode.SelectNodes("forecastCurrencyYieldCurve");
            if (forecastCurrencyYieldCurveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in forecastCurrencyYieldCurveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        forecastCurrencyYieldCurveIDRef = item.Attributes["id"].Name;
                        PricingStructureReference ob = PricingStructureReference();
                        IDManager.SetID(forecastCurrencyYieldCurveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        forecastCurrencyYieldCurveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        forecastCurrencyYieldCurve = new PricingStructureReference(item);
                    }
                }
            }
            
        
            XmlNodeList spotRateNodeList = xmlNode.SelectNodes("spotRate");
            if (spotRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in spotRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spotRateIDRef = item.Attributes["id"].Name;
                        FxRateSet ob = FxRateSet();
                        IDManager.SetID(spotRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spotRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        spotRate = new FxRateSet(item);
                    }
                }
            }
            
        
            XmlNodeList fxForwardCurveNodeList = xmlNode.SelectNodes("fxForwardCurve");
            if (fxForwardCurveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxForwardCurveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxForwardCurveIDRef = item.Attributes["id"].Name;
                        TermCurve ob = TermCurve();
                        IDManager.SetID(fxForwardCurveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxForwardCurveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxForwardCurve = new TermCurve(item);
                    }
                }
            }
            
        
            XmlNodeList fxForwardPointsCurveNodeList = xmlNode.SelectNodes("fxForwardPointsCurve");
            if (fxForwardPointsCurveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxForwardPointsCurveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxForwardPointsCurveIDRef = item.Attributes["id"].Name;
                        TermCurve ob = TermCurve();
                        IDManager.SetID(fxForwardPointsCurveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxForwardPointsCurveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxForwardPointsCurve = new TermCurve(item);
                    }
                }
            }
            
        
        }
        
    
        #region SettlementCurrencyYieldCurve
        private PricingStructureReference settlementCurrencyYieldCurve;
        public PricingStructureReference SettlementCurrencyYieldCurve
        {
            get
            {
                if (this.settlementCurrencyYieldCurve != null)
                {
                    return this.settlementCurrencyYieldCurve; 
                }
                else if (this.settlementCurrencyYieldCurveIDRef != null)
                {
                    settlementCurrencyYieldCurve = IDManager.getID(settlementCurrencyYieldCurveIDRef) as PricingStructureReference;
                    return this.settlementCurrencyYieldCurve; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementCurrencyYieldCurve != value)
                {
                    this.settlementCurrencyYieldCurve = value;
                }
            }
        }
        #endregion
        
        public string PricingStructureReferenceIDRef { get; set; }
        #region ForecastCurrencyYieldCurve
        private PricingStructureReference forecastCurrencyYieldCurve;
        public PricingStructureReference ForecastCurrencyYieldCurve
        {
            get
            {
                if (this.forecastCurrencyYieldCurve != null)
                {
                    return this.forecastCurrencyYieldCurve; 
                }
                else if (this.forecastCurrencyYieldCurveIDRef != null)
                {
                    forecastCurrencyYieldCurve = IDManager.getID(forecastCurrencyYieldCurveIDRef) as PricingStructureReference;
                    return this.forecastCurrencyYieldCurve; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.forecastCurrencyYieldCurve != value)
                {
                    this.forecastCurrencyYieldCurve = value;
                }
            }
        }
        #endregion
        
        public string PricingStructureReferenceIDRef { get; set; }
        #region SpotRate
        private FxRateSet spotRate;
        public FxRateSet SpotRate
        {
            get
            {
                if (this.spotRate != null)
                {
                    return this.spotRate; 
                }
                else if (this.spotRateIDRef != null)
                {
                    spotRate = IDManager.getID(spotRateIDRef) as FxRateSet;
                    return this.spotRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spotRate != value)
                {
                    this.spotRate = value;
                }
            }
        }
        #endregion
        
        public string FxRateSetIDRef { get; set; }
        #region FxForwardCurve
        private TermCurve fxForwardCurve;
        public TermCurve FxForwardCurve
        {
            get
            {
                if (this.fxForwardCurve != null)
                {
                    return this.fxForwardCurve; 
                }
                else if (this.fxForwardCurveIDRef != null)
                {
                    fxForwardCurve = IDManager.getID(fxForwardCurveIDRef) as TermCurve;
                    return this.fxForwardCurve; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxForwardCurve != value)
                {
                    this.fxForwardCurve = value;
                }
            }
        }
        #endregion
        
        public string TermCurveIDRef { get; set; }
        #region FxForwardPointsCurve
        private TermCurve fxForwardPointsCurve;
        public TermCurve FxForwardPointsCurve
        {
            get
            {
                if (this.fxForwardPointsCurve != null)
                {
                    return this.fxForwardPointsCurve; 
                }
                else if (this.fxForwardPointsCurveIDRef != null)
                {
                    fxForwardPointsCurve = IDManager.getID(fxForwardPointsCurveIDRef) as TermCurve;
                    return this.fxForwardPointsCurve; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxForwardPointsCurve != value)
                {
                    this.fxForwardPointsCurve = value;
                }
            }
        }
        #endregion
        
        public string TermCurveIDRef { get; set; }
        
    
        
    
    }
    
}

