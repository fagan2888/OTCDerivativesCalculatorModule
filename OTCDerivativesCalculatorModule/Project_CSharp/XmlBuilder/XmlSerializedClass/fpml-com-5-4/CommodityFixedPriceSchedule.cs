using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityFixedPriceSchedule : ISerialized
    {
        public CommodityFixedPriceSchedule(XmlNode xmlNode)
        {
            XmlNodeList fixedPriceStepNodeList = xmlNode.SelectNodes("fixedPriceStep");
            
            if (fixedPriceStepNodeList != null)
            {
                this.fixedPriceStep_ = new List<FixedPrice>();
                foreach (XmlNode item in fixedPriceStepNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            fixedPriceStepIDRef_ = item.Attributes["id"].Value;
                            fixedPriceStep_.Add(new FixedPrice(item));
                            IDManager.SetID(fixedPriceStepIDRef_, fixedPriceStep_[fixedPriceStep_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            fixedPriceStepIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        fixedPriceStep_.Add(new FixedPrice(item));
                        }
                    }
                    else
                    {
                        fixedPriceStep_.Add(new FixedPrice(item));
                    }
                }
            }
            
        
            XmlNodeList worldscaleRateStepNodeList = xmlNode.SelectNodes("worldscaleRateStep");
            
            if (worldscaleRateStepNodeList != null)
            {
                this.worldscaleRateStep_ = new List<XsdTypeDecimal>();
                foreach (XmlNode item in worldscaleRateStepNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            worldscaleRateStepIDRef_ = item.Attributes["id"].Value;
                            worldscaleRateStep_.Add(new XsdTypeDecimal(item));
                            IDManager.SetID(worldscaleRateStepIDRef_, worldscaleRateStep_[worldscaleRateStep_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            worldscaleRateStepIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        worldscaleRateStep_.Add(new XsdTypeDecimal(item));
                        }
                    }
                    else
                    {
                        worldscaleRateStep_.Add(new XsdTypeDecimal(item));
                    }
                }
            }
            
        
            XmlNodeList contractRateStepNodeList = xmlNode.SelectNodes("contractRateStep");
            
            if (contractRateStepNodeList != null)
            {
                this.contractRateStep_ = new List<NonNegativeMoney>();
                foreach (XmlNode item in contractRateStepNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            contractRateStepIDRef_ = item.Attributes["id"].Value;
                            contractRateStep_.Add(new NonNegativeMoney(item));
                            IDManager.SetID(contractRateStepIDRef_, contractRateStep_[contractRateStep_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            contractRateStepIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        contractRateStep_.Add(new NonNegativeMoney(item));
                        }
                    }
                    else
                    {
                        contractRateStep_.Add(new NonNegativeMoney(item));
                    }
                }
            }
            
        
            XmlNodeList settlementPeriodsPriceScheduleNodeList = xmlNode.SelectNodes("settlementPeriodsPriceSchedule");
            
            if (settlementPeriodsPriceScheduleNodeList != null)
            {
                this.settlementPeriodsPriceSchedule_ = new List<CommoditySettlementPeriodsPriceSchedule>();
                foreach (XmlNode item in settlementPeriodsPriceScheduleNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            settlementPeriodsPriceScheduleIDRef_ = item.Attributes["id"].Value;
                            settlementPeriodsPriceSchedule_.Add(new CommoditySettlementPeriodsPriceSchedule(item));
                            IDManager.SetID(settlementPeriodsPriceScheduleIDRef_, settlementPeriodsPriceSchedule_[settlementPeriodsPriceSchedule_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            settlementPeriodsPriceScheduleIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        settlementPeriodsPriceSchedule_.Add(new CommoditySettlementPeriodsPriceSchedule(item));
                        }
                    }
                    else
                    {
                        settlementPeriodsPriceSchedule_.Add(new CommoditySettlementPeriodsPriceSchedule(item));
                    }
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
        
    
        #region FixedPriceStep_
        private List<FixedPrice> fixedPriceStep_;
        public List<FixedPrice> FixedPriceStep_
        {
            get
            {
                if (this.fixedPriceStep_ != null)
                {
                    return this.fixedPriceStep_; 
                }
                else if (this.fixedPriceStepIDRef_ != null)
                {
                    return this.fixedPriceStep_; 
                }
                else
                {
                      return this.fixedPriceStep_; 
                }
            }
            set
            {
                if (this.fixedPriceStep_ != value)
                {
                    this.fixedPriceStep_ = value;
                }
            }
        }
        #endregion
        
        public string fixedPriceStepIDRef_ { get; set; }
        #region WorldscaleRateStep_
        private List<XsdTypeDecimal> worldscaleRateStep_;
        public List<XsdTypeDecimal> WorldscaleRateStep_
        {
            get
            {
                if (this.worldscaleRateStep_ != null)
                {
                    return this.worldscaleRateStep_; 
                }
                else if (this.worldscaleRateStepIDRef_ != null)
                {
                    return this.worldscaleRateStep_; 
                }
                else
                {
                      return this.worldscaleRateStep_; 
                }
            }
            set
            {
                if (this.worldscaleRateStep_ != value)
                {
                    this.worldscaleRateStep_ = value;
                }
            }
        }
        #endregion
        
        public string worldscaleRateStepIDRef_ { get; set; }
        #region ContractRateStep_
        private List<NonNegativeMoney> contractRateStep_;
        public List<NonNegativeMoney> ContractRateStep_
        {
            get
            {
                if (this.contractRateStep_ != null)
                {
                    return this.contractRateStep_; 
                }
                else if (this.contractRateStepIDRef_ != null)
                {
                    return this.contractRateStep_; 
                }
                else
                {
                      return this.contractRateStep_; 
                }
            }
            set
            {
                if (this.contractRateStep_ != value)
                {
                    this.contractRateStep_ = value;
                }
            }
        }
        #endregion
        
        public string contractRateStepIDRef_ { get; set; }
        #region SettlementPeriodsPriceSchedule_
        private List<CommoditySettlementPeriodsPriceSchedule> settlementPeriodsPriceSchedule_;
        public List<CommoditySettlementPeriodsPriceSchedule> SettlementPeriodsPriceSchedule_
        {
            get
            {
                if (this.settlementPeriodsPriceSchedule_ != null)
                {
                    return this.settlementPeriodsPriceSchedule_; 
                }
                else if (this.settlementPeriodsPriceScheduleIDRef_ != null)
                {
                    return this.settlementPeriodsPriceSchedule_; 
                }
                else
                {
                      return this.settlementPeriodsPriceSchedule_; 
                }
            }
            set
            {
                if (this.settlementPeriodsPriceSchedule_ != value)
                {
                    this.settlementPeriodsPriceSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string settlementPeriodsPriceScheduleIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

