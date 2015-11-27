using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ReferencePoolItem
    {
        public ReferencePoolItem(XmlNode xmlNode)
        {
            XmlNodeList constituentWeightNodeList = xmlNode.SelectNodes("constituentWeight");
            if (constituentWeightNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in constituentWeightNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        constituentWeightIDRef = item.Attributes["id"].Name;
                        ConstituentWeight ob = ConstituentWeight();
                        IDManager.SetID(constituentWeightIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        constituentWeightIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        constituentWeight = new ConstituentWeight(item);
                    }
                }
            }
            
        
            XmlNodeList referencePairNodeList = xmlNode.SelectNodes("referencePair");
            if (referencePairNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referencePairNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referencePairIDRef = item.Attributes["id"].Name;
                        ReferencePair ob = ReferencePair();
                        IDManager.SetID(referencePairIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referencePairIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referencePair = new ReferencePair(item);
                    }
                }
            }
            
        
            XmlNodeList protectionTermsReferenceNodeList = xmlNode.SelectNodes("protectionTermsReference");
            if (protectionTermsReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in protectionTermsReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        protectionTermsReferenceIDRef = item.Attributes["id"].Name;
                        ProtectionTermsReference ob = ProtectionTermsReference();
                        IDManager.SetID(protectionTermsReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        protectionTermsReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        protectionTermsReference = new ProtectionTermsReference(item);
                    }
                }
            }
            
        
            XmlNodeList settlementTermsReferenceNodeList = xmlNode.SelectNodes("settlementTermsReference");
            if (settlementTermsReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementTermsReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementTermsReferenceIDRef = item.Attributes["id"].Name;
                        SettlementTermsReference ob = SettlementTermsReference();
                        IDManager.SetID(settlementTermsReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementTermsReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementTermsReference = new SettlementTermsReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region ConstituentWeight
        private ConstituentWeight constituentWeight;
        public ConstituentWeight ConstituentWeight
        {
            get
            {
                if (this.constituentWeight != null)
                {
                    return this.constituentWeight; 
                }
                else if (this.constituentWeightIDRef != null)
                {
                    constituentWeight = IDManager.getID(constituentWeightIDRef) as ConstituentWeight;
                    return this.constituentWeight; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.constituentWeight != value)
                {
                    this.constituentWeight = value;
                }
            }
        }
        #endregion
        
        public string ConstituentWeightIDRef { get; set; }
        #region ReferencePair
        private ReferencePair referencePair;
        public ReferencePair ReferencePair
        {
            get
            {
                if (this.referencePair != null)
                {
                    return this.referencePair; 
                }
                else if (this.referencePairIDRef != null)
                {
                    referencePair = IDManager.getID(referencePairIDRef) as ReferencePair;
                    return this.referencePair; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referencePair != value)
                {
                    this.referencePair = value;
                }
            }
        }
        #endregion
        
        public string ReferencePairIDRef { get; set; }
        #region ProtectionTermsReference
        private ProtectionTermsReference protectionTermsReference;
        public ProtectionTermsReference ProtectionTermsReference
        {
            get
            {
                if (this.protectionTermsReference != null)
                {
                    return this.protectionTermsReference; 
                }
                else if (this.protectionTermsReferenceIDRef != null)
                {
                    protectionTermsReference = IDManager.getID(protectionTermsReferenceIDRef) as ProtectionTermsReference;
                    return this.protectionTermsReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.protectionTermsReference != value)
                {
                    this.protectionTermsReference = value;
                }
            }
        }
        #endregion
        
        public string ProtectionTermsReferenceIDRef { get; set; }
        #region SettlementTermsReference
        private SettlementTermsReference settlementTermsReference;
        public SettlementTermsReference SettlementTermsReference
        {
            get
            {
                if (this.settlementTermsReference != null)
                {
                    return this.settlementTermsReference; 
                }
                else if (this.settlementTermsReferenceIDRef != null)
                {
                    settlementTermsReference = IDManager.getID(settlementTermsReferenceIDRef) as SettlementTermsReference;
                    return this.settlementTermsReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementTermsReference != value)
                {
                    this.settlementTermsReference = value;
                }
            }
        }
        #endregion
        
        public string SettlementTermsReferenceIDRef { get; set; }
        
    
        
    
    }
    
}

