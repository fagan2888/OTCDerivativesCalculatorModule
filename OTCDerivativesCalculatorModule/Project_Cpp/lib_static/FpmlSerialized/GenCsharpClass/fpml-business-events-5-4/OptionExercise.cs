using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class OptionExercise
    {
        public OptionExercise(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList optionSellerNodeList = xmlNode.SelectNodes("optionSeller");
            if (optionSellerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionSellerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionSellerIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(optionSellerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionSellerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionSeller = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList optionBuyerNodeList = xmlNode.SelectNodes("optionBuyer");
            if (optionBuyerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionBuyerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionBuyerIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(optionBuyerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionBuyerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionBuyer = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList originalTradeNodeList = xmlNode.SelectNodes("originalTrade");
            if (originalTradeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in originalTradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        originalTradeIDRef = item.Attributes["id"].Name;
                        Trade ob = Trade();
                        IDManager.SetID(originalTradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        originalTradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        originalTrade = new Trade(item);
                    }
                }
            }
            
        
            XmlNodeList tradeIdentifierNodeList = xmlNode.SelectNodes("tradeIdentifier");
            
            foreach (XmlNode item in tradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeIdentifierIDRef = item.Attributes["id"].Name;
                        List<PartyTradeIdentifier> ob = new List<PartyTradeIdentifier>();
                        ob.Add(new PartyTradeIdentifier(item));
                        IDManager.SetID(tradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    tradeIdentifier.Add(new PartyTradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNodeList exerciseDateNodeList = xmlNode.SelectNodes("exerciseDate");
            if (exerciseDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exerciseDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(exerciseDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exerciseDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList exerciseTimeNodeList = xmlNode.SelectNodes("exerciseTime");
            if (exerciseTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exerciseTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseTimeIDRef = item.Attributes["id"].Name;
                        XsdTypeTime ob = XsdTypeTime();
                        IDManager.SetID(exerciseTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exerciseTime = new XsdTypeTime(item);
                    }
                }
            }
            
        
            XmlNodeList expiryNodeList = xmlNode.SelectNodes("expiry");
            if (expiryNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in expiryNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        expiryIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(expiryIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        expiryIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        expiry = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList fullExerciseNodeList = xmlNode.SelectNodes("fullExercise");
            if (fullExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fullExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fullExerciseIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(fullExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fullExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fullExercise = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList exerciseInNotionalAmountNodeList = xmlNode.SelectNodes("exerciseInNotionalAmount");
            if (exerciseInNotionalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exerciseInNotionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseInNotionalAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(exerciseInNotionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseInNotionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exerciseInNotionalAmount = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList outstandingNotionalAmountNodeList = xmlNode.SelectNodes("outstandingNotionalAmount");
            if (outstandingNotionalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in outstandingNotionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        outstandingNotionalAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(outstandingNotionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        outstandingNotionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        outstandingNotionalAmount = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList exerciseInNumberOfOptionsNodeList = xmlNode.SelectNodes("exerciseInNumberOfOptions");
            if (exerciseInNumberOfOptionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exerciseInNumberOfOptionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseInNumberOfOptionsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(exerciseInNumberOfOptionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseInNumberOfOptionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exerciseInNumberOfOptions = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList outstandingNumberOfOptionsNodeList = xmlNode.SelectNodes("outstandingNumberOfOptions");
            if (outstandingNumberOfOptionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in outstandingNumberOfOptionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        outstandingNumberOfOptionsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(outstandingNumberOfOptionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        outstandingNumberOfOptionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        outstandingNumberOfOptions = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList exerciseInNumberOfUnitsNodeList = xmlNode.SelectNodes("exerciseInNumberOfUnits");
            if (exerciseInNumberOfUnitsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exerciseInNumberOfUnitsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseInNumberOfUnitsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(exerciseInNumberOfUnitsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseInNumberOfUnitsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exerciseInNumberOfUnits = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList outstandingNumberOfUnitsNodeList = xmlNode.SelectNodes("outstandingNumberOfUnits");
            if (outstandingNumberOfUnitsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in outstandingNumberOfUnitsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        outstandingNumberOfUnitsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(outstandingNumberOfUnitsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        outstandingNumberOfUnitsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        outstandingNumberOfUnits = new XsdTypeDecimal(item);
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
            
        
            XmlNodeList cashSettlementNodeList = xmlNode.SelectNodes("cashSettlement");
            if (cashSettlementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashSettlementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashSettlementIDRef = item.Attributes["id"].Name;
                        SimplePayment ob = SimplePayment();
                        IDManager.SetID(cashSettlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashSettlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashSettlement = new SimplePayment(item);
                    }
                }
            }
            
        
            XmlNodeList physicalSettlementNodeList = xmlNode.SelectNodes("physicalSettlement");
            if (physicalSettlementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in physicalSettlementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        physicalSettlementIDRef = item.Attributes["id"].Name;
                        PhysicalSettlement ob = PhysicalSettlement();
                        IDManager.SetID(physicalSettlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        physicalSettlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        physicalSettlement = new PhysicalSettlement(item);
                    }
                }
            }
            
        
            XmlNodeList paymentNodeList = xmlNode.SelectNodes("payment");
            if (paymentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentIDRef = item.Attributes["id"].Name;
                        NonNegativePayment ob = NonNegativePayment();
                        IDManager.SetID(paymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payment = new NonNegativePayment(item);
                    }
                }
            }
            
        
        }
        
    
        #region OptionSeller
        private PartyReference optionSeller;
        public PartyReference OptionSeller
        {
            get
            {
                if (this.optionSeller != null)
                {
                    return this.optionSeller; 
                }
                else if (this.optionSellerIDRef != null)
                {
                    optionSeller = IDManager.getID(optionSellerIDRef) as PartyReference;
                    return this.optionSeller; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionSeller != value)
                {
                    this.optionSeller = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region OptionBuyer
        private PartyReference optionBuyer;
        public PartyReference OptionBuyer
        {
            get
            {
                if (this.optionBuyer != null)
                {
                    return this.optionBuyer; 
                }
                else if (this.optionBuyerIDRef != null)
                {
                    optionBuyer = IDManager.getID(optionBuyerIDRef) as PartyReference;
                    return this.optionBuyer; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionBuyer != value)
                {
                    this.optionBuyer = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region OriginalTrade
        private Trade originalTrade;
        public Trade OriginalTrade
        {
            get
            {
                if (this.originalTrade != null)
                {
                    return this.originalTrade; 
                }
                else if (this.originalTradeIDRef != null)
                {
                    originalTrade = IDManager.getID(originalTradeIDRef) as Trade;
                    return this.originalTrade; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.originalTrade != value)
                {
                    this.originalTrade = value;
                }
            }
        }
        #endregion
        
        public string TradeIDRef { get; set; }
        #region TradeIdentifier
        private List<PartyTradeIdentifier> tradeIdentifier;
        public List<PartyTradeIdentifier> TradeIdentifier
        {
            get
            {
                if (this.tradeIdentifier != null)
                {
                    return this.tradeIdentifier; 
                }
                else if (this.tradeIdentifierIDRef != null)
                {
                    tradeIdentifier = IDManager.getID(tradeIdentifierIDRef) as List<PartyTradeIdentifier>;
                    return this.tradeIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tradeIdentifier != value)
                {
                    this.tradeIdentifier = value;
                }
            }
        }
        #endregion
        
        public string PartyTradeIdentifierIDRef { get; set; }
        #region ExerciseDate
        private XsdTypeDate exerciseDate;
        public XsdTypeDate ExerciseDate
        {
            get
            {
                if (this.exerciseDate != null)
                {
                    return this.exerciseDate; 
                }
                else if (this.exerciseDateIDRef != null)
                {
                    exerciseDate = IDManager.getID(exerciseDateIDRef) as XsdTypeDate;
                    return this.exerciseDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exerciseDate != value)
                {
                    this.exerciseDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region ExerciseTime
        private XsdTypeTime exerciseTime;
        public XsdTypeTime ExerciseTime
        {
            get
            {
                if (this.exerciseTime != null)
                {
                    return this.exerciseTime; 
                }
                else if (this.exerciseTimeIDRef != null)
                {
                    exerciseTime = IDManager.getID(exerciseTimeIDRef) as XsdTypeTime;
                    return this.exerciseTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exerciseTime != value)
                {
                    this.exerciseTime = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTimeIDRef { get; set; }
        #region Expiry
        private XsdTypeBoolean expiry;
        public XsdTypeBoolean Expiry
        {
            get
            {
                if (this.expiry != null)
                {
                    return this.expiry; 
                }
                else if (this.expiryIDRef != null)
                {
                    expiry = IDManager.getID(expiryIDRef) as XsdTypeBoolean;
                    return this.expiry; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.expiry != value)
                {
                    this.expiry = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region FullExercise
        private XsdTypeBoolean fullExercise;
        public XsdTypeBoolean FullExercise
        {
            get
            {
                if (this.fullExercise != null)
                {
                    return this.fullExercise; 
                }
                else if (this.fullExerciseIDRef != null)
                {
                    fullExercise = IDManager.getID(fullExerciseIDRef) as XsdTypeBoolean;
                    return this.fullExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fullExercise != value)
                {
                    this.fullExercise = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ExerciseInNotionalAmount
        private Money exerciseInNotionalAmount;
        public Money ExerciseInNotionalAmount
        {
            get
            {
                if (this.exerciseInNotionalAmount != null)
                {
                    return this.exerciseInNotionalAmount; 
                }
                else if (this.exerciseInNotionalAmountIDRef != null)
                {
                    exerciseInNotionalAmount = IDManager.getID(exerciseInNotionalAmountIDRef) as Money;
                    return this.exerciseInNotionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exerciseInNotionalAmount != value)
                {
                    this.exerciseInNotionalAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region OutstandingNotionalAmount
        private Money outstandingNotionalAmount;
        public Money OutstandingNotionalAmount
        {
            get
            {
                if (this.outstandingNotionalAmount != null)
                {
                    return this.outstandingNotionalAmount; 
                }
                else if (this.outstandingNotionalAmountIDRef != null)
                {
                    outstandingNotionalAmount = IDManager.getID(outstandingNotionalAmountIDRef) as Money;
                    return this.outstandingNotionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.outstandingNotionalAmount != value)
                {
                    this.outstandingNotionalAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region ExerciseInNumberOfOptions
        private XsdTypeDecimal exerciseInNumberOfOptions;
        public XsdTypeDecimal ExerciseInNumberOfOptions
        {
            get
            {
                if (this.exerciseInNumberOfOptions != null)
                {
                    return this.exerciseInNumberOfOptions; 
                }
                else if (this.exerciseInNumberOfOptionsIDRef != null)
                {
                    exerciseInNumberOfOptions = IDManager.getID(exerciseInNumberOfOptionsIDRef) as XsdTypeDecimal;
                    return this.exerciseInNumberOfOptions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exerciseInNumberOfOptions != value)
                {
                    this.exerciseInNumberOfOptions = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region OutstandingNumberOfOptions
        private XsdTypeDecimal outstandingNumberOfOptions;
        public XsdTypeDecimal OutstandingNumberOfOptions
        {
            get
            {
                if (this.outstandingNumberOfOptions != null)
                {
                    return this.outstandingNumberOfOptions; 
                }
                else if (this.outstandingNumberOfOptionsIDRef != null)
                {
                    outstandingNumberOfOptions = IDManager.getID(outstandingNumberOfOptionsIDRef) as XsdTypeDecimal;
                    return this.outstandingNumberOfOptions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.outstandingNumberOfOptions != value)
                {
                    this.outstandingNumberOfOptions = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region ExerciseInNumberOfUnits
        private XsdTypeDecimal exerciseInNumberOfUnits;
        public XsdTypeDecimal ExerciseInNumberOfUnits
        {
            get
            {
                if (this.exerciseInNumberOfUnits != null)
                {
                    return this.exerciseInNumberOfUnits; 
                }
                else if (this.exerciseInNumberOfUnitsIDRef != null)
                {
                    exerciseInNumberOfUnits = IDManager.getID(exerciseInNumberOfUnitsIDRef) as XsdTypeDecimal;
                    return this.exerciseInNumberOfUnits; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exerciseInNumberOfUnits != value)
                {
                    this.exerciseInNumberOfUnits = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region OutstandingNumberOfUnits
        private XsdTypeDecimal outstandingNumberOfUnits;
        public XsdTypeDecimal OutstandingNumberOfUnits
        {
            get
            {
                if (this.outstandingNumberOfUnits != null)
                {
                    return this.outstandingNumberOfUnits; 
                }
                else if (this.outstandingNumberOfUnitsIDRef != null)
                {
                    outstandingNumberOfUnits = IDManager.getID(outstandingNumberOfUnitsIDRef) as XsdTypeDecimal;
                    return this.outstandingNumberOfUnits; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.outstandingNumberOfUnits != value)
                {
                    this.outstandingNumberOfUnits = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
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
        #region CashSettlement
        private SimplePayment cashSettlement;
        public SimplePayment CashSettlement
        {
            get
            {
                if (this.cashSettlement != null)
                {
                    return this.cashSettlement; 
                }
                else if (this.cashSettlementIDRef != null)
                {
                    cashSettlement = IDManager.getID(cashSettlementIDRef) as SimplePayment;
                    return this.cashSettlement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashSettlement != value)
                {
                    this.cashSettlement = value;
                }
            }
        }
        #endregion
        
        public string SimplePaymentIDRef { get; set; }
        #region PhysicalSettlement
        private PhysicalSettlement physicalSettlement;
        public PhysicalSettlement PhysicalSettlement
        {
            get
            {
                if (this.physicalSettlement != null)
                {
                    return this.physicalSettlement; 
                }
                else if (this.physicalSettlementIDRef != null)
                {
                    physicalSettlement = IDManager.getID(physicalSettlementIDRef) as PhysicalSettlement;
                    return this.physicalSettlement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.physicalSettlement != value)
                {
                    this.physicalSettlement = value;
                }
            }
        }
        #endregion
        
        public string PhysicalSettlementIDRef { get; set; }
        #region Payment
        private NonNegativePayment payment;
        public NonNegativePayment Payment
        {
            get
            {
                if (this.payment != null)
                {
                    return this.payment; 
                }
                else if (this.paymentIDRef != null)
                {
                    payment = IDManager.getID(paymentIDRef) as NonNegativePayment;
                    return this.payment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payment != value)
                {
                    this.payment = value;
                }
            }
        }
        #endregion
        
        public string NonNegativePaymentIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        
    
        
    
    }
    
}

