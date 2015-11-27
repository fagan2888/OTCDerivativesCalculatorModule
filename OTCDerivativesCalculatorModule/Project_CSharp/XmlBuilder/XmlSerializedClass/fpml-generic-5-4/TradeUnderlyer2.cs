using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TradeUnderlyer2 : ISerialized
    {
        public TradeUnderlyer2(XmlNode xmlNode)
        {
            XmlNode floatingRateNode = xmlNode.SelectSingleNode("floatingRate");
            
            if (floatingRateNode != null)
            {
                if (floatingRateNode.Attributes["href"] != null || floatingRateNode.Attributes["id"] != null) 
                {
                    if (floatingRateNode.Attributes["id"] != null) 
                    {
                        floatingRateIDRef_ = floatingRateNode.Attributes["id"].Value;
                        FloatingRate ob = new FloatingRate(floatingRateNode);
                        IDManager.SetID(floatingRateIDRef_, ob);
                    }
                    else if (floatingRateNode.Attributes["href"] != null)
                    {
                        floatingRateIDRef_ = floatingRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floatingRate_ = new FloatingRate(floatingRateNode);
                    }
                }
                else
                {
                    floatingRate_ = new FloatingRate(floatingRateNode);
                }
            }
            
        
            XmlNode fixedRateNode = xmlNode.SelectSingleNode("fixedRate");
            
            if (fixedRateNode != null)
            {
                if (fixedRateNode.Attributes["href"] != null || fixedRateNode.Attributes["id"] != null) 
                {
                    if (fixedRateNode.Attributes["id"] != null) 
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["id"].Value;
                        Schedule ob = new Schedule(fixedRateNode);
                        IDManager.SetID(fixedRateIDRef_, ob);
                    }
                    else if (fixedRateNode.Attributes["href"] != null)
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedRate_ = new Schedule(fixedRateNode);
                    }
                }
                else
                {
                    fixedRate_ = new Schedule(fixedRateNode);
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
            
        
            XmlNode quotedCurrencyPairNode = xmlNode.SelectSingleNode("quotedCurrencyPair");
            
            if (quotedCurrencyPairNode != null)
            {
                if (quotedCurrencyPairNode.Attributes["href"] != null || quotedCurrencyPairNode.Attributes["id"] != null) 
                {
                    if (quotedCurrencyPairNode.Attributes["id"] != null) 
                    {
                        quotedCurrencyPairIDRef_ = quotedCurrencyPairNode.Attributes["id"].Value;
                        QuotedCurrencyPair ob = new QuotedCurrencyPair(quotedCurrencyPairNode);
                        IDManager.SetID(quotedCurrencyPairIDRef_, ob);
                    }
                    else if (quotedCurrencyPairNode.Attributes["href"] != null)
                    {
                        quotedCurrencyPairIDRef_ = quotedCurrencyPairNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quotedCurrencyPair_ = new QuotedCurrencyPair(quotedCurrencyPairNode);
                    }
                }
                else
                {
                    quotedCurrencyPair_ = new QuotedCurrencyPair(quotedCurrencyPairNode);
                }
            }
            
        
            XmlNode referenceEntityNode = xmlNode.SelectSingleNode("referenceEntity");
            
            if (referenceEntityNode != null)
            {
                if (referenceEntityNode.Attributes["href"] != null || referenceEntityNode.Attributes["id"] != null) 
                {
                    if (referenceEntityNode.Attributes["id"] != null) 
                    {
                        referenceEntityIDRef_ = referenceEntityNode.Attributes["id"].Value;
                        LegalEntity ob = new LegalEntity(referenceEntityNode);
                        IDManager.SetID(referenceEntityIDRef_, ob);
                    }
                    else if (referenceEntityNode.Attributes["href"] != null)
                    {
                        referenceEntityIDRef_ = referenceEntityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceEntity_ = new LegalEntity(referenceEntityNode);
                    }
                }
                else
                {
                    referenceEntity_ = new LegalEntity(referenceEntityNode);
                }
            }
            
        
            XmlNode payerPartyReferenceNode = xmlNode.SelectSingleNode("payerPartyReference");
            
            if (payerPartyReferenceNode != null)
            {
                if (payerPartyReferenceNode.Attributes["href"] != null || payerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (payerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        payerPartyReferenceIDRef_ = payerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(payerPartyReferenceNode);
                        IDManager.SetID(payerPartyReferenceIDRef_, ob);
                    }
                    else if (payerPartyReferenceNode.Attributes["href"] != null)
                    {
                        payerPartyReferenceIDRef_ = payerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payerPartyReference_ = new PartyReference(payerPartyReferenceNode);
                    }
                }
                else
                {
                    payerPartyReference_ = new PartyReference(payerPartyReferenceNode);
                }
            }
            
        
            XmlNode payerAccountReferenceNode = xmlNode.SelectSingleNode("payerAccountReference");
            
            if (payerAccountReferenceNode != null)
            {
                if (payerAccountReferenceNode.Attributes["href"] != null || payerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (payerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        payerAccountReferenceIDRef_ = payerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(payerAccountReferenceNode);
                        IDManager.SetID(payerAccountReferenceIDRef_, ob);
                    }
                    else if (payerAccountReferenceNode.Attributes["href"] != null)
                    {
                        payerAccountReferenceIDRef_ = payerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payerAccountReference_ = new AccountReference(payerAccountReferenceNode);
                    }
                }
                else
                {
                    payerAccountReference_ = new AccountReference(payerAccountReferenceNode);
                }
            }
            
        
            XmlNode receiverPartyReferenceNode = xmlNode.SelectSingleNode("receiverPartyReference");
            
            if (receiverPartyReferenceNode != null)
            {
                if (receiverPartyReferenceNode.Attributes["href"] != null || receiverPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (receiverPartyReferenceNode.Attributes["id"] != null) 
                    {
                        receiverPartyReferenceIDRef_ = receiverPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(receiverPartyReferenceNode);
                        IDManager.SetID(receiverPartyReferenceIDRef_, ob);
                    }
                    else if (receiverPartyReferenceNode.Attributes["href"] != null)
                    {
                        receiverPartyReferenceIDRef_ = receiverPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        receiverPartyReference_ = new PartyReference(receiverPartyReferenceNode);
                    }
                }
                else
                {
                    receiverPartyReference_ = new PartyReference(receiverPartyReferenceNode);
                }
            }
            
        
            XmlNode receiverAccountReferenceNode = xmlNode.SelectSingleNode("receiverAccountReference");
            
            if (receiverAccountReferenceNode != null)
            {
                if (receiverAccountReferenceNode.Attributes["href"] != null || receiverAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (receiverAccountReferenceNode.Attributes["id"] != null) 
                    {
                        receiverAccountReferenceIDRef_ = receiverAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(receiverAccountReferenceNode);
                        IDManager.SetID(receiverAccountReferenceIDRef_, ob);
                    }
                    else if (receiverAccountReferenceNode.Attributes["href"] != null)
                    {
                        receiverAccountReferenceIDRef_ = receiverAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        receiverAccountReference_ = new AccountReference(receiverAccountReferenceNode);
                    }
                }
                else
                {
                    receiverAccountReference_ = new AccountReference(receiverAccountReferenceNode);
                }
            }
            
        
        }
        
    
        #region FloatingRate_
        private FloatingRate floatingRate_;
        public FloatingRate FloatingRate_
        {
            get
            {
                if (this.floatingRate_ != null)
                {
                    return this.floatingRate_; 
                }
                else if (this.floatingRateIDRef_ != null)
                {
                    floatingRate_ = IDManager.getID(floatingRateIDRef_) as FloatingRate;
                    return this.floatingRate_; 
                }
                else
                {
                      return this.floatingRate_; 
                }
            }
            set
            {
                if (this.floatingRate_ != value)
                {
                    this.floatingRate_ = value;
                }
            }
        }
        #endregion
        
        public string floatingRateIDRef_ { get; set; }
        #region FixedRate_
        private Schedule fixedRate_;
        public Schedule FixedRate_
        {
            get
            {
                if (this.fixedRate_ != null)
                {
                    return this.fixedRate_; 
                }
                else if (this.fixedRateIDRef_ != null)
                {
                    fixedRate_ = IDManager.getID(fixedRateIDRef_) as Schedule;
                    return this.fixedRate_; 
                }
                else
                {
                      return this.fixedRate_; 
                }
            }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                }
            }
        }
        #endregion
        
        public string fixedRateIDRef_ { get; set; }
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
        #region QuotedCurrencyPair_
        private QuotedCurrencyPair quotedCurrencyPair_;
        public QuotedCurrencyPair QuotedCurrencyPair_
        {
            get
            {
                if (this.quotedCurrencyPair_ != null)
                {
                    return this.quotedCurrencyPair_; 
                }
                else if (this.quotedCurrencyPairIDRef_ != null)
                {
                    quotedCurrencyPair_ = IDManager.getID(quotedCurrencyPairIDRef_) as QuotedCurrencyPair;
                    return this.quotedCurrencyPair_; 
                }
                else
                {
                      return this.quotedCurrencyPair_; 
                }
            }
            set
            {
                if (this.quotedCurrencyPair_ != value)
                {
                    this.quotedCurrencyPair_ = value;
                }
            }
        }
        #endregion
        
        public string quotedCurrencyPairIDRef_ { get; set; }
        #region ReferenceEntity_
        private LegalEntity referenceEntity_;
        public LegalEntity ReferenceEntity_
        {
            get
            {
                if (this.referenceEntity_ != null)
                {
                    return this.referenceEntity_; 
                }
                else if (this.referenceEntityIDRef_ != null)
                {
                    referenceEntity_ = IDManager.getID(referenceEntityIDRef_) as LegalEntity;
                    return this.referenceEntity_; 
                }
                else
                {
                      return this.referenceEntity_; 
                }
            }
            set
            {
                if (this.referenceEntity_ != value)
                {
                    this.referenceEntity_ = value;
                }
            }
        }
        #endregion
        
        public string referenceEntityIDRef_ { get; set; }
        #region PayerPartyReference_
        private PartyReference payerPartyReference_;
        public PartyReference PayerPartyReference_
        {
            get
            {
                if (this.payerPartyReference_ != null)
                {
                    return this.payerPartyReference_; 
                }
                else if (this.payerPartyReferenceIDRef_ != null)
                {
                    payerPartyReference_ = IDManager.getID(payerPartyReferenceIDRef_) as PartyReference;
                    return this.payerPartyReference_; 
                }
                else
                {
                      return this.payerPartyReference_; 
                }
            }
            set
            {
                if (this.payerPartyReference_ != value)
                {
                    this.payerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string payerPartyReferenceIDRef_ { get; set; }
        #region PayerAccountReference_
        private AccountReference payerAccountReference_;
        public AccountReference PayerAccountReference_
        {
            get
            {
                if (this.payerAccountReference_ != null)
                {
                    return this.payerAccountReference_; 
                }
                else if (this.payerAccountReferenceIDRef_ != null)
                {
                    payerAccountReference_ = IDManager.getID(payerAccountReferenceIDRef_) as AccountReference;
                    return this.payerAccountReference_; 
                }
                else
                {
                      return this.payerAccountReference_; 
                }
            }
            set
            {
                if (this.payerAccountReference_ != value)
                {
                    this.payerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string payerAccountReferenceIDRef_ { get; set; }
        #region ReceiverPartyReference_
        private PartyReference receiverPartyReference_;
        public PartyReference ReceiverPartyReference_
        {
            get
            {
                if (this.receiverPartyReference_ != null)
                {
                    return this.receiverPartyReference_; 
                }
                else if (this.receiverPartyReferenceIDRef_ != null)
                {
                    receiverPartyReference_ = IDManager.getID(receiverPartyReferenceIDRef_) as PartyReference;
                    return this.receiverPartyReference_; 
                }
                else
                {
                      return this.receiverPartyReference_; 
                }
            }
            set
            {
                if (this.receiverPartyReference_ != value)
                {
                    this.receiverPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string receiverPartyReferenceIDRef_ { get; set; }
        #region ReceiverAccountReference_
        private AccountReference receiverAccountReference_;
        public AccountReference ReceiverAccountReference_
        {
            get
            {
                if (this.receiverAccountReference_ != null)
                {
                    return this.receiverAccountReference_; 
                }
                else if (this.receiverAccountReferenceIDRef_ != null)
                {
                    receiverAccountReference_ = IDManager.getID(receiverAccountReferenceIDRef_) as AccountReference;
                    return this.receiverAccountReference_; 
                }
                else
                {
                      return this.receiverAccountReference_; 
                }
            }
            set
            {
                if (this.receiverAccountReference_ != value)
                {
                    this.receiverAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string receiverAccountReferenceIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

