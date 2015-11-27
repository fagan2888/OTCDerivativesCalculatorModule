using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VersionedContractId : ISerialized
    {
        public VersionedContractId(XmlNode xmlNode)
        {
            XmlNode contractIdNode = xmlNode.SelectSingleNode("contractId");
            
            if (contractIdNode != null)
            {
                if (contractIdNode.Attributes["href"] != null || contractIdNode.Attributes["id"] != null) 
                {
                    if (contractIdNode.Attributes["id"] != null) 
                    {
                        contractIdIDRef_ = contractIdNode.Attributes["id"].Value;
                        ContractId ob = new ContractId(contractIdNode);
                        IDManager.SetID(contractIdIDRef_, ob);
                    }
                    else if (contractIdNode.Attributes["href"] != null)
                    {
                        contractIdIDRef_ = contractIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        contractId_ = new ContractId(contractIdNode);
                    }
                }
                else
                {
                    contractId_ = new ContractId(contractIdNode);
                }
            }
            
        
            XmlNode versionNode = xmlNode.SelectSingleNode("version");
            
            if (versionNode != null)
            {
                if (versionNode.Attributes["href"] != null || versionNode.Attributes["id"] != null) 
                {
                    if (versionNode.Attributes["id"] != null) 
                    {
                        versionIDRef_ = versionNode.Attributes["id"].Value;
                        XsdTypeNonNegativeInteger ob = new XsdTypeNonNegativeInteger(versionNode);
                        IDManager.SetID(versionIDRef_, ob);
                    }
                    else if (versionNode.Attributes["href"] != null)
                    {
                        versionIDRef_ = versionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        version_ = new XsdTypeNonNegativeInteger(versionNode);
                    }
                }
                else
                {
                    version_ = new XsdTypeNonNegativeInteger(versionNode);
                }
            }
            
        
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new IdentifiedDate(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new IdentifiedDate(effectiveDateNode);
                }
            }
            
        
        }
        
    
        #region ContractId_
        private ContractId contractId_;
        public ContractId ContractId_
        {
            get
            {
                if (this.contractId_ != null)
                {
                    return this.contractId_; 
                }
                else if (this.contractIdIDRef_ != null)
                {
                    contractId_ = IDManager.getID(contractIdIDRef_) as ContractId;
                    return this.contractId_; 
                }
                else
                {
                      return this.contractId_; 
                }
            }
            set
            {
                if (this.contractId_ != value)
                {
                    this.contractId_ = value;
                }
            }
        }
        #endregion
        
        public string contractIdIDRef_ { get; set; }
        #region Version_
        private XsdTypeNonNegativeInteger version_;
        public XsdTypeNonNegativeInteger Version_
        {
            get
            {
                if (this.version_ != null)
                {
                    return this.version_; 
                }
                else if (this.versionIDRef_ != null)
                {
                    version_ = IDManager.getID(versionIDRef_) as XsdTypeNonNegativeInteger;
                    return this.version_; 
                }
                else
                {
                      return this.version_; 
                }
            }
            set
            {
                if (this.version_ != value)
                {
                    this.version_ = value;
                }
            }
        }
        #endregion
        
        public string versionIDRef_ { get; set; }
        #region EffectiveDate_
        private IdentifiedDate effectiveDate_;
        public IdentifiedDate EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as IdentifiedDate;
                    return this.effectiveDate_; 
                }
                else
                {
                      return this.effectiveDate_; 
                }
            }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

