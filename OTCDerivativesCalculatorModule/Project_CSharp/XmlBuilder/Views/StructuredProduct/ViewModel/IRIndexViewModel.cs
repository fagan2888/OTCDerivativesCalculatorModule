using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace XmlBuilder.Views.StructuredProduct.ViewModel
{
    class IRIndexViewModel : IXmlBuild
    {
        private FpmlSerializedCSharp.InterestrateIndex interestrateIndex;

        public IRIndexViewModel(FpmlSerializedCSharp.InterestrateIndex interestrateIndex)
        {
            // TODO: Complete member initialization
            this.interestrateIndex = interestrateIndex;
        }

        public void buildXml(XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
    }
}
