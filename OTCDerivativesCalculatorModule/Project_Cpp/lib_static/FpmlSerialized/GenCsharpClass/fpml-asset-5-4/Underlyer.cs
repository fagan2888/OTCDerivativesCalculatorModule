using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Underlyer
    {
        public Underlyer(XmlNode xmlNode)
        {
            XmlNodeList singleUnderlyerNodeList = xmlNode.SelectNodes("singleUnderlyer");
            if (singleUnderlyerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in singleUnderlyerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        singleUnderlyerIDRef = item.Attributes["id"].Name;
                        SingleUnderlyer ob = SingleUnderlyer();
                        IDManager.SetID(singleUnderlyerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        singleUnderlyerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        singleUnderlyer = new SingleUnderlyer(item);
                    }
                }
            }
            
        
            XmlNodeList basketNodeList = xmlNode.SelectNodes("basket");
            if (basketNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in basketNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        basketIDRef = item.Attributes["id"].Name;
                        Basket ob = Basket();
                        IDManager.SetID(basketIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        basketIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        basket = new Basket(item);
                    }
                }
            }
            
        
        }
        
    
        #region SingleUnderlyer
        private SingleUnderlyer singleUnderlyer;
        public SingleUnderlyer SingleUnderlyer
        {
            get
            {
                if (this.singleUnderlyer != null)
                {
                    return this.singleUnderlyer; 
                }
                else if (this.singleUnderlyerIDRef != null)
                {
                    singleUnderlyer = IDManager.getID(singleUnderlyerIDRef) as SingleUnderlyer;
                    return this.singleUnderlyer; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.singleUnderlyer != value)
                {
                    this.singleUnderlyer = value;
                }
            }
        }
        #endregion
        
        public string SingleUnderlyerIDRef { get; set; }
        #region Basket
        private Basket basket;
        public Basket Basket
        {
            get
            {
                if (this.basket != null)
                {
                    return this.basket; 
                }
                else if (this.basketIDRef != null)
                {
                    basket = IDManager.getID(basketIDRef) as Basket;
                    return this.basket; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.basket != value)
                {
                    this.basket = value;
                }
            }
        }
        #endregion
        
        public string BasketIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

