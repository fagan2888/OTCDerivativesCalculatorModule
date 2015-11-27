using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class NonPeriodicFixedPriceLeg : CommoditySwapLeg
    {
        public NonPeriodicFixedPriceLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode payerPartyReferenceNode = xmlNode.SelectSingleNode("payerPartyReference");
            
            if (payerPartyReferenceNode != null)
            {
                if (payerPartyReferenceNode.Attributes["href"] != null || payerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (payerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        payerPartyReferenceIDRef_ = payerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(payerPartyReferenceNode);
                        IDManager.SetID(payerPartyReferenceIDRef_, ob);
                    }
                    else if (payerPartyReferenceNode.Attributes["href"] != null)
                    {
                        payerPartyReferenceIDRef_ = payerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payerPartyReference_ = new PartyReference(payerPartyReferenceNode);
                    }
                }
                else
                {
                    payerPartyReference_ = new PartyReference(payerPartyReferenceNode);
                }
            }
            
        
            XmlNode payerAccountReferenceNode = xmlNode.SelectSingleNode("payerAccountReference");
            
            if (payerAccountReferenceNode != null)
            {
                if (payerAccountReferenceNode.Attributes["href"] != null || payerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (payerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        payerAccountReferenceIDRef_ = payerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(payerAccountReferenceNode);
                        IDManager.SetID(payerAccountReferenceIDRef_, ob);
                    }
                    else if (payerAccountReferenceNode.Attributes["href"] != null)
                    {
                        payerAccountReferenceIDRef_ = payerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payerAccountReference_ = new AccountReference(payerAccountReferenceNode);
                    }
                }
                else
                {
                    payerAccountReference_ = new AccountReference(payerAccountReferenceNode);
                }
            }
            
        
            XmlNode receiverPartyReferenceNode = xmlNode.SelectSingleNode("receiverPartyReference");
            
            if (receiverPartyReferenceNode != null)
            {
                if (receiverPartyReferenceNode.Attributes["href"] != null || receiverPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (receiverPartyReferenceNode.Attributes["id"] != null) 
                    {
                        receiverPartyReferenceIDRef_ = receiverPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(receiverPartyReferenceNode);
                        IDManager.SetID(receiverPartyReferenceIDRef_, ob);
                    }
                    else if (receiverPartyReferenceNode.Attributes["href"] != null)
                    {
                        receiverPartyReferenceIDRef_ = receiverPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        receiverPartyReference_ = new PartyReference(receiverPartyReferenceNode);
                    }
                }
                else
                {
                    receiverPartyReference_ = new PartyReference(receiverPartyReferenceNode);
                }
            }
            
        
            XmlNode receiverAccountReferenceNode = xmlNode.SelectSingleNode("receiverAccountReference");
            
            if (receiverAccountReferenceNode != null)
            {
                if (receiverAccountReferenceNode.Attributes["href"] != null || receiverAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (receiverAccountReferenceNode.Attributes["id"] != null) 
                    {
                        receiverAccountReferenceIDRef_ = receiverAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(receiverAccountReferenceNode);
                        IDManager.SetID(receiverAccountReferenceIDRef_, ob);
                    }
                    else if (receiverAccountReferenceNode.Attributes["href"] != null)
                    {
                        receiverAccountReferenceIDRef_ = receiverAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        receiverAccountReference_ = new AccountReference(receiverAccountReferenceNode);
                    }
                }
                else
                {
                    receiverAccountReference_ = new AccountReference(receiverAccountReferenceNode);
                }
            }
            
        
            XmlNode fixedPriceNode = xmlNode.SelectSingleNode("fixedPrice");
            
            if (fixedPriceNode != null)
            {
                if (fixedPriceNode.Attributes["href"] != null || fixedPriceNode.Attributes["id"] != null) 
                {
                    if (fixedPriceNode.Attributes["id"] != null) 
                    {
                        fixedPriceIDRef_ = fixedPriceNode.Attributes["id"].Value;
                        FixedPrice ob = new FixedPrice(fixedPriceNode);
                        IDManager.SetID(fixedPriceIDRef_, ob);
                    }
                    else if (fixedPriceNode.Attributes["href"] != null)
                    {
                        fixedPriceIDRef_ = fixedPriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedPrice_ = new FixedPrice(fixedPriceNode);
                    }
                }
                else
                {
                    fixedPrice_ = new FixedPrice(fixedPriceNode);
                }
            }
            
        
            XmlNode totalPriceNode = xmlNode.SelectSingleNode("totalPrice");
            
            if (totalPriceNode != null)
            {
                if (totalPriceNode.Attributes["href"] != null || totalPriceNode.Attributes["id"] != null) 
                {
                    if (totalPriceNode.Attributes["id"] != null) 
                    {
                        totalPriceIDRef_ = totalPriceNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(totalPriceNode);
                        IDManager.SetID(totalPriceIDRef_, ob);
                    }
                    else if (totalPriceNode.Attributes["href"] != null)
                    {
                        totalPriceIDRef_ = totalPriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        totalPrice_ = new NonNegativeMoney(totalPriceNode);
                    }
                }
                else
                {
                    totalPrice_ = new NonNegativeMoney(totalPriceNode);
                }
            }
            
        
            XmlNode quantityReferenceNode = xmlNode.SelectSingleNode("quantityReference");
            
            if (quantityReferenceNode != null)
            {
                if (quantityReferenceNode.Attributes["href"] != null || quantityReferenceNode.Attributes["id"] != null) 
                {
                    if (quantityReferenceNode.Attributes["id"] != null) 
                    {
                        quantityReferenceIDRef_ = quantityReferenceNode.Attributes["id"].Value;
                        QuantityReference ob = new QuantityReference(quantityReferenceNode);
                        IDManager.SetID(quantityReferenceIDRef_, ob);
                    }
                    else if (quantityReferenceNode.Attributes["href"] != null)
                    {
                        quantityReferenceIDRef_ = quantityReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quantityReference_ = new QuantityReference(quantityReferenceNode);
                    }
                }
                else
                {
                    quantityReference_ = new QuantityReference(quantityReferenceNode);
                }
            }
            
        
            XmlNode relativePaymentDatesNode = xmlNode.SelectSingleNode("relativePaymentDates");
            
            if (relativePaymentDatesNode != null)
            {
                if (relativePaymentDatesNode.Attributes["href"] != null || relativePaymentDatesNode.Attributes["id"] != null) 
                {
                    if (relativePaymentDatesNode.Attributes["id"] != null) 
                    {
                        relativePaymentDatesIDRef_ = relativePaymentDatesNode.Attributes["id"].Value;
                        CommodityRelativePaymentDates ob = new CommodityRelativePaymentDates(relativePaymentDatesNode);
                        IDManager.SetID(relativePaymentDatesIDRef_, ob);
                    }
                    else if (relativePaymentDatesNode.Attributes["href"] != null)
                    {
                        relativePaymentDatesIDRef_ = relativePaymentDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        relativePaymentDates_ = new CommodityRelativePaymentDates(relativePaymentDatesNode);
                    }
                }
                else
                {
                    relativePaymentDates_ = new CommodityRelativePaymentDates(relativePaymentDatesNode);
                }
            }
            
        
            XmlNode paymentDatesNode = xmlNode.SelectSingleNode("paymentDates");
            
            if (paymentDatesNode != null)
            {
                if (paymentDatesNode.Attributes["href"] != null || paymentDatesNode.Attributes["id"] != null) 
                {
                    if (paymentDatesNode.Attributes["id"] != null) 
                    {
                        paymentDatesIDRef_ = paymentDatesNode.Attributes["id"].Value;
                        AdjustableDatesOrRelativeDateOffset ob = new AdjustableDatesOrRelativeDateOffset(paymentDatesNode);
                        IDManager.SetID(paymentDatesIDRef_, ob);
                    }
                    else if (paymentDatesNode.Attributes["href"] != null)
                    {
                        paymentDatesIDRef_ = paymentDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDates_ = new AdjustableDatesOrRelativeDateOffset(paymentDatesNode);
                    }
                }
                else
                {
                    paymentDates_ = new AdjustableDatesOrRelativeDateOffset(paymentDatesNode);
                }
            }
            
        
            XmlNode masterAgreementPaymentDatesNode = xmlNode.SelectSingleNode("masterAgreementPaymentDates");
            
            if (masterAgreementPaymentDatesNode != null)
            {
                if (masterAgreementPaymentDatesNode.Attributes["href"] != null || masterAgreementPaymentDatesNode.Attributes["id"] != null) 
                {
                    if (masterAgreementPaymentDatesNode.Attributes["id"] != null) 
                    {
                        masterAgreementPaymentDatesIDRef_ = masterAgreementPaymentDatesNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(masterAgreementPaymentDatesNode);
                        IDManager.SetID(masterAgreementPaymentDatesIDRef_, ob);
                    }
                    else if (masterAgreementPaymentDatesNode.Attributes["href"] != null)
                    {
                        masterAgreementPaymentDatesIDRef_ = masterAgreementPaymentDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        masterAgreementPaymentDates_ = new XsdTypeBoolean(masterAgreementPaymentDatesNode);
                    }
                }
                else
                {
                    masterAgreementPaymentDates_ = new XsdTypeBoolean(masterAgreementPaymentDatesNode);
                }
            }
            
        
        }
        
    
        #region PayerPartyReference_
        private PartyReference payerPartyReference_;
        public PartyReference PayerPartyReference_
        {
            get
            {
                if (this.payerPartyReference_ != null)
                {
                    return this.payerPartyReference_; 
                }
                else if (this.payerPartyReferenceIDRef_ != null)
                {
                    payerPartyReference_ = IDManager.getID(payerPartyReferenceIDRef_) as PartyReference;
                    return this.payerPartyReference_; 
                }
                else
                {
                      return this.payerPartyReference_; 
                }
            }
            set
            {
                if (this.payerPartyReference_ != value)
                {
                    this.payerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string payerPartyReferenceIDRef_ { get; set; }
        #region PayerAccountReference_
        private AccountReference payerAccountReference_;
        public AccountReference PayerAccountReference_
        {
            get
            {
                if (this.payerAccountReference_ != null)
                {
                    return this.payerAccountReference_; 
                }
                else if (this.payerAccountReferenceIDRef_ != null)
                {
                    payerAccountReference_ = IDManager.getID(payerAccountReferenceIDRef_) as AccountReference;
                    return this.payerAccountReference_; 
                }
                else
                {
                      return this.payerAccountReference_; 
                }
            }
            set
            {
                if (this.payerAccountReference_ != value)
                {
                    this.payerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string payerAccountReferenceIDRef_ { get; set; }
        #region ReceiverPartyReference_
        private PartyReference receiverPartyReference_;
        public PartyReference ReceiverPartyReference_
        {
            get
            {
                if (this.receiverPartyReference_ != null)
                {
                    return this.receiverPartyReference_; 
                }
                else if (this.receiverPartyReferenceIDRef_ != null)
                {
                    receiverPartyReference_ = IDManager.getID(receiverPartyReferenceIDRef_) as PartyReference;
                    return this.receiverPartyReference_; 
                }
                else
                {
                      return this.receiverPartyReference_; 
                }
            }
            set
            {
                if (this.receiverPartyReference_ != value)
                {
                    this.receiverPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string receiverPartyReferenceIDRef_ { get; set; }
        #region ReceiverAccountReference_
        private AccountReference receiverAccountReference_;
        public AccountReference ReceiverAccountReference_
        {
            get
            {
                if (this.receiverAccountReference_ != null)
                {
                    return this.receiverAccountReference_; 
                }
                else if (this.receiverAccountReferenceIDRef_ != null)
                {
                    receiverAccountReference_ = IDManager.getID(receiverAccountReferenceIDRef_) as AccountReference;
                    return this.receiverAccountReference_; 
                }
                else
                {
                      return this.receiverAccountReference_; 
                }
            }
            set
            {
                if (this.receiverAccountReference_ != value)
                {
                    this.receiverAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string receiverAccountReferenceIDRef_ { get; set; }
        #region FixedPrice_
        private FixedPrice fixedPrice_;
        public FixedPrice FixedPrice_
        {
            get
            {
                if (this.fixedPrice_ != null)
                {
                    return this.fixedPrice_; 
                }
                else if (this.fixedPriceIDRef_ != null)
                {
                    fixedPrice_ = IDManager.getID(fixedPriceIDRef_) as FixedPrice;
                    return this.fixedPrice_; 
                }
                else
                {
                      return this.fixedPrice_; 
                }
            }
            set
            {
                if (this.fixedPrice_ != value)
                {
                    this.fixedPrice_ = value;
                }
            }
        }
        #endregion
        
        public string fixedPriceIDRef_ { get; set; }
        #region TotalPrice_
        private NonNegativeMoney totalPrice_;
        public NonNegativeMoney TotalPrice_
        {
            get
            {
                if (this.totalPrice_ != null)
                {
                    return this.totalPrice_; 
                }
                else if (this.totalPriceIDRef_ != null)
                {
                    totalPrice_ = IDManager.getID(totalPriceIDRef_) as NonNegativeMoney;
                    return this.totalPrice_; 
                }
                else
                {
                      return this.totalPrice_; 
                }
            }
            set
            {
                if (this.totalPrice_ != value)
                {
                    this.totalPrice_ = value;
                }
            }
        }
        #endregion
        
        public string totalPriceIDRef_ { get; set; }
        #region QuantityReference_
        private QuantityReference quantityReference_;
        public QuantityReference QuantityReference_
        {
            get
            {
                if (this.quantityReference_ != null)
                {
                    return this.quantityReference_; 
                }
                else if (this.quantityReferenceIDRef_ != null)
                {
                    quantityReference_ = IDManager.getID(quantityReferenceIDRef_) as QuantityReference;
                    return this.quantityReference_; 
                }
                else
                {
                      return this.quantityReference_; 
                }
            }
            set
            {
                if (this.quantityReference_ != value)
                {
                    this.quantityReference_ = value;
                }
            }
        }
        #endregion
        
        public string quantityReferenceIDRef_ { get; set; }
        #region RelativePaymentDates_
        private CommodityRelativePaymentDates relativePaymentDates_;
        public CommodityRelativePaymentDates RelativePaymentDates_
        {
            get
            {
                if (this.relativePaymentDates_ != null)
                {
                    return this.relativePaymentDates_; 
                }
                else if (this.relativePaymentDatesIDRef_ != null)
                {
                    relativePaymentDates_ = IDManager.getID(relativePaymentDatesIDRef_) as CommodityRelativePaymentDates;
                    return this.relativePaymentDates_; 
                }
                else
                {
                      return this.relativePaymentDates_; 
                }
            }
            set
            {
                if (this.relativePaymentDates_ != value)
                {
                    this.relativePaymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string relativePaymentDatesIDRef_ { get; set; }
        #region PaymentDates_
        private AdjustableDatesOrRelativeDateOffset paymentDates_;
        public AdjustableDatesOrRelativeDateOffset PaymentDates_
        {
            get
            {
                if (this.paymentDates_ != null)
                {
                    return this.paymentDates_; 
                }
                else if (this.paymentDatesIDRef_ != null)
                {
                    paymentDates_ = IDManager.getID(paymentDatesIDRef_) as AdjustableDatesOrRelativeDateOffset;
                    return this.paymentDates_; 
                }
                else
                {
                      return this.paymentDates_; 
                }
            }
            set
            {
                if (this.paymentDates_ != value)
                {
                    this.paymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDatesIDRef_ { get; set; }
        #region MasterAgreementPaymentDates_
        private XsdTypeBoolean masterAgreementPaymentDates_;
        public XsdTypeBoolean MasterAgreementPaymentDates_
        {
            get
            {
                if (this.masterAgreementPaymentDates_ != null)
                {
                    return this.masterAgreementPaymentDates_; 
                }
                else if (this.masterAgreementPaymentDatesIDRef_ != null)
                {
                    masterAgreementPaymentDates_ = IDManager.getID(masterAgreementPaymentDatesIDRef_) as XsdTypeBoolean;
                    return this.masterAgreementPaymentDates_; 
                }
                else
                {
                      return this.masterAgreementPaymentDates_; 
                }
            }
            set
            {
                if (this.masterAgreementPaymentDates_ != value)
                {
                    this.masterAgreementPaymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string masterAgreementPaymentDatesIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

