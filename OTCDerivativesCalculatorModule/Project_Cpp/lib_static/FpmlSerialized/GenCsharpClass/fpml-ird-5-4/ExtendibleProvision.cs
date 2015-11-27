using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ExtendibleProvision
    {
        public ExtendibleProvision(XmlNode xmlNode)
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
            if (exerciseNoticeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exerciseNoticeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exerciseNoticeIDRef = item.Attributes["id"].Name;
                        ExerciseNotice ob = ExerciseNotice();
                        IDManager.SetID(exerciseNoticeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exerciseNoticeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exerciseNotice = new ExerciseNotice(item);
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
            
        
            XmlNodeList extendibleProvisionAdjustedDatesNodeList = xmlNode.SelectNodes("extendibleProvisionAdjustedDates");
            if (extendibleProvisionAdjustedDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in extendibleProvisionAdjustedDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        extendibleProvisionAdjustedDatesIDRef = item.Attributes["id"].Name;
                        ExtendibleProvisionAdjustedDates ob = ExtendibleProvisionAdjustedDates();
                        IDManager.SetID(extendibleProvisionAdjustedDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        extendibleProvisionAdjustedDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        extendibleProvisionAdjustedDates = new ExtendibleProvisionAdjustedDates(item);
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
        private ExerciseNotice exerciseNotice;
        public ExerciseNotice ExerciseNotice
        {
            get
            {
                if (this.exerciseNotice != null)
                {
                    return this.exerciseNotice; 
                }
                else if (this.exerciseNoticeIDRef != null)
                {
                    exerciseNotice = IDManager.getID(exerciseNoticeIDRef) as ExerciseNotice;
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
        #region ExtendibleProvisionAdjustedDates
        private ExtendibleProvisionAdjustedDates extendibleProvisionAdjustedDates;
        public ExtendibleProvisionAdjustedDates ExtendibleProvisionAdjustedDates
        {
            get
            {
                if (this.extendibleProvisionAdjustedDates != null)
                {
                    return this.extendibleProvisionAdjustedDates; 
                }
                else if (this.extendibleProvisionAdjustedDatesIDRef != null)
                {
                    extendibleProvisionAdjustedDates = IDManager.getID(extendibleProvisionAdjustedDatesIDRef) as ExtendibleProvisionAdjustedDates;
                    return this.extendibleProvisionAdjustedDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.extendibleProvisionAdjustedDates != value)
                {
                    this.extendibleProvisionAdjustedDates = value;
                }
            }
        }
        #endregion
        
        public string ExtendibleProvisionAdjustedDatesIDRef { get; set; }
        
    
        
    
    }
    
}

