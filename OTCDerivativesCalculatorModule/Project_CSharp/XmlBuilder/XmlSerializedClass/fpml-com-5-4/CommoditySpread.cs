using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommoditySpread : Money
    {
        public CommoditySpread(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode spreadConversionFactorNode = xmlNode.SelectSingleNode("spreadConversionFactor");
            
            if (spreadConversionFactorNode != null)
            {
                if (spreadConversionFactorNode.Attributes["href"] != null || spreadConversionFactorNode.Attributes["id"] != null) 
                {
                    if (spreadConversionFactorNode.Attributes["id"] != null) 
                    {
                        spreadConversionFactorIDRef_ = spreadConversionFactorNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(spreadConversionFactorNode);
                        IDManager.SetID(spreadConversionFactorIDRef_, ob);
                    }
                    else if (spreadConversionFactorNode.Attributes["href"] != null)
                    {
                        spreadConversionFactorIDRef_ = spreadConversionFactorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spreadConversionFactor_ = new XsdTypeDecimal(spreadConversionFactorNode);
                    }
                }
                else
                {
                    spreadConversionFactor_ = new XsdTypeDecimal(spreadConversionFactorNode);
                }
            }
            
        
            XmlNode spreadUnitNode = xmlNode.SelectSingleNode("spreadUnit");
            
            if (spreadUnitNode != null)
            {
                if (spreadUnitNode.Attributes["href"] != null || spreadUnitNode.Attributes["id"] != null) 
                {
                    if (spreadUnitNode.Attributes["id"] != null) 
                    {
                        spreadUnitIDRef_ = spreadUnitNode.Attributes["id"].Value;
                        QuantityUnit ob = new QuantityUnit(spreadUnitNode);
                        IDManager.SetID(spreadUnitIDRef_, ob);
                    }
                    else if (spreadUnitNode.Attributes["href"] != null)
                    {
                        spreadUnitIDRef_ = spreadUnitNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spreadUnit_ = new QuantityUnit(spreadUnitNode);
                    }
                }
                else
                {
                    spreadUnit_ = new QuantityUnit(spreadUnitNode);
                }
            }
            
        
        }
        
    
        #region SpreadConversionFactor_
        private XsdTypeDecimal spreadConversionFactor_;
        public XsdTypeDecimal SpreadConversionFactor_
        {
            get
            {
                if (this.spreadConversionFactor_ != null)
                {
                    return this.spreadConversionFactor_; 
                }
                else if (this.spreadConversionFactorIDRef_ != null)
                {
                    spreadConversionFactor_ = IDManager.getID(spreadConversionFactorIDRef_) as XsdTypeDecimal;
                    return this.spreadConversionFactor_; 
                }
                else
                {
                      return this.spreadConversionFactor_; 
                }
            }
            set
            {
                if (this.spreadConversionFactor_ != value)
                {
                    this.spreadConversionFactor_ = value;
                }
            }
        }
        #endregion
        
        public string spreadConversionFactorIDRef_ { get; set; }
        #region SpreadUnit_
        private QuantityUnit spreadUnit_;
        public QuantityUnit SpreadUnit_
        {
            get
            {
                if (this.spreadUnit_ != null)
                {
                    return this.spreadUnit_; 
                }
                else if (this.spreadUnitIDRef_ != null)
                {
                    spreadUnit_ = IDManager.getID(spreadUnitIDRef_) as QuantityUnit;
                    return this.spreadUnit_; 
                }
                else
                {
                      return this.spreadUnit_; 
                }
            }
            set
            {
                if (this.spreadUnit_ != value)
                {
                    this.spreadUnit_ = value;
                }
            }
        }
        #endregion
        
        public string spreadUnitIDRef_ { get; set; }
        
    
        
    
    }
    
}

