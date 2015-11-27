using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxFeature : ISerialized
    {
        public FxFeature(XmlNode xmlNode)
        {
            XmlNode referenceCurrencyNode = xmlNode.SelectSingleNode("referenceCurrency");
            
            if (referenceCurrencyNode != null)
            {
                if (referenceCurrencyNode.Attributes["href"] != null || referenceCurrencyNode.Attributes["id"] != null) 
                {
                    if (referenceCurrencyNode.Attributes["id"] != null) 
                    {
                        referenceCurrencyIDRef_ = referenceCurrencyNode.Attributes["id"].Value;
                        IdentifiedCurrency ob = new IdentifiedCurrency(referenceCurrencyNode);
                        IDManager.SetID(referenceCurrencyIDRef_, ob);
                    }
                    else if (referenceCurrencyNode.Attributes["href"] != null)
                    {
                        referenceCurrencyIDRef_ = referenceCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceCurrency_ = new IdentifiedCurrency(referenceCurrencyNode);
                    }
                }
                else
                {
                    referenceCurrency_ = new IdentifiedCurrency(referenceCurrencyNode);
                }
            }
            
        
            XmlNode compositeNode = xmlNode.SelectSingleNode("composite");
            
            if (compositeNode != null)
            {
                if (compositeNode.Attributes["href"] != null || compositeNode.Attributes["id"] != null) 
                {
                    if (compositeNode.Attributes["id"] != null) 
                    {
                        compositeIDRef_ = compositeNode.Attributes["id"].Value;
                        Composite ob = new Composite(compositeNode);
                        IDManager.SetID(compositeIDRef_, ob);
                    }
                    else if (compositeNode.Attributes["href"] != null)
                    {
                        compositeIDRef_ = compositeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        composite_ = new Composite(compositeNode);
                    }
                }
                else
                {
                    composite_ = new Composite(compositeNode);
                }
            }
            
        
            XmlNode quantoNode = xmlNode.SelectSingleNode("quanto");
            
            if (quantoNode != null)
            {
                if (quantoNode.Attributes["href"] != null || quantoNode.Attributes["id"] != null) 
                {
                    if (quantoNode.Attributes["id"] != null) 
                    {
                        quantoIDRef_ = quantoNode.Attributes["id"].Value;
                        Quanto ob = new Quanto(quantoNode);
                        IDManager.SetID(quantoIDRef_, ob);
                    }
                    else if (quantoNode.Attributes["href"] != null)
                    {
                        quantoIDRef_ = quantoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quanto_ = new Quanto(quantoNode);
                    }
                }
                else
                {
                    quanto_ = new Quanto(quantoNode);
                }
            }
            
        
            XmlNode crossCurrencyNode = xmlNode.SelectSingleNode("crossCurrency");
            
            if (crossCurrencyNode != null)
            {
                if (crossCurrencyNode.Attributes["href"] != null || crossCurrencyNode.Attributes["id"] != null) 
                {
                    if (crossCurrencyNode.Attributes["id"] != null) 
                    {
                        crossCurrencyIDRef_ = crossCurrencyNode.Attributes["id"].Value;
                        Composite ob = new Composite(crossCurrencyNode);
                        IDManager.SetID(crossCurrencyIDRef_, ob);
                    }
                    else if (crossCurrencyNode.Attributes["href"] != null)
                    {
                        crossCurrencyIDRef_ = crossCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        crossCurrency_ = new Composite(crossCurrencyNode);
                    }
                }
                else
                {
                    crossCurrency_ = new Composite(crossCurrencyNode);
                }
            }
            
        
        }
        
    
        #region ReferenceCurrency_
        private IdentifiedCurrency referenceCurrency_;
        public IdentifiedCurrency ReferenceCurrency_
        {
            get
            {
                if (this.referenceCurrency_ != null)
                {
                    return this.referenceCurrency_; 
                }
                else if (this.referenceCurrencyIDRef_ != null)
                {
                    referenceCurrency_ = IDManager.getID(referenceCurrencyIDRef_) as IdentifiedCurrency;
                    return this.referenceCurrency_; 
                }
                else
                {
                      return this.referenceCurrency_; 
                }
            }
            set
            {
                if (this.referenceCurrency_ != value)
                {
                    this.referenceCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string referenceCurrencyIDRef_ { get; set; }
        #region Composite_
        private Composite composite_;
        public Composite Composite_
        {
            get
            {
                if (this.composite_ != null)
                {
                    return this.composite_; 
                }
                else if (this.compositeIDRef_ != null)
                {
                    composite_ = IDManager.getID(compositeIDRef_) as Composite;
                    return this.composite_; 
                }
                else
                {
                      return this.composite_; 
                }
            }
            set
            {
                if (this.composite_ != value)
                {
                    this.composite_ = value;
                }
            }
        }
        #endregion
        
        public string compositeIDRef_ { get; set; }
        #region Quanto_
        private Quanto quanto_;
        public Quanto Quanto_
        {
            get
            {
                if (this.quanto_ != null)
                {
                    return this.quanto_; 
                }
                else if (this.quantoIDRef_ != null)
                {
                    quanto_ = IDManager.getID(quantoIDRef_) as Quanto;
                    return this.quanto_; 
                }
                else
                {
                      return this.quanto_; 
                }
            }
            set
            {
                if (this.quanto_ != value)
                {
                    this.quanto_ = value;
                }
            }
        }
        #endregion
        
        public string quantoIDRef_ { get; set; }
        #region CrossCurrency_
        private Composite crossCurrency_;
        public Composite CrossCurrency_
        {
            get
            {
                if (this.crossCurrency_ != null)
                {
                    return this.crossCurrency_; 
                }
                else if (this.crossCurrencyIDRef_ != null)
                {
                    crossCurrency_ = IDManager.getID(crossCurrencyIDRef_) as Composite;
                    return this.crossCurrency_; 
                }
                else
                {
                      return this.crossCurrency_; 
                }
            }
            set
            {
                if (this.crossCurrency_ != value)
                {
                    this.crossCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string crossCurrencyIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

