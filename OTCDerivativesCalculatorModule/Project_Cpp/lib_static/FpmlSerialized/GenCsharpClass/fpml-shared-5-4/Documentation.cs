using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Documentation
    {
        public Documentation(XmlNode xmlNode)
        {
            XmlNodeList masterAgreementNodeList = xmlNode.SelectNodes("masterAgreement");
            if (masterAgreementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in masterAgreementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        masterAgreementIDRef = item.Attributes["id"].Name;
                        MasterAgreement ob = MasterAgreement();
                        IDManager.SetID(masterAgreementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        masterAgreementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        masterAgreement = new MasterAgreement(item);
                    }
                }
            }
            
        
            XmlNodeList masterConfirmationNodeList = xmlNode.SelectNodes("masterConfirmation");
            if (masterConfirmationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in masterConfirmationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        masterConfirmationIDRef = item.Attributes["id"].Name;
                        MasterConfirmation ob = MasterConfirmation();
                        IDManager.SetID(masterConfirmationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        masterConfirmationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        masterConfirmation = new MasterConfirmation(item);
                    }
                }
            }
            
        
            XmlNodeList brokerConfirmationNodeList = xmlNode.SelectNodes("brokerConfirmation");
            if (brokerConfirmationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in brokerConfirmationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        brokerConfirmationIDRef = item.Attributes["id"].Name;
                        BrokerConfirmation ob = BrokerConfirmation();
                        IDManager.SetID(brokerConfirmationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        brokerConfirmationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        brokerConfirmation = new BrokerConfirmation(item);
                    }
                }
            }
            
        
            XmlNodeList contractualDefinitionsNodeList = xmlNode.SelectNodes("contractualDefinitions");
            
            foreach (XmlNode item in contractualDefinitionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        contractualDefinitionsIDRef = item.Attributes["id"].Name;
                        List<ContractualDefinitions> ob = new List<ContractualDefinitions>();
                        ob.Add(new ContractualDefinitions(item));
                        IDManager.SetID(contractualDefinitionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        contractualDefinitionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    contractualDefinitions.Add(new ContractualDefinitions(item));
                    }
                }
            }
            
        
            XmlNodeList contractualTermsSupplementNodeList = xmlNode.SelectNodes("contractualTermsSupplement");
            
            foreach (XmlNode item in contractualTermsSupplementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        contractualTermsSupplementIDRef = item.Attributes["id"].Name;
                        List<ContractualTermsSupplement> ob = new List<ContractualTermsSupplement>();
                        ob.Add(new ContractualTermsSupplement(item));
                        IDManager.SetID(contractualTermsSupplementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        contractualTermsSupplementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    contractualTermsSupplement.Add(new ContractualTermsSupplement(item));
                    }
                }
            }
            
        
            XmlNodeList contractualMatrixNodeList = xmlNode.SelectNodes("contractualMatrix");
            
            foreach (XmlNode item in contractualMatrixNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        contractualMatrixIDRef = item.Attributes["id"].Name;
                        List<ContractualMatrix> ob = new List<ContractualMatrix>();
                        ob.Add(new ContractualMatrix(item));
                        IDManager.SetID(contractualMatrixIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        contractualMatrixIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    contractualMatrix.Add(new ContractualMatrix(item));
                    }
                }
            }
            
        
            XmlNodeList creditSupportAgreementNodeList = xmlNode.SelectNodes("creditSupportAgreement");
            if (creditSupportAgreementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditSupportAgreementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditSupportAgreementIDRef = item.Attributes["id"].Name;
                        CreditSupportAgreement ob = CreditSupportAgreement();
                        IDManager.SetID(creditSupportAgreementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditSupportAgreementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditSupportAgreement = new CreditSupportAgreement(item);
                    }
                }
            }
            
        
            XmlNodeList attachmentNodeList = xmlNode.SelectNodes("attachment");
            
            foreach (XmlNode item in attachmentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        attachmentIDRef = item.Attributes["id"].Name;
                        List<Resource> ob = new List<Resource>();
                        ob.Add(new Resource(item));
                        IDManager.SetID(attachmentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        attachmentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    attachment.Add(new Resource(item));
                    }
                }
            }
            
        
        }
        
    
        #region MasterAgreement
        private MasterAgreement masterAgreement;
        public MasterAgreement MasterAgreement
        {
            get
            {
                if (this.masterAgreement != null)
                {
                    return this.masterAgreement; 
                }
                else if (this.masterAgreementIDRef != null)
                {
                    masterAgreement = IDManager.getID(masterAgreementIDRef) as MasterAgreement;
                    return this.masterAgreement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.masterAgreement != value)
                {
                    this.masterAgreement = value;
                }
            }
        }
        #endregion
        
        public string MasterAgreementIDRef { get; set; }
        #region MasterConfirmation
        private MasterConfirmation masterConfirmation;
        public MasterConfirmation MasterConfirmation
        {
            get
            {
                if (this.masterConfirmation != null)
                {
                    return this.masterConfirmation; 
                }
                else if (this.masterConfirmationIDRef != null)
                {
                    masterConfirmation = IDManager.getID(masterConfirmationIDRef) as MasterConfirmation;
                    return this.masterConfirmation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.masterConfirmation != value)
                {
                    this.masterConfirmation = value;
                }
            }
        }
        #endregion
        
        public string MasterConfirmationIDRef { get; set; }
        #region BrokerConfirmation
        private BrokerConfirmation brokerConfirmation;
        public BrokerConfirmation BrokerConfirmation
        {
            get
            {
                if (this.brokerConfirmation != null)
                {
                    return this.brokerConfirmation; 
                }
                else if (this.brokerConfirmationIDRef != null)
                {
                    brokerConfirmation = IDManager.getID(brokerConfirmationIDRef) as BrokerConfirmation;
                    return this.brokerConfirmation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.brokerConfirmation != value)
                {
                    this.brokerConfirmation = value;
                }
            }
        }
        #endregion
        
        public string BrokerConfirmationIDRef { get; set; }
        #region ContractualDefinitions
        private List<ContractualDefinitions> contractualDefinitions;
        public List<ContractualDefinitions> ContractualDefinitions
        {
            get
            {
                if (this.contractualDefinitions != null)
                {
                    return this.contractualDefinitions; 
                }
                else if (this.contractualDefinitionsIDRef != null)
                {
                    contractualDefinitions = IDManager.getID(contractualDefinitionsIDRef) as List<ContractualDefinitions>;
                    return this.contractualDefinitions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.contractualDefinitions != value)
                {
                    this.contractualDefinitions = value;
                }
            }
        }
        #endregion
        
        public string ContractualDefinitionsIDRef { get; set; }
        #region ContractualTermsSupplement
        private List<ContractualTermsSupplement> contractualTermsSupplement;
        public List<ContractualTermsSupplement> ContractualTermsSupplement
        {
            get
            {
                if (this.contractualTermsSupplement != null)
                {
                    return this.contractualTermsSupplement; 
                }
                else if (this.contractualTermsSupplementIDRef != null)
                {
                    contractualTermsSupplement = IDManager.getID(contractualTermsSupplementIDRef) as List<ContractualTermsSupplement>;
                    return this.contractualTermsSupplement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.contractualTermsSupplement != value)
                {
                    this.contractualTermsSupplement = value;
                }
            }
        }
        #endregion
        
        public string ContractualTermsSupplementIDRef { get; set; }
        #region ContractualMatrix
        private List<ContractualMatrix> contractualMatrix;
        public List<ContractualMatrix> ContractualMatrix
        {
            get
            {
                if (this.contractualMatrix != null)
                {
                    return this.contractualMatrix; 
                }
                else if (this.contractualMatrixIDRef != null)
                {
                    contractualMatrix = IDManager.getID(contractualMatrixIDRef) as List<ContractualMatrix>;
                    return this.contractualMatrix; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.contractualMatrix != value)
                {
                    this.contractualMatrix = value;
                }
            }
        }
        #endregion
        
        public string ContractualMatrixIDRef { get; set; }
        #region CreditSupportAgreement
        private CreditSupportAgreement creditSupportAgreement;
        public CreditSupportAgreement CreditSupportAgreement
        {
            get
            {
                if (this.creditSupportAgreement != null)
                {
                    return this.creditSupportAgreement; 
                }
                else if (this.creditSupportAgreementIDRef != null)
                {
                    creditSupportAgreement = IDManager.getID(creditSupportAgreementIDRef) as CreditSupportAgreement;
                    return this.creditSupportAgreement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditSupportAgreement != value)
                {
                    this.creditSupportAgreement = value;
                }
            }
        }
        #endregion
        
        public string CreditSupportAgreementIDRef { get; set; }
        #region Attachment
        private List<Resource> attachment;
        public List<Resource> Attachment
        {
            get
            {
                if (this.attachment != null)
                {
                    return this.attachment; 
                }
                else if (this.attachmentIDRef != null)
                {
                    attachment = IDManager.getID(attachmentIDRef) as List<Resource>;
                    return this.attachment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.attachment != value)
                {
                    this.attachment = value;
                }
            }
        }
        #endregion
        
        public string ResourceIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

