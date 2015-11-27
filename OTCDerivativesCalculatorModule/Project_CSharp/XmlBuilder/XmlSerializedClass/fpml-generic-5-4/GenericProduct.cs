using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GenericProduct : Product
    {
        public GenericProduct(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode multiLegNode = xmlNode.SelectSingleNode("multiLeg");
            
            if (multiLegNode != null)
            {
                if (multiLegNode.Attributes["href"] != null || multiLegNode.Attributes["id"] != null) 
                {
                    if (multiLegNode.Attributes["id"] != null) 
                    {
                        multiLegIDRef_ = multiLegNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(multiLegNode);
                        IDManager.SetID(multiLegIDRef_, ob);
                    }
                    else if (multiLegNode.Attributes["href"] != null)
                    {
                        multiLegIDRef_ = multiLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        multiLeg_ = new XsdTypeBoolean(multiLegNode);
                    }
                }
                else
                {
                    multiLeg_ = new XsdTypeBoolean(multiLegNode);
                }
            }
            
        
            XmlNode buyerPartyReferenceNode = xmlNode.SelectSingleNode("buyerPartyReference");
            
            if (buyerPartyReferenceNode != null)
            {
                if (buyerPartyReferenceNode.Attributes["href"] != null || buyerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (buyerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        buyerPartyReferenceIDRef_ = buyerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(buyerPartyReferenceNode);
                        IDManager.SetID(buyerPartyReferenceIDRef_, ob);
                    }
                    else if (buyerPartyReferenceNode.Attributes["href"] != null)
                    {
                        buyerPartyReferenceIDRef_ = buyerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        buyerPartyReference_ = new PartyReference(buyerPartyReferenceNode);
                    }
                }
                else
                {
                    buyerPartyReference_ = new PartyReference(buyerPartyReferenceNode);
                }
            }
            
        
            XmlNode buyerAccountReferenceNode = xmlNode.SelectSingleNode("buyerAccountReference");
            
            if (buyerAccountReferenceNode != null)
            {
                if (buyerAccountReferenceNode.Attributes["href"] != null || buyerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (buyerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        buyerAccountReferenceIDRef_ = buyerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(buyerAccountReferenceNode);
                        IDManager.SetID(buyerAccountReferenceIDRef_, ob);
                    }
                    else if (buyerAccountReferenceNode.Attributes["href"] != null)
                    {
                        buyerAccountReferenceIDRef_ = buyerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        buyerAccountReference_ = new AccountReference(buyerAccountReferenceNode);
                    }
                }
                else
                {
                    buyerAccountReference_ = new AccountReference(buyerAccountReferenceNode);
                }
            }
            
        
            XmlNode sellerPartyReferenceNode = xmlNode.SelectSingleNode("sellerPartyReference");
            
            if (sellerPartyReferenceNode != null)
            {
                if (sellerPartyReferenceNode.Attributes["href"] != null || sellerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (sellerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        sellerPartyReferenceIDRef_ = sellerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(sellerPartyReferenceNode);
                        IDManager.SetID(sellerPartyReferenceIDRef_, ob);
                    }
                    else if (sellerPartyReferenceNode.Attributes["href"] != null)
                    {
                        sellerPartyReferenceIDRef_ = sellerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sellerPartyReference_ = new PartyReference(sellerPartyReferenceNode);
                    }
                }
                else
                {
                    sellerPartyReference_ = new PartyReference(sellerPartyReferenceNode);
                }
            }
            
        
            XmlNode sellerAccountReferenceNode = xmlNode.SelectSingleNode("sellerAccountReference");
            
            if (sellerAccountReferenceNode != null)
            {
                if (sellerAccountReferenceNode.Attributes["href"] != null || sellerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (sellerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        sellerAccountReferenceIDRef_ = sellerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(sellerAccountReferenceNode);
                        IDManager.SetID(sellerAccountReferenceIDRef_, ob);
                    }
                    else if (sellerAccountReferenceNode.Attributes["href"] != null)
                    {
                        sellerAccountReferenceIDRef_ = sellerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sellerAccountReference_ = new AccountReference(sellerAccountReferenceNode);
                    }
                }
                else
                {
                    sellerAccountReference_ = new AccountReference(sellerAccountReferenceNode);
                }
            }
            
        
            XmlNodeList counterpartyReferenceNodeList = xmlNode.SelectNodes("counterpartyReference");
            
            if (counterpartyReferenceNodeList != null)
            {
                this.counterpartyReference_ = new List<PartyReference>();
                foreach (XmlNode item in counterpartyReferenceNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            counterpartyReferenceIDRef_ = item.Attributes["id"].Value;
                            counterpartyReference_.Add(new PartyReference(item));
                            IDManager.SetID(counterpartyReferenceIDRef_, counterpartyReference_[counterpartyReference_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            counterpartyReferenceIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        counterpartyReference_.Add(new PartyReference(item));
                        }
                    }
                    else
                    {
                        counterpartyReference_.Add(new PartyReference(item));
                    }
                }
            }
            
        
            XmlNode premiumNode = xmlNode.SelectSingleNode("premium");
            
            if (premiumNode != null)
            {
                if (premiumNode.Attributes["href"] != null || premiumNode.Attributes["id"] != null) 
                {
                    if (premiumNode.Attributes["id"] != null) 
                    {
                        premiumIDRef_ = premiumNode.Attributes["id"].Value;
                        SimplePayment ob = new SimplePayment(premiumNode);
                        IDManager.SetID(premiumIDRef_, ob);
                    }
                    else if (premiumNode.Attributes["href"] != null)
                    {
                        premiumIDRef_ = premiumNode.Attributes["href"].Value;
                    }
                    else
                    {
                        premium_ = new SimplePayment(premiumNode);
                    }
                }
                else
                {
                    premium_ = new SimplePayment(premiumNode);
                }
            }
            
        
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        AdjustableDate2 ob = new AdjustableDate2(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new AdjustableDate2(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new AdjustableDate2(effectiveDateNode);
                }
            }
            
        
            XmlNode expirationDateNode = xmlNode.SelectSingleNode("expirationDate");
            
            if (expirationDateNode != null)
            {
                if (expirationDateNode.Attributes["href"] != null || expirationDateNode.Attributes["id"] != null) 
                {
                    if (expirationDateNode.Attributes["id"] != null) 
                    {
                        expirationDateIDRef_ = expirationDateNode.Attributes["id"].Value;
                        AdjustableDate2 ob = new AdjustableDate2(expirationDateNode);
                        IDManager.SetID(expirationDateIDRef_, ob);
                    }
                    else if (expirationDateNode.Attributes["href"] != null)
                    {
                        expirationDateIDRef_ = expirationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        expirationDate_ = new AdjustableDate2(expirationDateNode);
                    }
                }
                else
                {
                    expirationDate_ = new AdjustableDate2(expirationDateNode);
                }
            }
            
        
            XmlNode terminationDateNode = xmlNode.SelectSingleNode("terminationDate");
            
            if (terminationDateNode != null)
            {
                if (terminationDateNode.Attributes["href"] != null || terminationDateNode.Attributes["id"] != null) 
                {
                    if (terminationDateNode.Attributes["id"] != null) 
                    {
                        terminationDateIDRef_ = terminationDateNode.Attributes["id"].Value;
                        AdjustableDate2 ob = new AdjustableDate2(terminationDateNode);
                        IDManager.SetID(terminationDateIDRef_, ob);
                    }
                    else if (terminationDateNode.Attributes["href"] != null)
                    {
                        terminationDateIDRef_ = terminationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        terminationDate_ = new AdjustableDate2(terminationDateNode);
                    }
                }
                else
                {
                    terminationDate_ = new AdjustableDate2(terminationDateNode);
                }
            }
            
        
            XmlNodeList underlyerNodeList = xmlNode.SelectNodes("underlyer");
            
            if (underlyerNodeList != null)
            {
                this.underlyer_ = new List<TradeUnderlyer2>();
                foreach (XmlNode item in underlyerNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            underlyerIDRef_ = item.Attributes["id"].Value;
                            underlyer_.Add(new TradeUnderlyer2(item));
                            IDManager.SetID(underlyerIDRef_, underlyer_[underlyer_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            underlyerIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        underlyer_.Add(new TradeUnderlyer2(item));
                        }
                    }
                    else
                    {
                        underlyer_.Add(new TradeUnderlyer2(item));
                    }
                }
            }
            
        
            XmlNodeList notionalNodeList = xmlNode.SelectNodes("notional");
            
            if (notionalNodeList != null)
            {
                this.notional_ = new List<CashflowNotional>();
                foreach (XmlNode item in notionalNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            notionalIDRef_ = item.Attributes["id"].Value;
                            notional_.Add(new CashflowNotional(item));
                            IDManager.SetID(notionalIDRef_, notional_[notional_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            notionalIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        notional_.Add(new CashflowNotional(item));
                        }
                    }
                    else
                    {
                        notional_.Add(new CashflowNotional(item));
                    }
                }
            }
            
        
            XmlNode optionTypeNode = xmlNode.SelectSingleNode("optionType");
            
            if (optionTypeNode != null)
            {
                if (optionTypeNode.Attributes["href"] != null || optionTypeNode.Attributes["id"] != null) 
                {
                    if (optionTypeNode.Attributes["id"] != null) 
                    {
                        optionTypeIDRef_ = optionTypeNode.Attributes["id"].Value;
                        OptionType ob = new OptionType(optionTypeNode);
                        IDManager.SetID(optionTypeIDRef_, ob);
                    }
                    else if (optionTypeNode.Attributes["href"] != null)
                    {
                        optionTypeIDRef_ = optionTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionType_ = new OptionType(optionTypeNode);
                    }
                }
                else
                {
                    optionType_ = new OptionType(optionTypeNode);
                }
            }
            
        
            XmlNodeList settlementCurrencyNodeList = xmlNode.SelectNodes("settlementCurrency");
            
            if (settlementCurrencyNodeList != null)
            {
                this.settlementCurrency_ = new List<IdentifiedCurrency>();
                foreach (XmlNode item in settlementCurrencyNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            settlementCurrencyIDRef_ = item.Attributes["id"].Value;
                            settlementCurrency_.Add(new IdentifiedCurrency(item));
                            IDManager.SetID(settlementCurrencyIDRef_, settlementCurrency_[settlementCurrency_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            settlementCurrencyIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        settlementCurrency_.Add(new IdentifiedCurrency(item));
                        }
                    }
                    else
                    {
                        settlementCurrency_.Add(new IdentifiedCurrency(item));
                    }
                }
            }
            
        
            XmlNodeList dayCountFractionNodeList = xmlNode.SelectNodes("dayCountFraction");
            
            if (dayCountFractionNodeList != null)
            {
                this.dayCountFraction_ = new List<DayCountFraction>();
                foreach (XmlNode item in dayCountFractionNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            dayCountFractionIDRef_ = item.Attributes["id"].Value;
                            dayCountFraction_.Add(new DayCountFraction(item));
                            IDManager.SetID(dayCountFractionIDRef_, dayCountFraction_[dayCountFraction_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            dayCountFractionIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        dayCountFraction_.Add(new DayCountFraction(item));
                        }
                    }
                    else
                    {
                        dayCountFraction_.Add(new DayCountFraction(item));
                    }
                }
            }
            
        
        }
        
    
        #region MultiLeg_
        private XsdTypeBoolean multiLeg_;
        public XsdTypeBoolean MultiLeg_
        {
            get
            {
                if (this.multiLeg_ != null)
                {
                    return this.multiLeg_; 
                }
                else if (this.multiLegIDRef_ != null)
                {
                    multiLeg_ = IDManager.getID(multiLegIDRef_) as XsdTypeBoolean;
                    return this.multiLeg_; 
                }
                else
                {
                      return this.multiLeg_; 
                }
            }
            set
            {
                if (this.multiLeg_ != value)
                {
                    this.multiLeg_ = value;
                }
            }
        }
        #endregion
        
        public string multiLegIDRef_ { get; set; }
        #region BuyerPartyReference_
        private PartyReference buyerPartyReference_;
        public PartyReference BuyerPartyReference_
        {
            get
            {
                if (this.buyerPartyReference_ != null)
                {
                    return this.buyerPartyReference_; 
                }
                else if (this.buyerPartyReferenceIDRef_ != null)
                {
                    buyerPartyReference_ = IDManager.getID(buyerPartyReferenceIDRef_) as PartyReference;
                    return this.buyerPartyReference_; 
                }
                else
                {
                      return this.buyerPartyReference_; 
                }
            }
            set
            {
                if (this.buyerPartyReference_ != value)
                {
                    this.buyerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string buyerPartyReferenceIDRef_ { get; set; }
        #region BuyerAccountReference_
        private AccountReference buyerAccountReference_;
        public AccountReference BuyerAccountReference_
        {
            get
            {
                if (this.buyerAccountReference_ != null)
                {
                    return this.buyerAccountReference_; 
                }
                else if (this.buyerAccountReferenceIDRef_ != null)
                {
                    buyerAccountReference_ = IDManager.getID(buyerAccountReferenceIDRef_) as AccountReference;
                    return this.buyerAccountReference_; 
                }
                else
                {
                      return this.buyerAccountReference_; 
                }
            }
            set
            {
                if (this.buyerAccountReference_ != value)
                {
                    this.buyerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string buyerAccountReferenceIDRef_ { get; set; }
        #region SellerPartyReference_
        private PartyReference sellerPartyReference_;
        public PartyReference SellerPartyReference_
        {
            get
            {
                if (this.sellerPartyReference_ != null)
                {
                    return this.sellerPartyReference_; 
                }
                else if (this.sellerPartyReferenceIDRef_ != null)
                {
                    sellerPartyReference_ = IDManager.getID(sellerPartyReferenceIDRef_) as PartyReference;
                    return this.sellerPartyReference_; 
                }
                else
                {
                      return this.sellerPartyReference_; 
                }
            }
            set
            {
                if (this.sellerPartyReference_ != value)
                {
                    this.sellerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string sellerPartyReferenceIDRef_ { get; set; }
        #region SellerAccountReference_
        private AccountReference sellerAccountReference_;
        public AccountReference SellerAccountReference_
        {
            get
            {
                if (this.sellerAccountReference_ != null)
                {
                    return this.sellerAccountReference_; 
                }
                else if (this.sellerAccountReferenceIDRef_ != null)
                {
                    sellerAccountReference_ = IDManager.getID(sellerAccountReferenceIDRef_) as AccountReference;
                    return this.sellerAccountReference_; 
                }
                else
                {
                      return this.sellerAccountReference_; 
                }
            }
            set
            {
                if (this.sellerAccountReference_ != value)
                {
                    this.sellerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string sellerAccountReferenceIDRef_ { get; set; }
        #region CounterpartyReference_
        private List<PartyReference> counterpartyReference_;
        public List<PartyReference> CounterpartyReference_
        {
            get
            {
                if (this.counterpartyReference_ != null)
                {
                    return this.counterpartyReference_; 
                }
                else if (this.counterpartyReferenceIDRef_ != null)
                {
                    return this.counterpartyReference_; 
                }
                else
                {
                      return this.counterpartyReference_; 
                }
            }
            set
            {
                if (this.counterpartyReference_ != value)
                {
                    this.counterpartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string counterpartyReferenceIDRef_ { get; set; }
        #region Premium_
        private SimplePayment premium_;
        public SimplePayment Premium_
        {
            get
            {
                if (this.premium_ != null)
                {
                    return this.premium_; 
                }
                else if (this.premiumIDRef_ != null)
                {
                    premium_ = IDManager.getID(premiumIDRef_) as SimplePayment;
                    return this.premium_; 
                }
                else
                {
                      return this.premium_; 
                }
            }
            set
            {
                if (this.premium_ != value)
                {
                    this.premium_ = value;
                }
            }
        }
        #endregion
        
        public string premiumIDRef_ { get; set; }
        #region EffectiveDate_
        private AdjustableDate2 effectiveDate_;
        public AdjustableDate2 EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as AdjustableDate2;
                    return this.effectiveDate_; 
                }
                else
                {
                      return this.effectiveDate_; 
                }
            }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveDateIDRef_ { get; set; }
        #region ExpirationDate_
        private AdjustableDate2 expirationDate_;
        public AdjustableDate2 ExpirationDate_
        {
            get
            {
                if (this.expirationDate_ != null)
                {
                    return this.expirationDate_; 
                }
                else if (this.expirationDateIDRef_ != null)
                {
                    expirationDate_ = IDManager.getID(expirationDateIDRef_) as AdjustableDate2;
                    return this.expirationDate_; 
                }
                else
                {
                      return this.expirationDate_; 
                }
            }
            set
            {
                if (this.expirationDate_ != value)
                {
                    this.expirationDate_ = value;
                }
            }
        }
        #endregion
        
        public string expirationDateIDRef_ { get; set; }
        #region TerminationDate_
        private AdjustableDate2 terminationDate_;
        public AdjustableDate2 TerminationDate_
        {
            get
            {
                if (this.terminationDate_ != null)
                {
                    return this.terminationDate_; 
                }
                else if (this.terminationDateIDRef_ != null)
                {
                    terminationDate_ = IDManager.getID(terminationDateIDRef_) as AdjustableDate2;
                    return this.terminationDate_; 
                }
                else
                {
                      return this.terminationDate_; 
                }
            }
            set
            {
                if (this.terminationDate_ != value)
                {
                    this.terminationDate_ = value;
                }
            }
        }
        #endregion
        
        public string terminationDateIDRef_ { get; set; }
        #region Underlyer_
        private List<TradeUnderlyer2> underlyer_;
        public List<TradeUnderlyer2> Underlyer_
        {
            get
            {
                if (this.underlyer_ != null)
                {
                    return this.underlyer_; 
                }
                else if (this.underlyerIDRef_ != null)
                {
                    return this.underlyer_; 
                }
                else
                {
                      return this.underlyer_; 
                }
            }
            set
            {
                if (this.underlyer_ != value)
                {
                    this.underlyer_ = value;
                }
            }
        }
        #endregion
        
        public string underlyerIDRef_ { get; set; }
        #region Notional_
        private List<CashflowNotional> notional_;
        public List<CashflowNotional> Notional_
        {
            get
            {
                if (this.notional_ != null)
                {
                    return this.notional_; 
                }
                else if (this.notionalIDRef_ != null)
                {
                    return this.notional_; 
                }
                else
                {
                      return this.notional_; 
                }
            }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                }
            }
        }
        #endregion
        
        public string notionalIDRef_ { get; set; }
        #region OptionType_
        private OptionType optionType_;
        public OptionType OptionType_
        {
            get
            {
                if (this.optionType_ != null)
                {
                    return this.optionType_; 
                }
                else if (this.optionTypeIDRef_ != null)
                {
                    optionType_ = IDManager.getID(optionTypeIDRef_) as OptionType;
                    return this.optionType_; 
                }
                else
                {
                      return this.optionType_; 
                }
            }
            set
            {
                if (this.optionType_ != value)
                {
                    this.optionType_ = value;
                }
            }
        }
        #endregion
        
        public string optionTypeIDRef_ { get; set; }
        #region SettlementCurrency_
        private List<IdentifiedCurrency> settlementCurrency_;
        public List<IdentifiedCurrency> SettlementCurrency_
        {
            get
            {
                if (this.settlementCurrency_ != null)
                {
                    return this.settlementCurrency_; 
                }
                else if (this.settlementCurrencyIDRef_ != null)
                {
                    return this.settlementCurrency_; 
                }
                else
                {
                      return this.settlementCurrency_; 
                }
            }
            set
            {
                if (this.settlementCurrency_ != value)
                {
                    this.settlementCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string settlementCurrencyIDRef_ { get; set; }
        #region DayCountFraction_
        private List<DayCountFraction> dayCountFraction_;
        public List<DayCountFraction> DayCountFraction_
        {
            get
            {
                if (this.dayCountFraction_ != null)
                {
                    return this.dayCountFraction_; 
                }
                else if (this.dayCountFractionIDRef_ != null)
                {
                    return this.dayCountFraction_; 
                }
                else
                {
                      return this.dayCountFraction_; 
                }
            }
            set
            {
                if (this.dayCountFraction_ != value)
                {
                    this.dayCountFraction_ = value;
                }
            }
        }
        #endregion
        
        public string dayCountFractionIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

