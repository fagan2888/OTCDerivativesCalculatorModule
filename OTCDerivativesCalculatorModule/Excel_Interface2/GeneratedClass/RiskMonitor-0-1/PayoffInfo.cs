using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PayoffInfo : ISerialized
    {
        public PayoffInfo() { }
        public PayoffInfo(XmlNode xmlNode)
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
            
        
            XmlNode preDefinedVariableListNode = xmlNode.SelectSingleNode("preDefinedVariableList");
            
            if (preDefinedVariableListNode != null)
            {
                if (preDefinedVariableListNode.Attributes["href"] != null || preDefinedVariableListNode.Attributes["id"] != null) 
                {
                    if (preDefinedVariableListNode.Attributes["id"] != null) 
                    {
                        preDefinedVariableListIDRef_ = preDefinedVariableListNode.Attributes["id"].Value;
                        PreDefinedVariableList ob = new PreDefinedVariableList(preDefinedVariableListNode);
                        IDManager.SetID(preDefinedVariableListIDRef_, ob);
                    }
                    else if (preDefinedVariableListNode.Attributes["href"] != null)
                    {
                        preDefinedVariableListIDRef_ = preDefinedVariableListNode.Attributes["href"].Value;
                    }
                    else
                    {
                        preDefinedVariableList_ = new PreDefinedVariableList(preDefinedVariableListNode);
                    }
                }
                else
                {
                    preDefinedVariableList_ = new PreDefinedVariableList(preDefinedVariableListNode);
                }
            }
            
        
            XmlNode stopLossPayoffNode = xmlNode.SelectSingleNode("stopLossPayoff");
            
            if (stopLossPayoffNode != null)
            {
                if (stopLossPayoffNode.Attributes["href"] != null || stopLossPayoffNode.Attributes["id"] != null) 
                {
                    if (stopLossPayoffNode.Attributes["id"] != null) 
                    {
                        stopLossPayoffIDRef_ = stopLossPayoffNode.Attributes["id"].Value;
                        StopLossPayoff ob = new StopLossPayoff(stopLossPayoffNode);
                        IDManager.SetID(stopLossPayoffIDRef_, ob);
                    }
                    else if (stopLossPayoffNode.Attributes["href"] != null)
                    {
                        stopLossPayoffIDRef_ = stopLossPayoffNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stopLossPayoff_ = new StopLossPayoff(stopLossPayoffNode);
                    }
                }
                else
                {
                    stopLossPayoff_ = new StopLossPayoff(stopLossPayoffNode);
                }
            }
            
        
            XmlNode vanillaPayoffNode = xmlNode.SelectSingleNode("vanillaPayoff");
            
            if (vanillaPayoffNode != null)
            {
                if (vanillaPayoffNode.Attributes["href"] != null || vanillaPayoffNode.Attributes["id"] != null) 
                {
                    if (vanillaPayoffNode.Attributes["id"] != null) 
                    {
                        vanillaPayoffIDRef_ = vanillaPayoffNode.Attributes["id"].Value;
                        VanillaPayoff ob = new VanillaPayoff(vanillaPayoffNode);
                        IDManager.SetID(vanillaPayoffIDRef_, ob);
                    }
                    else if (vanillaPayoffNode.Attributes["href"] != null)
                    {
                        vanillaPayoffIDRef_ = vanillaPayoffNode.Attributes["href"].Value;
                    }
                    else
                    {
                        vanillaPayoff_ = new VanillaPayoff(vanillaPayoffNode);
                    }
                }
                else
                {
                    vanillaPayoff_ = new VanillaPayoff(vanillaPayoffNode);
                }
            }
            
        
            XmlNode compositeSumOptionPayoffNode = xmlNode.SelectSingleNode("compositeSumOptionPayoff");
            
            if (compositeSumOptionPayoffNode != null)
            {
                if (compositeSumOptionPayoffNode.Attributes["href"] != null || compositeSumOptionPayoffNode.Attributes["id"] != null) 
                {
                    if (compositeSumOptionPayoffNode.Attributes["id"] != null) 
                    {
                        compositeSumOptionPayoffIDRef_ = compositeSumOptionPayoffNode.Attributes["id"].Value;
                        CompositeSumOptionPayoff ob = new CompositeSumOptionPayoff(compositeSumOptionPayoffNode);
                        IDManager.SetID(compositeSumOptionPayoffIDRef_, ob);
                    }
                    else if (compositeSumOptionPayoffNode.Attributes["href"] != null)
                    {
                        compositeSumOptionPayoffIDRef_ = compositeSumOptionPayoffNode.Attributes["href"].Value;
                    }
                    else
                    {
                        compositeSumOptionPayoff_ = new CompositeSumOptionPayoff(compositeSumOptionPayoffNode);
                    }
                }
                else
                {
                    compositeSumOptionPayoff_ = new CompositeSumOptionPayoff(compositeSumOptionPayoffNode);
                }
            }
            
        
            XmlNode autoCallablePayoffNode = xmlNode.SelectSingleNode("autoCallablePayoff");
            
            if (autoCallablePayoffNode != null)
            {
                if (autoCallablePayoffNode.Attributes["href"] != null || autoCallablePayoffNode.Attributes["id"] != null) 
                {
                    if (autoCallablePayoffNode.Attributes["id"] != null) 
                    {
                        autoCallablePayoffIDRef_ = autoCallablePayoffNode.Attributes["id"].Value;
                        AutoCallablePayoff ob = new AutoCallablePayoff(autoCallablePayoffNode);
                        IDManager.SetID(autoCallablePayoffIDRef_, ob);
                    }
                    else if (autoCallablePayoffNode.Attributes["href"] != null)
                    {
                        autoCallablePayoffIDRef_ = autoCallablePayoffNode.Attributes["href"].Value;
                    }
                    else
                    {
                        autoCallablePayoff_ = new AutoCallablePayoff(autoCallablePayoffNode);
                    }
                }
                else
                {
                    autoCallablePayoff_ = new AutoCallablePayoff(autoCallablePayoffNode);
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
        #region PreDefinedVariableList_
        private PreDefinedVariableList preDefinedVariableList_;
        public PreDefinedVariableList PreDefinedVariableList_
        {
            get
            {
                if (this.preDefinedVariableList_ != null)
                {
                    return this.preDefinedVariableList_; 
                }
                else if (this.preDefinedVariableListIDRef_ != null)
                {
                    preDefinedVariableList_ = IDManager.getID(preDefinedVariableListIDRef_) as PreDefinedVariableList;
                    return this.preDefinedVariableList_; 
                }
                else
                {
                    throw new Exception( "preDefinedVariableList_Node no exist!");
                }
            }
            set
            {
                if (this.preDefinedVariableList_ != value)
                {
                    this.preDefinedVariableList_ = value;
                }
            }
        }
        #endregion
        
        public string preDefinedVariableListIDRef_ { get; set; }
        #region StopLossPayoff_
        private StopLossPayoff stopLossPayoff_;
        public StopLossPayoff StopLossPayoff_
        {
            get
            {
                if (this.stopLossPayoff_ != null)
                {
                    return this.stopLossPayoff_; 
                }
                else if (this.stopLossPayoffIDRef_ != null)
                {
                    stopLossPayoff_ = IDManager.getID(stopLossPayoffIDRef_) as StopLossPayoff;
                    return this.stopLossPayoff_; 
                }
                else
                {
                    throw new Exception( "stopLossPayoff_Node no exist!");
                }
            }
            set
            {
                if (this.stopLossPayoff_ != value)
                {
                    this.stopLossPayoff_ = value;
                }
            }
        }
        #endregion
        
        public string stopLossPayoffIDRef_ { get; set; }
        #region VanillaPayoff_
        private VanillaPayoff vanillaPayoff_;
        public VanillaPayoff VanillaPayoff_
        {
            get
            {
                if (this.vanillaPayoff_ != null)
                {
                    return this.vanillaPayoff_; 
                }
                else if (this.vanillaPayoffIDRef_ != null)
                {
                    vanillaPayoff_ = IDManager.getID(vanillaPayoffIDRef_) as VanillaPayoff;
                    return this.vanillaPayoff_; 
                }
                else
                {
                    throw new Exception( "vanillaPayoff_Node no exist!");
                }
            }
            set
            {
                if (this.vanillaPayoff_ != value)
                {
                    this.vanillaPayoff_ = value;
                }
            }
        }
        #endregion
        
        public string vanillaPayoffIDRef_ { get; set; }
        #region CompositeSumOptionPayoff_
        private CompositeSumOptionPayoff compositeSumOptionPayoff_;
        public CompositeSumOptionPayoff CompositeSumOptionPayoff_
        {
            get
            {
                if (this.compositeSumOptionPayoff_ != null)
                {
                    return this.compositeSumOptionPayoff_; 
                }
                else if (this.compositeSumOptionPayoffIDRef_ != null)
                {
                    compositeSumOptionPayoff_ = IDManager.getID(compositeSumOptionPayoffIDRef_) as CompositeSumOptionPayoff;
                    return this.compositeSumOptionPayoff_; 
                }
                else
                {
                    throw new Exception( "compositeSumOptionPayoff_Node no exist!");
                }
            }
            set
            {
                if (this.compositeSumOptionPayoff_ != value)
                {
                    this.compositeSumOptionPayoff_ = value;
                }
            }
        }
        #endregion
        
        public string compositeSumOptionPayoffIDRef_ { get; set; }
        #region AutoCallablePayoff_
        private AutoCallablePayoff autoCallablePayoff_;
        public AutoCallablePayoff AutoCallablePayoff_
        {
            get
            {
                if (this.autoCallablePayoff_ != null)
                {
                    return this.autoCallablePayoff_; 
                }
                else if (this.autoCallablePayoffIDRef_ != null)
                {
                    autoCallablePayoff_ = IDManager.getID(autoCallablePayoffIDRef_) as AutoCallablePayoff;
                    return this.autoCallablePayoff_; 
                }
                else
                {
                    throw new Exception( "autoCallablePayoff_Node no exist!");
                }
            }
            set
            {
                if (this.autoCallablePayoff_ != value)
                {
                    this.autoCallablePayoff_ = value;
                }
            }
        }
        #endregion
        
        public string autoCallablePayoffIDRef_ { get; set; }
        public string choiceStr_payoffType;
        
    
        
    
    }
    
}

