using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Quotation
    {
        public Quotation(XmlNode xmlNode)
        {
            XmlNodeList valueNodeList = xmlNode.SelectNodes("value");
            if (valueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valueIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(valueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        value = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList measureTypeNodeList = xmlNode.SelectNodes("measureType");
            if (measureTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in measureTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        measureTypeIDRef = item.Attributes["id"].Name;
                        AssetMeasureType ob = AssetMeasureType();
                        IDManager.SetID(measureTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        measureTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        measureType = new AssetMeasureType(item);
                    }
                }
            }
            
        
            XmlNodeList quoteUnitsNodeList = xmlNode.SelectNodes("quoteUnits");
            if (quoteUnitsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quoteUnitsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quoteUnitsIDRef = item.Attributes["id"].Name;
                        PriceQuoteUnits ob = PriceQuoteUnits();
                        IDManager.SetID(quoteUnitsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quoteUnitsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quoteUnits = new PriceQuoteUnits(item);
                    }
                }
            }
            
        
            XmlNodeList sideNodeList = xmlNode.SelectNodes("side");
            if (sideNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sideNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sideIDRef = item.Attributes["id"].Name;
                        QuotationSideEnum ob = QuotationSideEnum();
                        IDManager.SetID(sideIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sideIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        side = new QuotationSideEnum(item);
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
                        Currency ob = Currency();
                        IDManager.SetID(currencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        currencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        currency = new Currency(item);
                    }
                }
            }
            
        
            XmlNodeList currencyTypeNodeList = xmlNode.SelectNodes("currencyType");
            if (currencyTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in currencyTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        currencyTypeIDRef = item.Attributes["id"].Name;
                        ReportingCurrencyType ob = ReportingCurrencyType();
                        IDManager.SetID(currencyTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        currencyTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        currencyType = new ReportingCurrencyType(item);
                    }
                }
            }
            
        
            XmlNodeList timingNodeList = xmlNode.SelectNodes("timing");
            if (timingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in timingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        timingIDRef = item.Attributes["id"].Name;
                        QuoteTiming ob = QuoteTiming();
                        IDManager.SetID(timingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        timingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        timing = new QuoteTiming(item);
                    }
                }
            }
            
        
            XmlNodeList businessCenterNodeList = xmlNode.SelectNodes("businessCenter");
            if (businessCenterNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessCenterNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessCenterIDRef = item.Attributes["id"].Name;
                        BusinessCenter ob = BusinessCenter();
                        IDManager.SetID(businessCenterIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessCenterIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessCenter = new BusinessCenter(item);
                    }
                }
            }
            
        
            XmlNodeList exchangeIdNodeList = xmlNode.SelectNodes("exchangeId");
            if (exchangeIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exchangeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exchangeIdIDRef = item.Attributes["id"].Name;
                        ExchangeId ob = ExchangeId();
                        IDManager.SetID(exchangeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exchangeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exchangeId = new ExchangeId(item);
                    }
                }
            }
            
        
            XmlNodeList informationSourceNodeList = xmlNode.SelectNodes("informationSource");
            
            foreach (XmlNode item in informationSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        informationSourceIDRef = item.Attributes["id"].Name;
                        List<InformationSource> ob = new List<InformationSource>();
                        ob.Add(new InformationSource(item));
                        IDManager.SetID(informationSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        informationSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    informationSource.Add(new InformationSource(item));
                    }
                }
            }
            
        
            XmlNodeList pricingModelNodeList = xmlNode.SelectNodes("pricingModel");
            if (pricingModelNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in pricingModelNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pricingModelIDRef = item.Attributes["id"].Name;
                        PricingModel ob = PricingModel();
                        IDManager.SetID(pricingModelIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pricingModelIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        pricingModel = new PricingModel(item);
                    }
                }
            }
            
        
            XmlNodeList timeNodeList = xmlNode.SelectNodes("time");
            if (timeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in timeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        timeIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(timeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        timeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        time = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList valuationDateNodeList = xmlNode.SelectNodes("valuationDate");
            if (valuationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(valuationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList expiryTimeNodeList = xmlNode.SelectNodes("expiryTime");
            if (expiryTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expiryTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expiryTimeIDRef = item.Attributes["id"].Name;
                        XsdTypeDateTime ob = XsdTypeDateTime();
                        IDManager.SetID(expiryTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expiryTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expiryTime = new XsdTypeDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList cashflowTypeNodeList = xmlNode.SelectNodes("cashflowType");
            if (cashflowTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashflowTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashflowTypeIDRef = item.Attributes["id"].Name;
                        CashflowType ob = CashflowType();
                        IDManager.SetID(cashflowTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashflowTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashflowType = new CashflowType(item);
                    }
                }
            }
            
        
            XmlNodeList sensitivitySetNodeList = xmlNode.SelectNodes("sensitivitySet");
            
            foreach (XmlNode item in sensitivitySetNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sensitivitySetIDRef = item.Attributes["id"].Name;
                        List<SensitivitySet> ob = new List<SensitivitySet>();
                        ob.Add(new SensitivitySet(item));
                        IDManager.SetID(sensitivitySetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sensitivitySetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    sensitivitySet.Add(new SensitivitySet(item));
                    }
                }
            }
            
        
        }
        
    
        #region Value
        private XsdTypeDecimal value;
        public XsdTypeDecimal Value
        {
            get
            {
                if (this.value != null)
                {
                    return this.value; 
                }
                else if (this.valueIDRef != null)
                {
                    value = IDManager.getID(valueIDRef) as XsdTypeDecimal;
                    return this.value; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region MeasureType
        private AssetMeasureType measureType;
        public AssetMeasureType MeasureType
        {
            get
            {
                if (this.measureType != null)
                {
                    return this.measureType; 
                }
                else if (this.measureTypeIDRef != null)
                {
                    measureType = IDManager.getID(measureTypeIDRef) as AssetMeasureType;
                    return this.measureType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.measureType != value)
                {
                    this.measureType = value;
                }
            }
        }
        #endregion
        
        public string AssetMeasureTypeIDRef { get; set; }
        #region QuoteUnits
        private PriceQuoteUnits quoteUnits;
        public PriceQuoteUnits QuoteUnits
        {
            get
            {
                if (this.quoteUnits != null)
                {
                    return this.quoteUnits; 
                }
                else if (this.quoteUnitsIDRef != null)
                {
                    quoteUnits = IDManager.getID(quoteUnitsIDRef) as PriceQuoteUnits;
                    return this.quoteUnits; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quoteUnits != value)
                {
                    this.quoteUnits = value;
                }
            }
        }
        #endregion
        
        public string PriceQuoteUnitsIDRef { get; set; }
        #region Side
        private QuotationSideEnum side;
        public QuotationSideEnum Side
        {
            get
            {
                if (this.side != null)
                {
                    return this.side; 
                }
                else if (this.sideIDRef != null)
                {
                    side = IDManager.getID(sideIDRef) as QuotationSideEnum;
                    return this.side; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.side != value)
                {
                    this.side = value;
                }
            }
        }
        #endregion
        
        public string QuotationSideEnumIDRef { get; set; }
        #region Currency
        private Currency currency;
        public Currency Currency
        {
            get
            {
                if (this.currency != null)
                {
                    return this.currency; 
                }
                else if (this.currencyIDRef != null)
                {
                    currency = IDManager.getID(currencyIDRef) as Currency;
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
        
        public string CurrencyIDRef { get; set; }
        #region CurrencyType
        private ReportingCurrencyType currencyType;
        public ReportingCurrencyType CurrencyType
        {
            get
            {
                if (this.currencyType != null)
                {
                    return this.currencyType; 
                }
                else if (this.currencyTypeIDRef != null)
                {
                    currencyType = IDManager.getID(currencyTypeIDRef) as ReportingCurrencyType;
                    return this.currencyType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.currencyType != value)
                {
                    this.currencyType = value;
                }
            }
        }
        #endregion
        
        public string ReportingCurrencyTypeIDRef { get; set; }
        #region Timing
        private QuoteTiming timing;
        public QuoteTiming Timing
        {
            get
            {
                if (this.timing != null)
                {
                    return this.timing; 
                }
                else if (this.timingIDRef != null)
                {
                    timing = IDManager.getID(timingIDRef) as QuoteTiming;
                    return this.timing; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.timing != value)
                {
                    this.timing = value;
                }
            }
        }
        #endregion
        
        public string QuoteTimingIDRef { get; set; }
        #region BusinessCenter
        private BusinessCenter businessCenter;
        public BusinessCenter BusinessCenter
        {
            get
            {
                if (this.businessCenter != null)
                {
                    return this.businessCenter; 
                }
                else if (this.businessCenterIDRef != null)
                {
                    businessCenter = IDManager.getID(businessCenterIDRef) as BusinessCenter;
                    return this.businessCenter; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessCenter != value)
                {
                    this.businessCenter = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterIDRef { get; set; }
        #region ExchangeId
        private ExchangeId exchangeId;
        public ExchangeId ExchangeId
        {
            get
            {
                if (this.exchangeId != null)
                {
                    return this.exchangeId; 
                }
                else if (this.exchangeIdIDRef != null)
                {
                    exchangeId = IDManager.getID(exchangeIdIDRef) as ExchangeId;
                    return this.exchangeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exchangeId != value)
                {
                    this.exchangeId = value;
                }
            }
        }
        #endregion
        
        public string ExchangeIdIDRef { get; set; }
        #region InformationSource
        private List<InformationSource> informationSource;
        public List<InformationSource> InformationSource
        {
            get
            {
                if (this.informationSource != null)
                {
                    return this.informationSource; 
                }
                else if (this.informationSourceIDRef != null)
                {
                    informationSource = IDManager.getID(informationSourceIDRef) as List<InformationSource>;
                    return this.informationSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.informationSource != value)
                {
                    this.informationSource = value;
                }
            }
        }
        #endregion
        
        public string InformationSourceIDRef { get; set; }
        #region PricingModel
        private PricingModel pricingModel;
        public PricingModel PricingModel
        {
            get
            {
                if (this.pricingModel != null)
                {
                    return this.pricingModel; 
                }
                else if (this.pricingModelIDRef != null)
                {
                    pricingModel = IDManager.getID(pricingModelIDRef) as PricingModel;
                    return this.pricingModel; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pricingModel != value)
                {
                    this.pricingModel = value;
                }
            }
        }
        #endregion
        
        public string PricingModelIDRef { get; set; }
        #region Time
        private XsdTypeDateTime time;
        public XsdTypeDateTime Time
        {
            get
            {
                if (this.time != null)
                {
                    return this.time; 
                }
                else if (this.timeIDRef != null)
                {
                    time = IDManager.getID(timeIDRef) as XsdTypeDateTime;
                    return this.time; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.time != value)
                {
                    this.time = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region ValuationDate
        private XsdTypeDate valuationDate;
        public XsdTypeDate ValuationDate
        {
            get
            {
                if (this.valuationDate != null)
                {
                    return this.valuationDate; 
                }
                else if (this.valuationDateIDRef != null)
                {
                    valuationDate = IDManager.getID(valuationDateIDRef) as XsdTypeDate;
                    return this.valuationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationDate != value)
                {
                    this.valuationDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region ExpiryTime
        private XsdTypeDateTime expiryTime;
        public XsdTypeDateTime ExpiryTime
        {
            get
            {
                if (this.expiryTime != null)
                {
                    return this.expiryTime; 
                }
                else if (this.expiryTimeIDRef != null)
                {
                    expiryTime = IDManager.getID(expiryTimeIDRef) as XsdTypeDateTime;
                    return this.expiryTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expiryTime != value)
                {
                    this.expiryTime = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateTimeIDRef { get; set; }
        #region CashflowType
        private CashflowType cashflowType;
        public CashflowType CashflowType
        {
            get
            {
                if (this.cashflowType != null)
                {
                    return this.cashflowType; 
                }
                else if (this.cashflowTypeIDRef != null)
                {
                    cashflowType = IDManager.getID(cashflowTypeIDRef) as CashflowType;
                    return this.cashflowType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashflowType != value)
                {
                    this.cashflowType = value;
                }
            }
        }
        #endregion
        
        public string CashflowTypeIDRef { get; set; }
        #region SensitivitySet
        private List<SensitivitySet> sensitivitySet;
        public List<SensitivitySet> SensitivitySet
        {
            get
            {
                if (this.sensitivitySet != null)
                {
                    return this.sensitivitySet; 
                }
                else if (this.sensitivitySetIDRef != null)
                {
                    sensitivitySet = IDManager.getID(sensitivitySetIDRef) as List<SensitivitySet>;
                    return this.sensitivitySet; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sensitivitySet != value)
                {
                    this.sensitivitySet = value;
                }
            }
        }
        #endregion
        
        public string SensitivitySetIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

