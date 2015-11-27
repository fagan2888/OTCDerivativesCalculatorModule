using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TermDeposit : Product
    {
        public TermDeposit(XmlNode xmlNode)
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
            
        
            XmlNode startDateNode = xmlNode.SelectSingleNode("startDate");
            
            if (startDateNode != null)
            {
                if (startDateNode.Attributes["href"] != null || startDateNode.Attributes["id"] != null) 
                {
                    if (startDateNode.Attributes["id"] != null) 
                    {
                        startDateIDRef_ = startDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(startDateNode);
                        IDManager.SetID(startDateIDRef_, ob);
                    }
                    else if (startDateNode.Attributes["href"] != null)
                    {
                        startDateIDRef_ = startDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        startDate_ = new XsdTypeDate(startDateNode);
                    }
                }
                else
                {
                    startDate_ = new XsdTypeDate(startDateNode);
                }
            }
            
        
            XmlNode maturityDateNode = xmlNode.SelectSingleNode("maturityDate");
            
            if (maturityDateNode != null)
            {
                if (maturityDateNode.Attributes["href"] != null || maturityDateNode.Attributes["id"] != null) 
                {
                    if (maturityDateNode.Attributes["id"] != null) 
                    {
                        maturityDateIDRef_ = maturityDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(maturityDateNode);
                        IDManager.SetID(maturityDateIDRef_, ob);
                    }
                    else if (maturityDateNode.Attributes["href"] != null)
                    {
                        maturityDateIDRef_ = maturityDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maturityDate_ = new XsdTypeDate(maturityDateNode);
                    }
                }
                else
                {
                    maturityDate_ = new XsdTypeDate(maturityDateNode);
                }
            }
            
        
            XmlNode tenorNameNode = xmlNode.SelectSingleNode("tenorName");
            
            if (tenorNameNode != null)
            {
                if (tenorNameNode.Attributes["href"] != null || tenorNameNode.Attributes["id"] != null) 
                {
                    if (tenorNameNode.Attributes["id"] != null) 
                    {
                        tenorNameIDRef_ = tenorNameNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(tenorNameNode);
                        IDManager.SetID(tenorNameIDRef_, ob);
                    }
                    else if (tenorNameNode.Attributes["href"] != null)
                    {
                        tenorNameIDRef_ = tenorNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tenorName_ = new XsdTypeBoolean(tenorNameNode);
                    }
                }
                else
                {
                    tenorName_ = new XsdTypeBoolean(tenorNameNode);
                }
            }
            
        
            XmlNode tenorPeriodNode = xmlNode.SelectSingleNode("tenorPeriod");
            
            if (tenorPeriodNode != null)
            {
                if (tenorPeriodNode.Attributes["href"] != null || tenorPeriodNode.Attributes["id"] != null) 
                {
                    if (tenorPeriodNode.Attributes["id"] != null) 
                    {
                        tenorPeriodIDRef_ = tenorPeriodNode.Attributes["id"].Value;
                        Period ob = new Period(tenorPeriodNode);
                        IDManager.SetID(tenorPeriodIDRef_, ob);
                    }
                    else if (tenorPeriodNode.Attributes["href"] != null)
                    {
                        tenorPeriodIDRef_ = tenorPeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tenorPeriod_ = new Period(tenorPeriodNode);
                    }
                }
                else
                {
                    tenorPeriod_ = new Period(tenorPeriodNode);
                }
            }
            
        
            XmlNode principalNode = xmlNode.SelectSingleNode("principal");
            
            if (principalNode != null)
            {
                if (principalNode.Attributes["href"] != null || principalNode.Attributes["id"] != null) 
                {
                    if (principalNode.Attributes["id"] != null) 
                    {
                        principalIDRef_ = principalNode.Attributes["id"].Value;
                        PositiveMoney ob = new PositiveMoney(principalNode);
                        IDManager.SetID(principalIDRef_, ob);
                    }
                    else if (principalNode.Attributes["href"] != null)
                    {
                        principalIDRef_ = principalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        principal_ = new PositiveMoney(principalNode);
                    }
                }
                else
                {
                    principal_ = new PositiveMoney(principalNode);
                }
            }
            
        
            XmlNode fixedRateNode = xmlNode.SelectSingleNode("fixedRate");
            
            if (fixedRateNode != null)
            {
                if (fixedRateNode.Attributes["href"] != null || fixedRateNode.Attributes["id"] != null) 
                {
                    if (fixedRateNode.Attributes["id"] != null) 
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(fixedRateNode);
                        IDManager.SetID(fixedRateIDRef_, ob);
                    }
                    else if (fixedRateNode.Attributes["href"] != null)
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedRate_ = new PositiveDecimal(fixedRateNode);
                    }
                }
                else
                {
                    fixedRate_ = new PositiveDecimal(fixedRateNode);
                }
            }
            
        
            XmlNode dayCountFractionNode = xmlNode.SelectSingleNode("dayCountFraction");
            
            if (dayCountFractionNode != null)
            {
                if (dayCountFractionNode.Attributes["href"] != null || dayCountFractionNode.Attributes["id"] != null) 
                {
                    if (dayCountFractionNode.Attributes["id"] != null) 
                    {
                        dayCountFractionIDRef_ = dayCountFractionNode.Attributes["id"].Value;
                        DayCountFraction ob = new DayCountFraction(dayCountFractionNode);
                        IDManager.SetID(dayCountFractionIDRef_, ob);
                    }
                    else if (dayCountFractionNode.Attributes["href"] != null)
                    {
                        dayCountFractionIDRef_ = dayCountFractionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dayCountFraction_ = new DayCountFraction(dayCountFractionNode);
                    }
                }
                else
                {
                    dayCountFraction_ = new DayCountFraction(dayCountFractionNode);
                }
            }
            
        
            XmlNode featuresNode = xmlNode.SelectSingleNode("features");
            
            if (featuresNode != null)
            {
                if (featuresNode.Attributes["href"] != null || featuresNode.Attributes["id"] != null) 
                {
                    if (featuresNode.Attributes["id"] != null) 
                    {
                        featuresIDRef_ = featuresNode.Attributes["id"].Value;
                        TermDepositFeatures ob = new TermDepositFeatures(featuresNode);
                        IDManager.SetID(featuresIDRef_, ob);
                    }
                    else if (featuresNode.Attributes["href"] != null)
                    {
                        featuresIDRef_ = featuresNode.Attributes["href"].Value;
                    }
                    else
                    {
                        features_ = new TermDepositFeatures(featuresNode);
                    }
                }
                else
                {
                    features_ = new TermDepositFeatures(featuresNode);
                }
            }
            
        
            XmlNode interestNode = xmlNode.SelectSingleNode("interest");
            
            if (interestNode != null)
            {
                if (interestNode.Attributes["href"] != null || interestNode.Attributes["id"] != null) 
                {
                    if (interestNode.Attributes["id"] != null) 
                    {
                        interestIDRef_ = interestNode.Attributes["id"].Value;
                        Money ob = new Money(interestNode);
                        IDManager.SetID(interestIDRef_, ob);
                    }
                    else if (interestNode.Attributes["href"] != null)
                    {
                        interestIDRef_ = interestNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interest_ = new Money(interestNode);
                    }
                }
                else
                {
                    interest_ = new Money(interestNode);
                }
            }
            
        
            XmlNodeList paymentNodeList = xmlNode.SelectNodes("payment");
            
            if (paymentNodeList != null)
            {
                this.payment_ = new List<Payment>();
                foreach (XmlNode item in paymentNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            paymentIDRef_ = item.Attributes["id"].Value;
                            payment_.Add(new Payment(item));
                            IDManager.SetID(paymentIDRef_, payment_[payment_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            paymentIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        payment_.Add(new Payment(item));
                        }
                    }
                    else
                    {
                        payment_.Add(new Payment(item));
                    }
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
        #region StartDate_
        private XsdTypeDate startDate_;
        public XsdTypeDate StartDate_
        {
            get
            {
                if (this.startDate_ != null)
                {
                    return this.startDate_; 
                }
                else if (this.startDateIDRef_ != null)
                {
                    startDate_ = IDManager.getID(startDateIDRef_) as XsdTypeDate;
                    return this.startDate_; 
                }
                else
                {
                      return this.startDate_; 
                }
            }
            set
            {
                if (this.startDate_ != value)
                {
                    this.startDate_ = value;
                }
            }
        }
        #endregion
        
        public string startDateIDRef_ { get; set; }
        #region MaturityDate_
        private XsdTypeDate maturityDate_;
        public XsdTypeDate MaturityDate_
        {
            get
            {
                if (this.maturityDate_ != null)
                {
                    return this.maturityDate_; 
                }
                else if (this.maturityDateIDRef_ != null)
                {
                    maturityDate_ = IDManager.getID(maturityDateIDRef_) as XsdTypeDate;
                    return this.maturityDate_; 
                }
                else
                {
                      return this.maturityDate_; 
                }
            }
            set
            {
                if (this.maturityDate_ != value)
                {
                    this.maturityDate_ = value;
                }
            }
        }
        #endregion
        
        public string maturityDateIDRef_ { get; set; }
        #region TenorName_
        private XsdTypeBoolean tenorName_;
        public XsdTypeBoolean TenorName_
        {
            get
            {
                if (this.tenorName_ != null)
                {
                    return this.tenorName_; 
                }
                else if (this.tenorNameIDRef_ != null)
                {
                    tenorName_ = IDManager.getID(tenorNameIDRef_) as XsdTypeBoolean;
                    return this.tenorName_; 
                }
                else
                {
                      return this.tenorName_; 
                }
            }
            set
            {
                if (this.tenorName_ != value)
                {
                    this.tenorName_ = value;
                }
            }
        }
        #endregion
        
        public string tenorNameIDRef_ { get; set; }
        #region TenorPeriod_
        private Period tenorPeriod_;
        public Period TenorPeriod_
        {
            get
            {
                if (this.tenorPeriod_ != null)
                {
                    return this.tenorPeriod_; 
                }
                else if (this.tenorPeriodIDRef_ != null)
                {
                    tenorPeriod_ = IDManager.getID(tenorPeriodIDRef_) as Period;
                    return this.tenorPeriod_; 
                }
                else
                {
                      return this.tenorPeriod_; 
                }
            }
            set
            {
                if (this.tenorPeriod_ != value)
                {
                    this.tenorPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string tenorPeriodIDRef_ { get; set; }
        #region Principal_
        private PositiveMoney principal_;
        public PositiveMoney Principal_
        {
            get
            {
                if (this.principal_ != null)
                {
                    return this.principal_; 
                }
                else if (this.principalIDRef_ != null)
                {
                    principal_ = IDManager.getID(principalIDRef_) as PositiveMoney;
                    return this.principal_; 
                }
                else
                {
                      return this.principal_; 
                }
            }
            set
            {
                if (this.principal_ != value)
                {
                    this.principal_ = value;
                }
            }
        }
        #endregion
        
        public string principalIDRef_ { get; set; }
        #region FixedRate_
        private PositiveDecimal fixedRate_;
        public PositiveDecimal FixedRate_
        {
            get
            {
                if (this.fixedRate_ != null)
                {
                    return this.fixedRate_; 
                }
                else if (this.fixedRateIDRef_ != null)
                {
                    fixedRate_ = IDManager.getID(fixedRateIDRef_) as PositiveDecimal;
                    return this.fixedRate_; 
                }
                else
                {
                      return this.fixedRate_; 
                }
            }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                }
            }
        }
        #endregion
        
        public string fixedRateIDRef_ { get; set; }
        #region DayCountFraction_
        private DayCountFraction dayCountFraction_;
        public DayCountFraction DayCountFraction_
        {
            get
            {
                if (this.dayCountFraction_ != null)
                {
                    return this.dayCountFraction_; 
                }
                else if (this.dayCountFractionIDRef_ != null)
                {
                    dayCountFraction_ = IDManager.getID(dayCountFractionIDRef_) as DayCountFraction;
                    return this.dayCountFraction_; 
                }
                else
                {
                      return this.dayCountFraction_; 
                }
            }
            set
            {
                if (this.dayCountFraction_ != value)
                {
                    this.dayCountFraction_ = value;
                }
            }
        }
        #endregion
        
        public string dayCountFractionIDRef_ { get; set; }
        #region Features_
        private TermDepositFeatures features_;
        public TermDepositFeatures Features_
        {
            get
            {
                if (this.features_ != null)
                {
                    return this.features_; 
                }
                else if (this.featuresIDRef_ != null)
                {
                    features_ = IDManager.getID(featuresIDRef_) as TermDepositFeatures;
                    return this.features_; 
                }
                else
                {
                      return this.features_; 
                }
            }
            set
            {
                if (this.features_ != value)
                {
                    this.features_ = value;
                }
            }
        }
        #endregion
        
        public string featuresIDRef_ { get; set; }
        #region Interest_
        private Money interest_;
        public Money Interest_
        {
            get
            {
                if (this.interest_ != null)
                {
                    return this.interest_; 
                }
                else if (this.interestIDRef_ != null)
                {
                    interest_ = IDManager.getID(interestIDRef_) as Money;
                    return this.interest_; 
                }
                else
                {
                      return this.interest_; 
                }
            }
            set
            {
                if (this.interest_ != value)
                {
                    this.interest_ = value;
                }
            }
        }
        #endregion
        
        public string interestIDRef_ { get; set; }
        #region Payment_
        private List<Payment> payment_;
        public List<Payment> Payment_
        {
            get
            {
                if (this.payment_ != null)
                {
                    return this.payment_; 
                }
                else if (this.paymentIDRef_ != null)
                {
                    return this.payment_; 
                }
                else
                {
                      return this.payment_; 
                }
            }
            set
            {
                if (this.payment_ != value)
                {
                    this.payment_ = value;
                }
            }
        }
        #endregion
        
        public string paymentIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

