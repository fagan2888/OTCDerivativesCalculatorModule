using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityFx : ISerialized
    {
        public CommodityFx(XmlNode xmlNode)
        {
            XmlNode primaryRateSourceNode = xmlNode.SelectSingleNode("primaryRateSource");
            
            if (primaryRateSourceNode != null)
            {
                if (primaryRateSourceNode.Attributes["href"] != null || primaryRateSourceNode.Attributes["id"] != null) 
                {
                    if (primaryRateSourceNode.Attributes["id"] != null) 
                    {
                        primaryRateSourceIDRef_ = primaryRateSourceNode.Attributes["id"].Value;
                        InformationSource ob = new InformationSource(primaryRateSourceNode);
                        IDManager.SetID(primaryRateSourceIDRef_, ob);
                    }
                    else if (primaryRateSourceNode.Attributes["href"] != null)
                    {
                        primaryRateSourceIDRef_ = primaryRateSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        primaryRateSource_ = new InformationSource(primaryRateSourceNode);
                    }
                }
                else
                {
                    primaryRateSource_ = new InformationSource(primaryRateSourceNode);
                }
            }
            
        
            XmlNode secondaryRateSourceNode = xmlNode.SelectSingleNode("secondaryRateSource");
            
            if (secondaryRateSourceNode != null)
            {
                if (secondaryRateSourceNode.Attributes["href"] != null || secondaryRateSourceNode.Attributes["id"] != null) 
                {
                    if (secondaryRateSourceNode.Attributes["id"] != null) 
                    {
                        secondaryRateSourceIDRef_ = secondaryRateSourceNode.Attributes["id"].Value;
                        InformationSource ob = new InformationSource(secondaryRateSourceNode);
                        IDManager.SetID(secondaryRateSourceIDRef_, ob);
                    }
                    else if (secondaryRateSourceNode.Attributes["href"] != null)
                    {
                        secondaryRateSourceIDRef_ = secondaryRateSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        secondaryRateSource_ = new InformationSource(secondaryRateSourceNode);
                    }
                }
                else
                {
                    secondaryRateSource_ = new InformationSource(secondaryRateSourceNode);
                }
            }
            
        
            XmlNode fxTypeNode = xmlNode.SelectSingleNode("fxType");
            
            if (fxTypeNode != null)
            {
                if (fxTypeNode.Attributes["href"] != null || fxTypeNode.Attributes["id"] != null) 
                {
                    if (fxTypeNode.Attributes["id"] != null) 
                    {
                        fxTypeIDRef_ = fxTypeNode.Attributes["id"].Value;
                        CommodityFxType ob = new CommodityFxType(fxTypeNode);
                        IDManager.SetID(fxTypeIDRef_, ob);
                    }
                    else if (fxTypeNode.Attributes["href"] != null)
                    {
                        fxTypeIDRef_ = fxTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxType_ = new CommodityFxType(fxTypeNode);
                    }
                }
                else
                {
                    fxType_ = new CommodityFxType(fxTypeNode);
                }
            }
            
        
            XmlNode averagingMethodNode = xmlNode.SelectSingleNode("averagingMethod");
            
            if (averagingMethodNode != null)
            {
                if (averagingMethodNode.Attributes["href"] != null || averagingMethodNode.Attributes["id"] != null) 
                {
                    if (averagingMethodNode.Attributes["id"] != null) 
                    {
                        averagingMethodIDRef_ = averagingMethodNode.Attributes["id"].Value;
                        AveragingMethodEnum ob = new AveragingMethodEnum(averagingMethodNode);
                        IDManager.SetID(averagingMethodIDRef_, ob);
                    }
                    else if (averagingMethodNode.Attributes["href"] != null)
                    {
                        averagingMethodIDRef_ = averagingMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averagingMethod_ = new AveragingMethodEnum(averagingMethodNode);
                    }
                }
                else
                {
                    averagingMethod_ = new AveragingMethodEnum(averagingMethodNode);
                }
            }
            
        
            XmlNode fixingTimeNode = xmlNode.SelectSingleNode("fixingTime");
            
            if (fixingTimeNode != null)
            {
                if (fixingTimeNode.Attributes["href"] != null || fixingTimeNode.Attributes["id"] != null) 
                {
                    if (fixingTimeNode.Attributes["id"] != null) 
                    {
                        fixingTimeIDRef_ = fixingTimeNode.Attributes["id"].Value;
                        BusinessCenterTime ob = new BusinessCenterTime(fixingTimeNode);
                        IDManager.SetID(fixingTimeIDRef_, ob);
                    }
                    else if (fixingTimeNode.Attributes["href"] != null)
                    {
                        fixingTimeIDRef_ = fixingTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixingTime_ = new BusinessCenterTime(fixingTimeNode);
                    }
                }
                else
                {
                    fixingTime_ = new BusinessCenterTime(fixingTimeNode);
                }
            }
            
        
            XmlNodeList fxObservationDatesNodeList = xmlNode.SelectNodes("fxObservationDates");
            
            if (fxObservationDatesNodeList != null)
            {
                this.fxObservationDates_ = new List<AdjustableDates>();
                foreach (XmlNode item in fxObservationDatesNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            fxObservationDatesIDRef_ = item.Attributes["id"].Value;
                            fxObservationDates_.Add(new AdjustableDates(item));
                            IDManager.SetID(fxObservationDatesIDRef_, fxObservationDates_[fxObservationDates_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            fxObservationDatesIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        fxObservationDates_.Add(new AdjustableDates(item));
                        }
                    }
                    else
                    {
                        fxObservationDates_.Add(new AdjustableDates(item));
                    }
                }
            }
            
        
            XmlNode dayTypeNode = xmlNode.SelectSingleNode("dayType");
            
            if (dayTypeNode != null)
            {
                if (dayTypeNode.Attributes["href"] != null || dayTypeNode.Attributes["id"] != null) 
                {
                    if (dayTypeNode.Attributes["id"] != null) 
                    {
                        dayTypeIDRef_ = dayTypeNode.Attributes["id"].Value;
                        CommodityDayTypeEnum ob = new CommodityDayTypeEnum(dayTypeNode);
                        IDManager.SetID(dayTypeIDRef_, ob);
                    }
                    else if (dayTypeNode.Attributes["href"] != null)
                    {
                        dayTypeIDRef_ = dayTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayType_ = new CommodityDayTypeEnum(dayTypeNode);
                    }
                }
                else
                {
                    dayType_ = new CommodityDayTypeEnum(dayTypeNode);
                }
            }
            
        
            XmlNode dayDistributionNode = xmlNode.SelectSingleNode("dayDistribution");
            
            if (dayDistributionNode != null)
            {
                if (dayDistributionNode.Attributes["href"] != null || dayDistributionNode.Attributes["id"] != null) 
                {
                    if (dayDistributionNode.Attributes["id"] != null) 
                    {
                        dayDistributionIDRef_ = dayDistributionNode.Attributes["id"].Value;
                        CommodityFrequencyType ob = new CommodityFrequencyType(dayDistributionNode);
                        IDManager.SetID(dayDistributionIDRef_, ob);
                    }
                    else if (dayDistributionNode.Attributes["href"] != null)
                    {
                        dayDistributionIDRef_ = dayDistributionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayDistribution_ = new CommodityFrequencyType(dayDistributionNode);
                    }
                }
                else
                {
                    dayDistribution_ = new CommodityFrequencyType(dayDistributionNode);
                }
            }
            
        
            XmlNode dayCountNode = xmlNode.SelectSingleNode("dayCount");
            
            if (dayCountNode != null)
            {
                if (dayCountNode.Attributes["href"] != null || dayCountNode.Attributes["id"] != null) 
                {
                    if (dayCountNode.Attributes["id"] != null) 
                    {
                        dayCountIDRef_ = dayCountNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(dayCountNode);
                        IDManager.SetID(dayCountIDRef_, ob);
                    }
                    else if (dayCountNode.Attributes["href"] != null)
                    {
                        dayCountIDRef_ = dayCountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayCount_ = new XsdTypePositiveInteger(dayCountNode);
                    }
                }
                else
                {
                    dayCount_ = new XsdTypePositiveInteger(dayCountNode);
                }
            }
            
        
            XmlNodeList dayOfWeekNodeList = xmlNode.SelectNodes("dayOfWeek");
            
            if (dayOfWeekNodeList != null)
            {
                this.dayOfWeek_ = new List<DayOfWeekEnum>();
                foreach (XmlNode item in dayOfWeekNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            dayOfWeekIDRef_ = item.Attributes["id"].Value;
                            dayOfWeek_.Add(new DayOfWeekEnum(item));
                            IDManager.SetID(dayOfWeekIDRef_, dayOfWeek_[dayOfWeek_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            dayOfWeekIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        dayOfWeek_.Add(new DayOfWeekEnum(item));
                        }
                    }
                    else
                    {
                        dayOfWeek_.Add(new DayOfWeekEnum(item));
                    }
                }
            }
            
        
            XmlNode dayNumberNode = xmlNode.SelectSingleNode("dayNumber");
            
            if (dayNumberNode != null)
            {
                if (dayNumberNode.Attributes["href"] != null || dayNumberNode.Attributes["id"] != null) 
                {
                    if (dayNumberNode.Attributes["id"] != null) 
                    {
                        dayNumberIDRef_ = dayNumberNode.Attributes["id"].Value;
                        XsdTypeInteger ob = new XsdTypeInteger(dayNumberNode);
                        IDManager.SetID(dayNumberIDRef_, ob);
                    }
                    else if (dayNumberNode.Attributes["href"] != null)
                    {
                        dayNumberIDRef_ = dayNumberNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayNumber_ = new XsdTypeInteger(dayNumberNode);
                    }
                }
                else
                {
                    dayNumber_ = new XsdTypeInteger(dayNumberNode);
                }
            }
            
        
            XmlNode lagNode = xmlNode.SelectSingleNode("lag");
            
            if (lagNode != null)
            {
                if (lagNode.Attributes["href"] != null || lagNode.Attributes["id"] != null) 
                {
                    if (lagNode.Attributes["id"] != null) 
                    {
                        lagIDRef_ = lagNode.Attributes["id"].Value;
                        Lag ob = new Lag(lagNode);
                        IDManager.SetID(lagIDRef_, ob);
                    }
                    else if (lagNode.Attributes["href"] != null)
                    {
                        lagIDRef_ = lagNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lag_ = new Lag(lagNode);
                    }
                }
                else
                {
                    lag_ = new Lag(lagNode);
                }
            }
            
        
            XmlNode lagReferenceNode = xmlNode.SelectSingleNode("lagReference");
            
            if (lagReferenceNode != null)
            {
                if (lagReferenceNode.Attributes["href"] != null || lagReferenceNode.Attributes["id"] != null) 
                {
                    if (lagReferenceNode.Attributes["id"] != null) 
                    {
                        lagReferenceIDRef_ = lagReferenceNode.Attributes["id"].Value;
                        LagReference ob = new LagReference(lagReferenceNode);
                        IDManager.SetID(lagReferenceIDRef_, ob);
                    }
                    else if (lagReferenceNode.Attributes["href"] != null)
                    {
                        lagReferenceIDRef_ = lagReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lagReference_ = new LagReference(lagReferenceNode);
                    }
                }
                else
                {
                    lagReference_ = new LagReference(lagReferenceNode);
                }
            }
            
        
            XmlNode calculationPeriodsReferenceNode = xmlNode.SelectSingleNode("calculationPeriodsReference");
            
            if (calculationPeriodsReferenceNode != null)
            {
                if (calculationPeriodsReferenceNode.Attributes["href"] != null || calculationPeriodsReferenceNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodsReferenceNode.Attributes["id"] != null) 
                    {
                        calculationPeriodsReferenceIDRef_ = calculationPeriodsReferenceNode.Attributes["id"].Value;
                        CalculationPeriodsReference ob = new CalculationPeriodsReference(calculationPeriodsReferenceNode);
                        IDManager.SetID(calculationPeriodsReferenceIDRef_, ob);
                    }
                    else if (calculationPeriodsReferenceNode.Attributes["href"] != null)
                    {
                        calculationPeriodsReferenceIDRef_ = calculationPeriodsReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodsReference_ = new CalculationPeriodsReference(calculationPeriodsReferenceNode);
                    }
                }
                else
                {
                    calculationPeriodsReference_ = new CalculationPeriodsReference(calculationPeriodsReferenceNode);
                }
            }
            
        
            XmlNode calculationPeriodsScheduleReferenceNode = xmlNode.SelectSingleNode("calculationPeriodsScheduleReference");
            
            if (calculationPeriodsScheduleReferenceNode != null)
            {
                if (calculationPeriodsScheduleReferenceNode.Attributes["href"] != null || calculationPeriodsScheduleReferenceNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodsScheduleReferenceNode.Attributes["id"] != null) 
                    {
                        calculationPeriodsScheduleReferenceIDRef_ = calculationPeriodsScheduleReferenceNode.Attributes["id"].Value;
                        CalculationPeriodsScheduleReference ob = new CalculationPeriodsScheduleReference(calculationPeriodsScheduleReferenceNode);
                        IDManager.SetID(calculationPeriodsScheduleReferenceIDRef_, ob);
                    }
                    else if (calculationPeriodsScheduleReferenceNode.Attributes["href"] != null)
                    {
                        calculationPeriodsScheduleReferenceIDRef_ = calculationPeriodsScheduleReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodsScheduleReference_ = new CalculationPeriodsScheduleReference(calculationPeriodsScheduleReferenceNode);
                    }
                }
                else
                {
                    calculationPeriodsScheduleReference_ = new CalculationPeriodsScheduleReference(calculationPeriodsScheduleReferenceNode);
                }
            }
            
        
            XmlNode calculationPeriodsDatesReferenceNode = xmlNode.SelectSingleNode("calculationPeriodsDatesReference");
            
            if (calculationPeriodsDatesReferenceNode != null)
            {
                if (calculationPeriodsDatesReferenceNode.Attributes["href"] != null || calculationPeriodsDatesReferenceNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodsDatesReferenceNode.Attributes["id"] != null) 
                    {
                        calculationPeriodsDatesReferenceIDRef_ = calculationPeriodsDatesReferenceNode.Attributes["id"].Value;
                        CalculationPeriodsDatesReference ob = new CalculationPeriodsDatesReference(calculationPeriodsDatesReferenceNode);
                        IDManager.SetID(calculationPeriodsDatesReferenceIDRef_, ob);
                    }
                    else if (calculationPeriodsDatesReferenceNode.Attributes["href"] != null)
                    {
                        calculationPeriodsDatesReferenceIDRef_ = calculationPeriodsDatesReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodsDatesReference_ = new CalculationPeriodsDatesReference(calculationPeriodsDatesReferenceNode);
                    }
                }
                else
                {
                    calculationPeriodsDatesReference_ = new CalculationPeriodsDatesReference(calculationPeriodsDatesReferenceNode);
                }
            }
            
        
        }
        
    
        #region PrimaryRateSource_
        private InformationSource primaryRateSource_;
        public InformationSource PrimaryRateSource_
        {
            get
            {
                if (this.primaryRateSource_ != null)
                {
                    return this.primaryRateSource_; 
                }
                else if (this.primaryRateSourceIDRef_ != null)
                {
                    primaryRateSource_ = IDManager.getID(primaryRateSourceIDRef_) as InformationSource;
                    return this.primaryRateSource_; 
                }
                else
                {
                      return this.primaryRateSource_; 
                }
            }
            set
            {
                if (this.primaryRateSource_ != value)
                {
                    this.primaryRateSource_ = value;
                }
            }
        }
        #endregion
        
        public string primaryRateSourceIDRef_ { get; set; }
        #region SecondaryRateSource_
        private InformationSource secondaryRateSource_;
        public InformationSource SecondaryRateSource_
        {
            get
            {
                if (this.secondaryRateSource_ != null)
                {
                    return this.secondaryRateSource_; 
                }
                else if (this.secondaryRateSourceIDRef_ != null)
                {
                    secondaryRateSource_ = IDManager.getID(secondaryRateSourceIDRef_) as InformationSource;
                    return this.secondaryRateSource_; 
                }
                else
                {
                      return this.secondaryRateSource_; 
                }
            }
            set
            {
                if (this.secondaryRateSource_ != value)
                {
                    this.secondaryRateSource_ = value;
                }
            }
        }
        #endregion
        
        public string secondaryRateSourceIDRef_ { get; set; }
        #region FxType_
        private CommodityFxType fxType_;
        public CommodityFxType FxType_
        {
            get
            {
                if (this.fxType_ != null)
                {
                    return this.fxType_; 
                }
                else if (this.fxTypeIDRef_ != null)
                {
                    fxType_ = IDManager.getID(fxTypeIDRef_) as CommodityFxType;
                    return this.fxType_; 
                }
                else
                {
                      return this.fxType_; 
                }
            }
            set
            {
                if (this.fxType_ != value)
                {
                    this.fxType_ = value;
                }
            }
        }
        #endregion
        
        public string fxTypeIDRef_ { get; set; }
        #region AveragingMethod_
        private AveragingMethodEnum averagingMethod_;
        public AveragingMethodEnum AveragingMethod_
        {
            get
            {
                if (this.averagingMethod_ != null)
                {
                    return this.averagingMethod_; 
                }
                else if (this.averagingMethodIDRef_ != null)
                {
                    averagingMethod_ = IDManager.getID(averagingMethodIDRef_) as AveragingMethodEnum;
                    return this.averagingMethod_; 
                }
                else
                {
                      return this.averagingMethod_; 
                }
            }
            set
            {
                if (this.averagingMethod_ != value)
                {
                    this.averagingMethod_ = value;
                }
            }
        }
        #endregion
        
        public string averagingMethodIDRef_ { get; set; }
        #region FixingTime_
        private BusinessCenterTime fixingTime_;
        public BusinessCenterTime FixingTime_
        {
            get
            {
                if (this.fixingTime_ != null)
                {
                    return this.fixingTime_; 
                }
                else if (this.fixingTimeIDRef_ != null)
                {
                    fixingTime_ = IDManager.getID(fixingTimeIDRef_) as BusinessCenterTime;
                    return this.fixingTime_; 
                }
                else
                {
                      return this.fixingTime_; 
                }
            }
            set
            {
                if (this.fixingTime_ != value)
                {
                    this.fixingTime_ = value;
                }
            }
        }
        #endregion
        
        public string fixingTimeIDRef_ { get; set; }
        #region FxObservationDates_
        private List<AdjustableDates> fxObservationDates_;
        public List<AdjustableDates> FxObservationDates_
        {
            get
            {
                if (this.fxObservationDates_ != null)
                {
                    return this.fxObservationDates_; 
                }
                else if (this.fxObservationDatesIDRef_ != null)
                {
                    return this.fxObservationDates_; 
                }
                else
                {
                      return this.fxObservationDates_; 
                }
            }
            set
            {
                if (this.fxObservationDates_ != value)
                {
                    this.fxObservationDates_ = value;
                }
            }
        }
        #endregion
        
        public string fxObservationDatesIDRef_ { get; set; }
        #region DayType_
        private CommodityDayTypeEnum dayType_;
        public CommodityDayTypeEnum DayType_
        {
            get
            {
                if (this.dayType_ != null)
                {
                    return this.dayType_; 
                }
                else if (this.dayTypeIDRef_ != null)
                {
                    dayType_ = IDManager.getID(dayTypeIDRef_) as CommodityDayTypeEnum;
                    return this.dayType_; 
                }
                else
                {
                      return this.dayType_; 
                }
            }
            set
            {
                if (this.dayType_ != value)
                {
                    this.dayType_ = value;
                }
            }
        }
        #endregion
        
        public string dayTypeIDRef_ { get; set; }
        #region DayDistribution_
        private CommodityFrequencyType dayDistribution_;
        public CommodityFrequencyType DayDistribution_
        {
            get
            {
                if (this.dayDistribution_ != null)
                {
                    return this.dayDistribution_; 
                }
                else if (this.dayDistributionIDRef_ != null)
                {
                    dayDistribution_ = IDManager.getID(dayDistributionIDRef_) as CommodityFrequencyType;
                    return this.dayDistribution_; 
                }
                else
                {
                      return this.dayDistribution_; 
                }
            }
            set
            {
                if (this.dayDistribution_ != value)
                {
                    this.dayDistribution_ = value;
                }
            }
        }
        #endregion
        
        public string dayDistributionIDRef_ { get; set; }
        #region DayCount_
        private XsdTypePositiveInteger dayCount_;
        public XsdTypePositiveInteger DayCount_
        {
            get
            {
                if (this.dayCount_ != null)
                {
                    return this.dayCount_; 
                }
                else if (this.dayCountIDRef_ != null)
                {
                    dayCount_ = IDManager.getID(dayCountIDRef_) as XsdTypePositiveInteger;
                    return this.dayCount_; 
                }
                else
                {
                      return this.dayCount_; 
                }
            }
            set
            {
                if (this.dayCount_ != value)
                {
                    this.dayCount_ = value;
                }
            }
        }
        #endregion
        
        public string dayCountIDRef_ { get; set; }
        #region DayOfWeek_
        private List<DayOfWeekEnum> dayOfWeek_;
        public List<DayOfWeekEnum> DayOfWeek_
        {
            get
            {
                if (this.dayOfWeek_ != null)
                {
                    return this.dayOfWeek_; 
                }
                else if (this.dayOfWeekIDRef_ != null)
                {
                    return this.dayOfWeek_; 
                }
                else
                {
                      return this.dayOfWeek_; 
                }
            }
            set
            {
                if (this.dayOfWeek_ != value)
                {
                    this.dayOfWeek_ = value;
                }
            }
        }
        #endregion
        
        public string dayOfWeekIDRef_ { get; set; }
        #region DayNumber_
        private XsdTypeInteger dayNumber_;
        public XsdTypeInteger DayNumber_
        {
            get
            {
                if (this.dayNumber_ != null)
                {
                    return this.dayNumber_; 
                }
                else if (this.dayNumberIDRef_ != null)
                {
                    dayNumber_ = IDManager.getID(dayNumberIDRef_) as XsdTypeInteger;
                    return this.dayNumber_; 
                }
                else
                {
                      return this.dayNumber_; 
                }
            }
            set
            {
                if (this.dayNumber_ != value)
                {
                    this.dayNumber_ = value;
                }
            }
        }
        #endregion
        
        public string dayNumberIDRef_ { get; set; }
        #region Lag_
        private Lag lag_;
        public Lag Lag_
        {
            get
            {
                if (this.lag_ != null)
                {
                    return this.lag_; 
                }
                else if (this.lagIDRef_ != null)
                {
                    lag_ = IDManager.getID(lagIDRef_) as Lag;
                    return this.lag_; 
                }
                else
                {
                      return this.lag_; 
                }
            }
            set
            {
                if (this.lag_ != value)
                {
                    this.lag_ = value;
                }
            }
        }
        #endregion
        
        public string lagIDRef_ { get; set; }
        #region LagReference_
        private LagReference lagReference_;
        public LagReference LagReference_
        {
            get
            {
                if (this.lagReference_ != null)
                {
                    return this.lagReference_; 
                }
                else if (this.lagReferenceIDRef_ != null)
                {
                    lagReference_ = IDManager.getID(lagReferenceIDRef_) as LagReference;
                    return this.lagReference_; 
                }
                else
                {
                      return this.lagReference_; 
                }
            }
            set
            {
                if (this.lagReference_ != value)
                {
                    this.lagReference_ = value;
                }
            }
        }
        #endregion
        
        public string lagReferenceIDRef_ { get; set; }
        #region CalculationPeriodsReference_
        private CalculationPeriodsReference calculationPeriodsReference_;
        public CalculationPeriodsReference CalculationPeriodsReference_
        {
            get
            {
                if (this.calculationPeriodsReference_ != null)
                {
                    return this.calculationPeriodsReference_; 
                }
                else if (this.calculationPeriodsReferenceIDRef_ != null)
                {
                    calculationPeriodsReference_ = IDManager.getID(calculationPeriodsReferenceIDRef_) as CalculationPeriodsReference;
                    return this.calculationPeriodsReference_; 
                }
                else
                {
                      return this.calculationPeriodsReference_; 
                }
            }
            set
            {
                if (this.calculationPeriodsReference_ != value)
                {
                    this.calculationPeriodsReference_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodsReferenceIDRef_ { get; set; }
        #region CalculationPeriodsScheduleReference_
        private CalculationPeriodsScheduleReference calculationPeriodsScheduleReference_;
        public CalculationPeriodsScheduleReference CalculationPeriodsScheduleReference_
        {
            get
            {
                if (this.calculationPeriodsScheduleReference_ != null)
                {
                    return this.calculationPeriodsScheduleReference_; 
                }
                else if (this.calculationPeriodsScheduleReferenceIDRef_ != null)
                {
                    calculationPeriodsScheduleReference_ = IDManager.getID(calculationPeriodsScheduleReferenceIDRef_) as CalculationPeriodsScheduleReference;
                    return this.calculationPeriodsScheduleReference_; 
                }
                else
                {
                      return this.calculationPeriodsScheduleReference_; 
                }
            }
            set
            {
                if (this.calculationPeriodsScheduleReference_ != value)
                {
                    this.calculationPeriodsScheduleReference_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodsScheduleReferenceIDRef_ { get; set; }
        #region CalculationPeriodsDatesReference_
        private CalculationPeriodsDatesReference calculationPeriodsDatesReference_;
        public CalculationPeriodsDatesReference CalculationPeriodsDatesReference_
        {
            get
            {
                if (this.calculationPeriodsDatesReference_ != null)
                {
                    return this.calculationPeriodsDatesReference_; 
                }
                else if (this.calculationPeriodsDatesReferenceIDRef_ != null)
                {
                    calculationPeriodsDatesReference_ = IDManager.getID(calculationPeriodsDatesReferenceIDRef_) as CalculationPeriodsDatesReference;
                    return this.calculationPeriodsDatesReference_; 
                }
                else
                {
                      return this.calculationPeriodsDatesReference_; 
                }
            }
            set
            {
                if (this.calculationPeriodsDatesReference_ != value)
                {
                    this.calculationPeriodsDatesReference_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodsDatesReferenceIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        public string choiceStr_3;
        public string choiceStr_4;
        
    
        
    
    }
    
}

