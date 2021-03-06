using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SingleUnderlyer
    {
        public SingleUnderlyer(XmlNode xmlNode)
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
            
        
            XmlNodeList openUnitsNodeList = xmlNode.SelectNodes("openUnits");
            if (openUnitsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in openUnitsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        openUnitsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(openUnitsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        openUnitsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        openUnits = new XsdTypeDecimal(item);
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
            
        
            XmlNodeList averageDailyTradingVolumeNodeList = xmlNode.SelectNodes("averageDailyTradingVolume");
            if (averageDailyTradingVolumeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in averageDailyTradingVolumeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averageDailyTradingVolumeIDRef = item.Attributes["id"].Name;
                        AverageDailyTradingVolumeLimit ob = AverageDailyTradingVolumeLimit();
                        IDManager.SetID(averageDailyTradingVolumeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averageDailyTradingVolumeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        averageDailyTradingVolume = new AverageDailyTradingVolumeLimit(item);
                    }
                }
            }
            
        
            XmlNodeList depositoryReceiptNodeList = xmlNode.SelectNodes("depositoryReceipt");
            if (depositoryReceiptNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in depositoryReceiptNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        depositoryReceiptIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(depositoryReceiptIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        depositoryReceiptIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        depositoryReceipt = new XsdTypeBoolean(item);
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
        #region OpenUnits
        private XsdTypeDecimal openUnits;
        public XsdTypeDecimal OpenUnits
        {
            get
            {
                if (this.openUnits != null)
                {
                    return this.openUnits; 
                }
                else if (this.openUnitsIDRef != null)
                {
                    openUnits = IDManager.getID(openUnitsIDRef) as XsdTypeDecimal;
                    return this.openUnits; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.openUnits != value)
                {
                    this.openUnits = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
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
        #region AverageDailyTradingVolume
        private AverageDailyTradingVolumeLimit averageDailyTradingVolume;
        public AverageDailyTradingVolumeLimit AverageDailyTradingVolume
        {
            get
            {
                if (this.averageDailyTradingVolume != null)
                {
                    return this.averageDailyTradingVolume; 
                }
                else if (this.averageDailyTradingVolumeIDRef != null)
                {
                    averageDailyTradingVolume = IDManager.getID(averageDailyTradingVolumeIDRef) as AverageDailyTradingVolumeLimit;
                    return this.averageDailyTradingVolume; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averageDailyTradingVolume != value)
                {
                    this.averageDailyTradingVolume = value;
                }
            }
        }
        #endregion
        
        public string AverageDailyTradingVolumeLimitIDRef { get; set; }
        #region DepositoryReceipt
        private XsdTypeBoolean depositoryReceipt;
        public XsdTypeBoolean DepositoryReceipt
        {
            get
            {
                if (this.depositoryReceipt != null)
                {
                    return this.depositoryReceipt; 
                }
                else if (this.depositoryReceiptIDRef != null)
                {
                    depositoryReceipt = IDManager.getID(depositoryReceiptIDRef) as XsdTypeBoolean;
                    return this.depositoryReceipt; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.depositoryReceipt != value)
                {
                    this.depositoryReceipt = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

