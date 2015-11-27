using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RequestCollateralAllocation : CorrectableRequestMessage
    {
        public RequestCollateralAllocation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode serviceNameNode = xmlNode.SelectSingleNode("serviceName");
            
            if (serviceNameNode != null)
            {
                if (serviceNameNode.Attributes["href"] != null || serviceNameNode.Attributes["id"] != null) 
                {
                    if (serviceNameNode.Attributes["id"] != null) 
                    {
                        serviceNameIDRef_ = serviceNameNode.Attributes["id"].Value;
                        XsdTypeNormalizedString ob = new XsdTypeNormalizedString(serviceNameNode);
                        IDManager.SetID(serviceNameIDRef_, ob);
                    }
                    else if (serviceNameNode.Attributes["href"] != null)
                    {
                        serviceNameIDRef_ = serviceNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        serviceName_ = new XsdTypeNormalizedString(serviceNameNode);
                    }
                }
                else
                {
                    serviceName_ = new XsdTypeNormalizedString(serviceNameNode);
                }
            }
            
        
            XmlNode collateralGiverPartyReferenceNode = xmlNode.SelectSingleNode("collateralGiverPartyReference");
            
            if (collateralGiverPartyReferenceNode != null)
            {
                if (collateralGiverPartyReferenceNode.Attributes["href"] != null || collateralGiverPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (collateralGiverPartyReferenceNode.Attributes["id"] != null) 
                    {
                        collateralGiverPartyReferenceIDRef_ = collateralGiverPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(collateralGiverPartyReferenceNode);
                        IDManager.SetID(collateralGiverPartyReferenceIDRef_, ob);
                    }
                    else if (collateralGiverPartyReferenceNode.Attributes["href"] != null)
                    {
                        collateralGiverPartyReferenceIDRef_ = collateralGiverPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        collateralGiverPartyReference_ = new PartyReference(collateralGiverPartyReferenceNode);
                    }
                }
                else
                {
                    collateralGiverPartyReference_ = new PartyReference(collateralGiverPartyReferenceNode);
                }
            }
            
        
            XmlNodeList collateralAllocationNodeList = xmlNode.SelectNodes("collateralAllocation");
            
            if (collateralAllocationNodeList != null)
            {
                this.collateralAllocation_ = new List<ProposedCollateralAllocation>();
                foreach (XmlNode item in collateralAllocationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            collateralAllocationIDRef_ = item.Attributes["id"].Value;
                            collateralAllocation_.Add(new ProposedCollateralAllocation(item));
                            IDManager.SetID(collateralAllocationIDRef_, collateralAllocation_[collateralAllocation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            collateralAllocationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        collateralAllocation_.Add(new ProposedCollateralAllocation(item));
                        }
                    }
                    else
                    {
                        collateralAllocation_.Add(new ProposedCollateralAllocation(item));
                    }
                }
            }
            
        
            XmlNodeList partyNodeList = xmlNode.SelectNodes("party");
            
            if (partyNodeList != null)
            {
                this.party_ = new List<Party>();
                foreach (XmlNode item in partyNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            partyIDRef_ = item.Attributes["id"].Value;
                            party_.Add(new Party(item));
                            IDManager.SetID(partyIDRef_, party_[party_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            partyIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        party_.Add(new Party(item));
                        }
                    }
                    else
                    {
                        party_.Add(new Party(item));
                    }
                }
            }
            
        
            XmlNodeList accountNodeList = xmlNode.SelectNodes("account");
            
            if (accountNodeList != null)
            {
                this.account_ = new List<Account>();
                foreach (XmlNode item in accountNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            accountIDRef_ = item.Attributes["id"].Value;
                            account_.Add(new Account(item));
                            IDManager.SetID(accountIDRef_, account_[account_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            accountIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        account_.Add(new Account(item));
                        }
                    }
                    else
                    {
                        account_.Add(new Account(item));
                    }
                }
            }
            
        
        }
        
    
        #region ServiceName_
        private XsdTypeNormalizedString serviceName_;
        public XsdTypeNormalizedString ServiceName_
        {
            get
            {
                if (this.serviceName_ != null)
                {
                    return this.serviceName_; 
                }
                else if (this.serviceNameIDRef_ != null)
                {
                    serviceName_ = IDManager.getID(serviceNameIDRef_) as XsdTypeNormalizedString;
                    return this.serviceName_; 
                }
                else
                {
                      return this.serviceName_; 
                }
            }
            set
            {
                if (this.serviceName_ != value)
                {
                    this.serviceName_ = value;
                }
            }
        }
        #endregion
        
        public string serviceNameIDRef_ { get; set; }
        #region CollateralGiverPartyReference_
        private PartyReference collateralGiverPartyReference_;
        public PartyReference CollateralGiverPartyReference_
        {
            get
            {
                if (this.collateralGiverPartyReference_ != null)
                {
                    return this.collateralGiverPartyReference_; 
                }
                else if (this.collateralGiverPartyReferenceIDRef_ != null)
                {
                    collateralGiverPartyReference_ = IDManager.getID(collateralGiverPartyReferenceIDRef_) as PartyReference;
                    return this.collateralGiverPartyReference_; 
                }
                else
                {
                      return this.collateralGiverPartyReference_; 
                }
            }
            set
            {
                if (this.collateralGiverPartyReference_ != value)
                {
                    this.collateralGiverPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string collateralGiverPartyReferenceIDRef_ { get; set; }
        #region CollateralAllocation_
        private List<ProposedCollateralAllocation> collateralAllocation_;
        public List<ProposedCollateralAllocation> CollateralAllocation_
        {
            get
            {
                if (this.collateralAllocation_ != null)
                {
                    return this.collateralAllocation_; 
                }
                else if (this.collateralAllocationIDRef_ != null)
                {
                    return this.collateralAllocation_; 
                }
                else
                {
                      return this.collateralAllocation_; 
                }
            }
            set
            {
                if (this.collateralAllocation_ != value)
                {
                    this.collateralAllocation_ = value;
                }
            }
        }
        #endregion
        
        public string collateralAllocationIDRef_ { get; set; }
        #region Party_
        private List<Party> party_;
        public List<Party> Party_
        {
            get
            {
                if (this.party_ != null)
                {
                    return this.party_; 
                }
                else if (this.partyIDRef_ != null)
                {
                    return this.party_; 
                }
                else
                {
                      return this.party_; 
                }
            }
            set
            {
                if (this.party_ != value)
                {
                    this.party_ = value;
                }
            }
        }
        #endregion
        
        public string partyIDRef_ { get; set; }
        #region Account_
        private List<Account> account_;
        public List<Account> Account_
        {
            get
            {
                if (this.account_ != null)
                {
                    return this.account_; 
                }
                else if (this.accountIDRef_ != null)
                {
                    return this.account_; 
                }
                else
                {
                      return this.account_; 
                }
            }
            set
            {
                if (this.account_ != value)
                {
                    this.account_ = value;
                }
            }
        }
        #endregion
        
        public string accountIDRef_ { get; set; }
        
    
        
    
    }
    
}

