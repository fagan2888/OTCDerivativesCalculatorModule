using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BusinessCenterTime : ISerialized
    {
        public BusinessCenterTime(XmlNode xmlNode)
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
            
        
            XmlNode businessCenterNode = xmlNode.SelectSingleNode("businessCenter");
            
            if (businessCenterNode != null)
            {
                if (businessCenterNode.Attributes["href"] != null || businessCenterNode.Attributes["id"] != null) 
                {
                    if (businessCenterNode.Attributes["id"] != null) 
                    {
                        businessCenterIDRef_ = businessCenterNode.Attributes["id"].Value;
                        BusinessCenter ob = new BusinessCenter(businessCenterNode);
                        IDManager.SetID(businessCenterIDRef_, ob);
                    }
                    else if (businessCenterNode.Attributes["href"] != null)
                    {
                        businessCenterIDRef_ = businessCenterNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessCenter_ = new BusinessCenter(businessCenterNode);
                    }
                }
                else
                {
                    businessCenter_ = new BusinessCenter(businessCenterNode);
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
        #region BusinessCenter_
        private BusinessCenter businessCenter_;
        public BusinessCenter BusinessCenter_
        {
            get
            {
                if (this.businessCenter_ != null)
                {
                    return this.businessCenter_; 
                }
                else if (this.businessCenterIDRef_ != null)
                {
                    businessCenter_ = IDManager.getID(businessCenterIDRef_) as BusinessCenter;
                    return this.businessCenter_; 
                }
                else
                {
                      return this.businessCenter_; 
                }
            }
            set
            {
                if (this.businessCenter_ != value)
                {
                    this.businessCenter_ = value;
                }
            }
        }
        #endregion
        
        public string businessCenterIDRef_ { get; set; }
        
    
        
    
    }
    
}

