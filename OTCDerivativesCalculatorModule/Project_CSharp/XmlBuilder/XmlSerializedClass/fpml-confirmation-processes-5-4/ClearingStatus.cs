using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ClearingStatus : NotificationMessage
    {
        public ClearingStatus(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode clearingStatusItemNode = xmlNode.SelectSingleNode("clearingStatusItem");
            
            if (clearingStatusItemNode != null)
            {
                if (clearingStatusItemNode.Attributes["href"] != null || clearingStatusItemNode.Attributes["id"] != null) 
                {
                    if (clearingStatusItemNode.Attributes["id"] != null) 
                    {
                        clearingStatusItemIDRef_ = clearingStatusItemNode.Attributes["id"].Value;
                        ClearingStatusItem ob = new ClearingStatusItem(clearingStatusItemNode);
                        IDManager.SetID(clearingStatusItemIDRef_, ob);
                    }
                    else if (clearingStatusItemNode.Attributes["href"] != null)
                    {
                        clearingStatusItemIDRef_ = clearingStatusItemNode.Attributes["href"].Value;
                    }
                    else
                    {
                        clearingStatusItem_ = new ClearingStatusItem(clearingStatusItemNode);
                    }
                }
                else
                {
                    clearingStatusItem_ = new ClearingStatusItem(clearingStatusItemNode);
                }
            }
            
        
            XmlNodeList partyNodeList = xmlNode.SelectNodes("party");
            
            if (partyNodeList != null)
            {
                this.party_ = new List<Party>();
                foreach (XmlNode item in partyNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            partyIDRef_ = item.Attributes["id"].Value;
                            party_.Add(new Party(item));
                            IDManager.SetID(partyIDRef_, party_[party_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            partyIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        party_.Add(new Party(item));
                        }
                    }
                    else
                    {
                        party_.Add(new Party(item));
                    }
                }
            }
            
        
            XmlNodeList accountNodeList = xmlNode.SelectNodes("account");
            
            if (accountNodeList != null)
            {
                this.account_ = new List<Account>();
                foreach (XmlNode item in accountNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            accountIDRef_ = item.Attributes["id"].Value;
                            account_.Add(new Account(item));
                            IDManager.SetID(accountIDRef_, account_[account_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            accountIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        account_.Add(new Account(item));
                        }
                    }
                    else
                    {
                        account_.Add(new Account(item));
                    }
                }
            }
            
        
        }
        
    
        #region ClearingStatusItem_
        private ClearingStatusItem clearingStatusItem_;
        public ClearingStatusItem ClearingStatusItem_
        {
            get
            {
                if (this.clearingStatusItem_ != null)
                {
                    return this.clearingStatusItem_; 
                }
                else if (this.clearingStatusItemIDRef_ != null)
                {
                    clearingStatusItem_ = IDManager.getID(clearingStatusItemIDRef_) as ClearingStatusItem;
                    return this.clearingStatusItem_; 
                }
                else
                {
                      return this.clearingStatusItem_; 
                }
            }
            set
            {
                if (this.clearingStatusItem_ != value)
                {
                    this.clearingStatusItem_ = value;
                }
            }
        }
        #endregion
        
        public string clearingStatusItemIDRef_ { get; set; }
        #region Party_
        private List<Party> party_;
        public List<Party> Party_
        {
            get
            {
                if (this.party_ != null)
                {
                    return this.party_; 
                }
                else if (this.partyIDRef_ != null)
                {
                    return this.party_; 
                }
                else
                {
                      return this.party_; 
                }
            }
            set
            {
                if (this.party_ != value)
                {
                    this.party_ = value;
                }
            }
        }
        #endregion
        
        public string partyIDRef_ { get; set; }
        #region Account_
        private List<Account> account_;
        public List<Account> Account_
        {
            get
            {
                if (this.account_ != null)
                {
                    return this.account_; 
                }
                else if (this.accountIDRef_ != null)
                {
                    return this.account_; 
                }
                else
                {
                      return this.account_; 
                }
            }
            set
            {
                if (this.account_ != value)
                {
                    this.account_ = value;
                }
            }
        }
        #endregion
        
        public string accountIDRef_ { get; set; }
        
    
        
    
    }
    
}

