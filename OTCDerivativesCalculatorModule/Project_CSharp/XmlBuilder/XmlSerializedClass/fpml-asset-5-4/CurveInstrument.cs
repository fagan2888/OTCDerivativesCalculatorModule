using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CurveInstrument : IdentifiedAsset
    {
        public CurveInstrument(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode currencyNode = xmlNode.SelectSingleNode("currency");
            
            if (currencyNode != null)
            {
                if (currencyNode.Attributes["href"] != null || currencyNode.Attributes["id"] != null) 
                {
                    if (currencyNode.Attributes["id"] != null) 
                    {
                        currencyIDRef_ = currencyNode.Attributes["id"].Value;
                        Currency ob = new Currency(currencyNode);
                        IDManager.SetID(currencyIDRef_, ob);
                    }
                    else if (currencyNode.Attributes["href"] != null)
                    {
                        currencyIDRef_ = currencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency_ = new Currency(currencyNode);
                    }
                }
                else
                {
                    currency_ = new Currency(currencyNode);
                }
            }
            
        
            XmlNode exchangeIdNode = xmlNode.SelectSingleNode("exchangeId");
            
            if (exchangeIdNode != null)
            {
                if (exchangeIdNode.Attributes["href"] != null || exchangeIdNode.Attributes["id"] != null) 
                {
                    if (exchangeIdNode.Attributes["id"] != null) 
                    {
                        exchangeIdIDRef_ = exchangeIdNode.Attributes["id"].Value;
                        ExchangeId ob = new ExchangeId(exchangeIdNode);
                        IDManager.SetID(exchangeIdIDRef_, ob);
                    }
                    else if (exchangeIdNode.Attributes["href"] != null)
                    {
                        exchangeIdIDRef_ = exchangeIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        exchangeId_ = new ExchangeId(exchangeIdNode);
                    }
                }
                else
                {
                    exchangeId_ = new ExchangeId(exchangeIdNode);
                }
            }
            
        
            XmlNode clearanceSystemNode = xmlNode.SelectSingleNode("clearanceSystem");
            
            if (clearanceSystemNode != null)
            {
                if (clearanceSystemNode.Attributes["href"] != null || clearanceSystemNode.Attributes["id"] != null) 
                {
                    if (clearanceSystemNode.Attributes["id"] != null) 
                    {
                        clearanceSystemIDRef_ = clearanceSystemNode.Attributes["id"].Value;
                        ClearanceSystem ob = new ClearanceSystem(clearanceSystemNode);
                        IDManager.SetID(clearanceSystemIDRef_, ob);
                    }
                    else if (clearanceSystemNode.Attributes["href"] != null)
                    {
                        clearanceSystemIDRef_ = clearanceSystemNode.Attributes["href"].Value;
                    }
                    else
                    {
                        clearanceSystem_ = new ClearanceSystem(clearanceSystemNode);
                    }
                }
                else
                {
                    clearanceSystem_ = new ClearanceSystem(clearanceSystemNode);
                }
            }
            
        
            XmlNode definitionNode = xmlNode.SelectSingleNode("definition");
            
            if (definitionNode != null)
            {
                if (definitionNode.Attributes["href"] != null || definitionNode.Attributes["id"] != null) 
                {
                    if (definitionNode.Attributes["id"] != null) 
                    {
                        definitionIDRef_ = definitionNode.Attributes["id"].Value;
                        ProductReference ob = new ProductReference(definitionNode);
                        IDManager.SetID(definitionIDRef_, ob);
                    }
                    else if (definitionNode.Attributes["href"] != null)
                    {
                        definitionIDRef_ = definitionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        definition_ = new ProductReference(definitionNode);
                    }
                }
                else
                {
                    definition_ = new ProductReference(definitionNode);
                }
            }
            
        
        }
        
    
        #region Currency_
        private Currency currency_;
        public Currency Currency_
        {
            get
            {
                if (this.currency_ != null)
                {
                    return this.currency_; 
                }
                else if (this.currencyIDRef_ != null)
                {
                    currency_ = IDManager.getID(currencyIDRef_) as Currency;
                    return this.currency_; 
                }
                else
                {
                      return this.currency_; 
                }
            }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                }
            }
        }
        #endregion
        
        public string currencyIDRef_ { get; set; }
        #region ExchangeId_
        private ExchangeId exchangeId_;
        public ExchangeId ExchangeId_
        {
            get
            {
                if (this.exchangeId_ != null)
                {
                    return this.exchangeId_; 
                }
                else if (this.exchangeIdIDRef_ != null)
                {
                    exchangeId_ = IDManager.getID(exchangeIdIDRef_) as ExchangeId;
                    return this.exchangeId_; 
                }
                else
                {
                      return this.exchangeId_; 
                }
            }
            set
            {
                if (this.exchangeId_ != value)
                {
                    this.exchangeId_ = value;
                }
            }
        }
        #endregion
        
        public string exchangeIdIDRef_ { get; set; }
        #region ClearanceSystem_
        private ClearanceSystem clearanceSystem_;
        public ClearanceSystem ClearanceSystem_
        {
            get
            {
                if (this.clearanceSystem_ != null)
                {
                    return this.clearanceSystem_; 
                }
                else if (this.clearanceSystemIDRef_ != null)
                {
                    clearanceSystem_ = IDManager.getID(clearanceSystemIDRef_) as ClearanceSystem;
                    return this.clearanceSystem_; 
                }
                else
                {
                      return this.clearanceSystem_; 
                }
            }
            set
            {
                if (this.clearanceSystem_ != value)
                {
                    this.clearanceSystem_ = value;
                }
            }
        }
        #endregion
        
        public string clearanceSystemIDRef_ { get; set; }
        #region Definition_
        private ProductReference definition_;
        public ProductReference Definition_
        {
            get
            {
                if (this.definition_ != null)
                {
                    return this.definition_; 
                }
                else if (this.definitionIDRef_ != null)
                {
                    definition_ = IDManager.getID(definitionIDRef_) as ProductReference;
                    return this.definition_; 
                }
                else
                {
                      return this.definition_; 
                }
            }
            set
            {
                if (this.definition_ != value)
                {
                    this.definition_ = value;
                }
            }
        }
        #endregion
        
        public string definitionIDRef_ { get; set; }
        
    
        
    
    }
    
}

