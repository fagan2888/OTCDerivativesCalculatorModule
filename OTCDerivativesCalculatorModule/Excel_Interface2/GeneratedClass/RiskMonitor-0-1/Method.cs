using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Method : ISerialized
    {
        public Method() { }
        public Method(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode typeNode = xmlNode.SelectSingleNode("type");
            
            if (typeNode != null)
            {
                if (typeNode.Attributes["href"] != null || typeNode.Attributes["id"] != null) 
                {
                    if (typeNode.Attributes["id"] != null) 
                    {
                        typeIDRef_ = typeNode.Attributes["id"].Value;
                        XsdTypeToken ob = new XsdTypeToken(typeNode);
                        IDManager.SetID(typeIDRef_, ob);
                    }
                    else if (typeNode.Attributes["href"] != null)
                    {
                        typeIDRef_ = typeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        type_ = new XsdTypeToken(typeNode);
                    }
                }
                else
                {
                    type_ = new XsdTypeToken(typeNode);
                }
            }
            
        
            XmlNode monteNode = xmlNode.SelectSingleNode("monte");
            
            if (monteNode != null)
            {
                if (monteNode.Attributes["href"] != null || monteNode.Attributes["id"] != null) 
                {
                    if (monteNode.Attributes["id"] != null) 
                    {
                        monteIDRef_ = monteNode.Attributes["id"].Value;
                        Monte ob = new Monte(monteNode);
                        IDManager.SetID(monteIDRef_, ob);
                    }
                    else if (monteNode.Attributes["href"] != null)
                    {
                        monteIDRef_ = monteNode.Attributes["href"].Value;
                    }
                    else
                    {
                        monte_ = new Monte(monteNode);
                    }
                }
                else
                {
                    monte_ = new Monte(monteNode);
                }
            }
            
        
        }
        
    
        #region Type_
        private XsdTypeToken type_;
        public XsdTypeToken Type_
        {
            get
            {
                if (this.type_ != null)
                {
                    return this.type_; 
                }
                else if (this.typeIDRef_ != null)
                {
                    type_ = IDManager.getID(typeIDRef_) as XsdTypeToken;
                    return this.type_; 
                }
                else
                {
                    throw new Exception( "type_Node no exist!");
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
        #region Monte_
        private Monte monte_;
        public Monte Monte_
        {
            get
            {
                if (this.monte_ != null)
                {
                    return this.monte_; 
                }
                else if (this.monteIDRef_ != null)
                {
                    monte_ = IDManager.getID(monteIDRef_) as Monte;
                    return this.monte_; 
                }
                else
                {
                    throw new Exception( "monte_Node no exist!");
                }
            }
            set
            {
                if (this.monte_ != value)
                {
                    this.monte_ = value;
                }
            }
        }
        #endregion
        
        public string monteIDRef_ { get; set; }
        public string choiceStr_methodType;
        
    
        
    
    }
    
}

