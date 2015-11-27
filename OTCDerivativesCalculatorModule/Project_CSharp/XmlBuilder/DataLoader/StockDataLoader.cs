using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XmlBuilder.DataModel;

using System.ComponentModel;
using System.Collections.ObjectModel;

namespace XmlBuilder.DataLoader
{
    public class StockDataLoader : IData
    {

        

        public StockDataLoader() 
        {
        
        }

        public ObservableCollection<StockData> loadData() 
        {
            ObservableCollection<StockData> dataList = new ObservableCollection<StockData>();

            dataList.Add(new StockData("Samsung","KR05105120"));
            dataList.Add(new StockData("LG", "KR05102120"));
            dataList.Add(new StockData("OCI", "KR01079843"));
            dataList.Add(new StockData("STX", "KR72184914"));

            return dataList;
        }
    }
}
