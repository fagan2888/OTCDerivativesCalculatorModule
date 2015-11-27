using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class OptionBaseExtended
    {
        public OptionBaseExtended(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList premiumNodeList = xmlNode.SelectNodes("premium");
            if (premiumNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in premiumNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        premiumIDRef = item.Attributes["id"].Name;
                        Premium ob = Premium();
                        IDManager.SetID(premiumIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        premiumIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        premium = new Premium(item);
                    }
                }
            }
            
        
            XmlNodeList exerciseNodeList = xmlNode.SelectNodes("exercise");
            if (exerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseIDRef = item.Attributes["id"].Name;
                        Exercise ob = Exercise();
                        IDManager.SetID(exerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exercise = new Exercise(item);
                    }
                }
            }
            
        
            XmlNodeList americanExerciseNodeList = xmlNode.SelectNodes("americanExercise");
            if (americanExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in americanExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        americanExerciseIDRef = item.Attributes["id"].Name;
                        AmericanExercise ob = AmericanExercise();
                        IDManager.SetID(americanExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        americanExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        americanExercise = new AmericanExercise(item);
                    }
                }
            }
            
        
            XmlNodeList bermudaExerciseNodeList = xmlNode.SelectNodes("bermudaExercise");
            if (bermudaExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in bermudaExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        bermudaExerciseIDRef = item.Attributes["id"].Name;
                        BermudaExercise ob = BermudaExercise();
                        IDManager.SetID(bermudaExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        bermudaExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        bermudaExercise = new BermudaExercise(item);
                    }
                }
            }
            
        
            XmlNodeList europeanExerciseNodeList = xmlNode.SelectNodes("europeanExercise");
            if (europeanExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in europeanExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        europeanExerciseIDRef = item.Attributes["id"].Name;
                        EuropeanExercise ob = EuropeanExercise();
                        IDManager.SetID(europeanExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        europeanExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        europeanExercise = new EuropeanExercise(item);
                    }
                }
            }
            
        
            XmlNodeList exerciseProcedureNodeList = xmlNode.SelectNodes("exerciseProcedure");
            if (exerciseProcedureNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exerciseProcedureNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseProcedureIDRef = item.Attributes["id"].Name;
                        ExerciseProcedure ob = ExerciseProcedure();
                        IDManager.SetID(exerciseProcedureIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseProcedureIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exerciseProcedure = new ExerciseProcedure(item);
                    }
                }
            }
            
        
            XmlNodeList featureNodeList = xmlNode.SelectNodes("feature");
            if (featureNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in featureNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        featureIDRef = item.Attributes["id"].Name;
                        OptionFeature ob = OptionFeature();
                        IDManager.SetID(featureIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        featureIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        feature = new OptionFeature(item);
                    }
                }
            }
            
        
            XmlNodeList notionalReferenceNodeList = xmlNode.SelectNodes("notionalReference");
            if (notionalReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalReferenceIDRef = item.Attributes["id"].Name;
                        NotionalAmountReference ob = NotionalAmountReference();
                        IDManager.SetID(notionalReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalReference = new NotionalAmountReference(item);
                    }
                }
            }
            
        
            XmlNodeList notionalAmountNodeList = xmlNode.SelectNodes("notionalAmount");
            if (notionalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(notionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalAmount = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList optionEntitlementNodeList = xmlNode.SelectNodes("optionEntitlement");
            if (optionEntitlementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionEntitlementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionEntitlementIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(optionEntitlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionEntitlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionEntitlement = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList entitlementCurrencyNodeList = xmlNode.SelectNodes("entitlementCurrency");
            if (entitlementCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in entitlementCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        entitlementCurrencyIDRef = item.Attributes["id"].Name;
                        Currency ob = Currency();
                        IDManager.SetID(entitlementCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        entitlementCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        entitlementCurrency = new Currency(item);
                    }
                }
            }
            
        
            XmlNodeList numberOfOptionsNodeList = xmlNode.SelectNodes("numberOfOptions");
            if (numberOfOptionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in numberOfOptionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        numberOfOptionsIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(numberOfOptionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        numberOfOptionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        numberOfOptions = new PositiveDecimal(item);
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
            
        
            XmlNodeList settlementAmountNodeList = xmlNode.SelectNodes("settlementAmount");
            if (settlementAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(settlementAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementAmount = new Money(item);
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
            
        
        }
        
    
        #region Premium
        private Premium premium;
        public Premium Premium
        {
            get
            {
                if (this.premium != null)
                {
                    return this.premium; 
                }
                else if (this.premiumIDRef != null)
                {
                    premium = IDManager.getID(premiumIDRef) as Premium;
                    return this.premium; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.premium != value)
                {
                    this.premium = value;
                }
            }
        }
        #endregion
        
        public string PremiumIDRef { get; set; }
        #region Exercise
        private Exercise exercise;
        public Exercise Exercise
        {
            get
            {
                if (this.exercise != null)
                {
                    return this.exercise; 
                }
                else if (this.exerciseIDRef != null)
                {
                    exercise = IDManager.getID(exerciseIDRef) as Exercise;
                    return this.exercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exercise != value)
                {
                    this.exercise = value;
                }
            }
        }
        #endregion
        
        public string ExerciseIDRef { get; set; }
        #region AmericanExercise
        private AmericanExercise americanExercise;
        public AmericanExercise AmericanExercise
        {
            get
            {
                if (this.americanExercise != null)
                {
                    return this.americanExercise; 
                }
                else if (this.americanExerciseIDRef != null)
                {
                    americanExercise = IDManager.getID(americanExerciseIDRef) as AmericanExercise;
                    return this.americanExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.americanExercise != value)
                {
                    this.americanExercise = value;
                }
            }
        }
        #endregion
        
        public string AmericanExerciseIDRef { get; set; }     // substitude
        #region BermudaExercise
        private BermudaExercise bermudaExercise;
        public BermudaExercise BermudaExercise
        {
            get
            {
                if (this.bermudaExercise != null)
                {
                    return this.bermudaExercise; 
                }
                else if (this.bermudaExerciseIDRef != null)
                {
                    bermudaExercise = IDManager.getID(bermudaExerciseIDRef) as BermudaExercise;
                    return this.bermudaExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.bermudaExercise != value)
                {
                    this.bermudaExercise = value;
                }
            }
        }
        #endregion
        
        public string BermudaExerciseIDRef { get; set; }     // substitude
        #region EuropeanExercise
        private EuropeanExercise europeanExercise;
        public EuropeanExercise EuropeanExercise
        {
            get
            {
                if (this.europeanExercise != null)
                {
                    return this.europeanExercise; 
                }
                else if (this.europeanExerciseIDRef != null)
                {
                    europeanExercise = IDManager.getID(europeanExerciseIDRef) as EuropeanExercise;
                    return this.europeanExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.europeanExercise != value)
                {
                    this.europeanExercise = value;
                }
            }
        }
        #endregion
        
        public string EuropeanExerciseIDRef { get; set; }     // substitude
        #region ExerciseProcedure
        private ExerciseProcedure exerciseProcedure;
        public ExerciseProcedure ExerciseProcedure
        {
            get
            {
                if (this.exerciseProcedure != null)
                {
                    return this.exerciseProcedure; 
                }
                else if (this.exerciseProcedureIDRef != null)
                {
                    exerciseProcedure = IDManager.getID(exerciseProcedureIDRef) as ExerciseProcedure;
                    return this.exerciseProcedure; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exerciseProcedure != value)
                {
                    this.exerciseProcedure = value;
                }
            }
        }
        #endregion
        
        public string ExerciseProcedureIDRef { get; set; }
        #region Feature
        private OptionFeature feature;
        public OptionFeature Feature
        {
            get
            {
                if (this.feature != null)
                {
                    return this.feature; 
                }
                else if (this.featureIDRef != null)
                {
                    feature = IDManager.getID(featureIDRef) as OptionFeature;
                    return this.feature; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.feature != value)
                {
                    this.feature = value;
                }
            }
        }
        #endregion
        
        public string OptionFeatureIDRef { get; set; }
        #region NotionalReference
        private NotionalAmountReference notionalReference;
        public NotionalAmountReference NotionalReference
        {
            get
            {
                if (this.notionalReference != null)
                {
                    return this.notionalReference; 
                }
                else if (this.notionalReferenceIDRef != null)
                {
                    notionalReference = IDManager.getID(notionalReferenceIDRef) as NotionalAmountReference;
                    return this.notionalReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalReference != value)
                {
                    this.notionalReference = value;
                }
            }
        }
        #endregion
        
        public string NotionalAmountReferenceIDRef { get; set; }
        #region NotionalAmount
        private Money notionalAmount;
        public Money NotionalAmount
        {
            get
            {
                if (this.notionalAmount != null)
                {
                    return this.notionalAmount; 
                }
                else if (this.notionalAmountIDRef != null)
                {
                    notionalAmount = IDManager.getID(notionalAmountIDRef) as Money;
                    return this.notionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalAmount != value)
                {
                    this.notionalAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region OptionEntitlement
        private PositiveDecimal optionEntitlement;
        public PositiveDecimal OptionEntitlement
        {
            get
            {
                if (this.optionEntitlement != null)
                {
                    return this.optionEntitlement; 
                }
                else if (this.optionEntitlementIDRef != null)
                {
                    optionEntitlement = IDManager.getID(optionEntitlementIDRef) as PositiveDecimal;
                    return this.optionEntitlement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionEntitlement != value)
                {
                    this.optionEntitlement = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region EntitlementCurrency
        private Currency entitlementCurrency;
        public Currency EntitlementCurrency
        {
            get
            {
                if (this.entitlementCurrency != null)
                {
                    return this.entitlementCurrency; 
                }
                else if (this.entitlementCurrencyIDRef != null)
                {
                    entitlementCurrency = IDManager.getID(entitlementCurrencyIDRef) as Currency;
                    return this.entitlementCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.entitlementCurrency != value)
                {
                    this.entitlementCurrency = value;
                }
            }
        }
        #endregion
        
        public string CurrencyIDRef { get; set; }
        #region NumberOfOptions
        private PositiveDecimal numberOfOptions;
        public PositiveDecimal NumberOfOptions
        {
            get
            {
                if (this.numberOfOptions != null)
                {
                    return this.numberOfOptions; 
                }
                else if (this.numberOfOptionsIDRef != null)
                {
                    numberOfOptions = IDManager.getID(numberOfOptionsIDRef) as PositiveDecimal;
                    return this.numberOfOptions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.numberOfOptions != value)
                {
                    this.numberOfOptions = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
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
        #region SettlementAmount
        private Money settlementAmount;
        public Money SettlementAmount
        {
            get
            {
                if (this.settlementAmount != null)
                {
                    return this.settlementAmount; 
                }
                else if (this.settlementAmountIDRef != null)
                {
                    settlementAmount = IDManager.getID(settlementAmountIDRef) as Money;
                    return this.settlementAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementAmount != value)
                {
                    this.settlementAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
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
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

