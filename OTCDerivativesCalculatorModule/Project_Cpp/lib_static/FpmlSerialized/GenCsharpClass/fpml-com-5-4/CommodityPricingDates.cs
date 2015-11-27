using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityPricingDates
    {
        public CommodityPricingDates(XmlNode xmlNode)
        {
            XmlNodeList calculationPeriodsReferenceNodeList = xmlNode.SelectNodes("calculationPeriodsReference");
            if (calculationPeriodsReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodsReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodsReferenceIDRef = item.Attributes["id"].Name;
                        CalculationPeriodsReference ob = CalculationPeriodsReference();
                        IDManager.SetID(calculationPeriodsReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodsReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodsReference = new CalculationPeriodsReference(item);
                    }
                }
            }
            
        
            XmlNodeList calculationPeriodsScheduleReferenceNodeList = xmlNode.SelectNodes("calculationPeriodsScheduleReference");
            if (calculationPeriodsScheduleReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodsScheduleReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodsScheduleReferenceIDRef = item.Attributes["id"].Name;
                        CalculationPeriodsScheduleReference ob = CalculationPeriodsScheduleReference();
                        IDManager.SetID(calculationPeriodsScheduleReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodsScheduleReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodsScheduleReference = new CalculationPeriodsScheduleReference(item);
                    }
                }
            }
            
        
            XmlNodeList calculationPeriodsDatesReferenceNodeList = xmlNode.SelectNodes("calculationPeriodsDatesReference");
            if (calculationPeriodsDatesReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodsDatesReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodsDatesReferenceIDRef = item.Attributes["id"].Name;
                        CalculationPeriodsDatesReference ob = CalculationPeriodsDatesReference();
                        IDManager.SetID(calculationPeriodsDatesReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodsDatesReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodsDatesReference = new CalculationPeriodsDatesReference(item);
                    }
                }
            }
            
        
            XmlNodeList lagNodeList = xmlNode.SelectNodes("lag");
            if (lagNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in lagNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        lagIDRef = item.Attributes["id"].Name;
                        Lag ob = Lag();
                        IDManager.SetID(lagIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        lagIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        lag = new Lag(item);
                    }
                }
            }
            
        
            XmlNodeList dayTypeNodeList = xmlNode.SelectNodes("dayType");
            if (dayTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dayTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dayTypeIDRef = item.Attributes["id"].Name;
                        CommodityDayTypeEnum ob = CommodityDayTypeEnum();
                        IDManager.SetID(dayTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dayTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dayType = new CommodityDayTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList dayDistributionNodeList = xmlNode.SelectNodes("dayDistribution");
            if (dayDistributionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dayDistributionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dayDistributionIDRef = item.Attributes["id"].Name;
                        CommodityFrequencyType ob = CommodityFrequencyType();
                        IDManager.SetID(dayDistributionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dayDistributionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dayDistribution = new CommodityFrequencyType(item);
                    }
                }
            }
            
        
            XmlNodeList dayCountNodeList = xmlNode.SelectNodes("dayCount");
            if (dayCountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dayCountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dayCountIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(dayCountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dayCountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dayCount = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList dayOfWeekNodeList = xmlNode.SelectNodes("dayOfWeek");
            
            foreach (XmlNode item in dayOfWeekNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dayOfWeekIDRef = item.Attributes["id"].Name;
                        List<DayOfWeekEnum> ob = new List<DayOfWeekEnum>();
                        ob.Add(new DayOfWeekEnum(item));
                        IDManager.SetID(dayOfWeekIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dayOfWeekIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    dayOfWeek.Add(new DayOfWeekEnum(item));
                    }
                }
            }
            
        
            XmlNodeList dayNumberNodeList = xmlNode.SelectNodes("dayNumber");
            if (dayNumberNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dayNumberNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dayNumberIDRef = item.Attributes["id"].Name;
                        XsdTypeInteger ob = XsdTypeInteger();
                        IDManager.SetID(dayNumberIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dayNumberIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dayNumber = new XsdTypeInteger(item);
                    }
                }
            }
            
        
            XmlNodeList businessCalendarNodeList = xmlNode.SelectNodes("businessCalendar");
            if (businessCalendarNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessCalendarNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessCalendarIDRef = item.Attributes["id"].Name;
                        CommodityBusinessCalendar ob = CommodityBusinessCalendar();
                        IDManager.SetID(businessCalendarIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessCalendarIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessCalendar = new CommodityBusinessCalendar(item);
                    }
                }
            }
            
        
            XmlNodeList calendarSourceNodeList = xmlNode.SelectNodes("calendarSource");
            if (calendarSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calendarSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calendarSourceIDRef = item.Attributes["id"].Name;
                        CalendarSourceEnum ob = CalendarSourceEnum();
                        IDManager.SetID(calendarSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calendarSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calendarSource = new CalendarSourceEnum(item);
                    }
                }
            }
            
        
            XmlNodeList settlementPeriodsNodeList = xmlNode.SelectNodes("settlementPeriods");
            
            foreach (XmlNode item in settlementPeriodsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementPeriodsIDRef = item.Attributes["id"].Name;
                        List<SettlementPeriods> ob = new List<SettlementPeriods>();
                        ob.Add(new SettlementPeriods(item));
                        IDManager.SetID(settlementPeriodsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementPeriodsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    settlementPeriods.Add(new SettlementPeriods(item));
                    }
                }
            }
            
        
            XmlNodeList settlementPeriodsReferenceNodeList = xmlNode.SelectNodes("settlementPeriodsReference");
            
            foreach (XmlNode item in settlementPeriodsReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementPeriodsReferenceIDRef = item.Attributes["id"].Name;
                        List<SettlementPeriodsReference> ob = new List<SettlementPeriodsReference>();
                        ob.Add(new SettlementPeriodsReference(item));
                        IDManager.SetID(settlementPeriodsReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementPeriodsReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    settlementPeriodsReference.Add(new SettlementPeriodsReference(item));
                    }
                }
            }
            
        
            XmlNodeList pricingDatesNodeList = xmlNode.SelectNodes("pricingDates");
            
            foreach (XmlNode item in pricingDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pricingDatesIDRef = item.Attributes["id"].Name;
                        List<AdjustableDates> ob = new List<AdjustableDates>();
                        ob.Add(new AdjustableDates(item));
                        IDManager.SetID(pricingDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pricingDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    pricingDates.Add(new AdjustableDates(item));
                    }
                }
            }
            
        
        }
        
    
        #region CalculationPeriodsReference
        private CalculationPeriodsReference calculationPeriodsReference;
        public CalculationPeriodsReference CalculationPeriodsReference
        {
            get
            {
                if (this.calculationPeriodsReference != null)
                {
                    return this.calculationPeriodsReference; 
                }
                else if (this.calculationPeriodsReferenceIDRef != null)
                {
                    calculationPeriodsReference = IDManager.getID(calculationPeriodsReferenceIDRef) as CalculationPeriodsReference;
                    return this.calculationPeriodsReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodsReference != value)
                {
                    this.calculationPeriodsReference = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodsReferenceIDRef { get; set; }
        #region CalculationPeriodsScheduleReference
        private CalculationPeriodsScheduleReference calculationPeriodsScheduleReference;
        public CalculationPeriodsScheduleReference CalculationPeriodsScheduleReference
        {
            get
            {
                if (this.calculationPeriodsScheduleReference != null)
                {
                    return this.calculationPeriodsScheduleReference; 
                }
                else if (this.calculationPeriodsScheduleReferenceIDRef != null)
                {
                    calculationPeriodsScheduleReference = IDManager.getID(calculationPeriodsScheduleReferenceIDRef) as CalculationPeriodsScheduleReference;
                    return this.calculationPeriodsScheduleReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodsScheduleReference != value)
                {
                    this.calculationPeriodsScheduleReference = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodsScheduleReferenceIDRef { get; set; }
        #region CalculationPeriodsDatesReference
        private CalculationPeriodsDatesReference calculationPeriodsDatesReference;
        public CalculationPeriodsDatesReference CalculationPeriodsDatesReference
        {
            get
            {
                if (this.calculationPeriodsDatesReference != null)
                {
                    return this.calculationPeriodsDatesReference; 
                }
                else if (this.calculationPeriodsDatesReferenceIDRef != null)
                {
                    calculationPeriodsDatesReference = IDManager.getID(calculationPeriodsDatesReferenceIDRef) as CalculationPeriodsDatesReference;
                    return this.calculationPeriodsDatesReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodsDatesReference != value)
                {
                    this.calculationPeriodsDatesReference = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodsDatesReferenceIDRef { get; set; }
        #region Lag
        private Lag lag;
        public Lag Lag
        {
            get
            {
                if (this.lag != null)
                {
                    return this.lag; 
                }
                else if (this.lagIDRef != null)
                {
                    lag = IDManager.getID(lagIDRef) as Lag;
                    return this.lag; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.lag != value)
                {
                    this.lag = value;
                }
            }
        }
        #endregion
        
        public string LagIDRef { get; set; }
        #region DayType
        private CommodityDayTypeEnum dayType;
        public CommodityDayTypeEnum DayType
        {
            get
            {
                if (this.dayType != null)
                {
                    return this.dayType; 
                }
                else if (this.dayTypeIDRef != null)
                {
                    dayType = IDManager.getID(dayTypeIDRef) as CommodityDayTypeEnum;
                    return this.dayType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dayType != value)
                {
                    this.dayType = value;
                }
            }
        }
        #endregion
        
        public string CommodityDayTypeEnumIDRef { get; set; }
        #region DayDistribution
        private CommodityFrequencyType dayDistribution;
        public CommodityFrequencyType DayDistribution
        {
            get
            {
                if (this.dayDistribution != null)
                {
                    return this.dayDistribution; 
                }
                else if (this.dayDistributionIDRef != null)
                {
                    dayDistribution = IDManager.getID(dayDistributionIDRef) as CommodityFrequencyType;
                    return this.dayDistribution; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dayDistribution != value)
                {
                    this.dayDistribution = value;
                }
            }
        }
        #endregion
        
        public string CommodityFrequencyTypeIDRef { get; set; }
        #region DayCount
        private XsdTypePositiveInteger dayCount;
        public XsdTypePositiveInteger DayCount
        {
            get
            {
                if (this.dayCount != null)
                {
                    return this.dayCount; 
                }
                else if (this.dayCountIDRef != null)
                {
                    dayCount = IDManager.getID(dayCountIDRef) as XsdTypePositiveInteger;
                    return this.dayCount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dayCount != value)
                {
                    this.dayCount = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region DayOfWeek
        private List<DayOfWeekEnum> dayOfWeek;
        public List<DayOfWeekEnum> DayOfWeek
        {
            get
            {
                if (this.dayOfWeek != null)
                {
                    return this.dayOfWeek; 
                }
                else if (this.dayOfWeekIDRef != null)
                {
                    dayOfWeek = IDManager.getID(dayOfWeekIDRef) as List<DayOfWeekEnum>;
                    return this.dayOfWeek; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dayOfWeek != value)
                {
                    this.dayOfWeek = value;
                }
            }
        }
        #endregion
        
        public string DayOfWeekEnumIDRef { get; set; }
        #region DayNumber
        private XsdTypeInteger dayNumber;
        public XsdTypeInteger DayNumber
        {
            get
            {
                if (this.dayNumber != null)
                {
                    return this.dayNumber; 
                }
                else if (this.dayNumberIDRef != null)
                {
                    dayNumber = IDManager.getID(dayNumberIDRef) as XsdTypeInteger;
                    return this.dayNumber; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dayNumber != value)
                {
                    this.dayNumber = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeIntegerIDRef { get; set; }
        #region BusinessCalendar
        private CommodityBusinessCalendar businessCalendar;
        public CommodityBusinessCalendar BusinessCalendar
        {
            get
            {
                if (this.businessCalendar != null)
                {
                    return this.businessCalendar; 
                }
                else if (this.businessCalendarIDRef != null)
                {
                    businessCalendar = IDManager.getID(businessCalendarIDRef) as CommodityBusinessCalendar;
                    return this.businessCalendar; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessCalendar != value)
                {
                    this.businessCalendar = value;
                }
            }
        }
        #endregion
        
        public string CommodityBusinessCalendarIDRef { get; set; }
        #region CalendarSource
        private CalendarSourceEnum calendarSource;
        public CalendarSourceEnum CalendarSource
        {
            get
            {
                if (this.calendarSource != null)
                {
                    return this.calendarSource; 
                }
                else if (this.calendarSourceIDRef != null)
                {
                    calendarSource = IDManager.getID(calendarSourceIDRef) as CalendarSourceEnum;
                    return this.calendarSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calendarSource != value)
                {
                    this.calendarSource = value;
                }
            }
        }
        #endregion
        
        public string CalendarSourceEnumIDRef { get; set; }
        #region SettlementPeriods
        private List<SettlementPeriods> settlementPeriods;
        public List<SettlementPeriods> SettlementPeriods
        {
            get
            {
                if (this.settlementPeriods != null)
                {
                    return this.settlementPeriods; 
                }
                else if (this.settlementPeriodsIDRef != null)
                {
                    settlementPeriods = IDManager.getID(settlementPeriodsIDRef) as List<SettlementPeriods>;
                    return this.settlementPeriods; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementPeriods != value)
                {
                    this.settlementPeriods = value;
                }
            }
        }
        #endregion
        
        public string SettlementPeriodsIDRef { get; set; }
        #region SettlementPeriodsReference
        private List<SettlementPeriodsReference> settlementPeriodsReference;
        public List<SettlementPeriodsReference> SettlementPeriodsReference
        {
            get
            {
                if (this.settlementPeriodsReference != null)
                {
                    return this.settlementPeriodsReference; 
                }
                else if (this.settlementPeriodsReferenceIDRef != null)
                {
                    settlementPeriodsReference = IDManager.getID(settlementPeriodsReferenceIDRef) as List<SettlementPeriodsReference>;
                    return this.settlementPeriodsReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementPeriodsReference != value)
                {
                    this.settlementPeriodsReference = value;
                }
            }
        }
        #endregion
        
        public string SettlementPeriodsReferenceIDRef { get; set; }
        #region PricingDates
        private List<AdjustableDates> pricingDates;
        public List<AdjustableDates> PricingDates
        {
            get
            {
                if (this.pricingDates != null)
                {
                    return this.pricingDates; 
                }
                else if (this.pricingDatesIDRef != null)
                {
                    pricingDates = IDManager.getID(pricingDatesIDRef) as List<AdjustableDates>;
                    return this.pricingDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pricingDates != value)
                {
                    this.pricingDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDatesIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        public string choiceStr_3;
        
    
        
    
    }
    
}

