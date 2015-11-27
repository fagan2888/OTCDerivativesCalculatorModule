using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EndUserExceptionDeclaration : ISerialized
    {
        public EndUserExceptionDeclaration(XmlNode xmlNode)
        {
            XmlNodeList creditDocumentNodeList = xmlNode.SelectNodes("creditDocument");
            
            if (creditDocumentNodeList != null)
            {
                this.creditDocument_ = new List<CreditDocument>();
                foreach (XmlNode item in creditDocumentNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            creditDocumentIDRef_ = item.Attributes["id"].Value;
                            creditDocument_.Add(new CreditDocument(item));
                            IDManager.SetID(creditDocumentIDRef_, creditDocument_[creditDocument_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            creditDocumentIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        creditDocument_.Add(new CreditDocument(item));
                        }
                    }
                    else
                    {
                        creditDocument_.Add(new CreditDocument(item));
                    }
                }
            }
            
        
            XmlNodeList organizationCharacteristicNodeList = xmlNode.SelectNodes("organizationCharacteristic");
            
            if (organizationCharacteristicNodeList != null)
            {
                this.organizationCharacteristic_ = new List<OrganizationCharacteristic>();
                foreach (XmlNode item in organizationCharacteristicNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            organizationCharacteristicIDRef_ = item.Attributes["id"].Value;
                            organizationCharacteristic_.Add(new OrganizationCharacteristic(item));
                            IDManager.SetID(organizationCharacteristicIDRef_, organizationCharacteristic_[organizationCharacteristic_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            organizationCharacteristicIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        organizationCharacteristic_.Add(new OrganizationCharacteristic(item));
                        }
                    }
                    else
                    {
                        organizationCharacteristic_.Add(new OrganizationCharacteristic(item));
                    }
                }
            }
            
        
            XmlNodeList transactionCharacteristicNodeList = xmlNode.SelectNodes("transactionCharacteristic");
            
            if (transactionCharacteristicNodeList != null)
            {
                this.transactionCharacteristic_ = new List<TransactionCharacteristic>();
                foreach (XmlNode item in transactionCharacteristicNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            transactionCharacteristicIDRef_ = item.Attributes["id"].Value;
                            transactionCharacteristic_.Add(new TransactionCharacteristic(item));
                            IDManager.SetID(transactionCharacteristicIDRef_, transactionCharacteristic_[transactionCharacteristic_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            transactionCharacteristicIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        transactionCharacteristic_.Add(new TransactionCharacteristic(item));
                        }
                    }
                    else
                    {
                        transactionCharacteristic_.Add(new TransactionCharacteristic(item));
                    }
                }
            }
            
        
            XmlNodeList supervisorRegistrationNodeList = xmlNode.SelectNodes("supervisorRegistration");
            
            if (supervisorRegistrationNodeList != null)
            {
                this.supervisorRegistration_ = new List<SupervisorRegistration>();
                foreach (XmlNode item in supervisorRegistrationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            supervisorRegistrationIDRef_ = item.Attributes["id"].Value;
                            supervisorRegistration_.Add(new SupervisorRegistration(item));
                            IDManager.SetID(supervisorRegistrationIDRef_, supervisorRegistration_[supervisorRegistration_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            supervisorRegistrationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        supervisorRegistration_.Add(new SupervisorRegistration(item));
                        }
                    }
                    else
                    {
                        supervisorRegistration_.Add(new SupervisorRegistration(item));
                    }
                }
            }
            
        
        }
        
    
        #region CreditDocument_
        private List<CreditDocument> creditDocument_;
        public List<CreditDocument> CreditDocument_
        {
            get
            {
                if (this.creditDocument_ != null)
                {
                    return this.creditDocument_; 
                }
                else if (this.creditDocumentIDRef_ != null)
                {
                    return this.creditDocument_; 
                }
                else
                {
                      return this.creditDocument_; 
                }
            }
            set
            {
                if (this.creditDocument_ != value)
                {
                    this.creditDocument_ = value;
                }
            }
        }
        #endregion
        
        public string creditDocumentIDRef_ { get; set; }
        #region OrganizationCharacteristic_
        private List<OrganizationCharacteristic> organizationCharacteristic_;
        public List<OrganizationCharacteristic> OrganizationCharacteristic_
        {
            get
            {
                if (this.organizationCharacteristic_ != null)
                {
                    return this.organizationCharacteristic_; 
                }
                else if (this.organizationCharacteristicIDRef_ != null)
                {
                    return this.organizationCharacteristic_; 
                }
                else
                {
                      return this.organizationCharacteristic_; 
                }
            }
            set
            {
                if (this.organizationCharacteristic_ != value)
                {
                    this.organizationCharacteristic_ = value;
                }
            }
        }
        #endregion
        
        public string organizationCharacteristicIDRef_ { get; set; }
        #region TransactionCharacteristic_
        private List<TransactionCharacteristic> transactionCharacteristic_;
        public List<TransactionCharacteristic> TransactionCharacteristic_
        {
            get
            {
                if (this.transactionCharacteristic_ != null)
                {
                    return this.transactionCharacteristic_; 
                }
                else if (this.transactionCharacteristicIDRef_ != null)
                {
                    return this.transactionCharacteristic_; 
                }
                else
                {
                      return this.transactionCharacteristic_; 
                }
            }
            set
            {
                if (this.transactionCharacteristic_ != value)
                {
                    this.transactionCharacteristic_ = value;
                }
            }
        }
        #endregion
        
        public string transactionCharacteristicIDRef_ { get; set; }
        #region SupervisorRegistration_
        private List<SupervisorRegistration> supervisorRegistration_;
        public List<SupervisorRegistration> SupervisorRegistration_
        {
            get
            {
                if (this.supervisorRegistration_ != null)
                {
                    return this.supervisorRegistration_; 
                }
                else if (this.supervisorRegistrationIDRef_ != null)
                {
                    return this.supervisorRegistration_; 
                }
                else
                {
                      return this.supervisorRegistration_; 
                }
            }
            set
            {
                if (this.supervisorRegistration_ != value)
                {
                    this.supervisorRegistration_ = value;
                }
            }
        }
        #endregion
        
        public string supervisorRegistrationIDRef_ { get; set; }
        
    
        
    
    }
    
}

