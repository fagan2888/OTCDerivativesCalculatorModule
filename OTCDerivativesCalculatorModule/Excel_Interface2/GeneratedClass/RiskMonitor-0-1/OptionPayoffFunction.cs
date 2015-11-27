using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class OptionPayoffFunction : ISerialized
    {
        public OptionPayoffFunction() { }
        public OptionPayoffFunction(XmlNode xmlNode)
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
            
        
            XmlNode vanillaCallFunctionNode = xmlNode.SelectSingleNode("vanillaCallFunction");
            
            if (vanillaCallFunctionNode != null)
            {
                if (vanillaCallFunctionNode.Attributes["href"] != null || vanillaCallFunctionNode.Attributes["id"] != null) 
                {
                    if (vanillaCallFunctionNode.Attributes["id"] != null) 
                    {
                        vanillaCallFunctionIDRef_ = vanillaCallFunctionNode.Attributes["id"].Value;
                        VanillaCallFunction ob = new VanillaCallFunction(vanillaCallFunctionNode);
                        IDManager.SetID(vanillaCallFunctionIDRef_, ob);
                    }
                    else if (vanillaCallFunctionNode.Attributes["href"] != null)
                    {
                        vanillaCallFunctionIDRef_ = vanillaCallFunctionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vanillaCallFunction_ = new VanillaCallFunction(vanillaCallFunctionNode);
                    }
                }
                else
                {
                    vanillaCallFunction_ = new VanillaCallFunction(vanillaCallFunctionNode);
                }
            }
            
        
            XmlNode vanillaPutFunctionNode = xmlNode.SelectSingleNode("vanillaPutFunction");
            
            if (vanillaPutFunctionNode != null)
            {
                if (vanillaPutFunctionNode.Attributes["href"] != null || vanillaPutFunctionNode.Attributes["id"] != null) 
                {
                    if (vanillaPutFunctionNode.Attributes["id"] != null) 
                    {
                        vanillaPutFunctionIDRef_ = vanillaPutFunctionNode.Attributes["id"].Value;
                        VanillaPutFunction ob = new VanillaPutFunction(vanillaPutFunctionNode);
                        IDManager.SetID(vanillaPutFunctionIDRef_, ob);
                    }
                    else if (vanillaPutFunctionNode.Attributes["href"] != null)
                    {
                        vanillaPutFunctionIDRef_ = vanillaPutFunctionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vanillaPutFunction_ = new VanillaPutFunction(vanillaPutFunctionNode);
                    }
                }
                else
                {
                    vanillaPutFunction_ = new VanillaPutFunction(vanillaPutFunctionNode);
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
        #region VanillaCallFunction_
        private VanillaCallFunction vanillaCallFunction_;
        public VanillaCallFunction VanillaCallFunction_
        {
            get
            {
                if (this.vanillaCallFunction_ != null)
                {
                    return this.vanillaCallFunction_; 
                }
                else if (this.vanillaCallFunctionIDRef_ != null)
                {
                    vanillaCallFunction_ = IDManager.getID(vanillaCallFunctionIDRef_) as VanillaCallFunction;
                    return this.vanillaCallFunction_; 
                }
                else
                {
                    throw new Exception( "vanillaCallFunction_Node no exist!");
                }
            }
            set
            {
                if (this.vanillaCallFunction_ != value)
                {
                    this.vanillaCallFunction_ = value;
                }
            }
        }
        #endregion
        
        public string vanillaCallFunctionIDRef_ { get; set; }
        #region VanillaPutFunction_
        private VanillaPutFunction vanillaPutFunction_;
        public VanillaPutFunction VanillaPutFunction_
        {
            get
            {
                if (this.vanillaPutFunction_ != null)
                {
                    return this.vanillaPutFunction_; 
                }
                else if (this.vanillaPutFunctionIDRef_ != null)
                {
                    vanillaPutFunction_ = IDManager.getID(vanillaPutFunctionIDRef_) as VanillaPutFunction;
                    return this.vanillaPutFunction_; 
                }
                else
                {
                    throw new Exception( "vanillaPutFunction_Node no exist!");
                }
            }
            set
            {
                if (this.vanillaPutFunction_ != value)
                {
                    this.vanillaPutFunction_ = value;
                }
            }
        }
        #endregion
        
        public string vanillaPutFunctionIDRef_ { get; set; }
        public string choiceStr_optionPayoffFunctionType;
        
    
        
    
    }
    
}

