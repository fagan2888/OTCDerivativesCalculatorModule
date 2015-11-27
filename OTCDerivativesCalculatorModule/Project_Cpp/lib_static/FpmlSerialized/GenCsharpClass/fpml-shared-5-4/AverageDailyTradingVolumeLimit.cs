using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AverageDailyTradingVolumeLimit
    {
        public AverageDailyTradingVolumeLimit(XmlNode xmlNode)
        {
            XmlNodeList limitationPercentageNodeList = xmlNode.SelectNodes("limitationPercentage");
            if (limitationPercentageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in limitationPercentageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        limitationPercentageIDRef = item.Attributes["id"].Name;
                        RestrictedPercentage ob = RestrictedPercentage();
                        IDManager.SetID(limitationPercentageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        limitationPercentageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        limitationPercentage = new RestrictedPercentage(item);
                    }
                }
            }
            
        
            XmlNodeList limitationPeriodNodeList = xmlNode.SelectNodes("limitationPeriod");
            if (limitationPeriodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in limitationPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        limitationPeriodIDRef = item.Attributes["id"].Name;
                        XsdTypeNonNegativeInteger ob = XsdTypeNonNegativeInteger();
                        IDManager.SetID(limitationPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        limitationPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        limitationPeriod = new XsdTypeNonNegativeInteger(item);
                    }
                }
            }
            
        
        }
        
    
        #region LimitationPercentage
        private RestrictedPercentage limitationPercentage;
        public RestrictedPercentage LimitationPercentage
        {
            get
            {
                if (this.limitationPercentage != null)
                {
                    return this.limitationPercentage; 
                }
                else if (this.limitationPercentageIDRef != null)
                {
                    limitationPercentage = IDManager.getID(limitationPercentageIDRef) as RestrictedPercentage;
                    return this.limitationPercentage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.limitationPercentage != value)
                {
                    this.limitationPercentage = value;
                }
            }
        }
        #endregion
        
        public string RestrictedPercentageIDRef { get; set; }
        #region LimitationPeriod
        private XsdTypeNonNegativeInteger limitationPeriod;
        public XsdTypeNonNegativeInteger LimitationPeriod
        {
            get
            {
                if (this.limitationPeriod != null)
                {
                    return this.limitationPeriod; 
                }
                else if (this.limitationPeriodIDRef != null)
                {
                    limitationPeriod = IDManager.getID(limitationPeriodIDRef) as XsdTypeNonNegativeInteger;
                    return this.limitationPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.limitationPeriod != value)
                {
                    this.limitationPeriod = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNonNegativeIntegerIDRef { get; set; }
        
    
        
    
    }
    
}

