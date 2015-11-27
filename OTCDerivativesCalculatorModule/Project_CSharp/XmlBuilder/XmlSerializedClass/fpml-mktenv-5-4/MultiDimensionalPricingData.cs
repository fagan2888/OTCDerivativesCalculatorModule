using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class MultiDimensionalPricingData : ISerialized
    {
        public MultiDimensionalPricingData(XmlNode xmlNode)
        {
            XmlNode measureTypeNode = xmlNode.SelectSingleNode("measureType");
            
            if (measureTypeNode != null)
            {
                if (measureTypeNode.Attributes["href"] != null || measureTypeNode.Attributes["id"] != null) 
                {
                    if (measureTypeNode.Attributes["id"] != null) 
                    {
                        measureTypeIDRef_ = measureTypeNode.Attributes["id"].Value;
                        AssetMeasureType ob = new AssetMeasureType(measureTypeNode);
                        IDManager.SetID(measureTypeIDRef_, ob);
                    }
                    else if (measureTypeNode.Attributes["href"] != null)
                    {
                        measureTypeIDRef_ = measureTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        measureType_ = new AssetMeasureType(measureTypeNode);
                    }
                }
                else
                {
                    measureType_ = new AssetMeasureType(measureTypeNode);
                }
            }
            
        
            XmlNode quoteUnitsNode = xmlNode.SelectSingleNode("quoteUnits");
            
            if (quoteUnitsNode != null)
            {
                if (quoteUnitsNode.Attributes["href"] != null || quoteUnitsNode.Attributes["id"] != null) 
                {
                    if (quoteUnitsNode.Attributes["id"] != null) 
                    {
                        quoteUnitsIDRef_ = quoteUnitsNode.Attributes["id"].Value;
                        PriceQuoteUnits ob = new PriceQuoteUnits(quoteUnitsNode);
                        IDManager.SetID(quoteUnitsIDRef_, ob);
                    }
                    else if (quoteUnitsNode.Attributes["href"] != null)
                    {
                        quoteUnitsIDRef_ = quoteUnitsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quoteUnits_ = new PriceQuoteUnits(quoteUnitsNode);
                    }
                }
                else
                {
                    quoteUnits_ = new PriceQuoteUnits(quoteUnitsNode);
                }
            }
            
        
            XmlNode sideNode = xmlNode.SelectSingleNode("side");
            
            if (sideNode != null)
            {
                if (sideNode.Attributes["href"] != null || sideNode.Attributes["id"] != null) 
                {
                    if (sideNode.Attributes["id"] != null) 
                    {
                        sideIDRef_ = sideNode.Attributes["id"].Value;
                        QuotationSideEnum ob = new QuotationSideEnum(sideNode);
                        IDManager.SetID(sideIDRef_, ob);
                    }
                    else if (sideNode.Attributes["href"] != null)
                    {
                        sideIDRef_ = sideNode.Attributes["href"].Value;
                    }
                    else
                    {
                        side_ = new QuotationSideEnum(sideNode);
                    }
                }
                else
                {
                    side_ = new QuotationSideEnum(sideNode);
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
            
        
            XmlNode currencyTypeNode = xmlNode.SelectSingleNode("currencyType");
            
            if (currencyTypeNode != null)
            {
                if (currencyTypeNode.Attributes["href"] != null || currencyTypeNode.Attributes["id"] != null) 
                {
                    if (currencyTypeNode.Attributes["id"] != null) 
                    {
                        currencyTypeIDRef_ = currencyTypeNode.Attributes["id"].Value;
                        ReportingCurrencyType ob = new ReportingCurrencyType(currencyTypeNode);
                        IDManager.SetID(currencyTypeIDRef_, ob);
                    }
                    else if (currencyTypeNode.Attributes["href"] != null)
                    {
                        currencyTypeIDRef_ = currencyTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currencyType_ = new ReportingCurrencyType(currencyTypeNode);
                    }
                }
                else
                {
                    currencyType_ = new ReportingCurrencyType(currencyTypeNode);
                }
            }
            
        
            XmlNode timingNode = xmlNode.SelectSingleNode("timing");
            
            if (timingNode != null)
            {
                if (timingNode.Attributes["href"] != null || timingNode.Attributes["id"] != null) 
                {
                    if (timingNode.Attributes["id"] != null) 
                    {
                        timingIDRef_ = timingNode.Attributes["id"].Value;
                        QuoteTiming ob = new QuoteTiming(timingNode);
                        IDManager.SetID(timingIDRef_, ob);
                    }
                    else if (timingNode.Attributes["href"] != null)
                    {
                        timingIDRef_ = timingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        timing_ = new QuoteTiming(timingNode);
                    }
                }
                else
                {
                    timing_ = new QuoteTiming(timingNode);
                }
            }
            
        
            XmlNode businessCenterNode = xmlNode.SelectSingleNode("businessCenter");
            
            if (businessCenterNode != null)
            {
                if (businessCenterNode.Attributes["href"] != null || businessCenterNode.Attributes["id"] != null) 
                {
                    if (businessCenterNode.Attributes["id"] != null) 
                    {
                        businessCenterIDRef_ = businessCenterNode.Attributes["id"].Value;
                        BusinessCenter ob = new BusinessCenter(businessCenterNode);
                        IDManager.SetID(businessCenterIDRef_, ob);
                    }
                    else if (businessCenterNode.Attributes["href"] != null)
                    {
                        businessCenterIDRef_ = businessCenterNode.Attributes["href"].Value;
                    }
                    else
                    {
                        businessCenter_ = new BusinessCenter(businessCenterNode);
                    }
                }
                else
                {
                    businessCenter_ = new BusinessCenter(businessCenterNode);
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
            
        
            XmlNodeList informationSourceNodeList = xmlNode.SelectNodes("informationSource");
            
            if (informationSourceNodeList != null)
            {
                this.informationSource_ = new List<InformationSource>();
                foreach (XmlNode item in informationSourceNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            informationSourceIDRef_ = item.Attributes["id"].Value;
                            informationSource_.Add(new InformationSource(item));
                            IDManager.SetID(informationSourceIDRef_, informationSource_[informationSource_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            informationSourceIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        informationSource_.Add(new InformationSource(item));
                        }
                    }
                    else
                    {
                        informationSource_.Add(new InformationSource(item));
                    }
                }
            }
            
        
            XmlNode pricingModelNode = xmlNode.SelectSingleNode("pricingModel");
            
            if (pricingModelNode != null)
            {
                if (pricingModelNode.Attributes["href"] != null || pricingModelNode.Attributes["id"] != null) 
                {
                    if (pricingModelNode.Attributes["id"] != null) 
                    {
                        pricingModelIDRef_ = pricingModelNode.Attributes["id"].Value;
                        PricingModel ob = new PricingModel(pricingModelNode);
                        IDManager.SetID(pricingModelIDRef_, ob);
                    }
                    else if (pricingModelNode.Attributes["href"] != null)
                    {
                        pricingModelIDRef_ = pricingModelNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pricingModel_ = new PricingModel(pricingModelNode);
                    }
                }
                else
                {
                    pricingModel_ = new PricingModel(pricingModelNode);
                }
            }
            
        
            XmlNode timeNode = xmlNode.SelectSingleNode("time");
            
            if (timeNode != null)
            {
                if (timeNode.Attributes["href"] != null || timeNode.Attributes["id"] != null) 
                {
                    if (timeNode.Attributes["id"] != null) 
                    {
                        timeIDRef_ = timeNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(timeNode);
                        IDManager.SetID(timeIDRef_, ob);
                    }
                    else if (timeNode.Attributes["href"] != null)
                    {
                        timeIDRef_ = timeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        time_ = new XsdTypeDateTime(timeNode);
                    }
                }
                else
                {
                    time_ = new XsdTypeDateTime(timeNode);
                }
            }
            
        
            XmlNode valuationDateNode = xmlNode.SelectSingleNode("valuationDate");
            
            if (valuationDateNode != null)
            {
                if (valuationDateNode.Attributes["href"] != null || valuationDateNode.Attributes["id"] != null) 
                {
                    if (valuationDateNode.Attributes["id"] != null) 
                    {
                        valuationDateIDRef_ = valuationDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(valuationDateNode);
                        IDManager.SetID(valuationDateIDRef_, ob);
                    }
                    else if (valuationDateNode.Attributes["href"] != null)
                    {
                        valuationDateIDRef_ = valuationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationDate_ = new XsdTypeDate(valuationDateNode);
                    }
                }
                else
                {
                    valuationDate_ = new XsdTypeDate(valuationDateNode);
                }
            }
            
        
            XmlNode expiryTimeNode = xmlNode.SelectSingleNode("expiryTime");
            
            if (expiryTimeNode != null)
            {
                if (expiryTimeNode.Attributes["href"] != null || expiryTimeNode.Attributes["id"] != null) 
                {
                    if (expiryTimeNode.Attributes["id"] != null) 
                    {
                        expiryTimeIDRef_ = expiryTimeNode.Attributes["id"].Value;
                        XsdTypeDateTime ob = new XsdTypeDateTime(expiryTimeNode);
                        IDManager.SetID(expiryTimeIDRef_, ob);
                    }
                    else if (expiryTimeNode.Attributes["href"] != null)
                    {
                        expiryTimeIDRef_ = expiryTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expiryTime_ = new XsdTypeDateTime(expiryTimeNode);
                    }
                }
                else
                {
                    expiryTime_ = new XsdTypeDateTime(expiryTimeNode);
                }
            }
            
        
            XmlNode cashflowTypeNode = xmlNode.SelectSingleNode("cashflowType");
            
            if (cashflowTypeNode != null)
            {
                if (cashflowTypeNode.Attributes["href"] != null || cashflowTypeNode.Attributes["id"] != null) 
                {
                    if (cashflowTypeNode.Attributes["id"] != null) 
                    {
                        cashflowTypeIDRef_ = cashflowTypeNode.Attributes["id"].Value;
                        CashflowType ob = new CashflowType(cashflowTypeNode);
                        IDManager.SetID(cashflowTypeIDRef_, ob);
                    }
                    else if (cashflowTypeNode.Attributes["href"] != null)
                    {
                        cashflowTypeIDRef_ = cashflowTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashflowType_ = new CashflowType(cashflowTypeNode);
                    }
                }
                else
                {
                    cashflowType_ = new CashflowType(cashflowTypeNode);
                }
            }
            
        
            XmlNodeList pointNodeList = xmlNode.SelectNodes("point");
            
            if (pointNodeList != null)
            {
                this.point_ = new List<PricingStructurePoint>();
                foreach (XmlNode item in pointNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            pointIDRef_ = item.Attributes["id"].Value;
                            point_.Add(new PricingStructurePoint(item));
                            IDManager.SetID(pointIDRef_, point_[point_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            pointIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        point_.Add(new PricingStructurePoint(item));
                        }
                    }
                    else
                    {
                        point_.Add(new PricingStructurePoint(item));
                    }
                }
            }
            
        
        }
        
    
        #region MeasureType_
        private AssetMeasureType measureType_;
        public AssetMeasureType MeasureType_
        {
            get
            {
                if (this.measureType_ != null)
                {
                    return this.measureType_; 
                }
                else if (this.measureTypeIDRef_ != null)
                {
                    measureType_ = IDManager.getID(measureTypeIDRef_) as AssetMeasureType;
                    return this.measureType_; 
                }
                else
                {
                      return this.measureType_; 
                }
            }
            set
            {
                if (this.measureType_ != value)
                {
                    this.measureType_ = value;
                }
            }
        }
        #endregion
        
        public string measureTypeIDRef_ { get; set; }
        #region QuoteUnits_
        private PriceQuoteUnits quoteUnits_;
        public PriceQuoteUnits QuoteUnits_
        {
            get
            {
                if (this.quoteUnits_ != null)
                {
                    return this.quoteUnits_; 
                }
                else if (this.quoteUnitsIDRef_ != null)
                {
                    quoteUnits_ = IDManager.getID(quoteUnitsIDRef_) as PriceQuoteUnits;
                    return this.quoteUnits_; 
                }
                else
                {
                      return this.quoteUnits_; 
                }
            }
            set
            {
                if (this.quoteUnits_ != value)
                {
                    this.quoteUnits_ = value;
                }
            }
        }
        #endregion
        
        public string quoteUnitsIDRef_ { get; set; }
        #region Side_
        private QuotationSideEnum side_;
        public QuotationSideEnum Side_
        {
            get
            {
                if (this.side_ != null)
                {
                    return this.side_; 
                }
                else if (this.sideIDRef_ != null)
                {
                    side_ = IDManager.getID(sideIDRef_) as QuotationSideEnum;
                    return this.side_; 
                }
                else
                {
                      return this.side_; 
                }
            }
            set
            {
                if (this.side_ != value)
                {
                    this.side_ = value;
                }
            }
        }
        #endregion
        
        public string sideIDRef_ { get; set; }
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
        #region CurrencyType_
        private ReportingCurrencyType currencyType_;
        public ReportingCurrencyType CurrencyType_
        {
            get
            {
                if (this.currencyType_ != null)
                {
                    return this.currencyType_; 
                }
                else if (this.currencyTypeIDRef_ != null)
                {
                    currencyType_ = IDManager.getID(currencyTypeIDRef_) as ReportingCurrencyType;
                    return this.currencyType_; 
                }
                else
                {
                      return this.currencyType_; 
                }
            }
            set
            {
                if (this.currencyType_ != value)
                {
                    this.currencyType_ = value;
                }
            }
        }
        #endregion
        
        public string currencyTypeIDRef_ { get; set; }
        #region Timing_
        private QuoteTiming timing_;
        public QuoteTiming Timing_
        {
            get
            {
                if (this.timing_ != null)
                {
                    return this.timing_; 
                }
                else if (this.timingIDRef_ != null)
                {
                    timing_ = IDManager.getID(timingIDRef_) as QuoteTiming;
                    return this.timing_; 
                }
                else
                {
                      return this.timing_; 
                }
            }
            set
            {
                if (this.timing_ != value)
                {
                    this.timing_ = value;
                }
            }
        }
        #endregion
        
        public string timingIDRef_ { get; set; }
        #region BusinessCenter_
        private BusinessCenter businessCenter_;
        public BusinessCenter BusinessCenter_
        {
            get
            {
                if (this.businessCenter_ != null)
                {
                    return this.businessCenter_; 
                }
                else if (this.businessCenterIDRef_ != null)
                {
                    businessCenter_ = IDManager.getID(businessCenterIDRef_) as BusinessCenter;
                    return this.businessCenter_; 
                }
                else
                {
                      return this.businessCenter_; 
                }
            }
            set
            {
                if (this.businessCenter_ != value)
                {
                    this.businessCenter_ = value;
                }
            }
        }
        #endregion
        
        public string businessCenterIDRef_ { get; set; }
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
        #region InformationSource_
        private List<InformationSource> informationSource_;
        public List<InformationSource> InformationSource_
        {
            get
            {
                if (this.informationSource_ != null)
                {
                    return this.informationSource_; 
                }
                else if (this.informationSourceIDRef_ != null)
                {
                    return this.informationSource_; 
                }
                else
                {
                      return this.informationSource_; 
                }
            }
            set
            {
                if (this.informationSource_ != value)
                {
                    this.informationSource_ = value;
                }
            }
        }
        #endregion
        
        public string informationSourceIDRef_ { get; set; }
        #region PricingModel_
        private PricingModel pricingModel_;
        public PricingModel PricingModel_
        {
            get
            {
                if (this.pricingModel_ != null)
                {
                    return this.pricingModel_; 
                }
                else if (this.pricingModelIDRef_ != null)
                {
                    pricingModel_ = IDManager.getID(pricingModelIDRef_) as PricingModel;
                    return this.pricingModel_; 
                }
                else
                {
                      return this.pricingModel_; 
                }
            }
            set
            {
                if (this.pricingModel_ != value)
                {
                    this.pricingModel_ = value;
                }
            }
        }
        #endregion
        
        public string pricingModelIDRef_ { get; set; }
        #region Time_
        private XsdTypeDateTime time_;
        public XsdTypeDateTime Time_
        {
            get
            {
                if (this.time_ != null)
                {
                    return this.time_; 
                }
                else if (this.timeIDRef_ != null)
                {
                    time_ = IDManager.getID(timeIDRef_) as XsdTypeDateTime;
                    return this.time_; 
                }
                else
                {
                      return this.time_; 
                }
            }
            set
            {
                if (this.time_ != value)
                {
                    this.time_ = value;
                }
            }
        }
        #endregion
        
        public string timeIDRef_ { get; set; }
        #region ValuationDate_
        private XsdTypeDate valuationDate_;
        public XsdTypeDate ValuationDate_
        {
            get
            {
                if (this.valuationDate_ != null)
                {
                    return this.valuationDate_; 
                }
                else if (this.valuationDateIDRef_ != null)
                {
                    valuationDate_ = IDManager.getID(valuationDateIDRef_) as XsdTypeDate;
                    return this.valuationDate_; 
                }
                else
                {
                      return this.valuationDate_; 
                }
            }
            set
            {
                if (this.valuationDate_ != value)
                {
                    this.valuationDate_ = value;
                }
            }
        }
        #endregion
        
        public string valuationDateIDRef_ { get; set; }
        #region ExpiryTime_
        private XsdTypeDateTime expiryTime_;
        public XsdTypeDateTime ExpiryTime_
        {
            get
            {
                if (this.expiryTime_ != null)
                {
                    return this.expiryTime_; 
                }
                else if (this.expiryTimeIDRef_ != null)
                {
                    expiryTime_ = IDManager.getID(expiryTimeIDRef_) as XsdTypeDateTime;
                    return this.expiryTime_; 
                }
                else
                {
                      return this.expiryTime_; 
                }
            }
            set
            {
                if (this.expiryTime_ != value)
                {
                    this.expiryTime_ = value;
                }
            }
        }
        #endregion
        
        public string expiryTimeIDRef_ { get; set; }
        #region CashflowType_
        private CashflowType cashflowType_;
        public CashflowType CashflowType_
        {
            get
            {
                if (this.cashflowType_ != null)
                {
                    return this.cashflowType_; 
                }
                else if (this.cashflowTypeIDRef_ != null)
                {
                    cashflowType_ = IDManager.getID(cashflowTypeIDRef_) as CashflowType;
                    return this.cashflowType_; 
                }
                else
                {
                      return this.cashflowType_; 
                }
            }
            set
            {
                if (this.cashflowType_ != value)
                {
                    this.cashflowType_ = value;
                }
            }
        }
        #endregion
        
        public string cashflowTypeIDRef_ { get; set; }
        #region Point_
        private List<PricingStructurePoint> point_;
        public List<PricingStructurePoint> Point_
        {
            get
            {
                if (this.point_ != null)
                {
                    return this.point_; 
                }
                else if (this.pointIDRef_ != null)
                {
                    return this.point_; 
                }
                else
                {
                      return this.point_; 
                }
            }
            set
            {
                if (this.point_ != value)
                {
                    this.point_ = value;
                }
            }
        }
        #endregion
        
        public string pointIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

