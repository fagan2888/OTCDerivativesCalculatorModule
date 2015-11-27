using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxDigitalOption : Option
    {
        public FxDigitalOption(XmlNode xmlNode)
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
                        FxDigitalAmericanExercise ob = new FxDigitalAmericanExercise(americanExerciseNode);
                        IDManager.SetID(americanExerciseIDRef_, ob);
                    }
                    else if (americanExerciseNode.Attributes["href"] != null)
                    {
                        americanExerciseIDRef_ = americanExerciseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        americanExercise_ = new FxDigitalAmericanExercise(americanExerciseNode);
                    }
                }
                else
                {
                    americanExercise_ = new FxDigitalAmericanExercise(americanExerciseNode);
                }
            }
            
        
            XmlNodeList touchNodeList = xmlNode.SelectNodes("touch");
            
            if (touchNodeList != null)
            {
                this.touch_ = new List<FxTouch>();
                foreach (XmlNode item in touchNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            touchIDRef_ = item.Attributes["id"].Value;
                            touch_.Add(new FxTouch(item));
                            IDManager.SetID(touchIDRef_, touch_[touch_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            touchIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        touch_.Add(new FxTouch(item));
                        }
                    }
                    else
                    {
                        touch_.Add(new FxTouch(item));
                    }
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
            
        
            XmlNodeList triggerNodeList = xmlNode.SelectNodes("trigger");
            
            if (triggerNodeList != null)
            {
                this.trigger_ = new List<FxTrigger>();
                foreach (XmlNode item in triggerNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            triggerIDRef_ = item.Attributes["id"].Value;
                            trigger_.Add(new FxTrigger(item));
                            IDManager.SetID(triggerIDRef_, trigger_[trigger_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            triggerIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        trigger_.Add(new FxTrigger(item));
                        }
                    }
                    else
                    {
                        trigger_.Add(new FxTrigger(item));
                    }
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
            
        
            XmlNode payoutNode = xmlNode.SelectSingleNode("payout");
            
            if (payoutNode != null)
            {
                if (payoutNode.Attributes["href"] != null || payoutNode.Attributes["id"] != null) 
                {
                    if (payoutNode.Attributes["id"] != null) 
                    {
                        payoutIDRef_ = payoutNode.Attributes["id"].Value;
                        FxOptionPayout ob = new FxOptionPayout(payoutNode);
                        IDManager.SetID(payoutIDRef_, ob);
                    }
                    else if (payoutNode.Attributes["href"] != null)
                    {
                        payoutIDRef_ = payoutNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payout_ = new FxOptionPayout(payoutNode);
                    }
                }
                else
                {
                    payout_ = new FxOptionPayout(payoutNode);
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
        private FxDigitalAmericanExercise americanExercise_;
        public FxDigitalAmericanExercise AmericanExercise_
        {
            get
            {
                if (this.americanExercise_ != null)
                {
                    return this.americanExercise_; 
                }
                else if (this.americanExerciseIDRef_ != null)
                {
                    americanExercise_ = IDManager.getID(americanExerciseIDRef_) as FxDigitalAmericanExercise;
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
        #region Touch_
        private List<FxTouch> touch_;
        public List<FxTouch> Touch_
        {
            get
            {
                if (this.touch_ != null)
                {
                    return this.touch_; 
                }
                else if (this.touchIDRef_ != null)
                {
                    return this.touch_; 
                }
                else
                {
                      return this.touch_; 
                }
            }
            set
            {
                if (this.touch_ != value)
                {
                    this.touch_ = value;
                }
            }
        }
        #endregion
        
        public string touchIDRef_ { get; set; }
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
        #region Trigger_
        private List<FxTrigger> trigger_;
        public List<FxTrigger> Trigger_
        {
            get
            {
                if (this.trigger_ != null)
                {
                    return this.trigger_; 
                }
                else if (this.triggerIDRef_ != null)
                {
                    return this.trigger_; 
                }
                else
                {
                      return this.trigger_; 
                }
            }
            set
            {
                if (this.trigger_ != value)
                {
                    this.trigger_ = value;
                }
            }
        }
        #endregion
        
        public string triggerIDRef_ { get; set; }
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
        #region Payout_
        private FxOptionPayout payout_;
        public FxOptionPayout Payout_
        {
            get
            {
                if (this.payout_ != null)
                {
                    return this.payout_; 
                }
                else if (this.payoutIDRef_ != null)
                {
                    payout_ = IDManager.getID(payoutIDRef_) as FxOptionPayout;
                    return this.payout_; 
                }
                else
                {
                      return this.payout_; 
                }
            }
            set
            {
                if (this.payout_ != value)
                {
                    this.payout_ = value;
                }
            }
        }
        #endregion
        
        public string payoutIDRef_ { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

