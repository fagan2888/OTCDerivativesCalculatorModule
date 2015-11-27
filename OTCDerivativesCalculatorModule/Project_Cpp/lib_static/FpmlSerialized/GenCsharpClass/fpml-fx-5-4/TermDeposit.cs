using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TermDeposit
    {
        public TermDeposit(XmlNode xmlNode)
        : base(xmlNode)
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
            
        
            XmlNodeList startDateNodeList = xmlNode.SelectNodes("startDate");
            if (startDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in startDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        startDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(startDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        startDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        startDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList maturityDateNodeList = xmlNode.SelectNodes("maturityDate");
            if (maturityDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maturityDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maturityDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(maturityDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maturityDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maturityDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList tenorNameNodeList = xmlNode.SelectNodes("tenorName");
            if (tenorNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tenorNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tenorNameIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(tenorNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tenorNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tenorName = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList tenorPeriodNodeList = xmlNode.SelectNodes("tenorPeriod");
            if (tenorPeriodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tenorPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tenorPeriodIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(tenorPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tenorPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tenorPeriod = new Period(item);
                    }
                }
            }
            
        
            XmlNodeList principalNodeList = xmlNode.SelectNodes("principal");
            if (principalNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in principalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        principalIDRef = item.Attributes["id"].Name;
                        PositiveMoney ob = PositiveMoney();
                        IDManager.SetID(principalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        principalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        principal = new PositiveMoney(item);
                    }
                }
            }
            
        
            XmlNodeList fixedRateNodeList = xmlNode.SelectNodes("fixedRate");
            if (fixedRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedRateIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(fixedRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedRate = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList dayCountFractionNodeList = xmlNode.SelectNodes("dayCountFraction");
            if (dayCountFractionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dayCountFractionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dayCountFractionIDRef = item.Attributes["id"].Name;
                        DayCountFraction ob = DayCountFraction();
                        IDManager.SetID(dayCountFractionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dayCountFractionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dayCountFraction = new DayCountFraction(item);
                    }
                }
            }
            
        
            XmlNodeList featuresNodeList = xmlNode.SelectNodes("features");
            if (featuresNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in featuresNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        featuresIDRef = item.Attributes["id"].Name;
                        TermDepositFeatures ob = TermDepositFeatures();
                        IDManager.SetID(featuresIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        featuresIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        features = new TermDepositFeatures(item);
                    }
                }
            }
            
        
            XmlNodeList interestNodeList = xmlNode.SelectNodes("interest");
            if (interestNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interestNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interestIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(interestIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interestIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interest = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList paymentNodeList = xmlNode.SelectNodes("payment");
            
            foreach (XmlNode item in paymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentIDRef = item.Attributes["id"].Name;
                        List<Payment> ob = new List<Payment>();
                        ob.Add(new Payment(item));
                        IDManager.SetID(paymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    payment.Add(new Payment(item));
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
        #region StartDate
        private XsdTypeDate startDate;
        public XsdTypeDate StartDate
        {
            get
            {
                if (this.startDate != null)
                {
                    return this.startDate; 
                }
                else if (this.startDateIDRef != null)
                {
                    startDate = IDManager.getID(startDateIDRef) as XsdTypeDate;
                    return this.startDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.startDate != value)
                {
                    this.startDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region MaturityDate
        private XsdTypeDate maturityDate;
        public XsdTypeDate MaturityDate
        {
            get
            {
                if (this.maturityDate != null)
                {
                    return this.maturityDate; 
                }
                else if (this.maturityDateIDRef != null)
                {
                    maturityDate = IDManager.getID(maturityDateIDRef) as XsdTypeDate;
                    return this.maturityDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maturityDate != value)
                {
                    this.maturityDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region TenorName
        private XsdTypeBoolean tenorName;
        public XsdTypeBoolean TenorName
        {
            get
            {
                if (this.tenorName != null)
                {
                    return this.tenorName; 
                }
                else if (this.tenorNameIDRef != null)
                {
                    tenorName = IDManager.getID(tenorNameIDRef) as XsdTypeBoolean;
                    return this.tenorName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tenorName != value)
                {
                    this.tenorName = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region TenorPeriod
        private Period tenorPeriod;
        public Period TenorPeriod
        {
            get
            {
                if (this.tenorPeriod != null)
                {
                    return this.tenorPeriod; 
                }
                else if (this.tenorPeriodIDRef != null)
                {
                    tenorPeriod = IDManager.getID(tenorPeriodIDRef) as Period;
                    return this.tenorPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tenorPeriod != value)
                {
                    this.tenorPeriod = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region Principal
        private PositiveMoney principal;
        public PositiveMoney Principal
        {
            get
            {
                if (this.principal != null)
                {
                    return this.principal; 
                }
                else if (this.principalIDRef != null)
                {
                    principal = IDManager.getID(principalIDRef) as PositiveMoney;
                    return this.principal; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.principal != value)
                {
                    this.principal = value;
                }
            }
        }
        #endregion
        
        public string PositiveMoneyIDRef { get; set; }
        #region FixedRate
        private PositiveDecimal fixedRate;
        public PositiveDecimal FixedRate
        {
            get
            {
                if (this.fixedRate != null)
                {
                    return this.fixedRate; 
                }
                else if (this.fixedRateIDRef != null)
                {
                    fixedRate = IDManager.getID(fixedRateIDRef) as PositiveDecimal;
                    return this.fixedRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedRate != value)
                {
                    this.fixedRate = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region DayCountFraction
        private DayCountFraction dayCountFraction;
        public DayCountFraction DayCountFraction
        {
            get
            {
                if (this.dayCountFraction != null)
                {
                    return this.dayCountFraction; 
                }
                else if (this.dayCountFractionIDRef != null)
                {
                    dayCountFraction = IDManager.getID(dayCountFractionIDRef) as DayCountFraction;
                    return this.dayCountFraction; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dayCountFraction != value)
                {
                    this.dayCountFraction = value;
                }
            }
        }
        #endregion
        
        public string DayCountFractionIDRef { get; set; }
        #region Features
        private TermDepositFeatures features;
        public TermDepositFeatures Features
        {
            get
            {
                if (this.features != null)
                {
                    return this.features; 
                }
                else if (this.featuresIDRef != null)
                {
                    features = IDManager.getID(featuresIDRef) as TermDepositFeatures;
                    return this.features; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.features != value)
                {
                    this.features = value;
                }
            }
        }
        #endregion
        
        public string TermDepositFeaturesIDRef { get; set; }
        #region Interest
        private Money interest;
        public Money Interest
        {
            get
            {
                if (this.interest != null)
                {
                    return this.interest; 
                }
                else if (this.interestIDRef != null)
                {
                    interest = IDManager.getID(interestIDRef) as Money;
                    return this.interest; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interest != value)
                {
                    this.interest = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region Payment
        private List<Payment> payment;
        public List<Payment> Payment
        {
            get
            {
                if (this.payment != null)
                {
                    return this.payment; 
                }
                else if (this.paymentIDRef != null)
                {
                    payment = IDManager.getID(paymentIDRef) as List<Payment>;
                    return this.payment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payment != value)
                {
                    this.payment = value;
                }
            }
        }
        #endregion
        
        public string PaymentIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

