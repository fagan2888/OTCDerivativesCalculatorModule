using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FeaturePayment : PaymentBase
    {
        public FeaturePayment(XmlNode xmlNode)
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
            
        
            XmlNode levelPercentageNode = xmlNode.SelectSingleNode("levelPercentage");
            
            if (levelPercentageNode != null)
            {
                if (levelPercentageNode.Attributes["href"] != null || levelPercentageNode.Attributes["id"] != null) 
                {
                    if (levelPercentageNode.Attributes["id"] != null) 
                    {
                        levelPercentageIDRef_ = levelPercentageNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(levelPercentageNode);
                        IDManager.SetID(levelPercentageIDRef_, ob);
                    }
                    else if (levelPercentageNode.Attributes["href"] != null)
                    {
                        levelPercentageIDRef_ = levelPercentageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        levelPercentage_ = new XsdTypeDecimal(levelPercentageNode);
                    }
                }
                else
                {
                    levelPercentage_ = new XsdTypeDecimal(levelPercentageNode);
                }
            }
            
        
            XmlNode amountNode = xmlNode.SelectSingleNode("amount");
            
            if (amountNode != null)
            {
                if (amountNode.Attributes["href"] != null || amountNode.Attributes["id"] != null) 
                {
                    if (amountNode.Attributes["id"] != null) 
                    {
                        amountIDRef_ = amountNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(amountNode);
                        IDManager.SetID(amountIDRef_, ob);
                    }
                    else if (amountNode.Attributes["href"] != null)
                    {
                        amountIDRef_ = amountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        amount_ = new NonNegativeDecimal(amountNode);
                    }
                }
                else
                {
                    amount_ = new NonNegativeDecimal(amountNode);
                }
            }
            
        
            XmlNode timeNode = xmlNode.SelectSingleNode("time");
            
            if (timeNode != null)
            {
                if (timeNode.Attributes["href"] != null || timeNode.Attributes["id"] != null) 
                {
                    if (timeNode.Attributes["id"] != null) 
                    {
                        timeIDRef_ = timeNode.Attributes["id"].Value;
                        TimeTypeEnum ob = new TimeTypeEnum(timeNode);
                        IDManager.SetID(timeIDRef_, ob);
                    }
                    else if (timeNode.Attributes["href"] != null)
                    {
                        timeIDRef_ = timeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        time_ = new TimeTypeEnum(timeNode);
                    }
                }
                else
                {
                    time_ = new TimeTypeEnum(timeNode);
                }
            }
            
        
            XmlNode currencyNode = xmlNode.SelectSingleNode("currency");
            
            if (currencyNode != null)
            {
                if (currencyNode.Attributes["href"] != null || currencyNode.Attributes["id"] != null) 
                {
                    if (currencyNode.Attributes["id"] != null) 
                    {
                        currencyIDRef_ = currencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(currencyNode);
                        IDManager.SetID(currencyIDRef_, ob);
                    }
                    else if (currencyNode.Attributes["href"] != null)
                    {
                        currencyIDRef_ = currencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency_ = new Currency(currencyNode);
                    }
                }
                else
                {
                    currency_ = new Currency(currencyNode);
                }
            }
            
        
            XmlNode featurePaymentDateNode = xmlNode.SelectSingleNode("featurePaymentDate");
            
            if (featurePaymentDateNode != null)
            {
                if (featurePaymentDateNode.Attributes["href"] != null || featurePaymentDateNode.Attributes["id"] != null) 
                {
                    if (featurePaymentDateNode.Attributes["id"] != null) 
                    {
                        featurePaymentDateIDRef_ = featurePaymentDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(featurePaymentDateNode);
                        IDManager.SetID(featurePaymentDateIDRef_, ob);
                    }
                    else if (featurePaymentDateNode.Attributes["href"] != null)
                    {
                        featurePaymentDateIDRef_ = featurePaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        featurePaymentDate_ = new AdjustableOrRelativeDate(featurePaymentDateNode);
                    }
                }
                else
                {
                    featurePaymentDate_ = new AdjustableOrRelativeDate(featurePaymentDateNode);
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
        #region LevelPercentage_
        private XsdTypeDecimal levelPercentage_;
        public XsdTypeDecimal LevelPercentage_
        {
            get
            {
                if (this.levelPercentage_ != null)
                {
                    return this.levelPercentage_; 
                }
                else if (this.levelPercentageIDRef_ != null)
                {
                    levelPercentage_ = IDManager.getID(levelPercentageIDRef_) as XsdTypeDecimal;
                    return this.levelPercentage_; 
                }
                else
                {
                      return this.levelPercentage_; 
                }
            }
            set
            {
                if (this.levelPercentage_ != value)
                {
                    this.levelPercentage_ = value;
                }
            }
        }
        #endregion
        
        public string levelPercentageIDRef_ { get; set; }
        #region Amount_
        private NonNegativeDecimal amount_;
        public NonNegativeDecimal Amount_
        {
            get
            {
                if (this.amount_ != null)
                {
                    return this.amount_; 
                }
                else if (this.amountIDRef_ != null)
                {
                    amount_ = IDManager.getID(amountIDRef_) as NonNegativeDecimal;
                    return this.amount_; 
                }
                else
                {
                      return this.amount_; 
                }
            }
            set
            {
                if (this.amount_ != value)
                {
                    this.amount_ = value;
                }
            }
        }
        #endregion
        
        public string amountIDRef_ { get; set; }
        #region Time_
        private TimeTypeEnum time_;
        public TimeTypeEnum Time_
        {
            get
            {
                if (this.time_ != null)
                {
                    return this.time_; 
                }
                else if (this.timeIDRef_ != null)
                {
                    time_ = IDManager.getID(timeIDRef_) as TimeTypeEnum;
                    return this.time_; 
                }
                else
                {
                      return this.time_; 
                }
            }
            set
            {
                if (this.time_ != value)
                {
                    this.time_ = value;
                }
            }
        }
        #endregion
        
        public string timeIDRef_ { get; set; }
        #region Currency_
        private Currency currency_;
        public Currency Currency_
        {
            get
            {
                if (this.currency_ != null)
                {
                    return this.currency_; 
                }
                else if (this.currencyIDRef_ != null)
                {
                    currency_ = IDManager.getID(currencyIDRef_) as Currency;
                    return this.currency_; 
                }
                else
                {
                      return this.currency_; 
                }
            }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                }
            }
        }
        #endregion
        
        public string currencyIDRef_ { get; set; }
        #region FeaturePaymentDate_
        private AdjustableOrRelativeDate featurePaymentDate_;
        public AdjustableOrRelativeDate FeaturePaymentDate_
        {
            get
            {
                if (this.featurePaymentDate_ != null)
                {
                    return this.featurePaymentDate_; 
                }
                else if (this.featurePaymentDateIDRef_ != null)
                {
                    featurePaymentDate_ = IDManager.getID(featurePaymentDateIDRef_) as AdjustableOrRelativeDate;
                    return this.featurePaymentDate_; 
                }
                else
                {
                      return this.featurePaymentDate_; 
                }
            }
            set
            {
                if (this.featurePaymentDate_ != value)
                {
                    this.featurePaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string featurePaymentDateIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

