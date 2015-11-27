using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EquityExerciseValuationSettlement
    {
        public EquityExerciseValuationSettlement(XmlNode xmlNode)
        {
            XmlNodeList equityEuropeanExerciseNodeList = xmlNode.SelectNodes("equityEuropeanExercise");
            if (equityEuropeanExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equityEuropeanExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equityEuropeanExerciseIDRef = item.Attributes["id"].Name;
                        EquityEuropeanExercise ob = EquityEuropeanExercise();
                        IDManager.SetID(equityEuropeanExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equityEuropeanExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equityEuropeanExercise = new EquityEuropeanExercise(item);
                    }
                }
            }
            
        
            XmlNodeList equityAmericanExerciseNodeList = xmlNode.SelectNodes("equityAmericanExercise");
            if (equityAmericanExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equityAmericanExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equityAmericanExerciseIDRef = item.Attributes["id"].Name;
                        EquityAmericanExercise ob = EquityAmericanExercise();
                        IDManager.SetID(equityAmericanExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equityAmericanExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equityAmericanExercise = new EquityAmericanExercise(item);
                    }
                }
            }
            
        
            XmlNodeList equityBermudaExerciseNodeList = xmlNode.SelectNodes("equityBermudaExercise");
            if (equityBermudaExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equityBermudaExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equityBermudaExerciseIDRef = item.Attributes["id"].Name;
                        EquityBermudaExercise ob = EquityBermudaExercise();
                        IDManager.SetID(equityBermudaExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equityBermudaExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equityBermudaExercise = new EquityBermudaExercise(item);
                    }
                }
            }
            
        
            XmlNodeList automaticExerciseNodeList = xmlNode.SelectNodes("automaticExercise");
            if (automaticExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in automaticExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        automaticExerciseIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(automaticExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        automaticExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        automaticExercise = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList makeWholeProvisionsNodeList = xmlNode.SelectNodes("makeWholeProvisions");
            if (makeWholeProvisionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in makeWholeProvisionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        makeWholeProvisionsIDRef = item.Attributes["id"].Name;
                        MakeWholeProvisions ob = MakeWholeProvisions();
                        IDManager.SetID(makeWholeProvisionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        makeWholeProvisionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        makeWholeProvisions = new MakeWholeProvisions(item);
                    }
                }
            }
            
        
            XmlNodeList prePaymentNodeList = xmlNode.SelectNodes("prePayment");
            if (prePaymentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in prePaymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        prePaymentIDRef = item.Attributes["id"].Name;
                        PrePayment ob = PrePayment();
                        IDManager.SetID(prePaymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        prePaymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        prePayment = new PrePayment(item);
                    }
                }
            }
            
        
            XmlNodeList equityValuationNodeList = xmlNode.SelectNodes("equityValuation");
            if (equityValuationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equityValuationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equityValuationIDRef = item.Attributes["id"].Name;
                        EquityValuation ob = EquityValuation();
                        IDManager.SetID(equityValuationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equityValuationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equityValuation = new EquityValuation(item);
                    }
                }
            }
            
        
            XmlNodeList settlementDateNodeList = xmlNode.SelectNodes("settlementDate");
            if (settlementDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(settlementDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList settlementCurrencyNodeList = xmlNode.SelectNodes("settlementCurrency");
            if (settlementCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementCurrencyIDRef = item.Attributes["id"].Name;
                        Currency ob = Currency();
                        IDManager.SetID(settlementCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementCurrency = new Currency(item);
                    }
                }
            }
            
        
            XmlNodeList settlementPriceSourceNodeList = xmlNode.SelectNodes("settlementPriceSource");
            if (settlementPriceSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementPriceSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementPriceSourceIDRef = item.Attributes["id"].Name;
                        SettlementPriceSource ob = SettlementPriceSource();
                        IDManager.SetID(settlementPriceSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementPriceSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementPriceSource = new SettlementPriceSource(item);
                    }
                }
            }
            
        
            XmlNodeList settlementTypeNodeList = xmlNode.SelectNodes("settlementType");
            if (settlementTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementTypeIDRef = item.Attributes["id"].Name;
                        SettlementTypeEnum ob = SettlementTypeEnum();
                        IDManager.SetID(settlementTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementType = new SettlementTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList settlementMethodElectionDateNodeList = xmlNode.SelectNodes("settlementMethodElectionDate");
            if (settlementMethodElectionDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementMethodElectionDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementMethodElectionDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(settlementMethodElectionDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementMethodElectionDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementMethodElectionDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList settlementMethodElectingPartyReferenceNodeList = xmlNode.SelectNodes("settlementMethodElectingPartyReference");
            if (settlementMethodElectingPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementMethodElectingPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementMethodElectingPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(settlementMethodElectingPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementMethodElectingPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementMethodElectingPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList settlementPriceDefaultElectionNodeList = xmlNode.SelectNodes("settlementPriceDefaultElection");
            if (settlementPriceDefaultElectionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementPriceDefaultElectionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementPriceDefaultElectionIDRef = item.Attributes["id"].Name;
                        SettlementPriceDefaultElection ob = SettlementPriceDefaultElection();
                        IDManager.SetID(settlementPriceDefaultElectionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementPriceDefaultElectionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementPriceDefaultElection = new SettlementPriceDefaultElection(item);
                    }
                }
            }
            
        
        }
        
    
        #region EquityEuropeanExercise
        private EquityEuropeanExercise equityEuropeanExercise;
        public EquityEuropeanExercise EquityEuropeanExercise
        {
            get
            {
                if (this.equityEuropeanExercise != null)
                {
                    return this.equityEuropeanExercise; 
                }
                else if (this.equityEuropeanExerciseIDRef != null)
                {
                    equityEuropeanExercise = IDManager.getID(equityEuropeanExerciseIDRef) as EquityEuropeanExercise;
                    return this.equityEuropeanExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equityEuropeanExercise != value)
                {
                    this.equityEuropeanExercise = value;
                }
            }
        }
        #endregion
        
        public string EquityEuropeanExerciseIDRef { get; set; }
        #region EquityAmericanExercise
        private EquityAmericanExercise equityAmericanExercise;
        public EquityAmericanExercise EquityAmericanExercise
        {
            get
            {
                if (this.equityAmericanExercise != null)
                {
                    return this.equityAmericanExercise; 
                }
                else if (this.equityAmericanExerciseIDRef != null)
                {
                    equityAmericanExercise = IDManager.getID(equityAmericanExerciseIDRef) as EquityAmericanExercise;
                    return this.equityAmericanExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equityAmericanExercise != value)
                {
                    this.equityAmericanExercise = value;
                }
            }
        }
        #endregion
        
        public string EquityAmericanExerciseIDRef { get; set; }
        #region EquityBermudaExercise
        private EquityBermudaExercise equityBermudaExercise;
        public EquityBermudaExercise EquityBermudaExercise
        {
            get
            {
                if (this.equityBermudaExercise != null)
                {
                    return this.equityBermudaExercise; 
                }
                else if (this.equityBermudaExerciseIDRef != null)
                {
                    equityBermudaExercise = IDManager.getID(equityBermudaExerciseIDRef) as EquityBermudaExercise;
                    return this.equityBermudaExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equityBermudaExercise != value)
                {
                    this.equityBermudaExercise = value;
                }
            }
        }
        #endregion
        
        public string EquityBermudaExerciseIDRef { get; set; }
        #region AutomaticExercise
        private XsdTypeBoolean automaticExercise;
        public XsdTypeBoolean AutomaticExercise
        {
            get
            {
                if (this.automaticExercise != null)
                {
                    return this.automaticExercise; 
                }
                else if (this.automaticExerciseIDRef != null)
                {
                    automaticExercise = IDManager.getID(automaticExerciseIDRef) as XsdTypeBoolean;
                    return this.automaticExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.automaticExercise != value)
                {
                    this.automaticExercise = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region MakeWholeProvisions
        private MakeWholeProvisions makeWholeProvisions;
        public MakeWholeProvisions MakeWholeProvisions
        {
            get
            {
                if (this.makeWholeProvisions != null)
                {
                    return this.makeWholeProvisions; 
                }
                else if (this.makeWholeProvisionsIDRef != null)
                {
                    makeWholeProvisions = IDManager.getID(makeWholeProvisionsIDRef) as MakeWholeProvisions;
                    return this.makeWholeProvisions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.makeWholeProvisions != value)
                {
                    this.makeWholeProvisions = value;
                }
            }
        }
        #endregion
        
        public string MakeWholeProvisionsIDRef { get; set; }
        #region PrePayment
        private PrePayment prePayment;
        public PrePayment PrePayment
        {
            get
            {
                if (this.prePayment != null)
                {
                    return this.prePayment; 
                }
                else if (this.prePaymentIDRef != null)
                {
                    prePayment = IDManager.getID(prePaymentIDRef) as PrePayment;
                    return this.prePayment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.prePayment != value)
                {
                    this.prePayment = value;
                }
            }
        }
        #endregion
        
        public string PrePaymentIDRef { get; set; }
        #region EquityValuation
        private EquityValuation equityValuation;
        public EquityValuation EquityValuation
        {
            get
            {
                if (this.equityValuation != null)
                {
                    return this.equityValuation; 
                }
                else if (this.equityValuationIDRef != null)
                {
                    equityValuation = IDManager.getID(equityValuationIDRef) as EquityValuation;
                    return this.equityValuation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equityValuation != value)
                {
                    this.equityValuation = value;
                }
            }
        }
        #endregion
        
        public string EquityValuationIDRef { get; set; }
        #region SettlementDate
        private AdjustableOrRelativeDate settlementDate;
        public AdjustableOrRelativeDate SettlementDate
        {
            get
            {
                if (this.settlementDate != null)
                {
                    return this.settlementDate; 
                }
                else if (this.settlementDateIDRef != null)
                {
                    settlementDate = IDManager.getID(settlementDateIDRef) as AdjustableOrRelativeDate;
                    return this.settlementDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementDate != value)
                {
                    this.settlementDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region SettlementCurrency
        private Currency settlementCurrency;
        public Currency SettlementCurrency
        {
            get
            {
                if (this.settlementCurrency != null)
                {
                    return this.settlementCurrency; 
                }
                else if (this.settlementCurrencyIDRef != null)
                {
                    settlementCurrency = IDManager.getID(settlementCurrencyIDRef) as Currency;
                    return this.settlementCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementCurrency != value)
                {
                    this.settlementCurrency = value;
                }
            }
        }
        #endregion
        
        public string CurrencyIDRef { get; set; }
        #region SettlementPriceSource
        private SettlementPriceSource settlementPriceSource;
        public SettlementPriceSource SettlementPriceSource
        {
            get
            {
                if (this.settlementPriceSource != null)
                {
                    return this.settlementPriceSource; 
                }
                else if (this.settlementPriceSourceIDRef != null)
                {
                    settlementPriceSource = IDManager.getID(settlementPriceSourceIDRef) as SettlementPriceSource;
                    return this.settlementPriceSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementPriceSource != value)
                {
                    this.settlementPriceSource = value;
                }
            }
        }
        #endregion
        
        public string SettlementPriceSourceIDRef { get; set; }
        #region SettlementType
        private SettlementTypeEnum settlementType;
        public SettlementTypeEnum SettlementType
        {
            get
            {
                if (this.settlementType != null)
                {
                    return this.settlementType; 
                }
                else if (this.settlementTypeIDRef != null)
                {
                    settlementType = IDManager.getID(settlementTypeIDRef) as SettlementTypeEnum;
                    return this.settlementType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementType != value)
                {
                    this.settlementType = value;
                }
            }
        }
        #endregion
        
        public string SettlementTypeEnumIDRef { get; set; }
        #region SettlementMethodElectionDate
        private AdjustableOrRelativeDate settlementMethodElectionDate;
        public AdjustableOrRelativeDate SettlementMethodElectionDate
        {
            get
            {
                if (this.settlementMethodElectionDate != null)
                {
                    return this.settlementMethodElectionDate; 
                }
                else if (this.settlementMethodElectionDateIDRef != null)
                {
                    settlementMethodElectionDate = IDManager.getID(settlementMethodElectionDateIDRef) as AdjustableOrRelativeDate;
                    return this.settlementMethodElectionDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementMethodElectionDate != value)
                {
                    this.settlementMethodElectionDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region SettlementMethodElectingPartyReference
        private PartyReference settlementMethodElectingPartyReference;
        public PartyReference SettlementMethodElectingPartyReference
        {
            get
            {
                if (this.settlementMethodElectingPartyReference != null)
                {
                    return this.settlementMethodElectingPartyReference; 
                }
                else if (this.settlementMethodElectingPartyReferenceIDRef != null)
                {
                    settlementMethodElectingPartyReference = IDManager.getID(settlementMethodElectingPartyReferenceIDRef) as PartyReference;
                    return this.settlementMethodElectingPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementMethodElectingPartyReference != value)
                {
                    this.settlementMethodElectingPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region SettlementPriceDefaultElection
        private SettlementPriceDefaultElection settlementPriceDefaultElection;
        public SettlementPriceDefaultElection SettlementPriceDefaultElection
        {
            get
            {
                if (this.settlementPriceDefaultElection != null)
                {
                    return this.settlementPriceDefaultElection; 
                }
                else if (this.settlementPriceDefaultElectionIDRef != null)
                {
                    settlementPriceDefaultElection = IDManager.getID(settlementPriceDefaultElectionIDRef) as SettlementPriceDefaultElection;
                    return this.settlementPriceDefaultElection; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementPriceDefaultElection != value)
                {
                    this.settlementPriceDefaultElection = value;
                }
            }
        }
        #endregion
        
        public string SettlementPriceDefaultElectionIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

