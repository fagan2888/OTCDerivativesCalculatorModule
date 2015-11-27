using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Account
    {
        public Account(XmlNode xmlNode)
        {
            XmlNodeList accountIdNodeList = xmlNode.SelectNodes("accountId");
            
            foreach (XmlNode item in accountIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accountIdIDRef = item.Attributes["id"].Name;
                        List<AccountId> ob = new List<AccountId>();
                        ob.Add(new AccountId(item));
                        IDManager.SetID(accountIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accountIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    accountId.Add(new AccountId(item));
                    }
                }
            }
            
        
            XmlNodeList accountNameNodeList = xmlNode.SelectNodes("accountName");
            if (accountNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in accountNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accountNameIDRef = item.Attributes["id"].Name;
                        AccountName ob = AccountName();
                        IDManager.SetID(accountNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accountNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        accountName = new AccountName(item);
                    }
                }
            }
            
        
            XmlNodeList accountTypeNodeList = xmlNode.SelectNodes("accountType");
            if (accountTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in accountTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accountTypeIDRef = item.Attributes["id"].Name;
                        AccountType ob = AccountType();
                        IDManager.SetID(accountTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accountTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        accountType = new AccountType(item);
                    }
                }
            }
            
        
            XmlNodeList accountBeneficiaryNodeList = xmlNode.SelectNodes("accountBeneficiary");
            if (accountBeneficiaryNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in accountBeneficiaryNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accountBeneficiaryIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(accountBeneficiaryIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accountBeneficiaryIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        accountBeneficiary = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList servicingPartyNodeList = xmlNode.SelectNodes("servicingParty");
            if (servicingPartyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in servicingPartyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        servicingPartyIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(servicingPartyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        servicingPartyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        servicingParty = new PartyReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region AccountId
        private List<AccountId> accountId;
        public List<AccountId> AccountId
        {
            get
            {
                if (this.accountId != null)
                {
                    return this.accountId; 
                }
                else if (this.accountIdIDRef != null)
                {
                    accountId = IDManager.getID(accountIdIDRef) as List<AccountId>;
                    return this.accountId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.accountId != value)
                {
                    this.accountId = value;
                }
            }
        }
        #endregion
        
        public string AccountIdIDRef { get; set; }
        #region AccountName
        private AccountName accountName;
        public AccountName AccountName
        {
            get
            {
                if (this.accountName != null)
                {
                    return this.accountName; 
                }
                else if (this.accountNameIDRef != null)
                {
                    accountName = IDManager.getID(accountNameIDRef) as AccountName;
                    return this.accountName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.accountName != value)
                {
                    this.accountName = value;
                }
            }
        }
        #endregion
        
        public string AccountNameIDRef { get; set; }
        #region AccountType
        private AccountType accountType;
        public AccountType AccountType
        {
            get
            {
                if (this.accountType != null)
                {
                    return this.accountType; 
                }
                else if (this.accountTypeIDRef != null)
                {
                    accountType = IDManager.getID(accountTypeIDRef) as AccountType;
                    return this.accountType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.accountType != value)
                {
                    this.accountType = value;
                }
            }
        }
        #endregion
        
        public string AccountTypeIDRef { get; set; }
        #region AccountBeneficiary
        private PartyReference accountBeneficiary;
        public PartyReference AccountBeneficiary
        {
            get
            {
                if (this.accountBeneficiary != null)
                {
                    return this.accountBeneficiary; 
                }
                else if (this.accountBeneficiaryIDRef != null)
                {
                    accountBeneficiary = IDManager.getID(accountBeneficiaryIDRef) as PartyReference;
                    return this.accountBeneficiary; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.accountBeneficiary != value)
                {
                    this.accountBeneficiary = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region ServicingParty
        private PartyReference servicingParty;
        public PartyReference ServicingParty
        {
            get
            {
                if (this.servicingParty != null)
                {
                    return this.servicingParty; 
                }
                else if (this.servicingPartyIDRef != null)
                {
                    servicingParty = IDManager.getID(servicingPartyIDRef) as PartyReference;
                    return this.servicingParty; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.servicingParty != value)
                {
                    this.servicingParty = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

