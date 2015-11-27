using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventSchedule : ISerialized
    {
        public EventSchedule(XmlNode xmlNode)
        {
            XmlNodeList eventCheckNodeList = xmlNode.SelectNodes("eventCheck");
            
            if (eventCheckNodeList != null)
            {
                this.eventCheck_ = new List<EventCheck>();
                foreach (XmlNode item in eventCheckNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            eventCheckIDRef_ = item.Attributes["id"].Value;
                            eventCheck_.Add(new EventCheck(item));
                            IDManager.SetID(eventCheckIDRef_, eventCheck_[eventCheck_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            eventCheckIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        eventCheck_.Add(new EventCheck(item));
                        }
                    }
                    else
                    {
                        eventCheck_.Add(new EventCheck(item));
                    }
                }
            }
            
        
        }
        
    
        #region EventCheck_
        private List<EventCheck> eventCheck_;
        public List<EventCheck> EventCheck_
        {
            get
            {
                if (this.eventCheck_ != null)
                {
                    return this.eventCheck_; 
                }
                else if (this.eventCheckIDRef_ != null)
                {
                    return this.eventCheck_; 
                }
                else
                {
                      return this.eventCheck_; 
                }
            }
            set
            {
                if (this.eventCheck_ != value)
                {
                    this.eventCheck_ = value;
                }
            }
        }
        #endregion
        
        public string eventCheckIDRef_ { get; set; }
        
    
        
    
    }
    
}

