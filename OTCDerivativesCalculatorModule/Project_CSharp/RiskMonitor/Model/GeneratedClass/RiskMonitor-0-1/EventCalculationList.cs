using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventCalculationList : ISerialized
    {
        public EventCalculationList() { }
        public EventCalculationList(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList eventCalculationNodeList = xmlNode.SelectNodes("eventCalculation");
            
            if (eventCalculationNodeList != null)
            {
                this.eventCalculation_ = new List<EventCalculation>();
                foreach (XmlNode item in eventCalculationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            eventCalculationIDRef_ = item.Attributes["id"].Value;
                            eventCalculation_.Add(new EventCalculation(item));
                            IDManager.SetID(eventCalculationIDRef_, eventCalculation_[eventCalculation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            eventCalculationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        eventCalculation_.Add(new EventCalculation(item));
                        }
                    }
                    else
                    {
                        eventCalculation_.Add(new EventCalculation(item));
                    }
                }
            }
            
        
        }
        
    
        #region EventCalculation_
        private List<EventCalculation> eventCalculation_;
        public List<EventCalculation> EventCalculation_
        {
            get
            {
                if (this.eventCalculation_ != null)
                {
                    return this.eventCalculation_; 
                }
                else if (this.eventCalculationIDRef_ != null)
                {
                    return this.eventCalculation_; 
                }
                else
                {
                    throw new Exception( "eventCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.eventCalculation_ != value)
                {
                    this.eventCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string eventCalculationIDRef_ { get; set; }
        
    
        
    
    }
    
}

