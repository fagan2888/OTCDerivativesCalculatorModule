using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PrePayment : PaymentBase
    {
        public PrePayment(XmlNode xmlNode)
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
            
        
            XmlNode prePaymentNode = xmlNode.SelectSingleNode("prePayment");
            
            if (prePaymentNode != null)
            {
                if (prePaymentNode.Attributes["href"] != null || prePaymentNode.Attributes["id"] != null) 
                {
                    if (prePaymentNode.Attributes["id"] != null) 
                    {
                        prePaymentIDRef_ = prePaymentNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(prePaymentNode);
                        IDManager.SetID(prePaymentIDRef_, ob);
                    }
                    else if (prePaymentNode.Attributes["href"] != null)
                    {
                        prePaymentIDRef_ = prePaymentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        prePayment_ = new XsdTypeBoolean(prePaymentNode);
                    }
                }
                else
                {
                    prePayment_ = new XsdTypeBoolean(prePaymentNode);
                }
            }
            
        
            XmlNode prePaymentAmountNode = xmlNode.SelectSingleNode("prePaymentAmount");
            
            if (prePaymentAmountNode != null)
            {
                if (prePaymentAmountNode.Attributes["href"] != null || prePaymentAmountNode.Attributes["id"] != null) 
                {
                    if (prePaymentAmountNode.Attributes["id"] != null) 
                    {
                        prePaymentAmountIDRef_ = prePaymentAmountNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(prePaymentAmountNode);
                        IDManager.SetID(prePaymentAmountIDRef_, ob);
                    }
                    else if (prePaymentAmountNode.Attributes["href"] != null)
                    {
                        prePaymentAmountIDRef_ = prePaymentAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        prePaymentAmount_ = new NonNegativeMoney(prePaymentAmountNode);
                    }
                }
                else
                {
                    prePaymentAmount_ = new NonNegativeMoney(prePaymentAmountNode);
                }
            }
            
        
            XmlNode prePaymentDateNode = xmlNode.SelectSingleNode("prePaymentDate");
            
            if (prePaymentDateNode != null)
            {
                if (prePaymentDateNode.Attributes["href"] != null || prePaymentDateNode.Attributes["id"] != null) 
                {
                    if (prePaymentDateNode.Attributes["id"] != null) 
                    {
                        prePaymentDateIDRef_ = prePaymentDateNode.Attributes["id"].Value;
                        AdjustableDate ob = new AdjustableDate(prePaymentDateNode);
                        IDManager.SetID(prePaymentDateIDRef_, ob);
                    }
                    else if (prePaymentDateNode.Attributes["href"] != null)
                    {
                        prePaymentDateIDRef_ = prePaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        prePaymentDate_ = new AdjustableDate(prePaymentDateNode);
                    }
                }
                else
                {
                    prePaymentDate_ = new AdjustableDate(prePaymentDateNode);
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
        #region PrePayment_
        private XsdTypeBoolean prePayment_;
        public XsdTypeBoolean PrePayment_
        {
            get
            {
                if (this.prePayment_ != null)
                {
                    return this.prePayment_; 
                }
                else if (this.prePaymentIDRef_ != null)
                {
                    prePayment_ = IDManager.getID(prePaymentIDRef_) as XsdTypeBoolean;
                    return this.prePayment_; 
                }
                else
                {
                      return this.prePayment_; 
                }
            }
            set
            {
                if (this.prePayment_ != value)
                {
                    this.prePayment_ = value;
                }
            }
        }
        #endregion
        
        public string prePaymentIDRef_ { get; set; }
        #region PrePaymentAmount_
        private NonNegativeMoney prePaymentAmount_;
        public NonNegativeMoney PrePaymentAmount_
        {
            get
            {
                if (this.prePaymentAmount_ != null)
                {
                    return this.prePaymentAmount_; 
                }
                else if (this.prePaymentAmountIDRef_ != null)
                {
                    prePaymentAmount_ = IDManager.getID(prePaymentAmountIDRef_) as NonNegativeMoney;
                    return this.prePaymentAmount_; 
                }
                else
                {
                      return this.prePaymentAmount_; 
                }
            }
            set
            {
                if (this.prePaymentAmount_ != value)
                {
                    this.prePaymentAmount_ = value;
                }
            }
        }
        #endregion
        
        public string prePaymentAmountIDRef_ { get; set; }
        #region PrePaymentDate_
        private AdjustableDate prePaymentDate_;
        public AdjustableDate PrePaymentDate_
        {
            get
            {
                if (this.prePaymentDate_ != null)
                {
                    return this.prePaymentDate_; 
                }
                else if (this.prePaymentDateIDRef_ != null)
                {
                    prePaymentDate_ = IDManager.getID(prePaymentDateIDRef_) as AdjustableDate;
                    return this.prePaymentDate_; 
                }
                else
                {
                      return this.prePaymentDate_; 
                }
            }
            set
            {
                if (this.prePaymentDate_ != value)
                {
                    this.prePaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string prePaymentDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

