using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public interface IXmlData
    {

        //Control View_ { get; set; }
        
        void buildXml(XmlWriter xmlWriter);

        void setFromXml(XmlNode InstNode);

        void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);

    }
}
