using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExtendibleProvision : ISerialized
    {
        public ExtendibleProvision(XmlNode xmlNode)
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
            
        
            XmlNode exerciseNoticeNode = xmlNode.SelectSingleNode("exerciseNotice");
            
            if (exerciseNoticeNode != null)
            {
                if (exerciseNoticeNode.Attributes["href"] != null || exerciseNoticeNode.Attributes["id"] != null) 
                {
                    if (exerciseNoticeNode.Attributes["id"] != null) 
                    {
                        exerciseNoticeIDRef_ = exerciseNoticeNode.Attributes["id"].Value;
                        ExerciseNotice ob = new ExerciseNotice(exerciseNoticeNode);
                        IDManager.SetID(exerciseNoticeIDRef_, ob);
                    }
                    else if (exerciseNoticeNode.Attributes["href"] != null)
                    {
                        exerciseNoticeIDRef_ = exerciseNoticeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exerciseNotice_ = new ExerciseNotice(exerciseNoticeNode);
                    }
                }
                else
                {
                    exerciseNotice_ = new ExerciseNotice(exerciseNoticeNode);
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
            
        
            XmlNode extendibleProvisionAdjustedDatesNode = xmlNode.SelectSingleNode("extendibleProvisionAdjustedDates");
            
            if (extendibleProvisionAdjustedDatesNode != null)
            {
                if (extendibleProvisionAdjustedDatesNode.Attributes["href"] != null || extendibleProvisionAdjustedDatesNode.Attributes["id"] != null) 
                {
                    if (extendibleProvisionAdjustedDatesNode.Attributes["id"] != null) 
                    {
                        extendibleProvisionAdjustedDatesIDRef_ = extendibleProvisionAdjustedDatesNode.Attributes["id"].Value;
                        ExtendibleProvisionAdjustedDates ob = new ExtendibleProvisionAdjustedDates(extendibleProvisionAdjustedDatesNode);
                        IDManager.SetID(extendibleProvisionAdjustedDatesIDRef_, ob);
                    }
                    else if (extendibleProvisionAdjustedDatesNode.Attributes["href"] != null)
                    {
                        extendibleProvisionAdjustedDatesIDRef_ = extendibleProvisionAdjustedDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        extendibleProvisionAdjustedDates_ = new ExtendibleProvisionAdjustedDates(extendibleProvisionAdjustedDatesNode);
                    }
                }
                else
                {
                    extendibleProvisionAdjustedDates_ = new ExtendibleProvisionAdjustedDates(extendibleProvisionAdjustedDatesNode);
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
        private ExerciseNotice exerciseNotice_;
        public ExerciseNotice ExerciseNotice_
        {
            get
            {
                if (this.exerciseNotice_ != null)
                {
                    return this.exerciseNotice_; 
                }
                else if (this.exerciseNoticeIDRef_ != null)
                {
                    exerciseNotice_ = IDManager.getID(exerciseNoticeIDRef_) as ExerciseNotice;
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
        #region ExtendibleProvisionAdjustedDates_
        private ExtendibleProvisionAdjustedDates extendibleProvisionAdjustedDates_;
        public ExtendibleProvisionAdjustedDates ExtendibleProvisionAdjustedDates_
        {
            get
            {
                if (this.extendibleProvisionAdjustedDates_ != null)
                {
                    return this.extendibleProvisionAdjustedDates_; 
                }
                else if (this.extendibleProvisionAdjustedDatesIDRef_ != null)
                {
                    extendibleProvisionAdjustedDates_ = IDManager.getID(extendibleProvisionAdjustedDatesIDRef_) as ExtendibleProvisionAdjustedDates;
                    return this.extendibleProvisionAdjustedDates_; 
                }
                else
                {
                      return this.extendibleProvisionAdjustedDates_; 
                }
            }
            set
            {
                if (this.extendibleProvisionAdjustedDates_ != value)
                {
                    this.extendibleProvisionAdjustedDates_ = value;
                }
            }
        }
        #endregion
        
        public string extendibleProvisionAdjustedDatesIDRef_ { get; set; }
        
    
        
    
    }
    
}

