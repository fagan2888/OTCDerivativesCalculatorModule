using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ProposedCollateralAllocation
    {
        public ProposedCollateralAllocation(XmlNode xmlNode)
        {
            XmlNodeList allocationPartyReferenceNodeList = xmlNode.SelectNodes("allocationPartyReference");
            if (allocationPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in allocationPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        allocationPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(allocationPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        allocationPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        allocationPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList allocationAccountReferenceNodeList = xmlNode.SelectNodes("allocationAccountReference");
            if (allocationAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in allocationAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        allocationAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(allocationAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        allocationAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        allocationAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList collateralValueAllocationNodeList = xmlNode.SelectNodes("collateralValueAllocation");
            if (collateralValueAllocationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in collateralValueAllocationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        collateralValueAllocationIDRef = item.Attributes["id"].Name;
                        CollateralValueAllocation ob = CollateralValueAllocation();
                        IDManager.SetID(collateralValueAllocationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        collateralValueAllocationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        collateralValueAllocation = new CollateralValueAllocation(item);
                    }
                }
            }
            
        
        }
        
    
        #region AllocationPartyReference
        private PartyReference allocationPartyReference;
        public PartyReference AllocationPartyReference
        {
            get
            {
                if (this.allocationPartyReference != null)
                {
                    return this.allocationPartyReference; 
                }
                else if (this.allocationPartyReferenceIDRef != null)
                {
                    allocationPartyReference = IDManager.getID(allocationPartyReferenceIDRef) as PartyReference;
                    return this.allocationPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.allocationPartyReference != value)
                {
                    this.allocationPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region AllocationAccountReference
        private AccountReference allocationAccountReference;
        public AccountReference AllocationAccountReference
        {
            get
            {
                if (this.allocationAccountReference != null)
                {
                    return this.allocationAccountReference; 
                }
                else if (this.allocationAccountReferenceIDRef != null)
                {
                    allocationAccountReference = IDManager.getID(allocationAccountReferenceIDRef) as AccountReference;
                    return this.allocationAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.allocationAccountReference != value)
                {
                    this.allocationAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region CollateralValueAllocation
        private CollateralValueAllocation collateralValueAllocation;
        public CollateralValueAllocation CollateralValueAllocation
        {
            get
            {
                if (this.collateralValueAllocation != null)
                {
                    return this.collateralValueAllocation; 
                }
                else if (this.collateralValueAllocationIDRef != null)
                {
                    collateralValueAllocation = IDManager.getID(collateralValueAllocationIDRef) as CollateralValueAllocation;
                    return this.collateralValueAllocation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.collateralValueAllocation != value)
                {
                    this.collateralValueAllocation = value;
                }
            }
        }
        #endregion
        
        public string CollateralValueAllocationIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

