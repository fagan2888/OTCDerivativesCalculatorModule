using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CreditEventNotification : CorrectableRequestMessage
    {
        public CreditEventNotification(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode creditEventNoticeNode = xmlNode.SelectSingleNode("creditEventNotice");
            
            if (creditEventNoticeNode != null)
            {
                if (creditEventNoticeNode.Attributes["href"] != null || creditEventNoticeNode.Attributes["id"] != null) 
                {
                    if (creditEventNoticeNode.Attributes["id"] != null) 
                    {
                        creditEventNoticeIDRef_ = creditEventNoticeNode.Attributes["id"].Value;
                        CreditEventNoticeDocument ob = new CreditEventNoticeDocument(creditEventNoticeNode);
                        IDManager.SetID(creditEventNoticeIDRef_, ob);
                    }
                    else if (creditEventNoticeNode.Attributes["href"] != null)
                    {
                        creditEventNoticeIDRef_ = creditEventNoticeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditEventNotice_ = new CreditEventNoticeDocument(creditEventNoticeNode);
                    }
                }
                else
                {
                    creditEventNotice_ = new CreditEventNoticeDocument(creditEventNoticeNode);
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
            
        
        }
        
    
        #region CreditEventNotice_
        private CreditEventNoticeDocument creditEventNotice_;
        public CreditEventNoticeDocument CreditEventNotice_
        {
            get
            {
                if (this.creditEventNotice_ != null)
                {
                    return this.creditEventNotice_; 
                }
                else if (this.creditEventNoticeIDRef_ != null)
                {
                    creditEventNotice_ = IDManager.getID(creditEventNoticeIDRef_) as CreditEventNoticeDocument;
                    return this.creditEventNotice_; 
                }
                else
                {
                      return this.creditEventNotice_; 
                }
            }
            set
            {
                if (this.creditEventNotice_ != value)
                {
                    this.creditEventNotice_ = value;
                }
            }
        }
        #endregion
        
        public string creditEventNoticeIDRef_ { get; set; }
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
        
    
        
    
    }
    
}

