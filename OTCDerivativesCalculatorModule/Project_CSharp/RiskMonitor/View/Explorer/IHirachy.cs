using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    interface IHirachy
    {
        void loadHirachyInst(FpmlSerializedCSharp.ISerialized serial_hirachy);
    }
}
