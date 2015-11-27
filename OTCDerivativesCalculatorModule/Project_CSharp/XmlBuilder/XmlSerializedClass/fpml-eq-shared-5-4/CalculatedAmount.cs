using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CalculatedAmount : ISerialized
    {
        public CalculatedAmount(XmlNode xmlNode)
        {
            XmlNode calculationDatesNode = xmlNode.SelectSingleNode("calculationDates");
            
            if (calculationDatesNode != null)
            {
                if (calculationDatesNode.Attributes["href"] != null || calculationDatesNode.Attributes["id"] != null) 
                {
                    if (calculationDatesNode.Attributes["id"] != null) 
                    {
                        calculationDatesIDRef_ = calculationDatesNode.Attributes["id"].Value;
                        AdjustableRelativeOrPeriodicDates ob = new AdjustableRelativeOrPeriodicDates(calculationDatesNode);
                        IDManager.SetID(calculationDatesIDRef_, ob);
                    }
                    else if (calculationDatesNode.Attributes["href"] != null)
                    {
                        calculationDatesIDRef_ = calculationDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationDates_ = new AdjustableRelativeOrPeriodicDates(calculationDatesNode);
                    }
                }
                else
                {
                    calculationDates_ = new AdjustableRelativeOrPeriodicDates(calculationDatesNode);
                }
            }
            
        
            XmlNode observationStartDateNode = xmlNode.SelectSingleNode("observationStartDate");
            
            if (observationStartDateNode != null)
            {
                if (observationStartDateNode.Attributes["href"] != null || observationStartDateNode.Attributes["id"] != null) 
                {
                    if (observationStartDateNode.Attributes["id"] != null) 
                    {
                        observationStartDateIDRef_ = observationStartDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(observationStartDateNode);
                        IDManager.SetID(observationStartDateIDRef_, ob);
                    }
                    else if (observationStartDateNode.Attributes["href"] != null)
                    {
                        observationStartDateIDRef_ = observationStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        observationStartDate_ = new AdjustableOrRelativeDate(observationStartDateNode);
                    }
                }
                else
                {
                    observationStartDate_ = new AdjustableOrRelativeDate(observationStartDateNode);
                }
            }
            
        
            XmlNode optionsExchangeDividendsNode = xmlNode.SelectSingleNode("optionsExchangeDividends");
            
            if (optionsExchangeDividendsNode != null)
            {
                if (optionsExchangeDividendsNode.Attributes["href"] != null || optionsExchangeDividendsNode.Attributes["id"] != null) 
                {
                    if (optionsExchangeDividendsNode.Attributes["id"] != null) 
                    {
                        optionsExchangeDividendsIDRef_ = optionsExchangeDividendsNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(optionsExchangeDividendsNode);
                        IDManager.SetID(optionsExchangeDividendsIDRef_, ob);
                    }
                    else if (optionsExchangeDividendsNode.Attributes["href"] != null)
                    {
                        optionsExchangeDividendsIDRef_ = optionsExchangeDividendsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionsExchangeDividends_ = new XsdTypeBoolean(optionsExchangeDividendsNode);
                    }
                }
                else
                {
                    optionsExchangeDividends_ = new XsdTypeBoolean(optionsExchangeDividendsNode);
                }
            }
            
        
            XmlNode additionalDividendsNode = xmlNode.SelectSingleNode("additionalDividends");
            
            if (additionalDividendsNode != null)
            {
                if (additionalDividendsNode.Attributes["href"] != null || additionalDividendsNode.Attributes["id"] != null) 
                {
                    if (additionalDividendsNode.Attributes["id"] != null) 
                    {
                        additionalDividendsIDRef_ = additionalDividendsNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(additionalDividendsNode);
                        IDManager.SetID(additionalDividendsIDRef_, ob);
                    }
                    else if (additionalDividendsNode.Attributes["href"] != null)
                    {
                        additionalDividendsIDRef_ = additionalDividendsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        additionalDividends_ = new XsdTypeBoolean(additionalDividendsNode);
                    }
                }
                else
                {
                    additionalDividends_ = new XsdTypeBoolean(additionalDividendsNode);
                }
            }
            
        
            XmlNode allDividendsNode = xmlNode.SelectSingleNode("allDividends");
            
            if (allDividendsNode != null)
            {
                if (allDividendsNode.Attributes["href"] != null || allDividendsNode.Attributes["id"] != null) 
                {
                    if (allDividendsNode.Attributes["id"] != null) 
                    {
                        allDividendsIDRef_ = allDividendsNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(allDividendsNode);
                        IDManager.SetID(allDividendsIDRef_, ob);
                    }
                    else if (allDividendsNode.Attributes["href"] != null)
                    {
                        allDividendsIDRef_ = allDividendsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        allDividends_ = new XsdTypeBoolean(allDividendsNode);
                    }
                }
                else
                {
                    allDividends_ = new XsdTypeBoolean(allDividendsNode);
                }
            }
            
        
        }
        
    
        #region CalculationDates_
        private AdjustableRelativeOrPeriodicDates calculationDates_;
        public AdjustableRelativeOrPeriodicDates CalculationDates_
        {
            get
            {
                if (this.calculationDates_ != null)
                {
                    return this.calculationDates_; 
                }
                else if (this.calculationDatesIDRef_ != null)
                {
                    calculationDates_ = IDManager.getID(calculationDatesIDRef_) as AdjustableRelativeOrPeriodicDates;
                    return this.calculationDates_; 
                }
                else
                {
                      return this.calculationDates_; 
                }
            }
            set
            {
                if (this.calculationDates_ != value)
                {
                    this.calculationDates_ = value;
                }
            }
        }
        #endregion
        
        public string calculationDatesIDRef_ { get; set; }
        #region ObservationStartDate_
        private AdjustableOrRelativeDate observationStartDate_;
        public AdjustableOrRelativeDate ObservationStartDate_
        {
            get
            {
                if (this.observationStartDate_ != null)
                {
                    return this.observationStartDate_; 
                }
                else if (this.observationStartDateIDRef_ != null)
                {
                    observationStartDate_ = IDManager.getID(observationStartDateIDRef_) as AdjustableOrRelativeDate;
                    return this.observationStartDate_; 
                }
                else
                {
                      return this.observationStartDate_; 
                }
            }
            set
            {
                if (this.observationStartDate_ != value)
                {
                    this.observationStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string observationStartDateIDRef_ { get; set; }
        #region OptionsExchangeDividends_
        private XsdTypeBoolean optionsExchangeDividends_;
        public XsdTypeBoolean OptionsExchangeDividends_
        {
            get
            {
                if (this.optionsExchangeDividends_ != null)
                {
                    return this.optionsExchangeDividends_; 
                }
                else if (this.optionsExchangeDividendsIDRef_ != null)
                {
                    optionsExchangeDividends_ = IDManager.getID(optionsExchangeDividendsIDRef_) as XsdTypeBoolean;
                    return this.optionsExchangeDividends_; 
                }
                else
                {
                      return this.optionsExchangeDividends_; 
                }
            }
            set
            {
                if (this.optionsExchangeDividends_ != value)
                {
                    this.optionsExchangeDividends_ = value;
                }
            }
        }
        #endregion
        
        public string optionsExchangeDividendsIDRef_ { get; set; }
        #region AdditionalDividends_
        private XsdTypeBoolean additionalDividends_;
        public XsdTypeBoolean AdditionalDividends_
        {
            get
            {
                if (this.additionalDividends_ != null)
                {
                    return this.additionalDividends_; 
                }
                else if (this.additionalDividendsIDRef_ != null)
                {
                    additionalDividends_ = IDManager.getID(additionalDividendsIDRef_) as XsdTypeBoolean;
                    return this.additionalDividends_; 
                }
                else
                {
                      return this.additionalDividends_; 
                }
            }
            set
            {
                if (this.additionalDividends_ != value)
                {
                    this.additionalDividends_ = value;
                }
            }
        }
        #endregion
        
        public string additionalDividendsIDRef_ { get; set; }
        #region AllDividends_
        private XsdTypeBoolean allDividends_;
        public XsdTypeBoolean AllDividends_
        {
            get
            {
                if (this.allDividends_ != null)
                {
                    return this.allDividends_; 
                }
                else if (this.allDividendsIDRef_ != null)
                {
                    allDividends_ = IDManager.getID(allDividendsIDRef_) as XsdTypeBoolean;
                    return this.allDividends_; 
                }
                else
                {
                      return this.allDividends_; 
                }
            }
            set
            {
                if (this.allDividends_ != value)
                {
                    this.allDividends_ = value;
                }
            }
        }
        #endregion
        
        public string allDividendsIDRef_ { get; set; }
        
    
        
    
    }
    
}

