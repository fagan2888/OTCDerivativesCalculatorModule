using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class RequestClearing
    {
        public RequestClearing(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList portfolioReferenceNodeList = xmlNode.SelectNodes("portfolioReference");
            if (portfolioReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in portfolioReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        portfolioReferenceIDRef = item.Attributes["id"].Name;
                        PortfolioReference ob = PortfolioReference();
                        IDManager.SetID(portfolioReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        portfolioReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        portfolioReference = new PortfolioReference(item);
                    }
                }
            }
            
        
            XmlNodeList originatingEventNodeList = xmlNode.SelectNodes("originatingEvent");
            if (originatingEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in originatingEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        originatingEventIDRef = item.Attributes["id"].Name;
                        OriginatingEvent ob = OriginatingEvent();
                        IDManager.SetID(originatingEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        originatingEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        originatingEvent = new OriginatingEvent(item);
                    }
                }
            }
            
        
            XmlNodeList tradeNodeList = xmlNode.SelectNodes("trade");
            if (tradeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeIDRef = item.Attributes["id"].Name;
                        Trade ob = Trade();
                        IDManager.SetID(tradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        trade = new Trade(item);
                    }
                }
            }
            
        
            XmlNodeList amendmentNodeList = xmlNode.SelectNodes("amendment");
            if (amendmentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in amendmentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        amendmentIDRef = item.Attributes["id"].Name;
                        TradeAmendmentContent ob = TradeAmendmentContent();
                        IDManager.SetID(amendmentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        amendmentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        amendment = new TradeAmendmentContent(item);
                    }
                }
            }
            
        
            XmlNodeList increaseNodeList = xmlNode.SelectNodes("increase");
            if (increaseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in increaseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        increaseIDRef = item.Attributes["id"].Name;
                        TradeNotionalChange ob = TradeNotionalChange();
                        IDManager.SetID(increaseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        increaseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        increase = new TradeNotionalChange(item);
                    }
                }
            }
            
        
            XmlNodeList terminatingEventNodeList = xmlNode.SelectNodes("terminatingEvent");
            if (terminatingEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in terminatingEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        terminatingEventIDRef = item.Attributes["id"].Name;
                        TerminatingEvent ob = TerminatingEvent();
                        IDManager.SetID(terminatingEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        terminatingEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        terminatingEvent = new TerminatingEvent(item);
                    }
                }
            }
            
        
            XmlNodeList terminationNodeList = xmlNode.SelectNodes("termination");
            if (terminationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in terminationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        terminationIDRef = item.Attributes["id"].Name;
                        TradeNotionalChange ob = TradeNotionalChange();
                        IDManager.SetID(terminationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        terminationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        termination = new TradeNotionalChange(item);
                    }
                }
            }
            
        
            XmlNodeList novationNodeList = xmlNode.SelectNodes("novation");
            if (novationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in novationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        novationIDRef = item.Attributes["id"].Name;
                        TradeNovationContent ob = TradeNovationContent();
                        IDManager.SetID(novationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        novationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        novation = new TradeNovationContent(item);
                    }
                }
            }
            
        
            XmlNodeList optionExerciseNodeList = xmlNode.SelectNodes("optionExercise");
            if (optionExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionExerciseIDRef = item.Attributes["id"].Name;
                        OptionExercise ob = OptionExercise();
                        IDManager.SetID(optionExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionExercise = new OptionExercise(item);
                    }
                }
            }
            
        
            XmlNodeList optionExpiryNodeList = xmlNode.SelectNodes("optionExpiry");
            
            foreach (XmlNode item in optionExpiryNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionExpiryIDRef = item.Attributes["id"].Name;
                        List<OptionExpiry> ob = new List<OptionExpiry>();
                        ob.Add(new OptionExpiry(item));
                        IDManager.SetID(optionExpiryIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionExpiryIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    optionExpiry.Add(new OptionExpiry(item));
                    }
                }
            }
            
        
            XmlNodeList deClearNodeList = xmlNode.SelectNodes("deClear");
            if (deClearNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deClearNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deClearIDRef = item.Attributes["id"].Name;
                        DeClear ob = DeClear();
                        IDManager.SetID(deClearIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deClearIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deClear = new DeClear(item);
                    }
                }
            }
            
        
            XmlNodeList withdrawalNodeList = xmlNode.SelectNodes("withdrawal");
            if (withdrawalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in withdrawalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        withdrawalIDRef = item.Attributes["id"].Name;
                        Withdrawal ob = Withdrawal();
                        IDManager.SetID(withdrawalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        withdrawalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        withdrawal = new Withdrawal(item);
                    }
                }
            }
            
        
            XmlNodeList additionalEventNodeList = xmlNode.SelectNodes("additionalEvent");
            if (additionalEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in additionalEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        additionalEventIDRef = item.Attributes["id"].Name;
                        AdditionalEvent ob = AdditionalEvent();
                        IDManager.SetID(additionalEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        additionalEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        additionalEvent = new AdditionalEvent(item);
                    }
                }
            }
            
        
            XmlNodeList quoteNodeList = xmlNode.SelectNodes("quote");
            
            foreach (XmlNode item in quoteNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quoteIDRef = item.Attributes["id"].Name;
                        List<BasicQuotation> ob = new List<BasicQuotation>();
                        ob.Add(new BasicQuotation(item));
                        IDManager.SetID(quoteIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quoteIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    quote.Add(new BasicQuotation(item));
                    }
                }
            }
            
        
            XmlNodeList partyNodeList = xmlNode.SelectNodes("party");
            
            foreach (XmlNode item in partyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyIDRef = item.Attributes["id"].Name;
                        List<Party> ob = new List<Party>();
                        ob.Add(new Party(item));
                        IDManager.SetID(partyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    party.Add(new Party(item));
                    }
                }
            }
            
        
            XmlNodeList accountNodeList = xmlNode.SelectNodes("account");
            
            foreach (XmlNode item in accountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accountIDRef = item.Attributes["id"].Name;
                        List<Account> ob = new List<Account>();
                        ob.Add(new Account(item));
                        IDManager.SetID(accountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    account.Add(new Account(item));
                    }
                }
            }
            
        
        }
        
    
        #region PortfolioReference
        private PortfolioReference portfolioReference;
        public PortfolioReference PortfolioReference
        {
            get
            {
                if (this.portfolioReference != null)
                {
                    return this.portfolioReference; 
                }
                else if (this.portfolioReferenceIDRef != null)
                {
                    portfolioReference = IDManager.getID(portfolioReferenceIDRef) as PortfolioReference;
                    return this.portfolioReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.portfolioReference != value)
                {
                    this.portfolioReference = value;
                }
            }
        }
        #endregion
        
        public string PortfolioReferenceIDRef { get; set; }
        #region OriginatingEvent
        private OriginatingEvent originatingEvent;
        public OriginatingEvent OriginatingEvent
        {
            get
            {
                if (this.originatingEvent != null)
                {
                    return this.originatingEvent; 
                }
                else if (this.originatingEventIDRef != null)
                {
                    originatingEvent = IDManager.getID(originatingEventIDRef) as OriginatingEvent;
                    return this.originatingEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.originatingEvent != value)
                {
                    this.originatingEvent = value;
                }
            }
        }
        #endregion
        
        public string OriginatingEventIDRef { get; set; }
        #region Trade
        private Trade trade;
        public Trade Trade
        {
            get
            {
                if (this.trade != null)
                {
                    return this.trade; 
                }
                else if (this.tradeIDRef != null)
                {
                    trade = IDManager.getID(tradeIDRef) as Trade;
                    return this.trade; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.trade != value)
                {
                    this.trade = value;
                }
            }
        }
        #endregion
        
        public string TradeIDRef { get; set; }
        #region Amendment
        private TradeAmendmentContent amendment;
        public TradeAmendmentContent Amendment
        {
            get
            {
                if (this.amendment != null)
                {
                    return this.amendment; 
                }
                else if (this.amendmentIDRef != null)
                {
                    amendment = IDManager.getID(amendmentIDRef) as TradeAmendmentContent;
                    return this.amendment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.amendment != value)
                {
                    this.amendment = value;
                }
            }
        }
        #endregion
        
        public string TradeAmendmentContentIDRef { get; set; }
        #region Increase
        private TradeNotionalChange increase;
        public TradeNotionalChange Increase
        {
            get
            {
                if (this.increase != null)
                {
                    return this.increase; 
                }
                else if (this.increaseIDRef != null)
                {
                    increase = IDManager.getID(increaseIDRef) as TradeNotionalChange;
                    return this.increase; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.increase != value)
                {
                    this.increase = value;
                }
            }
        }
        #endregion
        
        public string TradeNotionalChangeIDRef { get; set; }
        #region TerminatingEvent
        private TerminatingEvent terminatingEvent;
        public TerminatingEvent TerminatingEvent
        {
            get
            {
                if (this.terminatingEvent != null)
                {
                    return this.terminatingEvent; 
                }
                else if (this.terminatingEventIDRef != null)
                {
                    terminatingEvent = IDManager.getID(terminatingEventIDRef) as TerminatingEvent;
                    return this.terminatingEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.terminatingEvent != value)
                {
                    this.terminatingEvent = value;
                }
            }
        }
        #endregion
        
        public string TerminatingEventIDRef { get; set; }
        #region Termination
        private TradeNotionalChange termination;
        public TradeNotionalChange Termination
        {
            get
            {
                if (this.termination != null)
                {
                    return this.termination; 
                }
                else if (this.terminationIDRef != null)
                {
                    termination = IDManager.getID(terminationIDRef) as TradeNotionalChange;
                    return this.termination; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.termination != value)
                {
                    this.termination = value;
                }
            }
        }
        #endregion
        
        public string TradeNotionalChangeIDRef { get; set; }
        #region Novation
        private TradeNovationContent novation;
        public TradeNovationContent Novation
        {
            get
            {
                if (this.novation != null)
                {
                    return this.novation; 
                }
                else if (this.novationIDRef != null)
                {
                    novation = IDManager.getID(novationIDRef) as TradeNovationContent;
                    return this.novation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.novation != value)
                {
                    this.novation = value;
                }
            }
        }
        #endregion
        
        public string TradeNovationContentIDRef { get; set; }
        #region OptionExercise
        private OptionExercise optionExercise;
        public OptionExercise OptionExercise
        {
            get
            {
                if (this.optionExercise != null)
                {
                    return this.optionExercise; 
                }
                else if (this.optionExerciseIDRef != null)
                {
                    optionExercise = IDManager.getID(optionExerciseIDRef) as OptionExercise;
                    return this.optionExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionExercise != value)
                {
                    this.optionExercise = value;
                }
            }
        }
        #endregion
        
        public string OptionExerciseIDRef { get; set; }
        #region OptionExpiry
        private List<OptionExpiry> optionExpiry;
        public List<OptionExpiry> OptionExpiry
        {
            get
            {
                if (this.optionExpiry != null)
                {
                    return this.optionExpiry; 
                }
                else if (this.optionExpiryIDRef != null)
                {
                    optionExpiry = IDManager.getID(optionExpiryIDRef) as List<OptionExpiry>;
                    return this.optionExpiry; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionExpiry != value)
                {
                    this.optionExpiry = value;
                }
            }
        }
        #endregion
        
        public string OptionExpiryIDRef { get; set; }
        #region DeClear
        private DeClear deClear;
        public DeClear DeClear
        {
            get
            {
                if (this.deClear != null)
                {
                    return this.deClear; 
                }
                else if (this.deClearIDRef != null)
                {
                    deClear = IDManager.getID(deClearIDRef) as DeClear;
                    return this.deClear; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deClear != value)
                {
                    this.deClear = value;
                }
            }
        }
        #endregion
        
        public string DeClearIDRef { get; set; }
        #region Withdrawal
        private Withdrawal withdrawal;
        public Withdrawal Withdrawal
        {
            get
            {
                if (this.withdrawal != null)
                {
                    return this.withdrawal; 
                }
                else if (this.withdrawalIDRef != null)
                {
                    withdrawal = IDManager.getID(withdrawalIDRef) as Withdrawal;
                    return this.withdrawal; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.withdrawal != value)
                {
                    this.withdrawal = value;
                }
            }
        }
        #endregion
        
        public string WithdrawalIDRef { get; set; }
        #region AdditionalEvent
        private AdditionalEvent additionalEvent;
        public AdditionalEvent AdditionalEvent
        {
            get
            {
                if (this.additionalEvent != null)
                {
                    return this.additionalEvent; 
                }
                else if (this.additionalEventIDRef != null)
                {
                    additionalEvent = IDManager.getID(additionalEventIDRef) as AdditionalEvent;
                    return this.additionalEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.additionalEvent != value)
                {
                    this.additionalEvent = value;
                }
            }
        }
        #endregion
        
        public string AdditionalEventIDRef { get; set; }
        #region Quote
        private List<BasicQuotation> quote;
        public List<BasicQuotation> Quote
        {
            get
            {
                if (this.quote != null)
                {
                    return this.quote; 
                }
                else if (this.quoteIDRef != null)
                {
                    quote = IDManager.getID(quoteIDRef) as List<BasicQuotation>;
                    return this.quote; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quote != value)
                {
                    this.quote = value;
                }
            }
        }
        #endregion
        
        public string BasicQuotationIDRef { get; set; }
        #region Party
        private List<Party> party;
        public List<Party> Party
        {
            get
            {
                if (this.party != null)
                {
                    return this.party; 
                }
                else if (this.partyIDRef != null)
                {
                    party = IDManager.getID(partyIDRef) as List<Party>;
                    return this.party; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.party != value)
                {
                    this.party = value;
                }
            }
        }
        #endregion
        
        public string PartyIDRef { get; set; }
        #region Account
        private List<Account> account;
        public List<Account> Account
        {
            get
            {
                if (this.account != null)
                {
                    return this.account; 
                }
                else if (this.accountIDRef != null)
                {
                    account = IDManager.getID(accountIDRef) as List<Account>;
                    return this.account; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.account != value)
                {
                    this.account = value;
                }
            }
        }
        #endregion
        
        public string AccountIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

