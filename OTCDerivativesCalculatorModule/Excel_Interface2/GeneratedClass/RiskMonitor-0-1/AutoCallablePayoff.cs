using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AutoCallablePayoff : ISerialized
    {
        public AutoCallablePayoff() { }
        public AutoCallablePayoff(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode eventTriggerListNode = xmlNode.SelectSingleNode("eventTriggerList");
            
            if (eventTriggerListNode != null)
            {
                if (eventTriggerListNode.Attributes["href"] != null || eventTriggerListNode.Attributes["id"] != null) 
                {
                    if (eventTriggerListNode.Attributes["id"] != null) 
                    {
                        eventTriggerListIDRef_ = eventTriggerListNode.Attributes["id"].Value;
                        EventTriggerList ob = new EventTriggerList(eventTriggerListNode);
                        IDManager.SetID(eventTriggerListIDRef_, ob);
                    }
                    else if (eventTriggerListNode.Attributes["href"] != null)
                    {
                        eventTriggerListIDRef_ = eventTriggerListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventTriggerList_ = new EventTriggerList(eventTriggerListNode);
                    }
                }
                else
                {
                    eventTriggerList_ = new EventTriggerList(eventTriggerListNode);
                }
            }
            
        
        }
        
    
        #region EventTriggerList_
        private EventTriggerList eventTriggerList_;
        public EventTriggerList EventTriggerList_
        {
            get
            {
                if (this.eventTriggerList_ != null)
                {
                    return this.eventTriggerList_; 
                }
                else if (this.eventTriggerListIDRef_ != null)
                {
                    eventTriggerList_ = IDManager.getID(eventTriggerListIDRef_) as EventTriggerList;
                    return this.eventTriggerList_; 
                }
                else
                {
                    throw new Exception( "eventTriggerList_Node no exist!");
                }
            }
            set
            {
                if (this.eventTriggerList_ != value)
                {
                    this.eventTriggerList_ = value;
                }
            }
        }
        #endregion
        
        public string eventTriggerListIDRef_ { get; set; }
        
    
        
    
    }
    
}

