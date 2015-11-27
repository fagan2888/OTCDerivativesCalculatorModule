using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public abstract class InstrumentWrapperVM : IXmlData
    {
        public InstUriInfo InstUri_ { get; set; }
        public ResultUriInfo ResultUri_ { get; set; }

        public InstrumentBaseViewModel InstBaseVM_ { get; set; }

        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode InstNode);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);

        public Control view()
        {
            this.InstBaseVM_.loadAll();
            return InstBaseVM_.View_;
        }


    }
}
