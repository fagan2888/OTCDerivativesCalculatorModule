using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AllocationRefused
    {
        public AllocationRefused(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList blockTradeIdentifierNodeList = xmlNode.SelectNodes("blockTradeIdentifier");
            if (blockTradeIdentifierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in blockTradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        blockTradeIdentifierIDRef = item.Attributes["id"].Name;
                        TradeIdentifier ob = TradeIdentifier();
                        IDManager.SetID(blockTradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        blockTradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        blockTradeIdentifier = new TradeIdentifier(item);
                    }
                }
            }
            
        
            XmlNodeList allocationsNodeList = xmlNode.SelectNodes("allocations");
            if (allocationsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in allocationsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        allocationsIDRef = item.Attributes["id"].Name;
                        Allocations ob = Allocations();
                        IDManager.SetID(allocationsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        allocationsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        allocations = new Allocations(item);
                    }
                }
            }
            
        
            XmlNodeList partyNodeList = xmlNode.SelectNodes("party");
            
            foreach (XmlNode item in partyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyIDRef = item.Attributes["id"].Name;
                        List<Party> ob = new List<Party>();
                        ob.Add(new Party(item));
                        IDManager.SetID(partyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    party.Add(new Party(item));
                    }
                }
            }
            
        
            XmlNodeList accountNodeList = xmlNode.SelectNodes("account");
            
            foreach (XmlNode item in accountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accountIDRef = item.Attributes["id"].Name;
                        List<Account> ob = new List<Account>();
                        ob.Add(new Account(item));
                        IDManager.SetID(accountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    account.Add(new Account(item));
                    }
                }
            }
            
        
            XmlNodeList reasonNodeList = xmlNode.SelectNodes("reason");
            
            foreach (XmlNode item in reasonNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        reasonIDRef = item.Attributes["id"].Name;
                        List<Reason> ob = new List<Reason>();
                        ob.Add(new Reason(item));
                        IDManager.SetID(reasonIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        reasonIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    reason.Add(new Reason(item));
                    }
                }
            }
            
        
        }
        
    
        #region BlockTradeIdentifier
        private TradeIdentifier blockTradeIdentifier;
        public TradeIdentifier BlockTradeIdentifier
        {
            get
            {
                if (this.blockTradeIdentifier != null)
                {
                    return this.blockTradeIdentifier; 
                }
                else if (this.blockTradeIdentifierIDRef != null)
                {
                    blockTradeIdentifier = IDManager.getID(blockTradeIdentifierIDRef) as TradeIdentifier;
                    return this.blockTradeIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.blockTradeIdentifier != value)
                {
                    this.blockTradeIdentifier = value;
                }
            }
        }
        #endregion
        
        public string TradeIdentifierIDRef { get; set; }
        #region Allocations
        private Allocations allocations;
        public Allocations Allocations
        {
            get
            {
                if (this.allocations != null)
                {
                    return this.allocations; 
                }
                else if (this.allocationsIDRef != null)
                {
                    allocations = IDManager.getID(allocationsIDRef) as Allocations;
                    return this.allocations; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.allocations != value)
                {
                    this.allocations = value;
                }
            }
        }
        #endregion
        
        public string AllocationsIDRef { get; set; }
        #region Party
        private List<Party> party;
        public List<Party> Party
        {
            get
            {
                if (this.party != null)
                {
                    return this.party; 
                }
                else if (this.partyIDRef != null)
                {
                    party = IDManager.getID(partyIDRef) as List<Party>;
                    return this.party; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.party != value)
                {
                    this.party = value;
                }
            }
        }
        #endregion
        
        public string PartyIDRef { get; set; }
        #region Account
        private List<Account> account;
        public List<Account> Account
        {
            get
            {
                if (this.account != null)
                {
                    return this.account; 
                }
                else if (this.accountIDRef != null)
                {
                    account = IDManager.getID(accountIDRef) as List<Account>;
                    return this.account; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.account != value)
                {
                    this.account = value;
                }
            }
        }
        #endregion
        
        public string AccountIDRef { get; set; }
        #region Reason
        private List<Reason> reason;
        public List<Reason> Reason
        {
            get
            {
                if (this.reason != null)
                {
                    return this.reason; 
                }
                else if (this.reasonIDRef != null)
                {
                    reason = IDManager.getID(reasonIDRef) as List<Reason>;
                    return this.reason; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.reason != value)
                {
                    this.reason = value;
                }
            }
        }
        #endregion
        
        public string ReasonIDRef { get; set; }
        
    
        
    
    }
    
}

