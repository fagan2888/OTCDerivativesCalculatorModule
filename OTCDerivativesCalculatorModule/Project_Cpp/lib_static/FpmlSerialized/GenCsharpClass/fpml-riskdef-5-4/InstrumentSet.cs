using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class InstrumentSet
    {
        public InstrumentSet(XmlNode xmlNode)
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
            
        
            XmlNodeList curveInstrumentNodeList = xmlNode.SelectNodes("curveInstrument");
            if (curveInstrumentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in curveInstrumentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        curveInstrumentIDRef = item.Attributes["id"].Name;
                        Asset ob = Asset();
                        IDManager.SetID(curveInstrumentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        curveInstrumentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        curveInstrument = new Asset(item);
                    }
                }
            }
            
        
            XmlNodeList depositNodeList = xmlNode.SelectNodes("deposit");
            if (depositNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in depositNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        depositIDRef = item.Attributes["id"].Name;
                        Deposit ob = Deposit();
                        IDManager.SetID(depositIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        depositIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deposit = new Deposit(item);
                    }
                }
            }
            
        
            XmlNodeList fxNodeList = xmlNode.SelectNodes("fx");
            if (fxNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxIDRef = item.Attributes["id"].Name;
                        FxRateAsset ob = FxRateAsset();
                        IDManager.SetID(fxIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fx = new FxRateAsset(item);
                    }
                }
            }
            
        
            XmlNodeList rateIndexNodeList = xmlNode.SelectNodes("rateIndex");
            if (rateIndexNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rateIndexNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateIndexIDRef = item.Attributes["id"].Name;
                        RateIndex ob = RateIndex();
                        IDManager.SetID(rateIndexIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateIndexIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rateIndex = new RateIndex(item);
                    }
                }
            }
            
        
            XmlNodeList simpleCreditDefaultSwapNodeList = xmlNode.SelectNodes("simpleCreditDefaultSwap");
            if (simpleCreditDefaultSwapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in simpleCreditDefaultSwapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        simpleCreditDefaultSwapIDRef = item.Attributes["id"].Name;
                        SimpleCreditDefaultSwap ob = SimpleCreditDefaultSwap();
                        IDManager.SetID(simpleCreditDefaultSwapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        simpleCreditDefaultSwapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        simpleCreditDefaultSwap = new SimpleCreditDefaultSwap(item);
                    }
                }
            }
            
        
            XmlNodeList simpleFraNodeList = xmlNode.SelectNodes("simpleFra");
            if (simpleFraNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in simpleFraNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        simpleFraIDRef = item.Attributes["id"].Name;
                        SimpleFra ob = SimpleFra();
                        IDManager.SetID(simpleFraIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        simpleFraIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        simpleFra = new SimpleFra(item);
                    }
                }
            }
            
        
            XmlNodeList simpleIrSwapNodeList = xmlNode.SelectNodes("simpleIrSwap");
            if (simpleIrSwapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in simpleIrSwapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        simpleIrSwapIDRef = item.Attributes["id"].Name;
                        SimpleIRSwap ob = SimpleIRSwap();
                        IDManager.SetID(simpleIrSwapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        simpleIrSwapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        simpleIrSwap = new SimpleIRSwap(item);
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
        #region CurveInstrument
        private Asset curveInstrument;
        public Asset CurveInstrument
        {
            get
            {
                if (this.curveInstrument != null)
                {
                    return this.curveInstrument; 
                }
                else if (this.curveInstrumentIDRef != null)
                {
                    curveInstrument = IDManager.getID(curveInstrumentIDRef) as Asset;
                    return this.curveInstrument; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.curveInstrument != value)
                {
                    this.curveInstrument = value;
                }
            }
        }
        #endregion
        
        public string AssetIDRef { get; set; }
        #region Deposit
        private Deposit deposit;
        public Deposit Deposit
        {
            get
            {
                if (this.deposit != null)
                {
                    return this.deposit; 
                }
                else if (this.depositIDRef != null)
                {
                    deposit = IDManager.getID(depositIDRef) as Deposit;
                    return this.deposit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deposit != value)
                {
                    this.deposit = value;
                }
            }
        }
        #endregion
        
        public string DepositIDRef { get; set; }     // substitude
        #region Fx
        private FxRateAsset fx;
        public FxRateAsset Fx
        {
            get
            {
                if (this.fx != null)
                {
                    return this.fx; 
                }
                else if (this.fxIDRef != null)
                {
                    fx = IDManager.getID(fxIDRef) as FxRateAsset;
                    return this.fx; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fx != value)
                {
                    this.fx = value;
                }
            }
        }
        #endregion
        
        public string FxRateAssetIDRef { get; set; }     // substitude
        #region RateIndex
        private RateIndex rateIndex;
        public RateIndex RateIndex
        {
            get
            {
                if (this.rateIndex != null)
                {
                    return this.rateIndex; 
                }
                else if (this.rateIndexIDRef != null)
                {
                    rateIndex = IDManager.getID(rateIndexIDRef) as RateIndex;
                    return this.rateIndex; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rateIndex != value)
                {
                    this.rateIndex = value;
                }
            }
        }
        #endregion
        
        public string RateIndexIDRef { get; set; }     // substitude
        #region SimpleCreditDefaultSwap
        private SimpleCreditDefaultSwap simpleCreditDefaultSwap;
        public SimpleCreditDefaultSwap SimpleCreditDefaultSwap
        {
            get
            {
                if (this.simpleCreditDefaultSwap != null)
                {
                    return this.simpleCreditDefaultSwap; 
                }
                else if (this.simpleCreditDefaultSwapIDRef != null)
                {
                    simpleCreditDefaultSwap = IDManager.getID(simpleCreditDefaultSwapIDRef) as SimpleCreditDefaultSwap;
                    return this.simpleCreditDefaultSwap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.simpleCreditDefaultSwap != value)
                {
                    this.simpleCreditDefaultSwap = value;
                }
            }
        }
        #endregion
        
        public string SimpleCreditDefaultSwapIDRef { get; set; }     // substitude
        #region SimpleFra
        private SimpleFra simpleFra;
        public SimpleFra SimpleFra
        {
            get
            {
                if (this.simpleFra != null)
                {
                    return this.simpleFra; 
                }
                else if (this.simpleFraIDRef != null)
                {
                    simpleFra = IDManager.getID(simpleFraIDRef) as SimpleFra;
                    return this.simpleFra; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.simpleFra != value)
                {
                    this.simpleFra = value;
                }
            }
        }
        #endregion
        
        public string SimpleFraIDRef { get; set; }     // substitude
        #region SimpleIrSwap
        private SimpleIRSwap simpleIrSwap;
        public SimpleIRSwap SimpleIrSwap
        {
            get
            {
                if (this.simpleIrSwap != null)
                {
                    return this.simpleIrSwap; 
                }
                else if (this.simpleIrSwapIDRef != null)
                {
                    simpleIrSwap = IDManager.getID(simpleIrSwapIDRef) as SimpleIRSwap;
                    return this.simpleIrSwap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.simpleIrSwap != value)
                {
                    this.simpleIrSwap = value;
                }
            }
        }
        #endregion
        
        public string SimpleIRSwapIDRef { get; set; }     // substitude
        public string choiceStr_0;
        
    
        
    
    }
    
}

