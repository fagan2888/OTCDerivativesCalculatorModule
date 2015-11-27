using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Strategy : Product
    {
        public Strategy(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList strategyComponentIdentifierNodeList = xmlNode.SelectNodes("strategyComponentIdentifier");
            
            if (strategyComponentIdentifierNodeList != null)
            {
                this.strategyComponentIdentifier_ = new List<StrategyComponentIdentification>();
                foreach (XmlNode item in strategyComponentIdentifierNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            strategyComponentIdentifierIDRef_ = item.Attributes["id"].Value;
                            strategyComponentIdentifier_.Add(new StrategyComponentIdentification(item));
                            IDManager.SetID(strategyComponentIdentifierIDRef_, strategyComponentIdentifier_[strategyComponentIdentifier_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            strategyComponentIdentifierIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        strategyComponentIdentifier_.Add(new StrategyComponentIdentification(item));
                        }
                    }
                    else
                    {
                        strategyComponentIdentifier_.Add(new StrategyComponentIdentification(item));
                    }
                }
            }
            
        
            XmlNode premiumProductReferenceNode = xmlNode.SelectSingleNode("premiumProductReference");
            
            if (premiumProductReferenceNode != null)
            {
                if (premiumProductReferenceNode.Attributes["href"] != null || premiumProductReferenceNode.Attributes["id"] != null) 
                {
                    if (premiumProductReferenceNode.Attributes["id"] != null) 
                    {
                        premiumProductReferenceIDRef_ = premiumProductReferenceNode.Attributes["id"].Value;
                        ProductReference ob = new ProductReference(premiumProductReferenceNode);
                        IDManager.SetID(premiumProductReferenceIDRef_, ob);
                    }
                    else if (premiumProductReferenceNode.Attributes["href"] != null)
                    {
                        premiumProductReferenceIDRef_ = premiumProductReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        premiumProductReference_ = new ProductReference(premiumProductReferenceNode);
                    }
                }
                else
                {
                    premiumProductReference_ = new ProductReference(premiumProductReferenceNode);
                }
            }
            
        
            XmlNode productNode = xmlNode.SelectSingleNode("product");
            
            if (productNode != null)
            {
                if (productNode.Attributes["href"] != null || productNode.Attributes["id"] != null) 
                {
                    if (productNode.Attributes["id"] != null) 
                    {
                        productIDRef_ = productNode.Attributes["id"].Value;
                        Product ob = new Product(productNode);
                        IDManager.SetID(productIDRef_, ob);
                    }
                    else if (productNode.Attributes["href"] != null)
                    {
                        productIDRef_ = productNode.Attributes["href"].Value;
                    }
                    else
                    {
                        product_ = new Product(productNode);
                    }
                }
                else
                {
                    product_ = new Product(productNode);
                }
            }
            
        
            XmlNode forwardNode = xmlNode.SelectSingleNode("forward");
            
            if (forwardNode != null)
            {
                if (forwardNode.Attributes["href"] != null || forwardNode.Attributes["id"] != null) 
                {
                    if (forwardNode.Attributes["id"] != null) 
                    {
                        forwardIDRef_ = forwardNode.Attributes["id"].Value;
                        ForwardSale ob = new ForwardSale(forwardNode);
                        IDManager.SetID(forwardIDRef_, ob);
                    }
                    else if (forwardNode.Attributes["href"] != null)
                    {
                        forwardIDRef_ = forwardNode.Attributes["href"].Value;
                    }
                    else
                    {
                        forward_ = new ForwardSale(forwardNode);
                    }
                }
                else
                {
                    forward_ = new ForwardSale(forwardNode);
                }
            }
            
        
            XmlNode bondOptionNode = xmlNode.SelectSingleNode("bondOption");
            
            if (bondOptionNode != null)
            {
                if (bondOptionNode.Attributes["href"] != null || bondOptionNode.Attributes["id"] != null) 
                {
                    if (bondOptionNode.Attributes["id"] != null) 
                    {
                        bondOptionIDRef_ = bondOptionNode.Attributes["id"].Value;
                        BondOption ob = new BondOption(bondOptionNode);
                        IDManager.SetID(bondOptionIDRef_, ob);
                    }
                    else if (bondOptionNode.Attributes["href"] != null)
                    {
                        bondOptionIDRef_ = bondOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        bondOption_ = new BondOption(bondOptionNode);
                    }
                }
                else
                {
                    bondOption_ = new BondOption(bondOptionNode);
                }
            }
            
        
            XmlNode creditDefaultSwapNode = xmlNode.SelectSingleNode("creditDefaultSwap");
            
            if (creditDefaultSwapNode != null)
            {
                if (creditDefaultSwapNode.Attributes["href"] != null || creditDefaultSwapNode.Attributes["id"] != null) 
                {
                    if (creditDefaultSwapNode.Attributes["id"] != null) 
                    {
                        creditDefaultSwapIDRef_ = creditDefaultSwapNode.Attributes["id"].Value;
                        CreditDefaultSwap ob = new CreditDefaultSwap(creditDefaultSwapNode);
                        IDManager.SetID(creditDefaultSwapIDRef_, ob);
                    }
                    else if (creditDefaultSwapNode.Attributes["href"] != null)
                    {
                        creditDefaultSwapIDRef_ = creditDefaultSwapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditDefaultSwap_ = new CreditDefaultSwap(creditDefaultSwapNode);
                    }
                }
                else
                {
                    creditDefaultSwap_ = new CreditDefaultSwap(creditDefaultSwapNode);
                }
            }
            
        
            XmlNode creditDefaultSwapOptionNode = xmlNode.SelectSingleNode("creditDefaultSwapOption");
            
            if (creditDefaultSwapOptionNode != null)
            {
                if (creditDefaultSwapOptionNode.Attributes["href"] != null || creditDefaultSwapOptionNode.Attributes["id"] != null) 
                {
                    if (creditDefaultSwapOptionNode.Attributes["id"] != null) 
                    {
                        creditDefaultSwapOptionIDRef_ = creditDefaultSwapOptionNode.Attributes["id"].Value;
                        CreditDefaultSwapOption ob = new CreditDefaultSwapOption(creditDefaultSwapOptionNode);
                        IDManager.SetID(creditDefaultSwapOptionIDRef_, ob);
                    }
                    else if (creditDefaultSwapOptionNode.Attributes["href"] != null)
                    {
                        creditDefaultSwapOptionIDRef_ = creditDefaultSwapOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditDefaultSwapOption_ = new CreditDefaultSwapOption(creditDefaultSwapOptionNode);
                    }
                }
                else
                {
                    creditDefaultSwapOption_ = new CreditDefaultSwapOption(creditDefaultSwapOptionNode);
                }
            }
            
        
            XmlNode commodityForwardNode = xmlNode.SelectSingleNode("commodityForward");
            
            if (commodityForwardNode != null)
            {
                if (commodityForwardNode.Attributes["href"] != null || commodityForwardNode.Attributes["id"] != null) 
                {
                    if (commodityForwardNode.Attributes["id"] != null) 
                    {
                        commodityForwardIDRef_ = commodityForwardNode.Attributes["id"].Value;
                        CommodityForward ob = new CommodityForward(commodityForwardNode);
                        IDManager.SetID(commodityForwardIDRef_, ob);
                    }
                    else if (commodityForwardNode.Attributes["href"] != null)
                    {
                        commodityForwardIDRef_ = commodityForwardNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commodityForward_ = new CommodityForward(commodityForwardNode);
                    }
                }
                else
                {
                    commodityForward_ = new CommodityForward(commodityForwardNode);
                }
            }
            
        
            XmlNode commodityOptionNode = xmlNode.SelectSingleNode("commodityOption");
            
            if (commodityOptionNode != null)
            {
                if (commodityOptionNode.Attributes["href"] != null || commodityOptionNode.Attributes["id"] != null) 
                {
                    if (commodityOptionNode.Attributes["id"] != null) 
                    {
                        commodityOptionIDRef_ = commodityOptionNode.Attributes["id"].Value;
                        CommodityOption ob = new CommodityOption(commodityOptionNode);
                        IDManager.SetID(commodityOptionIDRef_, ob);
                    }
                    else if (commodityOptionNode.Attributes["href"] != null)
                    {
                        commodityOptionIDRef_ = commodityOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commodityOption_ = new CommodityOption(commodityOptionNode);
                    }
                }
                else
                {
                    commodityOption_ = new CommodityOption(commodityOptionNode);
                }
            }
            
        
            XmlNode commoditySwapNode = xmlNode.SelectSingleNode("commoditySwap");
            
            if (commoditySwapNode != null)
            {
                if (commoditySwapNode.Attributes["href"] != null || commoditySwapNode.Attributes["id"] != null) 
                {
                    if (commoditySwapNode.Attributes["id"] != null) 
                    {
                        commoditySwapIDRef_ = commoditySwapNode.Attributes["id"].Value;
                        CommoditySwap ob = new CommoditySwap(commoditySwapNode);
                        IDManager.SetID(commoditySwapIDRef_, ob);
                    }
                    else if (commoditySwapNode.Attributes["href"] != null)
                    {
                        commoditySwapIDRef_ = commoditySwapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commoditySwap_ = new CommoditySwap(commoditySwapNode);
                    }
                }
                else
                {
                    commoditySwap_ = new CommoditySwap(commoditySwapNode);
                }
            }
            
        
            XmlNode commoditySwaptionNode = xmlNode.SelectSingleNode("commoditySwaption");
            
            if (commoditySwaptionNode != null)
            {
                if (commoditySwaptionNode.Attributes["href"] != null || commoditySwaptionNode.Attributes["id"] != null) 
                {
                    if (commoditySwaptionNode.Attributes["id"] != null) 
                    {
                        commoditySwaptionIDRef_ = commoditySwaptionNode.Attributes["id"].Value;
                        CommoditySwaption ob = new CommoditySwaption(commoditySwaptionNode);
                        IDManager.SetID(commoditySwaptionIDRef_, ob);
                    }
                    else if (commoditySwaptionNode.Attributes["href"] != null)
                    {
                        commoditySwaptionIDRef_ = commoditySwaptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commoditySwaption_ = new CommoditySwaption(commoditySwaptionNode);
                    }
                }
                else
                {
                    commoditySwaption_ = new CommoditySwaption(commoditySwaptionNode);
                }
            }
            
        
            XmlNode correlationSwapNode = xmlNode.SelectSingleNode("correlationSwap");
            
            if (correlationSwapNode != null)
            {
                if (correlationSwapNode.Attributes["href"] != null || correlationSwapNode.Attributes["id"] != null) 
                {
                    if (correlationSwapNode.Attributes["id"] != null) 
                    {
                        correlationSwapIDRef_ = correlationSwapNode.Attributes["id"].Value;
                        CorrelationSwap ob = new CorrelationSwap(correlationSwapNode);
                        IDManager.SetID(correlationSwapIDRef_, ob);
                    }
                    else if (correlationSwapNode.Attributes["href"] != null)
                    {
                        correlationSwapIDRef_ = correlationSwapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        correlationSwap_ = new CorrelationSwap(correlationSwapNode);
                    }
                }
                else
                {
                    correlationSwap_ = new CorrelationSwap(correlationSwapNode);
                }
            }
            
        
            XmlNode dividendSwapOptionTransactionSupplementNode = xmlNode.SelectSingleNode("dividendSwapOptionTransactionSupplement");
            
            if (dividendSwapOptionTransactionSupplementNode != null)
            {
                if (dividendSwapOptionTransactionSupplementNode.Attributes["href"] != null || dividendSwapOptionTransactionSupplementNode.Attributes["id"] != null) 
                {
                    if (dividendSwapOptionTransactionSupplementNode.Attributes["id"] != null) 
                    {
                        dividendSwapOptionTransactionSupplementIDRef_ = dividendSwapOptionTransactionSupplementNode.Attributes["id"].Value;
                        DividendSwapOptionTransactionSupplement ob = new DividendSwapOptionTransactionSupplement(dividendSwapOptionTransactionSupplementNode);
                        IDManager.SetID(dividendSwapOptionTransactionSupplementIDRef_, ob);
                    }
                    else if (dividendSwapOptionTransactionSupplementNode.Attributes["href"] != null)
                    {
                        dividendSwapOptionTransactionSupplementIDRef_ = dividendSwapOptionTransactionSupplementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendSwapOptionTransactionSupplement_ = new DividendSwapOptionTransactionSupplement(dividendSwapOptionTransactionSupplementNode);
                    }
                }
                else
                {
                    dividendSwapOptionTransactionSupplement_ = new DividendSwapOptionTransactionSupplement(dividendSwapOptionTransactionSupplementNode);
                }
            }
            
        
            XmlNode dividendSwapTransactionSupplementNode = xmlNode.SelectSingleNode("dividendSwapTransactionSupplement");
            
            if (dividendSwapTransactionSupplementNode != null)
            {
                if (dividendSwapTransactionSupplementNode.Attributes["href"] != null || dividendSwapTransactionSupplementNode.Attributes["id"] != null) 
                {
                    if (dividendSwapTransactionSupplementNode.Attributes["id"] != null) 
                    {
                        dividendSwapTransactionSupplementIDRef_ = dividendSwapTransactionSupplementNode.Attributes["id"].Value;
                        DividendSwapTransactionSupplement ob = new DividendSwapTransactionSupplement(dividendSwapTransactionSupplementNode);
                        IDManager.SetID(dividendSwapTransactionSupplementIDRef_, ob);
                    }
                    else if (dividendSwapTransactionSupplementNode.Attributes["href"] != null)
                    {
                        dividendSwapTransactionSupplementIDRef_ = dividendSwapTransactionSupplementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendSwapTransactionSupplement_ = new DividendSwapTransactionSupplement(dividendSwapTransactionSupplementNode);
                    }
                }
                else
                {
                    dividendSwapTransactionSupplement_ = new DividendSwapTransactionSupplement(dividendSwapTransactionSupplementNode);
                }
            }
            
        
            XmlNode instrumentTradeDetailsNode = xmlNode.SelectSingleNode("instrumentTradeDetails");
            
            if (instrumentTradeDetailsNode != null)
            {
                if (instrumentTradeDetailsNode.Attributes["href"] != null || instrumentTradeDetailsNode.Attributes["id"] != null) 
                {
                    if (instrumentTradeDetailsNode.Attributes["id"] != null) 
                    {
                        instrumentTradeDetailsIDRef_ = instrumentTradeDetailsNode.Attributes["id"].Value;
                        InstrumentTradeDetails ob = new InstrumentTradeDetails(instrumentTradeDetailsNode);
                        IDManager.SetID(instrumentTradeDetailsIDRef_, ob);
                    }
                    else if (instrumentTradeDetailsNode.Attributes["href"] != null)
                    {
                        instrumentTradeDetailsIDRef_ = instrumentTradeDetailsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        instrumentTradeDetails_ = new InstrumentTradeDetails(instrumentTradeDetailsNode);
                    }
                }
                else
                {
                    instrumentTradeDetails_ = new InstrumentTradeDetails(instrumentTradeDetailsNode);
                }
            }
            
        
            XmlNode strategyNode = xmlNode.SelectSingleNode("strategy");
            
            if (strategyNode != null)
            {
                if (strategyNode.Attributes["href"] != null || strategyNode.Attributes["id"] != null) 
                {
                    if (strategyNode.Attributes["id"] != null) 
                    {
                        strategyIDRef_ = strategyNode.Attributes["id"].Value;
                        Strategy ob = new Strategy(strategyNode);
                        IDManager.SetID(strategyIDRef_, ob);
                    }
                    else if (strategyNode.Attributes["href"] != null)
                    {
                        strategyIDRef_ = strategyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strategy_ = new Strategy(strategyNode);
                    }
                }
                else
                {
                    strategy_ = new Strategy(strategyNode);
                }
            }
            
        
            XmlNode returnSwapNode = xmlNode.SelectSingleNode("returnSwap");
            
            if (returnSwapNode != null)
            {
                if (returnSwapNode.Attributes["href"] != null || returnSwapNode.Attributes["id"] != null) 
                {
                    if (returnSwapNode.Attributes["id"] != null) 
                    {
                        returnSwapIDRef_ = returnSwapNode.Attributes["id"].Value;
                        ReturnSwap ob = new ReturnSwap(returnSwapNode);
                        IDManager.SetID(returnSwapIDRef_, ob);
                    }
                    else if (returnSwapNode.Attributes["href"] != null)
                    {
                        returnSwapIDRef_ = returnSwapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        returnSwap_ = new ReturnSwap(returnSwapNode);
                    }
                }
                else
                {
                    returnSwap_ = new ReturnSwap(returnSwapNode);
                }
            }
            
        
            XmlNode brokerEquityOptionNode = xmlNode.SelectSingleNode("brokerEquityOption");
            
            if (brokerEquityOptionNode != null)
            {
                if (brokerEquityOptionNode.Attributes["href"] != null || brokerEquityOptionNode.Attributes["id"] != null) 
                {
                    if (brokerEquityOptionNode.Attributes["id"] != null) 
                    {
                        brokerEquityOptionIDRef_ = brokerEquityOptionNode.Attributes["id"].Value;
                        BrokerEquityOption ob = new BrokerEquityOption(brokerEquityOptionNode);
                        IDManager.SetID(brokerEquityOptionIDRef_, ob);
                    }
                    else if (brokerEquityOptionNode.Attributes["href"] != null)
                    {
                        brokerEquityOptionIDRef_ = brokerEquityOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        brokerEquityOption_ = new BrokerEquityOption(brokerEquityOptionNode);
                    }
                }
                else
                {
                    brokerEquityOption_ = new BrokerEquityOption(brokerEquityOptionNode);
                }
            }
            
        
            XmlNode equityForwardNode = xmlNode.SelectSingleNode("equityForward");
            
            if (equityForwardNode != null)
            {
                if (equityForwardNode.Attributes["href"] != null || equityForwardNode.Attributes["id"] != null) 
                {
                    if (equityForwardNode.Attributes["id"] != null) 
                    {
                        equityForwardIDRef_ = equityForwardNode.Attributes["id"].Value;
                        EquityForward ob = new EquityForward(equityForwardNode);
                        IDManager.SetID(equityForwardIDRef_, ob);
                    }
                    else if (equityForwardNode.Attributes["href"] != null)
                    {
                        equityForwardIDRef_ = equityForwardNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equityForward_ = new EquityForward(equityForwardNode);
                    }
                }
                else
                {
                    equityForward_ = new EquityForward(equityForwardNode);
                }
            }
            
        
            XmlNode equityOptionNode = xmlNode.SelectSingleNode("equityOption");
            
            if (equityOptionNode != null)
            {
                if (equityOptionNode.Attributes["href"] != null || equityOptionNode.Attributes["id"] != null) 
                {
                    if (equityOptionNode.Attributes["id"] != null) 
                    {
                        equityOptionIDRef_ = equityOptionNode.Attributes["id"].Value;
                        EquityOption ob = new EquityOption(equityOptionNode);
                        IDManager.SetID(equityOptionIDRef_, ob);
                    }
                    else if (equityOptionNode.Attributes["href"] != null)
                    {
                        equityOptionIDRef_ = equityOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equityOption_ = new EquityOption(equityOptionNode);
                    }
                }
                else
                {
                    equityOption_ = new EquityOption(equityOptionNode);
                }
            }
            
        
            XmlNode equityOptionTransactionSupplementNode = xmlNode.SelectSingleNode("equityOptionTransactionSupplement");
            
            if (equityOptionTransactionSupplementNode != null)
            {
                if (equityOptionTransactionSupplementNode.Attributes["href"] != null || equityOptionTransactionSupplementNode.Attributes["id"] != null) 
                {
                    if (equityOptionTransactionSupplementNode.Attributes["id"] != null) 
                    {
                        equityOptionTransactionSupplementIDRef_ = equityOptionTransactionSupplementNode.Attributes["id"].Value;
                        EquityOptionTransactionSupplement ob = new EquityOptionTransactionSupplement(equityOptionTransactionSupplementNode);
                        IDManager.SetID(equityOptionTransactionSupplementIDRef_, ob);
                    }
                    else if (equityOptionTransactionSupplementNode.Attributes["href"] != null)
                    {
                        equityOptionTransactionSupplementIDRef_ = equityOptionTransactionSupplementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equityOptionTransactionSupplement_ = new EquityOptionTransactionSupplement(equityOptionTransactionSupplementNode);
                    }
                }
                else
                {
                    equityOptionTransactionSupplement_ = new EquityOptionTransactionSupplement(equityOptionTransactionSupplementNode);
                }
            }
            
        
            XmlNode fxSingleLegNode = xmlNode.SelectSingleNode("fxSingleLeg");
            
            if (fxSingleLegNode != null)
            {
                if (fxSingleLegNode.Attributes["href"] != null || fxSingleLegNode.Attributes["id"] != null) 
                {
                    if (fxSingleLegNode.Attributes["id"] != null) 
                    {
                        fxSingleLegIDRef_ = fxSingleLegNode.Attributes["id"].Value;
                        FxSingleLeg ob = new FxSingleLeg(fxSingleLegNode);
                        IDManager.SetID(fxSingleLegIDRef_, ob);
                    }
                    else if (fxSingleLegNode.Attributes["href"] != null)
                    {
                        fxSingleLegIDRef_ = fxSingleLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxSingleLeg_ = new FxSingleLeg(fxSingleLegNode);
                    }
                }
                else
                {
                    fxSingleLeg_ = new FxSingleLeg(fxSingleLegNode);
                }
            }
            
        
            XmlNode fxSwapNode = xmlNode.SelectSingleNode("fxSwap");
            
            if (fxSwapNode != null)
            {
                if (fxSwapNode.Attributes["href"] != null || fxSwapNode.Attributes["id"] != null) 
                {
                    if (fxSwapNode.Attributes["id"] != null) 
                    {
                        fxSwapIDRef_ = fxSwapNode.Attributes["id"].Value;
                        FxSwap ob = new FxSwap(fxSwapNode);
                        IDManager.SetID(fxSwapIDRef_, ob);
                    }
                    else if (fxSwapNode.Attributes["href"] != null)
                    {
                        fxSwapIDRef_ = fxSwapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxSwap_ = new FxSwap(fxSwapNode);
                    }
                }
                else
                {
                    fxSwap_ = new FxSwap(fxSwapNode);
                }
            }
            
        
            XmlNode fxOptionNode = xmlNode.SelectSingleNode("fxOption");
            
            if (fxOptionNode != null)
            {
                if (fxOptionNode.Attributes["href"] != null || fxOptionNode.Attributes["id"] != null) 
                {
                    if (fxOptionNode.Attributes["id"] != null) 
                    {
                        fxOptionIDRef_ = fxOptionNode.Attributes["id"].Value;
                        FxOption ob = new FxOption(fxOptionNode);
                        IDManager.SetID(fxOptionIDRef_, ob);
                    }
                    else if (fxOptionNode.Attributes["href"] != null)
                    {
                        fxOptionIDRef_ = fxOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxOption_ = new FxOption(fxOptionNode);
                    }
                }
                else
                {
                    fxOption_ = new FxOption(fxOptionNode);
                }
            }
            
        
            XmlNode fxDigitalOptionNode = xmlNode.SelectSingleNode("fxDigitalOption");
            
            if (fxDigitalOptionNode != null)
            {
                if (fxDigitalOptionNode.Attributes["href"] != null || fxDigitalOptionNode.Attributes["id"] != null) 
                {
                    if (fxDigitalOptionNode.Attributes["id"] != null) 
                    {
                        fxDigitalOptionIDRef_ = fxDigitalOptionNode.Attributes["id"].Value;
                        FxDigitalOption ob = new FxDigitalOption(fxDigitalOptionNode);
                        IDManager.SetID(fxDigitalOptionIDRef_, ob);
                    }
                    else if (fxDigitalOptionNode.Attributes["href"] != null)
                    {
                        fxDigitalOptionIDRef_ = fxDigitalOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxDigitalOption_ = new FxDigitalOption(fxDigitalOptionNode);
                    }
                }
                else
                {
                    fxDigitalOption_ = new FxDigitalOption(fxDigitalOptionNode);
                }
            }
            
        
            XmlNode termDepositNode = xmlNode.SelectSingleNode("termDeposit");
            
            if (termDepositNode != null)
            {
                if (termDepositNode.Attributes["href"] != null || termDepositNode.Attributes["id"] != null) 
                {
                    if (termDepositNode.Attributes["id"] != null) 
                    {
                        termDepositIDRef_ = termDepositNode.Attributes["id"].Value;
                        TermDeposit ob = new TermDeposit(termDepositNode);
                        IDManager.SetID(termDepositIDRef_, ob);
                    }
                    else if (termDepositNode.Attributes["href"] != null)
                    {
                        termDepositIDRef_ = termDepositNode.Attributes["href"].Value;
                    }
                    else
                    {
                        termDeposit_ = new TermDeposit(termDepositNode);
                    }
                }
                else
                {
                    termDeposit_ = new TermDeposit(termDepositNode);
                }
            }
            
        
            XmlNode genericProductNode = xmlNode.SelectSingleNode("genericProduct");
            
            if (genericProductNode != null)
            {
                if (genericProductNode.Attributes["href"] != null || genericProductNode.Attributes["id"] != null) 
                {
                    if (genericProductNode.Attributes["id"] != null) 
                    {
                        genericProductIDRef_ = genericProductNode.Attributes["id"].Value;
                        GenericProduct ob = new GenericProduct(genericProductNode);
                        IDManager.SetID(genericProductIDRef_, ob);
                    }
                    else if (genericProductNode.Attributes["href"] != null)
                    {
                        genericProductIDRef_ = genericProductNode.Attributes["href"].Value;
                    }
                    else
                    {
                        genericProduct_ = new GenericProduct(genericProductNode);
                    }
                }
                else
                {
                    genericProduct_ = new GenericProduct(genericProductNode);
                }
            }
            
        
            XmlNode nonSchemaProductNode = xmlNode.SelectSingleNode("nonSchemaProduct");
            
            if (nonSchemaProductNode != null)
            {
                if (nonSchemaProductNode.Attributes["href"] != null || nonSchemaProductNode.Attributes["id"] != null) 
                {
                    if (nonSchemaProductNode.Attributes["id"] != null) 
                    {
                        nonSchemaProductIDRef_ = nonSchemaProductNode.Attributes["id"].Value;
                        GenericProduct ob = new GenericProduct(nonSchemaProductNode);
                        IDManager.SetID(nonSchemaProductIDRef_, ob);
                    }
                    else if (nonSchemaProductNode.Attributes["href"] != null)
                    {
                        nonSchemaProductIDRef_ = nonSchemaProductNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nonSchemaProduct_ = new GenericProduct(nonSchemaProductNode);
                    }
                }
                else
                {
                    nonSchemaProduct_ = new GenericProduct(nonSchemaProductNode);
                }
            }
            
        
            XmlNode bulletPaymentNode = xmlNode.SelectSingleNode("bulletPayment");
            
            if (bulletPaymentNode != null)
            {
                if (bulletPaymentNode.Attributes["href"] != null || bulletPaymentNode.Attributes["id"] != null) 
                {
                    if (bulletPaymentNode.Attributes["id"] != null) 
                    {
                        bulletPaymentIDRef_ = bulletPaymentNode.Attributes["id"].Value;
                        BulletPayment ob = new BulletPayment(bulletPaymentNode);
                        IDManager.SetID(bulletPaymentIDRef_, ob);
                    }
                    else if (bulletPaymentNode.Attributes["href"] != null)
                    {
                        bulletPaymentIDRef_ = bulletPaymentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        bulletPayment_ = new BulletPayment(bulletPaymentNode);
                    }
                }
                else
                {
                    bulletPayment_ = new BulletPayment(bulletPaymentNode);
                }
            }
            
        
            XmlNode capFloorNode = xmlNode.SelectSingleNode("capFloor");
            
            if (capFloorNode != null)
            {
                if (capFloorNode.Attributes["href"] != null || capFloorNode.Attributes["id"] != null) 
                {
                    if (capFloorNode.Attributes["id"] != null) 
                    {
                        capFloorIDRef_ = capFloorNode.Attributes["id"].Value;
                        CapFloor ob = new CapFloor(capFloorNode);
                        IDManager.SetID(capFloorIDRef_, ob);
                    }
                    else if (capFloorNode.Attributes["href"] != null)
                    {
                        capFloorIDRef_ = capFloorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        capFloor_ = new CapFloor(capFloorNode);
                    }
                }
                else
                {
                    capFloor_ = new CapFloor(capFloorNode);
                }
            }
            
        
            XmlNode fraNode = xmlNode.SelectSingleNode("fra");
            
            if (fraNode != null)
            {
                if (fraNode.Attributes["href"] != null || fraNode.Attributes["id"] != null) 
                {
                    if (fraNode.Attributes["id"] != null) 
                    {
                        fraIDRef_ = fraNode.Attributes["id"].Value;
                        Fra ob = new Fra(fraNode);
                        IDManager.SetID(fraIDRef_, ob);
                    }
                    else if (fraNode.Attributes["href"] != null)
                    {
                        fraIDRef_ = fraNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fra_ = new Fra(fraNode);
                    }
                }
                else
                {
                    fra_ = new Fra(fraNode);
                }
            }
            
        
            XmlNode swapNode = xmlNode.SelectSingleNode("swap");
            
            if (swapNode != null)
            {
                if (swapNode.Attributes["href"] != null || swapNode.Attributes["id"] != null) 
                {
                    if (swapNode.Attributes["id"] != null) 
                    {
                        swapIDRef_ = swapNode.Attributes["id"].Value;
                        Swap ob = new Swap(swapNode);
                        IDManager.SetID(swapIDRef_, ob);
                    }
                    else if (swapNode.Attributes["href"] != null)
                    {
                        swapIDRef_ = swapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        swap_ = new Swap(swapNode);
                    }
                }
                else
                {
                    swap_ = new Swap(swapNode);
                }
            }
            
        
            XmlNode swaptionNode = xmlNode.SelectSingleNode("swaption");
            
            if (swaptionNode != null)
            {
                if (swaptionNode.Attributes["href"] != null || swaptionNode.Attributes["id"] != null) 
                {
                    if (swaptionNode.Attributes["id"] != null) 
                    {
                        swaptionIDRef_ = swaptionNode.Attributes["id"].Value;
                        Swaption ob = new Swaption(swaptionNode);
                        IDManager.SetID(swaptionIDRef_, ob);
                    }
                    else if (swaptionNode.Attributes["href"] != null)
                    {
                        swaptionIDRef_ = swaptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        swaption_ = new Swaption(swaptionNode);
                    }
                }
                else
                {
                    swaption_ = new Swaption(swaptionNode);
                }
            }
            
        
            XmlNode equitySwapTransactionSupplementNode = xmlNode.SelectSingleNode("equitySwapTransactionSupplement");
            
            if (equitySwapTransactionSupplementNode != null)
            {
                if (equitySwapTransactionSupplementNode.Attributes["href"] != null || equitySwapTransactionSupplementNode.Attributes["id"] != null) 
                {
                    if (equitySwapTransactionSupplementNode.Attributes["id"] != null) 
                    {
                        equitySwapTransactionSupplementIDRef_ = equitySwapTransactionSupplementNode.Attributes["id"].Value;
                        EquitySwapTransactionSupplement ob = new EquitySwapTransactionSupplement(equitySwapTransactionSupplementNode);
                        IDManager.SetID(equitySwapTransactionSupplementIDRef_, ob);
                    }
                    else if (equitySwapTransactionSupplementNode.Attributes["href"] != null)
                    {
                        equitySwapTransactionSupplementIDRef_ = equitySwapTransactionSupplementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equitySwapTransactionSupplement_ = new EquitySwapTransactionSupplement(equitySwapTransactionSupplementNode);
                    }
                }
                else
                {
                    equitySwapTransactionSupplement_ = new EquitySwapTransactionSupplement(equitySwapTransactionSupplementNode);
                }
            }
            
        
            XmlNode standardProductNode = xmlNode.SelectSingleNode("standardProduct");
            
            if (standardProductNode != null)
            {
                if (standardProductNode.Attributes["href"] != null || standardProductNode.Attributes["id"] != null) 
                {
                    if (standardProductNode.Attributes["id"] != null) 
                    {
                        standardProductIDRef_ = standardProductNode.Attributes["id"].Value;
                        StandardProduct ob = new StandardProduct(standardProductNode);
                        IDManager.SetID(standardProductIDRef_, ob);
                    }
                    else if (standardProductNode.Attributes["href"] != null)
                    {
                        standardProductIDRef_ = standardProductNode.Attributes["href"].Value;
                    }
                    else
                    {
                        standardProduct_ = new StandardProduct(standardProductNode);
                    }
                }
                else
                {
                    standardProduct_ = new StandardProduct(standardProductNode);
                }
            }
            
        
            XmlNode varianceOptionTransactionSupplementNode = xmlNode.SelectSingleNode("varianceOptionTransactionSupplement");
            
            if (varianceOptionTransactionSupplementNode != null)
            {
                if (varianceOptionTransactionSupplementNode.Attributes["href"] != null || varianceOptionTransactionSupplementNode.Attributes["id"] != null) 
                {
                    if (varianceOptionTransactionSupplementNode.Attributes["id"] != null) 
                    {
                        varianceOptionTransactionSupplementIDRef_ = varianceOptionTransactionSupplementNode.Attributes["id"].Value;
                        VarianceOptionTransactionSupplement ob = new VarianceOptionTransactionSupplement(varianceOptionTransactionSupplementNode);
                        IDManager.SetID(varianceOptionTransactionSupplementIDRef_, ob);
                    }
                    else if (varianceOptionTransactionSupplementNode.Attributes["href"] != null)
                    {
                        varianceOptionTransactionSupplementIDRef_ = varianceOptionTransactionSupplementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        varianceOptionTransactionSupplement_ = new VarianceOptionTransactionSupplement(varianceOptionTransactionSupplementNode);
                    }
                }
                else
                {
                    varianceOptionTransactionSupplement_ = new VarianceOptionTransactionSupplement(varianceOptionTransactionSupplementNode);
                }
            }
            
        
            XmlNode varianceSwapNode = xmlNode.SelectSingleNode("varianceSwap");
            
            if (varianceSwapNode != null)
            {
                if (varianceSwapNode.Attributes["href"] != null || varianceSwapNode.Attributes["id"] != null) 
                {
                    if (varianceSwapNode.Attributes["id"] != null) 
                    {
                        varianceSwapIDRef_ = varianceSwapNode.Attributes["id"].Value;
                        VarianceSwap ob = new VarianceSwap(varianceSwapNode);
                        IDManager.SetID(varianceSwapIDRef_, ob);
                    }
                    else if (varianceSwapNode.Attributes["href"] != null)
                    {
                        varianceSwapIDRef_ = varianceSwapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        varianceSwap_ = new VarianceSwap(varianceSwapNode);
                    }
                }
                else
                {
                    varianceSwap_ = new VarianceSwap(varianceSwapNode);
                }
            }
            
        
            XmlNode varianceSwapTransactionSupplementNode = xmlNode.SelectSingleNode("varianceSwapTransactionSupplement");
            
            if (varianceSwapTransactionSupplementNode != null)
            {
                if (varianceSwapTransactionSupplementNode.Attributes["href"] != null || varianceSwapTransactionSupplementNode.Attributes["id"] != null) 
                {
                    if (varianceSwapTransactionSupplementNode.Attributes["id"] != null) 
                    {
                        varianceSwapTransactionSupplementIDRef_ = varianceSwapTransactionSupplementNode.Attributes["id"].Value;
                        VarianceSwapTransactionSupplement ob = new VarianceSwapTransactionSupplement(varianceSwapTransactionSupplementNode);
                        IDManager.SetID(varianceSwapTransactionSupplementIDRef_, ob);
                    }
                    else if (varianceSwapTransactionSupplementNode.Attributes["href"] != null)
                    {
                        varianceSwapTransactionSupplementIDRef_ = varianceSwapTransactionSupplementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        varianceSwapTransactionSupplement_ = new VarianceSwapTransactionSupplement(varianceSwapTransactionSupplementNode);
                    }
                }
                else
                {
                    varianceSwapTransactionSupplement_ = new VarianceSwapTransactionSupplement(varianceSwapTransactionSupplementNode);
                }
            }
            
        
        }
        
    
        #region StrategyComponentIdentifier_
        private List<StrategyComponentIdentification> strategyComponentIdentifier_;
        public List<StrategyComponentIdentification> StrategyComponentIdentifier_
        {
            get
            {
                if (this.strategyComponentIdentifier_ != null)
                {
                    return this.strategyComponentIdentifier_; 
                }
                else if (this.strategyComponentIdentifierIDRef_ != null)
                {
                    return this.strategyComponentIdentifier_; 
                }
                else
                {
                      return this.strategyComponentIdentifier_; 
                }
            }
            set
            {
                if (this.strategyComponentIdentifier_ != value)
                {
                    this.strategyComponentIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string strategyComponentIdentifierIDRef_ { get; set; }
        #region PremiumProductReference_
        private ProductReference premiumProductReference_;
        public ProductReference PremiumProductReference_
        {
            get
            {
                if (this.premiumProductReference_ != null)
                {
                    return this.premiumProductReference_; 
                }
                else if (this.premiumProductReferenceIDRef_ != null)
                {
                    premiumProductReference_ = IDManager.getID(premiumProductReferenceIDRef_) as ProductReference;
                    return this.premiumProductReference_; 
                }
                else
                {
                      return this.premiumProductReference_; 
                }
            }
            set
            {
                if (this.premiumProductReference_ != value)
                {
                    this.premiumProductReference_ = value;
                }
            }
        }
        #endregion
        
        public string premiumProductReferenceIDRef_ { get; set; }
        #region Product_
        private Product product_;
        public Product Product_
        {
            get
            {
                if (this.product_ != null)
                {
                    return this.product_; 
                }
                else if (this.productIDRef_ != null)
                {
                    product_ = IDManager.getID(productIDRef_) as Product;
                    return this.product_; 
                }
                else
                {
                      return this.product_; 
                }
            }
            set
            {
                if (this.product_ != value)
                {
                    this.product_ = value;
                }
            }
        }
        #endregion
        
        public string productIDRef_ { get; set; }
        #region Forward_
        private ForwardSale forward_;
        public ForwardSale Forward_
        {
            get
            {
                if (this.forward_ != null)
                {
                    return this.forward_; 
                }
                else if (this.forwardIDRef_ != null)
                {
                    forward_ = IDManager.getID(forwardIDRef_) as ForwardSale;
                    return this.forward_; 
                }
                else
                {
                      return this.forward_; 
                }
            }
            set
            {
                if (this.forward_ != value)
                {
                    this.forward_ = value;
                }
            }
        }
        #endregion
        
        public string forwardIDRef_ { get; set; }     // substitude
        #region BondOption_
        private BondOption bondOption_;
        public BondOption BondOption_
        {
            get
            {
                if (this.bondOption_ != null)
                {
                    return this.bondOption_; 
                }
                else if (this.bondOptionIDRef_ != null)
                {
                    bondOption_ = IDManager.getID(bondOptionIDRef_) as BondOption;
                    return this.bondOption_; 
                }
                else
                {
                      return this.bondOption_; 
                }
            }
            set
            {
                if (this.bondOption_ != value)
                {
                    this.bondOption_ = value;
                }
            }
        }
        #endregion
        
        public string bondOptionIDRef_ { get; set; }     // substitude
        #region CreditDefaultSwap_
        private CreditDefaultSwap creditDefaultSwap_;
        public CreditDefaultSwap CreditDefaultSwap_
        {
            get
            {
                if (this.creditDefaultSwap_ != null)
                {
                    return this.creditDefaultSwap_; 
                }
                else if (this.creditDefaultSwapIDRef_ != null)
                {
                    creditDefaultSwap_ = IDManager.getID(creditDefaultSwapIDRef_) as CreditDefaultSwap;
                    return this.creditDefaultSwap_; 
                }
                else
                {
                      return this.creditDefaultSwap_; 
                }
            }
            set
            {
                if (this.creditDefaultSwap_ != value)
                {
                    this.creditDefaultSwap_ = value;
                }
            }
        }
        #endregion
        
        public string creditDefaultSwapIDRef_ { get; set; }     // substitude
        #region CreditDefaultSwapOption_
        private CreditDefaultSwapOption creditDefaultSwapOption_;
        public CreditDefaultSwapOption CreditDefaultSwapOption_
        {
            get
            {
                if (this.creditDefaultSwapOption_ != null)
                {
                    return this.creditDefaultSwapOption_; 
                }
                else if (this.creditDefaultSwapOptionIDRef_ != null)
                {
                    creditDefaultSwapOption_ = IDManager.getID(creditDefaultSwapOptionIDRef_) as CreditDefaultSwapOption;
                    return this.creditDefaultSwapOption_; 
                }
                else
                {
                      return this.creditDefaultSwapOption_; 
                }
            }
            set
            {
                if (this.creditDefaultSwapOption_ != value)
                {
                    this.creditDefaultSwapOption_ = value;
                }
            }
        }
        #endregion
        
        public string creditDefaultSwapOptionIDRef_ { get; set; }     // substitude
        #region CommodityForward_
        private CommodityForward commodityForward_;
        public CommodityForward CommodityForward_
        {
            get
            {
                if (this.commodityForward_ != null)
                {
                    return this.commodityForward_; 
                }
                else if (this.commodityForwardIDRef_ != null)
                {
                    commodityForward_ = IDManager.getID(commodityForwardIDRef_) as CommodityForward;
                    return this.commodityForward_; 
                }
                else
                {
                      return this.commodityForward_; 
                }
            }
            set
            {
                if (this.commodityForward_ != value)
                {
                    this.commodityForward_ = value;
                }
            }
        }
        #endregion
        
        public string commodityForwardIDRef_ { get; set; }     // substitude
        #region CommodityOption_
        private CommodityOption commodityOption_;
        public CommodityOption CommodityOption_
        {
            get
            {
                if (this.commodityOption_ != null)
                {
                    return this.commodityOption_; 
                }
                else if (this.commodityOptionIDRef_ != null)
                {
                    commodityOption_ = IDManager.getID(commodityOptionIDRef_) as CommodityOption;
                    return this.commodityOption_; 
                }
                else
                {
                      return this.commodityOption_; 
                }
            }
            set
            {
                if (this.commodityOption_ != value)
                {
                    this.commodityOption_ = value;
                }
            }
        }
        #endregion
        
        public string commodityOptionIDRef_ { get; set; }     // substitude
        #region CommoditySwap_
        private CommoditySwap commoditySwap_;
        public CommoditySwap CommoditySwap_
        {
            get
            {
                if (this.commoditySwap_ != null)
                {
                    return this.commoditySwap_; 
                }
                else if (this.commoditySwapIDRef_ != null)
                {
                    commoditySwap_ = IDManager.getID(commoditySwapIDRef_) as CommoditySwap;
                    return this.commoditySwap_; 
                }
                else
                {
                      return this.commoditySwap_; 
                }
            }
            set
            {
                if (this.commoditySwap_ != value)
                {
                    this.commoditySwap_ = value;
                }
            }
        }
        #endregion
        
        public string commoditySwapIDRef_ { get; set; }     // substitude
        #region CommoditySwaption_
        private CommoditySwaption commoditySwaption_;
        public CommoditySwaption CommoditySwaption_
        {
            get
            {
                if (this.commoditySwaption_ != null)
                {
                    return this.commoditySwaption_; 
                }
                else if (this.commoditySwaptionIDRef_ != null)
                {
                    commoditySwaption_ = IDManager.getID(commoditySwaptionIDRef_) as CommoditySwaption;
                    return this.commoditySwaption_; 
                }
                else
                {
                      return this.commoditySwaption_; 
                }
            }
            set
            {
                if (this.commoditySwaption_ != value)
                {
                    this.commoditySwaption_ = value;
                }
            }
        }
        #endregion
        
        public string commoditySwaptionIDRef_ { get; set; }     // substitude
        #region CorrelationSwap_
        private CorrelationSwap correlationSwap_;
        public CorrelationSwap CorrelationSwap_
        {
            get
            {
                if (this.correlationSwap_ != null)
                {
                    return this.correlationSwap_; 
                }
                else if (this.correlationSwapIDRef_ != null)
                {
                    correlationSwap_ = IDManager.getID(correlationSwapIDRef_) as CorrelationSwap;
                    return this.correlationSwap_; 
                }
                else
                {
                      return this.correlationSwap_; 
                }
            }
            set
            {
                if (this.correlationSwap_ != value)
                {
                    this.correlationSwap_ = value;
                }
            }
        }
        #endregion
        
        public string correlationSwapIDRef_ { get; set; }     // substitude
        #region DividendSwapOptionTransactionSupplement_
        private DividendSwapOptionTransactionSupplement dividendSwapOptionTransactionSupplement_;
        public DividendSwapOptionTransactionSupplement DividendSwapOptionTransactionSupplement_
        {
            get
            {
                if (this.dividendSwapOptionTransactionSupplement_ != null)
                {
                    return this.dividendSwapOptionTransactionSupplement_; 
                }
                else if (this.dividendSwapOptionTransactionSupplementIDRef_ != null)
                {
                    dividendSwapOptionTransactionSupplement_ = IDManager.getID(dividendSwapOptionTransactionSupplementIDRef_) as DividendSwapOptionTransactionSupplement;
                    return this.dividendSwapOptionTransactionSupplement_; 
                }
                else
                {
                      return this.dividendSwapOptionTransactionSupplement_; 
                }
            }
            set
            {
                if (this.dividendSwapOptionTransactionSupplement_ != value)
                {
                    this.dividendSwapOptionTransactionSupplement_ = value;
                }
            }
        }
        #endregion
        
        public string dividendSwapOptionTransactionSupplementIDRef_ { get; set; }     // substitude
        #region DividendSwapTransactionSupplement_
        private DividendSwapTransactionSupplement dividendSwapTransactionSupplement_;
        public DividendSwapTransactionSupplement DividendSwapTransactionSupplement_
        {
            get
            {
                if (this.dividendSwapTransactionSupplement_ != null)
                {
                    return this.dividendSwapTransactionSupplement_; 
                }
                else if (this.dividendSwapTransactionSupplementIDRef_ != null)
                {
                    dividendSwapTransactionSupplement_ = IDManager.getID(dividendSwapTransactionSupplementIDRef_) as DividendSwapTransactionSupplement;
                    return this.dividendSwapTransactionSupplement_; 
                }
                else
                {
                      return this.dividendSwapTransactionSupplement_; 
                }
            }
            set
            {
                if (this.dividendSwapTransactionSupplement_ != value)
                {
                    this.dividendSwapTransactionSupplement_ = value;
                }
            }
        }
        #endregion
        
        public string dividendSwapTransactionSupplementIDRef_ { get; set; }     // substitude
        #region InstrumentTradeDetails_
        private InstrumentTradeDetails instrumentTradeDetails_;
        public InstrumentTradeDetails InstrumentTradeDetails_
        {
            get
            {
                if (this.instrumentTradeDetails_ != null)
                {
                    return this.instrumentTradeDetails_; 
                }
                else if (this.instrumentTradeDetailsIDRef_ != null)
                {
                    instrumentTradeDetails_ = IDManager.getID(instrumentTradeDetailsIDRef_) as InstrumentTradeDetails;
                    return this.instrumentTradeDetails_; 
                }
                else
                {
                      return this.instrumentTradeDetails_; 
                }
            }
            set
            {
                if (this.instrumentTradeDetails_ != value)
                {
                    this.instrumentTradeDetails_ = value;
                }
            }
        }
        #endregion
        
        public string instrumentTradeDetailsIDRef_ { get; set; }     // substitude
        #region Strategy_
        private Strategy strategy_;
        public Strategy Strategy_
        {
            get
            {
                if (this.strategy_ != null)
                {
                    return this.strategy_; 
                }
                else if (this.strategyIDRef_ != null)
                {
                    strategy_ = IDManager.getID(strategyIDRef_) as Strategy;
                    return this.strategy_; 
                }
                else
                {
                      return this.strategy_; 
                }
            }
            set
            {
                if (this.strategy_ != value)
                {
                    this.strategy_ = value;
                }
            }
        }
        #endregion
        
        public string strategyIDRef_ { get; set; }     // substitude
        #region ReturnSwap_
        private ReturnSwap returnSwap_;
        public ReturnSwap ReturnSwap_
        {
            get
            {
                if (this.returnSwap_ != null)
                {
                    return this.returnSwap_; 
                }
                else if (this.returnSwapIDRef_ != null)
                {
                    returnSwap_ = IDManager.getID(returnSwapIDRef_) as ReturnSwap;
                    return this.returnSwap_; 
                }
                else
                {
                      return this.returnSwap_; 
                }
            }
            set
            {
                if (this.returnSwap_ != value)
                {
                    this.returnSwap_ = value;
                }
            }
        }
        #endregion
        
        public string returnSwapIDRef_ { get; set; }     // substitude
        #region BrokerEquityOption_
        private BrokerEquityOption brokerEquityOption_;
        public BrokerEquityOption BrokerEquityOption_
        {
            get
            {
                if (this.brokerEquityOption_ != null)
                {
                    return this.brokerEquityOption_; 
                }
                else if (this.brokerEquityOptionIDRef_ != null)
                {
                    brokerEquityOption_ = IDManager.getID(brokerEquityOptionIDRef_) as BrokerEquityOption;
                    return this.brokerEquityOption_; 
                }
                else
                {
                      return this.brokerEquityOption_; 
                }
            }
            set
            {
                if (this.brokerEquityOption_ != value)
                {
                    this.brokerEquityOption_ = value;
                }
            }
        }
        #endregion
        
        public string brokerEquityOptionIDRef_ { get; set; }     // substitude
        #region EquityForward_
        private EquityForward equityForward_;
        public EquityForward EquityForward_
        {
            get
            {
                if (this.equityForward_ != null)
                {
                    return this.equityForward_; 
                }
                else if (this.equityForwardIDRef_ != null)
                {
                    equityForward_ = IDManager.getID(equityForwardIDRef_) as EquityForward;
                    return this.equityForward_; 
                }
                else
                {
                      return this.equityForward_; 
                }
            }
            set
            {
                if (this.equityForward_ != value)
                {
                    this.equityForward_ = value;
                }
            }
        }
        #endregion
        
        public string equityForwardIDRef_ { get; set; }     // substitude
        #region EquityOption_
        private EquityOption equityOption_;
        public EquityOption EquityOption_
        {
            get
            {
                if (this.equityOption_ != null)
                {
                    return this.equityOption_; 
                }
                else if (this.equityOptionIDRef_ != null)
                {
                    equityOption_ = IDManager.getID(equityOptionIDRef_) as EquityOption;
                    return this.equityOption_; 
                }
                else
                {
                      return this.equityOption_; 
                }
            }
            set
            {
                if (this.equityOption_ != value)
                {
                    this.equityOption_ = value;
                }
            }
        }
        #endregion
        
        public string equityOptionIDRef_ { get; set; }     // substitude
        #region EquityOptionTransactionSupplement_
        private EquityOptionTransactionSupplement equityOptionTransactionSupplement_;
        public EquityOptionTransactionSupplement EquityOptionTransactionSupplement_
        {
            get
            {
                if (this.equityOptionTransactionSupplement_ != null)
                {
                    return this.equityOptionTransactionSupplement_; 
                }
                else if (this.equityOptionTransactionSupplementIDRef_ != null)
                {
                    equityOptionTransactionSupplement_ = IDManager.getID(equityOptionTransactionSupplementIDRef_) as EquityOptionTransactionSupplement;
                    return this.equityOptionTransactionSupplement_; 
                }
                else
                {
                      return this.equityOptionTransactionSupplement_; 
                }
            }
            set
            {
                if (this.equityOptionTransactionSupplement_ != value)
                {
                    this.equityOptionTransactionSupplement_ = value;
                }
            }
        }
        #endregion
        
        public string equityOptionTransactionSupplementIDRef_ { get; set; }     // substitude
        #region FxSingleLeg_
        private FxSingleLeg fxSingleLeg_;
        public FxSingleLeg FxSingleLeg_
        {
            get
            {
                if (this.fxSingleLeg_ != null)
                {
                    return this.fxSingleLeg_; 
                }
                else if (this.fxSingleLegIDRef_ != null)
                {
                    fxSingleLeg_ = IDManager.getID(fxSingleLegIDRef_) as FxSingleLeg;
                    return this.fxSingleLeg_; 
                }
                else
                {
                      return this.fxSingleLeg_; 
                }
            }
            set
            {
                if (this.fxSingleLeg_ != value)
                {
                    this.fxSingleLeg_ = value;
                }
            }
        }
        #endregion
        
        public string fxSingleLegIDRef_ { get; set; }     // substitude
        #region FxSwap_
        private FxSwap fxSwap_;
        public FxSwap FxSwap_
        {
            get
            {
                if (this.fxSwap_ != null)
                {
                    return this.fxSwap_; 
                }
                else if (this.fxSwapIDRef_ != null)
                {
                    fxSwap_ = IDManager.getID(fxSwapIDRef_) as FxSwap;
                    return this.fxSwap_; 
                }
                else
                {
                      return this.fxSwap_; 
                }
            }
            set
            {
                if (this.fxSwap_ != value)
                {
                    this.fxSwap_ = value;
                }
            }
        }
        #endregion
        
        public string fxSwapIDRef_ { get; set; }     // substitude
        #region FxOption_
        private FxOption fxOption_;
        public FxOption FxOption_
        {
            get
            {
                if (this.fxOption_ != null)
                {
                    return this.fxOption_; 
                }
                else if (this.fxOptionIDRef_ != null)
                {
                    fxOption_ = IDManager.getID(fxOptionIDRef_) as FxOption;
                    return this.fxOption_; 
                }
                else
                {
                      return this.fxOption_; 
                }
            }
            set
            {
                if (this.fxOption_ != value)
                {
                    this.fxOption_ = value;
                }
            }
        }
        #endregion
        
        public string fxOptionIDRef_ { get; set; }     // substitude
        #region FxDigitalOption_
        private FxDigitalOption fxDigitalOption_;
        public FxDigitalOption FxDigitalOption_
        {
            get
            {
                if (this.fxDigitalOption_ != null)
                {
                    return this.fxDigitalOption_; 
                }
                else if (this.fxDigitalOptionIDRef_ != null)
                {
                    fxDigitalOption_ = IDManager.getID(fxDigitalOptionIDRef_) as FxDigitalOption;
                    return this.fxDigitalOption_; 
                }
                else
                {
                      return this.fxDigitalOption_; 
                }
            }
            set
            {
                if (this.fxDigitalOption_ != value)
                {
                    this.fxDigitalOption_ = value;
                }
            }
        }
        #endregion
        
        public string fxDigitalOptionIDRef_ { get; set; }     // substitude
        #region TermDeposit_
        private TermDeposit termDeposit_;
        public TermDeposit TermDeposit_
        {
            get
            {
                if (this.termDeposit_ != null)
                {
                    return this.termDeposit_; 
                }
                else if (this.termDepositIDRef_ != null)
                {
                    termDeposit_ = IDManager.getID(termDepositIDRef_) as TermDeposit;
                    return this.termDeposit_; 
                }
                else
                {
                      return this.termDeposit_; 
                }
            }
            set
            {
                if (this.termDeposit_ != value)
                {
                    this.termDeposit_ = value;
                }
            }
        }
        #endregion
        
        public string termDepositIDRef_ { get; set; }     // substitude
        #region GenericProduct_
        private GenericProduct genericProduct_;
        public GenericProduct GenericProduct_
        {
            get
            {
                if (this.genericProduct_ != null)
                {
                    return this.genericProduct_; 
                }
                else if (this.genericProductIDRef_ != null)
                {
                    genericProduct_ = IDManager.getID(genericProductIDRef_) as GenericProduct;
                    return this.genericProduct_; 
                }
                else
                {
                      return this.genericProduct_; 
                }
            }
            set
            {
                if (this.genericProduct_ != value)
                {
                    this.genericProduct_ = value;
                }
            }
        }
        #endregion
        
        public string genericProductIDRef_ { get; set; }     // substitude
        #region NonSchemaProduct_
        private GenericProduct nonSchemaProduct_;
        public GenericProduct NonSchemaProduct_
        {
            get
            {
                if (this.nonSchemaProduct_ != null)
                {
                    return this.nonSchemaProduct_; 
                }
                else if (this.nonSchemaProductIDRef_ != null)
                {
                    nonSchemaProduct_ = IDManager.getID(nonSchemaProductIDRef_) as GenericProduct;
                    return this.nonSchemaProduct_; 
                }
                else
                {
                      return this.nonSchemaProduct_; 
                }
            }
            set
            {
                if (this.nonSchemaProduct_ != value)
                {
                    this.nonSchemaProduct_ = value;
                }
            }
        }
        #endregion
        
        public string nonSchemaProductIDRef_ { get; set; }     // substitude
        #region BulletPayment_
        private BulletPayment bulletPayment_;
        public BulletPayment BulletPayment_
        {
            get
            {
                if (this.bulletPayment_ != null)
                {
                    return this.bulletPayment_; 
                }
                else if (this.bulletPaymentIDRef_ != null)
                {
                    bulletPayment_ = IDManager.getID(bulletPaymentIDRef_) as BulletPayment;
                    return this.bulletPayment_; 
                }
                else
                {
                      return this.bulletPayment_; 
                }
            }
            set
            {
                if (this.bulletPayment_ != value)
                {
                    this.bulletPayment_ = value;
                }
            }
        }
        #endregion
        
        public string bulletPaymentIDRef_ { get; set; }     // substitude
        #region CapFloor_
        private CapFloor capFloor_;
        public CapFloor CapFloor_
        {
            get
            {
                if (this.capFloor_ != null)
                {
                    return this.capFloor_; 
                }
                else if (this.capFloorIDRef_ != null)
                {
                    capFloor_ = IDManager.getID(capFloorIDRef_) as CapFloor;
                    return this.capFloor_; 
                }
                else
                {
                      return this.capFloor_; 
                }
            }
            set
            {
                if (this.capFloor_ != value)
                {
                    this.capFloor_ = value;
                }
            }
        }
        #endregion
        
        public string capFloorIDRef_ { get; set; }     // substitude
        #region Fra_
        private Fra fra_;
        public Fra Fra_
        {
            get
            {
                if (this.fra_ != null)
                {
                    return this.fra_; 
                }
                else if (this.fraIDRef_ != null)
                {
                    fra_ = IDManager.getID(fraIDRef_) as Fra;
                    return this.fra_; 
                }
                else
                {
                      return this.fra_; 
                }
            }
            set
            {
                if (this.fra_ != value)
                {
                    this.fra_ = value;
                }
            }
        }
        #endregion
        
        public string fraIDRef_ { get; set; }     // substitude
        #region Swap_
        private Swap swap_;
        public Swap Swap_
        {
            get
            {
                if (this.swap_ != null)
                {
                    return this.swap_; 
                }
                else if (this.swapIDRef_ != null)
                {
                    swap_ = IDManager.getID(swapIDRef_) as Swap;
                    return this.swap_; 
                }
                else
                {
                      return this.swap_; 
                }
            }
            set
            {
                if (this.swap_ != value)
                {
                    this.swap_ = value;
                }
            }
        }
        #endregion
        
        public string swapIDRef_ { get; set; }     // substitude
        #region Swaption_
        private Swaption swaption_;
        public Swaption Swaption_
        {
            get
            {
                if (this.swaption_ != null)
                {
                    return this.swaption_; 
                }
                else if (this.swaptionIDRef_ != null)
                {
                    swaption_ = IDManager.getID(swaptionIDRef_) as Swaption;
                    return this.swaption_; 
                }
                else
                {
                      return this.swaption_; 
                }
            }
            set
            {
                if (this.swaption_ != value)
                {
                    this.swaption_ = value;
                }
            }
        }
        #endregion
        
        public string swaptionIDRef_ { get; set; }     // substitude
        #region EquitySwapTransactionSupplement_
        private EquitySwapTransactionSupplement equitySwapTransactionSupplement_;
        public EquitySwapTransactionSupplement EquitySwapTransactionSupplement_
        {
            get
            {
                if (this.equitySwapTransactionSupplement_ != null)
                {
                    return this.equitySwapTransactionSupplement_; 
                }
                else if (this.equitySwapTransactionSupplementIDRef_ != null)
                {
                    equitySwapTransactionSupplement_ = IDManager.getID(equitySwapTransactionSupplementIDRef_) as EquitySwapTransactionSupplement;
                    return this.equitySwapTransactionSupplement_; 
                }
                else
                {
                      return this.equitySwapTransactionSupplement_; 
                }
            }
            set
            {
                if (this.equitySwapTransactionSupplement_ != value)
                {
                    this.equitySwapTransactionSupplement_ = value;
                }
            }
        }
        #endregion
        
        public string equitySwapTransactionSupplementIDRef_ { get; set; }     // substitude
        #region StandardProduct_
        private StandardProduct standardProduct_;
        public StandardProduct StandardProduct_
        {
            get
            {
                if (this.standardProduct_ != null)
                {
                    return this.standardProduct_; 
                }
                else if (this.standardProductIDRef_ != null)
                {
                    standardProduct_ = IDManager.getID(standardProductIDRef_) as StandardProduct;
                    return this.standardProduct_; 
                }
                else
                {
                      return this.standardProduct_; 
                }
            }
            set
            {
                if (this.standardProduct_ != value)
                {
                    this.standardProduct_ = value;
                }
            }
        }
        #endregion
        
        public string standardProductIDRef_ { get; set; }     // substitude
        #region VarianceOptionTransactionSupplement_
        private VarianceOptionTransactionSupplement varianceOptionTransactionSupplement_;
        public VarianceOptionTransactionSupplement VarianceOptionTransactionSupplement_
        {
            get
            {
                if (this.varianceOptionTransactionSupplement_ != null)
                {
                    return this.varianceOptionTransactionSupplement_; 
                }
                else if (this.varianceOptionTransactionSupplementIDRef_ != null)
                {
                    varianceOptionTransactionSupplement_ = IDManager.getID(varianceOptionTransactionSupplementIDRef_) as VarianceOptionTransactionSupplement;
                    return this.varianceOptionTransactionSupplement_; 
                }
                else
                {
                      return this.varianceOptionTransactionSupplement_; 
                }
            }
            set
            {
                if (this.varianceOptionTransactionSupplement_ != value)
                {
                    this.varianceOptionTransactionSupplement_ = value;
                }
            }
        }
        #endregion
        
        public string varianceOptionTransactionSupplementIDRef_ { get; set; }     // substitude
        #region VarianceSwap_
        private VarianceSwap varianceSwap_;
        public VarianceSwap VarianceSwap_
        {
            get
            {
                if (this.varianceSwap_ != null)
                {
                    return this.varianceSwap_; 
                }
                else if (this.varianceSwapIDRef_ != null)
                {
                    varianceSwap_ = IDManager.getID(varianceSwapIDRef_) as VarianceSwap;
                    return this.varianceSwap_; 
                }
                else
                {
                      return this.varianceSwap_; 
                }
            }
            set
            {
                if (this.varianceSwap_ != value)
                {
                    this.varianceSwap_ = value;
                }
            }
        }
        #endregion
        
        public string varianceSwapIDRef_ { get; set; }     // substitude
        #region VarianceSwapTransactionSupplement_
        private VarianceSwapTransactionSupplement varianceSwapTransactionSupplement_;
        public VarianceSwapTransactionSupplement VarianceSwapTransactionSupplement_
        {
            get
            {
                if (this.varianceSwapTransactionSupplement_ != null)
                {
                    return this.varianceSwapTransactionSupplement_; 
                }
                else if (this.varianceSwapTransactionSupplementIDRef_ != null)
                {
                    varianceSwapTransactionSupplement_ = IDManager.getID(varianceSwapTransactionSupplementIDRef_) as VarianceSwapTransactionSupplement;
                    return this.varianceSwapTransactionSupplement_; 
                }
                else
                {
                      return this.varianceSwapTransactionSupplement_; 
                }
            }
            set
            {
                if (this.varianceSwapTransactionSupplement_ != value)
                {
                    this.varianceSwapTransactionSupplement_ = value;
                }
            }
        }
        #endregion
        
        public string varianceSwapTransactionSupplementIDRef_ { get; set; }     // substitude
        
    
        
    
    }
    
}

