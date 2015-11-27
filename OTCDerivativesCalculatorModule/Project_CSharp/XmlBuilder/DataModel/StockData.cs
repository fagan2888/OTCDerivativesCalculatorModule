using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XmlBuilder.DataModel
{
    public class StockData : IData
    {
        public StockData(string name,
                         string code) 
        {
            this.Type_ = "Stock";
            this.Name_ = name;
            this.Code_ = code;
        }
    }
}
