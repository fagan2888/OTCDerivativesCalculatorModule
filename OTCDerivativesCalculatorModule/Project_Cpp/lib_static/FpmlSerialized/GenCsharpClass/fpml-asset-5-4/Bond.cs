using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Bond
    {
        public Bond(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList issuerNameNodeList = xmlNode.SelectNodes("issuerName");
            if (issuerNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in issuerNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        issuerNameIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(issuerNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        issuerNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        issuerName = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList issuerPartyReferenceNodeList = xmlNode.SelectNodes("issuerPartyReference");
            if (issuerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in issuerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        issuerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(issuerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        issuerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        issuerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList seniorityNodeList = xmlNode.SelectNodes("seniority");
            if (seniorityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in seniorityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        seniorityIDRef = item.Attributes["id"].Name;
                        CreditSeniority ob = CreditSeniority();
                        IDManager.SetID(seniorityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        seniorityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        seniority = new CreditSeniority(item);
                    }
                }
            }
            
        
            XmlNodeList couponTypeNodeList = xmlNode.SelectNodes("couponType");
            if (couponTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in couponTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        couponTypeIDRef = item.Attributes["id"].Name;
                        CouponType ob = CouponType();
                        IDManager.SetID(couponTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        couponTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        couponType = new CouponType(item);
                    }
                }
            }
            
        
            XmlNodeList couponRateNodeList = xmlNode.SelectNodes("couponRate");
            if (couponRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in couponRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        couponRateIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(couponRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        couponRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        couponRate = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList maturityNodeList = xmlNode.SelectNodes("maturity");
            if (maturityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maturityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maturityIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(maturityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maturityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maturity = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList parValueNodeList = xmlNode.SelectNodes("parValue");
            if (parValueNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in parValueNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        parValueIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(parValueIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        parValueIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        parValue = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList faceAmountNodeList = xmlNode.SelectNodes("faceAmount");
            if (faceAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in faceAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        faceAmountIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(faceAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        faceAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        faceAmount = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList paymentFrequencyNodeList = xmlNode.SelectNodes("paymentFrequency");
            if (paymentFrequencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentFrequencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentFrequencyIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(paymentFrequencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentFrequencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentFrequency = new Period(item);
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
            
        
        }
        
    
        #region IssuerName
        private XsdTypeString issuerName;
        public XsdTypeString IssuerName
        {
            get
            {
                if (this.issuerName != null)
                {
                    return this.issuerName; 
                }
                else if (this.issuerNameIDRef != null)
                {
                    issuerName = IDManager.getID(issuerNameIDRef) as XsdTypeString;
                    return this.issuerName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.issuerName != value)
                {
                    this.issuerName = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region IssuerPartyReference
        private PartyReference issuerPartyReference;
        public PartyReference IssuerPartyReference
        {
            get
            {
                if (this.issuerPartyReference != null)
                {
                    return this.issuerPartyReference; 
                }
                else if (this.issuerPartyReferenceIDRef != null)
                {
                    issuerPartyReference = IDManager.getID(issuerPartyReferenceIDRef) as PartyReference;
                    return this.issuerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.issuerPartyReference != value)
                {
                    this.issuerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region Seniority
        private CreditSeniority seniority;
        public CreditSeniority Seniority
        {
            get
            {
                if (this.seniority != null)
                {
                    return this.seniority; 
                }
                else if (this.seniorityIDRef != null)
                {
                    seniority = IDManager.getID(seniorityIDRef) as CreditSeniority;
                    return this.seniority; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.seniority != value)
                {
                    this.seniority = value;
                }
            }
        }
        #endregion
        
        public string CreditSeniorityIDRef { get; set; }
        #region CouponType
        private CouponType couponType;
        public CouponType CouponType
        {
            get
            {
                if (this.couponType != null)
                {
                    return this.couponType; 
                }
                else if (this.couponTypeIDRef != null)
                {
                    couponType = IDManager.getID(couponTypeIDRef) as CouponType;
                    return this.couponType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.couponType != value)
                {
                    this.couponType = value;
                }
            }
        }
        #endregion
        
        public string CouponTypeIDRef { get; set; }
        #region CouponRate
        private XsdTypeDecimal couponRate;
        public XsdTypeDecimal CouponRate
        {
            get
            {
                if (this.couponRate != null)
                {
                    return this.couponRate; 
                }
                else if (this.couponRateIDRef != null)
                {
                    couponRate = IDManager.getID(couponRateIDRef) as XsdTypeDecimal;
                    return this.couponRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.couponRate != value)
                {
                    this.couponRate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Maturity
        private XsdTypeDate maturity;
        public XsdTypeDate Maturity
        {
            get
            {
                if (this.maturity != null)
                {
                    return this.maturity; 
                }
                else if (this.maturityIDRef != null)
                {
                    maturity = IDManager.getID(maturityIDRef) as XsdTypeDate;
                    return this.maturity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maturity != value)
                {
                    this.maturity = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region ParValue
        private XsdTypeDecimal parValue;
        public XsdTypeDecimal ParValue
        {
            get
            {
                if (this.parValue != null)
                {
                    return this.parValue; 
                }
                else if (this.parValueIDRef != null)
                {
                    parValue = IDManager.getID(parValueIDRef) as XsdTypeDecimal;
                    return this.parValue; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.parValue != value)
                {
                    this.parValue = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region FaceAmount
        private XsdTypeDecimal faceAmount;
        public XsdTypeDecimal FaceAmount
        {
            get
            {
                if (this.faceAmount != null)
                {
                    return this.faceAmount; 
                }
                else if (this.faceAmountIDRef != null)
                {
                    faceAmount = IDManager.getID(faceAmountIDRef) as XsdTypeDecimal;
                    return this.faceAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.faceAmount != value)
                {
                    this.faceAmount = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region PaymentFrequency
        private Period paymentFrequency;
        public Period PaymentFrequency
        {
            get
            {
                if (this.paymentFrequency != null)
                {
                    return this.paymentFrequency; 
                }
                else if (this.paymentFrequencyIDRef != null)
                {
                    paymentFrequency = IDManager.getID(paymentFrequencyIDRef) as Period;
                    return this.paymentFrequency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentFrequency != value)
                {
                    this.paymentFrequency = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

