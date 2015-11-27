using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxRateAsset : UnderlyingAsset
    {
        public FxRateAsset(XmlNode xmlNode)
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
            
        
            XmlNode rateSourceNode = xmlNode.SelectSingleNode("rateSource");
            
            if (rateSourceNode != null)
            {
                if (rateSourceNode.Attributes["href"] != null || rateSourceNode.Attributes["id"] != null) 
                {
                    if (rateSourceNode.Attributes["id"] != null) 
                    {
                        rateSourceIDRef_ = rateSourceNode.Attributes["id"].Value;
                        FxSpotRateSource ob = new FxSpotRateSource(rateSourceNode);
                        IDManager.SetID(rateSourceIDRef_, ob);
                    }
                    else if (rateSourceNode.Attributes["href"] != null)
                    {
                        rateSourceIDRef_ = rateSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rateSource_ = new FxSpotRateSource(rateSourceNode);
                    }
                }
                else
                {
                    rateSource_ = new FxSpotRateSource(rateSourceNode);
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
        #region RateSource_
        private FxSpotRateSource rateSource_;
        public FxSpotRateSource RateSource_
        {
            get
            {
                if (this.rateSource_ != null)
                {
                    return this.rateSource_; 
                }
                else if (this.rateSourceIDRef_ != null)
                {
                    rateSource_ = IDManager.getID(rateSourceIDRef_) as FxSpotRateSource;
                    return this.rateSource_; 
                }
                else
                {
                      return this.rateSource_; 
                }
            }
            set
            {
                if (this.rateSource_ != value)
                {
                    this.rateSource_ = value;
                }
            }
        }
        #endregion
        
        public string rateSourceIDRef_ { get; set; }
        
    
        
    
    }
    
}

