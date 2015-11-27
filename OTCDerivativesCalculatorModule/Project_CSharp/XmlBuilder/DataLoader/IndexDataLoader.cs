using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XmlBuilder.DataModel;

namespace XmlBuilder.DataLoader
{
    class IndexDataLoader
    {
        public IndexDataLoader() 
        {
        
        }

        public List<IndexData> loadData() 
        {
            List<IndexData> dataList = new List<IndexData>();

            dataList.Add(new IndexData("KOSPI200", "KOSPI200"));
            dataList.Add(new IndexData("S&P500", "KR05102120"));
            dataList.Add(new IndexData("HSCEI", "KR01079843"));

            return dataList;
        }
    }
}
