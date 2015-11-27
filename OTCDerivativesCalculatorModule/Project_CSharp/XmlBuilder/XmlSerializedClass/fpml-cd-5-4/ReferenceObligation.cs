using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReferenceObligation : ISerialized
    {
        public ReferenceObligation(XmlNode xmlNode)
        {
            XmlNode bondNode = xmlNode.SelectSingleNode("bond");
            
            if (bondNode != null)
            {
                if (bondNode.Attributes["href"] != null || bondNode.Attributes["id"] != null) 
                {
                    if (bondNode.Attributes["id"] != null) 
                    {
                        bondIDRef_ = bondNode.Attributes["id"].Value;
                        Bond ob = new Bond(bondNode);
                        IDManager.SetID(bondIDRef_, ob);
                    }
                    else if (bondNode.Attributes["href"] != null)
                    {
                        bondIDRef_ = bondNode.Attributes["href"].Value;
                    }
                    else
                    {
                        bond_ = new Bond(bondNode);
                    }
                }
                else
                {
                    bond_ = new Bond(bondNode);
                }
            }
            
        
            XmlNode convertibleBondNode = xmlNode.SelectSingleNode("convertibleBond");
            
            if (convertibleBondNode != null)
            {
                if (convertibleBondNode.Attributes["href"] != null || convertibleBondNode.Attributes["id"] != null) 
                {
                    if (convertibleBondNode.Attributes["id"] != null) 
                    {
                        convertibleBondIDRef_ = convertibleBondNode.Attributes["id"].Value;
                        ConvertibleBond ob = new ConvertibleBond(convertibleBondNode);
                        IDManager.SetID(convertibleBondIDRef_, ob);
                    }
                    else if (convertibleBondNode.Attributes["href"] != null)
                    {
                        convertibleBondIDRef_ = convertibleBondNode.Attributes["href"].Value;
                    }
                    else
                    {
                        convertibleBond_ = new ConvertibleBond(convertibleBondNode);
                    }
                }
                else
                {
                    convertibleBond_ = new ConvertibleBond(convertibleBondNode);
                }
            }
            
        
            XmlNode mortgageNode = xmlNode.SelectSingleNode("mortgage");
            
            if (mortgageNode != null)
            {
                if (mortgageNode.Attributes["href"] != null || mortgageNode.Attributes["id"] != null) 
                {
                    if (mortgageNode.Attributes["id"] != null) 
                    {
                        mortgageIDRef_ = mortgageNode.Attributes["id"].Value;
                        Mortgage ob = new Mortgage(mortgageNode);
                        IDManager.SetID(mortgageIDRef_, ob);
                    }
                    else if (mortgageNode.Attributes["href"] != null)
                    {
                        mortgageIDRef_ = mortgageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        mortgage_ = new Mortgage(mortgageNode);
                    }
                }
                else
                {
                    mortgage_ = new Mortgage(mortgageNode);
                }
            }
            
        
            XmlNode loanNode = xmlNode.SelectSingleNode("loan");
            
            if (loanNode != null)
            {
                if (loanNode.Attributes["href"] != null || loanNode.Attributes["id"] != null) 
                {
                    if (loanNode.Attributes["id"] != null) 
                    {
                        loanIDRef_ = loanNode.Attributes["id"].Value;
                        Loan ob = new Loan(loanNode);
                        IDManager.SetID(loanIDRef_, ob);
                    }
                    else if (loanNode.Attributes["href"] != null)
                    {
                        loanIDRef_ = loanNode.Attributes["href"].Value;
                    }
                    else
                    {
                        loan_ = new Loan(loanNode);
                    }
                }
                else
                {
                    loan_ = new Loan(loanNode);
                }
            }
            
        
            XmlNode primaryObligorNode = xmlNode.SelectSingleNode("primaryObligor");
            
            if (primaryObligorNode != null)
            {
                if (primaryObligorNode.Attributes["href"] != null || primaryObligorNode.Attributes["id"] != null) 
                {
                    if (primaryObligorNode.Attributes["id"] != null) 
                    {
                        primaryObligorIDRef_ = primaryObligorNode.Attributes["id"].Value;
                        LegalEntity ob = new LegalEntity(primaryObligorNode);
                        IDManager.SetID(primaryObligorIDRef_, ob);
                    }
                    else if (primaryObligorNode.Attributes["href"] != null)
                    {
                        primaryObligorIDRef_ = primaryObligorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        primaryObligor_ = new LegalEntity(primaryObligorNode);
                    }
                }
                else
                {
                    primaryObligor_ = new LegalEntity(primaryObligorNode);
                }
            }
            
        
            XmlNode primaryObligorReferenceNode = xmlNode.SelectSingleNode("primaryObligorReference");
            
            if (primaryObligorReferenceNode != null)
            {
                if (primaryObligorReferenceNode.Attributes["href"] != null || primaryObligorReferenceNode.Attributes["id"] != null) 
                {
                    if (primaryObligorReferenceNode.Attributes["id"] != null) 
                    {
                        primaryObligorReferenceIDRef_ = primaryObligorReferenceNode.Attributes["id"].Value;
                        LegalEntityReference ob = new LegalEntityReference(primaryObligorReferenceNode);
                        IDManager.SetID(primaryObligorReferenceIDRef_, ob);
                    }
                    else if (primaryObligorReferenceNode.Attributes["href"] != null)
                    {
                        primaryObligorReferenceIDRef_ = primaryObligorReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        primaryObligorReference_ = new LegalEntityReference(primaryObligorReferenceNode);
                    }
                }
                else
                {
                    primaryObligorReference_ = new LegalEntityReference(primaryObligorReferenceNode);
                }
            }
            
        
            XmlNode guarantorNode = xmlNode.SelectSingleNode("guarantor");
            
            if (guarantorNode != null)
            {
                if (guarantorNode.Attributes["href"] != null || guarantorNode.Attributes["id"] != null) 
                {
                    if (guarantorNode.Attributes["id"] != null) 
                    {
                        guarantorIDRef_ = guarantorNode.Attributes["id"].Value;
                        LegalEntity ob = new LegalEntity(guarantorNode);
                        IDManager.SetID(guarantorIDRef_, ob);
                    }
                    else if (guarantorNode.Attributes["href"] != null)
                    {
                        guarantorIDRef_ = guarantorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        guarantor_ = new LegalEntity(guarantorNode);
                    }
                }
                else
                {
                    guarantor_ = new LegalEntity(guarantorNode);
                }
            }
            
        
            XmlNode guarantorReferenceNode = xmlNode.SelectSingleNode("guarantorReference");
            
            if (guarantorReferenceNode != null)
            {
                if (guarantorReferenceNode.Attributes["href"] != null || guarantorReferenceNode.Attributes["id"] != null) 
                {
                    if (guarantorReferenceNode.Attributes["id"] != null) 
                    {
                        guarantorReferenceIDRef_ = guarantorReferenceNode.Attributes["id"].Value;
                        LegalEntityReference ob = new LegalEntityReference(guarantorReferenceNode);
                        IDManager.SetID(guarantorReferenceIDRef_, ob);
                    }
                    else if (guarantorReferenceNode.Attributes["href"] != null)
                    {
                        guarantorReferenceIDRef_ = guarantorReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        guarantorReference_ = new LegalEntityReference(guarantorReferenceNode);
                    }
                }
                else
                {
                    guarantorReference_ = new LegalEntityReference(guarantorReferenceNode);
                }
            }
            
        
        }
        
    
        #region Bond_
        private Bond bond_;
        public Bond Bond_
        {
            get
            {
                if (this.bond_ != null)
                {
                    return this.bond_; 
                }
                else if (this.bondIDRef_ != null)
                {
                    bond_ = IDManager.getID(bondIDRef_) as Bond;
                    return this.bond_; 
                }
                else
                {
                      return this.bond_; 
                }
            }
            set
            {
                if (this.bond_ != value)
                {
                    this.bond_ = value;
                }
            }
        }
        #endregion
        
        public string bondIDRef_ { get; set; }
        #region ConvertibleBond_
        private ConvertibleBond convertibleBond_;
        public ConvertibleBond ConvertibleBond_
        {
            get
            {
                if (this.convertibleBond_ != null)
                {
                    return this.convertibleBond_; 
                }
                else if (this.convertibleBondIDRef_ != null)
                {
                    convertibleBond_ = IDManager.getID(convertibleBondIDRef_) as ConvertibleBond;
                    return this.convertibleBond_; 
                }
                else
                {
                      return this.convertibleBond_; 
                }
            }
            set
            {
                if (this.convertibleBond_ != value)
                {
                    this.convertibleBond_ = value;
                }
            }
        }
        #endregion
        
        public string convertibleBondIDRef_ { get; set; }
        #region Mortgage_
        private Mortgage mortgage_;
        public Mortgage Mortgage_
        {
            get
            {
                if (this.mortgage_ != null)
                {
                    return this.mortgage_; 
                }
                else if (this.mortgageIDRef_ != null)
                {
                    mortgage_ = IDManager.getID(mortgageIDRef_) as Mortgage;
                    return this.mortgage_; 
                }
                else
                {
                      return this.mortgage_; 
                }
            }
            set
            {
                if (this.mortgage_ != value)
                {
                    this.mortgage_ = value;
                }
            }
        }
        #endregion
        
        public string mortgageIDRef_ { get; set; }
        #region Loan_
        private Loan loan_;
        public Loan Loan_
        {
            get
            {
                if (this.loan_ != null)
                {
                    return this.loan_; 
                }
                else if (this.loanIDRef_ != null)
                {
                    loan_ = IDManager.getID(loanIDRef_) as Loan;
                    return this.loan_; 
                }
                else
                {
                      return this.loan_; 
                }
            }
            set
            {
                if (this.loan_ != value)
                {
                    this.loan_ = value;
                }
            }
        }
        #endregion
        
        public string loanIDRef_ { get; set; }
        #region PrimaryObligor_
        private LegalEntity primaryObligor_;
        public LegalEntity PrimaryObligor_
        {
            get
            {
                if (this.primaryObligor_ != null)
                {
                    return this.primaryObligor_; 
                }
                else if (this.primaryObligorIDRef_ != null)
                {
                    primaryObligor_ = IDManager.getID(primaryObligorIDRef_) as LegalEntity;
                    return this.primaryObligor_; 
                }
                else
                {
                      return this.primaryObligor_; 
                }
            }
            set
            {
                if (this.primaryObligor_ != value)
                {
                    this.primaryObligor_ = value;
                }
            }
        }
        #endregion
        
        public string primaryObligorIDRef_ { get; set; }
        #region PrimaryObligorReference_
        private LegalEntityReference primaryObligorReference_;
        public LegalEntityReference PrimaryObligorReference_
        {
            get
            {
                if (this.primaryObligorReference_ != null)
                {
                    return this.primaryObligorReference_; 
                }
                else if (this.primaryObligorReferenceIDRef_ != null)
                {
                    primaryObligorReference_ = IDManager.getID(primaryObligorReferenceIDRef_) as LegalEntityReference;
                    return this.primaryObligorReference_; 
                }
                else
                {
                      return this.primaryObligorReference_; 
                }
            }
            set
            {
                if (this.primaryObligorReference_ != value)
                {
                    this.primaryObligorReference_ = value;
                }
            }
        }
        #endregion
        
        public string primaryObligorReferenceIDRef_ { get; set; }
        #region Guarantor_
        private LegalEntity guarantor_;
        public LegalEntity Guarantor_
        {
            get
            {
                if (this.guarantor_ != null)
                {
                    return this.guarantor_; 
                }
                else if (this.guarantorIDRef_ != null)
                {
                    guarantor_ = IDManager.getID(guarantorIDRef_) as LegalEntity;
                    return this.guarantor_; 
                }
                else
                {
                      return this.guarantor_; 
                }
            }
            set
            {
                if (this.guarantor_ != value)
                {
                    this.guarantor_ = value;
                }
            }
        }
        #endregion
        
        public string guarantorIDRef_ { get; set; }
        #region GuarantorReference_
        private LegalEntityReference guarantorReference_;
        public LegalEntityReference GuarantorReference_
        {
            get
            {
                if (this.guarantorReference_ != null)
                {
                    return this.guarantorReference_; 
                }
                else if (this.guarantorReferenceIDRef_ != null)
                {
                    guarantorReference_ = IDManager.getID(guarantorReferenceIDRef_) as LegalEntityReference;
                    return this.guarantorReference_; 
                }
                else
                {
                      return this.guarantorReference_; 
                }
            }
            set
            {
                if (this.guarantorReference_ != value)
                {
                    this.guarantorReference_ = value;
                }
            }
        }
        #endregion
        
        public string guarantorReferenceIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        
    
        
    
    }
    
}

