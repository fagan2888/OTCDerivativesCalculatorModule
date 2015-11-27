using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace XmlBuilder.Views.StructuredProduct.ViewModel
{
    public interface IXmlBuild
    {
        //StringBuilder buildXml();
        void buildXml(XmlWriter xmlWriter);
    }
}
