using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class RequestTradeReferenceInformationUpdateRetracted
    {
        public RequestTradeReferenceInformationUpdateRetracted(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList tradeReferenceInformationNodeList = xmlNode.SelectNodes("tradeReferenceInformation");
            if (tradeReferenceInformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tradeReferenceInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeReferenceInformationIDRef = item.Attributes["id"].Name;
                        TradeReferenceInformation ob = TradeReferenceInformation();
                        IDManager.SetID(tradeReferenceInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeReferenceInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tradeReferenceInformation = new TradeReferenceInformation(item);
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
        
    
        #region TradeReferenceInformation
        private TradeReferenceInformation tradeReferenceInformation;
        public TradeReferenceInformation TradeReferenceInformation
        {
            get
            {
                if (this.tradeReferenceInformation != null)
                {
                    return this.tradeReferenceInformation; 
                }
                else if (this.tradeReferenceInformationIDRef != null)
                {
                    tradeReferenceInformation = IDManager.getID(tradeReferenceInformationIDRef) as TradeReferenceInformation;
                    return this.tradeReferenceInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tradeReferenceInformation != value)
                {
                    this.tradeReferenceInformation = value;
                }
            }
        }
        #endregion
        
        public string TradeReferenceInformationIDRef { get; set; }
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
        
    
        
    
    }
    
}

