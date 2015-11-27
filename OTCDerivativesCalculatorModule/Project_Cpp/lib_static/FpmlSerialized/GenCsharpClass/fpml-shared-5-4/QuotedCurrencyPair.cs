using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class QuotedCurrencyPair
    {
        public QuotedCurrencyPair(XmlNode xmlNode)
        {
            XmlNodeList currency1NodeList = xmlNode.SelectNodes("currency1");
            if (currency1NodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in currency1NodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        currency1IDRef = item.Attributes["id"].Name;
                        Currency ob = Currency();
                        IDManager.SetID(currency1IDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        currency1IDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        currency1 = new Currency(item);
                    }
                }
            }
            
        
            XmlNodeList currency2NodeList = xmlNode.SelectNodes("currency2");
            if (currency2NodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in currency2NodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        currency2IDRef = item.Attributes["id"].Name;
                        Currency ob = Currency();
                        IDManager.SetID(currency2IDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        currency2IDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        currency2 = new Currency(item);
                    }
                }
            }
            
        
            XmlNodeList quoteBasisNodeList = xmlNode.SelectNodes("quoteBasis");
            if (quoteBasisNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quoteBasisNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quoteBasisIDRef = item.Attributes["id"].Name;
                        QuoteBasisEnum ob = QuoteBasisEnum();
                        IDManager.SetID(quoteBasisIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quoteBasisIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quoteBasis = new QuoteBasisEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region Currency1
        private Currency currency1;
        public Currency Currency1
        {
            get
            {
                if (this.currency1 != null)
                {
                    return this.currency1; 
                }
                else if (this.currency1IDRef != null)
                {
                    currency1 = IDManager.getID(currency1IDRef) as Currency;
                    return this.currency1; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.currency1 != value)
                {
                    this.currency1 = value;
                }
            }
        }
        #endregion
        
        public string CurrencyIDRef { get; set; }
        #region Currency2
        private Currency currency2;
        public Currency Currency2
        {
            get
            {
                if (this.currency2 != null)
                {
                    return this.currency2; 
                }
                else if (this.currency2IDRef != null)
                {
                    currency2 = IDManager.getID(currency2IDRef) as Currency;
                    return this.currency2; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.currency2 != value)
                {
                    this.currency2 = value;
                }
            }
        }
        #endregion
        
        public string CurrencyIDRef { get; set; }
        #region QuoteBasis
        private QuoteBasisEnum quoteBasis;
        public QuoteBasisEnum QuoteBasis
        {
            get
            {
                if (this.quoteBasis != null)
                {
                    return this.quoteBasis; 
                }
                else if (this.quoteBasisIDRef != null)
                {
                    quoteBasis = IDManager.getID(quoteBasisIDRef) as QuoteBasisEnum;
                    return this.quoteBasis; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quoteBasis != value)
                {
                    this.quoteBasis = value;
                }
            }
        }
        #endregion
        
        public string QuoteBasisEnumIDRef { get; set; }
        
    
        
    
    }
    
}

