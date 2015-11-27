using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class UnderlyingIndex
    {
        public UnderlyingIndex(XmlNode xmlNode)
        {
            XmlNodeList stockIndexNodeList = xmlNode.SelectNodes("stockIndex");
            if (stockIndexNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in stockIndexNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stockIndexIDRef = item.Attributes["id"].Name;
                        StockIndex ob = StockIndex();
                        IDManager.SetID(stockIndexIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stockIndexIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        stockIndex = new StockIndex(item);
                    }
                }
            }
            
        
            XmlNodeList interestrateIndexNodeList = xmlNode.SelectNodes("interestrateIndex");
            if (interestrateIndexNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in interestrateIndexNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        interestrateIndexIDRef = item.Attributes["id"].Name;
                        InterestrateIndex ob = InterestrateIndex();
                        IDManager.SetID(interestrateIndexIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        interestrateIndexIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        interestrateIndex = new InterestrateIndex(item);
                    }
                }
            }
            
        
            XmlNodeList commodityIndexNodeList = xmlNode.SelectNodes("commodityIndex");
            if (commodityIndexNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commodityIndexNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commodityIndexIDRef = item.Attributes["id"].Name;
                        CommodityIndex ob = CommodityIndex();
                        IDManager.SetID(commodityIndexIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commodityIndexIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commodityIndex = new CommodityIndex(item);
                    }
                }
            }
            
        
        }
        
    
        #region StockIndex
        private StockIndex stockIndex;
        public StockIndex StockIndex
        {
            get
            {
                if (this.stockIndex != null)
                {
                    return this.stockIndex; 
                }
                else if (this.stockIndexIDRef != null)
                {
                    stockIndex = IDManager.getID(stockIndexIDRef) as StockIndex;
                    return this.stockIndex; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.stockIndex != value)
                {
                    this.stockIndex = value;
                }
            }
        }
        #endregion
        
        public string StockIndexIDRef { get; set; }
        #region InterestrateIndex
        private InterestrateIndex interestrateIndex;
        public InterestrateIndex InterestrateIndex
        {
            get
            {
                if (this.interestrateIndex != null)
                {
                    return this.interestrateIndex; 
                }
                else if (this.interestrateIndexIDRef != null)
                {
                    interestrateIndex = IDManager.getID(interestrateIndexIDRef) as InterestrateIndex;
                    return this.interestrateIndex; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.interestrateIndex != value)
                {
                    this.interestrateIndex = value;
                }
            }
        }
        #endregion
        
        public string InterestrateIndexIDRef { get; set; }
        #region CommodityIndex
        private CommodityIndex commodityIndex;
        public CommodityIndex CommodityIndex
        {
            get
            {
                if (this.commodityIndex != null)
                {
                    return this.commodityIndex; 
                }
                else if (this.commodityIndexIDRef != null)
                {
                    commodityIndex = IDManager.getID(commodityIndexIDRef) as CommodityIndex;
                    return this.commodityIndex; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commodityIndex != value)
                {
                    this.commodityIndex = value;
                }
            }
        }
        #endregion
        
        public string CommodityIndexIDRef { get; set; }
        public string choiceStr_indexType;
        
    
        
    
    }
    
}

