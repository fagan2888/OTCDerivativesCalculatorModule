using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Approval : ISerialized
    {
        public Approval(XmlNode xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        XsdTypeNormalizedString ob = new XsdTypeNormalizedString(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new XsdTypeNormalizedString(typeNode);
                    }
                }
                else
                {
                    type_ = new XsdTypeNormalizedString(typeNode);
                }
            }
            
        
            XmlNode statusNode = xmlNode.SelectSingleNode("status");
            
            if (statusNode != null)
            {
                if (statusNode.Attributes["href"] != null || statusNode.Attributes["id"] != null) 
                {
                    if (statusNode.Attributes["id"] != null) 
                    {
                        statusIDRef_ = statusNode.Attributes["id"].Value;
                        XsdTypeNormalizedString ob = new XsdTypeNormalizedString(statusNode);
                        IDManager.SetID(statusIDRef_, ob);
                    }
                    else if (statusNode.Attributes["href"] != null)
                    {
                        statusIDRef_ = statusNode.Attributes["href"].Value;
                    }
                    else
                    {
                        status_ = new XsdTypeNormalizedString(statusNode);
                    }
                }
                else
                {
                    status_ = new XsdTypeNormalizedString(statusNode);
                }
            }
            
        
            XmlNode approverNode = xmlNode.SelectSingleNode("approver");
            
            if (approverNode != null)
            {
                if (approverNode.Attributes["href"] != null || approverNode.Attributes["id"] != null) 
                {
                    if (approverNode.Attributes["id"] != null) 
                    {
                        approverIDRef_ = approverNode.Attributes["id"].Value;
                        XsdTypeNormalizedString ob = new XsdTypeNormalizedString(approverNode);
                        IDManager.SetID(approverIDRef_, ob);
                    }
                    else if (approverNode.Attributes["href"] != null)
                    {
                        approverIDRef_ = approverNode.Attributes["href"].Value;
                    }
                    else
                    {
                        approver_ = new XsdTypeNormalizedString(approverNode);
                    }
                }
                else
                {
                    approver_ = new XsdTypeNormalizedString(approverNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private XsdTypeNormalizedString type_;
        public XsdTypeNormalizedString Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as XsdTypeNormalizedString;
                    return this.type_; 
                }
                else
                {
                      return this.type_; 
                }
            }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                }
            }
        }
        #endregion
        
        public string typeIDRef_ { get; set; }
        #region Status_
        private XsdTypeNormalizedString status_;
        public XsdTypeNormalizedString Status_
        {
            get
            {
                if (this.status_ != null)
                {
                    return this.status_; 
                }
                else if (this.statusIDRef_ != null)
                {
                    status_ = IDManager.getID(statusIDRef_) as XsdTypeNormalizedString;
                    return this.status_; 
                }
                else
                {
                      return this.status_; 
                }
            }
            set
            {
                if (this.status_ != value)
                {
                    this.status_ = value;
                }
            }
        }
        #endregion
        
        public string statusIDRef_ { get; set; }
        #region Approver_
        private XsdTypeNormalizedString approver_;
        public XsdTypeNormalizedString Approver_
        {
            get
            {
                if (this.approver_ != null)
                {
                    return this.approver_; 
                }
                else if (this.approverIDRef_ != null)
                {
                    approver_ = IDManager.getID(approverIDRef_) as XsdTypeNormalizedString;
                    return this.approver_; 
                }
                else
                {
                      return this.approver_; 
                }
            }
            set
            {
                if (this.approver_ != value)
                {
                    this.approver_ = value;
                }
            }
        }
        #endregion
        
        public string approverIDRef_ { get; set; }
        
    
        
    
    }
    
}

