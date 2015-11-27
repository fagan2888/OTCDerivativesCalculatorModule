using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityPricingDates : ISerialized
    {
        public CommodityPricingDates(XmlNode xmlNode)
        {
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
            
        
            XmlNode businessCalendarNode = xmlNode.SelectSingleNode("businessCalendar");
            
            if (businessCalendarNode != null)
            {
                if (businessCalendarNode.Attributes["href"] != null || businessCalendarNode.Attributes["id"] != null) 
                {
                    if (businessCalendarNode.Attributes["id"] != null) 
                    {
                        businessCalendarIDRef_ = businessCalendarNode.Attributes["id"].Value;
                        CommodityBusinessCalendar ob = new CommodityBusinessCalendar(businessCalendarNode);
                        IDManager.SetID(businessCalendarIDRef_, ob);
                    }
                    else if (businessCalendarNode.Attributes["href"] != null)
                    {
                        businessCalendarIDRef_ = businessCalendarNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessCalendar_ = new CommodityBusinessCalendar(businessCalendarNode);
                    }
                }
                else
                {
                    businessCalendar_ = new CommodityBusinessCalendar(businessCalendarNode);
                }
            }
            
        
            XmlNode calendarSourceNode = xmlNode.SelectSingleNode("calendarSource");
            
            if (calendarSourceNode != null)
            {
                if (calendarSourceNode.Attributes["href"] != null || calendarSourceNode.Attributes["id"] != null) 
                {
                    if (calendarSourceNode.Attributes["id"] != null) 
                    {
                        calendarSourceIDRef_ = calendarSourceNode.Attributes["id"].Value;
                        CalendarSourceEnum ob = new CalendarSourceEnum(calendarSourceNode);
                        IDManager.SetID(calendarSourceIDRef_, ob);
                    }
                    else if (calendarSourceNode.Attributes["href"] != null)
                    {
                        calendarSourceIDRef_ = calendarSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calendarSource_ = new CalendarSourceEnum(calendarSourceNode);
                    }
                }
                else
                {
                    calendarSource_ = new CalendarSourceEnum(calendarSourceNode);
                }
            }
            
        
            XmlNodeList settlementPeriodsNodeList = xmlNode.SelectNodes("settlementPeriods");
            
            if (settlementPeriodsNodeList != null)
            {
                this.settlementPeriods_ = new List<SettlementPeriods>();
                foreach (XmlNode item in settlementPeriodsNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            settlementPeriodsIDRef_ = item.Attributes["id"].Value;
                            settlementPeriods_.Add(new SettlementPeriods(item));
                            IDManager.SetID(settlementPeriodsIDRef_, settlementPeriods_[settlementPeriods_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            settlementPeriodsIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        settlementPeriods_.Add(new SettlementPeriods(item));
                        }
                    }
                    else
                    {
                        settlementPeriods_.Add(new SettlementPeriods(item));
                    }
                }
            }
            
        
            XmlNodeList settlementPeriodsReferenceNodeList = xmlNode.SelectNodes("settlementPeriodsReference");
            
            if (settlementPeriodsReferenceNodeList != null)
            {
                this.settlementPeriodsReference_ = new List<SettlementPeriodsReference>();
                foreach (XmlNode item in settlementPeriodsReferenceNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            settlementPeriodsReferenceIDRef_ = item.Attributes["id"].Value;
                            settlementPeriodsReference_.Add(new SettlementPeriodsReference(item));
                            IDManager.SetID(settlementPeriodsReferenceIDRef_, settlementPeriodsReference_[settlementPeriodsReference_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            settlementPeriodsReferenceIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        settlementPeriodsReference_.Add(new SettlementPeriodsReference(item));
                        }
                    }
                    else
                    {
                        settlementPeriodsReference_.Add(new SettlementPeriodsReference(item));
                    }
                }
            }
            
        
            XmlNodeList pricingDatesNodeList = xmlNode.SelectNodes("pricingDates");
            
            if (pricingDatesNodeList != null)
            {
                this.pricingDates_ = new List<AdjustableDates>();
                foreach (XmlNode item in pricingDatesNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            pricingDatesIDRef_ = item.Attributes["id"].Value;
                            pricingDates_.Add(new AdjustableDates(item));
                            IDManager.SetID(pricingDatesIDRef_, pricingDates_[pricingDates_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            pricingDatesIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        pricingDates_.Add(new AdjustableDates(item));
                        }
                    }
                    else
                    {
                        pricingDates_.Add(new AdjustableDates(item));
                    }
                }
            }
            
        
        }
        
    
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
        #region BusinessCalendar_
        private CommodityBusinessCalendar businessCalendar_;
        public CommodityBusinessCalendar BusinessCalendar_
        {
            get
            {
                if (this.businessCalendar_ != null)
                {
                    return this.businessCalendar_; 
                }
                else if (this.businessCalendarIDRef_ != null)
                {
                    businessCalendar_ = IDManager.getID(businessCalendarIDRef_) as CommodityBusinessCalendar;
                    return this.businessCalendar_; 
                }
                else
                {
                      return this.businessCalendar_; 
                }
            }
            set
            {
                if (this.businessCalendar_ != value)
                {
                    this.businessCalendar_ = value;
                }
            }
        }
        #endregion
        
        public string businessCalendarIDRef_ { get; set; }
        #region CalendarSource_
        private CalendarSourceEnum calendarSource_;
        public CalendarSourceEnum CalendarSource_
        {
            get
            {
                if (this.calendarSource_ != null)
                {
                    return this.calendarSource_; 
                }
                else if (this.calendarSourceIDRef_ != null)
                {
                    calendarSource_ = IDManager.getID(calendarSourceIDRef_) as CalendarSourceEnum;
                    return this.calendarSource_; 
                }
                else
                {
                      return this.calendarSource_; 
                }
            }
            set
            {
                if (this.calendarSource_ != value)
                {
                    this.calendarSource_ = value;
                }
            }
        }
        #endregion
        
        public string calendarSourceIDRef_ { get; set; }
        #region SettlementPeriods_
        private List<SettlementPeriods> settlementPeriods_;
        public List<SettlementPeriods> SettlementPeriods_
        {
            get
            {
                if (this.settlementPeriods_ != null)
                {
                    return this.settlementPeriods_; 
                }
                else if (this.settlementPeriodsIDRef_ != null)
                {
                    return this.settlementPeriods_; 
                }
                else
                {
                      return this.settlementPeriods_; 
                }
            }
            set
            {
                if (this.settlementPeriods_ != value)
                {
                    this.settlementPeriods_ = value;
                }
            }
        }
        #endregion
        
        public string settlementPeriodsIDRef_ { get; set; }
        #region SettlementPeriodsReference_
        private List<SettlementPeriodsReference> settlementPeriodsReference_;
        public List<SettlementPeriodsReference> SettlementPeriodsReference_
        {
            get
            {
                if (this.settlementPeriodsReference_ != null)
                {
                    return this.settlementPeriodsReference_; 
                }
                else if (this.settlementPeriodsReferenceIDRef_ != null)
                {
                    return this.settlementPeriodsReference_; 
                }
                else
                {
                      return this.settlementPeriodsReference_; 
                }
            }
            set
            {
                if (this.settlementPeriodsReference_ != value)
                {
                    this.settlementPeriodsReference_ = value;
                }
            }
        }
        #endregion
        
        public string settlementPeriodsReferenceIDRef_ { get; set; }
        #region PricingDates_
        private List<AdjustableDates> pricingDates_;
        public List<AdjustableDates> PricingDates_
        {
            get
            {
                if (this.pricingDates_ != null)
                {
                    return this.pricingDates_; 
                }
                else if (this.pricingDatesIDRef_ != null)
                {
                    return this.pricingDates_; 
                }
                else
                {
                      return this.pricingDates_; 
                }
            }
            set
            {
                if (this.pricingDates_ != value)
                {
                    this.pricingDates_ = value;
                }
            }
        }
        #endregion
        
        public string pricingDatesIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        public string choiceStr_3;
        
    
        
    
    }
    
}

