using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ConfirmationStatus : ResponseMessage
    {
        public ConfirmationStatus(XmlNode xmlNode)
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
                        EventStatus ob = new EventStatus(statusNode);
                        IDManager.SetID(statusIDRef_, ob);
                    }
                    else if (statusNode.Attributes["href"] != null)
                    {
                        statusIDRef_ = statusNode.Attributes["href"].Value;
                    }
                    else
                    {
                        status_ = new EventStatus(statusNode);
                    }
                }
                else
                {
                    status_ = new EventStatus(statusNode);
                }
            }
            
        
            XmlNode assertedEventNode = xmlNode.SelectSingleNode("assertedEvent");
            
            if (assertedEventNode != null)
            {
                if (assertedEventNode.Attributes["href"] != null || assertedEventNode.Attributes["id"] != null) 
                {
                    if (assertedEventNode.Attributes["id"] != null) 
                    {
                        assertedEventIDRef_ = assertedEventNode.Attributes["id"].Value;
                        EventsChoice ob = new EventsChoice(assertedEventNode);
                        IDManager.SetID(assertedEventIDRef_, ob);
                    }
                    else if (assertedEventNode.Attributes["href"] != null)
                    {
                        assertedEventIDRef_ = assertedEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        assertedEvent_ = new EventsChoice(assertedEventNode);
                    }
                }
                else
                {
                    assertedEvent_ = new EventsChoice(assertedEventNode);
                }
            }
            
        
            XmlNodeList proposedMatchNodeList = xmlNode.SelectNodes("proposedMatch");
            
            if (proposedMatchNodeList != null)
            {
                this.proposedMatch_ = new List<EventProposedMatch>();
                foreach (XmlNode item in proposedMatchNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            proposedMatchIDRef_ = item.Attributes["id"].Value;
                            proposedMatch_.Add(new EventProposedMatch(item));
                            IDManager.SetID(proposedMatchIDRef_, proposedMatch_[proposedMatch_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            proposedMatchIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        proposedMatch_.Add(new EventProposedMatch(item));
                        }
                    }
                    else
                    {
                        proposedMatch_.Add(new EventProposedMatch(item));
                    }
                }
            }
            
        
            XmlNode allegedEventNode = xmlNode.SelectSingleNode("allegedEvent");
            
            if (allegedEventNode != null)
            {
                if (allegedEventNode.Attributes["href"] != null || allegedEventNode.Attributes["id"] != null) 
                {
                    if (allegedEventNode.Attributes["id"] != null) 
                    {
                        allegedEventIDRef_ = allegedEventNode.Attributes["id"].Value;
                        EventsChoice ob = new EventsChoice(allegedEventNode);
                        IDManager.SetID(allegedEventIDRef_, ob);
                    }
                    else if (allegedEventNode.Attributes["href"] != null)
                    {
                        allegedEventIDRef_ = allegedEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        allegedEvent_ = new EventsChoice(allegedEventNode);
                    }
                }
                else
                {
                    allegedEvent_ = new EventsChoice(allegedEventNode);
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
        private EventStatus status_;
        public EventStatus Status_
        {
            get
            {
                if (this.status_ != null)
                {
                    return this.status_; 
                }
                else if (this.statusIDRef_ != null)
                {
                    status_ = IDManager.getID(statusIDRef_) as EventStatus;
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
        #region AssertedEvent_
        private EventsChoice assertedEvent_;
        public EventsChoice AssertedEvent_
        {
            get
            {
                if (this.assertedEvent_ != null)
                {
                    return this.assertedEvent_; 
                }
                else if (this.assertedEventIDRef_ != null)
                {
                    assertedEvent_ = IDManager.getID(assertedEventIDRef_) as EventsChoice;
                    return this.assertedEvent_; 
                }
                else
                {
                      return this.assertedEvent_; 
                }
            }
            set
            {
                if (this.assertedEvent_ != value)
                {
                    this.assertedEvent_ = value;
                }
            }
        }
        #endregion
        
        public string assertedEventIDRef_ { get; set; }
        #region ProposedMatch_
        private List<EventProposedMatch> proposedMatch_;
        public List<EventProposedMatch> ProposedMatch_
        {
            get
            {
                if (this.proposedMatch_ != null)
                {
                    return this.proposedMatch_; 
                }
                else if (this.proposedMatchIDRef_ != null)
                {
                    return this.proposedMatch_; 
                }
                else
                {
                      return this.proposedMatch_; 
                }
            }
            set
            {
                if (this.proposedMatch_ != value)
                {
                    this.proposedMatch_ = value;
                }
            }
        }
        #endregion
        
        public string proposedMatchIDRef_ { get; set; }
        #region AllegedEvent_
        private EventsChoice allegedEvent_;
        public EventsChoice AllegedEvent_
        {
            get
            {
                if (this.allegedEvent_ != null)
                {
                    return this.allegedEvent_; 
                }
                else if (this.allegedEventIDRef_ != null)
                {
                    allegedEvent_ = IDManager.getID(allegedEventIDRef_) as EventsChoice;
                    return this.allegedEvent_; 
                }
                else
                {
                      return this.allegedEvent_; 
                }
            }
            set
            {
                if (this.allegedEvent_ != value)
                {
                    this.allegedEvent_ = value;
                }
            }
        }
        #endregion
        
        public string allegedEventIDRef_ { get; set; }
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

