using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class OptionalEarlyTermination
    {
        public OptionalEarlyTermination(XmlNode xmlNode)
        {
            XmlNodeList singlePartyOptionNodeList = xmlNode.SelectNodes("singlePartyOption");
            if (singlePartyOptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in singlePartyOptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        singlePartyOptionIDRef = item.Attributes["id"].Name;
                        SinglePartyOption ob = SinglePartyOption();
                        IDManager.SetID(singlePartyOptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        singlePartyOptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        singlePartyOption = new SinglePartyOption(item);
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
            
        
            XmlNodeList exerciseNoticeNodeList = xmlNode.SelectNodes("exerciseNotice");
            
            foreach (XmlNode item in exerciseNoticeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseNoticeIDRef = item.Attributes["id"].Name;
                        List<ExerciseNotice> ob = new List<ExerciseNotice>();
                        ob.Add(new ExerciseNotice(item));
                        IDManager.SetID(exerciseNoticeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseNoticeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    exerciseNotice.Add(new ExerciseNotice(item));
                    }
                }
            }
            
        
            XmlNodeList followUpConfirmationNodeList = xmlNode.SelectNodes("followUpConfirmation");
            if (followUpConfirmationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in followUpConfirmationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        followUpConfirmationIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(followUpConfirmationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        followUpConfirmationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        followUpConfirmation = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList calculationAgentNodeList = xmlNode.SelectNodes("calculationAgent");
            if (calculationAgentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationAgentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationAgentIDRef = item.Attributes["id"].Name;
                        CalculationAgent ob = CalculationAgent();
                        IDManager.SetID(calculationAgentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationAgentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationAgent = new CalculationAgent(item);
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
                        CashSettlement ob = CashSettlement();
                        IDManager.SetID(cashSettlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashSettlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashSettlement = new CashSettlement(item);
                    }
                }
            }
            
        
            XmlNodeList optionalEarlyTerminationAdjustedDatesNodeList = xmlNode.SelectNodes("optionalEarlyTerminationAdjustedDates");
            if (optionalEarlyTerminationAdjustedDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionalEarlyTerminationAdjustedDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionalEarlyTerminationAdjustedDatesIDRef = item.Attributes["id"].Name;
                        OptionalEarlyTerminationAdjustedDates ob = OptionalEarlyTerminationAdjustedDates();
                        IDManager.SetID(optionalEarlyTerminationAdjustedDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionalEarlyTerminationAdjustedDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionalEarlyTerminationAdjustedDates = new OptionalEarlyTerminationAdjustedDates(item);
                    }
                }
            }
            
        
        }
        
    
        #region SinglePartyOption
        private SinglePartyOption singlePartyOption;
        public SinglePartyOption SinglePartyOption
        {
            get
            {
                if (this.singlePartyOption != null)
                {
                    return this.singlePartyOption; 
                }
                else if (this.singlePartyOptionIDRef != null)
                {
                    singlePartyOption = IDManager.getID(singlePartyOptionIDRef) as SinglePartyOption;
                    return this.singlePartyOption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.singlePartyOption != value)
                {
                    this.singlePartyOption = value;
                }
            }
        }
        #endregion
        
        public string SinglePartyOptionIDRef { get; set; }
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
        #region ExerciseNotice
        private List<ExerciseNotice> exerciseNotice;
        public List<ExerciseNotice> ExerciseNotice
        {
            get
            {
                if (this.exerciseNotice != null)
                {
                    return this.exerciseNotice; 
                }
                else if (this.exerciseNoticeIDRef != null)
                {
                    exerciseNotice = IDManager.getID(exerciseNoticeIDRef) as List<ExerciseNotice>;
                    return this.exerciseNotice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exerciseNotice != value)
                {
                    this.exerciseNotice = value;
                }
            }
        }
        #endregion
        
        public string ExerciseNoticeIDRef { get; set; }
        #region FollowUpConfirmation
        private XsdTypeBoolean followUpConfirmation;
        public XsdTypeBoolean FollowUpConfirmation
        {
            get
            {
                if (this.followUpConfirmation != null)
                {
                    return this.followUpConfirmation; 
                }
                else if (this.followUpConfirmationIDRef != null)
                {
                    followUpConfirmation = IDManager.getID(followUpConfirmationIDRef) as XsdTypeBoolean;
                    return this.followUpConfirmation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.followUpConfirmation != value)
                {
                    this.followUpConfirmation = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region CalculationAgent
        private CalculationAgent calculationAgent;
        public CalculationAgent CalculationAgent
        {
            get
            {
                if (this.calculationAgent != null)
                {
                    return this.calculationAgent; 
                }
                else if (this.calculationAgentIDRef != null)
                {
                    calculationAgent = IDManager.getID(calculationAgentIDRef) as CalculationAgent;
                    return this.calculationAgent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationAgent != value)
                {
                    this.calculationAgent = value;
                }
            }
        }
        #endregion
        
        public string CalculationAgentIDRef { get; set; }
        #region CashSettlement
        private CashSettlement cashSettlement;
        public CashSettlement CashSettlement
        {
            get
            {
                if (this.cashSettlement != null)
                {
                    return this.cashSettlement; 
                }
                else if (this.cashSettlementIDRef != null)
                {
                    cashSettlement = IDManager.getID(cashSettlementIDRef) as CashSettlement;
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
        
        public string CashSettlementIDRef { get; set; }
        #region OptionalEarlyTerminationAdjustedDates
        private OptionalEarlyTerminationAdjustedDates optionalEarlyTerminationAdjustedDates;
        public OptionalEarlyTerminationAdjustedDates OptionalEarlyTerminationAdjustedDates
        {
            get
            {
                if (this.optionalEarlyTerminationAdjustedDates != null)
                {
                    return this.optionalEarlyTerminationAdjustedDates; 
                }
                else if (this.optionalEarlyTerminationAdjustedDatesIDRef != null)
                {
                    optionalEarlyTerminationAdjustedDates = IDManager.getID(optionalEarlyTerminationAdjustedDatesIDRef) as OptionalEarlyTerminationAdjustedDates;
                    return this.optionalEarlyTerminationAdjustedDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionalEarlyTerminationAdjustedDates != value)
                {
                    this.optionalEarlyTerminationAdjustedDates = value;
                }
            }
        }
        #endregion
        
        public string OptionalEarlyTerminationAdjustedDatesIDRef { get; set; }
        
    
        
    
    }
    
}

