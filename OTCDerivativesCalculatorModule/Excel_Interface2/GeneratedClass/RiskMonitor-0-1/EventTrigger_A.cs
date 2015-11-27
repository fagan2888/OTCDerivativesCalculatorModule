using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EventTrigger_A : ISerialized
    {
        public EventTrigger_A() { }
        public EventTrigger_A(XmlNode xmlNode)
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
            
        
            XmlNode fixedRatePayoff_ANode = xmlNode.SelectSingleNode("fixedRatePayoff_A");
            
            if (fixedRatePayoff_ANode != null)
            {
                if (fixedRatePayoff_ANode.Attributes["href"] != null || fixedRatePayoff_ANode.Attributes["id"] != null) 
                {
                    if (fixedRatePayoff_ANode.Attributes["id"] != null) 
                    {
                        fixedRatePayoff_AIDRef_ = fixedRatePayoff_ANode.Attributes["id"].Value;
                        FixedRatePayoff_A ob = new FixedRatePayoff_A(fixedRatePayoff_ANode);
                        IDManager.SetID(fixedRatePayoff_AIDRef_, ob);
                    }
                    else if (fixedRatePayoff_ANode.Attributes["href"] != null)
                    {
                        fixedRatePayoff_AIDRef_ = fixedRatePayoff_ANode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedRatePayoff_A_ = new FixedRatePayoff_A(fixedRatePayoff_ANode);
                    }
                }
                else
                {
                    fixedRatePayoff_A_ = new FixedRatePayoff_A(fixedRatePayoff_ANode);
                }
            }
            
        
            XmlNode vanillaFloatingRatePayoff_ANode = xmlNode.SelectSingleNode("vanillaFloatingRatePayoff_A");
            
            if (vanillaFloatingRatePayoff_ANode != null)
            {
                if (vanillaFloatingRatePayoff_ANode.Attributes["href"] != null || vanillaFloatingRatePayoff_ANode.Attributes["id"] != null) 
                {
                    if (vanillaFloatingRatePayoff_ANode.Attributes["id"] != null) 
                    {
                        vanillaFloatingRatePayoff_AIDRef_ = vanillaFloatingRatePayoff_ANode.Attributes["id"].Value;
                        VanillaFloatingRatePayoff_A ob = new VanillaFloatingRatePayoff_A(vanillaFloatingRatePayoff_ANode);
                        IDManager.SetID(vanillaFloatingRatePayoff_AIDRef_, ob);
                    }
                    else if (vanillaFloatingRatePayoff_ANode.Attributes["href"] != null)
                    {
                        vanillaFloatingRatePayoff_AIDRef_ = vanillaFloatingRatePayoff_ANode.Attributes["href"].Value;
                    }
                    else
                    {
                        vanillaFloatingRatePayoff_A_ = new VanillaFloatingRatePayoff_A(vanillaFloatingRatePayoff_ANode);
                    }
                }
                else
                {
                    vanillaFloatingRatePayoff_A_ = new VanillaFloatingRatePayoff_A(vanillaFloatingRatePayoff_ANode);
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
        #region FixedRatePayoff_A_
        private FixedRatePayoff_A fixedRatePayoff_A_;
        public FixedRatePayoff_A FixedRatePayoff_A_
        {
            get
            {
                if (this.fixedRatePayoff_A_ != null)
                {
                    return this.fixedRatePayoff_A_; 
                }
                else if (this.fixedRatePayoff_AIDRef_ != null)
                {
                    fixedRatePayoff_A_ = IDManager.getID(fixedRatePayoff_AIDRef_) as FixedRatePayoff_A;
                    return this.fixedRatePayoff_A_; 
                }
                else
                {
                    throw new Exception( "fixedRatePayoff_A_Node no exist!");
                }
            }
            set
            {
                if (this.fixedRatePayoff_A_ != value)
                {
                    this.fixedRatePayoff_A_ = value;
                }
            }
        }
        #endregion
        
        public string fixedRatePayoff_AIDRef_ { get; set; }
        #region VanillaFloatingRatePayoff_A_
        private VanillaFloatingRatePayoff_A vanillaFloatingRatePayoff_A_;
        public VanillaFloatingRatePayoff_A VanillaFloatingRatePayoff_A_
        {
            get
            {
                if (this.vanillaFloatingRatePayoff_A_ != null)
                {
                    return this.vanillaFloatingRatePayoff_A_; 
                }
                else if (this.vanillaFloatingRatePayoff_AIDRef_ != null)
                {
                    vanillaFloatingRatePayoff_A_ = IDManager.getID(vanillaFloatingRatePayoff_AIDRef_) as VanillaFloatingRatePayoff_A;
                    return this.vanillaFloatingRatePayoff_A_; 
                }
                else
                {
                    throw new Exception( "vanillaFloatingRatePayoff_A_Node no exist!");
                }
            }
            set
            {
                if (this.vanillaFloatingRatePayoff_A_ != value)
                {
                    this.vanillaFloatingRatePayoff_A_ = value;
                }
            }
        }
        #endregion
        
        public string vanillaFloatingRatePayoff_AIDRef_ { get; set; }
        public string choiceStr_eventTriggerType_A;
        
    
        
    
    }
    
}

