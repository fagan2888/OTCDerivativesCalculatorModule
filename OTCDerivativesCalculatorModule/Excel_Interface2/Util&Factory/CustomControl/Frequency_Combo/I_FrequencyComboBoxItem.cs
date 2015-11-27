using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public abstract class I_FrequencyComboBoxItem
    {
        public enum FrequencyEnum
        {
            Once,
            Monthly,
            Quarterly,
            EveryFourthMonth,
            SemiAnnual,
            Annual
        }
        
        public FrequencyEnum FrequencyEnum_ { get; set; }
        public string TypeString_ { get; set; }

        public abstract DateTime nextDate(DateTime d);

        public static FrequencyEnum convertToEnum(string typeStr)
        {
            FrequencyEnum typeEnum;

            if (typeStr == "")
            {
                typeEnum = FrequencyEnum.Once;
            }
            else
            {
                typeEnum = FrequencyEnum.Monthly;

                throw new Exception();

            }

            return typeEnum;
        }

    }
}
