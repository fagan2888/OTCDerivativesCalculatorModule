using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Basket
    {
        public Basket(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList openUnitsNodeList = xmlNode.SelectNodes("openUnits");
            if (openUnitsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in openUnitsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        openUnitsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(openUnitsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        openUnitsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        openUnits = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList basketConstituentNodeList = xmlNode.SelectNodes("basketConstituent");
            
            foreach (XmlNode item in basketConstituentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        basketConstituentIDRef = item.Attributes["id"].Name;
                        List<BasketConstituent> ob = new List<BasketConstituent>();
                        ob.Add(new BasketConstituent(item));
                        IDManager.SetID(basketConstituentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        basketConstituentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    basketConstituent.Add(new BasketConstituent(item));
                    }
                }
            }
            
        
            XmlNodeList basketDivisorNodeList = xmlNode.SelectNodes("basketDivisor");
            if (basketDivisorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in basketDivisorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        basketDivisorIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(basketDivisorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        basketDivisorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        basketDivisor = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList basketNameNodeList = xmlNode.SelectNodes("basketName");
            if (basketNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in basketNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        basketNameIDRef = item.Attributes["id"].Name;
                        BasketName ob = BasketName();
                        IDManager.SetID(basketNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        basketNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        basketName = new BasketName(item);
                    }
                }
            }
            
        
            XmlNodeList basketIdNodeList = xmlNode.SelectNodes("basketId");
            
            foreach (XmlNode item in basketIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        basketIdIDRef = item.Attributes["id"].Name;
                        List<BasketId> ob = new List<BasketId>();
                        ob.Add(new BasketId(item));
                        IDManager.SetID(basketIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        basketIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    basketId.Add(new BasketId(item));
                    }
                }
            }
            
        
            XmlNodeList basketCurrencyNodeList = xmlNode.SelectNodes("basketCurrency");
            if (basketCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in basketCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        basketCurrencyIDRef = item.Attributes["id"].Name;
                        Currency ob = Currency();
                        IDManager.SetID(basketCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        basketCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        basketCurrency = new Currency(item);
                    }
                }
            }
            
        
        }
        
    
        #region OpenUnits
        private XsdTypeDecimal openUnits;
        public XsdTypeDecimal OpenUnits
        {
            get
            {
                if (this.openUnits != null)
                {
                    return this.openUnits; 
                }
                else if (this.openUnitsIDRef != null)
                {
                    openUnits = IDManager.getID(openUnitsIDRef) as XsdTypeDecimal;
                    return this.openUnits; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.openUnits != value)
                {
                    this.openUnits = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region BasketConstituent
        private List<BasketConstituent> basketConstituent;
        public List<BasketConstituent> BasketConstituent
        {
            get
            {
                if (this.basketConstituent != null)
                {
                    return this.basketConstituent; 
                }
                else if (this.basketConstituentIDRef != null)
                {
                    basketConstituent = IDManager.getID(basketConstituentIDRef) as List<BasketConstituent>;
                    return this.basketConstituent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.basketConstituent != value)
                {
                    this.basketConstituent = value;
                }
            }
        }
        #endregion
        
        public string BasketConstituentIDRef { get; set; }
        #region BasketDivisor
        private XsdTypeDecimal basketDivisor;
        public XsdTypeDecimal BasketDivisor
        {
            get
            {
                if (this.basketDivisor != null)
                {
                    return this.basketDivisor; 
                }
                else if (this.basketDivisorIDRef != null)
                {
                    basketDivisor = IDManager.getID(basketDivisorIDRef) as XsdTypeDecimal;
                    return this.basketDivisor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.basketDivisor != value)
                {
                    this.basketDivisor = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region BasketName
        private BasketName basketName;
        public BasketName BasketName
        {
            get
            {
                if (this.basketName != null)
                {
                    return this.basketName; 
                }
                else if (this.basketNameIDRef != null)
                {
                    basketName = IDManager.getID(basketNameIDRef) as BasketName;
                    return this.basketName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.basketName != value)
                {
                    this.basketName = value;
                }
            }
        }
        #endregion
        
        public string BasketNameIDRef { get; set; }
        #region BasketId
        private List<BasketId> basketId;
        public List<BasketId> BasketId
        {
            get
            {
                if (this.basketId != null)
                {
                    return this.basketId; 
                }
                else if (this.basketIdIDRef != null)
                {
                    basketId = IDManager.getID(basketIdIDRef) as List<BasketId>;
                    return this.basketId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.basketId != value)
                {
                    this.basketId = value;
                }
            }
        }
        #endregion
        
        public string BasketIdIDRef { get; set; }
        #region BasketCurrency
        private Currency basketCurrency;
        public Currency BasketCurrency
        {
            get
            {
                if (this.basketCurrency != null)
                {
                    return this.basketCurrency; 
                }
                else if (this.basketCurrencyIDRef != null)
                {
                    basketCurrency = IDManager.getID(basketCurrencyIDRef) as Currency;
                    return this.basketCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.basketCurrency != value)
                {
                    this.basketCurrency = value;
                }
            }
        }
        #endregion
        
        public string CurrencyIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

