using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace XmlBuilder.Views.StructuredProduct.ViewModel
{
    class StockIndexViewModel : IXmlBuild
    {
        private FpmlSerializedCSharp.StockIndex stockIndex;

        public StockIndexViewModel(FpmlSerializedCSharp.StockIndex stockIndex)
        {
            // TODO: Complete member initialization
            this.stockIndex = stockIndex;
        }

        public void buildXml(XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
    }
}
