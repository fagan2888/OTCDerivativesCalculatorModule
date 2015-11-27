using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BasketConstituent : ISerialized
    {
        public BasketConstituent(XmlNode xmlNode)
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
            
        
            XmlNode constituentWeightNode = xmlNode.SelectSingleNode("constituentWeight");
            
            if (constituentWeightNode != null)
            {
                if (constituentWeightNode.Attributes["href"] != null || constituentWeightNode.Attributes["id"] != null) 
                {
                    if (constituentWeightNode.Attributes["id"] != null) 
                    {
                        constituentWeightIDRef_ = constituentWeightNode.Attributes["id"].Value;
                        ConstituentWeight ob = new ConstituentWeight(constituentWeightNode);
                        IDManager.SetID(constituentWeightIDRef_, ob);
                    }
                    else if (constituentWeightNode.Attributes["href"] != null)
                    {
                        constituentWeightIDRef_ = constituentWeightNode.Attributes["href"].Value;
                    }
                    else
                    {
                        constituentWeight_ = new ConstituentWeight(constituentWeightNode);
                    }
                }
                else
                {
                    constituentWeight_ = new ConstituentWeight(constituentWeightNode);
                }
            }
            
        
            XmlNode dividendPayoutNode = xmlNode.SelectSingleNode("dividendPayout");
            
            if (dividendPayoutNode != null)
            {
                if (dividendPayoutNode.Attributes["href"] != null || dividendPayoutNode.Attributes["id"] != null) 
                {
                    if (dividendPayoutNode.Attributes["id"] != null) 
                    {
                        dividendPayoutIDRef_ = dividendPayoutNode.Attributes["id"].Value;
                        DividendPayout ob = new DividendPayout(dividendPayoutNode);
                        IDManager.SetID(dividendPayoutIDRef_, ob);
                    }
                    else if (dividendPayoutNode.Attributes["href"] != null)
                    {
                        dividendPayoutIDRef_ = dividendPayoutNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendPayout_ = new DividendPayout(dividendPayoutNode);
                    }
                }
                else
                {
                    dividendPayout_ = new DividendPayout(dividendPayoutNode);
                }
            }
            
        
            XmlNode underlyerPriceNode = xmlNode.SelectSingleNode("underlyerPrice");
            
            if (underlyerPriceNode != null)
            {
                if (underlyerPriceNode.Attributes["href"] != null || underlyerPriceNode.Attributes["id"] != null) 
                {
                    if (underlyerPriceNode.Attributes["id"] != null) 
                    {
                        underlyerPriceIDRef_ = underlyerPriceNode.Attributes["id"].Value;
                        Price ob = new Price(underlyerPriceNode);
                        IDManager.SetID(underlyerPriceIDRef_, ob);
                    }
                    else if (underlyerPriceNode.Attributes["href"] != null)
                    {
                        underlyerPriceIDRef_ = underlyerPriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underlyerPrice_ = new Price(underlyerPriceNode);
                    }
                }
                else
                {
                    underlyerPrice_ = new Price(underlyerPriceNode);
                }
            }
            
        
            XmlNode underlyerNotionalNode = xmlNode.SelectSingleNode("underlyerNotional");
            
            if (underlyerNotionalNode != null)
            {
                if (underlyerNotionalNode.Attributes["href"] != null || underlyerNotionalNode.Attributes["id"] != null) 
                {
                    if (underlyerNotionalNode.Attributes["id"] != null) 
                    {
                        underlyerNotionalIDRef_ = underlyerNotionalNode.Attributes["id"].Value;
                        Money ob = new Money(underlyerNotionalNode);
                        IDManager.SetID(underlyerNotionalIDRef_, ob);
                    }
                    else if (underlyerNotionalNode.Attributes["href"] != null)
                    {
                        underlyerNotionalIDRef_ = underlyerNotionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underlyerNotional_ = new Money(underlyerNotionalNode);
                    }
                }
                else
                {
                    underlyerNotional_ = new Money(underlyerNotionalNode);
                }
            }
            
        
            XmlNode underlyerSpreadNode = xmlNode.SelectSingleNode("underlyerSpread");
            
            if (underlyerSpreadNode != null)
            {
                if (underlyerSpreadNode.Attributes["href"] != null || underlyerSpreadNode.Attributes["id"] != null) 
                {
                    if (underlyerSpreadNode.Attributes["id"] != null) 
                    {
                        underlyerSpreadIDRef_ = underlyerSpreadNode.Attributes["id"].Value;
                        SpreadScheduleReference ob = new SpreadScheduleReference(underlyerSpreadNode);
                        IDManager.SetID(underlyerSpreadIDRef_, ob);
                    }
                    else if (underlyerSpreadNode.Attributes["href"] != null)
                    {
                        underlyerSpreadIDRef_ = underlyerSpreadNode.Attributes["href"].Value;
                    }
                    else
                    {
                        underlyerSpread_ = new SpreadScheduleReference(underlyerSpreadNode);
                    }
                }
                else
                {
                    underlyerSpread_ = new SpreadScheduleReference(underlyerSpreadNode);
                }
            }
            
        
            XmlNode couponPaymentNode = xmlNode.SelectSingleNode("couponPayment");
            
            if (couponPaymentNode != null)
            {
                if (couponPaymentNode.Attributes["href"] != null || couponPaymentNode.Attributes["id"] != null) 
                {
                    if (couponPaymentNode.Attributes["id"] != null) 
                    {
                        couponPaymentIDRef_ = couponPaymentNode.Attributes["id"].Value;
                        PendingPayment ob = new PendingPayment(couponPaymentNode);
                        IDManager.SetID(couponPaymentIDRef_, ob);
                    }
                    else if (couponPaymentNode.Attributes["href"] != null)
                    {
                        couponPaymentIDRef_ = couponPaymentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        couponPayment_ = new PendingPayment(couponPaymentNode);
                    }
                }
                else
                {
                    couponPayment_ = new PendingPayment(couponPaymentNode);
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
        #region ConstituentWeight_
        private ConstituentWeight constituentWeight_;
        public ConstituentWeight ConstituentWeight_
        {
            get
            {
                if (this.constituentWeight_ != null)
                {
                    return this.constituentWeight_; 
                }
                else if (this.constituentWeightIDRef_ != null)
                {
                    constituentWeight_ = IDManager.getID(constituentWeightIDRef_) as ConstituentWeight;
                    return this.constituentWeight_; 
                }
                else
                {
                      return this.constituentWeight_; 
                }
            }
            set
            {
                if (this.constituentWeight_ != value)
                {
                    this.constituentWeight_ = value;
                }
            }
        }
        #endregion
        
        public string constituentWeightIDRef_ { get; set; }
        #region DividendPayout_
        private DividendPayout dividendPayout_;
        public DividendPayout DividendPayout_
        {
            get
            {
                if (this.dividendPayout_ != null)
                {
                    return this.dividendPayout_; 
                }
                else if (this.dividendPayoutIDRef_ != null)
                {
                    dividendPayout_ = IDManager.getID(dividendPayoutIDRef_) as DividendPayout;
                    return this.dividendPayout_; 
                }
                else
                {
                      return this.dividendPayout_; 
                }
            }
            set
            {
                if (this.dividendPayout_ != value)
                {
                    this.dividendPayout_ = value;
                }
            }
        }
        #endregion
        
        public string dividendPayoutIDRef_ { get; set; }
        #region UnderlyerPrice_
        private Price underlyerPrice_;
        public Price UnderlyerPrice_
        {
            get
            {
                if (this.underlyerPrice_ != null)
                {
                    return this.underlyerPrice_; 
                }
                else if (this.underlyerPriceIDRef_ != null)
                {
                    underlyerPrice_ = IDManager.getID(underlyerPriceIDRef_) as Price;
                    return this.underlyerPrice_; 
                }
                else
                {
                      return this.underlyerPrice_; 
                }
            }
            set
            {
                if (this.underlyerPrice_ != value)
                {
                    this.underlyerPrice_ = value;
                }
            }
        }
        #endregion
        
        public string underlyerPriceIDRef_ { get; set; }
        #region UnderlyerNotional_
        private Money underlyerNotional_;
        public Money UnderlyerNotional_
        {
            get
            {
                if (this.underlyerNotional_ != null)
                {
                    return this.underlyerNotional_; 
                }
                else if (this.underlyerNotionalIDRef_ != null)
                {
                    underlyerNotional_ = IDManager.getID(underlyerNotionalIDRef_) as Money;
                    return this.underlyerNotional_; 
                }
                else
                {
                      return this.underlyerNotional_; 
                }
            }
            set
            {
                if (this.underlyerNotional_ != value)
                {
                    this.underlyerNotional_ = value;
                }
            }
        }
        #endregion
        
        public string underlyerNotionalIDRef_ { get; set; }
        #region UnderlyerSpread_
        private SpreadScheduleReference underlyerSpread_;
        public SpreadScheduleReference UnderlyerSpread_
        {
            get
            {
                if (this.underlyerSpread_ != null)
                {
                    return this.underlyerSpread_; 
                }
                else if (this.underlyerSpreadIDRef_ != null)
                {
                    underlyerSpread_ = IDManager.getID(underlyerSpreadIDRef_) as SpreadScheduleReference;
                    return this.underlyerSpread_; 
                }
                else
                {
                      return this.underlyerSpread_; 
                }
            }
            set
            {
                if (this.underlyerSpread_ != value)
                {
                    this.underlyerSpread_ = value;
                }
            }
        }
        #endregion
        
        public string underlyerSpreadIDRef_ { get; set; }
        #region CouponPayment_
        private PendingPayment couponPayment_;
        public PendingPayment CouponPayment_
        {
            get
            {
                if (this.couponPayment_ != null)
                {
                    return this.couponPayment_; 
                }
                else if (this.couponPaymentIDRef_ != null)
                {
                    couponPayment_ = IDManager.getID(couponPaymentIDRef_) as PendingPayment;
                    return this.couponPayment_; 
                }
                else
                {
                      return this.couponPayment_; 
                }
            }
            set
            {
                if (this.couponPayment_ != value)
                {
                    this.couponPayment_ = value;
                }
            }
        }
        #endregion
        
        public string couponPaymentIDRef_ { get; set; }
        
    
        
    
    }
    
}

