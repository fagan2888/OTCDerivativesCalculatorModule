using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityFixedPriceSchedule
    {
        public CommodityFixedPriceSchedule(XmlNode xmlNode)
        {
            XmlNodeList fixedPriceStepNodeList = xmlNode.SelectNodes("fixedPriceStep");
            
            foreach (XmlNode item in fixedPriceStepNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedPriceStepIDRef = item.Attributes["id"].Name;
                        List<FixedPrice> ob = new List<FixedPrice>();
                        ob.Add(new FixedPrice(item));
                        IDManager.SetID(fixedPriceStepIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedPriceStepIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    fixedPriceStep.Add(new FixedPrice(item));
                    }
                }
            }
            
        
            XmlNodeList worldscaleRateStepNodeList = xmlNode.SelectNodes("worldscaleRateStep");
            
            foreach (XmlNode item in worldscaleRateStepNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        worldscaleRateStepIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = new XsdTypeDecimal();
                        ob.Add(new XsdTypeDecimal(item));
                        IDManager.SetID(worldscaleRateStepIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        worldscaleRateStepIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    worldscaleRateStep.Add(new XsdTypeDecimal(item));
                    }
                }
            }
            
        
            XmlNodeList contractRateStepNodeList = xmlNode.SelectNodes("contractRateStep");
            
            foreach (XmlNode item in contractRateStepNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        contractRateStepIDRef = item.Attributes["id"].Name;
                        List<NonNegativeMoney> ob = new List<NonNegativeMoney>();
                        ob.Add(new NonNegativeMoney(item));
                        IDManager.SetID(contractRateStepIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        contractRateStepIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    contractRateStep.Add(new NonNegativeMoney(item));
                    }
                }
            }
            
        
            XmlNodeList settlementPeriodsPriceScheduleNodeList = xmlNode.SelectNodes("settlementPeriodsPriceSchedule");
            
            foreach (XmlNode item in settlementPeriodsPriceScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementPeriodsPriceScheduleIDRef = item.Attributes["id"].Name;
                        List<CommoditySettlementPeriodsPriceSchedule> ob = new List<CommoditySettlementPeriodsPriceSchedule>();
                        ob.Add(new CommoditySettlementPeriodsPriceSchedule(item));
                        IDManager.SetID(settlementPeriodsPriceScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementPeriodsPriceScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    settlementPeriodsPriceSchedule.Add(new CommoditySettlementPeriodsPriceSchedule(item));
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
        
    
        #region FixedPriceStep
        private List<FixedPrice> fixedPriceStep;
        public List<FixedPrice> FixedPriceStep
        {
            get
            {
                if (this.fixedPriceStep != null)
                {
                    return this.fixedPriceStep; 
                }
                else if (this.fixedPriceStepIDRef != null)
                {
                    fixedPriceStep = IDManager.getID(fixedPriceStepIDRef) as List<FixedPrice>;
                    return this.fixedPriceStep; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedPriceStep != value)
                {
                    this.fixedPriceStep = value;
                }
            }
        }
        #endregion
        
        public string FixedPriceIDRef { get; set; }
        #region WorldscaleRateStep
        private XsdTypeDecimal worldscaleRateStep;
        public XsdTypeDecimal WorldscaleRateStep
        {
            get
            {
                if (this.worldscaleRateStep != null)
                {
                    return this.worldscaleRateStep; 
                }
                else if (this.worldscaleRateStepIDRef != null)
                {
                    worldscaleRateStep = IDManager.getID(worldscaleRateStepIDRef) as XsdTypeDecimal;
                    return this.worldscaleRateStep; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.worldscaleRateStep != value)
                {
                    this.worldscaleRateStep = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region ContractRateStep
        private List<NonNegativeMoney> contractRateStep;
        public List<NonNegativeMoney> ContractRateStep
        {
            get
            {
                if (this.contractRateStep != null)
                {
                    return this.contractRateStep; 
                }
                else if (this.contractRateStepIDRef != null)
                {
                    contractRateStep = IDManager.getID(contractRateStepIDRef) as List<NonNegativeMoney>;
                    return this.contractRateStep; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.contractRateStep != value)
                {
                    this.contractRateStep = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region SettlementPeriodsPriceSchedule
        private List<CommoditySettlementPeriodsPriceSchedule> settlementPeriodsPriceSchedule;
        public List<CommoditySettlementPeriodsPriceSchedule> SettlementPeriodsPriceSchedule
        {
            get
            {
                if (this.settlementPeriodsPriceSchedule != null)
                {
                    return this.settlementPeriodsPriceSchedule; 
                }
                else if (this.settlementPeriodsPriceScheduleIDRef != null)
                {
                    settlementPeriodsPriceSchedule = IDManager.getID(settlementPeriodsPriceScheduleIDRef) as List<CommoditySettlementPeriodsPriceSchedule>;
                    return this.settlementPeriodsPriceSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementPeriodsPriceSchedule != value)
                {
                    this.settlementPeriodsPriceSchedule = value;
                }
            }
        }
        #endregion
        
        public string CommoditySettlementPeriodsPriceScheduleIDRef { get; set; }
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

