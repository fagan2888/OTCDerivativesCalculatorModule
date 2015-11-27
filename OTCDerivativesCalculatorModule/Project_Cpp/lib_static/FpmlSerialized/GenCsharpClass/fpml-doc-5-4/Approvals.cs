using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Approvals
    {
        public Approvals(XmlNode xmlNode)
        {
            XmlNodeList approvalNodeList = xmlNode.SelectNodes("approval");
            
            foreach (XmlNode item in approvalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        approvalIDRef = item.Attributes["id"].Name;
                        List<Approval> ob = new List<Approval>();
                        ob.Add(new Approval(item));
                        IDManager.SetID(approvalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        approvalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    approval.Add(new Approval(item));
                    }
                }
            }
            
        
        }
        
    
        #region Approval
        private List<Approval> approval;
        public List<Approval> Approval
        {
            get
            {
                if (this.approval != null)
                {
                    return this.approval; 
                }
                else if (this.approvalIDRef != null)
                {
                    approval = IDManager.getID(approvalIDRef) as List<Approval>;
                    return this.approval; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.approval != value)
                {
                    this.approval = value;
                }
            }
        }
        #endregion
        
        public string ApprovalIDRef { get; set; }
        
    
        
    
    }
    
}

