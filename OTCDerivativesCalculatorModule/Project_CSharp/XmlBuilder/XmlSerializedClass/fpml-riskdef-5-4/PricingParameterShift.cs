using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PricingParameterShift : ISerialized
    {
        public PricingParameterShift(XmlNode xmlNode)
        {
            XmlNode parameterReferenceNode = xmlNode.SelectSingleNode("parameterReference");
            
            if (parameterReferenceNode != null)
            {
                if (parameterReferenceNode.Attributes["href"] != null || parameterReferenceNode.Attributes["id"] != null) 
                {
                    if (parameterReferenceNode.Attributes["id"] != null) 
                    {
                        parameterReferenceIDRef_ = parameterReferenceNode.Attributes["id"].Value;
                        AssetOrTermPointOrPricingStructureReference ob = new AssetOrTermPointOrPricingStructureReference(parameterReferenceNode);
                        IDManager.SetID(parameterReferenceIDRef_, ob);
                    }
                    else if (parameterReferenceNode.Attributes["href"] != null)
                    {
                        parameterReferenceIDRef_ = parameterReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        parameterReference_ = new AssetOrTermPointOrPricingStructureReference(parameterReferenceNode);
                    }
                }
                else
                {
                    parameterReference_ = new AssetOrTermPointOrPricingStructureReference(parameterReferenceNode);
                }
            }
            
        
            XmlNode shiftNode = xmlNode.SelectSingleNode("shift");
            
            if (shiftNode != null)
            {
                if (shiftNode.Attributes["href"] != null || shiftNode.Attributes["id"] != null) 
                {
                    if (shiftNode.Attributes["id"] != null) 
                    {
                        shiftIDRef_ = shiftNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(shiftNode);
                        IDManager.SetID(shiftIDRef_, ob);
                    }
                    else if (shiftNode.Attributes["href"] != null)
                    {
                        shiftIDRef_ = shiftNode.Attributes["href"].Value;
                    }
                    else
                    {
                        shift_ = new XsdTypeDecimal(shiftNode);
                    }
                }
                else
                {
                    shift_ = new XsdTypeDecimal(shiftNode);
                }
            }
            
        
            XmlNode shiftUnitsNode = xmlNode.SelectSingleNode("shiftUnits");
            
            if (shiftUnitsNode != null)
            {
                if (shiftUnitsNode.Attributes["href"] != null || shiftUnitsNode.Attributes["id"] != null) 
                {
                    if (shiftUnitsNode.Attributes["id"] != null) 
                    {
                        shiftUnitsIDRef_ = shiftUnitsNode.Attributes["id"].Value;
                        PriceQuoteUnits ob = new PriceQuoteUnits(shiftUnitsNode);
                        IDManager.SetID(shiftUnitsIDRef_, ob);
                    }
                    else if (shiftUnitsNode.Attributes["href"] != null)
                    {
                        shiftUnitsIDRef_ = shiftUnitsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        shiftUnits_ = new PriceQuoteUnits(shiftUnitsNode);
                    }
                }
                else
                {
                    shiftUnits_ = new PriceQuoteUnits(shiftUnitsNode);
                }
            }
            
        
        }
        
    
        #region ParameterReference_
        private AssetOrTermPointOrPricingStructureReference parameterReference_;
        public AssetOrTermPointOrPricingStructureReference ParameterReference_
        {
            get
            {
                if (this.parameterReference_ != null)
                {
                    return this.parameterReference_; 
                }
                else if (this.parameterReferenceIDRef_ != null)
                {
                    parameterReference_ = IDManager.getID(parameterReferenceIDRef_) as AssetOrTermPointOrPricingStructureReference;
                    return this.parameterReference_; 
                }
                else
                {
                      return this.parameterReference_; 
                }
            }
            set
            {
                if (this.parameterReference_ != value)
                {
                    this.parameterReference_ = value;
                }
            }
        }
        #endregion
        
        public string parameterReferenceIDRef_ { get; set; }
        #region Shift_
        private XsdTypeDecimal shift_;
        public XsdTypeDecimal Shift_
        {
            get
            {
                if (this.shift_ != null)
                {
                    return this.shift_; 
                }
                else if (this.shiftIDRef_ != null)
                {
                    shift_ = IDManager.getID(shiftIDRef_) as XsdTypeDecimal;
                    return this.shift_; 
                }
                else
                {
                      return this.shift_; 
                }
            }
            set
            {
                if (this.shift_ != value)
                {
                    this.shift_ = value;
                }
            }
        }
        #endregion
        
        public string shiftIDRef_ { get; set; }
        #region ShiftUnits_
        private PriceQuoteUnits shiftUnits_;
        public PriceQuoteUnits ShiftUnits_
        {
            get
            {
                if (this.shiftUnits_ != null)
                {
                    return this.shiftUnits_; 
                }
                else if (this.shiftUnitsIDRef_ != null)
                {
                    shiftUnits_ = IDManager.getID(shiftUnitsIDRef_) as PriceQuoteUnits;
                    return this.shiftUnits_; 
                }
                else
                {
                      return this.shiftUnits_; 
                }
            }
            set
            {
                if (this.shiftUnits_ != value)
                {
                    this.shiftUnits_ = value;
                }
            }
        }
        #endregion
        
        public string shiftUnitsIDRef_ { get; set; }
        
    
        
    
    }
    
}

