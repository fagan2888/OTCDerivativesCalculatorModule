using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Mortgage : UnderlyingAsset
    {
        public Mortgage(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode insurerNode = xmlNode.SelectSingleNode("insurer");
            
            if (insurerNode != null)
            {
                if (insurerNode.Attributes["href"] != null || insurerNode.Attributes["id"] != null) 
                {
                    if (insurerNode.Attributes["id"] != null) 
                    {
                        insurerIDRef_ = insurerNode.Attributes["id"].Value;
                        LegalEntity ob = new LegalEntity(insurerNode);
                        IDManager.SetID(insurerIDRef_, ob);
                    }
                    else if (insurerNode.Attributes["href"] != null)
                    {
                        insurerIDRef_ = insurerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        insurer_ = new LegalEntity(insurerNode);
                    }
                }
                else
                {
                    insurer_ = new LegalEntity(insurerNode);
                }
            }
            
        
            XmlNode insurerReferenceNode = xmlNode.SelectSingleNode("insurerReference");
            
            if (insurerReferenceNode != null)
            {
                if (insurerReferenceNode.Attributes["href"] != null || insurerReferenceNode.Attributes["id"] != null) 
                {
                    if (insurerReferenceNode.Attributes["id"] != null) 
                    {
                        insurerReferenceIDRef_ = insurerReferenceNode.Attributes["id"].Value;
                        LegalEntityReference ob = new LegalEntityReference(insurerReferenceNode);
                        IDManager.SetID(insurerReferenceIDRef_, ob);
                    }
                    else if (insurerReferenceNode.Attributes["href"] != null)
                    {
                        insurerReferenceIDRef_ = insurerReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        insurerReference_ = new LegalEntityReference(insurerReferenceNode);
                    }
                }
                else
                {
                    insurerReference_ = new LegalEntityReference(insurerReferenceNode);
                }
            }
            
        
            XmlNode issuerNameNode = xmlNode.SelectSingleNode("issuerName");
            
            if (issuerNameNode != null)
            {
                if (issuerNameNode.Attributes["href"] != null || issuerNameNode.Attributes["id"] != null) 
                {
                    if (issuerNameNode.Attributes["id"] != null) 
                    {
                        issuerNameIDRef_ = issuerNameNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(issuerNameNode);
                        IDManager.SetID(issuerNameIDRef_, ob);
                    }
                    else if (issuerNameNode.Attributes["href"] != null)
                    {
                        issuerNameIDRef_ = issuerNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        issuerName_ = new XsdTypeString(issuerNameNode);
                    }
                }
                else
                {
                    issuerName_ = new XsdTypeString(issuerNameNode);
                }
            }
            
        
            XmlNode issuerPartyReferenceNode = xmlNode.SelectSingleNode("issuerPartyReference");
            
            if (issuerPartyReferenceNode != null)
            {
                if (issuerPartyReferenceNode.Attributes["href"] != null || issuerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (issuerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        issuerPartyReferenceIDRef_ = issuerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(issuerPartyReferenceNode);
                        IDManager.SetID(issuerPartyReferenceIDRef_, ob);
                    }
                    else if (issuerPartyReferenceNode.Attributes["href"] != null)
                    {
                        issuerPartyReferenceIDRef_ = issuerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        issuerPartyReference_ = new PartyReference(issuerPartyReferenceNode);
                    }
                }
                else
                {
                    issuerPartyReference_ = new PartyReference(issuerPartyReferenceNode);
                }
            }
            
        
            XmlNode seniorityNode = xmlNode.SelectSingleNode("seniority");
            
            if (seniorityNode != null)
            {
                if (seniorityNode.Attributes["href"] != null || seniorityNode.Attributes["id"] != null) 
                {
                    if (seniorityNode.Attributes["id"] != null) 
                    {
                        seniorityIDRef_ = seniorityNode.Attributes["id"].Value;
                        CreditSeniority ob = new CreditSeniority(seniorityNode);
                        IDManager.SetID(seniorityIDRef_, ob);
                    }
                    else if (seniorityNode.Attributes["href"] != null)
                    {
                        seniorityIDRef_ = seniorityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        seniority_ = new CreditSeniority(seniorityNode);
                    }
                }
                else
                {
                    seniority_ = new CreditSeniority(seniorityNode);
                }
            }
            
        
            XmlNode couponTypeNode = xmlNode.SelectSingleNode("couponType");
            
            if (couponTypeNode != null)
            {
                if (couponTypeNode.Attributes["href"] != null || couponTypeNode.Attributes["id"] != null) 
                {
                    if (couponTypeNode.Attributes["id"] != null) 
                    {
                        couponTypeIDRef_ = couponTypeNode.Attributes["id"].Value;
                        CouponType ob = new CouponType(couponTypeNode);
                        IDManager.SetID(couponTypeIDRef_, ob);
                    }
                    else if (couponTypeNode.Attributes["href"] != null)
                    {
                        couponTypeIDRef_ = couponTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        couponType_ = new CouponType(couponTypeNode);
                    }
                }
                else
                {
                    couponType_ = new CouponType(couponTypeNode);
                }
            }
            
        
            XmlNode couponRateNode = xmlNode.SelectSingleNode("couponRate");
            
            if (couponRateNode != null)
            {
                if (couponRateNode.Attributes["href"] != null || couponRateNode.Attributes["id"] != null) 
                {
                    if (couponRateNode.Attributes["id"] != null) 
                    {
                        couponRateIDRef_ = couponRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(couponRateNode);
                        IDManager.SetID(couponRateIDRef_, ob);
                    }
                    else if (couponRateNode.Attributes["href"] != null)
                    {
                        couponRateIDRef_ = couponRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        couponRate_ = new XsdTypeDecimal(couponRateNode);
                    }
                }
                else
                {
                    couponRate_ = new XsdTypeDecimal(couponRateNode);
                }
            }
            
        
            XmlNode maturityNode = xmlNode.SelectSingleNode("maturity");
            
            if (maturityNode != null)
            {
                if (maturityNode.Attributes["href"] != null || maturityNode.Attributes["id"] != null) 
                {
                    if (maturityNode.Attributes["id"] != null) 
                    {
                        maturityIDRef_ = maturityNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(maturityNode);
                        IDManager.SetID(maturityIDRef_, ob);
                    }
                    else if (maturityNode.Attributes["href"] != null)
                    {
                        maturityIDRef_ = maturityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maturity_ = new XsdTypeDate(maturityNode);
                    }
                }
                else
                {
                    maturity_ = new XsdTypeDate(maturityNode);
                }
            }
            
        
            XmlNode paymentFrequencyNode = xmlNode.SelectSingleNode("paymentFrequency");
            
            if (paymentFrequencyNode != null)
            {
                if (paymentFrequencyNode.Attributes["href"] != null || paymentFrequencyNode.Attributes["id"] != null) 
                {
                    if (paymentFrequencyNode.Attributes["id"] != null) 
                    {
                        paymentFrequencyIDRef_ = paymentFrequencyNode.Attributes["id"].Value;
                        Period ob = new Period(paymentFrequencyNode);
                        IDManager.SetID(paymentFrequencyIDRef_, ob);
                    }
                    else if (paymentFrequencyNode.Attributes["href"] != null)
                    {
                        paymentFrequencyIDRef_ = paymentFrequencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentFrequency_ = new Period(paymentFrequencyNode);
                    }
                }
                else
                {
                    paymentFrequency_ = new Period(paymentFrequencyNode);
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
            
        
            XmlNode originalPrincipalAmountNode = xmlNode.SelectSingleNode("originalPrincipalAmount");
            
            if (originalPrincipalAmountNode != null)
            {
                if (originalPrincipalAmountNode.Attributes["href"] != null || originalPrincipalAmountNode.Attributes["id"] != null) 
                {
                    if (originalPrincipalAmountNode.Attributes["id"] != null) 
                    {
                        originalPrincipalAmountIDRef_ = originalPrincipalAmountNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(originalPrincipalAmountNode);
                        IDManager.SetID(originalPrincipalAmountIDRef_, ob);
                    }
                    else if (originalPrincipalAmountNode.Attributes["href"] != null)
                    {
                        originalPrincipalAmountIDRef_ = originalPrincipalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        originalPrincipalAmount_ = new XsdTypeDecimal(originalPrincipalAmountNode);
                    }
                }
                else
                {
                    originalPrincipalAmount_ = new XsdTypeDecimal(originalPrincipalAmountNode);
                }
            }
            
        
            XmlNode poolNode = xmlNode.SelectSingleNode("pool");
            
            if (poolNode != null)
            {
                if (poolNode.Attributes["href"] != null || poolNode.Attributes["id"] != null) 
                {
                    if (poolNode.Attributes["id"] != null) 
                    {
                        poolIDRef_ = poolNode.Attributes["id"].Value;
                        AssetPool ob = new AssetPool(poolNode);
                        IDManager.SetID(poolIDRef_, ob);
                    }
                    else if (poolNode.Attributes["href"] != null)
                    {
                        poolIDRef_ = poolNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pool_ = new AssetPool(poolNode);
                    }
                }
                else
                {
                    pool_ = new AssetPool(poolNode);
                }
            }
            
        
            XmlNode sectorNode = xmlNode.SelectSingleNode("sector");
            
            if (sectorNode != null)
            {
                if (sectorNode.Attributes["href"] != null || sectorNode.Attributes["id"] != null) 
                {
                    if (sectorNode.Attributes["id"] != null) 
                    {
                        sectorIDRef_ = sectorNode.Attributes["id"].Value;
                        MortgageSector ob = new MortgageSector(sectorNode);
                        IDManager.SetID(sectorIDRef_, ob);
                    }
                    else if (sectorNode.Attributes["href"] != null)
                    {
                        sectorIDRef_ = sectorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sector_ = new MortgageSector(sectorNode);
                    }
                }
                else
                {
                    sector_ = new MortgageSector(sectorNode);
                }
            }
            
        
            XmlNode trancheNode = xmlNode.SelectSingleNode("tranche");
            
            if (trancheNode != null)
            {
                if (trancheNode.Attributes["href"] != null || trancheNode.Attributes["id"] != null) 
                {
                    if (trancheNode.Attributes["id"] != null) 
                    {
                        trancheIDRef_ = trancheNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(trancheNode);
                        IDManager.SetID(trancheIDRef_, ob);
                    }
                    else if (trancheNode.Attributes["href"] != null)
                    {
                        trancheIDRef_ = trancheNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tranche_ = new XsdTypeToken(trancheNode);
                    }
                }
                else
                {
                    tranche_ = new XsdTypeToken(trancheNode);
                }
            }
            
        
        }
        
    
        #region Insurer_
        private LegalEntity insurer_;
        public LegalEntity Insurer_
        {
            get
            {
                if (this.insurer_ != null)
                {
                    return this.insurer_; 
                }
                else if (this.insurerIDRef_ != null)
                {
                    insurer_ = IDManager.getID(insurerIDRef_) as LegalEntity;
                    return this.insurer_; 
                }
                else
                {
                      return this.insurer_; 
                }
            }
            set
            {
                if (this.insurer_ != value)
                {
                    this.insurer_ = value;
                }
            }
        }
        #endregion
        
        public string insurerIDRef_ { get; set; }
        #region InsurerReference_
        private LegalEntityReference insurerReference_;
        public LegalEntityReference InsurerReference_
        {
            get
            {
                if (this.insurerReference_ != null)
                {
                    return this.insurerReference_; 
                }
                else if (this.insurerReferenceIDRef_ != null)
                {
                    insurerReference_ = IDManager.getID(insurerReferenceIDRef_) as LegalEntityReference;
                    return this.insurerReference_; 
                }
                else
                {
                      return this.insurerReference_; 
                }
            }
            set
            {
                if (this.insurerReference_ != value)
                {
                    this.insurerReference_ = value;
                }
            }
        }
        #endregion
        
        public string insurerReferenceIDRef_ { get; set; }
        #region IssuerName_
        private XsdTypeString issuerName_;
        public XsdTypeString IssuerName_
        {
            get
            {
                if (this.issuerName_ != null)
                {
                    return this.issuerName_; 
                }
                else if (this.issuerNameIDRef_ != null)
                {
                    issuerName_ = IDManager.getID(issuerNameIDRef_) as XsdTypeString;
                    return this.issuerName_; 
                }
                else
                {
                      return this.issuerName_; 
                }
            }
            set
            {
                if (this.issuerName_ != value)
                {
                    this.issuerName_ = value;
                }
            }
        }
        #endregion
        
        public string issuerNameIDRef_ { get; set; }
        #region IssuerPartyReference_
        private PartyReference issuerPartyReference_;
        public PartyReference IssuerPartyReference_
        {
            get
            {
                if (this.issuerPartyReference_ != null)
                {
                    return this.issuerPartyReference_; 
                }
                else if (this.issuerPartyReferenceIDRef_ != null)
                {
                    issuerPartyReference_ = IDManager.getID(issuerPartyReferenceIDRef_) as PartyReference;
                    return this.issuerPartyReference_; 
                }
                else
                {
                      return this.issuerPartyReference_; 
                }
            }
            set
            {
                if (this.issuerPartyReference_ != value)
                {
                    this.issuerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string issuerPartyReferenceIDRef_ { get; set; }
        #region Seniority_
        private CreditSeniority seniority_;
        public CreditSeniority Seniority_
        {
            get
            {
                if (this.seniority_ != null)
                {
                    return this.seniority_; 
                }
                else if (this.seniorityIDRef_ != null)
                {
                    seniority_ = IDManager.getID(seniorityIDRef_) as CreditSeniority;
                    return this.seniority_; 
                }
                else
                {
                      return this.seniority_; 
                }
            }
            set
            {
                if (this.seniority_ != value)
                {
                    this.seniority_ = value;
                }
            }
        }
        #endregion
        
        public string seniorityIDRef_ { get; set; }
        #region CouponType_
        private CouponType couponType_;
        public CouponType CouponType_
        {
            get
            {
                if (this.couponType_ != null)
                {
                    return this.couponType_; 
                }
                else if (this.couponTypeIDRef_ != null)
                {
                    couponType_ = IDManager.getID(couponTypeIDRef_) as CouponType;
                    return this.couponType_; 
                }
                else
                {
                      return this.couponType_; 
                }
            }
            set
            {
                if (this.couponType_ != value)
                {
                    this.couponType_ = value;
                }
            }
        }
        #endregion
        
        public string couponTypeIDRef_ { get; set; }
        #region CouponRate_
        private XsdTypeDecimal couponRate_;
        public XsdTypeDecimal CouponRate_
        {
            get
            {
                if (this.couponRate_ != null)
                {
                    return this.couponRate_; 
                }
                else if (this.couponRateIDRef_ != null)
                {
                    couponRate_ = IDManager.getID(couponRateIDRef_) as XsdTypeDecimal;
                    return this.couponRate_; 
                }
                else
                {
                      return this.couponRate_; 
                }
            }
            set
            {
                if (this.couponRate_ != value)
                {
                    this.couponRate_ = value;
                }
            }
        }
        #endregion
        
        public string couponRateIDRef_ { get; set; }
        #region Maturity_
        private XsdTypeDate maturity_;
        public XsdTypeDate Maturity_
        {
            get
            {
                if (this.maturity_ != null)
                {
                    return this.maturity_; 
                }
                else if (this.maturityIDRef_ != null)
                {
                    maturity_ = IDManager.getID(maturityIDRef_) as XsdTypeDate;
                    return this.maturity_; 
                }
                else
                {
                      return this.maturity_; 
                }
            }
            set
            {
                if (this.maturity_ != value)
                {
                    this.maturity_ = value;
                }
            }
        }
        #endregion
        
        public string maturityIDRef_ { get; set; }
        #region PaymentFrequency_
        private Period paymentFrequency_;
        public Period PaymentFrequency_
        {
            get
            {
                if (this.paymentFrequency_ != null)
                {
                    return this.paymentFrequency_; 
                }
                else if (this.paymentFrequencyIDRef_ != null)
                {
                    paymentFrequency_ = IDManager.getID(paymentFrequencyIDRef_) as Period;
                    return this.paymentFrequency_; 
                }
                else
                {
                      return this.paymentFrequency_; 
                }
            }
            set
            {
                if (this.paymentFrequency_ != value)
                {
                    this.paymentFrequency_ = value;
                }
            }
        }
        #endregion
        
        public string paymentFrequencyIDRef_ { get; set; }
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
        #region OriginalPrincipalAmount_
        private XsdTypeDecimal originalPrincipalAmount_;
        public XsdTypeDecimal OriginalPrincipalAmount_
        {
            get
            {
                if (this.originalPrincipalAmount_ != null)
                {
                    return this.originalPrincipalAmount_; 
                }
                else if (this.originalPrincipalAmountIDRef_ != null)
                {
                    originalPrincipalAmount_ = IDManager.getID(originalPrincipalAmountIDRef_) as XsdTypeDecimal;
                    return this.originalPrincipalAmount_; 
                }
                else
                {
                      return this.originalPrincipalAmount_; 
                }
            }
            set
            {
                if (this.originalPrincipalAmount_ != value)
                {
                    this.originalPrincipalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string originalPrincipalAmountIDRef_ { get; set; }
        #region Pool_
        private AssetPool pool_;
        public AssetPool Pool_
        {
            get
            {
                if (this.pool_ != null)
                {
                    return this.pool_; 
                }
                else if (this.poolIDRef_ != null)
                {
                    pool_ = IDManager.getID(poolIDRef_) as AssetPool;
                    return this.pool_; 
                }
                else
                {
                      return this.pool_; 
                }
            }
            set
            {
                if (this.pool_ != value)
                {
                    this.pool_ = value;
                }
            }
        }
        #endregion
        
        public string poolIDRef_ { get; set; }
        #region Sector_
        private MortgageSector sector_;
        public MortgageSector Sector_
        {
            get
            {
                if (this.sector_ != null)
                {
                    return this.sector_; 
                }
                else if (this.sectorIDRef_ != null)
                {
                    sector_ = IDManager.getID(sectorIDRef_) as MortgageSector;
                    return this.sector_; 
                }
                else
                {
                      return this.sector_; 
                }
            }
            set
            {
                if (this.sector_ != value)
                {
                    this.sector_ = value;
                }
            }
        }
        #endregion
        
        public string sectorIDRef_ { get; set; }
        #region Tranche_
        private XsdTypeToken tranche_;
        public XsdTypeToken Tranche_
        {
            get
            {
                if (this.tranche_ != null)
                {
                    return this.tranche_; 
                }
                else if (this.trancheIDRef_ != null)
                {
                    tranche_ = IDManager.getID(trancheIDRef_) as XsdTypeToken;
                    return this.tranche_; 
                }
                else
                {
                      return this.tranche_; 
                }
            }
            set
            {
                if (this.tranche_ != value)
                {
                    this.tranche_ = value;
                }
            }
        }
        #endregion
        
        public string trancheIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

