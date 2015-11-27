using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class StructuredProductPayoff
    {
        public StructuredProductPayoff(XmlNode xmlNode)
        {
            XmlNodeList baseInformationNodeList = xmlNode.SelectNodes("baseInformation");
            if (baseInformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in baseInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        baseInformationIDRef = item.Attributes["id"].Name;
                        BaseInformation ob = BaseInformation();
                        IDManager.SetID(baseInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        baseInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        baseInformation = new BaseInformation(item);
                    }
                }
            }
            
        
            XmlNodeList eventScheduleNodeList = xmlNode.SelectNodes("eventSchedule");
            if (eventScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in eventScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        eventScheduleIDRef = item.Attributes["id"].Name;
                        EventSchedule ob = EventSchedule();
                        IDManager.SetID(eventScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        eventScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        eventSchedule = new EventSchedule(item);
                    }
                }
            }
            
        
        }
        
    
        #region BaseInformation
        private BaseInformation baseInformation;
        public BaseInformation BaseInformation
        {
            get
            {
                if (this.baseInformation != null)
                {
                    return this.baseInformation; 
                }
                else if (this.baseInformationIDRef != null)
                {
                    baseInformation = IDManager.getID(baseInformationIDRef) as BaseInformation;
                    return this.baseInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.baseInformation != value)
                {
                    this.baseInformation = value;
                }
            }
        }
        #endregion
        
        public string BaseInformationIDRef { get; set; }
        #region EventSchedule
        private EventSchedule eventSchedule;
        public EventSchedule EventSchedule
        {
            get
            {
                if (this.eventSchedule != null)
                {
                    return this.eventSchedule; 
                }
                else if (this.eventScheduleIDRef != null)
                {
                    eventSchedule = IDManager.getID(eventScheduleIDRef) as EventSchedule;
                    return this.eventSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.eventSchedule != value)
                {
                    this.eventSchedule = value;
                }
            }
        }
        #endregion
        
        public string EventScheduleIDRef { get; set; }
        
    
        
    
    }
    
}

