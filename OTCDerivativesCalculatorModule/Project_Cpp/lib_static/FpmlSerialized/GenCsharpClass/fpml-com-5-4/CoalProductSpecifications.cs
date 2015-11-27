using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CoalProductSpecifications
    {
        public CoalProductSpecifications(XmlNode xmlNode)
        {
            XmlNodeList standardQualityNodeList = xmlNode.SelectNodes("standardQuality");
            if (standardQualityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in standardQualityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        standardQualityIDRef = item.Attributes["id"].Name;
                        CoalStandardQuality ob = CoalStandardQuality();
                        IDManager.SetID(standardQualityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        standardQualityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        standardQuality = new CoalStandardQuality(item);
                    }
                }
            }
            
        
            XmlNodeList standardQualityScheduleNodeList = xmlNode.SelectNodes("standardQualitySchedule");
            if (standardQualityScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in standardQualityScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        standardQualityScheduleIDRef = item.Attributes["id"].Name;
                        CoalStandardQualitySchedule ob = CoalStandardQualitySchedule();
                        IDManager.SetID(standardQualityScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        standardQualityScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        standardQualitySchedule = new CoalStandardQualitySchedule(item);
                    }
                }
            }
            
        
        }
        
    
        #region StandardQuality
        private CoalStandardQuality standardQuality;
        public CoalStandardQuality StandardQuality
        {
            get
            {
                if (this.standardQuality != null)
                {
                    return this.standardQuality; 
                }
                else if (this.standardQualityIDRef != null)
                {
                    standardQuality = IDManager.getID(standardQualityIDRef) as CoalStandardQuality;
                    return this.standardQuality; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.standardQuality != value)
                {
                    this.standardQuality = value;
                }
            }
        }
        #endregion
        
        public string CoalStandardQualityIDRef { get; set; }
        #region StandardQualitySchedule
        private CoalStandardQualitySchedule standardQualitySchedule;
        public CoalStandardQualitySchedule StandardQualitySchedule
        {
            get
            {
                if (this.standardQualitySchedule != null)
                {
                    return this.standardQualitySchedule; 
                }
                else if (this.standardQualityScheduleIDRef != null)
                {
                    standardQualitySchedule = IDManager.getID(standardQualityScheduleIDRef) as CoalStandardQualitySchedule;
                    return this.standardQualitySchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.standardQualitySchedule != value)
                {
                    this.standardQualitySchedule = value;
                }
            }
        }
        #endregion
        
        public string CoalStandardQualityScheduleIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

