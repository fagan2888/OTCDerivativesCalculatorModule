using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventCheckTime : EventCheckBase
    {
        public EventCheckTime(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode eventDatesNode = xmlNode.SelectSingleNode("eventDates");
            
            if (eventDatesNode != null)
            {
                if (eventDatesNode.Attributes["href"] != null || eventDatesNode.Attributes["id"] != null) 
                {
                    if (eventDatesNode.Attributes["id"] != null) 
                    {
                        eventDatesIDRef_ = eventDatesNode.Attributes["id"].Value;
                        EventDates ob = new EventDates(eventDatesNode);
                        IDManager.SetID(eventDatesIDRef_, ob);
                    }
                    else if (eventDatesNode.Attributes["href"] != null)
                    {
                        eventDatesIDRef_ = eventDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventDates_ = new EventDates(eventDatesNode);
                    }
                }
                else
                {
                    eventDates_ = new EventDates(eventDatesNode);
                }
            }
            
        
            XmlNode jointTimeEventNode = xmlNode.SelectSingleNode("jointTimeEvent");
            
            if (jointTimeEventNode != null)
            {
                if (jointTimeEventNode.Attributes["href"] != null || jointTimeEventNode.Attributes["id"] != null) 
                {
                    if (jointTimeEventNode.Attributes["id"] != null) 
                    {
                        jointTimeEventIDRef_ = jointTimeEventNode.Attributes["id"].Value;
                        JointTimeEvent ob = new JointTimeEvent(jointTimeEventNode);
                        IDManager.SetID(jointTimeEventIDRef_, ob);
                    }
                    else if (jointTimeEventNode.Attributes["href"] != null)
                    {
                        jointTimeEventIDRef_ = jointTimeEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        jointTimeEvent_ = new JointTimeEvent(jointTimeEventNode);
                    }
                }
                else
                {
                    jointTimeEvent_ = new JointTimeEvent(jointTimeEventNode);
                }
            }
            
        
        }
        
    
        #region EventDates_
        private EventDates eventDates_;
        public EventDates EventDates_
        {
            get
            {
                if (this.eventDates_ != null)
                {
                    return this.eventDates_; 
                }
                else if (this.eventDatesIDRef_ != null)
                {
                    eventDates_ = IDManager.getID(eventDatesIDRef_) as EventDates;
                    return this.eventDates_; 
                }
                else
                {
                      return this.eventDates_; 
                }
            }
            set
            {
                if (this.eventDates_ != value)
                {
                    this.eventDates_ = value;
                }
            }
        }
        #endregion
        
        public string eventDatesIDRef_ { get; set; }
        #region JointTimeEvent_
        private JointTimeEvent jointTimeEvent_;
        public JointTimeEvent JointTimeEvent_
        {
            get
            {
                if (this.jointTimeEvent_ != null)
                {
                    return this.jointTimeEvent_; 
                }
                else if (this.jointTimeEventIDRef_ != null)
                {
                    jointTimeEvent_ = IDManager.getID(jointTimeEventIDRef_) as JointTimeEvent;
                    return this.jointTimeEvent_; 
                }
                else
                {
                      return this.jointTimeEvent_; 
                }
            }
            set
            {
                if (this.jointTimeEvent_ != value)
                {
                    this.jointTimeEvent_ = value;
                }
            }
        }
        #endregion
        
        public string jointTimeEventIDRef_ { get; set; }
        
    
        
    
    }
    
}

