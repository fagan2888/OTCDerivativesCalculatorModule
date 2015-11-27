using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class BestFitTrade
    {
        public BestFitTrade(XmlNode xmlNode)
        {
            XmlNodeList tradeIdentifierNodeList = xmlNode.SelectNodes("tradeIdentifier");
            if (tradeIdentifierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in tradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeIdentifierIDRef = item.Attributes["id"].Name;
                        TradeIdentifier ob = TradeIdentifier();
                        IDManager.SetID(tradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        tradeIdentifier = new TradeIdentifier(item);
                    }
                }
            }
            
        
            XmlNodeList differencesNodeList = xmlNode.SelectNodes("differences");
            
            foreach (XmlNode item in differencesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        differencesIDRef = item.Attributes["id"].Name;
                        List<TradeDifference> ob = new List<TradeDifference>();
                        ob.Add(new TradeDifference(item));
                        IDManager.SetID(differencesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        differencesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    differences.Add(new TradeDifference(item));
                    }
                }
            }
            
        
        }
        
    
        #region TradeIdentifier
        private TradeIdentifier tradeIdentifier;
        public TradeIdentifier TradeIdentifier
        {
            get
            {
                if (this.tradeIdentifier != null)
                {
                    return this.tradeIdentifier; 
                }
                else if (this.tradeIdentifierIDRef != null)
                {
                    tradeIdentifier = IDManager.getID(tradeIdentifierIDRef) as TradeIdentifier;
                    return this.tradeIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tradeIdentifier != value)
                {
                    this.tradeIdentifier = value;
                }
            }
        }
        #endregion
        
        public string TradeIdentifierIDRef { get; set; }
        #region Differences
        private List<TradeDifference> differences;
        public List<TradeDifference> Differences
        {
            get
            {
                if (this.differences != null)
                {
                    return this.differences; 
                }
                else if (this.differencesIDRef != null)
                {
                    differences = IDManager.getID(differencesIDRef) as List<TradeDifference>;
                    return this.differences; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.differences != value)
                {
                    this.differences = value;
                }
            }
        }
        #endregion
        
        public string TradeDifferenceIDRef { get; set; }
        
    
        
    
    }
    
}

