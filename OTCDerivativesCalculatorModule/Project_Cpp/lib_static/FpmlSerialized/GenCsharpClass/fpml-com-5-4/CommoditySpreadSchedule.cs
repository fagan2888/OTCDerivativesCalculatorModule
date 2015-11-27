using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommoditySpreadSchedule
    {
        public CommoditySpreadSchedule(XmlNode xmlNode)
        {
            XmlNodeList spreadStepNodeList = xmlNode.SelectNodes("spreadStep");
            
            foreach (XmlNode item in spreadStepNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spreadStepIDRef = item.Attributes["id"].Name;
                        List<CommoditySpread> ob = new List<CommoditySpread>();
                        ob.Add(new CommoditySpread(item));
                        IDManager.SetID(spreadStepIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spreadStepIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    spreadStep.Add(new CommoditySpread(item));
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
        
    
        #region SpreadStep
        private List<CommoditySpread> spreadStep;
        public List<CommoditySpread> SpreadStep
        {
            get
            {
                if (this.spreadStep != null)
                {
                    return this.spreadStep; 
                }
                else if (this.spreadStepIDRef != null)
                {
                    spreadStep = IDManager.getID(spreadStepIDRef) as List<CommoditySpread>;
                    return this.spreadStep; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spreadStep != value)
                {
                    this.spreadStep = value;
                }
            }
        }
        #endregion
        
        public string CommoditySpreadIDRef { get; set; }
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
        
    
        
    
    }
    
}

