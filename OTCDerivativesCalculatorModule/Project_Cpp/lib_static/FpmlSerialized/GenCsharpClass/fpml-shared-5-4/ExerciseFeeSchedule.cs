using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ExerciseFeeSchedule
    {
        public ExerciseFeeSchedule(XmlNode xmlNode)
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
            
        
            XmlNodeList notionalReferenceNodeList = xmlNode.SelectNodes("notionalReference");
            if (notionalReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notionalReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notionalReferenceIDRef = item.Attributes["id"].Name;
                        ScheduleReference ob = ScheduleReference();
                        IDManager.SetID(notionalReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notionalReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notionalReference = new ScheduleReference(item);
                    }
                }
            }
            
        
            XmlNodeList feeAmountScheduleNodeList = xmlNode.SelectNodes("feeAmountSchedule");
            if (feeAmountScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in feeAmountScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        feeAmountScheduleIDRef = item.Attributes["id"].Name;
                        AmountSchedule ob = AmountSchedule();
                        IDManager.SetID(feeAmountScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        feeAmountScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        feeAmountSchedule = new AmountSchedule(item);
                    }
                }
            }
            
        
            XmlNodeList feeRateScheduleNodeList = xmlNode.SelectNodes("feeRateSchedule");
            if (feeRateScheduleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in feeRateScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        feeRateScheduleIDRef = item.Attributes["id"].Name;
                        Schedule ob = Schedule();
                        IDManager.SetID(feeRateScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        feeRateScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        feeRateSchedule = new Schedule(item);
                    }
                }
            }
            
        
            XmlNodeList feePaymentDateNodeList = xmlNode.SelectNodes("feePaymentDate");
            if (feePaymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in feePaymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        feePaymentDateIDRef = item.Attributes["id"].Name;
                        RelativeDateOffset ob = RelativeDateOffset();
                        IDManager.SetID(feePaymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        feePaymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        feePaymentDate = new RelativeDateOffset(item);
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
        #region NotionalReference
        private ScheduleReference notionalReference;
        public ScheduleReference NotionalReference
        {
            get
            {
                if (this.notionalReference != null)
                {
                    return this.notionalReference; 
                }
                else if (this.notionalReferenceIDRef != null)
                {
                    notionalReference = IDManager.getID(notionalReferenceIDRef) as ScheduleReference;
                    return this.notionalReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notionalReference != value)
                {
                    this.notionalReference = value;
                }
            }
        }
        #endregion
        
        public string ScheduleReferenceIDRef { get; set; }
        #region FeeAmountSchedule
        private AmountSchedule feeAmountSchedule;
        public AmountSchedule FeeAmountSchedule
        {
            get
            {
                if (this.feeAmountSchedule != null)
                {
                    return this.feeAmountSchedule; 
                }
                else if (this.feeAmountScheduleIDRef != null)
                {
                    feeAmountSchedule = IDManager.getID(feeAmountScheduleIDRef) as AmountSchedule;
                    return this.feeAmountSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.feeAmountSchedule != value)
                {
                    this.feeAmountSchedule = value;
                }
            }
        }
        #endregion
        
        public string AmountScheduleIDRef { get; set; }
        #region FeeRateSchedule
        private Schedule feeRateSchedule;
        public Schedule FeeRateSchedule
        {
            get
            {
                if (this.feeRateSchedule != null)
                {
                    return this.feeRateSchedule; 
                }
                else if (this.feeRateScheduleIDRef != null)
                {
                    feeRateSchedule = IDManager.getID(feeRateScheduleIDRef) as Schedule;
                    return this.feeRateSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.feeRateSchedule != value)
                {
                    this.feeRateSchedule = value;
                }
            }
        }
        #endregion
        
        public string ScheduleIDRef { get; set; }
        #region FeePaymentDate
        private RelativeDateOffset feePaymentDate;
        public RelativeDateOffset FeePaymentDate
        {
            get
            {
                if (this.feePaymentDate != null)
                {
                    return this.feePaymentDate; 
                }
                else if (this.feePaymentDateIDRef != null)
                {
                    feePaymentDate = IDManager.getID(feePaymentDateIDRef) as RelativeDateOffset;
                    return this.feePaymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.feePaymentDate != value)
                {
                    this.feePaymentDate = value;
                }
            }
        }
        #endregion
        
        public string RelativeDateOffsetIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

