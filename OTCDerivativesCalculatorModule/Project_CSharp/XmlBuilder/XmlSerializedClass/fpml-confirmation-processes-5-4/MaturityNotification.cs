using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MaturityNotification : CorrectableRequestMessage
    {
        public MaturityNotification(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode optionExpiryNode = xmlNode.SelectSingleNode("optionExpiry");
            
            if (optionExpiryNode != null)
            {
                if (optionExpiryNode.Attributes["href"] != null || optionExpiryNode.Attributes["id"] != null) 
                {
                    if (optionExpiryNode.Attributes["id"] != null) 
                    {
                        optionExpiryIDRef_ = optionExpiryNode.Attributes["id"].Value;
                        OptionExpiryBase ob = new OptionExpiryBase(optionExpiryNode);
                        IDManager.SetID(optionExpiryIDRef_, ob);
                    }
                    else if (optionExpiryNode.Attributes["href"] != null)
                    {
                        optionExpiryIDRef_ = optionExpiryNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionExpiry_ = new OptionExpiryBase(optionExpiryNode);
                    }
                }
                else
                {
                    optionExpiry_ = new OptionExpiryBase(optionExpiryNode);
                }
            }
            
        
            XmlNode tradeMaturityNode = xmlNode.SelectSingleNode("tradeMaturity");
            
            if (tradeMaturityNode != null)
            {
                if (tradeMaturityNode.Attributes["href"] != null || tradeMaturityNode.Attributes["id"] != null) 
                {
                    if (tradeMaturityNode.Attributes["id"] != null) 
                    {
                        tradeMaturityIDRef_ = tradeMaturityNode.Attributes["id"].Value;
                        TradeMaturity ob = new TradeMaturity(tradeMaturityNode);
                        IDManager.SetID(tradeMaturityIDRef_, ob);
                    }
                    else if (tradeMaturityNode.Attributes["href"] != null)
                    {
                        tradeMaturityIDRef_ = tradeMaturityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tradeMaturity_ = new TradeMaturity(tradeMaturityNode);
                    }
                }
                else
                {
                    tradeMaturity_ = new TradeMaturity(tradeMaturityNode);
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
        
    
        #region OptionExpiry_
        private OptionExpiryBase optionExpiry_;
        public OptionExpiryBase OptionExpiry_
        {
            get
            {
                if (this.optionExpiry_ != null)
                {
                    return this.optionExpiry_; 
                }
                else if (this.optionExpiryIDRef_ != null)
                {
                    optionExpiry_ = IDManager.getID(optionExpiryIDRef_) as OptionExpiryBase;
                    return this.optionExpiry_; 
                }
                else
                {
                      return this.optionExpiry_; 
                }
            }
            set
            {
                if (this.optionExpiry_ != value)
                {
                    this.optionExpiry_ = value;
                }
            }
        }
        #endregion
        
        public string optionExpiryIDRef_ { get; set; }
        #region TradeMaturity_
        private TradeMaturity tradeMaturity_;
        public TradeMaturity TradeMaturity_
        {
            get
            {
                if (this.tradeMaturity_ != null)
                {
                    return this.tradeMaturity_; 
                }
                else if (this.tradeMaturityIDRef_ != null)
                {
                    tradeMaturity_ = IDManager.getID(tradeMaturityIDRef_) as TradeMaturity;
                    return this.tradeMaturity_; 
                }
                else
                {
                      return this.tradeMaturity_; 
                }
            }
            set
            {
                if (this.tradeMaturity_ != value)
                {
                    this.tradeMaturity_ = value;
                }
            }
        }
        #endregion
        
        public string tradeMaturityIDRef_ { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

