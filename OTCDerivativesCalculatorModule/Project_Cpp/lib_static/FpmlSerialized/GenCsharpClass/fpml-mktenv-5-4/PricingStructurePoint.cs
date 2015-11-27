using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PricingStructurePoint
    {
        public PricingStructurePoint(XmlNode xmlNode)
        {
            XmlNodeList coordinateNodeList = xmlNode.SelectNodes("coordinate");
            if (coordinateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in coordinateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        coordinateIDRef = item.Attributes["id"].Name;
                        PricingDataPointCoordinate ob = PricingDataPointCoordinate();
                        IDManager.SetID(coordinateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        coordinateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        coordinate = new PricingDataPointCoordinate(item);
                    }
                }
            }
            
        
            XmlNodeList coordinateReferenceNodeList = xmlNode.SelectNodes("coordinateReference");
            if (coordinateReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in coordinateReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        coordinateReferenceIDRef = item.Attributes["id"].Name;
                        PricingDataPointCoordinateReference ob = PricingDataPointCoordinateReference();
                        IDManager.SetID(coordinateReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        coordinateReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        coordinateReference = new PricingDataPointCoordinateReference(item);
                    }
                }
            }
            
        
            XmlNodeList underlyingAssetNodeList = xmlNode.SelectNodes("underlyingAsset");
            if (underlyingAssetNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in underlyingAssetNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        underlyingAssetIDRef = item.Attributes["id"].Name;
                        Asset ob = Asset();
                        IDManager.SetID(underlyingAssetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        underlyingAssetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        underlyingAsset = new Asset(item);
                    }
                }
            }
            
        
            XmlNodeList basketNodeList = xmlNode.SelectNodes("basket");
            if (basketNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in basketNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        basketIDRef = item.Attributes["id"].Name;
                        Basket ob = Basket();
                        IDManager.SetID(basketIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        basketIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        basket = new Basket(item);
                    }
                }
            }
            
        
            XmlNodeList bondNodeList = xmlNode.SelectNodes("bond");
            if (bondNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in bondNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        bondIDRef = item.Attributes["id"].Name;
                        Bond ob = Bond();
                        IDManager.SetID(bondIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        bondIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        bond = new Bond(item);
                    }
                }
            }
            
        
            XmlNodeList cashNodeList = xmlNode.SelectNodes("cash");
            if (cashNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashIDRef = item.Attributes["id"].Name;
                        Cash ob = Cash();
                        IDManager.SetID(cashIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cash = new Cash(item);
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
            
        
            XmlNodeList convertibleBondNodeList = xmlNode.SelectNodes("convertibleBond");
            if (convertibleBondNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in convertibleBondNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        convertibleBondIDRef = item.Attributes["id"].Name;
                        ConvertibleBond ob = ConvertibleBond();
                        IDManager.SetID(convertibleBondIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        convertibleBondIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        convertibleBond = new ConvertibleBond(item);
                    }
                }
            }
            
        
            XmlNodeList equityNodeList = xmlNode.SelectNodes("equity");
            if (equityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equityIDRef = item.Attributes["id"].Name;
                        EquityAsset ob = EquityAsset();
                        IDManager.SetID(equityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equity = new EquityAsset(item);
                    }
                }
            }
            
        
            XmlNodeList exchangeTradedFundNodeList = xmlNode.SelectNodes("exchangeTradedFund");
            if (exchangeTradedFundNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exchangeTradedFundNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exchangeTradedFundIDRef = item.Attributes["id"].Name;
                        ExchangeTradedFund ob = ExchangeTradedFund();
                        IDManager.SetID(exchangeTradedFundIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exchangeTradedFundIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exchangeTradedFund = new ExchangeTradedFund(item);
                    }
                }
            }
            
        
            XmlNodeList futureNodeList = xmlNode.SelectNodes("future");
            if (futureNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in futureNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        futureIDRef = item.Attributes["id"].Name;
                        Future ob = Future();
                        IDManager.SetID(futureIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        futureIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        future = new Future(item);
                    }
                }
            }
            
        
            XmlNodeList indexNodeList = xmlNode.SelectNodes("index");
            if (indexNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexIDRef = item.Attributes["id"].Name;
                        Index ob = Index();
                        IDManager.SetID(indexIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        index = new Index(item);
                    }
                }
            }
            
        
            XmlNodeList loanNodeList = xmlNode.SelectNodes("loan");
            if (loanNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in loanNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        loanIDRef = item.Attributes["id"].Name;
                        Loan ob = Loan();
                        IDManager.SetID(loanIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        loanIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        loan = new Loan(item);
                    }
                }
            }
            
        
            XmlNodeList mortgageNodeList = xmlNode.SelectNodes("mortgage");
            if (mortgageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in mortgageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        mortgageIDRef = item.Attributes["id"].Name;
                        Mortgage ob = Mortgage();
                        IDManager.SetID(mortgageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        mortgageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        mortgage = new Mortgage(item);
                    }
                }
            }
            
        
            XmlNodeList mutualFundNodeList = xmlNode.SelectNodes("mutualFund");
            if (mutualFundNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in mutualFundNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        mutualFundIDRef = item.Attributes["id"].Name;
                        MutualFund ob = MutualFund();
                        IDManager.SetID(mutualFundIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        mutualFundIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        mutualFund = new MutualFund(item);
                    }
                }
            }
            
        
            XmlNodeList underlyingAssetReferenceNodeList = xmlNode.SelectNodes("underlyingAssetReference");
            if (underlyingAssetReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in underlyingAssetReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        underlyingAssetReferenceIDRef = item.Attributes["id"].Name;
                        AssetReference ob = AssetReference();
                        IDManager.SetID(underlyingAssetReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        underlyingAssetReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        underlyingAssetReference = new AssetReference(item);
                    }
                }
            }
            
        
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
            
        
        }
        
    
        #region Coordinate
        private PricingDataPointCoordinate coordinate;
        public PricingDataPointCoordinate Coordinate
        {
            get
            {
                if (this.coordinate != null)
                {
                    return this.coordinate; 
                }
                else if (this.coordinateIDRef != null)
                {
                    coordinate = IDManager.getID(coordinateIDRef) as PricingDataPointCoordinate;
                    return this.coordinate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.coordinate != value)
                {
                    this.coordinate = value;
                }
            }
        }
        #endregion
        
        public string PricingDataPointCoordinateIDRef { get; set; }
        #region CoordinateReference
        private PricingDataPointCoordinateReference coordinateReference;
        public PricingDataPointCoordinateReference CoordinateReference
        {
            get
            {
                if (this.coordinateReference != null)
                {
                    return this.coordinateReference; 
                }
                else if (this.coordinateReferenceIDRef != null)
                {
                    coordinateReference = IDManager.getID(coordinateReferenceIDRef) as PricingDataPointCoordinateReference;
                    return this.coordinateReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.coordinateReference != value)
                {
                    this.coordinateReference = value;
                }
            }
        }
        #endregion
        
        public string PricingDataPointCoordinateReferenceIDRef { get; set; }
        #region UnderlyingAsset
        private Asset underlyingAsset;
        public Asset UnderlyingAsset
        {
            get
            {
                if (this.underlyingAsset != null)
                {
                    return this.underlyingAsset; 
                }
                else if (this.underlyingAssetIDRef != null)
                {
                    underlyingAsset = IDManager.getID(underlyingAssetIDRef) as Asset;
                    return this.underlyingAsset; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.underlyingAsset != value)
                {
                    this.underlyingAsset = value;
                }
            }
        }
        #endregion
        
        public string AssetIDRef { get; set; }
        #region Basket
        private Basket basket;
        public Basket Basket
        {
            get
            {
                if (this.basket != null)
                {
                    return this.basket; 
                }
                else if (this.basketIDRef != null)
                {
                    basket = IDManager.getID(basketIDRef) as Basket;
                    return this.basket; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.basket != value)
                {
                    this.basket = value;
                }
            }
        }
        #endregion
        
        public string BasketIDRef { get; set; }     // substitude
        #region Bond
        private Bond bond;
        public Bond Bond
        {
            get
            {
                if (this.bond != null)
                {
                    return this.bond; 
                }
                else if (this.bondIDRef != null)
                {
                    bond = IDManager.getID(bondIDRef) as Bond;
                    return this.bond; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.bond != value)
                {
                    this.bond = value;
                }
            }
        }
        #endregion
        
        public string BondIDRef { get; set; }     // substitude
        #region Cash
        private Cash cash;
        public Cash Cash
        {
            get
            {
                if (this.cash != null)
                {
                    return this.cash; 
                }
                else if (this.cashIDRef != null)
                {
                    cash = IDManager.getID(cashIDRef) as Cash;
                    return this.cash; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cash != value)
                {
                    this.cash = value;
                }
            }
        }
        #endregion
        
        public string CashIDRef { get; set; }     // substitude
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
        
        public string CommodityIDRef { get; set; }     // substitude
        #region ConvertibleBond
        private ConvertibleBond convertibleBond;
        public ConvertibleBond ConvertibleBond
        {
            get
            {
                if (this.convertibleBond != null)
                {
                    return this.convertibleBond; 
                }
                else if (this.convertibleBondIDRef != null)
                {
                    convertibleBond = IDManager.getID(convertibleBondIDRef) as ConvertibleBond;
                    return this.convertibleBond; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.convertibleBond != value)
                {
                    this.convertibleBond = value;
                }
            }
        }
        #endregion
        
        public string ConvertibleBondIDRef { get; set; }     // substitude
        #region Equity
        private EquityAsset equity;
        public EquityAsset Equity
        {
            get
            {
                if (this.equity != null)
                {
                    return this.equity; 
                }
                else if (this.equityIDRef != null)
                {
                    equity = IDManager.getID(equityIDRef) as EquityAsset;
                    return this.equity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equity != value)
                {
                    this.equity = value;
                }
            }
        }
        #endregion
        
        public string EquityAssetIDRef { get; set; }     // substitude
        #region ExchangeTradedFund
        private ExchangeTradedFund exchangeTradedFund;
        public ExchangeTradedFund ExchangeTradedFund
        {
            get
            {
                if (this.exchangeTradedFund != null)
                {
                    return this.exchangeTradedFund; 
                }
                else if (this.exchangeTradedFundIDRef != null)
                {
                    exchangeTradedFund = IDManager.getID(exchangeTradedFundIDRef) as ExchangeTradedFund;
                    return this.exchangeTradedFund; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exchangeTradedFund != value)
                {
                    this.exchangeTradedFund = value;
                }
            }
        }
        #endregion
        
        public string ExchangeTradedFundIDRef { get; set; }     // substitude
        #region Future
        private Future future;
        public Future Future
        {
            get
            {
                if (this.future != null)
                {
                    return this.future; 
                }
                else if (this.futureIDRef != null)
                {
                    future = IDManager.getID(futureIDRef) as Future;
                    return this.future; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.future != value)
                {
                    this.future = value;
                }
            }
        }
        #endregion
        
        public string FutureIDRef { get; set; }     // substitude
        #region Index
        private Index index;
        public Index Index
        {
            get
            {
                if (this.index != null)
                {
                    return this.index; 
                }
                else if (this.indexIDRef != null)
                {
                    index = IDManager.getID(indexIDRef) as Index;
                    return this.index; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.index != value)
                {
                    this.index = value;
                }
            }
        }
        #endregion
        
        public string IndexIDRef { get; set; }     // substitude
        #region Loan
        private Loan loan;
        public Loan Loan
        {
            get
            {
                if (this.loan != null)
                {
                    return this.loan; 
                }
                else if (this.loanIDRef != null)
                {
                    loan = IDManager.getID(loanIDRef) as Loan;
                    return this.loan; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.loan != value)
                {
                    this.loan = value;
                }
            }
        }
        #endregion
        
        public string LoanIDRef { get; set; }     // substitude
        #region Mortgage
        private Mortgage mortgage;
        public Mortgage Mortgage
        {
            get
            {
                if (this.mortgage != null)
                {
                    return this.mortgage; 
                }
                else if (this.mortgageIDRef != null)
                {
                    mortgage = IDManager.getID(mortgageIDRef) as Mortgage;
                    return this.mortgage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.mortgage != value)
                {
                    this.mortgage = value;
                }
            }
        }
        #endregion
        
        public string MortgageIDRef { get; set; }     // substitude
        #region MutualFund
        private MutualFund mutualFund;
        public MutualFund MutualFund
        {
            get
            {
                if (this.mutualFund != null)
                {
                    return this.mutualFund; 
                }
                else if (this.mutualFundIDRef != null)
                {
                    mutualFund = IDManager.getID(mutualFundIDRef) as MutualFund;
                    return this.mutualFund; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.mutualFund != value)
                {
                    this.mutualFund = value;
                }
            }
        }
        #endregion
        
        public string MutualFundIDRef { get; set; }     // substitude
        #region UnderlyingAssetReference
        private AssetReference underlyingAssetReference;
        public AssetReference UnderlyingAssetReference
        {
            get
            {
                if (this.underlyingAssetReference != null)
                {
                    return this.underlyingAssetReference; 
                }
                else if (this.underlyingAssetReferenceIDRef != null)
                {
                    underlyingAssetReference = IDManager.getID(underlyingAssetReferenceIDRef) as AssetReference;
                    return this.underlyingAssetReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.underlyingAssetReference != value)
                {
                    this.underlyingAssetReference = value;
                }
            }
        }
        #endregion
        
        public string AssetReferenceIDRef { get; set; }
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
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        
    
        
    
    }
    
}

