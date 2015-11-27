using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EndUserExceptionDeclaration
    {
        public EndUserExceptionDeclaration(XmlNode xmlNode)
        {
            XmlNodeList creditDocumentNodeList = xmlNode.SelectNodes("creditDocument");
            
            foreach (XmlNode item in creditDocumentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditDocumentIDRef = item.Attributes["id"].Name;
                        List<CreditDocument> ob = new List<CreditDocument>();
                        ob.Add(new CreditDocument(item));
                        IDManager.SetID(creditDocumentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditDocumentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    creditDocument.Add(new CreditDocument(item));
                    }
                }
            }
            
        
            XmlNodeList organizationCharacteristicNodeList = xmlNode.SelectNodes("organizationCharacteristic");
            
            foreach (XmlNode item in organizationCharacteristicNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        organizationCharacteristicIDRef = item.Attributes["id"].Name;
                        List<OrganizationCharacteristic> ob = new List<OrganizationCharacteristic>();
                        ob.Add(new OrganizationCharacteristic(item));
                        IDManager.SetID(organizationCharacteristicIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        organizationCharacteristicIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    organizationCharacteristic.Add(new OrganizationCharacteristic(item));
                    }
                }
            }
            
        
            XmlNodeList transactionCharacteristicNodeList = xmlNode.SelectNodes("transactionCharacteristic");
            
            foreach (XmlNode item in transactionCharacteristicNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        transactionCharacteristicIDRef = item.Attributes["id"].Name;
                        List<TransactionCharacteristic> ob = new List<TransactionCharacteristic>();
                        ob.Add(new TransactionCharacteristic(item));
                        IDManager.SetID(transactionCharacteristicIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        transactionCharacteristicIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    transactionCharacteristic.Add(new TransactionCharacteristic(item));
                    }
                }
            }
            
        
            XmlNodeList supervisorRegistrationNodeList = xmlNode.SelectNodes("supervisorRegistration");
            
            foreach (XmlNode item in supervisorRegistrationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        supervisorRegistrationIDRef = item.Attributes["id"].Name;
                        List<SupervisorRegistration> ob = new List<SupervisorRegistration>();
                        ob.Add(new SupervisorRegistration(item));
                        IDManager.SetID(supervisorRegistrationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        supervisorRegistrationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    supervisorRegistration.Add(new SupervisorRegistration(item));
                    }
                }
            }
            
        
        }
        
    
        #region CreditDocument
        private List<CreditDocument> creditDocument;
        public List<CreditDocument> CreditDocument
        {
            get
            {
                if (this.creditDocument != null)
                {
                    return this.creditDocument; 
                }
                else if (this.creditDocumentIDRef != null)
                {
                    creditDocument = IDManager.getID(creditDocumentIDRef) as List<CreditDocument>;
                    return this.creditDocument; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditDocument != value)
                {
                    this.creditDocument = value;
                }
            }
        }
        #endregion
        
        public string CreditDocumentIDRef { get; set; }
        #region OrganizationCharacteristic
        private List<OrganizationCharacteristic> organizationCharacteristic;
        public List<OrganizationCharacteristic> OrganizationCharacteristic
        {
            get
            {
                if (this.organizationCharacteristic != null)
                {
                    return this.organizationCharacteristic; 
                }
                else if (this.organizationCharacteristicIDRef != null)
                {
                    organizationCharacteristic = IDManager.getID(organizationCharacteristicIDRef) as List<OrganizationCharacteristic>;
                    return this.organizationCharacteristic; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.organizationCharacteristic != value)
                {
                    this.organizationCharacteristic = value;
                }
            }
        }
        #endregion
        
        public string OrganizationCharacteristicIDRef { get; set; }
        #region TransactionCharacteristic
        private List<TransactionCharacteristic> transactionCharacteristic;
        public List<TransactionCharacteristic> TransactionCharacteristic
        {
            get
            {
                if (this.transactionCharacteristic != null)
                {
                    return this.transactionCharacteristic; 
                }
                else if (this.transactionCharacteristicIDRef != null)
                {
                    transactionCharacteristic = IDManager.getID(transactionCharacteristicIDRef) as List<TransactionCharacteristic>;
                    return this.transactionCharacteristic; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.transactionCharacteristic != value)
                {
                    this.transactionCharacteristic = value;
                }
            }
        }
        #endregion
        
        public string TransactionCharacteristicIDRef { get; set; }
        #region SupervisorRegistration
        private List<SupervisorRegistration> supervisorRegistration;
        public List<SupervisorRegistration> SupervisorRegistration
        {
            get
            {
                if (this.supervisorRegistration != null)
                {
                    return this.supervisorRegistration; 
                }
                else if (this.supervisorRegistrationIDRef != null)
                {
                    supervisorRegistration = IDManager.getID(supervisorRegistrationIDRef) as List<SupervisorRegistration>;
                    return this.supervisorRegistration; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.supervisorRegistration != value)
                {
                    this.supervisorRegistration = value;
                }
            }
        }
        #endregion
        
        public string SupervisorRegistrationIDRef { get; set; }
        
    
        
    
    }
    
}

