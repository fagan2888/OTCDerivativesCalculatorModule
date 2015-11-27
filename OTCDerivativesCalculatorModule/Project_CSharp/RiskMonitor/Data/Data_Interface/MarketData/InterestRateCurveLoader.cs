using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace RiskMonitor
{
    public class InterestRateCurveLoader
    {
        public string tsXml(string curveName) 
        {
            StringBuilder sb = new StringBuilder();
            XmlWriter xmlWriter = XmlWriter.Create(sb);

            return xmlWriter.ToString();
        }

    }
}
