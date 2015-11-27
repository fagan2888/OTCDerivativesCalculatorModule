using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CreditEvents : ISerialized
    {
        public CreditEvents(XmlNode xmlNode)
        {
            XmlNode bankruptcyNode = xmlNode.SelectSingleNode("bankruptcy");
            
            if (bankruptcyNode != null)
            {
                if (bankruptcyNode.Attributes["href"] != null || bankruptcyNode.Attributes["id"] != null) 
                {
                    if (bankruptcyNode.Attributes["id"] != null) 
                    {
                        bankruptcyIDRef_ = bankruptcyNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(bankruptcyNode);
                        IDManager.SetID(bankruptcyIDRef_, ob);
                    }
                    else if (bankruptcyNode.Attributes["href"] != null)
                    {
                        bankruptcyIDRef_ = bankruptcyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        bankruptcy_ = new XsdTypeBoolean(bankruptcyNode);
                    }
                }
                else
                {
                    bankruptcy_ = new XsdTypeBoolean(bankruptcyNode);
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
                        FailureToPay ob = new FailureToPay(failureToPayNode);
                        IDManager.SetID(failureToPayIDRef_, ob);
                    }
                    else if (failureToPayNode.Attributes["href"] != null)
                    {
                        failureToPayIDRef_ = failureToPayNode.Attributes["href"].Value;
                    }
                    else
                    {
                        failureToPay_ = new FailureToPay(failureToPayNode);
                    }
                }
                else
                {
                    failureToPay_ = new FailureToPay(failureToPayNode);
                }
            }
            
        
            XmlNode failureToPayPrincipalNode = xmlNode.SelectSingleNode("failureToPayPrincipal");
            
            if (failureToPayPrincipalNode != null)
            {
                if (failureToPayPrincipalNode.Attributes["href"] != null || failureToPayPrincipalNode.Attributes["id"] != null) 
                {
                    if (failureToPayPrincipalNode.Attributes["id"] != null) 
                    {
                        failureToPayPrincipalIDRef_ = failureToPayPrincipalNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(failureToPayPrincipalNode);
                        IDManager.SetID(failureToPayPrincipalIDRef_, ob);
                    }
                    else if (failureToPayPrincipalNode.Attributes["href"] != null)
                    {
                        failureToPayPrincipalIDRef_ = failureToPayPrincipalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        failureToPayPrincipal_ = new XsdTypeBoolean(failureToPayPrincipalNode);
                    }
                }
                else
                {
                    failureToPayPrincipal_ = new XsdTypeBoolean(failureToPayPrincipalNode);
                }
            }
            
        
            XmlNode failureToPayInterestNode = xmlNode.SelectSingleNode("failureToPayInterest");
            
            if (failureToPayInterestNode != null)
            {
                if (failureToPayInterestNode.Attributes["href"] != null || failureToPayInterestNode.Attributes["id"] != null) 
                {
                    if (failureToPayInterestNode.Attributes["id"] != null) 
                    {
                        failureToPayInterestIDRef_ = failureToPayInterestNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(failureToPayInterestNode);
                        IDManager.SetID(failureToPayInterestIDRef_, ob);
                    }
                    else if (failureToPayInterestNode.Attributes["href"] != null)
                    {
                        failureToPayInterestIDRef_ = failureToPayInterestNode.Attributes["href"].Value;
                    }
                    else
                    {
                        failureToPayInterest_ = new XsdTypeBoolean(failureToPayInterestNode);
                    }
                }
                else
                {
                    failureToPayInterest_ = new XsdTypeBoolean(failureToPayInterestNode);
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
                        XsdTypeBoolean ob = new XsdTypeBoolean(obligationDefaultNode);
                        IDManager.SetID(obligationDefaultIDRef_, ob);
                    }
                    else if (obligationDefaultNode.Attributes["href"] != null)
                    {
                        obligationDefaultIDRef_ = obligationDefaultNode.Attributes["href"].Value;
                    }
                    else
                    {
                        obligationDefault_ = new XsdTypeBoolean(obligationDefaultNode);
                    }
                }
                else
                {
                    obligationDefault_ = new XsdTypeBoolean(obligationDefaultNode);
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
                        XsdTypeBoolean ob = new XsdTypeBoolean(obligationAccelerationNode);
                        IDManager.SetID(obligationAccelerationIDRef_, ob);
                    }
                    else if (obligationAccelerationNode.Attributes["href"] != null)
                    {
                        obligationAccelerationIDRef_ = obligationAccelerationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        obligationAcceleration_ = new XsdTypeBoolean(obligationAccelerationNode);
                    }
                }
                else
                {
                    obligationAcceleration_ = new XsdTypeBoolean(obligationAccelerationNode);
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
                        XsdTypeBoolean ob = new XsdTypeBoolean(repudiationMoratoriumNode);
                        IDManager.SetID(repudiationMoratoriumIDRef_, ob);
                    }
                    else if (repudiationMoratoriumNode.Attributes["href"] != null)
                    {
                        repudiationMoratoriumIDRef_ = repudiationMoratoriumNode.Attributes["href"].Value;
                    }
                    else
                    {
                        repudiationMoratorium_ = new XsdTypeBoolean(repudiationMoratoriumNode);
                    }
                }
                else
                {
                    repudiationMoratorium_ = new XsdTypeBoolean(repudiationMoratoriumNode);
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
                        Restructuring ob = new Restructuring(restructuringNode);
                        IDManager.SetID(restructuringIDRef_, ob);
                    }
                    else if (restructuringNode.Attributes["href"] != null)
                    {
                        restructuringIDRef_ = restructuringNode.Attributes["href"].Value;
                    }
                    else
                    {
                        restructuring_ = new Restructuring(restructuringNode);
                    }
                }
                else
                {
                    restructuring_ = new Restructuring(restructuringNode);
                }
            }
            
        
            XmlNode distressedRatingsDowngradeNode = xmlNode.SelectSingleNode("distressedRatingsDowngrade");
            
            if (distressedRatingsDowngradeNode != null)
            {
                if (distressedRatingsDowngradeNode.Attributes["href"] != null || distressedRatingsDowngradeNode.Attributes["id"] != null) 
                {
                    if (distressedRatingsDowngradeNode.Attributes["id"] != null) 
                    {
                        distressedRatingsDowngradeIDRef_ = distressedRatingsDowngradeNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(distressedRatingsDowngradeNode);
                        IDManager.SetID(distressedRatingsDowngradeIDRef_, ob);
                    }
                    else if (distressedRatingsDowngradeNode.Attributes["href"] != null)
                    {
                        distressedRatingsDowngradeIDRef_ = distressedRatingsDowngradeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        distressedRatingsDowngrade_ = new XsdTypeBoolean(distressedRatingsDowngradeNode);
                    }
                }
                else
                {
                    distressedRatingsDowngrade_ = new XsdTypeBoolean(distressedRatingsDowngradeNode);
                }
            }
            
        
            XmlNode maturityExtensionNode = xmlNode.SelectSingleNode("maturityExtension");
            
            if (maturityExtensionNode != null)
            {
                if (maturityExtensionNode.Attributes["href"] != null || maturityExtensionNode.Attributes["id"] != null) 
                {
                    if (maturityExtensionNode.Attributes["id"] != null) 
                    {
                        maturityExtensionIDRef_ = maturityExtensionNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(maturityExtensionNode);
                        IDManager.SetID(maturityExtensionIDRef_, ob);
                    }
                    else if (maturityExtensionNode.Attributes["href"] != null)
                    {
                        maturityExtensionIDRef_ = maturityExtensionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maturityExtension_ = new XsdTypeBoolean(maturityExtensionNode);
                    }
                }
                else
                {
                    maturityExtension_ = new XsdTypeBoolean(maturityExtensionNode);
                }
            }
            
        
            XmlNode writedownNode = xmlNode.SelectSingleNode("writedown");
            
            if (writedownNode != null)
            {
                if (writedownNode.Attributes["href"] != null || writedownNode.Attributes["id"] != null) 
                {
                    if (writedownNode.Attributes["id"] != null) 
                    {
                        writedownIDRef_ = writedownNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(writedownNode);
                        IDManager.SetID(writedownIDRef_, ob);
                    }
                    else if (writedownNode.Attributes["href"] != null)
                    {
                        writedownIDRef_ = writedownNode.Attributes["href"].Value;
                    }
                    else
                    {
                        writedown_ = new XsdTypeBoolean(writedownNode);
                    }
                }
                else
                {
                    writedown_ = new XsdTypeBoolean(writedownNode);
                }
            }
            
        
            XmlNode impliedWritedownNode = xmlNode.SelectSingleNode("impliedWritedown");
            
            if (impliedWritedownNode != null)
            {
                if (impliedWritedownNode.Attributes["href"] != null || impliedWritedownNode.Attributes["id"] != null) 
                {
                    if (impliedWritedownNode.Attributes["id"] != null) 
                    {
                        impliedWritedownIDRef_ = impliedWritedownNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(impliedWritedownNode);
                        IDManager.SetID(impliedWritedownIDRef_, ob);
                    }
                    else if (impliedWritedownNode.Attributes["href"] != null)
                    {
                        impliedWritedownIDRef_ = impliedWritedownNode.Attributes["href"].Value;
                    }
                    else
                    {
                        impliedWritedown_ = new XsdTypeBoolean(impliedWritedownNode);
                    }
                }
                else
                {
                    impliedWritedown_ = new XsdTypeBoolean(impliedWritedownNode);
                }
            }
            
        
            XmlNode defaultRequirementNode = xmlNode.SelectSingleNode("defaultRequirement");
            
            if (defaultRequirementNode != null)
            {
                if (defaultRequirementNode.Attributes["href"] != null || defaultRequirementNode.Attributes["id"] != null) 
                {
                    if (defaultRequirementNode.Attributes["id"] != null) 
                    {
                        defaultRequirementIDRef_ = defaultRequirementNode.Attributes["id"].Value;
                        Money ob = new Money(defaultRequirementNode);
                        IDManager.SetID(defaultRequirementIDRef_, ob);
                    }
                    else if (defaultRequirementNode.Attributes["href"] != null)
                    {
                        defaultRequirementIDRef_ = defaultRequirementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        defaultRequirement_ = new Money(defaultRequirementNode);
                    }
                }
                else
                {
                    defaultRequirement_ = new Money(defaultRequirementNode);
                }
            }
            
        
            XmlNode creditEventNoticeNode = xmlNode.SelectSingleNode("creditEventNotice");
            
            if (creditEventNoticeNode != null)
            {
                if (creditEventNoticeNode.Attributes["href"] != null || creditEventNoticeNode.Attributes["id"] != null) 
                {
                    if (creditEventNoticeNode.Attributes["id"] != null) 
                    {
                        creditEventNoticeIDRef_ = creditEventNoticeNode.Attributes["id"].Value;
                        CreditEventNotice ob = new CreditEventNotice(creditEventNoticeNode);
                        IDManager.SetID(creditEventNoticeIDRef_, ob);
                    }
                    else if (creditEventNoticeNode.Attributes["href"] != null)
                    {
                        creditEventNoticeIDRef_ = creditEventNoticeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditEventNotice_ = new CreditEventNotice(creditEventNoticeNode);
                    }
                }
                else
                {
                    creditEventNotice_ = new CreditEventNotice(creditEventNoticeNode);
                }
            }
            
        
        }
        
    
        #region Bankruptcy_
        private XsdTypeBoolean bankruptcy_;
        public XsdTypeBoolean Bankruptcy_
        {
            get
            {
                if (this.bankruptcy_ != null)
                {
                    return this.bankruptcy_; 
                }
                else if (this.bankruptcyIDRef_ != null)
                {
                    bankruptcy_ = IDManager.getID(bankruptcyIDRef_) as XsdTypeBoolean;
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
        
        public string bankruptcyIDRef_ { get; set; }
        #region FailureToPay_
        private FailureToPay failureToPay_;
        public FailureToPay FailureToPay_
        {
            get
            {
                if (this.failureToPay_ != null)
                {
                    return this.failureToPay_; 
                }
                else if (this.failureToPayIDRef_ != null)
                {
                    failureToPay_ = IDManager.getID(failureToPayIDRef_) as FailureToPay;
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
        
        public string failureToPayIDRef_ { get; set; }
        #region FailureToPayPrincipal_
        private XsdTypeBoolean failureToPayPrincipal_;
        public XsdTypeBoolean FailureToPayPrincipal_
        {
            get
            {
                if (this.failureToPayPrincipal_ != null)
                {
                    return this.failureToPayPrincipal_; 
                }
                else if (this.failureToPayPrincipalIDRef_ != null)
                {
                    failureToPayPrincipal_ = IDManager.getID(failureToPayPrincipalIDRef_) as XsdTypeBoolean;
                    return this.failureToPayPrincipal_; 
                }
                else
                {
                      return this.failureToPayPrincipal_; 
                }
            }
            set
            {
                if (this.failureToPayPrincipal_ != value)
                {
                    this.failureToPayPrincipal_ = value;
                }
            }
        }
        #endregion
        
        public string failureToPayPrincipalIDRef_ { get; set; }
        #region FailureToPayInterest_
        private XsdTypeBoolean failureToPayInterest_;
        public XsdTypeBoolean FailureToPayInterest_
        {
            get
            {
                if (this.failureToPayInterest_ != null)
                {
                    return this.failureToPayInterest_; 
                }
                else if (this.failureToPayInterestIDRef_ != null)
                {
                    failureToPayInterest_ = IDManager.getID(failureToPayInterestIDRef_) as XsdTypeBoolean;
                    return this.failureToPayInterest_; 
                }
                else
                {
                      return this.failureToPayInterest_; 
                }
            }
            set
            {
                if (this.failureToPayInterest_ != value)
                {
                    this.failureToPayInterest_ = value;
                }
            }
        }
        #endregion
        
        public string failureToPayInterestIDRef_ { get; set; }
        #region ObligationDefault_
        private XsdTypeBoolean obligationDefault_;
        public XsdTypeBoolean ObligationDefault_
        {
            get
            {
                if (this.obligationDefault_ != null)
                {
                    return this.obligationDefault_; 
                }
                else if (this.obligationDefaultIDRef_ != null)
                {
                    obligationDefault_ = IDManager.getID(obligationDefaultIDRef_) as XsdTypeBoolean;
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
        
        public string obligationDefaultIDRef_ { get; set; }
        #region ObligationAcceleration_
        private XsdTypeBoolean obligationAcceleration_;
        public XsdTypeBoolean ObligationAcceleration_
        {
            get
            {
                if (this.obligationAcceleration_ != null)
                {
                    return this.obligationAcceleration_; 
                }
                else if (this.obligationAccelerationIDRef_ != null)
                {
                    obligationAcceleration_ = IDManager.getID(obligationAccelerationIDRef_) as XsdTypeBoolean;
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
        
        public string obligationAccelerationIDRef_ { get; set; }
        #region RepudiationMoratorium_
        private XsdTypeBoolean repudiationMoratorium_;
        public XsdTypeBoolean RepudiationMoratorium_
        {
            get
            {
                if (this.repudiationMoratorium_ != null)
                {
                    return this.repudiationMoratorium_; 
                }
                else if (this.repudiationMoratoriumIDRef_ != null)
                {
                    repudiationMoratorium_ = IDManager.getID(repudiationMoratoriumIDRef_) as XsdTypeBoolean;
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
        
        public string repudiationMoratoriumIDRef_ { get; set; }
        #region Restructuring_
        private Restructuring restructuring_;
        public Restructuring Restructuring_
        {
            get
            {
                if (this.restructuring_ != null)
                {
                    return this.restructuring_; 
                }
                else if (this.restructuringIDRef_ != null)
                {
                    restructuring_ = IDManager.getID(restructuringIDRef_) as Restructuring;
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
        
        public string restructuringIDRef_ { get; set; }
        #region DistressedRatingsDowngrade_
        private XsdTypeBoolean distressedRatingsDowngrade_;
        public XsdTypeBoolean DistressedRatingsDowngrade_
        {
            get
            {
                if (this.distressedRatingsDowngrade_ != null)
                {
                    return this.distressedRatingsDowngrade_; 
                }
                else if (this.distressedRatingsDowngradeIDRef_ != null)
                {
                    distressedRatingsDowngrade_ = IDManager.getID(distressedRatingsDowngradeIDRef_) as XsdTypeBoolean;
                    return this.distressedRatingsDowngrade_; 
                }
                else
                {
                      return this.distressedRatingsDowngrade_; 
                }
            }
            set
            {
                if (this.distressedRatingsDowngrade_ != value)
                {
                    this.distressedRatingsDowngrade_ = value;
                }
            }
        }
        #endregion
        
        public string distressedRatingsDowngradeIDRef_ { get; set; }
        #region MaturityExtension_
        private XsdTypeBoolean maturityExtension_;
        public XsdTypeBoolean MaturityExtension_
        {
            get
            {
                if (this.maturityExtension_ != null)
                {
                    return this.maturityExtension_; 
                }
                else if (this.maturityExtensionIDRef_ != null)
                {
                    maturityExtension_ = IDManager.getID(maturityExtensionIDRef_) as XsdTypeBoolean;
                    return this.maturityExtension_; 
                }
                else
                {
                      return this.maturityExtension_; 
                }
            }
            set
            {
                if (this.maturityExtension_ != value)
                {
                    this.maturityExtension_ = value;
                }
            }
        }
        #endregion
        
        public string maturityExtensionIDRef_ { get; set; }
        #region Writedown_
        private XsdTypeBoolean writedown_;
        public XsdTypeBoolean Writedown_
        {
            get
            {
                if (this.writedown_ != null)
                {
                    return this.writedown_; 
                }
                else if (this.writedownIDRef_ != null)
                {
                    writedown_ = IDManager.getID(writedownIDRef_) as XsdTypeBoolean;
                    return this.writedown_; 
                }
                else
                {
                      return this.writedown_; 
                }
            }
            set
            {
                if (this.writedown_ != value)
                {
                    this.writedown_ = value;
                }
            }
        }
        #endregion
        
        public string writedownIDRef_ { get; set; }
        #region ImpliedWritedown_
        private XsdTypeBoolean impliedWritedown_;
        public XsdTypeBoolean ImpliedWritedown_
        {
            get
            {
                if (this.impliedWritedown_ != null)
                {
                    return this.impliedWritedown_; 
                }
                else if (this.impliedWritedownIDRef_ != null)
                {
                    impliedWritedown_ = IDManager.getID(impliedWritedownIDRef_) as XsdTypeBoolean;
                    return this.impliedWritedown_; 
                }
                else
                {
                      return this.impliedWritedown_; 
                }
            }
            set
            {
                if (this.impliedWritedown_ != value)
                {
                    this.impliedWritedown_ = value;
                }
            }
        }
        #endregion
        
        public string impliedWritedownIDRef_ { get; set; }
        #region DefaultRequirement_
        private Money defaultRequirement_;
        public Money DefaultRequirement_
        {
            get
            {
                if (this.defaultRequirement_ != null)
                {
                    return this.defaultRequirement_; 
                }
                else if (this.defaultRequirementIDRef_ != null)
                {
                    defaultRequirement_ = IDManager.getID(defaultRequirementIDRef_) as Money;
                    return this.defaultRequirement_; 
                }
                else
                {
                      return this.defaultRequirement_; 
                }
            }
            set
            {
                if (this.defaultRequirement_ != value)
                {
                    this.defaultRequirement_ = value;
                }
            }
        }
        #endregion
        
        public string defaultRequirementIDRef_ { get; set; }
        #region CreditEventNotice_
        private CreditEventNotice creditEventNotice_;
        public CreditEventNotice CreditEventNotice_
        {
            get
            {
                if (this.creditEventNotice_ != null)
                {
                    return this.creditEventNotice_; 
                }
                else if (this.creditEventNoticeIDRef_ != null)
                {
                    creditEventNotice_ = IDManager.getID(creditEventNoticeIDRef_) as CreditEventNotice;
                    return this.creditEventNotice_; 
                }
                else
                {
                      return this.creditEventNotice_; 
                }
            }
            set
            {
                if (this.creditEventNotice_ != value)
                {
                    this.creditEventNotice_ = value;
                }
            }
        }
        #endregion
        
        public string creditEventNoticeIDRef_ { get; set; }
        
    
        
    
    }
    
}

