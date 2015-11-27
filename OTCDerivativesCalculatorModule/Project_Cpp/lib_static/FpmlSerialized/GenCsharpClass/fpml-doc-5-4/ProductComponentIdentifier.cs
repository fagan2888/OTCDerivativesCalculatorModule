using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ProductComponentIdentifier
    {
        public ProductComponentIdentifier(XmlNode xmlNode)
        {
            XmlNodeList premiumProductReferenceNodeList = xmlNode.SelectNodes("premiumProductReference");
            if (premiumProductReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in premiumProductReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        premiumProductReferenceIDRef = item.Attributes["id"].Name;
                        ProductReference ob = ProductReference();
                        IDManager.SetID(premiumProductReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        premiumProductReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        premiumProductReference = new ProductReference(item);
                    }
                }
            }
            
        
            XmlNodeList issuerNodeList = xmlNode.SelectNodes("issuer");
            if (issuerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in issuerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        issuerIDRef = item.Attributes["id"].Name;
                        IssuerId ob = IssuerId();
                        IDManager.SetID(issuerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        issuerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        issuer = new IssuerId(item);
                    }
                }
            }
            
        
            XmlNodeList tradeIdNodeList = xmlNode.SelectNodes("tradeId");
            if (tradeIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tradeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeIdIDRef = item.Attributes["id"].Name;
                        TradeId ob = TradeId();
                        IDManager.SetID(tradeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tradeId = new TradeId(item);
                    }
                }
            }
            
        
        }
        
    
        #region PremiumProductReference
        private ProductReference premiumProductReference;
        public ProductReference PremiumProductReference
        {
            get
            {
                if (this.premiumProductReference != null)
                {
                    return this.premiumProductReference; 
                }
                else if (this.premiumProductReferenceIDRef != null)
                {
                    premiumProductReference = IDManager.getID(premiumProductReferenceIDRef) as ProductReference;
                    return this.premiumProductReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.premiumProductReference != value)
                {
                    this.premiumProductReference = value;
                }
            }
        }
        #endregion
        
        public string ProductReferenceIDRef { get; set; }
        #region Issuer
        private IssuerId issuer;
        public IssuerId Issuer
        {
            get
            {
                if (this.issuer != null)
                {
                    return this.issuer; 
                }
                else if (this.issuerIDRef != null)
                {
                    issuer = IDManager.getID(issuerIDRef) as IssuerId;
                    return this.issuer; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.issuer != value)
                {
                    this.issuer = value;
                }
            }
        }
        #endregion
        
        public string IssuerIdIDRef { get; set; }
        #region TradeId
        private TradeId tradeId;
        public TradeId TradeId
        {
            get
            {
                if (this.tradeId != null)
                {
                    return this.tradeId; 
                }
                else if (this.tradeIdIDRef != null)
                {
                    tradeId = IDManager.getID(tradeIdIDRef) as TradeId;
                    return this.tradeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tradeId != value)
                {
                    this.tradeId = value;
                }
            }
        }
        #endregion
        
        public string TradeIdIDRef { get; set; }
        
    
        
    
    }
    
}

