using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxFixing
    {
        public FxFixing(XmlNode xmlNode)
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
            
        
            XmlNodeList fixingDateNodeList = xmlNode.SelectNodes("fixingDate");
            if (fixingDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixingDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixingDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(fixingDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixingDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixingDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList fxSpotRateSourceNodeList = xmlNode.SelectNodes("fxSpotRateSource");
            if (fxSpotRateSourceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxSpotRateSourceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxSpotRateSourceIDRef = item.Attributes["id"].Name;
                        FxSpotRateSource ob = FxSpotRateSource();
                        IDManager.SetID(fxSpotRateSourceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxSpotRateSourceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fxSpotRateSource = new FxSpotRateSource(item);
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
        #region FixingDate
        private XsdTypeDate fixingDate;
        public XsdTypeDate FixingDate
        {
            get
            {
                if (this.fixingDate != null)
                {
                    return this.fixingDate; 
                }
                else if (this.fixingDateIDRef != null)
                {
                    fixingDate = IDManager.getID(fixingDateIDRef) as XsdTypeDate;
                    return this.fixingDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixingDate != value)
                {
                    this.fixingDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region FxSpotRateSource
        private FxSpotRateSource fxSpotRateSource;
        public FxSpotRateSource FxSpotRateSource
        {
            get
            {
                if (this.fxSpotRateSource != null)
                {
                    return this.fxSpotRateSource; 
                }
                else if (this.fxSpotRateSourceIDRef != null)
                {
                    fxSpotRateSource = IDManager.getID(fxSpotRateSourceIDRef) as FxSpotRateSource;
                    return this.fxSpotRateSource; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fxSpotRateSource != value)
                {
                    this.fxSpotRateSource = value;
                }
            }
        }
        #endregion
        
        public string FxSpotRateSourceIDRef { get; set; }
        
    
        
    
    }
    
}

