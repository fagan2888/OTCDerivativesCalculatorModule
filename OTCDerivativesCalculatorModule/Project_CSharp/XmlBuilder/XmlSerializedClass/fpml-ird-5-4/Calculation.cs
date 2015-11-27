using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Calculation : ISerialized
    {
        public Calculation(XmlNode xmlNode)
        {
            XmlNode notionalScheduleNode = xmlNode.SelectSingleNode("notionalSchedule");
            
            if (notionalScheduleNode != null)
            {
                if (notionalScheduleNode.Attributes["href"] != null || notionalScheduleNode.Attributes["id"] != null) 
                {
                    if (notionalScheduleNode.Attributes["id"] != null) 
                    {
                        notionalScheduleIDRef_ = notionalScheduleNode.Attributes["id"].Value;
                        Notional ob = new Notional(notionalScheduleNode);
                        IDManager.SetID(notionalScheduleIDRef_, ob);
                    }
                    else if (notionalScheduleNode.Attributes["href"] != null)
                    {
                        notionalScheduleIDRef_ = notionalScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalSchedule_ = new Notional(notionalScheduleNode);
                    }
                }
                else
                {
                    notionalSchedule_ = new Notional(notionalScheduleNode);
                }
            }
            
        
            XmlNode fxLinkedNotionalScheduleNode = xmlNode.SelectSingleNode("fxLinkedNotionalSchedule");
            
            if (fxLinkedNotionalScheduleNode != null)
            {
                if (fxLinkedNotionalScheduleNode.Attributes["href"] != null || fxLinkedNotionalScheduleNode.Attributes["id"] != null) 
                {
                    if (fxLinkedNotionalScheduleNode.Attributes["id"] != null) 
                    {
                        fxLinkedNotionalScheduleIDRef_ = fxLinkedNotionalScheduleNode.Attributes["id"].Value;
                        FxLinkedNotionalSchedule ob = new FxLinkedNotionalSchedule(fxLinkedNotionalScheduleNode);
                        IDManager.SetID(fxLinkedNotionalScheduleIDRef_, ob);
                    }
                    else if (fxLinkedNotionalScheduleNode.Attributes["href"] != null)
                    {
                        fxLinkedNotionalScheduleIDRef_ = fxLinkedNotionalScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxLinkedNotionalSchedule_ = new FxLinkedNotionalSchedule(fxLinkedNotionalScheduleNode);
                    }
                }
                else
                {
                    fxLinkedNotionalSchedule_ = new FxLinkedNotionalSchedule(fxLinkedNotionalScheduleNode);
                }
            }
            
        
            XmlNode fixedRateScheduleNode = xmlNode.SelectSingleNode("fixedRateSchedule");
            
            if (fixedRateScheduleNode != null)
            {
                if (fixedRateScheduleNode.Attributes["href"] != null || fixedRateScheduleNode.Attributes["id"] != null) 
                {
                    if (fixedRateScheduleNode.Attributes["id"] != null) 
                    {
                        fixedRateScheduleIDRef_ = fixedRateScheduleNode.Attributes["id"].Value;
                        Schedule ob = new Schedule(fixedRateScheduleNode);
                        IDManager.SetID(fixedRateScheduleIDRef_, ob);
                    }
                    else if (fixedRateScheduleNode.Attributes["href"] != null)
                    {
                        fixedRateScheduleIDRef_ = fixedRateScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedRateSchedule_ = new Schedule(fixedRateScheduleNode);
                    }
                }
                else
                {
                    fixedRateSchedule_ = new Schedule(fixedRateScheduleNode);
                }
            }
            
        
            XmlNode futureValueNotionalNode = xmlNode.SelectSingleNode("futureValueNotional");
            
            if (futureValueNotionalNode != null)
            {
                if (futureValueNotionalNode.Attributes["href"] != null || futureValueNotionalNode.Attributes["id"] != null) 
                {
                    if (futureValueNotionalNode.Attributes["id"] != null) 
                    {
                        futureValueNotionalIDRef_ = futureValueNotionalNode.Attributes["id"].Value;
                        FutureValueAmount ob = new FutureValueAmount(futureValueNotionalNode);
                        IDManager.SetID(futureValueNotionalIDRef_, ob);
                    }
                    else if (futureValueNotionalNode.Attributes["href"] != null)
                    {
                        futureValueNotionalIDRef_ = futureValueNotionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        futureValueNotional_ = new FutureValueAmount(futureValueNotionalNode);
                    }
                }
                else
                {
                    futureValueNotional_ = new FutureValueAmount(futureValueNotionalNode);
                }
            }
            
        
            XmlNode rateCalculationNode = xmlNode.SelectSingleNode("rateCalculation");
            
            if (rateCalculationNode != null)
            {
                if (rateCalculationNode.Attributes["href"] != null || rateCalculationNode.Attributes["id"] != null) 
                {
                    if (rateCalculationNode.Attributes["id"] != null) 
                    {
                        rateCalculationIDRef_ = rateCalculationNode.Attributes["id"].Value;
                        Rate ob = new Rate(rateCalculationNode);
                        IDManager.SetID(rateCalculationIDRef_, ob);
                    }
                    else if (rateCalculationNode.Attributes["href"] != null)
                    {
                        rateCalculationIDRef_ = rateCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rateCalculation_ = new Rate(rateCalculationNode);
                    }
                }
                else
                {
                    rateCalculation_ = new Rate(rateCalculationNode);
                }
            }
            
        
            XmlNode floatingRateCalculationNode = xmlNode.SelectSingleNode("floatingRateCalculation");
            
            if (floatingRateCalculationNode != null)
            {
                if (floatingRateCalculationNode.Attributes["href"] != null || floatingRateCalculationNode.Attributes["id"] != null) 
                {
                    if (floatingRateCalculationNode.Attributes["id"] != null) 
                    {
                        floatingRateCalculationIDRef_ = floatingRateCalculationNode.Attributes["id"].Value;
                        FloatingRateCalculation ob = new FloatingRateCalculation(floatingRateCalculationNode);
                        IDManager.SetID(floatingRateCalculationIDRef_, ob);
                    }
                    else if (floatingRateCalculationNode.Attributes["href"] != null)
                    {
                        floatingRateCalculationIDRef_ = floatingRateCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floatingRateCalculation_ = new FloatingRateCalculation(floatingRateCalculationNode);
                    }
                }
                else
                {
                    floatingRateCalculation_ = new FloatingRateCalculation(floatingRateCalculationNode);
                }
            }
            
        
            XmlNode inflationRateCalculationNode = xmlNode.SelectSingleNode("inflationRateCalculation");
            
            if (inflationRateCalculationNode != null)
            {
                if (inflationRateCalculationNode.Attributes["href"] != null || inflationRateCalculationNode.Attributes["id"] != null) 
                {
                    if (inflationRateCalculationNode.Attributes["id"] != null) 
                    {
                        inflationRateCalculationIDRef_ = inflationRateCalculationNode.Attributes["id"].Value;
                        InflationRateCalculation ob = new InflationRateCalculation(inflationRateCalculationNode);
                        IDManager.SetID(inflationRateCalculationIDRef_, ob);
                    }
                    else if (inflationRateCalculationNode.Attributes["href"] != null)
                    {
                        inflationRateCalculationIDRef_ = inflationRateCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        inflationRateCalculation_ = new InflationRateCalculation(inflationRateCalculationNode);
                    }
                }
                else
                {
                    inflationRateCalculation_ = new InflationRateCalculation(inflationRateCalculationNode);
                }
            }
            
        
            XmlNode dayCountFractionNode = xmlNode.SelectSingleNode("dayCountFraction");
            
            if (dayCountFractionNode != null)
            {
                if (dayCountFractionNode.Attributes["href"] != null || dayCountFractionNode.Attributes["id"] != null) 
                {
                    if (dayCountFractionNode.Attributes["id"] != null) 
                    {
                        dayCountFractionIDRef_ = dayCountFractionNode.Attributes["id"].Value;
                        DayCountFraction ob = new DayCountFraction(dayCountFractionNode);
                        IDManager.SetID(dayCountFractionIDRef_, ob);
                    }
                    else if (dayCountFractionNode.Attributes["href"] != null)
                    {
                        dayCountFractionIDRef_ = dayCountFractionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayCountFraction_ = new DayCountFraction(dayCountFractionNode);
                    }
                }
                else
                {
                    dayCountFraction_ = new DayCountFraction(dayCountFractionNode);
                }
            }
            
        
            XmlNode discountingNode = xmlNode.SelectSingleNode("discounting");
            
            if (discountingNode != null)
            {
                if (discountingNode.Attributes["href"] != null || discountingNode.Attributes["id"] != null) 
                {
                    if (discountingNode.Attributes["id"] != null) 
                    {
                        discountingIDRef_ = discountingNode.Attributes["id"].Value;
                        Discounting ob = new Discounting(discountingNode);
                        IDManager.SetID(discountingIDRef_, ob);
                    }
                    else if (discountingNode.Attributes["href"] != null)
                    {
                        discountingIDRef_ = discountingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        discounting_ = new Discounting(discountingNode);
                    }
                }
                else
                {
                    discounting_ = new Discounting(discountingNode);
                }
            }
            
        
            XmlNode compoundingMethodNode = xmlNode.SelectSingleNode("compoundingMethod");
            
            if (compoundingMethodNode != null)
            {
                if (compoundingMethodNode.Attributes["href"] != null || compoundingMethodNode.Attributes["id"] != null) 
                {
                    if (compoundingMethodNode.Attributes["id"] != null) 
                    {
                        compoundingMethodIDRef_ = compoundingMethodNode.Attributes["id"].Value;
                        CompoundingMethodEnum ob = new CompoundingMethodEnum(compoundingMethodNode);
                        IDManager.SetID(compoundingMethodIDRef_, ob);
                    }
                    else if (compoundingMethodNode.Attributes["href"] != null)
                    {
                        compoundingMethodIDRef_ = compoundingMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        compoundingMethod_ = new CompoundingMethodEnum(compoundingMethodNode);
                    }
                }
                else
                {
                    compoundingMethod_ = new CompoundingMethodEnum(compoundingMethodNode);
                }
            }
            
        
        }
        
    
        #region NotionalSchedule_
        private Notional notionalSchedule_;
        public Notional NotionalSchedule_
        {
            get
            {
                if (this.notionalSchedule_ != null)
                {
                    return this.notionalSchedule_; 
                }
                else if (this.notionalScheduleIDRef_ != null)
                {
                    notionalSchedule_ = IDManager.getID(notionalScheduleIDRef_) as Notional;
                    return this.notionalSchedule_; 
                }
                else
                {
                      return this.notionalSchedule_; 
                }
            }
            set
            {
                if (this.notionalSchedule_ != value)
                {
                    this.notionalSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string notionalScheduleIDRef_ { get; set; }
        #region FxLinkedNotionalSchedule_
        private FxLinkedNotionalSchedule fxLinkedNotionalSchedule_;
        public FxLinkedNotionalSchedule FxLinkedNotionalSchedule_
        {
            get
            {
                if (this.fxLinkedNotionalSchedule_ != null)
                {
                    return this.fxLinkedNotionalSchedule_; 
                }
                else if (this.fxLinkedNotionalScheduleIDRef_ != null)
                {
                    fxLinkedNotionalSchedule_ = IDManager.getID(fxLinkedNotionalScheduleIDRef_) as FxLinkedNotionalSchedule;
                    return this.fxLinkedNotionalSchedule_; 
                }
                else
                {
                      return this.fxLinkedNotionalSchedule_; 
                }
            }
            set
            {
                if (this.fxLinkedNotionalSchedule_ != value)
                {
                    this.fxLinkedNotionalSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string fxLinkedNotionalScheduleIDRef_ { get; set; }
        #region FixedRateSchedule_
        private Schedule fixedRateSchedule_;
        public Schedule FixedRateSchedule_
        {
            get
            {
                if (this.fixedRateSchedule_ != null)
                {
                    return this.fixedRateSchedule_; 
                }
                else if (this.fixedRateScheduleIDRef_ != null)
                {
                    fixedRateSchedule_ = IDManager.getID(fixedRateScheduleIDRef_) as Schedule;
                    return this.fixedRateSchedule_; 
                }
                else
                {
                      return this.fixedRateSchedule_; 
                }
            }
            set
            {
                if (this.fixedRateSchedule_ != value)
                {
                    this.fixedRateSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string fixedRateScheduleIDRef_ { get; set; }
        #region FutureValueNotional_
        private FutureValueAmount futureValueNotional_;
        public FutureValueAmount FutureValueNotional_
        {
            get
            {
                if (this.futureValueNotional_ != null)
                {
                    return this.futureValueNotional_; 
                }
                else if (this.futureValueNotionalIDRef_ != null)
                {
                    futureValueNotional_ = IDManager.getID(futureValueNotionalIDRef_) as FutureValueAmount;
                    return this.futureValueNotional_; 
                }
                else
                {
                      return this.futureValueNotional_; 
                }
            }
            set
            {
                if (this.futureValueNotional_ != value)
                {
                    this.futureValueNotional_ = value;
                }
            }
        }
        #endregion
        
        public string futureValueNotionalIDRef_ { get; set; }
        #region RateCalculation_
        private Rate rateCalculation_;
        public Rate RateCalculation_
        {
            get
            {
                if (this.rateCalculation_ != null)
                {
                    return this.rateCalculation_; 
                }
                else if (this.rateCalculationIDRef_ != null)
                {
                    rateCalculation_ = IDManager.getID(rateCalculationIDRef_) as Rate;
                    return this.rateCalculation_; 
                }
                else
                {
                      return this.rateCalculation_; 
                }
            }
            set
            {
                if (this.rateCalculation_ != value)
                {
                    this.rateCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string rateCalculationIDRef_ { get; set; }
        #region FloatingRateCalculation_
        private FloatingRateCalculation floatingRateCalculation_;
        public FloatingRateCalculation FloatingRateCalculation_
        {
            get
            {
                if (this.floatingRateCalculation_ != null)
                {
                    return this.floatingRateCalculation_; 
                }
                else if (this.floatingRateCalculationIDRef_ != null)
                {
                    floatingRateCalculation_ = IDManager.getID(floatingRateCalculationIDRef_) as FloatingRateCalculation;
                    return this.floatingRateCalculation_; 
                }
                else
                {
                      return this.floatingRateCalculation_; 
                }
            }
            set
            {
                if (this.floatingRateCalculation_ != value)
                {
                    this.floatingRateCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string floatingRateCalculationIDRef_ { get; set; }     // substitude
        #region InflationRateCalculation_
        private InflationRateCalculation inflationRateCalculation_;
        public InflationRateCalculation InflationRateCalculation_
        {
            get
            {
                if (this.inflationRateCalculation_ != null)
                {
                    return this.inflationRateCalculation_; 
                }
                else if (this.inflationRateCalculationIDRef_ != null)
                {
                    inflationRateCalculation_ = IDManager.getID(inflationRateCalculationIDRef_) as InflationRateCalculation;
                    return this.inflationRateCalculation_; 
                }
                else
                {
                      return this.inflationRateCalculation_; 
                }
            }
            set
            {
                if (this.inflationRateCalculation_ != value)
                {
                    this.inflationRateCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string inflationRateCalculationIDRef_ { get; set; }     // substitude
        #region DayCountFraction_
        private DayCountFraction dayCountFraction_;
        public DayCountFraction DayCountFraction_
        {
            get
            {
                if (this.dayCountFraction_ != null)
                {
                    return this.dayCountFraction_; 
                }
                else if (this.dayCountFractionIDRef_ != null)
                {
                    dayCountFraction_ = IDManager.getID(dayCountFractionIDRef_) as DayCountFraction;
                    return this.dayCountFraction_; 
                }
                else
                {
                      return this.dayCountFraction_; 
                }
            }
            set
            {
                if (this.dayCountFraction_ != value)
                {
                    this.dayCountFraction_ = value;
                }
            }
        }
        #endregion
        
        public string dayCountFractionIDRef_ { get; set; }
        #region Discounting_
        private Discounting discounting_;
        public Discounting Discounting_
        {
            get
            {
                if (this.discounting_ != null)
                {
                    return this.discounting_; 
                }
                else if (this.discountingIDRef_ != null)
                {
                    discounting_ = IDManager.getID(discountingIDRef_) as Discounting;
                    return this.discounting_; 
                }
                else
                {
                      return this.discounting_; 
                }
            }
            set
            {
                if (this.discounting_ != value)
                {
                    this.discounting_ = value;
                }
            }
        }
        #endregion
        
        public string discountingIDRef_ { get; set; }
        #region CompoundingMethod_
        private CompoundingMethodEnum compoundingMethod_;
        public CompoundingMethodEnum CompoundingMethod_
        {
            get
            {
                if (this.compoundingMethod_ != null)
                {
                    return this.compoundingMethod_; 
                }
                else if (this.compoundingMethodIDRef_ != null)
                {
                    compoundingMethod_ = IDManager.getID(compoundingMethodIDRef_) as CompoundingMethodEnum;
                    return this.compoundingMethod_; 
                }
                else
                {
                      return this.compoundingMethod_; 
                }
            }
            set
            {
                if (this.compoundingMethod_ != value)
                {
                    this.compoundingMethod_ = value;
                }
            }
        }
        #endregion
        
        public string compoundingMethodIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

