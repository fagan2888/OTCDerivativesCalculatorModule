using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Payment : PaymentBase
    {
        public Payment(XmlNode xmlNode)
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
            
        
            XmlNode paymentAmountNode = xmlNode.SelectSingleNode("paymentAmount");
            
            if (paymentAmountNode != null)
            {
                if (paymentAmountNode.Attributes["href"] != null || paymentAmountNode.Attributes["id"] != null) 
                {
                    if (paymentAmountNode.Attributes["id"] != null) 
                    {
                        paymentAmountIDRef_ = paymentAmountNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(paymentAmountNode);
                        IDManager.SetID(paymentAmountIDRef_, ob);
                    }
                    else if (paymentAmountNode.Attributes["href"] != null)
                    {
                        paymentAmountIDRef_ = paymentAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentAmount_ = new NonNegativeMoney(paymentAmountNode);
                    }
                }
                else
                {
                    paymentAmount_ = new NonNegativeMoney(paymentAmountNode);
                }
            }
            
        
            XmlNode paymentDateNode = xmlNode.SelectSingleNode("paymentDate");
            
            if (paymentDateNode != null)
            {
                if (paymentDateNode.Attributes["href"] != null || paymentDateNode.Attributes["id"] != null) 
                {
                    if (paymentDateNode.Attributes["id"] != null) 
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["id"].Value;
                        AdjustableOrAdjustedDate ob = new AdjustableOrAdjustedDate(paymentDateNode);
                        IDManager.SetID(paymentDateIDRef_, ob);
                    }
                    else if (paymentDateNode.Attributes["href"] != null)
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDate_ = new AdjustableOrAdjustedDate(paymentDateNode);
                    }
                }
                else
                {
                    paymentDate_ = new AdjustableOrAdjustedDate(paymentDateNode);
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
            
        
            XmlNode settlementInformationNode = xmlNode.SelectSingleNode("settlementInformation");
            
            if (settlementInformationNode != null)
            {
                if (settlementInformationNode.Attributes["href"] != null || settlementInformationNode.Attributes["id"] != null) 
                {
                    if (settlementInformationNode.Attributes["id"] != null) 
                    {
                        settlementInformationIDRef_ = settlementInformationNode.Attributes["id"].Value;
                        SettlementInformation ob = new SettlementInformation(settlementInformationNode);
                        IDManager.SetID(settlementInformationIDRef_, ob);
                    }
                    else if (settlementInformationNode.Attributes["href"] != null)
                    {
                        settlementInformationIDRef_ = settlementInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementInformation_ = new SettlementInformation(settlementInformationNode);
                    }
                }
                else
                {
                    settlementInformation_ = new SettlementInformation(settlementInformationNode);
                }
            }
            
        
            XmlNode discountFactorNode = xmlNode.SelectSingleNode("discountFactor");
            
            if (discountFactorNode != null)
            {
                if (discountFactorNode.Attributes["href"] != null || discountFactorNode.Attributes["id"] != null) 
                {
                    if (discountFactorNode.Attributes["id"] != null) 
                    {
                        discountFactorIDRef_ = discountFactorNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(discountFactorNode);
                        IDManager.SetID(discountFactorIDRef_, ob);
                    }
                    else if (discountFactorNode.Attributes["href"] != null)
                    {
                        discountFactorIDRef_ = discountFactorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        discountFactor_ = new XsdTypeDecimal(discountFactorNode);
                    }
                }
                else
                {
                    discountFactor_ = new XsdTypeDecimal(discountFactorNode);
                }
            }
            
        
            XmlNode presentValueAmountNode = xmlNode.SelectSingleNode("presentValueAmount");
            
            if (presentValueAmountNode != null)
            {
                if (presentValueAmountNode.Attributes["href"] != null || presentValueAmountNode.Attributes["id"] != null) 
                {
                    if (presentValueAmountNode.Attributes["id"] != null) 
                    {
                        presentValueAmountIDRef_ = presentValueAmountNode.Attributes["id"].Value;
                        Money ob = new Money(presentValueAmountNode);
                        IDManager.SetID(presentValueAmountIDRef_, ob);
                    }
                    else if (presentValueAmountNode.Attributes["href"] != null)
                    {
                        presentValueAmountIDRef_ = presentValueAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        presentValueAmount_ = new Money(presentValueAmountNode);
                    }
                }
                else
                {
                    presentValueAmount_ = new Money(presentValueAmountNode);
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
        #region PaymentAmount_
        private NonNegativeMoney paymentAmount_;
        public NonNegativeMoney PaymentAmount_
        {
            get
            {
                if (this.paymentAmount_ != null)
                {
                    return this.paymentAmount_; 
                }
                else if (this.paymentAmountIDRef_ != null)
                {
                    paymentAmount_ = IDManager.getID(paymentAmountIDRef_) as NonNegativeMoney;
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
        #region PaymentDate_
        private AdjustableOrAdjustedDate paymentDate_;
        public AdjustableOrAdjustedDate PaymentDate_
        {
            get
            {
                if (this.paymentDate_ != null)
                {
                    return this.paymentDate_; 
                }
                else if (this.paymentDateIDRef_ != null)
                {
                    paymentDate_ = IDManager.getID(paymentDateIDRef_) as AdjustableOrAdjustedDate;
                    return this.paymentDate_; 
                }
                else
                {
                      return this.paymentDate_; 
                }
            }
            set
            {
                if (this.paymentDate_ != value)
                {
                    this.paymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDateIDRef_ { get; set; }
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
        #region SettlementInformation_
        private SettlementInformation settlementInformation_;
        public SettlementInformation SettlementInformation_
        {
            get
            {
                if (this.settlementInformation_ != null)
                {
                    return this.settlementInformation_; 
                }
                else if (this.settlementInformationIDRef_ != null)
                {
                    settlementInformation_ = IDManager.getID(settlementInformationIDRef_) as SettlementInformation;
                    return this.settlementInformation_; 
                }
                else
                {
                      return this.settlementInformation_; 
                }
            }
            set
            {
                if (this.settlementInformation_ != value)
                {
                    this.settlementInformation_ = value;
                }
            }
        }
        #endregion
        
        public string settlementInformationIDRef_ { get; set; }
        #region DiscountFactor_
        private XsdTypeDecimal discountFactor_;
        public XsdTypeDecimal DiscountFactor_
        {
            get
            {
                if (this.discountFactor_ != null)
                {
                    return this.discountFactor_; 
                }
                else if (this.discountFactorIDRef_ != null)
                {
                    discountFactor_ = IDManager.getID(discountFactorIDRef_) as XsdTypeDecimal;
                    return this.discountFactor_; 
                }
                else
                {
                      return this.discountFactor_; 
                }
            }
            set
            {
                if (this.discountFactor_ != value)
                {
                    this.discountFactor_ = value;
                }
            }
        }
        #endregion
        
        public string discountFactorIDRef_ { get; set; }
        #region PresentValueAmount_
        private Money presentValueAmount_;
        public Money PresentValueAmount_
        {
            get
            {
                if (this.presentValueAmount_ != null)
                {
                    return this.presentValueAmount_; 
                }
                else if (this.presentValueAmountIDRef_ != null)
                {
                    presentValueAmount_ = IDManager.getID(presentValueAmountIDRef_) as Money;
                    return this.presentValueAmount_; 
                }
                else
                {
                      return this.presentValueAmount_; 
                }
            }
            set
            {
                if (this.presentValueAmount_ != value)
                {
                    this.presentValueAmount_ = value;
                }
            }
        }
        #endregion
        
        public string presentValueAmountIDRef_ { get; set; }
        
    
        
    
    }
    
}

