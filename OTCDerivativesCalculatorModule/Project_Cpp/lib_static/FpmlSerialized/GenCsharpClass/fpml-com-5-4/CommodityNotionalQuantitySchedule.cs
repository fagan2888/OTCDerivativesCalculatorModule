using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityNotionalQuantitySchedule
    {
        public CommodityNotionalQuantitySchedule(XmlNode xmlNode)
        {
            XmlNodeList notionalStepNodeList = xmlNode.SelectNodes("notionalStep");
            
            foreach (XmlNode item in notionalStepNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalStepIDRef = item.Attributes["id"].Name;
                        List<CommodityNotionalQuantity> ob = new List<CommodityNotionalQuantity>();
                        ob.Add(new CommodityNotionalQuantity(item));
                        IDManager.SetID(notionalStepIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalStepIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    notionalStep.Add(new CommodityNotionalQuantity(item));
                    }
                }
            }
            
        
            XmlNodeList settlementPeriodsNotionalQuantityScheduleNodeList = xmlNode.SelectNodes("settlementPeriodsNotionalQuantitySchedule");
            
            foreach (XmlNode item in settlementPeriodsNotionalQuantityScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementPeriodsNotionalQuantityScheduleIDRef = item.Attributes["id"].Name;
                        List<CommoditySettlementPeriodsNotionalQuantitySchedule> ob = new List<CommoditySettlementPeriodsNotionalQuantitySchedule>();
                        ob.Add(new CommoditySettlementPeriodsNotionalQuantitySchedule(item));
                        IDManager.SetID(settlementPeriodsNotionalQuantityScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementPeriodsNotionalQuantityScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    settlementPeriodsNotionalQuantitySchedule.Add(new CommoditySettlementPeriodsNotionalQuantitySchedule(item));
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
        
    
        #region NotionalStep
        private List<CommodityNotionalQuantity> notionalStep;
        public List<CommodityNotionalQuantity> NotionalStep
        {
            get
            {
                if (this.notionalStep != null)
                {
                    return this.notionalStep; 
                }
                else if (this.notionalStepIDRef != null)
                {
                    notionalStep = IDManager.getID(notionalStepIDRef) as List<CommodityNotionalQuantity>;
                    return this.notionalStep; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalStep != value)
                {
                    this.notionalStep = value;
                }
            }
        }
        #endregion
        
        public string CommodityNotionalQuantityIDRef { get; set; }
        #region SettlementPeriodsNotionalQuantitySchedule
        private List<CommoditySettlementPeriodsNotionalQuantitySchedule> settlementPeriodsNotionalQuantitySchedule;
        public List<CommoditySettlementPeriodsNotionalQuantitySchedule> SettlementPeriodsNotionalQuantitySchedule
        {
            get
            {
                if (this.settlementPeriodsNotionalQuantitySchedule != null)
                {
                    return this.settlementPeriodsNotionalQuantitySchedule; 
                }
                else if (this.settlementPeriodsNotionalQuantityScheduleIDRef != null)
                {
                    settlementPeriodsNotionalQuantitySchedule = IDManager.getID(settlementPeriodsNotionalQuantityScheduleIDRef) as List<CommoditySettlementPeriodsNotionalQuantitySchedule>;
                    return this.settlementPeriodsNotionalQuantitySchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementPeriodsNotionalQuantitySchedule != value)
                {
                    this.settlementPeriodsNotionalQuantitySchedule = value;
                }
            }
        }
        #endregion
        
        public string CommoditySettlementPeriodsNotionalQuantityScheduleIDRef { get; set; }
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

