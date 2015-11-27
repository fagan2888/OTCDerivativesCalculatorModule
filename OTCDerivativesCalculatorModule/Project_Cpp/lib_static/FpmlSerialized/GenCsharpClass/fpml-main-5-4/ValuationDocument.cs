using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class ValuationDocument
    {
        public ValuationDocument(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList marketNodeList = xmlNode.SelectNodes("market");
            if (marketNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in marketNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        marketIDRef = item.Attributes["id"].Name;
                        Market ob = Market();
                        IDManager.SetID(marketIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        marketIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        market = new Market(item);
                    }
                }
            }
            
        
            XmlNodeList valuationSetNodeList = xmlNode.SelectNodes("valuationSet");
            if (valuationSetNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationSetNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationSetIDRef = item.Attributes["id"].Name;
                        ValuationSet ob = ValuationSet();
                        IDManager.SetID(valuationSetIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationSetIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationSet = new ValuationSet(item);
                    }
                }
            }
            
        
        }
        
    
        #region Market
        private Market market;
        public Market Market
        {
            get
            {
                if (this.market != null)
                {
                    return this.market; 
                }
                else if (this.marketIDRef != null)
                {
                    market = IDManager.getID(marketIDRef) as Market;
                    return this.market; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.market != value)
                {
                    this.market = value;
                }
            }
        }
        #endregion
        
        public string MarketIDRef { get; set; }
        #region ValuationSet
        private ValuationSet valuationSet;
        public ValuationSet ValuationSet
        {
            get
            {
                if (this.valuationSet != null)
                {
                    return this.valuationSet; 
                }
                else if (this.valuationSetIDRef != null)
                {
                    valuationSet = IDManager.getID(valuationSetIDRef) as ValuationSet;
                    return this.valuationSet; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationSet != value)
                {
                    this.valuationSet = value;
                }
            }
        }
        #endregion
        
        public string ValuationSetIDRef { get; set; }
        
    
        
    
    }
    
}

