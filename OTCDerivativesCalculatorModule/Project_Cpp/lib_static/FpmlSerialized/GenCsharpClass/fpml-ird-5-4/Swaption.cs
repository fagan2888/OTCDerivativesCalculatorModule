using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Swaption
    {
        public Swaption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList buyerPartyReferenceNodeList = xmlNode.SelectNodes("buyerPartyReference");
            if (buyerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in buyerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        buyerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(buyerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        buyerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        buyerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList buyerAccountReferenceNodeList = xmlNode.SelectNodes("buyerAccountReference");
            if (buyerAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in buyerAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        buyerAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(buyerAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        buyerAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        buyerAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList sellerPartyReferenceNodeList = xmlNode.SelectNodes("sellerPartyReference");
            if (sellerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sellerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sellerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(sellerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sellerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sellerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList sellerAccountReferenceNodeList = xmlNode.SelectNodes("sellerAccountReference");
            if (sellerAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sellerAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sellerAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(sellerAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sellerAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sellerAccountReference = new AccountReference(item);
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
                        List<Payment> ob = new List<Payment>();
                        ob.Add(new Payment(item));
                        IDManager.SetID(premiumIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        premiumIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    premium.Add(new Payment(item));
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
                        SwaptionPhysicalSettlement ob = SwaptionPhysicalSettlement();
                        IDManager.SetID(physicalSettlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        physicalSettlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        physicalSettlement = new SwaptionPhysicalSettlement(item);
                    }
                }
            }
            
        
            XmlNodeList swaptionStraddleNodeList = xmlNode.SelectNodes("swaptionStraddle");
            if (swaptionStraddleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in swaptionStraddleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        swaptionStraddleIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(swaptionStraddleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        swaptionStraddleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        swaptionStraddle = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList swaptionAdjustedDatesNodeList = xmlNode.SelectNodes("swaptionAdjustedDates");
            if (swaptionAdjustedDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in swaptionAdjustedDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        swaptionAdjustedDatesIDRef = item.Attributes["id"].Name;
                        SwaptionAdjustedDates ob = SwaptionAdjustedDates();
                        IDManager.SetID(swaptionAdjustedDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        swaptionAdjustedDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        swaptionAdjustedDates = new SwaptionAdjustedDates(item);
                    }
                }
            }
            
        
            XmlNodeList swapNodeList = xmlNode.SelectNodes("swap");
            if (swapNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in swapNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        swapIDRef = item.Attributes["id"].Name;
                        Swap ob = Swap();
                        IDManager.SetID(swapIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        swapIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        swap = new Swap(item);
                    }
                }
            }
            
        
        }
        
    
        #region BuyerPartyReference
        private PartyReference buyerPartyReference;
        public PartyReference BuyerPartyReference
        {
            get
            {
                if (this.buyerPartyReference != null)
                {
                    return this.buyerPartyReference; 
                }
                else if (this.buyerPartyReferenceIDRef != null)
                {
                    buyerPartyReference = IDManager.getID(buyerPartyReferenceIDRef) as PartyReference;
                    return this.buyerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.buyerPartyReference != value)
                {
                    this.buyerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region BuyerAccountReference
        private AccountReference buyerAccountReference;
        public AccountReference BuyerAccountReference
        {
            get
            {
                if (this.buyerAccountReference != null)
                {
                    return this.buyerAccountReference; 
                }
                else if (this.buyerAccountReferenceIDRef != null)
                {
                    buyerAccountReference = IDManager.getID(buyerAccountReferenceIDRef) as AccountReference;
                    return this.buyerAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.buyerAccountReference != value)
                {
                    this.buyerAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region SellerPartyReference
        private PartyReference sellerPartyReference;
        public PartyReference SellerPartyReference
        {
            get
            {
                if (this.sellerPartyReference != null)
                {
                    return this.sellerPartyReference; 
                }
                else if (this.sellerPartyReferenceIDRef != null)
                {
                    sellerPartyReference = IDManager.getID(sellerPartyReferenceIDRef) as PartyReference;
                    return this.sellerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sellerPartyReference != value)
                {
                    this.sellerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region SellerAccountReference
        private AccountReference sellerAccountReference;
        public AccountReference SellerAccountReference
        {
            get
            {
                if (this.sellerAccountReference != null)
                {
                    return this.sellerAccountReference; 
                }
                else if (this.sellerAccountReferenceIDRef != null)
                {
                    sellerAccountReference = IDManager.getID(sellerAccountReferenceIDRef) as AccountReference;
                    return this.sellerAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sellerAccountReference != value)
                {
                    this.sellerAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region Premium
        private List<Payment> premium;
        public List<Payment> Premium
        {
            get
            {
                if (this.premium != null)
                {
                    return this.premium; 
                }
                else if (this.premiumIDRef != null)
                {
                    premium = IDManager.getID(premiumIDRef) as List<Payment>;
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
        
        public string PaymentIDRef { get; set; }
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
        #region PhysicalSettlement
        private SwaptionPhysicalSettlement physicalSettlement;
        public SwaptionPhysicalSettlement PhysicalSettlement
        {
            get
            {
                if (this.physicalSettlement != null)
                {
                    return this.physicalSettlement; 
                }
                else if (this.physicalSettlementIDRef != null)
                {
                    physicalSettlement = IDManager.getID(physicalSettlementIDRef) as SwaptionPhysicalSettlement;
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
        
        public string SwaptionPhysicalSettlementIDRef { get; set; }
        #region SwaptionStraddle
        private XsdTypeBoolean swaptionStraddle;
        public XsdTypeBoolean SwaptionStraddle
        {
            get
            {
                if (this.swaptionStraddle != null)
                {
                    return this.swaptionStraddle; 
                }
                else if (this.swaptionStraddleIDRef != null)
                {
                    swaptionStraddle = IDManager.getID(swaptionStraddleIDRef) as XsdTypeBoolean;
                    return this.swaptionStraddle; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.swaptionStraddle != value)
                {
                    this.swaptionStraddle = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region SwaptionAdjustedDates
        private SwaptionAdjustedDates swaptionAdjustedDates;
        public SwaptionAdjustedDates SwaptionAdjustedDates
        {
            get
            {
                if (this.swaptionAdjustedDates != null)
                {
                    return this.swaptionAdjustedDates; 
                }
                else if (this.swaptionAdjustedDatesIDRef != null)
                {
                    swaptionAdjustedDates = IDManager.getID(swaptionAdjustedDatesIDRef) as SwaptionAdjustedDates;
                    return this.swaptionAdjustedDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.swaptionAdjustedDates != value)
                {
                    this.swaptionAdjustedDates = value;
                }
            }
        }
        #endregion
        
        public string SwaptionAdjustedDatesIDRef { get; set; }
        #region Swap
        private Swap swap;
        public Swap Swap
        {
            get
            {
                if (this.swap != null)
                {
                    return this.swap; 
                }
                else if (this.swapIDRef != null)
                {
                    swap = IDManager.getID(swapIDRef) as Swap;
                    return this.swap; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.swap != value)
                {
                    this.swap = value;
                }
            }
        }
        #endregion
        
        public string SwapIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

