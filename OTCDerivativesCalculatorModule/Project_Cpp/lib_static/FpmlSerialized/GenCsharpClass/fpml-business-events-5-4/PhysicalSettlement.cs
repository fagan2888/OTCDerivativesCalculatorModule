using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PhysicalSettlement
    {
        public PhysicalSettlement(XmlNode xmlNode)
        {
            XmlNodeList resultingTradeIdentifierNodeList = xmlNode.SelectNodes("resultingTradeIdentifier");
            if (resultingTradeIdentifierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in resultingTradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        resultingTradeIdentifierIDRef = item.Attributes["id"].Name;
                        PartyTradeIdentifier ob = PartyTradeIdentifier();
                        IDManager.SetID(resultingTradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        resultingTradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        resultingTradeIdentifier = new PartyTradeIdentifier(item);
                    }
                }
            }
            
        
            XmlNodeList resultingTradeNodeList = xmlNode.SelectNodes("resultingTrade");
            if (resultingTradeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in resultingTradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        resultingTradeIDRef = item.Attributes["id"].Name;
                        Trade ob = Trade();
                        IDManager.SetID(resultingTradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        resultingTradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        resultingTrade = new Trade(item);
                    }
                }
            }
            
        
            XmlNodeList productNodeList = xmlNode.SelectNodes("product");
            if (productNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in productNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        productIDRef = item.Attributes["id"].Name;
                        Product ob = Product();
                        IDManager.SetID(productIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        productIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        product = new Product(item);
                    }
                }
            }
            
        
            XmlNodeList forwardNodeList = xmlNode.SelectNodes("forward");
            if (forwardNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in forwardNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        forwardIDRef = item.Attributes["id"].Name;
                        ForwardSale ob = ForwardSale();
                        IDManager.SetID(forwardIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        forwardIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        forward = new ForwardSale(item);
                    }
                }
            }
            
        
            XmlNodeList bondOptionNodeList = xmlNode.SelectNodes("bondOption");
            if (bondOptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in bondOptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        bondOptionIDRef = item.Attributes["id"].Name;
                        BondOption ob = BondOption();
                        IDManager.SetID(bondOptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        bondOptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        bondOption = new BondOption(item);
                    }
                }
            }
            
        
            XmlNodeList creditDefaultSwapNodeList = xmlNode.SelectNodes("creditDefaultSwap");
            if (creditDefaultSwapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditDefaultSwapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditDefaultSwapIDRef = item.Attributes["id"].Name;
                        CreditDefaultSwap ob = CreditDefaultSwap();
                        IDManager.SetID(creditDefaultSwapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditDefaultSwapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditDefaultSwap = new CreditDefaultSwap(item);
                    }
                }
            }
            
        
            XmlNodeList creditDefaultSwapOptionNodeList = xmlNode.SelectNodes("creditDefaultSwapOption");
            if (creditDefaultSwapOptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditDefaultSwapOptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditDefaultSwapOptionIDRef = item.Attributes["id"].Name;
                        CreditDefaultSwapOption ob = CreditDefaultSwapOption();
                        IDManager.SetID(creditDefaultSwapOptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditDefaultSwapOptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditDefaultSwapOption = new CreditDefaultSwapOption(item);
                    }
                }
            }
            
        
            XmlNodeList commodityForwardNodeList = xmlNode.SelectNodes("commodityForward");
            if (commodityForwardNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commodityForwardNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commodityForwardIDRef = item.Attributes["id"].Name;
                        CommodityForward ob = CommodityForward();
                        IDManager.SetID(commodityForwardIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commodityForwardIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commodityForward = new CommodityForward(item);
                    }
                }
            }
            
        
            XmlNodeList commodityOptionNodeList = xmlNode.SelectNodes("commodityOption");
            if (commodityOptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commodityOptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commodityOptionIDRef = item.Attributes["id"].Name;
                        CommodityOption ob = CommodityOption();
                        IDManager.SetID(commodityOptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commodityOptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commodityOption = new CommodityOption(item);
                    }
                }
            }
            
        
            XmlNodeList commoditySwapNodeList = xmlNode.SelectNodes("commoditySwap");
            if (commoditySwapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commoditySwapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commoditySwapIDRef = item.Attributes["id"].Name;
                        CommoditySwap ob = CommoditySwap();
                        IDManager.SetID(commoditySwapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commoditySwapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commoditySwap = new CommoditySwap(item);
                    }
                }
            }
            
        
            XmlNodeList commoditySwaptionNodeList = xmlNode.SelectNodes("commoditySwaption");
            if (commoditySwaptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commoditySwaptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commoditySwaptionIDRef = item.Attributes["id"].Name;
                        CommoditySwaption ob = CommoditySwaption();
                        IDManager.SetID(commoditySwaptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commoditySwaptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commoditySwaption = new CommoditySwaption(item);
                    }
                }
            }
            
        
            XmlNodeList correlationSwapNodeList = xmlNode.SelectNodes("correlationSwap");
            if (correlationSwapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in correlationSwapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        correlationSwapIDRef = item.Attributes["id"].Name;
                        CorrelationSwap ob = CorrelationSwap();
                        IDManager.SetID(correlationSwapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        correlationSwapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        correlationSwap = new CorrelationSwap(item);
                    }
                }
            }
            
        
            XmlNodeList dividendSwapOptionTransactionSupplementNodeList = xmlNode.SelectNodes("dividendSwapOptionTransactionSupplement");
            if (dividendSwapOptionTransactionSupplementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendSwapOptionTransactionSupplementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendSwapOptionTransactionSupplementIDRef = item.Attributes["id"].Name;
                        DividendSwapOptionTransactionSupplement ob = DividendSwapOptionTransactionSupplement();
                        IDManager.SetID(dividendSwapOptionTransactionSupplementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendSwapOptionTransactionSupplementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendSwapOptionTransactionSupplement = new DividendSwapOptionTransactionSupplement(item);
                    }
                }
            }
            
        
            XmlNodeList dividendSwapTransactionSupplementNodeList = xmlNode.SelectNodes("dividendSwapTransactionSupplement");
            if (dividendSwapTransactionSupplementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendSwapTransactionSupplementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendSwapTransactionSupplementIDRef = item.Attributes["id"].Name;
                        DividendSwapTransactionSupplement ob = DividendSwapTransactionSupplement();
                        IDManager.SetID(dividendSwapTransactionSupplementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendSwapTransactionSupplementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendSwapTransactionSupplement = new DividendSwapTransactionSupplement(item);
                    }
                }
            }
            
        
            XmlNodeList instrumentTradeDetailsNodeList = xmlNode.SelectNodes("instrumentTradeDetails");
            if (instrumentTradeDetailsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in instrumentTradeDetailsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        instrumentTradeDetailsIDRef = item.Attributes["id"].Name;
                        InstrumentTradeDetails ob = InstrumentTradeDetails();
                        IDManager.SetID(instrumentTradeDetailsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        instrumentTradeDetailsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        instrumentTradeDetails = new InstrumentTradeDetails(item);
                    }
                }
            }
            
        
            XmlNodeList strategyNodeList = xmlNode.SelectNodes("strategy");
            if (strategyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strategyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strategyIDRef = item.Attributes["id"].Name;
                        Strategy ob = Strategy();
                        IDManager.SetID(strategyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strategyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strategy = new Strategy(item);
                    }
                }
            }
            
        
            XmlNodeList returnSwapNodeList = xmlNode.SelectNodes("returnSwap");
            if (returnSwapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in returnSwapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        returnSwapIDRef = item.Attributes["id"].Name;
                        ReturnSwap ob = ReturnSwap();
                        IDManager.SetID(returnSwapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        returnSwapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        returnSwap = new ReturnSwap(item);
                    }
                }
            }
            
        
            XmlNodeList brokerEquityOptionNodeList = xmlNode.SelectNodes("brokerEquityOption");
            if (brokerEquityOptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in brokerEquityOptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        brokerEquityOptionIDRef = item.Attributes["id"].Name;
                        BrokerEquityOption ob = BrokerEquityOption();
                        IDManager.SetID(brokerEquityOptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        brokerEquityOptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        brokerEquityOption = new BrokerEquityOption(item);
                    }
                }
            }
            
        
            XmlNodeList equityForwardNodeList = xmlNode.SelectNodes("equityForward");
            if (equityForwardNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equityForwardNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equityForwardIDRef = item.Attributes["id"].Name;
                        EquityForward ob = EquityForward();
                        IDManager.SetID(equityForwardIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equityForwardIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equityForward = new EquityForward(item);
                    }
                }
            }
            
        
            XmlNodeList equityOptionNodeList = xmlNode.SelectNodes("equityOption");
            if (equityOptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equityOptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equityOptionIDRef = item.Attributes["id"].Name;
                        EquityOption ob = EquityOption();
                        IDManager.SetID(equityOptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equityOptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equityOption = new EquityOption(item);
                    }
                }
            }
            
        
            XmlNodeList equityOptionTransactionSupplementNodeList = xmlNode.SelectNodes("equityOptionTransactionSupplement");
            if (equityOptionTransactionSupplementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equityOptionTransactionSupplementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equityOptionTransactionSupplementIDRef = item.Attributes["id"].Name;
                        EquityOptionTransactionSupplement ob = EquityOptionTransactionSupplement();
                        IDManager.SetID(equityOptionTransactionSupplementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equityOptionTransactionSupplementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equityOptionTransactionSupplement = new EquityOptionTransactionSupplement(item);
                    }
                }
            }
            
        
            XmlNodeList fxSingleLegNodeList = xmlNode.SelectNodes("fxSingleLeg");
            if (fxSingleLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxSingleLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxSingleLegIDRef = item.Attributes["id"].Name;
                        FxSingleLeg ob = FxSingleLeg();
                        IDManager.SetID(fxSingleLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxSingleLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxSingleLeg = new FxSingleLeg(item);
                    }
                }
            }
            
        
            XmlNodeList fxSwapNodeList = xmlNode.SelectNodes("fxSwap");
            if (fxSwapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxSwapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxSwapIDRef = item.Attributes["id"].Name;
                        FxSwap ob = FxSwap();
                        IDManager.SetID(fxSwapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxSwapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxSwap = new FxSwap(item);
                    }
                }
            }
            
        
            XmlNodeList fxOptionNodeList = xmlNode.SelectNodes("fxOption");
            if (fxOptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxOptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxOptionIDRef = item.Attributes["id"].Name;
                        FxOption ob = FxOption();
                        IDManager.SetID(fxOptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxOptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxOption = new FxOption(item);
                    }
                }
            }
            
        
            XmlNodeList fxDigitalOptionNodeList = xmlNode.SelectNodes("fxDigitalOption");
            if (fxDigitalOptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxDigitalOptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxDigitalOptionIDRef = item.Attributes["id"].Name;
                        FxDigitalOption ob = FxDigitalOption();
                        IDManager.SetID(fxDigitalOptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxDigitalOptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxDigitalOption = new FxDigitalOption(item);
                    }
                }
            }
            
        
            XmlNodeList termDepositNodeList = xmlNode.SelectNodes("termDeposit");
            if (termDepositNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in termDepositNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        termDepositIDRef = item.Attributes["id"].Name;
                        TermDeposit ob = TermDeposit();
                        IDManager.SetID(termDepositIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        termDepositIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        termDeposit = new TermDeposit(item);
                    }
                }
            }
            
        
            XmlNodeList genericProductNodeList = xmlNode.SelectNodes("genericProduct");
            if (genericProductNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in genericProductNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        genericProductIDRef = item.Attributes["id"].Name;
                        GenericProduct ob = GenericProduct();
                        IDManager.SetID(genericProductIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        genericProductIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        genericProduct = new GenericProduct(item);
                    }
                }
            }
            
        
            XmlNodeList nonSchemaProductNodeList = xmlNode.SelectNodes("nonSchemaProduct");
            if (nonSchemaProductNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nonSchemaProductNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nonSchemaProductIDRef = item.Attributes["id"].Name;
                        GenericProduct ob = GenericProduct();
                        IDManager.SetID(nonSchemaProductIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nonSchemaProductIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        nonSchemaProduct = new GenericProduct(item);
                    }
                }
            }
            
        
            XmlNodeList bulletPaymentNodeList = xmlNode.SelectNodes("bulletPayment");
            if (bulletPaymentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in bulletPaymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        bulletPaymentIDRef = item.Attributes["id"].Name;
                        BulletPayment ob = BulletPayment();
                        IDManager.SetID(bulletPaymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        bulletPaymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        bulletPayment = new BulletPayment(item);
                    }
                }
            }
            
        
            XmlNodeList capFloorNodeList = xmlNode.SelectNodes("capFloor");
            if (capFloorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in capFloorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        capFloorIDRef = item.Attributes["id"].Name;
                        CapFloor ob = CapFloor();
                        IDManager.SetID(capFloorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        capFloorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        capFloor = new CapFloor(item);
                    }
                }
            }
            
        
            XmlNodeList fraNodeList = xmlNode.SelectNodes("fra");
            if (fraNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fraNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fraIDRef = item.Attributes["id"].Name;
                        Fra ob = Fra();
                        IDManager.SetID(fraIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fraIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fra = new Fra(item);
                    }
                }
            }
            
        
            XmlNodeList swapNodeList = xmlNode.SelectNodes("swap");
            if (swapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in swapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        swapIDRef = item.Attributes["id"].Name;
                        Swap ob = Swap();
                        IDManager.SetID(swapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        swapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        swap = new Swap(item);
                    }
                }
            }
            
        
            XmlNodeList swaptionNodeList = xmlNode.SelectNodes("swaption");
            if (swaptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in swaptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        swaptionIDRef = item.Attributes["id"].Name;
                        Swaption ob = Swaption();
                        IDManager.SetID(swaptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        swaptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        swaption = new Swaption(item);
                    }
                }
            }
            
        
            XmlNodeList equitySwapTransactionSupplementNodeList = xmlNode.SelectNodes("equitySwapTransactionSupplement");
            if (equitySwapTransactionSupplementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equitySwapTransactionSupplementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equitySwapTransactionSupplementIDRef = item.Attributes["id"].Name;
                        EquitySwapTransactionSupplement ob = EquitySwapTransactionSupplement();
                        IDManager.SetID(equitySwapTransactionSupplementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equitySwapTransactionSupplementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equitySwapTransactionSupplement = new EquitySwapTransactionSupplement(item);
                    }
                }
            }
            
        
            XmlNodeList standardProductNodeList = xmlNode.SelectNodes("standardProduct");
            if (standardProductNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in standardProductNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        standardProductIDRef = item.Attributes["id"].Name;
                        StandardProduct ob = StandardProduct();
                        IDManager.SetID(standardProductIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        standardProductIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        standardProduct = new StandardProduct(item);
                    }
                }
            }
            
        
            XmlNodeList varianceOptionTransactionSupplementNodeList = xmlNode.SelectNodes("varianceOptionTransactionSupplement");
            if (varianceOptionTransactionSupplementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in varianceOptionTransactionSupplementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        varianceOptionTransactionSupplementIDRef = item.Attributes["id"].Name;
                        VarianceOptionTransactionSupplement ob = VarianceOptionTransactionSupplement();
                        IDManager.SetID(varianceOptionTransactionSupplementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        varianceOptionTransactionSupplementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        varianceOptionTransactionSupplement = new VarianceOptionTransactionSupplement(item);
                    }
                }
            }
            
        
            XmlNodeList varianceSwapNodeList = xmlNode.SelectNodes("varianceSwap");
            if (varianceSwapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in varianceSwapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        varianceSwapIDRef = item.Attributes["id"].Name;
                        VarianceSwap ob = VarianceSwap();
                        IDManager.SetID(varianceSwapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        varianceSwapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        varianceSwap = new VarianceSwap(item);
                    }
                }
            }
            
        
            XmlNodeList varianceSwapTransactionSupplementNodeList = xmlNode.SelectNodes("varianceSwapTransactionSupplement");
            if (varianceSwapTransactionSupplementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in varianceSwapTransactionSupplementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        varianceSwapTransactionSupplementIDRef = item.Attributes["id"].Name;
                        VarianceSwapTransactionSupplement ob = VarianceSwapTransactionSupplement();
                        IDManager.SetID(varianceSwapTransactionSupplementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        varianceSwapTransactionSupplementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        varianceSwapTransactionSupplement = new VarianceSwapTransactionSupplement(item);
                    }
                }
            }
            
        
        }
        
    
        #region ResultingTradeIdentifier
        private PartyTradeIdentifier resultingTradeIdentifier;
        public PartyTradeIdentifier ResultingTradeIdentifier
        {
            get
            {
                if (this.resultingTradeIdentifier != null)
                {
                    return this.resultingTradeIdentifier; 
                }
                else if (this.resultingTradeIdentifierIDRef != null)
                {
                    resultingTradeIdentifier = IDManager.getID(resultingTradeIdentifierIDRef) as PartyTradeIdentifier;
                    return this.resultingTradeIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.resultingTradeIdentifier != value)
                {
                    this.resultingTradeIdentifier = value;
                }
            }
        }
        #endregion
        
        public string PartyTradeIdentifierIDRef { get; set; }
        #region ResultingTrade
        private Trade resultingTrade;
        public Trade ResultingTrade
        {
            get
            {
                if (this.resultingTrade != null)
                {
                    return this.resultingTrade; 
                }
                else if (this.resultingTradeIDRef != null)
                {
                    resultingTrade = IDManager.getID(resultingTradeIDRef) as Trade;
                    return this.resultingTrade; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.resultingTrade != value)
                {
                    this.resultingTrade = value;
                }
            }
        }
        #endregion
        
        public string TradeIDRef { get; set; }
        #region Product
        private Product product;
        public Product Product
        {
            get
            {
                if (this.product != null)
                {
                    return this.product; 
                }
                else if (this.productIDRef != null)
                {
                    product = IDManager.getID(productIDRef) as Product;
                    return this.product; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.product != value)
                {
                    this.product = value;
                }
            }
        }
        #endregion
        
        public string ProductIDRef { get; set; }
        #region Forward
        private ForwardSale forward;
        public ForwardSale Forward
        {
            get
            {
                if (this.forward != null)
                {
                    return this.forward; 
                }
                else if (this.forwardIDRef != null)
                {
                    forward = IDManager.getID(forwardIDRef) as ForwardSale;
                    return this.forward; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.forward != value)
                {
                    this.forward = value;
                }
            }
        }
        #endregion
        
        public string ForwardSaleIDRef { get; set; }     // substitude
        #region BondOption
        private BondOption bondOption;
        public BondOption BondOption
        {
            get
            {
                if (this.bondOption != null)
                {
                    return this.bondOption; 
                }
                else if (this.bondOptionIDRef != null)
                {
                    bondOption = IDManager.getID(bondOptionIDRef) as BondOption;
                    return this.bondOption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.bondOption != value)
                {
                    this.bondOption = value;
                }
            }
        }
        #endregion
        
        public string BondOptionIDRef { get; set; }     // substitude
        #region CreditDefaultSwap
        private CreditDefaultSwap creditDefaultSwap;
        public CreditDefaultSwap CreditDefaultSwap
        {
            get
            {
                if (this.creditDefaultSwap != null)
                {
                    return this.creditDefaultSwap; 
                }
                else if (this.creditDefaultSwapIDRef != null)
                {
                    creditDefaultSwap = IDManager.getID(creditDefaultSwapIDRef) as CreditDefaultSwap;
                    return this.creditDefaultSwap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditDefaultSwap != value)
                {
                    this.creditDefaultSwap = value;
                }
            }
        }
        #endregion
        
        public string CreditDefaultSwapIDRef { get; set; }     // substitude
        #region CreditDefaultSwapOption
        private CreditDefaultSwapOption creditDefaultSwapOption;
        public CreditDefaultSwapOption CreditDefaultSwapOption
        {
            get
            {
                if (this.creditDefaultSwapOption != null)
                {
                    return this.creditDefaultSwapOption; 
                }
                else if (this.creditDefaultSwapOptionIDRef != null)
                {
                    creditDefaultSwapOption = IDManager.getID(creditDefaultSwapOptionIDRef) as CreditDefaultSwapOption;
                    return this.creditDefaultSwapOption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditDefaultSwapOption != value)
                {
                    this.creditDefaultSwapOption = value;
                }
            }
        }
        #endregion
        
        public string CreditDefaultSwapOptionIDRef { get; set; }     // substitude
        #region CommodityForward
        private CommodityForward commodityForward;
        public CommodityForward CommodityForward
        {
            get
            {
                if (this.commodityForward != null)
                {
                    return this.commodityForward; 
                }
                else if (this.commodityForwardIDRef != null)
                {
                    commodityForward = IDManager.getID(commodityForwardIDRef) as CommodityForward;
                    return this.commodityForward; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commodityForward != value)
                {
                    this.commodityForward = value;
                }
            }
        }
        #endregion
        
        public string CommodityForwardIDRef { get; set; }     // substitude
        #region CommodityOption
        private CommodityOption commodityOption;
        public CommodityOption CommodityOption
        {
            get
            {
                if (this.commodityOption != null)
                {
                    return this.commodityOption; 
                }
                else if (this.commodityOptionIDRef != null)
                {
                    commodityOption = IDManager.getID(commodityOptionIDRef) as CommodityOption;
                    return this.commodityOption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commodityOption != value)
                {
                    this.commodityOption = value;
                }
            }
        }
        #endregion
        
        public string CommodityOptionIDRef { get; set; }     // substitude
        #region CommoditySwap
        private CommoditySwap commoditySwap;
        public CommoditySwap CommoditySwap
        {
            get
            {
                if (this.commoditySwap != null)
                {
                    return this.commoditySwap; 
                }
                else if (this.commoditySwapIDRef != null)
                {
                    commoditySwap = IDManager.getID(commoditySwapIDRef) as CommoditySwap;
                    return this.commoditySwap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commoditySwap != value)
                {
                    this.commoditySwap = value;
                }
            }
        }
        #endregion
        
        public string CommoditySwapIDRef { get; set; }     // substitude
        #region CommoditySwaption
        private CommoditySwaption commoditySwaption;
        public CommoditySwaption CommoditySwaption
        {
            get
            {
                if (this.commoditySwaption != null)
                {
                    return this.commoditySwaption; 
                }
                else if (this.commoditySwaptionIDRef != null)
                {
                    commoditySwaption = IDManager.getID(commoditySwaptionIDRef) as CommoditySwaption;
                    return this.commoditySwaption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commoditySwaption != value)
                {
                    this.commoditySwaption = value;
                }
            }
        }
        #endregion
        
        public string CommoditySwaptionIDRef { get; set; }     // substitude
        #region CorrelationSwap
        private CorrelationSwap correlationSwap;
        public CorrelationSwap CorrelationSwap
        {
            get
            {
                if (this.correlationSwap != null)
                {
                    return this.correlationSwap; 
                }
                else if (this.correlationSwapIDRef != null)
                {
                    correlationSwap = IDManager.getID(correlationSwapIDRef) as CorrelationSwap;
                    return this.correlationSwap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.correlationSwap != value)
                {
                    this.correlationSwap = value;
                }
            }
        }
        #endregion
        
        public string CorrelationSwapIDRef { get; set; }     // substitude
        #region DividendSwapOptionTransactionSupplement
        private DividendSwapOptionTransactionSupplement dividendSwapOptionTransactionSupplement;
        public DividendSwapOptionTransactionSupplement DividendSwapOptionTransactionSupplement
        {
            get
            {
                if (this.dividendSwapOptionTransactionSupplement != null)
                {
                    return this.dividendSwapOptionTransactionSupplement; 
                }
                else if (this.dividendSwapOptionTransactionSupplementIDRef != null)
                {
                    dividendSwapOptionTransactionSupplement = IDManager.getID(dividendSwapOptionTransactionSupplementIDRef) as DividendSwapOptionTransactionSupplement;
                    return this.dividendSwapOptionTransactionSupplement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendSwapOptionTransactionSupplement != value)
                {
                    this.dividendSwapOptionTransactionSupplement = value;
                }
            }
        }
        #endregion
        
        public string DividendSwapOptionTransactionSupplementIDRef { get; set; }     // substitude
        #region DividendSwapTransactionSupplement
        private DividendSwapTransactionSupplement dividendSwapTransactionSupplement;
        public DividendSwapTransactionSupplement DividendSwapTransactionSupplement
        {
            get
            {
                if (this.dividendSwapTransactionSupplement != null)
                {
                    return this.dividendSwapTransactionSupplement; 
                }
                else if (this.dividendSwapTransactionSupplementIDRef != null)
                {
                    dividendSwapTransactionSupplement = IDManager.getID(dividendSwapTransactionSupplementIDRef) as DividendSwapTransactionSupplement;
                    return this.dividendSwapTransactionSupplement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendSwapTransactionSupplement != value)
                {
                    this.dividendSwapTransactionSupplement = value;
                }
            }
        }
        #endregion
        
        public string DividendSwapTransactionSupplementIDRef { get; set; }     // substitude
        #region InstrumentTradeDetails
        private InstrumentTradeDetails instrumentTradeDetails;
        public InstrumentTradeDetails InstrumentTradeDetails
        {
            get
            {
                if (this.instrumentTradeDetails != null)
                {
                    return this.instrumentTradeDetails; 
                }
                else if (this.instrumentTradeDetailsIDRef != null)
                {
                    instrumentTradeDetails = IDManager.getID(instrumentTradeDetailsIDRef) as InstrumentTradeDetails;
                    return this.instrumentTradeDetails; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.instrumentTradeDetails != value)
                {
                    this.instrumentTradeDetails = value;
                }
            }
        }
        #endregion
        
        public string InstrumentTradeDetailsIDRef { get; set; }     // substitude
        #region Strategy
        private Strategy strategy;
        public Strategy Strategy
        {
            get
            {
                if (this.strategy != null)
                {
                    return this.strategy; 
                }
                else if (this.strategyIDRef != null)
                {
                    strategy = IDManager.getID(strategyIDRef) as Strategy;
                    return this.strategy; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strategy != value)
                {
                    this.strategy = value;
                }
            }
        }
        #endregion
        
        public string StrategyIDRef { get; set; }     // substitude
        #region ReturnSwap
        private ReturnSwap returnSwap;
        public ReturnSwap ReturnSwap
        {
            get
            {
                if (this.returnSwap != null)
                {
                    return this.returnSwap; 
                }
                else if (this.returnSwapIDRef != null)
                {
                    returnSwap = IDManager.getID(returnSwapIDRef) as ReturnSwap;
                    return this.returnSwap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.returnSwap != value)
                {
                    this.returnSwap = value;
                }
            }
        }
        #endregion
        
        public string ReturnSwapIDRef { get; set; }     // substitude
        #region BrokerEquityOption
        private BrokerEquityOption brokerEquityOption;
        public BrokerEquityOption BrokerEquityOption
        {
            get
            {
                if (this.brokerEquityOption != null)
                {
                    return this.brokerEquityOption; 
                }
                else if (this.brokerEquityOptionIDRef != null)
                {
                    brokerEquityOption = IDManager.getID(brokerEquityOptionIDRef) as BrokerEquityOption;
                    return this.brokerEquityOption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.brokerEquityOption != value)
                {
                    this.brokerEquityOption = value;
                }
            }
        }
        #endregion
        
        public string BrokerEquityOptionIDRef { get; set; }     // substitude
        #region EquityForward
        private EquityForward equityForward;
        public EquityForward EquityForward
        {
            get
            {
                if (this.equityForward != null)
                {
                    return this.equityForward; 
                }
                else if (this.equityForwardIDRef != null)
                {
                    equityForward = IDManager.getID(equityForwardIDRef) as EquityForward;
                    return this.equityForward; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equityForward != value)
                {
                    this.equityForward = value;
                }
            }
        }
        #endregion
        
        public string EquityForwardIDRef { get; set; }     // substitude
        #region EquityOption
        private EquityOption equityOption;
        public EquityOption EquityOption
        {
            get
            {
                if (this.equityOption != null)
                {
                    return this.equityOption; 
                }
                else if (this.equityOptionIDRef != null)
                {
                    equityOption = IDManager.getID(equityOptionIDRef) as EquityOption;
                    return this.equityOption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equityOption != value)
                {
                    this.equityOption = value;
                }
            }
        }
        #endregion
        
        public string EquityOptionIDRef { get; set; }     // substitude
        #region EquityOptionTransactionSupplement
        private EquityOptionTransactionSupplement equityOptionTransactionSupplement;
        public EquityOptionTransactionSupplement EquityOptionTransactionSupplement
        {
            get
            {
                if (this.equityOptionTransactionSupplement != null)
                {
                    return this.equityOptionTransactionSupplement; 
                }
                else if (this.equityOptionTransactionSupplementIDRef != null)
                {
                    equityOptionTransactionSupplement = IDManager.getID(equityOptionTransactionSupplementIDRef) as EquityOptionTransactionSupplement;
                    return this.equityOptionTransactionSupplement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equityOptionTransactionSupplement != value)
                {
                    this.equityOptionTransactionSupplement = value;
                }
            }
        }
        #endregion
        
        public string EquityOptionTransactionSupplementIDRef { get; set; }     // substitude
        #region FxSingleLeg
        private FxSingleLeg fxSingleLeg;
        public FxSingleLeg FxSingleLeg
        {
            get
            {
                if (this.fxSingleLeg != null)
                {
                    return this.fxSingleLeg; 
                }
                else if (this.fxSingleLegIDRef != null)
                {
                    fxSingleLeg = IDManager.getID(fxSingleLegIDRef) as FxSingleLeg;
                    return this.fxSingleLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxSingleLeg != value)
                {
                    this.fxSingleLeg = value;
                }
            }
        }
        #endregion
        
        public string FxSingleLegIDRef { get; set; }     // substitude
        #region FxSwap
        private FxSwap fxSwap;
        public FxSwap FxSwap
        {
            get
            {
                if (this.fxSwap != null)
                {
                    return this.fxSwap; 
                }
                else if (this.fxSwapIDRef != null)
                {
                    fxSwap = IDManager.getID(fxSwapIDRef) as FxSwap;
                    return this.fxSwap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxSwap != value)
                {
                    this.fxSwap = value;
                }
            }
        }
        #endregion
        
        public string FxSwapIDRef { get; set; }     // substitude
        #region FxOption
        private FxOption fxOption;
        public FxOption FxOption
        {
            get
            {
                if (this.fxOption != null)
                {
                    return this.fxOption; 
                }
                else if (this.fxOptionIDRef != null)
                {
                    fxOption = IDManager.getID(fxOptionIDRef) as FxOption;
                    return this.fxOption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxOption != value)
                {
                    this.fxOption = value;
                }
            }
        }
        #endregion
        
        public string FxOptionIDRef { get; set; }     // substitude
        #region FxDigitalOption
        private FxDigitalOption fxDigitalOption;
        public FxDigitalOption FxDigitalOption
        {
            get
            {
                if (this.fxDigitalOption != null)
                {
                    return this.fxDigitalOption; 
                }
                else if (this.fxDigitalOptionIDRef != null)
                {
                    fxDigitalOption = IDManager.getID(fxDigitalOptionIDRef) as FxDigitalOption;
                    return this.fxDigitalOption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxDigitalOption != value)
                {
                    this.fxDigitalOption = value;
                }
            }
        }
        #endregion
        
        public string FxDigitalOptionIDRef { get; set; }     // substitude
        #region TermDeposit
        private TermDeposit termDeposit;
        public TermDeposit TermDeposit
        {
            get
            {
                if (this.termDeposit != null)
                {
                    return this.termDeposit; 
                }
                else if (this.termDepositIDRef != null)
                {
                    termDeposit = IDManager.getID(termDepositIDRef) as TermDeposit;
                    return this.termDeposit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.termDeposit != value)
                {
                    this.termDeposit = value;
                }
            }
        }
        #endregion
        
        public string TermDepositIDRef { get; set; }     // substitude
        #region GenericProduct
        private GenericProduct genericProduct;
        public GenericProduct GenericProduct
        {
            get
            {
                if (this.genericProduct != null)
                {
                    return this.genericProduct; 
                }
                else if (this.genericProductIDRef != null)
                {
                    genericProduct = IDManager.getID(genericProductIDRef) as GenericProduct;
                    return this.genericProduct; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.genericProduct != value)
                {
                    this.genericProduct = value;
                }
            }
        }
        #endregion
        
        public string GenericProductIDRef { get; set; }     // substitude
        #region NonSchemaProduct
        private GenericProduct nonSchemaProduct;
        public GenericProduct NonSchemaProduct
        {
            get
            {
                if (this.nonSchemaProduct != null)
                {
                    return this.nonSchemaProduct; 
                }
                else if (this.nonSchemaProductIDRef != null)
                {
                    nonSchemaProduct = IDManager.getID(nonSchemaProductIDRef) as GenericProduct;
                    return this.nonSchemaProduct; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.nonSchemaProduct != value)
                {
                    this.nonSchemaProduct = value;
                }
            }
        }
        #endregion
        
        public string GenericProductIDRef { get; set; }     // substitude
        #region BulletPayment
        private BulletPayment bulletPayment;
        public BulletPayment BulletPayment
        {
            get
            {
                if (this.bulletPayment != null)
                {
                    return this.bulletPayment; 
                }
                else if (this.bulletPaymentIDRef != null)
                {
                    bulletPayment = IDManager.getID(bulletPaymentIDRef) as BulletPayment;
                    return this.bulletPayment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.bulletPayment != value)
                {
                    this.bulletPayment = value;
                }
            }
        }
        #endregion
        
        public string BulletPaymentIDRef { get; set; }     // substitude
        #region CapFloor
        private CapFloor capFloor;
        public CapFloor CapFloor
        {
            get
            {
                if (this.capFloor != null)
                {
                    return this.capFloor; 
                }
                else if (this.capFloorIDRef != null)
                {
                    capFloor = IDManager.getID(capFloorIDRef) as CapFloor;
                    return this.capFloor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.capFloor != value)
                {
                    this.capFloor = value;
                }
            }
        }
        #endregion
        
        public string CapFloorIDRef { get; set; }     // substitude
        #region Fra
        private Fra fra;
        public Fra Fra
        {
            get
            {
                if (this.fra != null)
                {
                    return this.fra; 
                }
                else if (this.fraIDRef != null)
                {
                    fra = IDManager.getID(fraIDRef) as Fra;
                    return this.fra; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fra != value)
                {
                    this.fra = value;
                }
            }
        }
        #endregion
        
        public string FraIDRef { get; set; }     // substitude
        #region Swap
        private Swap swap;
        public Swap Swap
        {
            get
            {
                if (this.swap != null)
                {
                    return this.swap; 
                }
                else if (this.swapIDRef != null)
                {
                    swap = IDManager.getID(swapIDRef) as Swap;
                    return this.swap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.swap != value)
                {
                    this.swap = value;
                }
            }
        }
        #endregion
        
        public string SwapIDRef { get; set; }     // substitude
        #region Swaption
        private Swaption swaption;
        public Swaption Swaption
        {
            get
            {
                if (this.swaption != null)
                {
                    return this.swaption; 
                }
                else if (this.swaptionIDRef != null)
                {
                    swaption = IDManager.getID(swaptionIDRef) as Swaption;
                    return this.swaption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.swaption != value)
                {
                    this.swaption = value;
                }
            }
        }
        #endregion
        
        public string SwaptionIDRef { get; set; }     // substitude
        #region EquitySwapTransactionSupplement
        private EquitySwapTransactionSupplement equitySwapTransactionSupplement;
        public EquitySwapTransactionSupplement EquitySwapTransactionSupplement
        {
            get
            {
                if (this.equitySwapTransactionSupplement != null)
                {
                    return this.equitySwapTransactionSupplement; 
                }
                else if (this.equitySwapTransactionSupplementIDRef != null)
                {
                    equitySwapTransactionSupplement = IDManager.getID(equitySwapTransactionSupplementIDRef) as EquitySwapTransactionSupplement;
                    return this.equitySwapTransactionSupplement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equitySwapTransactionSupplement != value)
                {
                    this.equitySwapTransactionSupplement = value;
                }
            }
        }
        #endregion
        
        public string EquitySwapTransactionSupplementIDRef { get; set; }     // substitude
        #region StandardProduct
        private StandardProduct standardProduct;
        public StandardProduct StandardProduct
        {
            get
            {
                if (this.standardProduct != null)
                {
                    return this.standardProduct; 
                }
                else if (this.standardProductIDRef != null)
                {
                    standardProduct = IDManager.getID(standardProductIDRef) as StandardProduct;
                    return this.standardProduct; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.standardProduct != value)
                {
                    this.standardProduct = value;
                }
            }
        }
        #endregion
        
        public string StandardProductIDRef { get; set; }     // substitude
        #region VarianceOptionTransactionSupplement
        private VarianceOptionTransactionSupplement varianceOptionTransactionSupplement;
        public VarianceOptionTransactionSupplement VarianceOptionTransactionSupplement
        {
            get
            {
                if (this.varianceOptionTransactionSupplement != null)
                {
                    return this.varianceOptionTransactionSupplement; 
                }
                else if (this.varianceOptionTransactionSupplementIDRef != null)
                {
                    varianceOptionTransactionSupplement = IDManager.getID(varianceOptionTransactionSupplementIDRef) as VarianceOptionTransactionSupplement;
                    return this.varianceOptionTransactionSupplement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.varianceOptionTransactionSupplement != value)
                {
                    this.varianceOptionTransactionSupplement = value;
                }
            }
        }
        #endregion
        
        public string VarianceOptionTransactionSupplementIDRef { get; set; }     // substitude
        #region VarianceSwap
        private VarianceSwap varianceSwap;
        public VarianceSwap VarianceSwap
        {
            get
            {
                if (this.varianceSwap != null)
                {
                    return this.varianceSwap; 
                }
                else if (this.varianceSwapIDRef != null)
                {
                    varianceSwap = IDManager.getID(varianceSwapIDRef) as VarianceSwap;
                    return this.varianceSwap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.varianceSwap != value)
                {
                    this.varianceSwap = value;
                }
            }
        }
        #endregion
        
        public string VarianceSwapIDRef { get; set; }     // substitude
        #region VarianceSwapTransactionSupplement
        private VarianceSwapTransactionSupplement varianceSwapTransactionSupplement;
        public VarianceSwapTransactionSupplement VarianceSwapTransactionSupplement
        {
            get
            {
                if (this.varianceSwapTransactionSupplement != null)
                {
                    return this.varianceSwapTransactionSupplement; 
                }
                else if (this.varianceSwapTransactionSupplementIDRef != null)
                {
                    varianceSwapTransactionSupplement = IDManager.getID(varianceSwapTransactionSupplementIDRef) as VarianceSwapTransactionSupplement;
                    return this.varianceSwapTransactionSupplement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.varianceSwapTransactionSupplement != value)
                {
                    this.varianceSwapTransactionSupplement = value;
                }
            }
        }
        #endregion
        
        public string VarianceSwapTransactionSupplementIDRef { get; set; }     // substitude
        public string choiceStr_0;
        
    
        
    
    }
    
}

