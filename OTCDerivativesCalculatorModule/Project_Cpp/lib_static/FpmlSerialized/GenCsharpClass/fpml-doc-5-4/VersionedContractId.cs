using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class VersionedContractId
    {
        public VersionedContractId(XmlNode xmlNode)
        {
            XmlNodeList contractIdNodeList = xmlNode.SelectNodes("contractId");
            if (contractIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in contractIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        contractIdIDRef = item.Attributes["id"].Name;
                        ContractId ob = ContractId();
                        IDManager.SetID(contractIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        contractIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        contractId = new ContractId(item);
                    }
                }
            }
            
        
            XmlNodeList versionNodeList = xmlNode.SelectNodes("version");
            if (versionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in versionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        versionIDRef = item.Attributes["id"].Name;
                        XsdTypeNonNegativeInteger ob = XsdTypeNonNegativeInteger();
                        IDManager.SetID(versionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        versionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        version = new XsdTypeNonNegativeInteger(item);
                    }
                }
            }
            
        
            XmlNodeList effectiveDateNodeList = xmlNode.SelectNodes("effectiveDate");
            if (effectiveDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in effectiveDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef = item.Attributes["id"].Name;
                        IdentifiedDate ob = IdentifiedDate();
                        IDManager.SetID(effectiveDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        effectiveDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        effectiveDate = new IdentifiedDate(item);
                    }
                }
            }
            
        
        }
        
    
        #region ContractId
        private ContractId contractId;
        public ContractId ContractId
        {
            get
            {
                if (this.contractId != null)
                {
                    return this.contractId; 
                }
                else if (this.contractIdIDRef != null)
                {
                    contractId = IDManager.getID(contractIdIDRef) as ContractId;
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
        #region Version
        private XsdTypeNonNegativeInteger version;
        public XsdTypeNonNegativeInteger Version
        {
            get
            {
                if (this.version != null)
                {
                    return this.version; 
                }
                else if (this.versionIDRef != null)
                {
                    version = IDManager.getID(versionIDRef) as XsdTypeNonNegativeInteger;
                    return this.version; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.version != value)
                {
                    this.version = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNonNegativeIntegerIDRef { get; set; }
        #region EffectiveDate
        private IdentifiedDate effectiveDate;
        public IdentifiedDate EffectiveDate
        {
            get
            {
                if (this.effectiveDate != null)
                {
                    return this.effectiveDate; 
                }
                else if (this.effectiveDateIDRef != null)
                {
                    effectiveDate = IDManager.getID(effectiveDateIDRef) as IdentifiedDate;
                    return this.effectiveDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.effectiveDate != value)
                {
                    this.effectiveDate = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedDateIDRef { get; set; }
        
    
        
    
    }
    
}

