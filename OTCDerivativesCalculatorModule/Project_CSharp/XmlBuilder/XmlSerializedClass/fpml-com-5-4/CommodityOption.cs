using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityOption : Product
    {
        public CommodityOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode buyerPartyReferenceNode = xmlNode.SelectSingleNode("buyerPartyReference");
            
            if (buyerPartyReferenceNode != null)
            {
                if (buyerPartyReferenceNode.Attributes["href"] != null || buyerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (buyerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        buyerPartyReferenceIDRef_ = buyerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(buyerPartyReferenceNode);
                        IDManager.SetID(buyerPartyReferenceIDRef_, ob);
                    }
                    else if (buyerPartyReferenceNode.Attributes["href"] != null)
                    {
                        buyerPartyReferenceIDRef_ = buyerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        buyerPartyReference_ = new PartyReference(buyerPartyReferenceNode);
                    }
                }
                else
                {
                    buyerPartyReference_ = new PartyReference(buyerPartyReferenceNode);
                }
            }
            
        
            XmlNode buyerAccountReferenceNode = xmlNode.SelectSingleNode("buyerAccountReference");
            
            if (buyerAccountReferenceNode != null)
            {
                if (buyerAccountReferenceNode.Attributes["href"] != null || buyerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (buyerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        buyerAccountReferenceIDRef_ = buyerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(buyerAccountReferenceNode);
                        IDManager.SetID(buyerAccountReferenceIDRef_, ob);
                    }
                    else if (buyerAccountReferenceNode.Attributes["href"] != null)
                    {
                        buyerAccountReferenceIDRef_ = buyerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        buyerAccountReference_ = new AccountReference(buyerAccountReferenceNode);
                    }
                }
                else
                {
                    buyerAccountReference_ = new AccountReference(buyerAccountReferenceNode);
                }
            }
            
        
            XmlNode sellerPartyReferenceNode = xmlNode.SelectSingleNode("sellerPartyReference");
            
            if (sellerPartyReferenceNode != null)
            {
                if (sellerPartyReferenceNode.Attributes["href"] != null || sellerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (sellerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        sellerPartyReferenceIDRef_ = sellerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(sellerPartyReferenceNode);
                        IDManager.SetID(sellerPartyReferenceIDRef_, ob);
                    }
                    else if (sellerPartyReferenceNode.Attributes["href"] != null)
                    {
                        sellerPartyReferenceIDRef_ = sellerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sellerPartyReference_ = new PartyReference(sellerPartyReferenceNode);
                    }
                }
                else
                {
                    sellerPartyReference_ = new PartyReference(sellerPartyReferenceNode);
                }
            }
            
        
            XmlNode sellerAccountReferenceNode = xmlNode.SelectSingleNode("sellerAccountReference");
            
            if (sellerAccountReferenceNode != null)
            {
                if (sellerAccountReferenceNode.Attributes["href"] != null || sellerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (sellerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        sellerAccountReferenceIDRef_ = sellerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(sellerAccountReferenceNode);
                        IDManager.SetID(sellerAccountReferenceIDRef_, ob);
                    }
                    else if (sellerAccountReferenceNode.Attributes["href"] != null)
                    {
                        sellerAccountReferenceIDRef_ = sellerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sellerAccountReference_ = new AccountReference(sellerAccountReferenceNode);
                    }
                }
                else
                {
                    sellerAccountReference_ = new AccountReference(sellerAccountReferenceNode);
                }
            }
            
        
            XmlNode optionTypeNode = xmlNode.SelectSingleNode("optionType");
            
            if (optionTypeNode != null)
            {
                if (optionTypeNode.Attributes["href"] != null || optionTypeNode.Attributes["id"] != null) 
                {
                    if (optionTypeNode.Attributes["id"] != null) 
                    {
                        optionTypeIDRef_ = optionTypeNode.Attributes["id"].Value;
                        PutCallEnum ob = new PutCallEnum(optionTypeNode);
                        IDManager.SetID(optionTypeIDRef_, ob);
                    }
                    else if (optionTypeNode.Attributes["href"] != null)
                    {
                        optionTypeIDRef_ = optionTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionType_ = new PutCallEnum(optionTypeNode);
                    }
                }
                else
                {
                    optionType_ = new PutCallEnum(optionTypeNode);
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
            
        
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new AdjustableOrRelativeDate(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new AdjustableOrRelativeDate(effectiveDateNode);
                }
            }
            
        
            XmlNode terminationDateNode = xmlNode.SelectSingleNode("terminationDate");
            
            if (terminationDateNode != null)
            {
                if (terminationDateNode.Attributes["href"] != null || terminationDateNode.Attributes["id"] != null) 
                {
                    if (terminationDateNode.Attributes["id"] != null) 
                    {
                        terminationDateIDRef_ = terminationDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(terminationDateNode);
                        IDManager.SetID(terminationDateIDRef_, ob);
                    }
                    else if (terminationDateNode.Attributes["href"] != null)
                    {
                        terminationDateIDRef_ = terminationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        terminationDate_ = new AdjustableOrRelativeDate(terminationDateNode);
                    }
                }
                else
                {
                    terminationDate_ = new AdjustableOrRelativeDate(terminationDateNode);
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
            
        
            XmlNode pricingDatesNode = xmlNode.SelectSingleNode("pricingDates");
            
            if (pricingDatesNode != null)
            {
                if (pricingDatesNode.Attributes["href"] != null || pricingDatesNode.Attributes["id"] != null) 
                {
                    if (pricingDatesNode.Attributes["id"] != null) 
                    {
                        pricingDatesIDRef_ = pricingDatesNode.Attributes["id"].Value;
                        CommodityPricingDates ob = new CommodityPricingDates(pricingDatesNode);
                        IDManager.SetID(pricingDatesIDRef_, ob);
                    }
                    else if (pricingDatesNode.Attributes["href"] != null)
                    {
                        pricingDatesIDRef_ = pricingDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pricingDates_ = new CommodityPricingDates(pricingDatesNode);
                    }
                }
                else
                {
                    pricingDates_ = new CommodityPricingDates(pricingDatesNode);
                }
            }
            
        
            XmlNode averagingMethodNode = xmlNode.SelectSingleNode("averagingMethod");
            
            if (averagingMethodNode != null)
            {
                if (averagingMethodNode.Attributes["href"] != null || averagingMethodNode.Attributes["id"] != null) 
                {
                    if (averagingMethodNode.Attributes["id"] != null) 
                    {
                        averagingMethodIDRef_ = averagingMethodNode.Attributes["id"].Value;
                        AveragingMethodEnum ob = new AveragingMethodEnum(averagingMethodNode);
                        IDManager.SetID(averagingMethodIDRef_, ob);
                    }
                    else if (averagingMethodNode.Attributes["href"] != null)
                    {
                        averagingMethodIDRef_ = averagingMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averagingMethod_ = new AveragingMethodEnum(averagingMethodNode);
                    }
                }
                else
                {
                    averagingMethod_ = new AveragingMethodEnum(averagingMethodNode);
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
            
        
            XmlNode exerciseNode = xmlNode.SelectSingleNode("exercise");
            
            if (exerciseNode != null)
            {
                if (exerciseNode.Attributes["href"] != null || exerciseNode.Attributes["id"] != null) 
                {
                    if (exerciseNode.Attributes["id"] != null) 
                    {
                        exerciseIDRef_ = exerciseNode.Attributes["id"].Value;
                        CommodityExercise ob = new CommodityExercise(exerciseNode);
                        IDManager.SetID(exerciseIDRef_, ob);
                    }
                    else if (exerciseNode.Attributes["href"] != null)
                    {
                        exerciseIDRef_ = exerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exercise_ = new CommodityExercise(exerciseNode);
                    }
                }
                else
                {
                    exercise_ = new CommodityExercise(exerciseNode);
                }
            }
            
        
            XmlNode strikePricePerUnitNode = xmlNode.SelectSingleNode("strikePricePerUnit");
            
            if (strikePricePerUnitNode != null)
            {
                if (strikePricePerUnitNode.Attributes["href"] != null || strikePricePerUnitNode.Attributes["id"] != null) 
                {
                    if (strikePricePerUnitNode.Attributes["id"] != null) 
                    {
                        strikePricePerUnitIDRef_ = strikePricePerUnitNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(strikePricePerUnitNode);
                        IDManager.SetID(strikePricePerUnitIDRef_, ob);
                    }
                    else if (strikePricePerUnitNode.Attributes["href"] != null)
                    {
                        strikePricePerUnitIDRef_ = strikePricePerUnitNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strikePricePerUnit_ = new NonNegativeMoney(strikePricePerUnitNode);
                    }
                }
                else
                {
                    strikePricePerUnit_ = new NonNegativeMoney(strikePricePerUnitNode);
                }
            }
            
        
            XmlNode strikePricePerUnitScheduleNode = xmlNode.SelectSingleNode("strikePricePerUnitSchedule");
            
            if (strikePricePerUnitScheduleNode != null)
            {
                if (strikePricePerUnitScheduleNode.Attributes["href"] != null || strikePricePerUnitScheduleNode.Attributes["id"] != null) 
                {
                    if (strikePricePerUnitScheduleNode.Attributes["id"] != null) 
                    {
                        strikePricePerUnitScheduleIDRef_ = strikePricePerUnitScheduleNode.Attributes["id"].Value;
                        CommodityStrikeSchedule ob = new CommodityStrikeSchedule(strikePricePerUnitScheduleNode);
                        IDManager.SetID(strikePricePerUnitScheduleIDRef_, ob);
                    }
                    else if (strikePricePerUnitScheduleNode.Attributes["href"] != null)
                    {
                        strikePricePerUnitScheduleIDRef_ = strikePricePerUnitScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strikePricePerUnitSchedule_ = new CommodityStrikeSchedule(strikePricePerUnitScheduleNode);
                    }
                }
                else
                {
                    strikePricePerUnitSchedule_ = new CommodityStrikeSchedule(strikePricePerUnitScheduleNode);
                }
            }
            
        
            XmlNode floatingStrikePricePerUnitNode = xmlNode.SelectSingleNode("floatingStrikePricePerUnit");
            
            if (floatingStrikePricePerUnitNode != null)
            {
                if (floatingStrikePricePerUnitNode.Attributes["href"] != null || floatingStrikePricePerUnitNode.Attributes["id"] != null) 
                {
                    if (floatingStrikePricePerUnitNode.Attributes["id"] != null) 
                    {
                        floatingStrikePricePerUnitIDRef_ = floatingStrikePricePerUnitNode.Attributes["id"].Value;
                        FloatingStrikePrice ob = new FloatingStrikePrice(floatingStrikePricePerUnitNode);
                        IDManager.SetID(floatingStrikePricePerUnitIDRef_, ob);
                    }
                    else if (floatingStrikePricePerUnitNode.Attributes["href"] != null)
                    {
                        floatingStrikePricePerUnitIDRef_ = floatingStrikePricePerUnitNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floatingStrikePricePerUnit_ = new FloatingStrikePrice(floatingStrikePricePerUnitNode);
                    }
                }
                else
                {
                    floatingStrikePricePerUnit_ = new FloatingStrikePrice(floatingStrikePricePerUnitNode);
                }
            }
            
        
            XmlNode floatingStrikePricePerUnitScheduleNode = xmlNode.SelectSingleNode("floatingStrikePricePerUnitSchedule");
            
            if (floatingStrikePricePerUnitScheduleNode != null)
            {
                if (floatingStrikePricePerUnitScheduleNode.Attributes["href"] != null || floatingStrikePricePerUnitScheduleNode.Attributes["id"] != null) 
                {
                    if (floatingStrikePricePerUnitScheduleNode.Attributes["id"] != null) 
                    {
                        floatingStrikePricePerUnitScheduleIDRef_ = floatingStrikePricePerUnitScheduleNode.Attributes["id"].Value;
                        CommodityCalculationPeriodsSchedule ob = new CommodityCalculationPeriodsSchedule(floatingStrikePricePerUnitScheduleNode);
                        IDManager.SetID(floatingStrikePricePerUnitScheduleIDRef_, ob);
                    }
                    else if (floatingStrikePricePerUnitScheduleNode.Attributes["href"] != null)
                    {
                        floatingStrikePricePerUnitScheduleIDRef_ = floatingStrikePricePerUnitScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floatingStrikePricePerUnitSchedule_ = new CommodityCalculationPeriodsSchedule(floatingStrikePricePerUnitScheduleNode);
                    }
                }
                else
                {
                    floatingStrikePricePerUnitSchedule_ = new CommodityCalculationPeriodsSchedule(floatingStrikePricePerUnitScheduleNode);
                }
            }
            
        
            XmlNode commoditySwapNode = xmlNode.SelectSingleNode("commoditySwap");
            
            if (commoditySwapNode != null)
            {
                if (commoditySwapNode.Attributes["href"] != null || commoditySwapNode.Attributes["id"] != null) 
                {
                    if (commoditySwapNode.Attributes["id"] != null) 
                    {
                        commoditySwapIDRef_ = commoditySwapNode.Attributes["id"].Value;
                        CommoditySwap ob = new CommoditySwap(commoditySwapNode);
                        IDManager.SetID(commoditySwapIDRef_, ob);
                    }
                    else if (commoditySwapNode.Attributes["href"] != null)
                    {
                        commoditySwapIDRef_ = commoditySwapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commoditySwap_ = new CommoditySwap(commoditySwapNode);
                    }
                }
                else
                {
                    commoditySwap_ = new CommoditySwap(commoditySwapNode);
                }
            }
            
        
            XmlNode commodityForwardNode = xmlNode.SelectSingleNode("commodityForward");
            
            if (commodityForwardNode != null)
            {
                if (commodityForwardNode.Attributes["href"] != null || commodityForwardNode.Attributes["id"] != null) 
                {
                    if (commodityForwardNode.Attributes["id"] != null) 
                    {
                        commodityForwardIDRef_ = commodityForwardNode.Attributes["id"].Value;
                        CommodityForward ob = new CommodityForward(commodityForwardNode);
                        IDManager.SetID(commodityForwardIDRef_, ob);
                    }
                    else if (commodityForwardNode.Attributes["href"] != null)
                    {
                        commodityForwardIDRef_ = commodityForwardNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commodityForward_ = new CommodityForward(commodityForwardNode);
                    }
                }
                else
                {
                    commodityForward_ = new CommodityForward(commodityForwardNode);
                }
            }
            
        
            XmlNode physicalExerciseNode = xmlNode.SelectSingleNode("physicalExercise");
            
            if (physicalExerciseNode != null)
            {
                if (physicalExerciseNode.Attributes["href"] != null || physicalExerciseNode.Attributes["id"] != null) 
                {
                    if (physicalExerciseNode.Attributes["id"] != null) 
                    {
                        physicalExerciseIDRef_ = physicalExerciseNode.Attributes["id"].Value;
                        CommodityPhysicalExercise ob = new CommodityPhysicalExercise(physicalExerciseNode);
                        IDManager.SetID(physicalExerciseIDRef_, ob);
                    }
                    else if (physicalExerciseNode.Attributes["href"] != null)
                    {
                        physicalExerciseIDRef_ = physicalExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        physicalExercise_ = new CommodityPhysicalExercise(physicalExerciseNode);
                    }
                }
                else
                {
                    physicalExercise_ = new CommodityPhysicalExercise(physicalExerciseNode);
                }
            }
            
        
            XmlNode weatherCalculationPeriodsNode = xmlNode.SelectSingleNode("weatherCalculationPeriods");
            
            if (weatherCalculationPeriodsNode != null)
            {
                if (weatherCalculationPeriodsNode.Attributes["href"] != null || weatherCalculationPeriodsNode.Attributes["id"] != null) 
                {
                    if (weatherCalculationPeriodsNode.Attributes["id"] != null) 
                    {
                        weatherCalculationPeriodsIDRef_ = weatherCalculationPeriodsNode.Attributes["id"].Value;
                        WeatherCalculationPeriods ob = new WeatherCalculationPeriods(weatherCalculationPeriodsNode);
                        IDManager.SetID(weatherCalculationPeriodsIDRef_, ob);
                    }
                    else if (weatherCalculationPeriodsNode.Attributes["href"] != null)
                    {
                        weatherCalculationPeriodsIDRef_ = weatherCalculationPeriodsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherCalculationPeriods_ = new WeatherCalculationPeriods(weatherCalculationPeriodsNode);
                    }
                }
                else
                {
                    weatherCalculationPeriods_ = new WeatherCalculationPeriods(weatherCalculationPeriodsNode);
                }
            }
            
        
            XmlNode weatherCalculationPeriodsReferenceNode = xmlNode.SelectSingleNode("weatherCalculationPeriodsReference");
            
            if (weatherCalculationPeriodsReferenceNode != null)
            {
                if (weatherCalculationPeriodsReferenceNode.Attributes["href"] != null || weatherCalculationPeriodsReferenceNode.Attributes["id"] != null) 
                {
                    if (weatherCalculationPeriodsReferenceNode.Attributes["id"] != null) 
                    {
                        weatherCalculationPeriodsReferenceIDRef_ = weatherCalculationPeriodsReferenceNode.Attributes["id"].Value;
                        CalculationPeriodsReference ob = new CalculationPeriodsReference(weatherCalculationPeriodsReferenceNode);
                        IDManager.SetID(weatherCalculationPeriodsReferenceIDRef_, ob);
                    }
                    else if (weatherCalculationPeriodsReferenceNode.Attributes["href"] != null)
                    {
                        weatherCalculationPeriodsReferenceIDRef_ = weatherCalculationPeriodsReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherCalculationPeriodsReference_ = new CalculationPeriodsReference(weatherCalculationPeriodsReferenceNode);
                    }
                }
                else
                {
                    weatherCalculationPeriodsReference_ = new CalculationPeriodsReference(weatherCalculationPeriodsReferenceNode);
                }
            }
            
        
            XmlNode weatherNotionalAmountNode = xmlNode.SelectSingleNode("weatherNotionalAmount");
            
            if (weatherNotionalAmountNode != null)
            {
                if (weatherNotionalAmountNode.Attributes["href"] != null || weatherNotionalAmountNode.Attributes["id"] != null) 
                {
                    if (weatherNotionalAmountNode.Attributes["id"] != null) 
                    {
                        weatherNotionalAmountIDRef_ = weatherNotionalAmountNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(weatherNotionalAmountNode);
                        IDManager.SetID(weatherNotionalAmountIDRef_, ob);
                    }
                    else if (weatherNotionalAmountNode.Attributes["href"] != null)
                    {
                        weatherNotionalAmountIDRef_ = weatherNotionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherNotionalAmount_ = new NonNegativeMoney(weatherNotionalAmountNode);
                    }
                }
                else
                {
                    weatherNotionalAmount_ = new NonNegativeMoney(weatherNotionalAmountNode);
                }
            }
            
        
            XmlNode weatherIndexStrikeLevelNode = xmlNode.SelectSingleNode("weatherIndexStrikeLevel");
            
            if (weatherIndexStrikeLevelNode != null)
            {
                if (weatherIndexStrikeLevelNode.Attributes["href"] != null || weatherIndexStrikeLevelNode.Attributes["id"] != null) 
                {
                    if (weatherIndexStrikeLevelNode.Attributes["id"] != null) 
                    {
                        weatherIndexStrikeLevelIDRef_ = weatherIndexStrikeLevelNode.Attributes["id"].Value;
                        WeatherIndex ob = new WeatherIndex(weatherIndexStrikeLevelNode);
                        IDManager.SetID(weatherIndexStrikeLevelIDRef_, ob);
                    }
                    else if (weatherIndexStrikeLevelNode.Attributes["href"] != null)
                    {
                        weatherIndexStrikeLevelIDRef_ = weatherIndexStrikeLevelNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherIndexStrikeLevel_ = new WeatherIndex(weatherIndexStrikeLevelNode);
                    }
                }
                else
                {
                    weatherIndexStrikeLevel_ = new WeatherIndex(weatherIndexStrikeLevelNode);
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
                        WeatherLegCalculation ob = new WeatherLegCalculation(calculationNode);
                        IDManager.SetID(calculationIDRef_, ob);
                    }
                    else if (calculationNode.Attributes["href"] != null)
                    {
                        calculationIDRef_ = calculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculation_ = new WeatherLegCalculation(calculationNode);
                    }
                }
                else
                {
                    calculation_ = new WeatherLegCalculation(calculationNode);
                }
            }
            
        
            XmlNode weatherIndexDataNode = xmlNode.SelectSingleNode("weatherIndexData");
            
            if (weatherIndexDataNode != null)
            {
                if (weatherIndexDataNode.Attributes["href"] != null || weatherIndexDataNode.Attributes["id"] != null) 
                {
                    if (weatherIndexDataNode.Attributes["id"] != null) 
                    {
                        weatherIndexDataIDRef_ = weatherIndexDataNode.Attributes["id"].Value;
                        WeatherIndexData ob = new WeatherIndexData(weatherIndexDataNode);
                        IDManager.SetID(weatherIndexDataIDRef_, ob);
                    }
                    else if (weatherIndexDataNode.Attributes["href"] != null)
                    {
                        weatherIndexDataIDRef_ = weatherIndexDataNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherIndexData_ = new WeatherIndexData(weatherIndexDataNode);
                    }
                }
                else
                {
                    weatherIndexData_ = new WeatherIndexData(weatherIndexDataNode);
                }
            }
            
        
            XmlNodeList premiumNodeList = xmlNode.SelectNodes("premium");
            
            if (premiumNodeList != null)
            {
                this.premium_ = new List<CommodityPremium>();
                foreach (XmlNode item in premiumNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            premiumIDRef_ = item.Attributes["id"].Value;
                            premium_.Add(new CommodityPremium(item));
                            IDManager.SetID(premiumIDRef_, premium_[premium_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            premiumIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        premium_.Add(new CommodityPremium(item));
                        }
                    }
                    else
                    {
                        premium_.Add(new CommodityPremium(item));
                    }
                }
            }
            
        
            XmlNode commonPricingNode = xmlNode.SelectSingleNode("commonPricing");
            
            if (commonPricingNode != null)
            {
                if (commonPricingNode.Attributes["href"] != null || commonPricingNode.Attributes["id"] != null) 
                {
                    if (commonPricingNode.Attributes["id"] != null) 
                    {
                        commonPricingIDRef_ = commonPricingNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(commonPricingNode);
                        IDManager.SetID(commonPricingIDRef_, ob);
                    }
                    else if (commonPricingNode.Attributes["href"] != null)
                    {
                        commonPricingIDRef_ = commonPricingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commonPricing_ = new XsdTypeBoolean(commonPricingNode);
                    }
                }
                else
                {
                    commonPricing_ = new XsdTypeBoolean(commonPricingNode);
                }
            }
            
        
            XmlNode marketDisruptionNode = xmlNode.SelectSingleNode("marketDisruption");
            
            if (marketDisruptionNode != null)
            {
                if (marketDisruptionNode.Attributes["href"] != null || marketDisruptionNode.Attributes["id"] != null) 
                {
                    if (marketDisruptionNode.Attributes["id"] != null) 
                    {
                        marketDisruptionIDRef_ = marketDisruptionNode.Attributes["id"].Value;
                        CommodityMarketDisruption ob = new CommodityMarketDisruption(marketDisruptionNode);
                        IDManager.SetID(marketDisruptionIDRef_, ob);
                    }
                    else if (marketDisruptionNode.Attributes["href"] != null)
                    {
                        marketDisruptionIDRef_ = marketDisruptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        marketDisruption_ = new CommodityMarketDisruption(marketDisruptionNode);
                    }
                }
                else
                {
                    marketDisruption_ = new CommodityMarketDisruption(marketDisruptionNode);
                }
            }
            
        
            XmlNode settlementDisruptionNode = xmlNode.SelectSingleNode("settlementDisruption");
            
            if (settlementDisruptionNode != null)
            {
                if (settlementDisruptionNode.Attributes["href"] != null || settlementDisruptionNode.Attributes["id"] != null) 
                {
                    if (settlementDisruptionNode.Attributes["id"] != null) 
                    {
                        settlementDisruptionIDRef_ = settlementDisruptionNode.Attributes["id"].Value;
                        CommodityBullionSettlementDisruptionEnum ob = new CommodityBullionSettlementDisruptionEnum(settlementDisruptionNode);
                        IDManager.SetID(settlementDisruptionIDRef_, ob);
                    }
                    else if (settlementDisruptionNode.Attributes["href"] != null)
                    {
                        settlementDisruptionIDRef_ = settlementDisruptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementDisruption_ = new CommodityBullionSettlementDisruptionEnum(settlementDisruptionNode);
                    }
                }
                else
                {
                    settlementDisruption_ = new CommodityBullionSettlementDisruptionEnum(settlementDisruptionNode);
                }
            }
            
        
            XmlNode roundingNode = xmlNode.SelectSingleNode("rounding");
            
            if (roundingNode != null)
            {
                if (roundingNode.Attributes["href"] != null || roundingNode.Attributes["id"] != null) 
                {
                    if (roundingNode.Attributes["id"] != null) 
                    {
                        roundingIDRef_ = roundingNode.Attributes["id"].Value;
                        Rounding ob = new Rounding(roundingNode);
                        IDManager.SetID(roundingIDRef_, ob);
                    }
                    else if (roundingNode.Attributes["href"] != null)
                    {
                        roundingIDRef_ = roundingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rounding_ = new Rounding(roundingNode);
                    }
                }
                else
                {
                    rounding_ = new Rounding(roundingNode);
                }
            }
            
        
        }
        
    
        #region BuyerPartyReference_
        private PartyReference buyerPartyReference_;
        public PartyReference BuyerPartyReference_
        {
            get
            {
                if (this.buyerPartyReference_ != null)
                {
                    return this.buyerPartyReference_; 
                }
                else if (this.buyerPartyReferenceIDRef_ != null)
                {
                    buyerPartyReference_ = IDManager.getID(buyerPartyReferenceIDRef_) as PartyReference;
                    return this.buyerPartyReference_; 
                }
                else
                {
                      return this.buyerPartyReference_; 
                }
            }
            set
            {
                if (this.buyerPartyReference_ != value)
                {
                    this.buyerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string buyerPartyReferenceIDRef_ { get; set; }
        #region BuyerAccountReference_
        private AccountReference buyerAccountReference_;
        public AccountReference BuyerAccountReference_
        {
            get
            {
                if (this.buyerAccountReference_ != null)
                {
                    return this.buyerAccountReference_; 
                }
                else if (this.buyerAccountReferenceIDRef_ != null)
                {
                    buyerAccountReference_ = IDManager.getID(buyerAccountReferenceIDRef_) as AccountReference;
                    return this.buyerAccountReference_; 
                }
                else
                {
                      return this.buyerAccountReference_; 
                }
            }
            set
            {
                if (this.buyerAccountReference_ != value)
                {
                    this.buyerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string buyerAccountReferenceIDRef_ { get; set; }
        #region SellerPartyReference_
        private PartyReference sellerPartyReference_;
        public PartyReference SellerPartyReference_
        {
            get
            {
                if (this.sellerPartyReference_ != null)
                {
                    return this.sellerPartyReference_; 
                }
                else if (this.sellerPartyReferenceIDRef_ != null)
                {
                    sellerPartyReference_ = IDManager.getID(sellerPartyReferenceIDRef_) as PartyReference;
                    return this.sellerPartyReference_; 
                }
                else
                {
                      return this.sellerPartyReference_; 
                }
            }
            set
            {
                if (this.sellerPartyReference_ != value)
                {
                    this.sellerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string sellerPartyReferenceIDRef_ { get; set; }
        #region SellerAccountReference_
        private AccountReference sellerAccountReference_;
        public AccountReference SellerAccountReference_
        {
            get
            {
                if (this.sellerAccountReference_ != null)
                {
                    return this.sellerAccountReference_; 
                }
                else if (this.sellerAccountReferenceIDRef_ != null)
                {
                    sellerAccountReference_ = IDManager.getID(sellerAccountReferenceIDRef_) as AccountReference;
                    return this.sellerAccountReference_; 
                }
                else
                {
                      return this.sellerAccountReference_; 
                }
            }
            set
            {
                if (this.sellerAccountReference_ != value)
                {
                    this.sellerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string sellerAccountReferenceIDRef_ { get; set; }
        #region OptionType_
        private PutCallEnum optionType_;
        public PutCallEnum OptionType_
        {
            get
            {
                if (this.optionType_ != null)
                {
                    return this.optionType_; 
                }
                else if (this.optionTypeIDRef_ != null)
                {
                    optionType_ = IDManager.getID(optionTypeIDRef_) as PutCallEnum;
                    return this.optionType_; 
                }
                else
                {
                      return this.optionType_; 
                }
            }
            set
            {
                if (this.optionType_ != value)
                {
                    this.optionType_ = value;
                }
            }
        }
        #endregion
        
        public string optionTypeIDRef_ { get; set; }
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
        #region EffectiveDate_
        private AdjustableOrRelativeDate effectiveDate_;
        public AdjustableOrRelativeDate EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as AdjustableOrRelativeDate;
                    return this.effectiveDate_; 
                }
                else
                {
                      return this.effectiveDate_; 
                }
            }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveDateIDRef_ { get; set; }
        #region TerminationDate_
        private AdjustableOrRelativeDate terminationDate_;
        public AdjustableOrRelativeDate TerminationDate_
        {
            get
            {
                if (this.terminationDate_ != null)
                {
                    return this.terminationDate_; 
                }
                else if (this.terminationDateIDRef_ != null)
                {
                    terminationDate_ = IDManager.getID(terminationDateIDRef_) as AdjustableOrRelativeDate;
                    return this.terminationDate_; 
                }
                else
                {
                      return this.terminationDate_; 
                }
            }
            set
            {
                if (this.terminationDate_ != value)
                {
                    this.terminationDate_ = value;
                }
            }
        }
        #endregion
        
        public string terminationDateIDRef_ { get; set; }
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
        #region PricingDates_
        private CommodityPricingDates pricingDates_;
        public CommodityPricingDates PricingDates_
        {
            get
            {
                if (this.pricingDates_ != null)
                {
                    return this.pricingDates_; 
                }
                else if (this.pricingDatesIDRef_ != null)
                {
                    pricingDates_ = IDManager.getID(pricingDatesIDRef_) as CommodityPricingDates;
                    return this.pricingDates_; 
                }
                else
                {
                      return this.pricingDates_; 
                }
            }
            set
            {
                if (this.pricingDates_ != value)
                {
                    this.pricingDates_ = value;
                }
            }
        }
        #endregion
        
        public string pricingDatesIDRef_ { get; set; }
        #region AveragingMethod_
        private AveragingMethodEnum averagingMethod_;
        public AveragingMethodEnum AveragingMethod_
        {
            get
            {
                if (this.averagingMethod_ != null)
                {
                    return this.averagingMethod_; 
                }
                else if (this.averagingMethodIDRef_ != null)
                {
                    averagingMethod_ = IDManager.getID(averagingMethodIDRef_) as AveragingMethodEnum;
                    return this.averagingMethod_; 
                }
                else
                {
                      return this.averagingMethod_; 
                }
            }
            set
            {
                if (this.averagingMethod_ != value)
                {
                    this.averagingMethod_ = value;
                }
            }
        }
        #endregion
        
        public string averagingMethodIDRef_ { get; set; }
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
        #region Exercise_
        private CommodityExercise exercise_;
        public CommodityExercise Exercise_
        {
            get
            {
                if (this.exercise_ != null)
                {
                    return this.exercise_; 
                }
                else if (this.exerciseIDRef_ != null)
                {
                    exercise_ = IDManager.getID(exerciseIDRef_) as CommodityExercise;
                    return this.exercise_; 
                }
                else
                {
                      return this.exercise_; 
                }
            }
            set
            {
                if (this.exercise_ != value)
                {
                    this.exercise_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseIDRef_ { get; set; }
        #region StrikePricePerUnit_
        private NonNegativeMoney strikePricePerUnit_;
        public NonNegativeMoney StrikePricePerUnit_
        {
            get
            {
                if (this.strikePricePerUnit_ != null)
                {
                    return this.strikePricePerUnit_; 
                }
                else if (this.strikePricePerUnitIDRef_ != null)
                {
                    strikePricePerUnit_ = IDManager.getID(strikePricePerUnitIDRef_) as NonNegativeMoney;
                    return this.strikePricePerUnit_; 
                }
                else
                {
                      return this.strikePricePerUnit_; 
                }
            }
            set
            {
                if (this.strikePricePerUnit_ != value)
                {
                    this.strikePricePerUnit_ = value;
                }
            }
        }
        #endregion
        
        public string strikePricePerUnitIDRef_ { get; set; }
        #region StrikePricePerUnitSchedule_
        private CommodityStrikeSchedule strikePricePerUnitSchedule_;
        public CommodityStrikeSchedule StrikePricePerUnitSchedule_
        {
            get
            {
                if (this.strikePricePerUnitSchedule_ != null)
                {
                    return this.strikePricePerUnitSchedule_; 
                }
                else if (this.strikePricePerUnitScheduleIDRef_ != null)
                {
                    strikePricePerUnitSchedule_ = IDManager.getID(strikePricePerUnitScheduleIDRef_) as CommodityStrikeSchedule;
                    return this.strikePricePerUnitSchedule_; 
                }
                else
                {
                      return this.strikePricePerUnitSchedule_; 
                }
            }
            set
            {
                if (this.strikePricePerUnitSchedule_ != value)
                {
                    this.strikePricePerUnitSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string strikePricePerUnitScheduleIDRef_ { get; set; }
        #region FloatingStrikePricePerUnit_
        private FloatingStrikePrice floatingStrikePricePerUnit_;
        public FloatingStrikePrice FloatingStrikePricePerUnit_
        {
            get
            {
                if (this.floatingStrikePricePerUnit_ != null)
                {
                    return this.floatingStrikePricePerUnit_; 
                }
                else if (this.floatingStrikePricePerUnitIDRef_ != null)
                {
                    floatingStrikePricePerUnit_ = IDManager.getID(floatingStrikePricePerUnitIDRef_) as FloatingStrikePrice;
                    return this.floatingStrikePricePerUnit_; 
                }
                else
                {
                      return this.floatingStrikePricePerUnit_; 
                }
            }
            set
            {
                if (this.floatingStrikePricePerUnit_ != value)
                {
                    this.floatingStrikePricePerUnit_ = value;
                }
            }
        }
        #endregion
        
        public string floatingStrikePricePerUnitIDRef_ { get; set; }
        #region FloatingStrikePricePerUnitSchedule_
        private CommodityCalculationPeriodsSchedule floatingStrikePricePerUnitSchedule_;
        public CommodityCalculationPeriodsSchedule FloatingStrikePricePerUnitSchedule_
        {
            get
            {
                if (this.floatingStrikePricePerUnitSchedule_ != null)
                {
                    return this.floatingStrikePricePerUnitSchedule_; 
                }
                else if (this.floatingStrikePricePerUnitScheduleIDRef_ != null)
                {
                    floatingStrikePricePerUnitSchedule_ = IDManager.getID(floatingStrikePricePerUnitScheduleIDRef_) as CommodityCalculationPeriodsSchedule;
                    return this.floatingStrikePricePerUnitSchedule_; 
                }
                else
                {
                      return this.floatingStrikePricePerUnitSchedule_; 
                }
            }
            set
            {
                if (this.floatingStrikePricePerUnitSchedule_ != value)
                {
                    this.floatingStrikePricePerUnitSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string floatingStrikePricePerUnitScheduleIDRef_ { get; set; }
        #region CommoditySwap_
        private CommoditySwap commoditySwap_;
        public CommoditySwap CommoditySwap_
        {
            get
            {
                if (this.commoditySwap_ != null)
                {
                    return this.commoditySwap_; 
                }
                else if (this.commoditySwapIDRef_ != null)
                {
                    commoditySwap_ = IDManager.getID(commoditySwapIDRef_) as CommoditySwap;
                    return this.commoditySwap_; 
                }
                else
                {
                      return this.commoditySwap_; 
                }
            }
            set
            {
                if (this.commoditySwap_ != value)
                {
                    this.commoditySwap_ = value;
                }
            }
        }
        #endregion
        
        public string commoditySwapIDRef_ { get; set; }
        #region CommodityForward_
        private CommodityForward commodityForward_;
        public CommodityForward CommodityForward_
        {
            get
            {
                if (this.commodityForward_ != null)
                {
                    return this.commodityForward_; 
                }
                else if (this.commodityForwardIDRef_ != null)
                {
                    commodityForward_ = IDManager.getID(commodityForwardIDRef_) as CommodityForward;
                    return this.commodityForward_; 
                }
                else
                {
                      return this.commodityForward_; 
                }
            }
            set
            {
                if (this.commodityForward_ != value)
                {
                    this.commodityForward_ = value;
                }
            }
        }
        #endregion
        
        public string commodityForwardIDRef_ { get; set; }
        #region PhysicalExercise_
        private CommodityPhysicalExercise physicalExercise_;
        public CommodityPhysicalExercise PhysicalExercise_
        {
            get
            {
                if (this.physicalExercise_ != null)
                {
                    return this.physicalExercise_; 
                }
                else if (this.physicalExerciseIDRef_ != null)
                {
                    physicalExercise_ = IDManager.getID(physicalExerciseIDRef_) as CommodityPhysicalExercise;
                    return this.physicalExercise_; 
                }
                else
                {
                      return this.physicalExercise_; 
                }
            }
            set
            {
                if (this.physicalExercise_ != value)
                {
                    this.physicalExercise_ = value;
                }
            }
        }
        #endregion
        
        public string physicalExerciseIDRef_ { get; set; }
        #region WeatherCalculationPeriods_
        private WeatherCalculationPeriods weatherCalculationPeriods_;
        public WeatherCalculationPeriods WeatherCalculationPeriods_
        {
            get
            {
                if (this.weatherCalculationPeriods_ != null)
                {
                    return this.weatherCalculationPeriods_; 
                }
                else if (this.weatherCalculationPeriodsIDRef_ != null)
                {
                    weatherCalculationPeriods_ = IDManager.getID(weatherCalculationPeriodsIDRef_) as WeatherCalculationPeriods;
                    return this.weatherCalculationPeriods_; 
                }
                else
                {
                      return this.weatherCalculationPeriods_; 
                }
            }
            set
            {
                if (this.weatherCalculationPeriods_ != value)
                {
                    this.weatherCalculationPeriods_ = value;
                }
            }
        }
        #endregion
        
        public string weatherCalculationPeriodsIDRef_ { get; set; }
        #region WeatherCalculationPeriodsReference_
        private CalculationPeriodsReference weatherCalculationPeriodsReference_;
        public CalculationPeriodsReference WeatherCalculationPeriodsReference_
        {
            get
            {
                if (this.weatherCalculationPeriodsReference_ != null)
                {
                    return this.weatherCalculationPeriodsReference_; 
                }
                else if (this.weatherCalculationPeriodsReferenceIDRef_ != null)
                {
                    weatherCalculationPeriodsReference_ = IDManager.getID(weatherCalculationPeriodsReferenceIDRef_) as CalculationPeriodsReference;
                    return this.weatherCalculationPeriodsReference_; 
                }
                else
                {
                      return this.weatherCalculationPeriodsReference_; 
                }
            }
            set
            {
                if (this.weatherCalculationPeriodsReference_ != value)
                {
                    this.weatherCalculationPeriodsReference_ = value;
                }
            }
        }
        #endregion
        
        public string weatherCalculationPeriodsReferenceIDRef_ { get; set; }
        #region WeatherNotionalAmount_
        private NonNegativeMoney weatherNotionalAmount_;
        public NonNegativeMoney WeatherNotionalAmount_
        {
            get
            {
                if (this.weatherNotionalAmount_ != null)
                {
                    return this.weatherNotionalAmount_; 
                }
                else if (this.weatherNotionalAmountIDRef_ != null)
                {
                    weatherNotionalAmount_ = IDManager.getID(weatherNotionalAmountIDRef_) as NonNegativeMoney;
                    return this.weatherNotionalAmount_; 
                }
                else
                {
                      return this.weatherNotionalAmount_; 
                }
            }
            set
            {
                if (this.weatherNotionalAmount_ != value)
                {
                    this.weatherNotionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string weatherNotionalAmountIDRef_ { get; set; }
        #region WeatherIndexStrikeLevel_
        private WeatherIndex weatherIndexStrikeLevel_;
        public WeatherIndex WeatherIndexStrikeLevel_
        {
            get
            {
                if (this.weatherIndexStrikeLevel_ != null)
                {
                    return this.weatherIndexStrikeLevel_; 
                }
                else if (this.weatherIndexStrikeLevelIDRef_ != null)
                {
                    weatherIndexStrikeLevel_ = IDManager.getID(weatherIndexStrikeLevelIDRef_) as WeatherIndex;
                    return this.weatherIndexStrikeLevel_; 
                }
                else
                {
                      return this.weatherIndexStrikeLevel_; 
                }
            }
            set
            {
                if (this.weatherIndexStrikeLevel_ != value)
                {
                    this.weatherIndexStrikeLevel_ = value;
                }
            }
        }
        #endregion
        
        public string weatherIndexStrikeLevelIDRef_ { get; set; }
        #region Calculation_
        private WeatherLegCalculation calculation_;
        public WeatherLegCalculation Calculation_
        {
            get
            {
                if (this.calculation_ != null)
                {
                    return this.calculation_; 
                }
                else if (this.calculationIDRef_ != null)
                {
                    calculation_ = IDManager.getID(calculationIDRef_) as WeatherLegCalculation;
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
        #region WeatherIndexData_
        private WeatherIndexData weatherIndexData_;
        public WeatherIndexData WeatherIndexData_
        {
            get
            {
                if (this.weatherIndexData_ != null)
                {
                    return this.weatherIndexData_; 
                }
                else if (this.weatherIndexDataIDRef_ != null)
                {
                    weatherIndexData_ = IDManager.getID(weatherIndexDataIDRef_) as WeatherIndexData;
                    return this.weatherIndexData_; 
                }
                else
                {
                      return this.weatherIndexData_; 
                }
            }
            set
            {
                if (this.weatherIndexData_ != value)
                {
                    this.weatherIndexData_ = value;
                }
            }
        }
        #endregion
        
        public string weatherIndexDataIDRef_ { get; set; }
        #region Premium_
        private List<CommodityPremium> premium_;
        public List<CommodityPremium> Premium_
        {
            get
            {
                if (this.premium_ != null)
                {
                    return this.premium_; 
                }
                else if (this.premiumIDRef_ != null)
                {
                    return this.premium_; 
                }
                else
                {
                      return this.premium_; 
                }
            }
            set
            {
                if (this.premium_ != value)
                {
                    this.premium_ = value;
                }
            }
        }
        #endregion
        
        public string premiumIDRef_ { get; set; }
        #region CommonPricing_
        private XsdTypeBoolean commonPricing_;
        public XsdTypeBoolean CommonPricing_
        {
            get
            {
                if (this.commonPricing_ != null)
                {
                    return this.commonPricing_; 
                }
                else if (this.commonPricingIDRef_ != null)
                {
                    commonPricing_ = IDManager.getID(commonPricingIDRef_) as XsdTypeBoolean;
                    return this.commonPricing_; 
                }
                else
                {
                      return this.commonPricing_; 
                }
            }
            set
            {
                if (this.commonPricing_ != value)
                {
                    this.commonPricing_ = value;
                }
            }
        }
        #endregion
        
        public string commonPricingIDRef_ { get; set; }
        #region MarketDisruption_
        private CommodityMarketDisruption marketDisruption_;
        public CommodityMarketDisruption MarketDisruption_
        {
            get
            {
                if (this.marketDisruption_ != null)
                {
                    return this.marketDisruption_; 
                }
                else if (this.marketDisruptionIDRef_ != null)
                {
                    marketDisruption_ = IDManager.getID(marketDisruptionIDRef_) as CommodityMarketDisruption;
                    return this.marketDisruption_; 
                }
                else
                {
                      return this.marketDisruption_; 
                }
            }
            set
            {
                if (this.marketDisruption_ != value)
                {
                    this.marketDisruption_ = value;
                }
            }
        }
        #endregion
        
        public string marketDisruptionIDRef_ { get; set; }
        #region SettlementDisruption_
        private CommodityBullionSettlementDisruptionEnum settlementDisruption_;
        public CommodityBullionSettlementDisruptionEnum SettlementDisruption_
        {
            get
            {
                if (this.settlementDisruption_ != null)
                {
                    return this.settlementDisruption_; 
                }
                else if (this.settlementDisruptionIDRef_ != null)
                {
                    settlementDisruption_ = IDManager.getID(settlementDisruptionIDRef_) as CommodityBullionSettlementDisruptionEnum;
                    return this.settlementDisruption_; 
                }
                else
                {
                      return this.settlementDisruption_; 
                }
            }
            set
            {
                if (this.settlementDisruption_ != value)
                {
                    this.settlementDisruption_ = value;
                }
            }
        }
        #endregion
        
        public string settlementDisruptionIDRef_ { get; set; }
        #region Rounding_
        private Rounding rounding_;
        public Rounding Rounding_
        {
            get
            {
                if (this.rounding_ != null)
                {
                    return this.rounding_; 
                }
                else if (this.roundingIDRef_ != null)
                {
                    rounding_ = IDManager.getID(roundingIDRef_) as Rounding;
                    return this.rounding_; 
                }
                else
                {
                      return this.rounding_; 
                }
            }
            set
            {
                if (this.rounding_ != value)
                {
                    this.rounding_ = value;
                }
            }
        }
        #endregion
        
        public string roundingIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        public string choiceStr_3;
        public string choiceStr_4;
        public string choiceStr_5;
        public string choiceStr_6;
        public string choiceStr_7;
        public string choiceStr_8;
        
    
        
    
    }
    
}

