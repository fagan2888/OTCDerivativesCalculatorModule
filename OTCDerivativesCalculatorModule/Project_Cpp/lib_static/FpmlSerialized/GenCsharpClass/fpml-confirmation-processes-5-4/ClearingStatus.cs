using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ClearingStatus
    {
        public ClearingStatus(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList clearingStatusItemNodeList = xmlNode.SelectNodes("clearingStatusItem");
            if (clearingStatusItemNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in clearingStatusItemNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        clearingStatusItemIDRef = item.Attributes["id"].Name;
                        ClearingStatusItem ob = ClearingStatusItem();
                        IDManager.SetID(clearingStatusItemIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        clearingStatusItemIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        clearingStatusItem = new ClearingStatusItem(item);
                    }
                }
            }
            
        
            XmlNodeList partyNodeList = xmlNode.SelectNodes("party");
            
            foreach (XmlNode item in partyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyIDRef = item.Attributes["id"].Name;
                        List<Party> ob = new List<Party>();
                        ob.Add(new Party(item));
                        IDManager.SetID(partyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    party.Add(new Party(item));
                    }
                }
            }
            
        
            XmlNodeList accountNodeList = xmlNode.SelectNodes("account");
            
            foreach (XmlNode item in accountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accountIDRef = item.Attributes["id"].Name;
                        List<Account> ob = new List<Account>();
                        ob.Add(new Account(item));
                        IDManager.SetID(accountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    account.Add(new Account(item));
                    }
                }
            }
            
        
        }
        
    
        #region ClearingStatusItem
        private ClearingStatusItem clearingStatusItem;
        public ClearingStatusItem ClearingStatusItem
        {
            get
            {
                if (this.clearingStatusItem != null)
                {
                    return this.clearingStatusItem; 
                }
                else if (this.clearingStatusItemIDRef != null)
                {
                    clearingStatusItem = IDManager.getID(clearingStatusItemIDRef) as ClearingStatusItem;
                    return this.clearingStatusItem; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.clearingStatusItem != value)
                {
                    this.clearingStatusItem = value;
                }
            }
        }
        #endregion
        
        public string ClearingStatusItemIDRef { get; set; }
        #region Party
        private List<Party> party;
        public List<Party> Party
        {
            get
            {
                if (this.party != null)
                {
                    return this.party; 
                }
                else if (this.partyIDRef != null)
                {
                    party = IDManager.getID(partyIDRef) as List<Party>;
                    return this.party; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.party != value)
                {
                    this.party = value;
                }
            }
        }
        #endregion
        
        public string PartyIDRef { get; set; }
        #region Account
        private List<Account> account;
        public List<Account> Account
        {
            get
            {
                if (this.account != null)
                {
                    return this.account; 
                }
                else if (this.accountIDRef != null)
                {
                    account = IDManager.getID(accountIDRef) as List<Account>;
                    return this.account; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.account != value)
                {
                    this.account = value;
                }
            }
        }
        #endregion
        
        public string AccountIDRef { get; set; }
        
    
        
    
    }
    
}

