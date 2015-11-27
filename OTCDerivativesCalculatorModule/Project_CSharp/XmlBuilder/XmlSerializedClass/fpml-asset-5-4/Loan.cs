using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Loan : UnderlyingAsset
    {
        public Loan(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode borrowerNode = xmlNode.SelectSingleNode("borrower");
            
            if (borrowerNode != null)
            {
                if (borrowerNode.Attributes["href"] != null || borrowerNode.Attributes["id"] != null) 
                {
                    if (borrowerNode.Attributes["id"] != null) 
                    {
                        borrowerIDRef_ = borrowerNode.Attributes["id"].Value;
                        LegalEntity ob = new LegalEntity(borrowerNode);
                        IDManager.SetID(borrowerIDRef_, ob);
                    }
                    else if (borrowerNode.Attributes["href"] != null)
                    {
                        borrowerIDRef_ = borrowerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        borrower_ = new LegalEntity(borrowerNode);
                    }
                }
                else
                {
                    borrower_ = new LegalEntity(borrowerNode);
                }
            }
            
        
            XmlNode borrowerReferenceNode = xmlNode.SelectSingleNode("borrowerReference");
            
            if (borrowerReferenceNode != null)
            {
                if (borrowerReferenceNode.Attributes["href"] != null || borrowerReferenceNode.Attributes["id"] != null) 
                {
                    if (borrowerReferenceNode.Attributes["id"] != null) 
                    {
                        borrowerReferenceIDRef_ = borrowerReferenceNode.Attributes["id"].Value;
                        LegalEntityReference ob = new LegalEntityReference(borrowerReferenceNode);
                        IDManager.SetID(borrowerReferenceIDRef_, ob);
                    }
                    else if (borrowerReferenceNode.Attributes["href"] != null)
                    {
                        borrowerReferenceIDRef_ = borrowerReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        borrowerReference_ = new LegalEntityReference(borrowerReferenceNode);
                    }
                }
                else
                {
                    borrowerReference_ = new LegalEntityReference(borrowerReferenceNode);
                }
            }
            
        
            XmlNode lienNode = xmlNode.SelectSingleNode("lien");
            
            if (lienNode != null)
            {
                if (lienNode.Attributes["href"] != null || lienNode.Attributes["id"] != null) 
                {
                    if (lienNode.Attributes["id"] != null) 
                    {
                        lienIDRef_ = lienNode.Attributes["id"].Value;
                        Lien ob = new Lien(lienNode);
                        IDManager.SetID(lienIDRef_, ob);
                    }
                    else if (lienNode.Attributes["href"] != null)
                    {
                        lienIDRef_ = lienNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lien_ = new Lien(lienNode);
                    }
                }
                else
                {
                    lien_ = new Lien(lienNode);
                }
            }
            
        
            XmlNode facilityTypeNode = xmlNode.SelectSingleNode("facilityType");
            
            if (facilityTypeNode != null)
            {
                if (facilityTypeNode.Attributes["href"] != null || facilityTypeNode.Attributes["id"] != null) 
                {
                    if (facilityTypeNode.Attributes["id"] != null) 
                    {
                        facilityTypeIDRef_ = facilityTypeNode.Attributes["id"].Value;
                        FacilityType ob = new FacilityType(facilityTypeNode);
                        IDManager.SetID(facilityTypeIDRef_, ob);
                    }
                    else if (facilityTypeNode.Attributes["href"] != null)
                    {
                        facilityTypeIDRef_ = facilityTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        facilityType_ = new FacilityType(facilityTypeNode);
                    }
                }
                else
                {
                    facilityType_ = new FacilityType(facilityTypeNode);
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
            
        
            XmlNode creditAgreementDateNode = xmlNode.SelectSingleNode("creditAgreementDate");
            
            if (creditAgreementDateNode != null)
            {
                if (creditAgreementDateNode.Attributes["href"] != null || creditAgreementDateNode.Attributes["id"] != null) 
                {
                    if (creditAgreementDateNode.Attributes["id"] != null) 
                    {
                        creditAgreementDateIDRef_ = creditAgreementDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(creditAgreementDateNode);
                        IDManager.SetID(creditAgreementDateIDRef_, ob);
                    }
                    else if (creditAgreementDateNode.Attributes["href"] != null)
                    {
                        creditAgreementDateIDRef_ = creditAgreementDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditAgreementDate_ = new XsdTypeDate(creditAgreementDateNode);
                    }
                }
                else
                {
                    creditAgreementDate_ = new XsdTypeDate(creditAgreementDateNode);
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
                        UnderlyingAssetTranche ob = new UnderlyingAssetTranche(trancheNode);
                        IDManager.SetID(trancheIDRef_, ob);
                    }
                    else if (trancheNode.Attributes["href"] != null)
                    {
                        trancheIDRef_ = trancheNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tranche_ = new UnderlyingAssetTranche(trancheNode);
                    }
                }
                else
                {
                    tranche_ = new UnderlyingAssetTranche(trancheNode);
                }
            }
            
        
        }
        
    
        #region Borrower_
        private LegalEntity borrower_;
        public LegalEntity Borrower_
        {
            get
            {
                if (this.borrower_ != null)
                {
                    return this.borrower_; 
                }
                else if (this.borrowerIDRef_ != null)
                {
                    borrower_ = IDManager.getID(borrowerIDRef_) as LegalEntity;
                    return this.borrower_; 
                }
                else
                {
                      return this.borrower_; 
                }
            }
            set
            {
                if (this.borrower_ != value)
                {
                    this.borrower_ = value;
                }
            }
        }
        #endregion
        
        public string borrowerIDRef_ { get; set; }
        #region BorrowerReference_
        private LegalEntityReference borrowerReference_;
        public LegalEntityReference BorrowerReference_
        {
            get
            {
                if (this.borrowerReference_ != null)
                {
                    return this.borrowerReference_; 
                }
                else if (this.borrowerReferenceIDRef_ != null)
                {
                    borrowerReference_ = IDManager.getID(borrowerReferenceIDRef_) as LegalEntityReference;
                    return this.borrowerReference_; 
                }
                else
                {
                      return this.borrowerReference_; 
                }
            }
            set
            {
                if (this.borrowerReference_ != value)
                {
                    this.borrowerReference_ = value;
                }
            }
        }
        #endregion
        
        public string borrowerReferenceIDRef_ { get; set; }
        #region Lien_
        private Lien lien_;
        public Lien Lien_
        {
            get
            {
                if (this.lien_ != null)
                {
                    return this.lien_; 
                }
                else if (this.lienIDRef_ != null)
                {
                    lien_ = IDManager.getID(lienIDRef_) as Lien;
                    return this.lien_; 
                }
                else
                {
                      return this.lien_; 
                }
            }
            set
            {
                if (this.lien_ != value)
                {
                    this.lien_ = value;
                }
            }
        }
        #endregion
        
        public string lienIDRef_ { get; set; }
        #region FacilityType_
        private FacilityType facilityType_;
        public FacilityType FacilityType_
        {
            get
            {
                if (this.facilityType_ != null)
                {
                    return this.facilityType_; 
                }
                else if (this.facilityTypeIDRef_ != null)
                {
                    facilityType_ = IDManager.getID(facilityTypeIDRef_) as FacilityType;
                    return this.facilityType_; 
                }
                else
                {
                      return this.facilityType_; 
                }
            }
            set
            {
                if (this.facilityType_ != value)
                {
                    this.facilityType_ = value;
                }
            }
        }
        #endregion
        
        public string facilityTypeIDRef_ { get; set; }
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
        #region CreditAgreementDate_
        private XsdTypeDate creditAgreementDate_;
        public XsdTypeDate CreditAgreementDate_
        {
            get
            {
                if (this.creditAgreementDate_ != null)
                {
                    return this.creditAgreementDate_; 
                }
                else if (this.creditAgreementDateIDRef_ != null)
                {
                    creditAgreementDate_ = IDManager.getID(creditAgreementDateIDRef_) as XsdTypeDate;
                    return this.creditAgreementDate_; 
                }
                else
                {
                      return this.creditAgreementDate_; 
                }
            }
            set
            {
                if (this.creditAgreementDate_ != value)
                {
                    this.creditAgreementDate_ = value;
                }
            }
        }
        #endregion
        
        public string creditAgreementDateIDRef_ { get; set; }
        #region Tranche_
        private UnderlyingAssetTranche tranche_;
        public UnderlyingAssetTranche Tranche_
        {
            get
            {
                if (this.tranche_ != null)
                {
                    return this.tranche_; 
                }
                else if (this.trancheIDRef_ != null)
                {
                    tranche_ = IDManager.getID(trancheIDRef_) as UnderlyingAssetTranche;
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
        
    
        
    
    }
    
}

