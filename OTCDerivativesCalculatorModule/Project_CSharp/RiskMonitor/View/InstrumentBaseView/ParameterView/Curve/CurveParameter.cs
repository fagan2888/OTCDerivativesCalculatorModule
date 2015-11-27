using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace RiskMonitor
{
    public class CurveParameter : IXmlData
    {

        public string Name_ { get; set; }
        public string Currency_ { get; set; }
        public string Type_ { get; set; }

        //public List<RateData> Data_ { get; set; }

        public void buildXml(XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public void setFromXml(XmlNode InstNode)
        {
            throw new NotImplementedException();
        }

        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            throw new NotImplementedException();
        }
    }
}
