using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DefaultProbabilityCurve : PricingStructureValuation
    {
        public DefaultProbabilityCurve(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode baseYieldCurveNode = xmlNode.SelectSingleNode("baseYieldCurve");
            
            if (baseYieldCurveNode != null)
            {
                if (baseYieldCurveNode.Attributes["href"] != null || baseYieldCurveNode.Attributes["id"] != null) 
                {
                    if (baseYieldCurveNode.Attributes["id"] != null) 
                    {
                        baseYieldCurveIDRef_ = baseYieldCurveNode.Attributes["id"].Value;
                        PricingStructureReference ob = new PricingStructureReference(baseYieldCurveNode);
                        IDManager.SetID(baseYieldCurveIDRef_, ob);
                    }
                    else if (baseYieldCurveNode.Attributes["href"] != null)
                    {
                        baseYieldCurveIDRef_ = baseYieldCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        baseYieldCurve_ = new PricingStructureReference(baseYieldCurveNode);
                    }
                }
                else
                {
                    baseYieldCurve_ = new PricingStructureReference(baseYieldCurveNode);
                }
            }
            
        
            XmlNode defaultProbabilitiesNode = xmlNode.SelectSingleNode("defaultProbabilities");
            
            if (defaultProbabilitiesNode != null)
            {
                if (defaultProbabilitiesNode.Attributes["href"] != null || defaultProbabilitiesNode.Attributes["id"] != null) 
                {
                    if (defaultProbabilitiesNode.Attributes["id"] != null) 
                    {
                        defaultProbabilitiesIDRef_ = defaultProbabilitiesNode.Attributes["id"].Value;
                        TermCurve ob = new TermCurve(defaultProbabilitiesNode);
                        IDManager.SetID(defaultProbabilitiesIDRef_, ob);
                    }
                    else if (defaultProbabilitiesNode.Attributes["href"] != null)
                    {
                        defaultProbabilitiesIDRef_ = defaultProbabilitiesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        defaultProbabilities_ = new TermCurve(defaultProbabilitiesNode);
                    }
                }
                else
                {
                    defaultProbabilities_ = new TermCurve(defaultProbabilitiesNode);
                }
            }
            
        
        }
        
    
        #region BaseYieldCurve_
        private PricingStructureReference baseYieldCurve_;
        public PricingStructureReference BaseYieldCurve_
        {
            get
            {
                if (this.baseYieldCurve_ != null)
                {
                    return this.baseYieldCurve_; 
                }
                else if (this.baseYieldCurveIDRef_ != null)
                {
                    baseYieldCurve_ = IDManager.getID(baseYieldCurveIDRef_) as PricingStructureReference;
                    return this.baseYieldCurve_; 
                }
                else
                {
                      return this.baseYieldCurve_; 
                }
            }
            set
            {
                if (this.baseYieldCurve_ != value)
                {
                    this.baseYieldCurve_ = value;
                }
            }
        }
        #endregion
        
        public string baseYieldCurveIDRef_ { get; set; }
        #region DefaultProbabilities_
        private TermCurve defaultProbabilities_;
        public TermCurve DefaultProbabilities_
        {
            get
            {
                if (this.defaultProbabilities_ != null)
                {
                    return this.defaultProbabilities_; 
                }
                else if (this.defaultProbabilitiesIDRef_ != null)
                {
                    defaultProbabilities_ = IDManager.getID(defaultProbabilitiesIDRef_) as TermCurve;
                    return this.defaultProbabilities_; 
                }
                else
                {
                      return this.defaultProbabilities_; 
                }
            }
            set
            {
                if (this.defaultProbabilities_ != value)
                {
                    this.defaultProbabilities_ = value;
                }
            }
        }
        #endregion
        
        public string defaultProbabilitiesIDRef_ { get; set; }
        
    
        
    
    }
    
}

