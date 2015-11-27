using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EventCheckNormal
    {
        public EventCheckNormal(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList eventDateNodeList = xmlNode.SelectNodes("eventDate");
            if (eventDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in eventDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        eventDateIDRef = item.Attributes["id"].Name;
                        EventDate ob = EventDate();
                        IDManager.SetID(eventDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        eventDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        eventDate = new EventDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region EventDate
        private EventDate eventDate;
        public EventDate EventDate
        {
            get
            {
                if (this.eventDate != null)
                {
                    return this.eventDate; 
                }
                else if (this.eventDateIDRef != null)
                {
                    eventDate = IDManager.getID(eventDateIDRef) as EventDate;
                    return this.eventDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.eventDate != value)
                {
                    this.eventDate = value;
                }
            }
        }
        #endregion
        
        public string EventDateIDRef { get; set; }
        
    
        
    
    }
    
}

