using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class UnderlyingIndex : ISerialized
    {
        public UnderlyingIndex(XmlNode xmlNode)
        {
            XmlNode stockIndexNode = xmlNode.SelectSingleNode("stockIndex");
            
            if (stockIndexNode != null)
            {
                if (stockIndexNode.Attributes["href"] != null || stockIndexNode.Attributes["id"] != null) 
                {
                    if (stockIndexNode.Attributes["id"] != null) 
                    {
                        stockIndexIDRef_ = stockIndexNode.Attributes["id"].Value;
                        StockIndex ob = new StockIndex(stockIndexNode);
                        IDManager.SetID(stockIndexIDRef_, ob);
                    }
                    else if (stockIndexNode.Attributes["href"] != null)
                    {
                        stockIndexIDRef_ = stockIndexNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stockIndex_ = new StockIndex(stockIndexNode);
                    }
                }
                else
                {
                    stockIndex_ = new StockIndex(stockIndexNode);
                }
            }
            
        
            XmlNode interestrateIndexNode = xmlNode.SelectSingleNode("interestrateIndex");
            
            if (interestrateIndexNode != null)
            {
                if (interestrateIndexNode.Attributes["href"] != null || interestrateIndexNode.Attributes["id"] != null) 
                {
                    if (interestrateIndexNode.Attributes["id"] != null) 
                    {
                        interestrateIndexIDRef_ = interestrateIndexNode.Attributes["id"].Value;
                        InterestrateIndex ob = new InterestrateIndex(interestrateIndexNode);
                        IDManager.SetID(interestrateIndexIDRef_, ob);
                    }
                    else if (interestrateIndexNode.Attributes["href"] != null)
                    {
                        interestrateIndexIDRef_ = interestrateIndexNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interestrateIndex_ = new InterestrateIndex(interestrateIndexNode);
                    }
                }
                else
                {
                    interestrateIndex_ = new InterestrateIndex(interestrateIndexNode);
                }
            }
            
        
            XmlNode commodityIndexNode = xmlNode.SelectSingleNode("commodityIndex");
            
            if (commodityIndexNode != null)
            {
                if (commodityIndexNode.Attributes["href"] != null || commodityIndexNode.Attributes["id"] != null) 
                {
                    if (commodityIndexNode.Attributes["id"] != null) 
                    {
                        commodityIndexIDRef_ = commodityIndexNode.Attributes["id"].Value;
                        CommodityIndex ob = new CommodityIndex(commodityIndexNode);
                        IDManager.SetID(commodityIndexIDRef_, ob);
                    }
                    else if (commodityIndexNode.Attributes["href"] != null)
                    {
                        commodityIndexIDRef_ = commodityIndexNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commodityIndex_ = new CommodityIndex(commodityIndexNode);
                    }
                }
                else
                {
                    commodityIndex_ = new CommodityIndex(commodityIndexNode);
                }
            }
            
        
        }
        
    
        #region StockIndex_
        private StockIndex stockIndex_;
        public StockIndex StockIndex_
        {
            get
            {
                if (this.stockIndex_ != null)
                {
                    return this.stockIndex_; 
                }
                else if (this.stockIndexIDRef_ != null)
                {
                    stockIndex_ = IDManager.getID(stockIndexIDRef_) as StockIndex;
                    return this.stockIndex_; 
                }
                else
                {
                      return this.stockIndex_; 
                }
            }
            set
            {
                if (this.stockIndex_ != value)
                {
                    this.stockIndex_ = value;
                }
            }
        }
        #endregion
        
        public string stockIndexIDRef_ { get; set; }
        #region InterestrateIndex_
        private InterestrateIndex interestrateIndex_;
        public InterestrateIndex InterestrateIndex_
        {
            get
            {
                if (this.interestrateIndex_ != null)
                {
                    return this.interestrateIndex_; 
                }
                else if (this.interestrateIndexIDRef_ != null)
                {
                    interestrateIndex_ = IDManager.getID(interestrateIndexIDRef_) as InterestrateIndex;
                    return this.interestrateIndex_; 
                }
                else
                {
                      return this.interestrateIndex_; 
                }
            }
            set
            {
                if (this.interestrateIndex_ != value)
                {
                    this.interestrateIndex_ = value;
                }
            }
        }
        #endregion
        
        public string interestrateIndexIDRef_ { get; set; }
        #region CommodityIndex_
        private CommodityIndex commodityIndex_;
        public CommodityIndex CommodityIndex_
        {
            get
            {
                if (this.commodityIndex_ != null)
                {
                    return this.commodityIndex_; 
                }
                else if (this.commodityIndexIDRef_ != null)
                {
                    commodityIndex_ = IDManager.getID(commodityIndexIDRef_) as CommodityIndex;
                    return this.commodityIndex_; 
                }
                else
                {
                      return this.commodityIndex_; 
                }
            }
            set
            {
                if (this.commodityIndex_ != value)
                {
                    this.commodityIndex_ = value;
                }
            }
        }
        #endregion
        
        public string commodityIndexIDRef_ { get; set; }
        public string choiceStr_indexType;
        
    
        
    
    }
    
}

