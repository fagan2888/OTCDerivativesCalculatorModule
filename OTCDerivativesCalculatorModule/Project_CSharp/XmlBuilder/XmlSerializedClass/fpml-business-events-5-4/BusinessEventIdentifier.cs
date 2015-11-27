using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BusinessEventIdentifier : ISerialized
    {
        public BusinessEventIdentifier(XmlNode xmlNode)
        {
            XmlNode partyReferenceNode = xmlNode.SelectSingleNode("partyReference");
            
            if (partyReferenceNode != null)
            {
                if (partyReferenceNode.Attributes["href"] != null || partyReferenceNode.Attributes["id"] != null) 
                {
                    if (partyReferenceNode.Attributes["id"] != null) 
                    {
                        partyReferenceIDRef_ = partyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(partyReferenceNode);
                        IDManager.SetID(partyReferenceIDRef_, ob);
                    }
                    else if (partyReferenceNode.Attributes["href"] != null)
                    {
                        partyReferenceIDRef_ = partyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partyReference_ = new PartyReference(partyReferenceNode);
                    }
                }
                else
                {
                    partyReference_ = new PartyReference(partyReferenceNode);
                }
            }
            
        
            XmlNode accountReferenceNode = xmlNode.SelectSingleNode("accountReference");
            
            if (accountReferenceNode != null)
            {
                if (accountReferenceNode.Attributes["href"] != null || accountReferenceNode.Attributes["id"] != null) 
                {
                    if (accountReferenceNode.Attributes["id"] != null) 
                    {
                        accountReferenceIDRef_ = accountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(accountReferenceNode);
                        IDManager.SetID(accountReferenceIDRef_, ob);
                    }
                    else if (accountReferenceNode.Attributes["href"] != null)
                    {
                        accountReferenceIDRef_ = accountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        accountReference_ = new AccountReference(accountReferenceNode);
                    }
                }
                else
                {
                    accountReference_ = new AccountReference(accountReferenceNode);
                }
            }
            
        
            XmlNode eventIdNode = xmlNode.SelectSingleNode("eventId");
            
            if (eventIdNode != null)
            {
                if (eventIdNode.Attributes["href"] != null || eventIdNode.Attributes["id"] != null) 
                {
                    if (eventIdNode.Attributes["id"] != null) 
                    {
                        eventIdIDRef_ = eventIdNode.Attributes["id"].Value;
                        EventId ob = new EventId(eventIdNode);
                        IDManager.SetID(eventIdIDRef_, ob);
                    }
                    else if (eventIdNode.Attributes["href"] != null)
                    {
                        eventIdIDRef_ = eventIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventId_ = new EventId(eventIdNode);
                    }
                }
                else
                {
                    eventId_ = new EventId(eventIdNode);
                }
            }
            
        
        }
        
    
        #region PartyReference_
        private PartyReference partyReference_;
        public PartyReference PartyReference_
        {
            get
            {
                if (this.partyReference_ != null)
                {
                    return this.partyReference_; 
                }
                else if (this.partyReferenceIDRef_ != null)
                {
                    partyReference_ = IDManager.getID(partyReferenceIDRef_) as PartyReference;
                    return this.partyReference_; 
                }
                else
                {
                      return this.partyReference_; 
                }
            }
            set
            {
                if (this.partyReference_ != value)
                {
                    this.partyReference_ = value;
                }
            }
        }
        #endregion
        
        public string partyReferenceIDRef_ { get; set; }
        #region AccountReference_
        private AccountReference accountReference_;
        public AccountReference AccountReference_
        {
            get
            {
                if (this.accountReference_ != null)
                {
                    return this.accountReference_; 
                }
                else if (this.accountReferenceIDRef_ != null)
                {
                    accountReference_ = IDManager.getID(accountReferenceIDRef_) as AccountReference;
                    return this.accountReference_; 
                }
                else
                {
                      return this.accountReference_; 
                }
            }
            set
            {
                if (this.accountReference_ != value)
                {
                    this.accountReference_ = value;
                }
            }
        }
        #endregion
        
        public string accountReferenceIDRef_ { get; set; }
        #region EventId_
        private EventId eventId_;
        public EventId EventId_
        {
            get
            {
                if (this.eventId_ != null)
                {
                    return this.eventId_; 
                }
                else if (this.eventIdIDRef_ != null)
                {
                    eventId_ = IDManager.getID(eventIdIDRef_) as EventId;
                    return this.eventId_; 
                }
                else
                {
                      return this.eventId_; 
                }
            }
            set
            {
                if (this.eventId_ != value)
                {
                    this.eventId_ = value;
                }
            }
        }
        #endregion
        
        public string eventIdIDRef_ { get; set; }
        
    
        
    
    }
    
}

