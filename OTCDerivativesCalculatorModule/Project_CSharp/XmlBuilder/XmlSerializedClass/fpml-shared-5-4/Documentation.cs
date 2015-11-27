using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Documentation : ISerialized
    {
        public Documentation(XmlNode xmlNode)
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
            
        
            XmlNode masterConfirmationNode = xmlNode.SelectSingleNode("masterConfirmation");
            
            if (masterConfirmationNode != null)
            {
                if (masterConfirmationNode.Attributes["href"] != null || masterConfirmationNode.Attributes["id"] != null) 
                {
                    if (masterConfirmationNode.Attributes["id"] != null) 
                    {
                        masterConfirmationIDRef_ = masterConfirmationNode.Attributes["id"].Value;
                        MasterConfirmation ob = new MasterConfirmation(masterConfirmationNode);
                        IDManager.SetID(masterConfirmationIDRef_, ob);
                    }
                    else if (masterConfirmationNode.Attributes["href"] != null)
                    {
                        masterConfirmationIDRef_ = masterConfirmationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        masterConfirmation_ = new MasterConfirmation(masterConfirmationNode);
                    }
                }
                else
                {
                    masterConfirmation_ = new MasterConfirmation(masterConfirmationNode);
                }
            }
            
        
            XmlNode brokerConfirmationNode = xmlNode.SelectSingleNode("brokerConfirmation");
            
            if (brokerConfirmationNode != null)
            {
                if (brokerConfirmationNode.Attributes["href"] != null || brokerConfirmationNode.Attributes["id"] != null) 
                {
                    if (brokerConfirmationNode.Attributes["id"] != null) 
                    {
                        brokerConfirmationIDRef_ = brokerConfirmationNode.Attributes["id"].Value;
                        BrokerConfirmation ob = new BrokerConfirmation(brokerConfirmationNode);
                        IDManager.SetID(brokerConfirmationIDRef_, ob);
                    }
                    else if (brokerConfirmationNode.Attributes["href"] != null)
                    {
                        brokerConfirmationIDRef_ = brokerConfirmationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        brokerConfirmation_ = new BrokerConfirmation(brokerConfirmationNode);
                    }
                }
                else
                {
                    brokerConfirmation_ = new BrokerConfirmation(brokerConfirmationNode);
                }
            }
            
        
            XmlNodeList contractualDefinitionsNodeList = xmlNode.SelectNodes("contractualDefinitions");
            
            if (contractualDefinitionsNodeList != null)
            {
                this.contractualDefinitions_ = new List<ContractualDefinitions>();
                foreach (XmlNode item in contractualDefinitionsNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            contractualDefinitionsIDRef_ = item.Attributes["id"].Value;
                            contractualDefinitions_.Add(new ContractualDefinitions(item));
                            IDManager.SetID(contractualDefinitionsIDRef_, contractualDefinitions_[contractualDefinitions_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            contractualDefinitionsIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        contractualDefinitions_.Add(new ContractualDefinitions(item));
                        }
                    }
                    else
                    {
                        contractualDefinitions_.Add(new ContractualDefinitions(item));
                    }
                }
            }
            
        
            XmlNodeList contractualTermsSupplementNodeList = xmlNode.SelectNodes("contractualTermsSupplement");
            
            if (contractualTermsSupplementNodeList != null)
            {
                this.contractualTermsSupplement_ = new List<ContractualTermsSupplement>();
                foreach (XmlNode item in contractualTermsSupplementNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            contractualTermsSupplementIDRef_ = item.Attributes["id"].Value;
                            contractualTermsSupplement_.Add(new ContractualTermsSupplement(item));
                            IDManager.SetID(contractualTermsSupplementIDRef_, contractualTermsSupplement_[contractualTermsSupplement_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            contractualTermsSupplementIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        contractualTermsSupplement_.Add(new ContractualTermsSupplement(item));
                        }
                    }
                    else
                    {
                        contractualTermsSupplement_.Add(new ContractualTermsSupplement(item));
                    }
                }
            }
            
        
            XmlNodeList contractualMatrixNodeList = xmlNode.SelectNodes("contractualMatrix");
            
            if (contractualMatrixNodeList != null)
            {
                this.contractualMatrix_ = new List<ContractualMatrix>();
                foreach (XmlNode item in contractualMatrixNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            contractualMatrixIDRef_ = item.Attributes["id"].Value;
                            contractualMatrix_.Add(new ContractualMatrix(item));
                            IDManager.SetID(contractualMatrixIDRef_, contractualMatrix_[contractualMatrix_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            contractualMatrixIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        contractualMatrix_.Add(new ContractualMatrix(item));
                        }
                    }
                    else
                    {
                        contractualMatrix_.Add(new ContractualMatrix(item));
                    }
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
            
        
            XmlNodeList attachmentNodeList = xmlNode.SelectNodes("attachment");
            
            if (attachmentNodeList != null)
            {
                this.attachment_ = new List<Resource>();
                foreach (XmlNode item in attachmentNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            attachmentIDRef_ = item.Attributes["id"].Value;
                            attachment_.Add(new Resource(item));
                            IDManager.SetID(attachmentIDRef_, attachment_[attachment_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            attachmentIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        attachment_.Add(new Resource(item));
                        }
                    }
                    else
                    {
                        attachment_.Add(new Resource(item));
                    }
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
        #region MasterConfirmation_
        private MasterConfirmation masterConfirmation_;
        public MasterConfirmation MasterConfirmation_
        {
            get
            {
                if (this.masterConfirmation_ != null)
                {
                    return this.masterConfirmation_; 
                }
                else if (this.masterConfirmationIDRef_ != null)
                {
                    masterConfirmation_ = IDManager.getID(masterConfirmationIDRef_) as MasterConfirmation;
                    return this.masterConfirmation_; 
                }
                else
                {
                      return this.masterConfirmation_; 
                }
            }
            set
            {
                if (this.masterConfirmation_ != value)
                {
                    this.masterConfirmation_ = value;
                }
            }
        }
        #endregion
        
        public string masterConfirmationIDRef_ { get; set; }
        #region BrokerConfirmation_
        private BrokerConfirmation brokerConfirmation_;
        public BrokerConfirmation BrokerConfirmation_
        {
            get
            {
                if (this.brokerConfirmation_ != null)
                {
                    return this.brokerConfirmation_; 
                }
                else if (this.brokerConfirmationIDRef_ != null)
                {
                    brokerConfirmation_ = IDManager.getID(brokerConfirmationIDRef_) as BrokerConfirmation;
                    return this.brokerConfirmation_; 
                }
                else
                {
                      return this.brokerConfirmation_; 
                }
            }
            set
            {
                if (this.brokerConfirmation_ != value)
                {
                    this.brokerConfirmation_ = value;
                }
            }
        }
        #endregion
        
        public string brokerConfirmationIDRef_ { get; set; }
        #region ContractualDefinitions_
        private List<ContractualDefinitions> contractualDefinitions_;
        public List<ContractualDefinitions> ContractualDefinitions_
        {
            get
            {
                if (this.contractualDefinitions_ != null)
                {
                    return this.contractualDefinitions_; 
                }
                else if (this.contractualDefinitionsIDRef_ != null)
                {
                    return this.contractualDefinitions_; 
                }
                else
                {
                      return this.contractualDefinitions_; 
                }
            }
            set
            {
                if (this.contractualDefinitions_ != value)
                {
                    this.contractualDefinitions_ = value;
                }
            }
        }
        #endregion
        
        public string contractualDefinitionsIDRef_ { get; set; }
        #region ContractualTermsSupplement_
        private List<ContractualTermsSupplement> contractualTermsSupplement_;
        public List<ContractualTermsSupplement> ContractualTermsSupplement_
        {
            get
            {
                if (this.contractualTermsSupplement_ != null)
                {
                    return this.contractualTermsSupplement_; 
                }
                else if (this.contractualTermsSupplementIDRef_ != null)
                {
                    return this.contractualTermsSupplement_; 
                }
                else
                {
                      return this.contractualTermsSupplement_; 
                }
            }
            set
            {
                if (this.contractualTermsSupplement_ != value)
                {
                    this.contractualTermsSupplement_ = value;
                }
            }
        }
        #endregion
        
        public string contractualTermsSupplementIDRef_ { get; set; }
        #region ContractualMatrix_
        private List<ContractualMatrix> contractualMatrix_;
        public List<ContractualMatrix> ContractualMatrix_
        {
            get
            {
                if (this.contractualMatrix_ != null)
                {
                    return this.contractualMatrix_; 
                }
                else if (this.contractualMatrixIDRef_ != null)
                {
                    return this.contractualMatrix_; 
                }
                else
                {
                      return this.contractualMatrix_; 
                }
            }
            set
            {
                if (this.contractualMatrix_ != value)
                {
                    this.contractualMatrix_ = value;
                }
            }
        }
        #endregion
        
        public string contractualMatrixIDRef_ { get; set; }
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
        #region Attachment_
        private List<Resource> attachment_;
        public List<Resource> Attachment_
        {
            get
            {
                if (this.attachment_ != null)
                {
                    return this.attachment_; 
                }
                else if (this.attachmentIDRef_ != null)
                {
                    return this.attachment_; 
                }
                else
                {
                      return this.attachment_; 
                }
            }
            set
            {
                if (this.attachment_ != value)
                {
                    this.attachment_ = value;
                }
            }
        }
        #endregion
        
        public string attachmentIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

