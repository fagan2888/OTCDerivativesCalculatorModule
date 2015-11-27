using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityDeliveryPeriods
    {
        public CommodityDeliveryPeriods(XmlNode xmlNode)
        {
            XmlNodeList periodsNodeList = xmlNode.SelectNodes("periods");
            if (periodsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in periodsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        periodsIDRef = item.Attributes["id"].Name;
                        AdjustableDates ob = AdjustableDates();
                        IDManager.SetID(periodsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        periodsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        periods = new AdjustableDates(item);
                    }
                }
            }
            
        
            XmlNodeList periodsScheduleNodeList = xmlNode.SelectNodes("periodsSchedule");
            if (periodsScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in periodsScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        periodsScheduleIDRef = item.Attributes["id"].Name;
                        CommodityCalculationPeriodsSchedule ob = CommodityCalculationPeriodsSchedule();
                        IDManager.SetID(periodsScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        periodsScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        periodsSchedule = new CommodityCalculationPeriodsSchedule(item);
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
        
    
        #region Periods
        private AdjustableDates periods;
        public AdjustableDates Periods
        {
            get
            {
                if (this.periods != null)
                {
                    return this.periods; 
                }
                else if (this.periodsIDRef != null)
                {
                    periods = IDManager.getID(periodsIDRef) as AdjustableDates;
                    return this.periods; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.periods != value)
                {
                    this.periods = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDatesIDRef { get; set; }
        #region PeriodsSchedule
        private CommodityCalculationPeriodsSchedule periodsSchedule;
        public CommodityCalculationPeriodsSchedule PeriodsSchedule
        {
            get
            {
                if (this.periodsSchedule != null)
                {
                    return this.periodsSchedule; 
                }
                else if (this.periodsScheduleIDRef != null)
                {
                    periodsSchedule = IDManager.getID(periodsScheduleIDRef) as CommodityCalculationPeriodsSchedule;
                    return this.periodsSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.periodsSchedule != value)
                {
                    this.periodsSchedule = value;
                }
            }
        }
        #endregion
        
        public string CommodityCalculationPeriodsScheduleIDRef { get; set; }
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
        
    
        
    
    }
    
}

