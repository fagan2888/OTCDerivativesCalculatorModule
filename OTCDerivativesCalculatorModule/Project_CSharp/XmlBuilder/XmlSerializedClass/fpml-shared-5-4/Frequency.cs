using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Frequency : ISerialized
    {
        public Frequency(XmlNode xmlNode)
        {
            XmlNode periodMultiplierNode = xmlNode.SelectSingleNode("periodMultiplier");
            
            if (periodMultiplierNode != null)
            {
                if (periodMultiplierNode.Attributes["href"] != null || periodMultiplierNode.Attributes["id"] != null) 
                {
                    if (periodMultiplierNode.Attributes["id"] != null) 
                    {
                        periodMultiplierIDRef_ = periodMultiplierNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(periodMultiplierNode);
                        IDManager.SetID(periodMultiplierIDRef_, ob);
                    }
                    else if (periodMultiplierNode.Attributes["href"] != null)
                    {
                        periodMultiplierIDRef_ = periodMultiplierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        periodMultiplier_ = new XsdTypePositiveInteger(periodMultiplierNode);
                    }
                }
                else
                {
                    periodMultiplier_ = new XsdTypePositiveInteger(periodMultiplierNode);
                }
            }
            
        
            XmlNode periodNode = xmlNode.SelectSingleNode("period");
            
            if (periodNode != null)
            {
                if (periodNode.Attributes["href"] != null || periodNode.Attributes["id"] != null) 
                {
                    if (periodNode.Attributes["id"] != null) 
                    {
                        periodIDRef_ = periodNode.Attributes["id"].Value;
                        PeriodExtendedEnum ob = new PeriodExtendedEnum(periodNode);
                        IDManager.SetID(periodIDRef_, ob);
                    }
                    else if (periodNode.Attributes["href"] != null)
                    {
                        periodIDRef_ = periodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        period_ = new PeriodExtendedEnum(periodNode);
                    }
                }
                else
                {
                    period_ = new PeriodExtendedEnum(periodNode);
                }
            }
            
        
        }
        
    
        #region PeriodMultiplier_
        private XsdTypePositiveInteger periodMultiplier_;
        public XsdTypePositiveInteger PeriodMultiplier_
        {
            get
            {
                if (this.periodMultiplier_ != null)
                {
                    return this.periodMultiplier_; 
                }
                else if (this.periodMultiplierIDRef_ != null)
                {
                    periodMultiplier_ = IDManager.getID(periodMultiplierIDRef_) as XsdTypePositiveInteger;
                    return this.periodMultiplier_; 
                }
                else
                {
                      return this.periodMultiplier_; 
                }
            }
            set
            {
                if (this.periodMultiplier_ != value)
                {
                    this.periodMultiplier_ = value;
                }
            }
        }
        #endregion
        
        public string periodMultiplierIDRef_ { get; set; }
        #region Period_
        private PeriodExtendedEnum period_;
        public PeriodExtendedEnum Period_
        {
            get
            {
                if (this.period_ != null)
                {
                    return this.period_; 
                }
                else if (this.periodIDRef_ != null)
                {
                    period_ = IDManager.getID(periodIDRef_) as PeriodExtendedEnum;
                    return this.period_; 
                }
                else
                {
                      return this.period_; 
                }
            }
            set
            {
                if (this.period_ != value)
                {
                    this.period_ = value;
                }
            }
        }
        #endregion
        
        public string periodIDRef_ { get; set; }
        
    
        
    
    }
    
}

