using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PartyTradeIdentifier : TradeIdentifier
    {
        public PartyTradeIdentifier(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList linkIdNodeList = xmlNode.SelectNodes("linkId");
            
            if (linkIdNodeList != null)
            {
                this.linkId_ = new List<LinkId>();
                foreach (XmlNode item in linkIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            linkIdIDRef_ = item.Attributes["id"].Value;
                            linkId_.Add(new LinkId(item));
                            IDManager.SetID(linkIdIDRef_, linkId_[linkId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            linkIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        linkId_.Add(new LinkId(item));
                        }
                    }
                    else
                    {
                        linkId_.Add(new LinkId(item));
                    }
                }
            }
            
        
            XmlNodeList allocationTradeIdNodeList = xmlNode.SelectNodes("allocationTradeId");
            
            if (allocationTradeIdNodeList != null)
            {
                this.allocationTradeId_ = new List<TradeIdentifier>();
                foreach (XmlNode item in allocationTradeIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            allocationTradeIdIDRef_ = item.Attributes["id"].Value;
                            allocationTradeId_.Add(new TradeIdentifier(item));
                            IDManager.SetID(allocationTradeIdIDRef_, allocationTradeId_[allocationTradeId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            allocationTradeIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        allocationTradeId_.Add(new TradeIdentifier(item));
                        }
                    }
                    else
                    {
                        allocationTradeId_.Add(new TradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNode blockTradeIdNode = xmlNode.SelectSingleNode("blockTradeId");
            
            if (blockTradeIdNode != null)
            {
                if (blockTradeIdNode.Attributes["href"] != null || blockTradeIdNode.Attributes["id"] != null) 
                {
                    if (blockTradeIdNode.Attributes["id"] != null) 
                    {
                        blockTradeIdIDRef_ = blockTradeIdNode.Attributes["id"].Value;
                        TradeIdentifier ob = new TradeIdentifier(blockTradeIdNode);
                        IDManager.SetID(blockTradeIdIDRef_, ob);
                    }
                    else if (blockTradeIdNode.Attributes["href"] != null)
                    {
                        blockTradeIdIDRef_ = blockTradeIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        blockTradeId_ = new TradeIdentifier(blockTradeIdNode);
                    }
                }
                else
                {
                    blockTradeId_ = new TradeIdentifier(blockTradeIdNode);
                }
            }
            
        
            XmlNodeList originatingTradeIdNodeList = xmlNode.SelectNodes("originatingTradeId");
            
            if (originatingTradeIdNodeList != null)
            {
                this.originatingTradeId_ = new List<TradeIdentifier>();
                foreach (XmlNode item in originatingTradeIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            originatingTradeIdIDRef_ = item.Attributes["id"].Value;
                            originatingTradeId_.Add(new TradeIdentifier(item));
                            IDManager.SetID(originatingTradeIdIDRef_, originatingTradeId_[originatingTradeId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            originatingTradeIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        originatingTradeId_.Add(new TradeIdentifier(item));
                        }
                    }
                    else
                    {
                        originatingTradeId_.Add(new TradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNodeList productComponentIdentifierNodeList = xmlNode.SelectNodes("productComponentIdentifier");
            
            if (productComponentIdentifierNodeList != null)
            {
                this.productComponentIdentifier_ = new List<ProductComponentIdentifier>();
                foreach (XmlNode item in productComponentIdentifierNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            productComponentIdentifierIDRef_ = item.Attributes["id"].Value;
                            productComponentIdentifier_.Add(new ProductComponentIdentifier(item));
                            IDManager.SetID(productComponentIdentifierIDRef_, productComponentIdentifier_[productComponentIdentifier_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            productComponentIdentifierIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        productComponentIdentifier_.Add(new ProductComponentIdentifier(item));
                        }
                    }
                    else
                    {
                        productComponentIdentifier_.Add(new ProductComponentIdentifier(item));
                    }
                }
            }
            
        
        }
        
    
        #region LinkId_
        private List<LinkId> linkId_;
        public List<LinkId> LinkId_
        {
            get
            {
                if (this.linkId_ != null)
                {
                    return this.linkId_; 
                }
                else if (this.linkIdIDRef_ != null)
                {
                    return this.linkId_; 
                }
                else
                {
                      return this.linkId_; 
                }
            }
            set
            {
                if (this.linkId_ != value)
                {
                    this.linkId_ = value;
                }
            }
        }
        #endregion
        
        public string linkIdIDRef_ { get; set; }
        #region AllocationTradeId_
        private List<TradeIdentifier> allocationTradeId_;
        public List<TradeIdentifier> AllocationTradeId_
        {
            get
            {
                if (this.allocationTradeId_ != null)
                {
                    return this.allocationTradeId_; 
                }
                else if (this.allocationTradeIdIDRef_ != null)
                {
                    return this.allocationTradeId_; 
                }
                else
                {
                      return this.allocationTradeId_; 
                }
            }
            set
            {
                if (this.allocationTradeId_ != value)
                {
                    this.allocationTradeId_ = value;
                }
            }
        }
        #endregion
        
        public string allocationTradeIdIDRef_ { get; set; }
        #region BlockTradeId_
        private TradeIdentifier blockTradeId_;
        public TradeIdentifier BlockTradeId_
        {
            get
            {
                if (this.blockTradeId_ != null)
                {
                    return this.blockTradeId_; 
                }
                else if (this.blockTradeIdIDRef_ != null)
                {
                    blockTradeId_ = IDManager.getID(blockTradeIdIDRef_) as TradeIdentifier;
                    return this.blockTradeId_; 
                }
                else
                {
                      return this.blockTradeId_; 
                }
            }
            set
            {
                if (this.blockTradeId_ != value)
                {
                    this.blockTradeId_ = value;
                }
            }
        }
        #endregion
        
        public string blockTradeIdIDRef_ { get; set; }
        #region OriginatingTradeId_
        private List<TradeIdentifier> originatingTradeId_;
        public List<TradeIdentifier> OriginatingTradeId_
        {
            get
            {
                if (this.originatingTradeId_ != null)
                {
                    return this.originatingTradeId_; 
                }
                else if (this.originatingTradeIdIDRef_ != null)
                {
                    return this.originatingTradeId_; 
                }
                else
                {
                      return this.originatingTradeId_; 
                }
            }
            set
            {
                if (this.originatingTradeId_ != value)
                {
                    this.originatingTradeId_ = value;
                }
            }
        }
        #endregion
        
        public string originatingTradeIdIDRef_ { get; set; }
        #region ProductComponentIdentifier_
        private List<ProductComponentIdentifier> productComponentIdentifier_;
        public List<ProductComponentIdentifier> ProductComponentIdentifier_
        {
            get
            {
                if (this.productComponentIdentifier_ != null)
                {
                    return this.productComponentIdentifier_; 
                }
                else if (this.productComponentIdentifierIDRef_ != null)
                {
                    return this.productComponentIdentifier_; 
                }
                else
                {
                      return this.productComponentIdentifier_; 
                }
            }
            set
            {
                if (this.productComponentIdentifier_ != value)
                {
                    this.productComponentIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string productComponentIdentifierIDRef_ { get; set; }
        
    
        
    
    }
    
}

