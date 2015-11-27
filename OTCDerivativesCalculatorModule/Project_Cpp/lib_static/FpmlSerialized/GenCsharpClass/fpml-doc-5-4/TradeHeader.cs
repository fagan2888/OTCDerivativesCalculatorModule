using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TradeHeader
    {
        public TradeHeader(XmlNode xmlNode)
        {
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
            
        
            XmlNodeList tradeDateNodeList = xmlNode.SelectNodes("tradeDate");
            if (tradeDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tradeDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeDateIDRef = item.Attributes["id"].Name;
                        IdentifiedDate ob = IdentifiedDate();
                        IDManager.SetID(tradeDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tradeDate = new IdentifiedDate(item);
                    }
                }
            }
            
        
            XmlNodeList clearedDateNodeList = xmlNode.SelectNodes("clearedDate");
            if (clearedDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in clearedDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        clearedDateIDRef = item.Attributes["id"].Name;
                        IdentifiedDate ob = IdentifiedDate();
                        IDManager.SetID(clearedDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        clearedDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        clearedDate = new IdentifiedDate(item);
                    }
                }
            }
            
        
        }
        
    
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
        #region TradeDate
        private IdentifiedDate tradeDate;
        public IdentifiedDate TradeDate
        {
            get
            {
                if (this.tradeDate != null)
                {
                    return this.tradeDate; 
                }
                else if (this.tradeDateIDRef != null)
                {
                    tradeDate = IDManager.getID(tradeDateIDRef) as IdentifiedDate;
                    return this.tradeDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tradeDate != value)
                {
                    this.tradeDate = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedDateIDRef { get; set; }
        #region ClearedDate
        private IdentifiedDate clearedDate;
        public IdentifiedDate ClearedDate
        {
            get
            {
                if (this.clearedDate != null)
                {
                    return this.clearedDate; 
                }
                else if (this.clearedDateIDRef != null)
                {
                    clearedDate = IDManager.getID(clearedDateIDRef) as IdentifiedDate;
                    return this.clearedDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.clearedDate != value)
                {
                    this.clearedDate = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedDateIDRef { get; set; }
        
    
        
    
    }
    
}

