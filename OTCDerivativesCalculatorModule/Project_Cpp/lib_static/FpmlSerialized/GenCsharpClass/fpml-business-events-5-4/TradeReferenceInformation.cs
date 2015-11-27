using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TradeReferenceInformation
    {
        public TradeReferenceInformation(XmlNode xmlNode)
        {
            XmlNodeList originatingEventNodeList = xmlNode.SelectNodes("originatingEvent");
            if (originatingEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in originatingEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        originatingEventIDRef = item.Attributes["id"].Name;
                        OriginatingEvent ob = OriginatingEvent();
                        IDManager.SetID(originatingEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        originatingEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        originatingEvent = new OriginatingEvent(item);
                    }
                }
            }
            
        
            XmlNodeList terminatingEventNodeList = xmlNode.SelectNodes("terminatingEvent");
            if (terminatingEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in terminatingEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        terminatingEventIDRef = item.Attributes["id"].Name;
                        TerminatingEvent ob = TerminatingEvent();
                        IDManager.SetID(terminatingEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        terminatingEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        terminatingEvent = new TerminatingEvent(item);
                    }
                }
            }
            
        
            XmlNodeList partyTradeIdentifierNodeList = xmlNode.SelectNodes("partyTradeIdentifier");
            
            foreach (XmlNode item in partyTradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyTradeIdentifierIDRef = item.Attributes["id"].Name;
                        List<PartyTradeIdentifier> ob = new List<PartyTradeIdentifier>();
                        ob.Add(new PartyTradeIdentifier(item));
                        IDManager.SetID(partyTradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyTradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    partyTradeIdentifier.Add(new PartyTradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNodeList partyTradeInformationNodeList = xmlNode.SelectNodes("partyTradeInformation");
            
            foreach (XmlNode item in partyTradeInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyTradeInformationIDRef = item.Attributes["id"].Name;
                        List<PartyTradeInformation> ob = new List<PartyTradeInformation>();
                        ob.Add(new PartyTradeInformation(item));
                        IDManager.SetID(partyTradeInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyTradeInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    partyTradeInformation.Add(new PartyTradeInformation(item));
                    }
                }
            }
            
        
            XmlNodeList productTypeNodeList = xmlNode.SelectNodes("productType");
            if (productTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in productTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        productTypeIDRef = item.Attributes["id"].Name;
                        ProductType ob = ProductType();
                        IDManager.SetID(productTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        productTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        productType = new ProductType(item);
                    }
                }
            }
            
        
            XmlNodeList productIdNodeList = xmlNode.SelectNodes("productId");
            if (productIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in productIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        productIdIDRef = item.Attributes["id"].Name;
                        ProductId ob = ProductId();
                        IDManager.SetID(productIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        productIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        productId = new ProductId(item);
                    }
                }
            }
            
        
        }
        
    
        #region OriginatingEvent
        private OriginatingEvent originatingEvent;
        public OriginatingEvent OriginatingEvent
        {
            get
            {
                if (this.originatingEvent != null)
                {
                    return this.originatingEvent; 
                }
                else if (this.originatingEventIDRef != null)
                {
                    originatingEvent = IDManager.getID(originatingEventIDRef) as OriginatingEvent;
                    return this.originatingEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.originatingEvent != value)
                {
                    this.originatingEvent = value;
                }
            }
        }
        #endregion
        
        public string OriginatingEventIDRef { get; set; }
        #region TerminatingEvent
        private TerminatingEvent terminatingEvent;
        public TerminatingEvent TerminatingEvent
        {
            get
            {
                if (this.terminatingEvent != null)
                {
                    return this.terminatingEvent; 
                }
                else if (this.terminatingEventIDRef != null)
                {
                    terminatingEvent = IDManager.getID(terminatingEventIDRef) as TerminatingEvent;
                    return this.terminatingEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.terminatingEvent != value)
                {
                    this.terminatingEvent = value;
                }
            }
        }
        #endregion
        
        public string TerminatingEventIDRef { get; set; }
        #region PartyTradeIdentifier
        private List<PartyTradeIdentifier> partyTradeIdentifier;
        public List<PartyTradeIdentifier> PartyTradeIdentifier
        {
            get
            {
                if (this.partyTradeIdentifier != null)
                {
                    return this.partyTradeIdentifier; 
                }
                else if (this.partyTradeIdentifierIDRef != null)
                {
                    partyTradeIdentifier = IDManager.getID(partyTradeIdentifierIDRef) as List<PartyTradeIdentifier>;
                    return this.partyTradeIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyTradeIdentifier != value)
                {
                    this.partyTradeIdentifier = value;
                }
            }
        }
        #endregion
        
        public string PartyTradeIdentifierIDRef { get; set; }
        #region PartyTradeInformation
        private List<PartyTradeInformation> partyTradeInformation;
        public List<PartyTradeInformation> PartyTradeInformation
        {
            get
            {
                if (this.partyTradeInformation != null)
                {
                    return this.partyTradeInformation; 
                }
                else if (this.partyTradeInformationIDRef != null)
                {
                    partyTradeInformation = IDManager.getID(partyTradeInformationIDRef) as List<PartyTradeInformation>;
                    return this.partyTradeInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyTradeInformation != value)
                {
                    this.partyTradeInformation = value;
                }
            }
        }
        #endregion
        
        public string PartyTradeInformationIDRef { get; set; }
        #region ProductType
        private ProductType productType;
        public ProductType ProductType
        {
            get
            {
                if (this.productType != null)
                {
                    return this.productType; 
                }
                else if (this.productTypeIDRef != null)
                {
                    productType = IDManager.getID(productTypeIDRef) as ProductType;
                    return this.productType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.productType != value)
                {
                    this.productType = value;
                }
            }
        }
        #endregion
        
        public string ProductTypeIDRef { get; set; }
        #region ProductId
        private ProductId productId;
        public ProductId ProductId
        {
            get
            {
                if (this.productId != null)
                {
                    return this.productId; 
                }
                else if (this.productIdIDRef != null)
                {
                    productId = IDManager.getID(productIdIDRef) as ProductId;
                    return this.productId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.productId != value)
                {
                    this.productId = value;
                }
            }
        }
        #endregion
        
        public string ProductIdIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

