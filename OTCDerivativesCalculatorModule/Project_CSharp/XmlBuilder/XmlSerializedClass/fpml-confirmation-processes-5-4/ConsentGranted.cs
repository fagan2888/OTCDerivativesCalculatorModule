using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ConsentGranted : ResponseMessage
    {
        public ConsentGranted(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode portfolioReferenceNode = xmlNode.SelectSingleNode("portfolioReference");
            
            if (portfolioReferenceNode != null)
            {
                if (portfolioReferenceNode.Attributes["href"] != null || portfolioReferenceNode.Attributes["id"] != null) 
                {
                    if (portfolioReferenceNode.Attributes["id"] != null) 
                    {
                        portfolioReferenceIDRef_ = portfolioReferenceNode.Attributes["id"].Value;
                        PortfolioReferenceBase ob = new PortfolioReferenceBase(portfolioReferenceNode);
                        IDManager.SetID(portfolioReferenceIDRef_, ob);
                    }
                    else if (portfolioReferenceNode.Attributes["href"] != null)
                    {
                        portfolioReferenceIDRef_ = portfolioReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        portfolioReference_ = new PortfolioReferenceBase(portfolioReferenceNode);
                    }
                }
                else
                {
                    portfolioReference_ = new PortfolioReferenceBase(portfolioReferenceNode);
                }
            }
            
        
            XmlNode originatingEventNode = xmlNode.SelectSingleNode("originatingEvent");
            
            if (originatingEventNode != null)
            {
                if (originatingEventNode.Attributes["href"] != null || originatingEventNode.Attributes["id"] != null) 
                {
                    if (originatingEventNode.Attributes["id"] != null) 
                    {
                        originatingEventIDRef_ = originatingEventNode.Attributes["id"].Value;
                        OriginatingEvent ob = new OriginatingEvent(originatingEventNode);
                        IDManager.SetID(originatingEventIDRef_, ob);
                    }
                    else if (originatingEventNode.Attributes["href"] != null)
                    {
                        originatingEventIDRef_ = originatingEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        originatingEvent_ = new OriginatingEvent(originatingEventNode);
                    }
                }
                else
                {
                    originatingEvent_ = new OriginatingEvent(originatingEventNode);
                }
            }
            
        
            XmlNode tradeNode = xmlNode.SelectSingleNode("trade");
            
            if (tradeNode != null)
            {
                if (tradeNode.Attributes["href"] != null || tradeNode.Attributes["id"] != null) 
                {
                    if (tradeNode.Attributes["id"] != null) 
                    {
                        tradeIDRef_ = tradeNode.Attributes["id"].Value;
                        Trade ob = new Trade(tradeNode);
                        IDManager.SetID(tradeIDRef_, ob);
                    }
                    else if (tradeNode.Attributes["href"] != null)
                    {
                        tradeIDRef_ = tradeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        trade_ = new Trade(tradeNode);
                    }
                }
                else
                {
                    trade_ = new Trade(tradeNode);
                }
            }
            
        
            XmlNode amendmentNode = xmlNode.SelectSingleNode("amendment");
            
            if (amendmentNode != null)
            {
                if (amendmentNode.Attributes["href"] != null || amendmentNode.Attributes["id"] != null) 
                {
                    if (amendmentNode.Attributes["id"] != null) 
                    {
                        amendmentIDRef_ = amendmentNode.Attributes["id"].Value;
                        TradeAmendmentContent ob = new TradeAmendmentContent(amendmentNode);
                        IDManager.SetID(amendmentIDRef_, ob);
                    }
                    else if (amendmentNode.Attributes["href"] != null)
                    {
                        amendmentIDRef_ = amendmentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        amendment_ = new TradeAmendmentContent(amendmentNode);
                    }
                }
                else
                {
                    amendment_ = new TradeAmendmentContent(amendmentNode);
                }
            }
            
        
            XmlNode increaseNode = xmlNode.SelectSingleNode("increase");
            
            if (increaseNode != null)
            {
                if (increaseNode.Attributes["href"] != null || increaseNode.Attributes["id"] != null) 
                {
                    if (increaseNode.Attributes["id"] != null) 
                    {
                        increaseIDRef_ = increaseNode.Attributes["id"].Value;
                        TradeNotionalChange ob = new TradeNotionalChange(increaseNode);
                        IDManager.SetID(increaseIDRef_, ob);
                    }
                    else if (increaseNode.Attributes["href"] != null)
                    {
                        increaseIDRef_ = increaseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        increase_ = new TradeNotionalChange(increaseNode);
                    }
                }
                else
                {
                    increase_ = new TradeNotionalChange(increaseNode);
                }
            }
            
        
            XmlNode terminatingEventNode = xmlNode.SelectSingleNode("terminatingEvent");
            
            if (terminatingEventNode != null)
            {
                if (terminatingEventNode.Attributes["href"] != null || terminatingEventNode.Attributes["id"] != null) 
                {
                    if (terminatingEventNode.Attributes["id"] != null) 
                    {
                        terminatingEventIDRef_ = terminatingEventNode.Attributes["id"].Value;
                        TerminatingEvent ob = new TerminatingEvent(terminatingEventNode);
                        IDManager.SetID(terminatingEventIDRef_, ob);
                    }
                    else if (terminatingEventNode.Attributes["href"] != null)
                    {
                        terminatingEventIDRef_ = terminatingEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        terminatingEvent_ = new TerminatingEvent(terminatingEventNode);
                    }
                }
                else
                {
                    terminatingEvent_ = new TerminatingEvent(terminatingEventNode);
                }
            }
            
        
            XmlNode terminationNode = xmlNode.SelectSingleNode("termination");
            
            if (terminationNode != null)
            {
                if (terminationNode.Attributes["href"] != null || terminationNode.Attributes["id"] != null) 
                {
                    if (terminationNode.Attributes["id"] != null) 
                    {
                        terminationIDRef_ = terminationNode.Attributes["id"].Value;
                        TradeNotionalChange ob = new TradeNotionalChange(terminationNode);
                        IDManager.SetID(terminationIDRef_, ob);
                    }
                    else if (terminationNode.Attributes["href"] != null)
                    {
                        terminationIDRef_ = terminationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        termination_ = new TradeNotionalChange(terminationNode);
                    }
                }
                else
                {
                    termination_ = new TradeNotionalChange(terminationNode);
                }
            }
            
        
            XmlNode novationNode = xmlNode.SelectSingleNode("novation");
            
            if (novationNode != null)
            {
                if (novationNode.Attributes["href"] != null || novationNode.Attributes["id"] != null) 
                {
                    if (novationNode.Attributes["id"] != null) 
                    {
                        novationIDRef_ = novationNode.Attributes["id"].Value;
                        TradeNovationContent ob = new TradeNovationContent(novationNode);
                        IDManager.SetID(novationIDRef_, ob);
                    }
                    else if (novationNode.Attributes["href"] != null)
                    {
                        novationIDRef_ = novationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        novation_ = new TradeNovationContent(novationNode);
                    }
                }
                else
                {
                    novation_ = new TradeNovationContent(novationNode);
                }
            }
            
        
            XmlNode optionExerciseNode = xmlNode.SelectSingleNode("optionExercise");
            
            if (optionExerciseNode != null)
            {
                if (optionExerciseNode.Attributes["href"] != null || optionExerciseNode.Attributes["id"] != null) 
                {
                    if (optionExerciseNode.Attributes["id"] != null) 
                    {
                        optionExerciseIDRef_ = optionExerciseNode.Attributes["id"].Value;
                        OptionExercise ob = new OptionExercise(optionExerciseNode);
                        IDManager.SetID(optionExerciseIDRef_, ob);
                    }
                    else if (optionExerciseNode.Attributes["href"] != null)
                    {
                        optionExerciseIDRef_ = optionExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionExercise_ = new OptionExercise(optionExerciseNode);
                    }
                }
                else
                {
                    optionExercise_ = new OptionExercise(optionExerciseNode);
                }
            }
            
        
            XmlNodeList optionExpiryNodeList = xmlNode.SelectNodes("optionExpiry");
            
            if (optionExpiryNodeList != null)
            {
                this.optionExpiry_ = new List<OptionExpiry>();
                foreach (XmlNode item in optionExpiryNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            optionExpiryIDRef_ = item.Attributes["id"].Value;
                            optionExpiry_.Add(new OptionExpiry(item));
                            IDManager.SetID(optionExpiryIDRef_, optionExpiry_[optionExpiry_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            optionExpiryIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        optionExpiry_.Add(new OptionExpiry(item));
                        }
                    }
                    else
                    {
                        optionExpiry_.Add(new OptionExpiry(item));
                    }
                }
            }
            
        
            XmlNode deClearNode = xmlNode.SelectSingleNode("deClear");
            
            if (deClearNode != null)
            {
                if (deClearNode.Attributes["href"] != null || deClearNode.Attributes["id"] != null) 
                {
                    if (deClearNode.Attributes["id"] != null) 
                    {
                        deClearIDRef_ = deClearNode.Attributes["id"].Value;
                        DeClear ob = new DeClear(deClearNode);
                        IDManager.SetID(deClearIDRef_, ob);
                    }
                    else if (deClearNode.Attributes["href"] != null)
                    {
                        deClearIDRef_ = deClearNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deClear_ = new DeClear(deClearNode);
                    }
                }
                else
                {
                    deClear_ = new DeClear(deClearNode);
                }
            }
            
        
            XmlNode withdrawalNode = xmlNode.SelectSingleNode("withdrawal");
            
            if (withdrawalNode != null)
            {
                if (withdrawalNode.Attributes["href"] != null || withdrawalNode.Attributes["id"] != null) 
                {
                    if (withdrawalNode.Attributes["id"] != null) 
                    {
                        withdrawalIDRef_ = withdrawalNode.Attributes["id"].Value;
                        Withdrawal ob = new Withdrawal(withdrawalNode);
                        IDManager.SetID(withdrawalIDRef_, ob);
                    }
                    else if (withdrawalNode.Attributes["href"] != null)
                    {
                        withdrawalIDRef_ = withdrawalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        withdrawal_ = new Withdrawal(withdrawalNode);
                    }
                }
                else
                {
                    withdrawal_ = new Withdrawal(withdrawalNode);
                }
            }
            
        
            XmlNode additionalEventNode = xmlNode.SelectSingleNode("additionalEvent");
            
            if (additionalEventNode != null)
            {
                if (additionalEventNode.Attributes["href"] != null || additionalEventNode.Attributes["id"] != null) 
                {
                    if (additionalEventNode.Attributes["id"] != null) 
                    {
                        additionalEventIDRef_ = additionalEventNode.Attributes["id"].Value;
                        AdditionalEvent ob = new AdditionalEvent(additionalEventNode);
                        IDManager.SetID(additionalEventIDRef_, ob);
                    }
                    else if (additionalEventNode.Attributes["href"] != null)
                    {
                        additionalEventIDRef_ = additionalEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        additionalEvent_ = new AdditionalEvent(additionalEventNode);
                    }
                }
                else
                {
                    additionalEvent_ = new AdditionalEvent(additionalEventNode);
                }
            }
            
        
            XmlNode tradeReferenceInformationNode = xmlNode.SelectSingleNode("tradeReferenceInformation");
            
            if (tradeReferenceInformationNode != null)
            {
                if (tradeReferenceInformationNode.Attributes["href"] != null || tradeReferenceInformationNode.Attributes["id"] != null) 
                {
                    if (tradeReferenceInformationNode.Attributes["id"] != null) 
                    {
                        tradeReferenceInformationIDRef_ = tradeReferenceInformationNode.Attributes["id"].Value;
                        TradeReferenceInformation ob = new TradeReferenceInformation(tradeReferenceInformationNode);
                        IDManager.SetID(tradeReferenceInformationIDRef_, ob);
                    }
                    else if (tradeReferenceInformationNode.Attributes["href"] != null)
                    {
                        tradeReferenceInformationIDRef_ = tradeReferenceInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tradeReferenceInformation_ = new TradeReferenceInformation(tradeReferenceInformationNode);
                    }
                }
                else
                {
                    tradeReferenceInformation_ = new TradeReferenceInformation(tradeReferenceInformationNode);
                }
            }
            
        
            XmlNodeList partyNodeList = xmlNode.SelectNodes("party");
            
            if (partyNodeList != null)
            {
                this.party_ = new List<Party>();
                foreach (XmlNode item in partyNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            partyIDRef_ = item.Attributes["id"].Value;
                            party_.Add(new Party(item));
                            IDManager.SetID(partyIDRef_, party_[party_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            partyIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        party_.Add(new Party(item));
                        }
                    }
                    else
                    {
                        party_.Add(new Party(item));
                    }
                }
            }
            
        
            XmlNodeList accountNodeList = xmlNode.SelectNodes("account");
            
            if (accountNodeList != null)
            {
                this.account_ = new List<Account>();
                foreach (XmlNode item in accountNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            accountIDRef_ = item.Attributes["id"].Value;
                            account_.Add(new Account(item));
                            IDManager.SetID(accountIDRef_, account_[account_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            accountIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        account_.Add(new Account(item));
                        }
                    }
                    else
                    {
                        account_.Add(new Account(item));
                    }
                }
            }
            
        
        }
        
    
        #region PortfolioReference_
        private PortfolioReferenceBase portfolioReference_;
        public PortfolioReferenceBase PortfolioReference_
        {
            get
            {
                if (this.portfolioReference_ != null)
                {
                    return this.portfolioReference_; 
                }
                else if (this.portfolioReferenceIDRef_ != null)
                {
                    portfolioReference_ = IDManager.getID(portfolioReferenceIDRef_) as PortfolioReferenceBase;
                    return this.portfolioReference_; 
                }
                else
                {
                      return this.portfolioReference_; 
                }
            }
            set
            {
                if (this.portfolioReference_ != value)
                {
                    this.portfolioReference_ = value;
                }
            }
        }
        #endregion
        
        public string portfolioReferenceIDRef_ { get; set; }
        #region OriginatingEvent_
        private OriginatingEvent originatingEvent_;
        public OriginatingEvent OriginatingEvent_
        {
            get
            {
                if (this.originatingEvent_ != null)
                {
                    return this.originatingEvent_; 
                }
                else if (this.originatingEventIDRef_ != null)
                {
                    originatingEvent_ = IDManager.getID(originatingEventIDRef_) as OriginatingEvent;
                    return this.originatingEvent_; 
                }
                else
                {
                      return this.originatingEvent_; 
                }
            }
            set
            {
                if (this.originatingEvent_ != value)
                {
                    this.originatingEvent_ = value;
                }
            }
        }
        #endregion
        
        public string originatingEventIDRef_ { get; set; }
        #region Trade_
        private Trade trade_;
        public Trade Trade_
        {
            get
            {
                if (this.trade_ != null)
                {
                    return this.trade_; 
                }
                else if (this.tradeIDRef_ != null)
                {
                    trade_ = IDManager.getID(tradeIDRef_) as Trade;
                    return this.trade_; 
                }
                else
                {
                      return this.trade_; 
                }
            }
            set
            {
                if (this.trade_ != value)
                {
                    this.trade_ = value;
                }
            }
        }
        #endregion
        
        public string tradeIDRef_ { get; set; }
        #region Amendment_
        private TradeAmendmentContent amendment_;
        public TradeAmendmentContent Amendment_
        {
            get
            {
                if (this.amendment_ != null)
                {
                    return this.amendment_; 
                }
                else if (this.amendmentIDRef_ != null)
                {
                    amendment_ = IDManager.getID(amendmentIDRef_) as TradeAmendmentContent;
                    return this.amendment_; 
                }
                else
                {
                      return this.amendment_; 
                }
            }
            set
            {
                if (this.amendment_ != value)
                {
                    this.amendment_ = value;
                }
            }
        }
        #endregion
        
        public string amendmentIDRef_ { get; set; }
        #region Increase_
        private TradeNotionalChange increase_;
        public TradeNotionalChange Increase_
        {
            get
            {
                if (this.increase_ != null)
                {
                    return this.increase_; 
                }
                else if (this.increaseIDRef_ != null)
                {
                    increase_ = IDManager.getID(increaseIDRef_) as TradeNotionalChange;
                    return this.increase_; 
                }
                else
                {
                      return this.increase_; 
                }
            }
            set
            {
                if (this.increase_ != value)
                {
                    this.increase_ = value;
                }
            }
        }
        #endregion
        
        public string increaseIDRef_ { get; set; }
        #region TerminatingEvent_
        private TerminatingEvent terminatingEvent_;
        public TerminatingEvent TerminatingEvent_
        {
            get
            {
                if (this.terminatingEvent_ != null)
                {
                    return this.terminatingEvent_; 
                }
                else if (this.terminatingEventIDRef_ != null)
                {
                    terminatingEvent_ = IDManager.getID(terminatingEventIDRef_) as TerminatingEvent;
                    return this.terminatingEvent_; 
                }
                else
                {
                      return this.terminatingEvent_; 
                }
            }
            set
            {
                if (this.terminatingEvent_ != value)
                {
                    this.terminatingEvent_ = value;
                }
            }
        }
        #endregion
        
        public string terminatingEventIDRef_ { get; set; }
        #region Termination_
        private TradeNotionalChange termination_;
        public TradeNotionalChange Termination_
        {
            get
            {
                if (this.termination_ != null)
                {
                    return this.termination_; 
                }
                else if (this.terminationIDRef_ != null)
                {
                    termination_ = IDManager.getID(terminationIDRef_) as TradeNotionalChange;
                    return this.termination_; 
                }
                else
                {
                      return this.termination_; 
                }
            }
            set
            {
                if (this.termination_ != value)
                {
                    this.termination_ = value;
                }
            }
        }
        #endregion
        
        public string terminationIDRef_ { get; set; }
        #region Novation_
        private TradeNovationContent novation_;
        public TradeNovationContent Novation_
        {
            get
            {
                if (this.novation_ != null)
                {
                    return this.novation_; 
                }
                else if (this.novationIDRef_ != null)
                {
                    novation_ = IDManager.getID(novationIDRef_) as TradeNovationContent;
                    return this.novation_; 
                }
                else
                {
                      return this.novation_; 
                }
            }
            set
            {
                if (this.novation_ != value)
                {
                    this.novation_ = value;
                }
            }
        }
        #endregion
        
        public string novationIDRef_ { get; set; }
        #region OptionExercise_
        private OptionExercise optionExercise_;
        public OptionExercise OptionExercise_
        {
            get
            {
                if (this.optionExercise_ != null)
                {
                    return this.optionExercise_; 
                }
                else if (this.optionExerciseIDRef_ != null)
                {
                    optionExercise_ = IDManager.getID(optionExerciseIDRef_) as OptionExercise;
                    return this.optionExercise_; 
                }
                else
                {
                      return this.optionExercise_; 
                }
            }
            set
            {
                if (this.optionExercise_ != value)
                {
                    this.optionExercise_ = value;
                }
            }
        }
        #endregion
        
        public string optionExerciseIDRef_ { get; set; }
        #region OptionExpiry_
        private List<OptionExpiry> optionExpiry_;
        public List<OptionExpiry> OptionExpiry_
        {
            get
            {
                if (this.optionExpiry_ != null)
                {
                    return this.optionExpiry_; 
                }
                else if (this.optionExpiryIDRef_ != null)
                {
                    return this.optionExpiry_; 
                }
                else
                {
                      return this.optionExpiry_; 
                }
            }
            set
            {
                if (this.optionExpiry_ != value)
                {
                    this.optionExpiry_ = value;
                }
            }
        }
        #endregion
        
        public string optionExpiryIDRef_ { get; set; }
        #region DeClear_
        private DeClear deClear_;
        public DeClear DeClear_
        {
            get
            {
                if (this.deClear_ != null)
                {
                    return this.deClear_; 
                }
                else if (this.deClearIDRef_ != null)
                {
                    deClear_ = IDManager.getID(deClearIDRef_) as DeClear;
                    return this.deClear_; 
                }
                else
                {
                      return this.deClear_; 
                }
            }
            set
            {
                if (this.deClear_ != value)
                {
                    this.deClear_ = value;
                }
            }
        }
        #endregion
        
        public string deClearIDRef_ { get; set; }
        #region Withdrawal_
        private Withdrawal withdrawal_;
        public Withdrawal Withdrawal_
        {
            get
            {
                if (this.withdrawal_ != null)
                {
                    return this.withdrawal_; 
                }
                else if (this.withdrawalIDRef_ != null)
                {
                    withdrawal_ = IDManager.getID(withdrawalIDRef_) as Withdrawal;
                    return this.withdrawal_; 
                }
                else
                {
                      return this.withdrawal_; 
                }
            }
            set
            {
                if (this.withdrawal_ != value)
                {
                    this.withdrawal_ = value;
                }
            }
        }
        #endregion
        
        public string withdrawalIDRef_ { get; set; }
        #region AdditionalEvent_
        private AdditionalEvent additionalEvent_;
        public AdditionalEvent AdditionalEvent_
        {
            get
            {
                if (this.additionalEvent_ != null)
                {
                    return this.additionalEvent_; 
                }
                else if (this.additionalEventIDRef_ != null)
                {
                    additionalEvent_ = IDManager.getID(additionalEventIDRef_) as AdditionalEvent;
                    return this.additionalEvent_; 
                }
                else
                {
                      return this.additionalEvent_; 
                }
            }
            set
            {
                if (this.additionalEvent_ != value)
                {
                    this.additionalEvent_ = value;
                }
            }
        }
        #endregion
        
        public string additionalEventIDRef_ { get; set; }
        #region TradeReferenceInformation_
        private TradeReferenceInformation tradeReferenceInformation_;
        public TradeReferenceInformation TradeReferenceInformation_
        {
            get
            {
                if (this.tradeReferenceInformation_ != null)
                {
                    return this.tradeReferenceInformation_; 
                }
                else if (this.tradeReferenceInformationIDRef_ != null)
                {
                    tradeReferenceInformation_ = IDManager.getID(tradeReferenceInformationIDRef_) as TradeReferenceInformation;
                    return this.tradeReferenceInformation_; 
                }
                else
                {
                      return this.tradeReferenceInformation_; 
                }
            }
            set
            {
                if (this.tradeReferenceInformation_ != value)
                {
                    this.tradeReferenceInformation_ = value;
                }
            }
        }
        #endregion
        
        public string tradeReferenceInformationIDRef_ { get; set; }
        #region Party_
        private List<Party> party_;
        public List<Party> Party_
        {
            get
            {
                if (this.party_ != null)
                {
                    return this.party_; 
                }
                else if (this.partyIDRef_ != null)
                {
                    return this.party_; 
                }
                else
                {
                      return this.party_; 
                }
            }
            set
            {
                if (this.party_ != value)
                {
                    this.party_ = value;
                }
            }
        }
        #endregion
        
        public string partyIDRef_ { get; set; }
        #region Account_
        private List<Account> account_;
        public List<Account> Account_
        {
            get
            {
                if (this.account_ != null)
                {
                    return this.account_; 
                }
                else if (this.accountIDRef_ != null)
                {
                    return this.account_; 
                }
                else
                {
                      return this.account_; 
                }
            }
            set
            {
                if (this.account_ != value)
                {
                    this.account_ = value;
                }
            }
        }
        #endregion
        
        public string accountIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

