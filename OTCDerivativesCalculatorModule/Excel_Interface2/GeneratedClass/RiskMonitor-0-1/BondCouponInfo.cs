using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BondCouponInfo : ISerialized
    {
        public BondCouponInfo() { }
        public BondCouponInfo(XmlNode xmlNode)
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
            
        
            XmlNode fixedRateTypeNode = xmlNode.SelectSingleNode("fixedRateType");
            
            if (fixedRateTypeNode != null)
            {
                if (fixedRateTypeNode.Attributes["href"] != null || fixedRateTypeNode.Attributes["id"] != null) 
                {
                    if (fixedRateTypeNode.Attributes["id"] != null) 
                    {
                        fixedRateTypeIDRef_ = fixedRateTypeNode.Attributes["id"].Value;
                        FixedRateType ob = new FixedRateType(fixedRateTypeNode);
                        IDManager.SetID(fixedRateTypeIDRef_, ob);
                    }
                    else if (fixedRateTypeNode.Attributes["href"] != null)
                    {
                        fixedRateTypeIDRef_ = fixedRateTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedRateType_ = new FixedRateType(fixedRateTypeNode);
                    }
                }
                else
                {
                    fixedRateType_ = new FixedRateType(fixedRateTypeNode);
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
        #region FixedRateType_
        private FixedRateType fixedRateType_;
        public FixedRateType FixedRateType_
        {
            get
            {
                if (this.fixedRateType_ != null)
                {
                    return this.fixedRateType_; 
                }
                else if (this.fixedRateTypeIDRef_ != null)
                {
                    fixedRateType_ = IDManager.getID(fixedRateTypeIDRef_) as FixedRateType;
                    return this.fixedRateType_; 
                }
                else
                {
                    throw new Exception( "fixedRateType_Node no exist!");
                }
            }
            set
            {
                if (this.fixedRateType_ != value)
                {
                    this.fixedRateType_ = value;
                }
            }
        }
        #endregion
        
        public string fixedRateTypeIDRef_ { get; set; }
        public string choiceStr_bondCouponType;
        
    
        
    
    }
    
}

