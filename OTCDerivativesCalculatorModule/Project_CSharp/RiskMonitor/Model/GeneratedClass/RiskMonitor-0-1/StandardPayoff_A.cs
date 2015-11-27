using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StandardPayoff_A : ISerialized
    {
        public StandardPayoff_A() { }
        public StandardPayoff_A(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode eventTriggerList_ANode = xmlNode.SelectSingleNode("eventTriggerList_A");
            
            if (eventTriggerList_ANode != null)
            {
                if (eventTriggerList_ANode.Attributes["href"] != null || eventTriggerList_ANode.Attributes["id"] != null) 
                {
                    if (eventTriggerList_ANode.Attributes["id"] != null) 
                    {
                        eventTriggerList_AIDRef_ = eventTriggerList_ANode.Attributes["id"].Value;
                        EventTriggerList_A ob = new EventTriggerList_A(eventTriggerList_ANode);
                        IDManager.SetID(eventTriggerList_AIDRef_, ob);
                    }
                    else if (eventTriggerList_ANode.Attributes["href"] != null)
                    {
                        eventTriggerList_AIDRef_ = eventTriggerList_ANode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventTriggerList_A_ = new EventTriggerList_A(eventTriggerList_ANode);
                    }
                }
                else
                {
                    eventTriggerList_A_ = new EventTriggerList_A(eventTriggerList_ANode);
                }
            }
            
        
        }
        
    
        #region EventTriggerList_A_
        private EventTriggerList_A eventTriggerList_A_;
        public EventTriggerList_A EventTriggerList_A_
        {
            get
            {
                if (this.eventTriggerList_A_ != null)
                {
                    return this.eventTriggerList_A_; 
                }
                else if (this.eventTriggerList_AIDRef_ != null)
                {
                    eventTriggerList_A_ = IDManager.getID(eventTriggerList_AIDRef_) as EventTriggerList_A;
                    return this.eventTriggerList_A_; 
                }
                else
                {
                    throw new Exception( "eventTriggerList_A_Node no exist!");
                }
            }
            set
            {
                if (this.eventTriggerList_A_ != value)
                {
                    this.eventTriggerList_A_ = value;
                }
            }
        }
        #endregion
        
        public string eventTriggerList_AIDRef_ { get; set; }
        
    
        
    
    }
    
}

