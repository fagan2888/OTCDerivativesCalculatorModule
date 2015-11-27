using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class QuotedCurrencyPair : ISerialized
    {
        public QuotedCurrencyPair(XmlNode xmlNode)
        {
            XmlNode currency1Node = xmlNode.SelectSingleNode("currency1");
            
            if (currency1Node != null)
            {
                if (currency1Node.Attributes["href"] != null || currency1Node.Attributes["id"] != null) 
                {
                    if (currency1Node.Attributes["id"] != null) 
                    {
                        currency1IDRef_ = currency1Node.Attributes["id"].Value;
                        Currency ob = new Currency(currency1Node);
                        IDManager.SetID(currency1IDRef_, ob);
                    }
                    else if (currency1Node.Attributes["href"] != null)
                    {
                        currency1IDRef_ = currency1Node.Attributes["href"].Value;
                    }
                    else
                    {
                        currency1_ = new Currency(currency1Node);
                    }
                }
                else
                {
                    currency1_ = new Currency(currency1Node);
                }
            }
            
        
            XmlNode currency2Node = xmlNode.SelectSingleNode("currency2");
            
            if (currency2Node != null)
            {
                if (currency2Node.Attributes["href"] != null || currency2Node.Attributes["id"] != null) 
                {
                    if (currency2Node.Attributes["id"] != null) 
                    {
                        currency2IDRef_ = currency2Node.Attributes["id"].Value;
                        Currency ob = new Currency(currency2Node);
                        IDManager.SetID(currency2IDRef_, ob);
                    }
                    else if (currency2Node.Attributes["href"] != null)
                    {
                        currency2IDRef_ = currency2Node.Attributes["href"].Value;
                    }
                    else
                    {
                        currency2_ = new Currency(currency2Node);
                    }
                }
                else
                {
                    currency2_ = new Currency(currency2Node);
                }
            }
            
        
            XmlNode quoteBasisNode = xmlNode.SelectSingleNode("quoteBasis");
            
            if (quoteBasisNode != null)
            {
                if (quoteBasisNode.Attributes["href"] != null || quoteBasisNode.Attributes["id"] != null) 
                {
                    if (quoteBasisNode.Attributes["id"] != null) 
                    {
                        quoteBasisIDRef_ = quoteBasisNode.Attributes["id"].Value;
                        QuoteBasisEnum ob = new QuoteBasisEnum(quoteBasisNode);
                        IDManager.SetID(quoteBasisIDRef_, ob);
                    }
                    else if (quoteBasisNode.Attributes["href"] != null)
                    {
                        quoteBasisIDRef_ = quoteBasisNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quoteBasis_ = new QuoteBasisEnum(quoteBasisNode);
                    }
                }
                else
                {
                    quoteBasis_ = new QuoteBasisEnum(quoteBasisNode);
                }
            }
            
        
        }
        
    
        #region Currency1_
        private Currency currency1_;
        public Currency Currency1_
        {
            get
            {
                if (this.currency1_ != null)
                {
                    return this.currency1_; 
                }
                else if (this.currency1IDRef_ != null)
                {
                    currency1_ = IDManager.getID(currency1IDRef_) as Currency;
                    return this.currency1_; 
                }
                else
                {
                      return this.currency1_; 
                }
            }
            set
            {
                if (this.currency1_ != value)
                {
                    this.currency1_ = value;
                }
            }
        }
        #endregion
        
        public string currency1IDRef_ { get; set; }
        #region Currency2_
        private Currency currency2_;
        public Currency Currency2_
        {
            get
            {
                if (this.currency2_ != null)
                {
                    return this.currency2_; 
                }
                else if (this.currency2IDRef_ != null)
                {
                    currency2_ = IDManager.getID(currency2IDRef_) as Currency;
                    return this.currency2_; 
                }
                else
                {
                      return this.currency2_; 
                }
            }
            set
            {
                if (this.currency2_ != value)
                {
                    this.currency2_ = value;
                }
            }
        }
        #endregion
        
        public string currency2IDRef_ { get; set; }
        #region QuoteBasis_
        private QuoteBasisEnum quoteBasis_;
        public QuoteBasisEnum QuoteBasis_
        {
            get
            {
                if (this.quoteBasis_ != null)
                {
                    return this.quoteBasis_; 
                }
                else if (this.quoteBasisIDRef_ != null)
                {
                    quoteBasis_ = IDManager.getID(quoteBasisIDRef_) as QuoteBasisEnum;
                    return this.quoteBasis_; 
                }
                else
                {
                      return this.quoteBasis_; 
                }
            }
            set
            {
                if (this.quoteBasis_ != value)
                {
                    this.quoteBasis_ = value;
                }
            }
        }
        #endregion
        
        public string quoteBasisIDRef_ { get; set; }
        
    
        
    
    }
    
}

