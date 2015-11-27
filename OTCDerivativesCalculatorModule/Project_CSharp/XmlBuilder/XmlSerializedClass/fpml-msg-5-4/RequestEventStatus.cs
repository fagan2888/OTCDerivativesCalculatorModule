using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RequestEventStatus : NonCorrectableRequestMessage
    {
        public RequestEventStatus(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode businessProcessNode = xmlNode.SelectSingleNode("businessProcess");
            
            if (businessProcessNode != null)
            {
                if (businessProcessNode.Attributes["href"] != null || businessProcessNode.Attributes["id"] != null) 
                {
                    if (businessProcessNode.Attributes["id"] != null) 
                    {
                        businessProcessIDRef_ = businessProcessNode.Attributes["id"].Value;
                        BusinessProcess ob = new BusinessProcess(businessProcessNode);
                        IDManager.SetID(businessProcessIDRef_, ob);
                    }
                    else if (businessProcessNode.Attributes["href"] != null)
                    {
                        businessProcessIDRef_ = businessProcessNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessProcess_ = new BusinessProcess(businessProcessNode);
                    }
                }
                else
                {
                    businessProcess_ = new BusinessProcess(businessProcessNode);
                }
            }
            
        
            XmlNode eventIdentifierNode = xmlNode.SelectSingleNode("eventIdentifier");
            
            if (eventIdentifierNode != null)
            {
                if (eventIdentifierNode.Attributes["href"] != null || eventIdentifierNode.Attributes["id"] != null) 
                {
                    if (eventIdentifierNode.Attributes["id"] != null) 
                    {
                        eventIdentifierIDRef_ = eventIdentifierNode.Attributes["id"].Value;
                        EventIdentifier ob = new EventIdentifier(eventIdentifierNode);
                        IDManager.SetID(eventIdentifierIDRef_, ob);
                    }
                    else if (eventIdentifierNode.Attributes["href"] != null)
                    {
                        eventIdentifierIDRef_ = eventIdentifierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventIdentifier_ = new EventIdentifier(eventIdentifierNode);
                    }
                }
                else
                {
                    eventIdentifier_ = new EventIdentifier(eventIdentifierNode);
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
        
    
        #region BusinessProcess_
        private BusinessProcess businessProcess_;
        public BusinessProcess BusinessProcess_
        {
            get
            {
                if (this.businessProcess_ != null)
                {
                    return this.businessProcess_; 
                }
                else if (this.businessProcessIDRef_ != null)
                {
                    businessProcess_ = IDManager.getID(businessProcessIDRef_) as BusinessProcess;
                    return this.businessProcess_; 
                }
                else
                {
                      return this.businessProcess_; 
                }
            }
            set
            {
                if (this.businessProcess_ != value)
                {
                    this.businessProcess_ = value;
                }
            }
        }
        #endregion
        
        public string businessProcessIDRef_ { get; set; }
        #region EventIdentifier_
        private EventIdentifier eventIdentifier_;
        public EventIdentifier EventIdentifier_
        {
            get
            {
                if (this.eventIdentifier_ != null)
                {
                    return this.eventIdentifier_; 
                }
                else if (this.eventIdentifierIDRef_ != null)
                {
                    eventIdentifier_ = IDManager.getID(eventIdentifierIDRef_) as EventIdentifier;
                    return this.eventIdentifier_; 
                }
                else
                {
                      return this.eventIdentifier_; 
                }
            }
            set
            {
                if (this.eventIdentifier_ != value)
                {
                    this.eventIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string eventIdentifierIDRef_ { get; set; }
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

