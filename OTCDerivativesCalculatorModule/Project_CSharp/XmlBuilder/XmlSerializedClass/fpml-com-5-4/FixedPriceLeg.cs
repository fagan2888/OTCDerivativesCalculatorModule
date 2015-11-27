using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FixedPriceLeg : FinancialSwapLeg
    {
        public FixedPriceLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNode fixedPriceScheduleNode = xmlNode.SelectSingleNode("fixedPriceSchedule");
            
            if (fixedPriceScheduleNode != null)
            {
                if (fixedPriceScheduleNode.Attributes["href"] != null || fixedPriceScheduleNode.Attributes["id"] != null) 
                {
                    if (fixedPriceScheduleNode.Attributes["id"] != null) 
                    {
                        fixedPriceScheduleIDRef_ = fixedPriceScheduleNode.Attributes["id"].Value;
                        CommodityFixedPriceSchedule ob = new CommodityFixedPriceSchedule(fixedPriceScheduleNode);
                        IDManager.SetID(fixedPriceScheduleIDRef_, ob);
                    }
                    else if (fixedPriceScheduleNode.Attributes["href"] != null)
                    {
                        fixedPriceScheduleIDRef_ = fixedPriceScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedPriceSchedule_ = new CommodityFixedPriceSchedule(fixedPriceScheduleNode);
                    }
                }
                else
                {
                    fixedPriceSchedule_ = new CommodityFixedPriceSchedule(fixedPriceScheduleNode);
                }
            }
            
        
            XmlNode fixedPriceNode = xmlNode.SelectSingleNode("fixedPrice");
            
            if (fixedPriceNode != null)
            {
                if (fixedPriceNode.Attributes["href"] != null || fixedPriceNode.Attributes["id"] != null) 
                {
                    if (fixedPriceNode.Attributes["id"] != null) 
                    {
                        fixedPriceIDRef_ = fixedPriceNode.Attributes["id"].Value;
                        FixedPrice ob = new FixedPrice(fixedPriceNode);
                        IDManager.SetID(fixedPriceIDRef_, ob);
                    }
                    else if (fixedPriceNode.Attributes["href"] != null)
                    {
                        fixedPriceIDRef_ = fixedPriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedPrice_ = new FixedPrice(fixedPriceNode);
                    }
                }
                else
                {
                    fixedPrice_ = new FixedPrice(fixedPriceNode);
                }
            }
            
        
            XmlNode worldscaleRateNode = xmlNode.SelectSingleNode("worldscaleRate");
            
            if (worldscaleRateNode != null)
            {
                if (worldscaleRateNode.Attributes["href"] != null || worldscaleRateNode.Attributes["id"] != null) 
                {
                    if (worldscaleRateNode.Attributes["id"] != null) 
                    {
                        worldscaleRateIDRef_ = worldscaleRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(worldscaleRateNode);
                        IDManager.SetID(worldscaleRateIDRef_, ob);
                    }
                    else if (worldscaleRateNode.Attributes["href"] != null)
                    {
                        worldscaleRateIDRef_ = worldscaleRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        worldscaleRate_ = new XsdTypeDecimal(worldscaleRateNode);
                    }
                }
                else
                {
                    worldscaleRate_ = new XsdTypeDecimal(worldscaleRateNode);
                }
            }
            
        
            XmlNode contractRateNode = xmlNode.SelectSingleNode("contractRate");
            
            if (contractRateNode != null)
            {
                if (contractRateNode.Attributes["href"] != null || contractRateNode.Attributes["id"] != null) 
                {
                    if (contractRateNode.Attributes["id"] != null) 
                    {
                        contractRateIDRef_ = contractRateNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(contractRateNode);
                        IDManager.SetID(contractRateIDRef_, ob);
                    }
                    else if (contractRateNode.Attributes["href"] != null)
                    {
                        contractRateIDRef_ = contractRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        contractRate_ = new NonNegativeMoney(contractRateNode);
                    }
                }
                else
                {
                    contractRate_ = new NonNegativeMoney(contractRateNode);
                }
            }
            
        
            XmlNodeList settlementPeriodsPriceNodeList = xmlNode.SelectNodes("settlementPeriodsPrice");
            
            if (settlementPeriodsPriceNodeList != null)
            {
                this.settlementPeriodsPrice_ = new List<SettlementPeriodsFixedPrice>();
                foreach (XmlNode item in settlementPeriodsPriceNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            settlementPeriodsPriceIDRef_ = item.Attributes["id"].Value;
                            settlementPeriodsPrice_.Add(new SettlementPeriodsFixedPrice(item));
                            IDManager.SetID(settlementPeriodsPriceIDRef_, settlementPeriodsPrice_[settlementPeriodsPrice_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            settlementPeriodsPriceIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        settlementPeriodsPrice_.Add(new SettlementPeriodsFixedPrice(item));
                        }
                    }
                    else
                    {
                        settlementPeriodsPrice_.Add(new SettlementPeriodsFixedPrice(item));
                    }
                }
            }
            
        
            XmlNode totalPriceNode = xmlNode.SelectSingleNode("totalPrice");
            
            if (totalPriceNode != null)
            {
                if (totalPriceNode.Attributes["href"] != null || totalPriceNode.Attributes["id"] != null) 
                {
                    if (totalPriceNode.Attributes["id"] != null) 
                    {
                        totalPriceIDRef_ = totalPriceNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(totalPriceNode);
                        IDManager.SetID(totalPriceIDRef_, ob);
                    }
                    else if (totalPriceNode.Attributes["href"] != null)
                    {
                        totalPriceIDRef_ = totalPriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        totalPrice_ = new NonNegativeMoney(totalPriceNode);
                    }
                }
                else
                {
                    totalPrice_ = new NonNegativeMoney(totalPriceNode);
                }
            }
            
        
            XmlNode notionalQuantityScheduleNode = xmlNode.SelectSingleNode("notionalQuantitySchedule");
            
            if (notionalQuantityScheduleNode != null)
            {
                if (notionalQuantityScheduleNode.Attributes["href"] != null || notionalQuantityScheduleNode.Attributes["id"] != null) 
                {
                    if (notionalQuantityScheduleNode.Attributes["id"] != null) 
                    {
                        notionalQuantityScheduleIDRef_ = notionalQuantityScheduleNode.Attributes["id"].Value;
                        CommodityNotionalQuantitySchedule ob = new CommodityNotionalQuantitySchedule(notionalQuantityScheduleNode);
                        IDManager.SetID(notionalQuantityScheduleIDRef_, ob);
                    }
                    else if (notionalQuantityScheduleNode.Attributes["href"] != null)
                    {
                        notionalQuantityScheduleIDRef_ = notionalQuantityScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalQuantitySchedule_ = new CommodityNotionalQuantitySchedule(notionalQuantityScheduleNode);
                    }
                }
                else
                {
                    notionalQuantitySchedule_ = new CommodityNotionalQuantitySchedule(notionalQuantityScheduleNode);
                }
            }
            
        
            XmlNode notionalQuantityNode = xmlNode.SelectSingleNode("notionalQuantity");
            
            if (notionalQuantityNode != null)
            {
                if (notionalQuantityNode.Attributes["href"] != null || notionalQuantityNode.Attributes["id"] != null) 
                {
                    if (notionalQuantityNode.Attributes["id"] != null) 
                    {
                        notionalQuantityIDRef_ = notionalQuantityNode.Attributes["id"].Value;
                        CommodityNotionalQuantity ob = new CommodityNotionalQuantity(notionalQuantityNode);
                        IDManager.SetID(notionalQuantityIDRef_, ob);
                    }
                    else if (notionalQuantityNode.Attributes["href"] != null)
                    {
                        notionalQuantityIDRef_ = notionalQuantityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalQuantity_ = new CommodityNotionalQuantity(notionalQuantityNode);
                    }
                }
                else
                {
                    notionalQuantity_ = new CommodityNotionalQuantity(notionalQuantityNode);
                }
            }
            
        
            XmlNodeList settlementPeriodsNotionalQuantityNodeList = xmlNode.SelectNodes("settlementPeriodsNotionalQuantity");
            
            if (settlementPeriodsNotionalQuantityNodeList != null)
            {
                this.settlementPeriodsNotionalQuantity_ = new List<CommoditySettlementPeriodsNotionalQuantity>();
                foreach (XmlNode item in settlementPeriodsNotionalQuantityNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            settlementPeriodsNotionalQuantityIDRef_ = item.Attributes["id"].Value;
                            settlementPeriodsNotionalQuantity_.Add(new CommoditySettlementPeriodsNotionalQuantity(item));
                            IDManager.SetID(settlementPeriodsNotionalQuantityIDRef_, settlementPeriodsNotionalQuantity_[settlementPeriodsNotionalQuantity_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            settlementPeriodsNotionalQuantityIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        settlementPeriodsNotionalQuantity_.Add(new CommoditySettlementPeriodsNotionalQuantity(item));
                        }
                    }
                    else
                    {
                        settlementPeriodsNotionalQuantity_.Add(new CommoditySettlementPeriodsNotionalQuantity(item));
                    }
                }
            }
            
        
            XmlNode totalNotionalQuantityNode = xmlNode.SelectSingleNode("totalNotionalQuantity");
            
            if (totalNotionalQuantityNode != null)
            {
                if (totalNotionalQuantityNode.Attributes["href"] != null || totalNotionalQuantityNode.Attributes["id"] != null) 
                {
                    if (totalNotionalQuantityNode.Attributes["id"] != null) 
                    {
                        totalNotionalQuantityIDRef_ = totalNotionalQuantityNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(totalNotionalQuantityNode);
                        IDManager.SetID(totalNotionalQuantityIDRef_, ob);
                    }
                    else if (totalNotionalQuantityNode.Attributes["href"] != null)
                    {
                        totalNotionalQuantityIDRef_ = totalNotionalQuantityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        totalNotionalQuantity_ = new XsdTypeDecimal(totalNotionalQuantityNode);
                    }
                }
                else
                {
                    totalNotionalQuantity_ = new XsdTypeDecimal(totalNotionalQuantityNode);
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
            
        
            XmlNode flatRateNode = xmlNode.SelectSingleNode("flatRate");
            
            if (flatRateNode != null)
            {
                if (flatRateNode.Attributes["href"] != null || flatRateNode.Attributes["id"] != null) 
                {
                    if (flatRateNode.Attributes["id"] != null) 
                    {
                        flatRateIDRef_ = flatRateNode.Attributes["id"].Value;
                        FlatRateEnum ob = new FlatRateEnum(flatRateNode);
                        IDManager.SetID(flatRateIDRef_, ob);
                    }
                    else if (flatRateNode.Attributes["href"] != null)
                    {
                        flatRateIDRef_ = flatRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        flatRate_ = new FlatRateEnum(flatRateNode);
                    }
                }
                else
                {
                    flatRate_ = new FlatRateEnum(flatRateNode);
                }
            }
            
        
            XmlNode flatRateAmountNode = xmlNode.SelectSingleNode("flatRateAmount");
            
            if (flatRateAmountNode != null)
            {
                if (flatRateAmountNode.Attributes["href"] != null || flatRateAmountNode.Attributes["id"] != null) 
                {
                    if (flatRateAmountNode.Attributes["id"] != null) 
                    {
                        flatRateAmountIDRef_ = flatRateAmountNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(flatRateAmountNode);
                        IDManager.SetID(flatRateAmountIDRef_, ob);
                    }
                    else if (flatRateAmountNode.Attributes["href"] != null)
                    {
                        flatRateAmountIDRef_ = flatRateAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        flatRateAmount_ = new NonNegativeMoney(flatRateAmountNode);
                    }
                }
                else
                {
                    flatRateAmount_ = new NonNegativeMoney(flatRateAmountNode);
                }
            }
            
        
        }
        
    
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
        #region FixedPriceSchedule_
        private CommodityFixedPriceSchedule fixedPriceSchedule_;
        public CommodityFixedPriceSchedule FixedPriceSchedule_
        {
            get
            {
                if (this.fixedPriceSchedule_ != null)
                {
                    return this.fixedPriceSchedule_; 
                }
                else if (this.fixedPriceScheduleIDRef_ != null)
                {
                    fixedPriceSchedule_ = IDManager.getID(fixedPriceScheduleIDRef_) as CommodityFixedPriceSchedule;
                    return this.fixedPriceSchedule_; 
                }
                else
                {
                      return this.fixedPriceSchedule_; 
                }
            }
            set
            {
                if (this.fixedPriceSchedule_ != value)
                {
                    this.fixedPriceSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string fixedPriceScheduleIDRef_ { get; set; }
        #region FixedPrice_
        private FixedPrice fixedPrice_;
        public FixedPrice FixedPrice_
        {
            get
            {
                if (this.fixedPrice_ != null)
                {
                    return this.fixedPrice_; 
                }
                else if (this.fixedPriceIDRef_ != null)
                {
                    fixedPrice_ = IDManager.getID(fixedPriceIDRef_) as FixedPrice;
                    return this.fixedPrice_; 
                }
                else
                {
                      return this.fixedPrice_; 
                }
            }
            set
            {
                if (this.fixedPrice_ != value)
                {
                    this.fixedPrice_ = value;
                }
            }
        }
        #endregion
        
        public string fixedPriceIDRef_ { get; set; }
        #region WorldscaleRate_
        private XsdTypeDecimal worldscaleRate_;
        public XsdTypeDecimal WorldscaleRate_
        {
            get
            {
                if (this.worldscaleRate_ != null)
                {
                    return this.worldscaleRate_; 
                }
                else if (this.worldscaleRateIDRef_ != null)
                {
                    worldscaleRate_ = IDManager.getID(worldscaleRateIDRef_) as XsdTypeDecimal;
                    return this.worldscaleRate_; 
                }
                else
                {
                      return this.worldscaleRate_; 
                }
            }
            set
            {
                if (this.worldscaleRate_ != value)
                {
                    this.worldscaleRate_ = value;
                }
            }
        }
        #endregion
        
        public string worldscaleRateIDRef_ { get; set; }
        #region ContractRate_
        private NonNegativeMoney contractRate_;
        public NonNegativeMoney ContractRate_
        {
            get
            {
                if (this.contractRate_ != null)
                {
                    return this.contractRate_; 
                }
                else if (this.contractRateIDRef_ != null)
                {
                    contractRate_ = IDManager.getID(contractRateIDRef_) as NonNegativeMoney;
                    return this.contractRate_; 
                }
                else
                {
                      return this.contractRate_; 
                }
            }
            set
            {
                if (this.contractRate_ != value)
                {
                    this.contractRate_ = value;
                }
            }
        }
        #endregion
        
        public string contractRateIDRef_ { get; set; }
        #region SettlementPeriodsPrice_
        private List<SettlementPeriodsFixedPrice> settlementPeriodsPrice_;
        public List<SettlementPeriodsFixedPrice> SettlementPeriodsPrice_
        {
            get
            {
                if (this.settlementPeriodsPrice_ != null)
                {
                    return this.settlementPeriodsPrice_; 
                }
                else if (this.settlementPeriodsPriceIDRef_ != null)
                {
                    return this.settlementPeriodsPrice_; 
                }
                else
                {
                      return this.settlementPeriodsPrice_; 
                }
            }
            set
            {
                if (this.settlementPeriodsPrice_ != value)
                {
                    this.settlementPeriodsPrice_ = value;
                }
            }
        }
        #endregion
        
        public string settlementPeriodsPriceIDRef_ { get; set; }
        #region TotalPrice_
        private NonNegativeMoney totalPrice_;
        public NonNegativeMoney TotalPrice_
        {
            get
            {
                if (this.totalPrice_ != null)
                {
                    return this.totalPrice_; 
                }
                else if (this.totalPriceIDRef_ != null)
                {
                    totalPrice_ = IDManager.getID(totalPriceIDRef_) as NonNegativeMoney;
                    return this.totalPrice_; 
                }
                else
                {
                      return this.totalPrice_; 
                }
            }
            set
            {
                if (this.totalPrice_ != value)
                {
                    this.totalPrice_ = value;
                }
            }
        }
        #endregion
        
        public string totalPriceIDRef_ { get; set; }
        #region NotionalQuantitySchedule_
        private CommodityNotionalQuantitySchedule notionalQuantitySchedule_;
        public CommodityNotionalQuantitySchedule NotionalQuantitySchedule_
        {
            get
            {
                if (this.notionalQuantitySchedule_ != null)
                {
                    return this.notionalQuantitySchedule_; 
                }
                else if (this.notionalQuantityScheduleIDRef_ != null)
                {
                    notionalQuantitySchedule_ = IDManager.getID(notionalQuantityScheduleIDRef_) as CommodityNotionalQuantitySchedule;
                    return this.notionalQuantitySchedule_; 
                }
                else
                {
                      return this.notionalQuantitySchedule_; 
                }
            }
            set
            {
                if (this.notionalQuantitySchedule_ != value)
                {
                    this.notionalQuantitySchedule_ = value;
                }
            }
        }
        #endregion
        
        public string notionalQuantityScheduleIDRef_ { get; set; }
        #region NotionalQuantity_
        private CommodityNotionalQuantity notionalQuantity_;
        public CommodityNotionalQuantity NotionalQuantity_
        {
            get
            {
                if (this.notionalQuantity_ != null)
                {
                    return this.notionalQuantity_; 
                }
                else if (this.notionalQuantityIDRef_ != null)
                {
                    notionalQuantity_ = IDManager.getID(notionalQuantityIDRef_) as CommodityNotionalQuantity;
                    return this.notionalQuantity_; 
                }
                else
                {
                      return this.notionalQuantity_; 
                }
            }
            set
            {
                if (this.notionalQuantity_ != value)
                {
                    this.notionalQuantity_ = value;
                }
            }
        }
        #endregion
        
        public string notionalQuantityIDRef_ { get; set; }
        #region SettlementPeriodsNotionalQuantity_
        private List<CommoditySettlementPeriodsNotionalQuantity> settlementPeriodsNotionalQuantity_;
        public List<CommoditySettlementPeriodsNotionalQuantity> SettlementPeriodsNotionalQuantity_
        {
            get
            {
                if (this.settlementPeriodsNotionalQuantity_ != null)
                {
                    return this.settlementPeriodsNotionalQuantity_; 
                }
                else if (this.settlementPeriodsNotionalQuantityIDRef_ != null)
                {
                    return this.settlementPeriodsNotionalQuantity_; 
                }
                else
                {
                      return this.settlementPeriodsNotionalQuantity_; 
                }
            }
            set
            {
                if (this.settlementPeriodsNotionalQuantity_ != value)
                {
                    this.settlementPeriodsNotionalQuantity_ = value;
                }
            }
        }
        #endregion
        
        public string settlementPeriodsNotionalQuantityIDRef_ { get; set; }
        #region TotalNotionalQuantity_
        private XsdTypeDecimal totalNotionalQuantity_;
        public XsdTypeDecimal TotalNotionalQuantity_
        {
            get
            {
                if (this.totalNotionalQuantity_ != null)
                {
                    return this.totalNotionalQuantity_; 
                }
                else if (this.totalNotionalQuantityIDRef_ != null)
                {
                    totalNotionalQuantity_ = IDManager.getID(totalNotionalQuantityIDRef_) as XsdTypeDecimal;
                    return this.totalNotionalQuantity_; 
                }
                else
                {
                      return this.totalNotionalQuantity_; 
                }
            }
            set
            {
                if (this.totalNotionalQuantity_ != value)
                {
                    this.totalNotionalQuantity_ = value;
                }
            }
        }
        #endregion
        
        public string totalNotionalQuantityIDRef_ { get; set; }
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
        #region FlatRate_
        private FlatRateEnum flatRate_;
        public FlatRateEnum FlatRate_
        {
            get
            {
                if (this.flatRate_ != null)
                {
                    return this.flatRate_; 
                }
                else if (this.flatRateIDRef_ != null)
                {
                    flatRate_ = IDManager.getID(flatRateIDRef_) as FlatRateEnum;
                    return this.flatRate_; 
                }
                else
                {
                      return this.flatRate_; 
                }
            }
            set
            {
                if (this.flatRate_ != value)
                {
                    this.flatRate_ = value;
                }
            }
        }
        #endregion
        
        public string flatRateIDRef_ { get; set; }
        #region FlatRateAmount_
        private NonNegativeMoney flatRateAmount_;
        public NonNegativeMoney FlatRateAmount_
        {
            get
            {
                if (this.flatRateAmount_ != null)
                {
                    return this.flatRateAmount_; 
                }
                else if (this.flatRateAmountIDRef_ != null)
                {
                    flatRateAmount_ = IDManager.getID(flatRateAmountIDRef_) as NonNegativeMoney;
                    return this.flatRateAmount_; 
                }
                else
                {
                      return this.flatRateAmount_; 
                }
            }
            set
            {
                if (this.flatRateAmount_ != value)
                {
                    this.flatRateAmount_ = value;
                }
            }
        }
        #endregion
        
        public string flatRateAmountIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        public string choiceStr_3;
        public string choiceStr_4;
        public string choiceStr_5;
        public string choiceStr_6;
        public string choiceStr_7;
        
    
        
    
    }
    
}
