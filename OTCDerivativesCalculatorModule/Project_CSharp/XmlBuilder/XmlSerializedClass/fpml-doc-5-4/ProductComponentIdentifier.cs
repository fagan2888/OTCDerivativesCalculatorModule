using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ProductComponentIdentifier : ISerialized
    {
        public ProductComponentIdentifier(XmlNode xmlNode)
        {
            XmlNode premiumProductReferenceNode = xmlNode.SelectSingleNode("premiumProductReference");
            
            if (premiumProductReferenceNode != null)
            {
                if (premiumProductReferenceNode.Attributes["href"] != null || premiumProductReferenceNode.Attributes["id"] != null) 
                {
                    if (premiumProductReferenceNode.Attributes["id"] != null) 
                    {
                        premiumProductReferenceIDRef_ = premiumProductReferenceNode.Attributes["id"].Value;
                        ProductReference ob = new ProductReference(premiumProductReferenceNode);
                        IDManager.SetID(premiumProductReferenceIDRef_, ob);
                    }
                    else if (premiumProductReferenceNode.Attributes["href"] != null)
                    {
                        premiumProductReferenceIDRef_ = premiumProductReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        premiumProductReference_ = new ProductReference(premiumProductReferenceNode);
                    }
                }
                else
                {
                    premiumProductReference_ = new ProductReference(premiumProductReferenceNode);
                }
            }
            
        
            XmlNode issuerNode = xmlNode.SelectSingleNode("issuer");
            
            if (issuerNode != null)
            {
                if (issuerNode.Attributes["href"] != null || issuerNode.Attributes["id"] != null) 
                {
                    if (issuerNode.Attributes["id"] != null) 
                    {
                        issuerIDRef_ = issuerNode.Attributes["id"].Value;
                        IssuerId ob = new IssuerId(issuerNode);
                        IDManager.SetID(issuerIDRef_, ob);
                    }
                    else if (issuerNode.Attributes["href"] != null)
                    {
                        issuerIDRef_ = issuerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        issuer_ = new IssuerId(issuerNode);
                    }
                }
                else
                {
                    issuer_ = new IssuerId(issuerNode);
                }
            }
            
        
            XmlNode tradeIdNode = xmlNode.SelectSingleNode("tradeId");
            
            if (tradeIdNode != null)
            {
                if (tradeIdNode.Attributes["href"] != null || tradeIdNode.Attributes["id"] != null) 
                {
                    if (tradeIdNode.Attributes["id"] != null) 
                    {
                        tradeIdIDRef_ = tradeIdNode.Attributes["id"].Value;
                        TradeId ob = new TradeId(tradeIdNode);
                        IDManager.SetID(tradeIdIDRef_, ob);
                    }
                    else if (tradeIdNode.Attributes["href"] != null)
                    {
                        tradeIdIDRef_ = tradeIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tradeId_ = new TradeId(tradeIdNode);
                    }
                }
                else
                {
                    tradeId_ = new TradeId(tradeIdNode);
                }
            }
            
        
        }
        
    
        #region PremiumProductReference_
        private ProductReference premiumProductReference_;
        public ProductReference PremiumProductReference_
        {
            get
            {
                if (this.premiumProductReference_ != null)
                {
                    return this.premiumProductReference_; 
                }
                else if (this.premiumProductReferenceIDRef_ != null)
                {
                    premiumProductReference_ = IDManager.getID(premiumProductReferenceIDRef_) as ProductReference;
                    return this.premiumProductReference_; 
                }
                else
                {
                      return this.premiumProductReference_; 
                }
            }
            set
            {
                if (this.premiumProductReference_ != value)
                {
                    this.premiumProductReference_ = value;
                }
            }
        }
        #endregion
        
        public string premiumProductReferenceIDRef_ { get; set; }
        #region Issuer_
        private IssuerId issuer_;
        public IssuerId Issuer_
        {
            get
            {
                if (this.issuer_ != null)
                {
                    return this.issuer_; 
                }
                else if (this.issuerIDRef_ != null)
                {
                    issuer_ = IDManager.getID(issuerIDRef_) as IssuerId;
                    return this.issuer_; 
                }
                else
                {
                      return this.issuer_; 
                }
            }
            set
            {
                if (this.issuer_ != value)
                {
                    this.issuer_ = value;
                }
            }
        }
        #endregion
        
        public string issuerIDRef_ { get; set; }
        #region TradeId_
        private TradeId tradeId_;
        public TradeId TradeId_
        {
            get
            {
                if (this.tradeId_ != null)
                {
                    return this.tradeId_; 
                }
                else if (this.tradeIdIDRef_ != null)
                {
                    tradeId_ = IDManager.getID(tradeIdIDRef_) as TradeId;
                    return this.tradeId_; 
                }
                else
                {
                      return this.tradeId_; 
                }
            }
            set
            {
                if (this.tradeId_ != value)
                {
                    this.tradeId_ = value;
                }
            }
        }
        #endregion
        
        public string tradeIdIDRef_ { get; set; }
        
    
        
    
    }
    
}

