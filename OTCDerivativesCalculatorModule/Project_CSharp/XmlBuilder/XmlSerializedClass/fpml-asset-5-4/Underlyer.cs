using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Underlyer : ISerialized
    {
        public Underlyer(XmlNode xmlNode)
        {
            XmlNode singleUnderlyerNode = xmlNode.SelectSingleNode("singleUnderlyer");
            
            if (singleUnderlyerNode != null)
            {
                if (singleUnderlyerNode.Attributes["href"] != null || singleUnderlyerNode.Attributes["id"] != null) 
                {
                    if (singleUnderlyerNode.Attributes["id"] != null) 
                    {
                        singleUnderlyerIDRef_ = singleUnderlyerNode.Attributes["id"].Value;
                        SingleUnderlyer ob = new SingleUnderlyer(singleUnderlyerNode);
                        IDManager.SetID(singleUnderlyerIDRef_, ob);
                    }
                    else if (singleUnderlyerNode.Attributes["href"] != null)
                    {
                        singleUnderlyerIDRef_ = singleUnderlyerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        singleUnderlyer_ = new SingleUnderlyer(singleUnderlyerNode);
                    }
                }
                else
                {
                    singleUnderlyer_ = new SingleUnderlyer(singleUnderlyerNode);
                }
            }
            
        
            XmlNode basketNode = xmlNode.SelectSingleNode("basket");
            
            if (basketNode != null)
            {
                if (basketNode.Attributes["href"] != null || basketNode.Attributes["id"] != null) 
                {
                    if (basketNode.Attributes["id"] != null) 
                    {
                        basketIDRef_ = basketNode.Attributes["id"].Value;
                        Basket ob = new Basket(basketNode);
                        IDManager.SetID(basketIDRef_, ob);
                    }
                    else if (basketNode.Attributes["href"] != null)
                    {
                        basketIDRef_ = basketNode.Attributes["href"].Value;
                    }
                    else
                    {
                        basket_ = new Basket(basketNode);
                    }
                }
                else
                {
                    basket_ = new Basket(basketNode);
                }
            }
            
        
        }
        
    
        #region SingleUnderlyer_
        private SingleUnderlyer singleUnderlyer_;
        public SingleUnderlyer SingleUnderlyer_
        {
            get
            {
                if (this.singleUnderlyer_ != null)
                {
                    return this.singleUnderlyer_; 
                }
                else if (this.singleUnderlyerIDRef_ != null)
                {
                    singleUnderlyer_ = IDManager.getID(singleUnderlyerIDRef_) as SingleUnderlyer;
                    return this.singleUnderlyer_; 
                }
                else
                {
                      return this.singleUnderlyer_; 
                }
            }
            set
            {
                if (this.singleUnderlyer_ != value)
                {
                    this.singleUnderlyer_ = value;
                }
            }
        }
        #endregion
        
        public string singleUnderlyerIDRef_ { get; set; }
        #region Basket_
        private Basket basket_;
        public Basket Basket_
        {
            get
            {
                if (this.basket_ != null)
                {
                    return this.basket_; 
                }
                else if (this.basketIDRef_ != null)
                {
                    basket_ = IDManager.getID(basketIDRef_) as Basket;
                    return this.basket_; 
                }
                else
                {
                      return this.basket_; 
                }
            }
            set
            {
                if (this.basket_ != value)
                {
                    this.basket_ = value;
                }
            }
        }
        #endregion
        
        public string basketIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

