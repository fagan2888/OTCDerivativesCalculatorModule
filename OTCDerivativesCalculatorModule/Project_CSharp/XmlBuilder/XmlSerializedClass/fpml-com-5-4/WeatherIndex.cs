using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class WeatherIndex : ISerialized
    {
        public WeatherIndex(XmlNode xmlNode)
        {
            XmlNode quantityNode = xmlNode.SelectSingleNode("quantity");
            
            if (quantityNode != null)
            {
                if (quantityNode.Attributes["href"] != null || quantityNode.Attributes["id"] != null) 
                {
                    if (quantityNode.Attributes["id"] != null) 
                    {
                        quantityIDRef_ = quantityNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(quantityNode);
                        IDManager.SetID(quantityIDRef_, ob);
                    }
                    else if (quantityNode.Attributes["href"] != null)
                    {
                        quantityIDRef_ = quantityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quantity_ = new XsdTypeDecimal(quantityNode);
                    }
                }
                else
                {
                    quantity_ = new XsdTypeDecimal(quantityNode);
                }
            }
            
        
            XmlNode unitNode = xmlNode.SelectSingleNode("unit");
            
            if (unitNode != null)
            {
                if (unitNode.Attributes["href"] != null || unitNode.Attributes["id"] != null) 
                {
                    if (unitNode.Attributes["id"] != null) 
                    {
                        unitIDRef_ = unitNode.Attributes["id"].Value;
                        QuantityUnit ob = new QuantityUnit(unitNode);
                        IDManager.SetID(unitIDRef_, ob);
                    }
                    else if (unitNode.Attributes["href"] != null)
                    {
                        unitIDRef_ = unitNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unit_ = new QuantityUnit(unitNode);
                    }
                }
                else
                {
                    unit_ = new QuantityUnit(unitNode);
                }
            }
            
        
        }
        
    
        #region Quantity_
        private XsdTypeDecimal quantity_;
        public XsdTypeDecimal Quantity_
        {
            get
            {
                if (this.quantity_ != null)
                {
                    return this.quantity_; 
                }
                else if (this.quantityIDRef_ != null)
                {
                    quantity_ = IDManager.getID(quantityIDRef_) as XsdTypeDecimal;
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
        #region Unit_
        private QuantityUnit unit_;
        public QuantityUnit Unit_
        {
            get
            {
                if (this.unit_ != null)
                {
                    return this.unit_; 
                }
                else if (this.unitIDRef_ != null)
                {
                    unit_ = IDManager.getID(unitIDRef_) as QuantityUnit;
                    return this.unit_; 
                }
                else
                {
                      return this.unit_; 
                }
            }
            set
            {
                if (this.unit_ != value)
                {
                    this.unit_ = value;
                }
            }
        }
        #endregion
        
        public string unitIDRef_ { get; set; }
        
    
        
    
    }
    
}

