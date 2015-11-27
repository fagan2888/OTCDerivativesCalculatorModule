using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Rounding : ISerialized
    {
        public Rounding(XmlNode xmlNode)
        {
            XmlNode roundingDirectionNode = xmlNode.SelectSingleNode("roundingDirection");
            
            if (roundingDirectionNode != null)
            {
                if (roundingDirectionNode.Attributes["href"] != null || roundingDirectionNode.Attributes["id"] != null) 
                {
                    if (roundingDirectionNode.Attributes["id"] != null) 
                    {
                        roundingDirectionIDRef_ = roundingDirectionNode.Attributes["id"].Value;
                        RoundingDirectionEnum ob = new RoundingDirectionEnum(roundingDirectionNode);
                        IDManager.SetID(roundingDirectionIDRef_, ob);
                    }
                    else if (roundingDirectionNode.Attributes["href"] != null)
                    {
                        roundingDirectionIDRef_ = roundingDirectionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        roundingDirection_ = new RoundingDirectionEnum(roundingDirectionNode);
                    }
                }
                else
                {
                    roundingDirection_ = new RoundingDirectionEnum(roundingDirectionNode);
                }
            }
            
        
            XmlNode precisionNode = xmlNode.SelectSingleNode("precision");
            
            if (precisionNode != null)
            {
                if (precisionNode.Attributes["href"] != null || precisionNode.Attributes["id"] != null) 
                {
                    if (precisionNode.Attributes["id"] != null) 
                    {
                        precisionIDRef_ = precisionNode.Attributes["id"].Value;
                        XsdTypeNonNegativeInteger ob = new XsdTypeNonNegativeInteger(precisionNode);
                        IDManager.SetID(precisionIDRef_, ob);
                    }
                    else if (precisionNode.Attributes["href"] != null)
                    {
                        precisionIDRef_ = precisionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        precision_ = new XsdTypeNonNegativeInteger(precisionNode);
                    }
                }
                else
                {
                    precision_ = new XsdTypeNonNegativeInteger(precisionNode);
                }
            }
            
        
        }
        
    
        #region RoundingDirection_
        private RoundingDirectionEnum roundingDirection_;
        public RoundingDirectionEnum RoundingDirection_
        {
            get
            {
                if (this.roundingDirection_ != null)
                {
                    return this.roundingDirection_; 
                }
                else if (this.roundingDirectionIDRef_ != null)
                {
                    roundingDirection_ = IDManager.getID(roundingDirectionIDRef_) as RoundingDirectionEnum;
                    return this.roundingDirection_; 
                }
                else
                {
                      return this.roundingDirection_; 
                }
            }
            set
            {
                if (this.roundingDirection_ != value)
                {
                    this.roundingDirection_ = value;
                }
            }
        }
        #endregion
        
        public string roundingDirectionIDRef_ { get; set; }
        #region Precision_
        private XsdTypeNonNegativeInteger precision_;
        public XsdTypeNonNegativeInteger Precision_
        {
            get
            {
                if (this.precision_ != null)
                {
                    return this.precision_; 
                }
                else if (this.precisionIDRef_ != null)
                {
                    precision_ = IDManager.getID(precisionIDRef_) as XsdTypeNonNegativeInteger;
                    return this.precision_; 
                }
                else
                {
                      return this.precision_; 
                }
            }
            set
            {
                if (this.precision_ != value)
                {
                    this.precision_ = value;
                }
            }
        }
        #endregion
        
        public string precisionIDRef_ { get; set; }
        
    
        
    
    }
    
}

