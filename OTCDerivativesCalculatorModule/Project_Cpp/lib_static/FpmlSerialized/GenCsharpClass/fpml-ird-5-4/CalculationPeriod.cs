using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CalculationPeriod
    {
        public CalculationPeriod(XmlNode xmlNode)
        {
            XmlNodeList unadjustedStartDateNodeList = xmlNode.SelectNodes("unadjustedStartDate");
            if (unadjustedStartDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in unadjustedStartDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unadjustedStartDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(unadjustedStartDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unadjustedStartDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        unadjustedStartDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList unadjustedEndDateNodeList = xmlNode.SelectNodes("unadjustedEndDate");
            if (unadjustedEndDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in unadjustedEndDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unadjustedEndDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(unadjustedEndDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unadjustedEndDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        unadjustedEndDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList adjustedStartDateNodeList = xmlNode.SelectNodes("adjustedStartDate");
            if (adjustedStartDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustedStartDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedStartDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(adjustedStartDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedStartDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustedStartDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList adjustedEndDateNodeList = xmlNode.SelectNodes("adjustedEndDate");
            if (adjustedEndDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustedEndDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedEndDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(adjustedEndDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedEndDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustedEndDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList calculationPeriodNumberOfDaysNodeList = xmlNode.SelectNodes("calculationPeriodNumberOfDays");
            if (calculationPeriodNumberOfDaysNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodNumberOfDaysNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodNumberOfDaysIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(calculationPeriodNumberOfDaysIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodNumberOfDaysIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodNumberOfDays = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList notionalAmountNodeList = xmlNode.SelectNodes("notionalAmount");
            if (notionalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalAmountIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(notionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalAmount = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList fxLinkedNotionalAmountNodeList = xmlNode.SelectNodes("fxLinkedNotionalAmount");
            if (fxLinkedNotionalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxLinkedNotionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxLinkedNotionalAmountIDRef = item.Attributes["id"].Name;
                        FxLinkedNotionalAmount ob = FxLinkedNotionalAmount();
                        IDManager.SetID(fxLinkedNotionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxLinkedNotionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxLinkedNotionalAmount = new FxLinkedNotionalAmount(item);
                    }
                }
            }
            
        
            XmlNodeList floatingRateDefinitionNodeList = xmlNode.SelectNodes("floatingRateDefinition");
            if (floatingRateDefinitionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in floatingRateDefinitionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floatingRateDefinitionIDRef = item.Attributes["id"].Name;
                        FloatingRateDefinition ob = FloatingRateDefinition();
                        IDManager.SetID(floatingRateDefinitionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floatingRateDefinitionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        floatingRateDefinition = new FloatingRateDefinition(item);
                    }
                }
            }
            
        
            XmlNodeList fixedRateNodeList = xmlNode.SelectNodes("fixedRate");
            if (fixedRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(fixedRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList dayCountYearFractionNodeList = xmlNode.SelectNodes("dayCountYearFraction");
            if (dayCountYearFractionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dayCountYearFractionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dayCountYearFractionIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(dayCountYearFractionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dayCountYearFractionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dayCountYearFraction = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList forecastAmountNodeList = xmlNode.SelectNodes("forecastAmount");
            if (forecastAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in forecastAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        forecastAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(forecastAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        forecastAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        forecastAmount = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList forecastRateNodeList = xmlNode.SelectNodes("forecastRate");
            if (forecastRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in forecastRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        forecastRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(forecastRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        forecastRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        forecastRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region UnadjustedStartDate
        private XsdTypeDate unadjustedStartDate;
        public XsdTypeDate UnadjustedStartDate
        {
            get
            {
                if (this.unadjustedStartDate != null)
                {
                    return this.unadjustedStartDate; 
                }
                else if (this.unadjustedStartDateIDRef != null)
                {
                    unadjustedStartDate = IDManager.getID(unadjustedStartDateIDRef) as XsdTypeDate;
                    return this.unadjustedStartDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unadjustedStartDate != value)
                {
                    this.unadjustedStartDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region UnadjustedEndDate
        private XsdTypeDate unadjustedEndDate;
        public XsdTypeDate UnadjustedEndDate
        {
            get
            {
                if (this.unadjustedEndDate != null)
                {
                    return this.unadjustedEndDate; 
                }
                else if (this.unadjustedEndDateIDRef != null)
                {
                    unadjustedEndDate = IDManager.getID(unadjustedEndDateIDRef) as XsdTypeDate;
                    return this.unadjustedEndDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unadjustedEndDate != value)
                {
                    this.unadjustedEndDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region AdjustedStartDate
        private XsdTypeDate adjustedStartDate;
        public XsdTypeDate AdjustedStartDate
        {
            get
            {
                if (this.adjustedStartDate != null)
                {
                    return this.adjustedStartDate; 
                }
                else if (this.adjustedStartDateIDRef != null)
                {
                    adjustedStartDate = IDManager.getID(adjustedStartDateIDRef) as XsdTypeDate;
                    return this.adjustedStartDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedStartDate != value)
                {
                    this.adjustedStartDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region AdjustedEndDate
        private XsdTypeDate adjustedEndDate;
        public XsdTypeDate AdjustedEndDate
        {
            get
            {
                if (this.adjustedEndDate != null)
                {
                    return this.adjustedEndDate; 
                }
                else if (this.adjustedEndDateIDRef != null)
                {
                    adjustedEndDate = IDManager.getID(adjustedEndDateIDRef) as XsdTypeDate;
                    return this.adjustedEndDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedEndDate != value)
                {
                    this.adjustedEndDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region CalculationPeriodNumberOfDays
        private XsdTypePositiveInteger calculationPeriodNumberOfDays;
        public XsdTypePositiveInteger CalculationPeriodNumberOfDays
        {
            get
            {
                if (this.calculationPeriodNumberOfDays != null)
                {
                    return this.calculationPeriodNumberOfDays; 
                }
                else if (this.calculationPeriodNumberOfDaysIDRef != null)
                {
                    calculationPeriodNumberOfDays = IDManager.getID(calculationPeriodNumberOfDaysIDRef) as XsdTypePositiveInteger;
                    return this.calculationPeriodNumberOfDays; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodNumberOfDays != value)
                {
                    this.calculationPeriodNumberOfDays = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region NotionalAmount
        private XsdTypeDecimal notionalAmount;
        public XsdTypeDecimal NotionalAmount
        {
            get
            {
                if (this.notionalAmount != null)
                {
                    return this.notionalAmount; 
                }
                else if (this.notionalAmountIDRef != null)
                {
                    notionalAmount = IDManager.getID(notionalAmountIDRef) as XsdTypeDecimal;
                    return this.notionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalAmount != value)
                {
                    this.notionalAmount = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region FxLinkedNotionalAmount
        private FxLinkedNotionalAmount fxLinkedNotionalAmount;
        public FxLinkedNotionalAmount FxLinkedNotionalAmount
        {
            get
            {
                if (this.fxLinkedNotionalAmount != null)
                {
                    return this.fxLinkedNotionalAmount; 
                }
                else if (this.fxLinkedNotionalAmountIDRef != null)
                {
                    fxLinkedNotionalAmount = IDManager.getID(fxLinkedNotionalAmountIDRef) as FxLinkedNotionalAmount;
                    return this.fxLinkedNotionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxLinkedNotionalAmount != value)
                {
                    this.fxLinkedNotionalAmount = value;
                }
            }
        }
        #endregion
        
        public string FxLinkedNotionalAmountIDRef { get; set; }
        #region FloatingRateDefinition
        private FloatingRateDefinition floatingRateDefinition;
        public FloatingRateDefinition FloatingRateDefinition
        {
            get
            {
                if (this.floatingRateDefinition != null)
                {
                    return this.floatingRateDefinition; 
                }
                else if (this.floatingRateDefinitionIDRef != null)
                {
                    floatingRateDefinition = IDManager.getID(floatingRateDefinitionIDRef) as FloatingRateDefinition;
                    return this.floatingRateDefinition; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floatingRateDefinition != value)
                {
                    this.floatingRateDefinition = value;
                }
            }
        }
        #endregion
        
        public string FloatingRateDefinitionIDRef { get; set; }
        #region FixedRate
        private XsdTypeDecimal fixedRate;
        public XsdTypeDecimal FixedRate
        {
            get
            {
                if (this.fixedRate != null)
                {
                    return this.fixedRate; 
                }
                else if (this.fixedRateIDRef != null)
                {
                    fixedRate = IDManager.getID(fixedRateIDRef) as XsdTypeDecimal;
                    return this.fixedRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedRate != value)
                {
                    this.fixedRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region DayCountYearFraction
        private XsdTypeDecimal dayCountYearFraction;
        public XsdTypeDecimal DayCountYearFraction
        {
            get
            {
                if (this.dayCountYearFraction != null)
                {
                    return this.dayCountYearFraction; 
                }
                else if (this.dayCountYearFractionIDRef != null)
                {
                    dayCountYearFraction = IDManager.getID(dayCountYearFractionIDRef) as XsdTypeDecimal;
                    return this.dayCountYearFraction; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dayCountYearFraction != value)
                {
                    this.dayCountYearFraction = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region ForecastAmount
        private Money forecastAmount;
        public Money ForecastAmount
        {
            get
            {
                if (this.forecastAmount != null)
                {
                    return this.forecastAmount; 
                }
                else if (this.forecastAmountIDRef != null)
                {
                    forecastAmount = IDManager.getID(forecastAmountIDRef) as Money;
                    return this.forecastAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.forecastAmount != value)
                {
                    this.forecastAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region ForecastRate
        private XsdTypeDecimal forecastRate;
        public XsdTypeDecimal ForecastRate
        {
            get
            {
                if (this.forecastRate != null)
                {
                    return this.forecastRate; 
                }
                else if (this.forecastRateIDRef != null)
                {
                    forecastRate = IDManager.getID(forecastRateIDRef) as XsdTypeDecimal;
                    return this.forecastRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.forecastRate != value)
                {
                    this.forecastRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

