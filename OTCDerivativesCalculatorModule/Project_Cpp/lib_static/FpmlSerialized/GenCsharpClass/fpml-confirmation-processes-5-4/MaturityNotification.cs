using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class MaturityNotification
    {
        public MaturityNotification(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList optionExpiryNodeList = xmlNode.SelectNodes("optionExpiry");
            if (optionExpiryNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionExpiryNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionExpiryIDRef = item.Attributes["id"].Name;
                        OptionExpiryBase ob = OptionExpiryBase();
                        IDManager.SetID(optionExpiryIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionExpiryIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionExpiry = new OptionExpiryBase(item);
                    }
                }
            }
            
        
            XmlNodeList tradeMaturityNodeList = xmlNode.SelectNodes("tradeMaturity");
            if (tradeMaturityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tradeMaturityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeMaturityIDRef = item.Attributes["id"].Name;
                        TradeMaturity ob = TradeMaturity();
                        IDManager.SetID(tradeMaturityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeMaturityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tradeMaturity = new TradeMaturity(item);
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
            
        
        }
        
    
        #region OptionExpiry
        private OptionExpiryBase optionExpiry;
        public OptionExpiryBase OptionExpiry
        {
            get
            {
                if (this.optionExpiry != null)
                {
                    return this.optionExpiry; 
                }
                else if (this.optionExpiryIDRef != null)
                {
                    optionExpiry = IDManager.getID(optionExpiryIDRef) as OptionExpiryBase;
                    return this.optionExpiry; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionExpiry != value)
                {
                    this.optionExpiry = value;
                }
            }
        }
        #endregion
        
        public string OptionExpiryBaseIDRef { get; set; }
        #region TradeMaturity
        private TradeMaturity tradeMaturity;
        public TradeMaturity TradeMaturity
        {
            get
            {
                if (this.tradeMaturity != null)
                {
                    return this.tradeMaturity; 
                }
                else if (this.tradeMaturityIDRef != null)
                {
                    tradeMaturity = IDManager.getID(tradeMaturityIDRef) as TradeMaturity;
                    return this.tradeMaturity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tradeMaturity != value)
                {
                    this.tradeMaturity = value;
                }
            }
        }
        #endregion
        
        public string TradeMaturityIDRef { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

