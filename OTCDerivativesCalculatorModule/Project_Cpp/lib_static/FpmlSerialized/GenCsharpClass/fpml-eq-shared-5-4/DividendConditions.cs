using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DividendConditions
    {
        public DividendConditions(XmlNode xmlNode)
        {
            XmlNodeList dividendReinvestmentNodeList = xmlNode.SelectNodes("dividendReinvestment");
            if (dividendReinvestmentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendReinvestmentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendReinvestmentIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(dividendReinvestmentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendReinvestmentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendReinvestment = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList dividendEntitlementNodeList = xmlNode.SelectNodes("dividendEntitlement");
            if (dividendEntitlementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendEntitlementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendEntitlementIDRef = item.Attributes["id"].Name;
                        DividendEntitlementEnum ob = DividendEntitlementEnum();
                        IDManager.SetID(dividendEntitlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendEntitlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendEntitlement = new DividendEntitlementEnum(item);
                    }
                }
            }
            
        
            XmlNodeList dividendAmountNodeList = xmlNode.SelectNodes("dividendAmount");
            if (dividendAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendAmountIDRef = item.Attributes["id"].Name;
                        DividendAmountTypeEnum ob = DividendAmountTypeEnum();
                        IDManager.SetID(dividendAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendAmount = new DividendAmountTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList dividendPaymentDateNodeList = xmlNode.SelectNodes("dividendPaymentDate");
            if (dividendPaymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendPaymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendPaymentDateIDRef = item.Attributes["id"].Name;
                        DividendPaymentDate ob = DividendPaymentDate();
                        IDManager.SetID(dividendPaymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendPaymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendPaymentDate = new DividendPaymentDate(item);
                    }
                }
            }
            
        
            XmlNodeList dividendPeriodEffectiveDateNodeList = xmlNode.SelectNodes("dividendPeriodEffectiveDate");
            if (dividendPeriodEffectiveDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendPeriodEffectiveDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendPeriodEffectiveDateIDRef = item.Attributes["id"].Name;
                        DateReference ob = DateReference();
                        IDManager.SetID(dividendPeriodEffectiveDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendPeriodEffectiveDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendPeriodEffectiveDate = new DateReference(item);
                    }
                }
            }
            
        
            XmlNodeList dividendPeriodEndDateNodeList = xmlNode.SelectNodes("dividendPeriodEndDate");
            if (dividendPeriodEndDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendPeriodEndDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendPeriodEndDateIDRef = item.Attributes["id"].Name;
                        DateReference ob = DateReference();
                        IDManager.SetID(dividendPeriodEndDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendPeriodEndDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendPeriodEndDate = new DateReference(item);
                    }
                }
            }
            
        
            XmlNodeList dividendPeriodNodeList = xmlNode.SelectNodes("dividendPeriod");
            if (dividendPeriodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendPeriodIDRef = item.Attributes["id"].Name;
                        DividendPeriodEnum ob = DividendPeriodEnum();
                        IDManager.SetID(dividendPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendPeriod = new DividendPeriodEnum(item);
                    }
                }
            }
            
        
            XmlNodeList extraOrdinaryDividendsNodeList = xmlNode.SelectNodes("extraOrdinaryDividends");
            if (extraOrdinaryDividendsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in extraOrdinaryDividendsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        extraOrdinaryDividendsIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(extraOrdinaryDividendsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        extraOrdinaryDividendsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        extraOrdinaryDividends = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList excessDividendAmountNodeList = xmlNode.SelectNodes("excessDividendAmount");
            if (excessDividendAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in excessDividendAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        excessDividendAmountIDRef = item.Attributes["id"].Name;
                        DividendAmountTypeEnum ob = DividendAmountTypeEnum();
                        IDManager.SetID(excessDividendAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        excessDividendAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        excessDividendAmount = new DividendAmountTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList currencyNodeList = xmlNode.SelectNodes("currency");
            if (currencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in currencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        currencyIDRef = item.Attributes["id"].Name;
                        IdentifiedCurrency ob = IdentifiedCurrency();
                        IDManager.SetID(currencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        currencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        currency = new IdentifiedCurrency(item);
                    }
                }
            }
            
        
            XmlNodeList determinationMethodNodeList = xmlNode.SelectNodes("determinationMethod");
            if (determinationMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in determinationMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        determinationMethodIDRef = item.Attributes["id"].Name;
                        DeterminationMethod ob = DeterminationMethod();
                        IDManager.SetID(determinationMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        determinationMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        determinationMethod = new DeterminationMethod(item);
                    }
                }
            }
            
        
            XmlNodeList currencyReferenceNodeList = xmlNode.SelectNodes("currencyReference");
            if (currencyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in currencyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        currencyReferenceIDRef = item.Attributes["id"].Name;
                        IdentifiedCurrencyReference ob = IdentifiedCurrencyReference();
                        IDManager.SetID(currencyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        currencyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        currencyReference = new IdentifiedCurrencyReference(item);
                    }
                }
            }
            
        
            XmlNodeList dividendFxTriggerDateNodeList = xmlNode.SelectNodes("dividendFxTriggerDate");
            if (dividendFxTriggerDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendFxTriggerDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendFxTriggerDateIDRef = item.Attributes["id"].Name;
                        DividendPaymentDate ob = DividendPaymentDate();
                        IDManager.SetID(dividendFxTriggerDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendFxTriggerDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendFxTriggerDate = new DividendPaymentDate(item);
                    }
                }
            }
            
        
            XmlNodeList interestAccrualsMethodNodeList = xmlNode.SelectNodes("interestAccrualsMethod");
            if (interestAccrualsMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interestAccrualsMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interestAccrualsMethodIDRef = item.Attributes["id"].Name;
                        InterestAccrualsCompoundingMethod ob = InterestAccrualsCompoundingMethod();
                        IDManager.SetID(interestAccrualsMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interestAccrualsMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interestAccrualsMethod = new InterestAccrualsCompoundingMethod(item);
                    }
                }
            }
            
        
            XmlNodeList numberOfIndexUnitsNodeList = xmlNode.SelectNodes("numberOfIndexUnits");
            if (numberOfIndexUnitsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in numberOfIndexUnitsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        numberOfIndexUnitsIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(numberOfIndexUnitsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        numberOfIndexUnitsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        numberOfIndexUnits = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList declaredCashDividendPercentageNodeList = xmlNode.SelectNodes("declaredCashDividendPercentage");
            if (declaredCashDividendPercentageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in declaredCashDividendPercentageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        declaredCashDividendPercentageIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(declaredCashDividendPercentageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        declaredCashDividendPercentageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        declaredCashDividendPercentage = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList declaredCashEquivalentDividendPercentageNodeList = xmlNode.SelectNodes("declaredCashEquivalentDividendPercentage");
            if (declaredCashEquivalentDividendPercentageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in declaredCashEquivalentDividendPercentageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        declaredCashEquivalentDividendPercentageIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(declaredCashEquivalentDividendPercentageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        declaredCashEquivalentDividendPercentageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        declaredCashEquivalentDividendPercentage = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList nonCashDividendTreatmentNodeList = xmlNode.SelectNodes("nonCashDividendTreatment");
            if (nonCashDividendTreatmentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nonCashDividendTreatmentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nonCashDividendTreatmentIDRef = item.Attributes["id"].Name;
                        NonCashDividendTreatmentEnum ob = NonCashDividendTreatmentEnum();
                        IDManager.SetID(nonCashDividendTreatmentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nonCashDividendTreatmentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        nonCashDividendTreatment = new NonCashDividendTreatmentEnum(item);
                    }
                }
            }
            
        
            XmlNodeList dividendCompositionNodeList = xmlNode.SelectNodes("dividendComposition");
            if (dividendCompositionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendCompositionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendCompositionIDRef = item.Attributes["id"].Name;
                        DividendCompositionEnum ob = DividendCompositionEnum();
                        IDManager.SetID(dividendCompositionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendCompositionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendComposition = new DividendCompositionEnum(item);
                    }
                }
            }
            
        
            XmlNodeList specialDividendsNodeList = xmlNode.SelectNodes("specialDividends");
            if (specialDividendsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in specialDividendsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        specialDividendsIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(specialDividendsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        specialDividendsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        specialDividends = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region DividendReinvestment
        private XsdTypeBoolean dividendReinvestment;
        public XsdTypeBoolean DividendReinvestment
        {
            get
            {
                if (this.dividendReinvestment != null)
                {
                    return this.dividendReinvestment; 
                }
                else if (this.dividendReinvestmentIDRef != null)
                {
                    dividendReinvestment = IDManager.getID(dividendReinvestmentIDRef) as XsdTypeBoolean;
                    return this.dividendReinvestment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendReinvestment != value)
                {
                    this.dividendReinvestment = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region DividendEntitlement
        private DividendEntitlementEnum dividendEntitlement;
        public DividendEntitlementEnum DividendEntitlement
        {
            get
            {
                if (this.dividendEntitlement != null)
                {
                    return this.dividendEntitlement; 
                }
                else if (this.dividendEntitlementIDRef != null)
                {
                    dividendEntitlement = IDManager.getID(dividendEntitlementIDRef) as DividendEntitlementEnum;
                    return this.dividendEntitlement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendEntitlement != value)
                {
                    this.dividendEntitlement = value;
                }
            }
        }
        #endregion
        
        public string DividendEntitlementEnumIDRef { get; set; }
        #region DividendAmount
        private DividendAmountTypeEnum dividendAmount;
        public DividendAmountTypeEnum DividendAmount
        {
            get
            {
                if (this.dividendAmount != null)
                {
                    return this.dividendAmount; 
                }
                else if (this.dividendAmountIDRef != null)
                {
                    dividendAmount = IDManager.getID(dividendAmountIDRef) as DividendAmountTypeEnum;
                    return this.dividendAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendAmount != value)
                {
                    this.dividendAmount = value;
                }
            }
        }
        #endregion
        
        public string DividendAmountTypeEnumIDRef { get; set; }
        #region DividendPaymentDate
        private DividendPaymentDate dividendPaymentDate;
        public DividendPaymentDate DividendPaymentDate
        {
            get
            {
                if (this.dividendPaymentDate != null)
                {
                    return this.dividendPaymentDate; 
                }
                else if (this.dividendPaymentDateIDRef != null)
                {
                    dividendPaymentDate = IDManager.getID(dividendPaymentDateIDRef) as DividendPaymentDate;
                    return this.dividendPaymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendPaymentDate != value)
                {
                    this.dividendPaymentDate = value;
                }
            }
        }
        #endregion
        
        public string DividendPaymentDateIDRef { get; set; }
        #region DividendPeriodEffectiveDate
        private DateReference dividendPeriodEffectiveDate;
        public DateReference DividendPeriodEffectiveDate
        {
            get
            {
                if (this.dividendPeriodEffectiveDate != null)
                {
                    return this.dividendPeriodEffectiveDate; 
                }
                else if (this.dividendPeriodEffectiveDateIDRef != null)
                {
                    dividendPeriodEffectiveDate = IDManager.getID(dividendPeriodEffectiveDateIDRef) as DateReference;
                    return this.dividendPeriodEffectiveDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendPeriodEffectiveDate != value)
                {
                    this.dividendPeriodEffectiveDate = value;
                }
            }
        }
        #endregion
        
        public string DateReferenceIDRef { get; set; }
        #region DividendPeriodEndDate
        private DateReference dividendPeriodEndDate;
        public DateReference DividendPeriodEndDate
        {
            get
            {
                if (this.dividendPeriodEndDate != null)
                {
                    return this.dividendPeriodEndDate; 
                }
                else if (this.dividendPeriodEndDateIDRef != null)
                {
                    dividendPeriodEndDate = IDManager.getID(dividendPeriodEndDateIDRef) as DateReference;
                    return this.dividendPeriodEndDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendPeriodEndDate != value)
                {
                    this.dividendPeriodEndDate = value;
                }
            }
        }
        #endregion
        
        public string DateReferenceIDRef { get; set; }
        #region DividendPeriod
        private DividendPeriodEnum dividendPeriod;
        public DividendPeriodEnum DividendPeriod
        {
            get
            {
                if (this.dividendPeriod != null)
                {
                    return this.dividendPeriod; 
                }
                else if (this.dividendPeriodIDRef != null)
                {
                    dividendPeriod = IDManager.getID(dividendPeriodIDRef) as DividendPeriodEnum;
                    return this.dividendPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendPeriod != value)
                {
                    this.dividendPeriod = value;
                }
            }
        }
        #endregion
        
        public string DividendPeriodEnumIDRef { get; set; }
        #region ExtraOrdinaryDividends
        private PartyReference extraOrdinaryDividends;
        public PartyReference ExtraOrdinaryDividends
        {
            get
            {
                if (this.extraOrdinaryDividends != null)
                {
                    return this.extraOrdinaryDividends; 
                }
                else if (this.extraOrdinaryDividendsIDRef != null)
                {
                    extraOrdinaryDividends = IDManager.getID(extraOrdinaryDividendsIDRef) as PartyReference;
                    return this.extraOrdinaryDividends; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.extraOrdinaryDividends != value)
                {
                    this.extraOrdinaryDividends = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region ExcessDividendAmount
        private DividendAmountTypeEnum excessDividendAmount;
        public DividendAmountTypeEnum ExcessDividendAmount
        {
            get
            {
                if (this.excessDividendAmount != null)
                {
                    return this.excessDividendAmount; 
                }
                else if (this.excessDividendAmountIDRef != null)
                {
                    excessDividendAmount = IDManager.getID(excessDividendAmountIDRef) as DividendAmountTypeEnum;
                    return this.excessDividendAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.excessDividendAmount != value)
                {
                    this.excessDividendAmount = value;
                }
            }
        }
        #endregion
        
        public string DividendAmountTypeEnumIDRef { get; set; }
        #region Currency
        private IdentifiedCurrency currency;
        public IdentifiedCurrency Currency
        {
            get
            {
                if (this.currency != null)
                {
                    return this.currency; 
                }
                else if (this.currencyIDRef != null)
                {
                    currency = IDManager.getID(currencyIDRef) as IdentifiedCurrency;
                    return this.currency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.currency != value)
                {
                    this.currency = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedCurrencyIDRef { get; set; }
        #region DeterminationMethod
        private DeterminationMethod determinationMethod;
        public DeterminationMethod DeterminationMethod
        {
            get
            {
                if (this.determinationMethod != null)
                {
                    return this.determinationMethod; 
                }
                else if (this.determinationMethodIDRef != null)
                {
                    determinationMethod = IDManager.getID(determinationMethodIDRef) as DeterminationMethod;
                    return this.determinationMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.determinationMethod != value)
                {
                    this.determinationMethod = value;
                }
            }
        }
        #endregion
        
        public string DeterminationMethodIDRef { get; set; }
        #region CurrencyReference
        private IdentifiedCurrencyReference currencyReference;
        public IdentifiedCurrencyReference CurrencyReference
        {
            get
            {
                if (this.currencyReference != null)
                {
                    return this.currencyReference; 
                }
                else if (this.currencyReferenceIDRef != null)
                {
                    currencyReference = IDManager.getID(currencyReferenceIDRef) as IdentifiedCurrencyReference;
                    return this.currencyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.currencyReference != value)
                {
                    this.currencyReference = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedCurrencyReferenceIDRef { get; set; }
        #region DividendFxTriggerDate
        private DividendPaymentDate dividendFxTriggerDate;
        public DividendPaymentDate DividendFxTriggerDate
        {
            get
            {
                if (this.dividendFxTriggerDate != null)
                {
                    return this.dividendFxTriggerDate; 
                }
                else if (this.dividendFxTriggerDateIDRef != null)
                {
                    dividendFxTriggerDate = IDManager.getID(dividendFxTriggerDateIDRef) as DividendPaymentDate;
                    return this.dividendFxTriggerDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendFxTriggerDate != value)
                {
                    this.dividendFxTriggerDate = value;
                }
            }
        }
        #endregion
        
        public string DividendPaymentDateIDRef { get; set; }
        #region InterestAccrualsMethod
        private InterestAccrualsCompoundingMethod interestAccrualsMethod;
        public InterestAccrualsCompoundingMethod InterestAccrualsMethod
        {
            get
            {
                if (this.interestAccrualsMethod != null)
                {
                    return this.interestAccrualsMethod; 
                }
                else if (this.interestAccrualsMethodIDRef != null)
                {
                    interestAccrualsMethod = IDManager.getID(interestAccrualsMethodIDRef) as InterestAccrualsCompoundingMethod;
                    return this.interestAccrualsMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interestAccrualsMethod != value)
                {
                    this.interestAccrualsMethod = value;
                }
            }
        }
        #endregion
        
        public string InterestAccrualsCompoundingMethodIDRef { get; set; }
        #region NumberOfIndexUnits
        private NonNegativeDecimal numberOfIndexUnits;
        public NonNegativeDecimal NumberOfIndexUnits
        {
            get
            {
                if (this.numberOfIndexUnits != null)
                {
                    return this.numberOfIndexUnits; 
                }
                else if (this.numberOfIndexUnitsIDRef != null)
                {
                    numberOfIndexUnits = IDManager.getID(numberOfIndexUnitsIDRef) as NonNegativeDecimal;
                    return this.numberOfIndexUnits; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.numberOfIndexUnits != value)
                {
                    this.numberOfIndexUnits = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        #region DeclaredCashDividendPercentage
        private NonNegativeDecimal declaredCashDividendPercentage;
        public NonNegativeDecimal DeclaredCashDividendPercentage
        {
            get
            {
                if (this.declaredCashDividendPercentage != null)
                {
                    return this.declaredCashDividendPercentage; 
                }
                else if (this.declaredCashDividendPercentageIDRef != null)
                {
                    declaredCashDividendPercentage = IDManager.getID(declaredCashDividendPercentageIDRef) as NonNegativeDecimal;
                    return this.declaredCashDividendPercentage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.declaredCashDividendPercentage != value)
                {
                    this.declaredCashDividendPercentage = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        #region DeclaredCashEquivalentDividendPercentage
        private NonNegativeDecimal declaredCashEquivalentDividendPercentage;
        public NonNegativeDecimal DeclaredCashEquivalentDividendPercentage
        {
            get
            {
                if (this.declaredCashEquivalentDividendPercentage != null)
                {
                    return this.declaredCashEquivalentDividendPercentage; 
                }
                else if (this.declaredCashEquivalentDividendPercentageIDRef != null)
                {
                    declaredCashEquivalentDividendPercentage = IDManager.getID(declaredCashEquivalentDividendPercentageIDRef) as NonNegativeDecimal;
                    return this.declaredCashEquivalentDividendPercentage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.declaredCashEquivalentDividendPercentage != value)
                {
                    this.declaredCashEquivalentDividendPercentage = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        #region NonCashDividendTreatment
        private NonCashDividendTreatmentEnum nonCashDividendTreatment;
        public NonCashDividendTreatmentEnum NonCashDividendTreatment
        {
            get
            {
                if (this.nonCashDividendTreatment != null)
                {
                    return this.nonCashDividendTreatment; 
                }
                else if (this.nonCashDividendTreatmentIDRef != null)
                {
                    nonCashDividendTreatment = IDManager.getID(nonCashDividendTreatmentIDRef) as NonCashDividendTreatmentEnum;
                    return this.nonCashDividendTreatment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.nonCashDividendTreatment != value)
                {
                    this.nonCashDividendTreatment = value;
                }
            }
        }
        #endregion
        
        public string NonCashDividendTreatmentEnumIDRef { get; set; }
        #region DividendComposition
        private DividendCompositionEnum dividendComposition;
        public DividendCompositionEnum DividendComposition
        {
            get
            {
                if (this.dividendComposition != null)
                {
                    return this.dividendComposition; 
                }
                else if (this.dividendCompositionIDRef != null)
                {
                    dividendComposition = IDManager.getID(dividendCompositionIDRef) as DividendCompositionEnum;
                    return this.dividendComposition; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendComposition != value)
                {
                    this.dividendComposition = value;
                }
            }
        }
        #endregion
        
        public string DividendCompositionEnumIDRef { get; set; }
        #region SpecialDividends
        private XsdTypeBoolean specialDividends;
        public XsdTypeBoolean SpecialDividends
        {
            get
            {
                if (this.specialDividends != null)
                {
                    return this.specialDividends; 
                }
                else if (this.specialDividendsIDRef != null)
                {
                    specialDividends = IDManager.getID(specialDividendsIDRef) as XsdTypeBoolean;
                    return this.specialDividends; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.specialDividends != value)
                {
                    this.specialDividends = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

