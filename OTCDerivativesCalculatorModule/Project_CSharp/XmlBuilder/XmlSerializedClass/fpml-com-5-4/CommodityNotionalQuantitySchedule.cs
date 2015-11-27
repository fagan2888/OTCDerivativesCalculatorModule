using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityNotionalQuantitySchedule : ISerialized
    {
        public CommodityNotionalQuantitySchedule(XmlNode xmlNode)
        {
            XmlNodeList notionalStepNodeList = xmlNode.SelectNodes("notionalStep");
            
            if (notionalStepNodeList != null)
            {
                this.notionalStep_ = new List<CommodityNotionalQuantity>();
                foreach (XmlNode item in notionalStepNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            notionalStepIDRef_ = item.Attributes["id"].Value;
                            notionalStep_.Add(new CommodityNotionalQuantity(item));
                            IDManager.SetID(notionalStepIDRef_, notionalStep_[notionalStep_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            notionalStepIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        notionalStep_.Add(new CommodityNotionalQuantity(item));
                        }
                    }
                    else
                    {
                        notionalStep_.Add(new CommodityNotionalQuantity(item));
                    }
                }
            }
            
        
            XmlNodeList settlementPeriodsNotionalQuantityScheduleNodeList = xmlNode.SelectNodes("settlementPeriodsNotionalQuantitySchedule");
            
            if (settlementPeriodsNotionalQuantityScheduleNodeList != null)
            {
                this.settlementPeriodsNotionalQuantitySchedule_ = new List<CommoditySettlementPeriodsNotionalQuantitySchedule>();
                foreach (XmlNode item in settlementPeriodsNotionalQuantityScheduleNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            settlementPeriodsNotionalQuantityScheduleIDRef_ = item.Attributes["id"].Value;
                            settlementPeriodsNotionalQuantitySchedule_.Add(new CommoditySettlementPeriodsNotionalQuantitySchedule(item));
                            IDManager.SetID(settlementPeriodsNotionalQuantityScheduleIDRef_, settlementPeriodsNotionalQuantitySchedule_[settlementPeriodsNotionalQuantitySchedule_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            settlementPeriodsNotionalQuantityScheduleIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        settlementPeriodsNotionalQuantitySchedule_.Add(new CommoditySettlementPeriodsNotionalQuantitySchedule(item));
                        }
                    }
                    else
                    {
                        settlementPeriodsNotionalQuantitySchedule_.Add(new CommoditySettlementPeriodsNotionalQuantitySchedule(item));
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
        
    
        #region NotionalStep_
        private List<CommodityNotionalQuantity> notionalStep_;
        public List<CommodityNotionalQuantity> NotionalStep_
        {
            get
            {
                if (this.notionalStep_ != null)
                {
                    return this.notionalStep_; 
                }
                else if (this.notionalStepIDRef_ != null)
                {
                    return this.notionalStep_; 
                }
                else
                {
                      return this.notionalStep_; 
                }
            }
            set
            {
                if (this.notionalStep_ != value)
                {
                    this.notionalStep_ = value;
                }
            }
        }
        #endregion
        
        public string notionalStepIDRef_ { get; set; }
        #region SettlementPeriodsNotionalQuantitySchedule_
        private List<CommoditySettlementPeriodsNotionalQuantitySchedule> settlementPeriodsNotionalQuantitySchedule_;
        public List<CommoditySettlementPeriodsNotionalQuantitySchedule> SettlementPeriodsNotionalQuantitySchedule_
        {
            get
            {
                if (this.settlementPeriodsNotionalQuantitySchedule_ != null)
                {
                    return this.settlementPeriodsNotionalQuantitySchedule_; 
                }
                else if (this.settlementPeriodsNotionalQuantityScheduleIDRef_ != null)
                {
                    return this.settlementPeriodsNotionalQuantitySchedule_; 
                }
                else
                {
                      return this.settlementPeriodsNotionalQuantitySchedule_; 
                }
            }
            set
            {
                if (this.settlementPeriodsNotionalQuantitySchedule_ != value)
                {
                    this.settlementPeriodsNotionalQuantitySchedule_ = value;
                }
            }
        }
        #endregion
        
        public string settlementPeriodsNotionalQuantityScheduleIDRef_ { get; set; }
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

