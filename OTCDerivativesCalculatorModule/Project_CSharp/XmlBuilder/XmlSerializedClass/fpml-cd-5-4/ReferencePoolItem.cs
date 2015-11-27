using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReferencePoolItem : ISerialized
    {
        public ReferencePoolItem(XmlNode xmlNode)
        {
            XmlNode constituentWeightNode = xmlNode.SelectSingleNode("constituentWeight");
            
            if (constituentWeightNode != null)
            {
                if (constituentWeightNode.Attributes["href"] != null || constituentWeightNode.Attributes["id"] != null) 
                {
                    if (constituentWeightNode.Attributes["id"] != null) 
                    {
                        constituentWeightIDRef_ = constituentWeightNode.Attributes["id"].Value;
                        ConstituentWeight ob = new ConstituentWeight(constituentWeightNode);
                        IDManager.SetID(constituentWeightIDRef_, ob);
                    }
                    else if (constituentWeightNode.Attributes["href"] != null)
                    {
                        constituentWeightIDRef_ = constituentWeightNode.Attributes["href"].Value;
                    }
                    else
                    {
                        constituentWeight_ = new ConstituentWeight(constituentWeightNode);
                    }
                }
                else
                {
                    constituentWeight_ = new ConstituentWeight(constituentWeightNode);
                }
            }
            
        
            XmlNode referencePairNode = xmlNode.SelectSingleNode("referencePair");
            
            if (referencePairNode != null)
            {
                if (referencePairNode.Attributes["href"] != null || referencePairNode.Attributes["id"] != null) 
                {
                    if (referencePairNode.Attributes["id"] != null) 
                    {
                        referencePairIDRef_ = referencePairNode.Attributes["id"].Value;
                        ReferencePair ob = new ReferencePair(referencePairNode);
                        IDManager.SetID(referencePairIDRef_, ob);
                    }
                    else if (referencePairNode.Attributes["href"] != null)
                    {
                        referencePairIDRef_ = referencePairNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referencePair_ = new ReferencePair(referencePairNode);
                    }
                }
                else
                {
                    referencePair_ = new ReferencePair(referencePairNode);
                }
            }
            
        
            XmlNode protectionTermsReferenceNode = xmlNode.SelectSingleNode("protectionTermsReference");
            
            if (protectionTermsReferenceNode != null)
            {
                if (protectionTermsReferenceNode.Attributes["href"] != null || protectionTermsReferenceNode.Attributes["id"] != null) 
                {
                    if (protectionTermsReferenceNode.Attributes["id"] != null) 
                    {
                        protectionTermsReferenceIDRef_ = protectionTermsReferenceNode.Attributes["id"].Value;
                        ProtectionTermsReference ob = new ProtectionTermsReference(protectionTermsReferenceNode);
                        IDManager.SetID(protectionTermsReferenceIDRef_, ob);
                    }
                    else if (protectionTermsReferenceNode.Attributes["href"] != null)
                    {
                        protectionTermsReferenceIDRef_ = protectionTermsReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        protectionTermsReference_ = new ProtectionTermsReference(protectionTermsReferenceNode);
                    }
                }
                else
                {
                    protectionTermsReference_ = new ProtectionTermsReference(protectionTermsReferenceNode);
                }
            }
            
        
            XmlNode settlementTermsReferenceNode = xmlNode.SelectSingleNode("settlementTermsReference");
            
            if (settlementTermsReferenceNode != null)
            {
                if (settlementTermsReferenceNode.Attributes["href"] != null || settlementTermsReferenceNode.Attributes["id"] != null) 
                {
                    if (settlementTermsReferenceNode.Attributes["id"] != null) 
                    {
                        settlementTermsReferenceIDRef_ = settlementTermsReferenceNode.Attributes["id"].Value;
                        SettlementTermsReference ob = new SettlementTermsReference(settlementTermsReferenceNode);
                        IDManager.SetID(settlementTermsReferenceIDRef_, ob);
                    }
                    else if (settlementTermsReferenceNode.Attributes["href"] != null)
                    {
                        settlementTermsReferenceIDRef_ = settlementTermsReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementTermsReference_ = new SettlementTermsReference(settlementTermsReferenceNode);
                    }
                }
                else
                {
                    settlementTermsReference_ = new SettlementTermsReference(settlementTermsReferenceNode);
                }
            }
            
        
        }
        
    
        #region ConstituentWeight_
        private ConstituentWeight constituentWeight_;
        public ConstituentWeight ConstituentWeight_
        {
            get
            {
                if (this.constituentWeight_ != null)
                {
                    return this.constituentWeight_; 
                }
                else if (this.constituentWeightIDRef_ != null)
                {
                    constituentWeight_ = IDManager.getID(constituentWeightIDRef_) as ConstituentWeight;
                    return this.constituentWeight_; 
                }
                else
                {
                      return this.constituentWeight_; 
                }
            }
            set
            {
                if (this.constituentWeight_ != value)
                {
                    this.constituentWeight_ = value;
                }
            }
        }
        #endregion
        
        public string constituentWeightIDRef_ { get; set; }
        #region ReferencePair_
        private ReferencePair referencePair_;
        public ReferencePair ReferencePair_
        {
            get
            {
                if (this.referencePair_ != null)
                {
                    return this.referencePair_; 
                }
                else if (this.referencePairIDRef_ != null)
                {
                    referencePair_ = IDManager.getID(referencePairIDRef_) as ReferencePair;
                    return this.referencePair_; 
                }
                else
                {
                      return this.referencePair_; 
                }
            }
            set
            {
                if (this.referencePair_ != value)
                {
                    this.referencePair_ = value;
                }
            }
        }
        #endregion
        
        public string referencePairIDRef_ { get; set; }
        #region ProtectionTermsReference_
        private ProtectionTermsReference protectionTermsReference_;
        public ProtectionTermsReference ProtectionTermsReference_
        {
            get
            {
                if (this.protectionTermsReference_ != null)
                {
                    return this.protectionTermsReference_; 
                }
                else if (this.protectionTermsReferenceIDRef_ != null)
                {
                    protectionTermsReference_ = IDManager.getID(protectionTermsReferenceIDRef_) as ProtectionTermsReference;
                    return this.protectionTermsReference_; 
                }
                else
                {
                      return this.protectionTermsReference_; 
                }
            }
            set
            {
                if (this.protectionTermsReference_ != value)
                {
                    this.protectionTermsReference_ = value;
                }
            }
        }
        #endregion
        
        public string protectionTermsReferenceIDRef_ { get; set; }
        #region SettlementTermsReference_
        private SettlementTermsReference settlementTermsReference_;
        public SettlementTermsReference SettlementTermsReference_
        {
            get
            {
                if (this.settlementTermsReference_ != null)
                {
                    return this.settlementTermsReference_; 
                }
                else if (this.settlementTermsReferenceIDRef_ != null)
                {
                    settlementTermsReference_ = IDManager.getID(settlementTermsReferenceIDRef_) as SettlementTermsReference;
                    return this.settlementTermsReference_; 
                }
                else
                {
                      return this.settlementTermsReference_; 
                }
            }
            set
            {
                if (this.settlementTermsReference_ != value)
                {
                    this.settlementTermsReference_ = value;
                }
            }
        }
        #endregion
        
        public string settlementTermsReferenceIDRef_ { get; set; }
        
    
        
    
    }
    
}

