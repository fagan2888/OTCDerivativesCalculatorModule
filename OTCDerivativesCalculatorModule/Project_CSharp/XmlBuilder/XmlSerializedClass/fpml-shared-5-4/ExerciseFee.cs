using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExerciseFee : ISerialized
    {
        public ExerciseFee(XmlNode xmlNode)
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
            
        
            XmlNode notionalReferenceNode = xmlNode.SelectSingleNode("notionalReference");
            
            if (notionalReferenceNode != null)
            {
                if (notionalReferenceNode.Attributes["href"] != null || notionalReferenceNode.Attributes["id"] != null) 
                {
                    if (notionalReferenceNode.Attributes["id"] != null) 
                    {
                        notionalReferenceIDRef_ = notionalReferenceNode.Attributes["id"].Value;
                        NotionalReference ob = new NotionalReference(notionalReferenceNode);
                        IDManager.SetID(notionalReferenceIDRef_, ob);
                    }
                    else if (notionalReferenceNode.Attributes["href"] != null)
                    {
                        notionalReferenceIDRef_ = notionalReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalReference_ = new NotionalReference(notionalReferenceNode);
                    }
                }
                else
                {
                    notionalReference_ = new NotionalReference(notionalReferenceNode);
                }
            }
            
        
            XmlNode feeAmountNode = xmlNode.SelectSingleNode("feeAmount");
            
            if (feeAmountNode != null)
            {
                if (feeAmountNode.Attributes["href"] != null || feeAmountNode.Attributes["id"] != null) 
                {
                    if (feeAmountNode.Attributes["id"] != null) 
                    {
                        feeAmountIDRef_ = feeAmountNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(feeAmountNode);
                        IDManager.SetID(feeAmountIDRef_, ob);
                    }
                    else if (feeAmountNode.Attributes["href"] != null)
                    {
                        feeAmountIDRef_ = feeAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        feeAmount_ = new XsdTypeDecimal(feeAmountNode);
                    }
                }
                else
                {
                    feeAmount_ = new XsdTypeDecimal(feeAmountNode);
                }
            }
            
        
            XmlNode feeRateNode = xmlNode.SelectSingleNode("feeRate");
            
            if (feeRateNode != null)
            {
                if (feeRateNode.Attributes["href"] != null || feeRateNode.Attributes["id"] != null) 
                {
                    if (feeRateNode.Attributes["id"] != null) 
                    {
                        feeRateIDRef_ = feeRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(feeRateNode);
                        IDManager.SetID(feeRateIDRef_, ob);
                    }
                    else if (feeRateNode.Attributes["href"] != null)
                    {
                        feeRateIDRef_ = feeRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        feeRate_ = new XsdTypeDecimal(feeRateNode);
                    }
                }
                else
                {
                    feeRate_ = new XsdTypeDecimal(feeRateNode);
                }
            }
            
        
            XmlNode feePaymentDateNode = xmlNode.SelectSingleNode("feePaymentDate");
            
            if (feePaymentDateNode != null)
            {
                if (feePaymentDateNode.Attributes["href"] != null || feePaymentDateNode.Attributes["id"] != null) 
                {
                    if (feePaymentDateNode.Attributes["id"] != null) 
                    {
                        feePaymentDateIDRef_ = feePaymentDateNode.Attributes["id"].Value;
                        RelativeDateOffset ob = new RelativeDateOffset(feePaymentDateNode);
                        IDManager.SetID(feePaymentDateIDRef_, ob);
                    }
                    else if (feePaymentDateNode.Attributes["href"] != null)
                    {
                        feePaymentDateIDRef_ = feePaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        feePaymentDate_ = new RelativeDateOffset(feePaymentDateNode);
                    }
                }
                else
                {
                    feePaymentDate_ = new RelativeDateOffset(feePaymentDateNode);
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
        #region NotionalReference_
        private NotionalReference notionalReference_;
        public NotionalReference NotionalReference_
        {
            get
            {
                if (this.notionalReference_ != null)
                {
                    return this.notionalReference_; 
                }
                else if (this.notionalReferenceIDRef_ != null)
                {
                    notionalReference_ = IDManager.getID(notionalReferenceIDRef_) as NotionalReference;
                    return this.notionalReference_; 
                }
                else
                {
                      return this.notionalReference_; 
                }
            }
            set
            {
                if (this.notionalReference_ != value)
                {
                    this.notionalReference_ = value;
                }
            }
        }
        #endregion
        
        public string notionalReferenceIDRef_ { get; set; }
        #region FeeAmount_
        private XsdTypeDecimal feeAmount_;
        public XsdTypeDecimal FeeAmount_
        {
            get
            {
                if (this.feeAmount_ != null)
                {
                    return this.feeAmount_; 
                }
                else if (this.feeAmountIDRef_ != null)
                {
                    feeAmount_ = IDManager.getID(feeAmountIDRef_) as XsdTypeDecimal;
                    return this.feeAmount_; 
                }
                else
                {
                      return this.feeAmount_; 
                }
            }
            set
            {
                if (this.feeAmount_ != value)
                {
                    this.feeAmount_ = value;
                }
            }
        }
        #endregion
        
        public string feeAmountIDRef_ { get; set; }
        #region FeeRate_
        private XsdTypeDecimal feeRate_;
        public XsdTypeDecimal FeeRate_
        {
            get
            {
                if (this.feeRate_ != null)
                {
                    return this.feeRate_; 
                }
                else if (this.feeRateIDRef_ != null)
                {
                    feeRate_ = IDManager.getID(feeRateIDRef_) as XsdTypeDecimal;
                    return this.feeRate_; 
                }
                else
                {
                      return this.feeRate_; 
                }
            }
            set
            {
                if (this.feeRate_ != value)
                {
                    this.feeRate_ = value;
                }
            }
        }
        #endregion
        
        public string feeRateIDRef_ { get; set; }
        #region FeePaymentDate_
        private RelativeDateOffset feePaymentDate_;
        public RelativeDateOffset FeePaymentDate_
        {
            get
            {
                if (this.feePaymentDate_ != null)
                {
                    return this.feePaymentDate_; 
                }
                else if (this.feePaymentDateIDRef_ != null)
                {
                    feePaymentDate_ = IDManager.getID(feePaymentDateIDRef_) as RelativeDateOffset;
                    return this.feePaymentDate_; 
                }
                else
                {
                      return this.feePaymentDate_; 
                }
            }
            set
            {
                if (this.feePaymentDate_ != value)
                {
                    this.feePaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string feePaymentDateIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

