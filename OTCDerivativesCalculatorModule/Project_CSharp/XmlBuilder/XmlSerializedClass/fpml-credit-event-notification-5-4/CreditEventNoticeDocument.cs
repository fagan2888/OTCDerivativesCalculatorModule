using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CreditEventNoticeDocument : ISerialized
    {
        public CreditEventNoticeDocument(XmlNode xmlNode)
        {
            XmlNode affectedTransactionsNode = xmlNode.SelectSingleNode("affectedTransactions");
            
            if (affectedTransactionsNode != null)
            {
                if (affectedTransactionsNode.Attributes["href"] != null || affectedTransactionsNode.Attributes["id"] != null) 
                {
                    if (affectedTransactionsNode.Attributes["id"] != null) 
                    {
                        affectedTransactionsIDRef_ = affectedTransactionsNode.Attributes["id"].Value;
                        AffectedTransactions ob = new AffectedTransactions(affectedTransactionsNode);
                        IDManager.SetID(affectedTransactionsIDRef_, ob);
                    }
                    else if (affectedTransactionsNode.Attributes["href"] != null)
                    {
                        affectedTransactionsIDRef_ = affectedTransactionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        affectedTransactions_ = new AffectedTransactions(affectedTransactionsNode);
                    }
                }
                else
                {
                    affectedTransactions_ = new AffectedTransactions(affectedTransactionsNode);
                }
            }
            
        
            XmlNode referenceEntityNode = xmlNode.SelectSingleNode("referenceEntity");
            
            if (referenceEntityNode != null)
            {
                if (referenceEntityNode.Attributes["href"] != null || referenceEntityNode.Attributes["id"] != null) 
                {
                    if (referenceEntityNode.Attributes["id"] != null) 
                    {
                        referenceEntityIDRef_ = referenceEntityNode.Attributes["id"].Value;
                        LegalEntity ob = new LegalEntity(referenceEntityNode);
                        IDManager.SetID(referenceEntityIDRef_, ob);
                    }
                    else if (referenceEntityNode.Attributes["href"] != null)
                    {
                        referenceEntityIDRef_ = referenceEntityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceEntity_ = new LegalEntity(referenceEntityNode);
                    }
                }
                else
                {
                    referenceEntity_ = new LegalEntity(referenceEntityNode);
                }
            }
            
        
            XmlNode creditEventNode = xmlNode.SelectSingleNode("creditEvent");
            
            if (creditEventNode != null)
            {
                if (creditEventNode.Attributes["href"] != null || creditEventNode.Attributes["id"] != null) 
                {
                    if (creditEventNode.Attributes["id"] != null) 
                    {
                        creditEventIDRef_ = creditEventNode.Attributes["id"].Value;
                        CreditEvent ob = new CreditEvent(creditEventNode);
                        IDManager.SetID(creditEventIDRef_, ob);
                    }
                    else if (creditEventNode.Attributes["href"] != null)
                    {
                        creditEventIDRef_ = creditEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditEvent_ = new CreditEvent(creditEventNode);
                    }
                }
                else
                {
                    creditEvent_ = new CreditEvent(creditEventNode);
                }
            }
            
        
            XmlNode bankruptcyNode = xmlNode.SelectSingleNode("bankruptcy");
            
            if (bankruptcyNode != null)
            {
                if (bankruptcyNode.Attributes["href"] != null || bankruptcyNode.Attributes["id"] != null) 
                {
                    if (bankruptcyNode.Attributes["id"] != null) 
                    {
                        bankruptcyIDRef_ = bankruptcyNode.Attributes["id"].Value;
                        BankruptcyEvent ob = new BankruptcyEvent(bankruptcyNode);
                        IDManager.SetID(bankruptcyIDRef_, ob);
                    }
                    else if (bankruptcyNode.Attributes["href"] != null)
                    {
                        bankruptcyIDRef_ = bankruptcyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        bankruptcy_ = new BankruptcyEvent(bankruptcyNode);
                    }
                }
                else
                {
                    bankruptcy_ = new BankruptcyEvent(bankruptcyNode);
                }
            }
            
        
            XmlNode failureToPayNode = xmlNode.SelectSingleNode("failureToPay");
            
            if (failureToPayNode != null)
            {
                if (failureToPayNode.Attributes["href"] != null || failureToPayNode.Attributes["id"] != null) 
                {
                    if (failureToPayNode.Attributes["id"] != null) 
                    {
                        failureToPayIDRef_ = failureToPayNode.Attributes["id"].Value;
                        FailureToPayEvent ob = new FailureToPayEvent(failureToPayNode);
                        IDManager.SetID(failureToPayIDRef_, ob);
                    }
                    else if (failureToPayNode.Attributes["href"] != null)
                    {
                        failureToPayIDRef_ = failureToPayNode.Attributes["href"].Value;
                    }
                    else
                    {
                        failureToPay_ = new FailureToPayEvent(failureToPayNode);
                    }
                }
                else
                {
                    failureToPay_ = new FailureToPayEvent(failureToPayNode);
                }
            }
            
        
            XmlNode obligationAccelerationNode = xmlNode.SelectSingleNode("obligationAcceleration");
            
            if (obligationAccelerationNode != null)
            {
                if (obligationAccelerationNode.Attributes["href"] != null || obligationAccelerationNode.Attributes["id"] != null) 
                {
                    if (obligationAccelerationNode.Attributes["id"] != null) 
                    {
                        obligationAccelerationIDRef_ = obligationAccelerationNode.Attributes["id"].Value;
                        ObligationAccelerationEvent ob = new ObligationAccelerationEvent(obligationAccelerationNode);
                        IDManager.SetID(obligationAccelerationIDRef_, ob);
                    }
                    else if (obligationAccelerationNode.Attributes["href"] != null)
                    {
                        obligationAccelerationIDRef_ = obligationAccelerationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        obligationAcceleration_ = new ObligationAccelerationEvent(obligationAccelerationNode);
                    }
                }
                else
                {
                    obligationAcceleration_ = new ObligationAccelerationEvent(obligationAccelerationNode);
                }
            }
            
        
            XmlNode obligationDefaultNode = xmlNode.SelectSingleNode("obligationDefault");
            
            if (obligationDefaultNode != null)
            {
                if (obligationDefaultNode.Attributes["href"] != null || obligationDefaultNode.Attributes["id"] != null) 
                {
                    if (obligationDefaultNode.Attributes["id"] != null) 
                    {
                        obligationDefaultIDRef_ = obligationDefaultNode.Attributes["id"].Value;
                        ObligationDefaultEvent ob = new ObligationDefaultEvent(obligationDefaultNode);
                        IDManager.SetID(obligationDefaultIDRef_, ob);
                    }
                    else if (obligationDefaultNode.Attributes["href"] != null)
                    {
                        obligationDefaultIDRef_ = obligationDefaultNode.Attributes["href"].Value;
                    }
                    else
                    {
                        obligationDefault_ = new ObligationDefaultEvent(obligationDefaultNode);
                    }
                }
                else
                {
                    obligationDefault_ = new ObligationDefaultEvent(obligationDefaultNode);
                }
            }
            
        
            XmlNode repudiationMoratoriumNode = xmlNode.SelectSingleNode("repudiationMoratorium");
            
            if (repudiationMoratoriumNode != null)
            {
                if (repudiationMoratoriumNode.Attributes["href"] != null || repudiationMoratoriumNode.Attributes["id"] != null) 
                {
                    if (repudiationMoratoriumNode.Attributes["id"] != null) 
                    {
                        repudiationMoratoriumIDRef_ = repudiationMoratoriumNode.Attributes["id"].Value;
                        RepudiationMoratoriumEvent ob = new RepudiationMoratoriumEvent(repudiationMoratoriumNode);
                        IDManager.SetID(repudiationMoratoriumIDRef_, ob);
                    }
                    else if (repudiationMoratoriumNode.Attributes["href"] != null)
                    {
                        repudiationMoratoriumIDRef_ = repudiationMoratoriumNode.Attributes["href"].Value;
                    }
                    else
                    {
                        repudiationMoratorium_ = new RepudiationMoratoriumEvent(repudiationMoratoriumNode);
                    }
                }
                else
                {
                    repudiationMoratorium_ = new RepudiationMoratoriumEvent(repudiationMoratoriumNode);
                }
            }
            
        
            XmlNode restructuringNode = xmlNode.SelectSingleNode("restructuring");
            
            if (restructuringNode != null)
            {
                if (restructuringNode.Attributes["href"] != null || restructuringNode.Attributes["id"] != null) 
                {
                    if (restructuringNode.Attributes["id"] != null) 
                    {
                        restructuringIDRef_ = restructuringNode.Attributes["id"].Value;
                        RestructuringEvent ob = new RestructuringEvent(restructuringNode);
                        IDManager.SetID(restructuringIDRef_, ob);
                    }
                    else if (restructuringNode.Attributes["href"] != null)
                    {
                        restructuringIDRef_ = restructuringNode.Attributes["href"].Value;
                    }
                    else
                    {
                        restructuring_ = new RestructuringEvent(restructuringNode);
                    }
                }
                else
                {
                    restructuring_ = new RestructuringEvent(restructuringNode);
                }
            }
            
        
            XmlNodeList publiclyAvailableInformationNodeList = xmlNode.SelectNodes("publiclyAvailableInformation");
            
            if (publiclyAvailableInformationNodeList != null)
            {
                this.publiclyAvailableInformation_ = new List<Resource>();
                foreach (XmlNode item in publiclyAvailableInformationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            publiclyAvailableInformationIDRef_ = item.Attributes["id"].Value;
                            publiclyAvailableInformation_.Add(new Resource(item));
                            IDManager.SetID(publiclyAvailableInformationIDRef_, publiclyAvailableInformation_[publiclyAvailableInformation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            publiclyAvailableInformationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        publiclyAvailableInformation_.Add(new Resource(item));
                        }
                    }
                    else
                    {
                        publiclyAvailableInformation_.Add(new Resource(item));
                    }
                }
            }
            
        
            XmlNode notifyingPartyReferenceNode = xmlNode.SelectSingleNode("notifyingPartyReference");
            
            if (notifyingPartyReferenceNode != null)
            {
                if (notifyingPartyReferenceNode.Attributes["href"] != null || notifyingPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (notifyingPartyReferenceNode.Attributes["id"] != null) 
                    {
                        notifyingPartyReferenceIDRef_ = notifyingPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(notifyingPartyReferenceNode);
                        IDManager.SetID(notifyingPartyReferenceIDRef_, ob);
                    }
                    else if (notifyingPartyReferenceNode.Attributes["href"] != null)
                    {
                        notifyingPartyReferenceIDRef_ = notifyingPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notifyingPartyReference_ = new PartyReference(notifyingPartyReferenceNode);
                    }
                }
                else
                {
                    notifyingPartyReference_ = new PartyReference(notifyingPartyReferenceNode);
                }
            }
            
        
            XmlNode notifiedPartyReferenceNode = xmlNode.SelectSingleNode("notifiedPartyReference");
            
            if (notifiedPartyReferenceNode != null)
            {
                if (notifiedPartyReferenceNode.Attributes["href"] != null || notifiedPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (notifiedPartyReferenceNode.Attributes["id"] != null) 
                    {
                        notifiedPartyReferenceIDRef_ = notifiedPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(notifiedPartyReferenceNode);
                        IDManager.SetID(notifiedPartyReferenceIDRef_, ob);
                    }
                    else if (notifiedPartyReferenceNode.Attributes["href"] != null)
                    {
                        notifiedPartyReferenceIDRef_ = notifiedPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notifiedPartyReference_ = new PartyReference(notifiedPartyReferenceNode);
                    }
                }
                else
                {
                    notifiedPartyReference_ = new PartyReference(notifiedPartyReferenceNode);
                }
            }
            
        
            XmlNode creditEventNoticeDateNode = xmlNode.SelectSingleNode("creditEventNoticeDate");
            
            if (creditEventNoticeDateNode != null)
            {
                if (creditEventNoticeDateNode.Attributes["href"] != null || creditEventNoticeDateNode.Attributes["id"] != null) 
                {
                    if (creditEventNoticeDateNode.Attributes["id"] != null) 
                    {
                        creditEventNoticeDateIDRef_ = creditEventNoticeDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(creditEventNoticeDateNode);
                        IDManager.SetID(creditEventNoticeDateIDRef_, ob);
                    }
                    else if (creditEventNoticeDateNode.Attributes["href"] != null)
                    {
                        creditEventNoticeDateIDRef_ = creditEventNoticeDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditEventNoticeDate_ = new XsdTypeDate(creditEventNoticeDateNode);
                    }
                }
                else
                {
                    creditEventNoticeDate_ = new XsdTypeDate(creditEventNoticeDateNode);
                }
            }
            
        
            XmlNode creditEventDateNode = xmlNode.SelectSingleNode("creditEventDate");
            
            if (creditEventDateNode != null)
            {
                if (creditEventDateNode.Attributes["href"] != null || creditEventDateNode.Attributes["id"] != null) 
                {
                    if (creditEventDateNode.Attributes["id"] != null) 
                    {
                        creditEventDateIDRef_ = creditEventDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(creditEventDateNode);
                        IDManager.SetID(creditEventDateIDRef_, ob);
                    }
                    else if (creditEventDateNode.Attributes["href"] != null)
                    {
                        creditEventDateIDRef_ = creditEventDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditEventDate_ = new XsdTypeDate(creditEventDateNode);
                    }
                }
                else
                {
                    creditEventDate_ = new XsdTypeDate(creditEventDateNode);
                }
            }
            
        
        }
        
    
        #region AffectedTransactions_
        private AffectedTransactions affectedTransactions_;
        public AffectedTransactions AffectedTransactions_
        {
            get
            {
                if (this.affectedTransactions_ != null)
                {
                    return this.affectedTransactions_; 
                }
                else if (this.affectedTransactionsIDRef_ != null)
                {
                    affectedTransactions_ = IDManager.getID(affectedTransactionsIDRef_) as AffectedTransactions;
                    return this.affectedTransactions_; 
                }
                else
                {
                      return this.affectedTransactions_; 
                }
            }
            set
            {
                if (this.affectedTransactions_ != value)
                {
                    this.affectedTransactions_ = value;
                }
            }
        }
        #endregion
        
        public string affectedTransactionsIDRef_ { get; set; }
        #region ReferenceEntity_
        private LegalEntity referenceEntity_;
        public LegalEntity ReferenceEntity_
        {
            get
            {
                if (this.referenceEntity_ != null)
                {
                    return this.referenceEntity_; 
                }
                else if (this.referenceEntityIDRef_ != null)
                {
                    referenceEntity_ = IDManager.getID(referenceEntityIDRef_) as LegalEntity;
                    return this.referenceEntity_; 
                }
                else
                {
                      return this.referenceEntity_; 
                }
            }
            set
            {
                if (this.referenceEntity_ != value)
                {
                    this.referenceEntity_ = value;
                }
            }
        }
        #endregion
        
        public string referenceEntityIDRef_ { get; set; }
        #region CreditEvent_
        private CreditEvent creditEvent_;
        public CreditEvent CreditEvent_
        {
            get
            {
                if (this.creditEvent_ != null)
                {
                    return this.creditEvent_; 
                }
                else if (this.creditEventIDRef_ != null)
                {
                    creditEvent_ = IDManager.getID(creditEventIDRef_) as CreditEvent;
                    return this.creditEvent_; 
                }
                else
                {
                      return this.creditEvent_; 
                }
            }
            set
            {
                if (this.creditEvent_ != value)
                {
                    this.creditEvent_ = value;
                }
            }
        }
        #endregion
        
        public string creditEventIDRef_ { get; set; }
        #region Bankruptcy_
        private BankruptcyEvent bankruptcy_;
        public BankruptcyEvent Bankruptcy_
        {
            get
            {
                if (this.bankruptcy_ != null)
                {
                    return this.bankruptcy_; 
                }
                else if (this.bankruptcyIDRef_ != null)
                {
                    bankruptcy_ = IDManager.getID(bankruptcyIDRef_) as BankruptcyEvent;
                    return this.bankruptcy_; 
                }
                else
                {
                      return this.bankruptcy_; 
                }
            }
            set
            {
                if (this.bankruptcy_ != value)
                {
                    this.bankruptcy_ = value;
                }
            }
        }
        #endregion
        
        public string bankruptcyIDRef_ { get; set; }     // substitude
        #region FailureToPay_
        private FailureToPayEvent failureToPay_;
        public FailureToPayEvent FailureToPay_
        {
            get
            {
                if (this.failureToPay_ != null)
                {
                    return this.failureToPay_; 
                }
                else if (this.failureToPayIDRef_ != null)
                {
                    failureToPay_ = IDManager.getID(failureToPayIDRef_) as FailureToPayEvent;
                    return this.failureToPay_; 
                }
                else
                {
                      return this.failureToPay_; 
                }
            }
            set
            {
                if (this.failureToPay_ != value)
                {
                    this.failureToPay_ = value;
                }
            }
        }
        #endregion
        
        public string failureToPayIDRef_ { get; set; }     // substitude
        #region ObligationAcceleration_
        private ObligationAccelerationEvent obligationAcceleration_;
        public ObligationAccelerationEvent ObligationAcceleration_
        {
            get
            {
                if (this.obligationAcceleration_ != null)
                {
                    return this.obligationAcceleration_; 
                }
                else if (this.obligationAccelerationIDRef_ != null)
                {
                    obligationAcceleration_ = IDManager.getID(obligationAccelerationIDRef_) as ObligationAccelerationEvent;
                    return this.obligationAcceleration_; 
                }
                else
                {
                      return this.obligationAcceleration_; 
                }
            }
            set
            {
                if (this.obligationAcceleration_ != value)
                {
                    this.obligationAcceleration_ = value;
                }
            }
        }
        #endregion
        
        public string obligationAccelerationIDRef_ { get; set; }     // substitude
        #region ObligationDefault_
        private ObligationDefaultEvent obligationDefault_;
        public ObligationDefaultEvent ObligationDefault_
        {
            get
            {
                if (this.obligationDefault_ != null)
                {
                    return this.obligationDefault_; 
                }
                else if (this.obligationDefaultIDRef_ != null)
                {
                    obligationDefault_ = IDManager.getID(obligationDefaultIDRef_) as ObligationDefaultEvent;
                    return this.obligationDefault_; 
                }
                else
                {
                      return this.obligationDefault_; 
                }
            }
            set
            {
                if (this.obligationDefault_ != value)
                {
                    this.obligationDefault_ = value;
                }
            }
        }
        #endregion
        
        public string obligationDefaultIDRef_ { get; set; }     // substitude
        #region RepudiationMoratorium_
        private RepudiationMoratoriumEvent repudiationMoratorium_;
        public RepudiationMoratoriumEvent RepudiationMoratorium_
        {
            get
            {
                if (this.repudiationMoratorium_ != null)
                {
                    return this.repudiationMoratorium_; 
                }
                else if (this.repudiationMoratoriumIDRef_ != null)
                {
                    repudiationMoratorium_ = IDManager.getID(repudiationMoratoriumIDRef_) as RepudiationMoratoriumEvent;
                    return this.repudiationMoratorium_; 
                }
                else
                {
                      return this.repudiationMoratorium_; 
                }
            }
            set
            {
                if (this.repudiationMoratorium_ != value)
                {
                    this.repudiationMoratorium_ = value;
                }
            }
        }
        #endregion
        
        public string repudiationMoratoriumIDRef_ { get; set; }     // substitude
        #region Restructuring_
        private RestructuringEvent restructuring_;
        public RestructuringEvent Restructuring_
        {
            get
            {
                if (this.restructuring_ != null)
                {
                    return this.restructuring_; 
                }
                else if (this.restructuringIDRef_ != null)
                {
                    restructuring_ = IDManager.getID(restructuringIDRef_) as RestructuringEvent;
                    return this.restructuring_; 
                }
                else
                {
                      return this.restructuring_; 
                }
            }
            set
            {
                if (this.restructuring_ != value)
                {
                    this.restructuring_ = value;
                }
            }
        }
        #endregion
        
        public string restructuringIDRef_ { get; set; }     // substitude
        #region PubliclyAvailableInformation_
        private List<Resource> publiclyAvailableInformation_;
        public List<Resource> PubliclyAvailableInformation_
        {
            get
            {
                if (this.publiclyAvailableInformation_ != null)
                {
                    return this.publiclyAvailableInformation_; 
                }
                else if (this.publiclyAvailableInformationIDRef_ != null)
                {
                    return this.publiclyAvailableInformation_; 
                }
                else
                {
                      return this.publiclyAvailableInformation_; 
                }
            }
            set
            {
                if (this.publiclyAvailableInformation_ != value)
                {
                    this.publiclyAvailableInformation_ = value;
                }
            }
        }
        #endregion
        
        public string publiclyAvailableInformationIDRef_ { get; set; }
        #region NotifyingPartyReference_
        private PartyReference notifyingPartyReference_;
        public PartyReference NotifyingPartyReference_
        {
            get
            {
                if (this.notifyingPartyReference_ != null)
                {
                    return this.notifyingPartyReference_; 
                }
                else if (this.notifyingPartyReferenceIDRef_ != null)
                {
                    notifyingPartyReference_ = IDManager.getID(notifyingPartyReferenceIDRef_) as PartyReference;
                    return this.notifyingPartyReference_; 
                }
                else
                {
                      return this.notifyingPartyReference_; 
                }
            }
            set
            {
                if (this.notifyingPartyReference_ != value)
                {
                    this.notifyingPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string notifyingPartyReferenceIDRef_ { get; set; }
        #region NotifiedPartyReference_
        private PartyReference notifiedPartyReference_;
        public PartyReference NotifiedPartyReference_
        {
            get
            {
                if (this.notifiedPartyReference_ != null)
                {
                    return this.notifiedPartyReference_; 
                }
                else if (this.notifiedPartyReferenceIDRef_ != null)
                {
                    notifiedPartyReference_ = IDManager.getID(notifiedPartyReferenceIDRef_) as PartyReference;
                    return this.notifiedPartyReference_; 
                }
                else
                {
                      return this.notifiedPartyReference_; 
                }
            }
            set
            {
                if (this.notifiedPartyReference_ != value)
                {
                    this.notifiedPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string notifiedPartyReferenceIDRef_ { get; set; }
        #region CreditEventNoticeDate_
        private XsdTypeDate creditEventNoticeDate_;
        public XsdTypeDate CreditEventNoticeDate_
        {
            get
            {
                if (this.creditEventNoticeDate_ != null)
                {
                    return this.creditEventNoticeDate_; 
                }
                else if (this.creditEventNoticeDateIDRef_ != null)
                {
                    creditEventNoticeDate_ = IDManager.getID(creditEventNoticeDateIDRef_) as XsdTypeDate;
                    return this.creditEventNoticeDate_; 
                }
                else
                {
                      return this.creditEventNoticeDate_; 
                }
            }
            set
            {
                if (this.creditEventNoticeDate_ != value)
                {
                    this.creditEventNoticeDate_ = value;
                }
            }
        }
        #endregion
        
        public string creditEventNoticeDateIDRef_ { get; set; }
        #region CreditEventDate_
        private XsdTypeDate creditEventDate_;
        public XsdTypeDate CreditEventDate_
        {
            get
            {
                if (this.creditEventDate_ != null)
                {
                    return this.creditEventDate_; 
                }
                else if (this.creditEventDateIDRef_ != null)
                {
                    creditEventDate_ = IDManager.getID(creditEventDateIDRef_) as XsdTypeDate;
                    return this.creditEventDate_; 
                }
                else
                {
                      return this.creditEventDate_; 
                }
            }
            set
            {
                if (this.creditEventDate_ != value)
                {
                    this.creditEventDate_ = value;
                }
            }
        }
        #endregion
        
        public string creditEventDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

