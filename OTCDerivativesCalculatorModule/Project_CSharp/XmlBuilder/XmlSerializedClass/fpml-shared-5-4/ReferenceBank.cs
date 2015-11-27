using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ReferenceBank : ISerialized
    {
        public ReferenceBank(XmlNode xmlNode)
        {
            XmlNode referenceBankIdNode = xmlNode.SelectSingleNode("referenceBankId");
            
            if (referenceBankIdNode != null)
            {
                if (referenceBankIdNode.Attributes["href"] != null || referenceBankIdNode.Attributes["id"] != null) 
                {
                    if (referenceBankIdNode.Attributes["id"] != null) 
                    {
                        referenceBankIdIDRef_ = referenceBankIdNode.Attributes["id"].Value;
                        ReferenceBankId ob = new ReferenceBankId(referenceBankIdNode);
                        IDManager.SetID(referenceBankIdIDRef_, ob);
                    }
                    else if (referenceBankIdNode.Attributes["href"] != null)
                    {
                        referenceBankIdIDRef_ = referenceBankIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceBankId_ = new ReferenceBankId(referenceBankIdNode);
                    }
                }
                else
                {
                    referenceBankId_ = new ReferenceBankId(referenceBankIdNode);
                }
            }
            
        
            XmlNode referenceBankNameNode = xmlNode.SelectSingleNode("referenceBankName");
            
            if (referenceBankNameNode != null)
            {
                if (referenceBankNameNode.Attributes["href"] != null || referenceBankNameNode.Attributes["id"] != null) 
                {
                    if (referenceBankNameNode.Attributes["id"] != null) 
                    {
                        referenceBankNameIDRef_ = referenceBankNameNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(referenceBankNameNode);
                        IDManager.SetID(referenceBankNameIDRef_, ob);
                    }
                    else if (referenceBankNameNode.Attributes["href"] != null)
                    {
                        referenceBankNameIDRef_ = referenceBankNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceBankName_ = new XsdTypeString(referenceBankNameNode);
                    }
                }
                else
                {
                    referenceBankName_ = new XsdTypeString(referenceBankNameNode);
                }
            }
            
        
        }
        
    
        #region ReferenceBankId_
        private ReferenceBankId referenceBankId_;
        public ReferenceBankId ReferenceBankId_
        {
            get
            {
                if (this.referenceBankId_ != null)
                {
                    return this.referenceBankId_; 
                }
                else if (this.referenceBankIdIDRef_ != null)
                {
                    referenceBankId_ = IDManager.getID(referenceBankIdIDRef_) as ReferenceBankId;
                    return this.referenceBankId_; 
                }
                else
                {
                      return this.referenceBankId_; 
                }
            }
            set
            {
                if (this.referenceBankId_ != value)
                {
                    this.referenceBankId_ = value;
                }
            }
        }
        #endregion
        
        public string referenceBankIdIDRef_ { get; set; }
        #region ReferenceBankName_
        private XsdTypeString referenceBankName_;
        public XsdTypeString ReferenceBankName_
        {
            get
            {
                if (this.referenceBankName_ != null)
                {
                    return this.referenceBankName_; 
                }
                else if (this.referenceBankNameIDRef_ != null)
                {
                    referenceBankName_ = IDManager.getID(referenceBankNameIDRef_) as XsdTypeString;
                    return this.referenceBankName_; 
                }
                else
                {
                      return this.referenceBankName_; 
                }
            }
            set
            {
                if (this.referenceBankName_ != value)
                {
                    this.referenceBankName_ = value;
                }
            }
        }
        #endregion
        
        public string referenceBankNameIDRef_ { get; set; }
        
    
        
    
    }
    
}

