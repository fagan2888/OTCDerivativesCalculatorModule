using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class NonPeriodicFixedPriceLeg
    {
        public NonPeriodicFixedPriceLeg(XmlNode xmlNode)
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
            
        
            XmlNodeList fixedPriceNodeList = xmlNode.SelectNodes("fixedPrice");
            if (fixedPriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedPriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedPriceIDRef = item.Attributes["id"].Name;
                        FixedPrice ob = FixedPrice();
                        IDManager.SetID(fixedPriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedPriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedPrice = new FixedPrice(item);
                    }
                }
            }
            
        
            XmlNodeList totalPriceNodeList = xmlNode.SelectNodes("totalPrice");
            if (totalPriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in totalPriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        totalPriceIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(totalPriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        totalPriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        totalPrice = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList quantityReferenceNodeList = xmlNode.SelectNodes("quantityReference");
            if (quantityReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quantityReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quantityReferenceIDRef = item.Attributes["id"].Name;
                        QuantityReference ob = QuantityReference();
                        IDManager.SetID(quantityReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quantityReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quantityReference = new QuantityReference(item);
                    }
                }
            }
            
        
            XmlNodeList relativePaymentDatesNodeList = xmlNode.SelectNodes("relativePaymentDates");
            if (relativePaymentDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in relativePaymentDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relativePaymentDatesIDRef = item.Attributes["id"].Name;
                        CommodityRelativePaymentDates ob = CommodityRelativePaymentDates();
                        IDManager.SetID(relativePaymentDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relativePaymentDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        relativePaymentDates = new CommodityRelativePaymentDates(item);
                    }
                }
            }
            
        
            XmlNodeList paymentDatesNodeList = xmlNode.SelectNodes("paymentDates");
            if (paymentDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDatesIDRef = item.Attributes["id"].Name;
                        AdjustableDatesOrRelativeDateOffset ob = AdjustableDatesOrRelativeDateOffset();
                        IDManager.SetID(paymentDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDates = new AdjustableDatesOrRelativeDateOffset(item);
                    }
                }
            }
            
        
            XmlNodeList masterAgreementPaymentDatesNodeList = xmlNode.SelectNodes("masterAgreementPaymentDates");
            if (masterAgreementPaymentDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in masterAgreementPaymentDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        masterAgreementPaymentDatesIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(masterAgreementPaymentDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        masterAgreementPaymentDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        masterAgreementPaymentDates = new XsdTypeBoolean(item);
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
        #region FixedPrice
        private FixedPrice fixedPrice;
        public FixedPrice FixedPrice
        {
            get
            {
                if (this.fixedPrice != null)
                {
                    return this.fixedPrice; 
                }
                else if (this.fixedPriceIDRef != null)
                {
                    fixedPrice = IDManager.getID(fixedPriceIDRef) as FixedPrice;
                    return this.fixedPrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedPrice != value)
                {
                    this.fixedPrice = value;
                }
            }
        }
        #endregion
        
        public string FixedPriceIDRef { get; set; }
        #region TotalPrice
        private NonNegativeMoney totalPrice;
        public NonNegativeMoney TotalPrice
        {
            get
            {
                if (this.totalPrice != null)
                {
                    return this.totalPrice; 
                }
                else if (this.totalPriceIDRef != null)
                {
                    totalPrice = IDManager.getID(totalPriceIDRef) as NonNegativeMoney;
                    return this.totalPrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.totalPrice != value)
                {
                    this.totalPrice = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region QuantityReference
        private QuantityReference quantityReference;
        public QuantityReference QuantityReference
        {
            get
            {
                if (this.quantityReference != null)
                {
                    return this.quantityReference; 
                }
                else if (this.quantityReferenceIDRef != null)
                {
                    quantityReference = IDManager.getID(quantityReferenceIDRef) as QuantityReference;
                    return this.quantityReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quantityReference != value)
                {
                    this.quantityReference = value;
                }
            }
        }
        #endregion
        
        public string QuantityReferenceIDRef { get; set; }
        #region RelativePaymentDates
        private CommodityRelativePaymentDates relativePaymentDates;
        public CommodityRelativePaymentDates RelativePaymentDates
        {
            get
            {
                if (this.relativePaymentDates != null)
                {
                    return this.relativePaymentDates; 
                }
                else if (this.relativePaymentDatesIDRef != null)
                {
                    relativePaymentDates = IDManager.getID(relativePaymentDatesIDRef) as CommodityRelativePaymentDates;
                    return this.relativePaymentDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relativePaymentDates != value)
                {
                    this.relativePaymentDates = value;
                }
            }
        }
        #endregion
        
        public string CommodityRelativePaymentDatesIDRef { get; set; }
        #region PaymentDates
        private AdjustableDatesOrRelativeDateOffset paymentDates;
        public AdjustableDatesOrRelativeDateOffset PaymentDates
        {
            get
            {
                if (this.paymentDates != null)
                {
                    return this.paymentDates; 
                }
                else if (this.paymentDatesIDRef != null)
                {
                    paymentDates = IDManager.getID(paymentDatesIDRef) as AdjustableDatesOrRelativeDateOffset;
                    return this.paymentDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDates != value)
                {
                    this.paymentDates = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDatesOrRelativeDateOffsetIDRef { get; set; }
        #region MasterAgreementPaymentDates
        private XsdTypeBoolean masterAgreementPaymentDates;
        public XsdTypeBoolean MasterAgreementPaymentDates
        {
            get
            {
                if (this.masterAgreementPaymentDates != null)
                {
                    return this.masterAgreementPaymentDates; 
                }
                else if (this.masterAgreementPaymentDatesIDRef != null)
                {
                    masterAgreementPaymentDates = IDManager.getID(masterAgreementPaymentDatesIDRef) as XsdTypeBoolean;
                    return this.masterAgreementPaymentDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.masterAgreementPaymentDates != value)
                {
                    this.masterAgreementPaymentDates = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

