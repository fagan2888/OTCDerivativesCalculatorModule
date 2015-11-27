using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityPremium : NonNegativePayment
    {
        public CommodityPremium(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode premiumPerUnitNode = xmlNode.SelectSingleNode("premiumPerUnit");
            
            if (premiumPerUnitNode != null)
            {
                if (premiumPerUnitNode.Attributes["href"] != null || premiumPerUnitNode.Attributes["id"] != null) 
                {
                    if (premiumPerUnitNode.Attributes["id"] != null) 
                    {
                        premiumPerUnitIDRef_ = premiumPerUnitNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(premiumPerUnitNode);
                        IDManager.SetID(premiumPerUnitIDRef_, ob);
                    }
                    else if (premiumPerUnitNode.Attributes["href"] != null)
                    {
                        premiumPerUnitIDRef_ = premiumPerUnitNode.Attributes["href"].Value;
                    }
                    else
                    {
                        premiumPerUnit_ = new NonNegativeMoney(premiumPerUnitNode);
                    }
                }
                else
                {
                    premiumPerUnit_ = new NonNegativeMoney(premiumPerUnitNode);
                }
            }
            
        
        }
        
    
        #region PremiumPerUnit_
        private NonNegativeMoney premiumPerUnit_;
        public NonNegativeMoney PremiumPerUnit_
        {
            get
            {
                if (this.premiumPerUnit_ != null)
                {
                    return this.premiumPerUnit_; 
                }
                else if (this.premiumPerUnitIDRef_ != null)
                {
                    premiumPerUnit_ = IDManager.getID(premiumPerUnitIDRef_) as NonNegativeMoney;
                    return this.premiumPerUnit_; 
                }
                else
                {
                      return this.premiumPerUnit_; 
                }
            }
            set
            {
                if (this.premiumPerUnit_ != value)
                {
                    this.premiumPerUnit_ = value;
                }
            }
        }
        #endregion
        
        public string premiumPerUnitIDRef_ { get; set; }
        
    
        
    
    }
    
}

