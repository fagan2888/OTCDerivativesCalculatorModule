using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventTriggerList_A : ISerialized
    {
        public EventTriggerList_A() { }
        public EventTriggerList_A(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList eventTrigger_ANodeList = xmlNode.SelectNodes("eventTrigger_A");
            
            if (eventTrigger_ANodeList != null)
            {
                this.eventTrigger_A_ = new List<EventTrigger_A>();
                foreach (XmlNode item in eventTrigger_ANodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            eventTrigger_AIDRef_ = item.Attributes["id"].Value;
                            eventTrigger_A_.Add(new EventTrigger_A(item));
                            IDManager.SetID(eventTrigger_AIDRef_, eventTrigger_A_[eventTrigger_A_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            eventTrigger_AIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        eventTrigger_A_.Add(new EventTrigger_A(item));
                        }
                    }
                    else
                    {
                        eventTrigger_A_.Add(new EventTrigger_A(item));
                    }
                }
            }
            
        
        }
        
    
        #region EventTrigger_A_
        private List<EventTrigger_A> eventTrigger_A_;
        public List<EventTrigger_A> EventTrigger_A_
        {
            get
            {
                if (this.eventTrigger_A_ != null)
                {
                    return this.eventTrigger_A_; 
                }
                else if (this.eventTrigger_AIDRef_ != null)
                {
                    return this.eventTrigger_A_; 
                }
                else
                {
                    throw new Exception( "eventTrigger_A_Node no exist!");
                }
            }
            set
            {
                if (this.eventTrigger_A_ != value)
                {
                    this.eventTrigger_A_ = value;
                }
            }
        }
        #endregion
        
        public string eventTrigger_AIDRef_ { get; set; }
        
    
        
    
    }
    
}

