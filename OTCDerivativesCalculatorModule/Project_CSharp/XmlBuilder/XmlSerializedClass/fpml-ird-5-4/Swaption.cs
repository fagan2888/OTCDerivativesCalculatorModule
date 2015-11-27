using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Swaption : Product
    {
        public Swaption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode buyerPartyReferenceNode = xmlNode.SelectSingleNode("buyerPartyReference");
            
            if (buyerPartyReferenceNode != null)
            {
                if (buyerPartyReferenceNode.Attributes["href"] != null || buyerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (buyerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        buyerPartyReferenceIDRef_ = buyerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(buyerPartyReferenceNode);
                        IDManager.SetID(buyerPartyReferenceIDRef_, ob);
                    }
                    else if (buyerPartyReferenceNode.Attributes["href"] != null)
                    {
                        buyerPartyReferenceIDRef_ = buyerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        buyerPartyReference_ = new PartyReference(buyerPartyReferenceNode);
                    }
                }
                else
                {
                    buyerPartyReference_ = new PartyReference(buyerPartyReferenceNode);
                }
            }
            
        
            XmlNode buyerAccountReferenceNode = xmlNode.SelectSingleNode("buyerAccountReference");
            
            if (buyerAccountReferenceNode != null)
            {
                if (buyerAccountReferenceNode.Attributes["href"] != null || buyerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (buyerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        buyerAccountReferenceIDRef_ = buyerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(buyerAccountReferenceNode);
                        IDManager.SetID(buyerAccountReferenceIDRef_, ob);
                    }
                    else if (buyerAccountReferenceNode.Attributes["href"] != null)
                    {
                        buyerAccountReferenceIDRef_ = buyerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        buyerAccountReference_ = new AccountReference(buyerAccountReferenceNode);
                    }
                }
                else
                {
                    buyerAccountReference_ = new AccountReference(buyerAccountReferenceNode);
                }
            }
            
        
            XmlNode sellerPartyReferenceNode = xmlNode.SelectSingleNode("sellerPartyReference");
            
            if (sellerPartyReferenceNode != null)
            {
                if (sellerPartyReferenceNode.Attributes["href"] != null || sellerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (sellerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        sellerPartyReferenceIDRef_ = sellerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(sellerPartyReferenceNode);
                        IDManager.SetID(sellerPartyReferenceIDRef_, ob);
                    }
                    else if (sellerPartyReferenceNode.Attributes["href"] != null)
                    {
                        sellerPartyReferenceIDRef_ = sellerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sellerPartyReference_ = new PartyReference(sellerPartyReferenceNode);
                    }
                }
                else
                {
                    sellerPartyReference_ = new PartyReference(sellerPartyReferenceNode);
                }
            }
            
        
            XmlNode sellerAccountReferenceNode = xmlNode.SelectSingleNode("sellerAccountReference");
            
            if (sellerAccountReferenceNode != null)
            {
                if (sellerAccountReferenceNode.Attributes["href"] != null || sellerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (sellerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        sellerAccountReferenceIDRef_ = sellerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(sellerAccountReferenceNode);
                        IDManager.SetID(sellerAccountReferenceIDRef_, ob);
                    }
                    else if (sellerAccountReferenceNode.Attributes["href"] != null)
                    {
                        sellerAccountReferenceIDRef_ = sellerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sellerAccountReference_ = new AccountReference(sellerAccountReferenceNode);
                    }
                }
                else
                {
                    sellerAccountReference_ = new AccountReference(sellerAccountReferenceNode);
                }
            }
            
        
            XmlNodeList premiumNodeList = xmlNode.SelectNodes("premium");
            
            if (premiumNodeList != null)
            {
                this.premium_ = new List<Payment>();
                foreach (XmlNode item in premiumNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            premiumIDRef_ = item.Attributes["id"].Value;
                            premium_.Add(new Payment(item));
                            IDManager.SetID(premiumIDRef_, premium_[premium_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            premiumIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        premium_.Add(new Payment(item));
                        }
                    }
                    else
                    {
                        premium_.Add(new Payment(item));
                    }
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
            
        
            XmlNode physicalSettlementNode = xmlNode.SelectSingleNode("physicalSettlement");
            
            if (physicalSettlementNode != null)
            {
                if (physicalSettlementNode.Attributes["href"] != null || physicalSettlementNode.Attributes["id"] != null) 
                {
                    if (physicalSettlementNode.Attributes["id"] != null) 
                    {
                        physicalSettlementIDRef_ = physicalSettlementNode.Attributes["id"].Value;
                        SwaptionPhysicalSettlement ob = new SwaptionPhysicalSettlement(physicalSettlementNode);
                        IDManager.SetID(physicalSettlementIDRef_, ob);
                    }
                    else if (physicalSettlementNode.Attributes["href"] != null)
                    {
                        physicalSettlementIDRef_ = physicalSettlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        physicalSettlement_ = new SwaptionPhysicalSettlement(physicalSettlementNode);
                    }
                }
                else
                {
                    physicalSettlement_ = new SwaptionPhysicalSettlement(physicalSettlementNode);
                }
            }
            
        
            XmlNode swaptionStraddleNode = xmlNode.SelectSingleNode("swaptionStraddle");
            
            if (swaptionStraddleNode != null)
            {
                if (swaptionStraddleNode.Attributes["href"] != null || swaptionStraddleNode.Attributes["id"] != null) 
                {
                    if (swaptionStraddleNode.Attributes["id"] != null) 
                    {
                        swaptionStraddleIDRef_ = swaptionStraddleNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(swaptionStraddleNode);
                        IDManager.SetID(swaptionStraddleIDRef_, ob);
                    }
                    else if (swaptionStraddleNode.Attributes["href"] != null)
                    {
                        swaptionStraddleIDRef_ = swaptionStraddleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        swaptionStraddle_ = new XsdTypeBoolean(swaptionStraddleNode);
                    }
                }
                else
                {
                    swaptionStraddle_ = new XsdTypeBoolean(swaptionStraddleNode);
                }
            }
            
        
            XmlNode swaptionAdjustedDatesNode = xmlNode.SelectSingleNode("swaptionAdjustedDates");
            
            if (swaptionAdjustedDatesNode != null)
            {
                if (swaptionAdjustedDatesNode.Attributes["href"] != null || swaptionAdjustedDatesNode.Attributes["id"] != null) 
                {
                    if (swaptionAdjustedDatesNode.Attributes["id"] != null) 
                    {
                        swaptionAdjustedDatesIDRef_ = swaptionAdjustedDatesNode.Attributes["id"].Value;
                        SwaptionAdjustedDates ob = new SwaptionAdjustedDates(swaptionAdjustedDatesNode);
                        IDManager.SetID(swaptionAdjustedDatesIDRef_, ob);
                    }
                    else if (swaptionAdjustedDatesNode.Attributes["href"] != null)
                    {
                        swaptionAdjustedDatesIDRef_ = swaptionAdjustedDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        swaptionAdjustedDates_ = new SwaptionAdjustedDates(swaptionAdjustedDatesNode);
                    }
                }
                else
                {
                    swaptionAdjustedDates_ = new SwaptionAdjustedDates(swaptionAdjustedDatesNode);
                }
            }
            
        
            XmlNode swapNode = xmlNode.SelectSingleNode("swap");
            
            if (swapNode != null)
            {
                if (swapNode.Attributes["href"] != null || swapNode.Attributes["id"] != null) 
                {
                    if (swapNode.Attributes["id"] != null) 
                    {
                        swapIDRef_ = swapNode.Attributes["id"].Value;
                        Swap ob = new Swap(swapNode);
                        IDManager.SetID(swapIDRef_, ob);
                    }
                    else if (swapNode.Attributes["href"] != null)
                    {
                        swapIDRef_ = swapNode.Attributes["href"].Value;
                    }
                    else
                    {
                        swap_ = new Swap(swapNode);
                    }
                }
                else
                {
                    swap_ = new Swap(swapNode);
                }
            }
            
        
        }
        
    
        #region BuyerPartyReference_
        private PartyReference buyerPartyReference_;
        public PartyReference BuyerPartyReference_
        {
            get
            {
                if (this.buyerPartyReference_ != null)
                {
                    return this.buyerPartyReference_; 
                }
                else if (this.buyerPartyReferenceIDRef_ != null)
                {
                    buyerPartyReference_ = IDManager.getID(buyerPartyReferenceIDRef_) as PartyReference;
                    return this.buyerPartyReference_; 
                }
                else
                {
                      return this.buyerPartyReference_; 
                }
            }
            set
            {
                if (this.buyerPartyReference_ != value)
                {
                    this.buyerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string buyerPartyReferenceIDRef_ { get; set; }
        #region BuyerAccountReference_
        private AccountReference buyerAccountReference_;
        public AccountReference BuyerAccountReference_
        {
            get
            {
                if (this.buyerAccountReference_ != null)
                {
                    return this.buyerAccountReference_; 
                }
                else if (this.buyerAccountReferenceIDRef_ != null)
                {
                    buyerAccountReference_ = IDManager.getID(buyerAccountReferenceIDRef_) as AccountReference;
                    return this.buyerAccountReference_; 
                }
                else
                {
                      return this.buyerAccountReference_; 
                }
            }
            set
            {
                if (this.buyerAccountReference_ != value)
                {
                    this.buyerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string buyerAccountReferenceIDRef_ { get; set; }
        #region SellerPartyReference_
        private PartyReference sellerPartyReference_;
        public PartyReference SellerPartyReference_
        {
            get
            {
                if (this.sellerPartyReference_ != null)
                {
                    return this.sellerPartyReference_; 
                }
                else if (this.sellerPartyReferenceIDRef_ != null)
                {
                    sellerPartyReference_ = IDManager.getID(sellerPartyReferenceIDRef_) as PartyReference;
                    return this.sellerPartyReference_; 
                }
                else
                {
                      return this.sellerPartyReference_; 
                }
            }
            set
            {
                if (this.sellerPartyReference_ != value)
                {
                    this.sellerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string sellerPartyReferenceIDRef_ { get; set; }
        #region SellerAccountReference_
        private AccountReference sellerAccountReference_;
        public AccountReference SellerAccountReference_
        {
            get
            {
                if (this.sellerAccountReference_ != null)
                {
                    return this.sellerAccountReference_; 
                }
                else if (this.sellerAccountReferenceIDRef_ != null)
                {
                    sellerAccountReference_ = IDManager.getID(sellerAccountReferenceIDRef_) as AccountReference;
                    return this.sellerAccountReference_; 
                }
                else
                {
                      return this.sellerAccountReference_; 
                }
            }
            set
            {
                if (this.sellerAccountReference_ != value)
                {
                    this.sellerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string sellerAccountReferenceIDRef_ { get; set; }
        #region Premium_
        private List<Payment> premium_;
        public List<Payment> Premium_
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
        #region PhysicalSettlement_
        private SwaptionPhysicalSettlement physicalSettlement_;
        public SwaptionPhysicalSettlement PhysicalSettlement_
        {
            get
            {
                if (this.physicalSettlement_ != null)
                {
                    return this.physicalSettlement_; 
                }
                else if (this.physicalSettlementIDRef_ != null)
                {
                    physicalSettlement_ = IDManager.getID(physicalSettlementIDRef_) as SwaptionPhysicalSettlement;
                    return this.physicalSettlement_; 
                }
                else
                {
                      return this.physicalSettlement_; 
                }
            }
            set
            {
                if (this.physicalSettlement_ != value)
                {
                    this.physicalSettlement_ = value;
                }
            }
        }
        #endregion
        
        public string physicalSettlementIDRef_ { get; set; }
        #region SwaptionStraddle_
        private XsdTypeBoolean swaptionStraddle_;
        public XsdTypeBoolean SwaptionStraddle_
        {
            get
            {
                if (this.swaptionStraddle_ != null)
                {
                    return this.swaptionStraddle_; 
                }
                else if (this.swaptionStraddleIDRef_ != null)
                {
                    swaptionStraddle_ = IDManager.getID(swaptionStraddleIDRef_) as XsdTypeBoolean;
                    return this.swaptionStraddle_; 
                }
                else
                {
                      return this.swaptionStraddle_; 
                }
            }
            set
            {
                if (this.swaptionStraddle_ != value)
                {
                    this.swaptionStraddle_ = value;
                }
            }
        }
        #endregion
        
        public string swaptionStraddleIDRef_ { get; set; }
        #region SwaptionAdjustedDates_
        private SwaptionAdjustedDates swaptionAdjustedDates_;
        public SwaptionAdjustedDates SwaptionAdjustedDates_
        {
            get
            {
                if (this.swaptionAdjustedDates_ != null)
                {
                    return this.swaptionAdjustedDates_; 
                }
                else if (this.swaptionAdjustedDatesIDRef_ != null)
                {
                    swaptionAdjustedDates_ = IDManager.getID(swaptionAdjustedDatesIDRef_) as SwaptionAdjustedDates;
                    return this.swaptionAdjustedDates_; 
                }
                else
                {
                      return this.swaptionAdjustedDates_; 
                }
            }
            set
            {
                if (this.swaptionAdjustedDates_ != value)
                {
                    this.swaptionAdjustedDates_ = value;
                }
            }
        }
        #endregion
        
        public string swaptionAdjustedDatesIDRef_ { get; set; }
        #region Swap_
        private Swap swap_;
        public Swap Swap_
        {
            get
            {
                if (this.swap_ != null)
                {
                    return this.swap_; 
                }
                else if (this.swapIDRef_ != null)
                {
                    swap_ = IDManager.getID(swapIDRef_) as Swap;
                    return this.swap_; 
                }
                else
                {
                      return this.swap_; 
                }
            }
            set
            {
                if (this.swap_ != value)
                {
                    this.swap_ = value;
                }
            }
        }
        #endregion
        
        public string swapIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

