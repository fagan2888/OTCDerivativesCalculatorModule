using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XmlBuilder.DataModel
{
    public class CommodityData : IData
    {
        public CommodityData(string name,
                             string code) 
        {
            this.Type_ = "Commodity";
            this.Name_ = name;
            this.Code_ = code;
        }

    }
}
