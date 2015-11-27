using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventStatusItem : ISerialized
    {
        public EventStatusItem(XmlNode xmlNode)
        {
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
            
        
        }
        
    
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
        
    
        
    
    }
    
}

