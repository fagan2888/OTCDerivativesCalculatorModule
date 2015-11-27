using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Payment
    {
        public Payment(XmlNode xmlNode)
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
            
        
            XmlNodeList paymentAmountNodeList = xmlNode.SelectNodes("paymentAmount");
            if (paymentAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentAmountIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(paymentAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList paymentDateNodeList = xmlNode.SelectNodes("paymentDate");
            if (paymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrAdjustedDate ob = AdjustableOrAdjustedDate();
                        IDManager.SetID(paymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDate = new AdjustableOrAdjustedDate(item);
                    }
                }
            }
            
        
            XmlNodeList paymentTypeNodeList = xmlNode.SelectNodes("paymentType");
            if (paymentTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentTypeIDRef = item.Attributes["id"].Name;
                        PaymentType ob = PaymentType();
                        IDManager.SetID(paymentTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentType = new PaymentType(item);
                    }
                }
            }
            
        
            XmlNodeList settlementInformationNodeList = xmlNode.SelectNodes("settlementInformation");
            if (settlementInformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementInformationIDRef = item.Attributes["id"].Name;
                        SettlementInformation ob = SettlementInformation();
                        IDManager.SetID(settlementInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementInformation = new SettlementInformation(item);
                    }
                }
            }
            
        
            XmlNodeList discountFactorNodeList = xmlNode.SelectNodes("discountFactor");
            if (discountFactorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in discountFactorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        discountFactorIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(discountFactorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        discountFactorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        discountFactor = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList presentValueAmountNodeList = xmlNode.SelectNodes("presentValueAmount");
            if (presentValueAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in presentValueAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        presentValueAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(presentValueAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        presentValueAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        presentValueAmount = new Money(item);
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
        #region PaymentAmount
        private NonNegativeMoney paymentAmount;
        public NonNegativeMoney PaymentAmount
        {
            get
            {
                if (this.paymentAmount != null)
                {
                    return this.paymentAmount; 
                }
                else if (this.paymentAmountIDRef != null)
                {
                    paymentAmount = IDManager.getID(paymentAmountIDRef) as NonNegativeMoney;
                    return this.paymentAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentAmount != value)
                {
                    this.paymentAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region PaymentDate
        private AdjustableOrAdjustedDate paymentDate;
        public AdjustableOrAdjustedDate PaymentDate
        {
            get
            {
                if (this.paymentDate != null)
                {
                    return this.paymentDate; 
                }
                else if (this.paymentDateIDRef != null)
                {
                    paymentDate = IDManager.getID(paymentDateIDRef) as AdjustableOrAdjustedDate;
                    return this.paymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDate != value)
                {
                    this.paymentDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrAdjustedDateIDRef { get; set; }
        #region PaymentType
        private PaymentType paymentType;
        public PaymentType PaymentType
        {
            get
            {
                if (this.paymentType != null)
                {
                    return this.paymentType; 
                }
                else if (this.paymentTypeIDRef != null)
                {
                    paymentType = IDManager.getID(paymentTypeIDRef) as PaymentType;
                    return this.paymentType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentType != value)
                {
                    this.paymentType = value;
                }
            }
        }
        #endregion
        
        public string PaymentTypeIDRef { get; set; }
        #region SettlementInformation
        private SettlementInformation settlementInformation;
        public SettlementInformation SettlementInformation
        {
            get
            {
                if (this.settlementInformation != null)
                {
                    return this.settlementInformation; 
                }
                else if (this.settlementInformationIDRef != null)
                {
                    settlementInformation = IDManager.getID(settlementInformationIDRef) as SettlementInformation;
                    return this.settlementInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementInformation != value)
                {
                    this.settlementInformation = value;
                }
            }
        }
        #endregion
        
        public string SettlementInformationIDRef { get; set; }
        #region DiscountFactor
        private XsdTypeDecimal discountFactor;
        public XsdTypeDecimal DiscountFactor
        {
            get
            {
                if (this.discountFactor != null)
                {
                    return this.discountFactor; 
                }
                else if (this.discountFactorIDRef != null)
                {
                    discountFactor = IDManager.getID(discountFactorIDRef) as XsdTypeDecimal;
                    return this.discountFactor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.discountFactor != value)
                {
                    this.discountFactor = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region PresentValueAmount
        private Money presentValueAmount;
        public Money PresentValueAmount
        {
            get
            {
                if (this.presentValueAmount != null)
                {
                    return this.presentValueAmount; 
                }
                else if (this.presentValueAmountIDRef != null)
                {
                    presentValueAmount = IDManager.getID(presentValueAmountIDRef) as Money;
                    return this.presentValueAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.presentValueAmount != value)
                {
                    this.presentValueAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        
    
        
    
    }
    
}

