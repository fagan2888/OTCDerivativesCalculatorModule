using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RequestTradeReferenceInformationUpdate : CorrectableRequestMessage
    {
        public RequestTradeReferenceInformationUpdate(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode tradeReferenceInformationNode = xmlNode.SelectSingleNode("tradeReferenceInformation");
            
            if (tradeReferenceInformationNode != null)
            {
                if (tradeReferenceInformationNode.Attributes["href"] != null || tradeReferenceInformationNode.Attributes["id"] != null) 
                {
                    if (tradeReferenceInformationNode.Attributes["id"] != null) 
                    {
                        tradeReferenceInformationIDRef_ = tradeReferenceInformationNode.Attributes["id"].Value;
                        TradeReferenceInformation ob = new TradeReferenceInformation(tradeReferenceInformationNode);
                        IDManager.SetID(tradeReferenceInformationIDRef_, ob);
                    }
                    else if (tradeReferenceInformationNode.Attributes["href"] != null)
                    {
                        tradeReferenceInformationIDRef_ = tradeReferenceInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tradeReferenceInformation_ = new TradeReferenceInformation(tradeReferenceInformationNode);
                    }
                }
                else
                {
                    tradeReferenceInformation_ = new TradeReferenceInformation(tradeReferenceInformationNode);
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
        
    
        #region TradeReferenceInformation_
        private TradeReferenceInformation tradeReferenceInformation_;
        public TradeReferenceInformation TradeReferenceInformation_
        {
            get
            {
                if (this.tradeReferenceInformation_ != null)
                {
                    return this.tradeReferenceInformation_; 
                }
                else if (this.tradeReferenceInformationIDRef_ != null)
                {
                    tradeReferenceInformation_ = IDManager.getID(tradeReferenceInformationIDRef_) as TradeReferenceInformation;
                    return this.tradeReferenceInformation_; 
                }
                else
                {
                      return this.tradeReferenceInformation_; 
                }
            }
            set
            {
                if (this.tradeReferenceInformation_ != value)
                {
                    this.tradeReferenceInformation_ = value;
                }
            }
        }
        #endregion
        
        public string tradeReferenceInformationIDRef_ { get; set; }
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

