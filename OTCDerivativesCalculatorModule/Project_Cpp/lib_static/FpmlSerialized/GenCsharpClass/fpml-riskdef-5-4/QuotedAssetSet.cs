using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class QuotedAssetSet
    {
        public QuotedAssetSet(XmlNode xmlNode)
        {
            XmlNodeList instrumentSetNodeList = xmlNode.SelectNodes("instrumentSet");
            if (instrumentSetNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in instrumentSetNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        instrumentSetIDRef = item.Attributes["id"].Name;
                        InstrumentSet ob = InstrumentSet();
                        IDManager.SetID(instrumentSetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        instrumentSetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        instrumentSet = new InstrumentSet(item);
                    }
                }
            }
            
        
            XmlNodeList assetQuoteNodeList = xmlNode.SelectNodes("assetQuote");
            
            foreach (XmlNode item in assetQuoteNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        assetQuoteIDRef = item.Attributes["id"].Name;
                        List<BasicAssetValuation> ob = new List<BasicAssetValuation>();
                        ob.Add(new BasicAssetValuation(item));
                        IDManager.SetID(assetQuoteIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        assetQuoteIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    assetQuote.Add(new BasicAssetValuation(item));
                    }
                }
            }
            
        
        }
        
    
        #region InstrumentSet
        private InstrumentSet instrumentSet;
        public InstrumentSet InstrumentSet
        {
            get
            {
                if (this.instrumentSet != null)
                {
                    return this.instrumentSet; 
                }
                else if (this.instrumentSetIDRef != null)
                {
                    instrumentSet = IDManager.getID(instrumentSetIDRef) as InstrumentSet;
                    return this.instrumentSet; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.instrumentSet != value)
                {
                    this.instrumentSet = value;
                }
            }
        }
        #endregion
        
        public string InstrumentSetIDRef { get; set; }
        #region AssetQuote
        private List<BasicAssetValuation> assetQuote;
        public List<BasicAssetValuation> AssetQuote
        {
            get
            {
                if (this.assetQuote != null)
                {
                    return this.assetQuote; 
                }
                else if (this.assetQuoteIDRef != null)
                {
                    assetQuote = IDManager.getID(assetQuoteIDRef) as List<BasicAssetValuation>;
                    return this.assetQuote; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.assetQuote != value)
                {
                    this.assetQuote = value;
                }
            }
        }
        #endregion
        
        public string BasicAssetValuationIDRef { get; set; }
        
    
        
    
    }
    
}

