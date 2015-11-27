using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class YieldCurve : PricingStructure
    {
        public YieldCurve(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode algorithmNode = xmlNode.SelectSingleNode("algorithm");
            
            if (algorithmNode != null)
            {
                if (algorithmNode.Attributes["href"] != null || algorithmNode.Attributes["id"] != null) 
                {
                    if (algorithmNode.Attributes["id"] != null) 
                    {
                        algorithmIDRef_ = algorithmNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(algorithmNode);
                        IDManager.SetID(algorithmIDRef_, ob);
                    }
                    else if (algorithmNode.Attributes["href"] != null)
                    {
                        algorithmIDRef_ = algorithmNode.Attributes["href"].Value;
                    }
                    else
                    {
                        algorithm_ = new XsdTypeString(algorithmNode);
                    }
                }
                else
                {
                    algorithm_ = new XsdTypeString(algorithmNode);
                }
            }
            
        
            XmlNode forecastRateIndexNode = xmlNode.SelectSingleNode("forecastRateIndex");
            
            if (forecastRateIndexNode != null)
            {
                if (forecastRateIndexNode.Attributes["href"] != null || forecastRateIndexNode.Attributes["id"] != null) 
                {
                    if (forecastRateIndexNode.Attributes["id"] != null) 
                    {
                        forecastRateIndexIDRef_ = forecastRateIndexNode.Attributes["id"].Value;
                        ForecastRateIndex ob = new ForecastRateIndex(forecastRateIndexNode);
                        IDManager.SetID(forecastRateIndexIDRef_, ob);
                    }
                    else if (forecastRateIndexNode.Attributes["href"] != null)
                    {
                        forecastRateIndexIDRef_ = forecastRateIndexNode.Attributes["href"].Value;
                    }
                    else
                    {
                        forecastRateIndex_ = new ForecastRateIndex(forecastRateIndexNode);
                    }
                }
                else
                {
                    forecastRateIndex_ = new ForecastRateIndex(forecastRateIndexNode);
                }
            }
            
        
        }
        
    
        #region Algorithm_
        private XsdTypeString algorithm_;
        public XsdTypeString Algorithm_
        {
            get
            {
                if (this.algorithm_ != null)
                {
                    return this.algorithm_; 
                }
                else if (this.algorithmIDRef_ != null)
                {
                    algorithm_ = IDManager.getID(algorithmIDRef_) as XsdTypeString;
                    return this.algorithm_; 
                }
                else
                {
                      return this.algorithm_; 
                }
            }
            set
            {
                if (this.algorithm_ != value)
                {
                    this.algorithm_ = value;
                }
            }
        }
        #endregion
        
        public string algorithmIDRef_ { get; set; }
        #region ForecastRateIndex_
        private ForecastRateIndex forecastRateIndex_;
        public ForecastRateIndex ForecastRateIndex_
        {
            get
            {
                if (this.forecastRateIndex_ != null)
                {
                    return this.forecastRateIndex_; 
                }
                else if (this.forecastRateIndexIDRef_ != null)
                {
                    forecastRateIndex_ = IDManager.getID(forecastRateIndexIDRef_) as ForecastRateIndex;
                    return this.forecastRateIndex_; 
                }
                else
                {
                      return this.forecastRateIndex_; 
                }
            }
            set
            {
                if (this.forecastRateIndex_ != value)
                {
                    this.forecastRateIndex_ = value;
                }
            }
        }
        #endregion
        
        public string forecastRateIndexIDRef_ { get; set; }
        
    
        
    
    }
    
}

