using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class RateCouponCalculation : ISerialized
    {
        public RateCouponCalculation() { }
        public RateCouponCalculation(XmlNode xmlNode)
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
            
        
            XmlNode fixedRateCouponCalculationNode = xmlNode.SelectSingleNode("fixedRateCouponCalculation");
            
            if (fixedRateCouponCalculationNode != null)
            {
                if (fixedRateCouponCalculationNode.Attributes["href"] != null || fixedRateCouponCalculationNode.Attributes["id"] != null) 
                {
                    if (fixedRateCouponCalculationNode.Attributes["id"] != null) 
                    {
                        fixedRateCouponCalculationIDRef_ = fixedRateCouponCalculationNode.Attributes["id"].Value;
                        FixedRateCouponCalculation ob = new FixedRateCouponCalculation(fixedRateCouponCalculationNode);
                        IDManager.SetID(fixedRateCouponCalculationIDRef_, ob);
                    }
                    else if (fixedRateCouponCalculationNode.Attributes["href"] != null)
                    {
                        fixedRateCouponCalculationIDRef_ = fixedRateCouponCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedRateCouponCalculation_ = new FixedRateCouponCalculation(fixedRateCouponCalculationNode);
                    }
                }
                else
                {
                    fixedRateCouponCalculation_ = new FixedRateCouponCalculation(fixedRateCouponCalculationNode);
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
        #region FixedRateCouponCalculation_
        private FixedRateCouponCalculation fixedRateCouponCalculation_;
        public FixedRateCouponCalculation FixedRateCouponCalculation_
        {
            get
            {
                if (this.fixedRateCouponCalculation_ != null)
                {
                    return this.fixedRateCouponCalculation_; 
                }
                else if (this.fixedRateCouponCalculationIDRef_ != null)
                {
                    fixedRateCouponCalculation_ = IDManager.getID(fixedRateCouponCalculationIDRef_) as FixedRateCouponCalculation;
                    return this.fixedRateCouponCalculation_; 
                }
                else
                {
                    throw new Exception( "fixedRateCouponCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.fixedRateCouponCalculation_ != value)
                {
                    this.fixedRateCouponCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string fixedRateCouponCalculationIDRef_ { get; set; }
        public string choiceStr_rateCouponCalType;
        
    
        
    
    }
    
}

