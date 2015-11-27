using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Commodity : IdentifiedAsset
    {
        public Commodity(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode commodityBaseNode = xmlNode.SelectSingleNode("commodityBase");
            
            if (commodityBaseNode != null)
            {
                if (commodityBaseNode.Attributes["href"] != null || commodityBaseNode.Attributes["id"] != null) 
                {
                    if (commodityBaseNode.Attributes["id"] != null) 
                    {
                        commodityBaseIDRef_ = commodityBaseNode.Attributes["id"].Value;
                        CommodityBase ob = new CommodityBase(commodityBaseNode);
                        IDManager.SetID(commodityBaseIDRef_, ob);
                    }
                    else if (commodityBaseNode.Attributes["href"] != null)
                    {
                        commodityBaseIDRef_ = commodityBaseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commodityBase_ = new CommodityBase(commodityBaseNode);
                    }
                }
                else
                {
                    commodityBase_ = new CommodityBase(commodityBaseNode);
                }
            }
            
        
            XmlNode commodityDetailsNode = xmlNode.SelectSingleNode("commodityDetails");
            
            if (commodityDetailsNode != null)
            {
                if (commodityDetailsNode.Attributes["href"] != null || commodityDetailsNode.Attributes["id"] != null) 
                {
                    if (commodityDetailsNode.Attributes["id"] != null) 
                    {
                        commodityDetailsIDRef_ = commodityDetailsNode.Attributes["id"].Value;
                        CommodityDetails ob = new CommodityDetails(commodityDetailsNode);
                        IDManager.SetID(commodityDetailsIDRef_, ob);
                    }
                    else if (commodityDetailsNode.Attributes["href"] != null)
                    {
                        commodityDetailsIDRef_ = commodityDetailsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commodityDetails_ = new CommodityDetails(commodityDetailsNode);
                    }
                }
                else
                {
                    commodityDetails_ = new CommodityDetails(commodityDetailsNode);
                }
            }
            
        
            XmlNode unitNode = xmlNode.SelectSingleNode("unit");
            
            if (unitNode != null)
            {
                if (unitNode.Attributes["href"] != null || unitNode.Attributes["id"] != null) 
                {
                    if (unitNode.Attributes["id"] != null) 
                    {
                        unitIDRef_ = unitNode.Attributes["id"].Value;
                        QuantityUnit ob = new QuantityUnit(unitNode);
                        IDManager.SetID(unitIDRef_, ob);
                    }
                    else if (unitNode.Attributes["href"] != null)
                    {
                        unitIDRef_ = unitNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unit_ = new QuantityUnit(unitNode);
                    }
                }
                else
                {
                    unit_ = new QuantityUnit(unitNode);
                }
            }
            
        
            XmlNode currencyNode = xmlNode.SelectSingleNode("currency");
            
            if (currencyNode != null)
            {
                if (currencyNode.Attributes["href"] != null || currencyNode.Attributes["id"] != null) 
                {
                    if (currencyNode.Attributes["id"] != null) 
                    {
                        currencyIDRef_ = currencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(currencyNode);
                        IDManager.SetID(currencyIDRef_, ob);
                    }
                    else if (currencyNode.Attributes["href"] != null)
                    {
                        currencyIDRef_ = currencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency_ = new Currency(currencyNode);
                    }
                }
                else
                {
                    currency_ = new Currency(currencyNode);
                }
            }
            
        
            XmlNode exchangeIdNode = xmlNode.SelectSingleNode("exchangeId");
            
            if (exchangeIdNode != null)
            {
                if (exchangeIdNode.Attributes["href"] != null || exchangeIdNode.Attributes["id"] != null) 
                {
                    if (exchangeIdNode.Attributes["id"] != null) 
                    {
                        exchangeIdIDRef_ = exchangeIdNode.Attributes["id"].Value;
                        ExchangeId ob = new ExchangeId(exchangeIdNode);
                        IDManager.SetID(exchangeIdIDRef_, ob);
                    }
                    else if (exchangeIdNode.Attributes["href"] != null)
                    {
                        exchangeIdIDRef_ = exchangeIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exchangeId_ = new ExchangeId(exchangeIdNode);
                    }
                }
                else
                {
                    exchangeId_ = new ExchangeId(exchangeIdNode);
                }
            }
            
        
            XmlNode publicationNode = xmlNode.SelectSingleNode("publication");
            
            if (publicationNode != null)
            {
                if (publicationNode.Attributes["href"] != null || publicationNode.Attributes["id"] != null) 
                {
                    if (publicationNode.Attributes["id"] != null) 
                    {
                        publicationIDRef_ = publicationNode.Attributes["id"].Value;
                        CommodityInformationSource ob = new CommodityInformationSource(publicationNode);
                        IDManager.SetID(publicationIDRef_, ob);
                    }
                    else if (publicationNode.Attributes["href"] != null)
                    {
                        publicationIDRef_ = publicationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        publication_ = new CommodityInformationSource(publicationNode);
                    }
                }
                else
                {
                    publication_ = new CommodityInformationSource(publicationNode);
                }
            }
            
        
            XmlNode specifiedPriceNode = xmlNode.SelectSingleNode("specifiedPrice");
            
            if (specifiedPriceNode != null)
            {
                if (specifiedPriceNode.Attributes["href"] != null || specifiedPriceNode.Attributes["id"] != null) 
                {
                    if (specifiedPriceNode.Attributes["id"] != null) 
                    {
                        specifiedPriceIDRef_ = specifiedPriceNode.Attributes["id"].Value;
                        SpecifiedPriceEnum ob = new SpecifiedPriceEnum(specifiedPriceNode);
                        IDManager.SetID(specifiedPriceIDRef_, ob);
                    }
                    else if (specifiedPriceNode.Attributes["href"] != null)
                    {
                        specifiedPriceIDRef_ = specifiedPriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        specifiedPrice_ = new SpecifiedPriceEnum(specifiedPriceNode);
                    }
                }
                else
                {
                    specifiedPrice_ = new SpecifiedPriceEnum(specifiedPriceNode);
                }
            }
            
        
            XmlNode deliveryDatesNode = xmlNode.SelectSingleNode("deliveryDates");
            
            if (deliveryDatesNode != null)
            {
                if (deliveryDatesNode.Attributes["href"] != null || deliveryDatesNode.Attributes["id"] != null) 
                {
                    if (deliveryDatesNode.Attributes["id"] != null) 
                    {
                        deliveryDatesIDRef_ = deliveryDatesNode.Attributes["id"].Value;
                        DeliveryDatesEnum ob = new DeliveryDatesEnum(deliveryDatesNode);
                        IDManager.SetID(deliveryDatesIDRef_, ob);
                    }
                    else if (deliveryDatesNode.Attributes["href"] != null)
                    {
                        deliveryDatesIDRef_ = deliveryDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryDates_ = new DeliveryDatesEnum(deliveryDatesNode);
                    }
                }
                else
                {
                    deliveryDates_ = new DeliveryDatesEnum(deliveryDatesNode);
                }
            }
            
        
            XmlNode deliveryDateNode = xmlNode.SelectSingleNode("deliveryDate");
            
            if (deliveryDateNode != null)
            {
                if (deliveryDateNode.Attributes["href"] != null || deliveryDateNode.Attributes["id"] != null) 
                {
                    if (deliveryDateNode.Attributes["id"] != null) 
                    {
                        deliveryDateIDRef_ = deliveryDateNode.Attributes["id"].Value;
                        AdjustableDate ob = new AdjustableDate(deliveryDateNode);
                        IDManager.SetID(deliveryDateIDRef_, ob);
                    }
                    else if (deliveryDateNode.Attributes["href"] != null)
                    {
                        deliveryDateIDRef_ = deliveryDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryDate_ = new AdjustableDate(deliveryDateNode);
                    }
                }
                else
                {
                    deliveryDate_ = new AdjustableDate(deliveryDateNode);
                }
            }
            
        
            XmlNode deliveryDateYearMonthNode = xmlNode.SelectSingleNode("deliveryDateYearMonth");
            
            if (deliveryDateYearMonthNode != null)
            {
                if (deliveryDateYearMonthNode.Attributes["href"] != null || deliveryDateYearMonthNode.Attributes["id"] != null) 
                {
                    if (deliveryDateYearMonthNode.Attributes["id"] != null) 
                    {
                        deliveryDateYearMonthIDRef_ = deliveryDateYearMonthNode.Attributes["id"].Value;
                        XsdTypeGYearMonth ob = new XsdTypeGYearMonth(deliveryDateYearMonthNode);
                        IDManager.SetID(deliveryDateYearMonthIDRef_, ob);
                    }
                    else if (deliveryDateYearMonthNode.Attributes["href"] != null)
                    {
                        deliveryDateYearMonthIDRef_ = deliveryDateYearMonthNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryDateYearMonth_ = new XsdTypeGYearMonth(deliveryDateYearMonthNode);
                    }
                }
                else
                {
                    deliveryDateYearMonth_ = new XsdTypeGYearMonth(deliveryDateYearMonthNode);
                }
            }
            
        
            XmlNode deliveryDateRollConventionNode = xmlNode.SelectSingleNode("deliveryDateRollConvention");
            
            if (deliveryDateRollConventionNode != null)
            {
                if (deliveryDateRollConventionNode.Attributes["href"] != null || deliveryDateRollConventionNode.Attributes["id"] != null) 
                {
                    if (deliveryDateRollConventionNode.Attributes["id"] != null) 
                    {
                        deliveryDateRollConventionIDRef_ = deliveryDateRollConventionNode.Attributes["id"].Value;
                        Offset ob = new Offset(deliveryDateRollConventionNode);
                        IDManager.SetID(deliveryDateRollConventionIDRef_, ob);
                    }
                    else if (deliveryDateRollConventionNode.Attributes["href"] != null)
                    {
                        deliveryDateRollConventionIDRef_ = deliveryDateRollConventionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryDateRollConvention_ = new Offset(deliveryDateRollConventionNode);
                    }
                }
                else
                {
                    deliveryDateRollConvention_ = new Offset(deliveryDateRollConventionNode);
                }
            }
            
        
            XmlNode multiplierNode = xmlNode.SelectSingleNode("multiplier");
            
            if (multiplierNode != null)
            {
                if (multiplierNode.Attributes["href"] != null || multiplierNode.Attributes["id"] != null) 
                {
                    if (multiplierNode.Attributes["id"] != null) 
                    {
                        multiplierIDRef_ = multiplierNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(multiplierNode);
                        IDManager.SetID(multiplierIDRef_, ob);
                    }
                    else if (multiplierNode.Attributes["href"] != null)
                    {
                        multiplierIDRef_ = multiplierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        multiplier_ = new PositiveDecimal(multiplierNode);
                    }
                }
                else
                {
                    multiplier_ = new PositiveDecimal(multiplierNode);
                }
            }
            
        
        }
        
    
        #region CommodityBase_
        private CommodityBase commodityBase_;
        public CommodityBase CommodityBase_
        {
            get
            {
                if (this.commodityBase_ != null)
                {
                    return this.commodityBase_; 
                }
                else if (this.commodityBaseIDRef_ != null)
                {
                    commodityBase_ = IDManager.getID(commodityBaseIDRef_) as CommodityBase;
                    return this.commodityBase_; 
                }
                else
                {
                      return this.commodityBase_; 
                }
            }
            set
            {
                if (this.commodityBase_ != value)
                {
                    this.commodityBase_ = value;
                }
            }
        }
        #endregion
        
        public string commodityBaseIDRef_ { get; set; }
        #region CommodityDetails_
        private CommodityDetails commodityDetails_;
        public CommodityDetails CommodityDetails_
        {
            get
            {
                if (this.commodityDetails_ != null)
                {
                    return this.commodityDetails_; 
                }
                else if (this.commodityDetailsIDRef_ != null)
                {
                    commodityDetails_ = IDManager.getID(commodityDetailsIDRef_) as CommodityDetails;
                    return this.commodityDetails_; 
                }
                else
                {
                      return this.commodityDetails_; 
                }
            }
            set
            {
                if (this.commodityDetails_ != value)
                {
                    this.commodityDetails_ = value;
                }
            }
        }
        #endregion
        
        public string commodityDetailsIDRef_ { get; set; }
        #region Unit_
        private QuantityUnit unit_;
        public QuantityUnit Unit_
        {
            get
            {
                if (this.unit_ != null)
                {
                    return this.unit_; 
                }
                else if (this.unitIDRef_ != null)
                {
                    unit_ = IDManager.getID(unitIDRef_) as QuantityUnit;
                    return this.unit_; 
                }
                else
                {
                      return this.unit_; 
                }
            }
            set
            {
                if (this.unit_ != value)
                {
                    this.unit_ = value;
                }
            }
        }
        #endregion
        
        public string unitIDRef_ { get; set; }
        #region Currency_
        private Currency currency_;
        public Currency Currency_
        {
            get
            {
                if (this.currency_ != null)
                {
                    return this.currency_; 
                }
                else if (this.currencyIDRef_ != null)
                {
                    currency_ = IDManager.getID(currencyIDRef_) as Currency;
                    return this.currency_; 
                }
                else
                {
                      return this.currency_; 
                }
            }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                }
            }
        }
        #endregion
        
        public string currencyIDRef_ { get; set; }
        #region ExchangeId_
        private ExchangeId exchangeId_;
        public ExchangeId ExchangeId_
        {
            get
            {
                if (this.exchangeId_ != null)
                {
                    return this.exchangeId_; 
                }
                else if (this.exchangeIdIDRef_ != null)
                {
                    exchangeId_ = IDManager.getID(exchangeIdIDRef_) as ExchangeId;
                    return this.exchangeId_; 
                }
                else
                {
                      return this.exchangeId_; 
                }
            }
            set
            {
                if (this.exchangeId_ != value)
                {
                    this.exchangeId_ = value;
                }
            }
        }
        #endregion
        
        public string exchangeIdIDRef_ { get; set; }
        #region Publication_
        private CommodityInformationSource publication_;
        public CommodityInformationSource Publication_
        {
            get
            {
                if (this.publication_ != null)
                {
                    return this.publication_; 
                }
                else if (this.publicationIDRef_ != null)
                {
                    publication_ = IDManager.getID(publicationIDRef_) as CommodityInformationSource;
                    return this.publication_; 
                }
                else
                {
                      return this.publication_; 
                }
            }
            set
            {
                if (this.publication_ != value)
                {
                    this.publication_ = value;
                }
            }
        }
        #endregion
        
        public string publicationIDRef_ { get; set; }
        #region SpecifiedPrice_
        private SpecifiedPriceEnum specifiedPrice_;
        public SpecifiedPriceEnum SpecifiedPrice_
        {
            get
            {
                if (this.specifiedPrice_ != null)
                {
                    return this.specifiedPrice_; 
                }
                else if (this.specifiedPriceIDRef_ != null)
                {
                    specifiedPrice_ = IDManager.getID(specifiedPriceIDRef_) as SpecifiedPriceEnum;
                    return this.specifiedPrice_; 
                }
                else
                {
                      return this.specifiedPrice_; 
                }
            }
            set
            {
                if (this.specifiedPrice_ != value)
                {
                    this.specifiedPrice_ = value;
                }
            }
        }
        #endregion
        
        public string specifiedPriceIDRef_ { get; set; }
        #region DeliveryDates_
        private DeliveryDatesEnum deliveryDates_;
        public DeliveryDatesEnum DeliveryDates_
        {
            get
            {
                if (this.deliveryDates_ != null)
                {
                    return this.deliveryDates_; 
                }
                else if (this.deliveryDatesIDRef_ != null)
                {
                    deliveryDates_ = IDManager.getID(deliveryDatesIDRef_) as DeliveryDatesEnum;
                    return this.deliveryDates_; 
                }
                else
                {
                      return this.deliveryDates_; 
                }
            }
            set
            {
                if (this.deliveryDates_ != value)
                {
                    this.deliveryDates_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryDatesIDRef_ { get; set; }
        #region DeliveryDate_
        private AdjustableDate deliveryDate_;
        public AdjustableDate DeliveryDate_
        {
            get
            {
                if (this.deliveryDate_ != null)
                {
                    return this.deliveryDate_; 
                }
                else if (this.deliveryDateIDRef_ != null)
                {
                    deliveryDate_ = IDManager.getID(deliveryDateIDRef_) as AdjustableDate;
                    return this.deliveryDate_; 
                }
                else
                {
                      return this.deliveryDate_; 
                }
            }
            set
            {
                if (this.deliveryDate_ != value)
                {
                    this.deliveryDate_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryDateIDRef_ { get; set; }
        #region DeliveryDateYearMonth_
        private XsdTypeGYearMonth deliveryDateYearMonth_;
        public XsdTypeGYearMonth DeliveryDateYearMonth_
        {
            get
            {
                if (this.deliveryDateYearMonth_ != null)
                {
                    return this.deliveryDateYearMonth_; 
                }
                else if (this.deliveryDateYearMonthIDRef_ != null)
                {
                    deliveryDateYearMonth_ = IDManager.getID(deliveryDateYearMonthIDRef_) as XsdTypeGYearMonth;
                    return this.deliveryDateYearMonth_; 
                }
                else
                {
                      return this.deliveryDateYearMonth_; 
                }
            }
            set
            {
                if (this.deliveryDateYearMonth_ != value)
                {
                    this.deliveryDateYearMonth_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryDateYearMonthIDRef_ { get; set; }
        #region DeliveryDateRollConvention_
        private Offset deliveryDateRollConvention_;
        public Offset DeliveryDateRollConvention_
        {
            get
            {
                if (this.deliveryDateRollConvention_ != null)
                {
                    return this.deliveryDateRollConvention_; 
                }
                else if (this.deliveryDateRollConventionIDRef_ != null)
                {
                    deliveryDateRollConvention_ = IDManager.getID(deliveryDateRollConventionIDRef_) as Offset;
                    return this.deliveryDateRollConvention_; 
                }
                else
                {
                      return this.deliveryDateRollConvention_; 
                }
            }
            set
            {
                if (this.deliveryDateRollConvention_ != value)
                {
                    this.deliveryDateRollConvention_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryDateRollConventionIDRef_ { get; set; }
        #region Multiplier_
        private PositiveDecimal multiplier_;
        public PositiveDecimal Multiplier_
        {
            get
            {
                if (this.multiplier_ != null)
                {
                    return this.multiplier_; 
                }
                else if (this.multiplierIDRef_ != null)
                {
                    multiplier_ = IDManager.getID(multiplierIDRef_) as PositiveDecimal;
                    return this.multiplier_; 
                }
                else
                {
                      return this.multiplier_; 
                }
            }
            set
            {
                if (this.multiplier_ != value)
                {
                    this.multiplier_ = value;
                }
            }
        }
        #endregion
        
        public string multiplierIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

