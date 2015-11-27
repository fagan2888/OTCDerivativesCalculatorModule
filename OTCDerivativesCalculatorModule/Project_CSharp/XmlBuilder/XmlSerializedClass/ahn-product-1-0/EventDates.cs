using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventDates : ISerialized
    {
        public EventDates(XmlNode xmlNode)
        {
            XmlNode dateListNode = xmlNode.SelectSingleNode("dateList");
            
            if (dateListNode != null)
            {
                if (dateListNode.Attributes["href"] != null || dateListNode.Attributes["id"] != null) 
                {
                    if (dateListNode.Attributes["id"] != null) 
                    {
                        dateListIDRef_ = dateListNode.Attributes["id"].Value;
                        DatesList ob = new DatesList(dateListNode);
                        IDManager.SetID(dateListIDRef_, ob);
                    }
                    else if (dateListNode.Attributes["href"] != null)
                    {
                        dateListIDRef_ = dateListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateList_ = new DatesList(dateListNode);
                    }
                }
                else
                {
                    dateList_ = new DatesList(dateListNode);
                }
            }
            
        
            XmlNode dateIntervalNode = xmlNode.SelectSingleNode("dateInterval");
            
            if (dateIntervalNode != null)
            {
                if (dateIntervalNode.Attributes["href"] != null || dateIntervalNode.Attributes["id"] != null) 
                {
                    if (dateIntervalNode.Attributes["id"] != null) 
                    {
                        dateIntervalIDRef_ = dateIntervalNode.Attributes["id"].Value;
                        DateInterval ob = new DateInterval(dateIntervalNode);
                        IDManager.SetID(dateIntervalIDRef_, ob);
                    }
                    else if (dateIntervalNode.Attributes["href"] != null)
                    {
                        dateIntervalIDRef_ = dateIntervalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateInterval_ = new DateInterval(dateIntervalNode);
                    }
                }
                else
                {
                    dateInterval_ = new DateInterval(dateIntervalNode);
                }
            }
            
        
        }
        
    
        #region DateList_
        private DatesList dateList_;
        public DatesList DateList_
        {
            get
            {
                if (this.dateList_ != null)
                {
                    return this.dateList_; 
                }
                else if (this.dateListIDRef_ != null)
                {
                    dateList_ = IDManager.getID(dateListIDRef_) as DatesList;
                    return this.dateList_; 
                }
                else
                {
                      return this.dateList_; 
                }
            }
            set
            {
                if (this.dateList_ != value)
                {
                    this.dateList_ = value;
                }
            }
        }
        #endregion
        
        public string dateListIDRef_ { get; set; }
        #region DateInterval_
        private DateInterval dateInterval_;
        public DateInterval DateInterval_
        {
            get
            {
                if (this.dateInterval_ != null)
                {
                    return this.dateInterval_; 
                }
                else if (this.dateIntervalIDRef_ != null)
                {
                    dateInterval_ = IDManager.getID(dateIntervalIDRef_) as DateInterval;
                    return this.dateInterval_; 
                }
                else
                {
                      return this.dateInterval_; 
                }
            }
            set
            {
                if (this.dateInterval_ != value)
                {
                    this.dateInterval_ = value;
                }
            }
        }
        #endregion
        
        public string dateIntervalIDRef_ { get; set; }
        public string choiceStr_eventDateType;
        
    
        
    
    }
    
}

