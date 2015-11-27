using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Basket : Asset
    {
        public Basket(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode openUnitsNode = xmlNode.SelectSingleNode("openUnits");
            
            if (openUnitsNode != null)
            {
                if (openUnitsNode.Attributes["href"] != null || openUnitsNode.Attributes["id"] != null) 
                {
                    if (openUnitsNode.Attributes["id"] != null) 
                    {
                        openUnitsIDRef_ = openUnitsNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(openUnitsNode);
                        IDManager.SetID(openUnitsIDRef_, ob);
                    }
                    else if (openUnitsNode.Attributes["href"] != null)
                    {
                        openUnitsIDRef_ = openUnitsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        openUnits_ = new XsdTypeDecimal(openUnitsNode);
                    }
                }
                else
                {
                    openUnits_ = new XsdTypeDecimal(openUnitsNode);
                }
            }
            
        
            XmlNodeList basketConstituentNodeList = xmlNode.SelectNodes("basketConstituent");
            
            if (basketConstituentNodeList != null)
            {
                this.basketConstituent_ = new List<BasketConstituent>();
                foreach (XmlNode item in basketConstituentNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            basketConstituentIDRef_ = item.Attributes["id"].Value;
                            basketConstituent_.Add(new BasketConstituent(item));
                            IDManager.SetID(basketConstituentIDRef_, basketConstituent_[basketConstituent_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            basketConstituentIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        basketConstituent_.Add(new BasketConstituent(item));
                        }
                    }
                    else
                    {
                        basketConstituent_.Add(new BasketConstituent(item));
                    }
                }
            }
            
        
            XmlNode basketDivisorNode = xmlNode.SelectSingleNode("basketDivisor");
            
            if (basketDivisorNode != null)
            {
                if (basketDivisorNode.Attributes["href"] != null || basketDivisorNode.Attributes["id"] != null) 
                {
                    if (basketDivisorNode.Attributes["id"] != null) 
                    {
                        basketDivisorIDRef_ = basketDivisorNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(basketDivisorNode);
                        IDManager.SetID(basketDivisorIDRef_, ob);
                    }
                    else if (basketDivisorNode.Attributes["href"] != null)
                    {
                        basketDivisorIDRef_ = basketDivisorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        basketDivisor_ = new XsdTypeDecimal(basketDivisorNode);
                    }
                }
                else
                {
                    basketDivisor_ = new XsdTypeDecimal(basketDivisorNode);
                }
            }
            
        
            XmlNode basketNameNode = xmlNode.SelectSingleNode("basketName");
            
            if (basketNameNode != null)
            {
                if (basketNameNode.Attributes["href"] != null || basketNameNode.Attributes["id"] != null) 
                {
                    if (basketNameNode.Attributes["id"] != null) 
                    {
                        basketNameIDRef_ = basketNameNode.Attributes["id"].Value;
                        BasketName ob = new BasketName(basketNameNode);
                        IDManager.SetID(basketNameIDRef_, ob);
                    }
                    else if (basketNameNode.Attributes["href"] != null)
                    {
                        basketNameIDRef_ = basketNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        basketName_ = new BasketName(basketNameNode);
                    }
                }
                else
                {
                    basketName_ = new BasketName(basketNameNode);
                }
            }
            
        
            XmlNodeList basketIdNodeList = xmlNode.SelectNodes("basketId");
            
            if (basketIdNodeList != null)
            {
                this.basketId_ = new List<BasketId>();
                foreach (XmlNode item in basketIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            basketIdIDRef_ = item.Attributes["id"].Value;
                            basketId_.Add(new BasketId(item));
                            IDManager.SetID(basketIdIDRef_, basketId_[basketId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            basketIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        basketId_.Add(new BasketId(item));
                        }
                    }
                    else
                    {
                        basketId_.Add(new BasketId(item));
                    }
                }
            }
            
        
            XmlNode basketCurrencyNode = xmlNode.SelectSingleNode("basketCurrency");
            
            if (basketCurrencyNode != null)
            {
                if (basketCurrencyNode.Attributes["href"] != null || basketCurrencyNode.Attributes["id"] != null) 
                {
                    if (basketCurrencyNode.Attributes["id"] != null) 
                    {
                        basketCurrencyIDRef_ = basketCurrencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(basketCurrencyNode);
                        IDManager.SetID(basketCurrencyIDRef_, ob);
                    }
                    else if (basketCurrencyNode.Attributes["href"] != null)
                    {
                        basketCurrencyIDRef_ = basketCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        basketCurrency_ = new Currency(basketCurrencyNode);
                    }
                }
                else
                {
                    basketCurrency_ = new Currency(basketCurrencyNode);
                }
            }
            
        
        }
        
    
        #region OpenUnits_
        private XsdTypeDecimal openUnits_;
        public XsdTypeDecimal OpenUnits_
        {
            get
            {
                if (this.openUnits_ != null)
                {
                    return this.openUnits_; 
                }
                else if (this.openUnitsIDRef_ != null)
                {
                    openUnits_ = IDManager.getID(openUnitsIDRef_) as XsdTypeDecimal;
                    return this.openUnits_; 
                }
                else
                {
                      return this.openUnits_; 
                }
            }
            set
            {
                if (this.openUnits_ != value)
                {
                    this.openUnits_ = value;
                }
            }
        }
        #endregion
        
        public string openUnitsIDRef_ { get; set; }
        #region BasketConstituent_
        private List<BasketConstituent> basketConstituent_;
        public List<BasketConstituent> BasketConstituent_
        {
            get
            {
                if (this.basketConstituent_ != null)
                {
                    return this.basketConstituent_; 
                }
                else if (this.basketConstituentIDRef_ != null)
                {
                    return this.basketConstituent_; 
                }
                else
                {
                      return this.basketConstituent_; 
                }
            }
            set
            {
                if (this.basketConstituent_ != value)
                {
                    this.basketConstituent_ = value;
                }
            }
        }
        #endregion
        
        public string basketConstituentIDRef_ { get; set; }
        #region BasketDivisor_
        private XsdTypeDecimal basketDivisor_;
        public XsdTypeDecimal BasketDivisor_
        {
            get
            {
                if (this.basketDivisor_ != null)
                {
                    return this.basketDivisor_; 
                }
                else if (this.basketDivisorIDRef_ != null)
                {
                    basketDivisor_ = IDManager.getID(basketDivisorIDRef_) as XsdTypeDecimal;
                    return this.basketDivisor_; 
                }
                else
                {
                      return this.basketDivisor_; 
                }
            }
            set
            {
                if (this.basketDivisor_ != value)
                {
                    this.basketDivisor_ = value;
                }
            }
        }
        #endregion
        
        public string basketDivisorIDRef_ { get; set; }
        #region BasketName_
        private BasketName basketName_;
        public BasketName BasketName_
        {
            get
            {
                if (this.basketName_ != null)
                {
                    return this.basketName_; 
                }
                else if (this.basketNameIDRef_ != null)
                {
                    basketName_ = IDManager.getID(basketNameIDRef_) as BasketName;
                    return this.basketName_; 
                }
                else
                {
                      return this.basketName_; 
                }
            }
            set
            {
                if (this.basketName_ != value)
                {
                    this.basketName_ = value;
                }
            }
        }
        #endregion
        
        public string basketNameIDRef_ { get; set; }
        #region BasketId_
        private List<BasketId> basketId_;
        public List<BasketId> BasketId_
        {
            get
            {
                if (this.basketId_ != null)
                {
                    return this.basketId_; 
                }
                else if (this.basketIdIDRef_ != null)
                {
                    return this.basketId_; 
                }
                else
                {
                      return this.basketId_; 
                }
            }
            set
            {
                if (this.basketId_ != value)
                {
                    this.basketId_ = value;
                }
            }
        }
        #endregion
        
        public string basketIdIDRef_ { get; set; }
        #region BasketCurrency_
        private Currency basketCurrency_;
        public Currency BasketCurrency_
        {
            get
            {
                if (this.basketCurrency_ != null)
                {
                    return this.basketCurrency_; 
                }
                else if (this.basketCurrencyIDRef_ != null)
                {
                    basketCurrency_ = IDManager.getID(basketCurrencyIDRef_) as Currency;
                    return this.basketCurrency_; 
                }
                else
                {
                      return this.basketCurrency_; 
                }
            }
            set
            {
                if (this.basketCurrency_ != value)
                {
                    this.basketCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string basketCurrencyIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

