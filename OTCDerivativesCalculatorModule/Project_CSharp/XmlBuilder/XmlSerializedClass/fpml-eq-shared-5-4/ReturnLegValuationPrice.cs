using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReturnLegValuationPrice : Price
    {
        public ReturnLegValuationPrice(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode valuationRulesNode = xmlNode.SelectSingleNode("valuationRules");
            
            if (valuationRulesNode != null)
            {
                if (valuationRulesNode.Attributes["href"] != null || valuationRulesNode.Attributes["id"] != null) 
                {
                    if (valuationRulesNode.Attributes["id"] != null) 
                    {
                        valuationRulesIDRef_ = valuationRulesNode.Attributes["id"].Value;
                        EquityValuation ob = new EquityValuation(valuationRulesNode);
                        IDManager.SetID(valuationRulesIDRef_, ob);
                    }
                    else if (valuationRulesNode.Attributes["href"] != null)
                    {
                        valuationRulesIDRef_ = valuationRulesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationRules_ = new EquityValuation(valuationRulesNode);
                    }
                }
                else
                {
                    valuationRules_ = new EquityValuation(valuationRulesNode);
                }
            }
            
        
        }
        
    
        #region ValuationRules_
        private EquityValuation valuationRules_;
        public EquityValuation ValuationRules_
        {
            get
            {
                if (this.valuationRules_ != null)
                {
                    return this.valuationRules_; 
                }
                else if (this.valuationRulesIDRef_ != null)
                {
                    valuationRules_ = IDManager.getID(valuationRulesIDRef_) as EquityValuation;
                    return this.valuationRules_; 
                }
                else
                {
                      return this.valuationRules_; 
                }
            }
            set
            {
                if (this.valuationRules_ != value)
                {
                    this.valuationRules_ = value;
                }
            }
        }
        #endregion
        
        public string valuationRulesIDRef_ { get; set; }
        
    
        
    
    }
    
}

