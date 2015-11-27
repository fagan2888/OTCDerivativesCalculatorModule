using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DataDocument : Document
    {
        public DataDocument(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList validationNodeList = xmlNode.SelectNodes("validation");
            
            if (validationNodeList != null)
            {
                this.validation_ = new List<Validation>();
                foreach (XmlNode item in validationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            validationIDRef_ = item.Attributes["id"].Value;
                            validation_.Add(new Validation(item));
                            IDManager.SetID(validationIDRef_, validation_[validation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            validationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        validation_.Add(new Validation(item));
                        }
                    }
                    else
                    {
                        validation_.Add(new Validation(item));
                    }
                }
            }
            
        
            XmlNode onBehalfOfNode = xmlNode.SelectSingleNode("onBehalfOf");
            
            if (onBehalfOfNode != null)
            {
                if (onBehalfOfNode.Attributes["href"] != null || onBehalfOfNode.Attributes["id"] != null) 
                {
                    if (onBehalfOfNode.Attributes["id"] != null) 
                    {
                        onBehalfOfIDRef_ = onBehalfOfNode.Attributes["id"].Value;
                        OnBehalfOf ob = new OnBehalfOf(onBehalfOfNode);
                        IDManager.SetID(onBehalfOfIDRef_, ob);
                    }
                    else if (onBehalfOfNode.Attributes["href"] != null)
                    {
                        onBehalfOfIDRef_ = onBehalfOfNode.Attributes["href"].Value;
                    }
                    else
                    {
                        onBehalfOf_ = new OnBehalfOf(onBehalfOfNode);
                    }
                }
                else
                {
                    onBehalfOf_ = new OnBehalfOf(onBehalfOfNode);
                }
            }
            
        
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
            
        
            XmlNodeList tradeNodeList = xmlNode.SelectNodes("trade");
            
            if (tradeNodeList != null)
            {
                this.trade_ = new List<Trade>();
                foreach (XmlNode item in tradeNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            tradeIDRef_ = item.Attributes["id"].Value;
                            trade_.Add(new Trade(item));
                            IDManager.SetID(tradeIDRef_, trade_[trade_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            tradeIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        trade_.Add(new Trade(item));
                        }
                    }
                    else
                    {
                        trade_.Add(new Trade(item));
                    }
                }
            }
            
        
            XmlNodeList portfolioNodeList = xmlNode.SelectNodes("portfolio");
            
            if (portfolioNodeList != null)
            {
                this.portfolio_ = new List<Portfolio>();
                foreach (XmlNode item in portfolioNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            portfolioIDRef_ = item.Attributes["id"].Value;
                            portfolio_.Add(new Portfolio(item));
                            IDManager.SetID(portfolioIDRef_, portfolio_[portfolio_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            portfolioIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        portfolio_.Add(new Portfolio(item));
                        }
                    }
                    else
                    {
                        portfolio_.Add(new Portfolio(item));
                    }
                }
            }
            
        
            XmlNodeList partyNodeList = xmlNode.SelectNodes("party");
            
            if (partyNodeList != null)
            {
                this.party_ = new List<Party>();
                foreach (XmlNode item in partyNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            partyIDRef_ = item.Attributes["id"].Value;
                            party_.Add(new Party(item));
                            IDManager.SetID(partyIDRef_, party_[party_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            partyIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        party_.Add(new Party(item));
                        }
                    }
                    else
                    {
                        party_.Add(new Party(item));
                    }
                }
            }
            
        
            XmlNodeList accountNodeList = xmlNode.SelectNodes("account");
            
            if (accountNodeList != null)
            {
                this.account_ = new List<Account>();
                foreach (XmlNode item in accountNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            accountIDRef_ = item.Attributes["id"].Value;
                            account_.Add(new Account(item));
                            IDManager.SetID(accountIDRef_, account_[account_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            accountIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        account_.Add(new Account(item));
                        }
                    }
                    else
                    {
                        account_.Add(new Account(item));
                    }
                }
            }
            
        
        }
        
    
        #region Validation_
        private List<Validation> validation_;
        public List<Validation> Validation_
        {
            get
            {
                if (this.validation_ != null)
                {
                    return this.validation_; 
                }
                else if (this.validationIDRef_ != null)
                {
                    return this.validation_; 
                }
                else
                {
                      return this.validation_; 
                }
            }
            set
            {
                if (this.validation_ != value)
                {
                    this.validation_ = value;
                }
            }
        }
        #endregion
        
        public string validationIDRef_ { get; set; }
        #region OnBehalfOf_
        private OnBehalfOf onBehalfOf_;
        public OnBehalfOf OnBehalfOf_
        {
            get
            {
                if (this.onBehalfOf_ != null)
                {
                    return this.onBehalfOf_; 
                }
                else if (this.onBehalfOfIDRef_ != null)
                {
                    onBehalfOf_ = IDManager.getID(onBehalfOfIDRef_) as OnBehalfOf;
                    return this.onBehalfOf_; 
                }
                else
                {
                      return this.onBehalfOf_; 
                }
            }
            set
            {
                if (this.onBehalfOf_ != value)
                {
                    this.onBehalfOf_ = value;
                }
            }
        }
        #endregion
        
        public string onBehalfOfIDRef_ { get; set; }
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
        #region Trade_
        private List<Trade> trade_;
        public List<Trade> Trade_
        {
            get
            {
                if (this.trade_ != null)
                {
                    return this.trade_; 
                }
                else if (this.tradeIDRef_ != null)
                {
                    return this.trade_; 
                }
                else
                {
                      return this.trade_; 
                }
            }
            set
            {
                if (this.trade_ != value)
                {
                    this.trade_ = value;
                }
            }
        }
        #endregion
        
        public string tradeIDRef_ { get; set; }
        #region Portfolio_
        private List<Portfolio> portfolio_;
        public List<Portfolio> Portfolio_
        {
            get
            {
                if (this.portfolio_ != null)
                {
                    return this.portfolio_; 
                }
                else if (this.portfolioIDRef_ != null)
                {
                    return this.portfolio_; 
                }
                else
                {
                      return this.portfolio_; 
                }
            }
            set
            {
                if (this.portfolio_ != value)
                {
                    this.portfolio_ = value;
                }
            }
        }
        #endregion
        
        public string portfolioIDRef_ { get; set; }
        #region Party_
        private List<Party> party_;
        public List<Party> Party_
        {
            get
            {
                if (this.party_ != null)
                {
                    return this.party_; 
                }
                else if (this.partyIDRef_ != null)
                {
                    return this.party_; 
                }
                else
                {
                      return this.party_; 
                }
            }
            set
            {
                if (this.party_ != value)
                {
                    this.party_ = value;
                }
            }
        }
        #endregion
        
        public string partyIDRef_ { get; set; }
        #region Account_
        private List<Account> account_;
        public List<Account> Account_
        {
            get
            {
                if (this.account_ != null)
                {
                    return this.account_; 
                }
                else if (this.accountIDRef_ != null)
                {
                    return this.account_; 
                }
                else
                {
                      return this.account_; 
                }
            }
            set
            {
                if (this.account_ != value)
                {
                    this.account_ = value;
                }
            }
        }
        #endregion
        
        public string accountIDRef_ { get; set; }
        
    
        
    
    }
    
}

