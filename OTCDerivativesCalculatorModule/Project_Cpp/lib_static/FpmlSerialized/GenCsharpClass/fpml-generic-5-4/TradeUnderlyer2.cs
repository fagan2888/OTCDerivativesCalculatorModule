using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TradeUnderlyer2
    {
        public TradeUnderlyer2(XmlNode xmlNode)
        {
            XmlNodeList floatingRateNodeList = xmlNode.SelectNodes("floatingRate");
            if (floatingRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in floatingRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floatingRateIDRef = item.Attributes["id"].Name;
                        FloatingRate ob = FloatingRate();
                        IDManager.SetID(floatingRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floatingRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        floatingRate = new FloatingRate(item);
                    }
                }
            }
            
        
            XmlNodeList fixedRateNodeList = xmlNode.SelectNodes("fixedRate");
            if (fixedRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedRateIDRef = item.Attributes["id"].Name;
                        Schedule ob = Schedule();
                        IDManager.SetID(fixedRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedRate = new Schedule(item);
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
            
        
            XmlNodeList quotedCurrencyPairNodeList = xmlNode.SelectNodes("quotedCurrencyPair");
            if (quotedCurrencyPairNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quotedCurrencyPairNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quotedCurrencyPairIDRef = item.Attributes["id"].Name;
                        QuotedCurrencyPair ob = QuotedCurrencyPair();
                        IDManager.SetID(quotedCurrencyPairIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quotedCurrencyPairIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quotedCurrencyPair = new QuotedCurrencyPair(item);
                    }
                }
            }
            
        
            XmlNodeList referenceEntityNodeList = xmlNode.SelectNodes("referenceEntity");
            if (referenceEntityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referenceEntityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceEntityIDRef = item.Attributes["id"].Name;
                        LegalEntity ob = LegalEntity();
                        IDManager.SetID(referenceEntityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceEntityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referenceEntity = new LegalEntity(item);
                    }
                }
            }
            
        
            XmlNodeList payerPartyReferenceNodeList = xmlNode.SelectNodes("payerPartyReference");
            if (payerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in payerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        payerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(payerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        payerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList payerAccountReferenceNodeList = xmlNode.SelectNodes("payerAccountReference");
            if (payerAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in payerAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        payerAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(payerAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        payerAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payerAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList receiverPartyReferenceNodeList = xmlNode.SelectNodes("receiverPartyReference");
            if (receiverPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in receiverPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        receiverPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(receiverPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        receiverPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        receiverPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList receiverAccountReferenceNodeList = xmlNode.SelectNodes("receiverAccountReference");
            if (receiverAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in receiverAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        receiverAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(receiverAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        receiverAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        receiverAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region FloatingRate
        private FloatingRate floatingRate;
        public FloatingRate FloatingRate
        {
            get
            {
                if (this.floatingRate != null)
                {
                    return this.floatingRate; 
                }
                else if (this.floatingRateIDRef != null)
                {
                    floatingRate = IDManager.getID(floatingRateIDRef) as FloatingRate;
                    return this.floatingRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floatingRate != value)
                {
                    this.floatingRate = value;
                }
            }
        }
        #endregion
        
        public string FloatingRateIDRef { get; set; }
        #region FixedRate
        private Schedule fixedRate;
        public Schedule FixedRate
        {
            get
            {
                if (this.fixedRate != null)
                {
                    return this.fixedRate; 
                }
                else if (this.fixedRateIDRef != null)
                {
                    fixedRate = IDManager.getID(fixedRateIDRef) as Schedule;
                    return this.fixedRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedRate != value)
                {
                    this.fixedRate = value;
                }
            }
        }
        #endregion
        
        public string ScheduleIDRef { get; set; }
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
        #region QuotedCurrencyPair
        private QuotedCurrencyPair quotedCurrencyPair;
        public QuotedCurrencyPair QuotedCurrencyPair
        {
            get
            {
                if (this.quotedCurrencyPair != null)
                {
                    return this.quotedCurrencyPair; 
                }
                else if (this.quotedCurrencyPairIDRef != null)
                {
                    quotedCurrencyPair = IDManager.getID(quotedCurrencyPairIDRef) as QuotedCurrencyPair;
                    return this.quotedCurrencyPair; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quotedCurrencyPair != value)
                {
                    this.quotedCurrencyPair = value;
                }
            }
        }
        #endregion
        
        public string QuotedCurrencyPairIDRef { get; set; }
        #region ReferenceEntity
        private LegalEntity referenceEntity;
        public LegalEntity ReferenceEntity
        {
            get
            {
                if (this.referenceEntity != null)
                {
                    return this.referenceEntity; 
                }
                else if (this.referenceEntityIDRef != null)
                {
                    referenceEntity = IDManager.getID(referenceEntityIDRef) as LegalEntity;
                    return this.referenceEntity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceEntity != value)
                {
                    this.referenceEntity = value;
                }
            }
        }
        #endregion
        
        public string LegalEntityIDRef { get; set; }
        #region PayerPartyReference
        private PartyReference payerPartyReference;
        public PartyReference PayerPartyReference
        {
            get
            {
                if (this.payerPartyReference != null)
                {
                    return this.payerPartyReference; 
                }
                else if (this.payerPartyReferenceIDRef != null)
                {
                    payerPartyReference = IDManager.getID(payerPartyReferenceIDRef) as PartyReference;
                    return this.payerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payerPartyReference != value)
                {
                    this.payerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region PayerAccountReference
        private AccountReference payerAccountReference;
        public AccountReference PayerAccountReference
        {
            get
            {
                if (this.payerAccountReference != null)
                {
                    return this.payerAccountReference; 
                }
                else if (this.payerAccountReferenceIDRef != null)
                {
                    payerAccountReference = IDManager.getID(payerAccountReferenceIDRef) as AccountReference;
                    return this.payerAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payerAccountReference != value)
                {
                    this.payerAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region ReceiverPartyReference
        private PartyReference receiverPartyReference;
        public PartyReference ReceiverPartyReference
        {
            get
            {
                if (this.receiverPartyReference != null)
                {
                    return this.receiverPartyReference; 
                }
                else if (this.receiverPartyReferenceIDRef != null)
                {
                    receiverPartyReference = IDManager.getID(receiverPartyReferenceIDRef) as PartyReference;
                    return this.receiverPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.receiverPartyReference != value)
                {
                    this.receiverPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region ReceiverAccountReference
        private AccountReference receiverAccountReference;
        public AccountReference ReceiverAccountReference
        {
            get
            {
                if (this.receiverAccountReference != null)
                {
                    return this.receiverAccountReference; 
                }
                else if (this.receiverAccountReferenceIDRef != null)
                {
                    receiverAccountReference = IDManager.getID(receiverAccountReferenceIDRef) as AccountReference;
                    return this.receiverAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.receiverAccountReference != value)
                {
                    this.receiverAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

