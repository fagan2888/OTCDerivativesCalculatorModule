using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ExerciseFeeSchedule : ISerialized
    {
        public ExerciseFeeSchedule(XmlNode xmlNode)
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
                        ScheduleReference ob = new ScheduleReference(notionalReferenceNode);
                        IDManager.SetID(notionalReferenceIDRef_, ob);
                    }
                    else if (notionalReferenceNode.Attributes["href"] != null)
                    {
                        notionalReferenceIDRef_ = notionalReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notionalReference_ = new ScheduleReference(notionalReferenceNode);
                    }
                }
                else
                {
                    notionalReference_ = new ScheduleReference(notionalReferenceNode);
                }
            }
            
        
            XmlNode feeAmountScheduleNode = xmlNode.SelectSingleNode("feeAmountSchedule");
            
            if (feeAmountScheduleNode != null)
            {
                if (feeAmountScheduleNode.Attributes["href"] != null || feeAmountScheduleNode.Attributes["id"] != null) 
                {
                    if (feeAmountScheduleNode.Attributes["id"] != null) 
                    {
                        feeAmountScheduleIDRef_ = feeAmountScheduleNode.Attributes["id"].Value;
                        AmountSchedule ob = new AmountSchedule(feeAmountScheduleNode);
                        IDManager.SetID(feeAmountScheduleIDRef_, ob);
                    }
                    else if (feeAmountScheduleNode.Attributes["href"] != null)
                    {
                        feeAmountScheduleIDRef_ = feeAmountScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        feeAmountSchedule_ = new AmountSchedule(feeAmountScheduleNode);
                    }
                }
                else
                {
                    feeAmountSchedule_ = new AmountSchedule(feeAmountScheduleNode);
                }
            }
            
        
            XmlNode feeRateScheduleNode = xmlNode.SelectSingleNode("feeRateSchedule");
            
            if (feeRateScheduleNode != null)
            {
                if (feeRateScheduleNode.Attributes["href"] != null || feeRateScheduleNode.Attributes["id"] != null) 
                {
                    if (feeRateScheduleNode.Attributes["id"] != null) 
                    {
                        feeRateScheduleIDRef_ = feeRateScheduleNode.Attributes["id"].Value;
                        Schedule ob = new Schedule(feeRateScheduleNode);
                        IDManager.SetID(feeRateScheduleIDRef_, ob);
                    }
                    else if (feeRateScheduleNode.Attributes["href"] != null)
                    {
                        feeRateScheduleIDRef_ = feeRateScheduleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        feeRateSchedule_ = new Schedule(feeRateScheduleNode);
                    }
                }
                else
                {
                    feeRateSchedule_ = new Schedule(feeRateScheduleNode);
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
        private ScheduleReference notionalReference_;
        public ScheduleReference NotionalReference_
        {
            get
            {
                if (this.notionalReference_ != null)
                {
                    return this.notionalReference_; 
                }
                else if (this.notionalReferenceIDRef_ != null)
                {
                    notionalReference_ = IDManager.getID(notionalReferenceIDRef_) as ScheduleReference;
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
        #region FeeAmountSchedule_
        private AmountSchedule feeAmountSchedule_;
        public AmountSchedule FeeAmountSchedule_
        {
            get
            {
                if (this.feeAmountSchedule_ != null)
                {
                    return this.feeAmountSchedule_; 
                }
                else if (this.feeAmountScheduleIDRef_ != null)
                {
                    feeAmountSchedule_ = IDManager.getID(feeAmountScheduleIDRef_) as AmountSchedule;
                    return this.feeAmountSchedule_; 
                }
                else
                {
                      return this.feeAmountSchedule_; 
                }
            }
            set
            {
                if (this.feeAmountSchedule_ != value)
                {
                    this.feeAmountSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string feeAmountScheduleIDRef_ { get; set; }
        #region FeeRateSchedule_
        private Schedule feeRateSchedule_;
        public Schedule FeeRateSchedule_
        {
            get
            {
                if (this.feeRateSchedule_ != null)
                {
                    return this.feeRateSchedule_; 
                }
                else if (this.feeRateScheduleIDRef_ != null)
                {
                    feeRateSchedule_ = IDManager.getID(feeRateScheduleIDRef_) as Schedule;
                    return this.feeRateSchedule_; 
                }
                else
                {
                      return this.feeRateSchedule_; 
                }
            }
            set
            {
                if (this.feeRateSchedule_ != value)
                {
                    this.feeRateSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string feeRateScheduleIDRef_ { get; set; }
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

