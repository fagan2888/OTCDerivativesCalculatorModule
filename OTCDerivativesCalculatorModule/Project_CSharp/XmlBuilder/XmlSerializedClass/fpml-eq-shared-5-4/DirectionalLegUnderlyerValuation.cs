using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DirectionalLegUnderlyerValuation : DirectionalLegUnderlyer
    {
        public DirectionalLegUnderlyerValuation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode valuationNode = xmlNode.SelectSingleNode("valuation");
            
            if (valuationNode != null)
            {
                if (valuationNode.Attributes["href"] != null || valuationNode.Attributes["id"] != null) 
                {
                    if (valuationNode.Attributes["id"] != null) 
                    {
                        valuationIDRef_ = valuationNode.Attributes["id"].Value;
                        EquityValuation ob = new EquityValuation(valuationNode);
                        IDManager.SetID(valuationIDRef_, ob);
                    }
                    else if (valuationNode.Attributes["href"] != null)
                    {
                        valuationIDRef_ = valuationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuation_ = new EquityValuation(valuationNode);
                    }
                }
                else
                {
                    valuation_ = new EquityValuation(valuationNode);
                }
            }
            
        
        }
        
    
        #region Valuation_
        private EquityValuation valuation_;
        public EquityValuation Valuation_
        {
            get
            {
                if (this.valuation_ != null)
                {
                    return this.valuation_; 
                }
                else if (this.valuationIDRef_ != null)
                {
                    valuation_ = IDManager.getID(valuationIDRef_) as EquityValuation;
                    return this.valuation_; 
                }
                else
                {
                      return this.valuation_; 
                }
            }
            set
            {
                if (this.valuation_ != value)
                {
                    this.valuation_ = value;
                }
            }
        }
        #endregion
        
        public string valuationIDRef_ { get; set; }
        
    
        
    
    }
    
}

