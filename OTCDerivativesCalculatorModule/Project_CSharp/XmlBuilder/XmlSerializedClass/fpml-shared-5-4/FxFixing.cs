using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FxFixing : ISerialized
    {
        public FxFixing(XmlNode xmlNode)
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
            
        
            XmlNode fixingDateNode = xmlNode.SelectSingleNode("fixingDate");
            
            if (fixingDateNode != null)
            {
                if (fixingDateNode.Attributes["href"] != null || fixingDateNode.Attributes["id"] != null) 
                {
                    if (fixingDateNode.Attributes["id"] != null) 
                    {
                        fixingDateIDRef_ = fixingDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(fixingDateNode);
                        IDManager.SetID(fixingDateIDRef_, ob);
                    }
                    else if (fixingDateNode.Attributes["href"] != null)
                    {
                        fixingDateIDRef_ = fixingDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixingDate_ = new XsdTypeDate(fixingDateNode);
                    }
                }
                else
                {
                    fixingDate_ = new XsdTypeDate(fixingDateNode);
                }
            }
            
        
            XmlNode fxSpotRateSourceNode = xmlNode.SelectSingleNode("fxSpotRateSource");
            
            if (fxSpotRateSourceNode != null)
            {
                if (fxSpotRateSourceNode.Attributes["href"] != null || fxSpotRateSourceNode.Attributes["id"] != null) 
                {
                    if (fxSpotRateSourceNode.Attributes["id"] != null) 
                    {
                        fxSpotRateSourceIDRef_ = fxSpotRateSourceNode.Attributes["id"].Value;
                        FxSpotRateSource ob = new FxSpotRateSource(fxSpotRateSourceNode);
                        IDManager.SetID(fxSpotRateSourceIDRef_, ob);
                    }
                    else if (fxSpotRateSourceNode.Attributes["href"] != null)
                    {
                        fxSpotRateSourceIDRef_ = fxSpotRateSourceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fxSpotRateSource_ = new FxSpotRateSource(fxSpotRateSourceNode);
                    }
                }
                else
                {
                    fxSpotRateSource_ = new FxSpotRateSource(fxSpotRateSourceNode);
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
        #region FixingDate_
        private XsdTypeDate fixingDate_;
        public XsdTypeDate FixingDate_
        {
            get
            {
                if (this.fixingDate_ != null)
                {
                    return this.fixingDate_; 
                }
                else if (this.fixingDateIDRef_ != null)
                {
                    fixingDate_ = IDManager.getID(fixingDateIDRef_) as XsdTypeDate;
                    return this.fixingDate_; 
                }
                else
                {
                      return this.fixingDate_; 
                }
            }
            set
            {
                if (this.fixingDate_ != value)
                {
                    this.fixingDate_ = value;
                }
            }
        }
        #endregion
        
        public string fixingDateIDRef_ { get; set; }
        #region FxSpotRateSource_
        private FxSpotRateSource fxSpotRateSource_;
        public FxSpotRateSource FxSpotRateSource_
        {
            get
            {
                if (this.fxSpotRateSource_ != null)
                {
                    return this.fxSpotRateSource_; 
                }
                else if (this.fxSpotRateSourceIDRef_ != null)
                {
                    fxSpotRateSource_ = IDManager.getID(fxSpotRateSourceIDRef_) as FxSpotRateSource;
                    return this.fxSpotRateSource_; 
                }
                else
                {
                      return this.fxSpotRateSource_; 
                }
            }
            set
            {
                if (this.fxSpotRateSource_ != value)
                {
                    this.fxSpotRateSource_ = value;
                }
            }
        }
        #endregion
        
        public string fxSpotRateSourceIDRef_ { get; set; }
        
    
        
    
    }
    
}

