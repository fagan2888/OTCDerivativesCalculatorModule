using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class UnitQuantity : ISerialized
    {
        public UnitQuantity(XmlNode xmlNode)
        {
            XmlNode quantityUnitNode = xmlNode.SelectSingleNode("quantityUnit");
            
            if (quantityUnitNode != null)
            {
                if (quantityUnitNode.Attributes["href"] != null || quantityUnitNode.Attributes["id"] != null) 
                {
                    if (quantityUnitNode.Attributes["id"] != null) 
                    {
                        quantityUnitIDRef_ = quantityUnitNode.Attributes["id"].Value;
                        QuantityUnit ob = new QuantityUnit(quantityUnitNode);
                        IDManager.SetID(quantityUnitIDRef_, ob);
                    }
                    else if (quantityUnitNode.Attributes["href"] != null)
                    {
                        quantityUnitIDRef_ = quantityUnitNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quantityUnit_ = new QuantityUnit(quantityUnitNode);
                    }
                }
                else
                {
                    quantityUnit_ = new QuantityUnit(quantityUnitNode);
                }
            }
            
        
            XmlNode quantityNode = xmlNode.SelectSingleNode("quantity");
            
            if (quantityNode != null)
            {
                if (quantityNode.Attributes["href"] != null || quantityNode.Attributes["id"] != null) 
                {
                    if (quantityNode.Attributes["id"] != null) 
                    {
                        quantityIDRef_ = quantityNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(quantityNode);
                        IDManager.SetID(quantityIDRef_, ob);
                    }
                    else if (quantityNode.Attributes["href"] != null)
                    {
                        quantityIDRef_ = quantityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quantity_ = new NonNegativeDecimal(quantityNode);
                    }
                }
                else
                {
                    quantity_ = new NonNegativeDecimal(quantityNode);
                }
            }
            
        
        }
        
    
        #region QuantityUnit_
        private QuantityUnit quantityUnit_;
        public QuantityUnit QuantityUnit_
        {
            get
            {
                if (this.quantityUnit_ != null)
                {
                    return this.quantityUnit_; 
                }
                else if (this.quantityUnitIDRef_ != null)
                {
                    quantityUnit_ = IDManager.getID(quantityUnitIDRef_) as QuantityUnit;
                    return this.quantityUnit_; 
                }
                else
                {
                      return this.quantityUnit_; 
                }
            }
            set
            {
                if (this.quantityUnit_ != value)
                {
                    this.quantityUnit_ = value;
                }
            }
        }
        #endregion
        
        public string quantityUnitIDRef_ { get; set; }
        #region Quantity_
        private NonNegativeDecimal quantity_;
        public NonNegativeDecimal Quantity_
        {
            get
            {
                if (this.quantity_ != null)
                {
                    return this.quantity_; 
                }
                else if (this.quantityIDRef_ != null)
                {
                    quantity_ = IDManager.getID(quantityIDRef_) as NonNegativeDecimal;
                    return this.quantity_; 
                }
                else
                {
                      return this.quantity_; 
                }
            }
            set
            {
                if (this.quantity_ != value)
                {
                    this.quantity_ = value;
                }
            }
        }
        #endregion
        
        public string quantityIDRef_ { get; set; }
        
    
        
    
    }
    
}

