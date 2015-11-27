using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Calculation
    {
        public Calculation(XmlNode xmlNode)
        {
            XmlNodeList notionalScheduleNodeList = xmlNode.SelectNodes("notionalSchedule");
            if (notionalScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalScheduleIDRef = item.Attributes["id"].Name;
                        Notional ob = Notional();
                        IDManager.SetID(notionalScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalSchedule = new Notional(item);
                    }
                }
            }
            
        
            XmlNodeList fxLinkedNotionalScheduleNodeList = xmlNode.SelectNodes("fxLinkedNotionalSchedule");
            if (fxLinkedNotionalScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxLinkedNotionalScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxLinkedNotionalScheduleIDRef = item.Attributes["id"].Name;
                        FxLinkedNotionalSchedule ob = FxLinkedNotionalSchedule();
                        IDManager.SetID(fxLinkedNotionalScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxLinkedNotionalScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxLinkedNotionalSchedule = new FxLinkedNotionalSchedule(item);
                    }
                }
            }
            
        
            XmlNodeList fixedRateScheduleNodeList = xmlNode.SelectNodes("fixedRateSchedule");
            if (fixedRateScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedRateScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedRateScheduleIDRef = item.Attributes["id"].Name;
                        Schedule ob = Schedule();
                        IDManager.SetID(fixedRateScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedRateScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedRateSchedule = new Schedule(item);
                    }
                }
            }
            
        
            XmlNodeList futureValueNotionalNodeList = xmlNode.SelectNodes("futureValueNotional");
            if (futureValueNotionalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in futureValueNotionalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        futureValueNotionalIDRef = item.Attributes["id"].Name;
                        FutureValueAmount ob = FutureValueAmount();
                        IDManager.SetID(futureValueNotionalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        futureValueNotionalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        futureValueNotional = new FutureValueAmount(item);
                    }
                }
            }
            
        
            XmlNodeList rateCalculationNodeList = xmlNode.SelectNodes("rateCalculation");
            if (rateCalculationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rateCalculationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateCalculationIDRef = item.Attributes["id"].Name;
                        Rate ob = Rate();
                        IDManager.SetID(rateCalculationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateCalculationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rateCalculation = new Rate(item);
                    }
                }
            }
            
        
            XmlNodeList floatingRateCalculationNodeList = xmlNode.SelectNodes("floatingRateCalculation");
            if (floatingRateCalculationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in floatingRateCalculationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floatingRateCalculationIDRef = item.Attributes["id"].Name;
                        FloatingRateCalculation ob = FloatingRateCalculation();
                        IDManager.SetID(floatingRateCalculationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floatingRateCalculationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        floatingRateCalculation = new FloatingRateCalculation(item);
                    }
                }
            }
            
        
            XmlNodeList inflationRateCalculationNodeList = xmlNode.SelectNodes("inflationRateCalculation");
            if (inflationRateCalculationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in inflationRateCalculationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        inflationRateCalculationIDRef = item.Attributes["id"].Name;
                        InflationRateCalculation ob = InflationRateCalculation();
                        IDManager.SetID(inflationRateCalculationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        inflationRateCalculationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        inflationRateCalculation = new InflationRateCalculation(item);
                    }
                }
            }
            
        
            XmlNodeList dayCountFractionNodeList = xmlNode.SelectNodes("dayCountFraction");
            if (dayCountFractionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dayCountFractionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dayCountFractionIDRef = item.Attributes["id"].Name;
                        DayCountFraction ob = DayCountFraction();
                        IDManager.SetID(dayCountFractionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dayCountFractionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dayCountFraction = new DayCountFraction(item);
                    }
                }
            }
            
        
            XmlNodeList discountingNodeList = xmlNode.SelectNodes("discounting");
            if (discountingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in discountingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        discountingIDRef = item.Attributes["id"].Name;
                        Discounting ob = Discounting();
                        IDManager.SetID(discountingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        discountingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        discounting = new Discounting(item);
                    }
                }
            }
            
        
            XmlNodeList compoundingMethodNodeList = xmlNode.SelectNodes("compoundingMethod");
            if (compoundingMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in compoundingMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        compoundingMethodIDRef = item.Attributes["id"].Name;
                        CompoundingMethodEnum ob = CompoundingMethodEnum();
                        IDManager.SetID(compoundingMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        compoundingMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        compoundingMethod = new CompoundingMethodEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region NotionalSchedule
        private Notional notionalSchedule;
        public Notional NotionalSchedule
        {
            get
            {
                if (this.notionalSchedule != null)
                {
                    return this.notionalSchedule; 
                }
                else if (this.notionalScheduleIDRef != null)
                {
                    notionalSchedule = IDManager.getID(notionalScheduleIDRef) as Notional;
                    return this.notionalSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalSchedule != value)
                {
                    this.notionalSchedule = value;
                }
            }
        }
        #endregion
        
        public string NotionalIDRef { get; set; }
        #region FxLinkedNotionalSchedule
        private FxLinkedNotionalSchedule fxLinkedNotionalSchedule;
        public FxLinkedNotionalSchedule FxLinkedNotionalSchedule
        {
            get
            {
                if (this.fxLinkedNotionalSchedule != null)
                {
                    return this.fxLinkedNotionalSchedule; 
                }
                else if (this.fxLinkedNotionalScheduleIDRef != null)
                {
                    fxLinkedNotionalSchedule = IDManager.getID(fxLinkedNotionalScheduleIDRef) as FxLinkedNotionalSchedule;
                    return this.fxLinkedNotionalSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxLinkedNotionalSchedule != value)
                {
                    this.fxLinkedNotionalSchedule = value;
                }
            }
        }
        #endregion
        
        public string FxLinkedNotionalScheduleIDRef { get; set; }
        #region FixedRateSchedule
        private Schedule fixedRateSchedule;
        public Schedule FixedRateSchedule
        {
            get
            {
                if (this.fixedRateSchedule != null)
                {
                    return this.fixedRateSchedule; 
                }
                else if (this.fixedRateScheduleIDRef != null)
                {
                    fixedRateSchedule = IDManager.getID(fixedRateScheduleIDRef) as Schedule;
                    return this.fixedRateSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedRateSchedule != value)
                {
                    this.fixedRateSchedule = value;
                }
            }
        }
        #endregion
        
        public string ScheduleIDRef { get; set; }
        #region FutureValueNotional
        private FutureValueAmount futureValueNotional;
        public FutureValueAmount FutureValueNotional
        {
            get
            {
                if (this.futureValueNotional != null)
                {
                    return this.futureValueNotional; 
                }
                else if (this.futureValueNotionalIDRef != null)
                {
                    futureValueNotional = IDManager.getID(futureValueNotionalIDRef) as FutureValueAmount;
                    return this.futureValueNotional; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.futureValueNotional != value)
                {
                    this.futureValueNotional = value;
                }
            }
        }
        #endregion
        
        public string FutureValueAmountIDRef { get; set; }
        #region RateCalculation
        private Rate rateCalculation;
        public Rate RateCalculation
        {
            get
            {
                if (this.rateCalculation != null)
                {
                    return this.rateCalculation; 
                }
                else if (this.rateCalculationIDRef != null)
                {
                    rateCalculation = IDManager.getID(rateCalculationIDRef) as Rate;
                    return this.rateCalculation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rateCalculation != value)
                {
                    this.rateCalculation = value;
                }
            }
        }
        #endregion
        
        public string RateIDRef { get; set; }
        #region FloatingRateCalculation
        private FloatingRateCalculation floatingRateCalculation;
        public FloatingRateCalculation FloatingRateCalculation
        {
            get
            {
                if (this.floatingRateCalculation != null)
                {
                    return this.floatingRateCalculation; 
                }
                else if (this.floatingRateCalculationIDRef != null)
                {
                    floatingRateCalculation = IDManager.getID(floatingRateCalculationIDRef) as FloatingRateCalculation;
                    return this.floatingRateCalculation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floatingRateCalculation != value)
                {
                    this.floatingRateCalculation = value;
                }
            }
        }
        #endregion
        
        public string FloatingRateCalculationIDRef { get; set; }     // substitude
        #region InflationRateCalculation
        private InflationRateCalculation inflationRateCalculation;
        public InflationRateCalculation InflationRateCalculation
        {
            get
            {
                if (this.inflationRateCalculation != null)
                {
                    return this.inflationRateCalculation; 
                }
                else if (this.inflationRateCalculationIDRef != null)
                {
                    inflationRateCalculation = IDManager.getID(inflationRateCalculationIDRef) as InflationRateCalculation;
                    return this.inflationRateCalculation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.inflationRateCalculation != value)
                {
                    this.inflationRateCalculation = value;
                }
            }
        }
        #endregion
        
        public string InflationRateCalculationIDRef { get; set; }     // substitude
        #region DayCountFraction
        private DayCountFraction dayCountFraction;
        public DayCountFraction DayCountFraction
        {
            get
            {
                if (this.dayCountFraction != null)
                {
                    return this.dayCountFraction; 
                }
                else if (this.dayCountFractionIDRef != null)
                {
                    dayCountFraction = IDManager.getID(dayCountFractionIDRef) as DayCountFraction;
                    return this.dayCountFraction; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dayCountFraction != value)
                {
                    this.dayCountFraction = value;
                }
            }
        }
        #endregion
        
        public string DayCountFractionIDRef { get; set; }
        #region Discounting
        private Discounting discounting;
        public Discounting Discounting
        {
            get
            {
                if (this.discounting != null)
                {
                    return this.discounting; 
                }
                else if (this.discountingIDRef != null)
                {
                    discounting = IDManager.getID(discountingIDRef) as Discounting;
                    return this.discounting; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.discounting != value)
                {
                    this.discounting = value;
                }
            }
        }
        #endregion
        
        public string DiscountingIDRef { get; set; }
        #region CompoundingMethod
        private CompoundingMethodEnum compoundingMethod;
        public CompoundingMethodEnum CompoundingMethod
        {
            get
            {
                if (this.compoundingMethod != null)
                {
                    return this.compoundingMethod; 
                }
                else if (this.compoundingMethodIDRef != null)
                {
                    compoundingMethod = IDManager.getID(compoundingMethodIDRef) as CompoundingMethodEnum;
                    return this.compoundingMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.compoundingMethod != value)
                {
                    this.compoundingMethod = value;
                }
            }
        }
        #endregion
        
        public string CompoundingMethodEnumIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

