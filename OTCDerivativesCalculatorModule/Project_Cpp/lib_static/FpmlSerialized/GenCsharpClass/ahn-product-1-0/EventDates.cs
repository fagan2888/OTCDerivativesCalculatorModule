using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EventDates
    {
        public EventDates(XmlNode xmlNode)
        {
            XmlNodeList dateListNodeList = xmlNode.SelectNodes("dateList");
            if (dateListNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateListNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateListIDRef = item.Attributes["id"].Name;
                        DatesList ob = DatesList();
                        IDManager.SetID(dateListIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateListIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dateList = new DatesList(item);
                    }
                }
            }
            
        
            XmlNodeList dateIntervalNodeList = xmlNode.SelectNodes("dateInterval");
            if (dateIntervalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateIntervalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateIntervalIDRef = item.Attributes["id"].Name;
                        DateInterval ob = DateInterval();
                        IDManager.SetID(dateIntervalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateIntervalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dateInterval = new DateInterval(item);
                    }
                }
            }
            
        
        }
        
    
        #region DateList
        private DatesList dateList;
        public DatesList DateList
        {
            get
            {
                if (this.dateList != null)
                {
                    return this.dateList; 
                }
                else if (this.dateListIDRef != null)
                {
                    dateList = IDManager.getID(dateListIDRef) as DatesList;
                    return this.dateList; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dateList != value)
                {
                    this.dateList = value;
                }
            }
        }
        #endregion
        
        public string DatesListIDRef { get; set; }
        #region DateInterval
        private DateInterval dateInterval;
        public DateInterval DateInterval
        {
            get
            {
                if (this.dateInterval != null)
                {
                    return this.dateInterval; 
                }
                else if (this.dateIntervalIDRef != null)
                {
                    dateInterval = IDManager.getID(dateIntervalIDRef) as DateInterval;
                    return this.dateInterval; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dateInterval != value)
                {
                    this.dateInterval = value;
                }
            }
        }
        #endregion
        
        public string DateIntervalIDRef { get; set; }
        public string choiceStr_eventDateType;
        
    
        
    
    }
    
}

