using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Approvals : ISerialized
    {
        public Approvals(XmlNode xmlNode)
        {
            XmlNodeList approvalNodeList = xmlNode.SelectNodes("approval");
            
            if (approvalNodeList != null)
            {
                this.approval_ = new List<Approval>();
                foreach (XmlNode item in approvalNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            approvalIDRef_ = item.Attributes["id"].Value;
                            approval_.Add(new Approval(item));
                            IDManager.SetID(approvalIDRef_, approval_[approval_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            approvalIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        approval_.Add(new Approval(item));
                        }
                    }
                    else
                    {
                        approval_.Add(new Approval(item));
                    }
                }
            }
            
        
        }
        
    
        #region Approval_
        private List<Approval> approval_;
        public List<Approval> Approval_
        {
            get
            {
                if (this.approval_ != null)
                {
                    return this.approval_; 
                }
                else if (this.approvalIDRef_ != null)
                {
                    return this.approval_; 
                }
                else
                {
                      return this.approval_; 
                }
            }
            set
            {
                if (this.approval_ != value)
                {
                    this.approval_ = value;
                }
            }
        }
        #endregion
        
        public string approvalIDRef_ { get; set; }
        
    
        
    
    }
    
}

