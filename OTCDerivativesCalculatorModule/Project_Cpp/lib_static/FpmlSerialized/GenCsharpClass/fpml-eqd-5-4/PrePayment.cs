using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PrePayment
    {
        public PrePayment(XmlNode xmlNode)
        : base(xmlNode)
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
            
        
            XmlNodeList prePaymentNodeList = xmlNode.SelectNodes("prePayment");
            if (prePaymentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in prePaymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        prePaymentIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(prePaymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        prePaymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        prePayment = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList prePaymentAmountNodeList = xmlNode.SelectNodes("prePaymentAmount");
            if (prePaymentAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in prePaymentAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        prePaymentAmountIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(prePaymentAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        prePaymentAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        prePaymentAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList prePaymentDateNodeList = xmlNode.SelectNodes("prePaymentDate");
            if (prePaymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in prePaymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        prePaymentDateIDRef = item.Attributes["id"].Name;
                        AdjustableDate ob = AdjustableDate();
                        IDManager.SetID(prePaymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        prePaymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        prePaymentDate = new AdjustableDate(item);
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
        #region PrePayment
        private XsdTypeBoolean prePayment;
        public XsdTypeBoolean PrePayment
        {
            get
            {
                if (this.prePayment != null)
                {
                    return this.prePayment; 
                }
                else if (this.prePaymentIDRef != null)
                {
                    prePayment = IDManager.getID(prePaymentIDRef) as XsdTypeBoolean;
                    return this.prePayment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.prePayment != value)
                {
                    this.prePayment = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region PrePaymentAmount
        private NonNegativeMoney prePaymentAmount;
        public NonNegativeMoney PrePaymentAmount
        {
            get
            {
                if (this.prePaymentAmount != null)
                {
                    return this.prePaymentAmount; 
                }
                else if (this.prePaymentAmountIDRef != null)
                {
                    prePaymentAmount = IDManager.getID(prePaymentAmountIDRef) as NonNegativeMoney;
                    return this.prePaymentAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.prePaymentAmount != value)
                {
                    this.prePaymentAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region PrePaymentDate
        private AdjustableDate prePaymentDate;
        public AdjustableDate PrePaymentDate
        {
            get
            {
                if (this.prePaymentDate != null)
                {
                    return this.prePaymentDate; 
                }
                else if (this.prePaymentDateIDRef != null)
                {
                    prePaymentDate = IDManager.getID(prePaymentDateIDRef) as AdjustableDate;
                    return this.prePaymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.prePaymentDate != value)
                {
                    this.prePaymentDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDateIDRef { get; set; }
        
    
        
    
    }
    
}

