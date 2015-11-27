using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RiskMonitor;

namespace ExcelInterface
{
    public class StockIndexXL : IndexXL
    {
        private string type_;
        private string krCode_;
        private string name_;
        private string basePrice_;

        public StockIndexXL(string type, string krCode, string name, string basePrice)
        {
            // TODO: Complete member initialization
            this.type_ = type;
            this.krCode_ = krCode;
            this.name_ = name;
            this.basePrice_ = basePrice;
        }

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            StockIndexUnderViewModel siuvm = new StockIndexUnderViewModel();

            siuvm.Type_ = this.type_;
            siuvm.KRCode_ = this.krCode_;
            siuvm.Name_ = this.name_;
            siuvm.BasePrice_ = Convert.ToDouble(this.basePrice_);

            siuvm.buildXml(xmlWriter);

        }
    }
}
