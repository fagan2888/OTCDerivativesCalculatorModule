using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Function : ISerialized
    {
        public Function(XmlNode xmlNode)
        {
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
            
        
            XmlNode truefalseNode = xmlNode.SelectSingleNode("truefalse");
            
            if (truefalseNode != null)
            {
                if (truefalseNode.Attributes["href"] != null || truefalseNode.Attributes["id"] != null) 
                {
                    if (truefalseNode.Attributes["id"] != null) 
                    {
                        truefalseIDRef_ = truefalseNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(truefalseNode);
                        IDManager.SetID(truefalseIDRef_, ob);
                    }
                    else if (truefalseNode.Attributes["href"] != null)
                    {
                        truefalseIDRef_ = truefalseNode.Attributes["href"].Value;
                    }
                    else
                    {
                        truefalse_ = new XsdTypeBoolean(truefalseNode);
                    }
                }
                else
                {
                    truefalse_ = new XsdTypeBoolean(truefalseNode);
                }
            }
            
        
        }
        
    
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
        #region Truefalse_
        private XsdTypeBoolean truefalse_;
        public XsdTypeBoolean Truefalse_
        {
            get
            {
                if (this.truefalse_ != null)
                {
                    return this.truefalse_; 
                }
                else if (this.truefalseIDRef_ != null)
                {
                    truefalse_ = IDManager.getID(truefalseIDRef_) as XsdTypeBoolean;
                    return this.truefalse_; 
                }
                else
                {
                      return this.truefalse_; 
                }
            }
            set
            {
                if (this.truefalse_ != value)
                {
                    this.truefalse_ = value;
                }
            }
        }
        #endregion
        
        public string truefalseIDRef_ { get; set; }
        
    
        
    
    }
    
}

