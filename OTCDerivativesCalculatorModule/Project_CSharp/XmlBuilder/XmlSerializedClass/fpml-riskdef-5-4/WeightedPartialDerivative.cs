using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class WeightedPartialDerivative : ISerialized
    {
        public WeightedPartialDerivative(XmlNode xmlNode)
        {
            XmlNode partialDerivativeReferenceNode = xmlNode.SelectSingleNode("partialDerivativeReference");
            
            if (partialDerivativeReferenceNode != null)
            {
                if (partialDerivativeReferenceNode.Attributes["href"] != null || partialDerivativeReferenceNode.Attributes["id"] != null) 
                {
                    if (partialDerivativeReferenceNode.Attributes["id"] != null) 
                    {
                        partialDerivativeReferenceIDRef_ = partialDerivativeReferenceNode.Attributes["id"].Value;
                        PricingParameterDerivativeReference ob = new PricingParameterDerivativeReference(partialDerivativeReferenceNode);
                        IDManager.SetID(partialDerivativeReferenceIDRef_, ob);
                    }
                    else if (partialDerivativeReferenceNode.Attributes["href"] != null)
                    {
                        partialDerivativeReferenceIDRef_ = partialDerivativeReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partialDerivativeReference_ = new PricingParameterDerivativeReference(partialDerivativeReferenceNode);
                    }
                }
                else
                {
                    partialDerivativeReference_ = new PricingParameterDerivativeReference(partialDerivativeReferenceNode);
                }
            }
            
        
            XmlNode weightNode = xmlNode.SelectSingleNode("weight");
            
            if (weightNode != null)
            {
                if (weightNode.Attributes["href"] != null || weightNode.Attributes["id"] != null) 
                {
                    if (weightNode.Attributes["id"] != null) 
                    {
                        weightIDRef_ = weightNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(weightNode);
                        IDManager.SetID(weightIDRef_, ob);
                    }
                    else if (weightNode.Attributes["href"] != null)
                    {
                        weightIDRef_ = weightNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weight_ = new XsdTypeDecimal(weightNode);
                    }
                }
                else
                {
                    weight_ = new XsdTypeDecimal(weightNode);
                }
            }
            
        
        }
        
    
        #region PartialDerivativeReference_
        private PricingParameterDerivativeReference partialDerivativeReference_;
        public PricingParameterDerivativeReference PartialDerivativeReference_
        {
            get
            {
                if (this.partialDerivativeReference_ != null)
                {
                    return this.partialDerivativeReference_; 
                }
                else if (this.partialDerivativeReferenceIDRef_ != null)
                {
                    partialDerivativeReference_ = IDManager.getID(partialDerivativeReferenceIDRef_) as PricingParameterDerivativeReference;
                    return this.partialDerivativeReference_; 
                }
                else
                {
                      return this.partialDerivativeReference_; 
                }
            }
            set
            {
                if (this.partialDerivativeReference_ != value)
                {
                    this.partialDerivativeReference_ = value;
                }
            }
        }
        #endregion
        
        public string partialDerivativeReferenceIDRef_ { get; set; }
        #region Weight_
        private XsdTypeDecimal weight_;
        public XsdTypeDecimal Weight_
        {
            get
            {
                if (this.weight_ != null)
                {
                    return this.weight_; 
                }
                else if (this.weightIDRef_ != null)
                {
                    weight_ = IDManager.getID(weightIDRef_) as XsdTypeDecimal;
                    return this.weight_; 
                }
                else
                {
                      return this.weight_; 
                }
            }
            set
            {
                if (this.weight_ != value)
                {
                    this.weight_ = value;
                }
            }
        }
        #endregion
        
        public string weightIDRef_ { get; set; }
        
    
        
    
    }
    
}

