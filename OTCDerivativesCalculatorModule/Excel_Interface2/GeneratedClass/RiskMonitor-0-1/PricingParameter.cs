using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PricingParameter : ISerialized
    {
        public PricingParameter() { }
        public PricingParameter(XmlNode xmlNode)
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
            
        
            XmlNode methodNode = xmlNode.SelectSingleNode("method");
            
            if (methodNode != null)
            {
                if (methodNode.Attributes["href"] != null || methodNode.Attributes["id"] != null) 
                {
                    if (methodNode.Attributes["id"] != null) 
                    {
                        methodIDRef_ = methodNode.Attributes["id"].Value;
                        Method ob = new Method(methodNode);
                        IDManager.SetID(methodIDRef_, ob);
                    }
                    else if (methodNode.Attributes["href"] != null)
                    {
                        methodIDRef_ = methodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        method_ = new Method(methodNode);
                    }
                }
                else
                {
                    method_ = new Method(methodNode);
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
        #region Method_
        private Method method_;
        public Method Method_
        {
            get
            {
                if (this.method_ != null)
                {
                    return this.method_; 
                }
                else if (this.methodIDRef_ != null)
                {
                    method_ = IDManager.getID(methodIDRef_) as Method;
                    return this.method_; 
                }
                else
                {
                    throw new Exception( "method_Node no exist!");
                }
            }
            set
            {
                if (this.method_ != value)
                {
                    this.method_ = value;
                }
            }
        }
        #endregion
        
        public string methodIDRef_ { get; set; }
        
    
        
    
    }
    
}

