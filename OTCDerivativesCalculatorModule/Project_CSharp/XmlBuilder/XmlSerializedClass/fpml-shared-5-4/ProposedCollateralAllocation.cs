using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ProposedCollateralAllocation : ISerialized
    {
        public ProposedCollateralAllocation(XmlNode xmlNode)
        {
            XmlNode allocationPartyReferenceNode = xmlNode.SelectSingleNode("allocationPartyReference");
            
            if (allocationPartyReferenceNode != null)
            {
                if (allocationPartyReferenceNode.Attributes["href"] != null || allocationPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (allocationPartyReferenceNode.Attributes["id"] != null) 
                    {
                        allocationPartyReferenceIDRef_ = allocationPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(allocationPartyReferenceNode);
                        IDManager.SetID(allocationPartyReferenceIDRef_, ob);
                    }
                    else if (allocationPartyReferenceNode.Attributes["href"] != null)
                    {
                        allocationPartyReferenceIDRef_ = allocationPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        allocationPartyReference_ = new PartyReference(allocationPartyReferenceNode);
                    }
                }
                else
                {
                    allocationPartyReference_ = new PartyReference(allocationPartyReferenceNode);
                }
            }
            
        
            XmlNode allocationAccountReferenceNode = xmlNode.SelectSingleNode("allocationAccountReference");
            
            if (allocationAccountReferenceNode != null)
            {
                if (allocationAccountReferenceNode.Attributes["href"] != null || allocationAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (allocationAccountReferenceNode.Attributes["id"] != null) 
                    {
                        allocationAccountReferenceIDRef_ = allocationAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(allocationAccountReferenceNode);
                        IDManager.SetID(allocationAccountReferenceIDRef_, ob);
                    }
                    else if (allocationAccountReferenceNode.Attributes["href"] != null)
                    {
                        allocationAccountReferenceIDRef_ = allocationAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        allocationAccountReference_ = new AccountReference(allocationAccountReferenceNode);
                    }
                }
                else
                {
                    allocationAccountReference_ = new AccountReference(allocationAccountReferenceNode);
                }
            }
            
        
            XmlNode collateralValueAllocationNode = xmlNode.SelectSingleNode("collateralValueAllocation");
            
            if (collateralValueAllocationNode != null)
            {
                if (collateralValueAllocationNode.Attributes["href"] != null || collateralValueAllocationNode.Attributes["id"] != null) 
                {
                    if (collateralValueAllocationNode.Attributes["id"] != null) 
                    {
                        collateralValueAllocationIDRef_ = collateralValueAllocationNode.Attributes["id"].Value;
                        CollateralValueAllocation ob = new CollateralValueAllocation(collateralValueAllocationNode);
                        IDManager.SetID(collateralValueAllocationIDRef_, ob);
                    }
                    else if (collateralValueAllocationNode.Attributes["href"] != null)
                    {
                        collateralValueAllocationIDRef_ = collateralValueAllocationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        collateralValueAllocation_ = new CollateralValueAllocation(collateralValueAllocationNode);
                    }
                }
                else
                {
                    collateralValueAllocation_ = new CollateralValueAllocation(collateralValueAllocationNode);
                }
            }
            
        
        }
        
    
        #region AllocationPartyReference_
        private PartyReference allocationPartyReference_;
        public PartyReference AllocationPartyReference_
        {
            get
            {
                if (this.allocationPartyReference_ != null)
                {
                    return this.allocationPartyReference_; 
                }
                else if (this.allocationPartyReferenceIDRef_ != null)
                {
                    allocationPartyReference_ = IDManager.getID(allocationPartyReferenceIDRef_) as PartyReference;
                    return this.allocationPartyReference_; 
                }
                else
                {
                      return this.allocationPartyReference_; 
                }
            }
            set
            {
                if (this.allocationPartyReference_ != value)
                {
                    this.allocationPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string allocationPartyReferenceIDRef_ { get; set; }
        #region AllocationAccountReference_
        private AccountReference allocationAccountReference_;
        public AccountReference AllocationAccountReference_
        {
            get
            {
                if (this.allocationAccountReference_ != null)
                {
                    return this.allocationAccountReference_; 
                }
                else if (this.allocationAccountReferenceIDRef_ != null)
                {
                    allocationAccountReference_ = IDManager.getID(allocationAccountReferenceIDRef_) as AccountReference;
                    return this.allocationAccountReference_; 
                }
                else
                {
                      return this.allocationAccountReference_; 
                }
            }
            set
            {
                if (this.allocationAccountReference_ != value)
                {
                    this.allocationAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string allocationAccountReferenceIDRef_ { get; set; }
        #region CollateralValueAllocation_
        private CollateralValueAllocation collateralValueAllocation_;
        public CollateralValueAllocation CollateralValueAllocation_
        {
            get
            {
                if (this.collateralValueAllocation_ != null)
                {
                    return this.collateralValueAllocation_; 
                }
                else if (this.collateralValueAllocationIDRef_ != null)
                {
                    collateralValueAllocation_ = IDManager.getID(collateralValueAllocationIDRef_) as CollateralValueAllocation;
                    return this.collateralValueAllocation_; 
                }
                else
                {
                      return this.collateralValueAllocation_; 
                }
            }
            set
            {
                if (this.collateralValueAllocation_ != value)
                {
                    this.collateralValueAllocation_ = value;
                }
            }
        }
        #endregion
        
        public string collateralValueAllocationIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

