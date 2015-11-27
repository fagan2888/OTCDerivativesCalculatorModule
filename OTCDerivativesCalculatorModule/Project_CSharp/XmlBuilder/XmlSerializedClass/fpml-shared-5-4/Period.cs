using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Period : ISerialized
    {
        public Period(XmlNode xmlNode)
        {
            XmlNode periodMultiplierNode = xmlNode.SelectSingleNode("periodMultiplier");
            
            if (periodMultiplierNode != null)
            {
                if (periodMultiplierNode.Attributes["href"] != null || periodMultiplierNode.Attributes["id"] != null) 
                {
                    if (periodMultiplierNode.Attributes["id"] != null) 
                    {
                        periodMultiplierIDRef_ = periodMultiplierNode.Attributes["id"].Value;
                        XsdTypeInteger ob = new XsdTypeInteger(periodMultiplierNode);
                        IDManager.SetID(periodMultiplierIDRef_, ob);
                    }
                    else if (periodMultiplierNode.Attributes["href"] != null)
                    {
                        periodMultiplierIDRef_ = periodMultiplierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        periodMultiplier_ = new XsdTypeInteger(periodMultiplierNode);
                    }
                }
                else
                {
                    periodMultiplier_ = new XsdTypeInteger(periodMultiplierNode);
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
                        PeriodEnum ob = new PeriodEnum(periodNode);
                        IDManager.SetID(periodIDRef_, ob);
                    }
                    else if (periodNode.Attributes["href"] != null)
                    {
                        periodIDRef_ = periodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        period_ = new PeriodEnum(periodNode);
                    }
                }
                else
                {
                    period_ = new PeriodEnum(periodNode);
                }
            }
            
        
        }
        
    
        #region PeriodMultiplier_
        private XsdTypeInteger periodMultiplier_;
        public XsdTypeInteger PeriodMultiplier_
        {
            get
            {
                if (this.periodMultiplier_ != null)
                {
                    return this.periodMultiplier_; 
                }
                else if (this.periodMultiplierIDRef_ != null)
                {
                    periodMultiplier_ = IDManager.getID(periodMultiplierIDRef_) as XsdTypeInteger;
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
        private PeriodEnum period_;
        public PeriodEnum Period_
        {
            get
            {
                if (this.period_ != null)
                {
                    return this.period_; 
                }
                else if (this.periodIDRef_ != null)
                {
                    period_ = IDManager.getID(periodIDRef_) as PeriodEnum;
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

