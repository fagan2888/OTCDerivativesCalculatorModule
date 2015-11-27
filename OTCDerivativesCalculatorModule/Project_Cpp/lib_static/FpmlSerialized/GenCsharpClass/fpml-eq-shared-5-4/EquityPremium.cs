using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EquityPremium
    {
        public EquityPremium(XmlNode xmlNode)
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
            
        
            XmlNodeList premiumTypeNodeList = xmlNode.SelectNodes("premiumType");
            if (premiumTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in premiumTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        premiumTypeIDRef = item.Attributes["id"].Name;
                        PremiumTypeEnum ob = PremiumTypeEnum();
                        IDManager.SetID(premiumTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        premiumTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        premiumType = new PremiumTypeEnum(item);
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
                        AdjustableDate ob = AdjustableDate();
                        IDManager.SetID(paymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDate = new AdjustableDate(item);
                    }
                }
            }
            
        
            XmlNodeList swapPremiumNodeList = xmlNode.SelectNodes("swapPremium");
            if (swapPremiumNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in swapPremiumNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        swapPremiumIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(swapPremiumIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        swapPremiumIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        swapPremium = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList pricePerOptionNodeList = xmlNode.SelectNodes("pricePerOption");
            if (pricePerOptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in pricePerOptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pricePerOptionIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(pricePerOptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pricePerOptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        pricePerOption = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList percentageOfNotionalNodeList = xmlNode.SelectNodes("percentageOfNotional");
            if (percentageOfNotionalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in percentageOfNotionalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        percentageOfNotionalIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(percentageOfNotionalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        percentageOfNotionalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        percentageOfNotional = new NonNegativeDecimal(item);
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
        #region PremiumType
        private PremiumTypeEnum premiumType;
        public PremiumTypeEnum PremiumType
        {
            get
            {
                if (this.premiumType != null)
                {
                    return this.premiumType; 
                }
                else if (this.premiumTypeIDRef != null)
                {
                    premiumType = IDManager.getID(premiumTypeIDRef) as PremiumTypeEnum;
                    return this.premiumType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.premiumType != value)
                {
                    this.premiumType = value;
                }
            }
        }
        #endregion
        
        public string PremiumTypeEnumIDRef { get; set; }
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
        private AdjustableDate paymentDate;
        public AdjustableDate PaymentDate
        {
            get
            {
                if (this.paymentDate != null)
                {
                    return this.paymentDate; 
                }
                else if (this.paymentDateIDRef != null)
                {
                    paymentDate = IDManager.getID(paymentDateIDRef) as AdjustableDate;
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
        
        public string AdjustableDateIDRef { get; set; }
        #region SwapPremium
        private XsdTypeBoolean swapPremium;
        public XsdTypeBoolean SwapPremium
        {
            get
            {
                if (this.swapPremium != null)
                {
                    return this.swapPremium; 
                }
                else if (this.swapPremiumIDRef != null)
                {
                    swapPremium = IDManager.getID(swapPremiumIDRef) as XsdTypeBoolean;
                    return this.swapPremium; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.swapPremium != value)
                {
                    this.swapPremium = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region PricePerOption
        private NonNegativeMoney pricePerOption;
        public NonNegativeMoney PricePerOption
        {
            get
            {
                if (this.pricePerOption != null)
                {
                    return this.pricePerOption; 
                }
                else if (this.pricePerOptionIDRef != null)
                {
                    pricePerOption = IDManager.getID(pricePerOptionIDRef) as NonNegativeMoney;
                    return this.pricePerOption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pricePerOption != value)
                {
                    this.pricePerOption = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region PercentageOfNotional
        private NonNegativeDecimal percentageOfNotional;
        public NonNegativeDecimal PercentageOfNotional
        {
            get
            {
                if (this.percentageOfNotional != null)
                {
                    return this.percentageOfNotional; 
                }
                else if (this.percentageOfNotionalIDRef != null)
                {
                    percentageOfNotional = IDManager.getID(percentageOfNotionalIDRef) as NonNegativeDecimal;
                    return this.percentageOfNotional; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.percentageOfNotional != value)
                {
                    this.percentageOfNotional = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        
    
        
    
    }
    
}

