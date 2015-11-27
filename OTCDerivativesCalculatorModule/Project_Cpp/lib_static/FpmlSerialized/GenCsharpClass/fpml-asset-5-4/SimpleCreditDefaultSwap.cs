using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class SimpleCreditDefaultSwap
    {
        public SimpleCreditDefaultSwap(XmlNode xmlNode)
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
            
        
            XmlNodeList termNodeList = xmlNode.SelectNodes("term");
            if (termNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in termNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        termIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(termIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        termIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        term = new Period(item);
                    }
                }
            }
            
        
            XmlNodeList paymentFrequencyNodeList = xmlNode.SelectNodes("paymentFrequency");
            if (paymentFrequencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentFrequencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentFrequencyIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(paymentFrequencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentFrequencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentFrequency = new Period(item);
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
        #region Term
        private Period term;
        public Period Term
        {
            get
            {
                if (this.term != null)
                {
                    return this.term; 
                }
                else if (this.termIDRef != null)
                {
                    term = IDManager.getID(termIDRef) as Period;
                    return this.term; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.term != value)
                {
                    this.term = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region PaymentFrequency
        private Period paymentFrequency;
        public Period PaymentFrequency
        {
            get
            {
                if (this.paymentFrequency != null)
                {
                    return this.paymentFrequency; 
                }
                else if (this.paymentFrequencyIDRef != null)
                {
                    paymentFrequency = IDManager.getID(paymentFrequencyIDRef) as Period;
                    return this.paymentFrequency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentFrequency != value)
                {
                    this.paymentFrequency = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

