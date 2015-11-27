using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class KiEventInfo : ISerialized
    {
        public KiEventInfo() { }
        public KiEventInfo(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode eventTriggerNode = xmlNode.SelectSingleNode("eventTrigger");
            
            if (eventTriggerNode != null)
            {
                if (eventTriggerNode.Attributes["href"] != null || eventTriggerNode.Attributes["id"] != null) 
                {
                    if (eventTriggerNode.Attributes["id"] != null) 
                    {
                        eventTriggerIDRef_ = eventTriggerNode.Attributes["id"].Value;
                        EventTrigger ob = new EventTrigger(eventTriggerNode);
                        IDManager.SetID(eventTriggerIDRef_, ob);
                    }
                    else if (eventTriggerNode.Attributes["href"] != null)
                    {
                        eventTriggerIDRef_ = eventTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventTrigger_ = new EventTrigger(eventTriggerNode);
                    }
                }
                else
                {
                    eventTrigger_ = new EventTrigger(eventTriggerNode);
                }
            }
            
        
        }
        
    
        #region EventTrigger_
        private EventTrigger eventTrigger_;
        public EventTrigger EventTrigger_
        {
            get
            {
                if (this.eventTrigger_ != null)
                {
                    return this.eventTrigger_; 
                }
                else if (this.eventTriggerIDRef_ != null)
                {
                    eventTrigger_ = IDManager.getID(eventTriggerIDRef_) as EventTrigger;
                    return this.eventTrigger_; 
                }
                else
                {
                    throw new Exception( "eventTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.eventTrigger_ != value)
                {
                    this.eventTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string eventTriggerIDRef_ { get; set; }
        
    
        
    
    }
    
}

