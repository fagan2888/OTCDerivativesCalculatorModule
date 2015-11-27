using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EventStatusItem
    {
        public EventStatusItem(XmlNode xmlNode)
        {
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
            
        
        }
        
    
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
        
    
        
    
    }
    
}

