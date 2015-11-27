using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PrevailingTime : ISerialized
    {
        public PrevailingTime(XmlNode xmlNode)
        {
            XmlNode hourMinuteTimeNode = xmlNode.SelectSingleNode("hourMinuteTime");
            
            if (hourMinuteTimeNode != null)
            {
                if (hourMinuteTimeNode.Attributes["href"] != null || hourMinuteTimeNode.Attributes["id"] != null) 
                {
                    if (hourMinuteTimeNode.Attributes["id"] != null) 
                    {
                        hourMinuteTimeIDRef_ = hourMinuteTimeNode.Attributes["id"].Value;
                        HourMinuteTime ob = new HourMinuteTime(hourMinuteTimeNode);
                        IDManager.SetID(hourMinuteTimeIDRef_, ob);
                    }
                    else if (hourMinuteTimeNode.Attributes["href"] != null)
                    {
                        hourMinuteTimeIDRef_ = hourMinuteTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        hourMinuteTime_ = new HourMinuteTime(hourMinuteTimeNode);
                    }
                }
                else
                {
                    hourMinuteTime_ = new HourMinuteTime(hourMinuteTimeNode);
                }
            }
            
        
            XmlNode locationNode = xmlNode.SelectSingleNode("location");
            
            if (locationNode != null)
            {
                if (locationNode.Attributes["href"] != null || locationNode.Attributes["id"] != null) 
                {
                    if (locationNode.Attributes["id"] != null) 
                    {
                        locationIDRef_ = locationNode.Attributes["id"].Value;
                        TimezoneLocation ob = new TimezoneLocation(locationNode);
                        IDManager.SetID(locationIDRef_, ob);
                    }
                    else if (locationNode.Attributes["href"] != null)
                    {
                        locationIDRef_ = locationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        location_ = new TimezoneLocation(locationNode);
                    }
                }
                else
                {
                    location_ = new TimezoneLocation(locationNode);
                }
            }
            
        
        }
        
    
        #region HourMinuteTime_
        private HourMinuteTime hourMinuteTime_;
        public HourMinuteTime HourMinuteTime_
        {
            get
            {
                if (this.hourMinuteTime_ != null)
                {
                    return this.hourMinuteTime_; 
                }
                else if (this.hourMinuteTimeIDRef_ != null)
                {
                    hourMinuteTime_ = IDManager.getID(hourMinuteTimeIDRef_) as HourMinuteTime;
                    return this.hourMinuteTime_; 
                }
                else
                {
                      return this.hourMinuteTime_; 
                }
            }
            set
            {
                if (this.hourMinuteTime_ != value)
                {
                    this.hourMinuteTime_ = value;
                }
            }
        }
        #endregion
        
        public string hourMinuteTimeIDRef_ { get; set; }
        #region Location_
        private TimezoneLocation location_;
        public TimezoneLocation Location_
        {
            get
            {
                if (this.location_ != null)
                {
                    return this.location_; 
                }
                else if (this.locationIDRef_ != null)
                {
                    location_ = IDManager.getID(locationIDRef_) as TimezoneLocation;
                    return this.location_; 
                }
                else
                {
                      return this.location_; 
                }
            }
            set
            {
                if (this.location_ != value)
                {
                    this.location_ = value;
                }
            }
        }
        #endregion
        
        public string locationIDRef_ { get; set; }
        
    
        
    
    }
    
}

