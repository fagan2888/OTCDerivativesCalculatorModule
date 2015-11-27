using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PaymentDates : ISerialized
    {
        public PaymentDates(XmlNode xmlNode)
        {
            XmlNode calculationPeriodDatesReferenceNode = xmlNode.SelectSingleNode("calculationPeriodDatesReference");
            
            if (calculationPeriodDatesReferenceNode != null)
            {
                if (calculationPeriodDatesReferenceNode.Attributes["href"] != null || calculationPeriodDatesReferenceNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodDatesReferenceNode.Attributes["id"] != null) 
                    {
                        calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode.Attributes["id"].Value;
                        CalculationPeriodDatesReference ob = new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode);
                        IDManager.SetID(calculationPeriodDatesReferenceIDRef_, ob);
                    }
                    else if (calculationPeriodDatesReferenceNode.Attributes["href"] != null)
                    {
                        calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodDatesReference_ = new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode);
                    }
                }
                else
                {
                    calculationPeriodDatesReference_ = new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode);
                }
            }
            
        
            XmlNode resetDatesReferenceNode = xmlNode.SelectSingleNode("resetDatesReference");
            
            if (resetDatesReferenceNode != null)
            {
                if (resetDatesReferenceNode.Attributes["href"] != null || resetDatesReferenceNode.Attributes["id"] != null) 
                {
                    if (resetDatesReferenceNode.Attributes["id"] != null) 
                    {
                        resetDatesReferenceIDRef_ = resetDatesReferenceNode.Attributes["id"].Value;
                        ResetDatesReference ob = new ResetDatesReference(resetDatesReferenceNode);
                        IDManager.SetID(resetDatesReferenceIDRef_, ob);
                    }
                    else if (resetDatesReferenceNode.Attributes["href"] != null)
                    {
                        resetDatesReferenceIDRef_ = resetDatesReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        resetDatesReference_ = new ResetDatesReference(resetDatesReferenceNode);
                    }
                }
                else
                {
                    resetDatesReference_ = new ResetDatesReference(resetDatesReferenceNode);
                }
            }
            
        
            XmlNode valuationDatesReferenceNode = xmlNode.SelectSingleNode("valuationDatesReference");
            
            if (valuationDatesReferenceNode != null)
            {
                if (valuationDatesReferenceNode.Attributes["href"] != null || valuationDatesReferenceNode.Attributes["id"] != null) 
                {
                    if (valuationDatesReferenceNode.Attributes["id"] != null) 
                    {
                        valuationDatesReferenceIDRef_ = valuationDatesReferenceNode.Attributes["id"].Value;
                        ValuationDatesReference ob = new ValuationDatesReference(valuationDatesReferenceNode);
                        IDManager.SetID(valuationDatesReferenceIDRef_, ob);
                    }
                    else if (valuationDatesReferenceNode.Attributes["href"] != null)
                    {
                        valuationDatesReferenceIDRef_ = valuationDatesReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationDatesReference_ = new ValuationDatesReference(valuationDatesReferenceNode);
                    }
                }
                else
                {
                    valuationDatesReference_ = new ValuationDatesReference(valuationDatesReferenceNode);
                }
            }
            
        
            XmlNode paymentFrequencyNode = xmlNode.SelectSingleNode("paymentFrequency");
            
            if (paymentFrequencyNode != null)
            {
                if (paymentFrequencyNode.Attributes["href"] != null || paymentFrequencyNode.Attributes["id"] != null) 
                {
                    if (paymentFrequencyNode.Attributes["id"] != null) 
                    {
                        paymentFrequencyIDRef_ = paymentFrequencyNode.Attributes["id"].Value;
                        Frequency ob = new Frequency(paymentFrequencyNode);
                        IDManager.SetID(paymentFrequencyIDRef_, ob);
                    }
                    else if (paymentFrequencyNode.Attributes["href"] != null)
                    {
                        paymentFrequencyIDRef_ = paymentFrequencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentFrequency_ = new Frequency(paymentFrequencyNode);
                    }
                }
                else
                {
                    paymentFrequency_ = new Frequency(paymentFrequencyNode);
                }
            }
            
        
            XmlNode firstPaymentDateNode = xmlNode.SelectSingleNode("firstPaymentDate");
            
            if (firstPaymentDateNode != null)
            {
                if (firstPaymentDateNode.Attributes["href"] != null || firstPaymentDateNode.Attributes["id"] != null) 
                {
                    if (firstPaymentDateNode.Attributes["id"] != null) 
                    {
                        firstPaymentDateIDRef_ = firstPaymentDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(firstPaymentDateNode);
                        IDManager.SetID(firstPaymentDateIDRef_, ob);
                    }
                    else if (firstPaymentDateNode.Attributes["href"] != null)
                    {
                        firstPaymentDateIDRef_ = firstPaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        firstPaymentDate_ = new XsdTypeDate(firstPaymentDateNode);
                    }
                }
                else
                {
                    firstPaymentDate_ = new XsdTypeDate(firstPaymentDateNode);
                }
            }
            
        
            XmlNode lastRegularPaymentDateNode = xmlNode.SelectSingleNode("lastRegularPaymentDate");
            
            if (lastRegularPaymentDateNode != null)
            {
                if (lastRegularPaymentDateNode.Attributes["href"] != null || lastRegularPaymentDateNode.Attributes["id"] != null) 
                {
                    if (lastRegularPaymentDateNode.Attributes["id"] != null) 
                    {
                        lastRegularPaymentDateIDRef_ = lastRegularPaymentDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(lastRegularPaymentDateNode);
                        IDManager.SetID(lastRegularPaymentDateIDRef_, ob);
                    }
                    else if (lastRegularPaymentDateNode.Attributes["href"] != null)
                    {
                        lastRegularPaymentDateIDRef_ = lastRegularPaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lastRegularPaymentDate_ = new XsdTypeDate(lastRegularPaymentDateNode);
                    }
                }
                else
                {
                    lastRegularPaymentDate_ = new XsdTypeDate(lastRegularPaymentDateNode);
                }
            }
            
        
            XmlNode payRelativeToNode = xmlNode.SelectSingleNode("payRelativeTo");
            
            if (payRelativeToNode != null)
            {
                if (payRelativeToNode.Attributes["href"] != null || payRelativeToNode.Attributes["id"] != null) 
                {
                    if (payRelativeToNode.Attributes["id"] != null) 
                    {
                        payRelativeToIDRef_ = payRelativeToNode.Attributes["id"].Value;
                        PayRelativeToEnum ob = new PayRelativeToEnum(payRelativeToNode);
                        IDManager.SetID(payRelativeToIDRef_, ob);
                    }
                    else if (payRelativeToNode.Attributes["href"] != null)
                    {
                        payRelativeToIDRef_ = payRelativeToNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payRelativeTo_ = new PayRelativeToEnum(payRelativeToNode);
                    }
                }
                else
                {
                    payRelativeTo_ = new PayRelativeToEnum(payRelativeToNode);
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
                        Offset ob = new Offset(paymentDaysOffsetNode);
                        IDManager.SetID(paymentDaysOffsetIDRef_, ob);
                    }
                    else if (paymentDaysOffsetNode.Attributes["href"] != null)
                    {
                        paymentDaysOffsetIDRef_ = paymentDaysOffsetNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDaysOffset_ = new Offset(paymentDaysOffsetNode);
                    }
                }
                else
                {
                    paymentDaysOffset_ = new Offset(paymentDaysOffsetNode);
                }
            }
            
        
            XmlNode paymentDatesAdjustmentsNode = xmlNode.SelectSingleNode("paymentDatesAdjustments");
            
            if (paymentDatesAdjustmentsNode != null)
            {
                if (paymentDatesAdjustmentsNode.Attributes["href"] != null || paymentDatesAdjustmentsNode.Attributes["id"] != null) 
                {
                    if (paymentDatesAdjustmentsNode.Attributes["id"] != null) 
                    {
                        paymentDatesAdjustmentsIDRef_ = paymentDatesAdjustmentsNode.Attributes["id"].Value;
                        BusinessDayAdjustments ob = new BusinessDayAdjustments(paymentDatesAdjustmentsNode);
                        IDManager.SetID(paymentDatesAdjustmentsIDRef_, ob);
                    }
                    else if (paymentDatesAdjustmentsNode.Attributes["href"] != null)
                    {
                        paymentDatesAdjustmentsIDRef_ = paymentDatesAdjustmentsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDatesAdjustments_ = new BusinessDayAdjustments(paymentDatesAdjustmentsNode);
                    }
                }
                else
                {
                    paymentDatesAdjustments_ = new BusinessDayAdjustments(paymentDatesAdjustmentsNode);
                }
            }
            
        
        }
        
    
        #region CalculationPeriodDatesReference_
        private CalculationPeriodDatesReference calculationPeriodDatesReference_;
        public CalculationPeriodDatesReference CalculationPeriodDatesReference_
        {
            get
            {
                if (this.calculationPeriodDatesReference_ != null)
                {
                    return this.calculationPeriodDatesReference_; 
                }
                else if (this.calculationPeriodDatesReferenceIDRef_ != null)
                {
                    calculationPeriodDatesReference_ = IDManager.getID(calculationPeriodDatesReferenceIDRef_) as CalculationPeriodDatesReference;
                    return this.calculationPeriodDatesReference_; 
                }
                else
                {
                      return this.calculationPeriodDatesReference_; 
                }
            }
            set
            {
                if (this.calculationPeriodDatesReference_ != value)
                {
                    this.calculationPeriodDatesReference_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodDatesReferenceIDRef_ { get; set; }
        #region ResetDatesReference_
        private ResetDatesReference resetDatesReference_;
        public ResetDatesReference ResetDatesReference_
        {
            get
            {
                if (this.resetDatesReference_ != null)
                {
                    return this.resetDatesReference_; 
                }
                else if (this.resetDatesReferenceIDRef_ != null)
                {
                    resetDatesReference_ = IDManager.getID(resetDatesReferenceIDRef_) as ResetDatesReference;
                    return this.resetDatesReference_; 
                }
                else
                {
                      return this.resetDatesReference_; 
                }
            }
            set
            {
                if (this.resetDatesReference_ != value)
                {
                    this.resetDatesReference_ = value;
                }
            }
        }
        #endregion
        
        public string resetDatesReferenceIDRef_ { get; set; }
        #region ValuationDatesReference_
        private ValuationDatesReference valuationDatesReference_;
        public ValuationDatesReference ValuationDatesReference_
        {
            get
            {
                if (this.valuationDatesReference_ != null)
                {
                    return this.valuationDatesReference_; 
                }
                else if (this.valuationDatesReferenceIDRef_ != null)
                {
                    valuationDatesReference_ = IDManager.getID(valuationDatesReferenceIDRef_) as ValuationDatesReference;
                    return this.valuationDatesReference_; 
                }
                else
                {
                      return this.valuationDatesReference_; 
                }
            }
            set
            {
                if (this.valuationDatesReference_ != value)
                {
                    this.valuationDatesReference_ = value;
                }
            }
        }
        #endregion
        
        public string valuationDatesReferenceIDRef_ { get; set; }
        #region PaymentFrequency_
        private Frequency paymentFrequency_;
        public Frequency PaymentFrequency_
        {
            get
            {
                if (this.paymentFrequency_ != null)
                {
                    return this.paymentFrequency_; 
                }
                else if (this.paymentFrequencyIDRef_ != null)
                {
                    paymentFrequency_ = IDManager.getID(paymentFrequencyIDRef_) as Frequency;
                    return this.paymentFrequency_; 
                }
                else
                {
                      return this.paymentFrequency_; 
                }
            }
            set
            {
                if (this.paymentFrequency_ != value)
                {
                    this.paymentFrequency_ = value;
                }
            }
        }
        #endregion
        
        public string paymentFrequencyIDRef_ { get; set; }
        #region FirstPaymentDate_
        private XsdTypeDate firstPaymentDate_;
        public XsdTypeDate FirstPaymentDate_
        {
            get
            {
                if (this.firstPaymentDate_ != null)
                {
                    return this.firstPaymentDate_; 
                }
                else if (this.firstPaymentDateIDRef_ != null)
                {
                    firstPaymentDate_ = IDManager.getID(firstPaymentDateIDRef_) as XsdTypeDate;
                    return this.firstPaymentDate_; 
                }
                else
                {
                      return this.firstPaymentDate_; 
                }
            }
            set
            {
                if (this.firstPaymentDate_ != value)
                {
                    this.firstPaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string firstPaymentDateIDRef_ { get; set; }
        #region LastRegularPaymentDate_
        private XsdTypeDate lastRegularPaymentDate_;
        public XsdTypeDate LastRegularPaymentDate_
        {
            get
            {
                if (this.lastRegularPaymentDate_ != null)
                {
                    return this.lastRegularPaymentDate_; 
                }
                else if (this.lastRegularPaymentDateIDRef_ != null)
                {
                    lastRegularPaymentDate_ = IDManager.getID(lastRegularPaymentDateIDRef_) as XsdTypeDate;
                    return this.lastRegularPaymentDate_; 
                }
                else
                {
                      return this.lastRegularPaymentDate_; 
                }
            }
            set
            {
                if (this.lastRegularPaymentDate_ != value)
                {
                    this.lastRegularPaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string lastRegularPaymentDateIDRef_ { get; set; }
        #region PayRelativeTo_
        private PayRelativeToEnum payRelativeTo_;
        public PayRelativeToEnum PayRelativeTo_
        {
            get
            {
                if (this.payRelativeTo_ != null)
                {
                    return this.payRelativeTo_; 
                }
                else if (this.payRelativeToIDRef_ != null)
                {
                    payRelativeTo_ = IDManager.getID(payRelativeToIDRef_) as PayRelativeToEnum;
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
        #region PaymentDaysOffset_
        private Offset paymentDaysOffset_;
        public Offset PaymentDaysOffset_
        {
            get
            {
                if (this.paymentDaysOffset_ != null)
                {
                    return this.paymentDaysOffset_; 
                }
                else if (this.paymentDaysOffsetIDRef_ != null)
                {
                    paymentDaysOffset_ = IDManager.getID(paymentDaysOffsetIDRef_) as Offset;
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
        #region PaymentDatesAdjustments_
        private BusinessDayAdjustments paymentDatesAdjustments_;
        public BusinessDayAdjustments PaymentDatesAdjustments_
        {
            get
            {
                if (this.paymentDatesAdjustments_ != null)
                {
                    return this.paymentDatesAdjustments_; 
                }
                else if (this.paymentDatesAdjustmentsIDRef_ != null)
                {
                    paymentDatesAdjustments_ = IDManager.getID(paymentDatesAdjustmentsIDRef_) as BusinessDayAdjustments;
                    return this.paymentDatesAdjustments_; 
                }
                else
                {
                      return this.paymentDatesAdjustments_; 
                }
            }
            set
            {
                if (this.paymentDatesAdjustments_ != value)
                {
                    this.paymentDatesAdjustments_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDatesAdjustmentsIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

