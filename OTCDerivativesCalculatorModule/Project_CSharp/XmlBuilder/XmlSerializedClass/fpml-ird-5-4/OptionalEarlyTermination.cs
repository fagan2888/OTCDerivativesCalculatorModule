using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OptionalEarlyTermination : ISerialized
    {
        public OptionalEarlyTermination(XmlNode xmlNode)
        {
            XmlNode singlePartyOptionNode = xmlNode.SelectSingleNode("singlePartyOption");
            
            if (singlePartyOptionNode != null)
            {
                if (singlePartyOptionNode.Attributes["href"] != null || singlePartyOptionNode.Attributes["id"] != null) 
                {
                    if (singlePartyOptionNode.Attributes["id"] != null) 
                    {
                        singlePartyOptionIDRef_ = singlePartyOptionNode.Attributes["id"].Value;
                        SinglePartyOption ob = new SinglePartyOption(singlePartyOptionNode);
                        IDManager.SetID(singlePartyOptionIDRef_, ob);
                    }
                    else if (singlePartyOptionNode.Attributes["href"] != null)
                    {
                        singlePartyOptionIDRef_ = singlePartyOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        singlePartyOption_ = new SinglePartyOption(singlePartyOptionNode);
                    }
                }
                else
                {
                    singlePartyOption_ = new SinglePartyOption(singlePartyOptionNode);
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
            
        
            XmlNodeList exerciseNoticeNodeList = xmlNode.SelectNodes("exerciseNotice");
            
            if (exerciseNoticeNodeList != null)
            {
                this.exerciseNotice_ = new List<ExerciseNotice>();
                foreach (XmlNode item in exerciseNoticeNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            exerciseNoticeIDRef_ = item.Attributes["id"].Value;
                            exerciseNotice_.Add(new ExerciseNotice(item));
                            IDManager.SetID(exerciseNoticeIDRef_, exerciseNotice_[exerciseNotice_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            exerciseNoticeIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        exerciseNotice_.Add(new ExerciseNotice(item));
                        }
                    }
                    else
                    {
                        exerciseNotice_.Add(new ExerciseNotice(item));
                    }
                }
            }
            
        
            XmlNode followUpConfirmationNode = xmlNode.SelectSingleNode("followUpConfirmation");
            
            if (followUpConfirmationNode != null)
            {
                if (followUpConfirmationNode.Attributes["href"] != null || followUpConfirmationNode.Attributes["id"] != null) 
                {
                    if (followUpConfirmationNode.Attributes["id"] != null) 
                    {
                        followUpConfirmationIDRef_ = followUpConfirmationNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(followUpConfirmationNode);
                        IDManager.SetID(followUpConfirmationIDRef_, ob);
                    }
                    else if (followUpConfirmationNode.Attributes["href"] != null)
                    {
                        followUpConfirmationIDRef_ = followUpConfirmationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        followUpConfirmation_ = new XsdTypeBoolean(followUpConfirmationNode);
                    }
                }
                else
                {
                    followUpConfirmation_ = new XsdTypeBoolean(followUpConfirmationNode);
                }
            }
            
        
            XmlNode calculationAgentNode = xmlNode.SelectSingleNode("calculationAgent");
            
            if (calculationAgentNode != null)
            {
                if (calculationAgentNode.Attributes["href"] != null || calculationAgentNode.Attributes["id"] != null) 
                {
                    if (calculationAgentNode.Attributes["id"] != null) 
                    {
                        calculationAgentIDRef_ = calculationAgentNode.Attributes["id"].Value;
                        CalculationAgent ob = new CalculationAgent(calculationAgentNode);
                        IDManager.SetID(calculationAgentIDRef_, ob);
                    }
                    else if (calculationAgentNode.Attributes["href"] != null)
                    {
                        calculationAgentIDRef_ = calculationAgentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationAgent_ = new CalculationAgent(calculationAgentNode);
                    }
                }
                else
                {
                    calculationAgent_ = new CalculationAgent(calculationAgentNode);
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
                        CashSettlement ob = new CashSettlement(cashSettlementNode);
                        IDManager.SetID(cashSettlementIDRef_, ob);
                    }
                    else if (cashSettlementNode.Attributes["href"] != null)
                    {
                        cashSettlementIDRef_ = cashSettlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashSettlement_ = new CashSettlement(cashSettlementNode);
                    }
                }
                else
                {
                    cashSettlement_ = new CashSettlement(cashSettlementNode);
                }
            }
            
        
            XmlNode optionalEarlyTerminationAdjustedDatesNode = xmlNode.SelectSingleNode("optionalEarlyTerminationAdjustedDates");
            
            if (optionalEarlyTerminationAdjustedDatesNode != null)
            {
                if (optionalEarlyTerminationAdjustedDatesNode.Attributes["href"] != null || optionalEarlyTerminationAdjustedDatesNode.Attributes["id"] != null) 
                {
                    if (optionalEarlyTerminationAdjustedDatesNode.Attributes["id"] != null) 
                    {
                        optionalEarlyTerminationAdjustedDatesIDRef_ = optionalEarlyTerminationAdjustedDatesNode.Attributes["id"].Value;
                        OptionalEarlyTerminationAdjustedDates ob = new OptionalEarlyTerminationAdjustedDates(optionalEarlyTerminationAdjustedDatesNode);
                        IDManager.SetID(optionalEarlyTerminationAdjustedDatesIDRef_, ob);
                    }
                    else if (optionalEarlyTerminationAdjustedDatesNode.Attributes["href"] != null)
                    {
                        optionalEarlyTerminationAdjustedDatesIDRef_ = optionalEarlyTerminationAdjustedDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionalEarlyTerminationAdjustedDates_ = new OptionalEarlyTerminationAdjustedDates(optionalEarlyTerminationAdjustedDatesNode);
                    }
                }
                else
                {
                    optionalEarlyTerminationAdjustedDates_ = new OptionalEarlyTerminationAdjustedDates(optionalEarlyTerminationAdjustedDatesNode);
                }
            }
            
        
        }
        
    
        #region SinglePartyOption_
        private SinglePartyOption singlePartyOption_;
        public SinglePartyOption SinglePartyOption_
        {
            get
            {
                if (this.singlePartyOption_ != null)
                {
                    return this.singlePartyOption_; 
                }
                else if (this.singlePartyOptionIDRef_ != null)
                {
                    singlePartyOption_ = IDManager.getID(singlePartyOptionIDRef_) as SinglePartyOption;
                    return this.singlePartyOption_; 
                }
                else
                {
                      return this.singlePartyOption_; 
                }
            }
            set
            {
                if (this.singlePartyOption_ != value)
                {
                    this.singlePartyOption_ = value;
                }
            }
        }
        #endregion
        
        public string singlePartyOptionIDRef_ { get; set; }
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
        #region ExerciseNotice_
        private List<ExerciseNotice> exerciseNotice_;
        public List<ExerciseNotice> ExerciseNotice_
        {
            get
            {
                if (this.exerciseNotice_ != null)
                {
                    return this.exerciseNotice_; 
                }
                else if (this.exerciseNoticeIDRef_ != null)
                {
                    return this.exerciseNotice_; 
                }
                else
                {
                      return this.exerciseNotice_; 
                }
            }
            set
            {
                if (this.exerciseNotice_ != value)
                {
                    this.exerciseNotice_ = value;
                }
            }
        }
        #endregion
        
        public string exerciseNoticeIDRef_ { get; set; }
        #region FollowUpConfirmation_
        private XsdTypeBoolean followUpConfirmation_;
        public XsdTypeBoolean FollowUpConfirmation_
        {
            get
            {
                if (this.followUpConfirmation_ != null)
                {
                    return this.followUpConfirmation_; 
                }
                else if (this.followUpConfirmationIDRef_ != null)
                {
                    followUpConfirmation_ = IDManager.getID(followUpConfirmationIDRef_) as XsdTypeBoolean;
                    return this.followUpConfirmation_; 
                }
                else
                {
                      return this.followUpConfirmation_; 
                }
            }
            set
            {
                if (this.followUpConfirmation_ != value)
                {
                    this.followUpConfirmation_ = value;
                }
            }
        }
        #endregion
        
        public string followUpConfirmationIDRef_ { get; set; }
        #region CalculationAgent_
        private CalculationAgent calculationAgent_;
        public CalculationAgent CalculationAgent_
        {
            get
            {
                if (this.calculationAgent_ != null)
                {
                    return this.calculationAgent_; 
                }
                else if (this.calculationAgentIDRef_ != null)
                {
                    calculationAgent_ = IDManager.getID(calculationAgentIDRef_) as CalculationAgent;
                    return this.calculationAgent_; 
                }
                else
                {
                      return this.calculationAgent_; 
                }
            }
            set
            {
                if (this.calculationAgent_ != value)
                {
                    this.calculationAgent_ = value;
                }
            }
        }
        #endregion
        
        public string calculationAgentIDRef_ { get; set; }
        #region CashSettlement_
        private CashSettlement cashSettlement_;
        public CashSettlement CashSettlement_
        {
            get
            {
                if (this.cashSettlement_ != null)
                {
                    return this.cashSettlement_; 
                }
                else if (this.cashSettlementIDRef_ != null)
                {
                    cashSettlement_ = IDManager.getID(cashSettlementIDRef_) as CashSettlement;
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
        #region OptionalEarlyTerminationAdjustedDates_
        private OptionalEarlyTerminationAdjustedDates optionalEarlyTerminationAdjustedDates_;
        public OptionalEarlyTerminationAdjustedDates OptionalEarlyTerminationAdjustedDates_
        {
            get
            {
                if (this.optionalEarlyTerminationAdjustedDates_ != null)
                {
                    return this.optionalEarlyTerminationAdjustedDates_; 
                }
                else if (this.optionalEarlyTerminationAdjustedDatesIDRef_ != null)
                {
                    optionalEarlyTerminationAdjustedDates_ = IDManager.getID(optionalEarlyTerminationAdjustedDatesIDRef_) as OptionalEarlyTerminationAdjustedDates;
                    return this.optionalEarlyTerminationAdjustedDates_; 
                }
                else
                {
                      return this.optionalEarlyTerminationAdjustedDates_; 
                }
            }
            set
            {
                if (this.optionalEarlyTerminationAdjustedDates_ != value)
                {
                    this.optionalEarlyTerminationAdjustedDates_ = value;
                }
            }
        }
        #endregion
        
        public string optionalEarlyTerminationAdjustedDatesIDRef_ { get; set; }
        
    
        
    
    }
    
}

