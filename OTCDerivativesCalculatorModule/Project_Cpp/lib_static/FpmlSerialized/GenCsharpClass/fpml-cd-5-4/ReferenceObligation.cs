using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReferenceObligation
    {
        public ReferenceObligation(XmlNode xmlNode)
        {
            XmlNodeList bondNodeList = xmlNode.SelectNodes("bond");
            if (bondNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in bondNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        bondIDRef = item.Attributes["id"].Name;
                        Bond ob = Bond();
                        IDManager.SetID(bondIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        bondIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        bond = new Bond(item);
                    }
                }
            }
            
        
            XmlNodeList convertibleBondNodeList = xmlNode.SelectNodes("convertibleBond");
            if (convertibleBondNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in convertibleBondNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        convertibleBondIDRef = item.Attributes["id"].Name;
                        ConvertibleBond ob = ConvertibleBond();
                        IDManager.SetID(convertibleBondIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        convertibleBondIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        convertibleBond = new ConvertibleBond(item);
                    }
                }
            }
            
        
            XmlNodeList mortgageNodeList = xmlNode.SelectNodes("mortgage");
            if (mortgageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in mortgageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        mortgageIDRef = item.Attributes["id"].Name;
                        Mortgage ob = Mortgage();
                        IDManager.SetID(mortgageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        mortgageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        mortgage = new Mortgage(item);
                    }
                }
            }
            
        
            XmlNodeList loanNodeList = xmlNode.SelectNodes("loan");
            if (loanNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in loanNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        loanIDRef = item.Attributes["id"].Name;
                        Loan ob = Loan();
                        IDManager.SetID(loanIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        loanIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        loan = new Loan(item);
                    }
                }
            }
            
        
            XmlNodeList primaryObligorNodeList = xmlNode.SelectNodes("primaryObligor");
            if (primaryObligorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in primaryObligorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        primaryObligorIDRef = item.Attributes["id"].Name;
                        LegalEntity ob = LegalEntity();
                        IDManager.SetID(primaryObligorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        primaryObligorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        primaryObligor = new LegalEntity(item);
                    }
                }
            }
            
        
            XmlNodeList primaryObligorReferenceNodeList = xmlNode.SelectNodes("primaryObligorReference");
            if (primaryObligorReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in primaryObligorReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        primaryObligorReferenceIDRef = item.Attributes["id"].Name;
                        LegalEntityReference ob = LegalEntityReference();
                        IDManager.SetID(primaryObligorReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        primaryObligorReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        primaryObligorReference = new LegalEntityReference(item);
                    }
                }
            }
            
        
            XmlNodeList guarantorNodeList = xmlNode.SelectNodes("guarantor");
            if (guarantorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in guarantorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        guarantorIDRef = item.Attributes["id"].Name;
                        LegalEntity ob = LegalEntity();
                        IDManager.SetID(guarantorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        guarantorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        guarantor = new LegalEntity(item);
                    }
                }
            }
            
        
            XmlNodeList guarantorReferenceNodeList = xmlNode.SelectNodes("guarantorReference");
            if (guarantorReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in guarantorReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        guarantorReferenceIDRef = item.Attributes["id"].Name;
                        LegalEntityReference ob = LegalEntityReference();
                        IDManager.SetID(guarantorReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        guarantorReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        guarantorReference = new LegalEntityReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region Bond
        private Bond bond;
        public Bond Bond
        {
            get
            {
                if (this.bond != null)
                {
                    return this.bond; 
                }
                else if (this.bondIDRef != null)
                {
                    bond = IDManager.getID(bondIDRef) as Bond;
                    return this.bond; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.bond != value)
                {
                    this.bond = value;
                }
            }
        }
        #endregion
        
        public string BondIDRef { get; set; }
        #region ConvertibleBond
        private ConvertibleBond convertibleBond;
        public ConvertibleBond ConvertibleBond
        {
            get
            {
                if (this.convertibleBond != null)
                {
                    return this.convertibleBond; 
                }
                else if (this.convertibleBondIDRef != null)
                {
                    convertibleBond = IDManager.getID(convertibleBondIDRef) as ConvertibleBond;
                    return this.convertibleBond; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.convertibleBond != value)
                {
                    this.convertibleBond = value;
                }
            }
        }
        #endregion
        
        public string ConvertibleBondIDRef { get; set; }
        #region Mortgage
        private Mortgage mortgage;
        public Mortgage Mortgage
        {
            get
            {
                if (this.mortgage != null)
                {
                    return this.mortgage; 
                }
                else if (this.mortgageIDRef != null)
                {
                    mortgage = IDManager.getID(mortgageIDRef) as Mortgage;
                    return this.mortgage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.mortgage != value)
                {
                    this.mortgage = value;
                }
            }
        }
        #endregion
        
        public string MortgageIDRef { get; set; }
        #region Loan
        private Loan loan;
        public Loan Loan
        {
            get
            {
                if (this.loan != null)
                {
                    return this.loan; 
                }
                else if (this.loanIDRef != null)
                {
                    loan = IDManager.getID(loanIDRef) as Loan;
                    return this.loan; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.loan != value)
                {
                    this.loan = value;
                }
            }
        }
        #endregion
        
        public string LoanIDRef { get; set; }
        #region PrimaryObligor
        private LegalEntity primaryObligor;
        public LegalEntity PrimaryObligor
        {
            get
            {
                if (this.primaryObligor != null)
                {
                    return this.primaryObligor; 
                }
                else if (this.primaryObligorIDRef != null)
                {
                    primaryObligor = IDManager.getID(primaryObligorIDRef) as LegalEntity;
                    return this.primaryObligor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.primaryObligor != value)
                {
                    this.primaryObligor = value;
                }
            }
        }
        #endregion
        
        public string LegalEntityIDRef { get; set; }
        #region PrimaryObligorReference
        private LegalEntityReference primaryObligorReference;
        public LegalEntityReference PrimaryObligorReference
        {
            get
            {
                if (this.primaryObligorReference != null)
                {
                    return this.primaryObligorReference; 
                }
                else if (this.primaryObligorReferenceIDRef != null)
                {
                    primaryObligorReference = IDManager.getID(primaryObligorReferenceIDRef) as LegalEntityReference;
                    return this.primaryObligorReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.primaryObligorReference != value)
                {
                    this.primaryObligorReference = value;
                }
            }
        }
        #endregion
        
        public string LegalEntityReferenceIDRef { get; set; }
        #region Guarantor
        private LegalEntity guarantor;
        public LegalEntity Guarantor
        {
            get
            {
                if (this.guarantor != null)
                {
                    return this.guarantor; 
                }
                else if (this.guarantorIDRef != null)
                {
                    guarantor = IDManager.getID(guarantorIDRef) as LegalEntity;
                    return this.guarantor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.guarantor != value)
                {
                    this.guarantor = value;
                }
            }
        }
        #endregion
        
        public string LegalEntityIDRef { get; set; }
        #region GuarantorReference
        private LegalEntityReference guarantorReference;
        public LegalEntityReference GuarantorReference
        {
            get
            {
                if (this.guarantorReference != null)
                {
                    return this.guarantorReference; 
                }
                else if (this.guarantorReferenceIDRef != null)
                {
                    guarantorReference = IDManager.getID(guarantorReferenceIDRef) as LegalEntityReference;
                    return this.guarantorReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.guarantorReference != value)
                {
                    this.guarantorReference = value;
                }
            }
        }
        #endregion
        
        public string LegalEntityReferenceIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        
    
        
    
    }
    
}

