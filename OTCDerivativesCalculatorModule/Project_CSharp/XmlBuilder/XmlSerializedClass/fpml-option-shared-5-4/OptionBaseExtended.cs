using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OptionBaseExtended : OptionBase
    {
        public OptionBaseExtended(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode premiumNode = xmlNode.SelectSingleNode("premium");
            
            if (premiumNode != null)
            {
                if (premiumNode.Attributes["href"] != null || premiumNode.Attributes["id"] != null) 
                {
                    if (premiumNode.Attributes["id"] != null) 
                    {
                        premiumIDRef_ = premiumNode.Attributes["id"].Value;
                        Premium ob = new Premium(premiumNode);
                        IDManager.SetID(premiumIDRef_, ob);
                    }
                    else if (premiumNode.Attributes["href"] != null)
                    {
                        premiumIDRef_ = premiumNode.Attributes["href"].Value;
                    }
                    else
                    {
                        premium_ = new Premium(premiumNode);
                    }
                }
                else
                {
                    premium_ = new Premium(premiumNode);
                }
            }
            
        
            XmlNode exerciseNode = xmlNode.SelectSingleNode("exercise");
            
            if (exerciseNode != null)
            {
                if (exerciseNode.Attributes["href"] != null || exerciseNode.Attributes["id"] != null) 
                {
                    if (exerciseNode.Attributes["id"] != null) 
                    {
                        exerciseIDRef_ = exerciseNode.Attributes["id"].Value;
                        Exercise ob = new Exercise(exerciseNode);
                        IDManager.SetID(exerciseIDRef_, ob);
                    }
                    else if (exerciseNode.Attributes["href"] != null)
                    {
                        exerciseIDRef_ = exerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exercise_ = new Exercise(exerciseNode);
                    }
                }
                else
                {
                    exercise_ = new Exercise(exerciseNode);
                }
            }
            
        
            XmlNode americanExerciseNode = xmlNode.SelectSingleNode("americanExercise");
            
            if (americanExerciseNode != null)
            {
                if (americanExerciseNode.Attributes["href"] != null || americanExerciseNode.Attributes["id"] != null) 
                {
                    if (americanExerciseNode.Attributes["id"] != null) 
                    {
                        americanExerciseIDRef_ = americanExerciseNode.Attributes["id"].Value;
                        AmericanExercise ob = new AmericanExercise(americanExerciseNode);
                        IDManager.SetID(americanExerciseIDRef_, ob);
                    }
                    else if (americanExerciseNode.Attributes["href"] != null)
                    {
                        americanExerciseIDRef_ = americanExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        americanExercise_ = new AmericanExercise(americanExerciseNode);
                    }
                }
                else
                {
                    americanExercise_ = new AmericanExercise(americanExerciseNode);
                }
            }
            
        
            XmlNode bermudaExerciseNode = xmlNode.SelectSingleNode("bermudaExercise");
            
            if (bermudaExerciseNode != null)
            {
                if (bermudaExerciseNode.Attributes["href"] != null || bermudaExerciseNode.Attributes["id"] != null) 
                {
                    if (bermudaExerciseNode.Attributes["id"] != null) 
                    {
                        bermudaExerciseIDRef_ = bermudaExerciseNode.Attributes["id"].Value;
                        BermudaExercise ob = new BermudaExercise(bermudaExerciseNode);
                        IDManager.SetID(bermudaExerciseIDRef_, ob);
                    }
                    else if (bermudaExerciseNode.Attributes["href"] != null)
                    {
                        bermudaExerciseIDRef_ = bermudaExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        bermudaExercise_ = new BermudaExercise(bermudaExerciseNode);
                    }
                }
                else
                {
                    bermudaExercise_ = new BermudaExercise(bermudaExerciseNode);
                }
            }
            
        
            XmlNode europeanExerciseNode = xmlNode.SelectSingleNode("europeanExercise");
            
            if (europeanExerciseNode != null)
            {
                if (europeanExerciseNode.Attributes["href"] != null || europeanExerciseNode.Attributes["id"] != null) 
                {
                    if (europeanExerciseNode.Attributes["id"] != null) 
                    {
                        europeanExerciseIDRef_ = europeanExerciseNode.Attributes["id"].Value;
                        EuropeanExercise ob = new EuropeanExercise(europeanExerciseNode);
                        IDManager.SetID(europeanExerciseIDRef_, ob);
                    }
                    else if (europeanExerciseNode.Attributes["href"] != null)
                    {
                        europeanExerciseIDRef_ = europeanExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        europeanExercise_ = new EuropeanExercise(europeanExerciseNode);
                    }
                }
                else
                {
                    europeanExercise_ = new EuropeanExercise(europeanExerciseNode);
                }
            }
            
        
            XmlNode exerciseProcedureNode = xmlNode.SelectSingleNode("exerciseProcedure");
            
            if (exerciseProcedureNode != null)
            {
                if (exerciseProcedureNode.Attributes["href"] != null || exerciseProcedureNode.Attributes["id"] != null) 
                {
                    if (exerciseProcedureNode.Attributes["id"] != null) 
                    {
                        exerciseProcedureIDRef_ = exerciseProcedureNode.Attributes["id"].Value;
                        ExerciseProcedure ob = new ExerciseProcedure(exerciseProcedureNode);
                        IDManager.SetID(exerciseProcedureIDRef_, ob);
                    }
                    else if (exerciseProcedureNode.Attributes["href"] != null)
                    {
                        exerciseProcedureIDRef_ = exerciseProcedureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exerciseProcedure_ = new ExerciseProcedure(exerciseProcedureNode);
                    }
                }
                else
                {
                    exerciseProcedure_ = new ExerciseProcedure(exerciseProcedureNode);
                }
            }
            
        
            XmlNode featureNode = xmlNode.SelectSingleNode("feature");
            
            if (featureNode != null)
            {
                if (featureNode.Attributes["href"] != null || featureNode.Attributes["id"] != null) 
                {
                    if (featureNode.Attributes["id"] != null) 
                    {
                        featureIDRef_ = featureNode.Attributes["id"].Value;
                        OptionFeature ob = new OptionFeature(featureNode);
                        IDManager.SetID(featureIDRef_, ob);
                    }
                    else if (featureNode.Attributes["href"] != null)
                    {
                        featureIDRef_ = featureNode.Attributes["href"].Value;
                    }
                    else
                    {
                        feature_ = new OptionFeature(featureNode);
                    }
                }
                else
                {
                    feature_ = new OptionFeature(featureNode);
                }
            }
            
        
            XmlNode notionalReferenceNode = xmlNode.SelectSingleNode("notionalReference");
            
            if (notionalReferenceNode != null)
            {
                if (notionalReferenceNode.Attributes["href"] != null || notionalReferenceNode.Attributes["id"] != null) 
                {
                    if (notionalReferenceNode.Attributes["id"] != null) 
                    {
                        notionalReferenceIDRef_ = notionalReferenceNode.Attributes["id"].Value;
                        NotionalAmountReference ob = new NotionalAmountReference(notionalReferenceNode);
                        IDManager.SetID(notionalReferenceIDRef_, ob);
                    }
                    else if (notionalReferenceNode.Attributes["href"] != null)
                    {
                        notionalReferenceIDRef_ = notionalReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalReference_ = new NotionalAmountReference(notionalReferenceNode);
                    }
                }
                else
                {
                    notionalReference_ = new NotionalAmountReference(notionalReferenceNode);
                }
            }
            
        
            XmlNode notionalAmountNode = xmlNode.SelectSingleNode("notionalAmount");
            
            if (notionalAmountNode != null)
            {
                if (notionalAmountNode.Attributes["href"] != null || notionalAmountNode.Attributes["id"] != null) 
                {
                    if (notionalAmountNode.Attributes["id"] != null) 
                    {
                        notionalAmountIDRef_ = notionalAmountNode.Attributes["id"].Value;
                        Money ob = new Money(notionalAmountNode);
                        IDManager.SetID(notionalAmountIDRef_, ob);
                    }
                    else if (notionalAmountNode.Attributes["href"] != null)
                    {
                        notionalAmountIDRef_ = notionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalAmount_ = new Money(notionalAmountNode);
                    }
                }
                else
                {
                    notionalAmount_ = new Money(notionalAmountNode);
                }
            }
            
        
            XmlNode optionEntitlementNode = xmlNode.SelectSingleNode("optionEntitlement");
            
            if (optionEntitlementNode != null)
            {
                if (optionEntitlementNode.Attributes["href"] != null || optionEntitlementNode.Attributes["id"] != null) 
                {
                    if (optionEntitlementNode.Attributes["id"] != null) 
                    {
                        optionEntitlementIDRef_ = optionEntitlementNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(optionEntitlementNode);
                        IDManager.SetID(optionEntitlementIDRef_, ob);
                    }
                    else if (optionEntitlementNode.Attributes["href"] != null)
                    {
                        optionEntitlementIDRef_ = optionEntitlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionEntitlement_ = new PositiveDecimal(optionEntitlementNode);
                    }
                }
                else
                {
                    optionEntitlement_ = new PositiveDecimal(optionEntitlementNode);
                }
            }
            
        
            XmlNode entitlementCurrencyNode = xmlNode.SelectSingleNode("entitlementCurrency");
            
            if (entitlementCurrencyNode != null)
            {
                if (entitlementCurrencyNode.Attributes["href"] != null || entitlementCurrencyNode.Attributes["id"] != null) 
                {
                    if (entitlementCurrencyNode.Attributes["id"] != null) 
                    {
                        entitlementCurrencyIDRef_ = entitlementCurrencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(entitlementCurrencyNode);
                        IDManager.SetID(entitlementCurrencyIDRef_, ob);
                    }
                    else if (entitlementCurrencyNode.Attributes["href"] != null)
                    {
                        entitlementCurrencyIDRef_ = entitlementCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        entitlementCurrency_ = new Currency(entitlementCurrencyNode);
                    }
                }
                else
                {
                    entitlementCurrency_ = new Currency(entitlementCurrencyNode);
                }
            }
            
        
            XmlNode numberOfOptionsNode = xmlNode.SelectSingleNode("numberOfOptions");
            
            if (numberOfOptionsNode != null)
            {
                if (numberOfOptionsNode.Attributes["href"] != null || numberOfOptionsNode.Attributes["id"] != null) 
                {
                    if (numberOfOptionsNode.Attributes["id"] != null) 
                    {
                        numberOfOptionsIDRef_ = numberOfOptionsNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(numberOfOptionsNode);
                        IDManager.SetID(numberOfOptionsIDRef_, ob);
                    }
                    else if (numberOfOptionsNode.Attributes["href"] != null)
                    {
                        numberOfOptionsIDRef_ = numberOfOptionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        numberOfOptions_ = new PositiveDecimal(numberOfOptionsNode);
                    }
                }
                else
                {
                    numberOfOptions_ = new PositiveDecimal(numberOfOptionsNode);
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
            
        
            XmlNode settlementAmountNode = xmlNode.SelectSingleNode("settlementAmount");
            
            if (settlementAmountNode != null)
            {
                if (settlementAmountNode.Attributes["href"] != null || settlementAmountNode.Attributes["id"] != null) 
                {
                    if (settlementAmountNode.Attributes["id"] != null) 
                    {
                        settlementAmountIDRef_ = settlementAmountNode.Attributes["id"].Value;
                        Money ob = new Money(settlementAmountNode);
                        IDManager.SetID(settlementAmountIDRef_, ob);
                    }
                    else if (settlementAmountNode.Attributes["href"] != null)
                    {
                        settlementAmountIDRef_ = settlementAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementAmount_ = new Money(settlementAmountNode);
                    }
                }
                else
                {
                    settlementAmount_ = new Money(settlementAmountNode);
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
            
        
        }
        
    
        #region Premium_
        private Premium premium_;
        public Premium Premium_
        {
            get
            {
                if (this.premium_ != null)
                {
                    return this.premium_; 
                }
                else if (this.premiumIDRef_ != null)
                {
                    premium_ = IDManager.getID(premiumIDRef_) as Premium;
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
        #region Exercise_
        private Exercise exercise_;
        public Exercise Exercise_
        {
            get
            {
                if (this.exercise_ != null)
                {
                    return this.exercise_; 
                }
                else if (this.exerciseIDRef_ != null)
                {
                    exercise_ = IDManager.getID(exerciseIDRef_) as Exercise;
                    return this.exercise_; 
                }
                else
                {
                      return this.exercise_; 
                }
            }
            set
            {
                if (this.exercise_ != value)
                {
                    this.exercise_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseIDRef_ { get; set; }
        #region AmericanExercise_
        private AmericanExercise americanExercise_;
        public AmericanExercise AmericanExercise_
        {
            get
            {
                if (this.americanExercise_ != null)
                {
                    return this.americanExercise_; 
                }
                else if (this.americanExerciseIDRef_ != null)
                {
                    americanExercise_ = IDManager.getID(americanExerciseIDRef_) as AmericanExercise;
                    return this.americanExercise_; 
                }
                else
                {
                      return this.americanExercise_; 
                }
            }
            set
            {
                if (this.americanExercise_ != value)
                {
                    this.americanExercise_ = value;
                }
            }
        }
        #endregion
        
        public string americanExerciseIDRef_ { get; set; }     // substitude
        #region BermudaExercise_
        private BermudaExercise bermudaExercise_;
        public BermudaExercise BermudaExercise_
        {
            get
            {
                if (this.bermudaExercise_ != null)
                {
                    return this.bermudaExercise_; 
                }
                else if (this.bermudaExerciseIDRef_ != null)
                {
                    bermudaExercise_ = IDManager.getID(bermudaExerciseIDRef_) as BermudaExercise;
                    return this.bermudaExercise_; 
                }
                else
                {
                      return this.bermudaExercise_; 
                }
            }
            set
            {
                if (this.bermudaExercise_ != value)
                {
                    this.bermudaExercise_ = value;
                }
            }
        }
        #endregion
        
        public string bermudaExerciseIDRef_ { get; set; }     // substitude
        #region EuropeanExercise_
        private EuropeanExercise europeanExercise_;
        public EuropeanExercise EuropeanExercise_
        {
            get
            {
                if (this.europeanExercise_ != null)
                {
                    return this.europeanExercise_; 
                }
                else if (this.europeanExerciseIDRef_ != null)
                {
                    europeanExercise_ = IDManager.getID(europeanExerciseIDRef_) as EuropeanExercise;
                    return this.europeanExercise_; 
                }
                else
                {
                      return this.europeanExercise_; 
                }
            }
            set
            {
                if (this.europeanExercise_ != value)
                {
                    this.europeanExercise_ = value;
                }
            }
        }
        #endregion
        
        public string europeanExerciseIDRef_ { get; set; }     // substitude
        #region ExerciseProcedure_
        private ExerciseProcedure exerciseProcedure_;
        public ExerciseProcedure ExerciseProcedure_
        {
            get
            {
                if (this.exerciseProcedure_ != null)
                {
                    return this.exerciseProcedure_; 
                }
                else if (this.exerciseProcedureIDRef_ != null)
                {
                    exerciseProcedure_ = IDManager.getID(exerciseProcedureIDRef_) as ExerciseProcedure;
                    return this.exerciseProcedure_; 
                }
                else
                {
                      return this.exerciseProcedure_; 
                }
            }
            set
            {
                if (this.exerciseProcedure_ != value)
                {
                    this.exerciseProcedure_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseProcedureIDRef_ { get; set; }
        #region Feature_
        private OptionFeature feature_;
        public OptionFeature Feature_
        {
            get
            {
                if (this.feature_ != null)
                {
                    return this.feature_; 
                }
                else if (this.featureIDRef_ != null)
                {
                    feature_ = IDManager.getID(featureIDRef_) as OptionFeature;
                    return this.feature_; 
                }
                else
                {
                      return this.feature_; 
                }
            }
            set
            {
                if (this.feature_ != value)
                {
                    this.feature_ = value;
                }
            }
        }
        #endregion
        
        public string featureIDRef_ { get; set; }
        #region NotionalReference_
        private NotionalAmountReference notionalReference_;
        public NotionalAmountReference NotionalReference_
        {
            get
            {
                if (this.notionalReference_ != null)
                {
                    return this.notionalReference_; 
                }
                else if (this.notionalReferenceIDRef_ != null)
                {
                    notionalReference_ = IDManager.getID(notionalReferenceIDRef_) as NotionalAmountReference;
                    return this.notionalReference_; 
                }
                else
                {
                      return this.notionalReference_; 
                }
            }
            set
            {
                if (this.notionalReference_ != value)
                {
                    this.notionalReference_ = value;
                }
            }
        }
        #endregion
        
        public string notionalReferenceIDRef_ { get; set; }
        #region NotionalAmount_
        private Money notionalAmount_;
        public Money NotionalAmount_
        {
            get
            {
                if (this.notionalAmount_ != null)
                {
                    return this.notionalAmount_; 
                }
                else if (this.notionalAmountIDRef_ != null)
                {
                    notionalAmount_ = IDManager.getID(notionalAmountIDRef_) as Money;
                    return this.notionalAmount_; 
                }
                else
                {
                      return this.notionalAmount_; 
                }
            }
            set
            {
                if (this.notionalAmount_ != value)
                {
                    this.notionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string notionalAmountIDRef_ { get; set; }
        #region OptionEntitlement_
        private PositiveDecimal optionEntitlement_;
        public PositiveDecimal OptionEntitlement_
        {
            get
            {
                if (this.optionEntitlement_ != null)
                {
                    return this.optionEntitlement_; 
                }
                else if (this.optionEntitlementIDRef_ != null)
                {
                    optionEntitlement_ = IDManager.getID(optionEntitlementIDRef_) as PositiveDecimal;
                    return this.optionEntitlement_; 
                }
                else
                {
                      return this.optionEntitlement_; 
                }
            }
            set
            {
                if (this.optionEntitlement_ != value)
                {
                    this.optionEntitlement_ = value;
                }
            }
        }
        #endregion
        
        public string optionEntitlementIDRef_ { get; set; }
        #region EntitlementCurrency_
        private Currency entitlementCurrency_;
        public Currency EntitlementCurrency_
        {
            get
            {
                if (this.entitlementCurrency_ != null)
                {
                    return this.entitlementCurrency_; 
                }
                else if (this.entitlementCurrencyIDRef_ != null)
                {
                    entitlementCurrency_ = IDManager.getID(entitlementCurrencyIDRef_) as Currency;
                    return this.entitlementCurrency_; 
                }
                else
                {
                      return this.entitlementCurrency_; 
                }
            }
            set
            {
                if (this.entitlementCurrency_ != value)
                {
                    this.entitlementCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string entitlementCurrencyIDRef_ { get; set; }
        #region NumberOfOptions_
        private PositiveDecimal numberOfOptions_;
        public PositiveDecimal NumberOfOptions_
        {
            get
            {
                if (this.numberOfOptions_ != null)
                {
                    return this.numberOfOptions_; 
                }
                else if (this.numberOfOptionsIDRef_ != null)
                {
                    numberOfOptions_ = IDManager.getID(numberOfOptionsIDRef_) as PositiveDecimal;
                    return this.numberOfOptions_; 
                }
                else
                {
                      return this.numberOfOptions_; 
                }
            }
            set
            {
                if (this.numberOfOptions_ != value)
                {
                    this.numberOfOptions_ = value;
                }
            }
        }
        #endregion
        
        public string numberOfOptionsIDRef_ { get; set; }
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
        #region SettlementAmount_
        private Money settlementAmount_;
        public Money SettlementAmount_
        {
            get
            {
                if (this.settlementAmount_ != null)
                {
                    return this.settlementAmount_; 
                }
                else if (this.settlementAmountIDRef_ != null)
                {
                    settlementAmount_ = IDManager.getID(settlementAmountIDRef_) as Money;
                    return this.settlementAmount_; 
                }
                else
                {
                      return this.settlementAmount_; 
                }
            }
            set
            {
                if (this.settlementAmount_ != value)
                {
                    this.settlementAmount_ = value;
                }
            }
        }
        #endregion
        
        public string settlementAmountIDRef_ { get; set; }
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
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

