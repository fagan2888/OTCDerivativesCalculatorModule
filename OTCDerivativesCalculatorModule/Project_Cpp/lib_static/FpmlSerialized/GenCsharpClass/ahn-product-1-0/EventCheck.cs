using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EventCheck
    {
        public EventCheck(XmlNode xmlNode)
        {
            XmlNodeList eventCheckNormalNodeList = xmlNode.SelectNodes("eventCheckNormal");
            if (eventCheckNormalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in eventCheckNormalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        eventCheckNormalIDRef = item.Attributes["id"].Name;
                        EventCheckNormal ob = EventCheckNormal();
                        IDManager.SetID(eventCheckNormalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        eventCheckNormalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        eventCheckNormal = new EventCheckNormal(item);
                    }
                }
            }
            
        
            XmlNodeList eventCheckTimeNodeList = xmlNode.SelectNodes("eventCheckTime");
            if (eventCheckTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in eventCheckTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        eventCheckTimeIDRef = item.Attributes["id"].Name;
                        EventCheckTime ob = EventCheckTime();
                        IDManager.SetID(eventCheckTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        eventCheckTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        eventCheckTime = new EventCheckTime(item);
                    }
                }
            }
            
        
        }
        
    
        #region EventCheckNormal
        private EventCheckNormal eventCheckNormal;
        public EventCheckNormal EventCheckNormal
        {
            get
            {
                if (this.eventCheckNormal != null)
                {
                    return this.eventCheckNormal; 
                }
                else if (this.eventCheckNormalIDRef != null)
                {
                    eventCheckNormal = IDManager.getID(eventCheckNormalIDRef) as EventCheckNormal;
                    return this.eventCheckNormal; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.eventCheckNormal != value)
                {
                    this.eventCheckNormal = value;
                }
            }
        }
        #endregion
        
        public string EventCheckNormalIDRef { get; set; }
        #region EventCheckTime
        private EventCheckTime eventCheckTime;
        public EventCheckTime EventCheckTime
        {
            get
            {
                if (this.eventCheckTime != null)
                {
                    return this.eventCheckTime; 
                }
                else if (this.eventCheckTimeIDRef != null)
                {
                    eventCheckTime = IDManager.getID(eventCheckTimeIDRef) as EventCheckTime;
                    return this.eventCheckTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.eventCheckTime != value)
                {
                    this.eventCheckTime = value;
                }
            }
        }
        #endregion
        
        public string EventCheckTimeIDRef { get; set; }
        public string choiceStr_ecType;
        
    
        
    
    }
    
}

