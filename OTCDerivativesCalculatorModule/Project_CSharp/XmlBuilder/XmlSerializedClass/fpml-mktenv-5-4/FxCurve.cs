using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxCurve : PricingStructure
    {
        public FxCurve(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode quotedCurrencyPairNode = xmlNode.SelectSingleNode("quotedCurrencyPair");
            
            if (quotedCurrencyPairNode != null)
            {
                if (quotedCurrencyPairNode.Attributes["href"] != null || quotedCurrencyPairNode.Attributes["id"] != null) 
                {
                    if (quotedCurrencyPairNode.Attributes["id"] != null) 
                    {
                        quotedCurrencyPairIDRef_ = quotedCurrencyPairNode.Attributes["id"].Value;
                        QuotedCurrencyPair ob = new QuotedCurrencyPair(quotedCurrencyPairNode);
                        IDManager.SetID(quotedCurrencyPairIDRef_, ob);
                    }
                    else if (quotedCurrencyPairNode.Attributes["href"] != null)
                    {
                        quotedCurrencyPairIDRef_ = quotedCurrencyPairNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quotedCurrencyPair_ = new QuotedCurrencyPair(quotedCurrencyPairNode);
                    }
                }
                else
                {
                    quotedCurrencyPair_ = new QuotedCurrencyPair(quotedCurrencyPairNode);
                }
            }
            
        
        }
        
    
        #region QuotedCurrencyPair_
        private QuotedCurrencyPair quotedCurrencyPair_;
        public QuotedCurrencyPair QuotedCurrencyPair_
        {
            get
            {
                if (this.quotedCurrencyPair_ != null)
                {
                    return this.quotedCurrencyPair_; 
                }
                else if (this.quotedCurrencyPairIDRef_ != null)
                {
                    quotedCurrencyPair_ = IDManager.getID(quotedCurrencyPairIDRef_) as QuotedCurrencyPair;
                    return this.quotedCurrencyPair_; 
                }
                else
                {
                      return this.quotedCurrencyPair_; 
                }
            }
            set
            {
                if (this.quotedCurrencyPair_ != value)
                {
                    this.quotedCurrencyPair_ = value;
                }
            }
        }
        #endregion
        
        public string quotedCurrencyPairIDRef_ { get; set; }
        
    
        
    
    }
    
}

