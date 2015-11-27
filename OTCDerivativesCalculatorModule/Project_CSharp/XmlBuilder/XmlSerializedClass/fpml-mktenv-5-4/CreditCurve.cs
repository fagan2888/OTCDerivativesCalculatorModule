using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CreditCurve : PricingStructure
    {
        public CreditCurve(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNode creditEntityReferenceNode = xmlNode.SelectSingleNode("creditEntityReference");
            
            if (creditEntityReferenceNode != null)
            {
                if (creditEntityReferenceNode.Attributes["href"] != null || creditEntityReferenceNode.Attributes["id"] != null) 
                {
                    if (creditEntityReferenceNode.Attributes["id"] != null) 
                    {
                        creditEntityReferenceIDRef_ = creditEntityReferenceNode.Attributes["id"].Value;
                        LegalEntityReference ob = new LegalEntityReference(creditEntityReferenceNode);
                        IDManager.SetID(creditEntityReferenceIDRef_, ob);
                    }
                    else if (creditEntityReferenceNode.Attributes["href"] != null)
                    {
                        creditEntityReferenceIDRef_ = creditEntityReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditEntityReference_ = new LegalEntityReference(creditEntityReferenceNode);
                    }
                }
                else
                {
                    creditEntityReference_ = new LegalEntityReference(creditEntityReferenceNode);
                }
            }
            
        
            XmlNode creditEventsNode = xmlNode.SelectSingleNode("creditEvents");
            
            if (creditEventsNode != null)
            {
                if (creditEventsNode.Attributes["href"] != null || creditEventsNode.Attributes["id"] != null) 
                {
                    if (creditEventsNode.Attributes["id"] != null) 
                    {
                        creditEventsIDRef_ = creditEventsNode.Attributes["id"].Value;
                        CreditEvents ob = new CreditEvents(creditEventsNode);
                        IDManager.SetID(creditEventsIDRef_, ob);
                    }
                    else if (creditEventsNode.Attributes["href"] != null)
                    {
                        creditEventsIDRef_ = creditEventsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditEvents_ = new CreditEvents(creditEventsNode);
                    }
                }
                else
                {
                    creditEvents_ = new CreditEvents(creditEventsNode);
                }
            }
            
        
            XmlNode seniorityNode = xmlNode.SelectSingleNode("seniority");
            
            if (seniorityNode != null)
            {
                if (seniorityNode.Attributes["href"] != null || seniorityNode.Attributes["id"] != null) 
                {
                    if (seniorityNode.Attributes["id"] != null) 
                    {
                        seniorityIDRef_ = seniorityNode.Attributes["id"].Value;
                        CreditSeniority ob = new CreditSeniority(seniorityNode);
                        IDManager.SetID(seniorityIDRef_, ob);
                    }
                    else if (seniorityNode.Attributes["href"] != null)
                    {
                        seniorityIDRef_ = seniorityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        seniority_ = new CreditSeniority(seniorityNode);
                    }
                }
                else
                {
                    seniority_ = new CreditSeniority(seniorityNode);
                }
            }
            
        
            XmlNode securedNode = xmlNode.SelectSingleNode("secured");
            
            if (securedNode != null)
            {
                if (securedNode.Attributes["href"] != null || securedNode.Attributes["id"] != null) 
                {
                    if (securedNode.Attributes["id"] != null) 
                    {
                        securedIDRef_ = securedNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(securedNode);
                        IDManager.SetID(securedIDRef_, ob);
                    }
                    else if (securedNode.Attributes["href"] != null)
                    {
                        securedIDRef_ = securedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        secured_ = new XsdTypeBoolean(securedNode);
                    }
                }
                else
                {
                    secured_ = new XsdTypeBoolean(securedNode);
                }
            }
            
        
            XmlNode obligationCurrencyNode = xmlNode.SelectSingleNode("obligationCurrency");
            
            if (obligationCurrencyNode != null)
            {
                if (obligationCurrencyNode.Attributes["href"] != null || obligationCurrencyNode.Attributes["id"] != null) 
                {
                    if (obligationCurrencyNode.Attributes["id"] != null) 
                    {
                        obligationCurrencyIDRef_ = obligationCurrencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(obligationCurrencyNode);
                        IDManager.SetID(obligationCurrencyIDRef_, ob);
                    }
                    else if (obligationCurrencyNode.Attributes["href"] != null)
                    {
                        obligationCurrencyIDRef_ = obligationCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        obligationCurrency_ = new Currency(obligationCurrencyNode);
                    }
                }
                else
                {
                    obligationCurrency_ = new Currency(obligationCurrencyNode);
                }
            }
            
        
            XmlNode obligationsNode = xmlNode.SelectSingleNode("obligations");
            
            if (obligationsNode != null)
            {
                if (obligationsNode.Attributes["href"] != null || obligationsNode.Attributes["id"] != null) 
                {
                    if (obligationsNode.Attributes["id"] != null) 
                    {
                        obligationsIDRef_ = obligationsNode.Attributes["id"].Value;
                        Obligations ob = new Obligations(obligationsNode);
                        IDManager.SetID(obligationsIDRef_, ob);
                    }
                    else if (obligationsNode.Attributes["href"] != null)
                    {
                        obligationsIDRef_ = obligationsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        obligations_ = new Obligations(obligationsNode);
                    }
                }
                else
                {
                    obligations_ = new Obligations(obligationsNode);
                }
            }
            
        
            XmlNode deliverableObligationsNode = xmlNode.SelectSingleNode("deliverableObligations");
            
            if (deliverableObligationsNode != null)
            {
                if (deliverableObligationsNode.Attributes["href"] != null || deliverableObligationsNode.Attributes["id"] != null) 
                {
                    if (deliverableObligationsNode.Attributes["id"] != null) 
                    {
                        deliverableObligationsIDRef_ = deliverableObligationsNode.Attributes["id"].Value;
                        DeliverableObligations ob = new DeliverableObligations(deliverableObligationsNode);
                        IDManager.SetID(deliverableObligationsIDRef_, ob);
                    }
                    else if (deliverableObligationsNode.Attributes["href"] != null)
                    {
                        deliverableObligationsIDRef_ = deliverableObligationsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliverableObligations_ = new DeliverableObligations(deliverableObligationsNode);
                    }
                }
                else
                {
                    deliverableObligations_ = new DeliverableObligations(deliverableObligationsNode);
                }
            }
            
        
        }
        
    
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
        #region CreditEntityReference_
        private LegalEntityReference creditEntityReference_;
        public LegalEntityReference CreditEntityReference_
        {
            get
            {
                if (this.creditEntityReference_ != null)
                {
                    return this.creditEntityReference_; 
                }
                else if (this.creditEntityReferenceIDRef_ != null)
                {
                    creditEntityReference_ = IDManager.getID(creditEntityReferenceIDRef_) as LegalEntityReference;
                    return this.creditEntityReference_; 
                }
                else
                {
                      return this.creditEntityReference_; 
                }
            }
            set
            {
                if (this.creditEntityReference_ != value)
                {
                    this.creditEntityReference_ = value;
                }
            }
        }
        #endregion
        
        public string creditEntityReferenceIDRef_ { get; set; }
        #region CreditEvents_
        private CreditEvents creditEvents_;
        public CreditEvents CreditEvents_
        {
            get
            {
                if (this.creditEvents_ != null)
                {
                    return this.creditEvents_; 
                }
                else if (this.creditEventsIDRef_ != null)
                {
                    creditEvents_ = IDManager.getID(creditEventsIDRef_) as CreditEvents;
                    return this.creditEvents_; 
                }
                else
                {
                      return this.creditEvents_; 
                }
            }
            set
            {
                if (this.creditEvents_ != value)
                {
                    this.creditEvents_ = value;
                }
            }
        }
        #endregion
        
        public string creditEventsIDRef_ { get; set; }
        #region Seniority_
        private CreditSeniority seniority_;
        public CreditSeniority Seniority_
        {
            get
            {
                if (this.seniority_ != null)
                {
                    return this.seniority_; 
                }
                else if (this.seniorityIDRef_ != null)
                {
                    seniority_ = IDManager.getID(seniorityIDRef_) as CreditSeniority;
                    return this.seniority_; 
                }
                else
                {
                      return this.seniority_; 
                }
            }
            set
            {
                if (this.seniority_ != value)
                {
                    this.seniority_ = value;
                }
            }
        }
        #endregion
        
        public string seniorityIDRef_ { get; set; }
        #region Secured_
        private XsdTypeBoolean secured_;
        public XsdTypeBoolean Secured_
        {
            get
            {
                if (this.secured_ != null)
                {
                    return this.secured_; 
                }
                else if (this.securedIDRef_ != null)
                {
                    secured_ = IDManager.getID(securedIDRef_) as XsdTypeBoolean;
                    return this.secured_; 
                }
                else
                {
                      return this.secured_; 
                }
            }
            set
            {
                if (this.secured_ != value)
                {
                    this.secured_ = value;
                }
            }
        }
        #endregion
        
        public string securedIDRef_ { get; set; }
        #region ObligationCurrency_
        private Currency obligationCurrency_;
        public Currency ObligationCurrency_
        {
            get
            {
                if (this.obligationCurrency_ != null)
                {
                    return this.obligationCurrency_; 
                }
                else if (this.obligationCurrencyIDRef_ != null)
                {
                    obligationCurrency_ = IDManager.getID(obligationCurrencyIDRef_) as Currency;
                    return this.obligationCurrency_; 
                }
                else
                {
                      return this.obligationCurrency_; 
                }
            }
            set
            {
                if (this.obligationCurrency_ != value)
                {
                    this.obligationCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string obligationCurrencyIDRef_ { get; set; }
        #region Obligations_
        private Obligations obligations_;
        public Obligations Obligations_
        {
            get
            {
                if (this.obligations_ != null)
                {
                    return this.obligations_; 
                }
                else if (this.obligationsIDRef_ != null)
                {
                    obligations_ = IDManager.getID(obligationsIDRef_) as Obligations;
                    return this.obligations_; 
                }
                else
                {
                      return this.obligations_; 
                }
            }
            set
            {
                if (this.obligations_ != value)
                {
                    this.obligations_ = value;
                }
            }
        }
        #endregion
        
        public string obligationsIDRef_ { get; set; }
        #region DeliverableObligations_
        private DeliverableObligations deliverableObligations_;
        public DeliverableObligations DeliverableObligations_
        {
            get
            {
                if (this.deliverableObligations_ != null)
                {
                    return this.deliverableObligations_; 
                }
                else if (this.deliverableObligationsIDRef_ != null)
                {
                    deliverableObligations_ = IDManager.getID(deliverableObligationsIDRef_) as DeliverableObligations;
                    return this.deliverableObligations_; 
                }
                else
                {
                      return this.deliverableObligations_; 
                }
            }
            set
            {
                if (this.deliverableObligations_ != value)
                {
                    this.deliverableObligations_ = value;
                }
            }
        }
        #endregion
        
        public string deliverableObligationsIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

