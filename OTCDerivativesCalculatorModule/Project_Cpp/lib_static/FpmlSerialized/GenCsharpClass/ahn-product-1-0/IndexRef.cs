using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class IndexRef
    {
        public IndexRef(XmlNode xmlNode)
        {
            XmlNodeList underlyingIndexRefNodeList = xmlNode.SelectNodes("underlyingIndexRef");
            if (underlyingIndexRefNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in underlyingIndexRefNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        underlyingIndexRefIDRef = item.Attributes["id"].Name;
                        UnderlyingIndex ob = UnderlyingIndex();
                        IDManager.SetID(underlyingIndexRefIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        underlyingIndexRefIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        underlyingIndexRef = new UnderlyingIndex(item);
                    }
                }
            }
            
        
            XmlNodeList eventDateRefNodeList = xmlNode.SelectNodes("eventDateRef");
            if (eventDateRefNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in eventDateRefNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        eventDateRefIDRef = item.Attributes["id"].Name;
                        EventDate ob = EventDate();
                        IDManager.SetID(eventDateRefIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        eventDateRefIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        eventDateRef = new EventDate(item);
                    }
                }
            }
            
        
            XmlNodeList fixingDaysNodeList = xmlNode.SelectNodes("fixingDays");
            if (fixingDaysNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixingDaysNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixingDaysIDRef = item.Attributes["id"].Name;
                        FixingDays ob = FixingDays();
                        IDManager.SetID(fixingDaysIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixingDaysIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixingDays = new FixingDays(item);
                    }
                }
            }
            
        
        }
        
    
        #region UnderlyingIndexRef
        private UnderlyingIndex underlyingIndexRef;
        public UnderlyingIndex UnderlyingIndexRef
        {
            get
            {
                if (this.underlyingIndexRef != null)
                {
                    return this.underlyingIndexRef; 
                }
                else if (this.underlyingIndexRefIDRef != null)
                {
                    underlyingIndexRef = IDManager.getID(underlyingIndexRefIDRef) as UnderlyingIndex;
                    return this.underlyingIndexRef; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.underlyingIndexRef != value)
                {
                    this.underlyingIndexRef = value;
                }
            }
        }
        #endregion
        
        public string UnderlyingIndexIDRef { get; set; }
        #region EventDateRef
        private EventDate eventDateRef;
        public EventDate EventDateRef
        {
            get
            {
                if (this.eventDateRef != null)
                {
                    return this.eventDateRef; 
                }
                else if (this.eventDateRefIDRef != null)
                {
                    eventDateRef = IDManager.getID(eventDateRefIDRef) as EventDate;
                    return this.eventDateRef; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.eventDateRef != value)
                {
                    this.eventDateRef = value;
                }
            }
        }
        #endregion
        
        public string EventDateIDRef { get; set; }
        #region FixingDays
        private FixingDays fixingDays;
        public FixingDays FixingDays
        {
            get
            {
                if (this.fixingDays != null)
                {
                    return this.fixingDays; 
                }
                else if (this.fixingDaysIDRef != null)
                {
                    fixingDays = IDManager.getID(fixingDaysIDRef) as FixingDays;
                    return this.fixingDays; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixingDays != value)
                {
                    this.fixingDays = value;
                }
            }
        }
        #endregion
        
        public string FixingDaysIDRef { get; set; }
        
    
        
    
    }
    
}

