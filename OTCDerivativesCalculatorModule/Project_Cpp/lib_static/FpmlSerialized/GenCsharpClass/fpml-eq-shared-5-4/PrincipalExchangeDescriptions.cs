using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PrincipalExchangeDescriptions
    {
        public PrincipalExchangeDescriptions(XmlNode xmlNode)
        {
            XmlNodeList payerPartyReferenceNodeList = xmlNode.SelectNodes("payerPartyReference");
            if (payerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in payerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        payerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(payerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        payerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList payerAccountReferenceNodeList = xmlNode.SelectNodes("payerAccountReference");
            if (payerAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in payerAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        payerAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(payerAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        payerAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payerAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList receiverPartyReferenceNodeList = xmlNode.SelectNodes("receiverPartyReference");
            if (receiverPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in receiverPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        receiverPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(receiverPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        receiverPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        receiverPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList receiverAccountReferenceNodeList = xmlNode.SelectNodes("receiverAccountReference");
            if (receiverAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in receiverAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        receiverAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(receiverAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        receiverAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        receiverAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList principalExchangeAmountNodeList = xmlNode.SelectNodes("principalExchangeAmount");
            if (principalExchangeAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in principalExchangeAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        principalExchangeAmountIDRef = item.Attributes["id"].Name;
                        PrincipalExchangeAmount ob = PrincipalExchangeAmount();
                        IDManager.SetID(principalExchangeAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        principalExchangeAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        principalExchangeAmount = new PrincipalExchangeAmount(item);
                    }
                }
            }
            
        
            XmlNodeList principalExchangeDateNodeList = xmlNode.SelectNodes("principalExchangeDate");
            if (principalExchangeDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in principalExchangeDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        principalExchangeDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(principalExchangeDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        principalExchangeDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        principalExchangeDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region PayerPartyReference
        private PartyReference payerPartyReference;
        public PartyReference PayerPartyReference
        {
            get
            {
                if (this.payerPartyReference != null)
                {
                    return this.payerPartyReference; 
                }
                else if (this.payerPartyReferenceIDRef != null)
                {
                    payerPartyReference = IDManager.getID(payerPartyReferenceIDRef) as PartyReference;
                    return this.payerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payerPartyReference != value)
                {
                    this.payerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region PayerAccountReference
        private AccountReference payerAccountReference;
        public AccountReference PayerAccountReference
        {
            get
            {
                if (this.payerAccountReference != null)
                {
                    return this.payerAccountReference; 
                }
                else if (this.payerAccountReferenceIDRef != null)
                {
                    payerAccountReference = IDManager.getID(payerAccountReferenceIDRef) as AccountReference;
                    return this.payerAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payerAccountReference != value)
                {
                    this.payerAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region ReceiverPartyReference
        private PartyReference receiverPartyReference;
        public PartyReference ReceiverPartyReference
        {
            get
            {
                if (this.receiverPartyReference != null)
                {
                    return this.receiverPartyReference; 
                }
                else if (this.receiverPartyReferenceIDRef != null)
                {
                    receiverPartyReference = IDManager.getID(receiverPartyReferenceIDRef) as PartyReference;
                    return this.receiverPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.receiverPartyReference != value)
                {
                    this.receiverPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region ReceiverAccountReference
        private AccountReference receiverAccountReference;
        public AccountReference ReceiverAccountReference
        {
            get
            {
                if (this.receiverAccountReference != null)
                {
                    return this.receiverAccountReference; 
                }
                else if (this.receiverAccountReferenceIDRef != null)
                {
                    receiverAccountReference = IDManager.getID(receiverAccountReferenceIDRef) as AccountReference;
                    return this.receiverAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.receiverAccountReference != value)
                {
                    this.receiverAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region PrincipalExchangeAmount
        private PrincipalExchangeAmount principalExchangeAmount;
        public PrincipalExchangeAmount PrincipalExchangeAmount
        {
            get
            {
                if (this.principalExchangeAmount != null)
                {
                    return this.principalExchangeAmount; 
                }
                else if (this.principalExchangeAmountIDRef != null)
                {
                    principalExchangeAmount = IDManager.getID(principalExchangeAmountIDRef) as PrincipalExchangeAmount;
                    return this.principalExchangeAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.principalExchangeAmount != value)
                {
                    this.principalExchangeAmount = value;
                }
            }
        }
        #endregion
        
        public string PrincipalExchangeAmountIDRef { get; set; }
        #region PrincipalExchangeDate
        private AdjustableOrRelativeDate principalExchangeDate;
        public AdjustableOrRelativeDate PrincipalExchangeDate
        {
            get
            {
                if (this.principalExchangeDate != null)
                {
                    return this.principalExchangeDate; 
                }
                else if (this.principalExchangeDateIDRef != null)
                {
                    principalExchangeDate = IDManager.getID(principalExchangeDateIDRef) as AdjustableOrRelativeDate;
                    return this.principalExchangeDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.principalExchangeDate != value)
                {
                    this.principalExchangeDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        
    
        
    
    }
    
}

