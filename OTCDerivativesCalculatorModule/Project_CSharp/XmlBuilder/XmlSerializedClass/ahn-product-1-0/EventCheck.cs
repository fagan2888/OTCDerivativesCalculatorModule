using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventCheck : ISerialized
    {
        public EventCheck(XmlNode xmlNode)
        {
            XmlNode eventCheckNormalNode = xmlNode.SelectSingleNode("eventCheckNormal");
            
            if (eventCheckNormalNode != null)
            {
                if (eventCheckNormalNode.Attributes["href"] != null || eventCheckNormalNode.Attributes["id"] != null) 
                {
                    if (eventCheckNormalNode.Attributes["id"] != null) 
                    {
                        eventCheckNormalIDRef_ = eventCheckNormalNode.Attributes["id"].Value;
                        EventCheckNormal ob = new EventCheckNormal(eventCheckNormalNode);
                        IDManager.SetID(eventCheckNormalIDRef_, ob);
                    }
                    else if (eventCheckNormalNode.Attributes["href"] != null)
                    {
                        eventCheckNormalIDRef_ = eventCheckNormalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventCheckNormal_ = new EventCheckNormal(eventCheckNormalNode);
                    }
                }
                else
                {
                    eventCheckNormal_ = new EventCheckNormal(eventCheckNormalNode);
                }
            }
            
        
            XmlNode eventCheckTimeNode = xmlNode.SelectSingleNode("eventCheckTime");
            
            if (eventCheckTimeNode != null)
            {
                if (eventCheckTimeNode.Attributes["href"] != null || eventCheckTimeNode.Attributes["id"] != null) 
                {
                    if (eventCheckTimeNode.Attributes["id"] != null) 
                    {
                        eventCheckTimeIDRef_ = eventCheckTimeNode.Attributes["id"].Value;
                        EventCheckTime ob = new EventCheckTime(eventCheckTimeNode);
                        IDManager.SetID(eventCheckTimeIDRef_, ob);
                    }
                    else if (eventCheckTimeNode.Attributes["href"] != null)
                    {
                        eventCheckTimeIDRef_ = eventCheckTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventCheckTime_ = new EventCheckTime(eventCheckTimeNode);
                    }
                }
                else
                {
                    eventCheckTime_ = new EventCheckTime(eventCheckTimeNode);
                }
            }
            
        
        }
        
    
        #region EventCheckNormal_
        private EventCheckNormal eventCheckNormal_;
        public EventCheckNormal EventCheckNormal_
        {
            get
            {
                if (this.eventCheckNormal_ != null)
                {
                    return this.eventCheckNormal_; 
                }
                else if (this.eventCheckNormalIDRef_ != null)
                {
                    eventCheckNormal_ = IDManager.getID(eventCheckNormalIDRef_) as EventCheckNormal;
                    return this.eventCheckNormal_; 
                }
                else
                {
                      return this.eventCheckNormal_; 
                }
            }
            set
            {
                if (this.eventCheckNormal_ != value)
                {
                    this.eventCheckNormal_ = value;
                }
            }
        }
        #endregion
        
        public string eventCheckNormalIDRef_ { get; set; }
        #region EventCheckTime_
        private EventCheckTime eventCheckTime_;
        public EventCheckTime EventCheckTime_
        {
            get
            {
                if (this.eventCheckTime_ != null)
                {
                    return this.eventCheckTime_; 
                }
                else if (this.eventCheckTimeIDRef_ != null)
                {
                    eventCheckTime_ = IDManager.getID(eventCheckTimeIDRef_) as EventCheckTime;
                    return this.eventCheckTime_; 
                }
                else
                {
                      return this.eventCheckTime_; 
                }
            }
            set
            {
                if (this.eventCheckTime_ != value)
                {
                    this.eventCheckTime_ = value;
                }
            }
        }
        #endregion
        
        public string eventCheckTimeIDRef_ { get; set; }
        public string choiceStr_ecType;
        
    
        
    
    }
    
}

