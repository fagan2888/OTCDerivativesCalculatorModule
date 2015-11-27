using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace XmlBuilder.Views.StructuredProduct.ViewModel
{
    class CommodityIndexViewModel : IXmlBuild
    {
        private FpmlSerializedCSharp.CommodityIndex commodityIndex;

        public CommodityIndexViewModel(FpmlSerializedCSharp.CommodityIndex commodityIndex)
        {
            // TODO: Complete member initialization
            this.commodityIndex = commodityIndex;
        }

        public void buildXml(XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
    }
}
