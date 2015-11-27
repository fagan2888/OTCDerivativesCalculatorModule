using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RiskMonitor;

namespace ExcelInterface
{
    public class InterestRateIndex : IndexXL
    {
        private string type_;
        private string krCode_;
        private string name_;
        private string tenor_;

        public InterestRateIndex(string type, string krCode, string name, string tenor)
        {
            // TODO: Complete member initialization
            this.type_ = type;
            this.krCode_ = krCode;
            this.name_ = name;
            this.tenor_ = tenor;
        }

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            IRIndexUnderViewModel iruvm = new IRIndexUnderViewModel();

            iruvm.Type_ = this.type_;
            iruvm.KRCode_ = this.krCode_;
            iruvm.Name_ = this.name_;
            iruvm.BasePrice_ = 1.0;
            iruvm.Period_ = this.tenor_;

            iruvm.buildXml(xmlWriter);

        }

    }
}
