using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class WeatherCalculationPeriods : ISerialized
    {
        public WeatherCalculationPeriods(XmlNode xmlNode)
        {
            XmlNodeList calculationPeriodNodeList = xmlNode.SelectNodes("calculationPeriod");
            
            if (calculationPeriodNodeList != null)
            {
                this.calculationPeriod_ = new List<WeatherCalculationPeriod>();
                foreach (XmlNode item in calculationPeriodNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            calculationPeriodIDRef_ = item.Attributes["id"].Value;
                            calculationPeriod_.Add(new WeatherCalculationPeriod(item));
                            IDManager.SetID(calculationPeriodIDRef_, calculationPeriod_[calculationPeriod_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            calculationPeriodIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        calculationPeriod_.Add(new WeatherCalculationPeriod(item));
                        }
                    }
                    else
                    {
                        calculationPeriod_.Add(new WeatherCalculationPeriod(item));
                    }
                }
            }
            
        
        }
        
    
        #region CalculationPeriod_
        private List<WeatherCalculationPeriod> calculationPeriod_;
        public List<WeatherCalculationPeriod> CalculationPeriod_
        {
            get
            {
                if (this.calculationPeriod_ != null)
                {
                    return this.calculationPeriod_; 
                }
                else if (this.calculationPeriodIDRef_ != null)
                {
                    return this.calculationPeriod_; 
                }
                else
                {
                      return this.calculationPeriod_; 
                }
            }
            set
            {
                if (this.calculationPeriod_ != value)
                {
                    this.calculationPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodIDRef_ { get; set; }
        
    
        
    
    }
    
}

