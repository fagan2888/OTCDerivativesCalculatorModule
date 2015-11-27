using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommodityIndex : ISerialized
    {
        public CommodityIndex(XmlNode xmlNode)
        {
            XmlNode codeNode = xmlNode.SelectSingleNode("code");
            
            if (codeNode != null)
            {
                if (codeNode.Attributes["href"] != null || codeNode.Attributes["id"] != null) 
                {
                    if (codeNode.Attributes["id"] != null) 
                    {
                        codeIDRef_ = codeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(codeNode);
                        IDManager.SetID(codeIDRef_, ob);
                    }
                    else if (codeNode.Attributes["href"] != null)
                    {
                        codeIDRef_ = codeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        code_ = new XsdTypeToken(codeNode);
                    }
                }
                else
                {
                    code_ = new XsdTypeToken(codeNode);
                }
            }
            
        
            XmlNode nameNode = xmlNode.SelectSingleNode("name");
            
            if (nameNode != null)
            {
                if (nameNode.Attributes["href"] != null || nameNode.Attributes["id"] != null) 
                {
                    if (nameNode.Attributes["id"] != null) 
                    {
                        nameIDRef_ = nameNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(nameNode);
                        IDManager.SetID(nameIDRef_, ob);
                    }
                    else if (nameNode.Attributes["href"] != null)
                    {
                        nameIDRef_ = nameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        name_ = new XsdTypeToken(nameNode);
                    }
                }
                else
                {
                    name_ = new XsdTypeToken(nameNode);
                }
            }
            
        
            XmlNode indexTypeNode = xmlNode.SelectSingleNode("indexType");
            
            if (indexTypeNode != null)
            {
                if (indexTypeNode.Attributes["href"] != null || indexTypeNode.Attributes["id"] != null) 
                {
                    if (indexTypeNode.Attributes["id"] != null) 
                    {
                        indexTypeIDRef_ = indexTypeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(indexTypeNode);
                        IDManager.SetID(indexTypeIDRef_, ob);
                    }
                    else if (indexTypeNode.Attributes["href"] != null)
                    {
                        indexTypeIDRef_ = indexTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexType_ = new XsdTypeToken(indexTypeNode);
                    }
                }
                else
                {
                    indexType_ = new XsdTypeToken(indexTypeNode);
                }
            }
            
        
        }
        
    
        #region Code_
        private XsdTypeToken code_;
        public XsdTypeToken Code_
        {
            get
            {
                if (this.code_ != null)
                {
                    return this.code_; 
                }
                else if (this.codeIDRef_ != null)
                {
                    code_ = IDManager.getID(codeIDRef_) as XsdTypeToken;
                    return this.code_; 
                }
                else
                {
                      return this.code_; 
                }
            }
            set
            {
                if (this.code_ != value)
                {
                    this.code_ = value;
                }
            }
        }
        #endregion
        
        public string codeIDRef_ { get; set; }
        #region Name_
        private XsdTypeToken name_;
        public XsdTypeToken Name_
        {
            get
            {
                if (this.name_ != null)
                {
                    return this.name_; 
                }
                else if (this.nameIDRef_ != null)
                {
                    name_ = IDManager.getID(nameIDRef_) as XsdTypeToken;
                    return this.name_; 
                }
                else
                {
                      return this.name_; 
                }
            }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                }
            }
        }
        #endregion
        
        public string nameIDRef_ { get; set; }
        #region IndexType_
        private XsdTypeToken indexType_;
        public XsdTypeToken IndexType_
        {
            get
            {
                if (this.indexType_ != null)
                {
                    return this.indexType_; 
                }
                else if (this.indexTypeIDRef_ != null)
                {
                    indexType_ = IDManager.getID(indexTypeIDRef_) as XsdTypeToken;
                    return this.indexType_; 
                }
                else
                {
                      return this.indexType_; 
                }
            }
            set
            {
                if (this.indexType_ != value)
                {
                    this.indexType_ = value;
                }
            }
        }
        #endregion
        
        public string indexTypeIDRef_ { get; set; }
        
    
        
    
    }
    
}

