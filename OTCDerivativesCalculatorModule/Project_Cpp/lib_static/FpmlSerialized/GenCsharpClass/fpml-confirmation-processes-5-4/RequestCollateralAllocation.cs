using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class RequestCollateralAllocation
    {
        public RequestCollateralAllocation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList serviceNameNodeList = xmlNode.SelectNodes("serviceName");
            if (serviceNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in serviceNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        serviceNameIDRef = item.Attributes["id"].Name;
                        XsdTypeNormalizedString ob = XsdTypeNormalizedString();
                        IDManager.SetID(serviceNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        serviceNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        serviceName = new XsdTypeNormalizedString(item);
                    }
                }
            }
            
        
            XmlNodeList collateralGiverPartyReferenceNodeList = xmlNode.SelectNodes("collateralGiverPartyReference");
            if (collateralGiverPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in collateralGiverPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        collateralGiverPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(collateralGiverPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        collateralGiverPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        collateralGiverPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList collateralAllocationNodeList = xmlNode.SelectNodes("collateralAllocation");
            
            foreach (XmlNode item in collateralAllocationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        collateralAllocationIDRef = item.Attributes["id"].Name;
                        List<ProposedCollateralAllocation> ob = new List<ProposedCollateralAllocation>();
                        ob.Add(new ProposedCollateralAllocation(item));
                        IDManager.SetID(collateralAllocationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        collateralAllocationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    collateralAllocation.Add(new ProposedCollateralAllocation(item));
                    }
                }
            }
            
        
            XmlNodeList partyNodeList = xmlNode.SelectNodes("party");
            
            foreach (XmlNode item in partyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyIDRef = item.Attributes["id"].Name;
                        List<Party> ob = new List<Party>();
                        ob.Add(new Party(item));
                        IDManager.SetID(partyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    party.Add(new Party(item));
                    }
                }
            }
            
        
            XmlNodeList accountNodeList = xmlNode.SelectNodes("account");
            
            foreach (XmlNode item in accountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accountIDRef = item.Attributes["id"].Name;
                        List<Account> ob = new List<Account>();
                        ob.Add(new Account(item));
                        IDManager.SetID(accountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    account.Add(new Account(item));
                    }
                }
            }
            
        
        }
        
    
        #region ServiceName
        private XsdTypeNormalizedString serviceName;
        public XsdTypeNormalizedString ServiceName
        {
            get
            {
                if (this.serviceName != null)
                {
                    return this.serviceName; 
                }
                else if (this.serviceNameIDRef != null)
                {
                    serviceName = IDManager.getID(serviceNameIDRef) as XsdTypeNormalizedString;
                    return this.serviceName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.serviceName != value)
                {
                    this.serviceName = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNormalizedStringIDRef { get; set; }
        #region CollateralGiverPartyReference
        private PartyReference collateralGiverPartyReference;
        public PartyReference CollateralGiverPartyReference
        {
            get
            {
                if (this.collateralGiverPartyReference != null)
                {
                    return this.collateralGiverPartyReference; 
                }
                else if (this.collateralGiverPartyReferenceIDRef != null)
                {
                    collateralGiverPartyReference = IDManager.getID(collateralGiverPartyReferenceIDRef) as PartyReference;
                    return this.collateralGiverPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.collateralGiverPartyReference != value)
                {
                    this.collateralGiverPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region CollateralAllocation
        private List<ProposedCollateralAllocation> collateralAllocation;
        public List<ProposedCollateralAllocation> CollateralAllocation
        {
            get
            {
                if (this.collateralAllocation != null)
                {
                    return this.collateralAllocation; 
                }
                else if (this.collateralAllocationIDRef != null)
                {
                    collateralAllocation = IDManager.getID(collateralAllocationIDRef) as List<ProposedCollateralAllocation>;
                    return this.collateralAllocation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.collateralAllocation != value)
                {
                    this.collateralAllocation = value;
                }
            }
        }
        #endregion
        
        public string ProposedCollateralAllocationIDRef { get; set; }
        #region Party
        private List<Party> party;
        public List<Party> Party
        {
            get
            {
                if (this.party != null)
                {
                    return this.party; 
                }
                else if (this.partyIDRef != null)
                {
                    party = IDManager.getID(partyIDRef) as List<Party>;
                    return this.party; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.party != value)
                {
                    this.party = value;
                }
            }
        }
        #endregion
        
        public string PartyIDRef { get; set; }
        #region Account
        private List<Account> account;
        public List<Account> Account
        {
            get
            {
                if (this.account != null)
                {
                    return this.account; 
                }
                else if (this.accountIDRef != null)
                {
                    account = IDManager.getID(accountIDRef) as List<Account>;
                    return this.account; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.account != value)
                {
                    this.account = value;
                }
            }
        }
        #endregion
        
        public string AccountIDRef { get; set; }
        
    
        
    
    }
    
}

