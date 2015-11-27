using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ParaRoot : ISerialized
    {
        public ParaRoot() { }
        public ParaRoot(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode pricingNode = xmlNode.SelectSingleNode("pricing");
            
            if (pricingNode != null)
            {
                if (pricingNode.Attributes["href"] != null || pricingNode.Attributes["id"] != null) 
                {
                    if (pricingNode.Attributes["id"] != null) 
                    {
                        pricingIDRef_ = pricingNode.Attributes["id"].Value;
                        Pricing ob = new Pricing(pricingNode);
                        IDManager.SetID(pricingIDRef_, ob);
                    }
                    else if (pricingNode.Attributes["href"] != null)
                    {
                        pricingIDRef_ = pricingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pricing_ = new Pricing(pricingNode);
                    }
                }
                else
                {
                    pricing_ = new Pricing(pricingNode);
                }
            }
            
        
        }
        
    
        #region Pricing_
        private Pricing pricing_;
        public Pricing Pricing_
        {
            get
            {
                if (this.pricing_ != null)
                {
                    return this.pricing_; 
                }
                else if (this.pricingIDRef_ != null)
                {
                    pricing_ = IDManager.getID(pricingIDRef_) as Pricing;
                    return this.pricing_; 
                }
                else
                {
                    throw new Exception( "pricing_Node no exist!");
                }
            }
            set
            {
                if (this.pricing_ != value)
                {
                    this.pricing_ = value;
                }
            }
        }
        #endregion
        
        public string pricingIDRef_ { get; set; }
        
    
        
    
    }
    
}

