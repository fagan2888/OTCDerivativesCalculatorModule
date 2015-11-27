using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VerificationStatusNotification : NonCorrectableRequestMessage
    {
        public VerificationStatusNotification(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode statusNode = xmlNode.SelectSingleNode("status");
            
            if (statusNode != null)
            {
                if (statusNode.Attributes["href"] != null || statusNode.Attributes["id"] != null) 
                {
                    if (statusNode.Attributes["id"] != null) 
                    {
                        statusIDRef_ = statusNode.Attributes["id"].Value;
                        VerificationStatus ob = new VerificationStatus(statusNode);
                        IDManager.SetID(statusIDRef_, ob);
                    }
                    else if (statusNode.Attributes["href"] != null)
                    {
                        statusIDRef_ = statusNode.Attributes["href"].Value;
                    }
                    else
                    {
                        status_ = new VerificationStatus(statusNode);
                    }
                }
                else
                {
                    status_ = new VerificationStatus(statusNode);
                }
            }
            
        
            XmlNodeList reasonNodeList = xmlNode.SelectNodes("reason");
            
            if (reasonNodeList != null)
            {
                this.reason_ = new List<Reason>();
                foreach (XmlNode item in reasonNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            reasonIDRef_ = item.Attributes["id"].Value;
                            reason_.Add(new Reason(item));
                            IDManager.SetID(reasonIDRef_, reason_[reason_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            reasonIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        reason_.Add(new Reason(item));
                        }
                    }
                    else
                    {
                        reason_.Add(new Reason(item));
                    }
                }
            }
            
        
            XmlNode partyTradeIdentifierNode = xmlNode.SelectSingleNode("partyTradeIdentifier");
            
            if (partyTradeIdentifierNode != null)
            {
                if (partyTradeIdentifierNode.Attributes["href"] != null || partyTradeIdentifierNode.Attributes["id"] != null) 
                {
                    if (partyTradeIdentifierNode.Attributes["id"] != null) 
                    {
                        partyTradeIdentifierIDRef_ = partyTradeIdentifierNode.Attributes["id"].Value;
                        PartyTradeIdentifier ob = new PartyTradeIdentifier(partyTradeIdentifierNode);
                        IDManager.SetID(partyTradeIdentifierIDRef_, ob);
                    }
                    else if (partyTradeIdentifierNode.Attributes["href"] != null)
                    {
                        partyTradeIdentifierIDRef_ = partyTradeIdentifierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partyTradeIdentifier_ = new PartyTradeIdentifier(partyTradeIdentifierNode);
                    }
                }
                else
                {
                    partyTradeIdentifier_ = new PartyTradeIdentifier(partyTradeIdentifierNode);
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
        
    
        #region Status_
        private VerificationStatus status_;
        public VerificationStatus Status_
        {
            get
            {
                if (this.status_ != null)
                {
                    return this.status_; 
                }
                else if (this.statusIDRef_ != null)
                {
                    status_ = IDManager.getID(statusIDRef_) as VerificationStatus;
                    return this.status_; 
                }
                else
                {
                      return this.status_; 
                }
            }
            set
            {
                if (this.status_ != value)
                {
                    this.status_ = value;
                }
            }
        }
        #endregion
        
        public string statusIDRef_ { get; set; }
        #region Reason_
        private List<Reason> reason_;
        public List<Reason> Reason_
        {
            get
            {
                if (this.reason_ != null)
                {
                    return this.reason_; 
                }
                else if (this.reasonIDRef_ != null)
                {
                    return this.reason_; 
                }
                else
                {
                      return this.reason_; 
                }
            }
            set
            {
                if (this.reason_ != value)
                {
                    this.reason_ = value;
                }
            }
        }
        #endregion
        
        public string reasonIDRef_ { get; set; }
        #region PartyTradeIdentifier_
        private PartyTradeIdentifier partyTradeIdentifier_;
        public PartyTradeIdentifier PartyTradeIdentifier_
        {
            get
            {
                if (this.partyTradeIdentifier_ != null)
                {
                    return this.partyTradeIdentifier_; 
                }
                else if (this.partyTradeIdentifierIDRef_ != null)
                {
                    partyTradeIdentifier_ = IDManager.getID(partyTradeIdentifierIDRef_) as PartyTradeIdentifier;
                    return this.partyTradeIdentifier_; 
                }
                else
                {
                      return this.partyTradeIdentifier_; 
                }
            }
            set
            {
                if (this.partyTradeIdentifier_ != value)
                {
                    this.partyTradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string partyTradeIdentifierIDRef_ { get; set; }
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

