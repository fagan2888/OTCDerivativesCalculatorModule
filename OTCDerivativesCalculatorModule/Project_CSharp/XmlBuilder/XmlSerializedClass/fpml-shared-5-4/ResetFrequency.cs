using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ResetFrequency : Frequency
    {
        public ResetFrequency(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode weeklyRollConventionNode = xmlNode.SelectSingleNode("weeklyRollConvention");
            
            if (weeklyRollConventionNode != null)
            {
                if (weeklyRollConventionNode.Attributes["href"] != null || weeklyRollConventionNode.Attributes["id"] != null) 
                {
                    if (weeklyRollConventionNode.Attributes["id"] != null) 
                    {
                        weeklyRollConventionIDRef_ = weeklyRollConventionNode.Attributes["id"].Value;
                        WeeklyRollConventionEnum ob = new WeeklyRollConventionEnum(weeklyRollConventionNode);
                        IDManager.SetID(weeklyRollConventionIDRef_, ob);
                    }
                    else if (weeklyRollConventionNode.Attributes["href"] != null)
                    {
                        weeklyRollConventionIDRef_ = weeklyRollConventionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weeklyRollConvention_ = new WeeklyRollConventionEnum(weeklyRollConventionNode);
                    }
                }
                else
                {
                    weeklyRollConvention_ = new WeeklyRollConventionEnum(weeklyRollConventionNode);
                }
            }
            
        
        }
        
    
        #region WeeklyRollConvention_
        private WeeklyRollConventionEnum weeklyRollConvention_;
        public WeeklyRollConventionEnum WeeklyRollConvention_
        {
            get
            {
                if (this.weeklyRollConvention_ != null)
                {
                    return this.weeklyRollConvention_; 
                }
                else if (this.weeklyRollConventionIDRef_ != null)
                {
                    weeklyRollConvention_ = IDManager.getID(weeklyRollConventionIDRef_) as WeeklyRollConventionEnum;
                    return this.weeklyRollConvention_; 
                }
                else
                {
                      return this.weeklyRollConvention_; 
                }
            }
            set
            {
                if (this.weeklyRollConvention_ != value)
                {
                    this.weeklyRollConvention_ = value;
                }
            }
        }
        #endregion
        
        public string weeklyRollConventionIDRef_ { get; set; }
        
    
        
    
    }
    
}

