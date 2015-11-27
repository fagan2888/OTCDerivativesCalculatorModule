using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CreditEventNoticeDocument
    {
        public CreditEventNoticeDocument(XmlNode xmlNode)
        {
            XmlNodeList affectedTransactionsNodeList = xmlNode.SelectNodes("affectedTransactions");
            if (affectedTransactionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in affectedTransactionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        affectedTransactionsIDRef = item.Attributes["id"].Name;
                        AffectedTransactions ob = AffectedTransactions();
                        IDManager.SetID(affectedTransactionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        affectedTransactionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        affectedTransactions = new AffectedTransactions(item);
                    }
                }
            }
            
        
            XmlNodeList referenceEntityNodeList = xmlNode.SelectNodes("referenceEntity");
            if (referenceEntityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referenceEntityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceEntityIDRef = item.Attributes["id"].Name;
                        LegalEntity ob = LegalEntity();
                        IDManager.SetID(referenceEntityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceEntityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referenceEntity = new LegalEntity(item);
                    }
                }
            }
            
        
            XmlNodeList creditEventNodeList = xmlNode.SelectNodes("creditEvent");
            if (creditEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditEventIDRef = item.Attributes["id"].Name;
                        CreditEvent ob = CreditEvent();
                        IDManager.SetID(creditEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditEvent = new CreditEvent(item);
                    }
                }
            }
            
        
            XmlNodeList bankruptcyNodeList = xmlNode.SelectNodes("bankruptcy");
            if (bankruptcyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in bankruptcyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        bankruptcyIDRef = item.Attributes["id"].Name;
                        BankruptcyEvent ob = BankruptcyEvent();
                        IDManager.SetID(bankruptcyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        bankruptcyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        bankruptcy = new BankruptcyEvent(item);
                    }
                }
            }
            
        
            XmlNodeList failureToPayNodeList = xmlNode.SelectNodes("failureToPay");
            if (failureToPayNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in failureToPayNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        failureToPayIDRef = item.Attributes["id"].Name;
                        FailureToPayEvent ob = FailureToPayEvent();
                        IDManager.SetID(failureToPayIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        failureToPayIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        failureToPay = new FailureToPayEvent(item);
                    }
                }
            }
            
        
            XmlNodeList obligationAccelerationNodeList = xmlNode.SelectNodes("obligationAcceleration");
            if (obligationAccelerationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in obligationAccelerationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        obligationAccelerationIDRef = item.Attributes["id"].Name;
                        ObligationAccelerationEvent ob = ObligationAccelerationEvent();
                        IDManager.SetID(obligationAccelerationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        obligationAccelerationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        obligationAcceleration = new ObligationAccelerationEvent(item);
                    }
                }
            }
            
        
            XmlNodeList obligationDefaultNodeList = xmlNode.SelectNodes("obligationDefault");
            if (obligationDefaultNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in obligationDefaultNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        obligationDefaultIDRef = item.Attributes["id"].Name;
                        ObligationDefaultEvent ob = ObligationDefaultEvent();
                        IDManager.SetID(obligationDefaultIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        obligationDefaultIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        obligationDefault = new ObligationDefaultEvent(item);
                    }
                }
            }
            
        
            XmlNodeList repudiationMoratoriumNodeList = xmlNode.SelectNodes("repudiationMoratorium");
            if (repudiationMoratoriumNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in repudiationMoratoriumNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        repudiationMoratoriumIDRef = item.Attributes["id"].Name;
                        RepudiationMoratoriumEvent ob = RepudiationMoratoriumEvent();
                        IDManager.SetID(repudiationMoratoriumIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        repudiationMoratoriumIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        repudiationMoratorium = new RepudiationMoratoriumEvent(item);
                    }
                }
            }
            
        
            XmlNodeList restructuringNodeList = xmlNode.SelectNodes("restructuring");
            if (restructuringNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in restructuringNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        restructuringIDRef = item.Attributes["id"].Name;
                        RestructuringEvent ob = RestructuringEvent();
                        IDManager.SetID(restructuringIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        restructuringIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        restructuring = new RestructuringEvent(item);
                    }
                }
            }
            
        
            XmlNodeList publiclyAvailableInformationNodeList = xmlNode.SelectNodes("publiclyAvailableInformation");
            
            foreach (XmlNode item in publiclyAvailableInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        publiclyAvailableInformationIDRef = item.Attributes["id"].Name;
                        List<Resource> ob = new List<Resource>();
                        ob.Add(new Resource(item));
                        IDManager.SetID(publiclyAvailableInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        publiclyAvailableInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    publiclyAvailableInformation.Add(new Resource(item));
                    }
                }
            }
            
        
            XmlNodeList notifyingPartyReferenceNodeList = xmlNode.SelectNodes("notifyingPartyReference");
            if (notifyingPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notifyingPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notifyingPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(notifyingPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notifyingPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notifyingPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList notifiedPartyReferenceNodeList = xmlNode.SelectNodes("notifiedPartyReference");
            if (notifiedPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notifiedPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notifiedPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(notifiedPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notifiedPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notifiedPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList creditEventNoticeDateNodeList = xmlNode.SelectNodes("creditEventNoticeDate");
            if (creditEventNoticeDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditEventNoticeDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditEventNoticeDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(creditEventNoticeDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditEventNoticeDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditEventNoticeDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList creditEventDateNodeList = xmlNode.SelectNodes("creditEventDate");
            if (creditEventDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditEventDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditEventDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(creditEventDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditEventDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditEventDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region AffectedTransactions
        private AffectedTransactions affectedTransactions;
        public AffectedTransactions AffectedTransactions
        {
            get
            {
                if (this.affectedTransactions != null)
                {
                    return this.affectedTransactions; 
                }
                else if (this.affectedTransactionsIDRef != null)
                {
                    affectedTransactions = IDManager.getID(affectedTransactionsIDRef) as AffectedTransactions;
                    return this.affectedTransactions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.affectedTransactions != value)
                {
                    this.affectedTransactions = value;
                }
            }
        }
        #endregion
        
        public string AffectedTransactionsIDRef { get; set; }
        #region ReferenceEntity
        private LegalEntity referenceEntity;
        public LegalEntity ReferenceEntity
        {
            get
            {
                if (this.referenceEntity != null)
                {
                    return this.referenceEntity; 
                }
                else if (this.referenceEntityIDRef != null)
                {
                    referenceEntity = IDManager.getID(referenceEntityIDRef) as LegalEntity;
                    return this.referenceEntity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceEntity != value)
                {
                    this.referenceEntity = value;
                }
            }
        }
        #endregion
        
        public string LegalEntityIDRef { get; set; }
        #region CreditEvent
        private CreditEvent creditEvent;
        public CreditEvent CreditEvent
        {
            get
            {
                if (this.creditEvent != null)
                {
                    return this.creditEvent; 
                }
                else if (this.creditEventIDRef != null)
                {
                    creditEvent = IDManager.getID(creditEventIDRef) as CreditEvent;
                    return this.creditEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditEvent != value)
                {
                    this.creditEvent = value;
                }
            }
        }
        #endregion
        
        public string CreditEventIDRef { get; set; }
        #region Bankruptcy
        private BankruptcyEvent bankruptcy;
        public BankruptcyEvent Bankruptcy
        {
            get
            {
                if (this.bankruptcy != null)
                {
                    return this.bankruptcy; 
                }
                else if (this.bankruptcyIDRef != null)
                {
                    bankruptcy = IDManager.getID(bankruptcyIDRef) as BankruptcyEvent;
                    return this.bankruptcy; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.bankruptcy != value)
                {
                    this.bankruptcy = value;
                }
            }
        }
        #endregion
        
        public string BankruptcyEventIDRef { get; set; }     // substitude
        #region FailureToPay
        private FailureToPayEvent failureToPay;
        public FailureToPayEvent FailureToPay
        {
            get
            {
                if (this.failureToPay != null)
                {
                    return this.failureToPay; 
                }
                else if (this.failureToPayIDRef != null)
                {
                    failureToPay = IDManager.getID(failureToPayIDRef) as FailureToPayEvent;
                    return this.failureToPay; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.failureToPay != value)
                {
                    this.failureToPay = value;
                }
            }
        }
        #endregion
        
        public string FailureToPayEventIDRef { get; set; }     // substitude
        #region ObligationAcceleration
        private ObligationAccelerationEvent obligationAcceleration;
        public ObligationAccelerationEvent ObligationAcceleration
        {
            get
            {
                if (this.obligationAcceleration != null)
                {
                    return this.obligationAcceleration; 
                }
                else if (this.obligationAccelerationIDRef != null)
                {
                    obligationAcceleration = IDManager.getID(obligationAccelerationIDRef) as ObligationAccelerationEvent;
                    return this.obligationAcceleration; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.obligationAcceleration != value)
                {
                    this.obligationAcceleration = value;
                }
            }
        }
        #endregion
        
        public string ObligationAccelerationEventIDRef { get; set; }     // substitude
        #region ObligationDefault
        private ObligationDefaultEvent obligationDefault;
        public ObligationDefaultEvent ObligationDefault
        {
            get
            {
                if (this.obligationDefault != null)
                {
                    return this.obligationDefault; 
                }
                else if (this.obligationDefaultIDRef != null)
                {
                    obligationDefault = IDManager.getID(obligationDefaultIDRef) as ObligationDefaultEvent;
                    return this.obligationDefault; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.obligationDefault != value)
                {
                    this.obligationDefault = value;
                }
            }
        }
        #endregion
        
        public string ObligationDefaultEventIDRef { get; set; }     // substitude
        #region RepudiationMoratorium
        private RepudiationMoratoriumEvent repudiationMoratorium;
        public RepudiationMoratoriumEvent RepudiationMoratorium
        {
            get
            {
                if (this.repudiationMoratorium != null)
                {
                    return this.repudiationMoratorium; 
                }
                else if (this.repudiationMoratoriumIDRef != null)
                {
                    repudiationMoratorium = IDManager.getID(repudiationMoratoriumIDRef) as RepudiationMoratoriumEvent;
                    return this.repudiationMoratorium; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.repudiationMoratorium != value)
                {
                    this.repudiationMoratorium = value;
                }
            }
        }
        #endregion
        
        public string RepudiationMoratoriumEventIDRef { get; set; }     // substitude
        #region Restructuring
        private RestructuringEvent restructuring;
        public RestructuringEvent Restructuring
        {
            get
            {
                if (this.restructuring != null)
                {
                    return this.restructuring; 
                }
                else if (this.restructuringIDRef != null)
                {
                    restructuring = IDManager.getID(restructuringIDRef) as RestructuringEvent;
                    return this.restructuring; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.restructuring != value)
                {
                    this.restructuring = value;
                }
            }
        }
        #endregion
        
        public string RestructuringEventIDRef { get; set; }     // substitude
        #region PubliclyAvailableInformation
        private List<Resource> publiclyAvailableInformation;
        public List<Resource> PubliclyAvailableInformation
        {
            get
            {
                if (this.publiclyAvailableInformation != null)
                {
                    return this.publiclyAvailableInformation; 
                }
                else if (this.publiclyAvailableInformationIDRef != null)
                {
                    publiclyAvailableInformation = IDManager.getID(publiclyAvailableInformationIDRef) as List<Resource>;
                    return this.publiclyAvailableInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.publiclyAvailableInformation != value)
                {
                    this.publiclyAvailableInformation = value;
                }
            }
        }
        #endregion
        
        public string ResourceIDRef { get; set; }
        #region NotifyingPartyReference
        private PartyReference notifyingPartyReference;
        public PartyReference NotifyingPartyReference
        {
            get
            {
                if (this.notifyingPartyReference != null)
                {
                    return this.notifyingPartyReference; 
                }
                else if (this.notifyingPartyReferenceIDRef != null)
                {
                    notifyingPartyReference = IDManager.getID(notifyingPartyReferenceIDRef) as PartyReference;
                    return this.notifyingPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notifyingPartyReference != value)
                {
                    this.notifyingPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region NotifiedPartyReference
        private PartyReference notifiedPartyReference;
        public PartyReference NotifiedPartyReference
        {
            get
            {
                if (this.notifiedPartyReference != null)
                {
                    return this.notifiedPartyReference; 
                }
                else if (this.notifiedPartyReferenceIDRef != null)
                {
                    notifiedPartyReference = IDManager.getID(notifiedPartyReferenceIDRef) as PartyReference;
                    return this.notifiedPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notifiedPartyReference != value)
                {
                    this.notifiedPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region CreditEventNoticeDate
        private XsdTypeDate creditEventNoticeDate;
        public XsdTypeDate CreditEventNoticeDate
        {
            get
            {
                if (this.creditEventNoticeDate != null)
                {
                    return this.creditEventNoticeDate; 
                }
                else if (this.creditEventNoticeDateIDRef != null)
                {
                    creditEventNoticeDate = IDManager.getID(creditEventNoticeDateIDRef) as XsdTypeDate;
                    return this.creditEventNoticeDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditEventNoticeDate != value)
                {
                    this.creditEventNoticeDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region CreditEventDate
        private XsdTypeDate creditEventDate;
        public XsdTypeDate CreditEventDate
        {
            get
            {
                if (this.creditEventDate != null)
                {
                    return this.creditEventDate; 
                }
                else if (this.creditEventDateIDRef != null)
                {
                    creditEventDate = IDManager.getID(creditEventDateIDRef) as XsdTypeDate;
                    return this.creditEventDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditEventDate != value)
                {
                    this.creditEventDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        
    
        
    
    }
    
}

