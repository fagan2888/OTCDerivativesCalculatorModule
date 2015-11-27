using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class IndexRef : ISerialized
    {
        public IndexRef(XmlNode xmlNode)
        {
            XmlNode underlyingIndexRefNode = xmlNode.SelectSingleNode("underlyingIndexRef");
            
            if (underlyingIndexRefNode != null)
            {
                if (underlyingIndexRefNode.Attributes["href"] != null || underlyingIndexRefNode.Attributes["id"] != null) 
                {
                    if (underlyingIndexRefNode.Attributes["id"] != null) 
                    {
                        underlyingIndexRefIDRef_ = underlyingIndexRefNode.Attributes["id"].Value;
                        UnderlyingIndex ob = new UnderlyingIndex(underlyingIndexRefNode);
                        IDManager.SetID(underlyingIndexRefIDRef_, ob);
                    }
                    else if (underlyingIndexRefNode.Attributes["href"] != null)
                    {
                        underlyingIndexRefIDRef_ = underlyingIndexRefNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underlyingIndexRef_ = new UnderlyingIndex(underlyingIndexRefNode);
                    }
                }
                else
                {
                    underlyingIndexRef_ = new UnderlyingIndex(underlyingIndexRefNode);
                }
            }
            
        
            XmlNode eventDateRefNode = xmlNode.SelectSingleNode("eventDateRef");
            
            if (eventDateRefNode != null)
            {
                if (eventDateRefNode.Attributes["href"] != null || eventDateRefNode.Attributes["id"] != null) 
                {
                    if (eventDateRefNode.Attributes["id"] != null) 
                    {
                        eventDateRefIDRef_ = eventDateRefNode.Attributes["id"].Value;
                        EventDate ob = new EventDate(eventDateRefNode);
                        IDManager.SetID(eventDateRefIDRef_, ob);
                    }
                    else if (eventDateRefNode.Attributes["href"] != null)
                    {
                        eventDateRefIDRef_ = eventDateRefNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventDateRef_ = new EventDate(eventDateRefNode);
                    }
                }
                else
                {
                    eventDateRef_ = new EventDate(eventDateRefNode);
                }
            }
            
        
            XmlNode fixingDaysNode = xmlNode.SelectSingleNode("fixingDays");
            
            if (fixingDaysNode != null)
            {
                if (fixingDaysNode.Attributes["href"] != null || fixingDaysNode.Attributes["id"] != null) 
                {
                    if (fixingDaysNode.Attributes["id"] != null) 
                    {
                        fixingDaysIDRef_ = fixingDaysNode.Attributes["id"].Value;
                        FixingDays ob = new FixingDays(fixingDaysNode);
                        IDManager.SetID(fixingDaysIDRef_, ob);
                    }
                    else if (fixingDaysNode.Attributes["href"] != null)
                    {
                        fixingDaysIDRef_ = fixingDaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixingDays_ = new FixingDays(fixingDaysNode);
                    }
                }
                else
                {
                    fixingDays_ = new FixingDays(fixingDaysNode);
                }
            }
            
        
        }
        
    
        #region UnderlyingIndexRef_
        private UnderlyingIndex underlyingIndexRef_;
        public UnderlyingIndex UnderlyingIndexRef_
        {
            get
            {
                if (this.underlyingIndexRef_ != null)
                {
                    return this.underlyingIndexRef_; 
                }
                else if (this.underlyingIndexRefIDRef_ != null)
                {
                    underlyingIndexRef_ = IDManager.getID(underlyingIndexRefIDRef_) as UnderlyingIndex;
                    return this.underlyingIndexRef_; 
                }
                else
                {
                      return this.underlyingIndexRef_; 
                }
            }
            set
            {
                if (this.underlyingIndexRef_ != value)
                {
                    this.underlyingIndexRef_ = value;
                }
            }
        }
        #endregion
        
        public string underlyingIndexRefIDRef_ { get; set; }
        #region EventDateRef_
        private EventDate eventDateRef_;
        public EventDate EventDateRef_
        {
            get
            {
                if (this.eventDateRef_ != null)
                {
                    return this.eventDateRef_; 
                }
                else if (this.eventDateRefIDRef_ != null)
                {
                    eventDateRef_ = IDManager.getID(eventDateRefIDRef_) as EventDate;
                    return this.eventDateRef_; 
                }
                else
                {
                      return this.eventDateRef_; 
                }
            }
            set
            {
                if (this.eventDateRef_ != value)
                {
                    this.eventDateRef_ = value;
                }
            }
        }
        #endregion
        
        public string eventDateRefIDRef_ { get; set; }
        #region FixingDays_
        private FixingDays fixingDays_;
        public FixingDays FixingDays_
        {
            get
            {
                if (this.fixingDays_ != null)
                {
                    return this.fixingDays_; 
                }
                else if (this.fixingDaysIDRef_ != null)
                {
                    fixingDays_ = IDManager.getID(fixingDaysIDRef_) as FixingDays;
                    return this.fixingDays_; 
                }
                else
                {
                      return this.fixingDays_; 
                }
            }
            set
            {
                if (this.fixingDays_ != value)
                {
                    this.fixingDays_ = value;
                }
            }
        }
        #endregion
        
        public string fixingDaysIDRef_ { get; set; }
        
    
        
    
    }
    
}

