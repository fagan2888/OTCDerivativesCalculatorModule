using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ContractIdentifier : ISerialized
    {
        public ContractIdentifier(XmlNode xmlNode)
        {
            XmlNode partyReferenceNode = xmlNode.SelectSingleNode("partyReference");
            
            if (partyReferenceNode != null)
            {
                if (partyReferenceNode.Attributes["href"] != null || partyReferenceNode.Attributes["id"] != null) 
                {
                    if (partyReferenceNode.Attributes["id"] != null) 
                    {
                        partyReferenceIDRef_ = partyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(partyReferenceNode);
                        IDManager.SetID(partyReferenceIDRef_, ob);
                    }
                    else if (partyReferenceNode.Attributes["href"] != null)
                    {
                        partyReferenceIDRef_ = partyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partyReference_ = new PartyReference(partyReferenceNode);
                    }
                }
                else
                {
                    partyReference_ = new PartyReference(partyReferenceNode);
                }
            }
            
        
            XmlNodeList contractIdNodeList = xmlNode.SelectNodes("contractId");
            
            if (contractIdNodeList != null)
            {
                this.contractId_ = new List<ContractId>();
                foreach (XmlNode item in contractIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            contractIdIDRef_ = item.Attributes["id"].Value;
                            contractId_.Add(new ContractId(item));
                            IDManager.SetID(contractIdIDRef_, contractId_[contractId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            contractIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        contractId_.Add(new ContractId(item));
                        }
                    }
                    else
                    {
                        contractId_.Add(new ContractId(item));
                    }
                }
            }
            
        
            XmlNodeList versionedContractIdNodeList = xmlNode.SelectNodes("versionedContractId");
            
            if (versionedContractIdNodeList != null)
            {
                this.versionedContractId_ = new List<VersionedContractId>();
                foreach (XmlNode item in versionedContractIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            versionedContractIdIDRef_ = item.Attributes["id"].Value;
                            versionedContractId_.Add(new VersionedContractId(item));
                            IDManager.SetID(versionedContractIdIDRef_, versionedContractId_[versionedContractId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            versionedContractIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        versionedContractId_.Add(new VersionedContractId(item));
                        }
                    }
                    else
                    {
                        versionedContractId_.Add(new VersionedContractId(item));
                    }
                }
            }
            
        
        }
        
    
        #region PartyReference_
        private PartyReference partyReference_;
        public PartyReference PartyReference_
        {
            get
            {
                if (this.partyReference_ != null)
                {
                    return this.partyReference_; 
                }
                else if (this.partyReferenceIDRef_ != null)
                {
                    partyReference_ = IDManager.getID(partyReferenceIDRef_) as PartyReference;
                    return this.partyReference_; 
                }
                else
                {
                      return this.partyReference_; 
                }
            }
            set
            {
                if (this.partyReference_ != value)
                {
                    this.partyReference_ = value;
                }
            }
        }
        #endregion
        
        public string partyReferenceIDRef_ { get; set; }
        #region ContractId_
        private List<ContractId> contractId_;
        public List<ContractId> ContractId_
        {
            get
            {
                if (this.contractId_ != null)
                {
                    return this.contractId_; 
                }
                else if (this.contractIdIDRef_ != null)
                {
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
        #region VersionedContractId_
        private List<VersionedContractId> versionedContractId_;
        public List<VersionedContractId> VersionedContractId_
        {
            get
            {
                if (this.versionedContractId_ != null)
                {
                    return this.versionedContractId_; 
                }
                else if (this.versionedContractIdIDRef_ != null)
                {
                    return this.versionedContractId_; 
                }
                else
                {
                      return this.versionedContractId_; 
                }
            }
            set
            {
                if (this.versionedContractId_ != value)
                {
                    this.versionedContractId_ = value;
                }
            }
        }
        #endregion
        
        public string versionedContractIdIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

