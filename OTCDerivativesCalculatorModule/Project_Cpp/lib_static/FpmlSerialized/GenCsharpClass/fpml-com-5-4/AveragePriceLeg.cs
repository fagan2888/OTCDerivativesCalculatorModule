using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AveragePriceLeg
    {
        public AveragePriceLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList payerPartyReferenceNodeList = xmlNode.SelectNodes("payerPartyReference");
            if (payerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in payerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        payerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(payerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        payerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList payerAccountReferenceNodeList = xmlNode.SelectNodes("payerAccountReference");
            if (payerAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in payerAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        payerAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(payerAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        payerAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payerAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList receiverPartyReferenceNodeList = xmlNode.SelectNodes("receiverPartyReference");
            if (receiverPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in receiverPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        receiverPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(receiverPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        receiverPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        receiverPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList receiverAccountReferenceNodeList = xmlNode.SelectNodes("receiverAccountReference");
            if (receiverAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in receiverAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        receiverAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(receiverAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        receiverAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        receiverAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
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
            
        
            XmlNodeList pricingStartDateNodeList = xmlNode.SelectNodes("pricingStartDate");
            if (pricingStartDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in pricingStartDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pricingStartDateIDRef = item.Attributes["id"].Name;
                        AdjustableDate ob = AdjustableDate();
                        IDManager.SetID(pricingStartDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pricingStartDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        pricingStartDate = new AdjustableDate(item);
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
                        FloatingLegCalculation ob = FloatingLegCalculation();
                        IDManager.SetID(calculationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculation = new FloatingLegCalculation(item);
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
            
        
        }
        
    
        #region PayerPartyReference
        private PartyReference payerPartyReference;
        public PartyReference PayerPartyReference
        {
            get
            {
                if (this.payerPartyReference != null)
                {
                    return this.payerPartyReference; 
                }
                else if (this.payerPartyReferenceIDRef != null)
                {
                    payerPartyReference = IDManager.getID(payerPartyReferenceIDRef) as PartyReference;
                    return this.payerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payerPartyReference != value)
                {
                    this.payerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region PayerAccountReference
        private AccountReference payerAccountReference;
        public AccountReference PayerAccountReference
        {
            get
            {
                if (this.payerAccountReference != null)
                {
                    return this.payerAccountReference; 
                }
                else if (this.payerAccountReferenceIDRef != null)
                {
                    payerAccountReference = IDManager.getID(payerAccountReferenceIDRef) as AccountReference;
                    return this.payerAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payerAccountReference != value)
                {
                    this.payerAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region ReceiverPartyReference
        private PartyReference receiverPartyReference;
        public PartyReference ReceiverPartyReference
        {
            get
            {
                if (this.receiverPartyReference != null)
                {
                    return this.receiverPartyReference; 
                }
                else if (this.receiverPartyReferenceIDRef != null)
                {
                    receiverPartyReference = IDManager.getID(receiverPartyReferenceIDRef) as PartyReference;
                    return this.receiverPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.receiverPartyReference != value)
                {
                    this.receiverPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region ReceiverAccountReference
        private AccountReference receiverAccountReference;
        public AccountReference ReceiverAccountReference
        {
            get
            {
                if (this.receiverAccountReference != null)
                {
                    return this.receiverAccountReference; 
                }
                else if (this.receiverAccountReferenceIDRef != null)
                {
                    receiverAccountReference = IDManager.getID(receiverAccountReferenceIDRef) as AccountReference;
                    return this.receiverAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.receiverAccountReference != value)
                {
                    this.receiverAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
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
        #region PricingStartDate
        private AdjustableDate pricingStartDate;
        public AdjustableDate PricingStartDate
        {
            get
            {
                if (this.pricingStartDate != null)
                {
                    return this.pricingStartDate; 
                }
                else if (this.pricingStartDateIDRef != null)
                {
                    pricingStartDate = IDManager.getID(pricingStartDateIDRef) as AdjustableDate;
                    return this.pricingStartDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pricingStartDate != value)
                {
                    this.pricingStartDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDateIDRef { get; set; }
        #region Calculation
        private FloatingLegCalculation calculation;
        public FloatingLegCalculation Calculation
        {
            get
            {
                if (this.calculation != null)
                {
                    return this.calculation; 
                }
                else if (this.calculationIDRef != null)
                {
                    calculation = IDManager.getID(calculationIDRef) as FloatingLegCalculation;
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
        
        public string FloatingLegCalculationIDRef { get; set; }
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
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        public string choiceStr_3;
        
    
        
    
    }
    
}

