using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class InstrumentTradeDetails
    {
        public InstrumentTradeDetails(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList buyerPartyReferenceNodeList = xmlNode.SelectNodes("buyerPartyReference");
            if (buyerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in buyerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        buyerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(buyerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        buyerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        buyerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList buyerAccountReferenceNodeList = xmlNode.SelectNodes("buyerAccountReference");
            if (buyerAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in buyerAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        buyerAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(buyerAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        buyerAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        buyerAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList sellerPartyReferenceNodeList = xmlNode.SelectNodes("sellerPartyReference");
            if (sellerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sellerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sellerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(sellerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sellerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sellerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList sellerAccountReferenceNodeList = xmlNode.SelectNodes("sellerAccountReference");
            if (sellerAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sellerAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sellerAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(sellerAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sellerAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sellerAccountReference = new AccountReference(item);
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
            
        
            XmlNodeList quantityNodeList = xmlNode.SelectNodes("quantity");
            if (quantityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quantityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quantityIDRef = item.Attributes["id"].Name;
                        InstrumentTradeQuantity ob = InstrumentTradeQuantity();
                        IDManager.SetID(quantityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quantityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quantity = new InstrumentTradeQuantity(item);
                    }
                }
            }
            
        
            XmlNodeList pricingNodeList = xmlNode.SelectNodes("pricing");
            if (pricingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in pricingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pricingIDRef = item.Attributes["id"].Name;
                        InstrumentTradePricing ob = InstrumentTradePricing();
                        IDManager.SetID(pricingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pricingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        pricing = new InstrumentTradePricing(item);
                    }
                }
            }
            
        
            XmlNodeList principalNodeList = xmlNode.SelectNodes("principal");
            if (principalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in principalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        principalIDRef = item.Attributes["id"].Name;
                        InstrumentTradePrincipal ob = InstrumentTradePrincipal();
                        IDManager.SetID(principalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        principalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        principal = new InstrumentTradePrincipal(item);
                    }
                }
            }
            
        
        }
        
    
        #region BuyerPartyReference
        private PartyReference buyerPartyReference;
        public PartyReference BuyerPartyReference
        {
            get
            {
                if (this.buyerPartyReference != null)
                {
                    return this.buyerPartyReference; 
                }
                else if (this.buyerPartyReferenceIDRef != null)
                {
                    buyerPartyReference = IDManager.getID(buyerPartyReferenceIDRef) as PartyReference;
                    return this.buyerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.buyerPartyReference != value)
                {
                    this.buyerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region BuyerAccountReference
        private AccountReference buyerAccountReference;
        public AccountReference BuyerAccountReference
        {
            get
            {
                if (this.buyerAccountReference != null)
                {
                    return this.buyerAccountReference; 
                }
                else if (this.buyerAccountReferenceIDRef != null)
                {
                    buyerAccountReference = IDManager.getID(buyerAccountReferenceIDRef) as AccountReference;
                    return this.buyerAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.buyerAccountReference != value)
                {
                    this.buyerAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region SellerPartyReference
        private PartyReference sellerPartyReference;
        public PartyReference SellerPartyReference
        {
            get
            {
                if (this.sellerPartyReference != null)
                {
                    return this.sellerPartyReference; 
                }
                else if (this.sellerPartyReferenceIDRef != null)
                {
                    sellerPartyReference = IDManager.getID(sellerPartyReferenceIDRef) as PartyReference;
                    return this.sellerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sellerPartyReference != value)
                {
                    this.sellerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region SellerAccountReference
        private AccountReference sellerAccountReference;
        public AccountReference SellerAccountReference
        {
            get
            {
                if (this.sellerAccountReference != null)
                {
                    return this.sellerAccountReference; 
                }
                else if (this.sellerAccountReferenceIDRef != null)
                {
                    sellerAccountReference = IDManager.getID(sellerAccountReferenceIDRef) as AccountReference;
                    return this.sellerAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sellerAccountReference != value)
                {
                    this.sellerAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
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
        #region Quantity
        private InstrumentTradeQuantity quantity;
        public InstrumentTradeQuantity Quantity
        {
            get
            {
                if (this.quantity != null)
                {
                    return this.quantity; 
                }
                else if (this.quantityIDRef != null)
                {
                    quantity = IDManager.getID(quantityIDRef) as InstrumentTradeQuantity;
                    return this.quantity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quantity != value)
                {
                    this.quantity = value;
                }
            }
        }
        #endregion
        
        public string InstrumentTradeQuantityIDRef { get; set; }
        #region Pricing
        private InstrumentTradePricing pricing;
        public InstrumentTradePricing Pricing
        {
            get
            {
                if (this.pricing != null)
                {
                    return this.pricing; 
                }
                else if (this.pricingIDRef != null)
                {
                    pricing = IDManager.getID(pricingIDRef) as InstrumentTradePricing;
                    return this.pricing; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pricing != value)
                {
                    this.pricing = value;
                }
            }
        }
        #endregion
        
        public string InstrumentTradePricingIDRef { get; set; }
        #region Principal
        private InstrumentTradePrincipal principal;
        public InstrumentTradePrincipal Principal
        {
            get
            {
                if (this.principal != null)
                {
                    return this.principal; 
                }
                else if (this.principalIDRef != null)
                {
                    principal = IDManager.getID(principalIDRef) as InstrumentTradePrincipal;
                    return this.principal; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.principal != value)
                {
                    this.principal = value;
                }
            }
        }
        #endregion
        
        public string InstrumentTradePrincipalIDRef { get; set; }
        
    
        
    
    }
    
}

