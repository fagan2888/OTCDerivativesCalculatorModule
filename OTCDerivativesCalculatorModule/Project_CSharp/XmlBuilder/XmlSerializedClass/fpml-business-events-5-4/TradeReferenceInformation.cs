using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TradeReferenceInformation : ISerialized
    {
        public TradeReferenceInformation(XmlNode xmlNode)
        {
            XmlNode originatingEventNode = xmlNode.SelectSingleNode("originatingEvent");
            
            if (originatingEventNode != null)
            {
                if (originatingEventNode.Attributes["href"] != null || originatingEventNode.Attributes["id"] != null) 
                {
                    if (originatingEventNode.Attributes["id"] != null) 
                    {
                        originatingEventIDRef_ = originatingEventNode.Attributes["id"].Value;
                        OriginatingEvent ob = new OriginatingEvent(originatingEventNode);
                        IDManager.SetID(originatingEventIDRef_, ob);
                    }
                    else if (originatingEventNode.Attributes["href"] != null)
                    {
                        originatingEventIDRef_ = originatingEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        originatingEvent_ = new OriginatingEvent(originatingEventNode);
                    }
                }
                else
                {
                    originatingEvent_ = new OriginatingEvent(originatingEventNode);
                }
            }
            
        
            XmlNode terminatingEventNode = xmlNode.SelectSingleNode("terminatingEvent");
            
            if (terminatingEventNode != null)
            {
                if (terminatingEventNode.Attributes["href"] != null || terminatingEventNode.Attributes["id"] != null) 
                {
                    if (terminatingEventNode.Attributes["id"] != null) 
                    {
                        terminatingEventIDRef_ = terminatingEventNode.Attributes["id"].Value;
                        TerminatingEvent ob = new TerminatingEvent(terminatingEventNode);
                        IDManager.SetID(terminatingEventIDRef_, ob);
                    }
                    else if (terminatingEventNode.Attributes["href"] != null)
                    {
                        terminatingEventIDRef_ = terminatingEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        terminatingEvent_ = new TerminatingEvent(terminatingEventNode);
                    }
                }
                else
                {
                    terminatingEvent_ = new TerminatingEvent(terminatingEventNode);
                }
            }
            
        
            XmlNodeList partyTradeIdentifierNodeList = xmlNode.SelectNodes("partyTradeIdentifier");
            
            if (partyTradeIdentifierNodeList != null)
            {
                this.partyTradeIdentifier_ = new List<PartyTradeIdentifier>();
                foreach (XmlNode item in partyTradeIdentifierNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            partyTradeIdentifierIDRef_ = item.Attributes["id"].Value;
                            partyTradeIdentifier_.Add(new PartyTradeIdentifier(item));
                            IDManager.SetID(partyTradeIdentifierIDRef_, partyTradeIdentifier_[partyTradeIdentifier_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            partyTradeIdentifierIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        partyTradeIdentifier_.Add(new PartyTradeIdentifier(item));
                        }
                    }
                    else
                    {
                        partyTradeIdentifier_.Add(new PartyTradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNodeList partyTradeInformationNodeList = xmlNode.SelectNodes("partyTradeInformation");
            
            if (partyTradeInformationNodeList != null)
            {
                this.partyTradeInformation_ = new List<PartyTradeInformation>();
                foreach (XmlNode item in partyTradeInformationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            partyTradeInformationIDRef_ = item.Attributes["id"].Value;
                            partyTradeInformation_.Add(new PartyTradeInformation(item));
                            IDManager.SetID(partyTradeInformationIDRef_, partyTradeInformation_[partyTradeInformation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            partyTradeInformationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        partyTradeInformation_.Add(new PartyTradeInformation(item));
                        }
                    }
                    else
                    {
                        partyTradeInformation_.Add(new PartyTradeInformation(item));
                    }
                }
            }
            
        
            XmlNode productTypeNode = xmlNode.SelectSingleNode("productType");
            
            if (productTypeNode != null)
            {
                if (productTypeNode.Attributes["href"] != null || productTypeNode.Attributes["id"] != null) 
                {
                    if (productTypeNode.Attributes["id"] != null) 
                    {
                        productTypeIDRef_ = productTypeNode.Attributes["id"].Value;
                        ProductType ob = new ProductType(productTypeNode);
                        IDManager.SetID(productTypeIDRef_, ob);
                    }
                    else if (productTypeNode.Attributes["href"] != null)
                    {
                        productTypeIDRef_ = productTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        productType_ = new ProductType(productTypeNode);
                    }
                }
                else
                {
                    productType_ = new ProductType(productTypeNode);
                }
            }
            
        
            XmlNode productIdNode = xmlNode.SelectSingleNode("productId");
            
            if (productIdNode != null)
            {
                if (productIdNode.Attributes["href"] != null || productIdNode.Attributes["id"] != null) 
                {
                    if (productIdNode.Attributes["id"] != null) 
                    {
                        productIdIDRef_ = productIdNode.Attributes["id"].Value;
                        ProductId ob = new ProductId(productIdNode);
                        IDManager.SetID(productIdIDRef_, ob);
                    }
                    else if (productIdNode.Attributes["href"] != null)
                    {
                        productIdIDRef_ = productIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        productId_ = new ProductId(productIdNode);
                    }
                }
                else
                {
                    productId_ = new ProductId(productIdNode);
                }
            }
            
        
        }
        
    
        #region OriginatingEvent_
        private OriginatingEvent originatingEvent_;
        public OriginatingEvent OriginatingEvent_
        {
            get
            {
                if (this.originatingEvent_ != null)
                {
                    return this.originatingEvent_; 
                }
                else if (this.originatingEventIDRef_ != null)
                {
                    originatingEvent_ = IDManager.getID(originatingEventIDRef_) as OriginatingEvent;
                    return this.originatingEvent_; 
                }
                else
                {
                      return this.originatingEvent_; 
                }
            }
            set
            {
                if (this.originatingEvent_ != value)
                {
                    this.originatingEvent_ = value;
                }
            }
        }
        #endregion
        
        public string originatingEventIDRef_ { get; set; }
        #region TerminatingEvent_
        private TerminatingEvent terminatingEvent_;
        public TerminatingEvent TerminatingEvent_
        {
            get
            {
                if (this.terminatingEvent_ != null)
                {
                    return this.terminatingEvent_; 
                }
                else if (this.terminatingEventIDRef_ != null)
                {
                    terminatingEvent_ = IDManager.getID(terminatingEventIDRef_) as TerminatingEvent;
                    return this.terminatingEvent_; 
                }
                else
                {
                      return this.terminatingEvent_; 
                }
            }
            set
            {
                if (this.terminatingEvent_ != value)
                {
                    this.terminatingEvent_ = value;
                }
            }
        }
        #endregion
        
        public string terminatingEventIDRef_ { get; set; }
        #region PartyTradeIdentifier_
        private List<PartyTradeIdentifier> partyTradeIdentifier_;
        public List<PartyTradeIdentifier> PartyTradeIdentifier_
        {
            get
            {
                if (this.partyTradeIdentifier_ != null)
                {
                    return this.partyTradeIdentifier_; 
                }
                else if (this.partyTradeIdentifierIDRef_ != null)
                {
                    return this.partyTradeIdentifier_; 
                }
                else
                {
                      return this.partyTradeIdentifier_; 
                }
            }
            set
            {
                if (this.partyTradeIdentifier_ != value)
                {
                    this.partyTradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string partyTradeIdentifierIDRef_ { get; set; }
        #region PartyTradeInformation_
        private List<PartyTradeInformation> partyTradeInformation_;
        public List<PartyTradeInformation> PartyTradeInformation_
        {
            get
            {
                if (this.partyTradeInformation_ != null)
                {
                    return this.partyTradeInformation_; 
                }
                else if (this.partyTradeInformationIDRef_ != null)
                {
                    return this.partyTradeInformation_; 
                }
                else
                {
                      return this.partyTradeInformation_; 
                }
            }
            set
            {
                if (this.partyTradeInformation_ != value)
                {
                    this.partyTradeInformation_ = value;
                }
            }
        }
        #endregion
        
        public string partyTradeInformationIDRef_ { get; set; }
        #region ProductType_
        private ProductType productType_;
        public ProductType ProductType_
        {
            get
            {
                if (this.productType_ != null)
                {
                    return this.productType_; 
                }
                else if (this.productTypeIDRef_ != null)
                {
                    productType_ = IDManager.getID(productTypeIDRef_) as ProductType;
                    return this.productType_; 
                }
                else
                {
                      return this.productType_; 
                }
            }
            set
            {
                if (this.productType_ != value)
                {
                    this.productType_ = value;
                }
            }
        }
        #endregion
        
        public string productTypeIDRef_ { get; set; }
        #region ProductId_
        private ProductId productId_;
        public ProductId ProductId_
        {
            get
            {
                if (this.productId_ != null)
                {
                    return this.productId_; 
                }
                else if (this.productIdIDRef_ != null)
                {
                    productId_ = IDManager.getID(productIdIDRef_) as ProductId;
                    return this.productId_; 
                }
                else
                {
                      return this.productId_; 
                }
            }
            set
            {
                if (this.productId_ != value)
                {
                    this.productId_ = value;
                }
            }
        }
        #endregion
        
        public string productIdIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

