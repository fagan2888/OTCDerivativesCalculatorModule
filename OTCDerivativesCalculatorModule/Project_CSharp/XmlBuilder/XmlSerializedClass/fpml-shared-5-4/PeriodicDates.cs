using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PeriodicDates : ISerialized
    {
        public PeriodicDates(XmlNode xmlNode)
        {
            XmlNode calculationStartDateNode = xmlNode.SelectSingleNode("calculationStartDate");
            
            if (calculationStartDateNode != null)
            {
                if (calculationStartDateNode.Attributes["href"] != null || calculationStartDateNode.Attributes["id"] != null) 
                {
                    if (calculationStartDateNode.Attributes["id"] != null) 
                    {
                        calculationStartDateIDRef_ = calculationStartDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(calculationStartDateNode);
                        IDManager.SetID(calculationStartDateIDRef_, ob);
                    }
                    else if (calculationStartDateNode.Attributes["href"] != null)
                    {
                        calculationStartDateIDRef_ = calculationStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationStartDate_ = new AdjustableOrRelativeDate(calculationStartDateNode);
                    }
                }
                else
                {
                    calculationStartDate_ = new AdjustableOrRelativeDate(calculationStartDateNode);
                }
            }
            
        
            XmlNode calculationEndDateNode = xmlNode.SelectSingleNode("calculationEndDate");
            
            if (calculationEndDateNode != null)
            {
                if (calculationEndDateNode.Attributes["href"] != null || calculationEndDateNode.Attributes["id"] != null) 
                {
                    if (calculationEndDateNode.Attributes["id"] != null) 
                    {
                        calculationEndDateIDRef_ = calculationEndDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(calculationEndDateNode);
                        IDManager.SetID(calculationEndDateIDRef_, ob);
                    }
                    else if (calculationEndDateNode.Attributes["href"] != null)
                    {
                        calculationEndDateIDRef_ = calculationEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationEndDate_ = new AdjustableOrRelativeDate(calculationEndDateNode);
                    }
                }
                else
                {
                    calculationEndDate_ = new AdjustableOrRelativeDate(calculationEndDateNode);
                }
            }
            
        
            XmlNode calculationPeriodFrequencyNode = xmlNode.SelectSingleNode("calculationPeriodFrequency");
            
            if (calculationPeriodFrequencyNode != null)
            {
                if (calculationPeriodFrequencyNode.Attributes["href"] != null || calculationPeriodFrequencyNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodFrequencyNode.Attributes["id"] != null) 
                    {
                        calculationPeriodFrequencyIDRef_ = calculationPeriodFrequencyNode.Attributes["id"].Value;
                        CalculationPeriodFrequency ob = new CalculationPeriodFrequency(calculationPeriodFrequencyNode);
                        IDManager.SetID(calculationPeriodFrequencyIDRef_, ob);
                    }
                    else if (calculationPeriodFrequencyNode.Attributes["href"] != null)
                    {
                        calculationPeriodFrequencyIDRef_ = calculationPeriodFrequencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodFrequency_ = new CalculationPeriodFrequency(calculationPeriodFrequencyNode);
                    }
                }
                else
                {
                    calculationPeriodFrequency_ = new CalculationPeriodFrequency(calculationPeriodFrequencyNode);
                }
            }
            
        
            XmlNode calculationPeriodDatesAdjustmentsNode = xmlNode.SelectSingleNode("calculationPeriodDatesAdjustments");
            
            if (calculationPeriodDatesAdjustmentsNode != null)
            {
                if (calculationPeriodDatesAdjustmentsNode.Attributes["href"] != null || calculationPeriodDatesAdjustmentsNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodDatesAdjustmentsNode.Attributes["id"] != null) 
                    {
                        calculationPeriodDatesAdjustmentsIDRef_ = calculationPeriodDatesAdjustmentsNode.Attributes["id"].Value;
                        BusinessDayAdjustments ob = new BusinessDayAdjustments(calculationPeriodDatesAdjustmentsNode);
                        IDManager.SetID(calculationPeriodDatesAdjustmentsIDRef_, ob);
                    }
                    else if (calculationPeriodDatesAdjustmentsNode.Attributes["href"] != null)
                    {
                        calculationPeriodDatesAdjustmentsIDRef_ = calculationPeriodDatesAdjustmentsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodDatesAdjustments_ = new BusinessDayAdjustments(calculationPeriodDatesAdjustmentsNode);
                    }
                }
                else
                {
                    calculationPeriodDatesAdjustments_ = new BusinessDayAdjustments(calculationPeriodDatesAdjustmentsNode);
                }
            }
            
        
        }
        
    
        #region CalculationStartDate_
        private AdjustableOrRelativeDate calculationStartDate_;
        public AdjustableOrRelativeDate CalculationStartDate_
        {
            get
            {
                if (this.calculationStartDate_ != null)
                {
                    return this.calculationStartDate_; 
                }
                else if (this.calculationStartDateIDRef_ != null)
                {
                    calculationStartDate_ = IDManager.getID(calculationStartDateIDRef_) as AdjustableOrRelativeDate;
                    return this.calculationStartDate_; 
                }
                else
                {
                      return this.calculationStartDate_; 
                }
            }
            set
            {
                if (this.calculationStartDate_ != value)
                {
                    this.calculationStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string calculationStartDateIDRef_ { get; set; }
        #region CalculationEndDate_
        private AdjustableOrRelativeDate calculationEndDate_;
        public AdjustableOrRelativeDate CalculationEndDate_
        {
            get
            {
                if (this.calculationEndDate_ != null)
                {
                    return this.calculationEndDate_; 
                }
                else if (this.calculationEndDateIDRef_ != null)
                {
                    calculationEndDate_ = IDManager.getID(calculationEndDateIDRef_) as AdjustableOrRelativeDate;
                    return this.calculationEndDate_; 
                }
                else
                {
                      return this.calculationEndDate_; 
                }
            }
            set
            {
                if (this.calculationEndDate_ != value)
                {
                    this.calculationEndDate_ = value;
                }
            }
        }
        #endregion
        
        public string calculationEndDateIDRef_ { get; set; }
        #region CalculationPeriodFrequency_
        private CalculationPeriodFrequency calculationPeriodFrequency_;
        public CalculationPeriodFrequency CalculationPeriodFrequency_
        {
            get
            {
                if (this.calculationPeriodFrequency_ != null)
                {
                    return this.calculationPeriodFrequency_; 
                }
                else if (this.calculationPeriodFrequencyIDRef_ != null)
                {
                    calculationPeriodFrequency_ = IDManager.getID(calculationPeriodFrequencyIDRef_) as CalculationPeriodFrequency;
                    return this.calculationPeriodFrequency_; 
                }
                else
                {
                      return this.calculationPeriodFrequency_; 
                }
            }
            set
            {
                if (this.calculationPeriodFrequency_ != value)
                {
                    this.calculationPeriodFrequency_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodFrequencyIDRef_ { get; set; }
        #region CalculationPeriodDatesAdjustments_
        private BusinessDayAdjustments calculationPeriodDatesAdjustments_;
        public BusinessDayAdjustments CalculationPeriodDatesAdjustments_
        {
            get
            {
                if (this.calculationPeriodDatesAdjustments_ != null)
                {
                    return this.calculationPeriodDatesAdjustments_; 
                }
                else if (this.calculationPeriodDatesAdjustmentsIDRef_ != null)
                {
                    calculationPeriodDatesAdjustments_ = IDManager.getID(calculationPeriodDatesAdjustmentsIDRef_) as BusinessDayAdjustments;
                    return this.calculationPeriodDatesAdjustments_; 
                }
                else
                {
                      return this.calculationPeriodDatesAdjustments_; 
                }
            }
            set
            {
                if (this.calculationPeriodDatesAdjustments_ != value)
                {
                    this.calculationPeriodDatesAdjustments_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodDatesAdjustmentsIDRef_ { get; set; }
        
    
        
    
    }
    
}

