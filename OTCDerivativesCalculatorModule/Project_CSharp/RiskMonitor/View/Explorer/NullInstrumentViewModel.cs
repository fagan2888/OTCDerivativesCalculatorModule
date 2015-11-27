using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class NullInstrumentViewModel : InstrumentViewModel
    {
        public NullInstrumentViewModel() 
        {
            
        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public override void setFromXml(System.Xml.XmlNode InstNode)
        {
            throw new NotImplementedException();
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            throw new NotImplementedException();
        }

        public override void calculate()
        {
            throw new NotImplementedException();
        }

        public override UnderlyingViewModel getUnderlying()
        {
            throw new NotImplementedException();
        }
    }
}
