using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FutureValueAmount : NonNegativeMoney
    {
        public FutureValueAmount(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode calculationPeriodNumberOfDaysNode = xmlNode.SelectSingleNode("calculationPeriodNumberOfDays");
            
            if (calculationPeriodNumberOfDaysNode != null)
            {
                if (calculationPeriodNumberOfDaysNode.Attributes["href"] != null || calculationPeriodNumberOfDaysNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodNumberOfDaysNode.Attributes["id"] != null) 
                    {
                        calculationPeriodNumberOfDaysIDRef_ = calculationPeriodNumberOfDaysNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(calculationPeriodNumberOfDaysNode);
                        IDManager.SetID(calculationPeriodNumberOfDaysIDRef_, ob);
                    }
                    else if (calculationPeriodNumberOfDaysNode.Attributes["href"] != null)
                    {
                        calculationPeriodNumberOfDaysIDRef_ = calculationPeriodNumberOfDaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodNumberOfDays_ = new XsdTypePositiveInteger(calculationPeriodNumberOfDaysNode);
                    }
                }
                else
                {
                    calculationPeriodNumberOfDays_ = new XsdTypePositiveInteger(calculationPeriodNumberOfDaysNode);
                }
            }
            
        
            XmlNode valueDateNode = xmlNode.SelectSingleNode("valueDate");
            
            if (valueDateNode != null)
            {
                if (valueDateNode.Attributes["href"] != null || valueDateNode.Attributes["id"] != null) 
                {
                    if (valueDateNode.Attributes["id"] != null) 
                    {
                        valueDateIDRef_ = valueDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(valueDateNode);
                        IDManager.SetID(valueDateIDRef_, ob);
                    }
                    else if (valueDateNode.Attributes["href"] != null)
                    {
                        valueDateIDRef_ = valueDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valueDate_ = new XsdTypeDate(valueDateNode);
                    }
                }
                else
                {
                    valueDate_ = new XsdTypeDate(valueDateNode);
                }
            }
            
        
        }
        
    
        #region CalculationPeriodNumberOfDays_
        private XsdTypePositiveInteger calculationPeriodNumberOfDays_;
        public XsdTypePositiveInteger CalculationPeriodNumberOfDays_
        {
            get
            {
                if (this.calculationPeriodNumberOfDays_ != null)
                {
                    return this.calculationPeriodNumberOfDays_; 
                }
                else if (this.calculationPeriodNumberOfDaysIDRef_ != null)
                {
                    calculationPeriodNumberOfDays_ = IDManager.getID(calculationPeriodNumberOfDaysIDRef_) as XsdTypePositiveInteger;
                    return this.calculationPeriodNumberOfDays_; 
                }
                else
                {
                      return this.calculationPeriodNumberOfDays_; 
                }
            }
            set
            {
                if (this.calculationPeriodNumberOfDays_ != value)
                {
                    this.calculationPeriodNumberOfDays_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodNumberOfDaysIDRef_ { get; set; }
        #region ValueDate_
        private XsdTypeDate valueDate_;
        public XsdTypeDate ValueDate_
        {
            get
            {
                if (this.valueDate_ != null)
                {
                    return this.valueDate_; 
                }
                else if (this.valueDateIDRef_ != null)
                {
                    valueDate_ = IDManager.getID(valueDateIDRef_) as XsdTypeDate;
                    return this.valueDate_; 
                }
                else
                {
                      return this.valueDate_; 
                }
            }
            set
            {
                if (this.valueDate_ != value)
                {
                    this.valueDate_ = value;
                }
            }
        }
        #endregion
        
        public string valueDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

