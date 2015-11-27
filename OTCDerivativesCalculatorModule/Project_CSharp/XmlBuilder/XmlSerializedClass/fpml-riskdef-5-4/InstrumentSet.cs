using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InstrumentSet : ISerialized
    {
        public InstrumentSet(XmlNode xmlNode)
        {
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
            
        
            XmlNode curveInstrumentNode = xmlNode.SelectSingleNode("curveInstrument");
            
            if (curveInstrumentNode != null)
            {
                if (curveInstrumentNode.Attributes["href"] != null || curveInstrumentNode.Attributes["id"] != null) 
                {
                    if (curveInstrumentNode.Attributes["id"] != null) 
                    {
                        curveInstrumentIDRef_ = curveInstrumentNode.Attributes["id"].Value;
                        Asset ob = new Asset(curveInstrumentNode);
                        IDManager.SetID(curveInstrumentIDRef_, ob);
                    }
                    else if (curveInstrumentNode.Attributes["href"] != null)
                    {
                        curveInstrumentIDRef_ = curveInstrumentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        curveInstrument_ = new Asset(curveInstrumentNode);
                    }
                }
                else
                {
                    curveInstrument_ = new Asset(curveInstrumentNode);
                }
            }
            
        
            XmlNode depositNode = xmlNode.SelectSingleNode("deposit");
            
            if (depositNode != null)
            {
                if (depositNode.Attributes["href"] != null || depositNode.Attributes["id"] != null) 
                {
                    if (depositNode.Attributes["id"] != null) 
                    {
                        depositIDRef_ = depositNode.Attributes["id"].Value;
                        Deposit ob = new Deposit(depositNode);
                        IDManager.SetID(depositIDRef_, ob);
                    }
                    else if (depositNode.Attributes["href"] != null)
                    {
                        depositIDRef_ = depositNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deposit_ = new Deposit(depositNode);
                    }
                }
                else
                {
                    deposit_ = new Deposit(depositNode);
                }
            }
            
        
            XmlNode fxNode = xmlNode.SelectSingleNode("fx");
            
            if (fxNode != null)
            {
                if (fxNode.Attributes["href"] != null || fxNode.Attributes["id"] != null) 
                {
                    if (fxNode.Attributes["id"] != null) 
                    {
                        fxIDRef_ = fxNode.Attributes["id"].Value;
                        FxRateAsset ob = new FxRateAsset(fxNode);
                        IDManager.SetID(fxIDRef_, ob);
                    }
                    else if (fxNode.Attributes["href"] != null)
                    {
                        fxIDRef_ = fxNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fx_ = new FxRateAsset(fxNode);
                    }
                }
                else
                {
                    fx_ = new FxRateAsset(fxNode);
                }
            }
            
        
            XmlNode rateIndexNode = xmlNode.SelectSingleNode("rateIndex");
            
            if (rateIndexNode != null)
            {
                if (rateIndexNode.Attributes["href"] != null || rateIndexNode.Attributes["id"] != null) 
                {
                    if (rateIndexNode.Attributes["id"] != null) 
                    {
                        rateIndexIDRef_ = rateIndexNode.Attributes["id"].Value;
                        RateIndex ob = new RateIndex(rateIndexNode);
                        IDManager.SetID(rateIndexIDRef_, ob);
                    }
                    else if (rateIndexNode.Attributes["href"] != null)
                    {
                        rateIndexIDRef_ = rateIndexNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rateIndex_ = new RateIndex(rateIndexNode);
                    }
                }
                else
                {
                    rateIndex_ = new RateIndex(rateIndexNode);
                }
            }
            
        
            XmlNode simpleCreditDefaultSwapNode = xmlNode.SelectSingleNode("simpleCreditDefaultSwap");
            
            if (simpleCreditDefaultSwapNode != null)
            {
                if (simpleCreditDefaultSwapNode.Attributes["href"] != null || simpleCreditDefaultSwapNode.Attributes["id"] != null) 
                {
                    if (simpleCreditDefaultSwapNode.Attributes["id"] != null) 
                    {
                        simpleCreditDefaultSwapIDRef_ = simpleCreditDefaultSwapNode.Attributes["id"].Value;
                        SimpleCreditDefaultSwap ob = new SimpleCreditDefaultSwap(simpleCreditDefaultSwapNode);
                        IDManager.SetID(simpleCreditDefaultSwapIDRef_, ob);
                    }
                    else if (simpleCreditDefaultSwapNode.Attributes["href"] != null)
                    {
                        simpleCreditDefaultSwapIDRef_ = simpleCreditDefaultSwapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        simpleCreditDefaultSwap_ = new SimpleCreditDefaultSwap(simpleCreditDefaultSwapNode);
                    }
                }
                else
                {
                    simpleCreditDefaultSwap_ = new SimpleCreditDefaultSwap(simpleCreditDefaultSwapNode);
                }
            }
            
        
            XmlNode simpleFraNode = xmlNode.SelectSingleNode("simpleFra");
            
            if (simpleFraNode != null)
            {
                if (simpleFraNode.Attributes["href"] != null || simpleFraNode.Attributes["id"] != null) 
                {
                    if (simpleFraNode.Attributes["id"] != null) 
                    {
                        simpleFraIDRef_ = simpleFraNode.Attributes["id"].Value;
                        SimpleFra ob = new SimpleFra(simpleFraNode);
                        IDManager.SetID(simpleFraIDRef_, ob);
                    }
                    else if (simpleFraNode.Attributes["href"] != null)
                    {
                        simpleFraIDRef_ = simpleFraNode.Attributes["href"].Value;
                    }
                    else
                    {
                        simpleFra_ = new SimpleFra(simpleFraNode);
                    }
                }
                else
                {
                    simpleFra_ = new SimpleFra(simpleFraNode);
                }
            }
            
        
            XmlNode simpleIrSwapNode = xmlNode.SelectSingleNode("simpleIrSwap");
            
            if (simpleIrSwapNode != null)
            {
                if (simpleIrSwapNode.Attributes["href"] != null || simpleIrSwapNode.Attributes["id"] != null) 
                {
                    if (simpleIrSwapNode.Attributes["id"] != null) 
                    {
                        simpleIrSwapIDRef_ = simpleIrSwapNode.Attributes["id"].Value;
                        SimpleIRSwap ob = new SimpleIRSwap(simpleIrSwapNode);
                        IDManager.SetID(simpleIrSwapIDRef_, ob);
                    }
                    else if (simpleIrSwapNode.Attributes["href"] != null)
                    {
                        simpleIrSwapIDRef_ = simpleIrSwapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        simpleIrSwap_ = new SimpleIRSwap(simpleIrSwapNode);
                    }
                }
                else
                {
                    simpleIrSwap_ = new SimpleIRSwap(simpleIrSwapNode);
                }
            }
            
        
        }
        
    
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
        #region CurveInstrument_
        private Asset curveInstrument_;
        public Asset CurveInstrument_
        {
            get
            {
                if (this.curveInstrument_ != null)
                {
                    return this.curveInstrument_; 
                }
                else if (this.curveInstrumentIDRef_ != null)
                {
                    curveInstrument_ = IDManager.getID(curveInstrumentIDRef_) as Asset;
                    return this.curveInstrument_; 
                }
                else
                {
                      return this.curveInstrument_; 
                }
            }
            set
            {
                if (this.curveInstrument_ != value)
                {
                    this.curveInstrument_ = value;
                }
            }
        }
        #endregion
        
        public string curveInstrumentIDRef_ { get; set; }
        #region Deposit_
        private Deposit deposit_;
        public Deposit Deposit_
        {
            get
            {
                if (this.deposit_ != null)
                {
                    return this.deposit_; 
                }
                else if (this.depositIDRef_ != null)
                {
                    deposit_ = IDManager.getID(depositIDRef_) as Deposit;
                    return this.deposit_; 
                }
                else
                {
                      return this.deposit_; 
                }
            }
            set
            {
                if (this.deposit_ != value)
                {
                    this.deposit_ = value;
                }
            }
        }
        #endregion
        
        public string depositIDRef_ { get; set; }     // substitude
        #region Fx_
        private FxRateAsset fx_;
        public FxRateAsset Fx_
        {
            get
            {
                if (this.fx_ != null)
                {
                    return this.fx_; 
                }
                else if (this.fxIDRef_ != null)
                {
                    fx_ = IDManager.getID(fxIDRef_) as FxRateAsset;
                    return this.fx_; 
                }
                else
                {
                      return this.fx_; 
                }
            }
            set
            {
                if (this.fx_ != value)
                {
                    this.fx_ = value;
                }
            }
        }
        #endregion
        
        public string fxIDRef_ { get; set; }     // substitude
        #region RateIndex_
        private RateIndex rateIndex_;
        public RateIndex RateIndex_
        {
            get
            {
                if (this.rateIndex_ != null)
                {
                    return this.rateIndex_; 
                }
                else if (this.rateIndexIDRef_ != null)
                {
                    rateIndex_ = IDManager.getID(rateIndexIDRef_) as RateIndex;
                    return this.rateIndex_; 
                }
                else
                {
                      return this.rateIndex_; 
                }
            }
            set
            {
                if (this.rateIndex_ != value)
                {
                    this.rateIndex_ = value;
                }
            }
        }
        #endregion
        
        public string rateIndexIDRef_ { get; set; }     // substitude
        #region SimpleCreditDefaultSwap_
        private SimpleCreditDefaultSwap simpleCreditDefaultSwap_;
        public SimpleCreditDefaultSwap SimpleCreditDefaultSwap_
        {
            get
            {
                if (this.simpleCreditDefaultSwap_ != null)
                {
                    return this.simpleCreditDefaultSwap_; 
                }
                else if (this.simpleCreditDefaultSwapIDRef_ != null)
                {
                    simpleCreditDefaultSwap_ = IDManager.getID(simpleCreditDefaultSwapIDRef_) as SimpleCreditDefaultSwap;
                    return this.simpleCreditDefaultSwap_; 
                }
                else
                {
                      return this.simpleCreditDefaultSwap_; 
                }
            }
            set
            {
                if (this.simpleCreditDefaultSwap_ != value)
                {
                    this.simpleCreditDefaultSwap_ = value;
                }
            }
        }
        #endregion
        
        public string simpleCreditDefaultSwapIDRef_ { get; set; }     // substitude
        #region SimpleFra_
        private SimpleFra simpleFra_;
        public SimpleFra SimpleFra_
        {
            get
            {
                if (this.simpleFra_ != null)
                {
                    return this.simpleFra_; 
                }
                else if (this.simpleFraIDRef_ != null)
                {
                    simpleFra_ = IDManager.getID(simpleFraIDRef_) as SimpleFra;
                    return this.simpleFra_; 
                }
                else
                {
                      return this.simpleFra_; 
                }
            }
            set
            {
                if (this.simpleFra_ != value)
                {
                    this.simpleFra_ = value;
                }
            }
        }
        #endregion
        
        public string simpleFraIDRef_ { get; set; }     // substitude
        #region SimpleIrSwap_
        private SimpleIRSwap simpleIrSwap_;
        public SimpleIRSwap SimpleIrSwap_
        {
            get
            {
                if (this.simpleIrSwap_ != null)
                {
                    return this.simpleIrSwap_; 
                }
                else if (this.simpleIrSwapIDRef_ != null)
                {
                    simpleIrSwap_ = IDManager.getID(simpleIrSwapIDRef_) as SimpleIRSwap;
                    return this.simpleIrSwap_; 
                }
                else
                {
                      return this.simpleIrSwap_; 
                }
            }
            set
            {
                if (this.simpleIrSwap_ != value)
                {
                    this.simpleIrSwap_ = value;
                }
            }
        }
        #endregion
        
        public string simpleIrSwapIDRef_ { get; set; }     // substitude
        public string choiceStr_0;
        
    
        
    
    }
    
}

