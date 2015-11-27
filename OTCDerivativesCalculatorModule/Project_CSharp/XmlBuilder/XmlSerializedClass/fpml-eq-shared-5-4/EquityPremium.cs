using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EquityPremium : PaymentBase
    {
        public EquityPremium(XmlNode xmlNode)
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
            
        
            XmlNode premiumTypeNode = xmlNode.SelectSingleNode("premiumType");
            
            if (premiumTypeNode != null)
            {
                if (premiumTypeNode.Attributes["href"] != null || premiumTypeNode.Attributes["id"] != null) 
                {
                    if (premiumTypeNode.Attributes["id"] != null) 
                    {
                        premiumTypeIDRef_ = premiumTypeNode.Attributes["id"].Value;
                        PremiumTypeEnum ob = new PremiumTypeEnum(premiumTypeNode);
                        IDManager.SetID(premiumTypeIDRef_, ob);
                    }
                    else if (premiumTypeNode.Attributes["href"] != null)
                    {
                        premiumTypeIDRef_ = premiumTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        premiumType_ = new PremiumTypeEnum(premiumTypeNode);
                    }
                }
                else
                {
                    premiumType_ = new PremiumTypeEnum(premiumTypeNode);
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
                        AdjustableDate ob = new AdjustableDate(paymentDateNode);
                        IDManager.SetID(paymentDateIDRef_, ob);
                    }
                    else if (paymentDateNode.Attributes["href"] != null)
                    {
                        paymentDateIDRef_ = paymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDate_ = new AdjustableDate(paymentDateNode);
                    }
                }
                else
                {
                    paymentDate_ = new AdjustableDate(paymentDateNode);
                }
            }
            
        
            XmlNode swapPremiumNode = xmlNode.SelectSingleNode("swapPremium");
            
            if (swapPremiumNode != null)
            {
                if (swapPremiumNode.Attributes["href"] != null || swapPremiumNode.Attributes["id"] != null) 
                {
                    if (swapPremiumNode.Attributes["id"] != null) 
                    {
                        swapPremiumIDRef_ = swapPremiumNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(swapPremiumNode);
                        IDManager.SetID(swapPremiumIDRef_, ob);
                    }
                    else if (swapPremiumNode.Attributes["href"] != null)
                    {
                        swapPremiumIDRef_ = swapPremiumNode.Attributes["href"].Value;
                    }
                    else
                    {
                        swapPremium_ = new XsdTypeBoolean(swapPremiumNode);
                    }
                }
                else
                {
                    swapPremium_ = new XsdTypeBoolean(swapPremiumNode);
                }
            }
            
        
            XmlNode pricePerOptionNode = xmlNode.SelectSingleNode("pricePerOption");
            
            if (pricePerOptionNode != null)
            {
                if (pricePerOptionNode.Attributes["href"] != null || pricePerOptionNode.Attributes["id"] != null) 
                {
                    if (pricePerOptionNode.Attributes["id"] != null) 
                    {
                        pricePerOptionIDRef_ = pricePerOptionNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(pricePerOptionNode);
                        IDManager.SetID(pricePerOptionIDRef_, ob);
                    }
                    else if (pricePerOptionNode.Attributes["href"] != null)
                    {
                        pricePerOptionIDRef_ = pricePerOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pricePerOption_ = new NonNegativeMoney(pricePerOptionNode);
                    }
                }
                else
                {
                    pricePerOption_ = new NonNegativeMoney(pricePerOptionNode);
                }
            }
            
        
            XmlNode percentageOfNotionalNode = xmlNode.SelectSingleNode("percentageOfNotional");
            
            if (percentageOfNotionalNode != null)
            {
                if (percentageOfNotionalNode.Attributes["href"] != null || percentageOfNotionalNode.Attributes["id"] != null) 
                {
                    if (percentageOfNotionalNode.Attributes["id"] != null) 
                    {
                        percentageOfNotionalIDRef_ = percentageOfNotionalNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(percentageOfNotionalNode);
                        IDManager.SetID(percentageOfNotionalIDRef_, ob);
                    }
                    else if (percentageOfNotionalNode.Attributes["href"] != null)
                    {
                        percentageOfNotionalIDRef_ = percentageOfNotionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        percentageOfNotional_ = new NonNegativeDecimal(percentageOfNotionalNode);
                    }
                }
                else
                {
                    percentageOfNotional_ = new NonNegativeDecimal(percentageOfNotionalNode);
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
        #region PremiumType_
        private PremiumTypeEnum premiumType_;
        public PremiumTypeEnum PremiumType_
        {
            get
            {
                if (this.premiumType_ != null)
                {
                    return this.premiumType_; 
                }
                else if (this.premiumTypeIDRef_ != null)
                {
                    premiumType_ = IDManager.getID(premiumTypeIDRef_) as PremiumTypeEnum;
                    return this.premiumType_; 
                }
                else
                {
                      return this.premiumType_; 
                }
            }
            set
            {
                if (this.premiumType_ != value)
                {
                    this.premiumType_ = value;
                }
            }
        }
        #endregion
        
        public string premiumTypeIDRef_ { get; set; }
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
        private AdjustableDate paymentDate_;
        public AdjustableDate PaymentDate_
        {
            get
            {
                if (this.paymentDate_ != null)
                {
                    return this.paymentDate_; 
                }
                else if (this.paymentDateIDRef_ != null)
                {
                    paymentDate_ = IDManager.getID(paymentDateIDRef_) as AdjustableDate;
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
        #region SwapPremium_
        private XsdTypeBoolean swapPremium_;
        public XsdTypeBoolean SwapPremium_
        {
            get
            {
                if (this.swapPremium_ != null)
                {
                    return this.swapPremium_; 
                }
                else if (this.swapPremiumIDRef_ != null)
                {
                    swapPremium_ = IDManager.getID(swapPremiumIDRef_) as XsdTypeBoolean;
                    return this.swapPremium_; 
                }
                else
                {
                      return this.swapPremium_; 
                }
            }
            set
            {
                if (this.swapPremium_ != value)
                {
                    this.swapPremium_ = value;
                }
            }
        }
        #endregion
        
        public string swapPremiumIDRef_ { get; set; }
        #region PricePerOption_
        private NonNegativeMoney pricePerOption_;
        public NonNegativeMoney PricePerOption_
        {
            get
            {
                if (this.pricePerOption_ != null)
                {
                    return this.pricePerOption_; 
                }
                else if (this.pricePerOptionIDRef_ != null)
                {
                    pricePerOption_ = IDManager.getID(pricePerOptionIDRef_) as NonNegativeMoney;
                    return this.pricePerOption_; 
                }
                else
                {
                      return this.pricePerOption_; 
                }
            }
            set
            {
                if (this.pricePerOption_ != value)
                {
                    this.pricePerOption_ = value;
                }
            }
        }
        #endregion
        
        public string pricePerOptionIDRef_ { get; set; }
        #region PercentageOfNotional_
        private NonNegativeDecimal percentageOfNotional_;
        public NonNegativeDecimal PercentageOfNotional_
        {
            get
            {
                if (this.percentageOfNotional_ != null)
                {
                    return this.percentageOfNotional_; 
                }
                else if (this.percentageOfNotionalIDRef_ != null)
                {
                    percentageOfNotional_ = IDManager.getID(percentageOfNotionalIDRef_) as NonNegativeDecimal;
                    return this.percentageOfNotional_; 
                }
                else
                {
                      return this.percentageOfNotional_; 
                }
            }
            set
            {
                if (this.percentageOfNotional_ != value)
                {
                    this.percentageOfNotional_ = value;
                }
            }
        }
        #endregion
        
        public string percentageOfNotionalIDRef_ { get; set; }
        
    
        
    
    }
    
}

