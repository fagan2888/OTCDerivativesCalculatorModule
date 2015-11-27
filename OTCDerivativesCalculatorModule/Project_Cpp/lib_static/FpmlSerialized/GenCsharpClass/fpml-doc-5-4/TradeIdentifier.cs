using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TradeIdentifier
    {
        public TradeIdentifier(XmlNode xmlNode)
        {
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
            
        
            XmlNodeList partyReferenceNodeList = xmlNode.SelectNodes("partyReference");
            if (partyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in partyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(partyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        partyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList accountReferenceNodeList = xmlNode.SelectNodes("accountReference");
            if (accountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in accountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(accountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        accountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList versionedTradeIdNodeList = xmlNode.SelectNodes("versionedTradeId");
            if (versionedTradeIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in versionedTradeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        versionedTradeIdIDRef = item.Attributes["id"].Name;
                        VersionedTradeId ob = VersionedTradeId();
                        IDManager.SetID(versionedTradeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        versionedTradeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        versionedTradeId = new VersionedTradeId(item);
                    }
                }
            }
            
        
        }
        
    
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
        #region PartyReference
        private PartyReference partyReference;
        public PartyReference PartyReference
        {
            get
            {
                if (this.partyReference != null)
                {
                    return this.partyReference; 
                }
                else if (this.partyReferenceIDRef != null)
                {
                    partyReference = IDManager.getID(partyReferenceIDRef) as PartyReference;
                    return this.partyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyReference != value)
                {
                    this.partyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region AccountReference
        private AccountReference accountReference;
        public AccountReference AccountReference
        {
            get
            {
                if (this.accountReference != null)
                {
                    return this.accountReference; 
                }
                else if (this.accountReferenceIDRef != null)
                {
                    accountReference = IDManager.getID(accountReferenceIDRef) as AccountReference;
                    return this.accountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.accountReference != value)
                {
                    this.accountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region VersionedTradeId
        private VersionedTradeId versionedTradeId;
        public VersionedTradeId VersionedTradeId
        {
            get
            {
                if (this.versionedTradeId != null)
                {
                    return this.versionedTradeId; 
                }
                else if (this.versionedTradeIdIDRef != null)
                {
                    versionedTradeId = IDManager.getID(versionedTradeIdIDRef) as VersionedTradeId;
                    return this.versionedTradeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.versionedTradeId != value)
                {
                    this.versionedTradeId = value;
                }
            }
        }
        #endregion
        
        public string VersionedTradeIdIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

