using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TradeChangeAdvice : CorrectableRequestMessage
    {
        public TradeChangeAdvice(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode changeNode = xmlNode.SelectSingleNode("change");
            
            if (changeNode != null)
            {
                if (changeNode.Attributes["href"] != null || changeNode.Attributes["id"] != null) 
                {
                    if (changeNode.Attributes["id"] != null) 
                    {
                        changeIDRef_ = changeNode.Attributes["id"].Value;
                        TradeChangeContent ob = new TradeChangeContent(changeNode);
                        IDManager.SetID(changeIDRef_, ob);
                    }
                    else if (changeNode.Attributes["href"] != null)
                    {
                        changeIDRef_ = changeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        change_ = new TradeChangeContent(changeNode);
                    }
                }
                else
                {
                    change_ = new TradeChangeContent(changeNode);
                }
            }
            
        
            XmlNodeList quoteNodeList = xmlNode.SelectNodes("quote");
            
            if (quoteNodeList != null)
            {
                this.quote_ = new List<BasicQuotation>();
                foreach (XmlNode item in quoteNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            quoteIDRef_ = item.Attributes["id"].Value;
                            quote_.Add(new BasicQuotation(item));
                            IDManager.SetID(quoteIDRef_, quote_[quote_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            quoteIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        quote_.Add(new BasicQuotation(item));
                        }
                    }
                    else
                    {
                        quote_.Add(new BasicQuotation(item));
                    }
                }
            }
            
        
            XmlNodeList paymentDetailsNodeList = xmlNode.SelectNodes("paymentDetails");
            
            if (paymentDetailsNodeList != null)
            {
                this.paymentDetails_ = new List<PaymentDetails>();
                foreach (XmlNode item in paymentDetailsNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            paymentDetailsIDRef_ = item.Attributes["id"].Value;
                            paymentDetails_.Add(new PaymentDetails(item));
                            IDManager.SetID(paymentDetailsIDRef_, paymentDetails_[paymentDetails_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            paymentDetailsIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        paymentDetails_.Add(new PaymentDetails(item));
                        }
                    }
                    else
                    {
                        paymentDetails_.Add(new PaymentDetails(item));
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
        
    
        #region Change_
        private TradeChangeContent change_;
        public TradeChangeContent Change_
        {
            get
            {
                if (this.change_ != null)
                {
                    return this.change_; 
                }
                else if (this.changeIDRef_ != null)
                {
                    change_ = IDManager.getID(changeIDRef_) as TradeChangeContent;
                    return this.change_; 
                }
                else
                {
                      return this.change_; 
                }
            }
            set
            {
                if (this.change_ != value)
                {
                    this.change_ = value;
                }
            }
        }
        #endregion
        
        public string changeIDRef_ { get; set; }
        #region Quote_
        private List<BasicQuotation> quote_;
        public List<BasicQuotation> Quote_
        {
            get
            {
                if (this.quote_ != null)
                {
                    return this.quote_; 
                }
                else if (this.quoteIDRef_ != null)
                {
                    return this.quote_; 
                }
                else
                {
                      return this.quote_; 
                }
            }
            set
            {
                if (this.quote_ != value)
                {
                    this.quote_ = value;
                }
            }
        }
        #endregion
        
        public string quoteIDRef_ { get; set; }
        #region PaymentDetails_
        private List<PaymentDetails> paymentDetails_;
        public List<PaymentDetails> PaymentDetails_
        {
            get
            {
                if (this.paymentDetails_ != null)
                {
                    return this.paymentDetails_; 
                }
                else if (this.paymentDetailsIDRef_ != null)
                {
                    return this.paymentDetails_; 
                }
                else
                {
                      return this.paymentDetails_; 
                }
            }
            set
            {
                if (this.paymentDetails_ != value)
                {
                    this.paymentDetails_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDetailsIDRef_ { get; set; }
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

