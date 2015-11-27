using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AveragePriceLeg : CommoditySwapLeg
    {
        public AveragePriceLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode payerPartyReferenceNode = xmlNode.SelectSingleNode("payerPartyReference");
            
            if (payerPartyReferenceNode != null)
            {
                if (payerPartyReferenceNode.Attributes["href"] != null || payerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (payerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        payerPartyReferenceIDRef_ = payerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(payerPartyReferenceNode);
                        IDManager.SetID(payerPartyReferenceIDRef_, ob);
                    }
                    else if (payerPartyReferenceNode.Attributes["href"] != null)
                    {
                        payerPartyReferenceIDRef_ = payerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payerPartyReference_ = new PartyReference(payerPartyReferenceNode);
                    }
                }
                else
                {
                    payerPartyReference_ = new PartyReference(payerPartyReferenceNode);
                }
            }
            
        
            XmlNode payerAccountReferenceNode = xmlNode.SelectSingleNode("payerAccountReference");
            
            if (payerAccountReferenceNode != null)
            {
                if (payerAccountReferenceNode.Attributes["href"] != null || payerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (payerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        payerAccountReferenceIDRef_ = payerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(payerAccountReferenceNode);
                        IDManager.SetID(payerAccountReferenceIDRef_, ob);
                    }
                    else if (payerAccountReferenceNode.Attributes["href"] != null)
                    {
                        payerAccountReferenceIDRef_ = payerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payerAccountReference_ = new AccountReference(payerAccountReferenceNode);
                    }
                }
                else
                {
                    payerAccountReference_ = new AccountReference(payerAccountReferenceNode);
                }
            }
            
        
            XmlNode receiverPartyReferenceNode = xmlNode.SelectSingleNode("receiverPartyReference");
            
            if (receiverPartyReferenceNode != null)
            {
                if (receiverPartyReferenceNode.Attributes["href"] != null || receiverPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (receiverPartyReferenceNode.Attributes["id"] != null) 
                    {
                        receiverPartyReferenceIDRef_ = receiverPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(receiverPartyReferenceNode);
                        IDManager.SetID(receiverPartyReferenceIDRef_, ob);
                    }
                    else if (receiverPartyReferenceNode.Attributes["href"] != null)
                    {
                        receiverPartyReferenceIDRef_ = receiverPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        receiverPartyReference_ = new PartyReference(receiverPartyReferenceNode);
                    }
                }
                else
                {
                    receiverPartyReference_ = new PartyReference(receiverPartyReferenceNode);
                }
            }
            
        
            XmlNode receiverAccountReferenceNode = xmlNode.SelectSingleNode("receiverAccountReference");
            
            if (receiverAccountReferenceNode != null)
            {
                if (receiverAccountReferenceNode.Attributes["href"] != null || receiverAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (receiverAccountReferenceNode.Attributes["id"] != null) 
                    {
                        receiverAccountReferenceIDRef_ = receiverAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(receiverAccountReferenceNode);
                        IDManager.SetID(receiverAccountReferenceIDRef_, ob);
                    }
                    else if (receiverAccountReferenceNode.Attributes["href"] != null)
                    {
                        receiverAccountReferenceIDRef_ = receiverAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        receiverAccountReference_ = new AccountReference(receiverAccountReferenceNode);
                    }
                }
                else
                {
                    receiverAccountReference_ = new AccountReference(receiverAccountReferenceNode);
                }
            }
            
        
            XmlNode calculationDatesNode = xmlNode.SelectSingleNode("calculationDates");
            
            if (calculationDatesNode != null)
            {
                if (calculationDatesNode.Attributes["href"] != null || calculationDatesNode.Attributes["id"] != null) 
                {
                    if (calculationDatesNode.Attributes["id"] != null) 
                    {
                        calculationDatesIDRef_ = calculationDatesNode.Attributes["id"].Value;
                        AdjustableDates ob = new AdjustableDates(calculationDatesNode);
                        IDManager.SetID(calculationDatesIDRef_, ob);
                    }
                    else if (calculationDatesNode.Attributes["href"] != null)
                    {
                        calculationDatesIDRef_ = calculationDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationDates_ = new AdjustableDates(calculationDatesNode);
                    }
                }
                else
                {
                    calculationDates_ = new AdjustableDates(calculationDatesNode);
                }
            }
            
        
            XmlNode calculationPeriodsNode = xmlNode.SelectSingleNode("calculationPeriods");
            
            if (calculationPeriodsNode != null)
            {
                if (calculationPeriodsNode.Attributes["href"] != null || calculationPeriodsNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodsNode.Attributes["id"] != null) 
                    {
                        calculationPeriodsIDRef_ = calculationPeriodsNode.Attributes["id"].Value;
                        AdjustableDates ob = new AdjustableDates(calculationPeriodsNode);
                        IDManager.SetID(calculationPeriodsIDRef_, ob);
                    }
                    else if (calculationPeriodsNode.Attributes["href"] != null)
                    {
                        calculationPeriodsIDRef_ = calculationPeriodsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriods_ = new AdjustableDates(calculationPeriodsNode);
                    }
                }
                else
                {
                    calculationPeriods_ = new AdjustableDates(calculationPeriodsNode);
                }
            }
            
        
            XmlNode calculationPeriodsScheduleNode = xmlNode.SelectSingleNode("calculationPeriodsSchedule");
            
            if (calculationPeriodsScheduleNode != null)
            {
                if (calculationPeriodsScheduleNode.Attributes["href"] != null || calculationPeriodsScheduleNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodsScheduleNode.Attributes["id"] != null) 
                    {
                        calculationPeriodsScheduleIDRef_ = calculationPeriodsScheduleNode.Attributes["id"].Value;
                        CommodityCalculationPeriodsSchedule ob = new CommodityCalculationPeriodsSchedule(calculationPeriodsScheduleNode);
                        IDManager.SetID(calculationPeriodsScheduleIDRef_, ob);
                    }
                    else if (calculationPeriodsScheduleNode.Attributes["href"] != null)
                    {
                        calculationPeriodsScheduleIDRef_ = calculationPeriodsScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodsSchedule_ = new CommodityCalculationPeriodsSchedule(calculationPeriodsScheduleNode);
                    }
                }
                else
                {
                    calculationPeriodsSchedule_ = new CommodityCalculationPeriodsSchedule(calculationPeriodsScheduleNode);
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
            
        
            XmlNode commodityNode = xmlNode.SelectSingleNode("commodity");
            
            if (commodityNode != null)
            {
                if (commodityNode.Attributes["href"] != null || commodityNode.Attributes["id"] != null) 
                {
                    if (commodityNode.Attributes["id"] != null) 
                    {
                        commodityIDRef_ = commodityNode.Attributes["id"].Value;
                        Commodity ob = new Commodity(commodityNode);
                        IDManager.SetID(commodityIDRef_, ob);
                    }
                    else if (commodityNode.Attributes["href"] != null)
                    {
                        commodityIDRef_ = commodityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commodity_ = new Commodity(commodityNode);
                    }
                }
                else
                {
                    commodity_ = new Commodity(commodityNode);
                }
            }
            
        
            XmlNode quantityReferenceNode = xmlNode.SelectSingleNode("quantityReference");
            
            if (quantityReferenceNode != null)
            {
                if (quantityReferenceNode.Attributes["href"] != null || quantityReferenceNode.Attributes["id"] != null) 
                {
                    if (quantityReferenceNode.Attributes["id"] != null) 
                    {
                        quantityReferenceIDRef_ = quantityReferenceNode.Attributes["id"].Value;
                        QuantityReference ob = new QuantityReference(quantityReferenceNode);
                        IDManager.SetID(quantityReferenceIDRef_, ob);
                    }
                    else if (quantityReferenceNode.Attributes["href"] != null)
                    {
                        quantityReferenceIDRef_ = quantityReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quantityReference_ = new QuantityReference(quantityReferenceNode);
                    }
                }
                else
                {
                    quantityReference_ = new QuantityReference(quantityReferenceNode);
                }
            }
            
        
            XmlNode pricingStartDateNode = xmlNode.SelectSingleNode("pricingStartDate");
            
            if (pricingStartDateNode != null)
            {
                if (pricingStartDateNode.Attributes["href"] != null || pricingStartDateNode.Attributes["id"] != null) 
                {
                    if (pricingStartDateNode.Attributes["id"] != null) 
                    {
                        pricingStartDateIDRef_ = pricingStartDateNode.Attributes["id"].Value;
                        AdjustableDate ob = new AdjustableDate(pricingStartDateNode);
                        IDManager.SetID(pricingStartDateIDRef_, ob);
                    }
                    else if (pricingStartDateNode.Attributes["href"] != null)
                    {
                        pricingStartDateIDRef_ = pricingStartDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pricingStartDate_ = new AdjustableDate(pricingStartDateNode);
                    }
                }
                else
                {
                    pricingStartDate_ = new AdjustableDate(pricingStartDateNode);
                }
            }
            
        
            XmlNode calculationNode = xmlNode.SelectSingleNode("calculation");
            
            if (calculationNode != null)
            {
                if (calculationNode.Attributes["href"] != null || calculationNode.Attributes["id"] != null) 
                {
                    if (calculationNode.Attributes["id"] != null) 
                    {
                        calculationIDRef_ = calculationNode.Attributes["id"].Value;
                        FloatingLegCalculation ob = new FloatingLegCalculation(calculationNode);
                        IDManager.SetID(calculationIDRef_, ob);
                    }
                    else if (calculationNode.Attributes["href"] != null)
                    {
                        calculationIDRef_ = calculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculation_ = new FloatingLegCalculation(calculationNode);
                    }
                }
                else
                {
                    calculation_ = new FloatingLegCalculation(calculationNode);
                }
            }
            
        
            XmlNode relativePaymentDatesNode = xmlNode.SelectSingleNode("relativePaymentDates");
            
            if (relativePaymentDatesNode != null)
            {
                if (relativePaymentDatesNode.Attributes["href"] != null || relativePaymentDatesNode.Attributes["id"] != null) 
                {
                    if (relativePaymentDatesNode.Attributes["id"] != null) 
                    {
                        relativePaymentDatesIDRef_ = relativePaymentDatesNode.Attributes["id"].Value;
                        CommodityRelativePaymentDates ob = new CommodityRelativePaymentDates(relativePaymentDatesNode);
                        IDManager.SetID(relativePaymentDatesIDRef_, ob);
                    }
                    else if (relativePaymentDatesNode.Attributes["href"] != null)
                    {
                        relativePaymentDatesIDRef_ = relativePaymentDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relativePaymentDates_ = new CommodityRelativePaymentDates(relativePaymentDatesNode);
                    }
                }
                else
                {
                    relativePaymentDates_ = new CommodityRelativePaymentDates(relativePaymentDatesNode);
                }
            }
            
        
            XmlNode paymentDatesNode = xmlNode.SelectSingleNode("paymentDates");
            
            if (paymentDatesNode != null)
            {
                if (paymentDatesNode.Attributes["href"] != null || paymentDatesNode.Attributes["id"] != null) 
                {
                    if (paymentDatesNode.Attributes["id"] != null) 
                    {
                        paymentDatesIDRef_ = paymentDatesNode.Attributes["id"].Value;
                        AdjustableDatesOrRelativeDateOffset ob = new AdjustableDatesOrRelativeDateOffset(paymentDatesNode);
                        IDManager.SetID(paymentDatesIDRef_, ob);
                    }
                    else if (paymentDatesNode.Attributes["href"] != null)
                    {
                        paymentDatesIDRef_ = paymentDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDates_ = new AdjustableDatesOrRelativeDateOffset(paymentDatesNode);
                    }
                }
                else
                {
                    paymentDates_ = new AdjustableDatesOrRelativeDateOffset(paymentDatesNode);
                }
            }
            
        
            XmlNode masterAgreementPaymentDatesNode = xmlNode.SelectSingleNode("masterAgreementPaymentDates");
            
            if (masterAgreementPaymentDatesNode != null)
            {
                if (masterAgreementPaymentDatesNode.Attributes["href"] != null || masterAgreementPaymentDatesNode.Attributes["id"] != null) 
                {
                    if (masterAgreementPaymentDatesNode.Attributes["id"] != null) 
                    {
                        masterAgreementPaymentDatesIDRef_ = masterAgreementPaymentDatesNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(masterAgreementPaymentDatesNode);
                        IDManager.SetID(masterAgreementPaymentDatesIDRef_, ob);
                    }
                    else if (masterAgreementPaymentDatesNode.Attributes["href"] != null)
                    {
                        masterAgreementPaymentDatesIDRef_ = masterAgreementPaymentDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        masterAgreementPaymentDates_ = new XsdTypeBoolean(masterAgreementPaymentDatesNode);
                    }
                }
                else
                {
                    masterAgreementPaymentDates_ = new XsdTypeBoolean(masterAgreementPaymentDatesNode);
                }
            }
            
        
        }
        
    
        #region PayerPartyReference_
        private PartyReference payerPartyReference_;
        public PartyReference PayerPartyReference_
        {
            get
            {
                if (this.payerPartyReference_ != null)
                {
                    return this.payerPartyReference_; 
                }
                else if (this.payerPartyReferenceIDRef_ != null)
                {
                    payerPartyReference_ = IDManager.getID(payerPartyReferenceIDRef_) as PartyReference;
                    return this.payerPartyReference_; 
                }
                else
                {
                      return this.payerPartyReference_; 
                }
            }
            set
            {
                if (this.payerPartyReference_ != value)
                {
                    this.payerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string payerPartyReferenceIDRef_ { get; set; }
        #region PayerAccountReference_
        private AccountReference payerAccountReference_;
        public AccountReference PayerAccountReference_
        {
            get
            {
                if (this.payerAccountReference_ != null)
                {
                    return this.payerAccountReference_; 
                }
                else if (this.payerAccountReferenceIDRef_ != null)
                {
                    payerAccountReference_ = IDManager.getID(payerAccountReferenceIDRef_) as AccountReference;
                    return this.payerAccountReference_; 
                }
                else
                {
                      return this.payerAccountReference_; 
                }
            }
            set
            {
                if (this.payerAccountReference_ != value)
                {
                    this.payerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string payerAccountReferenceIDRef_ { get; set; }
        #region ReceiverPartyReference_
        private PartyReference receiverPartyReference_;
        public PartyReference ReceiverPartyReference_
        {
            get
            {
                if (this.receiverPartyReference_ != null)
                {
                    return this.receiverPartyReference_; 
                }
                else if (this.receiverPartyReferenceIDRef_ != null)
                {
                    receiverPartyReference_ = IDManager.getID(receiverPartyReferenceIDRef_) as PartyReference;
                    return this.receiverPartyReference_; 
                }
                else
                {
                      return this.receiverPartyReference_; 
                }
            }
            set
            {
                if (this.receiverPartyReference_ != value)
                {
                    this.receiverPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string receiverPartyReferenceIDRef_ { get; set; }
        #region ReceiverAccountReference_
        private AccountReference receiverAccountReference_;
        public AccountReference ReceiverAccountReference_
        {
            get
            {
                if (this.receiverAccountReference_ != null)
                {
                    return this.receiverAccountReference_; 
                }
                else if (this.receiverAccountReferenceIDRef_ != null)
                {
                    receiverAccountReference_ = IDManager.getID(receiverAccountReferenceIDRef_) as AccountReference;
                    return this.receiverAccountReference_; 
                }
                else
                {
                      return this.receiverAccountReference_; 
                }
            }
            set
            {
                if (this.receiverAccountReference_ != value)
                {
                    this.receiverAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string receiverAccountReferenceIDRef_ { get; set; }
        #region CalculationDates_
        private AdjustableDates calculationDates_;
        public AdjustableDates CalculationDates_
        {
            get
            {
                if (this.calculationDates_ != null)
                {
                    return this.calculationDates_; 
                }
                else if (this.calculationDatesIDRef_ != null)
                {
                    calculationDates_ = IDManager.getID(calculationDatesIDRef_) as AdjustableDates;
                    return this.calculationDates_; 
                }
                else
                {
                      return this.calculationDates_; 
                }
            }
            set
            {
                if (this.calculationDates_ != value)
                {
                    this.calculationDates_ = value;
                }
            }
        }
        #endregion
        
        public string calculationDatesIDRef_ { get; set; }
        #region CalculationPeriods_
        private AdjustableDates calculationPeriods_;
        public AdjustableDates CalculationPeriods_
        {
            get
            {
                if (this.calculationPeriods_ != null)
                {
                    return this.calculationPeriods_; 
                }
                else if (this.calculationPeriodsIDRef_ != null)
                {
                    calculationPeriods_ = IDManager.getID(calculationPeriodsIDRef_) as AdjustableDates;
                    return this.calculationPeriods_; 
                }
                else
                {
                      return this.calculationPeriods_; 
                }
            }
            set
            {
                if (this.calculationPeriods_ != value)
                {
                    this.calculationPeriods_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodsIDRef_ { get; set; }
        #region CalculationPeriodsSchedule_
        private CommodityCalculationPeriodsSchedule calculationPeriodsSchedule_;
        public CommodityCalculationPeriodsSchedule CalculationPeriodsSchedule_
        {
            get
            {
                if (this.calculationPeriodsSchedule_ != null)
                {
                    return this.calculationPeriodsSchedule_; 
                }
                else if (this.calculationPeriodsScheduleIDRef_ != null)
                {
                    calculationPeriodsSchedule_ = IDManager.getID(calculationPeriodsScheduleIDRef_) as CommodityCalculationPeriodsSchedule;
                    return this.calculationPeriodsSchedule_; 
                }
                else
                {
                      return this.calculationPeriodsSchedule_; 
                }
            }
            set
            {
                if (this.calculationPeriodsSchedule_ != value)
                {
                    this.calculationPeriodsSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodsScheduleIDRef_ { get; set; }
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
        #region Commodity_
        private Commodity commodity_;
        public Commodity Commodity_
        {
            get
            {
                if (this.commodity_ != null)
                {
                    return this.commodity_; 
                }
                else if (this.commodityIDRef_ != null)
                {
                    commodity_ = IDManager.getID(commodityIDRef_) as Commodity;
                    return this.commodity_; 
                }
                else
                {
                      return this.commodity_; 
                }
            }
            set
            {
                if (this.commodity_ != value)
                {
                    this.commodity_ = value;
                }
            }
        }
        #endregion
        
        public string commodityIDRef_ { get; set; }
        #region QuantityReference_
        private QuantityReference quantityReference_;
        public QuantityReference QuantityReference_
        {
            get
            {
                if (this.quantityReference_ != null)
                {
                    return this.quantityReference_; 
                }
                else if (this.quantityReferenceIDRef_ != null)
                {
                    quantityReference_ = IDManager.getID(quantityReferenceIDRef_) as QuantityReference;
                    return this.quantityReference_; 
                }
                else
                {
                      return this.quantityReference_; 
                }
            }
            set
            {
                if (this.quantityReference_ != value)
                {
                    this.quantityReference_ = value;
                }
            }
        }
        #endregion
        
        public string quantityReferenceIDRef_ { get; set; }
        #region PricingStartDate_
        private AdjustableDate pricingStartDate_;
        public AdjustableDate PricingStartDate_
        {
            get
            {
                if (this.pricingStartDate_ != null)
                {
                    return this.pricingStartDate_; 
                }
                else if (this.pricingStartDateIDRef_ != null)
                {
                    pricingStartDate_ = IDManager.getID(pricingStartDateIDRef_) as AdjustableDate;
                    return this.pricingStartDate_; 
                }
                else
                {
                      return this.pricingStartDate_; 
                }
            }
            set
            {
                if (this.pricingStartDate_ != value)
                {
                    this.pricingStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string pricingStartDateIDRef_ { get; set; }
        #region Calculation_
        private FloatingLegCalculation calculation_;
        public FloatingLegCalculation Calculation_
        {
            get
            {
                if (this.calculation_ != null)
                {
                    return this.calculation_; 
                }
                else if (this.calculationIDRef_ != null)
                {
                    calculation_ = IDManager.getID(calculationIDRef_) as FloatingLegCalculation;
                    return this.calculation_; 
                }
                else
                {
                      return this.calculation_; 
                }
            }
            set
            {
                if (this.calculation_ != value)
                {
                    this.calculation_ = value;
                }
            }
        }
        #endregion
        
        public string calculationIDRef_ { get; set; }
        #region RelativePaymentDates_
        private CommodityRelativePaymentDates relativePaymentDates_;
        public CommodityRelativePaymentDates RelativePaymentDates_
        {
            get
            {
                if (this.relativePaymentDates_ != null)
                {
                    return this.relativePaymentDates_; 
                }
                else if (this.relativePaymentDatesIDRef_ != null)
                {
                    relativePaymentDates_ = IDManager.getID(relativePaymentDatesIDRef_) as CommodityRelativePaymentDates;
                    return this.relativePaymentDates_; 
                }
                else
                {
                      return this.relativePaymentDates_; 
                }
            }
            set
            {
                if (this.relativePaymentDates_ != value)
                {
                    this.relativePaymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string relativePaymentDatesIDRef_ { get; set; }
        #region PaymentDates_
        private AdjustableDatesOrRelativeDateOffset paymentDates_;
        public AdjustableDatesOrRelativeDateOffset PaymentDates_
        {
            get
            {
                if (this.paymentDates_ != null)
                {
                    return this.paymentDates_; 
                }
                else if (this.paymentDatesIDRef_ != null)
                {
                    paymentDates_ = IDManager.getID(paymentDatesIDRef_) as AdjustableDatesOrRelativeDateOffset;
                    return this.paymentDates_; 
                }
                else
                {
                      return this.paymentDates_; 
                }
            }
            set
            {
                if (this.paymentDates_ != value)
                {
                    this.paymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDatesIDRef_ { get; set; }
        #region MasterAgreementPaymentDates_
        private XsdTypeBoolean masterAgreementPaymentDates_;
        public XsdTypeBoolean MasterAgreementPaymentDates_
        {
            get
            {
                if (this.masterAgreementPaymentDates_ != null)
                {
                    return this.masterAgreementPaymentDates_; 
                }
                else if (this.masterAgreementPaymentDatesIDRef_ != null)
                {
                    masterAgreementPaymentDates_ = IDManager.getID(masterAgreementPaymentDatesIDRef_) as XsdTypeBoolean;
                    return this.masterAgreementPaymentDates_; 
                }
                else
                {
                      return this.masterAgreementPaymentDates_; 
                }
            }
            set
            {
                if (this.masterAgreementPaymentDates_ != value)
                {
                    this.masterAgreementPaymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string masterAgreementPaymentDatesIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        public string choiceStr_3;
        
    
        
    
    }
    
}

