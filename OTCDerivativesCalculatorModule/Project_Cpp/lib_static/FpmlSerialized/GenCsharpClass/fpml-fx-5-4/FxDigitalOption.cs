using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxDigitalOption
    {
        public FxDigitalOption(XmlNode xmlNode)
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
                        FxDigitalAmericanExercise ob = FxDigitalAmericanExercise();
                        IDManager.SetID(americanExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        americanExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        americanExercise = new FxDigitalAmericanExercise(item);
                    }
                }
            }
            
        
            XmlNodeList touchNodeList = xmlNode.SelectNodes("touch");
            
            foreach (XmlNode item in touchNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        touchIDRef = item.Attributes["id"].Name;
                        List<FxTouch> ob = new List<FxTouch>();
                        ob.Add(new FxTouch(item));
                        IDManager.SetID(touchIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        touchIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    touch.Add(new FxTouch(item));
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
            
        
            XmlNodeList triggerNodeList = xmlNode.SelectNodes("trigger");
            
            foreach (XmlNode item in triggerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        triggerIDRef = item.Attributes["id"].Name;
                        List<FxTrigger> ob = new List<FxTrigger>();
                        ob.Add(new FxTrigger(item));
                        IDManager.SetID(triggerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        triggerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    trigger.Add(new FxTrigger(item));
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
            
        
            XmlNodeList payoutNodeList = xmlNode.SelectNodes("payout");
            if (payoutNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in payoutNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        payoutIDRef = item.Attributes["id"].Name;
                        FxOptionPayout ob = FxOptionPayout();
                        IDManager.SetID(payoutIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        payoutIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payout = new FxOptionPayout(item);
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
        private FxDigitalAmericanExercise americanExercise;
        public FxDigitalAmericanExercise AmericanExercise
        {
            get
            {
                if (this.americanExercise != null)
                {
                    return this.americanExercise; 
                }
                else if (this.americanExerciseIDRef != null)
                {
                    americanExercise = IDManager.getID(americanExerciseIDRef) as FxDigitalAmericanExercise;
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
        
        public string FxDigitalAmericanExerciseIDRef { get; set; }
        #region Touch
        private List<FxTouch> touch;
        public List<FxTouch> Touch
        {
            get
            {
                if (this.touch != null)
                {
                    return this.touch; 
                }
                else if (this.touchIDRef != null)
                {
                    touch = IDManager.getID(touchIDRef) as List<FxTouch>;
                    return this.touch; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.touch != value)
                {
                    this.touch = value;
                }
            }
        }
        #endregion
        
        public string FxTouchIDRef { get; set; }
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
        #region Trigger
        private List<FxTrigger> trigger;
        public List<FxTrigger> Trigger
        {
            get
            {
                if (this.trigger != null)
                {
                    return this.trigger; 
                }
                else if (this.triggerIDRef != null)
                {
                    trigger = IDManager.getID(triggerIDRef) as List<FxTrigger>;
                    return this.trigger; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.trigger != value)
                {
                    this.trigger = value;
                }
            }
        }
        #endregion
        
        public string FxTriggerIDRef { get; set; }
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
        #region Payout
        private FxOptionPayout payout;
        public FxOptionPayout Payout
        {
            get
            {
                if (this.payout != null)
                {
                    return this.payout; 
                }
                else if (this.payoutIDRef != null)
                {
                    payout = IDManager.getID(payoutIDRef) as FxOptionPayout;
                    return this.payout; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payout != value)
                {
                    this.payout = value;
                }
            }
        }
        #endregion
        
        public string FxOptionPayoutIDRef { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

