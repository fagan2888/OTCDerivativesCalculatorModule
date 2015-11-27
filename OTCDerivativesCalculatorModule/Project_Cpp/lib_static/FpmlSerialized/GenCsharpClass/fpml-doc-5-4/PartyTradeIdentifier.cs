using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PartyTradeIdentifier
    {
        public PartyTradeIdentifier(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList linkIdNodeList = xmlNode.SelectNodes("linkId");
            
            foreach (XmlNode item in linkIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        linkIdIDRef = item.Attributes["id"].Name;
                        List<LinkId> ob = new List<LinkId>();
                        ob.Add(new LinkId(item));
                        IDManager.SetID(linkIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        linkIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    linkId.Add(new LinkId(item));
                    }
                }
            }
            
        
            XmlNodeList allocationTradeIdNodeList = xmlNode.SelectNodes("allocationTradeId");
            
            foreach (XmlNode item in allocationTradeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        allocationTradeIdIDRef = item.Attributes["id"].Name;
                        List<TradeIdentifier> ob = new List<TradeIdentifier>();
                        ob.Add(new TradeIdentifier(item));
                        IDManager.SetID(allocationTradeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        allocationTradeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    allocationTradeId.Add(new TradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNodeList blockTradeIdNodeList = xmlNode.SelectNodes("blockTradeId");
            if (blockTradeIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in blockTradeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        blockTradeIdIDRef = item.Attributes["id"].Name;
                        TradeIdentifier ob = TradeIdentifier();
                        IDManager.SetID(blockTradeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        blockTradeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        blockTradeId = new TradeIdentifier(item);
                    }
                }
            }
            
        
            XmlNodeList originatingTradeIdNodeList = xmlNode.SelectNodes("originatingTradeId");
            
            foreach (XmlNode item in originatingTradeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        originatingTradeIdIDRef = item.Attributes["id"].Name;
                        List<TradeIdentifier> ob = new List<TradeIdentifier>();
                        ob.Add(new TradeIdentifier(item));
                        IDManager.SetID(originatingTradeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        originatingTradeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    originatingTradeId.Add(new TradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNodeList productComponentIdentifierNodeList = xmlNode.SelectNodes("productComponentIdentifier");
            
            foreach (XmlNode item in productComponentIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        productComponentIdentifierIDRef = item.Attributes["id"].Name;
                        List<ProductComponentIdentifier> ob = new List<ProductComponentIdentifier>();
                        ob.Add(new ProductComponentIdentifier(item));
                        IDManager.SetID(productComponentIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        productComponentIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    productComponentIdentifier.Add(new ProductComponentIdentifier(item));
                    }
                }
            }
            
        
        }
        
    
        #region LinkId
        private List<LinkId> linkId;
        public List<LinkId> LinkId
        {
            get
            {
                if (this.linkId != null)
                {
                    return this.linkId; 
                }
                else if (this.linkIdIDRef != null)
                {
                    linkId = IDManager.getID(linkIdIDRef) as List<LinkId>;
                    return this.linkId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.linkId != value)
                {
                    this.linkId = value;
                }
            }
        }
        #endregion
        
        public string LinkIdIDRef { get; set; }
        #region AllocationTradeId
        private List<TradeIdentifier> allocationTradeId;
        public List<TradeIdentifier> AllocationTradeId
        {
            get
            {
                if (this.allocationTradeId != null)
                {
                    return this.allocationTradeId; 
                }
                else if (this.allocationTradeIdIDRef != null)
                {
                    allocationTradeId = IDManager.getID(allocationTradeIdIDRef) as List<TradeIdentifier>;
                    return this.allocationTradeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.allocationTradeId != value)
                {
                    this.allocationTradeId = value;
                }
            }
        }
        #endregion
        
        public string TradeIdentifierIDRef { get; set; }
        #region BlockTradeId
        private TradeIdentifier blockTradeId;
        public TradeIdentifier BlockTradeId
        {
            get
            {
                if (this.blockTradeId != null)
                {
                    return this.blockTradeId; 
                }
                else if (this.blockTradeIdIDRef != null)
                {
                    blockTradeId = IDManager.getID(blockTradeIdIDRef) as TradeIdentifier;
                    return this.blockTradeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.blockTradeId != value)
                {
                    this.blockTradeId = value;
                }
            }
        }
        #endregion
        
        public string TradeIdentifierIDRef { get; set; }
        #region OriginatingTradeId
        private List<TradeIdentifier> originatingTradeId;
        public List<TradeIdentifier> OriginatingTradeId
        {
            get
            {
                if (this.originatingTradeId != null)
                {
                    return this.originatingTradeId; 
                }
                else if (this.originatingTradeIdIDRef != null)
                {
                    originatingTradeId = IDManager.getID(originatingTradeIdIDRef) as List<TradeIdentifier>;
                    return this.originatingTradeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.originatingTradeId != value)
                {
                    this.originatingTradeId = value;
                }
            }
        }
        #endregion
        
        public string TradeIdentifierIDRef { get; set; }
        #region ProductComponentIdentifier
        private List<ProductComponentIdentifier> productComponentIdentifier;
        public List<ProductComponentIdentifier> ProductComponentIdentifier
        {
            get
            {
                if (this.productComponentIdentifier != null)
                {
                    return this.productComponentIdentifier; 
                }
                else if (this.productComponentIdentifierIDRef != null)
                {
                    productComponentIdentifier = IDManager.getID(productComponentIdentifierIDRef) as List<ProductComponentIdentifier>;
                    return this.productComponentIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.productComponentIdentifier != value)
                {
                    this.productComponentIdentifier = value;
                }
            }
        }
        #endregion
        
        public string ProductComponentIdentifierIDRef { get; set; }
        
    
        
    
    }
    
}

