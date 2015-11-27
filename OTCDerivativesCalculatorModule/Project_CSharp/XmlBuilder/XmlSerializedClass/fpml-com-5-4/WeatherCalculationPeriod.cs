using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class WeatherCalculationPeriod : ISerialized
    {
        public WeatherCalculationPeriod(XmlNode xmlNode)
        {
            XmlNode calculationPeriodFirstDayNode = xmlNode.SelectSingleNode("calculationPeriodFirstDay");
            
            if (calculationPeriodFirstDayNode != null)
            {
                if (calculationPeriodFirstDayNode.Attributes["href"] != null || calculationPeriodFirstDayNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodFirstDayNode.Attributes["id"] != null) 
                    {
                        calculationPeriodFirstDayIDRef_ = calculationPeriodFirstDayNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(calculationPeriodFirstDayNode);
                        IDManager.SetID(calculationPeriodFirstDayIDRef_, ob);
                    }
                    else if (calculationPeriodFirstDayNode.Attributes["href"] != null)
                    {
                        calculationPeriodFirstDayIDRef_ = calculationPeriodFirstDayNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodFirstDay_ = new IdentifiedDate(calculationPeriodFirstDayNode);
                    }
                }
                else
                {
                    calculationPeriodFirstDay_ = new IdentifiedDate(calculationPeriodFirstDayNode);
                }
            }
            
        
            XmlNode calculationPeriodEndDayNode = xmlNode.SelectSingleNode("calculationPeriodEndDay");
            
            if (calculationPeriodEndDayNode != null)
            {
                if (calculationPeriodEndDayNode.Attributes["href"] != null || calculationPeriodEndDayNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodEndDayNode.Attributes["id"] != null) 
                    {
                        calculationPeriodEndDayIDRef_ = calculationPeriodEndDayNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(calculationPeriodEndDayNode);
                        IDManager.SetID(calculationPeriodEndDayIDRef_, ob);
                    }
                    else if (calculationPeriodEndDayNode.Attributes["href"] != null)
                    {
                        calculationPeriodEndDayIDRef_ = calculationPeriodEndDayNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodEndDay_ = new IdentifiedDate(calculationPeriodEndDayNode);
                    }
                }
                else
                {
                    calculationPeriodEndDay_ = new IdentifiedDate(calculationPeriodEndDayNode);
                }
            }
            
        
        }
        
    
        #region CalculationPeriodFirstDay_
        private IdentifiedDate calculationPeriodFirstDay_;
        public IdentifiedDate CalculationPeriodFirstDay_
        {
            get
            {
                if (this.calculationPeriodFirstDay_ != null)
                {
                    return this.calculationPeriodFirstDay_; 
                }
                else if (this.calculationPeriodFirstDayIDRef_ != null)
                {
                    calculationPeriodFirstDay_ = IDManager.getID(calculationPeriodFirstDayIDRef_) as IdentifiedDate;
                    return this.calculationPeriodFirstDay_; 
                }
                else
                {
                      return this.calculationPeriodFirstDay_; 
                }
            }
            set
            {
                if (this.calculationPeriodFirstDay_ != value)
                {
                    this.calculationPeriodFirstDay_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodFirstDayIDRef_ { get; set; }
        #region CalculationPeriodEndDay_
        private IdentifiedDate calculationPeriodEndDay_;
        public IdentifiedDate CalculationPeriodEndDay_
        {
            get
            {
                if (this.calculationPeriodEndDay_ != null)
                {
                    return this.calculationPeriodEndDay_; 
                }
                else if (this.calculationPeriodEndDayIDRef_ != null)
                {
                    calculationPeriodEndDay_ = IDManager.getID(calculationPeriodEndDayIDRef_) as IdentifiedDate;
                    return this.calculationPeriodEndDay_; 
                }
                else
                {
                      return this.calculationPeriodEndDay_; 
                }
            }
            set
            {
                if (this.calculationPeriodEndDay_ != value)
                {
                    this.calculationPeriodEndDay_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodEndDayIDRef_ { get; set; }
        
    
        
    
    }
    
}

