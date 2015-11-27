using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxRateAsset
    {
        public FxRateAsset(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList quotedCurrencyPairNodeList = xmlNode.SelectNodes("quotedCurrencyPair");
            if (quotedCurrencyPairNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quotedCurrencyPairNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quotedCurrencyPairIDRef = item.Attributes["id"].Name;
                        QuotedCurrencyPair ob = QuotedCurrencyPair();
                        IDManager.SetID(quotedCurrencyPairIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quotedCurrencyPairIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quotedCurrencyPair = new QuotedCurrencyPair(item);
                    }
                }
            }
            
        
            XmlNodeList rateSourceNodeList = xmlNode.SelectNodes("rateSource");
            if (rateSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in rateSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        rateSourceIDRef = item.Attributes["id"].Name;
                        FxSpotRateSource ob = FxSpotRateSource();
                        IDManager.SetID(rateSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        rateSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rateSource = new FxSpotRateSource(item);
                    }
                }
            }
            
        
        }
        
    
        #region QuotedCurrencyPair
        private QuotedCurrencyPair quotedCurrencyPair;
        public QuotedCurrencyPair QuotedCurrencyPair
        {
            get
            {
                if (this.quotedCurrencyPair != null)
                {
                    return this.quotedCurrencyPair; 
                }
                else if (this.quotedCurrencyPairIDRef != null)
                {
                    quotedCurrencyPair = IDManager.getID(quotedCurrencyPairIDRef) as QuotedCurrencyPair;
                    return this.quotedCurrencyPair; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quotedCurrencyPair != value)
                {
                    this.quotedCurrencyPair = value;
                }
            }
        }
        #endregion
        
        public string QuotedCurrencyPairIDRef { get; set; }
        #region RateSource
        private FxSpotRateSource rateSource;
        public FxSpotRateSource RateSource
        {
            get
            {
                if (this.rateSource != null)
                {
                    return this.rateSource; 
                }
                else if (this.rateSourceIDRef != null)
                {
                    rateSource = IDManager.getID(rateSourceIDRef) as FxSpotRateSource;
                    return this.rateSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rateSource != value)
                {
                    this.rateSource = value;
                }
            }
        }
        #endregion
        
        public string FxSpotRateSourceIDRef { get; set; }
        
    
        
    
    }
    
}

