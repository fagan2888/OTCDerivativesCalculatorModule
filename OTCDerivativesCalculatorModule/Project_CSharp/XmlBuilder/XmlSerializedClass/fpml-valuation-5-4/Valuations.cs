using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Valuations : ISerialized
    {
        public Valuations(XmlNode xmlNode)
        {
            XmlNode valuationNode = xmlNode.SelectSingleNode("valuation");
            
            if (valuationNode != null)
            {
                if (valuationNode.Attributes["href"] != null || valuationNode.Attributes["id"] != null) 
                {
                    if (valuationNode.Attributes["id"] != null) 
                    {
                        valuationIDRef_ = valuationNode.Attributes["id"].Value;
                        AssetValuation ob = new AssetValuation(valuationNode);
                        IDManager.SetID(valuationIDRef_, ob);
                    }
                    else if (valuationNode.Attributes["href"] != null)
                    {
                        valuationIDRef_ = valuationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuation_ = new AssetValuation(valuationNode);
                    }
                }
                else
                {
                    valuation_ = new AssetValuation(valuationNode);
                }
            }
            
        
            XmlNode valuationReferenceNode = xmlNode.SelectSingleNode("valuationReference");
            
            if (valuationReferenceNode != null)
            {
                if (valuationReferenceNode.Attributes["href"] != null || valuationReferenceNode.Attributes["id"] != null) 
                {
                    if (valuationReferenceNode.Attributes["id"] != null) 
                    {
                        valuationReferenceIDRef_ = valuationReferenceNode.Attributes["id"].Value;
                        ValuationReference ob = new ValuationReference(valuationReferenceNode);
                        IDManager.SetID(valuationReferenceIDRef_, ob);
                    }
                    else if (valuationReferenceNode.Attributes["href"] != null)
                    {
                        valuationReferenceIDRef_ = valuationReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationReference_ = new ValuationReference(valuationReferenceNode);
                    }
                }
                else
                {
                    valuationReference_ = new ValuationReference(valuationReferenceNode);
                }
            }
            
        
        }
        
    
        #region Valuation_
        private AssetValuation valuation_;
        public AssetValuation Valuation_
        {
            get
            {
                if (this.valuation_ != null)
                {
                    return this.valuation_; 
                }
                else if (this.valuationIDRef_ != null)
                {
                    valuation_ = IDManager.getID(valuationIDRef_) as AssetValuation;
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
        #region ValuationReference_
        private ValuationReference valuationReference_;
        public ValuationReference ValuationReference_
        {
            get
            {
                if (this.valuationReference_ != null)
                {
                    return this.valuationReference_; 
                }
                else if (this.valuationReferenceIDRef_ != null)
                {
                    valuationReference_ = IDManager.getID(valuationReferenceIDRef_) as ValuationReference;
                    return this.valuationReference_; 
                }
                else
                {
                      return this.valuationReference_; 
                }
            }
            set
            {
                if (this.valuationReference_ != value)
                {
                    this.valuationReference_ = value;
                }
            }
        }
        #endregion
        
        public string valuationReferenceIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

