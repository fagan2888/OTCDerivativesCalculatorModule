using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Allocations
    {
        public Allocations(XmlNode xmlNode)
        {
            XmlNodeList allocationNodeList = xmlNode.SelectNodes("allocation");
            
            foreach (XmlNode item in allocationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        allocationIDRef = item.Attributes["id"].Name;
                        List<Allocation> ob = new List<Allocation>();
                        ob.Add(new Allocation(item));
                        IDManager.SetID(allocationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        allocationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    allocation.Add(new Allocation(item));
                    }
                }
            }
            
        
        }
        
    
        #region Allocation
        private List<Allocation> allocation;
        public List<Allocation> Allocation
        {
            get
            {
                if (this.allocation != null)
                {
                    return this.allocation; 
                }
                else if (this.allocationIDRef != null)
                {
                    allocation = IDManager.getID(allocationIDRef) as List<Allocation>;
                    return this.allocation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.allocation != value)
                {
                    this.allocation = value;
                }
            }
        }
        #endregion
        
        public string AllocationIDRef { get; set; }
        
    
        
    
    }
    
}

