using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TradeChangeAdvice
    {
        public TradeChangeAdvice(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList changeNodeList = xmlNode.SelectNodes("change");
            if (changeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in changeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        changeIDRef = item.Attributes["id"].Name;
                        TradeChangeContent ob = TradeChangeContent();
                        IDManager.SetID(changeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        changeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        change = new TradeChangeContent(item);
                    }
                }
            }
            
        
            XmlNodeList quoteNodeList = xmlNode.SelectNodes("quote");
            
            foreach (XmlNode item in quoteNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quoteIDRef = item.Attributes["id"].Name;
                        List<BasicQuotation> ob = new List<BasicQuotation>();
                        ob.Add(new BasicQuotation(item));
                        IDManager.SetID(quoteIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quoteIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    quote.Add(new BasicQuotation(item));
                    }
                }
            }
            
        
            XmlNodeList paymentDetailsNodeList = xmlNode.SelectNodes("paymentDetails");
            
            foreach (XmlNode item in paymentDetailsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDetailsIDRef = item.Attributes["id"].Name;
                        List<PaymentDetails> ob = new List<PaymentDetails>();
                        ob.Add(new PaymentDetails(item));
                        IDManager.SetID(paymentDetailsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDetailsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    paymentDetails.Add(new PaymentDetails(item));
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
        
    
        #region Change
        private TradeChangeContent change;
        public TradeChangeContent Change
        {
            get
            {
                if (this.change != null)
                {
                    return this.change; 
                }
                else if (this.changeIDRef != null)
                {
                    change = IDManager.getID(changeIDRef) as TradeChangeContent;
                    return this.change; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.change != value)
                {
                    this.change = value;
                }
            }
        }
        #endregion
        
        public string TradeChangeContentIDRef { get; set; }
        #region Quote
        private List<BasicQuotation> quote;
        public List<BasicQuotation> Quote
        {
            get
            {
                if (this.quote != null)
                {
                    return this.quote; 
                }
                else if (this.quoteIDRef != null)
                {
                    quote = IDManager.getID(quoteIDRef) as List<BasicQuotation>;
                    return this.quote; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quote != value)
                {
                    this.quote = value;
                }
            }
        }
        #endregion
        
        public string BasicQuotationIDRef { get; set; }
        #region PaymentDetails
        private List<PaymentDetails> paymentDetails;
        public List<PaymentDetails> PaymentDetails
        {
            get
            {
                if (this.paymentDetails != null)
                {
                    return this.paymentDetails; 
                }
                else if (this.paymentDetailsIDRef != null)
                {
                    paymentDetails = IDManager.getID(paymentDetailsIDRef) as List<PaymentDetails>;
                    return this.paymentDetails; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDetails != value)
                {
                    this.paymentDetails = value;
                }
            }
        }
        #endregion
        
        public string PaymentDetailsIDRef { get; set; }
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

