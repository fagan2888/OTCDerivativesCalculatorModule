using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ExploreHirachyGroupVMWrapper : ExploreHirachyVMWrapper
    {
        public ExploreHirachyGroupVMWrapper(InstrumentBaseViewModel instBaseVM)
        : base(instBaseVM)
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
            this.HirachyInstVMList_ = new ObservableCollection<HirachyInstrumentVM>();

            this.productType_ = "Group";
        }
    }
}
