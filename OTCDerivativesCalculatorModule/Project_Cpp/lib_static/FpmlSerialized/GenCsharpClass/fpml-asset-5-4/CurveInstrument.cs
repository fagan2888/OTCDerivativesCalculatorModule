using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CurveInstrument
    {
        public CurveInstrument(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList currencyNodeList = xmlNode.SelectNodes("currency");
            if (currencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in currencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        currencyIDRef = item.Attributes["id"].Name;
                        Currency ob = Currency();
                        IDManager.SetID(currencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        currencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        currency = new Currency(item);
                    }
                }
            }
            
        
            XmlNodeList exchangeIdNodeList = xmlNode.SelectNodes("exchangeId");
            if (exchangeIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exchangeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exchangeIdIDRef = item.Attributes["id"].Name;
                        ExchangeId ob = ExchangeId();
                        IDManager.SetID(exchangeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exchangeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exchangeId = new ExchangeId(item);
                    }
                }
            }
            
        
            XmlNodeList clearanceSystemNodeList = xmlNode.SelectNodes("clearanceSystem");
            if (clearanceSystemNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in clearanceSystemNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        clearanceSystemIDRef = item.Attributes["id"].Name;
                        ClearanceSystem ob = ClearanceSystem();
                        IDManager.SetID(clearanceSystemIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        clearanceSystemIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        clearanceSystem = new ClearanceSystem(item);
                    }
                }
            }
            
        
            XmlNodeList definitionNodeList = xmlNode.SelectNodes("definition");
            if (definitionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in definitionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        definitionIDRef = item.Attributes["id"].Name;
                        ProductReference ob = ProductReference();
                        IDManager.SetID(definitionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        definitionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        definition = new ProductReference(item);
                    }
                }
            }
            
        
        }
        
    
        #region Currency
        private Currency currency;
        public Currency Currency
        {
            get
            {
                if (this.currency != null)
                {
                    return this.currency; 
                }
                else if (this.currencyIDRef != null)
                {
                    currency = IDManager.getID(currencyIDRef) as Currency;
                    return this.currency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.currency != value)
                {
                    this.currency = value;
                }
            }
        }
        #endregion
        
        public string CurrencyIDRef { get; set; }
        #region ExchangeId
        private ExchangeId exchangeId;
        public ExchangeId ExchangeId
        {
            get
            {
                if (this.exchangeId != null)
                {
                    return this.exchangeId; 
                }
                else if (this.exchangeIdIDRef != null)
                {
                    exchangeId = IDManager.getID(exchangeIdIDRef) as ExchangeId;
                    return this.exchangeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exchangeId != value)
                {
                    this.exchangeId = value;
                }
            }
        }
        #endregion
        
        public string ExchangeIdIDRef { get; set; }
        #region ClearanceSystem
        private ClearanceSystem clearanceSystem;
        public ClearanceSystem ClearanceSystem
        {
            get
            {
                if (this.clearanceSystem != null)
                {
                    return this.clearanceSystem; 
                }
                else if (this.clearanceSystemIDRef != null)
                {
                    clearanceSystem = IDManager.getID(clearanceSystemIDRef) as ClearanceSystem;
                    return this.clearanceSystem; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.clearanceSystem != value)
                {
                    this.clearanceSystem = value;
                }
            }
        }
        #endregion
        
        public string ClearanceSystemIDRef { get; set; }
        #region Definition
        private ProductReference definition;
        public ProductReference Definition
        {
            get
            {
                if (this.definition != null)
                {
                    return this.definition; 
                }
                else if (this.definitionIDRef != null)
                {
                    definition = IDManager.getID(definitionIDRef) as ProductReference;
                    return this.definition; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.definition != value)
                {
                    this.definition = value;
                }
            }
        }
        #endregion
        
        public string ProductReferenceIDRef { get; set; }
        
    
        
    
    }
    
}

