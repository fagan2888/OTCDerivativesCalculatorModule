using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Account : ISerialized
    {
        public Account(XmlNode xmlNode)
        {
            XmlNodeList accountIdNodeList = xmlNode.SelectNodes("accountId");
            
            if (accountIdNodeList != null)
            {
                this.accountId_ = new List<AccountId>();
                foreach (XmlNode item in accountIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            accountIdIDRef_ = item.Attributes["id"].Value;
                            accountId_.Add(new AccountId(item));
                            IDManager.SetID(accountIdIDRef_, accountId_[accountId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            accountIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        accountId_.Add(new AccountId(item));
                        }
                    }
                    else
                    {
                        accountId_.Add(new AccountId(item));
                    }
                }
            }
            
        
            XmlNode accountNameNode = xmlNode.SelectSingleNode("accountName");
            
            if (accountNameNode != null)
            {
                if (accountNameNode.Attributes["href"] != null || accountNameNode.Attributes["id"] != null) 
                {
                    if (accountNameNode.Attributes["id"] != null) 
                    {
                        accountNameIDRef_ = accountNameNode.Attributes["id"].Value;
                        AccountName ob = new AccountName(accountNameNode);
                        IDManager.SetID(accountNameIDRef_, ob);
                    }
                    else if (accountNameNode.Attributes["href"] != null)
                    {
                        accountNameIDRef_ = accountNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        accountName_ = new AccountName(accountNameNode);
                    }
                }
                else
                {
                    accountName_ = new AccountName(accountNameNode);
                }
            }
            
        
            XmlNode accountTypeNode = xmlNode.SelectSingleNode("accountType");
            
            if (accountTypeNode != null)
            {
                if (accountTypeNode.Attributes["href"] != null || accountTypeNode.Attributes["id"] != null) 
                {
                    if (accountTypeNode.Attributes["id"] != null) 
                    {
                        accountTypeIDRef_ = accountTypeNode.Attributes["id"].Value;
                        AccountType ob = new AccountType(accountTypeNode);
                        IDManager.SetID(accountTypeIDRef_, ob);
                    }
                    else if (accountTypeNode.Attributes["href"] != null)
                    {
                        accountTypeIDRef_ = accountTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        accountType_ = new AccountType(accountTypeNode);
                    }
                }
                else
                {
                    accountType_ = new AccountType(accountTypeNode);
                }
            }
            
        
            XmlNode accountBeneficiaryNode = xmlNode.SelectSingleNode("accountBeneficiary");
            
            if (accountBeneficiaryNode != null)
            {
                if (accountBeneficiaryNode.Attributes["href"] != null || accountBeneficiaryNode.Attributes["id"] != null) 
                {
                    if (accountBeneficiaryNode.Attributes["id"] != null) 
                    {
                        accountBeneficiaryIDRef_ = accountBeneficiaryNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(accountBeneficiaryNode);
                        IDManager.SetID(accountBeneficiaryIDRef_, ob);
                    }
                    else if (accountBeneficiaryNode.Attributes["href"] != null)
                    {
                        accountBeneficiaryIDRef_ = accountBeneficiaryNode.Attributes["href"].Value;
                    }
                    else
                    {
                        accountBeneficiary_ = new PartyReference(accountBeneficiaryNode);
                    }
                }
                else
                {
                    accountBeneficiary_ = new PartyReference(accountBeneficiaryNode);
                }
            }
            
        
            XmlNode servicingPartyNode = xmlNode.SelectSingleNode("servicingParty");
            
            if (servicingPartyNode != null)
            {
                if (servicingPartyNode.Attributes["href"] != null || servicingPartyNode.Attributes["id"] != null) 
                {
                    if (servicingPartyNode.Attributes["id"] != null) 
                    {
                        servicingPartyIDRef_ = servicingPartyNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(servicingPartyNode);
                        IDManager.SetID(servicingPartyIDRef_, ob);
                    }
                    else if (servicingPartyNode.Attributes["href"] != null)
                    {
                        servicingPartyIDRef_ = servicingPartyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        servicingParty_ = new PartyReference(servicingPartyNode);
                    }
                }
                else
                {
                    servicingParty_ = new PartyReference(servicingPartyNode);
                }
            }
            
        
        }
        
    
        #region AccountId_
        private List<AccountId> accountId_;
        public List<AccountId> AccountId_
        {
            get
            {
                if (this.accountId_ != null)
                {
                    return this.accountId_; 
                }
                else if (this.accountIdIDRef_ != null)
                {
                    return this.accountId_; 
                }
                else
                {
                      return this.accountId_; 
                }
            }
            set
            {
                if (this.accountId_ != value)
                {
                    this.accountId_ = value;
                }
            }
        }
        #endregion
        
        public string accountIdIDRef_ { get; set; }
        #region AccountName_
        private AccountName accountName_;
        public AccountName AccountName_
        {
            get
            {
                if (this.accountName_ != null)
                {
                    return this.accountName_; 
                }
                else if (this.accountNameIDRef_ != null)
                {
                    accountName_ = IDManager.getID(accountNameIDRef_) as AccountName;
                    return this.accountName_; 
                }
                else
                {
                      return this.accountName_; 
                }
            }
            set
            {
                if (this.accountName_ != value)
                {
                    this.accountName_ = value;
                }
            }
        }
        #endregion
        
        public string accountNameIDRef_ { get; set; }
        #region AccountType_
        private AccountType accountType_;
        public AccountType AccountType_
        {
            get
            {
                if (this.accountType_ != null)
                {
                    return this.accountType_; 
                }
                else if (this.accountTypeIDRef_ != null)
                {
                    accountType_ = IDManager.getID(accountTypeIDRef_) as AccountType;
                    return this.accountType_; 
                }
                else
                {
                      return this.accountType_; 
                }
            }
            set
            {
                if (this.accountType_ != value)
                {
                    this.accountType_ = value;
                }
            }
        }
        #endregion
        
        public string accountTypeIDRef_ { get; set; }
        #region AccountBeneficiary_
        private PartyReference accountBeneficiary_;
        public PartyReference AccountBeneficiary_
        {
            get
            {
                if (this.accountBeneficiary_ != null)
                {
                    return this.accountBeneficiary_; 
                }
                else if (this.accountBeneficiaryIDRef_ != null)
                {
                    accountBeneficiary_ = IDManager.getID(accountBeneficiaryIDRef_) as PartyReference;
                    return this.accountBeneficiary_; 
                }
                else
                {
                      return this.accountBeneficiary_; 
                }
            }
            set
            {
                if (this.accountBeneficiary_ != value)
                {
                    this.accountBeneficiary_ = value;
                }
            }
        }
        #endregion
        
        public string accountBeneficiaryIDRef_ { get; set; }
        #region ServicingParty_
        private PartyReference servicingParty_;
        public PartyReference ServicingParty_
        {
            get
            {
                if (this.servicingParty_ != null)
                {
                    return this.servicingParty_; 
                }
                else if (this.servicingPartyIDRef_ != null)
                {
                    servicingParty_ = IDManager.getID(servicingPartyIDRef_) as PartyReference;
                    return this.servicingParty_; 
                }
                else
                {
                      return this.servicingParty_; 
                }
            }
            set
            {
                if (this.servicingParty_ != value)
                {
                    this.servicingParty_ = value;
                }
            }
        }
        #endregion
        
        public string servicingPartyIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

