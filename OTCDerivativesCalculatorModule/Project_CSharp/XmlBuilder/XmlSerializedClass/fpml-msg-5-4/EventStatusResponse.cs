using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventStatusResponse : ResponseMessage
    {
        public EventStatusResponse(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList statusItemNodeList = xmlNode.SelectNodes("statusItem");
            
            if (statusItemNodeList != null)
            {
                this.statusItem_ = new List<EventStatusItem>();
                foreach (XmlNode item in statusItemNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            statusItemIDRef_ = item.Attributes["id"].Value;
                            statusItem_.Add(new EventStatusItem(item));
                            IDManager.SetID(statusItemIDRef_, statusItem_[statusItem_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            statusItemIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        statusItem_.Add(new EventStatusItem(item));
                        }
                    }
                    else
                    {
                        statusItem_.Add(new EventStatusItem(item));
                    }
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
        
    
        #region StatusItem_
        private List<EventStatusItem> statusItem_;
        public List<EventStatusItem> StatusItem_
        {
            get
            {
                if (this.statusItem_ != null)
                {
                    return this.statusItem_; 
                }
                else if (this.statusItemIDRef_ != null)
                {
                    return this.statusItem_; 
                }
                else
                {
                      return this.statusItem_; 
                }
            }
            set
            {
                if (this.statusItem_ != value)
                {
                    this.statusItem_ = value;
                }
            }
        }
        #endregion
        
        public string statusItemIDRef_ { get; set; }
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

