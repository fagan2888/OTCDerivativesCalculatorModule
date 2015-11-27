using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PricingStructurePoint : ISerialized
    {
        public PricingStructurePoint(XmlNode xmlNode)
        {
            XmlNode coordinateNode = xmlNode.SelectSingleNode("coordinate");
            
            if (coordinateNode != null)
            {
                if (coordinateNode.Attributes["href"] != null || coordinateNode.Attributes["id"] != null) 
                {
                    if (coordinateNode.Attributes["id"] != null) 
                    {
                        coordinateIDRef_ = coordinateNode.Attributes["id"].Value;
                        PricingDataPointCoordinate ob = new PricingDataPointCoordinate(coordinateNode);
                        IDManager.SetID(coordinateIDRef_, ob);
                    }
                    else if (coordinateNode.Attributes["href"] != null)
                    {
                        coordinateIDRef_ = coordinateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        coordinate_ = new PricingDataPointCoordinate(coordinateNode);
                    }
                }
                else
                {
                    coordinate_ = new PricingDataPointCoordinate(coordinateNode);
                }
            }
            
        
            XmlNode coordinateReferenceNode = xmlNode.SelectSingleNode("coordinateReference");
            
            if (coordinateReferenceNode != null)
            {
                if (coordinateReferenceNode.Attributes["href"] != null || coordinateReferenceNode.Attributes["id"] != null) 
                {
                    if (coordinateReferenceNode.Attributes["id"] != null) 
                    {
                        coordinateReferenceIDRef_ = coordinateReferenceNode.Attributes["id"].Value;
                        PricingDataPointCoordinateReference ob = new PricingDataPointCoordinateReference(coordinateReferenceNode);
                        IDManager.SetID(coordinateReferenceIDRef_, ob);
                    }
                    else if (coordinateReferenceNode.Attributes["href"] != null)
                    {
                        coordinateReferenceIDRef_ = coordinateReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        coordinateReference_ = new PricingDataPointCoordinateReference(coordinateReferenceNode);
                    }
                }
                else
                {
                    coordinateReference_ = new PricingDataPointCoordinateReference(coordinateReferenceNode);
                }
            }
            
        
            XmlNode underlyingAssetNode = xmlNode.SelectSingleNode("underlyingAsset");
            
            if (underlyingAssetNode != null)
            {
                if (underlyingAssetNode.Attributes["href"] != null || underlyingAssetNode.Attributes["id"] != null) 
                {
                    if (underlyingAssetNode.Attributes["id"] != null) 
                    {
                        underlyingAssetIDRef_ = underlyingAssetNode.Attributes["id"].Value;
                        Asset ob = new Asset(underlyingAssetNode);
                        IDManager.SetID(underlyingAssetIDRef_, ob);
                    }
                    else if (underlyingAssetNode.Attributes["href"] != null)
                    {
                        underlyingAssetIDRef_ = underlyingAssetNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underlyingAsset_ = new Asset(underlyingAssetNode);
                    }
                }
                else
                {
                    underlyingAsset_ = new Asset(underlyingAssetNode);
                }
            }
            
        
            XmlNode basketNode = xmlNode.SelectSingleNode("basket");
            
            if (basketNode != null)
            {
                if (basketNode.Attributes["href"] != null || basketNode.Attributes["id"] != null) 
                {
                    if (basketNode.Attributes["id"] != null) 
                    {
                        basketIDRef_ = basketNode.Attributes["id"].Value;
                        Basket ob = new Basket(basketNode);
                        IDManager.SetID(basketIDRef_, ob);
                    }
                    else if (basketNode.Attributes["href"] != null)
                    {
                        basketIDRef_ = basketNode.Attributes["href"].Value;
                    }
                    else
                    {
                        basket_ = new Basket(basketNode);
                    }
                }
                else
                {
                    basket_ = new Basket(basketNode);
                }
            }
            
        
            XmlNode bondNode = xmlNode.SelectSingleNode("bond");
            
            if (bondNode != null)
            {
                if (bondNode.Attributes["href"] != null || bondNode.Attributes["id"] != null) 
                {
                    if (bondNode.Attributes["id"] != null) 
                    {
                        bondIDRef_ = bondNode.Attributes["id"].Value;
                        Bond ob = new Bond(bondNode);
                        IDManager.SetID(bondIDRef_, ob);
                    }
                    else if (bondNode.Attributes["href"] != null)
                    {
                        bondIDRef_ = bondNode.Attributes["href"].Value;
                    }
                    else
                    {
                        bond_ = new Bond(bondNode);
                    }
                }
                else
                {
                    bond_ = new Bond(bondNode);
                }
            }
            
        
            XmlNode cashNode = xmlNode.SelectSingleNode("cash");
            
            if (cashNode != null)
            {
                if (cashNode.Attributes["href"] != null || cashNode.Attributes["id"] != null) 
                {
                    if (cashNode.Attributes["id"] != null) 
                    {
                        cashIDRef_ = cashNode.Attributes["id"].Value;
                        Cash ob = new Cash(cashNode);
                        IDManager.SetID(cashIDRef_, ob);
                    }
                    else if (cashNode.Attributes["href"] != null)
                    {
                        cashIDRef_ = cashNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cash_ = new Cash(cashNode);
                    }
                }
                else
                {
                    cash_ = new Cash(cashNode);
                }
            }
            
        
            XmlNode commodityNode = xmlNode.SelectSingleNode("commodity");
            
            if (commodityNode != null)
            {
                if (commodityNode.Attributes["href"] != null || commodityNode.Attributes["id"] != null) 
                {
                    if (commodityNode.Attributes["id"] != null) 
                    {
                        commodityIDRef_ = commodityNode.Attributes["id"].Value;
                        Commodity ob = new Commodity(commodityNode);
                        IDManager.SetID(commodityIDRef_, ob);
                    }
                    else if (commodityNode.Attributes["href"] != null)
                    {
                        commodityIDRef_ = commodityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commodity_ = new Commodity(commodityNode);
                    }
                }
                else
                {
                    commodity_ = new Commodity(commodityNode);
                }
            }
            
        
            XmlNode convertibleBondNode = xmlNode.SelectSingleNode("convertibleBond");
            
            if (convertibleBondNode != null)
            {
                if (convertibleBondNode.Attributes["href"] != null || convertibleBondNode.Attributes["id"] != null) 
                {
                    if (convertibleBondNode.Attributes["id"] != null) 
                    {
                        convertibleBondIDRef_ = convertibleBondNode.Attributes["id"].Value;
                        ConvertibleBond ob = new ConvertibleBond(convertibleBondNode);
                        IDManager.SetID(convertibleBondIDRef_, ob);
                    }
                    else if (convertibleBondNode.Attributes["href"] != null)
                    {
                        convertibleBondIDRef_ = convertibleBondNode.Attributes["href"].Value;
                    }
                    else
                    {
                        convertibleBond_ = new ConvertibleBond(convertibleBondNode);
                    }
                }
                else
                {
                    convertibleBond_ = new ConvertibleBond(convertibleBondNode);
                }
            }
            
        
            XmlNode equityNode = xmlNode.SelectSingleNode("equity");
            
            if (equityNode != null)
            {
                if (equityNode.Attributes["href"] != null || equityNode.Attributes["id"] != null) 
                {
                    if (equityNode.Attributes["id"] != null) 
                    {
                        equityIDRef_ = equityNode.Attributes["id"].Value;
                        EquityAsset ob = new EquityAsset(equityNode);
                        IDManager.SetID(equityIDRef_, ob);
                    }
                    else if (equityNode.Attributes["href"] != null)
                    {
                        equityIDRef_ = equityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equity_ = new EquityAsset(equityNode);
                    }
                }
                else
                {
                    equity_ = new EquityAsset(equityNode);
                }
            }
            
        
            XmlNode exchangeTradedFundNode = xmlNode.SelectSingleNode("exchangeTradedFund");
            
            if (exchangeTradedFundNode != null)
            {
                if (exchangeTradedFundNode.Attributes["href"] != null || exchangeTradedFundNode.Attributes["id"] != null) 
                {
                    if (exchangeTradedFundNode.Attributes["id"] != null) 
                    {
                        exchangeTradedFundIDRef_ = exchangeTradedFundNode.Attributes["id"].Value;
                        ExchangeTradedFund ob = new ExchangeTradedFund(exchangeTradedFundNode);
                        IDManager.SetID(exchangeTradedFundIDRef_, ob);
                    }
                    else if (exchangeTradedFundNode.Attributes["href"] != null)
                    {
                        exchangeTradedFundIDRef_ = exchangeTradedFundNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exchangeTradedFund_ = new ExchangeTradedFund(exchangeTradedFundNode);
                    }
                }
                else
                {
                    exchangeTradedFund_ = new ExchangeTradedFund(exchangeTradedFundNode);
                }
            }
            
        
            XmlNode futureNode = xmlNode.SelectSingleNode("future");
            
            if (futureNode != null)
            {
                if (futureNode.Attributes["href"] != null || futureNode.Attributes["id"] != null) 
                {
                    if (futureNode.Attributes["id"] != null) 
                    {
                        futureIDRef_ = futureNode.Attributes["id"].Value;
                        Future ob = new Future(futureNode);
                        IDManager.SetID(futureIDRef_, ob);
                    }
                    else if (futureNode.Attributes["href"] != null)
                    {
                        futureIDRef_ = futureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        future_ = new Future(futureNode);
                    }
                }
                else
                {
                    future_ = new Future(futureNode);
                }
            }
            
        
            XmlNode indexNode = xmlNode.SelectSingleNode("index");
            
            if (indexNode != null)
            {
                if (indexNode.Attributes["href"] != null || indexNode.Attributes["id"] != null) 
                {
                    if (indexNode.Attributes["id"] != null) 
                    {
                        indexIDRef_ = indexNode.Attributes["id"].Value;
                        Index ob = new Index(indexNode);
                        IDManager.SetID(indexIDRef_, ob);
                    }
                    else if (indexNode.Attributes["href"] != null)
                    {
                        indexIDRef_ = indexNode.Attributes["href"].Value;
                    }
                    else
                    {
                        index_ = new Index(indexNode);
                    }
                }
                else
                {
                    index_ = new Index(indexNode);
                }
            }
            
        
            XmlNode loanNode = xmlNode.SelectSingleNode("loan");
            
            if (loanNode != null)
            {
                if (loanNode.Attributes["href"] != null || loanNode.Attributes["id"] != null) 
                {
                    if (loanNode.Attributes["id"] != null) 
                    {
                        loanIDRef_ = loanNode.Attributes["id"].Value;
                        Loan ob = new Loan(loanNode);
                        IDManager.SetID(loanIDRef_, ob);
                    }
                    else if (loanNode.Attributes["href"] != null)
                    {
                        loanIDRef_ = loanNode.Attributes["href"].Value;
                    }
                    else
                    {
                        loan_ = new Loan(loanNode);
                    }
                }
                else
                {
                    loan_ = new Loan(loanNode);
                }
            }
            
        
            XmlNode mortgageNode = xmlNode.SelectSingleNode("mortgage");
            
            if (mortgageNode != null)
            {
                if (mortgageNode.Attributes["href"] != null || mortgageNode.Attributes["id"] != null) 
                {
                    if (mortgageNode.Attributes["id"] != null) 
                    {
                        mortgageIDRef_ = mortgageNode.Attributes["id"].Value;
                        Mortgage ob = new Mortgage(mortgageNode);
                        IDManager.SetID(mortgageIDRef_, ob);
                    }
                    else if (mortgageNode.Attributes["href"] != null)
                    {
                        mortgageIDRef_ = mortgageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        mortgage_ = new Mortgage(mortgageNode);
                    }
                }
                else
                {
                    mortgage_ = new Mortgage(mortgageNode);
                }
            }
            
        
            XmlNode mutualFundNode = xmlNode.SelectSingleNode("mutualFund");
            
            if (mutualFundNode != null)
            {
                if (mutualFundNode.Attributes["href"] != null || mutualFundNode.Attributes["id"] != null) 
                {
                    if (mutualFundNode.Attributes["id"] != null) 
                    {
                        mutualFundIDRef_ = mutualFundNode.Attributes["id"].Value;
                        MutualFund ob = new MutualFund(mutualFundNode);
                        IDManager.SetID(mutualFundIDRef_, ob);
                    }
                    else if (mutualFundNode.Attributes["href"] != null)
                    {
                        mutualFundIDRef_ = mutualFundNode.Attributes["href"].Value;
                    }
                    else
                    {
                        mutualFund_ = new MutualFund(mutualFundNode);
                    }
                }
                else
                {
                    mutualFund_ = new MutualFund(mutualFundNode);
                }
            }
            
        
            XmlNode underlyingAssetReferenceNode = xmlNode.SelectSingleNode("underlyingAssetReference");
            
            if (underlyingAssetReferenceNode != null)
            {
                if (underlyingAssetReferenceNode.Attributes["href"] != null || underlyingAssetReferenceNode.Attributes["id"] != null) 
                {
                    if (underlyingAssetReferenceNode.Attributes["id"] != null) 
                    {
                        underlyingAssetReferenceIDRef_ = underlyingAssetReferenceNode.Attributes["id"].Value;
                        AssetReference ob = new AssetReference(underlyingAssetReferenceNode);
                        IDManager.SetID(underlyingAssetReferenceIDRef_, ob);
                    }
                    else if (underlyingAssetReferenceNode.Attributes["href"] != null)
                    {
                        underlyingAssetReferenceIDRef_ = underlyingAssetReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underlyingAssetReference_ = new AssetReference(underlyingAssetReferenceNode);
                    }
                }
                else
                {
                    underlyingAssetReference_ = new AssetReference(underlyingAssetReferenceNode);
                }
            }
            
        
            XmlNode valueNode = xmlNode.SelectSingleNode("value");
            
            if (valueNode != null)
            {
                if (valueNode.Attributes["href"] != null || valueNode.Attributes["id"] != null) 
                {
                    if (valueNode.Attributes["id"] != null) 
                    {
                        valueIDRef_ = valueNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(valueNode);
                        IDManager.SetID(valueIDRef_, ob);
                    }
                    else if (valueNode.Attributes["href"] != null)
                    {
                        valueIDRef_ = valueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        value_ = new XsdTypeDecimal(valueNode);
                    }
                }
                else
                {
                    value_ = new XsdTypeDecimal(valueNode);
                }
            }
            
        
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
            
        
        }
        
    
        #region Coordinate_
        private PricingDataPointCoordinate coordinate_;
        public PricingDataPointCoordinate Coordinate_
        {
            get
            {
                if (this.coordinate_ != null)
                {
                    return this.coordinate_; 
                }
                else if (this.coordinateIDRef_ != null)
                {
                    coordinate_ = IDManager.getID(coordinateIDRef_) as PricingDataPointCoordinate;
                    return this.coordinate_; 
                }
                else
                {
                      return this.coordinate_; 
                }
            }
            set
            {
                if (this.coordinate_ != value)
                {
                    this.coordinate_ = value;
                }
            }
        }
        #endregion
        
        public string coordinateIDRef_ { get; set; }
        #region CoordinateReference_
        private PricingDataPointCoordinateReference coordinateReference_;
        public PricingDataPointCoordinateReference CoordinateReference_
        {
            get
            {
                if (this.coordinateReference_ != null)
                {
                    return this.coordinateReference_; 
                }
                else if (this.coordinateReferenceIDRef_ != null)
                {
                    coordinateReference_ = IDManager.getID(coordinateReferenceIDRef_) as PricingDataPointCoordinateReference;
                    return this.coordinateReference_; 
                }
                else
                {
                      return this.coordinateReference_; 
                }
            }
            set
            {
                if (this.coordinateReference_ != value)
                {
                    this.coordinateReference_ = value;
                }
            }
        }
        #endregion
        
        public string coordinateReferenceIDRef_ { get; set; }
        #region UnderlyingAsset_
        private Asset underlyingAsset_;
        public Asset UnderlyingAsset_
        {
            get
            {
                if (this.underlyingAsset_ != null)
                {
                    return this.underlyingAsset_; 
                }
                else if (this.underlyingAssetIDRef_ != null)
                {
                    underlyingAsset_ = IDManager.getID(underlyingAssetIDRef_) as Asset;
                    return this.underlyingAsset_; 
                }
                else
                {
                      return this.underlyingAsset_; 
                }
            }
            set
            {
                if (this.underlyingAsset_ != value)
                {
                    this.underlyingAsset_ = value;
                }
            }
        }
        #endregion
        
        public string underlyingAssetIDRef_ { get; set; }
        #region Basket_
        private Basket basket_;
        public Basket Basket_
        {
            get
            {
                if (this.basket_ != null)
                {
                    return this.basket_; 
                }
                else if (this.basketIDRef_ != null)
                {
                    basket_ = IDManager.getID(basketIDRef_) as Basket;
                    return this.basket_; 
                }
                else
                {
                      return this.basket_; 
                }
            }
            set
            {
                if (this.basket_ != value)
                {
                    this.basket_ = value;
                }
            }
        }
        #endregion
        
        public string basketIDRef_ { get; set; }     // substitude
        #region Bond_
        private Bond bond_;
        public Bond Bond_
        {
            get
            {
                if (this.bond_ != null)
                {
                    return this.bond_; 
                }
                else if (this.bondIDRef_ != null)
                {
                    bond_ = IDManager.getID(bondIDRef_) as Bond;
                    return this.bond_; 
                }
                else
                {
                      return this.bond_; 
                }
            }
            set
            {
                if (this.bond_ != value)
                {
                    this.bond_ = value;
                }
            }
        }
        #endregion
        
        public string bondIDRef_ { get; set; }     // substitude
        #region Cash_
        private Cash cash_;
        public Cash Cash_
        {
            get
            {
                if (this.cash_ != null)
                {
                    return this.cash_; 
                }
                else if (this.cashIDRef_ != null)
                {
                    cash_ = IDManager.getID(cashIDRef_) as Cash;
                    return this.cash_; 
                }
                else
                {
                      return this.cash_; 
                }
            }
            set
            {
                if (this.cash_ != value)
                {
                    this.cash_ = value;
                }
            }
        }
        #endregion
        
        public string cashIDRef_ { get; set; }     // substitude
        #region Commodity_
        private Commodity commodity_;
        public Commodity Commodity_
        {
            get
            {
                if (this.commodity_ != null)
                {
                    return this.commodity_; 
                }
                else if (this.commodityIDRef_ != null)
                {
                    commodity_ = IDManager.getID(commodityIDRef_) as Commodity;
                    return this.commodity_; 
                }
                else
                {
                      return this.commodity_; 
                }
            }
            set
            {
                if (this.commodity_ != value)
                {
                    this.commodity_ = value;
                }
            }
        }
        #endregion
        
        public string commodityIDRef_ { get; set; }     // substitude
        #region ConvertibleBond_
        private ConvertibleBond convertibleBond_;
        public ConvertibleBond ConvertibleBond_
        {
            get
            {
                if (this.convertibleBond_ != null)
                {
                    return this.convertibleBond_; 
                }
                else if (this.convertibleBondIDRef_ != null)
                {
                    convertibleBond_ = IDManager.getID(convertibleBondIDRef_) as ConvertibleBond;
                    return this.convertibleBond_; 
                }
                else
                {
                      return this.convertibleBond_; 
                }
            }
            set
            {
                if (this.convertibleBond_ != value)
                {
                    this.convertibleBond_ = value;
                }
            }
        }
        #endregion
        
        public string convertibleBondIDRef_ { get; set; }     // substitude
        #region Equity_
        private EquityAsset equity_;
        public EquityAsset Equity_
        {
            get
            {
                if (this.equity_ != null)
                {
                    return this.equity_; 
                }
                else if (this.equityIDRef_ != null)
                {
                    equity_ = IDManager.getID(equityIDRef_) as EquityAsset;
                    return this.equity_; 
                }
                else
                {
                      return this.equity_; 
                }
            }
            set
            {
                if (this.equity_ != value)
                {
                    this.equity_ = value;
                }
            }
        }
        #endregion
        
        public string equityIDRef_ { get; set; }     // substitude
        #region ExchangeTradedFund_
        private ExchangeTradedFund exchangeTradedFund_;
        public ExchangeTradedFund ExchangeTradedFund_
        {
            get
            {
                if (this.exchangeTradedFund_ != null)
                {
                    return this.exchangeTradedFund_; 
                }
                else if (this.exchangeTradedFundIDRef_ != null)
                {
                    exchangeTradedFund_ = IDManager.getID(exchangeTradedFundIDRef_) as ExchangeTradedFund;
                    return this.exchangeTradedFund_; 
                }
                else
                {
                      return this.exchangeTradedFund_; 
                }
            }
            set
            {
                if (this.exchangeTradedFund_ != value)
                {
                    this.exchangeTradedFund_ = value;
                }
            }
        }
        #endregion
        
        public string exchangeTradedFundIDRef_ { get; set; }     // substitude
        #region Future_
        private Future future_;
        public Future Future_
        {
            get
            {
                if (this.future_ != null)
                {
                    return this.future_; 
                }
                else if (this.futureIDRef_ != null)
                {
                    future_ = IDManager.getID(futureIDRef_) as Future;
                    return this.future_; 
                }
                else
                {
                      return this.future_; 
                }
            }
            set
            {
                if (this.future_ != value)
                {
                    this.future_ = value;
                }
            }
        }
        #endregion
        
        public string futureIDRef_ { get; set; }     // substitude
        #region Index_
        private Index index_;
        public Index Index_
        {
            get
            {
                if (this.index_ != null)
                {
                    return this.index_; 
                }
                else if (this.indexIDRef_ != null)
                {
                    index_ = IDManager.getID(indexIDRef_) as Index;
                    return this.index_; 
                }
                else
                {
                      return this.index_; 
                }
            }
            set
            {
                if (this.index_ != value)
                {
                    this.index_ = value;
                }
            }
        }
        #endregion
        
        public string indexIDRef_ { get; set; }     // substitude
        #region Loan_
        private Loan loan_;
        public Loan Loan_
        {
            get
            {
                if (this.loan_ != null)
                {
                    return this.loan_; 
                }
                else if (this.loanIDRef_ != null)
                {
                    loan_ = IDManager.getID(loanIDRef_) as Loan;
                    return this.loan_; 
                }
                else
                {
                      return this.loan_; 
                }
            }
            set
            {
                if (this.loan_ != value)
                {
                    this.loan_ = value;
                }
            }
        }
        #endregion
        
        public string loanIDRef_ { get; set; }     // substitude
        #region Mortgage_
        private Mortgage mortgage_;
        public Mortgage Mortgage_
        {
            get
            {
                if (this.mortgage_ != null)
                {
                    return this.mortgage_; 
                }
                else if (this.mortgageIDRef_ != null)
                {
                    mortgage_ = IDManager.getID(mortgageIDRef_) as Mortgage;
                    return this.mortgage_; 
                }
                else
                {
                      return this.mortgage_; 
                }
            }
            set
            {
                if (this.mortgage_ != value)
                {
                    this.mortgage_ = value;
                }
            }
        }
        #endregion
        
        public string mortgageIDRef_ { get; set; }     // substitude
        #region MutualFund_
        private MutualFund mutualFund_;
        public MutualFund MutualFund_
        {
            get
            {
                if (this.mutualFund_ != null)
                {
                    return this.mutualFund_; 
                }
                else if (this.mutualFundIDRef_ != null)
                {
                    mutualFund_ = IDManager.getID(mutualFundIDRef_) as MutualFund;
                    return this.mutualFund_; 
                }
                else
                {
                      return this.mutualFund_; 
                }
            }
            set
            {
                if (this.mutualFund_ != value)
                {
                    this.mutualFund_ = value;
                }
            }
        }
        #endregion
        
        public string mutualFundIDRef_ { get; set; }     // substitude
        #region UnderlyingAssetReference_
        private AssetReference underlyingAssetReference_;
        public AssetReference UnderlyingAssetReference_
        {
            get
            {
                if (this.underlyingAssetReference_ != null)
                {
                    return this.underlyingAssetReference_; 
                }
                else if (this.underlyingAssetReferenceIDRef_ != null)
                {
                    underlyingAssetReference_ = IDManager.getID(underlyingAssetReferenceIDRef_) as AssetReference;
                    return this.underlyingAssetReference_; 
                }
                else
                {
                      return this.underlyingAssetReference_; 
                }
            }
            set
            {
                if (this.underlyingAssetReference_ != value)
                {
                    this.underlyingAssetReference_ = value;
                }
            }
        }
        #endregion
        
        public string underlyingAssetReferenceIDRef_ { get; set; }
        #region Value_
        private XsdTypeDecimal value_;
        public XsdTypeDecimal Value_
        {
            get
            {
                if (this.value_ != null)
                {
                    return this.value_; 
                }
                else if (this.valueIDRef_ != null)
                {
                    value_ = IDManager.getID(valueIDRef_) as XsdTypeDecimal;
                    return this.value_; 
                }
                else
                {
                      return this.value_; 
                }
            }
            set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                }
            }
        }
        #endregion
        
        public string valueIDRef_ { get; set; }
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
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        
    
        
    
    }
    
}

