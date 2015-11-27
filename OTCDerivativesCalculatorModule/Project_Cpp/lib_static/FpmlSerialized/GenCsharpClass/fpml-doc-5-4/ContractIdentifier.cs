using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ContractIdentifier
    {
        public ContractIdentifier(XmlNode xmlNode)
        {
            XmlNodeList partyReferenceNodeList = xmlNode.SelectNodes("partyReference");
            if (partyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in partyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(partyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        partyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList contractIdNodeList = xmlNode.SelectNodes("contractId");
            
            foreach (XmlNode item in contractIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        contractIdIDRef = item.Attributes["id"].Name;
                        List<ContractId> ob = new List<ContractId>();
                        ob.Add(new ContractId(item));
                        IDManager.SetID(contractIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        contractIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    contractId.Add(new ContractId(item));
                    }
                }
            }
            
        
            XmlNodeList versionedContractIdNodeList = xmlNode.SelectNodes("versionedContractId");
            
            foreach (XmlNode item in versionedContractIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        versionedContractIdIDRef = item.Attributes["id"].Name;
                        List<VersionedContractId> ob = new List<VersionedContractId>();
                        ob.Add(new VersionedContractId(item));
                        IDManager.SetID(versionedContractIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        versionedContractIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    versionedContractId.Add(new VersionedContractId(item));
                    }
                }
            }
            
        
        }
        
    
        #region PartyReference
        private PartyReference partyReference;
        public PartyReference PartyReference
        {
            get
            {
                if (this.partyReference != null)
                {
                    return this.partyReference; 
                }
                else if (this.partyReferenceIDRef != null)
                {
                    partyReference = IDManager.getID(partyReferenceIDRef) as PartyReference;
                    return this.partyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyReference != value)
                {
                    this.partyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region ContractId
        private List<ContractId> contractId;
        public List<ContractId> ContractId
        {
            get
            {
                if (this.contractId != null)
                {
                    return this.contractId; 
                }
                else if (this.contractIdIDRef != null)
                {
                    contractId = IDManager.getID(contractIdIDRef) as List<ContractId>;
                    return this.contractId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.contractId != value)
                {
                    this.contractId = value;
                }
            }
        }
        #endregion
        
        public string ContractIdIDRef { get; set; }
        #region VersionedContractId
        private List<VersionedContractId> versionedContractId;
        public List<VersionedContractId> VersionedContractId
        {
            get
            {
                if (this.versionedContractId != null)
                {
                    return this.versionedContractId; 
                }
                else if (this.versionedContractIdIDRef != null)
                {
                    versionedContractId = IDManager.getID(versionedContractIdIDRef) as List<VersionedContractId>;
                    return this.versionedContractId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.versionedContractId != value)
                {
                    this.versionedContractId = value;
                }
            }
        }
        #endregion
        
        public string VersionedContractIdIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

