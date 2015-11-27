using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InitialPayment : PaymentBase
    {
        public InitialPayment(XmlNode xmlNode)
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
            
        
            XmlNode adjustablePaymentDateNode = xmlNode.SelectSingleNode("adjustablePaymentDate");
            
            if (adjustablePaymentDateNode != null)
            {
                if (adjustablePaymentDateNode.Attributes["href"] != null || adjustablePaymentDateNode.Attributes["id"] != null) 
                {
                    if (adjustablePaymentDateNode.Attributes["id"] != null) 
                    {
                        adjustablePaymentDateIDRef_ = adjustablePaymentDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustablePaymentDateNode);
                        IDManager.SetID(adjustablePaymentDateIDRef_, ob);
                    }
                    else if (adjustablePaymentDateNode.Attributes["href"] != null)
                    {
                        adjustablePaymentDateIDRef_ = adjustablePaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustablePaymentDate_ = new XsdTypeDate(adjustablePaymentDateNode);
                    }
                }
                else
                {
                    adjustablePaymentDate_ = new XsdTypeDate(adjustablePaymentDateNode);
                }
            }
            
        
            XmlNode adjustedPaymentDateNode = xmlNode.SelectSingleNode("adjustedPaymentDate");
            
            if (adjustedPaymentDateNode != null)
            {
                if (adjustedPaymentDateNode.Attributes["href"] != null || adjustedPaymentDateNode.Attributes["id"] != null) 
                {
                    if (adjustedPaymentDateNode.Attributes["id"] != null) 
                    {
                        adjustedPaymentDateIDRef_ = adjustedPaymentDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustedPaymentDateNode);
                        IDManager.SetID(adjustedPaymentDateIDRef_, ob);
                    }
                    else if (adjustedPaymentDateNode.Attributes["href"] != null)
                    {
                        adjustedPaymentDateIDRef_ = adjustedPaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedPaymentDate_ = new XsdTypeDate(adjustedPaymentDateNode);
                    }
                }
                else
                {
                    adjustedPaymentDate_ = new XsdTypeDate(adjustedPaymentDateNode);
                }
            }
            
        
            XmlNode paymentAmountNode = xmlNode.SelectSingleNode("paymentAmount");
            
            if (paymentAmountNode != null)
            {
                if (paymentAmountNode.Attributes["href"] != null || paymentAmountNode.Attributes["id"] != null) 
                {
                    if (paymentAmountNode.Attributes["id"] != null) 
                    {
                        paymentAmountIDRef_ = paymentAmountNode.Attributes["id"].Value;
                        Money ob = new Money(paymentAmountNode);
                        IDManager.SetID(paymentAmountIDRef_, ob);
                    }
                    else if (paymentAmountNode.Attributes["href"] != null)
                    {
                        paymentAmountIDRef_ = paymentAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentAmount_ = new Money(paymentAmountNode);
                    }
                }
                else
                {
                    paymentAmount_ = new Money(paymentAmountNode);
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
        #region AdjustablePaymentDate_
        private XsdTypeDate adjustablePaymentDate_;
        public XsdTypeDate AdjustablePaymentDate_
        {
            get
            {
                if (this.adjustablePaymentDate_ != null)
                {
                    return this.adjustablePaymentDate_; 
                }
                else if (this.adjustablePaymentDateIDRef_ != null)
                {
                    adjustablePaymentDate_ = IDManager.getID(adjustablePaymentDateIDRef_) as XsdTypeDate;
                    return this.adjustablePaymentDate_; 
                }
                else
                {
                      return this.adjustablePaymentDate_; 
                }
            }
            set
            {
                if (this.adjustablePaymentDate_ != value)
                {
                    this.adjustablePaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustablePaymentDateIDRef_ { get; set; }
        #region AdjustedPaymentDate_
        private XsdTypeDate adjustedPaymentDate_;
        public XsdTypeDate AdjustedPaymentDate_
        {
            get
            {
                if (this.adjustedPaymentDate_ != null)
                {
                    return this.adjustedPaymentDate_; 
                }
                else if (this.adjustedPaymentDateIDRef_ != null)
                {
                    adjustedPaymentDate_ = IDManager.getID(adjustedPaymentDateIDRef_) as XsdTypeDate;
                    return this.adjustedPaymentDate_; 
                }
                else
                {
                      return this.adjustedPaymentDate_; 
                }
            }
            set
            {
                if (this.adjustedPaymentDate_ != value)
                {
                    this.adjustedPaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedPaymentDateIDRef_ { get; set; }
        #region PaymentAmount_
        private Money paymentAmount_;
        public Money PaymentAmount_
        {
            get
            {
                if (this.paymentAmount_ != null)
                {
                    return this.paymentAmount_; 
                }
                else if (this.paymentAmountIDRef_ != null)
                {
                    paymentAmount_ = IDManager.getID(paymentAmountIDRef_) as Money;
                    return this.paymentAmount_; 
                }
                else
                {
                      return this.paymentAmount_; 
                }
            }
            set
            {
                if (this.paymentAmount_ != value)
                {
                    this.paymentAmount_ = value;
                }
            }
        }
        #endregion
        
        public string paymentAmountIDRef_ { get; set; }
        
    
        
    
    }
    
}

