using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XmlBuilder.DataModel;

namespace XmlBuilder.DataLoader
{
    public class InterestRateDataLoader
    {

        public InterestRateDataLoader() 
        {
        
        }

        public List<InterestRateData> loadData() 
        {
            List<InterestRateData> dataList = new List<InterestRateData>();

            dataList.Add(new InterestRateData("CD_AAA", "3M"));
            dataList.Add(new InterestRateData("CD_AAA+", "6M"));
            dataList.Add(new InterestRateData("CD_AAA", "9M"));
            dataList.Add(new InterestRateData("CD_AAA", "12M"));

            return dataList;
        }
    }
}
