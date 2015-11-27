using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AverageDailyTradingVolumeLimit : ISerialized
    {
        public AverageDailyTradingVolumeLimit(XmlNode xmlNode)
        {
            XmlNode limitationPercentageNode = xmlNode.SelectSingleNode("limitationPercentage");
            
            if (limitationPercentageNode != null)
            {
                if (limitationPercentageNode.Attributes["href"] != null || limitationPercentageNode.Attributes["id"] != null) 
                {
                    if (limitationPercentageNode.Attributes["id"] != null) 
                    {
                        limitationPercentageIDRef_ = limitationPercentageNode.Attributes["id"].Value;
                        RestrictedPercentage ob = new RestrictedPercentage(limitationPercentageNode);
                        IDManager.SetID(limitationPercentageIDRef_, ob);
                    }
                    else if (limitationPercentageNode.Attributes["href"] != null)
                    {
                        limitationPercentageIDRef_ = limitationPercentageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        limitationPercentage_ = new RestrictedPercentage(limitationPercentageNode);
                    }
                }
                else
                {
                    limitationPercentage_ = new RestrictedPercentage(limitationPercentageNode);
                }
            }
            
        
            XmlNode limitationPeriodNode = xmlNode.SelectSingleNode("limitationPeriod");
            
            if (limitationPeriodNode != null)
            {
                if (limitationPeriodNode.Attributes["href"] != null || limitationPeriodNode.Attributes["id"] != null) 
                {
                    if (limitationPeriodNode.Attributes["id"] != null) 
                    {
                        limitationPeriodIDRef_ = limitationPeriodNode.Attributes["id"].Value;
                        XsdTypeNonNegativeInteger ob = new XsdTypeNonNegativeInteger(limitationPeriodNode);
                        IDManager.SetID(limitationPeriodIDRef_, ob);
                    }
                    else if (limitationPeriodNode.Attributes["href"] != null)
                    {
                        limitationPeriodIDRef_ = limitationPeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        limitationPeriod_ = new XsdTypeNonNegativeInteger(limitationPeriodNode);
                    }
                }
                else
                {
                    limitationPeriod_ = new XsdTypeNonNegativeInteger(limitationPeriodNode);
                }
            }
            
        
        }
        
    
        #region LimitationPercentage_
        private RestrictedPercentage limitationPercentage_;
        public RestrictedPercentage LimitationPercentage_
        {
            get
            {
                if (this.limitationPercentage_ != null)
                {
                    return this.limitationPercentage_; 
                }
                else if (this.limitationPercentageIDRef_ != null)
                {
                    limitationPercentage_ = IDManager.getID(limitationPercentageIDRef_) as RestrictedPercentage;
                    return this.limitationPercentage_; 
                }
                else
                {
                      return this.limitationPercentage_; 
                }
            }
            set
            {
                if (this.limitationPercentage_ != value)
                {
                    this.limitationPercentage_ = value;
                }
            }
        }
        #endregion
        
        public string limitationPercentageIDRef_ { get; set; }
        #region LimitationPeriod_
        private XsdTypeNonNegativeInteger limitationPeriod_;
        public XsdTypeNonNegativeInteger LimitationPeriod_
        {
            get
            {
                if (this.limitationPeriod_ != null)
                {
                    return this.limitationPeriod_; 
                }
                else if (this.limitationPeriodIDRef_ != null)
                {
                    limitationPeriod_ = IDManager.getID(limitationPeriodIDRef_) as XsdTypeNonNegativeInteger;
                    return this.limitationPeriod_; 
                }
                else
                {
                      return this.limitationPeriod_; 
                }
            }
            set
            {
                if (this.limitationPeriod_ != value)
                {
                    this.limitationPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string limitationPeriodIDRef_ { get; set; }
        
    
        
    
    }
    
}

