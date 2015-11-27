using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FixedPrice : ISerialized
    {
        public FixedPrice(XmlNode xmlNode)
        {
            XmlNode priceNode = xmlNode.SelectSingleNode("price");
            
            if (priceNode != null)
            {
                if (priceNode.Attributes["href"] != null || priceNode.Attributes["id"] != null) 
                {
                    if (priceNode.Attributes["id"] != null) 
                    {
                        priceIDRef_ = priceNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(priceNode);
                        IDManager.SetID(priceIDRef_, ob);
                    }
                    else if (priceNode.Attributes["href"] != null)
                    {
                        priceIDRef_ = priceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        price_ = new XsdTypeDecimal(priceNode);
                    }
                }
                else
                {
                    price_ = new XsdTypeDecimal(priceNode);
                }
            }
            
        
            XmlNode priceCurrencyNode = xmlNode.SelectSingleNode("priceCurrency");
            
            if (priceCurrencyNode != null)
            {
                if (priceCurrencyNode.Attributes["href"] != null || priceCurrencyNode.Attributes["id"] != null) 
                {
                    if (priceCurrencyNode.Attributes["id"] != null) 
                    {
                        priceCurrencyIDRef_ = priceCurrencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(priceCurrencyNode);
                        IDManager.SetID(priceCurrencyIDRef_, ob);
                    }
                    else if (priceCurrencyNode.Attributes["href"] != null)
                    {
                        priceCurrencyIDRef_ = priceCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        priceCurrency_ = new Currency(priceCurrencyNode);
                    }
                }
                else
                {
                    priceCurrency_ = new Currency(priceCurrencyNode);
                }
            }
            
        
            XmlNode priceUnitNode = xmlNode.SelectSingleNode("priceUnit");
            
            if (priceUnitNode != null)
            {
                if (priceUnitNode.Attributes["href"] != null || priceUnitNode.Attributes["id"] != null) 
                {
                    if (priceUnitNode.Attributes["id"] != null) 
                    {
                        priceUnitIDRef_ = priceUnitNode.Attributes["id"].Value;
                        QuantityUnit ob = new QuantityUnit(priceUnitNode);
                        IDManager.SetID(priceUnitIDRef_, ob);
                    }
                    else if (priceUnitNode.Attributes["href"] != null)
                    {
                        priceUnitIDRef_ = priceUnitNode.Attributes["href"].Value;
                    }
                    else
                    {
                        priceUnit_ = new QuantityUnit(priceUnitNode);
                    }
                }
                else
                {
                    priceUnit_ = new QuantityUnit(priceUnitNode);
                }
            }
            
        
        }
        
    
        #region Price_
        private XsdTypeDecimal price_;
        public XsdTypeDecimal Price_
        {
            get
            {
                if (this.price_ != null)
                {
                    return this.price_; 
                }
                else if (this.priceIDRef_ != null)
                {
                    price_ = IDManager.getID(priceIDRef_) as XsdTypeDecimal;
                    return this.price_; 
                }
                else
                {
                      return this.price_; 
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
        #region PriceCurrency_
        private Currency priceCurrency_;
        public Currency PriceCurrency_
        {
            get
            {
                if (this.priceCurrency_ != null)
                {
                    return this.priceCurrency_; 
                }
                else if (this.priceCurrencyIDRef_ != null)
                {
                    priceCurrency_ = IDManager.getID(priceCurrencyIDRef_) as Currency;
                    return this.priceCurrency_; 
                }
                else
                {
                      return this.priceCurrency_; 
                }
            }
            set
            {
                if (this.priceCurrency_ != value)
                {
                    this.priceCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string priceCurrencyIDRef_ { get; set; }
        #region PriceUnit_
        private QuantityUnit priceUnit_;
        public QuantityUnit PriceUnit_
        {
            get
            {
                if (this.priceUnit_ != null)
                {
                    return this.priceUnit_; 
                }
                else if (this.priceUnitIDRef_ != null)
                {
                    priceUnit_ = IDManager.getID(priceUnitIDRef_) as QuantityUnit;
                    return this.priceUnit_; 
                }
                else
                {
                      return this.priceUnit_; 
                }
            }
            set
            {
                if (this.priceUnit_ != value)
                {
                    this.priceUnit_ = value;
                }
            }
        }
        #endregion
        
        public string priceUnitIDRef_ { get; set; }
        
    
        
    
    }
    
}

