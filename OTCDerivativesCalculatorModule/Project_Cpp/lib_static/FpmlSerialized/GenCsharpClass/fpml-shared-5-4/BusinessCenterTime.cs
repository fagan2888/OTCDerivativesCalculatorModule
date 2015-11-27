using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BusinessCenterTime
    {
        public BusinessCenterTime(XmlNode xmlNode)
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
            
        
            XmlNodeList businessCenterNodeList = xmlNode.SelectNodes("businessCenter");
            if (businessCenterNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessCenterNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessCenterIDRef = item.Attributes["id"].Name;
                        BusinessCenter ob = BusinessCenter();
                        IDManager.SetID(businessCenterIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessCenterIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessCenter = new BusinessCenter(item);
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
        #region BusinessCenter
        private BusinessCenter businessCenter;
        public BusinessCenter BusinessCenter
        {
            get
            {
                if (this.businessCenter != null)
                {
                    return this.businessCenter; 
                }
                else if (this.businessCenterIDRef != null)
                {
                    businessCenter = IDManager.getID(businessCenterIDRef) as BusinessCenter;
                    return this.businessCenter; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessCenter != value)
                {
                    this.businessCenter = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterIDRef { get; set; }
        
    
        
    
    }
    
}

