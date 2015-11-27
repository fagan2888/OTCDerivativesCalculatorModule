using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class RequestEventStatus
    {
        public RequestEventStatus(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList businessProcessNodeList = xmlNode.SelectNodes("businessProcess");
            if (businessProcessNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessProcessNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessProcessIDRef = item.Attributes["id"].Name;
                        BusinessProcess ob = BusinessProcess();
                        IDManager.SetID(businessProcessIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessProcessIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessProcess = new BusinessProcess(item);
                    }
                }
            }
            
        
            XmlNodeList eventIdentifierNodeList = xmlNode.SelectNodes("eventIdentifier");
            if (eventIdentifierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in eventIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        eventIdentifierIDRef = item.Attributes["id"].Name;
                        EventIdentifier ob = EventIdentifier();
                        IDManager.SetID(eventIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        eventIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        eventIdentifier = new EventIdentifier(item);
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
        
    
        #region BusinessProcess
        private BusinessProcess businessProcess;
        public BusinessProcess BusinessProcess
        {
            get
            {
                if (this.businessProcess != null)
                {
                    return this.businessProcess; 
                }
                else if (this.businessProcessIDRef != null)
                {
                    businessProcess = IDManager.getID(businessProcessIDRef) as BusinessProcess;
                    return this.businessProcess; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessProcess != value)
                {
                    this.businessProcess = value;
                }
            }
        }
        #endregion
        
        public string BusinessProcessIDRef { get; set; }
        #region EventIdentifier
        private EventIdentifier eventIdentifier;
        public EventIdentifier EventIdentifier
        {
            get
            {
                if (this.eventIdentifier != null)
                {
                    return this.eventIdentifier; 
                }
                else if (this.eventIdentifierIDRef != null)
                {
                    eventIdentifier = IDManager.getID(eventIdentifierIDRef) as EventIdentifier;
                    return this.eventIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.eventIdentifier != value)
                {
                    this.eventIdentifier = value;
                }
            }
        }
        #endregion
        
        public string EventIdentifierIDRef { get; set; }
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

