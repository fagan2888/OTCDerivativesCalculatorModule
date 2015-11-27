using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EquityExerciseValuationSettlement : ISerialized
    {
        public EquityExerciseValuationSettlement(XmlNode xmlNode)
        {
            XmlNode equityEuropeanExerciseNode = xmlNode.SelectSingleNode("equityEuropeanExercise");
            
            if (equityEuropeanExerciseNode != null)
            {
                if (equityEuropeanExerciseNode.Attributes["href"] != null || equityEuropeanExerciseNode.Attributes["id"] != null) 
                {
                    if (equityEuropeanExerciseNode.Attributes["id"] != null) 
                    {
                        equityEuropeanExerciseIDRef_ = equityEuropeanExerciseNode.Attributes["id"].Value;
                        EquityEuropeanExercise ob = new EquityEuropeanExercise(equityEuropeanExerciseNode);
                        IDManager.SetID(equityEuropeanExerciseIDRef_, ob);
                    }
                    else if (equityEuropeanExerciseNode.Attributes["href"] != null)
                    {
                        equityEuropeanExerciseIDRef_ = equityEuropeanExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equityEuropeanExercise_ = new EquityEuropeanExercise(equityEuropeanExerciseNode);
                    }
                }
                else
                {
                    equityEuropeanExercise_ = new EquityEuropeanExercise(equityEuropeanExerciseNode);
                }
            }
            
        
            XmlNode equityAmericanExerciseNode = xmlNode.SelectSingleNode("equityAmericanExercise");
            
            if (equityAmericanExerciseNode != null)
            {
                if (equityAmericanExerciseNode.Attributes["href"] != null || equityAmericanExerciseNode.Attributes["id"] != null) 
                {
                    if (equityAmericanExerciseNode.Attributes["id"] != null) 
                    {
                        equityAmericanExerciseIDRef_ = equityAmericanExerciseNode.Attributes["id"].Value;
                        EquityAmericanExercise ob = new EquityAmericanExercise(equityAmericanExerciseNode);
                        IDManager.SetID(equityAmericanExerciseIDRef_, ob);
                    }
                    else if (equityAmericanExerciseNode.Attributes["href"] != null)
                    {
                        equityAmericanExerciseIDRef_ = equityAmericanExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equityAmericanExercise_ = new EquityAmericanExercise(equityAmericanExerciseNode);
                    }
                }
                else
                {
                    equityAmericanExercise_ = new EquityAmericanExercise(equityAmericanExerciseNode);
                }
            }
            
        
            XmlNode equityBermudaExerciseNode = xmlNode.SelectSingleNode("equityBermudaExercise");
            
            if (equityBermudaExerciseNode != null)
            {
                if (equityBermudaExerciseNode.Attributes["href"] != null || equityBermudaExerciseNode.Attributes["id"] != null) 
                {
                    if (equityBermudaExerciseNode.Attributes["id"] != null) 
                    {
                        equityBermudaExerciseIDRef_ = equityBermudaExerciseNode.Attributes["id"].Value;
                        EquityBermudaExercise ob = new EquityBermudaExercise(equityBermudaExerciseNode);
                        IDManager.SetID(equityBermudaExerciseIDRef_, ob);
                    }
                    else if (equityBermudaExerciseNode.Attributes["href"] != null)
                    {
                        equityBermudaExerciseIDRef_ = equityBermudaExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equityBermudaExercise_ = new EquityBermudaExercise(equityBermudaExerciseNode);
                    }
                }
                else
                {
                    equityBermudaExercise_ = new EquityBermudaExercise(equityBermudaExerciseNode);
                }
            }
            
        
            XmlNode automaticExerciseNode = xmlNode.SelectSingleNode("automaticExercise");
            
            if (automaticExerciseNode != null)
            {
                if (automaticExerciseNode.Attributes["href"] != null || automaticExerciseNode.Attributes["id"] != null) 
                {
                    if (automaticExerciseNode.Attributes["id"] != null) 
                    {
                        automaticExerciseIDRef_ = automaticExerciseNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(automaticExerciseNode);
                        IDManager.SetID(automaticExerciseIDRef_, ob);
                    }
                    else if (automaticExerciseNode.Attributes["href"] != null)
                    {
                        automaticExerciseIDRef_ = automaticExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        automaticExercise_ = new XsdTypeBoolean(automaticExerciseNode);
                    }
                }
                else
                {
                    automaticExercise_ = new XsdTypeBoolean(automaticExerciseNode);
                }
            }
            
        
            XmlNode makeWholeProvisionsNode = xmlNode.SelectSingleNode("makeWholeProvisions");
            
            if (makeWholeProvisionsNode != null)
            {
                if (makeWholeProvisionsNode.Attributes["href"] != null || makeWholeProvisionsNode.Attributes["id"] != null) 
                {
                    if (makeWholeProvisionsNode.Attributes["id"] != null) 
                    {
                        makeWholeProvisionsIDRef_ = makeWholeProvisionsNode.Attributes["id"].Value;
                        MakeWholeProvisions ob = new MakeWholeProvisions(makeWholeProvisionsNode);
                        IDManager.SetID(makeWholeProvisionsIDRef_, ob);
                    }
                    else if (makeWholeProvisionsNode.Attributes["href"] != null)
                    {
                        makeWholeProvisionsIDRef_ = makeWholeProvisionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        makeWholeProvisions_ = new MakeWholeProvisions(makeWholeProvisionsNode);
                    }
                }
                else
                {
                    makeWholeProvisions_ = new MakeWholeProvisions(makeWholeProvisionsNode);
                }
            }
            
        
            XmlNode prePaymentNode = xmlNode.SelectSingleNode("prePayment");
            
            if (prePaymentNode != null)
            {
                if (prePaymentNode.Attributes["href"] != null || prePaymentNode.Attributes["id"] != null) 
                {
                    if (prePaymentNode.Attributes["id"] != null) 
                    {
                        prePaymentIDRef_ = prePaymentNode.Attributes["id"].Value;
                        PrePayment ob = new PrePayment(prePaymentNode);
                        IDManager.SetID(prePaymentIDRef_, ob);
                    }
                    else if (prePaymentNode.Attributes["href"] != null)
                    {
                        prePaymentIDRef_ = prePaymentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        prePayment_ = new PrePayment(prePaymentNode);
                    }
                }
                else
                {
                    prePayment_ = new PrePayment(prePaymentNode);
                }
            }
            
        
            XmlNode equityValuationNode = xmlNode.SelectSingleNode("equityValuation");
            
            if (equityValuationNode != null)
            {
                if (equityValuationNode.Attributes["href"] != null || equityValuationNode.Attributes["id"] != null) 
                {
                    if (equityValuationNode.Attributes["id"] != null) 
                    {
                        equityValuationIDRef_ = equityValuationNode.Attributes["id"].Value;
                        EquityValuation ob = new EquityValuation(equityValuationNode);
                        IDManager.SetID(equityValuationIDRef_, ob);
                    }
                    else if (equityValuationNode.Attributes["href"] != null)
                    {
                        equityValuationIDRef_ = equityValuationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equityValuation_ = new EquityValuation(equityValuationNode);
                    }
                }
                else
                {
                    equityValuation_ = new EquityValuation(equityValuationNode);
                }
            }
            
        
            XmlNode settlementDateNode = xmlNode.SelectSingleNode("settlementDate");
            
            if (settlementDateNode != null)
            {
                if (settlementDateNode.Attributes["href"] != null || settlementDateNode.Attributes["id"] != null) 
                {
                    if (settlementDateNode.Attributes["id"] != null) 
                    {
                        settlementDateIDRef_ = settlementDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(settlementDateNode);
                        IDManager.SetID(settlementDateIDRef_, ob);
                    }
                    else if (settlementDateNode.Attributes["href"] != null)
                    {
                        settlementDateIDRef_ = settlementDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementDate_ = new AdjustableOrRelativeDate(settlementDateNode);
                    }
                }
                else
                {
                    settlementDate_ = new AdjustableOrRelativeDate(settlementDateNode);
                }
            }
            
        
            XmlNode settlementCurrencyNode = xmlNode.SelectSingleNode("settlementCurrency");
            
            if (settlementCurrencyNode != null)
            {
                if (settlementCurrencyNode.Attributes["href"] != null || settlementCurrencyNode.Attributes["id"] != null) 
                {
                    if (settlementCurrencyNode.Attributes["id"] != null) 
                    {
                        settlementCurrencyIDRef_ = settlementCurrencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(settlementCurrencyNode);
                        IDManager.SetID(settlementCurrencyIDRef_, ob);
                    }
                    else if (settlementCurrencyNode.Attributes["href"] != null)
                    {
                        settlementCurrencyIDRef_ = settlementCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementCurrency_ = new Currency(settlementCurrencyNode);
                    }
                }
                else
                {
                    settlementCurrency_ = new Currency(settlementCurrencyNode);
                }
            }
            
        
            XmlNode settlementPriceSourceNode = xmlNode.SelectSingleNode("settlementPriceSource");
            
            if (settlementPriceSourceNode != null)
            {
                if (settlementPriceSourceNode.Attributes["href"] != null || settlementPriceSourceNode.Attributes["id"] != null) 
                {
                    if (settlementPriceSourceNode.Attributes["id"] != null) 
                    {
                        settlementPriceSourceIDRef_ = settlementPriceSourceNode.Attributes["id"].Value;
                        SettlementPriceSource ob = new SettlementPriceSource(settlementPriceSourceNode);
                        IDManager.SetID(settlementPriceSourceIDRef_, ob);
                    }
                    else if (settlementPriceSourceNode.Attributes["href"] != null)
                    {
                        settlementPriceSourceIDRef_ = settlementPriceSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementPriceSource_ = new SettlementPriceSource(settlementPriceSourceNode);
                    }
                }
                else
                {
                    settlementPriceSource_ = new SettlementPriceSource(settlementPriceSourceNode);
                }
            }
            
        
            XmlNode settlementTypeNode = xmlNode.SelectSingleNode("settlementType");
            
            if (settlementTypeNode != null)
            {
                if (settlementTypeNode.Attributes["href"] != null || settlementTypeNode.Attributes["id"] != null) 
                {
                    if (settlementTypeNode.Attributes["id"] != null) 
                    {
                        settlementTypeIDRef_ = settlementTypeNode.Attributes["id"].Value;
                        SettlementTypeEnum ob = new SettlementTypeEnum(settlementTypeNode);
                        IDManager.SetID(settlementTypeIDRef_, ob);
                    }
                    else if (settlementTypeNode.Attributes["href"] != null)
                    {
                        settlementTypeIDRef_ = settlementTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementType_ = new SettlementTypeEnum(settlementTypeNode);
                    }
                }
                else
                {
                    settlementType_ = new SettlementTypeEnum(settlementTypeNode);
                }
            }
            
        
            XmlNode settlementMethodElectionDateNode = xmlNode.SelectSingleNode("settlementMethodElectionDate");
            
            if (settlementMethodElectionDateNode != null)
            {
                if (settlementMethodElectionDateNode.Attributes["href"] != null || settlementMethodElectionDateNode.Attributes["id"] != null) 
                {
                    if (settlementMethodElectionDateNode.Attributes["id"] != null) 
                    {
                        settlementMethodElectionDateIDRef_ = settlementMethodElectionDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(settlementMethodElectionDateNode);
                        IDManager.SetID(settlementMethodElectionDateIDRef_, ob);
                    }
                    else if (settlementMethodElectionDateNode.Attributes["href"] != null)
                    {
                        settlementMethodElectionDateIDRef_ = settlementMethodElectionDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementMethodElectionDate_ = new AdjustableOrRelativeDate(settlementMethodElectionDateNode);
                    }
                }
                else
                {
                    settlementMethodElectionDate_ = new AdjustableOrRelativeDate(settlementMethodElectionDateNode);
                }
            }
            
        
            XmlNode settlementMethodElectingPartyReferenceNode = xmlNode.SelectSingleNode("settlementMethodElectingPartyReference");
            
            if (settlementMethodElectingPartyReferenceNode != null)
            {
                if (settlementMethodElectingPartyReferenceNode.Attributes["href"] != null || settlementMethodElectingPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (settlementMethodElectingPartyReferenceNode.Attributes["id"] != null) 
                    {
                        settlementMethodElectingPartyReferenceIDRef_ = settlementMethodElectingPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(settlementMethodElectingPartyReferenceNode);
                        IDManager.SetID(settlementMethodElectingPartyReferenceIDRef_, ob);
                    }
                    else if (settlementMethodElectingPartyReferenceNode.Attributes["href"] != null)
                    {
                        settlementMethodElectingPartyReferenceIDRef_ = settlementMethodElectingPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementMethodElectingPartyReference_ = new PartyReference(settlementMethodElectingPartyReferenceNode);
                    }
                }
                else
                {
                    settlementMethodElectingPartyReference_ = new PartyReference(settlementMethodElectingPartyReferenceNode);
                }
            }
            
        
            XmlNode settlementPriceDefaultElectionNode = xmlNode.SelectSingleNode("settlementPriceDefaultElection");
            
            if (settlementPriceDefaultElectionNode != null)
            {
                if (settlementPriceDefaultElectionNode.Attributes["href"] != null || settlementPriceDefaultElectionNode.Attributes["id"] != null) 
                {
                    if (settlementPriceDefaultElectionNode.Attributes["id"] != null) 
                    {
                        settlementPriceDefaultElectionIDRef_ = settlementPriceDefaultElectionNode.Attributes["id"].Value;
                        SettlementPriceDefaultElection ob = new SettlementPriceDefaultElection(settlementPriceDefaultElectionNode);
                        IDManager.SetID(settlementPriceDefaultElectionIDRef_, ob);
                    }
                    else if (settlementPriceDefaultElectionNode.Attributes["href"] != null)
                    {
                        settlementPriceDefaultElectionIDRef_ = settlementPriceDefaultElectionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementPriceDefaultElection_ = new SettlementPriceDefaultElection(settlementPriceDefaultElectionNode);
                    }
                }
                else
                {
                    settlementPriceDefaultElection_ = new SettlementPriceDefaultElection(settlementPriceDefaultElectionNode);
                }
            }
            
        
        }
        
    
        #region EquityEuropeanExercise_
        private EquityEuropeanExercise equityEuropeanExercise_;
        public EquityEuropeanExercise EquityEuropeanExercise_
        {
            get
            {
                if (this.equityEuropeanExercise_ != null)
                {
                    return this.equityEuropeanExercise_; 
                }
                else if (this.equityEuropeanExerciseIDRef_ != null)
                {
                    equityEuropeanExercise_ = IDManager.getID(equityEuropeanExerciseIDRef_) as EquityEuropeanExercise;
                    return this.equityEuropeanExercise_; 
                }
                else
                {
                      return this.equityEuropeanExercise_; 
                }
            }
            set
            {
                if (this.equityEuropeanExercise_ != value)
                {
                    this.equityEuropeanExercise_ = value;
                }
            }
        }
        #endregion
        
        public string equityEuropeanExerciseIDRef_ { get; set; }
        #region EquityAmericanExercise_
        private EquityAmericanExercise equityAmericanExercise_;
        public EquityAmericanExercise EquityAmericanExercise_
        {
            get
            {
                if (this.equityAmericanExercise_ != null)
                {
                    return this.equityAmericanExercise_; 
                }
                else if (this.equityAmericanExerciseIDRef_ != null)
                {
                    equityAmericanExercise_ = IDManager.getID(equityAmericanExerciseIDRef_) as EquityAmericanExercise;
                    return this.equityAmericanExercise_; 
                }
                else
                {
                      return this.equityAmericanExercise_; 
                }
            }
            set
            {
                if (this.equityAmericanExercise_ != value)
                {
                    this.equityAmericanExercise_ = value;
                }
            }
        }
        #endregion
        
        public string equityAmericanExerciseIDRef_ { get; set; }
        #region EquityBermudaExercise_
        private EquityBermudaExercise equityBermudaExercise_;
        public EquityBermudaExercise EquityBermudaExercise_
        {
            get
            {
                if (this.equityBermudaExercise_ != null)
                {
                    return this.equityBermudaExercise_; 
                }
                else if (this.equityBermudaExerciseIDRef_ != null)
                {
                    equityBermudaExercise_ = IDManager.getID(equityBermudaExerciseIDRef_) as EquityBermudaExercise;
                    return this.equityBermudaExercise_; 
                }
                else
                {
                      return this.equityBermudaExercise_; 
                }
            }
            set
            {
                if (this.equityBermudaExercise_ != value)
                {
                    this.equityBermudaExercise_ = value;
                }
            }
        }
        #endregion
        
        public string equityBermudaExerciseIDRef_ { get; set; }
        #region AutomaticExercise_
        private XsdTypeBoolean automaticExercise_;
        public XsdTypeBoolean AutomaticExercise_
        {
            get
            {
                if (this.automaticExercise_ != null)
                {
                    return this.automaticExercise_; 
                }
                else if (this.automaticExerciseIDRef_ != null)
                {
                    automaticExercise_ = IDManager.getID(automaticExerciseIDRef_) as XsdTypeBoolean;
                    return this.automaticExercise_; 
                }
                else
                {
                      return this.automaticExercise_; 
                }
            }
            set
            {
                if (this.automaticExercise_ != value)
                {
                    this.automaticExercise_ = value;
                }
            }
        }
        #endregion
        
        public string automaticExerciseIDRef_ { get; set; }
        #region MakeWholeProvisions_
        private MakeWholeProvisions makeWholeProvisions_;
        public MakeWholeProvisions MakeWholeProvisions_
        {
            get
            {
                if (this.makeWholeProvisions_ != null)
                {
                    return this.makeWholeProvisions_; 
                }
                else if (this.makeWholeProvisionsIDRef_ != null)
                {
                    makeWholeProvisions_ = IDManager.getID(makeWholeProvisionsIDRef_) as MakeWholeProvisions;
                    return this.makeWholeProvisions_; 
                }
                else
                {
                      return this.makeWholeProvisions_; 
                }
            }
            set
            {
                if (this.makeWholeProvisions_ != value)
                {
                    this.makeWholeProvisions_ = value;
                }
            }
        }
        #endregion
        
        public string makeWholeProvisionsIDRef_ { get; set; }
        #region PrePayment_
        private PrePayment prePayment_;
        public PrePayment PrePayment_
        {
            get
            {
                if (this.prePayment_ != null)
                {
                    return this.prePayment_; 
                }
                else if (this.prePaymentIDRef_ != null)
                {
                    prePayment_ = IDManager.getID(prePaymentIDRef_) as PrePayment;
                    return this.prePayment_; 
                }
                else
                {
                      return this.prePayment_; 
                }
            }
            set
            {
                if (this.prePayment_ != value)
                {
                    this.prePayment_ = value;
                }
            }
        }
        #endregion
        
        public string prePaymentIDRef_ { get; set; }
        #region EquityValuation_
        private EquityValuation equityValuation_;
        public EquityValuation EquityValuation_
        {
            get
            {
                if (this.equityValuation_ != null)
                {
                    return this.equityValuation_; 
                }
                else if (this.equityValuationIDRef_ != null)
                {
                    equityValuation_ = IDManager.getID(equityValuationIDRef_) as EquityValuation;
                    return this.equityValuation_; 
                }
                else
                {
                      return this.equityValuation_; 
                }
            }
            set
            {
                if (this.equityValuation_ != value)
                {
                    this.equityValuation_ = value;
                }
            }
        }
        #endregion
        
        public string equityValuationIDRef_ { get; set; }
        #region SettlementDate_
        private AdjustableOrRelativeDate settlementDate_;
        public AdjustableOrRelativeDate SettlementDate_
        {
            get
            {
                if (this.settlementDate_ != null)
                {
                    return this.settlementDate_; 
                }
                else if (this.settlementDateIDRef_ != null)
                {
                    settlementDate_ = IDManager.getID(settlementDateIDRef_) as AdjustableOrRelativeDate;
                    return this.settlementDate_; 
                }
                else
                {
                      return this.settlementDate_; 
                }
            }
            set
            {
                if (this.settlementDate_ != value)
                {
                    this.settlementDate_ = value;
                }
            }
        }
        #endregion
        
        public string settlementDateIDRef_ { get; set; }
        #region SettlementCurrency_
        private Currency settlementCurrency_;
        public Currency SettlementCurrency_
        {
            get
            {
                if (this.settlementCurrency_ != null)
                {
                    return this.settlementCurrency_; 
                }
                else if (this.settlementCurrencyIDRef_ != null)
                {
                    settlementCurrency_ = IDManager.getID(settlementCurrencyIDRef_) as Currency;
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
        #region SettlementPriceSource_
        private SettlementPriceSource settlementPriceSource_;
        public SettlementPriceSource SettlementPriceSource_
        {
            get
            {
                if (this.settlementPriceSource_ != null)
                {
                    return this.settlementPriceSource_; 
                }
                else if (this.settlementPriceSourceIDRef_ != null)
                {
                    settlementPriceSource_ = IDManager.getID(settlementPriceSourceIDRef_) as SettlementPriceSource;
                    return this.settlementPriceSource_; 
                }
                else
                {
                      return this.settlementPriceSource_; 
                }
            }
            set
            {
                if (this.settlementPriceSource_ != value)
                {
                    this.settlementPriceSource_ = value;
                }
            }
        }
        #endregion
        
        public string settlementPriceSourceIDRef_ { get; set; }
        #region SettlementType_
        private SettlementTypeEnum settlementType_;
        public SettlementTypeEnum SettlementType_
        {
            get
            {
                if (this.settlementType_ != null)
                {
                    return this.settlementType_; 
                }
                else if (this.settlementTypeIDRef_ != null)
                {
                    settlementType_ = IDManager.getID(settlementTypeIDRef_) as SettlementTypeEnum;
                    return this.settlementType_; 
                }
                else
                {
                      return this.settlementType_; 
                }
            }
            set
            {
                if (this.settlementType_ != value)
                {
                    this.settlementType_ = value;
                }
            }
        }
        #endregion
        
        public string settlementTypeIDRef_ { get; set; }
        #region SettlementMethodElectionDate_
        private AdjustableOrRelativeDate settlementMethodElectionDate_;
        public AdjustableOrRelativeDate SettlementMethodElectionDate_
        {
            get
            {
                if (this.settlementMethodElectionDate_ != null)
                {
                    return this.settlementMethodElectionDate_; 
                }
                else if (this.settlementMethodElectionDateIDRef_ != null)
                {
                    settlementMethodElectionDate_ = IDManager.getID(settlementMethodElectionDateIDRef_) as AdjustableOrRelativeDate;
                    return this.settlementMethodElectionDate_; 
                }
                else
                {
                      return this.settlementMethodElectionDate_; 
                }
            }
            set
            {
                if (this.settlementMethodElectionDate_ != value)
                {
                    this.settlementMethodElectionDate_ = value;
                }
            }
        }
        #endregion
        
        public string settlementMethodElectionDateIDRef_ { get; set; }
        #region SettlementMethodElectingPartyReference_
        private PartyReference settlementMethodElectingPartyReference_;
        public PartyReference SettlementMethodElectingPartyReference_
        {
            get
            {
                if (this.settlementMethodElectingPartyReference_ != null)
                {
                    return this.settlementMethodElectingPartyReference_; 
                }
                else if (this.settlementMethodElectingPartyReferenceIDRef_ != null)
                {
                    settlementMethodElectingPartyReference_ = IDManager.getID(settlementMethodElectingPartyReferenceIDRef_) as PartyReference;
                    return this.settlementMethodElectingPartyReference_; 
                }
                else
                {
                      return this.settlementMethodElectingPartyReference_; 
                }
            }
            set
            {
                if (this.settlementMethodElectingPartyReference_ != value)
                {
                    this.settlementMethodElectingPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string settlementMethodElectingPartyReferenceIDRef_ { get; set; }
        #region SettlementPriceDefaultElection_
        private SettlementPriceDefaultElection settlementPriceDefaultElection_;
        public SettlementPriceDefaultElection SettlementPriceDefaultElection_
        {
            get
            {
                if (this.settlementPriceDefaultElection_ != null)
                {
                    return this.settlementPriceDefaultElection_; 
                }
                else if (this.settlementPriceDefaultElectionIDRef_ != null)
                {
                    settlementPriceDefaultElection_ = IDManager.getID(settlementPriceDefaultElectionIDRef_) as SettlementPriceDefaultElection;
                    return this.settlementPriceDefaultElection_; 
                }
                else
                {
                      return this.settlementPriceDefaultElection_; 
                }
            }
            set
            {
                if (this.settlementPriceDefaultElection_ != value)
                {
                    this.settlementPriceDefaultElection_ = value;
                }
            }
        }
        #endregion
        
        public string settlementPriceDefaultElectionIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

