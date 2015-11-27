using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ConfirmationStatus
    {
        public ConfirmationStatus(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList statusNodeList = xmlNode.SelectNodes("status");
            if (statusNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in statusNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        statusIDRef = item.Attributes["id"].Name;
                        EventStatus ob = EventStatus();
                        IDManager.SetID(statusIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        statusIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        status = new EventStatus(item);
                    }
                }
            }
            
        
            XmlNodeList assertedEventNodeList = xmlNode.SelectNodes("assertedEvent");
            if (assertedEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in assertedEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        assertedEventIDRef = item.Attributes["id"].Name;
                        EventsChoice ob = EventsChoice();
                        IDManager.SetID(assertedEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        assertedEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        assertedEvent = new EventsChoice(item);
                    }
                }
            }
            
        
            XmlNodeList proposedMatchNodeList = xmlNode.SelectNodes("proposedMatch");
            
            foreach (XmlNode item in proposedMatchNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        proposedMatchIDRef = item.Attributes["id"].Name;
                        List<EventProposedMatch> ob = new List<EventProposedMatch>();
                        ob.Add(new EventProposedMatch(item));
                        IDManager.SetID(proposedMatchIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        proposedMatchIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    proposedMatch.Add(new EventProposedMatch(item));
                    }
                }
            }
            
        
            XmlNodeList allegedEventNodeList = xmlNode.SelectNodes("allegedEvent");
            if (allegedEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in allegedEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        allegedEventIDRef = item.Attributes["id"].Name;
                        EventsChoice ob = EventsChoice();
                        IDManager.SetID(allegedEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        allegedEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        allegedEvent = new EventsChoice(item);
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
        
    
        #region Status
        private EventStatus status;
        public EventStatus Status
        {
            get
            {
                if (this.status != null)
                {
                    return this.status; 
                }
                else if (this.statusIDRef != null)
                {
                    status = IDManager.getID(statusIDRef) as EventStatus;
                    return this.status; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.status != value)
                {
                    this.status = value;
                }
            }
        }
        #endregion
        
        public string EventStatusIDRef { get; set; }
        #region AssertedEvent
        private EventsChoice assertedEvent;
        public EventsChoice AssertedEvent
        {
            get
            {
                if (this.assertedEvent != null)
                {
                    return this.assertedEvent; 
                }
                else if (this.assertedEventIDRef != null)
                {
                    assertedEvent = IDManager.getID(assertedEventIDRef) as EventsChoice;
                    return this.assertedEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.assertedEvent != value)
                {
                    this.assertedEvent = value;
                }
            }
        }
        #endregion
        
        public string EventsChoiceIDRef { get; set; }
        #region ProposedMatch
        private List<EventProposedMatch> proposedMatch;
        public List<EventProposedMatch> ProposedMatch
        {
            get
            {
                if (this.proposedMatch != null)
                {
                    return this.proposedMatch; 
                }
                else if (this.proposedMatchIDRef != null)
                {
                    proposedMatch = IDManager.getID(proposedMatchIDRef) as List<EventProposedMatch>;
                    return this.proposedMatch; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.proposedMatch != value)
                {
                    this.proposedMatch = value;
                }
            }
        }
        #endregion
        
        public string EventProposedMatchIDRef { get; set; }
        #region AllegedEvent
        private EventsChoice allegedEvent;
        public EventsChoice AllegedEvent
        {
            get
            {
                if (this.allegedEvent != null)
                {
                    return this.allegedEvent; 
                }
                else if (this.allegedEventIDRef != null)
                {
                    allegedEvent = IDManager.getID(allegedEventIDRef) as EventsChoice;
                    return this.allegedEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.allegedEvent != value)
                {
                    this.allegedEvent = value;
                }
            }
        }
        #endregion
        
        public string EventsChoiceIDRef { get; set; }
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

