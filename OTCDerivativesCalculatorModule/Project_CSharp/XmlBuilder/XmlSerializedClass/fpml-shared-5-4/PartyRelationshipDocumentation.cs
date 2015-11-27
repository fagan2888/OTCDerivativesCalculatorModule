using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PartyRelationshipDocumentation : ISerialized
    {
        public PartyRelationshipDocumentation(XmlNode xmlNode)
        {
            XmlNode masterAgreementNode = xmlNode.SelectSingleNode("masterAgreement");
            
            if (masterAgreementNode != null)
            {
                if (masterAgreementNode.Attributes["href"] != null || masterAgreementNode.Attributes["id"] != null) 
                {
                    if (masterAgreementNode.Attributes["id"] != null) 
                    {
                        masterAgreementIDRef_ = masterAgreementNode.Attributes["id"].Value;
                        MasterAgreement ob = new MasterAgreement(masterAgreementNode);
                        IDManager.SetID(masterAgreementIDRef_, ob);
                    }
                    else if (masterAgreementNode.Attributes["href"] != null)
                    {
                        masterAgreementIDRef_ = masterAgreementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        masterAgreement_ = new MasterAgreement(masterAgreementNode);
                    }
                }
                else
                {
                    masterAgreement_ = new MasterAgreement(masterAgreementNode);
                }
            }
            
        
            XmlNode creditSupportAgreementNode = xmlNode.SelectSingleNode("creditSupportAgreement");
            
            if (creditSupportAgreementNode != null)
            {
                if (creditSupportAgreementNode.Attributes["href"] != null || creditSupportAgreementNode.Attributes["id"] != null) 
                {
                    if (creditSupportAgreementNode.Attributes["id"] != null) 
                    {
                        creditSupportAgreementIDRef_ = creditSupportAgreementNode.Attributes["id"].Value;
                        CreditSupportAgreement ob = new CreditSupportAgreement(creditSupportAgreementNode);
                        IDManager.SetID(creditSupportAgreementIDRef_, ob);
                    }
                    else if (creditSupportAgreementNode.Attributes["href"] != null)
                    {
                        creditSupportAgreementIDRef_ = creditSupportAgreementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditSupportAgreement_ = new CreditSupportAgreement(creditSupportAgreementNode);
                    }
                }
                else
                {
                    creditSupportAgreement_ = new CreditSupportAgreement(creditSupportAgreementNode);
                }
            }
            
        
            XmlNode agreementNode = xmlNode.SelectSingleNode("agreement");
            
            if (agreementNode != null)
            {
                if (agreementNode.Attributes["href"] != null || agreementNode.Attributes["id"] != null) 
                {
                    if (agreementNode.Attributes["id"] != null) 
                    {
                        agreementIDRef_ = agreementNode.Attributes["id"].Value;
                        GenericAgreement ob = new GenericAgreement(agreementNode);
                        IDManager.SetID(agreementIDRef_, ob);
                    }
                    else if (agreementNode.Attributes["href"] != null)
                    {
                        agreementIDRef_ = agreementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        agreement_ = new GenericAgreement(agreementNode);
                    }
                }
                else
                {
                    agreement_ = new GenericAgreement(agreementNode);
                }
            }
            
        
        }
        
    
        #region MasterAgreement_
        private MasterAgreement masterAgreement_;
        public MasterAgreement MasterAgreement_
        {
            get
            {
                if (this.masterAgreement_ != null)
                {
                    return this.masterAgreement_; 
                }
                else if (this.masterAgreementIDRef_ != null)
                {
                    masterAgreement_ = IDManager.getID(masterAgreementIDRef_) as MasterAgreement;
                    return this.masterAgreement_; 
                }
                else
                {
                      return this.masterAgreement_; 
                }
            }
            set
            {
                if (this.masterAgreement_ != value)
                {
                    this.masterAgreement_ = value;
                }
            }
        }
        #endregion
        
        public string masterAgreementIDRef_ { get; set; }
        #region CreditSupportAgreement_
        private CreditSupportAgreement creditSupportAgreement_;
        public CreditSupportAgreement CreditSupportAgreement_
        {
            get
            {
                if (this.creditSupportAgreement_ != null)
                {
                    return this.creditSupportAgreement_; 
                }
                else if (this.creditSupportAgreementIDRef_ != null)
                {
                    creditSupportAgreement_ = IDManager.getID(creditSupportAgreementIDRef_) as CreditSupportAgreement;
                    return this.creditSupportAgreement_; 
                }
                else
                {
                      return this.creditSupportAgreement_; 
                }
            }
            set
            {
                if (this.creditSupportAgreement_ != value)
                {
                    this.creditSupportAgreement_ = value;
                }
            }
        }
        #endregion
        
        public string creditSupportAgreementIDRef_ { get; set; }
        #region Agreement_
        private GenericAgreement agreement_;
        public GenericAgreement Agreement_
        {
            get
            {
                if (this.agreement_ != null)
                {
                    return this.agreement_; 
                }
                else if (this.agreementIDRef_ != null)
                {
                    agreement_ = IDManager.getID(agreementIDRef_) as GenericAgreement;
                    return this.agreement_; 
                }
                else
                {
                      return this.agreement_; 
                }
            }
            set
            {
                if (this.agreement_ != value)
                {
                    this.agreement_ = value;
                }
            }
        }
        #endregion
        
        public string agreementIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

