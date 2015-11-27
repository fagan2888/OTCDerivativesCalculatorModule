using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Excel_result : ISerialized
    {
        public Excel_result() { }
        public Excel_result(XmlNode xmlNode)
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
            
        
            XmlNode priceNode = xmlNode.SelectSingleNode("price");
            
            if (priceNode != null)
            {
                if (priceNode.Attributes["href"] != null || priceNode.Attributes["id"] != null) 
                {
                    if (priceNode.Attributes["id"] != null) 
                    {
                        priceIDRef_ = priceNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(priceNode);
                        IDManager.SetID(priceIDRef_, ob);
                    }
                    else if (priceNode.Attributes["href"] != null)
                    {
                        priceIDRef_ = priceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        price_ = new XsdTypeDouble(priceNode);
                    }
                }
                else
                {
                    price_ = new XsdTypeDouble(priceNode);
                }
            }
            
        
            XmlNode unitPriceNode = xmlNode.SelectSingleNode("unitPrice");
            
            if (unitPriceNode != null)
            {
                if (unitPriceNode.Attributes["href"] != null || unitPriceNode.Attributes["id"] != null) 
                {
                    if (unitPriceNode.Attributes["id"] != null) 
                    {
                        unitPriceIDRef_ = unitPriceNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(unitPriceNode);
                        IDManager.SetID(unitPriceIDRef_, ob);
                    }
                    else if (unitPriceNode.Attributes["href"] != null)
                    {
                        unitPriceIDRef_ = unitPriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unitPrice_ = new XsdTypeDouble(unitPriceNode);
                    }
                }
                else
                {
                    unitPrice_ = new XsdTypeDouble(unitPriceNode);
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
        #region Price_
        private XsdTypeDouble price_;
        public XsdTypeDouble Price_
        {
            get
            {
                if (this.price_ != null)
                {
                    return this.price_; 
                }
                else if (this.priceIDRef_ != null)
                {
                    price_ = IDManager.getID(priceIDRef_) as XsdTypeDouble;
                    return this.price_; 
                }
                else
                {
                    throw new Exception( "price_Node no exist!");
                }
            }
            set
            {
                if (this.price_ != value)
                {
                    this.price_ = value;
                }
            }
        }
        #endregion
        
        public string priceIDRef_ { get; set; }
        #region UnitPrice_
        private XsdTypeDouble unitPrice_;
        public XsdTypeDouble UnitPrice_
        {
            get
            {
                if (this.unitPrice_ != null)
                {
                    return this.unitPrice_; 
                }
                else if (this.unitPriceIDRef_ != null)
                {
                    unitPrice_ = IDManager.getID(unitPriceIDRef_) as XsdTypeDouble;
                    return this.unitPrice_; 
                }
                else
                {
                    throw new Exception( "unitPrice_Node no exist!");
                }
            }
            set
            {
                if (this.unitPrice_ != value)
                {
                    this.unitPrice_ = value;
                }
            }
        }
        #endregion
        
        public string unitPriceIDRef_ { get; set; }
        
    
        
    
    }
    
}

