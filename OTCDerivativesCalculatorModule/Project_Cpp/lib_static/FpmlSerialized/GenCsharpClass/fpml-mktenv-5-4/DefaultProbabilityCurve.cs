using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DefaultProbabilityCurve
    {
        public DefaultProbabilityCurve(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList baseYieldCurveNodeList = xmlNode.SelectNodes("baseYieldCurve");
            if (baseYieldCurveNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in baseYieldCurveNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        baseYieldCurveIDRef = item.Attributes["id"].Name;
                        PricingStructureReference ob = PricingStructureReference();
                        IDManager.SetID(baseYieldCurveIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        baseYieldCurveIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        baseYieldCurve = new PricingStructureReference(item);
                    }
                }
            }
            
        
            XmlNodeList defaultProbabilitiesNodeList = xmlNode.SelectNodes("defaultProbabilities");
            if (defaultProbabilitiesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in defaultProbabilitiesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        defaultProbabilitiesIDRef = item.Attributes["id"].Name;
                        TermCurve ob = TermCurve();
                        IDManager.SetID(defaultProbabilitiesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        defaultProbabilitiesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        defaultProbabilities = new TermCurve(item);
                    }
                }
            }
            
        
        }
        
    
        #region BaseYieldCurve
        private PricingStructureReference baseYieldCurve;
        public PricingStructureReference BaseYieldCurve
        {
            get
            {
                if (this.baseYieldCurve != null)
                {
                    return this.baseYieldCurve; 
                }
                else if (this.baseYieldCurveIDRef != null)
                {
                    baseYieldCurve = IDManager.getID(baseYieldCurveIDRef) as PricingStructureReference;
                    return this.baseYieldCurve; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.baseYieldCurve != value)
                {
                    this.baseYieldCurve = value;
                }
            }
        }
        #endregion
        
        public string PricingStructureReferenceIDRef { get; set; }
        #region DefaultProbabilities
        private TermCurve defaultProbabilities;
        public TermCurve DefaultProbabilities
        {
            get
            {
                if (this.defaultProbabilities != null)
                {
                    return this.defaultProbabilities; 
                }
                else if (this.defaultProbabilitiesIDRef != null)
                {
                    defaultProbabilities = IDManager.getID(defaultProbabilitiesIDRef) as TermCurve;
                    return this.defaultProbabilities; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.defaultProbabilities != value)
                {
                    this.defaultProbabilities = value;
                }
            }
        }
        #endregion
        
        public string TermCurveIDRef { get; set; }
        
    
        
    
    }
    
}

