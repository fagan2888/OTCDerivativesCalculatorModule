using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XmlBuilder.DataModel
{
    public class InterestRateData : IData
    {

        public InterestRateData(string name,
                                string code) 
        {
            this.Type_ = "InterestRate";
            this.Name_ = name;
            this.Code_ = code;
        }

    }
}
