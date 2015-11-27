using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CoalProductSpecifications : ISerialized
    {
        public CoalProductSpecifications(XmlNode xmlNode)
        {
            XmlNode standardQualityNode = xmlNode.SelectSingleNode("standardQuality");
            
            if (standardQualityNode != null)
            {
                if (standardQualityNode.Attributes["href"] != null || standardQualityNode.Attributes["id"] != null) 
                {
                    if (standardQualityNode.Attributes["id"] != null) 
                    {
                        standardQualityIDRef_ = standardQualityNode.Attributes["id"].Value;
                        CoalStandardQuality ob = new CoalStandardQuality(standardQualityNode);
                        IDManager.SetID(standardQualityIDRef_, ob);
                    }
                    else if (standardQualityNode.Attributes["href"] != null)
                    {
                        standardQualityIDRef_ = standardQualityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        standardQuality_ = new CoalStandardQuality(standardQualityNode);
                    }
                }
                else
                {
                    standardQuality_ = new CoalStandardQuality(standardQualityNode);
                }
            }
            
        
            XmlNode standardQualityScheduleNode = xmlNode.SelectSingleNode("standardQualitySchedule");
            
            if (standardQualityScheduleNode != null)
            {
                if (standardQualityScheduleNode.Attributes["href"] != null || standardQualityScheduleNode.Attributes["id"] != null) 
                {
                    if (standardQualityScheduleNode.Attributes["id"] != null) 
                    {
                        standardQualityScheduleIDRef_ = standardQualityScheduleNode.Attributes["id"].Value;
                        CoalStandardQualitySchedule ob = new CoalStandardQualitySchedule(standardQualityScheduleNode);
                        IDManager.SetID(standardQualityScheduleIDRef_, ob);
                    }
                    else if (standardQualityScheduleNode.Attributes["href"] != null)
                    {
                        standardQualityScheduleIDRef_ = standardQualityScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        standardQualitySchedule_ = new CoalStandardQualitySchedule(standardQualityScheduleNode);
                    }
                }
                else
                {
                    standardQualitySchedule_ = new CoalStandardQualitySchedule(standardQualityScheduleNode);
                }
            }
            
        
        }
        
    
        #region StandardQuality_
        private CoalStandardQuality standardQuality_;
        public CoalStandardQuality StandardQuality_
        {
            get
            {
                if (this.standardQuality_ != null)
                {
                    return this.standardQuality_; 
                }
                else if (this.standardQualityIDRef_ != null)
                {
                    standardQuality_ = IDManager.getID(standardQualityIDRef_) as CoalStandardQuality;
                    return this.standardQuality_; 
                }
                else
                {
                      return this.standardQuality_; 
                }
            }
            set
            {
                if (this.standardQuality_ != value)
                {
                    this.standardQuality_ = value;
                }
            }
        }
        #endregion
        
        public string standardQualityIDRef_ { get; set; }
        #region StandardQualitySchedule_
        private CoalStandardQualitySchedule standardQualitySchedule_;
        public CoalStandardQualitySchedule StandardQualitySchedule_
        {
            get
            {
                if (this.standardQualitySchedule_ != null)
                {
                    return this.standardQualitySchedule_; 
                }
                else if (this.standardQualityScheduleIDRef_ != null)
                {
                    standardQualitySchedule_ = IDManager.getID(standardQualityScheduleIDRef_) as CoalStandardQualitySchedule;
                    return this.standardQualitySchedule_; 
                }
                else
                {
                      return this.standardQualitySchedule_; 
                }
            }
            set
            {
                if (this.standardQualitySchedule_ != value)
                {
                    this.standardQualitySchedule_ = value;
                }
            }
        }
        #endregion
        
        public string standardQualityScheduleIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

