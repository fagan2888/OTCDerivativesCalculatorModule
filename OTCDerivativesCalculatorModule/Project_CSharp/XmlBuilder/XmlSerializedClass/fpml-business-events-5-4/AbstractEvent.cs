using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AbstractEvent : ISerialized
    {
        public AbstractEvent(XmlNode xmlNode)
        {
            XmlNodeList eventIdentifierNodeList = xmlNode.SelectNodes("eventIdentifier");
            
            if (eventIdentifierNodeList != null)
            {
                this.eventIdentifier_ = new List<BusinessEventIdentifier>();
                foreach (XmlNode item in eventIdentifierNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            eventIdentifierIDRef_ = item.Attributes["id"].Value;
                            eventIdentifier_.Add(new BusinessEventIdentifier(item));
                            IDManager.SetID(eventIdentifierIDRef_, eventIdentifier_[eventIdentifier_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            eventIdentifierIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        eventIdentifier_.Add(new BusinessEventIdentifier(item));
                        }
                    }
                    else
                    {
                        eventIdentifier_.Add(new BusinessEventIdentifier(item));
                    }
                }
            }
            
        
        }
        
    
        #region EventIdentifier_
        private List<BusinessEventIdentifier> eventIdentifier_;
        public List<BusinessEventIdentifier> EventIdentifier_
        {
            get
            {
                if (this.eventIdentifier_ != null)
                {
                    return this.eventIdentifier_; 
                }
                else if (this.eventIdentifierIDRef_ != null)
                {
                    return this.eventIdentifier_; 
                }
                else
                {
                      return this.eventIdentifier_; 
                }
            }
            set
            {
                if (this.eventIdentifier_ != value)
                {
                    this.eventIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string eventIdentifierIDRef_ { get; set; }
        
    
        
    
    }
    
}

