using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BasketConstituent
    {
        public BasketConstituent(XmlNode xmlNode)
        {
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
            
        
            XmlNodeList constituentWeightNodeList = xmlNode.SelectNodes("constituentWeight");
            if (constituentWeightNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in constituentWeightNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        constituentWeightIDRef = item.Attributes["id"].Name;
                        ConstituentWeight ob = ConstituentWeight();
                        IDManager.SetID(constituentWeightIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        constituentWeightIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        constituentWeight = new ConstituentWeight(item);
                    }
                }
            }
            
        
            XmlNodeList dividendPayoutNodeList = xmlNode.SelectNodes("dividendPayout");
            if (dividendPayoutNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendPayoutNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendPayoutIDRef = item.Attributes["id"].Name;
                        DividendPayout ob = DividendPayout();
                        IDManager.SetID(dividendPayoutIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendPayoutIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendPayout = new DividendPayout(item);
                    }
                }
            }
            
        
            XmlNodeList underlyerPriceNodeList = xmlNode.SelectNodes("underlyerPrice");
            if (underlyerPriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in underlyerPriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        underlyerPriceIDRef = item.Attributes["id"].Name;
                        Price ob = Price();
                        IDManager.SetID(underlyerPriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        underlyerPriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        underlyerPrice = new Price(item);
                    }
                }
            }
            
        
            XmlNodeList underlyerNotionalNodeList = xmlNode.SelectNodes("underlyerNotional");
            if (underlyerNotionalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in underlyerNotionalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        underlyerNotionalIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(underlyerNotionalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        underlyerNotionalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        underlyerNotional = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList underlyerSpreadNodeList = xmlNode.SelectNodes("underlyerSpread");
            if (underlyerSpreadNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in underlyerSpreadNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        underlyerSpreadIDRef = item.Attributes["id"].Name;
                        SpreadScheduleReference ob = SpreadScheduleReference();
                        IDManager.SetID(underlyerSpreadIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        underlyerSpreadIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        underlyerSpread = new SpreadScheduleReference(item);
                    }
                }
            }
            
        
            XmlNodeList couponPaymentNodeList = xmlNode.SelectNodes("couponPayment");
            if (couponPaymentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in couponPaymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        couponPaymentIDRef = item.Attributes["id"].Name;
                        PendingPayment ob = PendingPayment();
                        IDManager.SetID(couponPaymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        couponPaymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        couponPayment = new PendingPayment(item);
                    }
                }
            }
            
        
        }
        
    
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
        #region ConstituentWeight
        private ConstituentWeight constituentWeight;
        public ConstituentWeight ConstituentWeight
        {
            get
            {
                if (this.constituentWeight != null)
                {
                    return this.constituentWeight; 
                }
                else if (this.constituentWeightIDRef != null)
                {
                    constituentWeight = IDManager.getID(constituentWeightIDRef) as ConstituentWeight;
                    return this.constituentWeight; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.constituentWeight != value)
                {
                    this.constituentWeight = value;
                }
            }
        }
        #endregion
        
        public string ConstituentWeightIDRef { get; set; }
        #region DividendPayout
        private DividendPayout dividendPayout;
        public DividendPayout DividendPayout
        {
            get
            {
                if (this.dividendPayout != null)
                {
                    return this.dividendPayout; 
                }
                else if (this.dividendPayoutIDRef != null)
                {
                    dividendPayout = IDManager.getID(dividendPayoutIDRef) as DividendPayout;
                    return this.dividendPayout; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendPayout != value)
                {
                    this.dividendPayout = value;
                }
            }
        }
        #endregion
        
        public string DividendPayoutIDRef { get; set; }
        #region UnderlyerPrice
        private Price underlyerPrice;
        public Price UnderlyerPrice
        {
            get
            {
                if (this.underlyerPrice != null)
                {
                    return this.underlyerPrice; 
                }
                else if (this.underlyerPriceIDRef != null)
                {
                    underlyerPrice = IDManager.getID(underlyerPriceIDRef) as Price;
                    return this.underlyerPrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.underlyerPrice != value)
                {
                    this.underlyerPrice = value;
                }
            }
        }
        #endregion
        
        public string PriceIDRef { get; set; }
        #region UnderlyerNotional
        private Money underlyerNotional;
        public Money UnderlyerNotional
        {
            get
            {
                if (this.underlyerNotional != null)
                {
                    return this.underlyerNotional; 
                }
                else if (this.underlyerNotionalIDRef != null)
                {
                    underlyerNotional = IDManager.getID(underlyerNotionalIDRef) as Money;
                    return this.underlyerNotional; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.underlyerNotional != value)
                {
                    this.underlyerNotional = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region UnderlyerSpread
        private SpreadScheduleReference underlyerSpread;
        public SpreadScheduleReference UnderlyerSpread
        {
            get
            {
                if (this.underlyerSpread != null)
                {
                    return this.underlyerSpread; 
                }
                else if (this.underlyerSpreadIDRef != null)
                {
                    underlyerSpread = IDManager.getID(underlyerSpreadIDRef) as SpreadScheduleReference;
                    return this.underlyerSpread; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.underlyerSpread != value)
                {
                    this.underlyerSpread = value;
                }
            }
        }
        #endregion
        
        public string SpreadScheduleReferenceIDRef { get; set; }
        #region CouponPayment
        private PendingPayment couponPayment;
        public PendingPayment CouponPayment
        {
            get
            {
                if (this.couponPayment != null)
                {
                    return this.couponPayment; 
                }
                else if (this.couponPaymentIDRef != null)
                {
                    couponPayment = IDManager.getID(couponPaymentIDRef) as PendingPayment;
                    return this.couponPayment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.couponPayment != value)
                {
                    this.couponPayment = value;
                }
            }
        }
        #endregion
        
        public string PendingPaymentIDRef { get; set; }
        
    
        
    
    }
    
}

