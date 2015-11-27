using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CreditEvents
    {
        public CreditEvents(XmlNode xmlNode)
        {
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
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(bankruptcyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        bankruptcyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        bankruptcy = new XsdTypeBoolean(item);
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
                        FailureToPay ob = FailureToPay();
                        IDManager.SetID(failureToPayIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        failureToPayIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        failureToPay = new FailureToPay(item);
                    }
                }
            }
            
        
            XmlNodeList failureToPayPrincipalNodeList = xmlNode.SelectNodes("failureToPayPrincipal");
            if (failureToPayPrincipalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in failureToPayPrincipalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        failureToPayPrincipalIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(failureToPayPrincipalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        failureToPayPrincipalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        failureToPayPrincipal = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList failureToPayInterestNodeList = xmlNode.SelectNodes("failureToPayInterest");
            if (failureToPayInterestNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in failureToPayInterestNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        failureToPayInterestIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(failureToPayInterestIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        failureToPayInterestIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        failureToPayInterest = new XsdTypeBoolean(item);
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
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(obligationDefaultIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        obligationDefaultIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        obligationDefault = new XsdTypeBoolean(item);
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
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(obligationAccelerationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        obligationAccelerationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        obligationAcceleration = new XsdTypeBoolean(item);
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
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(repudiationMoratoriumIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        repudiationMoratoriumIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        repudiationMoratorium = new XsdTypeBoolean(item);
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
                        Restructuring ob = Restructuring();
                        IDManager.SetID(restructuringIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        restructuringIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        restructuring = new Restructuring(item);
                    }
                }
            }
            
        
            XmlNodeList distressedRatingsDowngradeNodeList = xmlNode.SelectNodes("distressedRatingsDowngrade");
            if (distressedRatingsDowngradeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in distressedRatingsDowngradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        distressedRatingsDowngradeIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(distressedRatingsDowngradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        distressedRatingsDowngradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        distressedRatingsDowngrade = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList maturityExtensionNodeList = xmlNode.SelectNodes("maturityExtension");
            if (maturityExtensionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maturityExtensionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maturityExtensionIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(maturityExtensionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maturityExtensionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maturityExtension = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList writedownNodeList = xmlNode.SelectNodes("writedown");
            if (writedownNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in writedownNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        writedownIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(writedownIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        writedownIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        writedown = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList impliedWritedownNodeList = xmlNode.SelectNodes("impliedWritedown");
            if (impliedWritedownNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in impliedWritedownNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        impliedWritedownIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(impliedWritedownIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        impliedWritedownIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        impliedWritedown = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList defaultRequirementNodeList = xmlNode.SelectNodes("defaultRequirement");
            if (defaultRequirementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in defaultRequirementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        defaultRequirementIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(defaultRequirementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        defaultRequirementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        defaultRequirement = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList creditEventNoticeNodeList = xmlNode.SelectNodes("creditEventNotice");
            if (creditEventNoticeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditEventNoticeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditEventNoticeIDRef = item.Attributes["id"].Name;
                        CreditEventNotice ob = CreditEventNotice();
                        IDManager.SetID(creditEventNoticeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditEventNoticeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditEventNotice = new CreditEventNotice(item);
                    }
                }
            }
            
        
        }
        
    
        #region Bankruptcy
        private XsdTypeBoolean bankruptcy;
        public XsdTypeBoolean Bankruptcy
        {
            get
            {
                if (this.bankruptcy != null)
                {
                    return this.bankruptcy; 
                }
                else if (this.bankruptcyIDRef != null)
                {
                    bankruptcy = IDManager.getID(bankruptcyIDRef) as XsdTypeBoolean;
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
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region FailureToPay
        private FailureToPay failureToPay;
        public FailureToPay FailureToPay
        {
            get
            {
                if (this.failureToPay != null)
                {
                    return this.failureToPay; 
                }
                else if (this.failureToPayIDRef != null)
                {
                    failureToPay = IDManager.getID(failureToPayIDRef) as FailureToPay;
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
        
        public string FailureToPayIDRef { get; set; }
        #region FailureToPayPrincipal
        private XsdTypeBoolean failureToPayPrincipal;
        public XsdTypeBoolean FailureToPayPrincipal
        {
            get
            {
                if (this.failureToPayPrincipal != null)
                {
                    return this.failureToPayPrincipal; 
                }
                else if (this.failureToPayPrincipalIDRef != null)
                {
                    failureToPayPrincipal = IDManager.getID(failureToPayPrincipalIDRef) as XsdTypeBoolean;
                    return this.failureToPayPrincipal; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.failureToPayPrincipal != value)
                {
                    this.failureToPayPrincipal = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region FailureToPayInterest
        private XsdTypeBoolean failureToPayInterest;
        public XsdTypeBoolean FailureToPayInterest
        {
            get
            {
                if (this.failureToPayInterest != null)
                {
                    return this.failureToPayInterest; 
                }
                else if (this.failureToPayInterestIDRef != null)
                {
                    failureToPayInterest = IDManager.getID(failureToPayInterestIDRef) as XsdTypeBoolean;
                    return this.failureToPayInterest; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.failureToPayInterest != value)
                {
                    this.failureToPayInterest = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ObligationDefault
        private XsdTypeBoolean obligationDefault;
        public XsdTypeBoolean ObligationDefault
        {
            get
            {
                if (this.obligationDefault != null)
                {
                    return this.obligationDefault; 
                }
                else if (this.obligationDefaultIDRef != null)
                {
                    obligationDefault = IDManager.getID(obligationDefaultIDRef) as XsdTypeBoolean;
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
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ObligationAcceleration
        private XsdTypeBoolean obligationAcceleration;
        public XsdTypeBoolean ObligationAcceleration
        {
            get
            {
                if (this.obligationAcceleration != null)
                {
                    return this.obligationAcceleration; 
                }
                else if (this.obligationAccelerationIDRef != null)
                {
                    obligationAcceleration = IDManager.getID(obligationAccelerationIDRef) as XsdTypeBoolean;
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
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region RepudiationMoratorium
        private XsdTypeBoolean repudiationMoratorium;
        public XsdTypeBoolean RepudiationMoratorium
        {
            get
            {
                if (this.repudiationMoratorium != null)
                {
                    return this.repudiationMoratorium; 
                }
                else if (this.repudiationMoratoriumIDRef != null)
                {
                    repudiationMoratorium = IDManager.getID(repudiationMoratoriumIDRef) as XsdTypeBoolean;
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
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region Restructuring
        private Restructuring restructuring;
        public Restructuring Restructuring
        {
            get
            {
                if (this.restructuring != null)
                {
                    return this.restructuring; 
                }
                else if (this.restructuringIDRef != null)
                {
                    restructuring = IDManager.getID(restructuringIDRef) as Restructuring;
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
        
        public string RestructuringIDRef { get; set; }
        #region DistressedRatingsDowngrade
        private XsdTypeBoolean distressedRatingsDowngrade;
        public XsdTypeBoolean DistressedRatingsDowngrade
        {
            get
            {
                if (this.distressedRatingsDowngrade != null)
                {
                    return this.distressedRatingsDowngrade; 
                }
                else if (this.distressedRatingsDowngradeIDRef != null)
                {
                    distressedRatingsDowngrade = IDManager.getID(distressedRatingsDowngradeIDRef) as XsdTypeBoolean;
                    return this.distressedRatingsDowngrade; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.distressedRatingsDowngrade != value)
                {
                    this.distressedRatingsDowngrade = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region MaturityExtension
        private XsdTypeBoolean maturityExtension;
        public XsdTypeBoolean MaturityExtension
        {
            get
            {
                if (this.maturityExtension != null)
                {
                    return this.maturityExtension; 
                }
                else if (this.maturityExtensionIDRef != null)
                {
                    maturityExtension = IDManager.getID(maturityExtensionIDRef) as XsdTypeBoolean;
                    return this.maturityExtension; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maturityExtension != value)
                {
                    this.maturityExtension = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region Writedown
        private XsdTypeBoolean writedown;
        public XsdTypeBoolean Writedown
        {
            get
            {
                if (this.writedown != null)
                {
                    return this.writedown; 
                }
                else if (this.writedownIDRef != null)
                {
                    writedown = IDManager.getID(writedownIDRef) as XsdTypeBoolean;
                    return this.writedown; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.writedown != value)
                {
                    this.writedown = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ImpliedWritedown
        private XsdTypeBoolean impliedWritedown;
        public XsdTypeBoolean ImpliedWritedown
        {
            get
            {
                if (this.impliedWritedown != null)
                {
                    return this.impliedWritedown; 
                }
                else if (this.impliedWritedownIDRef != null)
                {
                    impliedWritedown = IDManager.getID(impliedWritedownIDRef) as XsdTypeBoolean;
                    return this.impliedWritedown; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.impliedWritedown != value)
                {
                    this.impliedWritedown = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region DefaultRequirement
        private Money defaultRequirement;
        public Money DefaultRequirement
        {
            get
            {
                if (this.defaultRequirement != null)
                {
                    return this.defaultRequirement; 
                }
                else if (this.defaultRequirementIDRef != null)
                {
                    defaultRequirement = IDManager.getID(defaultRequirementIDRef) as Money;
                    return this.defaultRequirement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.defaultRequirement != value)
                {
                    this.defaultRequirement = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region CreditEventNotice
        private CreditEventNotice creditEventNotice;
        public CreditEventNotice CreditEventNotice
        {
            get
            {
                if (this.creditEventNotice != null)
                {
                    return this.creditEventNotice; 
                }
                else if (this.creditEventNoticeIDRef != null)
                {
                    creditEventNotice = IDManager.getID(creditEventNoticeIDRef) as CreditEventNotice;
                    return this.creditEventNotice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditEventNotice != value)
                {
                    this.creditEventNotice = value;
                }
            }
        }
        #endregion
        
        public string CreditEventNoticeIDRef { get; set; }
        
    
        
    
    }
    
}

