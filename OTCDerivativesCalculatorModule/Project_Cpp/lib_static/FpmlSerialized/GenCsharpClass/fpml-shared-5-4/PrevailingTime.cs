using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PrevailingTime
    {
        public PrevailingTime(XmlNode xmlNode)
        {
            XmlNodeList hourMinuteTimeNodeList = xmlNode.SelectNodes("hourMinuteTime");
            if (hourMinuteTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in hourMinuteTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        hourMinuteTimeIDRef = item.Attributes["id"].Name;
                        HourMinuteTime ob = HourMinuteTime();
                        IDManager.SetID(hourMinuteTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        hourMinuteTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        hourMinuteTime = new HourMinuteTime(item);
                    }
                }
            }
            
        
            XmlNodeList locationNodeList = xmlNode.SelectNodes("location");
            if (locationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in locationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        locationIDRef = item.Attributes["id"].Name;
                        TimezoneLocation ob = TimezoneLocation();
                        IDManager.SetID(locationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        locationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        location = new TimezoneLocation(item);
                    }
                }
            }
            
        
        }
        
    
        #region HourMinuteTime
        private HourMinuteTime hourMinuteTime;
        public HourMinuteTime HourMinuteTime
        {
            get
            {
                if (this.hourMinuteTime != null)
                {
                    return this.hourMinuteTime; 
                }
                else if (this.hourMinuteTimeIDRef != null)
                {
                    hourMinuteTime = IDManager.getID(hourMinuteTimeIDRef) as HourMinuteTime;
                    return this.hourMinuteTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.hourMinuteTime != value)
                {
                    this.hourMinuteTime = value;
                }
            }
        }
        #endregion
        
        public string HourMinuteTimeIDRef { get; set; }
        #region Location
        private TimezoneLocation location;
        public TimezoneLocation Location
        {
            get
            {
                if (this.location != null)
                {
                    return this.location; 
                }
                else if (this.locationIDRef != null)
                {
                    location = IDManager.getID(locationIDRef) as TimezoneLocation;
                    return this.location; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.location != value)
                {
                    this.location = value;
                }
            }
        }
        #endregion
        
        public string TimezoneLocationIDRef { get; set; }
        
    
        
    
    }
    
}

