using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class JointSimpleCalculation : ISerialized
    {
        public JointSimpleCalculation() { }
        public JointSimpleCalculation(XmlNode xmlNode)
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
            
        
            XmlNode andSimpleCalNode = xmlNode.SelectSingleNode("andSimpleCal");
            
            if (andSimpleCalNode != null)
            {
                if (andSimpleCalNode.Attributes["href"] != null || andSimpleCalNode.Attributes["id"] != null) 
                {
                    if (andSimpleCalNode.Attributes["id"] != null) 
                    {
                        andSimpleCalIDRef_ = andSimpleCalNode.Attributes["id"].Value;
                        AndSimpleCal ob = new AndSimpleCal(andSimpleCalNode);
                        IDManager.SetID(andSimpleCalIDRef_, ob);
                    }
                    else if (andSimpleCalNode.Attributes["href"] != null)
                    {
                        andSimpleCalIDRef_ = andSimpleCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        andSimpleCal_ = new AndSimpleCal(andSimpleCalNode);
                    }
                }
                else
                {
                    andSimpleCal_ = new AndSimpleCal(andSimpleCalNode);
                }
            }
            
        
            XmlNode singeSimpleCalNode = xmlNode.SelectSingleNode("singeSimpleCal");
            
            if (singeSimpleCalNode != null)
            {
                if (singeSimpleCalNode.Attributes["href"] != null || singeSimpleCalNode.Attributes["id"] != null) 
                {
                    if (singeSimpleCalNode.Attributes["id"] != null) 
                    {
                        singeSimpleCalIDRef_ = singeSimpleCalNode.Attributes["id"].Value;
                        SingeSimpleCal ob = new SingeSimpleCal(singeSimpleCalNode);
                        IDManager.SetID(singeSimpleCalIDRef_, ob);
                    }
                    else if (singeSimpleCalNode.Attributes["href"] != null)
                    {
                        singeSimpleCalIDRef_ = singeSimpleCalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        singeSimpleCal_ = new SingeSimpleCal(singeSimpleCalNode);
                    }
                }
                else
                {
                    singeSimpleCal_ = new SingeSimpleCal(singeSimpleCalNode);
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
        #region AndSimpleCal_
        private AndSimpleCal andSimpleCal_;
        public AndSimpleCal AndSimpleCal_
        {
            get
            {
                if (this.andSimpleCal_ != null)
                {
                    return this.andSimpleCal_; 
                }
                else if (this.andSimpleCalIDRef_ != null)
                {
                    andSimpleCal_ = IDManager.getID(andSimpleCalIDRef_) as AndSimpleCal;
                    return this.andSimpleCal_; 
                }
                else
                {
                    throw new Exception( "andSimpleCal_Node no exist!");
                }
            }
            set
            {
                if (this.andSimpleCal_ != value)
                {
                    this.andSimpleCal_ = value;
                }
            }
        }
        #endregion
        
        public string andSimpleCalIDRef_ { get; set; }
        #region SingeSimpleCal_
        private SingeSimpleCal singeSimpleCal_;
        public SingeSimpleCal SingeSimpleCal_
        {
            get
            {
                if (this.singeSimpleCal_ != null)
                {
                    return this.singeSimpleCal_; 
                }
                else if (this.singeSimpleCalIDRef_ != null)
                {
                    singeSimpleCal_ = IDManager.getID(singeSimpleCalIDRef_) as SingeSimpleCal;
                    return this.singeSimpleCal_; 
                }
                else
                {
                    throw new Exception( "singeSimpleCal_Node no exist!");
                }
            }
            set
            {
                if (this.singeSimpleCal_ != value)
                {
                    this.singeSimpleCal_ = value;
                }
            }
        }
        #endregion
        
        public string singeSimpleCalIDRef_ { get; set; }
        public string choiceStr_jointSimpleType;
        
    
        
    
    }
    
}

