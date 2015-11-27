using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class SwapPayoffInfo : ISerialized
    {
        public SwapPayoffInfo() { }
        public SwapPayoffInfo(XmlNode xmlNode)
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
            
        
            XmlNode vanillaSwapPayoffNode = xmlNode.SelectSingleNode("vanillaSwapPayoff");
            
            if (vanillaSwapPayoffNode != null)
            {
                if (vanillaSwapPayoffNode.Attributes["href"] != null || vanillaSwapPayoffNode.Attributes["id"] != null) 
                {
                    if (vanillaSwapPayoffNode.Attributes["id"] != null) 
                    {
                        vanillaSwapPayoffIDRef_ = vanillaSwapPayoffNode.Attributes["id"].Value;
                        VanillaSwapPayoff ob = new VanillaSwapPayoff(vanillaSwapPayoffNode);
                        IDManager.SetID(vanillaSwapPayoffIDRef_, ob);
                    }
                    else if (vanillaSwapPayoffNode.Attributes["href"] != null)
                    {
                        vanillaSwapPayoffIDRef_ = vanillaSwapPayoffNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vanillaSwapPayoff_ = new VanillaSwapPayoff(vanillaSwapPayoffNode);
                    }
                }
                else
                {
                    vanillaSwapPayoff_ = new VanillaSwapPayoff(vanillaSwapPayoffNode);
                }
            }
            
        
            XmlNode autoCallableSwapPayoffNode = xmlNode.SelectSingleNode("autoCallableSwapPayoff");
            
            if (autoCallableSwapPayoffNode != null)
            {
                if (autoCallableSwapPayoffNode.Attributes["href"] != null || autoCallableSwapPayoffNode.Attributes["id"] != null) 
                {
                    if (autoCallableSwapPayoffNode.Attributes["id"] != null) 
                    {
                        autoCallableSwapPayoffIDRef_ = autoCallableSwapPayoffNode.Attributes["id"].Value;
                        AutoCallableSwapPayoff ob = new AutoCallableSwapPayoff(autoCallableSwapPayoffNode);
                        IDManager.SetID(autoCallableSwapPayoffIDRef_, ob);
                    }
                    else if (autoCallableSwapPayoffNode.Attributes["href"] != null)
                    {
                        autoCallableSwapPayoffIDRef_ = autoCallableSwapPayoffNode.Attributes["href"].Value;
                    }
                    else
                    {
                        autoCallableSwapPayoff_ = new AutoCallableSwapPayoff(autoCallableSwapPayoffNode);
                    }
                }
                else
                {
                    autoCallableSwapPayoff_ = new AutoCallableSwapPayoff(autoCallableSwapPayoffNode);
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
        #region VanillaSwapPayoff_
        private VanillaSwapPayoff vanillaSwapPayoff_;
        public VanillaSwapPayoff VanillaSwapPayoff_
        {
            get
            {
                if (this.vanillaSwapPayoff_ != null)
                {
                    return this.vanillaSwapPayoff_; 
                }
                else if (this.vanillaSwapPayoffIDRef_ != null)
                {
                    vanillaSwapPayoff_ = IDManager.getID(vanillaSwapPayoffIDRef_) as VanillaSwapPayoff;
                    return this.vanillaSwapPayoff_; 
                }
                else
                {
                    throw new Exception( "vanillaSwapPayoff_Node no exist!");
                }
            }
            set
            {
                if (this.vanillaSwapPayoff_ != value)
                {
                    this.vanillaSwapPayoff_ = value;
                }
            }
        }
        #endregion
        
        public string vanillaSwapPayoffIDRef_ { get; set; }
        #region AutoCallableSwapPayoff_
        private AutoCallableSwapPayoff autoCallableSwapPayoff_;
        public AutoCallableSwapPayoff AutoCallableSwapPayoff_
        {
            get
            {
                if (this.autoCallableSwapPayoff_ != null)
                {
                    return this.autoCallableSwapPayoff_; 
                }
                else if (this.autoCallableSwapPayoffIDRef_ != null)
                {
                    autoCallableSwapPayoff_ = IDManager.getID(autoCallableSwapPayoffIDRef_) as AutoCallableSwapPayoff;
                    return this.autoCallableSwapPayoff_; 
                }
                else
                {
                    throw new Exception( "autoCallableSwapPayoff_Node no exist!");
                }
            }
            set
            {
                if (this.autoCallableSwapPayoff_ != value)
                {
                    this.autoCallableSwapPayoff_ = value;
                }
            }
        }
        #endregion
        
        public string autoCallableSwapPayoffIDRef_ { get; set; }
        public string choiceStr_swapPayoffType;
        
    
        
    
    }
    
}

