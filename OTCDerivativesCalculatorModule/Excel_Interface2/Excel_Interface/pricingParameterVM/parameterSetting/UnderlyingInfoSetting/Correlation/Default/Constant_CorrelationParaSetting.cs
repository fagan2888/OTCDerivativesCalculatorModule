using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Constant_CorrelationParaSetting : CorrelationParaSetting
    {
        public Constant_CorrelationParaSetting(ParameterSettingManager parameterSettingManager)
        : base(parameterSettingManager)
        {
        }

        public override string value(DateTime refDate, string code, string other_code)
        {
            return "0.5";
        }

    }
}
