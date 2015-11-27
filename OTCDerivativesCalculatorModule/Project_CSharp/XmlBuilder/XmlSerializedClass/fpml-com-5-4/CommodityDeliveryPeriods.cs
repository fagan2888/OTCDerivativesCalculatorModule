using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityDeliveryPeriods : ISerialized
    {
        public CommodityDeliveryPeriods(XmlNode xmlNode)
        {
            XmlNode periodsNode = xmlNode.SelectSingleNode("periods");
            
            if (periodsNode != null)
            {
                if (periodsNode.Attributes["href"] != null || periodsNode.Attributes["id"] != null) 
                {
                    if (periodsNode.Attributes["id"] != null) 
                    {
                        periodsIDRef_ = periodsNode.Attributes["id"].Value;
                        AdjustableDates ob = new AdjustableDates(periodsNode);
                        IDManager.SetID(periodsIDRef_, ob);
                    }
                    else if (periodsNode.Attributes["href"] != null)
                    {
                        periodsIDRef_ = periodsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        periods_ = new AdjustableDates(periodsNode);
                    }
                }
                else
                {
                    periods_ = new AdjustableDates(periodsNode);
                }
            }
            
        
            XmlNode periodsScheduleNode = xmlNode.SelectSingleNode("periodsSchedule");
            
            if (periodsScheduleNode != null)
            {
                if (periodsScheduleNode.Attributes["href"] != null || periodsScheduleNode.Attributes["id"] != null) 
                {
                    if (periodsScheduleNode.Attributes["id"] != null) 
                    {
                        periodsScheduleIDRef_ = periodsScheduleNode.Attributes["id"].Value;
                        CommodityCalculationPeriodsSchedule ob = new CommodityCalculationPeriodsSchedule(periodsScheduleNode);
                        IDManager.SetID(periodsScheduleIDRef_, ob);
                    }
                    else if (periodsScheduleNode.Attributes["href"] != null)
                    {
                        periodsScheduleIDRef_ = periodsScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        periodsSchedule_ = new CommodityCalculationPeriodsSchedule(periodsScheduleNode);
                    }
                }
                else
                {
                    periodsSchedule_ = new CommodityCalculationPeriodsSchedule(periodsScheduleNode);
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
        
    
        #region Periods_
        private AdjustableDates periods_;
        public AdjustableDates Periods_
        {
            get
            {
                if (this.periods_ != null)
                {
                    return this.periods_; 
                }
                else if (this.periodsIDRef_ != null)
                {
                    periods_ = IDManager.getID(periodsIDRef_) as AdjustableDates;
                    return this.periods_; 
                }
                else
                {
                      return this.periods_; 
                }
            }
            set
            {
                if (this.periods_ != value)
                {
                    this.periods_ = value;
                }
            }
        }
        #endregion
        
        public string periodsIDRef_ { get; set; }
        #region PeriodsSchedule_
        private CommodityCalculationPeriodsSchedule periodsSchedule_;
        public CommodityCalculationPeriodsSchedule PeriodsSchedule_
        {
            get
            {
                if (this.periodsSchedule_ != null)
                {
                    return this.periodsSchedule_; 
                }
                else if (this.periodsScheduleIDRef_ != null)
                {
                    periodsSchedule_ = IDManager.getID(periodsScheduleIDRef_) as CommodityCalculationPeriodsSchedule;
                    return this.periodsSchedule_; 
                }
                else
                {
                      return this.periodsSchedule_; 
                }
            }
            set
            {
                if (this.periodsSchedule_ != value)
                {
                    this.periodsSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string periodsScheduleIDRef_ { get; set; }
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

