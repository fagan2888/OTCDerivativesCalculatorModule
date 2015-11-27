using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AutoCallRedem : ISerialized
    {
        public AutoCallRedem() { }
        public AutoCallRedem(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList eventTriggerNodeList = xmlNode.SelectNodes("eventTrigger");
            
            if (eventTriggerNodeList != null)
            {
                this.eventTrigger_ = new List<EventTrigger>();
                foreach (XmlNode item in eventTriggerNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            eventTriggerIDRef_ = item.Attributes["id"].Value;
                            eventTrigger_.Add(new EventTrigger(item));
                            IDManager.SetID(eventTriggerIDRef_, eventTrigger_[eventTrigger_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            eventTriggerIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        eventTrigger_.Add(new EventTrigger(item));
                        }
                    }
                    else
                    {
                        eventTrigger_.Add(new EventTrigger(item));
                    }
                }
            }
            
        
        }
        
    
        #region EventTrigger_
        private List<EventTrigger> eventTrigger_;
        public List<EventTrigger> EventTrigger_
        {
            get
            {
                if (this.eventTrigger_ != null)
                {
                    return this.eventTrigger_; 
                }
                else if (this.eventTriggerIDRef_ != null)
                {
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

