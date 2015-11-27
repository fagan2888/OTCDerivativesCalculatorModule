using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FloatingStrikePrice : FloatingLegCalculation
    {
        public FloatingStrikePrice(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode commodityNode = xmlNode.SelectSingleNode("commodity");
            
            if (commodityNode != null)
            {
                if (commodityNode.Attributes["href"] != null || commodityNode.Attributes["id"] != null) 
                {
                    if (commodityNode.Attributes["id"] != null) 
                    {
                        commodityIDRef_ = commodityNode.Attributes["id"].Value;
                        Commodity ob = new Commodity(commodityNode);
                        IDManager.SetID(commodityIDRef_, ob);
                    }
                    else if (commodityNode.Attributes["href"] != null)
                    {
                        commodityIDRef_ = commodityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commodity_ = new Commodity(commodityNode);
                    }
                }
                else
                {
                    commodity_ = new Commodity(commodityNode);
                }
            }
            
        
        }
        
    
        #region Commodity_
        private Commodity commodity_;
        public Commodity Commodity_
        {
            get
            {
                if (this.commodity_ != null)
                {
                    return this.commodity_; 
                }
                else if (this.commodityIDRef_ != null)
                {
                    commodity_ = IDManager.getID(commodityIDRef_) as Commodity;
                    return this.commodity_; 
                }
                else
                {
                      return this.commodity_; 
                }
            }
            set
            {
                if (this.commodity_ != value)
                {
                    this.commodity_ = value;
                }
            }
        }
        #endregion
        
        public string commodityIDRef_ { get; set; }
        
    
        
    
    }
    
}

