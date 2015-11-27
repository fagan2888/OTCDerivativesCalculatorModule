using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StepDownNoKIPayoff : ISerialized
    {
        public StepDownNoKIPayoff() { }
        public StepDownNoKIPayoff(XmlNode xmlNode)
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
            
        
            XmlNode noAutoCallReturnTriggerNode = xmlNode.SelectSingleNode("noAutoCallReturnTrigger");
            
            if (noAutoCallReturnTriggerNode != null)
            {
                if (noAutoCallReturnTriggerNode.Attributes["href"] != null || noAutoCallReturnTriggerNode.Attributes["id"] != null) 
                {
                    if (noAutoCallReturnTriggerNode.Attributes["id"] != null) 
                    {
                        noAutoCallReturnTriggerIDRef_ = noAutoCallReturnTriggerNode.Attributes["id"].Value;
                        NoAutoCallReturnTrigger ob = new NoAutoCallReturnTrigger(noAutoCallReturnTriggerNode);
                        IDManager.SetID(noAutoCallReturnTriggerIDRef_, ob);
                    }
                    else if (noAutoCallReturnTriggerNode.Attributes["href"] != null)
                    {
                        noAutoCallReturnTriggerIDRef_ = noAutoCallReturnTriggerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        noAutoCallReturnTrigger_ = new NoAutoCallReturnTrigger(noAutoCallReturnTriggerNode);
                    }
                }
                else
                {
                    noAutoCallReturnTrigger_ = new NoAutoCallReturnTrigger(noAutoCallReturnTriggerNode);
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
        #region NoAutoCallReturnTrigger_
        private NoAutoCallReturnTrigger noAutoCallReturnTrigger_;
        public NoAutoCallReturnTrigger NoAutoCallReturnTrigger_
        {
            get
            {
                if (this.noAutoCallReturnTrigger_ != null)
                {
                    return this.noAutoCallReturnTrigger_; 
                }
                else if (this.noAutoCallReturnTriggerIDRef_ != null)
                {
                    noAutoCallReturnTrigger_ = IDManager.getID(noAutoCallReturnTriggerIDRef_) as NoAutoCallReturnTrigger;
                    return this.noAutoCallReturnTrigger_; 
                }
                else
                {
                    throw new Exception( "noAutoCallReturnTrigger_Node no exist!");
                }
            }
            set
            {
                if (this.noAutoCallReturnTrigger_ != value)
                {
                    this.noAutoCallReturnTrigger_ = value;
                }
            }
        }
        #endregion
        
        public string noAutoCallReturnTriggerIDRef_ { get; set; }
        
    
        
    
    }
    
}

