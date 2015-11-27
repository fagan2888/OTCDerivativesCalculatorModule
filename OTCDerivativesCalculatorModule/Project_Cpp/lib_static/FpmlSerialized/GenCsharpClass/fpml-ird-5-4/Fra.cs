using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Fra
    {
        public Fra(XmlNode xmlNode)
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
            
        
            XmlNodeList adjustedEffectiveDateNodeList = xmlNode.SelectNodes("adjustedEffectiveDate");
            if (adjustedEffectiveDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustedEffectiveDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedEffectiveDateIDRef = item.Attributes["id"].Name;
                        RequiredIdentifierDate ob = RequiredIdentifierDate();
                        IDManager.SetID(adjustedEffectiveDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedEffectiveDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustedEffectiveDate = new RequiredIdentifierDate(item);
                    }
                }
            }
            
        
            XmlNodeList adjustedTerminationDateNodeList = xmlNode.SelectNodes("adjustedTerminationDate");
            if (adjustedTerminationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in adjustedTerminationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        adjustedTerminationDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(adjustedTerminationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        adjustedTerminationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        adjustedTerminationDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList paymentDateNodeList = xmlNode.SelectNodes("paymentDate");
            if (paymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDateIDRef = item.Attributes["id"].Name;
                        AdjustableDate ob = AdjustableDate();
                        IDManager.SetID(paymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDate = new AdjustableDate(item);
                    }
                }
            }
            
        
            XmlNodeList fixingDateOffsetNodeList = xmlNode.SelectNodes("fixingDateOffset");
            if (fixingDateOffsetNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixingDateOffsetNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixingDateOffsetIDRef = item.Attributes["id"].Name;
                        RelativeDateOffset ob = RelativeDateOffset();
                        IDManager.SetID(fixingDateOffsetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixingDateOffsetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixingDateOffset = new RelativeDateOffset(item);
                    }
                }
            }
            
        
            XmlNodeList dayCountFractionNodeList = xmlNode.SelectNodes("dayCountFraction");
            if (dayCountFractionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dayCountFractionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dayCountFractionIDRef = item.Attributes["id"].Name;
                        DayCountFraction ob = DayCountFraction();
                        IDManager.SetID(dayCountFractionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dayCountFractionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dayCountFraction = new DayCountFraction(item);
                    }
                }
            }
            
        
            XmlNodeList calculationPeriodNumberOfDaysNodeList = xmlNode.SelectNodes("calculationPeriodNumberOfDays");
            if (calculationPeriodNumberOfDaysNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodNumberOfDaysNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodNumberOfDaysIDRef = item.Attributes["id"].Name;
                        XsdTypePositiveInteger ob = XsdTypePositiveInteger();
                        IDManager.SetID(calculationPeriodNumberOfDaysIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodNumberOfDaysIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodNumberOfDays = new XsdTypePositiveInteger(item);
                    }
                }
            }
            
        
            XmlNodeList notionalNodeList = xmlNode.SelectNodes("notional");
            if (notionalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(notionalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notional = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList fixedRateNodeList = xmlNode.SelectNodes("fixedRate");
            if (fixedRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(fixedRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList floatingRateIndexNodeList = xmlNode.SelectNodes("floatingRateIndex");
            if (floatingRateIndexNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in floatingRateIndexNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floatingRateIndexIDRef = item.Attributes["id"].Name;
                        FloatingRateIndex ob = FloatingRateIndex();
                        IDManager.SetID(floatingRateIndexIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floatingRateIndexIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        floatingRateIndex = new FloatingRateIndex(item);
                    }
                }
            }
            
        
            XmlNodeList indexTenorNodeList = xmlNode.SelectNodes("indexTenor");
            
            foreach (XmlNode item in indexTenorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexTenorIDRef = item.Attributes["id"].Name;
                        List<Period> ob = new List<Period>();
                        ob.Add(new Period(item));
                        IDManager.SetID(indexTenorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexTenorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    indexTenor.Add(new Period(item));
                    }
                }
            }
            
        
            XmlNodeList fraDiscountingNodeList = xmlNode.SelectNodes("fraDiscounting");
            if (fraDiscountingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fraDiscountingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fraDiscountingIDRef = item.Attributes["id"].Name;
                        FraDiscountingEnum ob = FraDiscountingEnum();
                        IDManager.SetID(fraDiscountingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fraDiscountingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fraDiscounting = new FraDiscountingEnum(item);
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
        #region AdjustedEffectiveDate
        private RequiredIdentifierDate adjustedEffectiveDate;
        public RequiredIdentifierDate AdjustedEffectiveDate
        {
            get
            {
                if (this.adjustedEffectiveDate != null)
                {
                    return this.adjustedEffectiveDate; 
                }
                else if (this.adjustedEffectiveDateIDRef != null)
                {
                    adjustedEffectiveDate = IDManager.getID(adjustedEffectiveDateIDRef) as RequiredIdentifierDate;
                    return this.adjustedEffectiveDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedEffectiveDate != value)
                {
                    this.adjustedEffectiveDate = value;
                }
            }
        }
        #endregion
        
        public string RequiredIdentifierDateIDRef { get; set; }
        #region AdjustedTerminationDate
        private XsdTypeDate adjustedTerminationDate;
        public XsdTypeDate AdjustedTerminationDate
        {
            get
            {
                if (this.adjustedTerminationDate != null)
                {
                    return this.adjustedTerminationDate; 
                }
                else if (this.adjustedTerminationDateIDRef != null)
                {
                    adjustedTerminationDate = IDManager.getID(adjustedTerminationDateIDRef) as XsdTypeDate;
                    return this.adjustedTerminationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.adjustedTerminationDate != value)
                {
                    this.adjustedTerminationDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region PaymentDate
        private AdjustableDate paymentDate;
        public AdjustableDate PaymentDate
        {
            get
            {
                if (this.paymentDate != null)
                {
                    return this.paymentDate; 
                }
                else if (this.paymentDateIDRef != null)
                {
                    paymentDate = IDManager.getID(paymentDateIDRef) as AdjustableDate;
                    return this.paymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDate != value)
                {
                    this.paymentDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDateIDRef { get; set; }
        #region FixingDateOffset
        private RelativeDateOffset fixingDateOffset;
        public RelativeDateOffset FixingDateOffset
        {
            get
            {
                if (this.fixingDateOffset != null)
                {
                    return this.fixingDateOffset; 
                }
                else if (this.fixingDateOffsetIDRef != null)
                {
                    fixingDateOffset = IDManager.getID(fixingDateOffsetIDRef) as RelativeDateOffset;
                    return this.fixingDateOffset; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixingDateOffset != value)
                {
                    this.fixingDateOffset = value;
                }
            }
        }
        #endregion
        
        public string RelativeDateOffsetIDRef { get; set; }
        #region DayCountFraction
        private DayCountFraction dayCountFraction;
        public DayCountFraction DayCountFraction
        {
            get
            {
                if (this.dayCountFraction != null)
                {
                    return this.dayCountFraction; 
                }
                else if (this.dayCountFractionIDRef != null)
                {
                    dayCountFraction = IDManager.getID(dayCountFractionIDRef) as DayCountFraction;
                    return this.dayCountFraction; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dayCountFraction != value)
                {
                    this.dayCountFraction = value;
                }
            }
        }
        #endregion
        
        public string DayCountFractionIDRef { get; set; }
        #region CalculationPeriodNumberOfDays
        private XsdTypePositiveInteger calculationPeriodNumberOfDays;
        public XsdTypePositiveInteger CalculationPeriodNumberOfDays
        {
            get
            {
                if (this.calculationPeriodNumberOfDays != null)
                {
                    return this.calculationPeriodNumberOfDays; 
                }
                else if (this.calculationPeriodNumberOfDaysIDRef != null)
                {
                    calculationPeriodNumberOfDays = IDManager.getID(calculationPeriodNumberOfDaysIDRef) as XsdTypePositiveInteger;
                    return this.calculationPeriodNumberOfDays; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodNumberOfDays != value)
                {
                    this.calculationPeriodNumberOfDays = value;
                }
            }
        }
        #endregion
        
        public string XsdTypePositiveIntegerIDRef { get; set; }
        #region Notional
        private Money notional;
        public Money Notional
        {
            get
            {
                if (this.notional != null)
                {
                    return this.notional; 
                }
                else if (this.notionalIDRef != null)
                {
                    notional = IDManager.getID(notionalIDRef) as Money;
                    return this.notional; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notional != value)
                {
                    this.notional = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region FixedRate
        private XsdTypeDecimal fixedRate;
        public XsdTypeDecimal FixedRate
        {
            get
            {
                if (this.fixedRate != null)
                {
                    return this.fixedRate; 
                }
                else if (this.fixedRateIDRef != null)
                {
                    fixedRate = IDManager.getID(fixedRateIDRef) as XsdTypeDecimal;
                    return this.fixedRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedRate != value)
                {
                    this.fixedRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region FloatingRateIndex
        private FloatingRateIndex floatingRateIndex;
        public FloatingRateIndex FloatingRateIndex
        {
            get
            {
                if (this.floatingRateIndex != null)
                {
                    return this.floatingRateIndex; 
                }
                else if (this.floatingRateIndexIDRef != null)
                {
                    floatingRateIndex = IDManager.getID(floatingRateIndexIDRef) as FloatingRateIndex;
                    return this.floatingRateIndex; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floatingRateIndex != value)
                {
                    this.floatingRateIndex = value;
                }
            }
        }
        #endregion
        
        public string FloatingRateIndexIDRef { get; set; }
        #region IndexTenor
        private List<Period> indexTenor;
        public List<Period> IndexTenor
        {
            get
            {
                if (this.indexTenor != null)
                {
                    return this.indexTenor; 
                }
                else if (this.indexTenorIDRef != null)
                {
                    indexTenor = IDManager.getID(indexTenorIDRef) as List<Period>;
                    return this.indexTenor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexTenor != value)
                {
                    this.indexTenor = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region FraDiscounting
        private FraDiscountingEnum fraDiscounting;
        public FraDiscountingEnum FraDiscounting
        {
            get
            {
                if (this.fraDiscounting != null)
                {
                    return this.fraDiscounting; 
                }
                else if (this.fraDiscountingIDRef != null)
                {
                    fraDiscounting = IDManager.getID(fraDiscountingIDRef) as FraDiscountingEnum;
                    return this.fraDiscounting; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fraDiscounting != value)
                {
                    this.fraDiscounting = value;
                }
            }
        }
        #endregion
        
        public string FraDiscountingEnumIDRef { get; set; }
        
    
        
    
    }
    
}

