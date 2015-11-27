using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityOption
    {
        public CommodityOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList buyerPartyReferenceNodeList = xmlNode.SelectNodes("buyerPartyReference");
            if (buyerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in buyerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        buyerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(buyerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        buyerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        buyerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList buyerAccountReferenceNodeList = xmlNode.SelectNodes("buyerAccountReference");
            if (buyerAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in buyerAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        buyerAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(buyerAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        buyerAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        buyerAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList sellerPartyReferenceNodeList = xmlNode.SelectNodes("sellerPartyReference");
            if (sellerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sellerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sellerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(sellerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sellerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sellerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList sellerAccountReferenceNodeList = xmlNode.SelectNodes("sellerAccountReference");
            if (sellerAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sellerAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sellerAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(sellerAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sellerAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sellerAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList optionTypeNodeList = xmlNode.SelectNodes("optionType");
            if (optionTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionTypeIDRef = item.Attributes["id"].Name;
                        PutCallEnum ob = PutCallEnum();
                        IDManager.SetID(optionTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionType = new PutCallEnum(item);
                    }
                }
            }
            
        
            XmlNodeList commodityNodeList = xmlNode.SelectNodes("commodity");
            if (commodityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commodityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commodityIDRef = item.Attributes["id"].Name;
                        Commodity ob = Commodity();
                        IDManager.SetID(commodityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commodityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commodity = new Commodity(item);
                    }
                }
            }
            
        
            XmlNodeList effectiveDateNodeList = xmlNode.SelectNodes("effectiveDate");
            if (effectiveDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in effectiveDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(effectiveDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        effectiveDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        effectiveDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList terminationDateNodeList = xmlNode.SelectNodes("terminationDate");
            if (terminationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in terminationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        terminationDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(terminationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        terminationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        terminationDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList calculationPeriodsScheduleNodeList = xmlNode.SelectNodes("calculationPeriodsSchedule");
            if (calculationPeriodsScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodsScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodsScheduleIDRef = item.Attributes["id"].Name;
                        CommodityCalculationPeriodsSchedule ob = CommodityCalculationPeriodsSchedule();
                        IDManager.SetID(calculationPeriodsScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodsScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodsSchedule = new CommodityCalculationPeriodsSchedule(item);
                    }
                }
            }
            
        
            XmlNodeList calculationPeriodsNodeList = xmlNode.SelectNodes("calculationPeriods");
            if (calculationPeriodsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodsIDRef = item.Attributes["id"].Name;
                        AdjustableDates ob = AdjustableDates();
                        IDManager.SetID(calculationPeriodsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriods = new AdjustableDates(item);
                    }
                }
            }
            
        
            XmlNodeList pricingDatesNodeList = xmlNode.SelectNodes("pricingDates");
            if (pricingDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in pricingDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pricingDatesIDRef = item.Attributes["id"].Name;
                        CommodityPricingDates ob = CommodityPricingDates();
                        IDManager.SetID(pricingDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pricingDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        pricingDates = new CommodityPricingDates(item);
                    }
                }
            }
            
        
            XmlNodeList averagingMethodNodeList = xmlNode.SelectNodes("averagingMethod");
            if (averagingMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in averagingMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averagingMethodIDRef = item.Attributes["id"].Name;
                        AveragingMethodEnum ob = AveragingMethodEnum();
                        IDManager.SetID(averagingMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averagingMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        averagingMethod = new AveragingMethodEnum(item);
                    }
                }
            }
            
        
            XmlNodeList notionalQuantityScheduleNodeList = xmlNode.SelectNodes("notionalQuantitySchedule");
            if (notionalQuantityScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalQuantityScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalQuantityScheduleIDRef = item.Attributes["id"].Name;
                        CommodityNotionalQuantitySchedule ob = CommodityNotionalQuantitySchedule();
                        IDManager.SetID(notionalQuantityScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalQuantityScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalQuantitySchedule = new CommodityNotionalQuantitySchedule(item);
                    }
                }
            }
            
        
            XmlNodeList notionalQuantityNodeList = xmlNode.SelectNodes("notionalQuantity");
            if (notionalQuantityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalQuantityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalQuantityIDRef = item.Attributes["id"].Name;
                        CommodityNotionalQuantity ob = CommodityNotionalQuantity();
                        IDManager.SetID(notionalQuantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalQuantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalQuantity = new CommodityNotionalQuantity(item);
                    }
                }
            }
            
        
            XmlNodeList settlementPeriodsNotionalQuantityNodeList = xmlNode.SelectNodes("settlementPeriodsNotionalQuantity");
            
            foreach (XmlNode item in settlementPeriodsNotionalQuantityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementPeriodsNotionalQuantityIDRef = item.Attributes["id"].Name;
                        List<CommoditySettlementPeriodsNotionalQuantity> ob = new List<CommoditySettlementPeriodsNotionalQuantity>();
                        ob.Add(new CommoditySettlementPeriodsNotionalQuantity(item));
                        IDManager.SetID(settlementPeriodsNotionalQuantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementPeriodsNotionalQuantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    settlementPeriodsNotionalQuantity.Add(new CommoditySettlementPeriodsNotionalQuantity(item));
                    }
                }
            }
            
        
            XmlNodeList totalNotionalQuantityNodeList = xmlNode.SelectNodes("totalNotionalQuantity");
            if (totalNotionalQuantityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in totalNotionalQuantityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        totalNotionalQuantityIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(totalNotionalQuantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        totalNotionalQuantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        totalNotionalQuantity = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList quantityReferenceNodeList = xmlNode.SelectNodes("quantityReference");
            if (quantityReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quantityReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quantityReferenceIDRef = item.Attributes["id"].Name;
                        QuantityReference ob = QuantityReference();
                        IDManager.SetID(quantityReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quantityReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quantityReference = new QuantityReference(item);
                    }
                }
            }
            
        
            XmlNodeList exerciseNodeList = xmlNode.SelectNodes("exercise");
            if (exerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseIDRef = item.Attributes["id"].Name;
                        CommodityExercise ob = CommodityExercise();
                        IDManager.SetID(exerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exercise = new CommodityExercise(item);
                    }
                }
            }
            
        
            XmlNodeList strikePricePerUnitNodeList = xmlNode.SelectNodes("strikePricePerUnit");
            if (strikePricePerUnitNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikePricePerUnitNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikePricePerUnitIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(strikePricePerUnitIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikePricePerUnitIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strikePricePerUnit = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList strikePricePerUnitScheduleNodeList = xmlNode.SelectNodes("strikePricePerUnitSchedule");
            if (strikePricePerUnitScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikePricePerUnitScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikePricePerUnitScheduleIDRef = item.Attributes["id"].Name;
                        CommodityStrikeSchedule ob = CommodityStrikeSchedule();
                        IDManager.SetID(strikePricePerUnitScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikePricePerUnitScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strikePricePerUnitSchedule = new CommodityStrikeSchedule(item);
                    }
                }
            }
            
        
            XmlNodeList floatingStrikePricePerUnitNodeList = xmlNode.SelectNodes("floatingStrikePricePerUnit");
            if (floatingStrikePricePerUnitNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in floatingStrikePricePerUnitNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floatingStrikePricePerUnitIDRef = item.Attributes["id"].Name;
                        FloatingStrikePrice ob = FloatingStrikePrice();
                        IDManager.SetID(floatingStrikePricePerUnitIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floatingStrikePricePerUnitIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        floatingStrikePricePerUnit = new FloatingStrikePrice(item);
                    }
                }
            }
            
        
            XmlNodeList floatingStrikePricePerUnitScheduleNodeList = xmlNode.SelectNodes("floatingStrikePricePerUnitSchedule");
            if (floatingStrikePricePerUnitScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in floatingStrikePricePerUnitScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floatingStrikePricePerUnitScheduleIDRef = item.Attributes["id"].Name;
                        CommodityCalculationPeriodsSchedule ob = CommodityCalculationPeriodsSchedule();
                        IDManager.SetID(floatingStrikePricePerUnitScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floatingStrikePricePerUnitScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        floatingStrikePricePerUnitSchedule = new CommodityCalculationPeriodsSchedule(item);
                    }
                }
            }
            
        
            XmlNodeList commoditySwapNodeList = xmlNode.SelectNodes("commoditySwap");
            if (commoditySwapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commoditySwapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commoditySwapIDRef = item.Attributes["id"].Name;
                        CommoditySwap ob = CommoditySwap();
                        IDManager.SetID(commoditySwapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commoditySwapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commoditySwap = new CommoditySwap(item);
                    }
                }
            }
            
        
            XmlNodeList commodityForwardNodeList = xmlNode.SelectNodes("commodityForward");
            if (commodityForwardNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commodityForwardNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commodityForwardIDRef = item.Attributes["id"].Name;
                        CommodityForward ob = CommodityForward();
                        IDManager.SetID(commodityForwardIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commodityForwardIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commodityForward = new CommodityForward(item);
                    }
                }
            }
            
        
            XmlNodeList physicalExerciseNodeList = xmlNode.SelectNodes("physicalExercise");
            if (physicalExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in physicalExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        physicalExerciseIDRef = item.Attributes["id"].Name;
                        CommodityPhysicalExercise ob = CommodityPhysicalExercise();
                        IDManager.SetID(physicalExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        physicalExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        physicalExercise = new CommodityPhysicalExercise(item);
                    }
                }
            }
            
        
            XmlNodeList weatherCalculationPeriodsNodeList = xmlNode.SelectNodes("weatherCalculationPeriods");
            if (weatherCalculationPeriodsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherCalculationPeriodsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherCalculationPeriodsIDRef = item.Attributes["id"].Name;
                        WeatherCalculationPeriods ob = WeatherCalculationPeriods();
                        IDManager.SetID(weatherCalculationPeriodsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherCalculationPeriodsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherCalculationPeriods = new WeatherCalculationPeriods(item);
                    }
                }
            }
            
        
            XmlNodeList weatherCalculationPeriodsReferenceNodeList = xmlNode.SelectNodes("weatherCalculationPeriodsReference");
            if (weatherCalculationPeriodsReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherCalculationPeriodsReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherCalculationPeriodsReferenceIDRef = item.Attributes["id"].Name;
                        CalculationPeriodsReference ob = CalculationPeriodsReference();
                        IDManager.SetID(weatherCalculationPeriodsReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherCalculationPeriodsReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherCalculationPeriodsReference = new CalculationPeriodsReference(item);
                    }
                }
            }
            
        
            XmlNodeList weatherNotionalAmountNodeList = xmlNode.SelectNodes("weatherNotionalAmount");
            if (weatherNotionalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherNotionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherNotionalAmountIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(weatherNotionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherNotionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherNotionalAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList weatherIndexStrikeLevelNodeList = xmlNode.SelectNodes("weatherIndexStrikeLevel");
            if (weatherIndexStrikeLevelNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherIndexStrikeLevelNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherIndexStrikeLevelIDRef = item.Attributes["id"].Name;
                        WeatherIndex ob = WeatherIndex();
                        IDManager.SetID(weatherIndexStrikeLevelIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherIndexStrikeLevelIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherIndexStrikeLevel = new WeatherIndex(item);
                    }
                }
            }
            
        
            XmlNodeList calculationNodeList = xmlNode.SelectNodes("calculation");
            if (calculationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationIDRef = item.Attributes["id"].Name;
                        WeatherLegCalculation ob = WeatherLegCalculation();
                        IDManager.SetID(calculationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculation = new WeatherLegCalculation(item);
                    }
                }
            }
            
        
            XmlNodeList weatherIndexDataNodeList = xmlNode.SelectNodes("weatherIndexData");
            if (weatherIndexDataNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherIndexDataNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherIndexDataIDRef = item.Attributes["id"].Name;
                        WeatherIndexData ob = WeatherIndexData();
                        IDManager.SetID(weatherIndexDataIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherIndexDataIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherIndexData = new WeatherIndexData(item);
                    }
                }
            }
            
        
            XmlNodeList premiumNodeList = xmlNode.SelectNodes("premium");
            
            foreach (XmlNode item in premiumNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        premiumIDRef = item.Attributes["id"].Name;
                        List<CommodityPremium> ob = new List<CommodityPremium>();
                        ob.Add(new CommodityPremium(item));
                        IDManager.SetID(premiumIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        premiumIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    premium.Add(new CommodityPremium(item));
                    }
                }
            }
            
        
            XmlNodeList commonPricingNodeList = xmlNode.SelectNodes("commonPricing");
            if (commonPricingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commonPricingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commonPricingIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(commonPricingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commonPricingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commonPricing = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList marketDisruptionNodeList = xmlNode.SelectNodes("marketDisruption");
            if (marketDisruptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in marketDisruptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        marketDisruptionIDRef = item.Attributes["id"].Name;
                        CommodityMarketDisruption ob = CommodityMarketDisruption();
                        IDManager.SetID(marketDisruptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        marketDisruptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        marketDisruption = new CommodityMarketDisruption(item);
                    }
                }
            }
            
        
            XmlNodeList settlementDisruptionNodeList = xmlNode.SelectNodes("settlementDisruption");
            if (settlementDisruptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementDisruptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementDisruptionIDRef = item.Attributes["id"].Name;
                        CommodityBullionSettlementDisruptionEnum ob = CommodityBullionSettlementDisruptionEnum();
                        IDManager.SetID(settlementDisruptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementDisruptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementDisruption = new CommodityBullionSettlementDisruptionEnum(item);
                    }
                }
            }
            
        
            XmlNodeList roundingNodeList = xmlNode.SelectNodes("rounding");
            if (roundingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in roundingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        roundingIDRef = item.Attributes["id"].Name;
                        Rounding ob = Rounding();
                        IDManager.SetID(roundingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        roundingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rounding = new Rounding(item);
                    }
                }
            }
            
        
        }
        
    
        #region BuyerPartyReference
        private PartyReference buyerPartyReference;
        public PartyReference BuyerPartyReference
        {
            get
            {
                if (this.buyerPartyReference != null)
                {
                    return this.buyerPartyReference; 
                }
                else if (this.buyerPartyReferenceIDRef != null)
                {
                    buyerPartyReference = IDManager.getID(buyerPartyReferenceIDRef) as PartyReference;
                    return this.buyerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.buyerPartyReference != value)
                {
                    this.buyerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region BuyerAccountReference
        private AccountReference buyerAccountReference;
        public AccountReference BuyerAccountReference
        {
            get
            {
                if (this.buyerAccountReference != null)
                {
                    return this.buyerAccountReference; 
                }
                else if (this.buyerAccountReferenceIDRef != null)
                {
                    buyerAccountReference = IDManager.getID(buyerAccountReferenceIDRef) as AccountReference;
                    return this.buyerAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.buyerAccountReference != value)
                {
                    this.buyerAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region SellerPartyReference
        private PartyReference sellerPartyReference;
        public PartyReference SellerPartyReference
        {
            get
            {
                if (this.sellerPartyReference != null)
                {
                    return this.sellerPartyReference; 
                }
                else if (this.sellerPartyReferenceIDRef != null)
                {
                    sellerPartyReference = IDManager.getID(sellerPartyReferenceIDRef) as PartyReference;
                    return this.sellerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sellerPartyReference != value)
                {
                    this.sellerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region SellerAccountReference
        private AccountReference sellerAccountReference;
        public AccountReference SellerAccountReference
        {
            get
            {
                if (this.sellerAccountReference != null)
                {
                    return this.sellerAccountReference; 
                }
                else if (this.sellerAccountReferenceIDRef != null)
                {
                    sellerAccountReference = IDManager.getID(sellerAccountReferenceIDRef) as AccountReference;
                    return this.sellerAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sellerAccountReference != value)
                {
                    this.sellerAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region OptionType
        private PutCallEnum optionType;
        public PutCallEnum OptionType
        {
            get
            {
                if (this.optionType != null)
                {
                    return this.optionType; 
                }
                else if (this.optionTypeIDRef != null)
                {
                    optionType = IDManager.getID(optionTypeIDRef) as PutCallEnum;
                    return this.optionType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionType != value)
                {
                    this.optionType = value;
                }
            }
        }
        #endregion
        
        public string PutCallEnumIDRef { get; set; }
        #region Commodity
        private Commodity commodity;
        public Commodity Commodity
        {
            get
            {
                if (this.commodity != null)
                {
                    return this.commodity; 
                }
                else if (this.commodityIDRef != null)
                {
                    commodity = IDManager.getID(commodityIDRef) as Commodity;
                    return this.commodity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commodity != value)
                {
                    this.commodity = value;
                }
            }
        }
        #endregion
        
        public string CommodityIDRef { get; set; }
        #region EffectiveDate
        private AdjustableOrRelativeDate effectiveDate;
        public AdjustableOrRelativeDate EffectiveDate
        {
            get
            {
                if (this.effectiveDate != null)
                {
                    return this.effectiveDate; 
                }
                else if (this.effectiveDateIDRef != null)
                {
                    effectiveDate = IDManager.getID(effectiveDateIDRef) as AdjustableOrRelativeDate;
                    return this.effectiveDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.effectiveDate != value)
                {
                    this.effectiveDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region TerminationDate
        private AdjustableOrRelativeDate terminationDate;
        public AdjustableOrRelativeDate TerminationDate
        {
            get
            {
                if (this.terminationDate != null)
                {
                    return this.terminationDate; 
                }
                else if (this.terminationDateIDRef != null)
                {
                    terminationDate = IDManager.getID(terminationDateIDRef) as AdjustableOrRelativeDate;
                    return this.terminationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.terminationDate != value)
                {
                    this.terminationDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region CalculationPeriodsSchedule
        private CommodityCalculationPeriodsSchedule calculationPeriodsSchedule;
        public CommodityCalculationPeriodsSchedule CalculationPeriodsSchedule
        {
            get
            {
                if (this.calculationPeriodsSchedule != null)
                {
                    return this.calculationPeriodsSchedule; 
                }
                else if (this.calculationPeriodsScheduleIDRef != null)
                {
                    calculationPeriodsSchedule = IDManager.getID(calculationPeriodsScheduleIDRef) as CommodityCalculationPeriodsSchedule;
                    return this.calculationPeriodsSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodsSchedule != value)
                {
                    this.calculationPeriodsSchedule = value;
                }
            }
        }
        #endregion
        
        public string CommodityCalculationPeriodsScheduleIDRef { get; set; }
        #region CalculationPeriods
        private AdjustableDates calculationPeriods;
        public AdjustableDates CalculationPeriods
        {
            get
            {
                if (this.calculationPeriods != null)
                {
                    return this.calculationPeriods; 
                }
                else if (this.calculationPeriodsIDRef != null)
                {
                    calculationPeriods = IDManager.getID(calculationPeriodsIDRef) as AdjustableDates;
                    return this.calculationPeriods; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriods != value)
                {
                    this.calculationPeriods = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDatesIDRef { get; set; }
        #region PricingDates
        private CommodityPricingDates pricingDates;
        public CommodityPricingDates PricingDates
        {
            get
            {
                if (this.pricingDates != null)
                {
                    return this.pricingDates; 
                }
                else if (this.pricingDatesIDRef != null)
                {
                    pricingDates = IDManager.getID(pricingDatesIDRef) as CommodityPricingDates;
                    return this.pricingDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pricingDates != value)
                {
                    this.pricingDates = value;
                }
            }
        }
        #endregion
        
        public string CommodityPricingDatesIDRef { get; set; }
        #region AveragingMethod
        private AveragingMethodEnum averagingMethod;
        public AveragingMethodEnum AveragingMethod
        {
            get
            {
                if (this.averagingMethod != null)
                {
                    return this.averagingMethod; 
                }
                else if (this.averagingMethodIDRef != null)
                {
                    averagingMethod = IDManager.getID(averagingMethodIDRef) as AveragingMethodEnum;
                    return this.averagingMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averagingMethod != value)
                {
                    this.averagingMethod = value;
                }
            }
        }
        #endregion
        
        public string AveragingMethodEnumIDRef { get; set; }
        #region NotionalQuantitySchedule
        private CommodityNotionalQuantitySchedule notionalQuantitySchedule;
        public CommodityNotionalQuantitySchedule NotionalQuantitySchedule
        {
            get
            {
                if (this.notionalQuantitySchedule != null)
                {
                    return this.notionalQuantitySchedule; 
                }
                else if (this.notionalQuantityScheduleIDRef != null)
                {
                    notionalQuantitySchedule = IDManager.getID(notionalQuantityScheduleIDRef) as CommodityNotionalQuantitySchedule;
                    return this.notionalQuantitySchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalQuantitySchedule != value)
                {
                    this.notionalQuantitySchedule = value;
                }
            }
        }
        #endregion
        
        public string CommodityNotionalQuantityScheduleIDRef { get; set; }
        #region NotionalQuantity
        private CommodityNotionalQuantity notionalQuantity;
        public CommodityNotionalQuantity NotionalQuantity
        {
            get
            {
                if (this.notionalQuantity != null)
                {
                    return this.notionalQuantity; 
                }
                else if (this.notionalQuantityIDRef != null)
                {
                    notionalQuantity = IDManager.getID(notionalQuantityIDRef) as CommodityNotionalQuantity;
                    return this.notionalQuantity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalQuantity != value)
                {
                    this.notionalQuantity = value;
                }
            }
        }
        #endregion
        
        public string CommodityNotionalQuantityIDRef { get; set; }
        #region SettlementPeriodsNotionalQuantity
        private List<CommoditySettlementPeriodsNotionalQuantity> settlementPeriodsNotionalQuantity;
        public List<CommoditySettlementPeriodsNotionalQuantity> SettlementPeriodsNotionalQuantity
        {
            get
            {
                if (this.settlementPeriodsNotionalQuantity != null)
                {
                    return this.settlementPeriodsNotionalQuantity; 
                }
                else if (this.settlementPeriodsNotionalQuantityIDRef != null)
                {
                    settlementPeriodsNotionalQuantity = IDManager.getID(settlementPeriodsNotionalQuantityIDRef) as List<CommoditySettlementPeriodsNotionalQuantity>;
                    return this.settlementPeriodsNotionalQuantity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementPeriodsNotionalQuantity != value)
                {
                    this.settlementPeriodsNotionalQuantity = value;
                }
            }
        }
        #endregion
        
        public string CommoditySettlementPeriodsNotionalQuantityIDRef { get; set; }
        #region TotalNotionalQuantity
        private XsdTypeDecimal totalNotionalQuantity;
        public XsdTypeDecimal TotalNotionalQuantity
        {
            get
            {
                if (this.totalNotionalQuantity != null)
                {
                    return this.totalNotionalQuantity; 
                }
                else if (this.totalNotionalQuantityIDRef != null)
                {
                    totalNotionalQuantity = IDManager.getID(totalNotionalQuantityIDRef) as XsdTypeDecimal;
                    return this.totalNotionalQuantity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.totalNotionalQuantity != value)
                {
                    this.totalNotionalQuantity = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region QuantityReference
        private QuantityReference quantityReference;
        public QuantityReference QuantityReference
        {
            get
            {
                if (this.quantityReference != null)
                {
                    return this.quantityReference; 
                }
                else if (this.quantityReferenceIDRef != null)
                {
                    quantityReference = IDManager.getID(quantityReferenceIDRef) as QuantityReference;
                    return this.quantityReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quantityReference != value)
                {
                    this.quantityReference = value;
                }
            }
        }
        #endregion
        
        public string QuantityReferenceIDRef { get; set; }
        #region Exercise
        private CommodityExercise exercise;
        public CommodityExercise Exercise
        {
            get
            {
                if (this.exercise != null)
                {
                    return this.exercise; 
                }
                else if (this.exerciseIDRef != null)
                {
                    exercise = IDManager.getID(exerciseIDRef) as CommodityExercise;
                    return this.exercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exercise != value)
                {
                    this.exercise = value;
                }
            }
        }
        #endregion
        
        public string CommodityExerciseIDRef { get; set; }
        #region StrikePricePerUnit
        private NonNegativeMoney strikePricePerUnit;
        public NonNegativeMoney StrikePricePerUnit
        {
            get
            {
                if (this.strikePricePerUnit != null)
                {
                    return this.strikePricePerUnit; 
                }
                else if (this.strikePricePerUnitIDRef != null)
                {
                    strikePricePerUnit = IDManager.getID(strikePricePerUnitIDRef) as NonNegativeMoney;
                    return this.strikePricePerUnit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strikePricePerUnit != value)
                {
                    this.strikePricePerUnit = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region StrikePricePerUnitSchedule
        private CommodityStrikeSchedule strikePricePerUnitSchedule;
        public CommodityStrikeSchedule StrikePricePerUnitSchedule
        {
            get
            {
                if (this.strikePricePerUnitSchedule != null)
                {
                    return this.strikePricePerUnitSchedule; 
                }
                else if (this.strikePricePerUnitScheduleIDRef != null)
                {
                    strikePricePerUnitSchedule = IDManager.getID(strikePricePerUnitScheduleIDRef) as CommodityStrikeSchedule;
                    return this.strikePricePerUnitSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strikePricePerUnitSchedule != value)
                {
                    this.strikePricePerUnitSchedule = value;
                }
            }
        }
        #endregion
        
        public string CommodityStrikeScheduleIDRef { get; set; }
        #region FloatingStrikePricePerUnit
        private FloatingStrikePrice floatingStrikePricePerUnit;
        public FloatingStrikePrice FloatingStrikePricePerUnit
        {
            get
            {
                if (this.floatingStrikePricePerUnit != null)
                {
                    return this.floatingStrikePricePerUnit; 
                }
                else if (this.floatingStrikePricePerUnitIDRef != null)
                {
                    floatingStrikePricePerUnit = IDManager.getID(floatingStrikePricePerUnitIDRef) as FloatingStrikePrice;
                    return this.floatingStrikePricePerUnit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floatingStrikePricePerUnit != value)
                {
                    this.floatingStrikePricePerUnit = value;
                }
            }
        }
        #endregion
        
        public string FloatingStrikePriceIDRef { get; set; }
        #region FloatingStrikePricePerUnitSchedule
        private CommodityCalculationPeriodsSchedule floatingStrikePricePerUnitSchedule;
        public CommodityCalculationPeriodsSchedule FloatingStrikePricePerUnitSchedule
        {
            get
            {
                if (this.floatingStrikePricePerUnitSchedule != null)
                {
                    return this.floatingStrikePricePerUnitSchedule; 
                }
                else if (this.floatingStrikePricePerUnitScheduleIDRef != null)
                {
                    floatingStrikePricePerUnitSchedule = IDManager.getID(floatingStrikePricePerUnitScheduleIDRef) as CommodityCalculationPeriodsSchedule;
                    return this.floatingStrikePricePerUnitSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floatingStrikePricePerUnitSchedule != value)
                {
                    this.floatingStrikePricePerUnitSchedule = value;
                }
            }
        }
        #endregion
        
        public string CommodityCalculationPeriodsScheduleIDRef { get; set; }
        #region CommoditySwap
        private CommoditySwap commoditySwap;
        public CommoditySwap CommoditySwap
        {
            get
            {
                if (this.commoditySwap != null)
                {
                    return this.commoditySwap; 
                }
                else if (this.commoditySwapIDRef != null)
                {
                    commoditySwap = IDManager.getID(commoditySwapIDRef) as CommoditySwap;
                    return this.commoditySwap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commoditySwap != value)
                {
                    this.commoditySwap = value;
                }
            }
        }
        #endregion
        
        public string CommoditySwapIDRef { get; set; }
        #region CommodityForward
        private CommodityForward commodityForward;
        public CommodityForward CommodityForward
        {
            get
            {
                if (this.commodityForward != null)
                {
                    return this.commodityForward; 
                }
                else if (this.commodityForwardIDRef != null)
                {
                    commodityForward = IDManager.getID(commodityForwardIDRef) as CommodityForward;
                    return this.commodityForward; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commodityForward != value)
                {
                    this.commodityForward = value;
                }
            }
        }
        #endregion
        
        public string CommodityForwardIDRef { get; set; }
        #region PhysicalExercise
        private CommodityPhysicalExercise physicalExercise;
        public CommodityPhysicalExercise PhysicalExercise
        {
            get
            {
                if (this.physicalExercise != null)
                {
                    return this.physicalExercise; 
                }
                else if (this.physicalExerciseIDRef != null)
                {
                    physicalExercise = IDManager.getID(physicalExerciseIDRef) as CommodityPhysicalExercise;
                    return this.physicalExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.physicalExercise != value)
                {
                    this.physicalExercise = value;
                }
            }
        }
        #endregion
        
        public string CommodityPhysicalExerciseIDRef { get; set; }
        #region WeatherCalculationPeriods
        private WeatherCalculationPeriods weatherCalculationPeriods;
        public WeatherCalculationPeriods WeatherCalculationPeriods
        {
            get
            {
                if (this.weatherCalculationPeriods != null)
                {
                    return this.weatherCalculationPeriods; 
                }
                else if (this.weatherCalculationPeriodsIDRef != null)
                {
                    weatherCalculationPeriods = IDManager.getID(weatherCalculationPeriodsIDRef) as WeatherCalculationPeriods;
                    return this.weatherCalculationPeriods; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherCalculationPeriods != value)
                {
                    this.weatherCalculationPeriods = value;
                }
            }
        }
        #endregion
        
        public string WeatherCalculationPeriodsIDRef { get; set; }
        #region WeatherCalculationPeriodsReference
        private CalculationPeriodsReference weatherCalculationPeriodsReference;
        public CalculationPeriodsReference WeatherCalculationPeriodsReference
        {
            get
            {
                if (this.weatherCalculationPeriodsReference != null)
                {
                    return this.weatherCalculationPeriodsReference; 
                }
                else if (this.weatherCalculationPeriodsReferenceIDRef != null)
                {
                    weatherCalculationPeriodsReference = IDManager.getID(weatherCalculationPeriodsReferenceIDRef) as CalculationPeriodsReference;
                    return this.weatherCalculationPeriodsReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherCalculationPeriodsReference != value)
                {
                    this.weatherCalculationPeriodsReference = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodsReferenceIDRef { get; set; }
        #region WeatherNotionalAmount
        private NonNegativeMoney weatherNotionalAmount;
        public NonNegativeMoney WeatherNotionalAmount
        {
            get
            {
                if (this.weatherNotionalAmount != null)
                {
                    return this.weatherNotionalAmount; 
                }
                else if (this.weatherNotionalAmountIDRef != null)
                {
                    weatherNotionalAmount = IDManager.getID(weatherNotionalAmountIDRef) as NonNegativeMoney;
                    return this.weatherNotionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherNotionalAmount != value)
                {
                    this.weatherNotionalAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region WeatherIndexStrikeLevel
        private WeatherIndex weatherIndexStrikeLevel;
        public WeatherIndex WeatherIndexStrikeLevel
        {
            get
            {
                if (this.weatherIndexStrikeLevel != null)
                {
                    return this.weatherIndexStrikeLevel; 
                }
                else if (this.weatherIndexStrikeLevelIDRef != null)
                {
                    weatherIndexStrikeLevel = IDManager.getID(weatherIndexStrikeLevelIDRef) as WeatherIndex;
                    return this.weatherIndexStrikeLevel; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherIndexStrikeLevel != value)
                {
                    this.weatherIndexStrikeLevel = value;
                }
            }
        }
        #endregion
        
        public string WeatherIndexIDRef { get; set; }
        #region Calculation
        private WeatherLegCalculation calculation;
        public WeatherLegCalculation Calculation
        {
            get
            {
                if (this.calculation != null)
                {
                    return this.calculation; 
                }
                else if (this.calculationIDRef != null)
                {
                    calculation = IDManager.getID(calculationIDRef) as WeatherLegCalculation;
                    return this.calculation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculation != value)
                {
                    this.calculation = value;
                }
            }
        }
        #endregion
        
        public string WeatherLegCalculationIDRef { get; set; }
        #region WeatherIndexData
        private WeatherIndexData weatherIndexData;
        public WeatherIndexData WeatherIndexData
        {
            get
            {
                if (this.weatherIndexData != null)
                {
                    return this.weatherIndexData; 
                }
                else if (this.weatherIndexDataIDRef != null)
                {
                    weatherIndexData = IDManager.getID(weatherIndexDataIDRef) as WeatherIndexData;
                    return this.weatherIndexData; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherIndexData != value)
                {
                    this.weatherIndexData = value;
                }
            }
        }
        #endregion
        
        public string WeatherIndexDataIDRef { get; set; }
        #region Premium
        private List<CommodityPremium> premium;
        public List<CommodityPremium> Premium
        {
            get
            {
                if (this.premium != null)
                {
                    return this.premium; 
                }
                else if (this.premiumIDRef != null)
                {
                    premium = IDManager.getID(premiumIDRef) as List<CommodityPremium>;
                    return this.premium; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.premium != value)
                {
                    this.premium = value;
                }
            }
        }
        #endregion
        
        public string CommodityPremiumIDRef { get; set; }
        #region CommonPricing
        private XsdTypeBoolean commonPricing;
        public XsdTypeBoolean CommonPricing
        {
            get
            {
                if (this.commonPricing != null)
                {
                    return this.commonPricing; 
                }
                else if (this.commonPricingIDRef != null)
                {
                    commonPricing = IDManager.getID(commonPricingIDRef) as XsdTypeBoolean;
                    return this.commonPricing; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commonPricing != value)
                {
                    this.commonPricing = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region MarketDisruption
        private CommodityMarketDisruption marketDisruption;
        public CommodityMarketDisruption MarketDisruption
        {
            get
            {
                if (this.marketDisruption != null)
                {
                    return this.marketDisruption; 
                }
                else if (this.marketDisruptionIDRef != null)
                {
                    marketDisruption = IDManager.getID(marketDisruptionIDRef) as CommodityMarketDisruption;
                    return this.marketDisruption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.marketDisruption != value)
                {
                    this.marketDisruption = value;
                }
            }
        }
        #endregion
        
        public string CommodityMarketDisruptionIDRef { get; set; }
        #region SettlementDisruption
        private CommodityBullionSettlementDisruptionEnum settlementDisruption;
        public CommodityBullionSettlementDisruptionEnum SettlementDisruption
        {
            get
            {
                if (this.settlementDisruption != null)
                {
                    return this.settlementDisruption; 
                }
                else if (this.settlementDisruptionIDRef != null)
                {
                    settlementDisruption = IDManager.getID(settlementDisruptionIDRef) as CommodityBullionSettlementDisruptionEnum;
                    return this.settlementDisruption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementDisruption != value)
                {
                    this.settlementDisruption = value;
                }
            }
        }
        #endregion
        
        public string CommodityBullionSettlementDisruptionEnumIDRef { get; set; }
        #region Rounding
        private Rounding rounding;
        public Rounding Rounding
        {
            get
            {
                if (this.rounding != null)
                {
                    return this.rounding; 
                }
                else if (this.roundingIDRef != null)
                {
                    rounding = IDManager.getID(roundingIDRef) as Rounding;
                    return this.rounding; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rounding != value)
                {
                    this.rounding = value;
                }
            }
        }
        #endregion
        
        public string RoundingIDRef { get; set; }
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

