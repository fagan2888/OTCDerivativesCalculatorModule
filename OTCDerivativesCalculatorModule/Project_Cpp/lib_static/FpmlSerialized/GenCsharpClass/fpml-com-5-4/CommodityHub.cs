using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityHub
    {
        public CommodityHub(XmlNode xmlNode)
        {
            XmlNodeList partyReferenceNodeList = xmlNode.SelectNodes("partyReference");
            if (partyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in partyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(partyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        partyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList accountReferenceNodeList = xmlNode.SelectNodes("accountReference");
            if (accountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in accountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(accountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        accountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList hubCodeNodeList = xmlNode.SelectNodes("hubCode");
            if (hubCodeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in hubCodeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        hubCodeIDRef = item.Attributes["id"].Name;
                        CommodityHubCode ob = CommodityHubCode();
                        IDManager.SetID(hubCodeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        hubCodeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        hubCode = new CommodityHubCode(item);
                    }
                }
            }
            
        
        }
        
    
        #region PartyReference
        private PartyReference partyReference;
        public PartyReference PartyReference
        {
            get
            {
                if (this.partyReference != null)
                {
                    return this.partyReference; 
                }
                else if (this.partyReferenceIDRef != null)
                {
                    partyReference = IDManager.getID(partyReferenceIDRef) as PartyReference;
                    return this.partyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyReference != value)
                {
                    this.partyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region AccountReference
        private AccountReference accountReference;
        public AccountReference AccountReference
        {
            get
            {
                if (this.accountReference != null)
                {
                    return this.accountReference; 
                }
                else if (this.accountReferenceIDRef != null)
                {
                    accountReference = IDManager.getID(accountReferenceIDRef) as AccountReference;
                    return this.accountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.accountReference != value)
                {
                    this.accountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region HubCode
        private CommodityHubCode hubCode;
        public CommodityHubCode HubCode
        {
            get
            {
                if (this.hubCode != null)
                {
                    return this.hubCode; 
                }
                else if (this.hubCodeIDRef != null)
                {
                    hubCode = IDManager.getID(hubCodeIDRef) as CommodityHubCode;
                    return this.hubCode; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.hubCode != value)
                {
                    this.hubCode = value;
                }
            }
        }
        #endregion
        
        public string CommodityHubCodeIDRef { get; set; }
        
    
        
    
    }
    
}

