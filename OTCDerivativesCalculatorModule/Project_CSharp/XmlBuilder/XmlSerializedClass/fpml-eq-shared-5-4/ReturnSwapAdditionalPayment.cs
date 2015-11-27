using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReturnSwapAdditionalPayment : PaymentBase
    {
        public ReturnSwapAdditionalPayment(XmlNode xmlNode)
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
            
        
            XmlNode additionalPaymentAmountNode = xmlNode.SelectSingleNode("additionalPaymentAmount");
            
            if (additionalPaymentAmountNode != null)
            {
                if (additionalPaymentAmountNode.Attributes["href"] != null || additionalPaymentAmountNode.Attributes["id"] != null) 
                {
                    if (additionalPaymentAmountNode.Attributes["id"] != null) 
                    {
                        additionalPaymentAmountIDRef_ = additionalPaymentAmountNode.Attributes["id"].Value;
                        AdditionalPaymentAmount ob = new AdditionalPaymentAmount(additionalPaymentAmountNode);
                        IDManager.SetID(additionalPaymentAmountIDRef_, ob);
                    }
                    else if (additionalPaymentAmountNode.Attributes["href"] != null)
                    {
                        additionalPaymentAmountIDRef_ = additionalPaymentAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        additionalPaymentAmount_ = new AdditionalPaymentAmount(additionalPaymentAmountNode);
                    }
                }
                else
                {
                    additionalPaymentAmount_ = new AdditionalPaymentAmount(additionalPaymentAmountNode);
                }
            }
            
        
            XmlNode additionalPaymentDateNode = xmlNode.SelectSingleNode("additionalPaymentDate");
            
            if (additionalPaymentDateNode != null)
            {
                if (additionalPaymentDateNode.Attributes["href"] != null || additionalPaymentDateNode.Attributes["id"] != null) 
                {
                    if (additionalPaymentDateNode.Attributes["id"] != null) 
                    {
                        additionalPaymentDateIDRef_ = additionalPaymentDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(additionalPaymentDateNode);
                        IDManager.SetID(additionalPaymentDateIDRef_, ob);
                    }
                    else if (additionalPaymentDateNode.Attributes["href"] != null)
                    {
                        additionalPaymentDateIDRef_ = additionalPaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        additionalPaymentDate_ = new AdjustableOrRelativeDate(additionalPaymentDateNode);
                    }
                }
                else
                {
                    additionalPaymentDate_ = new AdjustableOrRelativeDate(additionalPaymentDateNode);
                }
            }
            
        
            XmlNode paymentTypeNode = xmlNode.SelectSingleNode("paymentType");
            
            if (paymentTypeNode != null)
            {
                if (paymentTypeNode.Attributes["href"] != null || paymentTypeNode.Attributes["id"] != null) 
                {
                    if (paymentTypeNode.Attributes["id"] != null) 
                    {
                        paymentTypeIDRef_ = paymentTypeNode.Attributes["id"].Value;
                        PaymentType ob = new PaymentType(paymentTypeNode);
                        IDManager.SetID(paymentTypeIDRef_, ob);
                    }
                    else if (paymentTypeNode.Attributes["href"] != null)
                    {
                        paymentTypeIDRef_ = paymentTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentType_ = new PaymentType(paymentTypeNode);
                    }
                }
                else
                {
                    paymentType_ = new PaymentType(paymentTypeNode);
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
        #region AdditionalPaymentAmount_
        private AdditionalPaymentAmount additionalPaymentAmount_;
        public AdditionalPaymentAmount AdditionalPaymentAmount_
        {
            get
            {
                if (this.additionalPaymentAmount_ != null)
                {
                    return this.additionalPaymentAmount_; 
                }
                else if (this.additionalPaymentAmountIDRef_ != null)
                {
                    additionalPaymentAmount_ = IDManager.getID(additionalPaymentAmountIDRef_) as AdditionalPaymentAmount;
                    return this.additionalPaymentAmount_; 
                }
                else
                {
                      return this.additionalPaymentAmount_; 
                }
            }
            set
            {
                if (this.additionalPaymentAmount_ != value)
                {
                    this.additionalPaymentAmount_ = value;
                }
            }
        }
        #endregion
        
        public string additionalPaymentAmountIDRef_ { get; set; }
        #region AdditionalPaymentDate_
        private AdjustableOrRelativeDate additionalPaymentDate_;
        public AdjustableOrRelativeDate AdditionalPaymentDate_
        {
            get
            {
                if (this.additionalPaymentDate_ != null)
                {
                    return this.additionalPaymentDate_; 
                }
                else if (this.additionalPaymentDateIDRef_ != null)
                {
                    additionalPaymentDate_ = IDManager.getID(additionalPaymentDateIDRef_) as AdjustableOrRelativeDate;
                    return this.additionalPaymentDate_; 
                }
                else
                {
                      return this.additionalPaymentDate_; 
                }
            }
            set
            {
                if (this.additionalPaymentDate_ != value)
                {
                    this.additionalPaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string additionalPaymentDateIDRef_ { get; set; }
        #region PaymentType_
        private PaymentType paymentType_;
        public PaymentType PaymentType_
        {
            get
            {
                if (this.paymentType_ != null)
                {
                    return this.paymentType_; 
                }
                else if (this.paymentTypeIDRef_ != null)
                {
                    paymentType_ = IDManager.getID(paymentTypeIDRef_) as PaymentType;
                    return this.paymentType_; 
                }
                else
                {
                      return this.paymentType_; 
                }
            }
            set
            {
                if (this.paymentType_ != value)
                {
                    this.paymentType_ = value;
                }
            }
        }
        #endregion
        
        public string paymentTypeIDRef_ { get; set; }
        
    
        
    
    }
    
}

