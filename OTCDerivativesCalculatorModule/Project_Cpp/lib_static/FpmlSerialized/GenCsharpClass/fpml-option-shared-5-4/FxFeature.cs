using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxFeature
    {
        public FxFeature(XmlNode xmlNode)
        {
            XmlNodeList referenceCurrencyNodeList = xmlNode.SelectNodes("referenceCurrency");
            if (referenceCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referenceCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceCurrencyIDRef = item.Attributes["id"].Name;
                        IdentifiedCurrency ob = IdentifiedCurrency();
                        IDManager.SetID(referenceCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referenceCurrency = new IdentifiedCurrency(item);
                    }
                }
            }
            
        
            XmlNodeList compositeNodeList = xmlNode.SelectNodes("composite");
            if (compositeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in compositeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        compositeIDRef = item.Attributes["id"].Name;
                        Composite ob = Composite();
                        IDManager.SetID(compositeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        compositeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        composite = new Composite(item);
                    }
                }
            }
            
        
            XmlNodeList quantoNodeList = xmlNode.SelectNodes("quanto");
            if (quantoNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quantoNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quantoIDRef = item.Attributes["id"].Name;
                        Quanto ob = Quanto();
                        IDManager.SetID(quantoIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quantoIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quanto = new Quanto(item);
                    }
                }
            }
            
        
            XmlNodeList crossCurrencyNodeList = xmlNode.SelectNodes("crossCurrency");
            if (crossCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in crossCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        crossCurrencyIDRef = item.Attributes["id"].Name;
                        Composite ob = Composite();
                        IDManager.SetID(crossCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        crossCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        crossCurrency = new Composite(item);
                    }
                }
            }
            
        
        }
        
    
        #region ReferenceCurrency
        private IdentifiedCurrency referenceCurrency;
        public IdentifiedCurrency ReferenceCurrency
        {
            get
            {
                if (this.referenceCurrency != null)
                {
                    return this.referenceCurrency; 
                }
                else if (this.referenceCurrencyIDRef != null)
                {
                    referenceCurrency = IDManager.getID(referenceCurrencyIDRef) as IdentifiedCurrency;
                    return this.referenceCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceCurrency != value)
                {
                    this.referenceCurrency = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedCurrencyIDRef { get; set; }
        #region Composite
        private Composite composite;
        public Composite Composite
        {
            get
            {
                if (this.composite != null)
                {
                    return this.composite; 
                }
                else if (this.compositeIDRef != null)
                {
                    composite = IDManager.getID(compositeIDRef) as Composite;
                    return this.composite; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.composite != value)
                {
                    this.composite = value;
                }
            }
        }
        #endregion
        
        public string CompositeIDRef { get; set; }
        #region Quanto
        private Quanto quanto;
        public Quanto Quanto
        {
            get
            {
                if (this.quanto != null)
                {
                    return this.quanto; 
                }
                else if (this.quantoIDRef != null)
                {
                    quanto = IDManager.getID(quantoIDRef) as Quanto;
                    return this.quanto; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quanto != value)
                {
                    this.quanto = value;
                }
            }
        }
        #endregion
        
        public string QuantoIDRef { get; set; }
        #region CrossCurrency
        private Composite crossCurrency;
        public Composite CrossCurrency
        {
            get
            {
                if (this.crossCurrency != null)
                {
                    return this.crossCurrency; 
                }
                else if (this.crossCurrencyIDRef != null)
                {
                    crossCurrency = IDManager.getID(crossCurrencyIDRef) as Composite;
                    return this.crossCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.crossCurrency != value)
                {
                    this.crossCurrency = value;
                }
            }
        }
        #endregion
        
        public string CompositeIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

