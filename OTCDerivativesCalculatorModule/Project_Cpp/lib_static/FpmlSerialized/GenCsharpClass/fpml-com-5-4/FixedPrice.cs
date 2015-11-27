using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FixedPrice
    {
        public FixedPrice(XmlNode xmlNode)
        {
            XmlNodeList priceNodeList = xmlNode.SelectNodes("price");
            if (priceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in priceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        priceIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(priceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        priceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        price = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList priceCurrencyNodeList = xmlNode.SelectNodes("priceCurrency");
            if (priceCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in priceCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        priceCurrencyIDRef = item.Attributes["id"].Name;
                        Currency ob = Currency();
                        IDManager.SetID(priceCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        priceCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        priceCurrency = new Currency(item);
                    }
                }
            }
            
        
            XmlNodeList priceUnitNodeList = xmlNode.SelectNodes("priceUnit");
            if (priceUnitNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in priceUnitNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        priceUnitIDRef = item.Attributes["id"].Name;
                        QuantityUnit ob = QuantityUnit();
                        IDManager.SetID(priceUnitIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        priceUnitIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        priceUnit = new QuantityUnit(item);
                    }
                }
            }
            
        
        }
        
    
        #region Price
        private XsdTypeDecimal price;
        public XsdTypeDecimal Price
        {
            get
            {
                if (this.price != null)
                {
                    return this.price; 
                }
                else if (this.priceIDRef != null)
                {
                    price = IDManager.getID(priceIDRef) as XsdTypeDecimal;
                    return this.price; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.price != value)
                {
                    this.price = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region PriceCurrency
        private Currency priceCurrency;
        public Currency PriceCurrency
        {
            get
            {
                if (this.priceCurrency != null)
                {
                    return this.priceCurrency; 
                }
                else if (this.priceCurrencyIDRef != null)
                {
                    priceCurrency = IDManager.getID(priceCurrencyIDRef) as Currency;
                    return this.priceCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.priceCurrency != value)
                {
                    this.priceCurrency = value;
                }
            }
        }
        #endregion
        
        public string CurrencyIDRef { get; set; }
        #region PriceUnit
        private QuantityUnit priceUnit;
        public QuantityUnit PriceUnit
        {
            get
            {
                if (this.priceUnit != null)
                {
                    return this.priceUnit; 
                }
                else if (this.priceUnitIDRef != null)
                {
                    priceUnit = IDManager.getID(priceUnitIDRef) as QuantityUnit;
                    return this.priceUnit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.priceUnit != value)
                {
                    this.priceUnit = value;
                }
            }
        }
        #endregion
        
        public string QuantityUnitIDRef { get; set; }
        
    
        
    
    }
    
}

