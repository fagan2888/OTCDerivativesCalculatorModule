using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DataDocument
    {
        public DataDocument(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList validationNodeList = xmlNode.SelectNodes("validation");
            
            foreach (XmlNode item in validationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        validationIDRef = item.Attributes["id"].Name;
                        List<Validation> ob = new List<Validation>();
                        ob.Add(new Validation(item));
                        IDManager.SetID(validationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        validationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    validation.Add(new Validation(item));
                    }
                }
            }
            
        
            XmlNodeList onBehalfOfNodeList = xmlNode.SelectNodes("onBehalfOf");
            if (onBehalfOfNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in onBehalfOfNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        onBehalfOfIDRef = item.Attributes["id"].Name;
                        OnBehalfOf ob = OnBehalfOf();
                        IDManager.SetID(onBehalfOfIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        onBehalfOfIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        onBehalfOf = new OnBehalfOf(item);
                    }
                }
            }
            
        
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
            
        
            XmlNodeList tradeNodeList = xmlNode.SelectNodes("trade");
            
            foreach (XmlNode item in tradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeIDRef = item.Attributes["id"].Name;
                        List<Trade> ob = new List<Trade>();
                        ob.Add(new Trade(item));
                        IDManager.SetID(tradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    trade.Add(new Trade(item));
                    }
                }
            }
            
        
            XmlNodeList portfolioNodeList = xmlNode.SelectNodes("portfolio");
            
            foreach (XmlNode item in portfolioNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        portfolioIDRef = item.Attributes["id"].Name;
                        List<Portfolio> ob = new List<Portfolio>();
                        ob.Add(new Portfolio(item));
                        IDManager.SetID(portfolioIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        portfolioIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    portfolio.Add(new Portfolio(item));
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
        
    
        #region Validation
        private List<Validation> validation;
        public List<Validation> Validation
        {
            get
            {
                if (this.validation != null)
                {
                    return this.validation; 
                }
                else if (this.validationIDRef != null)
                {
                    validation = IDManager.getID(validationIDRef) as List<Validation>;
                    return this.validation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.validation != value)
                {
                    this.validation = value;
                }
            }
        }
        #endregion
        
        public string ValidationIDRef { get; set; }
        #region OnBehalfOf
        private OnBehalfOf onBehalfOf;
        public OnBehalfOf OnBehalfOf
        {
            get
            {
                if (this.onBehalfOf != null)
                {
                    return this.onBehalfOf; 
                }
                else if (this.onBehalfOfIDRef != null)
                {
                    onBehalfOf = IDManager.getID(onBehalfOfIDRef) as OnBehalfOf;
                    return this.onBehalfOf; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.onBehalfOf != value)
                {
                    this.onBehalfOf = value;
                }
            }
        }
        #endregion
        
        public string OnBehalfOfIDRef { get; set; }
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
        #region Trade
        private List<Trade> trade;
        public List<Trade> Trade
        {
            get
            {
                if (this.trade != null)
                {
                    return this.trade; 
                }
                else if (this.tradeIDRef != null)
                {
                    trade = IDManager.getID(tradeIDRef) as List<Trade>;
                    return this.trade; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.trade != value)
                {
                    this.trade = value;
                }
            }
        }
        #endregion
        
        public string TradeIDRef { get; set; }
        #region Portfolio
        private List<Portfolio> portfolio;
        public List<Portfolio> Portfolio
        {
            get
            {
                if (this.portfolio != null)
                {
                    return this.portfolio; 
                }
                else if (this.portfolioIDRef != null)
                {
                    portfolio = IDManager.getID(portfolioIDRef) as List<Portfolio>;
                    return this.portfolio; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.portfolio != value)
                {
                    this.portfolio = value;
                }
            }
        }
        #endregion
        
        public string PortfolioIDRef { get; set; }
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

