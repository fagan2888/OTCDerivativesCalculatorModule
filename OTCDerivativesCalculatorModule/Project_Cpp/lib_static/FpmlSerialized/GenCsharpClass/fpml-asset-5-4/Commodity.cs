using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Commodity
    {
        public Commodity(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList commodityBaseNodeList = xmlNode.SelectNodes("commodityBase");
            if (commodityBaseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commodityBaseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commodityBaseIDRef = item.Attributes["id"].Name;
                        CommodityBase ob = CommodityBase();
                        IDManager.SetID(commodityBaseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commodityBaseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commodityBase = new CommodityBase(item);
                    }
                }
            }
            
        
            XmlNodeList commodityDetailsNodeList = xmlNode.SelectNodes("commodityDetails");
            if (commodityDetailsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commodityDetailsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commodityDetailsIDRef = item.Attributes["id"].Name;
                        CommodityDetails ob = CommodityDetails();
                        IDManager.SetID(commodityDetailsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commodityDetailsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commodityDetails = new CommodityDetails(item);
                    }
                }
            }
            
        
            XmlNodeList unitNodeList = xmlNode.SelectNodes("unit");
            if (unitNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in unitNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unitIDRef = item.Attributes["id"].Name;
                        QuantityUnit ob = QuantityUnit();
                        IDManager.SetID(unitIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unitIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        unit = new QuantityUnit(item);
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
            
        
            XmlNodeList publicationNodeList = xmlNode.SelectNodes("publication");
            if (publicationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in publicationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        publicationIDRef = item.Attributes["id"].Name;
                        CommodityInformationSource ob = CommodityInformationSource();
                        IDManager.SetID(publicationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        publicationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        publication = new CommodityInformationSource(item);
                    }
                }
            }
            
        
            XmlNodeList specifiedPriceNodeList = xmlNode.SelectNodes("specifiedPrice");
            if (specifiedPriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in specifiedPriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        specifiedPriceIDRef = item.Attributes["id"].Name;
                        SpecifiedPriceEnum ob = SpecifiedPriceEnum();
                        IDManager.SetID(specifiedPriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        specifiedPriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        specifiedPrice = new SpecifiedPriceEnum(item);
                    }
                }
            }
            
        
            XmlNodeList deliveryDatesNodeList = xmlNode.SelectNodes("deliveryDates");
            if (deliveryDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryDatesIDRef = item.Attributes["id"].Name;
                        DeliveryDatesEnum ob = DeliveryDatesEnum();
                        IDManager.SetID(deliveryDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryDates = new DeliveryDatesEnum(item);
                    }
                }
            }
            
        
            XmlNodeList deliveryDateNodeList = xmlNode.SelectNodes("deliveryDate");
            if (deliveryDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryDateIDRef = item.Attributes["id"].Name;
                        AdjustableDate ob = AdjustableDate();
                        IDManager.SetID(deliveryDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryDate = new AdjustableDate(item);
                    }
                }
            }
            
        
            XmlNodeList deliveryDateYearMonthNodeList = xmlNode.SelectNodes("deliveryDateYearMonth");
            if (deliveryDateYearMonthNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryDateYearMonthNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryDateYearMonthIDRef = item.Attributes["id"].Name;
                        XsdTypeGYearMonth ob = XsdTypeGYearMonth();
                        IDManager.SetID(deliveryDateYearMonthIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryDateYearMonthIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryDateYearMonth = new XsdTypeGYearMonth(item);
                    }
                }
            }
            
        
            XmlNodeList deliveryDateRollConventionNodeList = xmlNode.SelectNodes("deliveryDateRollConvention");
            if (deliveryDateRollConventionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryDateRollConventionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryDateRollConventionIDRef = item.Attributes["id"].Name;
                        Offset ob = Offset();
                        IDManager.SetID(deliveryDateRollConventionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryDateRollConventionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryDateRollConvention = new Offset(item);
                    }
                }
            }
            
        
            XmlNodeList multiplierNodeList = xmlNode.SelectNodes("multiplier");
            if (multiplierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in multiplierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        multiplierIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(multiplierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        multiplierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        multiplier = new PositiveDecimal(item);
                    }
                }
            }
            
        
        }
        
    
        #region CommodityBase
        private CommodityBase commodityBase;
        public CommodityBase CommodityBase
        {
            get
            {
                if (this.commodityBase != null)
                {
                    return this.commodityBase; 
                }
                else if (this.commodityBaseIDRef != null)
                {
                    commodityBase = IDManager.getID(commodityBaseIDRef) as CommodityBase;
                    return this.commodityBase; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commodityBase != value)
                {
                    this.commodityBase = value;
                }
            }
        }
        #endregion
        
        public string CommodityBaseIDRef { get; set; }
        #region CommodityDetails
        private CommodityDetails commodityDetails;
        public CommodityDetails CommodityDetails
        {
            get
            {
                if (this.commodityDetails != null)
                {
                    return this.commodityDetails; 
                }
                else if (this.commodityDetailsIDRef != null)
                {
                    commodityDetails = IDManager.getID(commodityDetailsIDRef) as CommodityDetails;
                    return this.commodityDetails; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commodityDetails != value)
                {
                    this.commodityDetails = value;
                }
            }
        }
        #endregion
        
        public string CommodityDetailsIDRef { get; set; }
        #region Unit
        private QuantityUnit unit;
        public QuantityUnit Unit
        {
            get
            {
                if (this.unit != null)
                {
                    return this.unit; 
                }
                else if (this.unitIDRef != null)
                {
                    unit = IDManager.getID(unitIDRef) as QuantityUnit;
                    return this.unit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unit != value)
                {
                    this.unit = value;
                }
            }
        }
        #endregion
        
        public string QuantityUnitIDRef { get; set; }
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
        #region Publication
        private CommodityInformationSource publication;
        public CommodityInformationSource Publication
        {
            get
            {
                if (this.publication != null)
                {
                    return this.publication; 
                }
                else if (this.publicationIDRef != null)
                {
                    publication = IDManager.getID(publicationIDRef) as CommodityInformationSource;
                    return this.publication; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.publication != value)
                {
                    this.publication = value;
                }
            }
        }
        #endregion
        
        public string CommodityInformationSourceIDRef { get; set; }
        #region SpecifiedPrice
        private SpecifiedPriceEnum specifiedPrice;
        public SpecifiedPriceEnum SpecifiedPrice
        {
            get
            {
                if (this.specifiedPrice != null)
                {
                    return this.specifiedPrice; 
                }
                else if (this.specifiedPriceIDRef != null)
                {
                    specifiedPrice = IDManager.getID(specifiedPriceIDRef) as SpecifiedPriceEnum;
                    return this.specifiedPrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.specifiedPrice != value)
                {
                    this.specifiedPrice = value;
                }
            }
        }
        #endregion
        
        public string SpecifiedPriceEnumIDRef { get; set; }
        #region DeliveryDates
        private DeliveryDatesEnum deliveryDates;
        public DeliveryDatesEnum DeliveryDates
        {
            get
            {
                if (this.deliveryDates != null)
                {
                    return this.deliveryDates; 
                }
                else if (this.deliveryDatesIDRef != null)
                {
                    deliveryDates = IDManager.getID(deliveryDatesIDRef) as DeliveryDatesEnum;
                    return this.deliveryDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryDates != value)
                {
                    this.deliveryDates = value;
                }
            }
        }
        #endregion
        
        public string DeliveryDatesEnumIDRef { get; set; }
        #region DeliveryDate
        private AdjustableDate deliveryDate;
        public AdjustableDate DeliveryDate
        {
            get
            {
                if (this.deliveryDate != null)
                {
                    return this.deliveryDate; 
                }
                else if (this.deliveryDateIDRef != null)
                {
                    deliveryDate = IDManager.getID(deliveryDateIDRef) as AdjustableDate;
                    return this.deliveryDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryDate != value)
                {
                    this.deliveryDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDateIDRef { get; set; }
        #region DeliveryDateYearMonth
        private XsdTypeGYearMonth deliveryDateYearMonth;
        public XsdTypeGYearMonth DeliveryDateYearMonth
        {
            get
            {
                if (this.deliveryDateYearMonth != null)
                {
                    return this.deliveryDateYearMonth; 
                }
                else if (this.deliveryDateYearMonthIDRef != null)
                {
                    deliveryDateYearMonth = IDManager.getID(deliveryDateYearMonthIDRef) as XsdTypeGYearMonth;
                    return this.deliveryDateYearMonth; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryDateYearMonth != value)
                {
                    this.deliveryDateYearMonth = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeGYearMonthIDRef { get; set; }
        #region DeliveryDateRollConvention
        private Offset deliveryDateRollConvention;
        public Offset DeliveryDateRollConvention
        {
            get
            {
                if (this.deliveryDateRollConvention != null)
                {
                    return this.deliveryDateRollConvention; 
                }
                else if (this.deliveryDateRollConventionIDRef != null)
                {
                    deliveryDateRollConvention = IDManager.getID(deliveryDateRollConventionIDRef) as Offset;
                    return this.deliveryDateRollConvention; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryDateRollConvention != value)
                {
                    this.deliveryDateRollConvention = value;
                }
            }
        }
        #endregion
        
        public string OffsetIDRef { get; set; }
        #region Multiplier
        private PositiveDecimal multiplier;
        public PositiveDecimal Multiplier
        {
            get
            {
                if (this.multiplier != null)
                {
                    return this.multiplier; 
                }
                else if (this.multiplierIDRef != null)
                {
                    multiplier = IDManager.getID(multiplierIDRef) as PositiveDecimal;
                    return this.multiplier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.multiplier != value)
                {
                    this.multiplier = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

