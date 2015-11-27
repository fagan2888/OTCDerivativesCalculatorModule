using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Allocations : ISerialized
    {
        public Allocations(XmlNode xmlNode)
        {
            XmlNodeList allocationNodeList = xmlNode.SelectNodes("allocation");
            
            if (allocationNodeList != null)
            {
                this.allocation_ = new List<Allocation>();
                foreach (XmlNode item in allocationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            allocationIDRef_ = item.Attributes["id"].Value;
                            allocation_.Add(new Allocation(item));
                            IDManager.SetID(allocationIDRef_, allocation_[allocation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            allocationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        allocation_.Add(new Allocation(item));
                        }
                    }
                    else
                    {
                        allocation_.Add(new Allocation(item));
                    }
                }
            }
            
        
        }
        
    
        #region Allocation_
        private List<Allocation> allocation_;
        public List<Allocation> Allocation_
        {
            get
            {
                if (this.allocation_ != null)
                {
                    return this.allocation_; 
                }
                else if (this.allocationIDRef_ != null)
                {
                    return this.allocation_; 
                }
                else
                {
                      return this.allocation_; 
                }
            }
            set
            {
                if (this.allocation_ != value)
                {
                    this.allocation_ = value;
                }
            }
        }
        #endregion
        
        public string allocationIDRef_ { get; set; }
        
    
        
    
    }
    
}

