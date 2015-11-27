using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityFx
    {
        public CommodityFx(XmlNode xmlNode)
        {
            XmlNodeList primaryRateSourceNodeList = xmlNode.SelectNodes("primaryRateSource");
            if (primaryRateSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in primaryRateSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        primaryRateSourceIDRef = item.Attributes["id"].Name;
                        InformationSource ob = InformationSource();
                        IDManager.SetID(primaryRateSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        primaryRateSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        primaryRateSource = new InformationSource(item);
                    }
                }
            }
            
        
            XmlNodeList secondaryRateSourceNodeList = xmlNode.SelectNodes("secondaryRateSource");
            if (secondaryRateSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in secondaryRateSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        secondaryRateSourceIDRef = item.Attributes["id"].Name;
                        InformationSource ob = InformationSource();
                        IDManager.SetID(secondaryRateSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        secondaryRateSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        secondaryRateSource = new InformationSource(item);
                    }
                }
            }
            
        
            XmlNodeList fxTypeNodeList = xmlNode.SelectNodes("fxType");
            if (fxTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxTypeIDRef = item.Attributes["id"].Name;
                        CommodityFxType ob = CommodityFxType();
                        IDManager.SetID(fxTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxType = new CommodityFxType(item);
                    }
                }
            }
            
        
            XmlNodeList averagingMethodNodeList = xmlNode.SelectNodes("averagingMethod");
            if (averagingMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in averagingMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averagingMethodIDRef = item.Attributes["id"].Name;
                        AveragingMethodEnum ob = AveragingMethodEnum();
                        IDManager.SetID(averagingMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averagingMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        averagingMethod = new AveragingMethodEnum(item);
                    }
                }
            }
            
        
            XmlNodeList fixingTimeNodeList = xmlNode.SelectNodes("fixingTime");
            if (fixingTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixingTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixingTimeIDRef = item.Attributes["id"].Name;
                        BusinessCenterTime ob = BusinessCenterTime();
                        IDManager.SetID(fixingTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixingTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixingTime = new BusinessCenterTime(item);
                    }
                }
            }
            
        
            XmlNodeList fxObservationDatesNodeList = xmlNode.SelectNodes("fxObservationDates");
            
            foreach (XmlNode item in fxObservationDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxObservationDatesIDRef = item.Attributes["id"].Name;
                        List<AdjustableDates> ob = new List<AdjustableDates>();
                        ob.Add(new AdjustableDates(item));
                        IDManager.SetID(fxObservationDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxObservationDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    fxObservationDates.Add(new AdjustableDates(item));
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
            
        
            XmlNodeList lagReferenceNodeList = xmlNode.SelectNodes("lagReference");
            if (lagReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in lagReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        lagReferenceIDRef = item.Attributes["id"].Name;
                        LagReference ob = LagReference();
                        IDManager.SetID(lagReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        lagReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        lagReference = new LagReference(item);
                    }
                }
            }
            
        
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
            
        
        }
        
    
        #region PrimaryRateSource
        private InformationSource primaryRateSource;
        public InformationSource PrimaryRateSource
        {
            get
            {
                if (this.primaryRateSource != null)
                {
                    return this.primaryRateSource; 
                }
                else if (this.primaryRateSourceIDRef != null)
                {
                    primaryRateSource = IDManager.getID(primaryRateSourceIDRef) as InformationSource;
                    return this.primaryRateSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.primaryRateSource != value)
                {
                    this.primaryRateSource = value;
                }
            }
        }
        #endregion
        
        public string InformationSourceIDRef { get; set; }
        #region SecondaryRateSource
        private InformationSource secondaryRateSource;
        public InformationSource SecondaryRateSource
        {
            get
            {
                if (this.secondaryRateSource != null)
                {
                    return this.secondaryRateSource; 
                }
                else if (this.secondaryRateSourceIDRef != null)
                {
                    secondaryRateSource = IDManager.getID(secondaryRateSourceIDRef) as InformationSource;
                    return this.secondaryRateSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.secondaryRateSource != value)
                {
                    this.secondaryRateSource = value;
                }
            }
        }
        #endregion
        
        public string InformationSourceIDRef { get; set; }
        #region FxType
        private CommodityFxType fxType;
        public CommodityFxType FxType
        {
            get
            {
                if (this.fxType != null)
                {
                    return this.fxType; 
                }
                else if (this.fxTypeIDRef != null)
                {
                    fxType = IDManager.getID(fxTypeIDRef) as CommodityFxType;
                    return this.fxType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxType != value)
                {
                    this.fxType = value;
                }
            }
        }
        #endregion
        
        public string CommodityFxTypeIDRef { get; set; }
        #region AveragingMethod
        private AveragingMethodEnum averagingMethod;
        public AveragingMethodEnum AveragingMethod
        {
            get
            {
                if (this.averagingMethod != null)
                {
                    return this.averagingMethod; 
                }
                else if (this.averagingMethodIDRef != null)
                {
                    averagingMethod = IDManager.getID(averagingMethodIDRef) as AveragingMethodEnum;
                    return this.averagingMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averagingMethod != value)
                {
                    this.averagingMethod = value;
                }
            }
        }
        #endregion
        
        public string AveragingMethodEnumIDRef { get; set; }
        #region FixingTime
        private BusinessCenterTime fixingTime;
        public BusinessCenterTime FixingTime
        {
            get
            {
                if (this.fixingTime != null)
                {
                    return this.fixingTime; 
                }
                else if (this.fixingTimeIDRef != null)
                {
                    fixingTime = IDManager.getID(fixingTimeIDRef) as BusinessCenterTime;
                    return this.fixingTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixingTime != value)
                {
                    this.fixingTime = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterTimeIDRef { get; set; }
        #region FxObservationDates
        private List<AdjustableDates> fxObservationDates;
        public List<AdjustableDates> FxObservationDates
        {
            get
            {
                if (this.fxObservationDates != null)
                {
                    return this.fxObservationDates; 
                }
                else if (this.fxObservationDatesIDRef != null)
                {
                    fxObservationDates = IDManager.getID(fxObservationDatesIDRef) as List<AdjustableDates>;
                    return this.fxObservationDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxObservationDates != value)
                {
                    this.fxObservationDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDatesIDRef { get; set; }
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
        #region LagReference
        private LagReference lagReference;
        public LagReference LagReference
        {
            get
            {
                if (this.lagReference != null)
                {
                    return this.lagReference; 
                }
                else if (this.lagReferenceIDRef != null)
                {
                    lagReference = IDManager.getID(lagReferenceIDRef) as LagReference;
                    return this.lagReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.lagReference != value)
                {
                    this.lagReference = value;
                }
            }
        }
        #endregion
        
        public string LagReferenceIDRef { get; set; }
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
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        public string choiceStr_3;
        public string choiceStr_4;
        
    
        
    
    }
    
}

