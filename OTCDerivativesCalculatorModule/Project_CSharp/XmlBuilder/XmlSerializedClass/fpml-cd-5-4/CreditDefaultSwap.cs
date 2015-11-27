using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CreditDefaultSwap : Product
    {
        public CreditDefaultSwap(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode generalTermsNode = xmlNode.SelectSingleNode("generalTerms");
            
            if (generalTermsNode != null)
            {
                if (generalTermsNode.Attributes["href"] != null || generalTermsNode.Attributes["id"] != null) 
                {
                    if (generalTermsNode.Attributes["id"] != null) 
                    {
                        generalTermsIDRef_ = generalTermsNode.Attributes["id"].Value;
                        GeneralTerms ob = new GeneralTerms(generalTermsNode);
                        IDManager.SetID(generalTermsIDRef_, ob);
                    }
                    else if (generalTermsNode.Attributes["href"] != null)
                    {
                        generalTermsIDRef_ = generalTermsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        generalTerms_ = new GeneralTerms(generalTermsNode);
                    }
                }
                else
                {
                    generalTerms_ = new GeneralTerms(generalTermsNode);
                }
            }
            
        
            XmlNode feeLegNode = xmlNode.SelectSingleNode("feeLeg");
            
            if (feeLegNode != null)
            {
                if (feeLegNode.Attributes["href"] != null || feeLegNode.Attributes["id"] != null) 
                {
                    if (feeLegNode.Attributes["id"] != null) 
                    {
                        feeLegIDRef_ = feeLegNode.Attributes["id"].Value;
                        FeeLeg ob = new FeeLeg(feeLegNode);
                        IDManager.SetID(feeLegIDRef_, ob);
                    }
                    else if (feeLegNode.Attributes["href"] != null)
                    {
                        feeLegIDRef_ = feeLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        feeLeg_ = new FeeLeg(feeLegNode);
                    }
                }
                else
                {
                    feeLeg_ = new FeeLeg(feeLegNode);
                }
            }
            
        
            XmlNodeList protectionTermsNodeList = xmlNode.SelectNodes("protectionTerms");
            
            if (protectionTermsNodeList != null)
            {
                this.protectionTerms_ = new List<ProtectionTerms>();
                foreach (XmlNode item in protectionTermsNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            protectionTermsIDRef_ = item.Attributes["id"].Value;
                            protectionTerms_.Add(new ProtectionTerms(item));
                            IDManager.SetID(protectionTermsIDRef_, protectionTerms_[protectionTerms_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            protectionTermsIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        protectionTerms_.Add(new ProtectionTerms(item));
                        }
                    }
                    else
                    {
                        protectionTerms_.Add(new ProtectionTerms(item));
                    }
                }
            }
            
        
            XmlNode cashSettlementTermsNode = xmlNode.SelectSingleNode("cashSettlementTerms");
            
            if (cashSettlementTermsNode != null)
            {
                if (cashSettlementTermsNode.Attributes["href"] != null || cashSettlementTermsNode.Attributes["id"] != null) 
                {
                    if (cashSettlementTermsNode.Attributes["id"] != null) 
                    {
                        cashSettlementTermsIDRef_ = cashSettlementTermsNode.Attributes["id"].Value;
                        CashSettlementTerms ob = new CashSettlementTerms(cashSettlementTermsNode);
                        IDManager.SetID(cashSettlementTermsIDRef_, ob);
                    }
                    else if (cashSettlementTermsNode.Attributes["href"] != null)
                    {
                        cashSettlementTermsIDRef_ = cashSettlementTermsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashSettlementTerms_ = new CashSettlementTerms(cashSettlementTermsNode);
                    }
                }
                else
                {
                    cashSettlementTerms_ = new CashSettlementTerms(cashSettlementTermsNode);
                }
            }
            
        
            XmlNode physicalSettlementTermsNode = xmlNode.SelectSingleNode("physicalSettlementTerms");
            
            if (physicalSettlementTermsNode != null)
            {
                if (physicalSettlementTermsNode.Attributes["href"] != null || physicalSettlementTermsNode.Attributes["id"] != null) 
                {
                    if (physicalSettlementTermsNode.Attributes["id"] != null) 
                    {
                        physicalSettlementTermsIDRef_ = physicalSettlementTermsNode.Attributes["id"].Value;
                        PhysicalSettlementTerms ob = new PhysicalSettlementTerms(physicalSettlementTermsNode);
                        IDManager.SetID(physicalSettlementTermsIDRef_, ob);
                    }
                    else if (physicalSettlementTermsNode.Attributes["href"] != null)
                    {
                        physicalSettlementTermsIDRef_ = physicalSettlementTermsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        physicalSettlementTerms_ = new PhysicalSettlementTerms(physicalSettlementTermsNode);
                    }
                }
                else
                {
                    physicalSettlementTerms_ = new PhysicalSettlementTerms(physicalSettlementTermsNode);
                }
            }
            
        
        }
        
    
        #region GeneralTerms_
        private GeneralTerms generalTerms_;
        public GeneralTerms GeneralTerms_
        {
            get
            {
                if (this.generalTerms_ != null)
                {
                    return this.generalTerms_; 
                }
                else if (this.generalTermsIDRef_ != null)
                {
                    generalTerms_ = IDManager.getID(generalTermsIDRef_) as GeneralTerms;
                    return this.generalTerms_; 
                }
                else
                {
                      return this.generalTerms_; 
                }
            }
            set
            {
                if (this.generalTerms_ != value)
                {
                    this.generalTerms_ = value;
                }
            }
        }
        #endregion
        
        public string generalTermsIDRef_ { get; set; }
        #region FeeLeg_
        private FeeLeg feeLeg_;
        public FeeLeg FeeLeg_
        {
            get
            {
                if (this.feeLeg_ != null)
                {
                    return this.feeLeg_; 
                }
                else if (this.feeLegIDRef_ != null)
                {
                    feeLeg_ = IDManager.getID(feeLegIDRef_) as FeeLeg;
                    return this.feeLeg_; 
                }
                else
                {
                      return this.feeLeg_; 
                }
            }
            set
            {
                if (this.feeLeg_ != value)
                {
                    this.feeLeg_ = value;
                }
            }
        }
        #endregion
        
        public string feeLegIDRef_ { get; set; }
        #region ProtectionTerms_
        private List<ProtectionTerms> protectionTerms_;
        public List<ProtectionTerms> ProtectionTerms_
        {
            get
            {
                if (this.protectionTerms_ != null)
                {
                    return this.protectionTerms_; 
                }
                else if (this.protectionTermsIDRef_ != null)
                {
                    return this.protectionTerms_; 
                }
                else
                {
                      return this.protectionTerms_; 
                }
            }
            set
            {
                if (this.protectionTerms_ != value)
                {
                    this.protectionTerms_ = value;
                }
            }
        }
        #endregion
        
        public string protectionTermsIDRef_ { get; set; }
        #region CashSettlementTerms_
        private CashSettlementTerms cashSettlementTerms_;
        public CashSettlementTerms CashSettlementTerms_
        {
            get
            {
                if (this.cashSettlementTerms_ != null)
                {
                    return this.cashSettlementTerms_; 
                }
                else if (this.cashSettlementTermsIDRef_ != null)
                {
                    cashSettlementTerms_ = IDManager.getID(cashSettlementTermsIDRef_) as CashSettlementTerms;
                    return this.cashSettlementTerms_; 
                }
                else
                {
                      return this.cashSettlementTerms_; 
                }
            }
            set
            {
                if (this.cashSettlementTerms_ != value)
                {
                    this.cashSettlementTerms_ = value;
                }
            }
        }
        #endregion
        
        public string cashSettlementTermsIDRef_ { get; set; }
        #region PhysicalSettlementTerms_
        private PhysicalSettlementTerms physicalSettlementTerms_;
        public PhysicalSettlementTerms PhysicalSettlementTerms_
        {
            get
            {
                if (this.physicalSettlementTerms_ != null)
                {
                    return this.physicalSettlementTerms_; 
                }
                else if (this.physicalSettlementTermsIDRef_ != null)
                {
                    physicalSettlementTerms_ = IDManager.getID(physicalSettlementTermsIDRef_) as PhysicalSettlementTerms;
                    return this.physicalSettlementTerms_; 
                }
                else
                {
                      return this.physicalSettlementTerms_; 
                }
            }
            set
            {
                if (this.physicalSettlementTerms_ != value)
                {
                    this.physicalSettlementTerms_ = value;
                }
            }
        }
        #endregion
        
        public string physicalSettlementTermsIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

