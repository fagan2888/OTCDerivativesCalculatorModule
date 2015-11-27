using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Mortgage
    {
        public Mortgage(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList insurerNodeList = xmlNode.SelectNodes("insurer");
            if (insurerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in insurerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        insurerIDRef = item.Attributes["id"].Name;
                        LegalEntity ob = LegalEntity();
                        IDManager.SetID(insurerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        insurerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        insurer = new LegalEntity(item);
                    }
                }
            }
            
        
            XmlNodeList insurerReferenceNodeList = xmlNode.SelectNodes("insurerReference");
            if (insurerReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in insurerReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        insurerReferenceIDRef = item.Attributes["id"].Name;
                        LegalEntityReference ob = LegalEntityReference();
                        IDManager.SetID(insurerReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        insurerReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        insurerReference = new LegalEntityReference(item);
                    }
                }
            }
            
        
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
            
        
            XmlNodeList originalPrincipalAmountNodeList = xmlNode.SelectNodes("originalPrincipalAmount");
            if (originalPrincipalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in originalPrincipalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        originalPrincipalAmountIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(originalPrincipalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        originalPrincipalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        originalPrincipalAmount = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList poolNodeList = xmlNode.SelectNodes("pool");
            if (poolNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in poolNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        poolIDRef = item.Attributes["id"].Name;
                        AssetPool ob = AssetPool();
                        IDManager.SetID(poolIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        poolIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        pool = new AssetPool(item);
                    }
                }
            }
            
        
            XmlNodeList sectorNodeList = xmlNode.SelectNodes("sector");
            if (sectorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sectorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sectorIDRef = item.Attributes["id"].Name;
                        MortgageSector ob = MortgageSector();
                        IDManager.SetID(sectorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sectorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sector = new MortgageSector(item);
                    }
                }
            }
            
        
            XmlNodeList trancheNodeList = xmlNode.SelectNodes("tranche");
            if (trancheNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in trancheNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        trancheIDRef = item.Attributes["id"].Name;
                        XsdTypeToken ob = XsdTypeToken();
                        IDManager.SetID(trancheIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        trancheIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tranche = new XsdTypeToken(item);
                    }
                }
            }
            
        
        }
        
    
        #region Insurer
        private LegalEntity insurer;
        public LegalEntity Insurer
        {
            get
            {
                if (this.insurer != null)
                {
                    return this.insurer; 
                }
                else if (this.insurerIDRef != null)
                {
                    insurer = IDManager.getID(insurerIDRef) as LegalEntity;
                    return this.insurer; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.insurer != value)
                {
                    this.insurer = value;
                }
            }
        }
        #endregion
        
        public string LegalEntityIDRef { get; set; }
        #region InsurerReference
        private LegalEntityReference insurerReference;
        public LegalEntityReference InsurerReference
        {
            get
            {
                if (this.insurerReference != null)
                {
                    return this.insurerReference; 
                }
                else if (this.insurerReferenceIDRef != null)
                {
                    insurerReference = IDManager.getID(insurerReferenceIDRef) as LegalEntityReference;
                    return this.insurerReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.insurerReference != value)
                {
                    this.insurerReference = value;
                }
            }
        }
        #endregion
        
        public string LegalEntityReferenceIDRef { get; set; }
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
        #region OriginalPrincipalAmount
        private XsdTypeDecimal originalPrincipalAmount;
        public XsdTypeDecimal OriginalPrincipalAmount
        {
            get
            {
                if (this.originalPrincipalAmount != null)
                {
                    return this.originalPrincipalAmount; 
                }
                else if (this.originalPrincipalAmountIDRef != null)
                {
                    originalPrincipalAmount = IDManager.getID(originalPrincipalAmountIDRef) as XsdTypeDecimal;
                    return this.originalPrincipalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.originalPrincipalAmount != value)
                {
                    this.originalPrincipalAmount = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Pool
        private AssetPool pool;
        public AssetPool Pool
        {
            get
            {
                if (this.pool != null)
                {
                    return this.pool; 
                }
                else if (this.poolIDRef != null)
                {
                    pool = IDManager.getID(poolIDRef) as AssetPool;
                    return this.pool; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pool != value)
                {
                    this.pool = value;
                }
            }
        }
        #endregion
        
        public string AssetPoolIDRef { get; set; }
        #region Sector
        private MortgageSector sector;
        public MortgageSector Sector
        {
            get
            {
                if (this.sector != null)
                {
                    return this.sector; 
                }
                else if (this.sectorIDRef != null)
                {
                    sector = IDManager.getID(sectorIDRef) as MortgageSector;
                    return this.sector; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sector != value)
                {
                    this.sector = value;
                }
            }
        }
        #endregion
        
        public string MortgageSectorIDRef { get; set; }
        #region Tranche
        private XsdTypeToken tranche;
        public XsdTypeToken Tranche
        {
            get
            {
                if (this.tranche != null)
                {
                    return this.tranche; 
                }
                else if (this.trancheIDRef != null)
                {
                    tranche = IDManager.getID(trancheIDRef) as XsdTypeToken;
                    return this.tranche; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tranche != value)
                {
                    this.tranche = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeTokenIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

