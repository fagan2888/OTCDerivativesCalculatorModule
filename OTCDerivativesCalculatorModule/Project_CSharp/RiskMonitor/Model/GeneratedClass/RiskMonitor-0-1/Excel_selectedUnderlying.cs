using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_selectedUnderlying : ISerialized
    {
        public Excel_selectedUnderlying() { }
        public Excel_selectedUnderlying(XmlNode xmlNode)
        : base(xmlNode)
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
            
        
            XmlNode checkedNode = xmlNode.SelectSingleNode("checked");
            
            if (checkedNode != null)
            {
                if (checkedNode.Attributes["href"] != null || checkedNode.Attributes["id"] != null) 
                {
                    if (checkedNode.Attributes["id"] != null) 
                    {
                        checkedIDRef_ = checkedNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(checkedNode);
                        IDManager.SetID(checkedIDRef_, ob);
                    }
                    else if (checkedNode.Attributes["href"] != null)
                    {
                        checkedIDRef_ = checkedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        checked_ = new XsdTypeToken(checkedNode);
                    }
                }
                else
                {
                    checked_ = new XsdTypeToken(checkedNode);
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
                    throw new Exception( "code_Node no exist!");
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
                    throw new Exception( "name_Node no exist!");
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
        #region Checked_
        private XsdTypeToken checked_;
        public XsdTypeToken Checked_
        {
            get
            {
                if (this.checked_ != null)
                {
                    return this.checked_; 
                }
                else if (this.checkedIDRef_ != null)
                {
                    checked_ = IDManager.getID(checkedIDRef_) as XsdTypeToken;
                    return this.checked_; 
                }
                else
                {
                    throw new Exception( "checked_Node no exist!");
                }
            }
            set
            {
                if (this.checked_ != value)
                {
                    this.checked_ = value;
                }
            }
        }
        #endregion
        
        public string checkedIDRef_ { get; set; }
        
    
        
    
    }
    
}

