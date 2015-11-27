using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxOption
    {
        public FxOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList effectiveDateNodeList = xmlNode.SelectNodes("effectiveDate");
            if (effectiveDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in effectiveDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(effectiveDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        effectiveDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        effectiveDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList tenorPeriodNodeList = xmlNode.SelectNodes("tenorPeriod");
            if (tenorPeriodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tenorPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tenorPeriodIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(tenorPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tenorPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tenorPeriod = new Period(item);
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
                        FxAmericanExercise ob = FxAmericanExercise();
                        IDManager.SetID(americanExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        americanExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        americanExercise = new FxAmericanExercise(item);
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
                        FxEuropeanExercise ob = FxEuropeanExercise();
                        IDManager.SetID(europeanExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        europeanExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        europeanExercise = new FxEuropeanExercise(item);
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
            
        
            XmlNodeList putCurrencyAmountNodeList = xmlNode.SelectNodes("putCurrencyAmount");
            if (putCurrencyAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in putCurrencyAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        putCurrencyAmountIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(putCurrencyAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        putCurrencyAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        putCurrencyAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList callCurrencyAmountNodeList = xmlNode.SelectNodes("callCurrencyAmount");
            if (callCurrencyAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in callCurrencyAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        callCurrencyAmountIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(callCurrencyAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        callCurrencyAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        callCurrencyAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList soldAsNodeList = xmlNode.SelectNodes("soldAs");
            if (soldAsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in soldAsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        soldAsIDRef = item.Attributes["id"].Name;
                        PutCallEnum ob = PutCallEnum();
                        IDManager.SetID(soldAsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        soldAsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        soldAs = new PutCallEnum(item);
                    }
                }
            }
            
        
            XmlNodeList strikeNodeList = xmlNode.SelectNodes("strike");
            if (strikeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikeIDRef = item.Attributes["id"].Name;
                        FxStrikePrice ob = FxStrikePrice();
                        IDManager.SetID(strikeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strike = new FxStrikePrice(item);
                    }
                }
            }
            
        
            XmlNodeList spotRateNodeList = xmlNode.SelectNodes("spotRate");
            if (spotRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in spotRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spotRateIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(spotRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spotRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        spotRate = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList featuresNodeList = xmlNode.SelectNodes("features");
            if (featuresNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in featuresNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        featuresIDRef = item.Attributes["id"].Name;
                        FxOptionFeatures ob = FxOptionFeatures();
                        IDManager.SetID(featuresIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        featuresIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        features = new FxOptionFeatures(item);
                    }
                }
            }
            
        
            XmlNodeList premiumNodeList = xmlNode.SelectNodes("premium");
            
            foreach (XmlNode item in premiumNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        premiumIDRef = item.Attributes["id"].Name;
                        List<FxOptionPremium> ob = new List<FxOptionPremium>();
                        ob.Add(new FxOptionPremium(item));
                        IDManager.SetID(premiumIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        premiumIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    premium.Add(new FxOptionPremium(item));
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
                        FxCashSettlement ob = FxCashSettlement();
                        IDManager.SetID(cashSettlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashSettlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashSettlement = new FxCashSettlement(item);
                    }
                }
            }
            
        
        }
        
    
        #region EffectiveDate
        private AdjustableOrRelativeDate effectiveDate;
        public AdjustableOrRelativeDate EffectiveDate
        {
            get
            {
                if (this.effectiveDate != null)
                {
                    return this.effectiveDate; 
                }
                else if (this.effectiveDateIDRef != null)
                {
                    effectiveDate = IDManager.getID(effectiveDateIDRef) as AdjustableOrRelativeDate;
                    return this.effectiveDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.effectiveDate != value)
                {
                    this.effectiveDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region TenorPeriod
        private Period tenorPeriod;
        public Period TenorPeriod
        {
            get
            {
                if (this.tenorPeriod != null)
                {
                    return this.tenorPeriod; 
                }
                else if (this.tenorPeriodIDRef != null)
                {
                    tenorPeriod = IDManager.getID(tenorPeriodIDRef) as Period;
                    return this.tenorPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tenorPeriod != value)
                {
                    this.tenorPeriod = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region AmericanExercise
        private FxAmericanExercise americanExercise;
        public FxAmericanExercise AmericanExercise
        {
            get
            {
                if (this.americanExercise != null)
                {
                    return this.americanExercise; 
                }
                else if (this.americanExerciseIDRef != null)
                {
                    americanExercise = IDManager.getID(americanExerciseIDRef) as FxAmericanExercise;
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
        
        public string FxAmericanExerciseIDRef { get; set; }
        #region EuropeanExercise
        private FxEuropeanExercise europeanExercise;
        public FxEuropeanExercise EuropeanExercise
        {
            get
            {
                if (this.europeanExercise != null)
                {
                    return this.europeanExercise; 
                }
                else if (this.europeanExerciseIDRef != null)
                {
                    europeanExercise = IDManager.getID(europeanExerciseIDRef) as FxEuropeanExercise;
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
        
        public string FxEuropeanExerciseIDRef { get; set; }
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
        #region PutCurrencyAmount
        private NonNegativeMoney putCurrencyAmount;
        public NonNegativeMoney PutCurrencyAmount
        {
            get
            {
                if (this.putCurrencyAmount != null)
                {
                    return this.putCurrencyAmount; 
                }
                else if (this.putCurrencyAmountIDRef != null)
                {
                    putCurrencyAmount = IDManager.getID(putCurrencyAmountIDRef) as NonNegativeMoney;
                    return this.putCurrencyAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.putCurrencyAmount != value)
                {
                    this.putCurrencyAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region CallCurrencyAmount
        private NonNegativeMoney callCurrencyAmount;
        public NonNegativeMoney CallCurrencyAmount
        {
            get
            {
                if (this.callCurrencyAmount != null)
                {
                    return this.callCurrencyAmount; 
                }
                else if (this.callCurrencyAmountIDRef != null)
                {
                    callCurrencyAmount = IDManager.getID(callCurrencyAmountIDRef) as NonNegativeMoney;
                    return this.callCurrencyAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.callCurrencyAmount != value)
                {
                    this.callCurrencyAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region SoldAs
        private PutCallEnum soldAs;
        public PutCallEnum SoldAs
        {
            get
            {
                if (this.soldAs != null)
                {
                    return this.soldAs; 
                }
                else if (this.soldAsIDRef != null)
                {
                    soldAs = IDManager.getID(soldAsIDRef) as PutCallEnum;
                    return this.soldAs; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.soldAs != value)
                {
                    this.soldAs = value;
                }
            }
        }
        #endregion
        
        public string PutCallEnumIDRef { get; set; }
        #region Strike
        private FxStrikePrice strike;
        public FxStrikePrice Strike
        {
            get
            {
                if (this.strike != null)
                {
                    return this.strike; 
                }
                else if (this.strikeIDRef != null)
                {
                    strike = IDManager.getID(strikeIDRef) as FxStrikePrice;
                    return this.strike; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strike != value)
                {
                    this.strike = value;
                }
            }
        }
        #endregion
        
        public string FxStrikePriceIDRef { get; set; }
        #region SpotRate
        private PositiveDecimal spotRate;
        public PositiveDecimal SpotRate
        {
            get
            {
                if (this.spotRate != null)
                {
                    return this.spotRate; 
                }
                else if (this.spotRateIDRef != null)
                {
                    spotRate = IDManager.getID(spotRateIDRef) as PositiveDecimal;
                    return this.spotRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spotRate != value)
                {
                    this.spotRate = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region Features
        private FxOptionFeatures features;
        public FxOptionFeatures Features
        {
            get
            {
                if (this.features != null)
                {
                    return this.features; 
                }
                else if (this.featuresIDRef != null)
                {
                    features = IDManager.getID(featuresIDRef) as FxOptionFeatures;
                    return this.features; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.features != value)
                {
                    this.features = value;
                }
            }
        }
        #endregion
        
        public string FxOptionFeaturesIDRef { get; set; }
        #region Premium
        private List<FxOptionPremium> premium;
        public List<FxOptionPremium> Premium
        {
            get
            {
                if (this.premium != null)
                {
                    return this.premium; 
                }
                else if (this.premiumIDRef != null)
                {
                    premium = IDManager.getID(premiumIDRef) as List<FxOptionPremium>;
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
        
        public string FxOptionPremiumIDRef { get; set; }
        #region CashSettlement
        private FxCashSettlement cashSettlement;
        public FxCashSettlement CashSettlement
        {
            get
            {
                if (this.cashSettlement != null)
                {
                    return this.cashSettlement; 
                }
                else if (this.cashSettlementIDRef != null)
                {
                    cashSettlement = IDManager.getID(cashSettlementIDRef) as FxCashSettlement;
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
        
        public string FxCashSettlementIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

