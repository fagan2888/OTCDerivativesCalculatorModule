using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CalculationPeriodFrequency : Frequency
    {
        public CalculationPeriodFrequency(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode rollConventionNode = xmlNode.SelectSingleNode("rollConvention");
            
            if (rollConventionNode != null)
            {
                if (rollConventionNode.Attributes["href"] != null || rollConventionNode.Attributes["id"] != null) 
                {
                    if (rollConventionNode.Attributes["id"] != null) 
                    {
                        rollConventionIDRef_ = rollConventionNode.Attributes["id"].Value;
                        RollConventionEnum ob = new RollConventionEnum(rollConventionNode);
                        IDManager.SetID(rollConventionIDRef_, ob);
                    }
                    else if (rollConventionNode.Attributes["href"] != null)
                    {
                        rollConventionIDRef_ = rollConventionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rollConvention_ = new RollConventionEnum(rollConventionNode);
                    }
                }
                else
                {
                    rollConvention_ = new RollConventionEnum(rollConventionNode);
                }
            }
            
        
        }
        
    
        #region RollConvention_
        private RollConventionEnum rollConvention_;
        public RollConventionEnum RollConvention_
        {
            get
            {
                if (this.rollConvention_ != null)
                {
                    return this.rollConvention_; 
                }
                else if (this.rollConventionIDRef_ != null)
                {
                    rollConvention_ = IDManager.getID(rollConventionIDRef_) as RollConventionEnum;
                    return this.rollConvention_; 
                }
                else
                {
                      return this.rollConvention_; 
                }
            }
            set
            {
                if (this.rollConvention_ != value)
                {
                    this.rollConvention_ = value;
                }
            }
        }
        #endregion
        
        public string rollConventionIDRef_ { get; set; }
        
    
        
    
    }
    
}

