using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class CalculationSetting
    {
        public enum CalculateTypeEnum
        {
            Local,
            Parellel
        };

        public CalculateTypeEnum CalculateTypeEnum_;

        public CalculationSetting()
        {
            this.CalculateTypeEnum_ = CalculateTypeEnum.Local;
        }
    }
}
