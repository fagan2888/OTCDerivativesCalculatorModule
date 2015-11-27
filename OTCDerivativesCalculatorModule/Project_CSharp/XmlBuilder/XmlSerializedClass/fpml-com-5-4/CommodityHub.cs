using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityHub : ISerialized
    {
        public CommodityHub(XmlNode xmlNode)
        {
            XmlNode partyReferenceNode = xmlNode.SelectSingleNode("partyReference");
            
            if (partyReferenceNode != null)
            {
                if (partyReferenceNode.Attributes["href"] != null || partyReferenceNode.Attributes["id"] != null) 
                {
                    if (partyReferenceNode.Attributes["id"] != null) 
                    {
                        partyReferenceIDRef_ = partyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(partyReferenceNode);
                        IDManager.SetID(partyReferenceIDRef_, ob);
                    }
                    else if (partyReferenceNode.Attributes["href"] != null)
                    {
                        partyReferenceIDRef_ = partyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partyReference_ = new PartyReference(partyReferenceNode);
                    }
                }
                else
                {
                    partyReference_ = new PartyReference(partyReferenceNode);
                }
            }
            
        
            XmlNode accountReferenceNode = xmlNode.SelectSingleNode("accountReference");
            
            if (accountReferenceNode != null)
            {
                if (accountReferenceNode.Attributes["href"] != null || accountReferenceNode.Attributes["id"] != null) 
                {
                    if (accountReferenceNode.Attributes["id"] != null) 
                    {
                        accountReferenceIDRef_ = accountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(accountReferenceNode);
                        IDManager.SetID(accountReferenceIDRef_, ob);
                    }
                    else if (accountReferenceNode.Attributes["href"] != null)
                    {
                        accountReferenceIDRef_ = accountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        accountReference_ = new AccountReference(accountReferenceNode);
                    }
                }
                else
                {
                    accountReference_ = new AccountReference(accountReferenceNode);
                }
            }
            
        
            XmlNode hubCodeNode = xmlNode.SelectSingleNode("hubCode");
            
            if (hubCodeNode != null)
            {
                if (hubCodeNode.Attributes["href"] != null || hubCodeNode.Attributes["id"] != null) 
                {
                    if (hubCodeNode.Attributes["id"] != null) 
                    {
                        hubCodeIDRef_ = hubCodeNode.Attributes["id"].Value;
                        CommodityHubCode ob = new CommodityHubCode(hubCodeNode);
                        IDManager.SetID(hubCodeIDRef_, ob);
                    }
                    else if (hubCodeNode.Attributes["href"] != null)
                    {
                        hubCodeIDRef_ = hubCodeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        hubCode_ = new CommodityHubCode(hubCodeNode);
                    }
                }
                else
                {
                    hubCode_ = new CommodityHubCode(hubCodeNode);
                }
            }
            
        
        }
        
    
        #region PartyReference_
        private PartyReference partyReference_;
        public PartyReference PartyReference_
        {
            get
            {
                if (this.partyReference_ != null)
                {
                    return this.partyReference_; 
                }
                else if (this.partyReferenceIDRef_ != null)
                {
                    partyReference_ = IDManager.getID(partyReferenceIDRef_) as PartyReference;
                    return this.partyReference_; 
                }
                else
                {
                      return this.partyReference_; 
                }
            }
            set
            {
                if (this.partyReference_ != value)
                {
                    this.partyReference_ = value;
                }
            }
        }
        #endregion
        
        public string partyReferenceIDRef_ { get; set; }
        #region AccountReference_
        private AccountReference accountReference_;
        public AccountReference AccountReference_
        {
            get
            {
                if (this.accountReference_ != null)
                {
                    return this.accountReference_; 
                }
                else if (this.accountReferenceIDRef_ != null)
                {
                    accountReference_ = IDManager.getID(accountReferenceIDRef_) as AccountReference;
                    return this.accountReference_; 
                }
                else
                {
                      return this.accountReference_; 
                }
            }
            set
            {
                if (this.accountReference_ != value)
                {
                    this.accountReference_ = value;
                }
            }
        }
        #endregion
        
        public string accountReferenceIDRef_ { get; set; }
        #region HubCode_
        private CommodityHubCode hubCode_;
        public CommodityHubCode HubCode_
        {
            get
            {
                if (this.hubCode_ != null)
                {
                    return this.hubCode_; 
                }
                else if (this.hubCodeIDRef_ != null)
                {
                    hubCode_ = IDManager.getID(hubCodeIDRef_) as CommodityHubCode;
                    return this.hubCode_; 
                }
                else
                {
                      return this.hubCode_; 
                }
            }
            set
            {
                if (this.hubCode_ != value)
                {
                    this.hubCode_ = value;
                }
            }
        }
        #endregion
        
        public string hubCodeIDRef_ { get; set; }
        
    
        
    
    }
    
}

