using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class HisoryData : ISerialized
    {
        public HisoryData() { }
        public HisoryData(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList marketDataNodeList = xmlNode.SelectNodes("marketData");
            
            if (marketDataNodeList != null)
            {
                this.marketData_ = new List<MarketData>();
                foreach (XmlNode item in marketDataNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            marketDataIDRef_ = item.Attributes["id"].Value;
                            marketData_.Add(new MarketData(item));
                            IDManager.SetID(marketDataIDRef_, marketData_[marketData_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            marketDataIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        marketData_.Add(new MarketData(item));
                        }
                    }
                    else
                    {
                        marketData_.Add(new MarketData(item));
                    }
                }
            }
            
        
        }
        
    
        #region MarketData_
        private List<MarketData> marketData_;
        public List<MarketData> MarketData_
        {
            get
            {
                if (this.marketData_ != null)
                {
                    return this.marketData_; 
                }
                else if (this.marketDataIDRef_ != null)
                {
                    return this.marketData_; 
                }
                else
                {
                    throw new Exception( "marketData_Node no exist!");
                }
            }
            set
            {
                if (this.marketData_ != value)
                {
                    this.marketData_ = value;
                }
            }
        }
        #endregion
        
        public string marketDataIDRef_ { get; set; }
        
    
        
    
    }
    
}

