using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EventSchedule
    {
        public EventSchedule(XmlNode xmlNode)
        {
            XmlNodeList eventCheckNodeList = xmlNode.SelectNodes("eventCheck");
            
            foreach (XmlNode item in eventCheckNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        eventCheckIDRef = item.Attributes["id"].Name;
                        List<EventCheck> ob = new List<EventCheck>();
                        ob.Add(new EventCheck(item));
                        IDManager.SetID(eventCheckIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        eventCheckIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    eventCheck.Add(new EventCheck(item));
                    }
                }
            }
            
        
        }
        
    
        #region EventCheck
        private List<EventCheck> eventCheck;
        public List<EventCheck> EventCheck
        {
            get
            {
                if (this.eventCheck != null)
                {
                    return this.eventCheck; 
                }
                else if (this.eventCheckIDRef != null)
                {
                    eventCheck = IDManager.getID(eventCheckIDRef) as List<EventCheck>;
                    return this.eventCheck; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.eventCheck != value)
                {
                    this.eventCheck = value;
                }
            }
        }
        #endregion
        
        public string EventCheckIDRef { get; set; }
        
    
        
    
    }
    
}

