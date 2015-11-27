using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CreditCurve
    {
        public CreditCurve(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNodeList creditEntityReferenceNodeList = xmlNode.SelectNodes("creditEntityReference");
            if (creditEntityReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditEntityReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditEntityReferenceIDRef = item.Attributes["id"].Name;
                        LegalEntityReference ob = LegalEntityReference();
                        IDManager.SetID(creditEntityReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditEntityReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditEntityReference = new LegalEntityReference(item);
                    }
                }
            }
            
        
            XmlNodeList creditEventsNodeList = xmlNode.SelectNodes("creditEvents");
            if (creditEventsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditEventsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditEventsIDRef = item.Attributes["id"].Name;
                        CreditEvents ob = CreditEvents();
                        IDManager.SetID(creditEventsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditEventsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditEvents = new CreditEvents(item);
                    }
                }
            }
            
        
            XmlNodeList seniorityNodeList = xmlNode.SelectNodes("seniority");
            if (seniorityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in seniorityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        seniorityIDRef = item.Attributes["id"].Name;
                        CreditSeniority ob = CreditSeniority();
                        IDManager.SetID(seniorityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        seniorityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        seniority = new CreditSeniority(item);
                    }
                }
            }
            
        
            XmlNodeList securedNodeList = xmlNode.SelectNodes("secured");
            if (securedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in securedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        securedIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(securedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        securedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        secured = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList obligationCurrencyNodeList = xmlNode.SelectNodes("obligationCurrency");
            if (obligationCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in obligationCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        obligationCurrencyIDRef = item.Attributes["id"].Name;
                        Currency ob = Currency();
                        IDManager.SetID(obligationCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        obligationCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        obligationCurrency = new Currency(item);
                    }
                }
            }
            
        
            XmlNodeList obligationsNodeList = xmlNode.SelectNodes("obligations");
            if (obligationsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in obligationsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        obligationsIDRef = item.Attributes["id"].Name;
                        Obligations ob = Obligations();
                        IDManager.SetID(obligationsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        obligationsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        obligations = new Obligations(item);
                    }
                }
            }
            
        
            XmlNodeList deliverableObligationsNodeList = xmlNode.SelectNodes("deliverableObligations");
            if (deliverableObligationsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliverableObligationsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliverableObligationsIDRef = item.Attributes["id"].Name;
                        DeliverableObligations ob = DeliverableObligations();
                        IDManager.SetID(deliverableObligationsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliverableObligationsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliverableObligations = new DeliverableObligations(item);
                    }
                }
            }
            
        
        }
        
    
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
        #region CreditEntityReference
        private LegalEntityReference creditEntityReference;
        public LegalEntityReference CreditEntityReference
        {
            get
            {
                if (this.creditEntityReference != null)
                {
                    return this.creditEntityReference; 
                }
                else if (this.creditEntityReferenceIDRef != null)
                {
                    creditEntityReference = IDManager.getID(creditEntityReferenceIDRef) as LegalEntityReference;
                    return this.creditEntityReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditEntityReference != value)
                {
                    this.creditEntityReference = value;
                }
            }
        }
        #endregion
        
        public string LegalEntityReferenceIDRef { get; set; }
        #region CreditEvents
        private CreditEvents creditEvents;
        public CreditEvents CreditEvents
        {
            get
            {
                if (this.creditEvents != null)
                {
                    return this.creditEvents; 
                }
                else if (this.creditEventsIDRef != null)
                {
                    creditEvents = IDManager.getID(creditEventsIDRef) as CreditEvents;
                    return this.creditEvents; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditEvents != value)
                {
                    this.creditEvents = value;
                }
            }
        }
        #endregion
        
        public string CreditEventsIDRef { get; set; }
        #region Seniority
        private CreditSeniority seniority;
        public CreditSeniority Seniority
        {
            get
            {
                if (this.seniority != null)
                {
                    return this.seniority; 
                }
                else if (this.seniorityIDRef != null)
                {
                    seniority = IDManager.getID(seniorityIDRef) as CreditSeniority;
                    return this.seniority; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.seniority != value)
                {
                    this.seniority = value;
                }
            }
        }
        #endregion
        
        public string CreditSeniorityIDRef { get; set; }
        #region Secured
        private XsdTypeBoolean secured;
        public XsdTypeBoolean Secured
        {
            get
            {
                if (this.secured != null)
                {
                    return this.secured; 
                }
                else if (this.securedIDRef != null)
                {
                    secured = IDManager.getID(securedIDRef) as XsdTypeBoolean;
                    return this.secured; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.secured != value)
                {
                    this.secured = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ObligationCurrency
        private Currency obligationCurrency;
        public Currency ObligationCurrency
        {
            get
            {
                if (this.obligationCurrency != null)
                {
                    return this.obligationCurrency; 
                }
                else if (this.obligationCurrencyIDRef != null)
                {
                    obligationCurrency = IDManager.getID(obligationCurrencyIDRef) as Currency;
                    return this.obligationCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.obligationCurrency != value)
                {
                    this.obligationCurrency = value;
                }
            }
        }
        #endregion
        
        public string CurrencyIDRef { get; set; }
        #region Obligations
        private Obligations obligations;
        public Obligations Obligations
        {
            get
            {
                if (this.obligations != null)
                {
                    return this.obligations; 
                }
                else if (this.obligationsIDRef != null)
                {
                    obligations = IDManager.getID(obligationsIDRef) as Obligations;
                    return this.obligations; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.obligations != value)
                {
                    this.obligations = value;
                }
            }
        }
        #endregion
        
        public string ObligationsIDRef { get; set; }
        #region DeliverableObligations
        private DeliverableObligations deliverableObligations;
        public DeliverableObligations DeliverableObligations
        {
            get
            {
                if (this.deliverableObligations != null)
                {
                    return this.deliverableObligations; 
                }
                else if (this.deliverableObligationsIDRef != null)
                {
                    deliverableObligations = IDManager.getID(deliverableObligationsIDRef) as DeliverableObligations;
                    return this.deliverableObligations; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliverableObligations != value)
                {
                    this.deliverableObligations = value;
                }
            }
        }
        #endregion
        
        public string DeliverableObligationsIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

