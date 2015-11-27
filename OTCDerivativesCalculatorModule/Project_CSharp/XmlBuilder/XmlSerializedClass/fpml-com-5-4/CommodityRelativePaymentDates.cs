using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityRelativePaymentDates : ISerialized
    {
        public CommodityRelativePaymentDates(XmlNode xmlNode)
        {
            XmlNode payRelativeToNode = xmlNode.SelectSingleNode("payRelativeTo");
            
            if (payRelativeToNode != null)
            {
                if (payRelativeToNode.Attributes["href"] != null || payRelativeToNode.Attributes["id"] != null) 
                {
                    if (payRelativeToNode.Attributes["id"] != null) 
                    {
                        payRelativeToIDRef_ = payRelativeToNode.Attributes["id"].Value;
                        CommodityPayRelativeToEnum ob = new CommodityPayRelativeToEnum(payRelativeToNode);
                        IDManager.SetID(payRelativeToIDRef_, ob);
                    }
                    else if (payRelativeToNode.Attributes["href"] != null)
                    {
                        payRelativeToIDRef_ = payRelativeToNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payRelativeTo_ = new CommodityPayRelativeToEnum(payRelativeToNode);
                    }
                }
                else
                {
                    payRelativeTo_ = new CommodityPayRelativeToEnum(payRelativeToNode);
                }
            }
            
        
            XmlNode payRelativeToEventNode = xmlNode.SelectSingleNode("payRelativeToEvent");
            
            if (payRelativeToEventNode != null)
            {
                if (payRelativeToEventNode.Attributes["href"] != null || payRelativeToEventNode.Attributes["id"] != null) 
                {
                    if (payRelativeToEventNode.Attributes["id"] != null) 
                    {
                        payRelativeToEventIDRef_ = payRelativeToEventNode.Attributes["id"].Value;
                        CommodityPayRelativeToEvent ob = new CommodityPayRelativeToEvent(payRelativeToEventNode);
                        IDManager.SetID(payRelativeToEventIDRef_, ob);
                    }
                    else if (payRelativeToEventNode.Attributes["href"] != null)
                    {
                        payRelativeToEventIDRef_ = payRelativeToEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payRelativeToEvent_ = new CommodityPayRelativeToEvent(payRelativeToEventNode);
                    }
                }
                else
                {
                    payRelativeToEvent_ = new CommodityPayRelativeToEvent(payRelativeToEventNode);
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
            
        
            XmlNode paymentDaysOffsetNode = xmlNode.SelectSingleNode("paymentDaysOffset");
            
            if (paymentDaysOffsetNode != null)
            {
                if (paymentDaysOffsetNode.Attributes["href"] != null || paymentDaysOffsetNode.Attributes["id"] != null) 
                {
                    if (paymentDaysOffsetNode.Attributes["id"] != null) 
                    {
                        paymentDaysOffsetIDRef_ = paymentDaysOffsetNode.Attributes["id"].Value;
                        DateOffset ob = new DateOffset(paymentDaysOffsetNode);
                        IDManager.SetID(paymentDaysOffsetIDRef_, ob);
                    }
                    else if (paymentDaysOffsetNode.Attributes["href"] != null)
                    {
                        paymentDaysOffsetIDRef_ = paymentDaysOffsetNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDaysOffset_ = new DateOffset(paymentDaysOffsetNode);
                    }
                }
                else
                {
                    paymentDaysOffset_ = new DateOffset(paymentDaysOffsetNode);
                }
            }
            
        
            XmlNode businessCentersReferenceNode = xmlNode.SelectSingleNode("businessCentersReference");
            
            if (businessCentersReferenceNode != null)
            {
                if (businessCentersReferenceNode.Attributes["href"] != null || businessCentersReferenceNode.Attributes["id"] != null) 
                {
                    if (businessCentersReferenceNode.Attributes["id"] != null) 
                    {
                        businessCentersReferenceIDRef_ = businessCentersReferenceNode.Attributes["id"].Value;
                        BusinessCentersReference ob = new BusinessCentersReference(businessCentersReferenceNode);
                        IDManager.SetID(businessCentersReferenceIDRef_, ob);
                    }
                    else if (businessCentersReferenceNode.Attributes["href"] != null)
                    {
                        businessCentersReferenceIDRef_ = businessCentersReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessCentersReference_ = new BusinessCentersReference(businessCentersReferenceNode);
                    }
                }
                else
                {
                    businessCentersReference_ = new BusinessCentersReference(businessCentersReferenceNode);
                }
            }
            
        
            XmlNode businessCentersNode = xmlNode.SelectSingleNode("businessCenters");
            
            if (businessCentersNode != null)
            {
                if (businessCentersNode.Attributes["href"] != null || businessCentersNode.Attributes["id"] != null) 
                {
                    if (businessCentersNode.Attributes["id"] != null) 
                    {
                        businessCentersIDRef_ = businessCentersNode.Attributes["id"].Value;
                        BusinessCenters ob = new BusinessCenters(businessCentersNode);
                        IDManager.SetID(businessCentersIDRef_, ob);
                    }
                    else if (businessCentersNode.Attributes["href"] != null)
                    {
                        businessCentersIDRef_ = businessCentersNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessCenters_ = new BusinessCenters(businessCentersNode);
                    }
                }
                else
                {
                    businessCenters_ = new BusinessCenters(businessCentersNode);
                }
            }
            
        
        }
        
    
        #region PayRelativeTo_
        private CommodityPayRelativeToEnum payRelativeTo_;
        public CommodityPayRelativeToEnum PayRelativeTo_
        {
            get
            {
                if (this.payRelativeTo_ != null)
                {
                    return this.payRelativeTo_; 
                }
                else if (this.payRelativeToIDRef_ != null)
                {
                    payRelativeTo_ = IDManager.getID(payRelativeToIDRef_) as CommodityPayRelativeToEnum;
                    return this.payRelativeTo_; 
                }
                else
                {
                      return this.payRelativeTo_; 
                }
            }
            set
            {
                if (this.payRelativeTo_ != value)
                {
                    this.payRelativeTo_ = value;
                }
            }
        }
        #endregion
        
        public string payRelativeToIDRef_ { get; set; }
        #region PayRelativeToEvent_
        private CommodityPayRelativeToEvent payRelativeToEvent_;
        public CommodityPayRelativeToEvent PayRelativeToEvent_
        {
            get
            {
                if (this.payRelativeToEvent_ != null)
                {
                    return this.payRelativeToEvent_; 
                }
                else if (this.payRelativeToEventIDRef_ != null)
                {
                    payRelativeToEvent_ = IDManager.getID(payRelativeToEventIDRef_) as CommodityPayRelativeToEvent;
                    return this.payRelativeToEvent_; 
                }
                else
                {
                      return this.payRelativeToEvent_; 
                }
            }
            set
            {
                if (this.payRelativeToEvent_ != value)
                {
                    this.payRelativeToEvent_ = value;
                }
            }
        }
        #endregion
        
        public string payRelativeToEventIDRef_ { get; set; }
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
        #region PaymentDaysOffset_
        private DateOffset paymentDaysOffset_;
        public DateOffset PaymentDaysOffset_
        {
            get
            {
                if (this.paymentDaysOffset_ != null)
                {
                    return this.paymentDaysOffset_; 
                }
                else if (this.paymentDaysOffsetIDRef_ != null)
                {
                    paymentDaysOffset_ = IDManager.getID(paymentDaysOffsetIDRef_) as DateOffset;
                    return this.paymentDaysOffset_; 
                }
                else
                {
                      return this.paymentDaysOffset_; 
                }
            }
            set
            {
                if (this.paymentDaysOffset_ != value)
                {
                    this.paymentDaysOffset_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDaysOffsetIDRef_ { get; set; }
        #region BusinessCentersReference_
        private BusinessCentersReference businessCentersReference_;
        public BusinessCentersReference BusinessCentersReference_
        {
            get
            {
                if (this.businessCentersReference_ != null)
                {
                    return this.businessCentersReference_; 
                }
                else if (this.businessCentersReferenceIDRef_ != null)
                {
                    businessCentersReference_ = IDManager.getID(businessCentersReferenceIDRef_) as BusinessCentersReference;
                    return this.businessCentersReference_; 
                }
                else
                {
                      return this.businessCentersReference_; 
                }
            }
            set
            {
                if (this.businessCentersReference_ != value)
                {
                    this.businessCentersReference_ = value;
                }
            }
        }
        #endregion
        
        public string businessCentersReferenceIDRef_ { get; set; }
        #region BusinessCenters_
        private BusinessCenters businessCenters_;
        public BusinessCenters BusinessCenters_
        {
            get
            {
                if (this.businessCenters_ != null)
                {
                    return this.businessCenters_; 
                }
                else if (this.businessCentersIDRef_ != null)
                {
                    businessCenters_ = IDManager.getID(businessCentersIDRef_) as BusinessCenters;
                    return this.businessCenters_; 
                }
                else
                {
                      return this.businessCenters_; 
                }
            }
            set
            {
                if (this.businessCenters_ != value)
                {
                    this.businessCenters_ = value;
                }
            }
        }
        #endregion
        
        public string businessCentersIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        
    
        
    
    }
    
}

