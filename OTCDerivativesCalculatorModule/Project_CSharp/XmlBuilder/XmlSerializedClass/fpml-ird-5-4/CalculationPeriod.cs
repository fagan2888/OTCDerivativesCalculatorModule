using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CalculationPeriod : ISerialized
    {
        public CalculationPeriod(XmlNode xmlNode)
        {
            XmlNode unadjustedStartDateNode = xmlNode.SelectSingleNode("unadjustedStartDate");
            
            if (unadjustedStartDateNode != null)
            {
                if (unadjustedStartDateNode.Attributes["href"] != null || unadjustedStartDateNode.Attributes["id"] != null) 
                {
                    if (unadjustedStartDateNode.Attributes["id"] != null) 
                    {
                        unadjustedStartDateIDRef_ = unadjustedStartDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(unadjustedStartDateNode);
                        IDManager.SetID(unadjustedStartDateIDRef_, ob);
                    }
                    else if (unadjustedStartDateNode.Attributes["href"] != null)
                    {
                        unadjustedStartDateIDRef_ = unadjustedStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unadjustedStartDate_ = new XsdTypeDate(unadjustedStartDateNode);
                    }
                }
                else
                {
                    unadjustedStartDate_ = new XsdTypeDate(unadjustedStartDateNode);
                }
            }
            
        
            XmlNode unadjustedEndDateNode = xmlNode.SelectSingleNode("unadjustedEndDate");
            
            if (unadjustedEndDateNode != null)
            {
                if (unadjustedEndDateNode.Attributes["href"] != null || unadjustedEndDateNode.Attributes["id"] != null) 
                {
                    if (unadjustedEndDateNode.Attributes["id"] != null) 
                    {
                        unadjustedEndDateIDRef_ = unadjustedEndDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(unadjustedEndDateNode);
                        IDManager.SetID(unadjustedEndDateIDRef_, ob);
                    }
                    else if (unadjustedEndDateNode.Attributes["href"] != null)
                    {
                        unadjustedEndDateIDRef_ = unadjustedEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unadjustedEndDate_ = new XsdTypeDate(unadjustedEndDateNode);
                    }
                }
                else
                {
                    unadjustedEndDate_ = new XsdTypeDate(unadjustedEndDateNode);
                }
            }
            
        
            XmlNode adjustedStartDateNode = xmlNode.SelectSingleNode("adjustedStartDate");
            
            if (adjustedStartDateNode != null)
            {
                if (adjustedStartDateNode.Attributes["href"] != null || adjustedStartDateNode.Attributes["id"] != null) 
                {
                    if (adjustedStartDateNode.Attributes["id"] != null) 
                    {
                        adjustedStartDateIDRef_ = adjustedStartDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustedStartDateNode);
                        IDManager.SetID(adjustedStartDateIDRef_, ob);
                    }
                    else if (adjustedStartDateNode.Attributes["href"] != null)
                    {
                        adjustedStartDateIDRef_ = adjustedStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedStartDate_ = new XsdTypeDate(adjustedStartDateNode);
                    }
                }
                else
                {
                    adjustedStartDate_ = new XsdTypeDate(adjustedStartDateNode);
                }
            }
            
        
            XmlNode adjustedEndDateNode = xmlNode.SelectSingleNode("adjustedEndDate");
            
            if (adjustedEndDateNode != null)
            {
                if (adjustedEndDateNode.Attributes["href"] != null || adjustedEndDateNode.Attributes["id"] != null) 
                {
                    if (adjustedEndDateNode.Attributes["id"] != null) 
                    {
                        adjustedEndDateIDRef_ = adjustedEndDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustedEndDateNode);
                        IDManager.SetID(adjustedEndDateIDRef_, ob);
                    }
                    else if (adjustedEndDateNode.Attributes["href"] != null)
                    {
                        adjustedEndDateIDRef_ = adjustedEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedEndDate_ = new XsdTypeDate(adjustedEndDateNode);
                    }
                }
                else
                {
                    adjustedEndDate_ = new XsdTypeDate(adjustedEndDateNode);
                }
            }
            
        
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
            
        
            XmlNode notionalAmountNode = xmlNode.SelectSingleNode("notionalAmount");
            
            if (notionalAmountNode != null)
            {
                if (notionalAmountNode.Attributes["href"] != null || notionalAmountNode.Attributes["id"] != null) 
                {
                    if (notionalAmountNode.Attributes["id"] != null) 
                    {
                        notionalAmountIDRef_ = notionalAmountNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(notionalAmountNode);
                        IDManager.SetID(notionalAmountIDRef_, ob);
                    }
                    else if (notionalAmountNode.Attributes["href"] != null)
                    {
                        notionalAmountIDRef_ = notionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalAmount_ = new XsdTypeDecimal(notionalAmountNode);
                    }
                }
                else
                {
                    notionalAmount_ = new XsdTypeDecimal(notionalAmountNode);
                }
            }
            
        
            XmlNode fxLinkedNotionalAmountNode = xmlNode.SelectSingleNode("fxLinkedNotionalAmount");
            
            if (fxLinkedNotionalAmountNode != null)
            {
                if (fxLinkedNotionalAmountNode.Attributes["href"] != null || fxLinkedNotionalAmountNode.Attributes["id"] != null) 
                {
                    if (fxLinkedNotionalAmountNode.Attributes["id"] != null) 
                    {
                        fxLinkedNotionalAmountIDRef_ = fxLinkedNotionalAmountNode.Attributes["id"].Value;
                        FxLinkedNotionalAmount ob = new FxLinkedNotionalAmount(fxLinkedNotionalAmountNode);
                        IDManager.SetID(fxLinkedNotionalAmountIDRef_, ob);
                    }
                    else if (fxLinkedNotionalAmountNode.Attributes["href"] != null)
                    {
                        fxLinkedNotionalAmountIDRef_ = fxLinkedNotionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxLinkedNotionalAmount_ = new FxLinkedNotionalAmount(fxLinkedNotionalAmountNode);
                    }
                }
                else
                {
                    fxLinkedNotionalAmount_ = new FxLinkedNotionalAmount(fxLinkedNotionalAmountNode);
                }
            }
            
        
            XmlNode floatingRateDefinitionNode = xmlNode.SelectSingleNode("floatingRateDefinition");
            
            if (floatingRateDefinitionNode != null)
            {
                if (floatingRateDefinitionNode.Attributes["href"] != null || floatingRateDefinitionNode.Attributes["id"] != null) 
                {
                    if (floatingRateDefinitionNode.Attributes["id"] != null) 
                    {
                        floatingRateDefinitionIDRef_ = floatingRateDefinitionNode.Attributes["id"].Value;
                        FloatingRateDefinition ob = new FloatingRateDefinition(floatingRateDefinitionNode);
                        IDManager.SetID(floatingRateDefinitionIDRef_, ob);
                    }
                    else if (floatingRateDefinitionNode.Attributes["href"] != null)
                    {
                        floatingRateDefinitionIDRef_ = floatingRateDefinitionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floatingRateDefinition_ = new FloatingRateDefinition(floatingRateDefinitionNode);
                    }
                }
                else
                {
                    floatingRateDefinition_ = new FloatingRateDefinition(floatingRateDefinitionNode);
                }
            }
            
        
            XmlNode fixedRateNode = xmlNode.SelectSingleNode("fixedRate");
            
            if (fixedRateNode != null)
            {
                if (fixedRateNode.Attributes["href"] != null || fixedRateNode.Attributes["id"] != null) 
                {
                    if (fixedRateNode.Attributes["id"] != null) 
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(fixedRateNode);
                        IDManager.SetID(fixedRateIDRef_, ob);
                    }
                    else if (fixedRateNode.Attributes["href"] != null)
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedRate_ = new XsdTypeDecimal(fixedRateNode);
                    }
                }
                else
                {
                    fixedRate_ = new XsdTypeDecimal(fixedRateNode);
                }
            }
            
        
            XmlNode dayCountYearFractionNode = xmlNode.SelectSingleNode("dayCountYearFraction");
            
            if (dayCountYearFractionNode != null)
            {
                if (dayCountYearFractionNode.Attributes["href"] != null || dayCountYearFractionNode.Attributes["id"] != null) 
                {
                    if (dayCountYearFractionNode.Attributes["id"] != null) 
                    {
                        dayCountYearFractionIDRef_ = dayCountYearFractionNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(dayCountYearFractionNode);
                        IDManager.SetID(dayCountYearFractionIDRef_, ob);
                    }
                    else if (dayCountYearFractionNode.Attributes["href"] != null)
                    {
                        dayCountYearFractionIDRef_ = dayCountYearFractionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayCountYearFraction_ = new XsdTypeDecimal(dayCountYearFractionNode);
                    }
                }
                else
                {
                    dayCountYearFraction_ = new XsdTypeDecimal(dayCountYearFractionNode);
                }
            }
            
        
            XmlNode forecastAmountNode = xmlNode.SelectSingleNode("forecastAmount");
            
            if (forecastAmountNode != null)
            {
                if (forecastAmountNode.Attributes["href"] != null || forecastAmountNode.Attributes["id"] != null) 
                {
                    if (forecastAmountNode.Attributes["id"] != null) 
                    {
                        forecastAmountIDRef_ = forecastAmountNode.Attributes["id"].Value;
                        Money ob = new Money(forecastAmountNode);
                        IDManager.SetID(forecastAmountIDRef_, ob);
                    }
                    else if (forecastAmountNode.Attributes["href"] != null)
                    {
                        forecastAmountIDRef_ = forecastAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        forecastAmount_ = new Money(forecastAmountNode);
                    }
                }
                else
                {
                    forecastAmount_ = new Money(forecastAmountNode);
                }
            }
            
        
            XmlNode forecastRateNode = xmlNode.SelectSingleNode("forecastRate");
            
            if (forecastRateNode != null)
            {
                if (forecastRateNode.Attributes["href"] != null || forecastRateNode.Attributes["id"] != null) 
                {
                    if (forecastRateNode.Attributes["id"] != null) 
                    {
                        forecastRateIDRef_ = forecastRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(forecastRateNode);
                        IDManager.SetID(forecastRateIDRef_, ob);
                    }
                    else if (forecastRateNode.Attributes["href"] != null)
                    {
                        forecastRateIDRef_ = forecastRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        forecastRate_ = new XsdTypeDecimal(forecastRateNode);
                    }
                }
                else
                {
                    forecastRate_ = new XsdTypeDecimal(forecastRateNode);
                }
            }
            
        
        }
        
    
        #region UnadjustedStartDate_
        private XsdTypeDate unadjustedStartDate_;
        public XsdTypeDate UnadjustedStartDate_
        {
            get
            {
                if (this.unadjustedStartDate_ != null)
                {
                    return this.unadjustedStartDate_; 
                }
                else if (this.unadjustedStartDateIDRef_ != null)
                {
                    unadjustedStartDate_ = IDManager.getID(unadjustedStartDateIDRef_) as XsdTypeDate;
                    return this.unadjustedStartDate_; 
                }
                else
                {
                      return this.unadjustedStartDate_; 
                }
            }
            set
            {
                if (this.unadjustedStartDate_ != value)
                {
                    this.unadjustedStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string unadjustedStartDateIDRef_ { get; set; }
        #region UnadjustedEndDate_
        private XsdTypeDate unadjustedEndDate_;
        public XsdTypeDate UnadjustedEndDate_
        {
            get
            {
                if (this.unadjustedEndDate_ != null)
                {
                    return this.unadjustedEndDate_; 
                }
                else if (this.unadjustedEndDateIDRef_ != null)
                {
                    unadjustedEndDate_ = IDManager.getID(unadjustedEndDateIDRef_) as XsdTypeDate;
                    return this.unadjustedEndDate_; 
                }
                else
                {
                      return this.unadjustedEndDate_; 
                }
            }
            set
            {
                if (this.unadjustedEndDate_ != value)
                {
                    this.unadjustedEndDate_ = value;
                }
            }
        }
        #endregion
        
        public string unadjustedEndDateIDRef_ { get; set; }
        #region AdjustedStartDate_
        private XsdTypeDate adjustedStartDate_;
        public XsdTypeDate AdjustedStartDate_
        {
            get
            {
                if (this.adjustedStartDate_ != null)
                {
                    return this.adjustedStartDate_; 
                }
                else if (this.adjustedStartDateIDRef_ != null)
                {
                    adjustedStartDate_ = IDManager.getID(adjustedStartDateIDRef_) as XsdTypeDate;
                    return this.adjustedStartDate_; 
                }
                else
                {
                      return this.adjustedStartDate_; 
                }
            }
            set
            {
                if (this.adjustedStartDate_ != value)
                {
                    this.adjustedStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedStartDateIDRef_ { get; set; }
        #region AdjustedEndDate_
        private XsdTypeDate adjustedEndDate_;
        public XsdTypeDate AdjustedEndDate_
        {
            get
            {
                if (this.adjustedEndDate_ != null)
                {
                    return this.adjustedEndDate_; 
                }
                else if (this.adjustedEndDateIDRef_ != null)
                {
                    adjustedEndDate_ = IDManager.getID(adjustedEndDateIDRef_) as XsdTypeDate;
                    return this.adjustedEndDate_; 
                }
                else
                {
                      return this.adjustedEndDate_; 
                }
            }
            set
            {
                if (this.adjustedEndDate_ != value)
                {
                    this.adjustedEndDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedEndDateIDRef_ { get; set; }
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
        #region NotionalAmount_
        private XsdTypeDecimal notionalAmount_;
        public XsdTypeDecimal NotionalAmount_
        {
            get
            {
                if (this.notionalAmount_ != null)
                {
                    return this.notionalAmount_; 
                }
                else if (this.notionalAmountIDRef_ != null)
                {
                    notionalAmount_ = IDManager.getID(notionalAmountIDRef_) as XsdTypeDecimal;
                    return this.notionalAmount_; 
                }
                else
                {
                      return this.notionalAmount_; 
                }
            }
            set
            {
                if (this.notionalAmount_ != value)
                {
                    this.notionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string notionalAmountIDRef_ { get; set; }
        #region FxLinkedNotionalAmount_
        private FxLinkedNotionalAmount fxLinkedNotionalAmount_;
        public FxLinkedNotionalAmount FxLinkedNotionalAmount_
        {
            get
            {
                if (this.fxLinkedNotionalAmount_ != null)
                {
                    return this.fxLinkedNotionalAmount_; 
                }
                else if (this.fxLinkedNotionalAmountIDRef_ != null)
                {
                    fxLinkedNotionalAmount_ = IDManager.getID(fxLinkedNotionalAmountIDRef_) as FxLinkedNotionalAmount;
                    return this.fxLinkedNotionalAmount_; 
                }
                else
                {
                      return this.fxLinkedNotionalAmount_; 
                }
            }
            set
            {
                if (this.fxLinkedNotionalAmount_ != value)
                {
                    this.fxLinkedNotionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string fxLinkedNotionalAmountIDRef_ { get; set; }
        #region FloatingRateDefinition_
        private FloatingRateDefinition floatingRateDefinition_;
        public FloatingRateDefinition FloatingRateDefinition_
        {
            get
            {
                if (this.floatingRateDefinition_ != null)
                {
                    return this.floatingRateDefinition_; 
                }
                else if (this.floatingRateDefinitionIDRef_ != null)
                {
                    floatingRateDefinition_ = IDManager.getID(floatingRateDefinitionIDRef_) as FloatingRateDefinition;
                    return this.floatingRateDefinition_; 
                }
                else
                {
                      return this.floatingRateDefinition_; 
                }
            }
            set
            {
                if (this.floatingRateDefinition_ != value)
                {
                    this.floatingRateDefinition_ = value;
                }
            }
        }
        #endregion
        
        public string floatingRateDefinitionIDRef_ { get; set; }
        #region FixedRate_
        private XsdTypeDecimal fixedRate_;
        public XsdTypeDecimal FixedRate_
        {
            get
            {
                if (this.fixedRate_ != null)
                {
                    return this.fixedRate_; 
                }
                else if (this.fixedRateIDRef_ != null)
                {
                    fixedRate_ = IDManager.getID(fixedRateIDRef_) as XsdTypeDecimal;
                    return this.fixedRate_; 
                }
                else
                {
                      return this.fixedRate_; 
                }
            }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                }
            }
        }
        #endregion
        
        public string fixedRateIDRef_ { get; set; }
        #region DayCountYearFraction_
        private XsdTypeDecimal dayCountYearFraction_;
        public XsdTypeDecimal DayCountYearFraction_
        {
            get
            {
                if (this.dayCountYearFraction_ != null)
                {
                    return this.dayCountYearFraction_; 
                }
                else if (this.dayCountYearFractionIDRef_ != null)
                {
                    dayCountYearFraction_ = IDManager.getID(dayCountYearFractionIDRef_) as XsdTypeDecimal;
                    return this.dayCountYearFraction_; 
                }
                else
                {
                      return this.dayCountYearFraction_; 
                }
            }
            set
            {
                if (this.dayCountYearFraction_ != value)
                {
                    this.dayCountYearFraction_ = value;
                }
            }
        }
        #endregion
        
        public string dayCountYearFractionIDRef_ { get; set; }
        #region ForecastAmount_
        private Money forecastAmount_;
        public Money ForecastAmount_
        {
            get
            {
                if (this.forecastAmount_ != null)
                {
                    return this.forecastAmount_; 
                }
                else if (this.forecastAmountIDRef_ != null)
                {
                    forecastAmount_ = IDManager.getID(forecastAmountIDRef_) as Money;
                    return this.forecastAmount_; 
                }
                else
                {
                      return this.forecastAmount_; 
                }
            }
            set
            {
                if (this.forecastAmount_ != value)
                {
                    this.forecastAmount_ = value;
                }
            }
        }
        #endregion
        
        public string forecastAmountIDRef_ { get; set; }
        #region ForecastRate_
        private XsdTypeDecimal forecastRate_;
        public XsdTypeDecimal ForecastRate_
        {
            get
            {
                if (this.forecastRate_ != null)
                {
                    return this.forecastRate_; 
                }
                else if (this.forecastRateIDRef_ != null)
                {
                    forecastRate_ = IDManager.getID(forecastRateIDRef_) as XsdTypeDecimal;
                    return this.forecastRate_; 
                }
                else
                {
                      return this.forecastRate_; 
                }
            }
            set
            {
                if (this.forecastRate_ != value)
                {
                    this.forecastRate_ = value;
                }
            }
        }
        #endregion
        
        public string forecastRateIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

