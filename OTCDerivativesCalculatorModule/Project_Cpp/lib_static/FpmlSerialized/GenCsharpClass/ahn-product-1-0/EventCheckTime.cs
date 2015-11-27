using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EventCheckTime
    {
        public EventCheckTime(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList eventDatesNodeList = xmlNode.SelectNodes("eventDates");
            if (eventDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in eventDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        eventDatesIDRef = item.Attributes["id"].Name;
                        EventDates ob = EventDates();
                        IDManager.SetID(eventDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        eventDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        eventDates = new EventDates(item);
                    }
                }
            }
            
        
            XmlNodeList jointTimeEventNodeList = xmlNode.SelectNodes("jointTimeEvent");
            if (jointTimeEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in jointTimeEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        jointTimeEventIDRef = item.Attributes["id"].Name;
                        JointTimeEvent ob = JointTimeEvent();
                        IDManager.SetID(jointTimeEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        jointTimeEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        jointTimeEvent = new JointTimeEvent(item);
                    }
                }
            }
            
        
        }
        
    
        #region EventDates
        private EventDates eventDates;
        public EventDates EventDates
        {
            get
            {
                if (this.eventDates != null)
                {
                    return this.eventDates; 
                }
                else if (this.eventDatesIDRef != null)
                {
                    eventDates = IDManager.getID(eventDatesIDRef) as EventDates;
                    return this.eventDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.eventDates != value)
                {
                    this.eventDates = value;
                }
            }
        }
        #endregion
        
        public string EventDatesIDRef { get; set; }
        #region JointTimeEvent
        private JointTimeEvent jointTimeEvent;
        public JointTimeEvent JointTimeEvent
        {
            get
            {
                if (this.jointTimeEvent != null)
                {
                    return this.jointTimeEvent; 
                }
                else if (this.jointTimeEventIDRef != null)
                {
                    jointTimeEvent = IDManager.getID(jointTimeEventIDRef) as JointTimeEvent;
                    return this.jointTimeEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.jointTimeEvent != value)
                {
                    this.jointTimeEvent = value;
                }
            }
        }
        #endregion
        
        public string JointTimeEventIDRef { get; set; }
        
    
        
    
    }
    
}

