using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class StructuredProductPayoff : ISerialized
    {
        public StructuredProductPayoff(XmlNode xmlNode)
        {
            XmlNode baseInformationNode = xmlNode.SelectSingleNode("baseInformation");
            
            if (baseInformationNode != null)
            {
                if (baseInformationNode.Attributes["href"] != null || baseInformationNode.Attributes["id"] != null) 
                {
                    if (baseInformationNode.Attributes["id"] != null) 
                    {
                        baseInformationIDRef_ = baseInformationNode.Attributes["id"].Value;
                        BaseInformation ob = new BaseInformation(baseInformationNode);
                        IDManager.SetID(baseInformationIDRef_, ob);
                    }
                    else if (baseInformationNode.Attributes["href"] != null)
                    {
                        baseInformationIDRef_ = baseInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        baseInformation_ = new BaseInformation(baseInformationNode);
                    }
                }
                else
                {
                    baseInformation_ = new BaseInformation(baseInformationNode);
                }
            }
            
        
            XmlNode eventScheduleNode = xmlNode.SelectSingleNode("eventSchedule");
            
            if (eventScheduleNode != null)
            {
                if (eventScheduleNode.Attributes["href"] != null || eventScheduleNode.Attributes["id"] != null) 
                {
                    if (eventScheduleNode.Attributes["id"] != null) 
                    {
                        eventScheduleIDRef_ = eventScheduleNode.Attributes["id"].Value;
                        EventSchedule ob = new EventSchedule(eventScheduleNode);
                        IDManager.SetID(eventScheduleIDRef_, ob);
                    }
                    else if (eventScheduleNode.Attributes["href"] != null)
                    {
                        eventScheduleIDRef_ = eventScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        eventSchedule_ = new EventSchedule(eventScheduleNode);
                    }
                }
                else
                {
                    eventSchedule_ = new EventSchedule(eventScheduleNode);
                }
            }
            
        
        }
        
    
        #region BaseInformation_
        private BaseInformation baseInformation_;
        public BaseInformation BaseInformation_
        {
            get
            {
                if (this.baseInformation_ != null)
                {
                    return this.baseInformation_; 
                }
                else if (this.baseInformationIDRef_ != null)
                {
                    baseInformation_ = IDManager.getID(baseInformationIDRef_) as BaseInformation;
                    return this.baseInformation_; 
                }
                else
                {
                      return this.baseInformation_; 
                }
            }
            set
            {
                if (this.baseInformation_ != value)
                {
                    this.baseInformation_ = value;
                }
            }
        }
        #endregion
        
        public string baseInformationIDRef_ { get; set; }
        #region EventSchedule_
        private EventSchedule eventSchedule_;
        public EventSchedule EventSchedule_
        {
            get
            {
                if (this.eventSchedule_ != null)
                {
                    return this.eventSchedule_; 
                }
                else if (this.eventScheduleIDRef_ != null)
                {
                    eventSchedule_ = IDManager.getID(eventScheduleIDRef_) as EventSchedule;
                    return this.eventSchedule_; 
                }
                else
                {
                      return this.eventSchedule_; 
                }
            }
            set
            {
                if (this.eventSchedule_ != value)
                {
                    this.eventSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string eventScheduleIDRef_ { get; set; }
        
    
        
    
    }
    
}

