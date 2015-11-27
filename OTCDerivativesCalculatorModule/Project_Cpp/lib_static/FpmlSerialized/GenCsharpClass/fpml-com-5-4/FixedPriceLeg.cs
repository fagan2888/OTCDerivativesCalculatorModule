using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FixedPriceLeg
    {
        public FixedPriceLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList calculationDatesNodeList = xmlNode.SelectNodes("calculationDates");
            if (calculationDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationDatesIDRef = item.Attributes["id"].Name;
                        AdjustableDates ob = AdjustableDates();
                        IDManager.SetID(calculationDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationDates = new AdjustableDates(item);
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
            
        
            XmlNodeList fixedPriceScheduleNodeList = xmlNode.SelectNodes("fixedPriceSchedule");
            if (fixedPriceScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedPriceScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedPriceScheduleIDRef = item.Attributes["id"].Name;
                        CommodityFixedPriceSchedule ob = CommodityFixedPriceSchedule();
                        IDManager.SetID(fixedPriceScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedPriceScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedPriceSchedule = new CommodityFixedPriceSchedule(item);
                    }
                }
            }
            
        
            XmlNodeList fixedPriceNodeList = xmlNode.SelectNodes("fixedPrice");
            if (fixedPriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedPriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedPriceIDRef = item.Attributes["id"].Name;
                        FixedPrice ob = FixedPrice();
                        IDManager.SetID(fixedPriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedPriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedPrice = new FixedPrice(item);
                    }
                }
            }
            
        
            XmlNodeList worldscaleRateNodeList = xmlNode.SelectNodes("worldscaleRate");
            if (worldscaleRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in worldscaleRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        worldscaleRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(worldscaleRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        worldscaleRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        worldscaleRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList contractRateNodeList = xmlNode.SelectNodes("contractRate");
            if (contractRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in contractRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        contractRateIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(contractRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        contractRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        contractRate = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList settlementPeriodsPriceNodeList = xmlNode.SelectNodes("settlementPeriodsPrice");
            
            foreach (XmlNode item in settlementPeriodsPriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementPeriodsPriceIDRef = item.Attributes["id"].Name;
                        List<SettlementPeriodsFixedPrice> ob = new List<SettlementPeriodsFixedPrice>();
                        ob.Add(new SettlementPeriodsFixedPrice(item));
                        IDManager.SetID(settlementPeriodsPriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementPeriodsPriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    settlementPeriodsPrice.Add(new SettlementPeriodsFixedPrice(item));
                    }
                }
            }
            
        
            XmlNodeList totalPriceNodeList = xmlNode.SelectNodes("totalPrice");
            if (totalPriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in totalPriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        totalPriceIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(totalPriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        totalPriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        totalPrice = new NonNegativeMoney(item);
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
            
        
            XmlNodeList relativePaymentDatesNodeList = xmlNode.SelectNodes("relativePaymentDates");
            if (relativePaymentDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relativePaymentDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relativePaymentDatesIDRef = item.Attributes["id"].Name;
                        CommodityRelativePaymentDates ob = CommodityRelativePaymentDates();
                        IDManager.SetID(relativePaymentDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relativePaymentDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relativePaymentDates = new CommodityRelativePaymentDates(item);
                    }
                }
            }
            
        
            XmlNodeList paymentDatesNodeList = xmlNode.SelectNodes("paymentDates");
            if (paymentDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDatesIDRef = item.Attributes["id"].Name;
                        AdjustableDatesOrRelativeDateOffset ob = AdjustableDatesOrRelativeDateOffset();
                        IDManager.SetID(paymentDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDates = new AdjustableDatesOrRelativeDateOffset(item);
                    }
                }
            }
            
        
            XmlNodeList masterAgreementPaymentDatesNodeList = xmlNode.SelectNodes("masterAgreementPaymentDates");
            if (masterAgreementPaymentDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in masterAgreementPaymentDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        masterAgreementPaymentDatesIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(masterAgreementPaymentDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        masterAgreementPaymentDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        masterAgreementPaymentDates = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList flatRateNodeList = xmlNode.SelectNodes("flatRate");
            if (flatRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in flatRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        flatRateIDRef = item.Attributes["id"].Name;
                        FlatRateEnum ob = FlatRateEnum();
                        IDManager.SetID(flatRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        flatRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        flatRate = new FlatRateEnum(item);
                    }
                }
            }
            
        
            XmlNodeList flatRateAmountNodeList = xmlNode.SelectNodes("flatRateAmount");
            if (flatRateAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in flatRateAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        flatRateAmountIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(flatRateAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        flatRateAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        flatRateAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
        }
        
    
        #region CalculationDates
        private AdjustableDates calculationDates;
        public AdjustableDates CalculationDates
        {
            get
            {
                if (this.calculationDates != null)
                {
                    return this.calculationDates; 
                }
                else if (this.calculationDatesIDRef != null)
                {
                    calculationDates = IDManager.getID(calculationDatesIDRef) as AdjustableDates;
                    return this.calculationDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationDates != value)
                {
                    this.calculationDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDatesIDRef { get; set; }
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
        #region FixedPriceSchedule
        private CommodityFixedPriceSchedule fixedPriceSchedule;
        public CommodityFixedPriceSchedule FixedPriceSchedule
        {
            get
            {
                if (this.fixedPriceSchedule != null)
                {
                    return this.fixedPriceSchedule; 
                }
                else if (this.fixedPriceScheduleIDRef != null)
                {
                    fixedPriceSchedule = IDManager.getID(fixedPriceScheduleIDRef) as CommodityFixedPriceSchedule;
                    return this.fixedPriceSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedPriceSchedule != value)
                {
                    this.fixedPriceSchedule = value;
                }
            }
        }
        #endregion
        
        public string CommodityFixedPriceScheduleIDRef { get; set; }
        #region FixedPrice
        private FixedPrice fixedPrice;
        public FixedPrice FixedPrice
        {
            get
            {
                if (this.fixedPrice != null)
                {
                    return this.fixedPrice; 
                }
                else if (this.fixedPriceIDRef != null)
                {
                    fixedPrice = IDManager.getID(fixedPriceIDRef) as FixedPrice;
                    return this.fixedPrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedPrice != value)
                {
                    this.fixedPrice = value;
                }
            }
        }
        #endregion
        
        public string FixedPriceIDRef { get; set; }
        #region WorldscaleRate
        private XsdTypeDecimal worldscaleRate;
        public XsdTypeDecimal WorldscaleRate
        {
            get
            {
                if (this.worldscaleRate != null)
                {
                    return this.worldscaleRate; 
                }
                else if (this.worldscaleRateIDRef != null)
                {
                    worldscaleRate = IDManager.getID(worldscaleRateIDRef) as XsdTypeDecimal;
                    return this.worldscaleRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.worldscaleRate != value)
                {
                    this.worldscaleRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region ContractRate
        private NonNegativeMoney contractRate;
        public NonNegativeMoney ContractRate
        {
            get
            {
                if (this.contractRate != null)
                {
                    return this.contractRate; 
                }
                else if (this.contractRateIDRef != null)
                {
                    contractRate = IDManager.getID(contractRateIDRef) as NonNegativeMoney;
                    return this.contractRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.contractRate != value)
                {
                    this.contractRate = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region SettlementPeriodsPrice
        private List<SettlementPeriodsFixedPrice> settlementPeriodsPrice;
        public List<SettlementPeriodsFixedPrice> SettlementPeriodsPrice
        {
            get
            {
                if (this.settlementPeriodsPrice != null)
                {
                    return this.settlementPeriodsPrice; 
                }
                else if (this.settlementPeriodsPriceIDRef != null)
                {
                    settlementPeriodsPrice = IDManager.getID(settlementPeriodsPriceIDRef) as List<SettlementPeriodsFixedPrice>;
                    return this.settlementPeriodsPrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementPeriodsPrice != value)
                {
                    this.settlementPeriodsPrice = value;
                }
            }
        }
        #endregion
        
        public string SettlementPeriodsFixedPriceIDRef { get; set; }
        #region TotalPrice
        private NonNegativeMoney totalPrice;
        public NonNegativeMoney TotalPrice
        {
            get
            {
                if (this.totalPrice != null)
                {
                    return this.totalPrice; 
                }
                else if (this.totalPriceIDRef != null)
                {
                    totalPrice = IDManager.getID(totalPriceIDRef) as NonNegativeMoney;
                    return this.totalPrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.totalPrice != value)
                {
                    this.totalPrice = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
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
        #region RelativePaymentDates
        private CommodityRelativePaymentDates relativePaymentDates;
        public CommodityRelativePaymentDates RelativePaymentDates
        {
            get
            {
                if (this.relativePaymentDates != null)
                {
                    return this.relativePaymentDates; 
                }
                else if (this.relativePaymentDatesIDRef != null)
                {
                    relativePaymentDates = IDManager.getID(relativePaymentDatesIDRef) as CommodityRelativePaymentDates;
                    return this.relativePaymentDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relativePaymentDates != value)
                {
                    this.relativePaymentDates = value;
                }
            }
        }
        #endregion
        
        public string CommodityRelativePaymentDatesIDRef { get; set; }
        #region PaymentDates
        private AdjustableDatesOrRelativeDateOffset paymentDates;
        public AdjustableDatesOrRelativeDateOffset PaymentDates
        {
            get
            {
                if (this.paymentDates != null)
                {
                    return this.paymentDates; 
                }
                else if (this.paymentDatesIDRef != null)
                {
                    paymentDates = IDManager.getID(paymentDatesIDRef) as AdjustableDatesOrRelativeDateOffset;
                    return this.paymentDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDates != value)
                {
                    this.paymentDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDatesOrRelativeDateOffsetIDRef { get; set; }
        #region MasterAgreementPaymentDates
        private XsdTypeBoolean masterAgreementPaymentDates;
        public XsdTypeBoolean MasterAgreementPaymentDates
        {
            get
            {
                if (this.masterAgreementPaymentDates != null)
                {
                    return this.masterAgreementPaymentDates; 
                }
                else if (this.masterAgreementPaymentDatesIDRef != null)
                {
                    masterAgreementPaymentDates = IDManager.getID(masterAgreementPaymentDatesIDRef) as XsdTypeBoolean;
                    return this.masterAgreementPaymentDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.masterAgreementPaymentDates != value)
                {
                    this.masterAgreementPaymentDates = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region FlatRate
        private FlatRateEnum flatRate;
        public FlatRateEnum FlatRate
        {
            get
            {
                if (this.flatRate != null)
                {
                    return this.flatRate; 
                }
                else if (this.flatRateIDRef != null)
                {
                    flatRate = IDManager.getID(flatRateIDRef) as FlatRateEnum;
                    return this.flatRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.flatRate != value)
                {
                    this.flatRate = value;
                }
            }
        }
        #endregion
        
        public string FlatRateEnumIDRef { get; set; }
        #region FlatRateAmount
        private NonNegativeMoney flatRateAmount;
        public NonNegativeMoney FlatRateAmount
        {
            get
            {
                if (this.flatRateAmount != null)
                {
                    return this.flatRateAmount; 
                }
                else if (this.flatRateAmountIDRef != null)
                {
                    flatRateAmount = IDManager.getID(flatRateAmountIDRef) as NonNegativeMoney;
                    return this.flatRateAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.flatRateAmount != value)
                {
                    this.flatRateAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
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

