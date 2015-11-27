using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BestFitTrade : ISerialized
    {
        public BestFitTrade(XmlNode xmlNode)
        {
            XmlNode tradeIdentifierNode = xmlNode.SelectSingleNode("tradeIdentifier");
            
            if (tradeIdentifierNode != null)
            {
                if (tradeIdentifierNode.Attributes["href"] != null || tradeIdentifierNode.Attributes["id"] != null) 
                {
                    if (tradeIdentifierNode.Attributes["id"] != null) 
                    {
                        tradeIdentifierIDRef_ = tradeIdentifierNode.Attributes["id"].Value;
                        TradeIdentifier ob = new TradeIdentifier(tradeIdentifierNode);
                        IDManager.SetID(tradeIdentifierIDRef_, ob);
                    }
                    else if (tradeIdentifierNode.Attributes["href"] != null)
                    {
                        tradeIdentifierIDRef_ = tradeIdentifierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tradeIdentifier_ = new TradeIdentifier(tradeIdentifierNode);
                    }
                }
                else
                {
                    tradeIdentifier_ = new TradeIdentifier(tradeIdentifierNode);
                }
            }
            
        
            XmlNodeList differencesNodeList = xmlNode.SelectNodes("differences");
            
            if (differencesNodeList != null)
            {
                this.differences_ = new List<TradeDifference>();
                foreach (XmlNode item in differencesNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            differencesIDRef_ = item.Attributes["id"].Value;
                            differences_.Add(new TradeDifference(item));
                            IDManager.SetID(differencesIDRef_, differences_[differences_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            differencesIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        differences_.Add(new TradeDifference(item));
                        }
                    }
                    else
                    {
                        differences_.Add(new TradeDifference(item));
                    }
                }
            }
            
        
        }
        
    
        #region TradeIdentifier_
        private TradeIdentifier tradeIdentifier_;
        public TradeIdentifier TradeIdentifier_
        {
            get
            {
                if (this.tradeIdentifier_ != null)
                {
                    return this.tradeIdentifier_; 
                }
                else if (this.tradeIdentifierIDRef_ != null)
                {
                    tradeIdentifier_ = IDManager.getID(tradeIdentifierIDRef_) as TradeIdentifier;
                    return this.tradeIdentifier_; 
                }
                else
                {
                      return this.tradeIdentifier_; 
                }
            }
            set
            {
                if (this.tradeIdentifier_ != value)
                {
                    this.tradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string tradeIdentifierIDRef_ { get; set; }
        #region Differences_
        private List<TradeDifference> differences_;
        public List<TradeDifference> Differences_
        {
            get
            {
                if (this.differences_ != null)
                {
                    return this.differences_; 
                }
                else if (this.differencesIDRef_ != null)
                {
                    return this.differences_; 
                }
                else
                {
                      return this.differences_; 
                }
            }
            set
            {
                if (this.differences_ != value)
                {
                    this.differences_ = value;
                }
            }
        }
        #endregion
        
        public string differencesIDRef_ { get; set; }
        
    
        
    
    }
    
}

