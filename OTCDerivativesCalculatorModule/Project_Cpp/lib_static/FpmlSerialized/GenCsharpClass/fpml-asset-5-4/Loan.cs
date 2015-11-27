using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Loan
    {
        public Loan(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList borrowerNodeList = xmlNode.SelectNodes("borrower");
            if (borrowerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in borrowerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        borrowerIDRef = item.Attributes["id"].Name;
                        LegalEntity ob = LegalEntity();
                        IDManager.SetID(borrowerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        borrowerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        borrower = new LegalEntity(item);
                    }
                }
            }
            
        
            XmlNodeList borrowerReferenceNodeList = xmlNode.SelectNodes("borrowerReference");
            if (borrowerReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in borrowerReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        borrowerReferenceIDRef = item.Attributes["id"].Name;
                        LegalEntityReference ob = LegalEntityReference();
                        IDManager.SetID(borrowerReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        borrowerReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        borrowerReference = new LegalEntityReference(item);
                    }
                }
            }
            
        
            XmlNodeList lienNodeList = xmlNode.SelectNodes("lien");
            if (lienNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in lienNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        lienIDRef = item.Attributes["id"].Name;
                        Lien ob = Lien();
                        IDManager.SetID(lienIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        lienIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        lien = new Lien(item);
                    }
                }
            }
            
        
            XmlNodeList facilityTypeNodeList = xmlNode.SelectNodes("facilityType");
            if (facilityTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in facilityTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        facilityTypeIDRef = item.Attributes["id"].Name;
                        FacilityType ob = FacilityType();
                        IDManager.SetID(facilityTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        facilityTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        facilityType = new FacilityType(item);
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
            
        
            XmlNodeList creditAgreementDateNodeList = xmlNode.SelectNodes("creditAgreementDate");
            if (creditAgreementDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditAgreementDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditAgreementDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(creditAgreementDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditAgreementDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditAgreementDate = new XsdTypeDate(item);
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
                        UnderlyingAssetTranche ob = UnderlyingAssetTranche();
                        IDManager.SetID(trancheIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        trancheIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tranche = new UnderlyingAssetTranche(item);
                    }
                }
            }
            
        
        }
        
    
        #region Borrower
        private LegalEntity borrower;
        public LegalEntity Borrower
        {
            get
            {
                if (this.borrower != null)
                {
                    return this.borrower; 
                }
                else if (this.borrowerIDRef != null)
                {
                    borrower = IDManager.getID(borrowerIDRef) as LegalEntity;
                    return this.borrower; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.borrower != value)
                {
                    this.borrower = value;
                }
            }
        }
        #endregion
        
        public string LegalEntityIDRef { get; set; }
        #region BorrowerReference
        private LegalEntityReference borrowerReference;
        public LegalEntityReference BorrowerReference
        {
            get
            {
                if (this.borrowerReference != null)
                {
                    return this.borrowerReference; 
                }
                else if (this.borrowerReferenceIDRef != null)
                {
                    borrowerReference = IDManager.getID(borrowerReferenceIDRef) as LegalEntityReference;
                    return this.borrowerReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.borrowerReference != value)
                {
                    this.borrowerReference = value;
                }
            }
        }
        #endregion
        
        public string LegalEntityReferenceIDRef { get; set; }
        #region Lien
        private Lien lien;
        public Lien Lien
        {
            get
            {
                if (this.lien != null)
                {
                    return this.lien; 
                }
                else if (this.lienIDRef != null)
                {
                    lien = IDManager.getID(lienIDRef) as Lien;
                    return this.lien; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.lien != value)
                {
                    this.lien = value;
                }
            }
        }
        #endregion
        
        public string LienIDRef { get; set; }
        #region FacilityType
        private FacilityType facilityType;
        public FacilityType FacilityType
        {
            get
            {
                if (this.facilityType != null)
                {
                    return this.facilityType; 
                }
                else if (this.facilityTypeIDRef != null)
                {
                    facilityType = IDManager.getID(facilityTypeIDRef) as FacilityType;
                    return this.facilityType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.facilityType != value)
                {
                    this.facilityType = value;
                }
            }
        }
        #endregion
        
        public string FacilityTypeIDRef { get; set; }
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
        #region CreditAgreementDate
        private XsdTypeDate creditAgreementDate;
        public XsdTypeDate CreditAgreementDate
        {
            get
            {
                if (this.creditAgreementDate != null)
                {
                    return this.creditAgreementDate; 
                }
                else if (this.creditAgreementDateIDRef != null)
                {
                    creditAgreementDate = IDManager.getID(creditAgreementDateIDRef) as XsdTypeDate;
                    return this.creditAgreementDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditAgreementDate != value)
                {
                    this.creditAgreementDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region Tranche
        private UnderlyingAssetTranche tranche;
        public UnderlyingAssetTranche Tranche
        {
            get
            {
                if (this.tranche != null)
                {
                    return this.tranche; 
                }
                else if (this.trancheIDRef != null)
                {
                    tranche = IDManager.getID(trancheIDRef) as UnderlyingAssetTranche;
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
        
        public string UnderlyingAssetTrancheIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

