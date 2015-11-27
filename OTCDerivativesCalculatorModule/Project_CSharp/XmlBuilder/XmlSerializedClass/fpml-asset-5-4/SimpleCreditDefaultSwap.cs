using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SimpleCreditDefaultSwap : UnderlyingAsset
    {
        public SimpleCreditDefaultSwap(XmlNode xmlNode)
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
            
        
            XmlNode termNode = xmlNode.SelectSingleNode("term");
            
            if (termNode != null)
            {
                if (termNode.Attributes["href"] != null || termNode.Attributes["id"] != null) 
                {
                    if (termNode.Attributes["id"] != null) 
                    {
                        termIDRef_ = termNode.Attributes["id"].Value;
                        Period ob = new Period(termNode);
                        IDManager.SetID(termIDRef_, ob);
                    }
                    else if (termNode.Attributes["href"] != null)
                    {
                        termIDRef_ = termNode.Attributes["href"].Value;
                    }
                    else
                    {
                        term_ = new Period(termNode);
                    }
                }
                else
                {
                    term_ = new Period(termNode);
                }
            }
            
        
            XmlNode paymentFrequencyNode = xmlNode.SelectSingleNode("paymentFrequency");
            
            if (paymentFrequencyNode != null)
            {
                if (paymentFrequencyNode.Attributes["href"] != null || paymentFrequencyNode.Attributes["id"] != null) 
                {
                    if (paymentFrequencyNode.Attributes["id"] != null) 
                    {
                        paymentFrequencyIDRef_ = paymentFrequencyNode.Attributes["id"].Value;
                        Period ob = new Period(paymentFrequencyNode);
                        IDManager.SetID(paymentFrequencyIDRef_, ob);
                    }
                    else if (paymentFrequencyNode.Attributes["href"] != null)
                    {
                        paymentFrequencyIDRef_ = paymentFrequencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentFrequency_ = new Period(paymentFrequencyNode);
                    }
                }
                else
                {
                    paymentFrequency_ = new Period(paymentFrequencyNode);
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
        #region Term_
        private Period term_;
        public Period Term_
        {
            get
            {
                if (this.term_ != null)
                {
                    return this.term_; 
                }
                else if (this.termIDRef_ != null)
                {
                    term_ = IDManager.getID(termIDRef_) as Period;
                    return this.term_; 
                }
                else
                {
                      return this.term_; 
                }
            }
            set
            {
                if (this.term_ != value)
                {
                    this.term_ = value;
                }
            }
        }
        #endregion
        
        public string termIDRef_ { get; set; }
        #region PaymentFrequency_
        private Period paymentFrequency_;
        public Period PaymentFrequency_
        {
            get
            {
                if (this.paymentFrequency_ != null)
                {
                    return this.paymentFrequency_; 
                }
                else if (this.paymentFrequencyIDRef_ != null)
                {
                    paymentFrequency_ = IDManager.getID(paymentFrequencyIDRef_) as Period;
                    return this.paymentFrequency_; 
                }
                else
                {
                      return this.paymentFrequency_; 
                }
            }
            set
            {
                if (this.paymentFrequency_ != value)
                {
                    this.paymentFrequency_ = value;
                }
            }
        }
        #endregion
        
        public string paymentFrequencyIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

