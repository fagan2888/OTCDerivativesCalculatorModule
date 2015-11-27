using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Bond : UnderlyingAsset
    {
        public Bond(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNode parValueNode = xmlNode.SelectSingleNode("parValue");
            
            if (parValueNode != null)
            {
                if (parValueNode.Attributes["href"] != null || parValueNode.Attributes["id"] != null) 
                {
                    if (parValueNode.Attributes["id"] != null) 
                    {
                        parValueIDRef_ = parValueNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(parValueNode);
                        IDManager.SetID(parValueIDRef_, ob);
                    }
                    else if (parValueNode.Attributes["href"] != null)
                    {
                        parValueIDRef_ = parValueNode.Attributes["href"].Value;
                    }
                    else
                    {
                        parValue_ = new XsdTypeDecimal(parValueNode);
                    }
                }
                else
                {
                    parValue_ = new XsdTypeDecimal(parValueNode);
                }
            }
            
        
            XmlNode faceAmountNode = xmlNode.SelectSingleNode("faceAmount");
            
            if (faceAmountNode != null)
            {
                if (faceAmountNode.Attributes["href"] != null || faceAmountNode.Attributes["id"] != null) 
                {
                    if (faceAmountNode.Attributes["id"] != null) 
                    {
                        faceAmountIDRef_ = faceAmountNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(faceAmountNode);
                        IDManager.SetID(faceAmountIDRef_, ob);
                    }
                    else if (faceAmountNode.Attributes["href"] != null)
                    {
                        faceAmountIDRef_ = faceAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        faceAmount_ = new XsdTypeDecimal(faceAmountNode);
                    }
                }
                else
                {
                    faceAmount_ = new XsdTypeDecimal(faceAmountNode);
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
            
        
        }
        
    
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
        #region ParValue_
        private XsdTypeDecimal parValue_;
        public XsdTypeDecimal ParValue_
        {
            get
            {
                if (this.parValue_ != null)
                {
                    return this.parValue_; 
                }
                else if (this.parValueIDRef_ != null)
                {
                    parValue_ = IDManager.getID(parValueIDRef_) as XsdTypeDecimal;
                    return this.parValue_; 
                }
                else
                {
                      return this.parValue_; 
                }
            }
            set
            {
                if (this.parValue_ != value)
                {
                    this.parValue_ = value;
                }
            }
        }
        #endregion
        
        public string parValueIDRef_ { get; set; }
        #region FaceAmount_
        private XsdTypeDecimal faceAmount_;
        public XsdTypeDecimal FaceAmount_
        {
            get
            {
                if (this.faceAmount_ != null)
                {
                    return this.faceAmount_; 
                }
                else if (this.faceAmountIDRef_ != null)
                {
                    faceAmount_ = IDManager.getID(faceAmountIDRef_) as XsdTypeDecimal;
                    return this.faceAmount_; 
                }
                else
                {
                      return this.faceAmount_; 
                }
            }
            set
            {
                if (this.faceAmount_ != value)
                {
                    this.faceAmount_ = value;
                }
            }
        }
        #endregion
        
        public string faceAmountIDRef_ { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

