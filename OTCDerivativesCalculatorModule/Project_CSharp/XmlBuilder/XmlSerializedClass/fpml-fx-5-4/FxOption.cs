using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxOption : Option
    {
        public FxOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new AdjustableOrRelativeDate(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new AdjustableOrRelativeDate(effectiveDateNode);
                }
            }
            
        
            XmlNode tenorPeriodNode = xmlNode.SelectSingleNode("tenorPeriod");
            
            if (tenorPeriodNode != null)
            {
                if (tenorPeriodNode.Attributes["href"] != null || tenorPeriodNode.Attributes["id"] != null) 
                {
                    if (tenorPeriodNode.Attributes["id"] != null) 
                    {
                        tenorPeriodIDRef_ = tenorPeriodNode.Attributes["id"].Value;
                        Period ob = new Period(tenorPeriodNode);
                        IDManager.SetID(tenorPeriodIDRef_, ob);
                    }
                    else if (tenorPeriodNode.Attributes["href"] != null)
                    {
                        tenorPeriodIDRef_ = tenorPeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tenorPeriod_ = new Period(tenorPeriodNode);
                    }
                }
                else
                {
                    tenorPeriod_ = new Period(tenorPeriodNode);
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
                        FxAmericanExercise ob = new FxAmericanExercise(americanExerciseNode);
                        IDManager.SetID(americanExerciseIDRef_, ob);
                    }
                    else if (americanExerciseNode.Attributes["href"] != null)
                    {
                        americanExerciseIDRef_ = americanExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        americanExercise_ = new FxAmericanExercise(americanExerciseNode);
                    }
                }
                else
                {
                    americanExercise_ = new FxAmericanExercise(americanExerciseNode);
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
                        FxEuropeanExercise ob = new FxEuropeanExercise(europeanExerciseNode);
                        IDManager.SetID(europeanExerciseIDRef_, ob);
                    }
                    else if (europeanExerciseNode.Attributes["href"] != null)
                    {
                        europeanExerciseIDRef_ = europeanExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        europeanExercise_ = new FxEuropeanExercise(europeanExerciseNode);
                    }
                }
                else
                {
                    europeanExercise_ = new FxEuropeanExercise(europeanExerciseNode);
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
            
        
            XmlNode putCurrencyAmountNode = xmlNode.SelectSingleNode("putCurrencyAmount");
            
            if (putCurrencyAmountNode != null)
            {
                if (putCurrencyAmountNode.Attributes["href"] != null || putCurrencyAmountNode.Attributes["id"] != null) 
                {
                    if (putCurrencyAmountNode.Attributes["id"] != null) 
                    {
                        putCurrencyAmountIDRef_ = putCurrencyAmountNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(putCurrencyAmountNode);
                        IDManager.SetID(putCurrencyAmountIDRef_, ob);
                    }
                    else if (putCurrencyAmountNode.Attributes["href"] != null)
                    {
                        putCurrencyAmountIDRef_ = putCurrencyAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        putCurrencyAmount_ = new NonNegativeMoney(putCurrencyAmountNode);
                    }
                }
                else
                {
                    putCurrencyAmount_ = new NonNegativeMoney(putCurrencyAmountNode);
                }
            }
            
        
            XmlNode callCurrencyAmountNode = xmlNode.SelectSingleNode("callCurrencyAmount");
            
            if (callCurrencyAmountNode != null)
            {
                if (callCurrencyAmountNode.Attributes["href"] != null || callCurrencyAmountNode.Attributes["id"] != null) 
                {
                    if (callCurrencyAmountNode.Attributes["id"] != null) 
                    {
                        callCurrencyAmountIDRef_ = callCurrencyAmountNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(callCurrencyAmountNode);
                        IDManager.SetID(callCurrencyAmountIDRef_, ob);
                    }
                    else if (callCurrencyAmountNode.Attributes["href"] != null)
                    {
                        callCurrencyAmountIDRef_ = callCurrencyAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        callCurrencyAmount_ = new NonNegativeMoney(callCurrencyAmountNode);
                    }
                }
                else
                {
                    callCurrencyAmount_ = new NonNegativeMoney(callCurrencyAmountNode);
                }
            }
            
        
            XmlNode soldAsNode = xmlNode.SelectSingleNode("soldAs");
            
            if (soldAsNode != null)
            {
                if (soldAsNode.Attributes["href"] != null || soldAsNode.Attributes["id"] != null) 
                {
                    if (soldAsNode.Attributes["id"] != null) 
                    {
                        soldAsIDRef_ = soldAsNode.Attributes["id"].Value;
                        PutCallEnum ob = new PutCallEnum(soldAsNode);
                        IDManager.SetID(soldAsIDRef_, ob);
                    }
                    else if (soldAsNode.Attributes["href"] != null)
                    {
                        soldAsIDRef_ = soldAsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        soldAs_ = new PutCallEnum(soldAsNode);
                    }
                }
                else
                {
                    soldAs_ = new PutCallEnum(soldAsNode);
                }
            }
            
        
            XmlNode strikeNode = xmlNode.SelectSingleNode("strike");
            
            if (strikeNode != null)
            {
                if (strikeNode.Attributes["href"] != null || strikeNode.Attributes["id"] != null) 
                {
                    if (strikeNode.Attributes["id"] != null) 
                    {
                        strikeIDRef_ = strikeNode.Attributes["id"].Value;
                        FxStrikePrice ob = new FxStrikePrice(strikeNode);
                        IDManager.SetID(strikeIDRef_, ob);
                    }
                    else if (strikeNode.Attributes["href"] != null)
                    {
                        strikeIDRef_ = strikeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strike_ = new FxStrikePrice(strikeNode);
                    }
                }
                else
                {
                    strike_ = new FxStrikePrice(strikeNode);
                }
            }
            
        
            XmlNode spotRateNode = xmlNode.SelectSingleNode("spotRate");
            
            if (spotRateNode != null)
            {
                if (spotRateNode.Attributes["href"] != null || spotRateNode.Attributes["id"] != null) 
                {
                    if (spotRateNode.Attributes["id"] != null) 
                    {
                        spotRateIDRef_ = spotRateNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(spotRateNode);
                        IDManager.SetID(spotRateIDRef_, ob);
                    }
                    else if (spotRateNode.Attributes["href"] != null)
                    {
                        spotRateIDRef_ = spotRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spotRate_ = new PositiveDecimal(spotRateNode);
                    }
                }
                else
                {
                    spotRate_ = new PositiveDecimal(spotRateNode);
                }
            }
            
        
            XmlNode featuresNode = xmlNode.SelectSingleNode("features");
            
            if (featuresNode != null)
            {
                if (featuresNode.Attributes["href"] != null || featuresNode.Attributes["id"] != null) 
                {
                    if (featuresNode.Attributes["id"] != null) 
                    {
                        featuresIDRef_ = featuresNode.Attributes["id"].Value;
                        FxOptionFeatures ob = new FxOptionFeatures(featuresNode);
                        IDManager.SetID(featuresIDRef_, ob);
                    }
                    else if (featuresNode.Attributes["href"] != null)
                    {
                        featuresIDRef_ = featuresNode.Attributes["href"].Value;
                    }
                    else
                    {
                        features_ = new FxOptionFeatures(featuresNode);
                    }
                }
                else
                {
                    features_ = new FxOptionFeatures(featuresNode);
                }
            }
            
        
            XmlNodeList premiumNodeList = xmlNode.SelectNodes("premium");
            
            if (premiumNodeList != null)
            {
                this.premium_ = new List<FxOptionPremium>();
                foreach (XmlNode item in premiumNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            premiumIDRef_ = item.Attributes["id"].Value;
                            premium_.Add(new FxOptionPremium(item));
                            IDManager.SetID(premiumIDRef_, premium_[premium_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            premiumIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        premium_.Add(new FxOptionPremium(item));
                        }
                    }
                    else
                    {
                        premium_.Add(new FxOptionPremium(item));
                    }
                }
            }
            
        
            XmlNode cashSettlementNode = xmlNode.SelectSingleNode("cashSettlement");
            
            if (cashSettlementNode != null)
            {
                if (cashSettlementNode.Attributes["href"] != null || cashSettlementNode.Attributes["id"] != null) 
                {
                    if (cashSettlementNode.Attributes["id"] != null) 
                    {
                        cashSettlementIDRef_ = cashSettlementNode.Attributes["id"].Value;
                        FxCashSettlement ob = new FxCashSettlement(cashSettlementNode);
                        IDManager.SetID(cashSettlementIDRef_, ob);
                    }
                    else if (cashSettlementNode.Attributes["href"] != null)
                    {
                        cashSettlementIDRef_ = cashSettlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashSettlement_ = new FxCashSettlement(cashSettlementNode);
                    }
                }
                else
                {
                    cashSettlement_ = new FxCashSettlement(cashSettlementNode);
                }
            }
            
        
        }
        
    
        #region EffectiveDate_
        private AdjustableOrRelativeDate effectiveDate_;
        public AdjustableOrRelativeDate EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as AdjustableOrRelativeDate;
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
        #region TenorPeriod_
        private Period tenorPeriod_;
        public Period TenorPeriod_
        {
            get
            {
                if (this.tenorPeriod_ != null)
                {
                    return this.tenorPeriod_; 
                }
                else if (this.tenorPeriodIDRef_ != null)
                {
                    tenorPeriod_ = IDManager.getID(tenorPeriodIDRef_) as Period;
                    return this.tenorPeriod_; 
                }
                else
                {
                      return this.tenorPeriod_; 
                }
            }
            set
            {
                if (this.tenorPeriod_ != value)
                {
                    this.tenorPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string tenorPeriodIDRef_ { get; set; }
        #region AmericanExercise_
        private FxAmericanExercise americanExercise_;
        public FxAmericanExercise AmericanExercise_
        {
            get
            {
                if (this.americanExercise_ != null)
                {
                    return this.americanExercise_; 
                }
                else if (this.americanExerciseIDRef_ != null)
                {
                    americanExercise_ = IDManager.getID(americanExerciseIDRef_) as FxAmericanExercise;
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
        
        public string americanExerciseIDRef_ { get; set; }
        #region EuropeanExercise_
        private FxEuropeanExercise europeanExercise_;
        public FxEuropeanExercise EuropeanExercise_
        {
            get
            {
                if (this.europeanExercise_ != null)
                {
                    return this.europeanExercise_; 
                }
                else if (this.europeanExerciseIDRef_ != null)
                {
                    europeanExercise_ = IDManager.getID(europeanExerciseIDRef_) as FxEuropeanExercise;
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
        
        public string europeanExerciseIDRef_ { get; set; }
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
        #region PutCurrencyAmount_
        private NonNegativeMoney putCurrencyAmount_;
        public NonNegativeMoney PutCurrencyAmount_
        {
            get
            {
                if (this.putCurrencyAmount_ != null)
                {
                    return this.putCurrencyAmount_; 
                }
                else if (this.putCurrencyAmountIDRef_ != null)
                {
                    putCurrencyAmount_ = IDManager.getID(putCurrencyAmountIDRef_) as NonNegativeMoney;
                    return this.putCurrencyAmount_; 
                }
                else
                {
                      return this.putCurrencyAmount_; 
                }
            }
            set
            {
                if (this.putCurrencyAmount_ != value)
                {
                    this.putCurrencyAmount_ = value;
                }
            }
        }
        #endregion
        
        public string putCurrencyAmountIDRef_ { get; set; }
        #region CallCurrencyAmount_
        private NonNegativeMoney callCurrencyAmount_;
        public NonNegativeMoney CallCurrencyAmount_
        {
            get
            {
                if (this.callCurrencyAmount_ != null)
                {
                    return this.callCurrencyAmount_; 
                }
                else if (this.callCurrencyAmountIDRef_ != null)
                {
                    callCurrencyAmount_ = IDManager.getID(callCurrencyAmountIDRef_) as NonNegativeMoney;
                    return this.callCurrencyAmount_; 
                }
                else
                {
                      return this.callCurrencyAmount_; 
                }
            }
            set
            {
                if (this.callCurrencyAmount_ != value)
                {
                    this.callCurrencyAmount_ = value;
                }
            }
        }
        #endregion
        
        public string callCurrencyAmountIDRef_ { get; set; }
        #region SoldAs_
        private PutCallEnum soldAs_;
        public PutCallEnum SoldAs_
        {
            get
            {
                if (this.soldAs_ != null)
                {
                    return this.soldAs_; 
                }
                else if (this.soldAsIDRef_ != null)
                {
                    soldAs_ = IDManager.getID(soldAsIDRef_) as PutCallEnum;
                    return this.soldAs_; 
                }
                else
                {
                      return this.soldAs_; 
                }
            }
            set
            {
                if (this.soldAs_ != value)
                {
                    this.soldAs_ = value;
                }
            }
        }
        #endregion
        
        public string soldAsIDRef_ { get; set; }
        #region Strike_
        private FxStrikePrice strike_;
        public FxStrikePrice Strike_
        {
            get
            {
                if (this.strike_ != null)
                {
                    return this.strike_; 
                }
                else if (this.strikeIDRef_ != null)
                {
                    strike_ = IDManager.getID(strikeIDRef_) as FxStrikePrice;
                    return this.strike_; 
                }
                else
                {
                      return this.strike_; 
                }
            }
            set
            {
                if (this.strike_ != value)
                {
                    this.strike_ = value;
                }
            }
        }
        #endregion
        
        public string strikeIDRef_ { get; set; }
        #region SpotRate_
        private PositiveDecimal spotRate_;
        public PositiveDecimal SpotRate_
        {
            get
            {
                if (this.spotRate_ != null)
                {
                    return this.spotRate_; 
                }
                else if (this.spotRateIDRef_ != null)
                {
                    spotRate_ = IDManager.getID(spotRateIDRef_) as PositiveDecimal;
                    return this.spotRate_; 
                }
                else
                {
                      return this.spotRate_; 
                }
            }
            set
            {
                if (this.spotRate_ != value)
                {
                    this.spotRate_ = value;
                }
            }
        }
        #endregion
        
        public string spotRateIDRef_ { get; set; }
        #region Features_
        private FxOptionFeatures features_;
        public FxOptionFeatures Features_
        {
            get
            {
                if (this.features_ != null)
                {
                    return this.features_; 
                }
                else if (this.featuresIDRef_ != null)
                {
                    features_ = IDManager.getID(featuresIDRef_) as FxOptionFeatures;
                    return this.features_; 
                }
                else
                {
                      return this.features_; 
                }
            }
            set
            {
                if (this.features_ != value)
                {
                    this.features_ = value;
                }
            }
        }
        #endregion
        
        public string featuresIDRef_ { get; set; }
        #region Premium_
        private List<FxOptionPremium> premium_;
        public List<FxOptionPremium> Premium_
        {
            get
            {
                if (this.premium_ != null)
                {
                    return this.premium_; 
                }
                else if (this.premiumIDRef_ != null)
                {
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
        #region CashSettlement_
        private FxCashSettlement cashSettlement_;
        public FxCashSettlement CashSettlement_
        {
            get
            {
                if (this.cashSettlement_ != null)
                {
                    return this.cashSettlement_; 
                }
                else if (this.cashSettlementIDRef_ != null)
                {
                    cashSettlement_ = IDManager.getID(cashSettlementIDRef_) as FxCashSettlement;
                    return this.cashSettlement_; 
                }
                else
                {
                      return this.cashSettlement_; 
                }
            }
            set
            {
                if (this.cashSettlement_ != value)
                {
                    this.cashSettlement_ = value;
                }
            }
        }
        #endregion
        
        public string cashSettlementIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

